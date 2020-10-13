Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmMonitoringAndControlling

    Private Sub cmbCabangDaftarAsset_Click(sender As Object, e As EventArgs) Handles cmbCabangDaftarAsset.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabangDaftarAsset, "Select PrcCode,PrcName From OPRC WHere PrcCode NOT Like 'Centr%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub


    Private Sub cmbkategori_Click(sender As Object, e As EventArgs) Handles cmbkategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbkategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE IDCategories='" & cmbkategori.SelectedValue & "' AND StatusEnabled='Y'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub



    Sub LoadListAsset()

        Dim strQuery2 As String = "SELECT ItemCode,ItemName,Spesifikasi,ID FROM dbo.OAssetsManagement Where KodeCabang='" & cmbCabangDaftarAsset.SelectedValue & "' AND IDCategories='" & cmbkategori.SelectedValue & "' AND IDSub ='" & cmbSubKategori.SelectedValue & "'"

        Try
            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvListAsset, strQuery2, KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub



    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        LoadListAsset()
    End Sub

    Private Sub btnAssesment_Click(sender As Object, e As EventArgs) Handles btnAssesment.Click
        dgvDaftarAssesment.DataSource = Nothing
        dgvDaftarAssesment.Rows.Clear()
        dgvDaftarAssesment.Columns.Clear()
        txtKodeBarang.Text = dgvListAsset.Item(0, dgvListAsset.CurrentRow.Index).Value
        txtNamaBarang.Text = dgvListAsset.Item(1, dgvListAsset.CurrentRow.Index).Value
        txtSpesifikasi.Text = dgvListAsset.Item(2, dgvListAsset.CurrentRow.Index).Value
        BuatParameterUji("Buat-Parameter")
    End Sub



    Sub BuatParameterUji(strFunction As String)
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_BuatParameterUji]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Kategori", Trim(cmbkategori.SelectedValue))
            command.Parameters.AddWithValue("SubKategori", Trim(cmbSubKategori.SelectedValue))
            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
            command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
            MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()


            If MstrErrorCode = "E-00" Then
                DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            End If




            Dim table As New DataTable
            adapter.Fill(table)
            dgvDaftarAssesment.Columns.Add("ParameterUji", "ParameterUji")

            Dim chk As New DataGridViewCheckBoxColumn()
            dgvDaftarAssesment.Columns.Add(chk)
            chk.HeaderText = "Kondisi"
            chk.Name = "Kondisi"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"


            dgvDaftarAssesment.Columns.Add("Indikator", "Indikator")


            dgvDaftarAssesment.Columns(0).ReadOnly = True
            dgvDaftarAssesment.Columns(1).ReadOnly = False
            dgvDaftarAssesment.Columns(2).ReadOnly = True

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvDaftarAssesment.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next

            End With




        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

End Class