Imports System.Data.SqlClient
Public Class FormListDatabase

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        With My.Settings
            .DatabaseName = Trim(cmbListDB.Text)
            .Save()
            MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses")
            Me.Dispose()
        End With

    End Sub

    Sub LoadComboDaftarDB()

        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT dbid,name FROM [master].[dbo].[sysdatabases]", Koneksi)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbListDB.DataSource = dt
            cmbListDB.ValueMember = "dbid"
            cmbListDB.DisplayMember = "name"
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbListDB_Click(sender As Object, e As EventArgs) Handles cmbListDB.Click
        LoadComboDaftarDB()
    End Sub
End Class