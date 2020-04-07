
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Public Class TCPcontrolClass

    Public Event MessageReceived(sender As TCPcontrolClass, Data As String)

    'SERVER CONFIGURATIONS
    Public serverIP As IPAddress = IPAddress.Parse("10.1.1.31")
    Public serverPORT As Integer = 8080
    Public server As TcpListener

    Private comThread As Thread
    Public isListening As Boolean = True

    ' CLIENT CONFIGURATIONS
    Private client As TcpClient
    Private clientData As StreamReader

    Public Sub New()
        server = New TcpListener(serverIP, serverPORT)
        server.Start()
        comThread = New Thread(New ThreadStart(AddressOf Listening))
        comThread.Start()
    End Sub

    Private Sub Listening()
        'CREATE LISTENER LOOP
        Do Until isListening = False
            'ACCEPT INCOMING CONNECTION
            If server.Pending = True Then
                client = server.AcceptTcpClient
                clientData = New StreamReader(client.GetStream)
            End If
            ' RAISE EVENT FOR INCOMING MESSAGE
            Try
                RaiseEvent MessageReceived(Me, "[ " & DateTime.Now() & " ] " & clientData.ReadLine)
            Catch ex As Exception

            End Try
            ' REDUCE CPU USAGE
            Thread.Sleep(100)
        Loop
    End Sub
End Class
