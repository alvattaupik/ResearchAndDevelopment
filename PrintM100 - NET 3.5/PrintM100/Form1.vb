Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports



Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Delivery Print LX Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()

            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(TextBox1.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = TextBox2.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields

            cryRpt.Load("DeliveryLX.rpt")
            Module_Konfigurasi_laporan()
            'reportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()

        End If

    End Sub


    Private Sub BtnDMDeliveryM100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDMDeliveryM100.Click
        If txtDMDeliveryM100.Text = "" Or txtUserDeliveryM100.Text = "" Then
            MsgBox("Data Delivery Print M100 Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("DELIVERY IDTRANS SAP.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtDMDeliveryM100.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtUserDeliveryM100.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnTransferLX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransferLX.Click
        If txtTransferLX.Text = "" Or txtUserTransferLX.Text = "" Then
            MsgBox("Data Transfer Print LX Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("Inventory Transfer.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtTransferLX.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtUserTransferLX.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnTransM100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransM100.Click
        If txtTransDMM100.Text = "" Or txtTransuserM100.Text = "" Then
            MsgBox("Data Transfer Print LX Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("Inventory Transfer A5.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtTransDMM100.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtTransuserM100.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnReqLx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReqLx.Click
        If txtReqDmLx.Text = "" Or txtReqUserLX.Text = "" Then
            MsgBox("Data Request Print LX Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("Form Transfer Request LX.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtReqDmLx.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtReqUserLX.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnReqM100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReqM100.Click
        If txtReqDmM100.Text = "" Or txtReqUserM100.Text = "" Then
            MsgBox("Data Request Print M100 Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("Form Transfer Request A5.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtReqDmM100.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtReqUserM100.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnGRPOLX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGRPOLX.Click
        If txtGRPODmLX.Text = "" Or txtGRPOUserLX.Text = "" Then
            MsgBox("Data GRPO Print LX Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("GRPO LX.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtGRPODmLX.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtGRPOUserLX.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub BtnGRPOM100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGRPOM100.Click
        If txtGRPODmM100.Text = "" Or txtGRPOUserM100.Text = "" Then
            MsgBox("Data GRPO Print M100 Belum Lengkap.! Harap Isi Semua")
            Exit Sub
        Else
            Laporan.Show()
            cryRpt.Load("GRPO A5 xxx.rpt")
            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(txtGRPODmM100.Text)
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = txtGRPOUserM100.Text
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            Laporan.CrystalReportViewer1.ParameterFieldInfo = paramFields
            Module_Konfigurasi_laporan()
            'ReportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            Laporan.CrystalReportViewer1.ReportSource = cryRpt
            Laporan.CrystalReportViewer1.Refresh()
        End If
    End Sub

End Class
