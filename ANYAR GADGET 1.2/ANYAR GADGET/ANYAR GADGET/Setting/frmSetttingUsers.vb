Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSetttingUsers

    Private Sub frmSetttingUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picNew_Click(sender As Object, e As EventArgs) Handles picNew.Click
        txtEmployeeID.Text = ""
        txtNamaPegawai.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbLocation.Text = ""
        cmbManager.Text = ""
        cmbLocation.Enabled = True
        cmbManager.Enabled = True
        cboAktif.Enabled = True
        cboAktif.Checked = True
        txtEmployeeID.Enabled = False
        txtNamaPegawai.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        picBrowsePegawai.Enabled = True
        btnAksi.Text = "Add"

        dgvDetailMenu.DataSource = Nothing
        dgvDetailMenu.Rows.Clear()

        dgvHeaderMenu.DataSource = Nothing
        dgvHeaderMenu.Rows.Clear()

        dgvLocationControl.DataSource = Nothing
        dgvLocationControl.Rows.Clear()


    End Sub

    Private Sub picFind_Click(sender As Object, e As EventArgs) Handles picFind.Click
        btnAksi.Text = "Update"
        txtCariHeader.Text = ""
        txtEmployeeID.Text = ""
        txtNamaPegawai.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        cmbLocation.Text = ""
        cmbManager.Text = ""
        cmbLocation.Enabled = True
        cmbManager.Enabled = True
        txtCariHeader.Text = ""
        txtEmployeeID.Enabled = False
        txtNamaPegawai.Enabled = True
        txtPassword.Enabled = True
        txtUsername.Enabled = True
        cboAktif.Enabled = True
        dgvDetailMenu.DataSource = Nothing
        dgvDetailMenu.Rows.Clear()

        dgvHeaderMenu.DataSource = Nothing
        dgvHeaderMenu.Rows.Clear()

        dgvLocationControl.DataSource = Nothing
        dgvLocationControl.Rows.Clear()


    End Sub

    Private Sub btnAksi_Click(sender As Object, e As EventArgs) Handles btnAksi.Click
        If btnAksi.Text = "Ok" Then
            Me.Dispose()
        End If

        AU_Users(btnAksi.Text)

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
       Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 And Microsoft.VisualBasic.Left(txtUsername.Text, 1) <> "*" Then

            F_Users("CariUser")
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            cmbLocation.Enabled = True
            cmbManager.Enabled = True
        End If
        If Tombol = 13 And Microsoft.VisualBasic.Left(txtUsername.Text, 1) = "*" Then
            Dim frm As New frmBrowseUsers
            frm.Show()
        End If

        Exit Sub

    End Sub

    Sub F_Users(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_Find_Users]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("EmployeeNameIN", Trim(txtNamaPegawai.Text))

            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("UserNameLoginIN", Trim(txtUsername.Text))

            command.Parameters.Add("UserNameLoginOUT", SqlDbType.VarChar, 100)
            command.Parameters("UserNameLoginOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("PasswordLoginOut", SqlDbType.VarChar, 100)
            command.Parameters("PasswordLoginOut").Direction = ParameterDirection.Output

            command.Parameters.Add("KodeManagerOut", SqlDbType.VarChar, 100)
            command.Parameters("KodeManagerOut").Direction = ParameterDirection.Output

            command.Parameters.Add("NamaManagerOut", SqlDbType.VarChar, 100)
            command.Parameters("NamaManagerOut").Direction = ParameterDirection.Output

            command.Parameters.Add("LocationCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("LocationCodeOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("LocationNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("LocationNameOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("StatusAktifOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusAktifOUT").Direction = ParameterDirection.Output

      
            command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
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


            If MstrErrorCode = "E-00" Or MstrErrorCode = "E-00" Then
                DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
                ClearAfterAdd()
                Exit Sub
            Else
                DisplayPesanOK("Data Ditemukan", frmMainMenu.txtPesanError, 1000)
                txtEmployeeID.Text = command.Parameters("EmployeeIDOUT").Value.ToString()
                txtUsername.Enabled = False
                txtNamaPegawai.Text = command.Parameters("EmployeeNameOUT").Value.ToString()
                cmbLocation.SelectedValue = command.Parameters("LocationCodeOUT").Value.ToString()
                cmbLocation.Text = command.Parameters("LocationNameOUT").Value.ToString()
                txtUsername.Text = command.Parameters("UserNameLoginOUT").Value.ToString()
                txtPassword.Text = command.Parameters("PasswordLoginOUT").Value.ToString()
                cmbManager.Text = command.Parameters("NamaManagerOUT").Value.ToString()
                cmbManager.SelectedValue = command.Parameters("KodeManagerOUT").Value.ToString()

                If command.Parameters("StatusAktifOUT").Value.ToString() = "Y" Then
                    cboAktif.Checked = True
                Else
                    cboAktif.Checked = False
                End If

                LoadHeadermenu()

            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub








    Sub AU_Users(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AU_Users]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("EmployeeIDIN", Trim(txtEmployeeID.Text))
            command.Parameters.AddWithValue("EmployeeNameIN", Trim(txtNamaPegawai.Text))
            command.Parameters.AddWithValue("UserNameLoginIN", Trim(txtUsername.Text))
            command.Parameters.AddWithValue("PasswordLoginIN", Trim(txtPassword.Text))
            command.Parameters.AddWithValue("KodeManagerIN", Trim(cmbManager.SelectedValue))
            command.Parameters.AddWithValue("LocationCodeIN", Trim(cmbLocation.SelectedValue))
            If cboAktif.Checked = True Then
                command.Parameters.AddWithValue("StatusAktifIn", Trim("Y"))
            Else
                command.Parameters.AddWithValue("StatusAktifIn", Trim("N"))
            End If
            command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
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
                Exit Sub
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
                If strFunction = "Add" Then
                    ClearAfterAdd()
                End If
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Sub ClearAfterAdd()
        btnAksi.Text = "OK"
        txtCariHeader.Text = ""
        txtEmployeeID.Text = ""
        txtNamaPegawai.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        cmbLocation.Text = ""
        cmbManager.Text = ""

        cmbLocation.Enabled = True
        cmbManager.Enabled = True

        txtCariHeader.Text = ""
        txtEmployeeID.Enabled = False
        txtNamaPegawai.Enabled = True
        txtPassword.Enabled = True
        txtUsername.Enabled = True

        cboAktif.Enabled = True
        cboAktif.Checked = True

        dgvDetailMenu.DataSource = Nothing
        dgvDetailMenu.Rows.Clear()

        dgvHeaderMenu.DataSource = Nothing
        dgvHeaderMenu.Rows.Clear()

        dgvLocationControl.DataSource = Nothing
        dgvLocationControl.Rows.Clear()

    End Sub


    Sub LoadHeadermenu()

        Dim strQuery2 As String = "SELECT HeaderMenu,Deskripsi,StatusEnabled FROM V_DaftarHeaderMenuUser WHERE  UsernameLogin='" & txtUsername.Text & "'AND KodeAplikasi='AG' AND Deskripsi like '%" & txtCariHeader.Text & "%'"
        Call KoneksiDB_EMAIL()

        cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgvHeaderMenu.Columns.Add("HeaderMenu", "HeaderMenu")
        dgvHeaderMenu.Columns.Add("Deskripsi", "Deskripsi")
        Dim chk As New DataGridViewCheckBoxColumn()
        dgvHeaderMenu.Columns.Add(chk)
        chk.HeaderText = "StatusEnabled"
        chk.Name = "StatusEnabled"

        chk.TrueValue = "Y"
        chk.FalseValue = "N"

        dgvHeaderMenu.Columns(0).ReadOnly = True
        dgvHeaderMenu.Columns(1).ReadOnly = True
        dgvHeaderMenu.Columns(2).ReadOnly = False

        With table
            For i = 0 To table.Rows.Count - 1
                dgvHeaderMenu.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
            Next

        End With

        LoadListControlCabang()

        Exit Sub


    End Sub



    Sub LoadListControlCabang()
        dgvLocationControl.DataSource = Nothing
        dgvLocationControl.Rows.Clear()
        dgvLocationControl.Columns.Clear()

        Dim strQuery3 As String = "SELECT OLocControlUsers.KodeLocation,NamaLocation,StatusEnabled FROM dbo.OLocControlUsers" & _
              " LEFT OUTER JOIN dbo.OLocation ON OLocation.KodeLocation = OLocControlUsers.KodeLocation" & _
              " Where OLocControlUsers.UsernameLogin='" & txtUsername.Text & "'  AND OLocControlUsers.KodeAplikasi='" & MstrKodeAplikasi & "'"

        Call KoneksiDB_EMAIL()

        cmd = New SqlCommand(strQuery3, KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgvLocationControl.Columns.Add("KodeLocation", "KodeLocation")
        dgvLocationControl.Columns.Add("NamaLocation", "NamaLocation")
        Dim chk As New DataGridViewCheckBoxColumn()
        dgvLocationControl.Columns.Add(chk)
        chk.HeaderText = "StatusEnabled"
        chk.Name = "StatusEnabled"

        chk.TrueValue = "Y"
        chk.FalseValue = "N"

        dgvLocationControl.Columns(0).ReadOnly = True
        dgvLocationControl.Columns(1).ReadOnly = True
        dgvLocationControl.Columns(2).ReadOnly = False

        With table
            For i = 0 To table.Rows.Count - 1
                dgvLocationControl.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
            Next

        End With



    End Sub


    Private Sub cmbHeaderMenu_Click(sender As Object, e As EventArgs) Handles cmbHeaderMenu.Click
        Dim strQuery As String = "Select KodeObjectHeader,Deskripsi From V_HeaderComboMenuAplikasi Where UserNameLogin='" & txtUsername.Text & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'"
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbHeaderMenu, strQuery, "KodeObjectHeader", "Deskripsi", KoneksiDBEmail)

        dgvDetailMenu.DataSource = Nothing
        dgvDetailMenu.Rows.Clear()
    End Sub

    Private Sub cmbListForm_Click(sender As Object, e As EventArgs) Handles cmbListForm.Click
        Dim strQuery As String = "Select KodeForm,Deskripsi From V_HeaderComboFormUser Where UserNameLogin='" & txtUsername.Text & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'"
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbListForm, strQuery, "KodeForm", "Deskripsi", KoneksiDBEmail)

        dgvDetailForm.DataSource = Nothing
        dgvDetailForm.Rows.Clear()
    End Sub

    Private Sub cmbManager_Click(sender As Object, e As EventArgs) Handles cmbManager.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbManager, "SELECT ID,NamaPegawai FROM dbo.OEmployee WHERE StatusEnabled='Y'", "ID", "NamaPegawai", KoneksiDBEmail)
    End Sub

    Private Sub cmbLocation_Click(sender As Object, e As EventArgs) Handles cmbLocation.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbLocation, "SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi", "KodeDivisi", "NamaDivisi", KoneksiDBEmail)
    End Sub

    Private Sub cmbHeaderMenu_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeaderMenu.SelectionChangeCommitted
        Dim strQuery2 As String = "SELECT DetailMenu,Deskripsi,StatusEnabled FROM V_DaftarDetailMenuUser WHERE  UserNameLogin='" & txtUsername.Text & "' AND Header='" & cmbHeaderMenu.SelectedValue & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'"
        Call KoneksiDB_EMAIL()
        Try
            dgvDetailMenu.DataSource = Nothing
            dgvDetailMenu.Rows.Clear()
            dgvDetailMenu.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            dgvDetailMenu.Columns.Add("DetailMenu", "DetailMenu")
            dgvDetailMenu.Columns.Add("Deskripsi", "Deskripsi")
            Dim chk As New DataGridViewCheckBoxColumn()
            dgvDetailMenu.Columns.Add(chk)
            chk.HeaderText = "StatusEnabled"
            chk.Name = "StatusEnabled"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgvDetailMenu.Columns(0).ReadOnly = True
            dgvDetailMenu.Columns(1).ReadOnly = True
            dgvDetailMenu.Columns(2).ReadOnly = False

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvDetailMenu.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next


            End With

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub cmbListForm_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbListForm.SelectionChangeCommitted
        Dim strQuery2 As String = "SELECT DetailMenu,Deskripsi,StatusEnabled FROM V_DaftarDetailFormUser WHERE  UserNameLogin='" & txtUsername.Text & "' AND Header='" & cmbListForm.SelectedValue & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'"
        Call KoneksiDB_EMAIL()

        Try
            dgvDetailForm.DataSource = Nothing
            dgvDetailForm.Rows.Clear()
            dgvDetailForm.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            dgvDetailForm.Columns.Add("DetailMenu", "DetailMenu")
            dgvDetailForm.Columns.Add("Deskripsi", "Deskripsi")
            Dim chk As New DataGridViewCheckBoxColumn()
            dgvDetailForm.Columns.Add(chk)
            chk.HeaderText = "StatusEnabled"
            chk.Name = "StatusEnabled"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgvDetailForm.Columns(0).ReadOnly = True
            dgvDetailForm.Columns(1).ReadOnly = True
            dgvDetailForm.Columns(2).ReadOnly = False

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvDetailForm.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next


            End With


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub picBrowsePegawai_Click(sender As Object, e As EventArgs) Handles picBrowsePegawai.Click
        Dim frm As New frmBrowseEmployeeSetting
        frm.Show()
    End Sub

    Private Sub btnCariUser_Click(sender As Object, e As EventArgs) Handles btnCariUser.Click
        F_Users("CariUser")
    End Sub

    Private Sub btnUpdateHdrMenu_Click(sender As Object, e As EventArgs) Handles btnUpdateHdrMenu.Click
        Call AUDRS_UpdateMenu("UpdateHDRMenu", dgvHeaderMenu)
    End Sub


    Sub AUDRS_UpdateMenu(strFunction As String, dgv As DataGridView)

        For i As Integer = 0 To dgv.Rows.Count - 1

            Try
                KoneksiDB_EMAIL()
                Dim command As SqlCommand
                command = New SqlCommand("[tmsp_AUD_MenuAplikasi]", KoneksiDBEmail)
                Dim adapter As New SqlDataAdapter(command)
                command.CommandType = CommandType.StoredProcedure

                If strFunction = "UpdateHDRMenu" Then
                    command.Parameters.AddWithValue("KodeHeader", Trim(dgv.Rows(i).Cells(0).Value))
                    command.Parameters.AddWithValue("KodeDetail", Trim(""))
                End If


                If strFunction = "UpdateDetailMenu" Then
                    command.Parameters.AddWithValue("KodeHeader", Trim(cmbHeaderMenu.SelectedValue))
                    command.Parameters.AddWithValue("KodeDetail", Trim(dgv.Rows(i).Cells(0).Value))
                End If

                If strFunction = "UpdateFormMenu" Then
                    command.Parameters.AddWithValue("KodeHeader", Trim(cmbListForm.SelectedValue))
                    command.Parameters.AddWithValue("KodeDetail", Trim(dgv.Rows(i).Cells(0).Value))
                End If


                If strFunction = "UpdateLocationControl" Then
                    command.Parameters.AddWithValue("KodeHeader", Trim(dgv.Rows(i).Cells(0).Value))
                    command.Parameters.AddWithValue("KodeDetail", Trim(dgv.Rows(i).Cells(0).Value))
                End If


                command.Parameters.AddWithValue("StatusEnabled", Trim(dgv.Rows(i).Cells(2).Value))
                command.Parameters.AddWithValue("UsernameLogin", Trim(txtUsername.Text))
                command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
                command.Parameters.AddWithValue("KodeUsernameLoginTujuan", Trim(""))
                command.Parameters.AddWithValue("Function", Trim(strFunction))

                If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
                command.Connection = KoneksiDBEmail
                KoneksiDBEmail.Open()
                command.ExecuteNonQuery()

            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 5000)

            End Try

        Next

        DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)


    End Sub

    Private Sub btnUpdateDetailMenu_Click(sender As Object, e As EventArgs) Handles btnUpdateDetailMenu.Click
        If cmbHeaderMenu.Text = "" Then
            DisplayPesanError("Header Menu Harus Dipilih", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        Call AUDRS_UpdateMenu("UpdateDetailMenu", dgvDetailMenu)
    End Sub

    Private Sub btnUpdateFormObject_Click(sender As Object, e As EventArgs) Handles btnUpdateFormObject.Click
        If cmbListForm.Text = "" Then
            DisplayPesanError("List Form Harus Dipilih", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        Call AUDRS_UpdateMenu("UpdateFormMenu", dgvDetailForm)
    End Sub

    Private Sub btnUpdateLocationControl_Click(sender As Object, e As EventArgs) Handles btnUpdateLocationControl.Click
        Call AUDRS_UpdateMenu("UpdateLocationControl", dgvLocationControl)
    End Sub

    Private Sub CopyAllControlToAnotherUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyAllControlToAnotherUsersToolStripMenuItem.Click
        If txtUsername.Text <> "" Then
            MstrFungsiContextMenu = "ALL"
            MstrTempUsernameLogin = Trim(txtUsername.Text)
            frmBrowseListUserAplikasi.ShowDialog()
        End If
    End Sub

    Private Sub RefreshControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshControlToolStripMenuItem.Click
         AUDRS_CopyToUser("RefreshListMenu")
    End Sub

    Sub AUDRS_CopyToUser(strFunction As String)
        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_AUD_MenuAplikasi]", KoneksiDBEmail)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("KodeHeader", Trim(""))
        command.Parameters.AddWithValue("KodeDetail", Trim(""))
        command.Parameters.AddWithValue("StatusEnabled", Trim(""))
        command.Parameters.AddWithValue("UsernameLogin", Trim(txtUsername.Text))
        command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
        command.Parameters.AddWithValue("KodeUsernameLoginTujuan", (""))
        command.Parameters.AddWithValue("Function", Trim(strFunction))

        If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
        command.Connection = KoneksiDBEmail
        KoneksiDBEmail.Open()
        command.ExecuteNonQuery()
        DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)


    End Sub
End Class