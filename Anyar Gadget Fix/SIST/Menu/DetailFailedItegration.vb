Imports System.Data.SqlClient

Public Class DetailFailedItegration




    Sub LoadDaftarItemGagalIntegrasi()
        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("SELECT ProductKey AS KodeBarang,Description,QTY,Total FROM dbo.V_ListItemErrorIntegrasi WHERE NoStruk='" & MstrNoStruk & "'", KoneksiIvend)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgListItemFail.DataSource = table
        dgListItemFail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgListItemFail.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgListItemFail.AutoResizeColumns()
        dgListItemFail.RowHeadersVisible = False
    End Sub


    Private Sub DetailFailedItegration_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarItemGagalIntegrasi()
        hitung()

    End Sub



    Sub hitung()
        Dim LongTotal As Long
        Dim intJumlahItem As Integer
        Dim i As Integer

        For i = 0 To dgListItemFail.RowCount - 1
            dgListItemFail.Rows(i).Cells(3).Value = dgListItemFail.Rows(i).Cells(3).Value 'total jual
            LongTotal = LongTotal + (dgListItemFail.Rows(i).Cells(3).Value)

            dgListItemFail.Rows(i).Cells(2).Value = dgListItemFail.Rows(i).Cells(2).Value 'total jual
            intJumlahItem = intJumlahItem + (dgListItemFail.Rows(i).Cells(2).Value)

        Next


        txtTotal.Text = Format(LongTotal, "N0")
        lblJumlahItem.Text = "Jumlah Qty : " & Format(intJumlahItem, "N0")

    End Sub

End Class