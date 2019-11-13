Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmUtama.Show()
        ElseIf ProgressBar1.Value = 70 Then
            lblStarting.Visible = True
        End If
    End Sub
End Class