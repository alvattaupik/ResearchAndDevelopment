Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormSettingMonitoringDatabase

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        strServer2 = Trim(txtServerName.Text)
        strNamaDatabase2 = Trim(txtDatabaseName.Text)
        strUserNameDB2 = Trim(txtUserNameDB.Text)
        strPasswordDB2 = Trim(txtPasswordDB.Text)



        Call CekKoneksiDatabase()

        If bolStatusKoneksi = True Then
            With My.Settings
                .ServerNameDB = Trim(txtServerName.Text)
                .UsernameDB = Trim(txtUserNameDB.Text)
                .PasswordDB = Trim(txtPasswordDB.Text)
                .DatabaseName = Trim(txtDatabaseName.Text)
                .Save()
            End With

            MsgBox("Koneksi Berhasil Terhubung", vbInformation, "Sukses!")
            Me.Dispose()
            Exit Sub

        Else
            MsgBox("Kesalahan Dalam Menghubungkan Database, Silahkan Cek Parameter", vbCritical, "Gagal Menghubungkan!")
            Exit Sub

        End If

    End Sub

    Private Sub FormSettingMonitoringDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtServerName.Text = My.Settings.ServerNameDB
        txtUserNameDB.Text = My.Settings.UsernameDB
        txtPasswordDB.Text = My.Settings.PasswordDB
        txtDatabaseName.Text = My.Settings.DatabaseName


    End Sub


End Class