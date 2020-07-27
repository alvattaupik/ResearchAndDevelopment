Public Class SettingDatabase
    Dim BolSuksesMySQL As Boolean
    Dim BolSuksesSQLSRv As Boolean
    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        strServer = txtHostMysql.Text
        strDbase = txtDBNameMysql.Text
        strUser = txtUsernameMysql.Text
        strPass = txtPasswordMySQL.Text


        strServerIntegration = txtServerSQLServer.Text
        strDbaseIntegration = txtDBNameSQLServer.Text
        strUserIntegration = txtUsernameSQLServer.Text
        strPassIntegration = txtPasswordSQlServer.Text

        connDB.Close()

        Call TestconecDBMySQL()
        Call testKoneksiSQLSERVER()


        If bolStatusKoneksiMySQL = False Then
            MsgBox("Terjadi Kesalahan Pada Koneksi MYSQL", vbCritical, "Gagal Menghubungkan!")
            Exit Sub
        End If

        If bolStatusKoneksiSQLServer = False Then
            MsgBox("Terjadi Kesalahan Pada Koneksi SQL Server", vbCritical, "Gagal Menghubungkan!")
            Exit Sub
        End If


        With My.Settings

            .MysqlHost = txtHostMysql.Text
            .DBmysql = txtDBNameMysql.Text
            .UsernameMySQL = txtUsernameMysql.Text
            .PasswordMySQL = txtPasswordMySQL.Text
            .Save()

        End With


        With My.Settings

            .SQLServer = txtServerSQLServer.Text
            .DBSqlServer = txtDBNameSQLServer.Text
            .UsernameSQLServer = txtUsernameSQLServer.Text
            .PasswordSQLServer = txtPasswordSQlServer.Text
            .Save()

        End With


        MsgBox("Konfigurasi Database Berhasil Disimpan", vbInformation, "Sukses!")
        Me.Dispose()
        Exit Sub




    End Sub

    Private Sub SettingDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDatabase()
    End Sub



    Sub LoadDatabase()

        txtHostMysql.Text = My.Settings.MysqlHost
        txtDBNameMysql.Text = My.Settings.DBmysql
        txtUsernameMysql.Text = My.Settings.UsernameMySQL
        txtPasswordMySQL.Text = My.Settings.PasswordMySQL

        txtServerSQLServer.Text = My.Settings.SQLServer
        txtDBNameSQLServer.Text = My.Settings.DBSqlServer
        txtUsernameSQLServer.Text = My.Settings.UsernameSQLServer
        txtPasswordSQlServer.Text = My.Settings.PasswordSQLServer
    End Sub

    Private Sub cmdTestLinkMysql_Click(sender As Object, e As EventArgs) Handles cmdTestLinkMysql.Click
        strServer = txtHostMysql.Text
        strDbase = txtDBNameMysql.Text
        strUser = txtUsernameMysql.Text
        strPass = txtPasswordMySQL.Text


        Call TestconecDBMySQL()


        If bolStatusKoneksiMySQL = True Then
            MsgBox("Koneksi MySQL Berhasil Terhubung", vbInformation, "Sukses !")
            connDB.Close()
            Exit Sub
        Else
            MsgBox("Gagal terhubung dengan MYSQL Periksa Parameter", vbCritical, "Gagal !")
            connDB.Close()
            Exit Sub
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strServerIntegration = txtServerSQLServer.Text
        strDbaseIntegration = txtDBNameSQLServer.Text
        strUserIntegration = txtUsernameSQLServer.Text
        strPassIntegration = txtPasswordSQlServer.Text

        Call testKoneksiSQLSERVER()



        If bolStatusKoneksiSQLServer = True Then
            MsgBox("Koneksi SQL Server Berhasil", vbInformation, "Sukses !")
            Exit Sub
        Else
            MsgBox("Gagal terhubung dengan SQL Server Periksa Parameter", vbCritical, "Gagal !")
            Exit Sub
        End If


    End Sub
End Class