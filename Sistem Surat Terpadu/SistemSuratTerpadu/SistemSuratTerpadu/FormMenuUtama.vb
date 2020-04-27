Imports System.Data.SqlClient

Public Class FormMenuUtama
    Dim strPathPhoto As String

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

        strPathPhoto = My.Settings.PathPhoto

        If strPathPhoto = "" Then
            Dim A As String
            A = ""
        Else
            GunaPictureBox2.Image = Image.FromFile(Trim(strPathPhoto))
        End If



        LoadDaftarSurat()
        txtNamaUser.Text = GlobalstrNamaUser

        'If MstrLevelUser = "STAFF" Then
        '    ApprovalToolStripMenuItem.Visible = False
        'Else
        '    ApprovalToolStripMenuItem.Visible = True
        'End If



        'If MstrLevelUser = "STAFF" Then
        '    ProsesRequestToolStripMenuItem1.Visible = False
        'Else
        '    ProsesRequestToolStripMenuItem1.Visible = True
        'End If


        'If GlobalstrKodeDivisi = "113" Then
        '    ProsesRequestToolStripMenuItem1.Visible = True
        'Else
        '    ProsesRequestToolStripMenuItem1.Visible = False
        'End If


    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""

            MsgBox("Terimakasih " & GlobalstrNamaUser, vbInformation, "Terimakasih!")

        Else
            Exit Sub
        End If
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratToolStripMenuItem.Click

    End Sub

    Private Sub SurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SurJalanToolStripMenuItem.Click
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



    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        End
    End Sub

    Private Sub RequestValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestValidasiToolStripMenuItem.Click
        FormMonitoringApproval.ShowDialog()
    End Sub

    Private Sub ApprovalValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormManagementApproval.ShowDialog()
    End Sub

    Private Sub ProsesRequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ProsesRequest.ShowDialog()
    End Sub

    Private Sub SuratTerimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratTerimaToolStripMenuItem.Click
        FormBuatSuratTerima.ShowDialog()
    End Sub


    Private Sub RequestValidasiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RequestValidasiToolStripMenuItem1.Click
        'If MstrLevelUser = "STAFF" Then
        '    MsgBox("Anda Tidak Berhak Mengakses Menu Ini", vbCritical, "Not Authorise Access!")
        '    Exit Sub
        'End If
        FormManagementApproval.ShowDialog()
    End Sub

    Private Sub FormValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormValidasiToolStripMenuItem.Click
        FormBuatRequestValidasi.ShowDialog()
    End Sub

    Private Sub UserLoginDanHakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLoginDanHakAksesToolStripMenuItem.Click
        'If GlobalstrKodeDivisi <> "113" Then
        '    MsgBox("Anda Tidak Berhak Mengakses Menu Ini", vbCritical, "Not Authorise Access!")
        '    Exit Sub
        'Else
        FormUserLogin.ShowDialog()
        'End If
    End Sub

    Private Sub ProsesRequestToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RequestFullfilmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestFullfilmentToolStripMenuItem.Click
        'If GlobalstrKodeDivisi <> "113" Then
        '    MsgBox("Anda Tidak Berhak Mengakses Menu Ini", vbCritical, "Not Authorise Access!")
        '    Exit Sub
        'End If

        FormDaftarAllRequest.ShowDialog()
    End Sub

    Private Sub PenyelesaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyelesaianToolStripMenuItem.Click

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FormKonfigurasiCetakanSurat.ShowDialog()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        FormJenisValidasi.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Apakah Yakin anda akan keluar dari aplikasi ini?", vbYesNo, "Konfirmasi") = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""

            MsgBox("Terimakasih " & GlobalstrNamaUser, vbInformation, "Terimakasih!")

        Else
            Exit Sub
        End If
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.WindowState = 1
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        EditUsernamePassword.ShowDialog()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        EditUsernamePassword.ShowDialog()
    End Sub
End Class