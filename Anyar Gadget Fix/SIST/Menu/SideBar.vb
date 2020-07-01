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
        Me.Text &= " " & NIckFrefix
    End Sub


    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(Client.GetStream).ReadLine)
            Client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        Catch ex As Exception
            xUpdate("You have disconnecting from server")
            Exit Sub
        End Try
    End Sub



    Sub readRunningText(ByVal ar As IAsyncResult)
        Try
            xUpdateRunning(New StreamReader(Client2.GetStream).ReadLine)
            Client2.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf readRunningText, Nothing)

        Catch ex As Exception
            xUpdateRunning("You have disconnecting from server")
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
        txtLocation.Text = "Location : " & MstrKodeDivisi
        txtSiteID.Text = "Site ID: " & MstrSiteID
        lblHari.Text = Date.Today.ToString("dddd")
        TimerJam.Start()
    End Sub




   



    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
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
                xUpdate("Can't connect to the server!")
                xUpdateRunning("Can't connect to the server!")
            End Try
        Else
            Client.Client.Close()
            Client2.Client.Close()

            Client = Nothing
            Client2 = Nothing
            cmdConnectNotif.Text = "Connect"
        End If

    End Sub

    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        lblJam.Text = TimeOfDay
    End Sub
End Class