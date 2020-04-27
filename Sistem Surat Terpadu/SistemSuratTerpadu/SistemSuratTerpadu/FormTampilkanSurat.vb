Public Class FormTampilkanSurat
   

    Private Sub FormTampilkanSurat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = Format(Trim(GlobalstrNoSurat))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "KodeUser@"
        paramDiscreteValue2.Value = GlobalstrKodeUser
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)
        CrystalReportViewer1.ParameterFieldInfo = paramFields

        cryRpt.Load(GlobalstrPathReport)

        Module_Konfigurasi_laporan()
       
        CrystalReportViewer1.ReportSource = cryRpt

        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        CrystalReportViewer1.Refresh()
    End Sub
End Class