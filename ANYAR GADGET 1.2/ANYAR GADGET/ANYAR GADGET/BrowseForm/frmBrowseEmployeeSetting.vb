Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseEmployeeSetting
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
        CType(frmMainMenu.ActiveMdiChild, frmSetttingUsers).txtEmployeeID.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmSetttingUsers).txtNamaPegawai.Text = dgvBrowseEmployee.Rows(e.RowIndex).Cells(1).Value()
        Me.Close()
    End Sub
End Class