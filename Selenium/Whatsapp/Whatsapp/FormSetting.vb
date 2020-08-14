Public Class FormSetting

    Private Sub btnSimpanSetting_Click(sender As Object, e As EventArgs) Handles btnSimpanSetting.Click

        If txtInterval.Text = "" Then
            MsgBox("Durasi Interval Harus DI Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        If cmbSatuanInterval.Text = "" Then
            MsgBox("Satuan Interval Harus DI Isi", vbCritical, "Penting !")
            Exit Sub
        End If


        With My.Settings

            .Server = txtServerName.Text
            .DatabaseName = txtDabataseName.Text
            .UserNameDB = txtUsername.Text
            .PasswordDB = txtPassword.Text

            .DurasiInterval = txtInterval.Text
            .Delay1 = txtDelay1.Text
            .Delay2 = txtDelay2.Text

            .SatuanInterval = cmbSatuanInterval.Text
            .Save()
            MsgBox("Konfigurasi Aplikasi Berhasil Disimpan", vbInformation, "Sukses!")

        End With



    End Sub

    Private Sub btnKoneksiDatabase_Click(sender As Object, e As EventArgs) Handles btnKoneksiDatabase.Click
        Call testKoneksiSQLSERVER()


        If bolStatusKoneksiSQLServer = True Then

            With My.Settings

                .Server = txtServerName.Text
                .DatabaseName = txtDabataseName.Text
                .UserNameDB = txtUsername.Text
                .PasswordDB = txtPassword.Text

                .DurasiInterval = txtInterval.Text
                .Delay1 = txtDelay1.Text
                .Delay2 = txtDelay2.Text

                .SatuanInterval = cmbSatuanInterval.Text
                .Save()
                MsgBox("Konfigurasi Database Berhasil Disimpan", vbInformation, "Sukses!")
            End With

        Else

            MsgBox("Kesalahan Pada Parameter Setting Database", vbCritical, "Error!")
            Exit Sub

        End If

    End Sub

    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtServerName.Text = My.Settings.Server
        txtDabataseName.Text = My.Settings.DatabaseName
        txtUsername.Text = My.Settings.UserNameDB
        txtPassword.Text = My.Settings.PasswordDB


        txtInterval.Text = My.Settings.DurasiInterval
        cmbSatuanInterval.Text = My.Settings.SatuanInterval
        txtDelay1.Text = My.Settings.Delay1
        txtDelay2.Text = My.Settings.Delay2

    End Sub
End Class