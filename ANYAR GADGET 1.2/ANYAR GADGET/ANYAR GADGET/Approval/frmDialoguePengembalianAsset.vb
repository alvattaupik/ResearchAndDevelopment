Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class frmDialoguePengembalianAsset
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
        AU_SISTER_APPROVAL("U-KembaliDetailPinjam")
        frmAprovalPeminjamanAsset.LoadDaftarApproval()
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
                frmAprovalPeminjamanAsset.LoadDaftarApproval()
                Call AU_PengembalianAsset(dgvListItem)
                Me.Dispose()
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub
    Sub AU_PengembalianAsset(dgvKode As DataGridView)

        For i As Integer = 0 To dgvKode.Rows.Count - 1

            Try
                KoneksiDB_EMAIL()
                Dim command As SqlCommand
                command = New SqlCommand("[U_DETAIL_PENGEMBALIAN]", KoneksiDBEmail)
                Dim adapter As New SqlDataAdapter(command)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("NomorSurat", Trim(txtNomorSurat.Text))
                command.Parameters.AddWithValue("ItemCode", Trim(dgvKode.Rows(i).Cells(1).Value))
                command.Parameters.AddWithValue("ItemName", Trim(dgvKode.Rows(i).Cells(2).Value))
                command.Parameters.AddWithValue("Spesifikasi", Trim(""))
                command.Parameters.AddWithValue("FromDate", Trim(""))
                command.Parameters.AddWithValue("ToDate", Trim(""))
                command.Parameters.AddWithValue("Catatan", Trim(""))
                command.Parameters.AddWithValue("StatusPinjam", Trim(Trim(dgvKode.Rows(i).Cells(0).Value)))
                command.Parameters.AddWithValue("EmpID", Trim(Trim(MstrKodePegawai)))
                command.Parameters.AddWithValue("Function", Trim("U-KembaliDetailPinjam"))
                If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
                command.Connection = KoneksiDBEmail
                KoneksiDBEmail.Open()
                command.ExecuteNonQuery()

            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
            End Try

        Next

        DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
    End Sub
    Private Sub btnLihatRequest_Click(sender As Object, e As EventArgs) Handles btnLihatRequest.Click
        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(txtNomorSurat.Text))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)
        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim("IT006")
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField2.CurrentValues.Add(paramDiscreteValue3)


        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New FormPeminjamanAsset_Anyar_Gadget_IT006_01
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")
        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
    Private Sub btnDownload_Click(sender As Object, e As EventArgs)
        CopyFileKeLokasiLain(dgvListItem.Item(0, dgvListItem.CurrentRow.Index).Value, Path.GetFileName((dgvListItem.Item(0, dgvListItem.CurrentRow.Index).Value)))
    End Sub
    Private Sub frmDialogueApprovalReq_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        txtUsername.Text = MstrUsernameLogin

        LoadDaftarItemYangBelumKembali()
    End Sub
    Sub LoadDaftarItemYangDiPinjam()

        Dim strQuery2 As String = "SELECT StatusPinjam AS Approve,ItemCode,ItemName FROM dbo.trxPeminjamanAsset WHERE NomorSurat='" & Trim(txtNomorSurat.Text) & "' AND StatusPinjam='N' AND TglKembali IS NULL"
        Call KoneksiDB_EMAIL()

        Try
            dgvListItem.DataSource = Nothing
            dgvListItem.Rows.Clear()
            dgvListItem.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)


            Dim chk As New DataGridViewCheckBoxColumn()
            dgvListItem.Columns.Add(chk)
            chk.HeaderText = "Approve"
            chk.Name = "Approve"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgvListItem.Columns.Add("ItemCode", "ItemCode")
            dgvListItem.Columns.Add("ItemName", "ItemName")

            dgvListItem.Columns(0).ReadOnly = False
            dgvListItem.Columns(1).ReadOnly = True
            dgvListItem.Columns(2).ReadOnly = True

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvListItem.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next


            End With


        Catch ex As Exception
            MessageBox.Show("Kesalahan memuat datagrid !: ( " & strQuery2 & ")")
        End Try

    End Sub

    Sub LoadDaftarItemYangBelumKembali()

        Dim strQuery2 As String = "SELECT StatusPinjam AS Approve,ItemCode,ItemName,'' As Kondisi FROM dbo.trxPeminjamanAsset WHERE NomorSurat='" & Trim(txtNomorSurat.Text) & "' AND StatusPinjam='Y' AND TglKembali IS NULL"
        Call KoneksiDB_EMAIL()

        Try
            dgvListItem.DataSource = Nothing
            dgvListItem.Rows.Clear()
            dgvListItem.Columns.Clear()

            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)


            Dim chk As New DataGridViewCheckBoxColumn()
            dgvListItem.Columns.Add(chk)
            chk.HeaderText = "Approve"
            chk.Name = "Approve"

            chk.TrueValue = "N"
            chk.FalseValue = "Y"

            dgvListItem.Columns.Add("ItemCode", "ItemCode")
            dgvListItem.Columns.Add("ItemName", "ItemName")
            dgvListItem.Columns.Add("Kondisi", "Kondisi")

            dgvListItem.Columns(0).ReadOnly = False
            dgvListItem.Columns(1).ReadOnly = True
            dgvListItem.Columns(2).ReadOnly = True
            dgvListItem.Columns(3).ReadOnly = False

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvListItem.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString(), .Rows(i).Item(3).ToString())
                Next


            End With


        Catch ex As Exception
            MessageBox.Show("Kesalahan memuat datagrid !: ( " & strQuery2 & ")")
        End Try

    End Sub



End Class