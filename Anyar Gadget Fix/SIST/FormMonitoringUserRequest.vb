Imports System.Data.SqlClient
Public Class FormMonitoringUserRequest

    Sub LoadDaftarRequestValidasiALL()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub



    Sub BelumDiproses()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where StatusRequest=''", Koneksi1)
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


    'Sub LoadDaftarRequestValidasiActive()

    '    Call KoneksiDatabase1()
    '    Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where StatusRequest<>'Di Setujui dan Di Proses'", Koneksi1)
    '    cmd.CommandTimeout = 0
    '    Dim adapter As New SqlDataAdapter(cmd)
    '    Dim table As New DataTable
    '    adapter.Fill(table)
    '    dgRequestMonitoring.DataSource = table
    '    dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '    dgRequestMonitoring.AutoResizeColumns()


    'End Sub




    Private Sub FormMonitoringStatusValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        BelumDiproses()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where StatusRequest=''", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        'If dgRequestMonitoring.RowCount = 0 Then Exit Sub
        'MstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        'MstrJenisDokumen = dgRequestMonitoring.Item(2, dgRequestMonitoring.CurrentRow.Index).Value

        'If MstrJenisDokumen = "FORM VALIDASI" Then
        '    FormApprovalDetaiMyRequest.ShowDialog()
        'End If

        'If MstrJenisDokumen = "FORM CLOSE AND CANCEL DOCUMENTS" Then
        '    FormApprovalDetaiMyRequestCloseCancelDocument.ShowDialog()
        'End If


        'If MstrJenisDokumen = "FORM CLOSE AND OPEN POSTING PERIODE" Then
        '    FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.ShowDialog()
        'End If

        'If MstrJenisDokumen = "FORM PEMINJAMAN ASSET " Then
        '    FormDetailPeminjamanSaya.ShowDialog()
        'End If

    End Sub

    Private Sub cmdProsesRequest_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdCetakForm_Click(sender As Object, e As EventArgs) Handles cmdCetakForm.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            MstrPathReport = dr.GetString(0)
            FormTampilkanCetakan.Show()
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

    Private Sub txtNoValidasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoValidasi.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where NoValidasi like '%" & txtNoValidasi.Text & "%'", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgRequestMonitoring.DataSource = table
            dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgRequestMonitoring.AutoResizeColumns()
            e.Handled = True
        End If
    End Sub

    Private Sub txtNamaUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where NamaUser like '%" & txtNamaUser.Text & "%'", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgRequestMonitoring.DataSource = table
            dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgRequestMonitoring.AutoResizeColumns()
            e.Handled = True
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FormTemplate.ShowDialog()
    End Sub
End Class