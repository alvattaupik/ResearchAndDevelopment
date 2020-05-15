Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditUsernamePassword
    Dim strA As String

    Sub LoadDataUser()
        KoneksiDatabase1()
        Dim strSQL As String
        strSQL = "SELECT * FROM dbo.UserLogin WHERE KodePegawai='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtUsername.Text = dr.GetString(2)
            txtPassword.Text = dr.GetString(3)
            dr.Close()

        Else

            dr.Close()

            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub





    Private Sub EditUsernamePassword_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtPathAplikasi.Text = My.Settings.PathPhoto

        If txtPathAplikasi.Text = "" Then
            Dim A As String
            A = ""
        Else
            GunaPictureBox1.Image = Image.FromFile(Trim(txtPathAplikasi.Text))
        End If
        LoadDataUser()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        On Error Resume Next
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathAplikasi.Text = O.FileName
            End If
        End Using
        GunaPictureBox1.Image = Image.FromFile(Trim(txtPathAplikasi.Text))

    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click


        Call KoneksiDatabase1()
        strSQL = "SELECT * FROM dbo.V_DataUser WHERE PasswordLogin='" & Trim(txtPassword.Text) & "' "
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows = True Then
            If MsgBox("Password terlalu lemah, Lanjutkan?", vbYesNo, "Konfirmasi?!") = vbYes Then
                Call KoneksiDatabase1()
                Dim str As String
                str = "Update Userlogin set UsernameLogin = '" & txtUsername.Text & "', PasswordLogin = '" & txtPassword.Text & "' where KodePegawai = '" & MstrKodeUser & "'"

                cmd = New SqlCommand(str, Koneksi1)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Update Password Berhasil Disimpan, Silahkan Logout untuk menerapkan perubahan")
                With My.Settings
                    .PathPhoto = Trim(txtPathAplikasi.Text)
                    .Save()
                End With
            End If
            Exit Sub
        Else
            Try

                Call KoneksiDatabase1()
                Dim str As String
                str = "Update Userlogin set UsernameLogin = '" & txtUsername.Text & "', PasswordLogin = '" & txtPassword.Text & "' where KodePegawai = '" & MstrKodeUser & "'"

                cmd = New SqlCommand(str, Koneksi1)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Update Password Berhasil Disimpan, Silahkan Logout untuk menerapkan perubahan")
                With My.Settings
                    .PathPhoto = Trim(txtPathAplikasi.Text)
                    .Save()
                End With



            Catch ex As Exception

                MessageBox.Show("Update Username & Password Berhasil Disimpan")

            End Try
            Exit Sub
        End If









    End Sub
End Class