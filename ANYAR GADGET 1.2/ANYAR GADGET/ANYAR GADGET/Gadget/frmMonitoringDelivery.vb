Imports System.Data.SqlClient

Public Class frmMonitoringDelivery

    Private Sub MonitoringDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load

        'MstrNamaModul = "AG-Monitoring Delivery"

        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"

        dtpTgl1.Value = Now
        dtpTgl2.Value = Now

        'LoadHeaderTransaksiCustomerFormLoad()
        'LoadHeaderTransaksiDefaultLoad()
        'LoadControl()
        'LoadHeaderTransferFormLoad()

    End Sub


    Sub LoadHeaderTransaksiCustomerFormLoad()
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "01")
        command.Parameters.AddWithValue("@NoStruk", "")

        command.Parameters.AddWithValue("@From", "")

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False


        lblJumlahTransaksi.Text = "Jumlah Transaksi Untuk Dikirim : " & dgDaftarDelivery.RowCount

    End Sub




    Sub LoadHeaderTransaksiSudahDikirim()
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "SudahKirim")
        command.Parameters.AddWithValue("@NoStruk", "")

        command.Parameters.AddWithValue("@From", "")

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDeliverySudahDikirim.AutoResizeColumns()
        dgDeliverySudahDikirim.RowHeadersVisible = False


        lblDeliverySudahDikirim.Text = "Jumlah Delivery Sudah Dikirim : " & dgDeliverySudahDikirim.RowCount

    End Sub





    Sub LoadHeaderTransaksiBelumDikirim()
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "BelumDikirim")
        command.Parameters.AddWithValue("@NoStruk", "")

        command.Parameters.AddWithValue("@From", "")

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDeliveryBelumDikirim.DataSource = table
        dgDeliveryBelumDikirim.DataSource = table
        dgDeliveryBelumDikirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDeliveryBelumDikirim.AutoResizeColumns()
        dgDeliveryBelumDikirim.RowHeadersVisible = False


        lblDeliverySudahDikirim.Text = "Jumlah Delivery Belum Dikirim : " & dgDeliverySudahDikirim.RowCount

    End Sub





    Sub LoadHeaderTransaksiDefaultLoad()
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "01Load")
        command.Parameters.AddWithValue("@NoStruk", "")

        command.Parameters.AddWithValue("@From", "")

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False


        lblJumlahTransaksi.Text = "Jumlah Transaksi Untuk Dikirim : " & dgDaftarDelivery.RowCount

    End Sub






    Sub LoadHeaderDeliveryALL()
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "01ALL")
        command.Parameters.AddWithValue("@NoStruk", "")

        command.Parameters.AddWithValue("@From", "")

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False


        lblJumlahTransaksi.Text = "Jumlah Transaksi Untuk Dikirim : " & dgDaftarDelivery.RowCount

    End Sub









    'Sub LoadHeaderTransferFormLoad()
    '    KoneksiDatabase2()
    '    Dim command2 As SqlCommand
    '    command2 = New SqlCommand("tmsp_LapStatusDelivery", Koneksi2)
    '    Dim adapter As New SqlDataAdapter(command2)
    '    command2.CommandType = CommandType.StoredProcedure
    '    command2.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
    '    command2.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
    '    command2.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
    '    command2.Parameters.AddWithValue("@Menu", "202")
    '    command2.Parameters.AddWithValue("@NoStruk", "")
    '    command2.Parameters.AddWithValue("@From", "")

    '    Dim table2 As New DataTable
    '    adapter.Fill(table2)

    '    dgDaftarTransfer.DataSource = table2
    '    dgDaftarTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgDaftarTransfer.AutoResizeColumns()
    '    dgDaftarTransfer.RowHeadersVisible = False

    '    lblJumlahTransfer.Text = "Jumlah Transfer : " & dgDaftarTransfer.RowCount

    'End Sub




    'Sub LoadHeaderTransaksiCustom()
    '    KoneksiDatabase2()
    '    Dim command2 As SqlCommand
    '    command2 = New SqlCommand("tmsp_LapStatusDelivery", Koneksi2)
    '    Dim adapter As New SqlDataAdapter(command2)
    '    command2.CommandType = CommandType.StoredProcedure
    '    command2.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
    '    command2.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
    '    command2.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
    '    command2.Parameters.AddWithValue("@Menu", "202")
    '    command2.Parameters.AddWithValue("@NoStruk", "")

    '    command2.Parameters.AddWithValue("@From", "")



    '    Dim table2 As New DataTable
    '    adapter.Fill(table2)

    '    dgDaftarTransfer.DataSource = table2
    '    dgDaftarTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgDaftarTransfer.AutoResizeColumns()
    '    dgDaftarTransfer.RowHeadersVisible = False

    '    lblJumlahTransfer.Text = "Jumlah Transfer : " & dgDaftarTransfer.RowCount

    'End Sub




    Sub LoadHeaderTransferCustom()

    End Sub

    Sub LoadControl()
        'Call KoneksiDatabase1()

        'strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='CHK001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        'cmd = New SqlCommand(strSQL, Koneksi1)
        'dr = cmd.ExecuteReader
        'dr.Read()
        'If dr.HasRows = True Then
        '    dr.GetString(0)

        '    If dr.GetString(0) = "1" Then
        '        chkAllDelivey.Visible = True
        '    Else
        '        chkAllDelivey.Visible = False
        '    End If

        '    dr.Close()
        'Else
        '    chkAllDelivey.Visible = False
        '    dr.Close()
        'End If


    End Sub







    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        If chkAllDelivey.Checked = True Then

            LoadHeaderDeliveryALL()
        Else
            LoadHeaderTransferCustom()
            LoadHeaderTransaksiCustomerFormLoad()
            LoadHeaderTransaksiSudahDikirim()
            LoadHeaderTransaksiBelumDikirim()
        End If




    End Sub





    Private Sub dgDaftarDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarDelivery.CellContentClick
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "02")
        command.Parameters.AddWithValue("@NoStruk", dgDaftarDelivery.Item(0, dgDaftarDelivery.CurrentRow.Index).Value)
        command.Parameters.AddWithValue("@From", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgItemDelivery.DataSource = table
        dgItemDelivery.DataSource = table
        dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemDelivery.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(4).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(5).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(6).DefaultCellStyle.Format = "N0"


        dgItemDelivery.AutoResizeColumns()
        dgItemDelivery.RowHeadersVisible = False
        lblJumlahItemTransaksi.Text = "Jumlah Item : " & dgItemDelivery.RowCount


    End Sub

    'Private Sub dgDaftarTransfer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    koneksiMenu()
    '    Dim command As SqlCommand
    '    command = New SqlCommand("tmsp_LapStatusDelivery", conn)

    '    Dim adapter As New SqlDataAdapter(command)
    '    command.CommandType = CommandType.StoredProcedure

    '    command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
    '    command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
    '    command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
    '    command.Parameters.AddWithValue("@Menu", "21")
    '    command.Parameters.AddWithValue("@NoStruk", dgDaftarTransfer.Item(0, dgDaftarTransfer.CurrentRow.Index).Value)
    '    command.Parameters.AddWithValue("@From", "")
    '    Dim table As New DataTable
    '    adapter.Fill(table)
    '    Me.dgItemDelivery.DataSource = table
    '    dgItemDelivery.DataSource = table
    '    dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgItemDelivery.AutoResizeColumns()
    '    dgItemDelivery.RowHeadersVisible = False
    'End Sub

    Private Sub MonitoringDelivery_Move(sender As Object, e As EventArgs) Handles Me.Move
        'ShowLocation(Me)

    End Sub

    Private Sub MonitoringDelivery_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'ShowLocation(Me)
    End Sub




    Private Sub cmbFromTransfer_Click(sender As Object, e As EventArgs)
        'LoadComboBoxDBLive(cmbFromTransfer, "SELECT WhsCode,WhsName FROM dbo.OWHS WHERE WhsCode NOT LIKE '%ds%'", "WhsCode", "WhsName")
    End Sub

    Private Sub cmdToTransfer_Click(sender As Object, e As EventArgs)
        'LoadComboBoxDBLive(cmbFromTransfer, "SELECT WhsCode,WhsName FROM dbo.OWHS WHERE WhsCode NOT LIKE '%ds%'", "WhsCode", "WhsName")
    End Sub

    Private Sub AvailableToPromiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableToPromiseToolStripMenuItem.Click

        'If dgItemDelivery.Rows.Count = 0 Then Exit Sub


        'Dim frm As New FormAvailableToPromise

        'frm.MdiParent = MenuUtama

        'frm.txtItemCode.Text = Me.dgItemDelivery.Item(2, dgItemDelivery.CurrentRow.Index).Value
        'frm.txtItemName.Text = Me.dgItemDelivery.Item(3, dgItemDelivery.CurrentRow.Index).Value
        'frm.Location = New Point(294, 39)

        'frm.TopMost = True
        'frm.Show()
    End Sub

    Private Sub dgDeliveryBelumDikirim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDeliveryBelumDikirim.CellContentClick
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "02")
        command.Parameters.AddWithValue("@NoStruk", dgDeliveryBelumDikirim.Item(0, dgDeliveryBelumDikirim.CurrentRow.Index).Value)
        command.Parameters.AddWithValue("@From", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgItemDelivery.DataSource = table
        dgItemDelivery.DataSource = table
        dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemDelivery.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(4).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(5).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(6).DefaultCellStyle.Format = "N0"


        dgItemDelivery.AutoResizeColumns()
        dgItemDelivery.RowHeadersVisible = False
        lblJumlahItemTransaksi.Text = "Jumlah Item : " & dgItemDelivery.RowCount
    End Sub

    Private Sub dgDeliverySudahDikirim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDeliverySudahDikirim.CellContentClick
        'koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", MstrKodeDivisi)
        command.Parameters.AddWithValue("@Menu", "DetailSudahDikirim")
        command.Parameters.AddWithValue("@NoStruk", dgDeliverySudahDikirim.Item(0, dgDeliverySudahDikirim.CurrentRow.Index).Value)
        command.Parameters.AddWithValue("@From", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgItemDelivery.DataSource = table
        dgItemDelivery.DataSource = table
        dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemDelivery.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dgItemDelivery.Columns(4).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(5).DefaultCellStyle.Format = "N0"
        dgItemDelivery.Columns(6).DefaultCellStyle.Format = "N0"


        dgItemDelivery.AutoResizeColumns()
        dgItemDelivery.RowHeadersVisible = False
        lblJumlahItemTransaksi.Text = "Jumlah Item : " & dgItemDelivery.RowCount
    End Sub
End Class