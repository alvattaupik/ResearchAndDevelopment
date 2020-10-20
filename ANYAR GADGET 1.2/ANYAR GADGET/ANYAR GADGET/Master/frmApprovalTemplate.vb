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
        LoadComboBox(cmbKodeTemplate, "SELECT ID,NamaPegawai FROM dbo.OEmployee", "ID", "NamaPegawai", KoneksiDBEmail)
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

    End Sub
End Class