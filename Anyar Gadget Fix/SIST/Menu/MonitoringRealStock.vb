Imports System.Data.SqlClient
Public Class MonitoringRealStock



    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbItem.Visible = False
        End If

        If Tombol = 13 Then



            gbItem.Visible = True
            Call koneksiMenu()
            conn = New SqlConnection(server)


            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemCode LIKE  '%" & (Trim(txtKodeBarang.Text)) & "%' ", conn)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgItemList.AutoResizeColumns()
            dgItemList.RowHeadersVisible = False
        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        Call MsubPesanError()
        strFilter = ""
        Exit Sub
    End Sub

    Private Sub MonitoringRealStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"
        MstrNamaModul = "AG-Monitoring RealStock"

    End Sub

    Private Sub dgItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellContentClick
        On Error GoTo ErrorHandler

        txtKodeBarang.Text = dgItemList.Item(0, dgItemList.CurrentRow.Index).Value
        txtNamaBarang.Text = dgItemList.Item(1, dgItemList.CurrentRow.Index).Value
        txtGroup.Text = dgItemList.Item(2, dgItemList.CurrentRow.Index).Value
        gbItem.Visible = False
        LoadDatagridViewInventory()
        Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub

    Private Sub txtNamaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaBarang.KeyPress
        On Error GoTo Errorhandler
        Dim Tombol As Integer = Asc(e.KeyChar)
        Dim strFilter As String

        If Tombol = 27 Then
            gbItem.Visible = False
        End If

        If Tombol = 13 Then



            gbItem.Visible = True
            Call koneksiMenu()
            conn = New SqlConnection(server)


            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemName LIKE  '%" & (Trim(txtNamaBarang.Text)) & "%' ", conn)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgItemList.AutoResizeColumns()
            dgItemList.RowHeadersVisible = False

        Else
            Exit Sub
        End If

        Exit Sub


Errorhandler:
        Call MsubPesanError()
        strFilter = ""
        Exit Sub
    End Sub

    Public Sub LoadDatagridViewInventory()

        Call koneksiMenu()
        If koneksiMenu() = True Then
            conn = New SqlConnection(server)

            Dim cmd As New SqlCommand("SELECT [Nama Gudang],[In Stock],Commited,[On Order] FROM V_DaftarMonitoringStok Where ItemCode='" & Trim(txtKodeBarang.Text) & "'", conn)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)
            dgInventoryData.DataSource = table
            dgInventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgInventoryData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgInventoryData.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.AutoResizeColumns()
            dgInventoryData.RowHeadersVisible = False

        End If
    End Sub



    Private Sub cmdTutup_Click(sender As Object, e As EventArgs) Handles cmdTutup.Click
        gbItem.Visible = False
    End Sub

    Private Sub AvailableToPromiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableToPromiseToolStripMenuItem.Click

        Dim frm As New FormAvailableToPromise

        frm.MdiParent = MenuUtama

        frm.txtItemCode.Text = Me.txtKodeBarang.Text
        frm.txtItemName.Text = Me.txtNamaBarang.Text
        frm.Location = New Point(294, 39)

        frm.TopMost = True
        frm.Show()

    End Sub


End Class