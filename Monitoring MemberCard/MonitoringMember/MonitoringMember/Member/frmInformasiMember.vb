Public Class frmInformasiMember

    Private Sub timerInformasiMember_Tick(sender As Object, e As EventArgs) Handles timerInformasiMember.Tick
        lblJamDigital.Text = TimeOfDay
    End Sub




    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Dispose()
            frmMainMenu.Dispose()
            frmLogin.Show()
            frmLogin.txtUsernameLogin.Text = ""
            frmLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaPegawai, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

End Class