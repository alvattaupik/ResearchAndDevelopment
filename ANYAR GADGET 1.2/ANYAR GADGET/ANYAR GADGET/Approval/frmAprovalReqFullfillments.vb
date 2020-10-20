Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmAprovalReqFullfillments

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

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        If dgvListSurat.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvListSurat.Item(0, dgvListSurat.CurrentRow.Index).Value))
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

 
    Private Sub frmAprovalReqFullfillments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadListRequestBelumDiApprove()
        LoadListRequestSudahDiApprove()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvListSurat.RowCount = 0 Then
            Exit Sub
        Else
            frmDialogueApprovalReq.txtNomorSurat.Text = (Trim(dgvListSurat.Item(0, dgvListSurat.CurrentRow.Index).Value))
            frmDialogueApprovalReq.ShowDialog()
        End If
    End Sub


    Sub LoadDaftarApproval()
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListSurat, "SELECT * FROM V_ListApproval Where (NomorSurat Like '%" & txtCari.Text & "%'  OR Lokasi Like '%" & txtCari.Text & "%' OR Perihal Like '%" & txtCari.Text & "%' OR Tgl Like '%" & txtCari.Text & "%'   OR DibuatOleh Like '%" & txtCari.Text & "%' OR DitujukanKepada Like '%" & txtCari.Text & "%') AND Lokasi ='" & MstrNamaCabang & "' AND Jenis<>'Form Peminjaman Aset' AND Tembusan='' Order By CreateDate Desc", KoneksiDBEmail)
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                LoadListRequestSudahDiApprove()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Sub LoadListRequestBelumDiApprove()
        Call KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_ListRequestBelumDiApprove]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@EmpID", Trim(MstrKodePegawai))
        Dim table As New DataTable
        adapter.Fill(table)

        dgvListSurat.DataSource = table
        dgvListSurat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListSurat.AutoResizeColumns()
        dgvListSurat.RowHeadersVisible = False



    End Sub



    Sub LoadListRequestSudahDiApprove()
        Call KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_ListRequestSudahDiApprove]", KoneksiDBEmail)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@EmpID", Trim(MstrKodePegawai))
        command.Parameters.AddWithValue("@DibuatOleh", Trim(txtCari.Text))
        command.Parameters.AddWithValue("@Divisi", Trim(txtCari.Text))
        Dim table As New DataTable
        adapter.Fill(table)

        dgvSudahDisetujui.DataSource = table
        dgvSudahDisetujui.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSudahDisetujui.AutoResizeColumns()
        dgvSudahDisetujui.RowHeadersVisible = False



    End Sub



    Private Sub btnLihatApprovalOk_Click(sender As Object, e As EventArgs) Handles btnLihatApprovalOk.Click
        If dgvSudahDisetujui.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvSudahDisetujui.Item(0, dgvSudahDisetujui.CurrentRow.Index).Value))
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
End Class