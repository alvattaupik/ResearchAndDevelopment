Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports System.Net.Sockets


Public Class MenuUtama

  Dim Bergerak As Integer
    Dim Jam, Menit, Detik As Integer
   

    'Dim MyCommand As SqlDataAdapter
    'Dim DtSet As System.Data.DataSet
    'Dim MyConnection As SqlConnection
    'Dim MyCommand2 As SqlDataAdapter
    'Dim DtSet2 As System.Data.DataSet
    'Dim MyConnection2 As SqlConnection
    'Dim MyCommand3 As SqlDataAdapter
    'Dim DtSet3 As System.Data.DataSet
    'Dim MyConnection3 As SqlConnection

    'Dim ProMyCommand1 As SqlDataAdapter
    'Dim ProDtSet1 As System.Data.DataSet
    'Dim ProMyCommand2 As SqlDataAdapter
    'Dim ProDtSet2 As System.Data.DataSet
    'Dim cnt As Integer
    'Dim ctrlDict As New Dictionary(Of String, Control)



    Dim r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 As Integer
    Dim g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12 As Integer



    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim frm As New SideBar
        frm.MdiParent = Me
        frm.TopMost = True
        frm.ObjectMenu()
        frm.Show()

        If MstrSatuanWaktu = "" Or MIntDurasi = 0 Then
            TimerNotifikasi.Stop()
        Else
            TimerNotifikasi.Start()
        End If

        'LoadHover()


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sorry This Feature Unavailable, Is Currently Under Development", vbInformation, "Informasi")
        Exit Sub
        'Reporting.MdiParent = Me
        'Reporting.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'StorePerform.MdiParent = Me
        'StorePerform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sorry This Feature Unavailable, Is Currently Under Development", vbInformation, "Informasi")
        Exit Sub

        'Dim frm As New AsetMonitoring
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Timer4.Enabled = True

        If MsgBox("Anda Akan Keluar Dari Aplikasi Ini", vbYesNo, "Lanjutkan?") = vbYes Then
            Panel1.Enabled = False
            'LogIn.MdiParent = Me
            'Panel1.BackColor = Color.LightGray
            'LogIn.Show()
        End If

    End Sub












    Private Sub MonitoringRealstokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringRealstokToolStripMenuItem.Click
        Dim frm As New MonitoringRealStock

        frm.MdiParent = Me
        'PanelSideBar.SendToBack()
        'PanelPencarian.SendToBack()
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MonitoringDeliveryToolStripMenuItem.Click
        Dim frm As New MonitoringDelivery

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub

    Private Sub AnyarDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnyarDirectoryToolStripMenuItem.Click
        Dim frm As New AnyarRepository

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

 

    Private Sub MenuUtama_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblMousePosition.Text = "Mouse Position :" & "X." & e.X & vbCrLf & "Y." & e.Y
    End Sub

    Private Sub AnyarLocalPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnyarLocalPrintToolStripMenuItem.Click
        Dim frm As New AnyarLocalPrint

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub

    Private Sub AnyarLocalPrintServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnyarLocalPrintServicesTemplateToolStripMenuItem.Click
        Dim frm As New FormKonfigurasiFormatLaporan

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()


    End Sub

    Private Sub UserLoginDanHakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLoginDanHakAksesToolStripMenuItem.Click
        'Dim frm As New FormUserLoginDanHakAkses

        'frm.MdiParent = Me
        'frm.TopMost = True
        Me.Location = New Point(360, 220)
        FormUserLoginDanHakAkses.ShowDialog()


        'frm.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
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

    Private Sub ExportHargaJualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportHargaJualToolStripMenuItem.Click
        Dim frm As New ExportHargaJual

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(395, 15)
        frm.Show()
    End Sub

    Private Sub IntegrationMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegrationMonitoringToolStripMenuItem.Click
        Dim frm As New IntegrationMonitoring

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(372, 60)
        frm.Show()
    End Sub

    Private Sub TimerRunningText_Tick(sender As Object, e As EventArgs) Handles TimerRunningText.Tick
       
        'txtPesanBerjalan.Text = Bergerak
        'Teks = Microsoft.VisualBasic.Right(Teks, Len(Teks) - 1) & " " & Microsoft.VisualBasic.Left(Teks, 1)
        'txtPesanBerjalan.Text = Teks

        'Dim abc As String = Microsoft.VisualBasic.Left(Teks, 1)
        'Dim def As String = Microsoft.VisualBasic.Right(Teks, Len(Teks) - 1)
        'txtPesanBerjalan.Text = def + abc

        lblBergerak.Text = MstrIsiRunningText

        If lblBergerak.Left >= Me.Width Then
            lblBergerak.Left = Me.Width
            TimerRunningText.Enabled = False
            Timer1.Enabled = True
        Else
            lblBergerak.Left = lblBergerak.Left + 10
        End If



        'lblBergerak.Left = lblBergerak.Left + 1
        'If lblBergerak.Width <= 0 Then
        '    lblBergerak.Left = lblBergerak.Left - 1
        'End If


        'txtPesanBerjalan.Left = txtPesanBerjalan.Left + 1
        'If txtPesanBerjalan.Width <= 0 Then
        '    txtPesanBerjalan.Left = txtPesanBerjalan.Left - 1
        'End If


    End Sub

 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblBergerak.Text = MstrIsiRunningText

        If lblBergerak.Left <= -lblBergerak.Width Then
            lblBergerak.Left = -lblBergerak.Width
            Timer1.Enabled = False
            TimerRunningText.Enabled = True
        Else
            lblBergerak.Left = lblBergerak.Left - 10
        End If
    End Sub

    Private Sub SideBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SideBarToolStripMenuItem.Click

        Dim frm As New SideBar
        frm.MdiParent = Me
        frm.TopMost = True
        frm.ObjectMenu()
        frm.Show()
    End Sub

    Private Sub PushNotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PushNotificationsToolStripMenuItem.Click
        Dim frm As New AlertsSetup
        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(440, 65)
        frm.Show()


    End Sub

    Private Sub TimerNotifikasi_Tick(sender As Object, e As EventArgs) Handles TimerNotifikasi.Tick


        MdblDurasiDetikTimerNotifikasi = MdblDurasiDetikTimerNotifikasi - 1

        lblTimerTime.Text = MdblDurasiDetikTimerNotifikasi.ToString

        If lblTimerTime.Text = "0" Then

            TimerNotifikasi.Stop()
            LoadNotifPerubahanHarga()

        End If



    End Sub

    Private Sub PerubahanHargaJualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerubahanHargaJualToolStripMenuItem.Click
        LoadNotifPerubahanHarga()
    End Sub

    Private Sub ShowMyIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMyIPToolStripMenuItem.Click
        Ping.ShowDialog()
    End Sub

    Private Sub FormBukaValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormBukaValidasiToolStripMenuItem.Click
        Dim frm As New FormBuatRequestBukaValidasi

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub

    Private Sub MonitoringMyRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringMyRequestToolStripMenuItem.Click
        Dim frm As New FormMonitoringMyRequest

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub
End Class
