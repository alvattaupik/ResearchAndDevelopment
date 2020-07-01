Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Module ModuleUltility

    Dim strSQlLogin As String

    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

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




        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='cmd001' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrCmdMonitorMyRequest = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
        End If




        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Public Sub SetKontrolObject()




        If MstrMenuSuratTerima = "1" Then
            MenuUtama.SuratTerimaToolStripMenuItem.Visible = True
        Else
            MenuUtama.SuratTerimaToolStripMenuItem.Visible = False
        End If

        If MstrMenuSuratTugas = "1" Then
            MenuUtama.SuratTugasToolStripMenuItem.Visible = True
        Else
            MenuUtama.SuratTugasToolStripMenuItem.Visible = False
        End If

        If MstrMenuSuratPengajuanBiaya = "1" Then
            MenuUtama.SuratPengajuanBiayaPerjalananToolStripMenuItem.Visible = True
        Else
            MenuUtama.SuratPengajuanBiayaPerjalananToolStripMenuItem.Visible = False
        End If



        If MstrMenuBAPPenyelesaian = "1" Then
            MenuUtama.BAPPenyelesaianToolStripMenuItem.Visible = True
        Else
            MenuUtama.BAPPenyelesaianToolStripMenuItem.Visible = False
        End If

        If MstrMenuBAPSerahTerima = "1" Then
            MenuUtama.BAPSerahTerimaToolStripMenuItem.Visible = True
        Else
            MenuUtama.BAPSerahTerimaToolStripMenuItem.Visible = False
        End If


        If MstrMenuFormValidasi = "1" Then
            MenuUtama.FormValidasiToolStripMenuItem.Visible = True
        Else
            MenuUtama.FormValidasiToolStripMenuItem.Visible = False
        End If

        If MstrMenuFormCancelDanClose = "1" Then
            MenuUtama.CancelDanCloseDokumenToolStripMenuItem.Visible = True
        Else
            MenuUtama.CancelDanCloseDokumenToolStripMenuItem.Visible = False
        End If

        If MstrMenuFormOpenDanClose = "1" Then
            MenuUtama.OpenDanClosingPeriodeToolStripMenuItem.Visible = True
        Else
            MenuUtama.OpenDanClosingPeriodeToolStripMenuItem.Visible = False
        End If


        If MstrMenuMyTemplate = "1" Then
            MenuUtama.MyTemplateToolStripMenuItem.Visible = True
        Else
            MenuUtama.MyTemplateToolStripMenuItem.Visible = False
        End If


        If MstrMenuAllUsersTemplate = "1" Then
            MenuUtama.AllUsersTemplateToolStripMenuItem.Visible = True
        Else
            MenuUtama.AllUsersTemplateToolStripMenuItem.Visible = False
        End If




        If MstrMenuMasterValidasi = "1" Then
            MenuUtama.JenisValidasiToolStripMenuItem.Visible = True
        Else
            MenuUtama.JenisValidasiToolStripMenuItem.Visible = False
        End If


        If MstrMenuUserLogindanHakAkses = "1" Then
            MenuUtama.DataUserToolStripMenuItem.Visible = True
        Else
            MenuUtama.DataUserToolStripMenuItem.Visible = False
        End If


        If MstrMenuUbahPassword = "1" Then
            MenuUtama.UbahPasswordToolStripMenuItem.Visible = True
        Else
            MenuUtama.UbahPasswordToolStripMenuItem.Visible = False
        End If


        If MstrMenuMonitoringMyRequest = "1" Then
            MenuUtama.MonitoringToolStripMenuItem.Visible = True
        Else
            MenuUtama.MonitoringToolStripMenuItem.Visible = False
        End If


        If MstrMenuApprovalRequest = "1" Then
            MenuUtama.ApprovalToolStripMenuItem.Visible = True
            MenuUtama.DaftarRequestToolStripMenuItem.Visible = True
        Else
            MenuUtama.ApprovalToolStripMenuItem.Visible = False
            MenuUtama.DaftarRequestToolStripMenuItem.Visible = False
        End If


        If MstrMenuProsesRequest = "1" Then
            MenuUtama.ProsesToolStripMenuItem.Visible = True
        Else
            MenuUtama.ProsesToolStripMenuItem.Visible = False
        End If


        If MstrMenuFormPeminjamanAsset = "1" Then
            MenuUtama.FormPeminjamanAsetToolStripMenuItem.Visible = True
        Else
            MenuUtama.FormPeminjamanAsetToolStripMenuItem.Visible = False
        End If


        If MstrMenuMonitoringPeminjamanAsset = "1" Then
            MenuUtama.PeminjamanAssetToolStripMenuItem.Visible = True
        Else
            MenuUtama.PeminjamanAssetToolStripMenuItem.Visible = False
        End If


        If MstrCmdMonitorMyRequest = "1" Then
            MenuUtama.cmdMonitorMyRequest.Visible = True
        Else
            MenuUtama.cmdMonitorMyRequest.Visible = False
        End If



    End Sub



    Sub LoadTemplateSurat()

        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()




        If MstrJenisDokumen = "G001" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='G001' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "G002" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='G002' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "G003" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='G003' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "G004" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='G004' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "G005" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='G005' AND StatusEnabled='1'"
        End If




        If MstrJenisDokumen = "GA001" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='GA001' AND StatusEnabled='1'"
        End If

        If MstrJenisDokumen = "GA002" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='GA002' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "GA003" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='GA003' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "GA004" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='GA004' AND StatusEnabled='1'"
        End If

        If MstrJenisDokumen = "GA005" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='GA005' AND StatusEnabled='1'"
        End If





        If MstrJenisDokumen = "IT001" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT001' AND StatusEnabled='1'"
        End If

        If MstrJenisDokumen = "IT002" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT002' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "IT003" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='1'"
        End If

        If MstrJenisDokumen = "IT004" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT004' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "IT005" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT005' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "IT006" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT006' AND StatusEnabled='1'"
        End If



        If MstrJenisDokumen = "IT007" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT007' AND StatusEnabled='1'"
        End If


        If MstrJenisDokumen = "IT008" Then
            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT008' AND StatusEnabled='1'"
        End If


        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            MstrPathReport = dr.GetString(0)
            FormTampilkanCetakan.Show()
            dr.Close()

        Else

            MsgBox("Template Belum Ada " & vbCrLf & "Silahkan Masukan Template di Menu Setting - Template - My Template ", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub




    Sub LoadFormDetailMyRequest()
        If MstrJenisDokumen = "IT003" Then
            FormDetaiMyRequestValidasi.ShowDialog()
        End If

        If MstrJenisDokumen = "IT004" Then
            FormDetaiMyRequestCloseCancelDocument.ShowDialog()
        End If

        If MstrJenisDokumen = "IT005" Then
            FormDetaiMyRequestCloseAndOpenPostingPeriode.ShowDialog()
        End If

        If MstrJenisDokumen = "IT006" Then
            FormDetailPeminjamanSaya.ShowDialog()
        End If

    End Sub




    Sub LoadFormDetailApprovalRequest()
        If MstrJenisDokumen = "IT003" Then
            FormApprovalDetaiMyRequestValidasi.ShowDialog()
        End If

        If MstrJenisDokumen = "IT004" Then
            FormApprovalDetaiMyRequestCloseCancelDocument.ShowDialog()
        End If


        If MstrJenisDokumen = "IT005" Then
            FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.ShowDialog()
        End If


        If MstrJenisDokumen = "IT006" Then
            FormDetailPeminjamanSaya.ShowDialog()
        End If


    End Sub



    Sub LoadFormDetailProsesRequest()
        If MstrJenisDokumen = "IT003" Then
            FormProsesRequestValidasi.ShowDialog()
        End If

        If MstrJenisDokumen = "IT004" Then
            FormProsesCloseAndCancelDocuments.ShowDialog()
        End If


        If MstrJenisDokumen = "IT005" Then
            FormProsesClosingAndOpenPeriode.ShowDialog()
        End If


        If MstrJenisDokumen = "IT006" Then
            FormProsesPeminjamanAsset.ShowDialog()
        End If


    End Sub



    Sub LoadDaftarSuratMenuUtama()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT DISTINCT NomorSurat,DibuatOleh,TanggalSurat,JenisSurat,Perihal,Penerima,Attachment,KdJenisSurat,KdUser FROM V_DaftarSuratUser Where KdDivisi='" & Trim(MstrKodeDivisi) & "' Order By TanggalSurat Desc", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        MenuUtama.dgSuratSaya.DataSource = table
        MenuUtama.dgSuratSaya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        MenuUtama.dgSuratSaya.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MenuUtama.dgSuratSaya.AutoResizeColumns()
    End Sub



End Module
