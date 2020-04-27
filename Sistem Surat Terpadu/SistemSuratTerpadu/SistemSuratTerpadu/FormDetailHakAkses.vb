Imports System.Data.SqlClient
Public Class FormDetailHakAkses

    Private Sub FormDetailHakAkses_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtKodeUser.Text = FormUserLogin.txtKodeUser.Text
        txtNamaPegawai.Text = FormUserLogin.txtNamaLengkap.Text
        txtLevelUser.Text = FormUserLogin.cmbLevelUser.Text

        LoadDaftarUserSAP()
    End Sub

    Sub LoadDaftarUserSAP()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT KodeObject,NamaKomponen,StatusEnabled FROM V_ObjectUserAplikasi  WHERE KodePegawai= '" & Trim(txtKodeUser.Text) & "'", Koneksi1)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgHakAksesUser.DataSource = table
        dgHakAksesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHakAksesUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHakAksesUser.AutoResizeColumns()

    End Sub


End Class