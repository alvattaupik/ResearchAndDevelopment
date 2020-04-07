Imports System.Data.SqlClient
Public Class FormMonitoringStatusValidasi



    Sub LoadDaftarRequestValidasiALL()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_HeaderValidasiALL Where KdUser='" & Trim(GlobalstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub



    Private Sub cmdCari_Click(sender As Object, e As EventArgs) Handles cmdCari.Click
        LoadDaftarRequestValidasiALL()
    End Sub


    Sub LoadDaftarRequestValidasiActive()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_HeaderValidasi Where KdUser='" & Trim(GlobalstrKodeUser) & "'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub




    Private Sub FormMonitoringStatusValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarRequestValidasiActive()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarRequestValidasiActive()
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        FormDetailValidasi.ShowDialog()
    End Sub

    Private Sub cmdProsesRequest_Click(sender As Object, e As EventArgs) Handles cmdProsesRequest.Click

    End Sub
End Class