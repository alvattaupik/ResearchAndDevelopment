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


    Private Sub EmailConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailConfigurationToolStripMenuItem.Click
        frmSetting.ShowDialog()
    End Sub

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next

        Timer1.Enabled = True
        Timer1.Start()
        dtpAwal.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")
        dtpAkhir.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")

        dtpAwalFailed.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")
        dtpAkhirFailed.Value = Format(Now, "yyyy-MM-dd HH:mm:ss")

        'NextExecution()
        GetEmailSetting()
        GetAppandbehaviourSetting()

        LoadDaftarOutgoingPayments()
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()

        lblStrip1.Text = "Jumlah Record Untuk DiProses : " & dgDaftarManualDiscount.RowCount

        'TextBox1.Text = 
    End Sub

    Sub LoadDaftarOutgoingPayments()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT * FROM dbo.V_DaftarOutgoingPayments Where DocDate BETWEEN '" & Format(Now, "yyyy-MM-dd") & "' AND '" & Format(Now, "yyyy-MM-dd") & "'", Koneksi)
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

    Sub LoadDaftarOutgoingPaymentsCustomFilter()

        KoneksiDatabase()
        Dim cmd As New SqlCommand("SELECT * FROM dbo.V_DaftarOutgoingPayments Where DocDate BETWEEN '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)
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

    Sub LoadDaftarEmailSent()

        KoneksiDatabaseEmail()

        Dim cmd2 As New SqlCommand("SELECT * FROM dbo.send_mail WHERE type='Outgoing Payments' AND TanggalKirim='" & Format(Now, "yyyy-MM-dd") & "'", Koneksi2)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable

        adapter2.Fill(table2)

        dgSuccess.DataSource = table2
        'aturDGSAP()
        dgSuccess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSuccess.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSuccess.AutoResizeColumns()
        Koneksi2.Close()

        lblRecordTerkirim.Text = "Jumlah Record Terkirim : " & dgSuccess.RowCount

    End Sub

    Sub LoadDaftarFailtoSend()

        KoneksiDatabaseEmail()

        Dim cmd2 As New SqlCommand("SELECT * FROM dbo.V_DaftarEmailGagalTerkirim WHERE type='Outgoing Payments' AND TanggalKirim='" & Format(Now, "yyyy-MM-dd") & "'", Koneksi2)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)


        dgFailed.DataSource = table2
        dgFailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailed.AutoResizeColumns()
        Koneksi2.Close()

        lblJumlahRecordgagal.Text = "Jumlah Record Gagal Terkirim : " & dgFailed.RowCount

    End Sub

    Sub SendEmail()
        Dim strCustomMessage As String
        Dim strCustomMessage2 As String

        If strTestMode = "" Then
            strTestMode="On"
        End If

        strCustomMessage = "</br></br>Payment Number: " & Trim(txtNoDokumen.Text) & " Payment Date: " & dtTglDokumen
        strCustomMessage2 = "</br></br>Please Feel Free to Contact us if you do not receive any attachment."

        Try

            Dim mail As New MailMessage
            Dim SmtpServer As New SmtpClient(strHost)
            mail.From = New MailAddress(strSender)



            If strTestMode = "On" Then
                mail.[To].Add(Trim(strPenerima))
            Else
                mail.[To].Add(Trim(txtPenerima.Text))
            End If

            'mail.[To].Add(Trim(strPenerima))

            'mail.[To].Add(DataGridView1.Rows(i).Cells(3).Value)
            If strCC = "" Then
                mail.CC.Clear()
            Else
                mail.CC.Add(strCC)
            End If




            mail.Subject = strSubject
            mail.Body = strHeader & strBody & strCustomMessage & strCustomMessage2 & strFooter
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



        Catch ex As Exception
            strErrorMail = (ex.Message)
            'strErrorMail = ("Error Sending e-mail" & Environment.NewLine)
            strStatusMail = "Failed to Send"
            Exit Sub
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

            sqlComm2.Parameters.AddWithValue("Type", "Outgoing Payments")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", strStatusMail)
            sqlComm2.Parameters.AddWithValue("Tanggal", dtTglDokumen)
            sqlComm2.Parameters.AddWithValue("Email", Trim(txtPenerima.Text))
            sqlComm2.Parameters.AddWithValue("ErrorMessage", "")
            sqlComm2.Parameters.AddWithValue("StatusEmail", strStatusMail)
            sqlComm2.Parameters.AddWithValue("TanggalKirim", Format(Now, "yyyy-MM-dd"))

            Koneksi2.Open()
            sqlComm2.ExecuteNonQuery()


            Koneksi2.Close()

            LoadDaftarEmailSent()


        Else

            If strErrorMail = "" Then
                strErrorMail = "Failed"
            Else
                strErrorMail = strErrorMail
            End If

            Call KoneksiDatabaseEmail()
            Koneksi2.Close()



            Dim sqlComm2 As New SqlCommand

            sqlComm2.Connection = Koneksi2

            sqlComm2.CommandText = "[AU_ManualDiscountEmail]"
            sqlComm2.CommandType = CommandType.StoredProcedure

            sqlComm2.Parameters.AddWithValue("Type", "Outgoing Payments")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", "Failed")
            sqlComm2.Parameters.AddWithValue("Tanggal", dtTglDokumen)
            sqlComm2.Parameters.AddWithValue("Email", Trim(txtPenerima.Text))
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

            sqlComm2.Parameters.AddWithValue("Type", "Outgoing Payments")
            sqlComm2.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
            sqlComm2.Parameters.AddWithValue("Status", "Resend & Success")
            sqlComm2.Parameters.AddWithValue("Tanggal", dtTglDokumen)
            sqlComm2.Parameters.AddWithValue("Email", Trim(txtPenerima.Text))
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
            sqlComm2.Parameters.AddWithValue("Tanggal", dtTglDokumen)
            sqlComm2.Parameters.AddWithValue("Email", Trim(txtPenerima.Text))
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

    Sub LoopGridOutgoingPayments()

        For i As Integer = 0 To dgDaftarManualDiscount.Rows.Count - 1
            txtNoDokumen.Text = dgDaftarManualDiscount.Rows(i).Cells("DocEntry").Value
            txtPenerima.Text = dgDaftarManualDiscount.Rows(i).Cells("E_MailL").Value
            dtTglDokumen = dgDaftarManualDiscount.Rows(i).Cells("DocDate").Value


            rptDoc = New Outgoing_Payment2


            Dim cmd As SqlCommand

            cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
            cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

            rptDoc.Close()
            rptDoc.Dispose()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()

        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarOutgoingPayments()

        If dgFailed.RowCount = 0 Then
            NextExecution()
            Exit Sub

        Else

            For i As Integer = 0 To dgFailed.Rows.Count - 1
                txtNoDokumen.Text = dgFailed.Rows(i).Cells("Code").Value
                txtPenerima.Text = strPenerima

                rptDoc = New Outgoing_Payment2


                Dim cmd As SqlCommand

                cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
                cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

                rptDoc.Close()
                rptDoc.Dispose()

                LoadDaftarEmailSent()
                LoadDaftarFailtoSend()

            Next

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            NextExecution()
            LoadDaftarOutgoingPayments()

        End If




    End Sub

    Sub LoopGridManualFilter()

        For i As Integer = 0 To dgDaftarManualDiscount.Rows.Count - 1
            txtNoDokumen.Text = dgDaftarManualDiscount.Rows(i).Cells("DocEntry").Value
            txtPenerima.Text = dgDaftarManualDiscount.Rows(i).Cells("E_MailL").Value
            dtTglDokumen = dgDaftarManualDiscount.Rows(i).Cells("DocDate").Value


            rptDoc = New Outgoing_Payment2


            Dim cmd As SqlCommand

            cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
            cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

            rptDoc.Close()
            rptDoc.Dispose()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()


        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarOutgoingPaymentsCustomFilter()

        If dgFailed.RowCount = 0 Then
            NextExecution()
            Exit Sub

        Else

            For i As Integer = 0 To dgFailed.Rows.Count - 1
                txtNoDokumen.Text = dgFailed.Rows(i).Cells("code").Value
                txtPenerima.Text = strPenerima

                rptDoc = New Outgoing_Payment2


                Dim cmd As SqlCommand

                cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
                cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

                rptDoc.Close()
                rptDoc.Dispose()

                LoadDaftarEmailSent()
                LoadDaftarFailtoSend()


            Next

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            NextExecution()
            LoadDaftarOutgoingPaymentsCustomFilter()

        End If


    End Sub

    Private Sub BehaviourAndConfigurationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BehaviourAndConfigurationsToolStripMenuItem.Click
        frmKonfigurasiAplikasi.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If intTimer = 0 Then

            Timer1.Stop()
            Timer1.Enabled = False
            lblAwal.Visible = False
            lblTime.Visible = False
            LoopGridOutgoingPayments()

        Else

            intTimer -= 1
            lblCounter.Text = intTimer

        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
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
            Call LoadDaftarOutgoingPayments()
            Call LoopGridOutgoingPayments()
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

    Private Sub cmdShow_Click_1(sender As Object, e As EventArgs) Handles cmdShow.Click
        LoadDaftarOutgoingPaymentsCustomFilter()
        lblStrip1.Text = "Jumlah Record Untuk DiProses : " & dgDaftarManualDiscount.RowCount
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        lblAwal.Visible = False
        lblCounter.Visible = False
        NextExecution()
    End Sub

    Private Sub cmdPaused_Click(sender As Object, e As EventArgs) Handles cmdPaused.Click
        Timer2.Enabled = False
    End Sub

    Private Sub cmdManualStart_Click(sender As Object, e As EventArgs) Handles cmdManualStart.Click

        Timer2.Enabled = False

        LoopGridManualFilter()
        LoadDaftarFailtoSend()
        lblStrip1.Text = "Jumlah Record Untuk DiProses : " & dgDaftarManualDiscount.RowCount
        NextExecution()

    End Sub

    Private Sub cmdRetry_Click(sender As Object, e As EventArgs) Handles cmdRetry.Click
        LoopGridRetryALLFailed()
    End Sub

    Sub LoopGridRetryALLFailed()

        For i As Integer = 0 To dgFailed.Rows.Count - 1
            txtNoDokumen.Text = dgFailed.Item(5, dgFailed.CurrentRow.Index).Value
            txtPenerima.Text = dgFailed.Item(4, dgFailed.CurrentRow.Index).Value
            dtTglDokumen = dgFailed.Item(3, dgFailed.CurrentRow.Index).Value
            rptDoc = New Outgoing_Payment2


            Dim cmd As SqlCommand

            cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
            cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

            rptDoc.Close()
            rptDoc.Dispose()

            LoadDaftarEmailSent()
            LoadDaftarFailtoSend()
            LoadDaftarFailtoSendCustomParameter()

        Next
        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarFailtoSendCustomParameter()

    End Sub

    Private Sub cmdRetryOne_Click(sender As Object, e As EventArgs) Handles cmdRetryOne.Click



        If dgFailed.RowCount = 0 Then Exit Sub
        txtNoDokumen.Text = dgFailed.Item(5, dgFailed.CurrentRow.Index).Value
        txtPenerima.Text = dgFailed.Item(4, dgFailed.CurrentRow.Index).Value
        dtTglDokumen = dgFailed.Item(3, dgFailed.CurrentRow.Index).Value
        rptDoc = New Outgoing_Payment2


        Dim cmd As SqlCommand

        cmd = New SqlCommand("Lap_Form_Outgoing_Vendor", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@dockey", Trim(txtNoDokumen.Text)))
        cmd.Parameters.Add(New SqlParameter("@usercode", "manager"))


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

        rptDoc.Close()
        rptDoc.Dispose()

        LoadDaftarEmailSent()
        LoadDaftarFailtoSend()
        LoadDaftarFailtoSendCustomParameter()



    End Sub


    Sub LoadDaftarFailtoSendCustomParameter()

        KoneksiDatabaseEmail()

        lblJumlahRecordgagal.Text = "Jumlah Record Gagal Terkirim : " & dgFailed.RowCount

        Dim cmd2 As New SqlCommand("SELECT ErrorMessage,type,status,tanggal,email,code FROM dbo.Resend_mail WHERE type='Outgoing Payments' AND TanggalKirim Between '" & Format(dtpAwalFailed.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpAkhirFailed.Value, "yyyy-MM-dd") & "' ", Koneksi2)
        Dim adapter2 As New SqlDataAdapter(cmd2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)


        dgFailed.DataSource = table2
        dgFailed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailed.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailed.AutoResizeColumns()
        Koneksi2.Close()


    End Sub




    Private Sub cmdShowData_Click(sender As Object, e As EventArgs) Handles cmdShowData.Click
        LoadDaftarFailtoSendCustomParameter()
    End Sub
End Class
