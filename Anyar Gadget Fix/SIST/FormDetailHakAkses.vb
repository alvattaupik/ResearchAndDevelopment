Imports System.Data.SqlClient
Public Class FormDetailHakAkses
    Dim source1 As New BindingSource()
    Private Sub FormDetailHakAkses_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtKodeUser.Text = FormUserLoginDanHakAkses.txtKodeUser.Text
        txtNamaPegawai.Text = FormUserLoginDanHakAkses.txtNamaLengkap.Text
        txtLevelUser.Text = FormUserLoginDanHakAkses.cmbLevelUser.Text
        LoadDaftarHakAkses()
        dgHakAksesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHakAksesUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHakAksesUser.AutoResizeColumns()
    End Sub

    Sub LoadDaftarHakAkses()
        On Error Resume Next


        dgHakAksesUser.DataSource = Nothing
        dgHakAksesUser.Rows.Clear()
        dgHakAksesUser.Columns.Clear()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT Distinct KodeObject,NamaKomponen,StatusEnabled FROM V_ObjectUserAnyarGadget  WHERE KodePegawai= '" & Trim(txtKodeUser.Text) & "' AND NamaKomponen Like '%" & txtCariHakAkses.Text & "%' Order By KodeObject ", Koneksi1)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgHakAksesUser.Columns.Add("KodeObject", "KodeObject")
        dgHakAksesUser.Columns.Add("NamaKomponen", "NamaKomponen")
        Dim chk As New DataGridViewCheckBoxColumn()
        dgHakAksesUser.Columns.Add(chk)
        chk.HeaderText = "Aktif"
        chk.Name = "Aktif"

        chk.TrueValue = "1"
        chk.FalseValue = "0"


        With table
            For i = 0 To table.Rows.Count - 1
                'If .Rows(i).Item(1).ToString() = "1" Then
                '    Dim A As String = "True"
                'Else
                '    Dim B As String = "False"
                dgHakAksesUser.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
            Next


        End With




    End Sub


    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        For i As Integer = 0 To dgHakAksesUser.Rows.Count - 1

            Call KoneksiDatabase1()
            Dim cmd1 As New SqlCommand
            cmd1.CommandText = "[U_AksesUser]"
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Parameters.AddWithValue("KodePegawai", txtKodeUser.Text)
            cmd1.Parameters.AddWithValue("KodeObject", dgHakAksesUser.Rows(i).Cells(0).Value)
            cmd1.Parameters.AddWithValue("KodeAplikasi", "AG")
            cmd1.Parameters.AddWithValue("StatusEnabled", dgHakAksesUser.Rows(i).Cells(2).Value)
            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd1.Connection = Koneksi1
            Koneksi1.Open()
            cmd1.ExecuteNonQuery()

        Next
        Koneksi1.Close()
        LoadDaftarHakAkses()
        MsgBox("Hak Akses Berhasil diperbaharui", vbInformation, "Sukses!")
        Exit Sub
    End Sub

    Private Sub cmdPerbaharui_Click(sender As Object, e As EventArgs) Handles cmdPerbaharui.Click

        Call KoneksiDatabase1()
        Dim cmd1 As New SqlCommand
        cmd1.CommandText = "[Update_AksesUser]"
        cmd1.CommandType = CommandType.StoredProcedure
        cmd1.Parameters.AddWithValue("KodePegawai", txtKodeUser.Text)
        cmd1.Parameters.AddWithValue("KodeAplikasi", "AG")
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd1.Connection = Koneksi1
        Koneksi1.Open()
        cmd1.ExecuteNonQuery()
        Koneksi1.Close()
        MsgBox("Daftar Menu Berhasil Diperbaharui", vbInformation, "Informasi")
        LoadDaftarHakAkses()


    End Sub
    Private Sub txtCariHakAkses_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariHakAkses.KeyPress

        LoadDaftarHakAkses()
        dgHakAksesUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHakAksesUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHakAksesUser.AutoResizeColumns()
    End Sub

  

    Private Sub txtCariHakAkses_TextChanged(sender As Object, e As EventArgs) Handles txtCariHakAkses.TextChanged

    End Sub
End Class