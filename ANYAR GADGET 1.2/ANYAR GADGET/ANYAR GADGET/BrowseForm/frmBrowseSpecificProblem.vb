Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseSpecificProblem

    Private myBindingSource As New BindingSource()


    Sub ListSpecificProblems()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("Select IDSub,Deskripsi From Categories2 Where StatusEnabled='Y' AND IDCategories='" & MstrIDCategories & "' AND IDSub='" & MstrIDSubCategories & "'", KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvSpecificProblem.DataSource = myBindingSource

        dgvSpecificProblem.DataSource = table
        dgvSpecificProblem.Refresh()
        dgvSpecificProblem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSpecificProblem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvSpecificProblem.AutoResizeColumns()

    End Sub



    Private Sub frmBrowseSubkategori_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListSpecificProblems()
        txtKategori.Text = MstrNamaCategories
        txtNamaPerangkat.Text = MstrNamaSubCategories
    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "Deskripsi Like '%" & txtCari.Text & "%' OR IDSimptoms like '%" & txtCari.Text & "%' "
                dgvSpecificProblem.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub dgvDetailSubkategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSpecificProblem.CellClick
        CType(frmMainMenu.ActiveMdiChild, frmLaporkanMasalah).txtKodeSpecificProblem.Text = dgvSpecificProblem.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmLaporkanMasalah).txtNamaSpecificProblems.Text = dgvSpecificProblem.Rows(e.RowIndex).Cells(1).Value()
        Me.Close()
    End Sub
End Class