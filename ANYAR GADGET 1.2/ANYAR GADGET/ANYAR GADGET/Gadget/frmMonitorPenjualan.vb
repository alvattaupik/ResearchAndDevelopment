Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmMonitorPenjualan

    Private Sub cmbListCabang_Click(sender As Object, e As EventArgs) Handles cmbListCabang.Click
        Dim strSQLLocation As String = "SELECT KodeDivisi,NamaDivisi FROM V_Divisi Where KodeDivisi In (SELECT KodeLocation COLLATE DATABASE_DEFAULT FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbListCabang, strSQLLocation, "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[Lap_Margin_AG]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpAwal.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpAkhir.Value.ToString("yyyy-MM-dd"))

        If cmbListCabang.SelectedValue = "" Then
            command.Parameters.AddWithValue("@Cabang", "")
        Else
            command.Parameters.AddWithValue("@Cabang", cmbListCabang.SelectedValue)
        End If

        command.Parameters.AddWithValue("@KodeJabatan", MstrLevelUser)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgvListPenjualan.DataSource = table
        dgvListPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListPenjualan.AutoResizeColumns()
    End Sub

    Private Sub picExportToExcel_Click(sender As Object, e As EventArgs) Handles picExportToExcel.Click
        If dgvListPenjualan.RowCount = 0 Then
            DisplayPesanError("No Records To Export", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else

            Try

                Dim ApExcel As Object

                'Set sebagai excel  object
                ApExcel = CreateObject("Excel.application")

                'Menyembunyikan proses excel
                ApExcel.Visible = False

                'Membuat/menambah workbook baru
                ApExcel.Workbooks.Add()


                'Lebar Kolom
                ApExcel.Columns(1).ColumnWidth = 15
                ApExcel.Columns(2).ColumnWidth = 20

                'Tulis nama kolom ke excel
                For i As Integer = 1 To dgvListPenjualan.Columns.Count
                    ApExcel.Cells(1, i).Value = dgvListPenjualan.Columns(i - 1).Name
                Next

                lblExport.Visible = True

                'Tulis data ke excel
                For r = 0 To dgvListPenjualan.RowCount - 1
                    For i As Integer = 1 To dgvListPenjualan.Columns.Count
                        ApExcel.Cells(r + 2, i).Value = dgvListPenjualan.Rows(r).Cells(i - 1).Value

                        lblExport.Text = "Mengexport : " & r & " Dari : " & dgvListPenjualan.RowCount

                    Next
                Next

                'Membuat Font Bold
                ApExcel.Range("A1:M1").Font.Bold = True

                'Memberi warna backgound
                ApExcel.Range("A1:M1").interior.colorindex = 36

                'Agar nilai cell yang panjang menjadi beberapa baris
                ApExcel.Range("A2:B" & dgvListPenjualan.RowCount + 1).WrapText = True

                'Membuat border hitam
                'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
                ApExcel.Visible = True
                ApExcel = Nothing
                lblExport.Visible = False

            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End Try
        
        End If
    End Sub

    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvListPenjualan)
    End Sub
End Class