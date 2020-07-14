Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Profile
    Dim strA As String
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        On Error Resume Next
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathPhoto.Text = O.FileName
            End If
        End Using
        GunaPictureBox1.Image = Image.FromFile(Trim(txtPathPhoto.Text))
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPathPhoto.Text = My.Settings.PathPhoto

        If txtPathPhoto.Text = "" Then
            Dim A As String
            A = ""
        Else
            GunaPictureBox1.Image = Image.FromFile(Trim(txtPathPhoto.Text))
        End If
        LoadDataUser()
    End Sub

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click


        Call KoneksiDatabase1()
        Dim str As String
        str = "Update Userlogin set  PasswordLogin = '" & txtPassword.Text & "' where KodePegawai = '" & MstrKodeUser & "'"

        cmd = New SqlCommand(str, Koneksi1)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Update Password Berhasil Disimpan, Silahkan Logout untuk menerapkan perubahan")
        With My.Settings
            .PathPhoto = Trim(txtPathPhoto.Text)
            .Save()
        End With
        Try

        Catch ex As Exception

            MessageBox.Show(Err.Description)
            Exit Sub

        End Try



    End Sub
End Class