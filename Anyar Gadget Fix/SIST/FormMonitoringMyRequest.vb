Imports System.Data.SqlClient
Public Class FormMonitoringMyRequest

    Sub LoadDaftarRequestALL()

        Call KoneksiDatabase1()

        Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where KdUser='" & Trim(MstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)
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
        LoadDaftarRequestALL()
    End Sub


    Sub LoadDaftarRequesActive()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where KdUser='" & Trim(MstrKodeUser) & "' AND StatusRequest='Belum Di Proses IT'", Koneksi1)
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
        LoadDaftarRequesActive()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarRequesActive()
        cmbStatusRequest.DataSource = Nothing
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub
        MstrNoSurat = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(6, dgRequestMonitoring.CurrentRow.Index).Value
        LoadFormDetailMyRequest()

    End Sub

    Sub LoadFormDetailMyRequest()
        If MstrJenisDokumen = "IT003" Then
            'FormDetaiMyRequestValidasi.ShowDialog()
        End If

        If MstrJenisDokumen = "IT004" Then
            FormDetaiMyRequestCloseCancelDocument.ShowDialog()
        End If

        If MstrJenisDokumen = "IT005" Then
            FormDetaiMyRequestCloseAndOpenPostingPeriode.ShowDialog()
        End If

        If MstrJenisDokumen = "IT006" Then
            FormDetailPeminjamanSaya.ShowDialog()
        End If

    End Sub

    Private Sub cmdCetakForm_Click(sender As Object, e As EventArgs) Handles cmdCetakForm.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(6, dgRequestMonitoring.CurrentRow.Index).Value

        'LoadTemplateSurat()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
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

   



    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call KoneksiDatabase1()


        'Dim cmd As New SqlCommand("SELECT NoValidasi,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarRequestSaya Where KdUser='" & Trim(MstrKodeUser) & "' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND StatusApproval Like '%" & cmbStatus.Text & "%'", Koneksi1)
        'cmd.CommandTimeout = 0
        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable
        'adapter.Fill(table)
        'dgRequestMonitoring.DataSource = table
        'dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dgRequestMonitoring.AutoResizeColumns()
    End Sub

    Private Sub cmbStatusRequest_Click(sender As Object, e As EventArgs)
        LoadComboStatus()
    End Sub

    Private Sub cmbStatusRequest_SelectedIndexChanged(sender As Object, e As EventArgs)
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



    Private Sub dgRequestMonitoring_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRequestMonitoring.CellContentDoubleClick
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(6, dgRequestMonitoring.CurrentRow.Index).Value
        LoadFormDetailMyRequest()

    End Sub

    Private Sub FormMonitoringMyRequest_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        ShowLocation(Me)
    End Sub

    Private Sub FormMonitoringMyRequest_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub


    Private Sub cmbStatusRequest_Click1(sender As Object, e As EventArgs) Handles cmbStatusRequest.Click
        LoadComboBoxDBEMAIL(cmbStatusRequest, "SELECT KdStatus,NamaStatus FROM dbo.MasterStatus WHERE StatusEnabled='Y'", "KdStatus", "NamaStatus")
    End Sub


End Class