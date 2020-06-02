Imports System.Data.SqlClient

Public Class MonitoringDelivery

    Private Sub MonitoringDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"

        dtpTgl1.Value = Now
        dtpTgl2.Value = Now

        LoadHeaderTransaksiCustomerFormLoad()
        LoadHeaderTransferFormLoad()
       
    End Sub


    Sub LoadHeaderTransaksiCustomerFormLoad()
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Header Transaksi Form Load")
        command.Parameters.AddWithValue("@NoStruk", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False
    End Sub


    Sub LoadHeaderTransferFormLoad()
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Header TR")
        command.Parameters.AddWithValue("@NoStruk", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarTransfer.DataSource = table
        dgDaftarTransfer.DataSource = table
        dgDaftarTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarTransfer.AutoResizeColumns()
        dgDaftarTransfer.RowHeadersVisible = False
    End Sub



    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click

        LoadHeaderTransaksi()
        LoadHeaderTransfer()


    End Sub


    Sub LoadHeaderTransaksi()
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Header Transaksi")
        command.Parameters.AddWithValue("@NoStruk", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.DataSource = table
        dgDaftarDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarDelivery.AutoResizeColumns()
        dgDaftarDelivery.RowHeadersVisible = False
    End Sub


    Sub LoadHeaderTransfer()
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Header TR")
        command.Parameters.AddWithValue("@NoStruk", "")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgDaftarTransfer.DataSource = table
        dgDaftarTransfer.DataSource = table
        dgDaftarTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarTransfer.AutoResizeColumns()
        dgDaftarTransfer.RowHeadersVisible = False
    End Sub


    Private Sub dgDaftarDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarDelivery.CellContentClick
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Detail Transaksi")
        command.Parameters.AddWithValue("@NoStruk", dgDaftarDelivery.Item(0, dgDaftarDelivery.CurrentRow.Index).Value)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgItemDelivery.DataSource = table
        dgItemDelivery.DataSource = table
        dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemDelivery.AutoResizeColumns()
        dgItemDelivery.RowHeadersVisible = False
    End Sub

    Private Sub dgDaftarTransfer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarTransfer.CellContentClick
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_LapStatusDelivery", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@TanggalAwal", dtpTgl1.Value)
        command.Parameters.AddWithValue("@TanggalAkhir", dtpTgl2.Value)
        command.Parameters.AddWithValue("@Cabang", "003")
        command.Parameters.AddWithValue("@Menu", "Detail TR")
        command.Parameters.AddWithValue("@NoStruk", dgDaftarTransfer.Item(0, dgDaftarTransfer.CurrentRow.Index).Value)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgItemDelivery.DataSource = table
        dgItemDelivery.DataSource = table
        dgItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemDelivery.AutoResizeColumns()
        dgItemDelivery.RowHeadersVisible = False
    End Sub

    Private Sub MonitoringDelivery_Move(sender As Object, e As EventArgs) Handles Me.Move
        Dim p As Point
        p = Me.Location

        MenuUtama.lblMousePosition.Text = "Form Position : " & "X : " & p.X & "  Y : " & p.Y

    End Sub

    Private Sub MonitoringDelivery_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        MenuUtama.lblFormSize.Text = " Form Size Width: " & Me.Width.ToString & " Height:" & Me.Height.ToString
    End Sub
End Class