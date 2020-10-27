Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblKodeCabang.Text = "Kode Cabang :" & MstrKodeDivisi
        lblNamaUser.Text = MstrNamaPegawai
        lblSiteID.Text = "Ivend Site ID :" & MstrSITEID
        lblNamaCabang.Text = MstrNamaCabang

        'WebBrowser1.Navigate("https://www.flickr.com/photos/143455489@N03/50410844042/in/photolist-2jLqctx-2jKXY8U-2jLGvPE-2jNjxM9-2jLn22s-2jLZyES-2jN1k7X-2jK6xy7-2jNCPi7-2jHH1u8-2jKPaN4-2jNCKDu-2jNZSY6-2jP6hnb-2jLM8yd-2jKRtZg-2jKsALD-2jLbBs3-2jMpgMp-2jKPbPT-2jPcgv3-2jGGr9N-2jJukwT-2jJmVpH-2jE9tLB-2jMsqc9-2jKTtxp-2jKK3qr-2jFqqYy-2jHevAB-2jHsaRp-2jEJaHp-2jPDf4u-2jPyTLt-2jHqHUG-2jH642D-2jNJ9NV-2jF76Vb-2jGKEq6-2jJ1j23-2jM53C1-2jJcHWF-2jMdBYt-2jLahS3-2jHXcNP-2j3A43d-2jNvDLg-2jDSWCq-2jMzjPG-2jE62Ud/lightbox/")

        WebBrowser1.Navigate(MstrLinkPhotoOnline)
        WebBrowser1.ScriptErrorsSuppressed = True

        timerDashboard.Start()
    End Sub


    Private Sub timerDashboard_Tick(sender As Object, e As EventArgs) Handles timerDashboard.Tick
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

    Private Sub GunaCirclePictureBox3_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox3.Click

    End Sub
End Class