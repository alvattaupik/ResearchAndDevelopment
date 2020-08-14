Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class CekStok

 
    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbdaftarItem.Visible = False
        End If

        If Tombol = 13 Then
            gbdaftarItem.Visible = True
            Call KoneksiDatabaseSQLSERVER()

            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemCode LIKE  '%" & (Trim(txtKodeBarang.Text)) & "%' ", KoneksiSQLSRV)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgListItem.DataSource = table
            dgListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgListItem.AutoResizeColumns()
            dgListItem.RowHeadersVisible = False
        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        MsgBox(Err.Description)
        strFilter = ""
        Exit Sub
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        gbdaftarItem.Visible = False
    End Sub

    Private Sub txtNamaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbdaftarItem.Visible = False
        End If

        If Tombol = 13 Then
            gbdaftarItem.Visible = True
            Call KoneksiDatabaseSQLSERVER()

            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemName LIKE  '%" & (Trim(txtNamaBarang.Text)) & "%' ", KoneksiSQLSRV)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgListItem.DataSource = table
            dgListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgListItem.AutoResizeColumns()
            dgListItem.RowHeadersVisible = False
        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        MsgBox(Err.Description)
        strFilter = ""
        Exit Sub
    End Sub

    Private Sub dgListItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListItem.CellContentClick
        On Error GoTo ErrorHandler

        txtKodeBarang.Text = dgListItem.Item(0, dgListItem.CurrentRow.Index).Value
        txtNamaBarang.Text = dgListItem.Item(1, dgListItem.CurrentRow.Index).Value
        gbdaftarItem.Visible = False
        LoadDatagridViewInventory()
        HitungStock()
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub




    Sub HitungStock()
        Try
            If dgDaftarStok.RowCount > 1 Then
                Dim iTotal As Integer = 0

                For index As Integer = 0 To dgDaftarStok.RowCount - 1
                    iTotal += Convert.ToInt32(dgDaftarStok.Rows(index).Cells(4).Value)

                Next

                txtStockAvailable.Text = iTotal

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub




    Public Sub LoadDatagridViewInventory()

        Call KoneksiDatabaseSQLSERVER()

        Dim cmd As New SqlCommand("SELECT [Nama Gudang],[In Stock],Commited,[On Order],[In Stock]-Commited+[On Order] AS Available FROM V_DaftarMonitoringStok Where ItemCode='" & Trim(txtKodeBarang.Text) & "'", KoneksiSQLSRV)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)
        dgDaftarStok.DataSource = table

        dgDaftarStok.Columns(0).Width = 300
        dgDaftarStok.Columns(1).Width = 100
        dgDaftarStok.Columns(2).Width = 150
        dgDaftarStok.Columns(3).Width = 100
        dgDaftarStok.Columns(4).Width = 100

        dgDaftarStok.Columns(1).DefaultCellStyle.Format = "N0"
        dgDaftarStok.Columns(2).DefaultCellStyle.Format = "N0"
        dgDaftarStok.Columns(3).DefaultCellStyle.Format = "N0"
        dgDaftarStok.Columns(4).DefaultCellStyle.Format = "N0"

        dgDaftarStok.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dgDaftarStok.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dgDaftarStok.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
        dgDaftarStok.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter

        dgDaftarStok.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgDaftarStok.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgDaftarStok.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgDaftarStok.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight


        'dgInventoryData.AutoResizeColumns()
        dgDaftarStok.RowHeadersVisible = False

    End Sub




   
End Class