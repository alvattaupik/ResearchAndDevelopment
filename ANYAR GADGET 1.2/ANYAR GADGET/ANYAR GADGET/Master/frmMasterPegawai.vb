Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMasterPegawai
    Dim bolStatusSP As Boolean
    Private Sub btnAksi_Click(sender As Object, e As EventArgs) Handles btnAksi.Click
        If btnAksi.Text = "Ok" Then Me.Dispose()



        If btnAksi.Text = "Update" Then
            Call AU_Employee(btnAksi.Text)
        End If



        If btnAksi.Text = "Add" Then
            Call AU_Employee(btnAksi.Text)
        End If



    End Sub

    Private Sub picNew_Click(sender As Object, e As EventArgs) Handles picNew.Click
        txtEmployeeID.Text = ""

        txtNamaPegawai.Text = ""
        txtNamaPegawai.Enabled = True
        txtAlamat.Text = ""
        txtAlamat.Enabled = True
        txtAlamatEmail.Text = ""
        txtAlamatEmail.Enabled = True
        cmbFungsional.Enabled = True
        cmbFungsional.Text = ""
        cmbJabatan.Text = ""
        cmbJabatan.Enabled = True
        cboAktif.Enabled = True
        cboAktif.Checked = True

        txtNoTelp.Text = ""
        txtNoTelp.Enabled = True

        btnAksi.Text = "Add"
    End Sub

    Private Sub picFind_Click(sender As Object, e As EventArgs) Handles picFind.Click
        txtEmployeeID.Text = ""
        txtNamaPegawai.Text = ""
        txtNamaPegawai.Enabled = True
        txtAlamat.Text = ""
        txtAlamatEmail.Text = ""
        cmbFungsional.Text = ""
        cmbJabatan.Text = ""
        btnAksi.Text = "Update"
    End Sub

    Private Sub txtNamaPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPegawai.KeyPress

        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 And Microsoft.VisualBasic.Left(txtNamaPegawai.Text, 1) <> "*" Then

            F_Employee("Cari")
            txtAlamat.Enabled = True
            txtAlamatEmail.Enabled = True
            cmbFungsional.Enabled = True
            cmbJabatan.Enabled = True
        End If
        If Tombol = 13 And Microsoft.VisualBasic.Left(txtNamaPegawai.Text, 1) = "*" Then
            F_Employee2("Cari")
        End If

        Exit Sub


    End Sub



    Sub AU_Employee(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AU_Employee]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("EmployeeID", Trim(txtEmployeeID.Text))
            command.Parameters.AddWithValue("EmployeeName", Trim(txtNamaPegawai.Text))
            command.Parameters.AddWithValue("Alamat", Trim(txtAlamat.Text))
            command.Parameters.AddWithValue("Jabatan", Trim(cmbJabatan.Text))
            command.Parameters.AddWithValue("Fungsional", Trim(cmbFungsional.Text))
            command.Parameters.AddWithValue("AlamatEmail", Trim(txtAlamatEmail.Text))
            If cboAktif.Checked = True Then
                command.Parameters.AddWithValue("StatusEnabled", Trim("Y"))
            Else
                command.Parameters.AddWithValue("StatusEnabled", Trim("N"))
            End If

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
            End If

        Catch ex As Exception
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub F_Employee(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_Find_Employee]]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("EmployeeID", Trim(txtEmployeeID.Text))

            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("EmployeeName", Trim(txtNamaPegawai.Text))
            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("AlamatOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("JabatanOUT", SqlDbType.VarChar, 100)
            command.Parameters("JabatanOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("FungsionalOUT", SqlDbType.VarChar, 100)
            command.Parameters("FungsionalOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("AlamatEmailOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatEmailOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("NoTelpOut", SqlDbType.VarChar, 100)
            command.Parameters("NoTelpOut").Direction = ParameterDirection.Output
            command.Parameters.Add("StatusEnabledOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusEnabledOUT").Direction = ParameterDirection.Output
        
   


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
                Exit Sub
            Else
                DisplayPesanOK("Data Ditemukan", frmMainMenu.txtPesanError, 1000)
                txtEmployeeID.Text = command.Parameters("EmployeeIDOUT").Value.ToString()
                txtNamaPegawai.Text = command.Parameters("EmployeeNameOUT").Value.ToString()
                txtAlamat.Text = command.Parameters("AlamatOUT").Value.ToString()
                cmbJabatan.Text = command.Parameters("JabatanOUT").Value.ToString()
                cmbFungsional.Text = command.Parameters("FungsionalOUT").Value.ToString()
                txtAlamatEmail.Text = command.Parameters("AlamatEmailOUT").Value.ToString()
                txtNoTelp.Text = command.Parameters("NoTelpOut").Value.ToString()

                If command.Parameters("StatusEnabledOUT").Value.ToString() = "Y" Then
                    cboAktif.Checked = True
                Else
                    cboAktif.Checked = False
                End If

            End If

        Catch ex As Exception
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





    Sub F_Employee2(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_Find_Employee]]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("EmployeeID", Trim(txtEmployeeID.Text))

            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("EmployeeName", Trim(txtNamaPegawai.Text))
            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("AlamatOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("JabatanOUT", SqlDbType.VarChar, 100)
            command.Parameters("JabatanOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("FungsionalOUT", SqlDbType.VarChar, 100)
            command.Parameters("FungsionalOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("AlamatEmailOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatEmailOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("NoTelpOut", SqlDbType.VarChar, 100)
            command.Parameters("NoTelpOut").Direction = ParameterDirection.Output
            command.Parameters.Add("StatusEnabledOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusEnabledOUT").Direction = ParameterDirection.Output




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
                Exit Sub
            Else
                DisplayPesanOK("Data Ditemukan", frmMainMenu.txtPesanError, 1000)





                If command.Parameters("StatusEnabledOUT").Value.ToString() = "Y" Then
                    cboAktif.Checked = True
                Else
                    cboAktif.Checked = False
                End If

            End If

        Catch ex As Exception
            DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub




End Class