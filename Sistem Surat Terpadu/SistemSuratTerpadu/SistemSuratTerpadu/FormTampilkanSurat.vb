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
        'reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", strServer, strNamaDatabase)

        'cryRpt.DataSourceConnections.Clear()
        'cryRpt.DataSourceConnections.Item(0).SetConnection("10.1.0.53", "RKM_Live_2", 1)


        CrystalReportViewer1.ReportSource = cryRpt

        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        CrystalReportViewer1.Refresh()
    End Sub
End Class