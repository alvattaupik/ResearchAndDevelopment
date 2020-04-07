Public Class SplashScreenDTW

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim intJumlah As Integer

        intJumlah = 0

        If intJumlah = 1000 Then
            intJumlah += 1
        Else
            Timer1.Stop()
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub SplashScreenDTW_Load(sender As Object, e As EventArgs) Handles Me.Load
        strServer = My.Settings.Servername
        strDbase = My.Settings.Databasename
        strUser = My.Settings.UsernameDB
        strPass = My.Settings.PasswordDB
    End Sub



End Class