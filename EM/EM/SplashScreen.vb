Public Class frmSplashScreen



    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Timer1.Enabled = True
        'If GunaCircleProgressBar1.Value = 1000 Then
        '    Timer1.Enabled = False
        '    Me.Hide()
        '    FormLogin.Show()
        'Else
        '    GunaCircleProgressBar1.Value += 10
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If GunaCircleProgressBar1.Value < 100 Then
            GunaCircleProgressBar1.Value += 3
        ElseIf GunaCircleProgressBar1.Value = 100 Then
            Timer1.Stop()
            FormLogin.Show()
            Me.Hide()
        End If

    End Sub
End Class
