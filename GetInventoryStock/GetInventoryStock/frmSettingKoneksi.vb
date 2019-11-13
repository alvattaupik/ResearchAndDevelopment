Imports System.Data.SqlClient

Public Class frmSettingKoneksi
    Sub sett()
        Call conn_get()
        txtServer.Text = conn_server
        txtUsername.Text = conn_user
        txtPassword.Text = conn_pass
        txtdatabase.Text = conn_database

    End Sub
    Sub tampilDataComboBox()
        'If koneksi() = True Then
        '    Dim str As String
        '    str = "SELECT name FROM master.sys.databases"
        '    Dim cmd As New SqlCommand(str, conn)
        '    cmd = New SqlCommand(str, conn)
        '    Dim rs As SqlDataReader

        '    rs = cmd.ExecuteReader

        '    If rs.HasRows Then
        '        Do While rs.HasRows
        '            cmbListDataBase.Items.Add(rs("name"))
        '        Loop
        '    Else
        '    End If
        'End If
    End Sub
    Private Sub frmSettingKoneksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call sett()
    End Sub


    Private Sub txtCancel_Click(sender As Object, e As EventArgs) Handles txtCancel.Click
        Call sett()
        Me.Close()
    End Sub


    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        Call conn_save(txtServer.Text, txtUsername.Text, txtPassword.Text, txtdatabase.Text)
        Call koneksi()
        If bolStatus = True Then
            MsgBox("Konfigurasi Gagal Tersimpan!")
        Else
            MsgBox("Konfigurasi Koneksi Tersimpan!")
        End If

        Me.Close()
        'frmLogin.Show()
    End Sub


    Private Sub cmdTestkoneksi_Click(sender As Object, e As EventArgs)
        tempstrconn_server = Trim(txtServer.Text)
        tempstrconn_user = Trim(txtUsername.Text)
        tempstrconn_pass = Trim(txtPassword.Text)
        tempstrconn_database = Trim(txtdatabase.Text)
        Call Testkoneksi()
    End Sub

    Private Sub cmbListDataBase_Click(sender As Object, e As EventArgs)
        Call tampilDataComboBox()
    End Sub


    Private Sub cmbListDataBase_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSettingKoneksi_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate

    End Sub
End Class
