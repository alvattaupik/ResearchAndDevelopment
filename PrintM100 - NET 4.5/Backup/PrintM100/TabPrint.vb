Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Public Class TabPrint

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
End Class
