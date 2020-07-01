Imports System.Data.SqlClient
Public Class FormMonitoringProsesRequest

    Sub LoadDaftarProsesRequestAll()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("Select CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where StatusRequest='Belum Di Proses IT' AND Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestMonitoring.DataSource = table
        dgRequestMonitoring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestMonitoring.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestMonitoring.AutoResizeColumns()


    End Sub



    Sub LoadDaftarBelumDiProses()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where StatusRequest='Belum Di Proses IT'", Koneksi1)
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
        LoadDaftarProsesRequestAll()
    End Sub

    Private Sub FormMonitoringStatusValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarBelumDiProses()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarBelumDiProses()
    End Sub


    Sub RefreshData()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where StatusRequest=''", Koneksi1)
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
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(2, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(7, dgRequestMonitoring.CurrentRow.Index).Value
        LoadFormDetailProsesRequest()

    End Sub

    Private Sub cmdProsesRequest_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdCetakForm_Click(sender As Object, e As EventArgs) Handles cmdCetakForm.Click
        On Error GoTo ErrorLoad
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(2, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(7, dgRequestMonitoring.CurrentRow.Index).Value

        LoadTemplateSurat()

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
            Dim cmd As New SqlCommand("SELECT CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NoValidasi like '%" & txtNoValidasi.Text & "%'", Koneksi1)
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
            Dim cmd As New SqlCommand("SELECT CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where NamaUser like '%" & txtNamaUser.Text & "%'", Koneksi1)
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


    Private Sub dgRequestMonitoring_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRequestMonitoring.CellDoubleClick
        If dgRequestMonitoring.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgRequestMonitoring.Item(2, dgRequestMonitoring.CurrentRow.Index).Value
        MstrJenisDokumen = dgRequestMonitoring.Item(7, dgRequestMonitoring.CurrentRow.Index).Value

        LoadFormDetailProsesRequest()

    End Sub

    Private Sub cmbStatusProses_Click(sender As Object, e As EventArgs) Handles cmbStatusProses.Click
        LoadComboBoxDBEMAIL(cmbStatusProses, "SELECT KdStatus,NamaStatus FROM dbo.MasterStatus WHERE StatusEnabled='Y'", "KdStatus", "NamaStatus")
    End Sub

    Private Sub cmbStatusProses_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStatusProses.SelectedValueChanged
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("Select CreateDate,NamaUser,NoValidasi AS Nomor,JenisRequest,StatusApproval,StatusRequest,Komponen,KdJenisSurat FROM V_HeaderRequestUsers Where StatusRequest='" & cmbStatusProses.Text & "' AND Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND NamaUser Like '%" & txtNamaUser.Text & "%'", Koneksi1)
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