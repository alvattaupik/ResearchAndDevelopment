Public Class FormKonfigurasi

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        With My.Settings
            .Servername = txtServerName.Text
            .LoginName = txtLogin.Text
            .PasswordName = txtPassword.Text
            .Save()

            MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses")

        End With
    End Sub
End Class