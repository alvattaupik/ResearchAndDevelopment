Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class PerubahanHargaJual




  
    Private Sub dgListPerubahanHargaJual_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListPerubahanHargaJual.CellContentClick
        If dgListPerubahanHargaJual.RowCount = 0 Then Exit Sub
        DetailPerubahanHargaJual.LblNamaPerubahanharga.Text = dgListPerubahanHargaJual.Rows(e.RowIndex).Cells(0).Value
        DetailPerubahanHargaJual.lblTanggal.Text = "Tanggal : " & dgListPerubahanHargaJual.Rows(e.RowIndex).Cells(1).Value
        DetailPerubahanHargaJual.ShowDialog()
    End Sub


End Class