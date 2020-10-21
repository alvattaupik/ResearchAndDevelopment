Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class frmBrowseMasterStagging

    Private Sub frmBrowseMasterStagging_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListEmployee, "Select * From Oemployee Where Cast(ID As Varchar(100)) Like '%" & Trim(txtCariEmployee.Text) & "%' Or NamaPegawai like '%" & Trim(txtCariEmployee.Text) & "%' OR AlamatPegawai Like '%" & Trim(txtCariEmployee.Text) & "%' Or Jabatan Like '%" & Trim(txtCariEmployee.Text) & "%' or Fungsional like '%" & Trim(txtCariEmployee.Text) & "%'", KoneksiDBEmail)
    End Sub


    Private Sub dgvListEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListEmployee.CellClick
        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[AU_MASTER_STAGGING]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("IDtemplate", Trim(frmApprovalTemplate.cmbKodeTemplate.SelectedValue))
        command.Parameters.AddWithValue("APVStaggingID", "")
        command.Parameters.AddWithValue("EmpID", Trim(dgvListEmployee.Rows(e.RowIndex).Cells(0).Value()))

        command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
        command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output
        command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
        command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output
       
        command.Parameters.AddWithValue("Function", Trim("ADD-UserStagging"))


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
            frmApprovalTemplate.LoadMasterStagging()
            Me.Dispose()
        End If


    End Sub



   
End Class