Imports System.Data.SqlClient

Public Class AlertsSetup


    Private Sub AlertsSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        AssignValidation(txtDurasi, ValidationType.Only_Numbers)

        AssignValidation(txtSatuanWaktu, ValidationType.Only_Characters)


        LoadDaftarUserAplikasi()
        LoadDaftarObjectUser()

    End Sub

    Sub LoadDaftarUserAplikasi()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT KodePegawai,NamaPegawai FROM V_DataUser WHERE KodeAplikasi='AG' AND  NamaPegawai Like '%" & Trim(txtCariUsers.Text) & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarUser.DataSource = table
        dgDaftarUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUser.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUser.AutoResizeColumns()
        dgDaftarUser.RowHeadersVisible = False
    End Sub

    Sub LoadDaftarObjectUser()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NamaKomponen,KodeObject,isnull(Satuan,'') As Satuan,isnull(Durasi,'') As Durasi FROM dbo.V_ObjectUserAnyarGadget WHERE NamaKomponen Like '%" & Trim(txtCariKomponen.Text) & "%' AND KodePegawai='" & Trim(txtKodeUser.Text) & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarKomponen.DataSource = table
        dgDaftarKomponen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarKomponen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarKomponen.AutoResizeColumns()
        dgDaftarKomponen.RowHeadersVisible = False
    End Sub

    Private Sub AlertsSetup_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub



    Private Sub AlertsSetup_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

    Private Sub dgDaftarKomponen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarKomponen.CellContentClick
        txtNamaKomponen.Text = dgDaftarKomponen.Item(0, dgDaftarKomponen.CurrentRow.Index).Value
        txtKodeKomponen.Text = dgDaftarKomponen.Item(1, dgDaftarKomponen.CurrentRow.Index).Value
        txtSatuanWaktu.Text = dgDaftarKomponen.Item(2, dgDaftarKomponen.CurrentRow.Index).Value
        txtDurasi.Text = dgDaftarKomponen.Item(3, dgDaftarKomponen.CurrentRow.Index).Value
    End Sub

    Private Sub dgDaftarUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarUser.CellContentClick
        txtKodeUser.Text = dgDaftarUser.Item(0, dgDaftarUser.CurrentRow.Index).Value
        txtNamaUser.Text = dgDaftarUser.Item(1, dgDaftarUser.CurrentRow.Index).Value
    End Sub

    Private Sub txtCariUsers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariUsers.KeyPress
        LoadDaftarUserAplikasi()
    End Sub

    Private Sub txtCariKomponen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariKomponen.KeyPress
        LoadDaftarObjectUser()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtSatuanWaktu.Text = "" Then
            MsgBox("Satuan Waktu Harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtDurasi.Text = "" Then
            MsgBox("Durasi Waktu Harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If




        Call KoneksiDatabase1()
        Dim str As String
        str = "Update AksesUserKeMenu set Value = '" & txtDurasi.Text & "', Value2 = '" & txtSatuanWaktu.Text & "' where KodePegawai = '" & txtKodeUser.Text & "' AND KodeObjectAplikasi='" & txtKodeKomponen.Text & "' AND KodeAplikasi='" & MstrNamaAplikasi & "'"

        cmd = New SqlCommand(str, Koneksi1)

        cmd.ExecuteNonQuery()


        MsgBox("Setting Notifikasi Berhasil Disimpan, Silahkan Perintahkan Login Ulang", vbInformation, "Penting !")
        txtKodeUser.Text = ""
        txtNamaUser.Text = ""
        txtKodeKomponen.Text = ""
        txtNamaKomponen.Text = ""
        txtSatuanWaktu.Text = ""
        txtDurasi.Text = ""
        Exit Sub



    End Sub

End Class