Imports System.Data.SqlClient
Public Class FormMonitoringApprovalUserRequest

    Sub LoadDaftarRequestValidasiALL()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_DaftarMonitoringRequest Where Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND KdDivisi='" & MstrKodeDivisi & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub


    Sub LoadAllRequest()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub



    Sub LoadDaftarApprovalActive()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where KdDivisi='" & Trim(MstrKodeDivisi) & "' AND StatusApproval='Belum Disetujui SPV' AND kdJenisSurat<>'IT006'", Koneksi1)
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
        Dim cmd As New SqlCommand("SELECT NoValidasi,NamaUser,Jenis,StatusApproval,StatusRequest,CreateDate,JenisRequest,Komponen,Durasi,Pesan FROM V_DaftarMonitoringRequest Where StatusRequest='Belum Di Proses IT' AND KdDivisi='" & MstrKodeDivisi & "'", Koneksi1)
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

        If ChkAllReqAndApproval.Checked = True Then
            LoadAllRequest()
        Else
            LoadDaftarApprovalActive()
        End If

    End Sub





    Private Sub FormMonitoringStatusValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'BelumDiproses()
        LoadDaftarApprovalActive()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='CHK001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            If dr.GetString(0) = "1" Then
                ChkAllReqAndApproval.Enabled = True
            Else
                ChkAllReqAndApproval.Enabled = False
            End If

            dr.Close()
        Else
            ChkAllReqAndApproval.Enabled = False
            dr.Close()
        End If



    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        If ChkAllReqAndApproval.Checked = False Then

            LoadDaftarApprovalActive()
        Else
            LoadDaftarRequestValidasiALL()
        End If

    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub
        MstrNoSurat = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(6, dgRequestMonitoring.CurrentRow.Index).Value

        LoadFormDetailApprovalRequest()

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

            If ChkAllReqAndApproval.Checked = True Then

                Call KoneksiDatabase1()
                Dim cmd As New SqlCommand("SELECT SELECT CreateDate,NoValidasi AS Nomor,NamaUser,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NoValidasi like '%" & txtNoValidasi.Text & "%' AND KdDivisi='" & MstrKodeDivisi & "'", Koneksi1)
                cmd.CommandTimeout = 0
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                dgRequestMonitoring.DataSource = table
                dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgRequestMonitoring.AutoResizeColumns()
                e.Handled = True

            Else
                Call KoneksiDatabase1()
                Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,NamaUser,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NoValidasi like '%" & txtNoValidasi.Text & "%'", Koneksi1)
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


        End If
    End Sub

    Private Sub txtNamaUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaUser.KeyPress
        If Asc(e.KeyChar) = 13 Then



            If ChkAllReqAndApproval.Checked = True Then

                Call KoneksiDatabase1()
                Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,NamaUser,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NamaUser like '%" & txtNamaUser.Text & "%'", Koneksi1)
                cmd.CommandTimeout = 0
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                dgRequestMonitoring.DataSource = table
                dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgRequestMonitoring.AutoResizeColumns()
                e.Handled = True

            Else

                Call KoneksiDatabase1()
                Dim cmd As New SqlCommand("SELECT CreateDate,NoValidasi AS Nomor,NamaUser,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NamaUser like '%" & txtNamaUser.Text & "%'  AND KdDivisi='" & MstrKodeDivisi & "'", Koneksi1)
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






        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FormTemplate.ShowDialog()
    End Sub


    Private Sub dgRequestMonitoring_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRequestMonitoring.CellContentClick

    End Sub

    Private Sub dgRequestMonitoring_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRequestMonitoring.CellDoubleClick

        If dgRequestMonitoring.RowCount = 0 Then Exit Sub
        MstrNoSurat = dgRequestMonitoring.Item(1, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(6, dgRequestMonitoring.CurrentRow.Index).Value

        LoadFormDetailApprovalRequest()
    End Sub
End Class