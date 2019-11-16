Public Class frmSetting

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtSMTPName.Text = My.Settings.SMTPName
        txtHost.Text = My.Settings.HostName
        txtPort.Text = My.Settings.PortName
        chkSSL.CheckState = My.Settings.SSLStatus
        chkAuthenticate.CheckState = My.Settings.AuthenticateStatus
        txtUserName.Text = My.Settings.UsernameEmail
        txtPassword.Text = My.Settings.PasswordEmail
        txtNamaPenerima.Text = My.Settings.Penerima
        txtSender.Text = My.Settings.Sender

        txtCC.Text = My.Settings.CC
        txtSubject.Text = My.Settings.Subject
        txtBody.Text = My.Settings.Body
        txtFooter.Text = My.Settings.Footer


    End Sub

    Private Sub btSimpanSetting_Click(sender As Object, e As EventArgs) Handles btSimpanSetting.Click
        With My.Settings
            .SMTPName = TxtSMTPName.Text
            .HostName = txtHost.Text
            .PortName = txtPort.Text
            .SSLStatus = chkSSL.CheckState
            .AuthenticateStatus = chkAuthenticate.CheckState
            .UsernameEmail = txtUserName.Text
            .PasswordEmail = txtPassword.Text
            .Sender = txtSender.Text
            .Penerima = txtNamaPenerima.Text

            .CC = txtCC.Text
            .Subject = txtSubject.Text
            .Body = txtBody.Text
            .Footer = txtFooter.Text

            .Save()

            MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses!")

        End With
    End Sub
End Class