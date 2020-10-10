﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmBrowseItemMasterDataSuratTerima





    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call Koneksi_SAP()
                LoadDataGrid(dgvItemMasterData, "Select Top 10 ItemCode,ItemName From OITM Where ItemName Like '%" & Trim(txtCari.Text) & "%' Or ItemCode Like '%" & Trim(txtCari.Text) & "%'", KoneksiSAP)
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvBusinessPartner_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemMasterData.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmSuratTerima).txtKode.Text = dgvItemMasterData.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmSuratTerima).txtDeskripsi.Text = dgvItemMasterData.Rows(e.RowIndex).Cells(1).Value()

        Me.Close()
    End Sub




End Class