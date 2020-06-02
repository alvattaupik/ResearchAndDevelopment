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


    Sub MsubPesanError()
        MsgBox("Kesalahan :" & Err.Description, vbCritical, "Silahkan Hubungi IT - Department")
    End Sub


    Sub GetKontrolObjek()
        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratJalan = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratTerima = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat003' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratTugas = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat004' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratPengajuanBiaya = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='BA001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuBAPPenyelesaian = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='BA002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuBAPSerahTerima = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormValidasi = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormCancelDanClose = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req003' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormOpenDanClose = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Mon001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuMonitoringMyRequest = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Aprv001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuApprovalRequest = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Proc001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuProsesRequest = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If







        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Set001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuMyTemplate = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Set002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuMasterValidasi = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Set003' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuUserLogindanHakAkses = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Set004' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuUbahPassword = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If


        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Set005' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuAllUsersTemplate = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req004' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormPeminjamanAsset = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Mon002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuMonitoringPeminjamanAsset = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Public Sub SetKontrolObject()

        'If MstrMenuSuratJalan = "Y" Then
        '    MenuUtama.SuratJalanToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.SuratJalanToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuSuratTerima = "Y" Then
        '    MenuUtama.SuratTerimaToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.SuratTerimaToolStripMenuItem.Visible = False
        'End If

        'If MstrMenuSuratTugas = "Y" Then
        '    MenuUtama.SuratTugasToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.SuratTugasToolStripMenuItem.Visible = False
        'End If

        'If MstrMenuSuratPengajuanBiaya = "Y" Then
        '    MenuUtama.SuratPengajuanBiayaPerjalananToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.SuratPengajuanBiayaPerjalananToolStripMenuItem.Visible = False
        'End If



        'If MstrMenuBAPPenyelesaian = "Y" Then
        '    MenuUtama.BAPPenyelesaianToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.BAPPenyelesaianToolStripMenuItem.Visible = False
        'End If

        'If MstrMenuBAPSerahTerima = "Y" Then
        '    MenuUtama.BAPSerahTerimaToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.BAPSerahTerimaToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuFormValidasi = "Y" Then
        '    MenuUtama.FormValidasiToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.FormValidasiToolStripMenuItem.Visible = False
        'End If

        'If MstrMenuFormCancelDanClose = "Y" Then
        '    MenuUtama.CancelDanCloseDokumenToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.CancelDanCloseDokumenToolStripMenuItem.Visible = False
        'End If

        'If MstrMenuFormOpenDanClose = "Y" Then
        '    MenuUtama.OpenDanClosingPeriodeToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.OpenDanClosingPeriodeToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuMyTemplate = "Y" Then
        '    MenuUtama.MyTemplateToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.MyTemplateToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuAllUsersTemplate = "Y" Then
        '    MenuUtama.AllUsersTemplateToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.AllUsersTemplateToolStripMenuItem.Visible = False
        'End If




        'If MstrMenuMasterValidasi = "Y" Then
        '    MenuUtama.JenisValidasiToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.JenisValidasiToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuUserLogindanHakAkses = "Y" Then
        '    MenuUtama.DataUserToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.DataUserToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuUbahPassword = "Y" Then
        '    MenuUtama.UbahPasswordToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.UbahPasswordToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuMonitoringMyRequest = "Y" Then
        '    MenuUtama.MonitoringToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.MonitoringToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuApprovalRequest = "Y" Then
        '    MenuUtama.ApprovalToolStripMenuItem.Visible = True
        '    MenuUtama.DaftarRequestToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.ApprovalToolStripMenuItem.Visible = False
        '    MenuUtama.DaftarRequestToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuProsesRequest = "Y" Then
        '    MenuUtama.ProsesToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.ProsesToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuFormPeminjamanAsset = "Y" Then
        '    MenuUtama.FormPeminjamanAsetToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.FormPeminjamanAsetToolStripMenuItem.Visible = False
        'End If


        'If MstrMenuMonitoringPeminjamanAsset = "Y" Then
        '    MenuUtama.PeminjamanAssetToolStripMenuItem.Visible = True
        'Else
        '    MenuUtama.PeminjamanAssetToolStripMenuItem.Visible = False
        'End If



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



End Module
