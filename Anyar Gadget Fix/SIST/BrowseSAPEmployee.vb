Imports System.Data.SqlClient
Public Class BrowseSAPEmployee







    Sub LoadSAPEmployee()
        Call KoneksiDatabase2()
        Dim cmd As New SqlCommand("SELECT empID,firstName,middleName,lastName,jobTitle,position,dept,branch,manager,Active FROM dbo.OHEM WHere FirstName Like'%" & Trim(txtCariPegawai.Text) & "%' Or MiddleName Like'%" & Trim(txtCariPegawai.Text) & "%' Or LastName like '%" & Trim(txtCariPegawai.Text) & "%' ", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgSAPEmployee.DataSource = table
        dgSAPEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSAPEmployee.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSAPEmployee.AutoResizeColumns()
    End Sub





    Private Sub BrowseSAPEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSAPEmployee()
    End Sub

    Private Sub txtCariPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariPegawai.KeyPress
        LoadSAPEmployee()
    End Sub


    Private Sub dgSAPEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSAPEmployee.CellContentClick

    End Sub
End Class