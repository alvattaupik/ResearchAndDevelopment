Imports System.Data.SqlClient
Public Class FormLogin
    Dim strSQlLogin As String

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        On Error GoTo ErrorLoad

        If My.Settings.ServerName = "" Then
            MsgBox("Setting Database Belum Di Atur", vbCritical, "Warning!")
            FormKoneksiDatabase.ShowDialog()
            Exit Sub
        End If


        KoneksiDatabase1()
        strSQlLogin = "SELECT Top 1 * FROM dbo.CustomMessage WHERE KdAplikasi='BCP' AND StatusEnabled='1'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            MsgBox("Penting! " & vbCrLf & "Kategori :" & dr.GetString(2) & vbCrLf & "Pesan :" & dr.GetString(3), vbInformation)

            Exit Sub
        Else
            GoTo Lanjut
        End If


Lanjut:



        KoneksiDatabase1()


        strSQlLogin = "SELECT * From UserLogin WHERE UserNameLogin='" & Trim(txtUsername.Text) & "' AND PasswordLogin ='" & Trim(txtPassword.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            MstrKodeUser = dr.GetString(0)
            MstrNamaUser = dr.GetString(1)
            MstrKodeDivisi = dr.GetString(6)
            MstrNamaDivisi = dr.GetString(7)

            MstrLevelUser = dr.GetString(5)
            MstrKdSupervisor = dr.GetString(8)
            MstrSupervisor = dr.GetString(9)

            MainMenu.Show()
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

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            txtPassword.Focus()
        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            cmdLogin.PerformClick()
        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click

    End Sub
End Class