Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        KoneksiDatabase()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT U_NAME FROM dbo.OUSR WITH (NOLOCK) WHERE USER_CODE='" & Trim(txtUseName.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, KoneksiSQl)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strNamaUser = dr.GetString(0)
            MsgBox("Selamat Datang " & strNamaUser, vbInformation, "Login Sukses!")

            strUsernameSAP = Trim(txtUseName.Text)


            With My.Settings
                .UserName = Trim(txtUseName.Text)
                .PasswordLogin = Trim(txtPassword.Text)
                .Save()
            End With


            AnyarServices.Show()
            Me.Dispose()
            dr.Close()

        Else

            MsgBox("Username dan Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If


    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUseName.Text = My.Settings.UserName
        txtPassword.Text = My.Settings.PasswordLogin
    End Sub
End Class