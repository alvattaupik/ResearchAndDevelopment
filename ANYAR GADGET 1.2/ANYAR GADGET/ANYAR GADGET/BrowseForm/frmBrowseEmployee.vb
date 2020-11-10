Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseEmployee


    Sub LoadDaftarPegawai()
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvBrowseEmployee, "Select * from Oemployee Where NamaPegawai Like '%" & Trim(txtCari.Text) & "%' Or Cast(ID As Varchar(100)) Like '%" & Trim(txtCari.Text) & "%' Or AlamatPegawai Like '%" & Trim(txtCari.Text) & "%'", KoneksiDBEmail)
    End Sub



    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                LoadDaftarPegawai()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvBrowseEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrowseEmployee.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).txtEmployeeID.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).txtNamaPegawai.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(1).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).txtAlamat.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(2).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).cmbJabatan.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(3).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).cmbFungsional.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(4).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).txtAlamatEmail.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(5).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).txtNoTelp.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(6).Value()
        If dgvBrowseEmployee.Rows(e.RowIndex).Cells(7).Value() = "Y" Then
            CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).cboAktif.Checked = True
        Else
            CType(frmMainMenu.ActiveMdiChild, frmMasterPegawai).cboAktif.Checked = False
        End If

        Me.Close()
    End Sub
End Class