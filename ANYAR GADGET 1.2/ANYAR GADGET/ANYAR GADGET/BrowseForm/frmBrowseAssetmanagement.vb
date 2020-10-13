Imports System.Data.SqlClient
Public Class frmBrowseAssetmanagement


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call Koneksi_SAP()
                LoadDataGrid(dgvCariAssets, "SELECT ItemCode,ItemName,'' As Spesifikasi FROM dbo.OITM WHERE ItemType='f' AND (ItemName Like '%" & Trim(txtCari.Text) & "%' Or ItemName like '%" & Trim(txtCari.Text) & "%')", KoneksiSAP)
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvCariAssets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCariAssets.CellClick
        CType(frmMainMenu.ActiveMdiChild, frmMasterNewAssets).txtItemCode.Text = dgvCariAssets.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterNewAssets).txtItemName.Text = dgvCariAssets.Rows(e.RowIndex).Cells(1).Value()
        CType(frmMainMenu.ActiveMdiChild, frmMasterNewAssets).txtSpesifikasi.Text = dgvCariAssets.Rows(e.RowIndex).Cells(2).Value()



        Me.Close()

    
    End Sub


End Class