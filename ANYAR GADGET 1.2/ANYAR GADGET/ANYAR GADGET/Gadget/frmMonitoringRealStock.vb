Imports System.Data.SqlClient
Public Class frmMonitoringRealStock



    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbItem.Visible = False
        End If

        If Tombol = 13 Then
            Call Koneksi_SAP()

            Dim strQuery As String = "SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemCode LIKE  '%" & (Trim(txtKodeBarang.Text)) & "%' "

            gbItem.Visible = True
            Call LoadDataGrid(dgItemList, strQuery, KoneksiSAP)

        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        MsgBox(Err.Description)
        strFilter = ""
        Exit Sub
    End Sub

    Private Sub MonitoringRealStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim l As Single = (frmMainMenu.ClientSize.Width - Me.Width) / 2
        Dim t As Single = ((frmMainMenu.ClientSize.Height - Me.Height) / 2) - 30
        Me.SetBounds(l, t, Me.Width, Me.Height)
        Me.MdiParent = frmMainMenu
        'MstrNamaModul = "AG-Monitoring RealStock"

    End Sub



    Private Sub txtNamaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbItem.Visible = False
        End If

        If Tombol = 13 Then
            Call Koneksi_SAP()

            Dim strQuery As String = "SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemName LIKE  '%" & (Trim(txtNamaBarang.Text)) & "%' "

            gbItem.Visible = True
            LoadDataGrid(dgItemList, strQuery, KoneksiSAP)


        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        MsgBox(Err.Description)
        Exit Sub

        Exit Sub
    End Sub

    Public Sub LoadDatagridViewInventory()
        Dim strQuery As String = "SELECT [Nama Gudang],[In Stock],Commited,[On Order] FROM V_DaftarMonitoringStok Where ItemCode='" & Trim(txtKodeBarang.Text) & "'"
        Call Koneksi_SAP()
        LoadDataGrid(dgInventoryData, strQuery, KoneksiSAP)
    End Sub



    Private Sub cmdTutup_Click(sender As Object, e As EventArgs) Handles cmdTutup.Click
        gbItem.Visible = False
    End Sub

    Private Sub AvailableToPromiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableToPromiseToolStripMenuItem.Click
        gbATP.Visible = True
        LoadAvailableToPromise()
    End Sub


    Sub LoadAvailableToPromise()
        dgvATP.DataSource = Nothing
        dgvATP.Rows.Clear()
        dgvATP.Columns.Clear()

        Call Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspATP", KoneksiSAP)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@KodeBarang", txtKodeBarang.Text)

        Dim table As New DataTable
        adapter.Fill(table)


        dgvATP.Columns.Add("Document", "Document")
        dgvATP.Columns.Add("CardName", "CardName")
        dgvATP.Columns.Add("OrderDate", "OrderDate")
        dgvATP.Columns.Add("DeliveryDate", "DeliveryDate")
        dgvATP.Columns.Add("Ordered", "Ordered")
        dgvATP.Columns.Add("Commited", "Commited")
        dgvATP.Columns.Add("Total", "Available")
        dgvATP.Columns.Add("WhsName", "Warehouse")

        dgvATP.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvATP.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable



        dgvATP.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dgvATP.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dgvATP.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        With table
            For i = 0 To table.Rows.Count - 1
                dgvATP.Rows.Add(.Rows(i).Item(1).ToString(), .Rows(i).Item(3).ToString(), .Rows(i).Item(4).ToString(), .Rows(i).Item(5).ToString(), .Rows(i).Item(6).ToString(), .Rows(i).Item(7).ToString(), .Rows(i).Item(9).ToString(), .Rows(i).Item(10).ToString())
            Next

            dgvATP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgvATP.AutoResizeColumns()


        End With

    End Sub

    Private Sub dgItemList_Click(sender As Object, e As EventArgs) Handles dgItemList.Click
        On Error GoTo ErrorHandler

        txtKodeBarang.Text = dgItemList.Item(0, dgItemList.CurrentRow.Index).Value
        txtNamaBarang.Text = dgItemList.Item(1, dgItemList.CurrentRow.Index).Value
        txtGroup.Text = dgItemList.Item(2, dgItemList.CurrentRow.Index).Value
        gbItem.Visible = False
        LoadDatagridViewInventory()
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        gbATP.Visible = False
    End Sub
End Class