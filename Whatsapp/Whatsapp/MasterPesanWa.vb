Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class MasterPesanWa




    Sub LoadMasterPesanWA()
        Call KoneksiDBEmail()

        Dim cmd As New SqlCommand("Select NamaStatus,KalimatPembuka,Isi,KalimatPenutup,KodeStatus from dbo.MasterNotifikasiWA Where NamaStatus Like '%" & Trim(txtCari.Text) & "%' OR KodeStatus Like '%" & Trim(txtCari.Text) & "%' Or Isi Like '%" & Trim(txtCari.Text) & "%' Or KalimatPenutup Like '%" & Trim(txtCari.Text) & "%'", Koneksi)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgvMasterStatusWa.DataSource = table
        dgvMasterStatusWa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvMasterStatusWa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvMasterStatusWa.AutoResizeColumns()
    End Sub


    Private Sub MasterPesanWa_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMasterPesanWA()
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        LoadMasterPesanWA()
    End Sub

    Private Sub dgvMasterStatusWa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMasterStatusWa.CellDoubleClick
        If dgvMasterStatusWa.Rows.Count = 0 Then Exit Sub
        txtKodeStatus.Text = dgvMasterStatusWa.Item(4, dgvMasterStatusWa.CurrentRow.Index).Value()
        txtFungsi.Text = dgvMasterStatusWa.Item(0, dgvMasterStatusWa.CurrentRow.Index).Value()
        txtPembukaan.Text = dgvMasterStatusWa.Item(1, dgvMasterStatusWa.CurrentRow.Index).Value()
        txtIsi.Text = dgvMasterStatusWa.Item(2, dgvMasterStatusWa.CurrentRow.Index).Value()
        txtPenutup.Text = dgvMasterStatusWa.Item(3, dgvMasterStatusWa.CurrentRow.Index).Value()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Call KoneksiDBEmail()
        Dim str As String
        str = "Update MasterNotifikasiWA set KalimatPembuka = '" & txtPembukaan.Text & "', Isi = '" & txtIsi.Text & "', KalimatPenutup = '" & txtPenutup.Text & "' Where KodeStatus = '" & txtKodeStatus.Text & "'"

        cmd = New SqlCommand(str, Koneksi)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Update Berhasil")
        LoadMasterPesanWA()

    End Sub
End Class