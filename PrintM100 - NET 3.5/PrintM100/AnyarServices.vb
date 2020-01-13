Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class AnyarServices
    Dim strDocEntry As String

    Private Sub AnyarServices_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNamaUser.Text = strNamaUser
        CRVDelivery.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub


    Private Sub cmdPreviewDelivery_Click(sender As Object, e As EventArgs) Handles cmdPreviewDelivery.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.DeliveryPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoDelivery.Text = "" Then
            MsgBox("No Delivery Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.DeliveryPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ODLN WHERE DocNum='" & Trim(txtNoDelivery.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If





            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVDelivery.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)

            Module_Konfigurasi_laporan()
            'reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", strServer, strNamaDatabase)

            'cryRpt.DataSourceConnections.Clear()
            'cryRpt.DataSourceConnections.Item(0).SetConnection("10.1.0.53", "RKM_Live_2", 1)


            CRVDelivery.ReportSource = cryRpt

            CRVDelivery.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

            CRVDelivery.Refresh()

        End If
    End Sub

    Private Sub TemplateLaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemplateLaporanToolStripMenuItem.Click
        FormKonfigurasiFormatLaporan.ShowDialog()
    End Sub

    Private Sub cmdPreviewGoodsIssue_Click(sender As Object, e As EventArgs) Handles cmdPreviewGoodsIssue.Click
        'MsgBox("Feature Ini akan Tiba Segera", vbInformation, "Information")
        'Exit Sub



        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.GoodsIssuePath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoGoodsIssue.Text = "" Then
            MsgBox("No Goods Issue Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.GoodsIssuePath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OIGE WHERE DocNum='" & Trim(txtNoGoodsIssue.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVGoodsIssue.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVGoodsIssue.ReportSource = cryRpt
            CRVGoodsIssue.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVGoodsIssue.Refresh()

        End If






    End Sub

    Private Sub cmdPreviewGoodsReceipt_Click(sender As Object, e As EventArgs)
        MsgBox("Feature Ini akan Tiba Segera", vbInformation, "Information")
        Exit Sub
    End Sub

    Private Sub cmdPreviewInventoryTransfer_Click(sender As Object, e As EventArgs) Handles cmdPreviewInventoryTransfer.Click
        'MsgBox("Feature Ini akan Tiba Segera", vbInformation, "Information")
        'Exit Sub

        Dim strPathReport As String
        Dim strStatusPath As String
        Dim strSQL As String

        strStatusPath = My.Settings.InventoryTransferPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoInventoryTransfer.Text = "" Then
            MsgBox("No Inventory Transfer Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.InventoryTransferPath

            KoneksiDatabase()


            strSQL = "SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OWTR WHERE DocNum='" & Trim(txtNoInventoryTransfer.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            crvInventoryTransfer.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            crvInventoryTransfer.ReportSource = cryRpt
            crvInventoryTransfer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            crvInventoryTransfer.Refresh()

        End If


    End Sub

    Private Sub cmdPreviewInventoryRequest_Click(sender As Object, e As EventArgs) Handles cmdPreviewInventoryRequest.Click
        'MsgBox("Feature Ini akan Tiba Segera", vbInformation, "Information")
        'Exit Sub


        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.InventoryRequestPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoInventoryRequest.Text = "" Then
            MsgBox("No Inventory Request Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.InventoryRequestPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OWTQ WHERE DocNum='" & Trim(txtNoInventoryRequest.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)
            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            crvInventoryRequest.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()

            crvInventoryRequest.ReportSource = cryRpt
            crvInventoryRequest.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            crvInventoryRequest.Refresh()

        End If



    End Sub

    Private Sub cmdPreviewGRPO_Click(sender As Object, e As EventArgs) Handles cmdPreviewGRPO.Click
        'MsgBox("Feature Ini akan Tiba Segera", vbInformation, "Information")
        'Exit Sub


        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.GRPOPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoGRPO.Text = "" Then
            MsgBox("No GRPO Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.GRPOPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OPDN WHERE DocNum='" & Trim(txtNoGRPO.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            crvGRPO.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            'reportDocument.SetDatabaseLogon("sa", "h0spit4lity#")
            'reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", strServer, strNamaDatabase)
            ' cryRpt.DataSourceConnections.Clear()
            ' cryRpt.DataSourceConnections.Item(0).SetConnection("10.1.0.53", "RKM_Live_2", 1)

            crvGRPO.ReportSource = cryRpt

            crvGRPO.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

            crvGRPO.Refresh()

        End If



    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If (MsgBox("Apakah Anda Akan logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes) Then
            Me.Dispose()
            MsgBox("Terimakasih " & strNamaUser, vbInformation, "Hatur Nuhun!")
            LoginForm.Show()
            LoginForm.txtPassword.Text = ""
            LoginForm.txtUseName.Text = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ChangeLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeLogToolStripMenuItem.Click
        FormChangeLog.ShowDialog()
    End Sub

    Private Sub ShowMyIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMyIPToolStripMenuItem.Click
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        MsgBox("IP Address Anda Adalah : " & vbNewLine & h.AddressList.GetValue(0).ToString, vbInformation, "Anyar Local Print Services 1.1")
    End Sub

    Private Sub PingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingToolStripMenuItem.Click
        FormPing.ShowDialog()
    End Sub

    Private Sub cmdPreviewOutgoingPayments_Click(sender As Object, e As EventArgs) Handles cmdPreviewOutgoingPayments.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.OutgoingPaymentsPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoOutgoingPayments.Text = "" Then
            MsgBox("No OutgoingPayments Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.OutgoingPaymentsPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.OVPM WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoOutgoingPayments.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVOutgoingPayments.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVOutgoingPayments.ReportSource = cryRpt
            CRVOutgoingPayments.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVOutgoingPayments.Refresh()

        End If

    End Sub


    Private Sub cmdPreviewIncomingPayment_Click(sender As Object, e As EventArgs) Handles cmdPreviewIncomingPayment.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.IncomingPaymentsPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoIncomingPayment.Text = "" Then
            MsgBox("No Incoming Payments Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.IncomingPaymentsPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.ORCT WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoIncomingPayment.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVIncomingPayment.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVIncomingPayment.ReportSource = cryRpt
            CRVIncomingPayment.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVIncomingPayment.Refresh()

        End If
    End Sub

    Private Sub cmdPreviewGoodsReceipt_Click_1(sender As Object, e As EventArgs) Handles cmdPreviewGoodsReceipt.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.GoodsReceiptPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoGoodsReceipt.Text = "" Then
            MsgBox("No Goods Receipt Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.GoodsReceiptPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.OIGN WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoGoodsReceipt.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVGoodsReceipt.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVGoodsReceipt.ReportSource = cryRpt
            CRVGoodsReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVGoodsReceipt.Refresh()

        End If
    End Sub

    Private Sub cmdPreviewNoPickList_Click(sender As Object, e As EventArgs) Handles cmdPreviewNoPickList.Click

        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.PickListPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoPickList.Text = "" Then
            MsgBox("No Pick List Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.PickListPath

            'KoneksiDatabase()
            'Dim strSQL As String

            'strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.OIGN WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoGoodsReceipt.Text) & "'"
            'cmd = New SqlCommand(strSQL, KoneksiSQl)
            'dr = cmd.ExecuteReader
            'dr.Read()
            'If dr.HasRows = True Then

            '    strDocEntry = dr.GetString(0)

            'Else

            '    MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
            '    Exit Sub
            'End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(txtNoPickList.Text))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "ExtParam@"
            paramDiscreteValue2.Value = "0"
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVPickList.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVPickList.ReportSource = cryRpt
            CRVPickList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVPickList.Refresh()

        End If


    End Sub

    Private Sub cmdPreviewGoodsReturn_Click(sender As Object, e As EventArgs) Handles cmdPreviewGoodsReturn.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.GoodsReturnPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoGoodsReturn.Text = "" Then
            MsgBox("No Goods Return Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.GoodsReturnPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.ORPD WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoGoodsReturn.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRvGoodsReturn.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRvGoodsReturn.ReportSource = cryRpt
            CRvGoodsReturn.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRvGoodsReturn.Refresh()

        End If
    End Sub

    Private Sub cmdPreviewSO_Click(sender As Object, e As EventArgs) Handles cmdPreviewSO.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.SalesOrderPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoSO.Text = "" Then
            MsgBox("No Sales Order Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.SalesOrderPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.ORDR WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoSO.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRvGoodsReturn.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVSO.ReportSource = cryRpt
            CRVSO.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVSO.Refresh()

        End If
    End Sub

    Private Sub cmdPreviewReturn_Click(sender As Object, e As EventArgs) Handles cmdPreviewReturn.Click
        Dim strPathReport As String
        Dim strStatusPath As String

        strStatusPath = My.Settings.ReturnPath

        If strStatusPath = "" Then
            MsgBox("Lokasi Default Report Belum Di Isi,Silahkan Buka Menu Setting", vbInformation, "Informasi")
            Exit Sub
        End If


        If txtNoReturn.Text = "" Then
            MsgBox("No Return Harus Di Isi")
            Exit Sub
        Else

            strPathReport = My.Settings.ReturnPath

            KoneksiDatabase()
            Dim strSQL As String

            strSQL = "SELECT TOP 1 CAST(DocEntry AS VARCHAR(100)) AS DocEntry FROM dbo.ORDN WITH (NOLOCK) WHERE DocNum='" & Trim(txtNoReturn.Text) & "'"
            cmd = New SqlCommand(strSQL, KoneksiSQl)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                strDocEntry = dr.GetString(0)

            Else

                MsgBox("Docentry Tidak Dapat Ditemukan", vbInformation, "Hubungi Administrator")
                Exit Sub
            End If



            paramField.Name = "Dockey@"
            paramDiscreteValue.Value = Format(Trim(strDocEntry))
            paramField.CurrentValues.Add(paramDiscreteValue)
            paramFields.Add(paramField)

            paramField2.Name = "usercode@"
            paramDiscreteValue2.Value = strUsernameSAP
            paramField2.CurrentValues.Add(paramDiscreteValue2)
            paramFields.Add(paramField2)
            CRVReturn.ParameterFieldInfo = paramFields

            cryRpt.Load(strPathReport)
            Module_Konfigurasi_laporan()
            CRVReturn.ReportSource = cryRpt
            CRVReturn.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            CRVReturn.Refresh()

        End If
    End Sub
End Class