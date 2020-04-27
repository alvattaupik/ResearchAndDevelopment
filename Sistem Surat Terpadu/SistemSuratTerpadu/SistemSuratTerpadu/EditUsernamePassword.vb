Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EditUsernamePassword
    Dim strA As String

    Sub LoadDataUser()
        KoneksiDatabase1()
        Dim strSQlLogin As String
        strSQlLogin = "SELECT * FROM dbo.UserLogin WHERE KodePegawai='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
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
            GunaPictureBox2.Image = Image.FromFile(Trim(txtPathAplikasi.Text))
        End If
        LoadDataUser()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click

        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathAplikasi.Text = O.FileName
            End If
        End Using
        GunaPictureBox2.Image = Image.FromFile(Trim(txtPathAplikasi.Text))

    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click


        Call KoneksiDatabase1()
        strSQlLogin = "SELECT * FROM dbo.V_DataUser WHERE UserNameLogin='" & Trim(txtUsername.Text) & "' "
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Ganti Username, Username Sudah Digunakan", vbCritical, "Warning!")
            Exit Sub
        Else
            Try

                Call KoneksiDatabase1()
                Dim str As String
                str = "Update Userlogin set UsernameLogin = '" & txtUsername.Text & "', PasswordLogin = '" & txtPassword.Text & "' where KodePegawai = '" & GlobalstrKodeUser & "'"

                cmd = New SqlCommand(str, Koneksi1)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Update Username & Password Berhasil Disimpan, Silahkan Logout untuk menerapkan perubahan")
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