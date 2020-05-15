Public Class FormBuatPeminjamanAset

    Private Sub cmbBuatBaru_Click(sender As Object, e As EventArgs) Handles cmbBuatBaru.Click
        txtCatatanUser.Text = ""
        txtNoHP.Text = ""
        txtNoSurat.Text = ""
        txtAlamatEmail.Text = ""
        txtLokasi.Text = ""
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItemsAset.ShowDialog()
    End Sub
End Class