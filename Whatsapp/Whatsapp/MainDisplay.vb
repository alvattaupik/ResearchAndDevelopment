Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class MainDisplay

    Dim Driver As IWebDriver
    Dim List As New List(Of String)()
    Dim i As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If My.Settings.Server = "" Then
            MsgBox("Konfigurasi Server Belum Diatur", vbCritical, "Error !")
            FormSetting.ShowDialog()
            Exit Sub
        End If


        LoadDurasi()

        If btnStart.Text = "Start" Then

            Driver = New ChromeDriver
            Driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            btnStart.Text = "Stop"
            TimerLogin.Enabled = True
            TimerLogin.Interval = 1000
            btnKirim.PerformClick()


        Else
            TimerMsg1.Enabled = False

            'Driver.Quit()
            btnStart.Text = "Start"


        End If

    End Sub


    Private Function CekApakahSudahLogin() As Boolean
        Try

            Driver.FindElements(By.ClassName(" _2BPp"))
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function

    Private Sub TimerLogin_Tick(sender As Object, e As EventArgs) Handles TimerLogin.Tick

        If CekApakahSudahLogin() = True Then
            TimerLogin.Enabled = False
            TimerMsg1.Enabled = True
            TimerMsg1.Interval = 1000
         
        End If

    End Sub





    Sub LoadPesan()
        KoneksiDatabase()
        Dim cmd As New SqlCommand("SELECT NoTelepon,CustomMessage FROM kontakWhatsapp", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgPenerima.DataSource = table
        dgPenerima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgPenerima.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPenerima.AutoResizeColumns()
        Koneksi.Close()


    End Sub



    Sub LoadDaftarPenerimaPesanTransaksiBerhasil()
        Try
            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("_tmspSendPesanWhatsapp", Koneksi)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            Dim table As New DataTable
            adapter.Fill(table)
            dgPenerima.DataSource = table
            dgPenerima.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Exit Sub
        End Try

    End Sub



    Sub LoadDaftarPenerimaPesanWA()
        Try
            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("_tmspSendPesanWhatsapp", Koneksi)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            Dim table As New DataTable
            adapter.Fill(table)
            dgPenerima.DataSource = table
            dgPenerima.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Exit Sub
        End Try

    End Sub


    Sub LoadNotifikasiBackup()
        Try
            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("_tmspSendNotifikasiBackup", Koneksi)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            Dim table As New DataTable
            adapter.Fill(table)
            dgPenerima.DataSource = table
            dgPenerima.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Exit Sub
        End Try

    End Sub


    Sub LoadNotifikasiIntegrasi()
        Try
            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("_tmsp_Omset_Harian_UnpivotNotifikasi", Koneksi)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            Dim table As New DataTable
            adapter.Fill(table)
            dgPenerima.DataSource = table
            dgPenerima.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Exit Sub
        End Try

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDurasi()
        GetSettingBehaviour()
        TimerDateTime.Enabled = True
        lblWorkingHour.Text = MstrWorkingHourValue1 & " - " & MstrWorkingHourValue2
        tanggal()
        LoadDaftarPenerimaPesanWA()
    End Sub





    Private Sub Broadcast()
        LoadDaftarPenerimaPesanWA()

        If dgPenerima.Rows.Count = 0 Then Exit Sub

        For i As Integer = 0 To dgPenerima.Rows.Count - 1


            Try

                Dim Url As String = "https://web.whatsapp.com/send?phone=" & dgPenerima.Rows(i).Cells("Kontak").Value & "&text=" & dgPenerima.Rows(i).Cells("Pesan").Value & "&source&data&app_absent"
                Driver.Navigate().GoToUrl(Url)
                Threading.Thread.Sleep(11000)
                Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                Threading.Thread.Sleep(3000)


                Call SendStatusWA("A", "Sukses")

            Catch ex As Exception

                Call SendStatusWA("A", "Gagal")
                GoTo trynext
                Threading.Thread.Sleep(2000)
            End Try
trynext:


        Next



    End Sub




    Private Sub SendNotifikasiBackup()
        LoadNotifikasiBackup()

        If dgPenerima.Rows.Count = 0 Then Exit Sub

        For i As Integer = 0 To dgPenerima.Rows.Count - 1


            Try

                Dim Url As String = "https://web.whatsapp.com/send?phone=" & dgPenerima.Rows(i).Cells("Kontak").Value & "&text=" & dgPenerima.Rows(i).Cells("Pesan").Value & "&source&data&app_absent"
                Driver.Navigate().GoToUrl(Url)
                Threading.Thread.Sleep(11000)
                Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                Threading.Thread.Sleep(3000)


                Call SendStatusWA("A", "Sukses")

            Catch ex As Exception

                Call SendStatusWA("A", "Gagal")
                GoTo trynext
                Threading.Thread.Sleep(2000)
            End Try
trynext:


        Next

        Threading.Thread.Sleep(5000)
        TimerMsg1.Start()
        LoadNotifikasiBackup()

    End Sub


    Private Sub SendIntegrationNotification()
        LoadNotifikasiIntegrasi()

        If dgPenerima.Rows.Count = 0 Then Exit Sub

        For i As Integer = 0 To dgPenerima.Rows.Count - 1


            Try

                Dim Url As String = "https://web.whatsapp.com/send?phone=" & dgPenerima.Rows(i).Cells("Kontak").Value & "&text=" & dgPenerima.Rows(i).Cells("Pesan").Value & "&source&data&app_absent"
                Driver.Navigate().GoToUrl(Url)
                Threading.Thread.Sleep(11000)
                Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                Threading.Thread.Sleep(3000)


                Call SendStatusWA("A", "Sukses")

            Catch ex As Exception

                Call SendStatusWA("A", "Gagal")
                GoTo trynext
                Threading.Thread.Sleep(2000)
            End Try
trynext:


        Next

        Threading.Thread.Sleep(5000)
        TimerMsg1.Start()
        LoadNotifikasiIntegrasi()


    End Sub





    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        LoadDaftarPenerimaPesanWA()
        Broadcast()
    End Sub



    Sub SendStatusWA(strStatusSP As String, strStatusPesan As String)
        Try
            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("AU_SendStatusWhatsapp", Koneksi)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@NoDocument", dgPenerima.Rows(i).Cells("DocNum").Value)
            command.Parameters.AddWithValue("@Tipe", dgPenerima.Rows(i).Cells("Tipe").Value)
            command.Parameters.AddWithValue("@Kontak", dgPenerima.Rows(i).Cells("Kontak").Value)
            command.Parameters.AddWithValue("@Pesan", dgPenerima.Rows(i).Cells("Pesan").Value)
            command.Parameters.AddWithValue("@StatusPesan", strStatusPesan)
            command.Parameters.AddWithValue("@StatusSP", strStatusSP)
            command.ExecuteNonQuery()


        Catch ex As Exception

            MsgBox(Err.Description)
            Exit Sub

        End Try

    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Driver.Quit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormSetting.ShowDialog()
    End Sub


    Sub tanggal()
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
        lblNamaHari.Text = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        lblTanggal.Text = Format(Now.ToString("dd-MMMM-yyyy"))
        lblWorkingHour.Text = MstrWorkingHourValue1 & " - " & MstrWorkingHourValue2
    End Sub


    Sub LoadDurasi()

        If My.Settings.DurasiInterval = "" Or My.Settings.SatuanInterval = "" Then
            MsgBox("Setting Interval Belum Di Isi", vbCritical, "Tidak Dapat Memulai Apps")
            FormSetting.ShowDialog()
            Exit Sub
        End If

        FnTimerNotifikasi(My.Settings.DurasiInterval, My.Settings.SatuanInterval)

        MstrDelay1 = My.Settings.Delay1
        MstrDelay2 = My.Settings.Delay2

    End Sub


    Private Sub TimerMsg1_Tick(sender As Object, e As EventArgs) Handles TimerMsg1.Tick
        LongDurasi = LongDurasi - 1
        lblTimer.Text = LongDurasi.ToString

        If lblTimer.Text = "0" Then
            TimerMsg1.Stop()
            LoadDaftarPenerimaPesanWA()
            Threading.Thread.Sleep(1000)

            Broadcast()

            Threading.Thread.Sleep(2000)

            LoadDurasi()
            TimerMsg1.Start()
        End If

    End Sub

    Private Sub cmdtest_Click(sender As Object, e As EventArgs)
        LoadDurasi()
        TimerMsg1.Enabled = True
    End Sub



    Private Sub TimerDateTime_Tick(sender As Object, e As EventArgs) Handles TimerDateTime.Tick
        lblJam.Text = TimeOfDay
        lblJam2.Text = TimeOfDay.ToString("HH:mm")



        ' Working Hour Aplikasi 
        If MstrWorkingHourValue2 = lblJam2.Text Then
            TimerMsg1.Enabled = False
            lblTimer.Text = "Paused"
        End If

        If MstrWorkingHourValue1 & ":03" = lblJam.Text Then
            LoadDurasi()
            TimerMsg1.Start()
        End If
        ' Working Hour Aplikasi 






        'Notifikasi Backup
        If MstrNotifikasiBackup = "Y" Then
            If MstrNotifikasiBackupValue1 & ":03" = lblJam.Text Then
                TimerMsg1.Stop()
                SendNotifikasiBackup()
            End If
        End If


        '    If MstrNotifikasiBackupValue2 & ":03" = lblJam.Text Then
        '        LoadDurasi()
        '        TimerMsg1.Start()
        '    End If
        'End If
        'Notifikasi Backup



        'Notifikasi Integrasi BI
        If MstrNotifikasiIntegrasiBI = "Y" Then
            If MstrNotifikasiIntegrasiBIValue1 & ":03" = lblJam.Text Then
                TimerMsg1.Stop()
                SendIntegrationNotification()
            End If

            'If MstrNotifikasiIntegrasiBIValue2 & ":03" = lblJam.Text Then
            '    LoadDurasi()
            '    TimerMsg1.Start()
            'End If
        End If
        'Notifikasi Integrasi BI



        'Notifikasi Custom1 
        If MstrCustomCommand1 = "Y" Then
            If MstrCustomCommand1Value1 & ":03" = lblJam.Text Then
                TimerMsg1.Stop()
                'Broadcast()
            End If

            'If MstrCustomCommand1Value2 & ":03" = lblJam.Text Then
            '    LoadDurasi()
            '    TimerMsg1.Start()
            'End If
        End If

        'Notifikasi Custom1 



        'Notifikasi Custom2
        If MstrCustomCommand2 = "Y" Then
            If MstrCustomCommand2Value1 & ":03" = lblJam.Text Then
                TimerMsg1.Stop()
                'Broadcast()
            End If

            'If MstrCustomCommand2Value2 & ":03" = lblJam.Text Then
            '    LoadDurasi()
            '    TimerMsg1.Start()
            'End If
        End If
        'Notifikasi Custom2


        'Notifikasi ResendDeliveryGagal
        If MstrResendDeliveryGagal = "Y" Then
            If MstrResendDeliveryGagalValue1 & ":03" = lblJam.Text Then
                TimerMsg1.Stop()
                'Broadcast()
            End If

            'If MstrResendDeliveryGagalValue2 & ":03" = lblJam.Text Then
            '    LoadDurasi()
            '    TimerMsg1.Start()
            'End If
        End If
        'Notifikasi ResendDeliveryGagal




    End Sub





    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        LoadDaftarPenerimaPesanWA()
        GetSettingBehaviour()
        lblWorkingHour.Text = MstrWorkingHourValue1 & " - " & MstrWorkingHourValue2
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LoadDaftarPenerimaPesanWA()
        GetSettingBehaviour()
        lblWorkingHour.Text = MstrWorkingHourValue1 & " - " & MstrWorkingHourValue2
    End Sub

    Private Sub WaBlastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaBlastToolStripMenuItem.Click
        MasterPesanWa.ShowDialog()
    End Sub
End Class
