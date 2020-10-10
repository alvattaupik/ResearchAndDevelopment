Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmListKendaraan


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "Ok" Then
            Me.Dispose()
            Exit Sub
        End If


        If btnProses.Text = "Add" Then
            AU_ListKendaraan("ADD")
            If MstrErrorCode = "" Then
                txtKode.Text = ""
                txtKodeNama.Text = ""
                txtNoKendaraan.Text = ""
                cmbCabang.Text = ""
                txtTipeKendaraan.Text = ""
                btnProses.Text = "Ok"
            End If

        End If


        If btnProses.Text = "Update" Then
            AU_ListKendaraan("UPDATE")
        End If


    End Sub

    Private Sub picNew_Click(sender As Object, e As EventArgs) Handles picNew.Click
        'txtKode.Enabled = True
        'txtKode.ReadOnly = False
        txtNoKendaraan.Enabled = True
        txtTipeKendaraan.Enabled = True
        txtKodeNama.Enabled = True
        cmbCabang.Enabled = True
        btnProses.Text = "Add"
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        txtCari.ReadOnly = False
        txtCari.Enabled = True
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call Koneksi_SAP()
                gbListKendaraan.Visible = True
                LoadDataGrid(dgvListKendaraan, "SELECT Code,U_RKM_NO_KENDARAAN,U_RKM_TYPE_KENDARAAN,ISNULL(U_RKM_CABANG,'') AS U_RKM_CABANG ,ISNULL(U_RKM_NAMA_CABANG,'') AS U_RKM_NAMA_CABANG ,U_RKM_KODE_NAMA FROM dbo.[@RKM_LIST_KENDARAAN] WHERE U_RKM_NO_KENDARAAN lIKE '%" & Trim(txtCari.Text) & "%' OR U_RKM_TYPE_KENDARAAN LIKE '%" & Trim(txtCari.Text) & "%' OR U_RKM_CABANG LIKE '%" & Trim(txtCari.Text) & "%' OR U_RKM_NAMA_CABANG LIKE '%" & Trim(txtCari.Text) & "%' OR U_RKM_KODE_NAMA LIKE '%" & Trim(txtCari.Text) & "%'", KoneksiSAP)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        gbListKendaraan.Visible = False
    End Sub

    Private Sub dgvListKendaraan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListKendaraan.CellClick
        txtKode.Text = dgvListKendaraan.Rows(e.RowIndex).Cells(0).Value()
        txtNoKendaraan.Text = dgvListKendaraan.Rows(e.RowIndex).Cells(1).Value()
        txtTipeKendaraan.Text = dgvListKendaraan.Rows(e.RowIndex).Cells(2).Value()
        cmbCabang.ValueMember = dgvListKendaraan.Rows(e.RowIndex).Cells(3).Value()
        cmbCabang.DisplayMember = dgvListKendaraan.Rows(e.RowIndex).Cells(4).Value()
        txtKodeNama.Text = dgvListKendaraan.Rows(e.RowIndex).Cells(5).Value()
        gbListKendaraan.Visible = False

        txtNoKendaraan.Enabled = True
        txtTipeKendaraan.Enabled = True
        txtKodeNama.Enabled = True
        cmbCabang.Enabled = True

        btnProses.Text = "Update"


    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode LIKE '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub




    Sub AU_ListKendaraan(strFunction As String)

        Try
            Koneksi_SAP()
            Dim command As SqlCommand
            command = New SqlCommand("[_tmsp_AU_ListKendaraanRKM]", KoneksiSAP)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Code", Trim(txtKode.Text))
            command.Parameters.AddWithValue("NoKendaraan", Trim(txtNoKendaraan.Text))
            command.Parameters.AddWithValue("TipeKendaraan", Trim(txtTipeKendaraan.Text))
            If cmbCabang.SelectedValue = "" Then
                command.Parameters.AddWithValue("KodeCabang", Trim(""))
            Else
                command.Parameters.AddWithValue("KodeCabang", Trim(cmbCabang.SelectedValue))
            End If


            command.Parameters.AddWithValue("KodeNama", Trim(txtKodeNama.Text))
            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
            command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("NomorSuratOUT", SqlDbType.VarChar, 100)
            command.Parameters("NomorSuratOUT").Direction = ParameterDirection.Output
            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiSAP.State = ConnectionState.Open) Then KoneksiSAP.Close()
            command.Connection = KoneksiSAP
            KoneksiSAP.Open()
            command.ExecuteNonQuery()

            MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
            MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()

            If MstrErrorCode = "E-00" Then
                DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



End Class