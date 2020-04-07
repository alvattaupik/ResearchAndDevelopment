Imports System.Data.SqlClient

Public Class FormMenuUtama


    Sub LoadDaftarSurat()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT DISTINCT NomorSurat,DibuatOleh,TanggalSurat,JenisSurat,Perihal,Penerima,Attachment,KdJenisSurat,KdUser FROM V_DaftarSuratUser Where KdDivisi='" & Trim(GlobalstrKodeDivisi) & "'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgSuratSaya.DataSource = table
        dgSuratSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSuratSaya.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSuratSaya.AutoResizeColumns()


    End Sub



    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarSurat()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""

            MsgBox("Terimakasih" & GlobalstrNamaUser, vbInformation, "Terimakasih!")

        Else
            Exit Sub
        End If
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratJalanToolStripMenuItem.Click

    End Sub

    Private Sub SurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurToolStripMenuItem.Click
        FormBuatSuratJalan.ShowDialog()
    End Sub

    Private Sub TemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemplateToolStripMenuItem.Click
        FormKonfigurasiCetakanSurat.ShowDialog()
    End Sub

    Private Sub cmdLihatSurat_Click(sender As Object, e As EventArgs) Handles cmdLihatSurat.Click
        If dgSuratSaya.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgSuratSaya.Item(0, dgSuratSaya.CurrentRow.Index).Value

        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(GlobalstrKodeUser) & "' AND KdJenisSurat='" & dgSuratSaya.Item(7, dgSuratSaya.CurrentRow.Index).Value & "' AND StatusEnabled='Y'"
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

    Private Sub ValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidasiToolStripMenuItem.Click
        FormValidasi.ShowDialog()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        End
    End Sub

    Private Sub RequestValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestValidasiToolStripMenuItem.Click
        FormMonitoringStatusValidasi.ShowDialog()
    End Sub

    Private Sub ApprovalValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApprovalValidasiToolStripMenuItem.Click
        FormManagementApproval.ShowDialog()
    End Sub
End Class