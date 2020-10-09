Imports System.Data
Imports System.Data.SqlClient
Public Class frmBantuan

    Private myBindingSource As New BindingSource()



    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE  StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub



    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE  StatusEnabled='Y' AND Cast(IDCategories AS varchar(100))='" & cmbKategori.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub





    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        dgvKonten.DataSource = Nothing
        dgvKonten.Rows.Clear()
        'Call KoneksiDB_EMAIL()
        'LoadDataGrid(dgvKonten, "SELECT ID,NamaKonten,IDKategori,IDSubKategori FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSubKategori='" & cmbSubKategori.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)
        LoadDetailKonten()



    End Sub



    Sub LoadDetailKonten()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ID,NamaKonten FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSubKategori='" & cmbSubKategori.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvKonten.DataSource = myBindingSource

        dgvKonten.DataSource = table
        dgvKonten.Refresh()
        dgvKonten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvKonten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKonten.AutoResizeColumns()

    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "NamaKonten Like '%" & txtCari.Text & "%'"
                dgvKonten.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvKonten_Click(sender As Object, e As EventArgs) Handles dgvKonten.Click
        txtKodeKonten.Text = dgvKonten.Item(0, dgvKonten.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvKonten.Item(1, dgvKonten.CurrentRow.Index).Value
        txtKategori.Text = cmbKategori.Text
        txtSubKategori.Text = cmbSubKategori.Text

        KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarLampiran, "SELECT AttachID,NamaFile,LokasiFile FROM dbo.Help1 WHere ID='" & Trim(txtKodeKonten.Text) & "'", KoneksiDBEmail)

    End Sub
End Class