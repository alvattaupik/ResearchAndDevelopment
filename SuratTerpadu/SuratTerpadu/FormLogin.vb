Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormLogin

    Private Sub cmdBatal_Click(sender As Object, e As EventArgs) Handles cmdBatal.Click
        End
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click

        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT * From UserLogin WHERE UserNameLogin='" & Trim(txtUsername.Text) & "' AND PasswordLogin ='" & Trim(txtPassword.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            GlobalstrKodeUser = dr.GetString(0)
            GlobalstrNamaUser = dr.GetString(1)
            GlobalstrKodeDivisi = dr.GetString(6)
            GlobalstrNamaDivisi = dr.GetString(7)
            GlobalstrSupervisor = dr.GetString(8)

            MenuUtama.Show()
            Me.Dispose()
            dr.Close()

        Else

            MsgBox("Username dan Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

        MsgBox("Selamat Datang " & GlobalstrNamaUser, vbInformation, "Login Sukses!")

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



End Class