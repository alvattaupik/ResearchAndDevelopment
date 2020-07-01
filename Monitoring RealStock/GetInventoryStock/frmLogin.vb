Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub cmdCancelUser_Click(sender As Object, e As EventArgs) Handles cmdCancelUser.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmSettingKoneksi.Show()
    End Sub

    Private Sub cmdLoginUser_Click(sender As Object, e As EventArgs) Handles cmdLoginUser.Click
        strStatusForm = "Form Login"
        Call Cekkelengkapan()
        If bolStatus = True Then
            Exit Sub
        End If
        Try
            Call conn_get()
            If koneksi() = True Then
                Dim sql As String = "SELECT * FROM LoginUser WHERE Username='" & txtUsernameLogin.Text & "' AND Password='" & txtPasswordLogin.Text & "' "
                Dim cmd As New SqlCommand(sql, conn)
                Dim rs As SqlDataReader
                rs = cmd.ExecuteReader

                If rs.Read Then
                    rs.Close()
                    cmd.Dispose()
                    Me.Hide()
                    MsgBox("Selamat Datang", MsgBoxStyle.Information, "Login Success")
                    MainWindows.Show()
                Else
                    MsgBox("Wrong ID/Password!", MsgBoxStyle.Critical, "ERROR")
                    rs.Close()
                    cmd.Dispose()
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cekkelengkapan()
        If txtUsernameLogin.Text = "" Then
            bolStatus = 1
            MsgBox("Username Tidak boleh Kosong!", MsgBoxStyle.Critical, "Not Allow Null")
            txtUsernameLogin.BackColor = Color.Red
            Exit Sub
        Else
            bolStatus = 0
            txtUsernameLogin.BackColor = Color.White
        End If

        If txtPasswordLogin.Text = "" Then
            bolStatus = 1
            MsgBox("Password Tidak boleh Kosong!", MsgBoxStyle.Critical, "Not Allow Null")
            txtPasswordLogin.BackColor = Color.Red
            Exit Sub
        Else
            bolStatus = 0
            txtPasswordLogin.BackColor = Color.White
        End If

    End Sub

End Class