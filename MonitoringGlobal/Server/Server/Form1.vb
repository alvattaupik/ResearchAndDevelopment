Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Data.SqlClient

Public Class Form1
    Dim Listning As TcpListener
    Dim Allclient As TcpClient
    Dim clientList As New List(Of ClassforClient)
    Dim pReader As StreamReader
    Dim pClient As ClassforClient


    Sub Listen()
        Listning = New TcpListener(IPAddress.Any, 3818)
        Listning.Start()
        UpdateList("Server Starting", False)
        Listning.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listning)
    End Sub

    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As Boolean)
    Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else
            txtBroadcastMessage.AppendText(str & vbNewLine)
            ' if relay we will send a string
            If relay Then send(str)
        End If
    End Sub

    Sub send(ByVal str As String)
        For x As Integer = 0 To clientList.Count - 1
            Try
                clientList(x).Send(str)
            Catch ex As Exception
                clientList.RemoveAt(x)
            End Try
        Next
    End Sub



    Sub AcceptClient(ByVal ar As IAsyncResult)
        pClient = New ClassforClient(Listning.EndAcceptTcpClient(ar))
        AddHandler (pClient.getMessage), AddressOf MessageReceived
        AddHandler (pClient.clientLogout), AddressOf ClientExited
        clientList.Add(pClient)
        UpdateList("New Client Joined!", True)
        Listning.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listning)
    End Sub


    Sub MessageReceived(ByVal str As String)
        UpdateList(str, True)
    End Sub
    Sub ClientExited(ByVal client As ClassforClient)
        clientList.Remove(client)
        UpdateList("Client Exited!", True)
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSendBroadcast.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateList("Server says : " & txtSendBroadcast.Text, True)
            txtSendBroadcast.Clear()
        End If
    End Sub
    Private Sub cmd(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateList("Server says : " & TextBox2.Text, True)
        TextBox2.Clear()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartServer()
    End Sub

    Function StartServer()
        If ServerStatus = False Then
            ServerTrying = True
            Try
                Server = New TcpListener(IPAddress.Any, 4305)
                Server.Start()
                ServerStatus = True
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                StatusServer.Text = "Server Status : Connected"
                StatusServer.BackColor = Color.Green

            Catch ex As Exception
                ServerStatus = False
                StatusServer.Text = "Server Status : Disconnected"
                StatusServer.BackColor = Color.Red

            End Try
            ServerTrying = False
        End If
        Return True
    End Function




    Function StartServerBroadCast()
        If ServerStatus = False Then
            ServerTrying = True
            Try
                Server = New TcpListener(IPAddress.Any, 4301)
                Server.Start()
                ServerStatus = True
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                StatusServer.Text = "Server Status : Connected"
                StatusServer.BackColor = Color.Green

            Catch ex As Exception
                ServerStatus = False
                StatusServer.Text = "Server Status : Disconnected"
                StatusServer.BackColor = Color.Red

            End Try
            ServerTrying = False
        End If
        Return True
    End Function







    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StopServer()
        StatusServer.Text = "Server Status : Disconnected"
        StatusServer.BackColor = Color.White
    End Sub

    Function StopServer()
        If ServerStatus = True Then
            ServerTrying = True
            Try
                For Each Client As TcpClient In Clients
                    Client.Close()
                Next
                Server.Stop()
                ServerStatus = False
            Catch ex As Exception
                StopServer()
            End Try
            ServerTrying = False
        End If
        Return True
    End Function



    Function Handler_Client(ByVal state As Object)
        Dim TempClient As TcpClient

        Try
            Using Client As TcpClient = Server.AcceptTcpClient
                ''     Console.Beep()

                If ServerTrying = False Then
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                End If

                Clients.Add(Client)
                TempClient = Client

                Dim TX As New StreamWriter(Client.GetStream)
                Dim RX As New StreamReader(Client.GetStream)
                Try
                    If RX.BaseStream.CanRead = True Then
                        While RX.BaseStream.CanRead = True
                            Dim RawData As String = RX.ReadLine
                            If Client.Client.Connected = True AndAlso Client.Connected = True AndAlso Client.GetStream.CanRead = True Then
                                REM For some reason this seems to stop the comon tcp connection bug vvv
                                Dim RawDataLength As String = RawData.Length.ToString
                                REM ^^^^ Comment it out and test it in your own projects. Mine might be the only stupid one.
                                txtBroadcastMessage.Text += Client.Client.RemoteEndPoint.ToString + ">>" + RawData + vbNewLine
                            Else : Exit While
                            End If
                        End While
                    End If
                Catch ex As Exception
                    If Clients.Contains(Client) Then
                        Clients.Remove(Client)
                        Client.Close()
                    End If

                End Try


                ''   If RX.BaseStream.CanRead = False Then
                ''   Client.Close()
                ''   Clients.Remove(Client)
                ''   End If
                ''   Console.Beep()
            End Using
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
                TempClient.Close()
            End If
        Catch ex As Exception
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
                TempClient.Close()
            End If
        End Try

        Return True
    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdSendBroadcast.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtSendBroadcast.Text)
    End Sub


    Function SendToClients(ByVal Data As String)
        If ServerStatus = True Then
            If Clients.Count > 0 Then
                Try
                    REM  Broadcast data to all clients
                    REM To target one client,
                    REM USAGE: If client.client.remoteendpoint.tostring.contains(IP As String) Then
                    REM I am sorry for the lack of preparation for this project and in the video.
                    REM I wrote 99% of this from the top of my head,  no one is perfect, bound to make mistakes.
                    For Each Client As TcpClient In Clients
                        Dim TX1 As New StreamWriter(Client.GetStream)
                        ''   Dim RX1 As New StreamReader(Client.GetStream)
                        TX1.WriteLine(Data)
                        TX1.Flush()
                    Next
                Catch ex As Exception
                    SendToClients(Data)
                End Try
            End If
        End If
        Return True
    End Function

    REM   Timer1 enabled = true
    REM Just if you want to always have a count of connected clients.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadDaftarTugasSQL()
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, txtBebanLoad.Text)
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormKonfigurasi.ShowDialog()
    End Sub



    Sub GetSettingDatabase()
        strServerName = My.Settings.Servername
        strLoginName = My.Settings.LoginName
        strPasswordLogin = My.Settings.PasswordName
    End Sub


    Private Sub cmdStartMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStartMonitoring.Click



        GetSettingDatabase()
        If strServerName = "" Then
            MsgBox("Konfigurasi Server Belum Diatur", vbCritical, "Konfigurasi kosong!")
            FormKonfigurasi.ShowDialog()
            Exit Sub
        End If



        If cmbListDB.Text = "" Then
            MsgBox("Pilih Database yang akan Dimonitor", vbInformation, "Informasi")
            cmbListDB.Enabled = True
            Exit Sub
        End If
        Timer1.Enabled = True
        cmbListDB.Enabled = False
    End Sub

    Private Sub cmbListDB_Click(sender As Object, e As EventArgs) Handles cmbListDB.Click
        LoadComboDaftarDB()
    End Sub



    Sub LoadDaftarTugasSQL()

        strNamaDatabase2 = cmbListDB.Text
        KoneksiDatabase2()
        Dim cmd As New SqlCommand("SELECT session_id AS Sesi,[Blk by] AS BlockedBy,host_name AS NamaClient,cpu_time,status AS StatusSesi,wait_type AS WaitType,program_name AS NamaProgram ," & _
        " [Wait M] AS DurasiTunggu,command_text AS Query," & _
        " wait_resource ," & _
        " logical_reads,reads,writes From dbo.V_MonitoringTraffic ORDER BY cpu_time DESC ", Koneksi2)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarTugas.DataSource = table
        'aturDGSAP()
        dgDaftarTugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarTugas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarTugas.AutoResizeColumns()
        Koneksi2.Close()
        txtBebanLoad.Text = dgDaftarTugas.RowCount
    End Sub

    Private Sub cmdStopMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStopMonitoring.Click
        Timer1.Enabled = False
        cmbListDB.Enabled = True
    End Sub



    Private Sub LoadComboDaftarDB()
        GetSettingDatabase()


        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT dbid,name FROM [master].[dbo].[sysdatabases]", Koneksi)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbListDB.DataSource = dt
            cmbListDB.ValueMember = "dbid"
            cmbListDB.DisplayMember = "name"
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
