Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseBusinessPartnerBAPPenyelesaian





    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call Koneksi_SAP()
                LoadDataGrid(dgvBusinessPartner, "Select Top 10 * From V_Kontak Where Nama Like '%" & Trim(txtCari.Text) & "%'", KoneksiSAP)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvBusinessPartner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusinessPartner.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmBAPPenyelesaian).txtDitujukanKepada.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmBAPPenyelesaian).txtAlamat.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(1).Value()
        CType(frmMainMenu.ActiveMdiChild, frmBAPPenyelesaian).txtNoTelp.Text = dgvBusinessPartner.Rows(e.RowIndex).Cells(2).Value()
        Me.Close()
    End Sub




End Class