Public Class FormKonfigurasiIntegrasi

    Private Sub cmdSimpanKonfigurasi_Click(sender As Object, e As EventArgs) Handles cmdSimpanKonfigurasi.Click

        strServerIntegration = txtNamaServer.Text
        strDbaseIntegration = txtNamaDatabase.Text
        strUserIntegration = txtUsername.Text
        strPassIntegration = txtPassword.Text

        With My.Settings
            .ServerNameIntegrasi = Trim(txtNamaServer.Text)
            .DatabasenameIntegrasi = Trim(txtNamaDatabase.Text)
            .UsernameDBIntegrasi = Trim(txtUsername.Text)
            .PasswordDBIntegrasi = Trim(txtPassword.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With



        Call KoneksiDatabaseSQLSERVER()

        If bolStatusKoneksi = True Then
            With My.Settings
                .ServerNameIntegrasi = Trim(txtNamaServer.Text)
                .DatabasenameIntegrasi = Trim(txtNamaDatabase.Text)
                .UsernameDBIntegrasi = Trim(txtUsername.Text)
                .PasswordDBIntegrasi = Trim(txtPassword.Text)
                MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
                .Save()
            End With
            Me.Close()
            FormLogin.Show()
        Else
            MsgBox("Terjadi Kesalahan Saat Menghubungkan Database", MsgBoxStyle.Critical, "Periksa parameter!")
            Exit Sub
        End If





    End Sub

    Private Sub FormKonfigurasiDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNamaServer.Text = My.Settings.ServerNameIntegrasi
        txtNamaDatabase.Text = My.Settings.DatabasenameIntegrasi
        txtUsername.Text = My.Settings.UsernameDBIntegrasi
        txtPassword.Text = My.Settings.PasswordDBIntegrasi
    End Sub
End Class