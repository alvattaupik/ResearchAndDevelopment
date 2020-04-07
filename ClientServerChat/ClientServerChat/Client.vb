Public Class FormClient

    Private client As TCPcontroller
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtKirim.Click
        SendMessage()
        txtPesan.Clear()
        txtPesan.Focus()
    End Sub

    Private Sub SendMessage()

        If client.client.Connected = True Then client.send(txtPesan.Text)

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If client.client.Connected = True Then
            client.clientData.Close()
            client.client.Close()
        End If
        ' lets try it

        ' you see?
        ' No connection could be made because the target machine actively refused it
        ' you must open your server before connect the client
        ' lets open the server

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        client = New TCPcontroller(Trim(txtServer.Text), 8080) ' ITS FOR YOUR SERVER IP ADDRESS AND PORT NUMBER
        If client.client.Connected Then lblStatus.Text = "Connected !!!"
    End Sub
End Class