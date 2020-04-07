Public Class FormBeritaAcaraPenyelesaian

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        FormBusinessPartner.ShowDialog()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItems.ShowDialog()
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click

    End Sub

    Private Sub FormBeritaAcaraPenyelesaian_Load(sender As Object, e As EventArgs) Handles Me.Load
        GlobalstrKodeJenisSurat = "IT001"
    End Sub
End Class