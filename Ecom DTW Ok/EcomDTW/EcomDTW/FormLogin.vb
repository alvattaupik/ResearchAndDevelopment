Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Public Class FormLogin

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        connDB.Close()


        If My.Settings.MysqlHost = "" Or My.Settings.SQLServer = "" Then
            MsgBox("Konfigurasi Database Belum Diatur", vbCritical, "Gagal menghubungkan!")
            SettingDatabase.ShowDialog()
            Exit Sub
        End If

        conecDB()

        Try

            SQL = "SELECT Name from users WHERE username =  '" & txtUsername.Text & "' AND password ='" & txtPassword.Text & "'"

            initCMD()
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()
            If rdDB.HasRows = True Then
                Me.Hide()
                FormMainMenu.ShowDialog()
                'MstrKdPegawai = rdDB!id.ToString.Trim
            Else
                MsgBox("Username and or Password are not found", MsgBoxStyle.Exclamation, "Information")
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Select()
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try






    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        SettingDatabase.Show()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        If strServer = "" Then
            MsgBox("Konfigurasi Database Belum Diatur", vbCritical, "Warning!")
            Me.Close()
            SettingDatabase.Show()
            Exit Sub
        End If
    End Sub

    Private Sub cmdBatal_Click(sender As Object, e As EventArgs) Handles cmdBatal.Click
        End
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'FormKonfigurasiIntegrasi.ShowDialog()
        SettingDatabase.ShowDialog()
    End Sub
End Class