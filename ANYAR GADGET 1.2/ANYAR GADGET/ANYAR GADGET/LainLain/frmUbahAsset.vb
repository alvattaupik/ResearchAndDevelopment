Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmUbahAsset

    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories Where StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSub_Click(sender As Object, e As EventArgs) Handles cmbSub.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSub, "SELECT IDSub,Deskripsi FROM dbo.Categories1 Where StatusEnabled='Y' AND IDCategories='" & Trim(cmbKategori.SelectedValue) & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub frmUbahAsset_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim strQuery As String
            strQuery = "SELECT ItemCode,ItemName,Spesifikasi,OAssetsManagement.StatusEnabled,OCategories.Deskripsi AS DeskripsiKategori,dbo.Categories1.Deskripsi AS DeskripsiSubKategori,V_Divisi.NamaDivisi " & _
                        " FROM dbo.OAssetsManagement " & _
                        " LEFT OUTER JOIN dbo.OCategories ON OCategories.IDCategories = OAssetsManagement.IDCategories" & _
                        " LEFT OUTER JOIN dbo.Categories1 ON Categories1.IDSub = OAssetsManagement.IDSub" & _
                        " LEFT OUTER JOIN V_DIVISI On V_DIVISI.KOdeDivisi COLLATE DATABASE_DEFAULT =OAssetsManagement.KodeCabang COLLATE DATABASE_DEFAULT" & _
                        " Where OAssetsManagement.ID='" & Trim(txtID.Text) & "'"

            Call KoneksiDB_EMAIL()
            cmd = New SqlCommand(strQuery, KoneksiDBEmail)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                txtItemCode.Text = dr.GetString(0)
                txtItemName.Text = dr.GetString(1)
                txtSpesifikasi.Text = dr.GetString(2)

                If dr.GetString(3) = "Y" Then
                    chkStatusEnabled.Checked = True
                Else
                    chkStatusEnabled.Checked = False
                End If

                cmbKategori.Text = dr.GetString(4)
                cmbSub.Text = dr.GetString(5)
                cmbCabang.Text = dr.GetString(6)


            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


        

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call AUD_ASSETS("UPDATE-ASSETS")
        frmMasterNewAssets.LoadDetailAssets()
    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "SELECT PrcCode,PrcName FROM dbo.OPRC Where PrcCode Not Like 'Cent%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Sub AUD_ASSETS(strFunction As String)
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_MasterAssetManagement]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("ID", Trim(txtID.Text))
            command.Parameters.AddWithValue("Source", "1")

            command.Parameters.AddWithValue("KodeCabang", Trim(cmbCabang.SelectedValue))
            command.Parameters.AddWithValue("ItemCode", Trim(txtItemCode.Text))
            command.Parameters.AddWithValue("ItemName", Trim(txtItemName.Text))
            command.Parameters.AddWithValue("Spesifikasi", Trim(txtSpesifikasi.Text))
            command.Parameters.AddWithValue("IDCategories", Trim(cmbKategori.SelectedValue))
            command.Parameters.AddWithValue("IDSub", Trim(cmbSub.SelectedValue))
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


End Class