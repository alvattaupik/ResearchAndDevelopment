Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseConfigurationItems





    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvBusinessPartner, "SELECT Top 30 * FROM dbo.V_ListConfigurationItems Where Kode Like '%" & Trim(txtCari.Text) & "%' Or NamaValidasi Like '%" & Trim(txtCari.Text) & "%' Or Notifikasi Like '%" & Trim(txtCari.Text) & "%'", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvBusinessPartner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusinessPartner.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmRequestFullfillment).txtKode.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmRequestFullfillment).txtDeskripsi.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(1).Value()
        CType(frmMainMenu.ActiveMdiChild, frmRequestFullfillment).txtNotifikasi.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(2).Value()
        Me.Close()
    End Sub





End Class