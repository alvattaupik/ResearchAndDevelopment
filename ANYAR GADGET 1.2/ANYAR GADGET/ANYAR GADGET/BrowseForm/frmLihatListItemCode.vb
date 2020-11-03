Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmLihatListItemCode

    Private Sub txtCariBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariBarang.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            Call Koneksi_SAP()
            Call LoadDataGrid(dgvCaribarang, "SELECT Top 100 ItemCode,ItemName FROM dbo.OITM WHERE ItemType='i' AND (ItemCode Like '%" & txtCariBarang.Text & "%' Or ItemName Like '%" & txtCariBarang.Text & "%' )", KoneksiSAP)

        End If


        Exit Sub

ErrorHandler:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub
    End Sub



End Class