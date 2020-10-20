Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowsePegawai
    Dim strIDPegawai As String



    Private Sub frmBrowsePegawai_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListPegawai, "Select * from OEmployee Where NamaPegawai Like '%" & Trim(txtCariPegawai.Text) & "%' AND StatusEnabled='Y'", KoneksiDBEmail)
    End Sub


    Private Sub txtCariPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariPegawai.KeyPress
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListPegawai, "Select * from OEmployee Where NamaPegawai Like '%" & Trim(txtCariPegawai.Text) & "%' AND StatusEnabled='Y'", KoneksiDBEmail)
    End Sub

    Private Sub dgvListPegawai_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListPegawai.CellClick
        On Error Resume Next
        CType(frmMainMenu.ActiveMdiChild, frmUsers).txtEmployee.Text = dgvListPegawai.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmUsers).txtNamaPegawai.Text = dgvListPegawai.Rows(e.RowIndex).Cells(1).Value()
        Me.Close()


    End Sub

    Private Sub dgvListPegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListPegawai.CellContentClick
        MstrKonsIDPegawai = dgvListPegawai.Rows(e.RowIndex).Cells(0).Value()
        MstrKonsNamaPegawai = dgvListPegawai.Rows(e.RowIndex).Cells(1).Value()
        Me.Close()
       
    End Sub
End Class