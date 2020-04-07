Public Class MainMenu

    Private Sub GunaImageButton2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        End
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        'FormDashboard.Show()
        Form1.Show()
    End Sub
End Class