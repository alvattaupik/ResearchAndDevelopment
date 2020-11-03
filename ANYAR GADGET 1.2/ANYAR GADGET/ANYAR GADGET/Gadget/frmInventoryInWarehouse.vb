Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInventoryInWarehouse

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

    Private Sub btnLihatItemCode_Click(sender As Object, e As EventArgs) Handles btnLihatItemCode.Click
        Dim frm As New frmLihatListItemCode
        frm.Show()
    End Sub

    Private Sub txtLihatvendorCode_Click(sender As Object, e As EventArgs) Handles txtLihatvendorCode.Click
        Dim frm As New frmLihatListVendor
        frm.Show()
    End Sub

    Private Sub cmbItemGroup_Click(sender As Object, e As EventArgs) Handles cmbItemGroup.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbItemGroup, "SELECT ItmsGrpCod,ItmsGrpNam FROM oitb", "ItmsGrpCod", "ItmsGrpNam", KoneksiSAP)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        paramField.Name = "ItemCodeFrom@"
        paramDiscreteValue.Value = Trim(txtItemCodeFrom.Text)
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "ItemCodeTo@"
        paramDiscreteValue2.Value = Trim(txtItemCodeTo.Text)
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)


        paramField3.Name = "VendorCodeFrom@"
        paramDiscreteValue3.Value = Trim(txtVendorCodeFrom.Text)
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)


        paramField4.Name = "VendorCodeTo@"
        paramDiscreteValue4.Value = Trim(txtVendorCodeTo.Text)
        paramField4.CurrentValues.Add(paramDiscreteValue4)
        paramFields.Add(paramField4)

        paramField5.Name = "KodeCabangFrom@"
        paramDiscreteValue5.Value = Trim(txtKodeCabangFrom.Text)
        paramField5.CurrentValues.Add(paramDiscreteValue5)
        paramFields.Add(paramField5)

        paramField6.Name = "KodeCabangTo@"
        paramDiscreteValue6.Value = Trim(txtKodeCabangTo.Text)
        paramField6.CurrentValues.Add(paramDiscreteValue6)
        paramFields.Add(paramField6)


        paramField7.Name = "ItemGroup@"
        paramDiscreteValue7.Value = Trim(cmbItemGroup.SelectedValue)
        paramField7.CurrentValues.Add(paramDiscreteValue7)
        paramFields.Add(paramField7)


        paramField8.Name = "KodeJabatan@"
        paramDiscreteValue8.Value = Trim(MstrLevelUser)
        paramField8.CurrentValues.Add(paramDiscreteValue8)
        paramFields.Add(paramField8)

   


        Dim frm As New frmTampilkanLaporan
        frm.crvTampilkanLaporan.ParameterFieldInfo = paramFields
        reportDocument = New Inventory_In_Warehouse
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "RKM_LIVE_2")

        frm.crvTampilkanLaporan.ReportSource = reportDocument
        frm.crvTampilkanLaporan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanLaporan.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class