Imports System.Data
Imports System.Data.SqlClient
Public Class frmMasterParameterUji

    Private myBindingSource As New BindingSource()
    Public selRow As New DataGridViewRow
    Dim intRow As Integer
    Public strStatusEnabled As String

    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE  StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub
    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE  StatusEnabled='Y' AND Cast(IDCategories AS varchar(100))='" & cmbKategori.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub
    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        txtIDSubCategories.Text = cmbSubKategori.SelectedValue
        txtNamaSubs.Text = cmbSubKategori.Text

        dgvListParameter.DataSource = Nothing
        dgvListParameter.Rows.Clear()
        LoadDetailKonten()
    End Sub
    Sub LoadDetailKonten()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ParameterUji,Catatan,ID FROM dbo.OParameterUji Where Cast(IDCategories AS varchar(100))='" & txtIDCategories.Text & "' and IDSub='" & txtIDSubCategories.Text & "'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvListParameter.DataSource = myBindingSource

        dgvListParameter.DataSource = table
        dgvListParameter.Refresh()
        dgvListParameter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListParameter.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListParameter.AutoResizeColumns()

        lblJumlahParameterUji.Text = "Jumlah Parameter Uji : " & dgvListParameter.RowCount

    End Sub
    Private Sub cmbKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbKategori.SelectionChangeCommitted
        txtIDCategories.Text = cmbKategori.SelectedValue
        txtNamaCategories.Text = cmbKategori.Text
    End Sub

    Sub AUDRS_ADDKONTEN(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AUDR_Content]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDIN", Trim(txtKodeParameter.Text))

            command.Parameters.Add("IDOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(txtIDCategories.Text))
            command.Parameters.AddWithValue("IDSubCategoriesIN", Trim(txtIDSubCategories.Text))
            command.Parameters.AddWithValue("NamaKontenIN", Trim(txtParameterUji.Text))
            command.Parameters.AddWithValue("NamaExternalIN", Trim(""))
            command.Parameters.AddWithValue("KodeExternalIN", Trim(""))
            command.Parameters.AddWithValue("IDEmployeeIN", Trim(MstrKodePegawai))
            command.Parameters.AddWithValue("StatusEnabledIN", Trim(strStatusEnabled))
            command.Parameters.AddWithValue("NamaFileIN", Trim(""))
            command.Parameters.AddWithValue("LokasiFileIN", Trim(""))
            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            txtKodeParameter.Text = command.Parameters("IDOUT").Value.ToString()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub
    Sub AUDRS_ADDLampiranKonten(strFunction As String, dgv As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AUDR_Content]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDIN", Trim(txtKodeParameter.Text))

            command.Parameters.Add("IDOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(txtIDCategories.Text))
            command.Parameters.AddWithValue("IDSubCategoriesIN", Trim(txtIDSubCategories.Text))
            command.Parameters.AddWithValue("NamaKontenIN", Trim(txtParameterUji.Text))
            command.Parameters.AddWithValue("NamaExternalIN", Trim(""))
            command.Parameters.AddWithValue("KodeExternalIN", Trim(""))
            command.Parameters.AddWithValue("IDEmployeeIN", Trim(MstrKodePegawai))
            command.Parameters.AddWithValue("StatusEnabledIN", Trim(strStatusEnabled))
            command.Parameters.AddWithValue("NamaFileIN", Trim(dgv.Rows(intRow).Cells(1).Value))
            command.Parameters.AddWithValue("LokasiFileIN", Trim(dgv.Rows(intRow).Cells(2).Value))
            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            GetExtentionfile((dgv.Rows(intRow).Cells(2).Value))
            CopyFileKeDirectoryAttachment(command.Parameters("IDOUT").Value.ToString(), Trim(dgv.Rows(intRow).Cells(2).Value))

            'UpdatePathLampiran(MstrpathAttatchments, txtKodeKonten.Text, command.Parameters("IDOUT").Value.ToString())


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Sub Bersihkan()
        txtParameterUji.Text = ""
        txtIndikator.Text = ""
        btnProses.Text = "OK"
    End Sub
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "Add" Then
            Call AUD_ParameterUji("ADD-ParameterUji")
        End If

        If btnProses.Text = "Update" Then
            Call AUD_ParameterUji("UPDATE-ParameterUji")
        End If


    End Sub
    Private Sub txtIDCategories_TextChanged(sender As Object, e As EventArgs) Handles txtIDCategories.TextChanged
        txtNamaCategories.Text = cmbKategori.Text
    End Sub

    Private Sub txtIDSubCategories_TextChanged(sender As Object, e As EventArgs) Handles txtIDSubCategories.TextChanged
        txtNamaSubs.Text = cmbSubKategori.Text
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtParameterUji.Text = ""
        txtIndikator.Text = ""
        btnProses.Text = "Add"
    End Sub
    Sub AUD_ParameterUji(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_ParameterUji]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDParameterUji", Trim(txtKodeParameter.Text))
            command.Parameters.AddWithValue("IDCategories", Trim(cmbKategori.SelectedValue))
            command.Parameters.AddWithValue("IDSub", Trim(cmbSubKategori.SelectedValue))
            command.Parameters.AddWithValue("ParameterUji", Trim(txtParameterUji.Text))
            command.Parameters.AddWithValue("Indikator", Trim(txtIndikator.Text))

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
                LoadDetailKonten()
                Bersihkan()
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub dgvListParameter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListParameter.CellClick
        txtKodeParameter.Text = dgvListParameter.Item(2, dgvListParameter.CurrentRow.Index).Value
        txtParameterUji.Text = dgvListParameter.Item(0, dgvListParameter.CurrentRow.Index).Value
        txtIndikator.Text = dgvListParameter.Item(1, dgvListParameter.CurrentRow.Index).Value
        btnProses.Text = "Update"
    End Sub

    Private Sub picCancelParameter_Click(sender As Object, e As EventArgs) Handles picCancelParameter.Click
        Call AUD_ParameterUji("DELETE-ParameterUji")
    End Sub
End Class