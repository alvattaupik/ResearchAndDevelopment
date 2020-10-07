Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmLogin
    Dim strSQlLogin As String

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsernameLogin.KeyPress
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
            btnLogin.PerformClick()
        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        MessageBoxWarningOkGunaUI(txtUsernameLogin, "Username Harus Di Isi !")
        MessageBoxWarningOkGunaUI(txtPassword, "Username Harus Di Isi !")
        If mBolFunction = True Then Exit Sub



        CekLogin()
        If MstrKodePegawai = "" And MstrNamaPegawai = "" Then
            MsgBox("Data Login Tidak Ditemukan", MsgBoxStyle.Critical, "Periksa Username dan Password")
            Exit Sub
        Else
            If MstrStatusAktifUser = "" Then
                MsgBox("Anda Tidak Memiliki Akses Aplikasi Ini", MsgBoxStyle.Critical, "Hubungi IT")
                Exit Sub
            Else

                MstrUsernameLogin = Trim(txtUsernameLogin.Text)
                frmMainMenu.Show()
                Me.Hide()

            End If

        End If

        



      

    End Sub




    Sub CekLogin()

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("tmsp_Login", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("UserNameLogin", Trim(txtUsernameLogin.Text))
            command.Parameters.AddWithValue("PasswordLogin", Trim(txtPassword.Text))
            command.Parameters.Add("KodePegawai", SqlDbType.VarChar, 50)
            command.Parameters("KodePegawai").Direction = ParameterDirection.Output
            command.Parameters.Add("NamaPegawai", SqlDbType.VarChar, 50)
            command.Parameters("NamaPegawai").Direction = ParameterDirection.Output
            command.Parameters.Add("KodeDivisi", SqlDbType.VarChar, 50)
            command.Parameters("KodeDivisi").Direction = ParameterDirection.Output
            command.Parameters.Add("KodeSupervisor", SqlDbType.VarChar, 50)
            command.Parameters("KodeSupervisor").Direction = ParameterDirection.Output
            command.Parameters.Add("NamaSupervisor", SqlDbType.VarChar, 50)
            command.Parameters("NamaSupervisor").Direction = ParameterDirection.Output
            command.Parameters.Add("KodeLevelUser", SqlDbType.VarChar, 50)
            command.Parameters("KodeLevelUser").Direction = ParameterDirection.Output
            command.Parameters.Add("StatusAktifUser", SqlDbType.VarChar, 50)
            command.Parameters("StatusAktifUser").Direction = ParameterDirection.Output
            command.Parameters.Add("PriceListHJ", SqlDbType.VarChar, 50)
            command.Parameters("PriceListHJ").Direction = ParameterDirection.Output
            command.Parameters.Add("PriceListHB", SqlDbType.VarChar, 50)
            command.Parameters("PriceListHB").Direction = ParameterDirection.Output
            command.Parameters.Add("SiteID", SqlDbType.VarChar, 50)
            command.Parameters("SiteID").Direction = ParameterDirection.Output
            command.Parameters.Add("NamaCabang", SqlDbType.VarChar, 50)
            command.Parameters("NamaCabang").Direction = ParameterDirection.Output
            command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
            command.Parameters.AddWithValue("Function", Trim("GetDataLogin"))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()
            MstrKodePegawai = command.Parameters("KodePegawai").Value.ToString()
            MstrNamaPegawai = command.Parameters("NamaPegawai").Value.ToString()
            MstrKodeDivisi = command.Parameters("KodeDivisi").Value.ToString()
            MstrKodeSPV = command.Parameters("KodeSupervisor").Value.ToString()
            MstrNamaSPV = command.Parameters("NamaSupervisor").Value.ToString()
            MstrStatusAktifUser = command.Parameters("StatusAktifUser").Value.ToString()
            MstrLevelUser = command.Parameters("KodeLevelUser").Value.ToString()
            MstrPriceListHj = command.Parameters("PriceListHJ").Value.ToString()
            MstrPriceListHB = command.Parameters("PriceListHB").Value.ToString()
            MstrSITEID = command.Parameters("SiteID").Value.ToString()
            MstrNamaCabang = command.Parameters("NamaCabang").Value.ToString()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


 

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsernameLogin.SetOnGotFocus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class