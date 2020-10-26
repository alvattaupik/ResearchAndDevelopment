Imports System.Data
Imports System.Data.SqlClient
Public Class frmMasterKontenBantuan

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

        dgvKonten.DataSource = Nothing
        dgvKonten.Rows.Clear()
        LoadDetailKonten()

    End Sub



    Sub LoadDetailKonten()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ID,NamaKonten,StatusEnabled FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & txtIDCategories.Text & "' and IDSubKategori='" & txtIDSubCategories.Text & "' AND StatusEnabled='Y'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvKonten.DataSource = myBindingSource

        dgvKonten.DataSource = table
        dgvKonten.Refresh()
        dgvKonten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvKonten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKonten.AutoResizeColumns()

    End Sub



    Sub LoadDetailKonten2()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ID,NamaKonten,StatusEnabled FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & txtIDCategories.Text & "' and IDSubKategori='" & txtIDSubCategories.Text & "' AND StatusEnabled='Y'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvKonten.DataSource = myBindingSource

        dgvKonten.DataSource = table
        dgvKonten.Refresh()
        dgvKonten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvKonten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKonten.AutoResizeColumns()

    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "NamaKonten Like '%" & txtCari.Text & "%'"
                dgvKonten.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub picCariLampiran_Click(sender As Object, e As EventArgs) Handles picCariLampiran.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathLampiran.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnAddLampiran_Click(sender As Object, e As EventArgs) Handles btnAddLampiran.Click
        If txtPathLampiran.Text = "" Then
            DisplayPesanError("Attachments Is Required, Please Browse", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If txtNamaFile.Text = "" Then
            DisplayPesanError("Nama File Harus Di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        dgvListLampiran.Rows.Add("", txtNamaFile.Text, txtPathLampiran.Text)
        lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
        dgvListLampiran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListLampiran.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListLampiran.AutoResizeColumns()
        txtPathLampiran.Text = ""
        txtNamaFile.Text = ""
    End Sub

    Private Sub btnHapusLampiran_Click(sender As Object, e As EventArgs) Handles btnHapusLampiran.Click
        Dim row As Integer
        Dim index As Integer

        On Error Resume Next

        If dgvListLampiran.RowCount = 0 Then Exit Sub

        If dgvListLampiran.Item(0, dgvListLampiran.CurrentRow.Index).Value = "" Then


            index = dgvListLampiran.SelectedRows.Item(0).Index
            selRow = dgvListLampiran.Rows.Item(index)
            dgvListLampiran.Rows.Remove(selRow)
            row = row - 1
            lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
        End If


        If dgvListLampiran.Item(0, dgvListLampiran.CurrentRow.Index).Value <> "" Then


            Call DeleteLampiranKonten("DELETE-LAMPIRAN", dgvListLampiran)


    
            lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
        End If


    End Sub

    Private Sub cmbKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbKategori.SelectionChangeCommitted
        txtIDCategories.Text = cmbKategori.SelectedValue
        txtNamaCategories.Text = cmbKategori.Text
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnProses.Text = "Add"
        txtKodeKonten.Text = ""
        txtDeskripsi.Text = ""
        dgvListLampiran.DataSource = Nothing
        dgvListLampiran.Rows.Clear()
        chkAktif.CheckState = CheckState.Checked
        If txtIDCategories.Text = "" Then
            DisplayPesanError("Category Is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If txtIDSubCategories.Text = "" Then
            DisplayPesanError("Sub Category Is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

    End Sub





    Sub AUDRS_ADDKONTEN(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AUDR_Content]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDIN", Trim(txtKodeKonten.Text))

            command.Parameters.Add("IDOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(txtIDCategories.Text))
            command.Parameters.AddWithValue("IDSubCategoriesIN", Trim(txtIDSubCategories.Text))
            command.Parameters.AddWithValue("NamaKontenIN", Trim(txtDeskripsi.Text))
            command.Parameters.AddWithValue("NamaExternalIN", Trim(""))
            command.Parameters.AddWithValue("KodeExternalIN", Trim(""))
            command.Parameters.AddWithValue("IDEmployeeIN", Trim(MstrKodePegawai))
            command.Parameters.AddWithValue("StatusEnabledIN", Trim(strStatusEnabled))
            command.Parameters.AddWithValue("NamaFileIN", Trim(txtNamaFile.Text))
            command.Parameters.AddWithValue("LokasiFileIN", Trim(""))
            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            txtKodeKonten.Text = command.Parameters("IDOUT").Value.ToString()

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
            command.Parameters.AddWithValue("IDIN", Trim(txtKodeKonten.Text))

            command.Parameters.Add("IDOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(txtIDCategories.Text))
            command.Parameters.AddWithValue("IDSubCategoriesIN", Trim(txtIDSubCategories.Text))
            command.Parameters.AddWithValue("NamaKontenIN", Trim(txtDeskripsi.Text))
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

            UpdatePathLampiran(MstrpathAttatchments, txtKodeKonten.Text, command.Parameters("IDOUT").Value.ToString())


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub UpdatePathLampiran(strPathLampiran As String, strIDKonten As String, strIDLampiran As String)
        Try

            Call KoneksiDB_EMAIL()
            Dim str As String
            str = "UPDATE dbo.Help1" & _
                  " SET LokasiFile='" & strPathLampiran & "'" & _
                  " WHERE AttachID='" & strIDLampiran & "' AND ID='" & strIDKonten & "'"
            cmd = New SqlCommand(str, KoneksiDBEmail)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)

        End Try

    End Sub



    Sub DeleteLampiranKonten(strFunction As String, dgv As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AUDR_Content]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDIN", Trim(txtKodeKonten.Text))

            command.Parameters.Add("IDOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(txtIDCategories.Text))
            command.Parameters.AddWithValue("IDSubCategoriesIN", Trim(txtIDSubCategories.Text))
            command.Parameters.AddWithValue("NamaKontenIN", Trim(txtDeskripsi.Text))
            command.Parameters.AddWithValue("NamaExternalIN", Trim(""))
            command.Parameters.AddWithValue("KodeExternalIN", Trim(dgv.Rows(intRow).Cells(0).Value))
            command.Parameters.AddWithValue("IDEmployeeIN", Trim(MstrKodePegawai))
            command.Parameters.AddWithValue("StatusEnabledIN", Trim(strStatusEnabled))
            command.Parameters.AddWithValue("NamaFileIN", Trim(dgv.Rows(intRow).Cells(1).Value))
            command.Parameters.AddWithValue("LokasiFileIN", Trim(dgv.Rows(intRow).Cells(2).Value))
            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            'txtKodeKonten.Text = command.Parameters("IDOUT").Value.ToString()

            'GetExtentionfile((dgv.Rows(intRow).Cells(2).Value))
            'CopyFileKeDirectoryAttachment(command.Parameters("IDOUT").Value.ToString(), Trim(dgv.Rows(intRow).Cells(2).Value))

            DisplayPesanOK("Attachment Deleted Successfully", frmMainMenu.txtPesanError, 1000)
            LoadDetailLampiran()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





    Sub Bersihkan()
        txtDeskripsi.Text = ""
        txtNamaFile.Text = ""
        txtPathLampiran.Text = ""
        dgvListLampiran.DataSource = Nothing
        dgvListLampiran.Rows.Clear()
        btnProses.Text = "OK"
    End Sub


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        If chkAktif.CheckState = CheckState.Checked Then
            strStatusEnabled = "Y"
        Else
            strStatusEnabled = "N"
        End If


        If btnProses.Text = "OK" Then
            Me.Dispose()
            Exit Sub
        End If


        If btnProses.Text = "Add" Then
            If txtDeskripsi.Text = "" Then
                DisplayPesanError("Deskripsi is Required", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If

            Call AUDRS_ADDKONTEN("ADD-KONTEN")

            For Me.intRow = 0 To dgvListLampiran.Rows.Count - 1

                Call AUDRS_ADDLampiranKonten("ADD-LAMPIRAN", dgvListLampiran)

            Next

            DisplayPesanOK("Attachments Added Successfully", frmMainMenu.txtPesanError, 1000)

            Call Bersihkan()
            LoadDetailKonten()
        End If




        If btnProses.Text = "Update" Then

            If txtDeskripsi.Text = "" Then
                DisplayPesanError("Deskripsi is Required", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If


            Call AUDRS_ADDKONTEN("UPDATE-KONTEN")

            For Me.intRow = 0 To dgvListLampiran.Rows.Count - 1

                If Trim(dgvListLampiran.Rows(intRow).Cells(0).Value) = "" Then
                    Call AUDRS_ADDLampiranKonten("ADD-LAMPIRAN", dgvListLampiran)
                End If



            Next

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

            Call Bersihkan()
            LoadDetailKonten()
        End If



    End Sub


    Private Sub txtIDCategories_TextChanged(sender As Object, e As EventArgs) Handles txtIDCategories.TextChanged
        txtNamaCategories.Text = cmbKategori.Text
    End Sub

    Private Sub txtIDSubCategories_TextChanged(sender As Object, e As EventArgs) Handles txtIDSubCategories.TextChanged
        txtNamaSubs.Text = cmbSubKategori.Text
    End Sub

    Private Sub dgvKonten_Click(sender As Object, e As EventArgs) Handles dgvKonten.Click
        If dgvKonten.Rows.Count = 0 Then Exit Sub


        txtDeskripsi.Text = dgvKonten.Item(1, dgvKonten.CurrentRow.Index).Value
        txtKodeKonten.Text = dgvKonten.Item(0, dgvKonten.CurrentRow.Index).Value

        If dgvKonten.Item(2, dgvKonten.CurrentRow.Index).Value = "Y" Then
            chkAktif.Checked = True
        Else
            chkAktif.Checked = False
        End If


        btnProses.Text = "Update"

        LoadDetailLampiran()
        'Call KoneksiDB_EMAIL()
        'LoadDataGrid(dgvListLampiran, "SELECT AttachID,NamaFile,LokasiFile FROM dbo.Help1 WHERE ID='" & txtKodeKonten.Text & "'", KoneksiDBEmail)

    End Sub


    Sub LoadDetailLampiran()
        Dim strQuery2 As String = "SELECT AttachID,NamaFile,LokasiFile FROM dbo.Help1 WHERE ID='" & txtKodeKonten.Text & "'"
        Call KoneksiDB_EMAIL()

        Try
            dgvListLampiran.DataSource = Nothing
            dgvListLampiran.Rows.Clear()
            dgvListLampiran.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            dgvListLampiran.Columns.Add("AttachID", "AttachID")
            dgvListLampiran.Columns.Add("NamaFile", "NamaFile")
            dgvListLampiran.Columns.Add("LokasiFile", "LokasiFile")
          
            dgvListLampiran.Columns(0).ReadOnly = True
            dgvListLampiran.Columns(1).ReadOnly = True
            dgvListLampiran.Columns(2).ReadOnly = False

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvListLampiran.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next
            End With


        Catch ex As Exception
            DisplayPesanError(Err.Description & "  " & strQuery2, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

End Class