Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormRiwayatTransaksi

    Private Sub FormRiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRiwayatTransaksiCustomerByNoMember()


        Dim LongMargin As Long = 0
        Dim LongTotalJual As Long = 0
        Dim LongTotalBeli As Long = 0
        Dim LongTotalMargin As Long = 0


        For i = 0 To dgHistoryTransaksiCustomer.RowCount - 1



            dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value = dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value 'Total Jual
            LongTotalJual = LongTotalJual + dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value




        Next



        lblTotalTransaksi.Text = "Total Transaksi: " & Format(LongTotalJual, "N0")
    End Sub


    Sub LoadRiwayatTransaksiCustomerByNoMember()
        Call KoneksiDatabaseSAP()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE NoMember ='" & Trim(MstrNoMember) & "'", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgHistoryTransaksiCustomer.DataSource = table
        dgHistoryTransaksiCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHistoryTransaksiCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHistoryTransaksiCustomer.AutoResizeColumns()
    End Sub
End Class