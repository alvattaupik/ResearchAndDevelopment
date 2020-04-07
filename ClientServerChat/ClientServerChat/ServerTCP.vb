Public Class ServerTCP
    Private server As TCPcontrolClass




    Private Sub ServerTCP_Load(sender As Object, e As EventArgs) Handles Me.Load
        server = New TCPcontrolClass
        TextBox1.Text = "Server Started" & vbCrLf
        AddHandler server.MessageReceived, AddressOf OnlineReceived
    End Sub

    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)

    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
        End If
    End Sub


    Private Sub OnlineReceived(sender As TCPcontrolClass, Data As String)
        UpdateText(TextBox1, Data)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        server.isListening = False
    End Sub

    Private Sub cmdShowClient_Click(sender As Object, e As EventArgs) Handles cmdShowClient.Click
        FormClient.Show()
    End Sub
End Class