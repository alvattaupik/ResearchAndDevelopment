Imports System.Data.SqlClient
Public Class ItemList
    Private Sub LoadDatagridView()
        Call conn_get()
        Call koneksi()
        If koneksi() = True Then
            conn = New SqlConnection(server)
            Dim cmd As New SqlCommand("SELECT ItemCode AS [Kode Barang],ItemName AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod Where ItemCode LIKE  '%" & Trim(txtKodeBarang.Text) & "%' ", conn)

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
        Else
            frmSettingKoneksi.Show()
        End If
    End Sub

    Private Sub LoadDatagridViewByname()
        Call conn_get()
        Call koneksi()
        If koneksi() = True Then
            conn = New SqlConnection(server)
            Dim cmd As New SqlCommand("SELECT ItemCode AS [Kode Barang],ItemName AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod Where ItemName LIKE  '%" & Trim(txtNamaBarang.Text) & "%' ", conn)

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
        Else
            frmSettingKoneksi.Show()
        End If
    End Sub




    Private Sub ItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtKodeBarang.Text = MainWindows.txtKodeBarang.Text
        Call LoadDatagridView()

    End Sub

    Private Sub dgItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellContentClick

    End Sub

    Private Sub dgItemList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellContentDoubleClick
        MainWindows.txtKodeBarang.Text = dgItemList.Rows(e.RowIndex).Cells(0).Value
        MainWindows.txtNamaBarang.Text = dgItemList.Rows(e.RowIndex).Cells(1).Value
        MainWindows.txtItemGroup.Text = dgItemList.Rows(e.RowIndex).Cells(2).Value
        Call MainWindows.LoadDatagridViewInventory()

        Me.Close()
    End Sub

    Private Sub txtKodeBarang_GotFocus(sender As Object, e As EventArgs) Handles txtKodeBarang.GotFocus
        bolStatus1 = 1
    End Sub

    Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
        If bolStatus1 = True Then
            Call LoadDatagridView()
        End If
    End Sub

    Private Sub dgItemList_SelectionChanged(sender As Object, e As EventArgs) Handles dgItemList.SelectionChanged
    End Sub

    Private Sub txtNamaBarang_GotFocus(sender As Object, e As EventArgs) Handles txtNamaBarang.GotFocus
        bolStatus1 = 1
    End Sub

    Private Sub txtNamaBarang_TextChanged(sender As Object, e As EventArgs) Handles txtNamaBarang.TextChanged
        If bolStatus1 = True Then
            Call LoadDatagridViewByName()
        End If
    End Sub
End Class
