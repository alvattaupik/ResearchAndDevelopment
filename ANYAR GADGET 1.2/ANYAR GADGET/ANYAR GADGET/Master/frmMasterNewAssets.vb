Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmMasterNewAssets

    Private myBindingSource As New BindingSource()
    Dim strID As String
    Dim strSource As String
    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode NOT LIKE 'Cent%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub



    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub



    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE StatusEnabled='Y' AND IDCategories='" & Trim(cmbKategori.SelectedValue) & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub picBrowseAssets_Click(sender As Object, e As EventArgs) Handles picBrowseAssets.Click
        strSource = "1"
        txtItemCode.Text = ""
        txtItemName.Text = ""
        txtSpesifikasi.Text = ""
        frmBrowseAssetmanagement.ShowDialog()
    End Sub

    Private Sub picManual_Click(sender As Object, e As EventArgs) Handles picManual.Click
        strSource = "0"

        txtItemCode.Text = ""
        txtItemName.Text = ""
        txtSpesifikasi.Text = ""

    End Sub





    Sub LoadDetailAssets()

        Dim strQuery2 As String = "SELECT ItemCode,ItemName,Spesifikasi,ID,StatusEnabled FROM dbo.OAssetsManagement Where KodeCabang='" & cmbCabang.SelectedValue & "' AND IDCategories='" & cmbKategori.SelectedValue & "' AND IDSub ='" & cmbSubKategori.SelectedValue & "'"
        Call KoneksiDB_EMAIL()
        Try
            dgvAssetList.DataSource = Nothing
            dgvAssetList.Rows.Clear()
            dgvAssetList.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            dgvAssetList.Columns.Add("ItemCode", "ItemCode")
            dgvAssetList.Columns.Add("ItemName", "ItemName")
            dgvAssetList.Columns.Add("Spesifikasi", "Spesifikasi")
            dgvAssetList.Columns.Add("ID", "ID")
            dgvAssetList.Columns.Add("StatusEnabled", "StatusEnabled")


            dgvAssetList.Columns(0).ReadOnly = True
            dgvAssetList.Columns(1).ReadOnly = True
            dgvAssetList.Columns(2).ReadOnly = False

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvAssetList.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString(), .Rows(i).Item(3).ToString())
                Next

            End With

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        LoadDetailAssets()
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "ItemCode Like '%" & txtCari.Text & "%' Or ItemName Like '%" & txtCari.Text & "%'"
                dgvAssetList.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub


    Private Sub btnSimpanKeDaftar_Click(sender As Object, e As EventArgs) Handles btnSimpanKeDaftar.Click
        Call AUD_ASSETS("ADD-NEW-ASSET")
        LoadDetailAssets()
    End Sub


    Sub AUD_ASSETS(strFunction As String)
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_MasterAssetManagement]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("ID", Trim(strID))
            If strSource = Nothing Then
                command.Parameters.AddWithValue("Source", "1")
            Else
                command.Parameters.AddWithValue("Source", strSource)
            End If
            command.Parameters.AddWithValue("KodeCabang", Trim(cmbCabang.SelectedValue))
            command.Parameters.AddWithValue("ItemCode", Trim(txtItemCode.Text))
            command.Parameters.AddWithValue("ItemName", Trim(txtItemName.Text))
            command.Parameters.AddWithValue("Spesifikasi", Trim(txtSpesifikasi.Text))
            command.Parameters.AddWithValue("IDCategories", Trim(cmbKategori.SelectedValue))
            command.Parameters.AddWithValue("IDSub", Trim(cmbSubKategori.SelectedValue))
            command.Parameters.AddWithValue("StatusEnabled", Trim("Y"))
            command.Parameters.AddWithValue("Function", Trim(strFunction))

            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
            command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output


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

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        If dgvAssetList.RowCount = 0 Then Exit Sub
        strID = dgvAssetList.Item(3, dgvAssetList.CurrentRow.Index).Value
        If MsgBox("Apakah Anda Yakin data yang akan di Hapus sudah sesuai?", vbYesNo, "Konfirmasi") = vbYes Then
            Call AUD_ASSETS("DELETE-ASSETS")
            LoadDetailAssets()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        If dgvAssetList.RowCount = 0 Then Exit Sub
        frmUbahAsset.txtID.Text = dgvAssetList.Item(3, dgvAssetList.CurrentRow.Index).Value
        frmUbahAsset.ShowDialog()
    End Sub
End Class