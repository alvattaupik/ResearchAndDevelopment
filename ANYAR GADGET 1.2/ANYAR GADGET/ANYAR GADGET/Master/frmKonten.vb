Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmKonten
    Private myBindingSource As New BindingSource()
    Public selRow As New DataGridViewRow
    Private Sub picCariLampiran_Click(sender As Object, e As EventArgs) Handles picCariLampiran.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathLampiran.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnAddLampiran_Click(sender As Object, e As EventArgs) Handles btnAddLampiran.Click
        If txtPathLampiran.Text = "" Then
            DisplayPesanError("Attachments Is Required, Please Browse", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If txtNamaFile.Text = "" Then
            DisplayPesanError("Nama File Harus Di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        dgvListLampiran.Rows.Add("", txtNamaFile.Text, txtPathLampiran.Text)
        lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
        dgvListLampiran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListLampiran.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListLampiran.AutoResizeColumns()
        txtPathLampiran.Text = ""
        txtNamaFile.Text = ""
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()
    End Sub

    Private Sub cmbHeaders_Click(sender As Object, e As EventArgs) Handles cmbHeaders.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbHeaders, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE  StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSubCategories_Click(sender As Object, e As EventArgs) Handles cmbSubCategories.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubCategories, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE  StatusEnabled='Y' AND Cast(IDCategories AS varchar(100))='" & cmbHeaders.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSubCategories_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbSubCategories.SelectedValueChanged
        txtSubKategori.Text = cmbSubCategories.Text
    End Sub


    Private Sub cmbSubCategories_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubCategories.SelectionChangeCommitted
        dgvListKonten.DataSource = Nothing
        dgvListKonten.Rows.Clear()
        'Call KoneksiDB_EMAIL()
        'LoadDataGrid(dgvKonten, "SELECT ID,NamaKonten,IDKategori,IDSubKategori FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSubKategori='" & cmbSubKategori.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)
        LoadDetailKonten()


    End Sub


    Sub LoadDetailKonten()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ID,NamaKonten,IDKategori,IDSubKategori FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbHeaders.SelectedValue & "' and IDSubKategori='" & cmbSubCategories.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvListKonten.DataSource = myBindingSource

        dgvListKonten.DataSource = table
        dgvListKonten.Refresh()
        dgvListKonten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListKonten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListKonten.AutoResizeColumns()

    End Sub


    Private Sub cmbHeaders_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeaders.SelectionChangeCommitted
        txtNamaKategori.Text = cmbHeaders.Text
    End Sub

    Private Sub btnHapusLampiran_Click(sender As Object, e As EventArgs) Handles btnHapusLampiran.Click
        Dim row As Integer
        Dim index As Integer

        On Error Resume Next

        If dgvListLampiran.RowCount = 0 Then Exit Sub

        index = dgvListLampiran.SelectedRows.Item(0).Index
        selRow = dgvListLampiran.Rows.Item(index)
        dgvListLampiran.Rows.Remove(selRow)
        row = row - 1
        lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
    End Sub
End Class