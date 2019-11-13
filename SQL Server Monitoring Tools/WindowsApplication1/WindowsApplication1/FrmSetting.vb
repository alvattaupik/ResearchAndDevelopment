Public Class FrmSetting
    Dim strStatusChecked As String

    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetLoginSetting()
        txtServerName.Text = strServerName

        If strStatusAuthentication = "1" Then
            rbSQL.Checked = True
        Else
            rbWindow.Checked = True
        End If

        txtLogin.Text = strLoginName
        txtPassword.Text = strPasswordLogin



    End Sub



    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        If rbSQL.Checked = True Then
            strStatusChecked = "1"
        Else
            strStatusChecked = "0"
        End If

        With My.Settings
            .Servername = txtServerName.Text
            .AuthenticationMode = strStatusChecked
            .LoginName = txtLogin.Text
            .PasswordName = txtPassword.Text

            .Save()

            MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses")

        End With
    End Sub
End Class