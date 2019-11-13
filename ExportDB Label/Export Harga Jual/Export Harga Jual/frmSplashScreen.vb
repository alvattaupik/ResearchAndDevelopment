Public Class frmSplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 50 Then
            Timer1.Enabled = False
            Me.Hide()
            MainMenu.Show()
        End If
    End Sub
End Class