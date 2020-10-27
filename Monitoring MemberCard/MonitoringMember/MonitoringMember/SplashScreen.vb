Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim intJumlah As Integer

        intJumlah = 0

        If intJumlah = 1000 Then
            intJumlah += 1
        Else
            Timer1.Stop()
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class
