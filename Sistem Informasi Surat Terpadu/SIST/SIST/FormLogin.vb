Imports System.Data.SqlClient
Public Class FormLogin

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo ErrorLoad
        KoneksiDatabase1()
        Dim strSQlLogin As String

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
            GetKontrolObjek()



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

    Private Sub cmdBatal_Click(sender As Object, e As EventArgs) Handles cmdBatal.Click
        End
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click

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

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class