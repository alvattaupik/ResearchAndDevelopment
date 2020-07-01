Imports System.Data.SqlClient
Public Class FormUserSAP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Sub LoadDaftarUserSAP()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("Select * From V_ListMasterUser WHERE NamaUser Like '%" & Trim(txtCariUer.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarUserSAp.DataSource = table
        dgDaftarUserSAp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUserSAp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUserSAp.AutoResizeColumns()

    End Sub


    Private Sub txtCariUer_TextChanged(sender As Object, e As EventArgs) Handles txtCariUer.TextChanged
        LoadDaftarUserSAP()
    End Sub


    Private Sub dgDaftarUserSAp_Click(sender As Object, e As EventArgs) Handles dgDaftarUserSAp.Click
        If MstrNamaForm = "Cari kode User" Then
            FormUserLoginDanHakAkses.txtKodeUser.Text = dgDaftarUserSAp.Item(0, dgDaftarUserSAp.CurrentRow.Index).Value
            FormUserLoginDanHakAkses.txtNamaLengkap.Text = dgDaftarUserSAp.Item(1, dgDaftarUserSAp.CurrentRow.Index).Value
            Me.Close()
        End If


        If MstrNamaForm = "Cari kode SPV" Then
            FormUserLoginDanHakAkses.txtKodeSPV.Text = dgDaftarUserSAp.Item(0, dgDaftarUserSAp.CurrentRow.Index).Value
            FormUserLoginDanHakAkses.txtNamaSPV.Text = dgDaftarUserSAp.Item(1, dgDaftarUserSAp.CurrentRow.Index).Value
            Me.Close()
        End If

    End Sub
End Class