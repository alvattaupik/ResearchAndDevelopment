Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class MenuUtama

    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Dim strPathPhoto As String
    Dim strPathHelp As String
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetKontrolObject()

        strPathPhoto = My.Settings.PathPhoto

        If strPathPhoto = "" Then
            Dim A As String
        Else
            GunaPictureBox2.Image = Image.FromFile(Trim(strPathPhoto))
        End If

        txtNamaUser.Text = MstrNamaUser
        LoadDaftarSuratMenuUtama()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaUser, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratJalanToolStripMenuItem.Click
        FormBuatSuratJalan.Show()
    End Sub

    Private Sub SuratTerimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratTerimaToolStripMenuItem.Click
        FormBuatSuratTerima.Show()
    End Sub

    Private Sub SuratTugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratTugasToolStripMenuItem.Click
        FormBuatSuratTugas.ShowDialog()
    End Sub

    Private Sub SuratPengajuanBiayaPerjalananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratPengajuanBiayaPerjalananToolStripMenuItem.Click
        FormBuatSuratPengajuanBiayaPerjalananDinas.Show()
    End Sub

    Private Sub FormValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormValidasiToolStripMenuItem.Click
        FormBuatRequestValidasi.ShowDialog()
    End Sub

    Private Sub JenisValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisValidasiToolStripMenuItem.Click
        FormMasterJenisValidasi.ShowDialog()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        FormDataUser.ShowDialog()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        EditUsernamePassword.ShowDialog()
    End Sub


    Private Sub MyRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyRequestToolStripMenuItem.Click
        FormMonitoringMyRequest.ShowDialog()
    End Sub

    Private Sub CancelDanCloseDokumenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelDanCloseDokumenToolStripMenuItem.Click
        FormBuatRequestCloseAndCancel.ShowDialog()
    End Sub

    Private Sub OpenDanClosingPeriodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDanClosingPeriodeToolStripMenuItem.Click
        FormBuatRequestOpenDanClosingPeriode.ShowDialog()
    End Sub

    Private Sub DaftarRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarRequestToolStripMenuItem.Click
        FormMonitoringUserRequest.ShowDialog()
    End Sub

    Private Sub RequestToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem2.Click
        FormMonitoringProsesRequest.ShowDialog()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FormTemplate.ShowDialog()
    End Sub

    Private Sub cmdLihatSurat_Click(sender As Object, e As EventArgs) Handles cmdLihatSurat.Click
        If dgSuratSaya.RowCount = 0 Then Exit Sub

        MstrNoSurat = dgSuratSaya.Item(0, dgSuratSaya.CurrentRow.Index).Value

        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='" & dgSuratSaya.Item(7, dgSuratSaya.CurrentRow.Index).Value & "' AND StatusEnabled='Y'"
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

    Private Sub cmdUbahUserNamePassword_Click(sender As Object, e As EventArgs) Handles cmdUbahUserNamePassword.Click
        EditUsernamePassword.ShowDialog()
    End Sub

    Private Sub MembuatDokumenToolStripMenuItem_Click(sender As Object, e As EventArgs)



        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT PathKonten FROM dbo.HelpKonten WHERE KodeKonten='DOC001' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strPathHelp = dr.GetString(0)
            dr.Close()

        Else
            dr.Close()
        End If


        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub MelakukanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT PathKonten FROM dbo.HelpKonten WHERE KodeKonten='APV001' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strPathHelp = dr.GetString(0)
            dr.Close()

        Else
            dr.Close()
        End If


        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub MengaturTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT PathKonten FROM dbo.HelpKonten WHERE KodeKonten='TEMP001' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strPathHelp = dr.GetString(0)
            dr.Close()

        Else
            dr.Close()
        End If


        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub MengubahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT PathKonten FROM dbo.HelpKonten WHERE KodeKonten='PASS001' AND StatusEnabled='Y'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strPathHelp = dr.GetString(0)
            dr.Close()

        Else
            dr.Close()
        End If


        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub DaftarBantuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBantuanToolStripMenuItem.Click
        FormHelp.ShowDialog()
    End Sub

    Private Sub MyTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyTemplateToolStripMenuItem.Click
        FormTemplate.ShowDialog()
    End Sub

    Private Sub FormPeminjamanAsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormPeminjamanAsetToolStripMenuItem.Click
        FormBuatPeminjamanAset.ShowDialog()
    End Sub


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


    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click

    End Sub

    Private Sub BAPPenyelesaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BAPPenyelesaianToolStripMenuItem.Click
        FormBuatBeritaAcaraPenyelesaian.ShowDialog()
    End Sub

    Private Sub BAPSerahTerimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BAPSerahTerimaToolStripMenuItem.Click
        FormBuatBeritaAcaraSerahTerima.ShowDialog()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarSuratMenuUtama()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT DISTINCT NomorSurat,DibuatOleh,TanggalSurat,JenisSurat,Perihal,Penerima,Attachment,KdJenisSurat,KdUser FROM V_DaftarSuratUser Where KdDivisi='" & Trim(MstrKodeDivisi) & "' AND DibuatOleh like '%" & txtNamaUser.Text & "%' AND JenisSurat like '%" & cmbJenisSurat.Text & "%' Order By TanggalSurat Desc", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgSuratSaya.DataSource = table
        dgSuratSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSuratSaya.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSuratSaya.AutoResizeColumns()

    End Sub

    Private Sub cmbJenisSurat_Click(sender As Object, e As EventArgs) Handles cmbJenisSurat.Click
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdJenisSurat,NamaSurat FROM dbo.JenisSurat WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbJenisSurat.DataSource = ds.Tables(0)
            cmbJenisSurat.ValueMember = "KdJenisSurat"
            cmbJenisSurat.DisplayMember = "NamaSurat"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub PeminjamanAssetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanAssetToolStripMenuItem.Click
        FormMonitoringPeminjamanAset.ShowDialog()
    End Sub

    Private Sub EmailNotifikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailNotifikasiToolStripMenuItem.Click
        frmSetting.ShowDialog()
    End Sub
End Class