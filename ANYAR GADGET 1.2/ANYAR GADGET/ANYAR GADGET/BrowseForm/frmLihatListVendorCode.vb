Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmLihatListVendor

    Private Sub txtCariBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariBarang.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            Call Koneksi_SAP()
            Call LoadDataGrid(dgvListVendor, "SELECT Top 100 CardCode,CardName FROM dbo.OCRD WHERE CardCode LIKE 'V%' AND (CardCode Like '%" & txtCariBarang.Text & "%' Or CardName Like '%" & txtCariBarang.Text & "%' )", KoneksiSAP)

        End If


        Exit Sub

ErrorHandler:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub
    End Sub



End Class