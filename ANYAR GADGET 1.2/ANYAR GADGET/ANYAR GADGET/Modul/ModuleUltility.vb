Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Module ModuleUltility

    Public mBolFunction As Boolean


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

    Sub LoadDataGrid(dgv As DataGridView, strQuery As String, connection As System.Data.SqlClient.SqlConnection)

        Try

            cmd = New SqlCommand(strQuery, connection)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgv.DataSource = table
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show("Kesalahan memuat datagrid !: ( " & strQuery & ")")
        End Try

    End Sub
    Sub LoadComboBox(cmb As ComboBox, strQuery As String, strKode As String, strDeskripsi As String, connection As System.Data.SqlClient.SqlConnection)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            cmd = New SqlCommand(strQuery, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            connection.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strKode
            cmb.DisplayMember = strDeskripsi
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub
    Sub MessageBoxWarningOkGunaUI(txt As Guna.UI.WinForms.GunaTextBox, strPesan As String)
        If txt.Text = "" Then
            MsgBox(strPesan, MessageBoxButtons.OK, "Perhatian !")
            mBolFunction = True
        End If
    End Sub

    Sub MessageBoxWarningOkWinform(txt As TextBox, strPesan As String)
        If txt.Text = "" Then
            MsgBox(strPesan, MessageBoxButtons.OK, "Perhatian !")
            mBolFunction = True
        End If
    End Sub


    Sub LoadMenuAplikasi(dgv As DataGridView)

        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = "OFILE001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Logout.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OFILE002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Shutdown.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OSETTING001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Template.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OSETTING002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_UbahPassword.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OSETTING003" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_PushNotification.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OSETTING004" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_User.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OMASTER001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Pegawai.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OMASTER002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Menu.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OMASTER003" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_ITILV3.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OMASTER004" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Konten.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OMASTER005" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_AssetManagement.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Sidebar.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Monitoring.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET003" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_PrintServices.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET004" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Ping.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET005" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Request.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET006" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Repository.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET007" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_AIO.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET008" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_PricingAndPromotion.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET009" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_AnyarChat.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET010" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_LaporanLaporan.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET011" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_SISTER.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET012" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_ABPC.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OGADGET013" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_Controlling.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "OHELP001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_LaporkanMasalah.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "OHELP002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.H_CaraPenggunaan.Visible = True


                '-------SUB MENU


            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_Realstock.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_Delivery.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget003" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_Request.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget004" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_AnyarLocalPrint.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget005" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_RKMDisplayTag.Visible = True
                'ElseIf dgv.Rows(i).Cells(0).Value = "IGadget006" And dgv.Rows(i).Cells(1).Value = "Y" Then
                '    frmMainMenu.I_ReqFullfillment.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget007" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_RequestFullfillments.Visible = True
                'ElseIf dgv.Rows(i).Cells(0).Value = "IGadget008" And dgv.Rows(i).Cells(1).Value = "Y" Then
                '    frmMainMenu.I_BukaPostingPeriode.Visible = True
                'ElseIf dgv.Rows(i).Cells(0).Value = "IGadget009" And dgv.Rows(i).Cells(1).Value = "Y" Then
                '    frmMainMenu.I_BukaAuthorisasi.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget010" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_IntegrationMonitor.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget011" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_FullfilmentChecker.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget012" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ReplicationMonitor.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget013" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_StoreDatabaseMonitor.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget014" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ExportHargaJual.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget015" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_PerubahanHarga.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget016" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_Promo.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget017" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_AnyarRepository.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget018" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_LapInventoryCheck.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget019" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_MutasiStock.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget020" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_SuratJalan.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget021" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_SuratTerima.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget022" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_BAPSerahTerima.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget023" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_BAPPenyelesaian.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget024" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ListKendaraan.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget025" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ValidationControl.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IGadget026" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_BuatControlling.Visible = True

            ElseIf dgv.Rows(i).Cells(0).Value = "IMenu001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_HeaderMenu.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IMenu002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ItemsMenu.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IMenu003" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_HeaderForm.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "IMenu004" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ItemsForm.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "ITIL001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_IncidentManagement.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "ITIL002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ProblemManagement.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "AM001" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_RegNewAsset.Visible = True
            ElseIf dgv.Rows(i).Cells(0).Value = "AM002" And dgv.Rows(i).Cells(1).Value = "Y" Then
                frmMainMenu.I_ParameterUji.Visible = True

            End If


        Next


    End Sub




 

    Public Sub FnCustomTimer(tmr As Timer, durasi As Integer)

        MintNilaiTimer = durasi * 1000

    End Sub
    Public Sub DisplayPesanError(strPesan As String, txtObject As TextBox, intInterval As Integer)
        txtObject.Visible = True
        frmMainMenu.txtJamDanWaktu.Visible = False
        frmMainMenu.TimerPesanError.Enabled = True

        txtObject.Text = strPesan
        txtObject.BackColor = Color.Red
        frmMainMenu.TimerPesanError.Interval = intInterval
        frmMainMenu.TimerPesanError.Start()

    End Sub
    Public Sub DisplayPesanOK(strPesan As String, txtObject As TextBox, intInterval As Integer)
        txtObject.Visible = True
        frmMainMenu.TimerPesanError.Enabled = True
        frmMainMenu.txtJamDanWaktu.Visible = False
        txtObject.Text = strPesan
        txtObject.BackColor = Color.LightGreen
        frmMainMenu.TimerPesanError.Interval = intInterval
        frmMainMenu.TimerPesanError.Start()


    End Sub
    Sub AUD_MenuAplikasi(strFunction As String, strDocEntry As String, strKode As String, strKodeDetail As String, strDeskripsi As String, strNamaExternal As String, strStatusEnabled As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_MenuAplikasi]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("DocEntry", Trim(strDocEntry))
            command.Parameters.AddWithValue("Kode", Trim(strKode))
            command.Parameters.AddWithValue("KodeDetail", Trim(strKodeDetail))
            command.Parameters.AddWithValue("Deskripsi", Trim(strDeskripsi))
            command.Parameters.AddWithValue("NamaExternal", Trim(strNamaExternal))
            command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
            command.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))

            command.Parameters.Add("StatusRecordOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusRecordOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            If Microsoft.VisualBasic.Left(strFunction, 1) = "A" Then

                If command.Parameters("StatusRecordOUT").Value.ToString() <> "0" Then
                    DisplayPesanError("Kode Telah Digunakan !", frmMainMenu.txtPesanError, 1000)
                  
                    Exit Sub
                Else
                    DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)
                   
                End If
            Else
                DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)



            End If


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub AUD_MenuAplikasiSpecificITIL(strFunction As String, strDocEntry As String, strKode As String, strKodeDetail As String, strDeskripsi As String, strNamaExternal As String, strKodeAplikasi As String, strStatusEnabled As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_MenuAplikasi]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("DocEntry", Trim(strDocEntry))
            command.Parameters.AddWithValue("Kode", Trim(strKode))
            command.Parameters.AddWithValue("KodeDetail", Trim(strKodeDetail))
            command.Parameters.AddWithValue("Deskripsi", Trim(strDeskripsi))
            command.Parameters.AddWithValue("NamaExternal", Trim(strNamaExternal))
            command.Parameters.AddWithValue("KodeAplikasi", Trim(strKodeAplikasi))
            command.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))

            command.Parameters.Add("StatusRecordOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusRecordOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            If Microsoft.VisualBasic.Left(strFunction, 1) = "A" Then

                If command.Parameters("StatusRecordOUT").Value.ToString() <> "0" Then
                    DisplayPesanError("Kode Telah Digunakan !", frmMainMenu.txtPesanError, 1000)

                    Exit Sub
                Else
                    DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)

                End If
            Else
                DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)



            End If


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub GetDocEntry(strQuery1 As String, strQuery2 As String)
        Call Koneksi_SAP()
        cmd = New SqlCommand(strQuery1, KoneksiSAP)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrDocEntry = dr.GetString(0)
            dr.Close()
        Else
            DisplayPesanError("Dokumen Tidak Dapat Ditemukan", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        Call Koneksi_SAP()
        cmd = New SqlCommand(strQuery2, KoneksiSAP)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrUserIDSAP = dr.GetString(0)
            dr.Close()
        Else
            DisplayPesanError("User ID Tidak Ditemukan", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


    End Sub




    Sub DisplayAnyarLocalPrintCrystalReport(strQuery As String, strKodeJenisDokumen As String, strUserCode As String, crv As CrystalDecisions.Windows.Forms.CrystalReportViewer)

        Dim strQuery2 As String = "Select Top 1 Cast(USERID As Varchar(100)) As USERID From OUSR Where USER_CODE='" & MstrUsernameLogin & "'"

        Dim strPathReport As String
        If strKodeJenisDokumen = "OIGN001" Then
            If My.Settings.P_GoodsReceipt = "" Then
                DisplayPesanError("Template Goods Receipt Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_GoodsReceipt
                GetDocEntry(strQuery, strQuery2)
            End If
        End If

        If strKodeJenisDokumen = "ORCT001" Then
            If My.Settings.P_IncomingPayment = "" Then
                DisplayPesanError("Template Incoming Payment Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_IncomingPayment
                GetDocEntry(strQuery, strQuery2)
            End If
        End If

        If strKodeJenisDokumen = "OPKL001" Then
            If My.Settings.P_PickListForm = "" Then
                DisplayPesanError("Template Pick List Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_PickListForm
                GetDocEntry(strQuery, strQuery2)
            End If

        End If

        If strKodeJenisDokumen = "ORPD001" Then
            If My.Settings.P_GoodsReturn = "" Then
                DisplayPesanError("Template GoodsReturn Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_GoodsReturn
                GetDocEntry(strQuery, strQuery2)
            End If

        End If


        If strKodeJenisDokumen = "ORDN001" Then
            If My.Settings.P_Return = "" Then
                DisplayPesanError("Template Return Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_Return
                GetDocEntry(strQuery, strQuery2)
            End If
        End If


        If strKodeJenisDokumen = "ORDR001" Then
            If My.Settings.P_SalesOrder = "" Then
                DisplayPesanError("Template Sales Order Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_SalesOrder
                GetDocEntry(strQuery, strQuery2)
            End If
        End If


        If strKodeJenisDokumen = "ODLN001" Then
            If My.Settings.P_Delivery = "" Then
                DisplayPesanError("Template Delivery Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_Delivery
                GetDocEntry(strQuery, strQuery2)
            End If
        End If

        If strKodeJenisDokumen = "OPDN001" Then
            If My.Settings.P_GRPO = "" Then
                DisplayPesanError("Template GRPO Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_GRPO
                GetDocEntry(strQuery, strQuery2)
            End If
        
        End If

        If strKodeJenisDokumen = "OWTQ001" Then
            If My.Settings.P_InventoryTransferReq = "" Then
                DisplayPesanError("Template Transfer Request Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_InventoryTransferReq
                GetDocEntry(strQuery, strQuery2)
            End If
        End If

        If strKodeJenisDokumen = "OWTR001" Then
            If My.Settings.P_GRPO = "" Then
                DisplayPesanError("Template Inventory Transfer Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_InventoryTransfer
                GetDocEntry(strQuery, strQuery2)
            End If
        End If

        If strKodeJenisDokumen = "OIGE001" Then
            If My.Settings.P_GoodsIssue = "" Then
                DisplayPesanError("Template Goods Issue Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_GoodsIssue
                GetDocEntry(strQuery, strQuery2)
            End If
        End If


        If strKodeJenisDokumen = "OVPM001" Then
            If My.Settings.P_OutgoingPayments = "" Then
                DisplayPesanError("Template Outgoing Payment Belum Ada !", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                strPathReport = My.Settings.P_OutgoingPayments
                GetDocEntry(strQuery, strQuery2)
            End If
        End If


        paramField.Name = "Dockey@"
        paramDiscreteValue.Value = MstrDocEntry
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "usercode@"
        paramDiscreteValue2.Value = MstrUsernameLogin
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)
        crv.ParameterFieldInfo = paramFields
        cryRpt.Load(strPathReport)


        With crConnectionInfo
            .ServerName = "10.1.0.53"
            .UserID = "sa"
            .Password = "h0spit4lity#"
            .DatabaseName = "RKM_live_2"
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next


        crv.ReportSource = cryRpt
        crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        crv.Refresh()

    End Sub



    Sub GetExtentionfile(strPath As String)
        ' Get extension.
        Dim extension As String = Path.GetExtension(strPath)

        ' Display extension.
        MstrExtentionFile = extension

    End Sub


    Sub CopyFileKeDirectoryAttachment(strNamaAttachments As String, strLokasiAsal As String)


        MstrpathAttatchments = "\\10.1.0.52\Attachments Surat\ITIL INCIDENT MANAGEMENT\" & Trim(strNamaAttachments) & MstrExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), MstrpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub


    Sub CopyFileKeLokasiLain(strLokasiAsal As String, strFileName As String)
        Try

            Dim LocationSave As String

            Dim mySaveFileDialog As New SaveFileDialog


            MsgBox("Silahkan Memilih Lokasi Penyimpanan", vbInformation, "Informasi!")

            mySaveFileDialog.Filter = "All files (*.*)|"
            mySaveFileDialog.FileName = strFileName
            If mySaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                LocationSave = IO.Path.GetDirectoryName(mySaveFileDialog.FileName)
                My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), LocationSave + "\" + strFileName,
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                DisplayPesanOK("Download Successfully, Saved in : " & LocationSave + "\" + strFileName, frmMainMenu.txtPesanError, 1000)

            Else

                Exit Sub
            End If

            Exit Sub



        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub

    Public Sub Module_Konfigurasi_laporan()
        With crConnectionInfo
            .ServerName = "10.1.0.53"
            .UserID = "sa"
            .Password = "h0spit4lity#"
            .DatabaseName = "DB_EMAIL"
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
    End Sub


End Module
