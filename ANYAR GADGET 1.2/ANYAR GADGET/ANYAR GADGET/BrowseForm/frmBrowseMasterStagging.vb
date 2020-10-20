Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmBrowseMasterStagging

    Private Sub frmBrowseMasterStagging_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListEmployee, "Select * From Oemployee Where Cast(ID As Varchar(100)) Like '%" & Trim(txtCariEmployee.Text) & "%' Or NamaPegawai like '%" & Trim(txtCariEmployee.Text) & "%' OR AlamatPegawai Like '%" & Trim(txtCariEmployee.Text) & "%' Or Jabatan Like '%" & Trim(txtCariEmployee.Text) & "%' or Fungsional like '%" & Trim(txtCariEmployee.Text) & "%'", KoneksiDBEmail)
    End Sub



    Private Sub dgvListEmployee_Click(sender As Object, e As EventArgs) Handles dgvListEmployee.Click
        
    End Sub
End Class