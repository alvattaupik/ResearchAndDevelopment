Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCariCustomer


    Private Sub dgvlistCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistCustomer.CellContentClick
        Call GetInformasiCustomer(dgvlistCustomer.Rows(e.RowIndex).Cells(0).Value())
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtKodeCustomer.Text = dgvlistCustomer.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtNamaCustomer.Text = MstrNamaCustomer
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtNoMember.Text = MstrNoMember
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtPhoneNumber.Text = MstrPhoneNumber
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtAlamat.Text = MstrAlamatCustomer
        CType(frmMainMenu.ActiveMdiChild, frmInformasiCustomer).txtTransaksiTerakhir.Text = MstrLastTransaction

        Me.Close()
    End Sub

    Private Sub txtCariCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariCustomer.KeyPress
        Dim strQuery As String = "SELECT Top 50 * From V_ListBusinessPartner" & _
                                 " Where KodeCustomer Like '%" & Trim(txtCariCustomer.Text) & "%' Or NamaCustomer Like '%" & Trim(txtCariCustomer.Text) & "%' Or Phone Like '%" & Trim(txtCariCustomer.Text) & "%' OR Alamat Like '%" & Trim(txtCariCustomer.Text) & "%' "
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call Koneksi_SAP()
                LoadDataGrid(dgvlistCustomer, strQuery, KoneksiSAP)
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub
End Class