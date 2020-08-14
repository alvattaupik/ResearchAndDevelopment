Public Class BrowseEmployee

    Private Sub BrowseEmployee_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub BrowseEmployee_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class