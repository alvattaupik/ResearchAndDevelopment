Public Class MenuUtama

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetKontrolObject()
        txtNamaUser.Text = MstrNamaUser
        LoadDaftarSuratMenuUtama()
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Show()
            FormLogin.txtUsername.Text = ""
            FormLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaUser, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratJalanToolStripMenuItem.Click
        FormBuatSuratTerima.Show()
    End Sub

    Private Sub SuratTerimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratTerimaToolStripMenuItem.Click
        FormBuatSuratTerima.Show()
    End Sub

    Private Sub SuratTugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratTugasToolStripMenuItem.Click

    End Sub

    Private Sub SuratPengajuanBiayaPerjalananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratPengajuanBiayaPerjalananToolStripMenuItem.Click
        FormBuatSuratPengajuanBiayaPerjalananDinas.Show()
    End Sub

    Private Sub FormValidasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormValidasiToolStripMenuItem.Click

    End Sub
End Class