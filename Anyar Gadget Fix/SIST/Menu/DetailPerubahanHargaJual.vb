Imports System.Data.SqlClient

Public Class DetailPerubahanHargaJual









    Private Sub DetailPerubahanHargaJual_Load(sender As Object, e As EventArgs) Handles Me.Load



        KoneksiDatabase2()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspPerubahanHarga", Koneksi2)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PriceList", MstrHargaJual)
        command.Parameters.AddWithValue("@NotifSelect", "")


        Dim table As New DataTable
        adapter.Fill(table)

        dgPerubahanHarga.DataSource = table
        dgPerubahanHarga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgPerubahanHarga.AutoResizeColumns()
        dgPerubahanHarga.RowHeadersVisible = False




    End Sub
End Class