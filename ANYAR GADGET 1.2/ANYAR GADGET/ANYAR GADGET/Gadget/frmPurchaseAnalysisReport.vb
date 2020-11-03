Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPurchaseAnalysisReport
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


    Public paramField4 As New ParameterField()
    Public paramFields4 As New ParameterFields()
    Public paramDiscreteValue4 As New ParameterDiscreteValue()



    Public paramField5 As New ParameterField()
    Public paramFields5 As New ParameterFields()
    Public paramDiscreteValue5 As New ParameterDiscreteValue()

    Public paramField6 As New ParameterField()
    Public paramFields6 As New ParameterFields()
    Public paramDiscreteValue6 As New ParameterDiscreteValue()


    Public paramField7 As New ParameterField()
    Public paramFields7 As New ParameterFields()
    Public paramDiscreteValue7 As New ParameterDiscreteValue()

    Public paramField8 As New ParameterField()
    Public paramFields8 As New ParameterFields()
    Public paramDiscreteValue8 As New ParameterDiscreteValue()

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        paramField.Name = "TglAwal@"
        paramDiscreteValue.Value = Format(tglAwal.Value, "dd/MM/yyyy")
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "TglAkhir@"
        paramDiscreteValue2.Value = Format(tglAkhir.Value, "dd/MM/yyyy")
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)


        paramField3.Name = "KodeCabang@"
        paramDiscreteValue3.Value = Trim(cmbKodeCabang.SelectedValue)
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)


        Dim frm As New frmTampilkanLaporan
        frm.crvTampilkanLaporan.ParameterFieldInfo = paramFields
        reportDocument = New Purchase_Analysis_By_GRPO
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "RKM_LIVE_2")

        frm.crvTampilkanLaporan.ReportSource = reportDocument
        frm.crvTampilkanLaporan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanLaporan.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub cmbKodeCabang_Click(sender As Object, e As EventArgs) Handles cmbKodeCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbKodeCabang, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode LIKE '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class