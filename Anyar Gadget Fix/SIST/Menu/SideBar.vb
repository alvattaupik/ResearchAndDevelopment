Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets

Public Class SideBar

    Dim Rand As New Random
    Dim Counter As Double = 1
    Dim IsiCounterNew As Double
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim isiCounter As Integer

    Dim Client2 As TcpClient
    Dim sWriter As StreamWriter
    Dim NIckFrefix As Integer = New Random().Next(1111, 9999)


    Sub xLoad() Handles Me.Load
        'Me.Text &= " " & NIckFrefix
       



     

    End Sub


    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(Client.GetStream).ReadLine)
            Client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        Catch ex As Exception
            xUpdate("Anda Telah Terputus dari Server")
            Exit Sub
        End Try
    End Sub



    Sub readRunningText(ByVal ar As IAsyncResult)
        Try
            xUpdateRunning(New StreamReader(Client2.GetStream).ReadLine)
            Client2.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf readRunningText, Nothing)

        Catch ex As Exception
            xUpdateRunning("Anda Telah Terputus dari Server")
            Exit Sub
        End Try
    End Sub


    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(client.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch ex As Exception
            xUpdate("You're not server")
        End Try
    End Sub




    Delegate Sub _xUpdate(ByVal str As String)
    Delegate Sub _xUpdateRunning(ByVal str As String)

    Sub xUpdate(ByVal str As String)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            txtNotifikasi.AppendText(str & vbNewLine)
        End If

    End Sub

    Sub xUpdateRunning(ByVal str As String)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _xUpdateRunning(AddressOf xUpdateRunning), str)
        Else
            MstrIsiRunningText = (str)

            If MstrIsiRunningText = Nothing Then
                Teks = MstrIsiRunningText = "Selamat Datang"
                MenuUtama.TimerRunningText.Stop()
            Else
                Teks = MstrIsiRunningText
                MenuUtama.TimerRunningText.Start()
            End If

        End If

    End Sub



    Private Sub SideBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNamaUser.Text = MstrNamaUser
        txtLocation.Text = "Kode Cabang : " & MstrKodeDivisi
        txtSiteID.Text = "Site ID: " & MstrSiteID
        lblHari.Text = Date.Today.ToString("dddd")
        TimerJam.Start()

        cmdAnyarLocalPrint.Enabled = True
        ObjectMenu()
        MstrNamaModul = "AG-Sidebar"


        Dim strPathPhoto As String = My.Settings.PathPhoto

        If strPathPhoto = "" Then
            Dim A As String = "Wah"
        Else
            GunaCirclePictureBox3.Image = Image.FromFile(Trim(strPathPhoto))
        End If


        cmdConnectNotif.PerformClick()

    End Sub


    Sub ObjectMenu()
        If MstrMenuAnyarLocalPrint = "1" Then
            cmdAnyarLocalPrint.Visible = True

        Else
            cmdAnyarLocalPrint.Visible = False

        End If

        If MstrMenuMonitoringRealstok = "1" Then
            cmdMonitoringRealStok.Visible = True

        Else
            cmdMonitoringRealStok.Visible = False

        End If




        If MstrMenuDelivery = "1" Then
            cmdMonitoringDelivery.Visible = True
        Else
            cmdMonitoringDelivery.Visible = False
        End If



        If MstrMenuExportHargaJual = "1" Then
            cmdExportHargaJual.Visible = True
        Else
            cmdExportHargaJual.Visible = False

        End If



        If MstrMenuAnyarDirectory = "1" Then
            cmdAnyarRepository.Visible = True
        Else
            cmdAnyarRepository.Visible = False

        End If



        If MstrMenuIntegrationMonitor = "1" Then
            cmdAIO.Visible = True
        Else
            cmdAIO.Visible = False
        End If


        If MstrMenuIntegrationMonitor = "1" Then
            cmdAIO.Visible = True
        Else
            cmdAIO.Visible = False
        End If


    End Sub





    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        lblJam.Text = TimeOfDay
    End Sub

    Private Sub GunaGradientButton2_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            MenuUtama.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaUser, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmdConnectNotif_Click(sender As Object, e As EventArgs) Handles cmdConnectNotif.Click
        If cmdConnectNotif.Text = "Connect" Then
            Try
                Client = New TcpClient(MstrServerBroadCast, CInt("3818"))
                Client2 = New TcpClient(MstrServerBroadCast, CInt("3819"))
                Client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                Client2.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf readRunningText), Nothing)
                cmdConnectNotif.Text = "Disconnect"
            Catch ex As Exception
                xUpdate("Tidak Dapat Terhubung Ke Server!")
                xUpdateRunning("Tidak Dapat Terhubung Ke Server!")
            End Try
        Else
            Client.Client.Close()
            Client2.Client.Close()

            Client = Nothing
            Client2 = Nothing
            cmdConnectNotif.Text = "Connect"
        End If
    End Sub



   
    Private Sub cmdExportHargaJual_Click_1(sender As Object, e As EventArgs)
        Dim frm As New ExportHargaJual
        frm.MdiParent = MenuUtama
        frm.TopMost = True
        frm.Location = New Point(395, 15)
        frm.Show()
    End Sub

    

    Private Sub cmdAnyarLocalPrint_Click(sender As Object, e As EventArgs) Handles cmdAnyarLocalPrint.Click
        AnyarLocalPrint.Location = New Point(229, 3)
        AnyarLocalPrint.Show()
    End Sub

    Private Sub cmdMonitoringDelivery_Click_1(sender As Object, e As EventArgs) Handles cmdMonitoringDelivery.Click
        Dim frm As New MonitoringDelivery
        frm.MdiParent = MenuUtama
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub

    Private Sub cmdMonitoringRealStok_Click_1(sender As Object, e As EventArgs) Handles cmdMonitoringRealStok.Click
        Dim frm As New MonitoringRealStock
        frm.MdiParent = MenuUtama
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub cmdAnyarRepository_Click(sender As Object, e As EventArgs) Handles cmdAnyarRepository.Click
        Dim frm As New AnyarRepository
        frm.MdiParent = MenuUtama
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub cmdExportHargaJual_Click(sender As Object, e As EventArgs) Handles cmdExportHargaJual.Click
        Dim frm As New ExportHargaJual
        frm.MdiParent = MenuUtama
        frm.TopMost = True
        frm.Location = New Point(395, 15)
        frm.Show()
    End Sub

    Private Sub cmdAIO_Click(sender As Object, e As EventArgs) Handles cmdAIO.Click
     
        IntegrationMonitoring.MdiParent = MenuUtama
        IntegrationMonitoring.TopMost = True
        IntegrationMonitoring.Location = New Point(372, 60)
        IntegrationMonitoring.Show()
    End Sub

    Private Sub cmdAnyarNotifications_Click(sender As Object, e As EventArgs) Handles cmdAnyarNotifications.Click
        LoadNotifPerubahanHarga()
    End Sub

    Private Sub cmdUbahPassword_Click(sender As Object, e As EventArgs) Handles cmdUbahPassword.Click
        Profile.ShowDialog()
    End Sub
End Class