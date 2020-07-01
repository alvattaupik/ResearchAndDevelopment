Public Class FormKoneksiDatabase

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If cmbDatabase.Text = "" Then
            MsgBox("Nama Database Harus Dipilih!", vbInformation, "Informasi!")
            Exit Sub
        End If


        strServer2 = Trim(txtServer.Text)
        strUserNameDB2 = Trim(txtUsername.Text)
        strPasswordDB2 = Trim(txtPassword.Text)
        strNamaDatabase2 = Trim(cmbDatabase.Text)


        Call CekKoneksiDatabase()

        If bolStatusKoneksi = True Then
            With My.Settings
                .ServerName = Trim(txtServer.Text)
                .UsernameDatabase = Trim(txtUsername.Text)
                .PasswordDatabase = Trim(txtPassword.Text)
                .NamaDatabase = Trim(cmbDatabase.Text)
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

    Private Sub FormKoneksiDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtServer.Text = My.Settings.ServerName
        txtPassword.Text = My.Settings.PasswordDatabase
        txtUsername.Text = My.Settings.UsernameDatabase
        cmbDatabase.Text = My.Settings.NamaDatabase
    End Sub



    Private Sub cmdTutup_Click(sender As Object, e As EventArgs) Handles cmdTutup.Click
        Me.Dispose()
    End Sub

    Private Sub cmbDatabase_Click(sender As Object, e As EventArgs) Handles cmbDatabase.Click
        LoadComboBox1(cmbDatabase, "Select database_id,name from Sys.Databases", "database_id", "name")
    End Sub
End Class