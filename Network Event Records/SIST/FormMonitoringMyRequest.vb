Imports System.Data.SqlClient
Public Class FormMonitoringMyRequest

    Sub LoadDaftarRequestValidasiALL()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarRequestSaya Where KdUser='" & Trim(MstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)
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


        Dim cmd As New SqlCommand("SELECT NoValidasi,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarRequestSaya Where KdUser='" & Trim(MstrKodeUser) & "' AND StatusRequest=''", Koneksi1)
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
        cmbStatusRequest.DataSource = Nothing
        cmbStatus.Items.Clear()
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub
        MstrNoSurat = dgRequestMonitoring.Item(0, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrStatusRequest = dgRequestMonitoring.Item(3, dgRequestMonitoring.CurrentRow.Index).Value

        If MstrJenisDokumen = "FORM VALIDASI" Then
            FormDetaiMyRequest.ShowDialog()
        End If

        If MstrJenisDokumen = "FORM CLOSE AND CANCEL DOCUMENTS" Then
            FormDetaiMyRequestCloseCancelDocument.ShowDialog()
        End If


        If MstrJenisDokumen = "FORM CLOSE AND OPEN POSTING PERIOD " Then
            FormDetaiMyRequestCloseAndOpenPostingPeriode.ShowDialog()
        End If

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

    Sub LoadComboStatus()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdStatus,NamaStatus FROM dbo.MasterStatus WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbStatusRequest.DataSource = ds.Tables(0)
            cmbStatusRequest.ValueMember = "KdStatus"
            cmbStatusRequest.DisplayMember = "NamaStatus"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub



    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarRequestSaya Where KdUser='" & Trim(MstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND StatusApproval Like '%" & cmbStatus.Text & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()
    End Sub

    Private Sub cmbStatusRequest_Click(sender As Object, e As EventArgs) Handles cmbStatusRequest.Click
        LoadComboStatus()
    End Sub

    Private Sub cmbStatusRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusRequest.SelectedIndexChanged
        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT NoValidasi,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarRequestSaya Where KdUser='" & Trim(MstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND StatusRequest Like '%" & cmbStatusRequest.Text & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FormTemplate.ShowDialog()
    End Sub

End Class