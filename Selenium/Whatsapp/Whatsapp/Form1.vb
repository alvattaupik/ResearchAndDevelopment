Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

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

        Else
            TimerMsg1.Enabled = False
            TimerMsg2.Enabled = False
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
            TimerMsg1.Interval = 500
            TimerMsg2.Enabled = True
            TimerMsg2.Interval = 1000
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



    Sub LoadDaftarSendWhatsapp()
        KoneksiDatabase()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspSendWhatsappDelivery", Koneksi)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Now().ToString("yyyyMMdd"))


        Dim table As New DataTable
        adapter.Fill(table)

        dgPenerima.DataSource = table
        dgPenerima.RowHeadersVisible = False


    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadPesan()
        LoadDaftarSendWhatsapp()
    End Sub





    Private Sub AddToList()
        List.Clear()

        For i As Integer = 0 To dgPenerima.Rows.Count - 1
            List.Add(dgPenerima.Rows(i).Cells("NoTelepon").Value)
        Next


        For i As Integer = 0 To dgPenerima.Rows.Count - 1
            List.Add(dgPenerima.Rows(i).Cells("CustomMessage").Value)
        Next


    End Sub



    Private Sub Broadcast()


        For i As Integer = 0 To dgPenerima.Rows.Count - 1


            Try

                Dim Url As String = "https://web.whatsapp.com/send?phone=" & dgPenerima.Rows(i).Cells("NoHP").Value & "&text=" & dgPenerima.Rows(i).Cells("Pesan").Value & "&source&data&app_absent"
                Driver.Navigate().GoToUrl(Url)
                Threading.Thread.Sleep(11000)
                Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                Threading.Thread.Sleep(3000)


                Call KoneksiDBEmail()
                Dim str As String
                str = "INSERT INTO dbo.DeliverySudahDikirim VALUES  ('" & dgPenerima.Rows(i).Cells("Docnum").Value & "','" & dgPenerima.Rows(i).Cells("NoStruk").Value & "','" & dgPenerima.Rows(i).Cells("CardCode").Value & "','" & Now.ToString("yyyyMMdd HH:mm") & "')"
                cmd = New SqlCommand(str, Koneksi)
                cmd.ExecuteNonQuery()
                Threading.Thread.Sleep(1000)


            Catch ex As Exception

                GoTo trynext
                Threading.Thread.Sleep(2000)
            End Try
trynext:


        Next



    End Sub



    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click
        Broadcast()
    End Sub






    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LoadDaftarSendWhatsapp()
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Driver.Quit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormSetting.ShowDialog()
    End Sub


    Sub LoadDurasi()

        If My.Settings.DurasiInterval = "" Or My.Settings.SatuanInterval = "" Then
            MsgBox("Setting Interval Belum Di Isi", vbCritical, "Tidak Dapat Memulai Apps")
            FormSetting.ShowDialog()
            Exit Sub
        End If

        FnTimerNotifikasi(My.Settings.DurasiInterval, My.Settings.SatuanInterval)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoadDaftarSendWhatsapp()
        LoadDurasi()

    End Sub



    Private Sub TimerMsg1_Tick(sender As Object, e As EventArgs) Handles TimerMsg1.Tick
        LongDurasi = LongDurasi - 1

        lblTimer.Text = LongDurasi.ToString

        If lblTimer.Text = "0" Then
            TimerMsg1.Stop()
            LoadDaftarSendWhatsapp()

            Threading.Thread.Sleep(1000)

            Broadcast()

            Threading.Thread.Sleep(2000)

            LoadDurasi()
            TimerMsg1.Start()
        End If

    End Sub

End Class
