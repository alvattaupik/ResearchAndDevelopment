Imports WhatsAppNETAPI
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class Form1


    Dim strLokasiSImpan As String
    Dim MdblDurasiDetikTimerNotifikasi As Double = 30
    Dim second As Integer
    Dim bolStatusTimer As Boolean = False


    Dim intDelaySendMessageLampiran As Integer
    Dim intDelaySendMessageTanpaLampiran As Integer

    Dim intDelayBCLampiran As Integer
    Dim intDelayBCTanpaLampiran As Integer

    Dim strPathExport As String
    Dim strLokasiFile As String

    Dim strSatuanInterval As String
    Dim intDurasi As Integer

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


        If (_whatsAppApi.Connect(url)) Then

            While (Not _whatsAppApi.OnReady())
                Tunggu(1)
            End While

            btnStart.Enabled = False
            btnStop.Enabled = True

        End If
    End Sub


    Private Sub cmdKirim_Click(sender As Object, e As EventArgs) Handles cmdKirim.Click
        LoadKonfigurasi()
        LoopDaftarPenerima()
    End Sub







    Sub LoopDaftarPenerima()

        LoadManualDiscount()
        LoadKonfigurasi()
        ExportDokumen()


        For i As Integer = 0 To dglistkontak.Rows.Count - 1


            If (Not String.IsNullOrEmpty(strPathExport)) Then
                _whatsAppApi.SendMessage(New MsgArgs(dglistkontak.Rows(i).Cells("NoTelepon").Value, dglistkontak.Rows(i).Cells("CustomMessage").Value, strPathExport))

                Tunggu(intDelaySendMessageLampiran)


            Else
                _whatsAppApi.SendMessage(New MsgArgs(dglistkontak.Rows(i).Cells("NoTelepon").Value, dglistkontak.Rows(i).Cells("CustomMessage").Value))

                Tunggu(intDelaySendMessageTanpaLampiran)
            End If



        Next


    End Sub


    Sub LoadDaftarKontak()
        On Error Resume Next
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoTelepon,NamaPenerima,CustomMessage FROM dbo.WaReceiver", Koneksi1)
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

            If strSatuanInterval = "H" Then
                intDurasi = My.Settings.NilaiInterval * 3600
            Else
                intDurasi = My.Settings.NilaiInterval * 60
            End If

        End With
    End Sub



    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _whatsAppApi.Disconnect()

        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub
End Class
