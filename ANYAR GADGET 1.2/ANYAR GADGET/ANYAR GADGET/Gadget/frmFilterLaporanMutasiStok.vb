﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmFilterLaporanMutasiStok

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        paramField.Name = "tanggal@"
        paramDiscreteValue.Value = Format(dtpTgl.Value, "dd/MM/yyyy")
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "Gudang@"
        paramDiscreteValue2.Value = cmbKodeGudang.SelectedValue
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)


        paramField3.Name = "PrintByUserName@"
        paramDiscreteValue3.Value = MstrUsernameLogin
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)


        Dim frm As New frmTampilkanLaporan
        frm.crvTampilkanLaporan.ParameterFieldInfo = paramFields
        reportDocument = New LaporanMutasiStockAG
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "RKM_LIVE_2")

        frm.crvTampilkanLaporan.ReportSource = reportDocument
        frm.crvTampilkanLaporan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanLaporan.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()





    End Sub


    Private Sub cmbKodeGudang_Click(sender As Object, e As EventArgs) Handles cmbKodeGudang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbKodeGudang, "SELECT WhsCode,WhsName FROM owhs WHERE WhsCode LIKE '01%'", "WhsCode", "WhsName", KoneksiSAP)
    End Sub

 
End Class