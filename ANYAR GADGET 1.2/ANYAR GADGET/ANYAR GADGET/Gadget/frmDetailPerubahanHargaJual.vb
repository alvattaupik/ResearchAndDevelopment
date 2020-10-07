Imports System.Data.SqlClient

Public Class frmDetailPerubahanHargaJual




    Sub LoadDetailPerubahanHarga()
        Try
            Koneksi_SAP()
            Dim command As SqlCommand
            command = New SqlCommand("_tmspPerubahanHargaDateParameter", KoneksiSAP)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@PriceList", cmbLocation.SelectedValue)
            command.Parameters.AddWithValue("@TanggalAwal", dtpAwal.Value)
            command.Parameters.AddWithValue("@TanggalAkhir", dtpAkhir.Value)

            Dim table As New DataTable
            adapter.Fill(table)

            dgPerubahanHarga.DataSource = table
            dgPerubahanHarga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgPerubahanHarga.AutoResizeColumns()
            dgPerubahanHarga.RowHeadersVisible = False

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub cmbLocation_Click(sender As Object, e As EventArgs) Handles cmbLocation.Click
        Call KoneksiDB_EMAIL()
        Dim strSQlQuery As String = "SELECT  ListNum ," & _
        " CASE WHEN NamaLocation IS NULL THEN Cabang" & _
        "     ELSE NamaLocation" & _
        " END AS Name" & _
        " FROM dbo.V_ListHargadanCabang" & _
        " LEFT OUTER JOIN dbo.OLocation ON KodeLocation = Cabang" & _
        " WHERE Ket='HJ' AND Cabang IN (SELECT KodeLocation FROM dbo.OLocControlUsers WHERE KodeAplikasi='AG' AND UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y')"
        LoadComboBox(cmbLocation, strSQlQuery, "ListNum", "Name", KoneksiDBEmail)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        LoadDetailPerubahanHarga()
    End Sub
End Class