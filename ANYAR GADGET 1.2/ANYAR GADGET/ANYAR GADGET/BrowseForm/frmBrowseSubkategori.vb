Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseSubkategori

    Private myBindingSource As New BindingSource()


    Sub ListSubkategori()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("Select IDSub,Deskripsi From Categories1 Where StatusEnabled='Y' AND IDCategories='" & MstrIDCategories & "'", KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvDetailSubkategori.DataSource = myBindingSource

        dgvDetailSubkategori.DataSource = table
        dgvDetailSubkategori.Refresh()
        dgvDetailSubkategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDetailSubkategori.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDetailSubkategori.AutoResizeColumns()

    End Sub



    Private Sub frmBrowseSubkategori_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListSubkategori()
        txtKategori.Text = MstrNamaCategories
    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "Deskripsi Like '%" & txtCari.Text & "%' OR IDSub like '%" & txtCari.Text & "%' "
                dgvDetailSubkategori.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub dgvDetailSubkategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetailSubkategori.CellClick
        CType(frmMainMenu.ActiveMdiChild, frmLaporkanMasalah).txtKodeSubkategori.Text = dgvDetailSubkategori.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmLaporkanMasalah).txtNamaSubkategori.Text = dgvDetailSubkategori.Rows(e.RowIndex).Cells(1).Value()
        Me.Close()
    End Sub
End Class