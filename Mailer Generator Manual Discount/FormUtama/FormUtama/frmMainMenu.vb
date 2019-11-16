Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net.Mail


Public Class frmUtama


    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim reportDocument As New ReportDocument()
    Dim strRecipient As String
    Dim strErrorMail As String
    Dim strStatusMail As String
    Dim intTimer As Integer = 10
    Dim Jam, Menit, Detik As Integer
    Dim dtTglDokumen As Date
    Dim strNamaCabang As String



    Private Sub EmailConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailConfigurationToolStripMenuItem.Click
        frmSetting.ShowDialog()
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next

        Timer1.Enabled = True
        Timer1.Start()
        dtpAwal.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")
        dtpAkhir.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")

        'NextExecution()

        GetEmailSetting()
        GetAppandbehaviourSetting()

        LoadDaftarManualDiscount()
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()


        lblStrip1.Text = "Jumlah Record : " & dgDaftarManualDiscount.RowCount

        'TextBox1.Text = 
    End Sub

    Sub LoadDaftarManualDiscount()

        KoneksiDatabase()



        Dim cmd As New SqlCommand("Select  * From V_DaftarManualDiscount Where FilterDate BETWEEN '" & Format(Now, "yyyy-MM-dd") & "' AND '" & Format(Now, "yyyy-MM-dd") & "'", Koneksi)


        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgDaftarManualDiscount.DataSource = table
        'aturDGSAP()
        dgDaftarManualDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarManualDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarManualDiscount.AutoResizeColumns()
        Koneksi.Close()


    End Sub

    Sub LoadDaftarManualDiscountCustomFilter()

        KoneksiDatabase()


        Dim cmd As New SqlCommand("Select  * From V_DaftarManualDiscount Where FilterDate BETWEEN '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)


        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgDaftarManualDiscount.DataSource = table
        'aturDGSAP()
        dgDaftarManualDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarManualDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarManualDiscount.AutoResizeColumns()
        Koneksi.Close()


        lblStrip1.Text = "Jumlah Record Untuk di Proses : " & dgDaftarManualDiscount.RowCount

    End Sub

    Sub LoadDaftarEmailSent()

        KoneksiDatabaseEmail()

        Dim cmd2 As New SqlCommand("SELECT * FROM dbo.send_mail WHERE type='Manual Discount Email Notification' AND Tanggal='" & Format(Now, "yyyy-MM-dd") & "'", Koneksi2)


        Dim adapter2 As New SqlDataAdapter(cmd2)

        Dim table2 As New DataTable

        adapter2.Fill(table2)


        dgSuccess.DataSource = table2
        'aturDGSAP()
        dgSuccess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSuccess.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSuccess.AutoResizeColumns()
        Koneksi2.Close()

        lblJumlahTerkirim.Text = "Jumlah Email Terkirim : " & dgSuccess.RowCount


    End Sub

    Sub LoadDaftarFailtoSend()

        KoneksiDatabaseEmail()

        Dim cmd2 As New SqlCommand("SELECT * FROM dbo.V_DaftarEmailGagalTerkirim WHERE type='Manual Discount Email Notification' AND Tanggal='" & Format(Now, "yyyy-MM-dd") & "'", Koneksi2)

        Dim adapter2 As New SqlDataAdapter(cmd2)

        Dim table2 As New DataTable

        adapter2.Fill(table2)


        dgFailed.DataSource = table2
        dgFailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailed.AutoResizeColumns()
        Koneksi2.Close()

        lblGagalTerkirim.Text = "Jumlah Email Gagal Terkirim : " & dgSuccess.RowCount

    End Sub

    Sub LoadDaftarFailtoSendCustomDate()

        KoneksiDatabaseEmail()

        Dim cmd2 As New SqlCommand("SELECT * FROM dbo.V_DaftarEmailGagalTerkirim WHERE type='Manual Discount Email Notification' AND TanggalKirim Between '" & Format(dtpAwalFailed.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpAkhirFailed.Value, "yyyy-MM-dd") & "' ", Koneksi2)

        Dim adapter2 As New SqlDataAdapter(cmd2)

        Dim table2 As New DataTable

        adapter2.Fill(table2)


        dgFailed.DataSource = table2
        dgFailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailed.AutoResizeColumns()
        Koneksi2.Close()

        lblGagalTerkirim.Text = "Jumlah Email Gagal Terkirim : " & dgSuccess.RowCount


    End Sub

    Sub SendEmail()

        If strStatusTestmode = "" Then
            strStatusTestmode = "On"
        End If


        Try

            Dim mail As New MailMessage
            Dim SmtpServer As New SmtpClient(strHost)
            mail.From = New MailAddress(strSender)


            If strStatusTestmode = "On" Then
                mail.[To].Add(Trim(strPenerima))
            Else
                mail.[To].Add(Trim(txtPenerima.Text))
            End If


            'mail.[To].Add(strPenerima)
            'mail.[To].Add(DataGridView1.Rows(i).Cells(3).Value)

            If strCC = "" Then
                mail.CC.Clear()
            Else
                mail.CC.Add(strCC)
            End If


            mail.Subject = strSubject & " " & strNamaCabang
            mail.Body = strBody & txtNoDokumen.Text & strFooter
            mail.IsBodyHtml = True
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(strLokasiExport & txtNoDokumen.Text & ".pdf")
            mail.Attachments.Add(attachment)

            SmtpServer.Port = strPort
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New System.Net.NetworkCredential(strSender, strPasswordEmail)
            'SmtpServer.EnableSsl = True

            SmtpServer.Send(mail)
            strStatusMail = "Sent"
            'MessageBox.Show("mail Send")
        Catch ex As Exception
            strErrorMail = (ex.Message)
            'strErrorMail = ("Error Sending e-mail" & Environment.NewLine)
            strStatusMail = "Failed to Send"

        End Try
    End Sub

    Sub SendErrorEmail()

        'If strStatusTestmode = "" Then
        '    strStatusTestmode = "On"
        'End If


        Try

            Dim mail As New MailMessage
            Dim SmtpServer As New SmtpClient(strHost)
            mail.From = New MailAddress(strSender)



            mail.[To].Add(strPenerimaPesanError)

            'mail.[To].Add(strPenerima)
            'mail.[To].Add(DataGridView1.Rows(i).Cells(3).Value)

            If strCC = "" Then
                mail.CC.Clear()
            Else
                mail.CC.Add(strCCError)
            End If


            mail.Subject = strSubjectError
            mail.Body = strHeaderError & strBodyError & Err.Description & strFooter
            mail.IsBodyHtml = True
            'Dim attachment As System.Net.Mail.Attachment
            'attachment = New System.Net.Mail.Attachment(strLokasiExport & txtNoDokumen.Text & ".pdf")
            'mail.Attachments.Add(attachment)

            SmtpServer.Port = strPort
            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Credentials = New System.Net.NetworkCredential(strSender, strPasswordEmail)
            'SmtpServer.EnableSsl = True

            SmtpServer.Send(mail)
            strStatusMail = "Sent"
            'MessageBox.Show("mail Send")
        Catch ex As Exception
            strErrorMail = (ex.Message)
            'strErrorMail = ("Error Sending e-mail" & Environment.NewLine)
            strStatusMail = "Failed to Send"

        End Try
    End Sub

    Sub SimpanData()
        If strStatusMail = "Sent" Then

            Call KoneksiDatabaseEmail()
            Koneksi2.Close()

            Dim sqlComm2 As New SqlCommand

            sqlComm2.Connection = Koneksi2


            sqlComm2.CommandText = "[AU_ManualDiscountEmail]"
            sqlComm2.CommandType = CommandType.StoredProcedure

            sqlComm2.Parameters.AddWithValue("Type", "Manual Discount Email Notification")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", strStatusMail)
            sqlComm2.Parameters.AddWithValue("Tanggal", Format(dtTglDokumen, "yyyy-MM-dd"))
            sqlComm2.Parameters.AddWithValue("Email", strPenerima)
            sqlComm2.Parameters.AddWithValue("ErrorMessage", "")
            sqlComm2.Parameters.AddWithValue("StatusEmail", strStatusMail)
            sqlComm2.Parameters.AddWithValue("TanggalKirim", Format(Now, "yyyy-MM-dd"))
            Koneksi2.Open()
            sqlComm2.ExecuteNonQuery()


            Koneksi2.Close()

            LoadDaftarEmailSent()


        Else

            Call KoneksiDatabaseEmail()
            Koneksi2.Close()

            Dim sqlComm2 As New SqlCommand

            sqlComm2.Connection = Koneksi2


            sqlComm2.CommandText = "[AU_ManualDiscountEmail]"
            sqlComm2.CommandType = CommandType.StoredProcedure

            sqlComm2.Parameters.AddWithValue("Type", "Manual Discount Email Notification")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", "Failed")
            sqlComm2.Parameters.AddWithValue("Tanggal", Format(dtTglDokumen, "yyyy-MM-dd"))
            sqlComm2.Parameters.AddWithValue("Email", strPenerima)
            sqlComm2.Parameters.AddWithValue("ErrorMessage", strErrorMail)
            sqlComm2.Parameters.AddWithValue("StatusEmail", "Failed")
            sqlComm2.Parameters.AddWithValue("TanggalKirim", Format(Now, "yyyy-MM-dd"))
            Koneksi2.Open()
            sqlComm2.ExecuteNonQuery()
            Koneksi2.Close()

            LoadDaftarFailtoSend()
        End If



    End Sub

    Sub SimpanDataResend()
        If strStatusMail = "Sent" Then

            Call KoneksiDatabaseEmail()
            Koneksi2.Close()

            Dim sqlComm2 As New SqlCommand

            sqlComm2.Connection = Koneksi2


            sqlComm2.CommandText = "[AU_ManualDiscountEmail]"
            sqlComm2.CommandType = CommandType.StoredProcedure

            sqlComm2.Parameters.AddWithValue("Type", "Manual Discount Email Notification")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", "Resend & Success")
            sqlComm2.Parameters.AddWithValue("Tanggal", Format(dtTglDokumen, "yyyy-MM-dd"))
            sqlComm2.Parameters.AddWithValue("Email", strPenerima)
            sqlComm2.Parameters.AddWithValue("ErrorMessage", "")
            sqlComm2.Parameters.AddWithValue("StatusEmail", strStatusMail)
            sqlComm2.Parameters.AddWithValue("TanggalKirim", Format(Now, "yyyy-MM-dd"))
            Koneksi2.Open()
            sqlComm2.ExecuteNonQuery()


            Koneksi2.Close()

            LoadDaftarEmailSent()


        Else

            Call KoneksiDatabaseEmail()
            Koneksi2.Close()

            Dim sqlComm2 As New SqlCommand

            sqlComm2.Connection = Koneksi2


            sqlComm2.CommandText = "[AU_ManualDiscountEmail]"
            sqlComm2.CommandType = CommandType.StoredProcedure

            sqlComm2.Parameters.AddWithValue("Type", "Manual Discount Email Notification")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", "Resend & Failed")
            sqlComm2.Parameters.AddWithValue("Tanggal", Format(dtTglDokumen, "yyyy-MM-dd"))
            sqlComm2.Parameters.AddWithValue("Email", strPenerima)
            sqlComm2.Parameters.AddWithValue("ErrorMessage", strErrorMail)
            sqlComm2.Parameters.AddWithValue("StatusEmail", "Failed")
            sqlComm2.Parameters.AddWithValue("TanggalKirim", Format(Now, "yyyy-MM-dd"))
            Koneksi2.Open()
            sqlComm2.ExecuteNonQuery()
            Koneksi2.Close()

            LoadDaftarFailtoSend()
        End If



    End Sub

    Sub ExportDokumen()
        Try
            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptions.DiskFileName = strLokasiExport & txtNoDokumen.Text & ".pdf"
            CrExportOptions = rptDoc.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            rptDoc.Export()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Sub LoopGridManualDiscount()
        On Error GoTo Errorhandler

        For i As Integer = 0 To dgDaftarManualDiscount.Rows.Count - 1
            txtNoDokumen.Text = dgDaftarManualDiscount.Rows(i).Cells("TransactionKey").Value
            txtPenerima.Text = strPenerima
            dtTglDokumen = dgDaftarManualDiscount.Rows(i).Cells("ActualDate").Value
            strNamaCabang = dgDaftarManualDiscount.Rows(i).Cells("Cabang").Value


            rptDoc = New crManualDiscount

            'Dim cmd As New SqlCommand("Select  * From V_DaftarManualDiscount Where TransactionKey='" & Trim(txtNoDokumen.Text) & "'", Koneksi)
            'Dim adapter1 As New SqlDataAdapter(cmd)
            'Dim Tabel1 As New DataTable

            'adapter1.Fill(Tabel1)

            'rptDoc.SetDataSource(Tabel1)
            'CrystalReportViewer1.ReportSource = rptDoc
            'CrystalReportViewer1.Refresh()


            Dim cmd As SqlCommand

            cmd = New SqlCommand("_TmSp_ManualDiskonAlert", Koneksi)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@TransactionKey", Trim(txtNoDokumen.Text)))


            Dim Tabel1 As New DataTable
            Dim adapter1 As SqlDataAdapter
            adapter1 = New SqlDataAdapter
            adapter1.SelectCommand = cmd
            adapter1.Fill(Tabel1)

            rptDoc.SetDataSource(Tabel1)
            CrystalReportViewer1.ReportSource = rptDoc
            CrystalReportViewer1.Refresh()


            Call ExportDokumen()
            Call SendEmail()
            Call SimpanData()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()

        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarManualDiscount()
        NextExecution()

        If dgFailed.RowCount = 0 Then
            NextExecution()
            Exit Sub

        Else

            For i As Integer = 0 To dgFailed.Rows.Count - 1
                txtNoDokumen.Text = dgFailed.Rows(i).Cells("code").Value
                txtPenerima.Text = strPenerima
                dtTglDokumen = dgDaftarManualDiscount.Rows(i).Cells("ActualDate").Value


                rptDoc = New crManualDiscount

                Dim cmd As SqlCommand

                cmd = New SqlCommand("_TmSp_ManualDiskonAlert", Koneksi)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@TransactionKey", Trim(txtNoDokumen.Text)))


                Dim Tabel1 As New DataTable
                Dim adapter1 As SqlDataAdapter
                adapter1 = New SqlDataAdapter
                adapter1.SelectCommand = cmd
                adapter1.Fill(Tabel1)

                rptDoc.SetDataSource(Tabel1)
                CrystalReportViewer1.ReportSource = rptDoc
                CrystalReportViewer1.Refresh()

                'Call ExportDokumen()
                Call SendEmail()
                Call SimpanDataResend()

                LoadDaftarEmailSent()
                LoadDaftarFailtoSend()

            Next

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            LoadDaftarManualDiscount()
            NextExecution()
        End If

Errorhandler:

        Call MsubPesanError()
        Call SendErrorEmail()
        Exit Sub

    End Sub

    Sub LoopGridManualDiscountCustomFilter()

        On Error GoTo ErrorHandler

        For i As Integer = 0 To dgDaftarManualDiscount.Rows.Count - 1

            txtNoDokumen.Text = dgDaftarManualDiscount.Rows(i).Cells("TransactionKey").Value
            txtPenerima.Text = strPenerima
            dtTglDokumen = dgDaftarManualDiscount.Rows(i).Cells("ActualDate").Value
            strNamaCabang = dgDaftarManualDiscount.Rows(i).Cells("Cabang").Value

            rptDoc = New crManualDiscount

            Dim cmd As New SqlCommand("Select * From V_DaftarManualDiscount Where TransactionKey='" & Trim(txtNoDokumen.Text) & "'", Koneksi)
            Dim adapter1 As New SqlDataAdapter(cmd)
            Dim Tabel1 As New DataTable

            adapter1.Fill(Tabel1)

            rptDoc.SetDataSource(Tabel1)
            CrystalReportViewer1.ReportSource = rptDoc
            CrystalReportViewer1.Refresh()

            Call ExportDokumen()
            Call SendEmail()
            Call SimpanData()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()

        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()

        If dgFailed.RowCount = 0 Then
            Exit Sub

        Else

            For i As Integer = 0 To dgFailed.Rows.Count - 1
                txtNoDokumen.Text = dgFailed.Rows(i).Cells("code").Value
                txtPenerima.Text = strPenerima

                rptDoc = New crManualDiscount

                Dim cmd As New SqlCommand("Select *  From  Where TransactionKey='" & Trim(txtNoDokumen.Text) & "'", Koneksi)
                Dim adapter1 As New SqlDataAdapter(cmd)
                Dim Tabel1 As New DataTable

                adapter1.Fill(Tabel1)

                rptDoc.SetDataSource(Tabel1)
                CrystalReportViewer1.ReportSource = rptDoc
                CrystalReportViewer1.Refresh()



                Call ExportDokumen()
                Call SendEmail()
                Call SimpanDataResend()

                LoadDaftarEmailSent()
                LoadDaftarFailtoSend()

            Next

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            LoadDaftarManualDiscountCustomFilter()

        End If

ErrorHandler:
        Call MsubPesanError()
        Call SendErrorEmail()
        Exit Sub


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoadDaftarManualDiscountCustomFilter()
        LoopGridManualDiscountCustomFilter()
    End Sub

    Private Sub BehaviourAndConfigurationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BehaviourAndConfigurationsToolStripMenuItem.Click
        frmKonfigurasiAplikasi.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If intTimer = 0 Then

            Timer1.Stop()
            Timer1.Enabled = False
            LoopGridManualDiscount()
            lblAwal.Visible = False
            lblCounter.Visible = False

        Else

            intTimer -= 1
            lblCounter.Text = intTimer

        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        Timer1.Enabled = False
        lblCounter.Text = 0
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GetAppandbehaviourSetting()
        Call GetEmailSetting()
        Dim strA As String

        strA = strDurasiDelay

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Detik -= 1
        If Detik < 0 Then
            Detik = 59
            Menit -= 1
            If Menit < 0 Then
                Menit = 59
                Jam -= 1
            End If
        End If

        lblTime.Text = Format(Jam, "00") & ":" & Format(Menit, "00") & ":" & Format(Detik, "00")

        If Jam = 0 And Menit = 0 And Detik = 0 Then
            Timer2.Enabled = False
            Call LoadDaftarManualDiscount()
            Call LoopGridManualDiscount()
        End If
    End Sub

    Sub NextExecution()
        Jam = strDurasiDelay
        Menit = 0
        Detik = 0

        lblTime.Text = Format(Jam, "00") & ":" & Format(Menit, "00") & ":" & Format(Detik, "00")
        lblTime.Visible = True
        lblJudul.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub cmdShow_Click(sender As Object, e As EventArgs)
        LoadDaftarManualDiscountCustomFilter()
    End Sub

    Private Sub cmdRetry_Click(sender As Object, e As EventArgs) Handles cmdRetry.Click

        If dgFailed.RowCount = 0 Then Exit Sub

        txtNoDokumen.Text = dgFailed.Item(5, dgFailed.CurrentRow.Index).Value
        txtPenerima.Text = dgFailed.Item(4, dgFailed.CurrentRow.Index).Value
        dtTglDokumen = dgFailed.Item(3, dgFailed.CurrentRow.Index).Value

        rptDoc = New crManualDiscount


        Dim cmd As SqlCommand

        cmd = New SqlCommand("_TmSp_ManualDiskonAlert", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TransactionKey", Trim(txtNoDokumen.Text)))


        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)

        rptDoc.SetDataSource(Tabel1)
        CrystalReportViewer1.ReportSource = rptDoc
        CrystalReportViewer1.Refresh()



        Call ExportDokumen()
        Call SendEmail()
        Call SimpanData()

        LoadDaftarEmailSent()
        'LoadDaftarFailtoSend()
        LoadDaftarFailtoSendCustomDate()

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        lblAwal.Visible = False
        lblCounter.Visible = False
        NextExecution()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        Timer1.Enabled = False
        lblCounter.Text = 0
    End Sub

    Private Sub cmdPaused_Click(sender As Object, e As EventArgs) Handles cmdPaused.Click
        Timer2.Enabled = False
    End Sub

    Private Sub cmdShowData_Click(sender As Object, e As EventArgs) Handles cmdShowData.Click
        LoadDaftarFailtoSendCustomDate()
    End Sub

    Private Sub ErrorNotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorNotificationToolStripMenuItem.Click
        frmErrorHandler.ShowDialog()
    End Sub

    Private Sub cmdRetryAll_Click(sender As Object, e As EventArgs) Handles cmdRetryAll.Click

        On Error GoTo Errorhandler

        For i As Integer = 0 To dgFailed.Rows.Count - 1


            txtNoDokumen.Text = dgFailed.Item(5, dgFailed.CurrentRow.Index).Value
            txtPenerima.Text = dgFailed.Item(4, dgFailed.CurrentRow.Index).Value
            dtTglDokumen = dgFailed.Item(3, dgFailed.CurrentRow.Index).Value

            rptDoc = New crManualDiscount


            Dim cmd As SqlCommand

            cmd = New SqlCommand("_TmSp_ManualDiskonAlert", Koneksi)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@TransactionKey", Trim(txtNoDokumen.Text)))


            Dim Tabel1 As New DataTable
            Dim adapter1 As SqlDataAdapter
            adapter1 = New SqlDataAdapter
            adapter1.SelectCommand = cmd
            adapter1.Fill(Tabel1)

            rptDoc.SetDataSource(Tabel1)
            CrystalReportViewer1.ReportSource = rptDoc
            CrystalReportViewer1.Refresh()



            Call ExportDokumen()
            Call SendEmail()



            Call SimpanData()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            LoadDaftarFailtoSendCustomDate()

        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarFailtoSendCustomDate()


Errorhandler:
        Call MsubPesanError()
        Call SendErrorEmail()
        Exit Sub

    End Sub



    Private Sub cmdShowManualParameter_Click(sender As Object, e As EventArgs) Handles cmdShowManualParameter.Click
        LoadDaftarManualDiscountCustomFilter()
    End Sub

    Private Sub cmdStartmanualparameter_Click(sender As Object, e As EventArgs) Handles cmdStartmanualparameter.Click
        LoopGridManualDiscountCustomFilter()
    End Sub
End Class
