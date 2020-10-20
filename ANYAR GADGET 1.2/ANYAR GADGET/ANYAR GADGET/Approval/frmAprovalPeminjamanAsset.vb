Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmAprovalPeminjamanAsset

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
        If dgvListBelumDiproses.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvListBelumDiproses.Item(0, dgvListBelumDiproses.CurrentRow.Index).Value))
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

    Private Sub txtCariNoSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariNoSurat.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvListBelumDiproses, "SELECT * FROM V_ListPeminjamanALL Where NomorSurat Like '%" & txtCariNoSurat.Text & "%'  OR TglBuat Like '%" & txtCariNoSurat.Text & "%' OR  DibuatOleh Like '%" & txtCariNoSurat.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
      
    End Sub

    Private Sub frmAprovalReqFullfillments_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDaftarApproval()

    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvListBelumDiproses.RowCount = 0 Then
            Exit Sub
        Else
            frmDialogueApprovalPeminjaman.txtNomorSurat.Text = (Trim(dgvListBelumDiproses.Item(0, dgvListBelumDiproses.CurrentRow.Index).Value))
            frmDialogueApprovalPeminjaman.ShowDialog()
        End If
    End Sub


    Sub LoadDaftarApproval()
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListBelumDiproses, "SELECT  distinct * FROM V_ListPeminjamanBelumDiProses Where NomorSurat Like '%" & txtCariNoSurat.Text & "%'  OR TglBuat Like '%" & txtCariNoSurat.Text & "%' OR  DibuatOleh Like '%" & txtCariNoSurat.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)

        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvBelumKembali, "SELECT distinct * FROM V_ListPeminjamanBelumKembali Where NomorSurat Like '%" & txtCariBelumKembali.Text & "%'  OR TglBuat Like '%" & txtCariBelumKembali.Text & "%' OR  DibuatOleh Like '%" & txtCariBelumKembali.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)

        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListSudahKembali, "SELECT distinct * FROM V_ListPeminjamanSudahKembali Where NomorSurat Like '%" & txtCariSuratSudahKembali.Text & "%'  OR TglBuat Like '%" & txtCariSuratSudahKembali.Text & "%' OR  DibuatOleh Like '%" & txtCariSuratSudahKembali.Text & "%' Or DiterimaOleh Like '%" & txtCariSuratSudahKembali.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)
    End Sub

    Private Sub txtCariBelumKembali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariBelumKembali.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvBelumKembali, "SELECT * FROM V_ListPeminjamanALL Where NomorSurat Like '%" & txtCariBelumKembali.Text & "%'  OR TglBuat Like '%" & txtCariBelumKembali.Text & "%' OR  DibuatOleh Like '%" & txtCariNoSurat.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnLihatAssetBelumKembali_Click(sender As Object, e As EventArgs) Handles btnLihatAssetBelumKembali.Click
        If dgvBelumKembali.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvBelumKembali.Item(0, dgvBelumKembali.CurrentRow.Index).Value))
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

    Private Sub btnCancelAssetBelumKembali_Click(sender As Object, e As EventArgs) Handles btnCancelAssetBelumKembali.Click

    End Sub

    Private Sub btnApproveAssetBelumKembali_Click(sender As Object, e As EventArgs) Handles btnApproveAssetBelumKembali.Click
        If dgvBelumKembali.RowCount = 0 Then
            Exit Sub
        Else
            frmDialoguePengembalianAsset.txtNomorSurat.Text = (Trim(dgvBelumKembali.Item(0, dgvBelumKembali.CurrentRow.Index).Value))
            frmDialoguePengembalianAsset.ShowDialog()
        End If
    End Sub

    Private Sub txtCariSuratSudahKembali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSuratSudahKembali.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvListSudahKembali, "SELECT * FROM V_ListPeminjamanALL Where NomorSurat Like '%" & txtCariNoSurat.Text & "%'  OR TglBuat Like '%" & txtCariNoSurat.Text & "%' OR  DibuatOleh Like '%" & txtCariNoSurat.Text & "%' Order By TglBuat Desc", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnSudahKembali_Click(sender As Object, e As EventArgs) Handles btnSudahKembali.Click
        If dgvListSudahKembali.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvListSudahKembali.Item(0, dgvListSudahKembali.CurrentRow.Index).Value))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)
        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim("IT006-01")
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField2.CurrentValues.Add(paramDiscreteValue3)



        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New FormPengembalian_Asset_Anyar_Gadget_IT006_01
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")
        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
End Class