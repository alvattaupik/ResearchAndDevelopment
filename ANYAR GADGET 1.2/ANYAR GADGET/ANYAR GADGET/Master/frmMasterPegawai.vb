Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMasterPegawai
    Dim bolStatusSP As Boolean
    Private Sub btnAksi_Click(sender As Object, e As EventArgs) Handles btnAksi.Click
        If btnAksi.Text = "Ok" Then Me.Dispose()



        If btnAksi.Text = "Update" Then

            'Call AUDR_Employee("CekEmployee")
            If cmbFungsional.Text = "" Then
                DisplayPesanError("Fungsional Tidak Boleh Kosong !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If

            If cmbJabatan.Text = "" Then
                DisplayPesanError("Jabatan Tidak Boleh Kosong !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If


            If bolStatusSP = True Then
                DisplayPesanError("Kode Pegawai telah Digunakan", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                Call AUDR_Employee("UpdateEmployee")

                DisplayPesanOK("Operasi berhasil", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If


        End If



        If btnAksi.Text = "Add" Then

            Call AUDR_Employee("CekEmployee")

            If bolStatusSP = True Then
                DisplayPesanError("Kode Pegawai telah Digunakan", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                Call AUDR_Employee("AddEmployee")

                DisplayPesanOK("Operasi berhasil", frmMainMenu.txtPesanError, 1000)


                txtEmployeeID.Text = ""
                txtNamaPegawai.Text = ""
                txtAlamat.Text = ""
                txtAlamatEmail.Text = ""
                cmbFungsional.Text = ""
                cmbJabatan.Text = ""
                btnAksi.Text = "OK"
                txtNoTelp.Text = ""

                Exit Sub
            End If


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
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            AUDR_Employee("CariEmployee")

            If bolStatusSP = False Then
                DisplayPesanError("Data Tidak Ditemukan !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                DisplayPesanOK("Data Ditemukan !", frmMainMenu.txtPesanError, 1000)
                txtAlamat.Enabled = True
                txtAlamatEmail.Enabled = True
                cmbFungsional.Enabled = True
                cmbJabatan.Enabled = True

                Exit Sub
            End If

        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



    Sub AUDR_Employee(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AUDR_Employee]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("EmployeeIDIN", Trim(txtEmployeeID.Text))
            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 50)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("EmployeeNameIN", Trim(txtNamaPegawai.Text))
            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("AlamatIn", Trim(txtAlamat.Text))
            command.Parameters.Add("AlamatOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatOUT").Direction = ParameterDirection.Output
            command.Parameters.AddWithValue("JabatanIN", Trim(cmbJabatan.Text))
            command.Parameters.Add("JabatanOUT", SqlDbType.VarChar, 100)
            command.Parameters("JabatanOUT").Direction = ParameterDirection.Output
            command.Parameters.AddWithValue("FungsionalIN", Trim(cmbFungsional.Text))
            command.Parameters.Add("FungsionalOUT", SqlDbType.VarChar, 100)
            command.Parameters("FungsionalOUT").Direction = ParameterDirection.Output
            command.Parameters.AddWithValue("AlamatEmailIN", Trim(txtAlamatEmail.Text))



            command.Parameters.Add("AlamatEmailOUT", SqlDbType.VarChar, 100)
            command.Parameters("AlamatEmailOUT").Direction = ParameterDirection.Output



            If cboAktif.Checked = True Then
                command.Parameters.AddWithValue("StatusEnabledIn", Trim("Y"))
            Else
                command.Parameters.AddWithValue("StatusEnabledIn", Trim("N"))
            End If

            command.Parameters.Add("StatusEnabledOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusEnabledOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("StatusRecord", SqlDbType.VarChar, 100)
            command.Parameters("StatusRecord").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("NoTelpIN", Trim(txtNoTelp.Text))
            command.Parameters.Add("NoTelpOut", SqlDbType.VarChar, 100)
            command.Parameters("NoTelpOut").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()






            If strFunction = "CariEmployee" Then
                If command.Parameters("StatusRecord").Value.ToString() <> "0" Then
                    bolStatusSP = True
                Else
                    bolStatusSP = False
                    Exit Sub
                End If
                txtEmployeeID.Text = command.Parameters("EmployeeIDOUT").Value.ToString()
                txtNamaPegawai.Text = command.Parameters("EmployeeNameOUT").Value.ToString()
                txtAlamat.Text = command.Parameters("AlamatOUT").Value.ToString()
                txtAlamatEmail.Text = command.Parameters("AlamatEmailOUT").Value.ToString()

                cmbFungsional.Text = command.Parameters("FungsionalOUT").Value.ToString()
                cmbJabatan.Text = command.Parameters("JabatanOUT").Value.ToString()
                txtNoTelp.Text = command.Parameters("NoTelpOut").Value.ToString()

                If command.Parameters("StatusEnabledOUT").Value.ToString() = "Y" Then
                    cboAktif.CheckState = CheckState.Checked
                Else
                    cboAktif.CheckState = CheckState.Unchecked
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub



End Class