Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Public Class FormLogin

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click









        conecDB()

        Try
            SQL = "SELECT * from users WHERE username =  '" & txtUsername.Text & "' AND password ='" & txtPassword.Text & "'"

            initCMD()
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()
            If rdDB.HasRows = True Then
                Me.Hide()
                FormUpload.Show()
                MstrKdPegawai = rdDB!id.ToString.Trim
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









        'KoneksiDatabase1()
        'Dim strSQlLogin As String

        'Try
        '    If Koneksi1.State = ConnectionState.Closed Then Koneksi1.Open()
        '    strSQlLogin = "SELECT * From Users WHERE Username='" & Trim(txtUsername.Text) & "' AND password ='" & Trim(txtPassword.Text) & "'"
        '    With cmd
        '        .CommandText = strSQlLogin
        '        .ExecuteNonQuery()
        '    End With

        '    dr = cmd.ExecuteReader
        '    dr.Read()
        '    If dr.HasRows = True Then
        '        Me.Hide()
        '        Form1.Show()
        '        MstrKdPegawai = dr!username.ToString.Trim
        '        MstrNamaPegawai = dr!name.ToString.Trim


        '    Else
        '        MsgBox("Username atau Password Salah!", MsgBoxStyle.Exclamation, "Information")
        '        txtUsername.Text = ""
        '        txtPassword.Text = ""
        '        txtUsername.Select()
        '    End If
        '    dr.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


















    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        FormKonfigurasiDatabase.Show()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        If strServer = "" Then
            MsgBox("Konfigurasi Database Belum Diatur", vbCritical, "Warning!")
            Me.Close()
            FormKonfigurasiDatabase.Show()
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
        FormKonfigurasiIntegrasi.ShowDialog()
    End Sub
End Class