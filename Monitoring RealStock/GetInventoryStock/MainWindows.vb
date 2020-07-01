Imports System.Data.SqlClient
Public Class MainWindows


    Public Sub LoadDatagridViewInventory()
        CekWorker()
        Call conn_get()
        Call koneksi()
        If koneksi() = True Then
            conn = New SqlConnection(server)
            'Dim cmd As New SqlCommand("SELECT OITW.WhsCode AS [Kode Gudang]," _
            '                          & " OWHS.WhsName AS [Nama Gudang],Cast(OnHand AS INT) AS [In Stock]," _
            '                          & " Cast(IsCommited AS INT) AS [Commited],CAST(OnOrder AS INt) AS [On Order]" _
            '                          & " FROM dbo.OITW LEFT JOIN dbo.OWHS ON OITW.WhsCode=dbo.OWHS.WhsCode " _
            '                          & " WHERE dbo.OWHS.WhsName LIKE '%Gudang Toko%' AND OITW.ItemCode Like'%" & Trim(txtKodeBarang.Text) & "%'", conn)


            Dim cmd As New SqlCommand("SELECT [Kode Gudang],[Nama Gudang],[In Stock],Commited,[On Order] FROM V_DaftarMonitoringStokAll Where ItemCode Like'%" & Trim(txtKodeBarang.Text) & "%' Order By [Kode Gudang] ", conn)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable

            adapter.Fill(table)


            dgInventoryData.DataSource = table
            dgInventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'dgInventoryData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgInventoryData.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.AutoResizeColumns()


        End If
    End Sub

    Sub aturDGV()
        Try
            dgInventoryData.Columns(0).Width = 200
            dgInventoryData.Columns(1).Width = 500
            dgInventoryData.Columns(2).Width = 200
            dgInventoryData.Columns(3).Width = 200
            dgInventoryData.Columns(4).Width = 200

            dgInventoryData.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            dgInventoryData.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter

        Catch ex As Exception
        End Try
    End Sub



    Public Sub LoadDatagridViewInventoryMaximizeForm()
        CekWorker()
        Call koneksi()
        If koneksi() = True Then
            conn = New SqlConnection(server)

            Dim cmd As New SqlCommand("SELECT [Kode Gudang],[Nama Gudang],[In Stock],Commited,[On Order] FROM V_DaftarMonitoringStokAll Where ItemCode Like'%" & Trim(txtKodeBarang.Text) & "%' Order By [Kode Gudang] ", conn)


            'Dim cmd As New SqlCommand("SELECT OITW.WhsCode AS [Kode Gudang]," _
            '                          & " OWHS.WhsName AS [Nama Gudang],Cast(OnHand AS INT) AS [In Stock]," _
            '                          & " Cast(IsCommited AS INT) AS [Commited],CAST(OnOrder AS INt) AS [On Order]" _
            '                          & " FROM dbo.OITW LEFT JOIN dbo.OWHS ON OITW.WhsCode=dbo.OWHS.WhsCode " _
            '                          & " WHERE dbo.OWHS.WhsName LIKE '%Gudang Toko%' AND OITW.ItemCode Like'%" & Trim(txtKodeBarang.Text) & "%'", conn)


            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            dgInventoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None


            adapter.Fill(table)
            dgInventoryData.DataSource = table
            Call aturDGV()

        End If
    End Sub



    Private Sub MainWindows_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        If Tombol = 27 Then
            gbItem.Visible = False
        End If
    End Sub
    Private Sub MainWindows_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo ErrorHandler

        conn_server = "10.1.0.53"
        conn_user = "sa"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        'setting property backgroundworker

        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True

        Call koneksi()
        If Err.Description = "" Then Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub

    End Sub


    Sub CekWorker()
        ' jika backgroundworker tidak sedang berjalan/busy
        If (BackgroundWorker1.IsBusy = False) Then
            ' menjalankan backgroundworker
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub



    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        'Call NumberOnly(tombol, e)

        If tombol = 27 Then
            gbItem.Visible = False
        End If




        If tombol = 13 Then

            gbItem.Visible = True
            Call koneksi()
            'If koneksi() = True Then
            conn = New SqlConnection(server)
            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemCode LIKE  '%" & fConvert(Trim(txtKodeBarang.Text)) & "%' ", conn)

            'Dim cmd As New SqlCommand("Select * From V_DaftarBarangMonitoring Where [Kode Barang] LIKE  '%" & fConvert(Trim(txtKodeBarang.Text)) & "%' ", conn)



            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgItemList.AutoResizeColumns()
            'End If
        Else
            Exit Sub
        End If








        'End If
    End Sub


    Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
        '        On Error GoTo ErrorHandler

        '        gbItem.Visible = True
        '        If koneksi() = True Then
        '            conn = New SqlConnection(server)
        '            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
        '                                        & " ItemName AS [Nama Barang], " _
        '                                        & " dbo.OITB.ItmsGrpNam AS [Kategori Barang]," _
        '                                        & " CAST(dbo.OITM.AvgPrice AS INT) As Price  " _
        '                                        & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
        '                                        & " Where ItemCode LIKE  '%" & Trim(txtKodeBarang.Text) & "%' ", conn)
        '            conn.CreateCommand.CommandTimeout = 0
        '            Dim adapter As New SqlDataAdapter(cmd)
        '            Dim table As New DataTable
        '            adapter.Fill(table)
        '            dgItemList.DataSource = table
        '            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '            dgItemList.AutoResizeColumns()
        '        End If

        '        If Err.Description = "" Then Exit Sub

        'ErrorHandler:
        '        Call MsubPesanError()
        '        Exit Sub


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
            Call koneksi()
            conn = New SqlConnection(server)


            Dim cmd As New SqlCommand("SELECT Top 10 ItemCode AS [Kode Barang], " _
                                      & " REPLACE(ItemName,'I''','I`') AS [Nama Barang],dbo.OITB.ItmsGrpNam AS [Kategori Barang] " _
                                      & " FROM dbo.OITM LEFT OUTER JOIN OITB ON OITB.ItmsGrpCod = OITM.ItmsGrpCod " _
                                      & " Where ItemName LIKE  '%" & fConvert(Trim(txtNamaBarang.Text)) & "%' ", conn)

            cmd.CommandTimeout = 0

            Dim adapter As New SqlDataAdapter(cmd)

            Dim table As New DataTable

            adapter.Fill(table)

            dgItemList.DataSource = table
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgItemList.AutoResizeColumns()
        Else
            Exit Sub
        End If

        If Err.Description = "" Then Exit Sub


Errorhandler:
        Call MsubPesanError()
        strFilter = ""
        Exit Sub

    End Sub

    Private Sub dgItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellClick
        On Error GoTo ErrorHandler

        txtKodeBarang.Text = dgItemList.Item(0, dgItemList.CurrentRow.Index).Value
        txtNamaBarang.Text = dgItemList.Item(1, dgItemList.CurrentRow.Index).Value
        txtItemGroup.Text = dgItemList.Item(2, dgItemList.CurrentRow.Index).Value

        If WindowState = FormWindowState.Normal Then
            Call LoadDatagridViewInventory()
        Else
            Call LoadDatagridViewInventoryMaximizeForm()
        End If

        gbItem.Visible = False

        If Err.Description = "" Then Exit Sub
ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub

    Private Sub MainWindows_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        On Error Resume Next
        lblJudul.Size = New Size(ClientSize.Width / 4, ClientSize.Height / 4)
        'lblJudul.Font = New Font("Microsoft YaHei", ClientSize.Height / 22)

    End Sub


    Private Sub dgInventoryData_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgInventoryData.CellFormatting
        On Error Resume Next
        For i As Integer = 0 To dgInventoryData.Rows.Count - 1
            If dgInventoryData.Rows(i).Cells(2).Value < 0 Then
                dgInventoryData.Rows(i).Cells(2).Style.ForeColor = Color.OrangeRed
                dgInventoryData.Rows(i).Cells(2).Style.BackColor = Color.YellowGreen
            Else
                dgInventoryData.Rows(i).Cells(2).Style.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub btTutup_Click(sender As Object, e As EventArgs) Handles btTutup.Click
        gbItem.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        '' perulangan untuk mengisi value pada progressbar
        'For i As Integer = 0 To 100

        '    Dim status As String = ""
        '    If (i >= 1 And i < 5) Then
        '        status = "Menghubungkan Database"
        '    ElseIf (i >= 5 And i < 10) Then
        '        status = "Mengirim Perintah"
        '    ElseIf (i >= 10 And i < 15) Then
        '        status = "Menunggu Respon"
        '    ElseIf (i = 20) Then
        '        status = "Selesai"
        '    End If

        '    ' memperbarui reportprogress
        '    BackgroundWorker1.ReportProgress(i, status)

        '    System.Threading.Thread.Sleep(100)

        '    ' jika backgroundWorker1 di batalkan
        '    If (BackgroundWorker1.CancellationPending) Then
        '        e.Cancel = True
        '        Exit Sub
        '    End If
        'Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = Convert.ToDouble(e.ProgressPercentage) 'memperbarui value pada progressbar
        lblStatus.Text = e.ProgressPercentage.ToString() & "%" ' memperbarui text pada label1
        lblStatus.Text = DirectCast(e.UserState, String) ' memberparui text pada label2
    End Sub

    Private Sub cmdStopALL_Click(sender As Object, e As EventArgs) Handles cmdStopALL.Click
        If (BackgroundWorker1.IsBusy) Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (e.Cancelled = True) Then 'jika backgroundWorker1 dibatalkan
            lblStatus.Text = "Proses dibatalkan"
            'MessageBox.Show("Proses dibatalkan")
            Exit Sub
        ElseIf (e.Error IsNot Nothing) Then ' jika terjadi error selama backgroundworker berjalan
            MessageBox.Show(e.Error.Message)
            Exit Sub
        Else
            lblStatus.Text = "Proses selesai"
            Exit Sub

            'MessageBox.Show("Proses selesai")
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ShowMyIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMyIPToolStripMenuItem.Click
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        MsgBox("IP Address Anda Adalah : " & vbNewLine & h.AddressList.GetValue(0).ToString, vbInformation, "Monitoring Realstok V1.1")
    End Sub

    Private Sub ChangeLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeLogToolStripMenuItem.Click
        FormChangeLog.ShowDialog()
    End Sub

    Private Sub PingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingToolStripMenuItem.Click
        FormPing.ShowDialog()
    End Sub



    Private Sub dgInventoryData_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgInventoryData.ColumnHeaderMouseClick
        For i As Integer = 0 To dgInventoryData.Rows.Count - 1
            dgInventoryData.Rows(i).Cells(2).Style.ForeColor = Color.Black
        Next
    End Sub



    Private Sub dgInventoryData_SelectionChanged(sender As Object, e As EventArgs) Handles dgInventoryData.SelectionChanged

        On Error Resume Next
        For i As Integer = 0 To dgInventoryData.Rows.Count - 1
            dgInventoryData.Rows(i).Cells(2).Style.ForeColor = Color.Black
        Next

    End Sub

    Private Sub dgInventoryData_Sorted(sender As Object, e As EventArgs) Handles dgInventoryData.Sorted
        On Error Resume Next
        For i As Integer = 0 To dgInventoryData.Rows.Count - 1
            dgInventoryData.Rows(i).Cells(2).Style.ForeColor = Color.Black
        Next
    End Sub

End Class