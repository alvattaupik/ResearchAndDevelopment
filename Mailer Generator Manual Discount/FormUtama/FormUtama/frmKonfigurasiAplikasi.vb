Public Class frmKonfigurasiAplikasi

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtNamaDatabaseUtama.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub



    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        With My.Settings
            .IPDBUtama = Trim(txtLokasiDatabaseUtama.Text)
            .IPDBEmail = Trim(txtLokasiDBEmail.Text)

            .NamaDBUtama = Trim(txtNamaDatabaseUtama.Text)
            .NamaDBEmail = Trim(txtNamaDBEmail.Text)

            .UsernameDBUtama = Trim(txtusernameDBUtama.Text)
            .UsernameDBEmail = Trim(txtUsernameDBemail.Text)

            .PasswordDBUtama = Trim(txtPasswordDatabaseUtama.Text)
            .PasswordDBEmail = Trim(txtPasswordDBEmail.Text)

            .LokasiExport = Trim(txtLokasiExport.Text)
            .DelayTime = txtDurasiDelay.Text
            .TestMode = Trim(txtTestMode.Text)

            .Save()
            MsgBox("Konfigurasi berhasil disimpan", vbInformation, "Sukses!")

        End With
    End Sub

    Private Sub frmKonfigurasiAplikasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetAppandbehaviourSetting()
        txtLokasiDatabaseUtama.Text = strLokasiDatabaseUtama
        txtNamaDatabaseUtama.Text = strNamaDatabaseUtama
        txtusernameDBUtama.Text = strUsernameDatabaseUtama
        txtPasswordDatabaseUtama.Text = strPasswordDatabaseUtama


        txtLokasiDBEmail.Text = strLokasiDBEmail
        txtNamaDBEmail.Text = strNamaDatabaseEmail
        txtUsernameDBemail.Text = strusernameDatabaseEmail
        txtPasswordDBEmail.Text = strPassswordDatabaseEmail


        txtLokasiExport.Text = strLokasiExport
        txtDurasiDelay.Text = strDurasiDelay
        txtTestMode.Text = strStatusTestmode

    End Sub

    Private Sub cmdbrowseLokasi_Click(sender As Object, e As EventArgs) Handles cmdbrowseLokasi.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtLokasiExport.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub cmdSimpandanRestart_Click(sender As Object, e As EventArgs) Handles cmdSimpandanRestart.Click
        With My.Settings
            .IPDBUtama = Trim(txtLokasiDatabaseUtama.Text)
            .IPDBEmail = Trim(txtLokasiDBEmail.Text)

            .NamaDBUtama = Trim(txtNamaDatabaseUtama.Text)
            .NamaDBEmail = Trim(txtNamaDBEmail.Text)

            .UsernameDBUtama = Trim(txtusernameDBUtama.Text)
            .UsernameDBEmail = Trim(txtUsernameDBemail.Text)

            .PasswordDBUtama = Trim(txtPasswordDatabaseUtama.Text)
            .PasswordDBEmail = Trim(txtPasswordDBEmail.Text)

            .LokasiExport = Trim(txtLokasiExport.Text)
            .DelayTime = Trim(txtDurasiDelay.Text)
            .TestMode = Trim(txtTestMode.Text)
            .Save()
            MsgBox("Konfigurasi berhasil disimpan", vbInformation, "Sukses!")
            Me.Dispose()
            GetEmailSetting()
            GetAppandbehaviourSetting()
        End With
    End Sub

    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        Me.Dispose()
        GetEmailSetting()
        GetAppandbehaviourSetting()
    End Sub

    Private Sub txtDurasiDelay_TextChanged(sender As Object, e As EventArgs) Handles txtDurasiDelay.TextChanged

    End Sub
End Class