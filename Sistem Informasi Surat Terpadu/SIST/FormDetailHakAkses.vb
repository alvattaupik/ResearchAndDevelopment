Imports System.Data.SqlClient
Public Class FormDetailHakAkses

    Private Sub FormDetailHakAkses_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtKodeUser.Text = FormDataUser.txtKodeUser.Text
        txtNamaPegawai.Text = FormDataUser.txtNamaLengkap.Text
        txtLevelUser.Text = FormDataUser.cmbLevelUser.Text

        LoadDaftarHakAkses()
    End Sub

    Sub LoadDaftarHakAkses()
        On Error Resume Next
        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT KodeObject,NamaKomponen,StatusEnabled FROM V_ObjectUserAplikasi  WHERE KodePegawai= '" & Trim(txtKodeUser.Text) & "' Order By KodeObject ", Koneksi1)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgHakAksesUser.DataSource = table
        dgHakAksesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHakAksesUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHakAksesUser.AutoResizeColumns()

    End Sub


    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        For i As Integer = 0 To dgHakAksesUser.Rows.Count - 1

            Call KoneksiDatabase1()
            Dim cmd1 As New SqlCommand
            cmd1.CommandText = "[U_AksesUser]"
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Parameters.AddWithValue("KodePegawai", txtKodeUser.Text)
            cmd1.Parameters.AddWithValue("KodeObject", dgHakAksesUser.Rows(i).Cells(0).Value)
            cmd1.Parameters.AddWithValue("StatusEnabled", dgHakAksesUser.Rows(i).Cells(2).Value)
            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd1.Connection = Koneksi1
            Koneksi1.Open()
            cmd1.ExecuteNonQuery()

        Next
        Koneksi1.Close()
        LoadDaftarHakAkses()
        Exit Sub
    End Sub

    Private Sub cmdPerbaharui_Click(sender As Object, e As EventArgs) Handles cmdPerbaharui.Click

        Call KoneksiDatabase1()
        Dim cmd1 As New SqlCommand
        cmd1.CommandText = "[Update_AksesUser]"
        cmd1.CommandType = CommandType.StoredProcedure
        cmd1.Parameters.AddWithValue("KodePegawai", txtKodeUser.Text)
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd1.Connection = Koneksi1
        Koneksi1.Open()
        cmd1.ExecuteNonQuery()
        Koneksi1.Close()
        LoadDaftarHakAkses()


    End Sub
End Class