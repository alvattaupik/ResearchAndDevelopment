Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmListCustomer

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If cmbListCabang.Text = "" Then
            DisplayPesanError("Cabang Is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[Lap_ListCustomer_VM]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", cmbListCabang.SelectedValue)
        command.Parameters.AddWithValue("@Pencarian", txtCari.Text)


        Dim table As New DataTable
        adapter.Fill(table)

     


        Me.dgvListCustomer.DataSource = table
        dgvListCustomer.DataSource = table
        lblJumlahRow.Text = "Jumlah Data : " & dgvListCustomer.RowCount
        dgvListCustomer.RowHeadersVisible = False

    End Sub


    Private Sub picExportTransaksi_Click(sender As Object, e As EventArgs) Handles picExportTransaksi.Click
        If dgvListCustomer.RowCount = 0 Then
            DisplayPesanError("No Records To Export", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            ExportToExcel(lblExport, dgvListCustomer)
        End If


    End Sub

    Private Sub cmbListCabang_Click(sender As Object, e As EventArgs) Handles cmbListCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbListCabang, "Select PrcCode,PrcName From OPRC Where PrcCode Like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub
End Class