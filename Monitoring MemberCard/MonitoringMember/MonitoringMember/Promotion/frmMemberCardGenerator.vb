Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMemberCardGenerator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbRincianNomor.Visible = False
    End Sub

    Private Sub picExportToExcel_Click(sender As Object, e As EventArgs) Handles picExportToExcel.Click
        ExportToExcel(lblJumlahNomor, dgvRincianNomor)
    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode Like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If txtFrom.TextLength > 15 Or txtTo.TextLength > 15 Then
            DisplayPesanError("No Member TelahLebih dari 15 Digit yang diperbolehkan!, Silahkan periksa kembali", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If txtFrom.Text = "" Or txtTo.Text = "" Then
            DisplayPesanError("No Member From dan To Harus Di isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If cmbCabang.Text = "" Then
            DisplayPesanError("Cabang Harus Di isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If txtCatatan.Text = "" Then
            DisplayPesanError("Catatan Harus Di isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If MsgBox("Apakah yakin Anda Akan Membuat No Member dari " & txtFrom.Text & " Sampai No " & txtTo.Text, vbYesNo, "Konfirmasi") = vbYes Then
            AddGenerateNoMember()
            ListNomorYangSUdahDibuat()
            txtCatatan.Text = ""
            txtFrom.Text = ""
            txtTo.Text = ""
            cmbCabang.Text = ""

        Else
            Exit Sub
        End If
    End Sub



    Sub AddGenerateNoMember()

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("dbo.Add_OMember ", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@catatan", Trim(txtCatatan.Text))
            command.Parameters.AddWithValue("@dibuatoleh", MstrNamaPegawai)
            command.Parameters.AddWithValue("@Cabang", cmbCabang.SelectedValue)
            command.Parameters.AddWithValue("@startNumber", Trim(txtFrom.Text))
            command.Parameters.AddWithValue("@finishNumber", Trim(txtTo.Text))
            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvListGenerate.DataSource = table
            dgvListGenerate.DataSource = table

            lblJumlahDataNomor.Text = "Jumlah No: " & dgvListGenerate.RowCount

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Sub ListNomorYangSUdahDibuat()
        Dim strQuery As String = "SELECT NumberFrom,NumberTo,NamaDivisi AS Cabang,Jumlah,GeneratedBy,CreatedDate,Catatan FROM dbo.OMember" & _
                                " LEFT OUTER JOIN dbo.V_Divisi ON KodeCabang COLLATE DATABASE_DEFAULT=KodeDivisi COLLATE DATABASE_DEFAULT"
        Call Koneksi_SAP()
        LoadDataGrid(dgvListGenerate, strQuery, KoneksiDBEmail)
        lblJumlahDataNomor.Text = "Jumlah Pembuatan : " & dgvListGenerate.RowCount
    End Sub


    Private Sub frmMemberCardGenerator_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListNomorYangSUdahDibuat()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            gbRincianNomor.Visible = True
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("Fn_GenerateMember1", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@startnum", Trim(dgvListGenerate.Item(0, dgvListGenerate.CurrentRow.Index).Value()))
            command.Parameters.AddWithValue("@endnum", Trim(dgvListGenerate.Item(1, dgvListGenerate.CurrentRow.Index).Value()))
            command.Parameters.AddWithValue("@KodeCabang", "R")
            command.Parameters.AddWithValue("@status", "R")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvRincianNomor.DataSource = table
            dgvRincianNomor.DataSource = table

            lblJumlahNomor.Text = "Jumlah Nomor: " & dgvRincianNomor.RowCount
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub CopyToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToExcelToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvRincianNomor)
    End Sub
End Class