Imports System.Data.SqlClient

Public Class frmMonitoringDelivery

    Private Sub MonitoringDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load


        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"

        dtpTgl1.Value = Now
        dtpTgl2.Value = Now


    End Sub


    Sub LoadHeaderTransaksiCustomerFormLoad()
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
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_LapStatusDeliveryALL]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value.ToString("yyyy-MM-dd"))

        If cmbCabangAll.SelectedValue = "" Then
            command.Parameters.AddWithValue("@Cabang", "")
        Else
            command.Parameters.AddWithValue("@Cabang", cmbCabangAll.SelectedValue)
        End If

        command.Parameters.AddWithValue("@KodeJabatan", MstrLevelUser)

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False

        lblJumlahTransaksi.Text = "Jumlah Seluruh Delivery : " & dgDaftarDelivery.RowCount

    End Sub

    Sub LoadHeaderDeliverySudahDikirim()
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_LapStatusDeliverySudahDikirim]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtp1SudahDikirim.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtp2SudahDikirim.Value.ToString("yyyy-MM-dd"))

        If cmbCabangAll.SelectedValue = "" Then
            command.Parameters.AddWithValue("@Cabang", "")
        Else
            command.Parameters.AddWithValue("@Cabang", cmbSudahDikirim.SelectedValue)
        End If

        command.Parameters.AddWithValue("@KodeJabatan", MstrLevelUser)

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDeliverySudahDikirim.AutoResizeColumns()
        dgDeliverySudahDikirim.RowHeadersVisible = False

        lblDeliverySudahDikirim.Text = "Jumlah Sudah Dikirim : " & dgDeliverySudahDikirim.RowCount

    End Sub


    Sub LoadHeaderDeliveryBlmDikirm()
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_LapStatusDeliveryBelumDikirim]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtp1BlmDikirim.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtp2BlmDikirim.Value.ToString("yyyy-MM-dd"))

        If cmbCabangBelumDikirim.SelectedValue = "" Then
            command.Parameters.AddWithValue("@Cabang", "")
        Else
            command.Parameters.AddWithValue("@Cabang", cmbCabangBelumDikirim.SelectedValue)
        End If

        command.Parameters.AddWithValue("@KodeJabatan", MstrLevelUser)

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDeliveryBelumDikirim.DataSource = table
        dgDeliveryBelumDikirim.DataSource = table
        dgDeliveryBelumDikirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDeliveryBelumDikirim.AutoResizeColumns()
        dgDeliveryBelumDikirim.RowHeadersVisible = False

        lblDeliveryBelumDikirim.Text = "Jumlah Belum Dikirim : " & dgDeliveryBelumDikirim.RowCount

    End Sub
    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        LoadHeaderDeliveryALL()
    End Sub





    Private Sub dgDaftarDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarDelivery.CellContentClick
        Call DetailItemDelivery("ALL", dgDaftarDelivery)


    End Sub

    Private Sub dgDeliveryBelumDikirim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDeliveryBelumDikirim.CellContentClick
        Call DetailItemDelivery("Belum Dikirim", dgDeliveryBelumDikirim)
    End Sub


    Sub DetailItemDelivery(strStatus As String, dgv As DataGridView)
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_ListItemDelivery]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@NoStruk", dgv.Item(0, dgv.CurrentRow.Index).Value)
        command.Parameters.AddWithValue("@Status", strStatus)
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
        txtNamaCustomer.Text = dgv.Item(2, dgv.CurrentRow.Index).Value
    End Sub


    Private Sub dgDeliverySudahDikirim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDeliverySudahDikirim.CellContentClick
        Call DetailItemDelivery("Sudah Dikirim", dgDeliverySudahDikirim)

    End Sub

    Private Sub cmbCabangAll_Click(sender As Object, e As EventArgs) Handles cmbCabangAll.Click
        Dim strSQLLocation As String = "SELECT KodeDivisi,NamaDivisi FROM V_Divisi Where KodeDivisi In (SELECT KodeLocation COLLATE DATABASE_DEFAULT FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbCabangAll, strSQLLocation, "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub
    Private Sub cmbCabangBelumDikirim_Click(sender As Object, e As EventArgs) Handles cmbCabangBelumDikirim.Click
        Dim strSQLLocation As String = "SELECT KodeDivisi,NamaDivisi FROM V_Divisi Where KodeDivisi In (SELECT KodeLocation COLLATE DATABASE_DEFAULT FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbCabangBelumDikirim, strSQLLocation, "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub
    Private Sub btnShowBelumDikirim_Click(sender As Object, e As EventArgs) Handles btnShowBelumDikirim.Click
        LoadHeaderDeliveryBlmDikirm()
    End Sub

    Private Sub btnSudahDIkirim_Click(sender As Object, e As EventArgs) Handles btnSudahDIkirim.Click
        LoadHeaderDeliverySudahDikirim()
    End Sub

    Private Sub cmbSudahDikirim_Click(sender As Object, e As EventArgs) Handles cmbSudahDikirim.Click
        Dim strSQLLocation As String = "SELECT KodeDivisi,NamaDivisi FROM V_Divisi Where KodeDivisi In (SELECT KodeLocation COLLATE DATABASE_DEFAULT FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSudahDikirim, strSQLLocation, "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub

    Sub LoadDeliverySudahDikirim()
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_LapStatusDeliverySudahDikirim]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtp1SudahDikirim.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtp2SudahDikirim.Value.ToString("yyyy-MM-dd"))

        If cmbCabangBelumDikirim.SelectedValue = "" Then
            command.Parameters.AddWithValue("@Cabang", "")
        Else
            command.Parameters.AddWithValue("@Cabang", cmbSudahDikirim.SelectedValue)
        End If

        command.Parameters.AddWithValue("@KodeJabatan", MstrLevelUser)

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.DataSource = table
        dgDeliverySudahDikirim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDeliverySudahDikirim.AutoResizeColumns()
        dgDeliverySudahDikirim.RowHeadersVisible = False
        lblDeliveryBelumDikirim.Text = "Jumlah Belum Dikirim : " & dgDeliveryBelumDikirim.RowCount
    End Sub

End Class