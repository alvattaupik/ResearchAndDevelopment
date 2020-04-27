Imports System.Data.SqlClient
Public Class FormDaftarAllRequest

    Private Sub cmdProsesRequest_Click(sender As Object, e As EventArgs) Handles cmdProsesRequest.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value

        ProsesRequest.ShowDialog()
       
    End Sub

    Private Sub FormDaftarAllRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarApproval()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Sub LoadDaftarApproval()
        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_HeaderValidasiALL Where StatusApproval<>'Lengkap Disetujui' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND StatusApproval Like '%" & Trim(cmbStatus.Text) & "%' ", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdCari_Click(sender As Object, e As EventArgs) Handles cmdCari.Click
        LoadAllApproval()
    End Sub



    Sub LoadAllApproval()
        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_HeaderValidasiALL Where  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND StatusApproval Like '%" & Trim(cmbStatus.Text) & "%' ", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()
    End Sub


End Class