Imports System.Data.SqlClient
Public Class FormItemsPostingPeriode



    Sub LoadDaftarPostingPeriode()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("Select * From V_Daftarpostingperiode WHere Periode Like'%" & Trim(txtCariItemMasterData.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarItem.DataSource = table
        dgDaftarItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarItem.AutoResizeColumns()

    End Sub

    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarPostingPeriode()

    End Sub

   



    Private Sub dgDaftarItem_Click(sender As Object, e As EventArgs) Handles dgDaftarItem.Click

        Dim JumlahDuplikat As Integer
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean


        JumlahDuplikat = 0
        For Each drr As DataGridViewRow In dgDaftarItem.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.RowCount - 1

                    If FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.Rows(barisatas).Cells(0).Value = dgDaftarItem.Rows(intBarisNow).Cells(0).Value Then
                        BolDuplikat = True
                        JumlahDuplikat = JumlahDuplikat + 1
                    Else

                        BolDuplikat = False

                    End If
                Next

            Next
            If JumlahDuplikat > 0 Then
                Exit Sub
            Else
                FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.Rows.Add(row2)
                FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.AutoResizeColumns()
                FormBuatRequestOpenDanClosingPeriode.lblJumlahPeriode.Text = "Jumlah Periode : " & FormBuatRequestOpenDanClosingPeriode.dgDaftarPeriode.RowCount
                Me.Close()
            End If

        Next

    End Sub


    Private Sub txtCariItemMasterData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariItemMasterData.KeyPress
        LoadDaftarPostingPeriode()
    End Sub
End Class