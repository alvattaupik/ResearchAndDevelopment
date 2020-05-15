Public Class FormKonfigurasiDatabase

    Private Sub cmdSimpanKonfigurasi_Click(sender As Object, e As EventArgs) Handles cmdSimpanKonfigurasi.Click

        strServer = txtNamaServer.Text
        strDbase = txtNamaDatabase.Text
        strUser = txtUsername.Text
        strPass = txtPassword.Text



        Call TestconecDB()

        If bolStatusKoneksi = True Then
            With My.Settings
                .Servername = Trim(txtNamaServer.Text)
                .Databasename = Trim(txtNamaDatabase.Text)
                .UsernameDB = Trim(txtUsername.Text)
                .PasswordDB = Trim(txtPassword.Text)
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
        txtNamaServer.Text = My.Settings.Servername
        txtNamaDatabase.Text = My.Settings.Databasename
        txtUsername.Text = My.Settings.UsernameDB
        txtPassword.Text = My.Settings.PasswordDB
    End Sub
End Class