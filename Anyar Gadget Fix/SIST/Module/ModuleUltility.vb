Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Module ModuleUltility

    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub



    Public Sub ShowLocation(frm As Form)

        Dim p As Point
        p = frm.Location

        MenuUtama.lblMousePosition.Text = "Form Position : " & "X : " & p.X & "  Y : " & p.Y
        MenuUtama.lblFormSize.Text = " Form Size Width: " & frm.Width.ToString & " Height:" & frm.Height.ToString
    End Sub





    Sub LoadComboBoxDBEMAIL(cmb As ComboBox, strSQL As String, strValue As String, strMember As String)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand(strSQL, Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strValue
            cmb.DisplayMember = strMember
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try

    End Sub


    Sub LoadComboBoxDBLive(cmb As ComboBox, strSQL As String, strValue As String, strMember As String)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase2()
            cmd = New SqlCommand(strSQL, Koneksi2)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strValue
            cmb.DisplayMember = strMember
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try

    End Sub





    Sub MsubPesanError()
        MsgBox("Kesalahan :" & Err.Description, vbCritical, "Silahkan Hubungi IT - Department")
    End Sub


    Sub GetKontrolObjek()
        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='File001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuLogout = dr.GetString(0)

            If MstrMenuLogout = "1" Then
                MenuUtama.LogoutToolStripMenuItem.Visible = True
            Else
                MenuUtama.LogoutToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.LogoutToolStripMenuItem.Visible = False
            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='File002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuShutdown = dr.GetString(0)


            If MstrMenuShutdown = "1" Then
                MenuUtama.ShutDownAppsToolStripMenuItem.Visible = True
            Else
                MenuUtama.ShutDownAppsToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else

            MenuUtama.ShutDownAppsToolStripMenuItem.Visible = False

            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuMonitoringRealstok = dr.GetString(0)


            If MstrMenuMonitoringRealstok = "1" Then
                MenuUtama.MonitoringRealstokToolStripMenuItem.Visible = True
            Else
                MenuUtama.MonitoringRealstokToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.MonitoringRealstokToolStripMenuItem.Visible = False
            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuDelivery = dr.GetString(0)

            If MstrMenuDelivery = "1" Then
                MenuUtama.MonitoringDeliveryToolStripMenuItem.Visible = True
            Else
                MenuUtama.MonitoringDeliveryToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else
            MenuUtama.MonitoringDeliveryToolStripMenuItem.Visible = False
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget003' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuAnyarLocalPrint = dr.GetString(0)


            If MstrMenuAnyarLocalPrint = "1" Then
                MenuUtama.AnyarLocalPrintToolStripMenuItem.Visible = True
            Else
                MenuUtama.AnyarLocalPrintToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.AnyarLocalPrintToolStripMenuItem.Visible = False
            dr.Close()
        End If




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget004' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuRKMDisplayTag = dr.GetString(0)


            If MstrMenuRKMDisplayTag = "1" Then
                MenuUtama.RKMDisplayTagToolStripMenuItem.Visible = True
            Else
                MenuUtama.RKMDisplayTagToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.RKMDisplayTagToolStripMenuItem.Visible = False
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget005' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuExportHargaJual = dr.GetString(0)

            If MstrMenuExportHargaJual = "1" Then
                MenuUtama.ExportHargaJualToolStripMenuItem.Visible = True
            Else
                MenuUtama.ExportHargaJualToolStripMenuItem.Visible = False
            End If



            dr.Close()
        Else
            MenuUtama.ExportHargaJualToolStripMenuItem.Visible = False
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget006' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuPing = dr.GetString(0)


            If MstrMenuPing = "1" Then
                MenuUtama.ShowMyIPToolStripMenuItem.Visible = True
            Else
                MenuUtama.ShowMyIPToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.ShowMyIPToolStripMenuItem.Visible = False
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget009' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormPeminjamanAsset = dr.GetString(0)

            If MstrMenuFormPeminjamanAsset = "1" Then
                MenuUtama.FormPeminjamanAssetToolStripMenuItem.Visible = True
            Else
                MenuUtama.FormPeminjamanAssetToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.FormPeminjamanAssetToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget010' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormBukaValidasi = dr.GetString(0)

            If MstrMenuFormBukaValidasi = "1" Then
                MenuUtama.FormBukaValidasiToolStripMenuItem.Visible = True
            Else
                MenuUtama.FormBukaValidasiToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else

            MenuUtama.FormBukaValidasiToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget011' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormBukaPostingPeriode = dr.GetString(0)


            If MstrMenuFormBukaPostingPeriode = "1" Then
                MenuUtama.FormBukaPostingPeriodeToolStripMenuItem.Visible = True
            Else
                MenuUtama.FormBukaPostingPeriodeToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else

            MenuUtama.FormBukaPostingPeriodeToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget012' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormRequestUmum = dr.GetString(0)


            If MstrMenuFormRequestUmum = "1" Then
                MenuUtama.FormRequestUmumToolStripMenuItem.Visible = True
            Else
                MenuUtama.FormRequestUmumToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else
            MenuUtama.FormRequestUmumToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget013' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuAnyarDirectory = dr.GetString(0)

            If MstrMenuAnyarDirectory = "1" Then
                MenuUtama.AnyarDirectoryToolStripMenuItem.Visible = True
            Else
                MenuUtama.AnyarDirectoryToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.AnyarDirectoryToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget014' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuIntegrationMonitor = dr.GetString(0)


            If MstrMenuIntegrationMonitor = "1" Then
                MenuUtama.IntegrationMonitoringToolStripMenuItem.Visible = True
            Else
                MenuUtama.IntegrationMonitoringToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else

            MenuUtama.IntegrationMonitoringToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If





        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Gadget007' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuAnyarChat = dr.GetString(0)


            If MstrMenuAnyarChat = "1" Then
                MenuUtama.AnyarChatToolStripMenuItem.Visible = True
            Else
                MenuUtama.AnyarChatToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else

            MenuUtama.AnyarChatToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If








        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Sett001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuTemplateAnyarLocalPrint = dr.GetString(0)

            If MstrMenuTemplateAnyarLocalPrint = "1" Then
                MenuUtama.AnyarLocalPrintServicesTemplateToolStripMenuItem.Visible = True
            Else
                MenuUtama.AnyarLocalPrintServicesTemplateToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.AnyarLocalPrintServicesTemplateToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Sett002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFotoProfile = dr.GetString(0)


            If MstrMenuFotoProfile = "1" Then
                MenuUtama.FotoProfileToolStripMenuItem.Visible = True
            Else
                MenuUtama.FotoProfileToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else
            MenuUtama.FotoProfileToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Sett003' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuPushNotifications = dr.GetString(0)

            If MstrMenuPushNotifications = "1" Then
                MenuUtama.PushNotificationsToolStripMenuItem.Visible = True
            Else
                MenuUtama.PushNotificationsToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else
            MenuUtama.PushNotificationsToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Sett004' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSettingUserLogin = dr.GetString(0)

            If MstrMenuSettingUserLogin = "1" Then
                MenuUtama.UserLoginDanHakAksesToolStripMenuItem.Visible = True
            Else
                MenuUtama.UserLoginDanHakAksesToolStripMenuItem.Visible = False
            End If

            dr.Close()
        Else
            MenuUtama.UserLoginDanHakAksesToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If







        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Support001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuDaftarbantuanDanMasalah = dr.GetString(0)

            If MstrMenuDaftarbantuanDanMasalah = "1" Then
                MenuUtama.DaftarBantuanDanPermasalahanToolStripMenuItem.Visible = True
            Else
                MenuUtama.DaftarBantuanDanPermasalahanToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.DaftarBantuanDanPermasalahanToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='CL001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuVersiSaatIni = dr.GetString(0)

            If MstrMenuVersiSaatIni = "1" Then
                MenuUtama.ChangeLogToolStripMenuItem.Visible = True
            Else
                MenuUtama.ChangeLogToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else

            MenuUtama.ChangeLogToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='Support002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuLaporkanmasalah = dr.GetString(0)

            If MstrMenuLaporkanmasalah = "1" Then
                MenuUtama.LaporkanMasalahToolStripMenuItem.Visible = True
            Else
                MenuUtama.LaporkanMasalahToolStripMenuItem.Visible = False
            End If


            dr.Close()
        Else
            MenuUtama.LaporkanMasalahToolStripMenuItem.Visible = False
            dr.Close()
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


   



    Sub LoadDaftarSuratMenuUtama()

        'Call KoneksiDatabase1()
        'Dim cmd As New SqlCommand("SELECT DISTINCT NomorSurat,DibuatOleh,TanggalSurat,JenisSurat,Perihal,Penerima,Attachment,KdJenisSurat,KdUser FROM V_DaftarSuratUser Where KdDivisi='" & Trim(MstrKodeDivisi) & "' Order By TanggalSurat Desc", Koneksi1)
        'cmd.CommandTimeout = 0
        'Dim adapter As New SqlDataAdapter(cmd)
        'Dim table As New DataTable
        'adapter.Fill(table)
        'MenuUtama.dgSuratSaya.DataSource = table
        'MenuUtama.dgSuratSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'MenuUtama.dgSuratSaya.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'MenuUtama.dgSuratSaya.AutoResizeColumns()

    End Sub


    'Sub getPriceListNumber()
    '    KoneksiDatabase2()
    '    strSQlLogin = "SELECT Top 1 ListNum FROM dbo.CustomMessage WHERE KdAplikasi='AG' AND StatusEnabled='1'"
    '    cmd = New SqlCommand(strSQlLogin, Koneksi1)
    '    dr = cmd.ExecuteReader
    '    dr.Read()
    '    If dr.HasRows = True Then

    '        MsgBox("Penting! " & vbCrLf & "Kategori :" & dr.GetString(2) & vbCrLf & "Pesan :" & dr.GetString(3), vbInformation)

    '        Exit Sub
    '    Else
    '        'GoTo Lanjut
    '    End If
    'End Sub



    Sub LoadNotifPerubahanHarga()
        KoneksiDatabase2()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspPerubahanHargaJual", Koneksi2)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@HargaJual", MstrHargaJual)
        command.Parameters.AddWithValue("@NotifSelect", "Header")


        Dim table As New DataTable
        adapter.Fill(table)


        If table.Rows.Count = 0 Then
            Exit Sub
        Else

            PerubahanHargaJual.dgListPerubahanHargaJual.DataSource = table
            PerubahanHargaJual.dgListPerubahanHargaJual.DataSource = table
            PerubahanHargaJual.dgListPerubahanHargaJual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            PerubahanHargaJual.dgListPerubahanHargaJual.AutoResizeColumns()
            PerubahanHargaJual.dgListPerubahanHargaJual.RowHeadersVisible = False
        End If

    End Sub



End Module
