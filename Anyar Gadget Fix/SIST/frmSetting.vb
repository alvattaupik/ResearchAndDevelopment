Imports System.Data.SqlClient
Public Class frmSetting

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load



    End Sub

    Private Sub btSimpanSetting_Click(sender As Object, e As EventArgs) Handles btSimpanSetting.Click

        MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses")


    End Sub



    Sub LoadSettingEmail()
        On Error GoTo ErrorLoad
        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT Top 1 * FROM dbo.SettingEmail"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            TxtSMTPName.Text = dr.GetString(0)
            txtHost.Text = dr.GetString(1)
            txtPort.Text = dr.GetString(2)
            chkSSL.CheckState = dr.GetString(3)
            chkAuthenticate.CheckState = dr.GetString(4)
            txtUserName.Text = dr.GetString(5)
            txtPassword.Text = dr.GetString(6)
            txtSubject.Text = dr.GetString(7)
            txtHeader.Text = dr.GetString(8)




            MenuUtama.Show()
            Me.Dispose()
            dr.Close()

        Else

            MsgBox("Username dan Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

        MsgBox("Selamat Datang " & MstrNamaUser, vbInformation, "Login Sukses!")

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


End Class