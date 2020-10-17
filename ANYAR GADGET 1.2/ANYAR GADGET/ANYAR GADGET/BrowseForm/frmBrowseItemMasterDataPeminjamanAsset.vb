Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseItemMasterDataPeminjamanAsset


    Private myBindingSource As New BindingSource()



    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "ItemCode Like '%" & txtCari.Text & "%' OR ItemName  Like '%" & txtCari.Text & "%' OR Spesifikasi  Like '%" & txtCari.Text & "%' "
                dgvItemMasterData.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvBusinessPartner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemMasterData.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmPeminajamanAsset).txtItemCode.Text = dgvItemMasterData.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmPeminajamanAsset).txtItemName.Text = dgvItemMasterData.Rows(e.RowIndex).Cells(1).Value()
        CType(frmMainMenu.ActiveMdiChild, frmPeminajamanAsset).txtSpesifikasi.Text = dgvItemMasterData.Rows(e.RowIndex).Cells(2).Value()

        Me.Close()
    End Sub





    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbCabang, "Select KodeDivisi,NamaDivisi From V_Divisi", "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub

    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub



    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE StatusEnabled='Y' AND IDCategories='" & cmbKategori.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub









    Sub LoadDaftarAsset()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ItemCode,ItemName,Spesifikasi FROM V_ListDaftarAssetPeminjaman Where Cast(IDCategories AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSub='" & cmbSubKategori.SelectedValue & "' AND KodeCabang='" & cmbCabang.SelectedValue & "'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvItemMasterData.DataSource = myBindingSource

        dgvItemMasterData.DataSource = table
        dgvItemMasterData.Refresh()
        dgvItemMasterData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvItemMasterData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvItemMasterData.AutoResizeColumns()

    End Sub



    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        LoadDaftarAsset()
    End Sub
End Class