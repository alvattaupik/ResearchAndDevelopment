Imports System.Collections.Generic
Imports System.Threading
Imports WhatsAppNETAPI
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports ConceptCave.WaitCursor


Public Class Form1


    Dim strLokasiSImpan As String
    Dim MdblDurasiDetikTimerNotifikasi As Double = 30
    Dim second As Integer
    Dim bolStatusTimer As Boolean = False
    Dim bolStatusRecord As Boolean = False


    Dim intDelaySendMessageLampiran As Integer
    Dim intDelaySendMessageTanpaLampiran As Integer

    Dim intDelayBCLampiran As Integer
    Dim intDelayBCTanpaLampiran As Integer

    Dim strPathExport As String
    Dim strLokasiFile As String

    Dim strSatuanInterval As String
    Dim intDurasi As Integer

    Dim strKalimatAutoReply As String

    Dim DblTimer As Double
    Dim dblTempTimer As Double

    Private _whatsAppApi As IWhatsAppNETAPI







    Private Sub Tunggu(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click


        If My.Settings.DelayMessageLampiran = "" Or My.Settings.DelayMessageTanpaLampiran = "" Or My.Settings.SatuanInterval = "" Or My.Settings.NilaiInterval = "" Then
            MsgBox("Beberapa Konfigurasi Parameter Belum Di Isi", vbCritical, "Penting!")
            SettingAplikasi.ShowDialog()
            Exit Sub
        End If



        LoadKonfigurasi()




        _whatsAppApi = New WhatsAppNETAPI.WhatsAppNETAPI()
        Dim url = "https://web.whatsapp.com"
        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))

            If (_whatsAppApi.Connect(url, rbStealthMode.Checked)) Then
                While (Not _whatsAppApi.OnReady())
                    If rbStealthMode.Checked Then
                        If _whatsAppApi.IsScanMe() Then
                            Dim frmScanQRCode = New QRCode(_whatsAppApi)
                            frmScanQRCode.ShowDialog()
                        End If
                    End If
                    Thread.Sleep(1000)
                End While

                btnStart.Enabled = False
                btnStop.Enabled = True
                cmdGetContactList.Enabled = True
                TimerExecute.Start()




            Else
                _whatsAppApi.Disconnect()
            End If

        End Using








    End Sub


    Private Sub cmdKirim_Click(sender As Object, e As EventArgs) Handles cmdKirim.Click
        LoadKonfigurasi()
        LoopDaftarPenerima()
    End Sub







    Sub LoopDaftarPenerima()
        CekStatusRow()


        If bolStatusRecord = True Then
            LoadManualDiscount()
            LoadKonfigurasi()
            ExportDokumen()
        Else
            Exit Sub
        End If



        If strPathExport <> "" Then

            For i As Integer = 0 To dglistkontak.Rows.Count - 1
                _whatsAppApi.SendMessage(New MsgArgs(dglistkontak.Rows(i).Cells("NoTelepon").Value, dglistkontak.Rows(i).Cells("CustomMessage").Value))

                Tunggu(intDelaySendMessageTanpaLampiran)
            Next


            GoTo Lampiran

        Else

            For i As Integer = 0 To dglistkontak.Rows.Count - 1
                _whatsAppApi.SendMessage(New MsgArgs(dglistkontak.Rows(i).Cells("NoTelepon").Value, dglistkontak.Rows(i).Cells("CustomMessage").Value))

                Tunggu(intDelaySendMessageTanpaLampiran)
            Next

        End If

        Exit Sub


Lampiran:

        For i As Integer = 0 To dglistkontak.Rows.Count - 1

            _whatsAppApi.SendMessage(New MsgArgs(dglistkontak.Rows(i).Cells("NoTelepon").Value, "", strPathExport))

            Tunggu(intDelaySendMessageLampiran)

            lblStatusPengiriman.Text = "Telah Terkirim" & dglistkontak.Rows.Count - 1 & " Dari " & dglistkontak.Rows.Count & " Penerima"

        Next
        LoadKonfigurasi()
        TimerExecute.Start()



    End Sub


    Sub LoadDaftarKontak()
        On Error Resume Next
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoTelepon,NamaPenerima,CustomMessage FROM dbo.KontakWhatsapp", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dglistkontak.DataSource = table
        dglistkontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dglistkontak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dglistkontak.RowHeadersVisible = False
        dglistkontak.AutoResizeColumns()

    End Sub

    Sub LoadManualDiscount()




        cryRpt = New WAManualDiscount
        Module_Konfigurasi_laporan()
        CrystalReportViewer1.ReportSource = strLokasiFile

        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        CrystalReportViewer1.Refresh()

    End Sub


    Sub ExportDokumen()

        If strPathExport = "" Then
            Exit Sub
        End If


        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = strPathExport
            CrExportOptions = cryRpt.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            cryRpt.Export()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarKontak()
        lblIntervalTimer.Text = "Interval " & My.Settings.NilaiInterval & " " & My.Settings.SatuanInterval
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiToolStripMenuItem.Click
        SettingAplikasi.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoadDaftarKontak()
    End Sub



    Sub LoadKonfigurasi()
        With My.Settings
            strPathExport = .PathExport
            intDelaySendMessageLampiran = .DelayMessageLampiran
            intDelaySendMessageTanpaLampiran = .DelayMessageTanpaLampiran
            strLokasiFile = .LokasiFileReport
            'txtBCLampiran.Text = .DelayBCLampiran
            'txtBCTanpaLampiran.Text = .DelayBCTanpaLampiran

            strSatuanInterval = .SatuanInterval

            If strSatuanInterval = "H" Then
                intDurasi = My.Settings.NilaiInterval * 3600
            Else
                intDurasi = My.Settings.NilaiInterval * 60
            End If

            strKalimatAutoReply = .KalimatAutoReply


        End With
    End Sub



    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _whatsAppApi.Disconnect()

        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub cmdGetContactList_Click(sender As Object, e As EventArgs) Handles cmdGetContactList.Click
        Using New StCursor(Cursors.WaitCursor, New TimeSpan(0, 0, 0, 0))
            Dim contacts = _whatsAppApi.GrabContacts()

            Dim frmContact = New DaftarKontak(contacts)
            frmContact.ShowDialog()
        End Using
    End Sub

    Private Sub TimerExecute_Tick(sender As Object, e As EventArgs) Handles TimerExecute.Tick

        intDurasi = intDurasi - 1

        lblNextExecute.Text = "Next Execution In " & intDurasi.ToString

        If lblNextExecute.Text = "Next Execution In 0" Then
            TimerExecute.Stop()
            cmdKirim.PerformClick()
        End If


    End Sub




    Sub CekStatusRow()

        KoneksiDatabase2()
        Dim command As SqlCommand
        command = New SqlCommand("tmspNotifikasiManualDiskonWA", Koneksi2)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure



        Dim table As New DataTable
        adapter.Fill(table)


        If table.Rows.Count = 0 Then
            bolStatusRecord = False
            
            Exit Sub
        Else
            bolStatusRecord = True
        End If
    End Sub

    Private Sub KontakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KontakToolStripMenuItem.Click
        MasterKontak.ShowDialog()
    End Sub

 



    Private Sub chkAktif_CheckedChanged(sender As Object, e As EventArgs) Handles chkAktif.CheckedChanged


        If (chkAktif.Checked) Then
            AddHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            _whatsAppApi.MessageSubscribe()
        Else
            RemoveHandler _whatsAppApi.OnMessageRecieved, AddressOf OnMessageRecievedEventHandler
            lvDaftarPesan.Items.Clear()
        End If
    End Sub






    Private Sub OnMessageRecievedEventHandler(e As MsgArgs)
        Dim msg = String.Format("[{0}] {1}: {2}",
                e.TimeStamp.ToString("yyyy-MM-dd HH:mm:ss"), e.Sender, e.Msg)

        ' karena pesan yang masuk beda thread, 
        ' jadi harus menggunakan cara seperti ini untuk mengupdate UI
        lvDaftarPesan.Invoke(
            Sub()
                lvDaftarPesan.Items.Add(msg)
                lvDaftarPesan.SelectedIndex = lvDaftarPesan.Items.Count - 1
            End Sub
        )

      
    End Sub



End Class
