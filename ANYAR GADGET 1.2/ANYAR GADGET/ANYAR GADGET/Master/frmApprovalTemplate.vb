Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmApprovalTemplate


    Private Sub cmbFungsi_Click(sender As Object, e As EventArgs) Handles cmbFungsi.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbFungsi, "Select KdJenisSurat,NamaSurat From JenisSurat", "KdJenisSurat", "NamaSurat", KoneksiDBEmail)
    End Sub

    Private Sub cmbKodeTemplate_Click(sender As Object, e As EventArgs) Handles cmbKodeTemplate.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKodeTemplate, "SELECT IDTemplate,NamaTemplate FROM dbo.OAPV WHERE StatusEnabled='Y'", "IDTemplate", "NamaTemplate", KoneksiDBEmail)
    End Sub

    Private Sub cmbMasterStagging_Click(sender As Object, e As EventArgs) Handles cmbMasterStagging.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbMasterStagging, "SELECT IDTemplate,NamaTemplate FROM dbo.OAPV WHERE StatusEnabled='Y'", "IDTemplate", "NamaTemplate", KoneksiDBEmail)
    End Sub

    Private Sub cmbCariUsers_Click(sender As Object, e As EventArgs) Handles cmbCariUsers.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbCariUsers, "SELECT ID,NamaPegawai FROM dbo.OEmployee", "ID", "NamaPegawai", KoneksiDBEmail)
    End Sub



    Private Sub frmApprovalTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListTemplate, "Select * From OAPV Where IDtemplate Like '%" & txtCariTemplateID.Text & "%' Or NamaTemplate Like '%" & Trim(txtNamaTemplate.Text) & "%'", KoneksiDBEmail)
    End Sub

    Private Sub picNew_Click(sender As Object, e As EventArgs) Handles picNew.Click
        txtKodetemplate.Text = ""
        txtNamaTemplate.Text = ""
        cmbFungsi.Text = ""
        chkStatusEnabled.Checked = True
        btnProses.Text = "Add"
    End Sub

    Private Sub picSearch_Click(sender As Object, e As EventArgs) Handles picSearch.Click
        txtKodetemplate.Text = ""
        txtNamaTemplate.Text = ""
        cmbFungsi.Text = ""
        chkStatusEnabled.Checked = True
        btnProses.Text = "Update"
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()


        If btnProses.Text = "Add" Then
            Call AU_MASTER_APPROVAl("ADD-APPROVAL-TEMPLATE")
          
        End If

        If btnProses.Text = "Update" Then
            Call AU_MASTER_APPROVAl("U-APPROVAL-TEMPLATE")
        End If


    End Sub



    Sub LoadMasterStagging()
        Dim strQuery As String = "SELECT NamaPegawai,Jabatan,EmpID,ApvID FROM dbo.APV1" & _
                                " LEFT OUTER JOIN dbo.OEmployee ON ID=EmpID WHere dbo.APV1.IDTemplate='" & cmbKodeTemplate.SelectedValue & "'"


        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvMasterStagging, strQuery, KoneksiDBEmail)
    End Sub


    Sub AU_MASTER_APPROVAl(strFunction As String)
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_MASTER_APPROVAL_TEMPLATE]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("IDTemplate", Trim(txtKodetemplate.Text))
            command.Parameters.AddWithValue("NamaTemplate", Trim(txtNamaTemplate.Text))
            command.Parameters.AddWithValue("Fungsi", Trim(cmbFungsi.Text))
            command.Parameters.AddWithValue("KodeJenisSurat", Trim(cmbFungsi.SelectedValue))
            If chkStatusEnabled.Checked = True Then
                command.Parameters.AddWithValue("StatusEnabled", Trim("Y"))
            Else
                command.Parameters.AddWithValue("StatusEnabled", Trim("N"))
            End If


            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 100)
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
                Exit Sub
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
                txtKodetemplate.Text = ""
                txtNamaTemplate.Text = ""
                cmbFungsi.Text = ""
                chkStatusEnabled.Checked = True
                btnProses.Text = "Ok"
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvListTemplate, "Select * From OAPV Where IDtemplate Like '%" & txtCariTemplateID.Text & "%' Or NamaTemplate Like '%" & Trim(txtNamaTemplate.Text) & "%'", KoneksiDBEmail)
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub dgvListTemplate_Click(sender As Object, e As EventArgs) Handles dgvListTemplate.Click
        txtKodetemplate.Text = dgvListTemplate.Item(0, dgvListTemplate.CurrentRow.Index).Value
        txtNamaTemplate.Text = dgvListTemplate.Item(1, dgvListTemplate.CurrentRow.Index).Value
        cmbFungsi.Text = dgvListTemplate.Item(2, dgvListTemplate.CurrentRow.Index).Value
        cmbFungsi.SelectedValue = dgvListTemplate.Item(3, dgvListTemplate.CurrentRow.Index).Value



        If dgvListTemplate.Item(4, dgvListTemplate.CurrentRow.Index).Value = "Y" Then
            chkStatusEnabled.Checked = True
        Else
            chkStatusEnabled.Checked = False
        End If
        btnProses.Text = "Update"


    End Sub

    Private Sub txtCariTemplateID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariTemplateID.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvListTemplate, "Select * From OAPV Where IDtemplate Like '%" & txtCariTemplateID.Text & "%' Or NamaTemplate Like '%" & Trim(txtNamaTemplate.Text) & "%'", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnAddNewUserStaging_Click(sender As Object, e As EventArgs) Handles btnAddNewUserStaging.Click
        If cmbKodeTemplate.SelectedValue = "" Then
            DisplayPesanError("Template ID Is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        frmBrowseMasterStagging.ShowDialog()
    End Sub

    Private Sub cmbKodeTemplate_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbKodeTemplate.SelectionChangeCommitted
        LoadMasterStagging()
    End Sub

    Private Sub RemoveUserStaging_Click(sender As Object, e As EventArgs) Handles RemoveUserStaging.Click
        If dgvMasterStagging.RowCount = 0 Then Exit Sub
        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[AU_MASTER_STAGGING]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("IDtemplate", Trim(cmbKodeTemplate.SelectedValue))
        command.Parameters.AddWithValue("APVStaggingID", (Trim(dgvMasterStagging.Item(3, dgvMasterStagging.CurrentRow.Index).Value)))
        command.Parameters.AddWithValue("EmpID", (Trim(dgvMasterStagging.Item(2, dgvMasterStagging.CurrentRow.Index).Value)))

        command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
        command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
        command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
        command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output

        command.Parameters.AddWithValue("Function", Trim("D-UserStagging"))


        If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
        command.Connection = KoneksiDBEmail
        KoneksiDBEmail.Open()
        command.ExecuteNonQuery()

        MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
        MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()

        If MstrErrorCode = "E-00" Then
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            LoadMasterStagging()
            'Me.Dispose()
        End If

    End Sub

    Private Sub cmbMasterStagging_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMasterStagging.SelectionChangeCommitted
        Dim strQuery As String = "SELECT NamaPegawai,Jabatan FROM dbo.APV1" & _
                               " LEFT OUTER JOIN dbo.OEmployee ON ID=EmpID WHere dbo.APV1.IDTemplate='" & cmbMasterStagging.SelectedValue & "'"


        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListUsersMaster, strQuery, KoneksiDBEmail)



        Dim strQuery2 As String = "SELECT NamaPegawai,Jabatan FROM dbo.OEmployee1" & _
                                " LEFT OUTER JOIN dbo.OEmployee ON EmpID=ID" & _
                                " Where TemplateID='" & Trim(cmbMasterStagging.SelectedValue) & "'"


        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListUsersAffected, strQuery2, KoneksiDBEmail)



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[AU_MASTER_STAGGING]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("IDtemplate", Trim(cmbMasterStagging.SelectedValue))
        command.Parameters.AddWithValue("APVStaggingID", (""))
        command.Parameters.AddWithValue("EmpID", (Trim(cmbCariUsers.SelectedValue)))

        command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
        command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
        command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
        command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output

        command.Parameters.AddWithValue("Function", Trim("A-AffectedUsers"))


        If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
        command.Connection = KoneksiDBEmail
        KoneksiDBEmail.Open()
        command.ExecuteNonQuery()

        MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
        MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()

        If MstrErrorCode = "E-00" Then
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            LoadAffectedUsers()
            'Me.Dispose()
        End If

    End Sub


    Sub LoadAffectedUsers()
        Dim strQuery2 As String = "SELECT NamaPegawai,Jabatan,EmpID,TemplateID FROM dbo.OEmployee1" & _
                         " LEFT OUTER JOIN dbo.OEmployee ON EmpID=ID" & _
                         " Where TemplateID='" & Trim(cmbMasterStagging.SelectedValue) & "'"
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListUsersAffected, strQuery2, KoneksiDBEmail)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[AU_MASTER_STAGGING]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("IDtemplate", Trim((dgvListUsersAffected.Item(3, dgvListUsersAffected.CurrentRow.Index).Value)))
        command.Parameters.AddWithValue("APVStaggingID", (""))
        command.Parameters.AddWithValue("EmpID", Trim((dgvListUsersAffected.Item(2, dgvListUsersAffected.CurrentRow.Index).Value)))

        command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
        command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
        command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
        command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output

        command.Parameters.AddWithValue("Function", Trim("D-AffectedUsers"))


        If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
        command.Connection = KoneksiDBEmail
        KoneksiDBEmail.Open()
        command.ExecuteNonQuery()

        MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
        MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()

        If MstrErrorCode = "E-00" Then
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            LoadAffectedUsers()
            'Me.Dispose()
        End If

    End Sub
End Class