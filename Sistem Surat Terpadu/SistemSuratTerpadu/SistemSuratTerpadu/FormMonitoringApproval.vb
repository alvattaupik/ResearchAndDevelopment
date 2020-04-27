Imports System.Data.SqlClient
Public Class FormMonitoringApproval

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
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarRequestValidasiActive()
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        FormDetailValidasi.ShowDialog()

    End Sub

    Private Sub cmdProsesRequest_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdCetakForm_Click(sender As Object, e As EventArgs) Handles cmdCetakForm.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(GlobalstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            GlobalstrPathReport = dr.GetString(0)
            FormTampilkanSurat.Show()
            dr.Close()

        Else

            MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class