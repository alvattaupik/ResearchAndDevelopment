Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class frmDialogueApprovalReq
    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table
    Public RptDocument As New ReportDocument
    Public reportDocument As New ReportDocument()
    Public paramField As New ParameterField()
    Public paramFields As New ParameterFields()
    Public paramDiscreteValue As New ParameterDiscreteValue()
    Public paramField2 As New ParameterField()
    Public paramFields2 As New ParameterFields()
    Public paramDiscreteValue2 As New ParameterDiscreteValue()

    Public paramField3 As New ParameterField()
    Public paramFields3 As New ParameterFields()
    Public paramDiscreteValue3 As New ParameterDiscreteValue()
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        AU_SISTER_APPROVAL("APV-Req")
    End Sub


    Sub AU_SISTER_APPROVAL(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_ApprovalAG]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NoSurat", Trim(txtNomorSurat.Text))
            command.Parameters.AddWithValue("EmpID", MstrKodePegawai)
            command.Parameters.AddWithValue("UsernameLogin", Trim(txtUsername.Text))
            command.Parameters.AddWithValue("Password", Trim(txtPassword.Text))
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
                Exit Sub
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
                frmAprovalReqFullfillments.LoadDaftarApproval()
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub btnLihatRequest_Click(sender As Object, e As EventArgs) Handles btnLihatRequest.Click
        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(txtNomorSurat.Text))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)
        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim("IT008")
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField2.CurrentValues.Add(paramDiscreteValue3)


        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New RequestFullfillment
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")
        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        CopyFileKeLokasiLain(dgvListLampiran.Item(0, dgvListLampiran.CurrentRow.Index).Value, Path.GetFileName((dgvListLampiran.Item(0, dgvListLampiran.CurrentRow.Index).Value)))
    End Sub

    Private Sub frmDialogueApprovalReq_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        txtUsername.Text = MstrUsernameLogin
        LoadDataGrid(dgvListLampiran, "SELECT PathLampiran FROM dbo.trxDetailReqFullfillment Where NomorSurat='" & Trim(txtNomorSurat.Text) & "'",KoneksiDBEmail)
    End Sub
End Class