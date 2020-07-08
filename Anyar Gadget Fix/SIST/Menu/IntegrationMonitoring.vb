Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets
Public Class IntegrationMonitoring


    Dim Rand As New Random
    Dim Counter As Double = 1
    Dim IsiCounterNew As Double
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim isiCounter As Integer


    Function MSG1(ByVal Data As String)
        REM Creates a messageBox for new threads to stop freezing
        MsgBox(Data)
        Return True
    End Function


    Function Connected()
        REM Has connected to server and now listening for data from the server
        If RX.BaseStream.CanRead = True Then
            Try
                While RX.BaseStream.CanRead = True
                    Dim RawData As String = RX.ReadLine
                    If RawData.ToUpper = "/MSG" Then
                        Threading.ThreadPool.QueueUserWorkItem(AddressOf MSG1, "Hello World.")
                    Else
                        'RichTextBox1.Text += "Server>>" + RawData + vbNewLine
                        IsiCounterNew = RawData
                    End If
                End While
            Catch ex As Exception
                Client.Close()

            End Try
        End If
        Return True
    End Function







    Sub GetStream()
        REM Connect Button
        Try
            REM IP, Port
            REM If port is in a textbox, use: integer.parse(textbox1.text)  instead of the port number vvv
            Client = New TcpClient(MstrServerBroadCast, 4305)
            If Client.GetStream.CanRead = True Then
                RX = New StreamReader(Client.GetStream)
                TX = New StreamWriter(Client.GetStream)
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
            End If
        Catch ex As Exception
            txtNotif.Text += "Failed to connect, E: " + ex.Message + vbNewLine
            Timer2.Stop()
        End Try
    End Sub


 






    Private Angle As Integer


    Structure DataPointType
        Public x As Double
        Public y As Double

    End Structure


    Private ChartDataList As New List(Of DataPointType)


    Private Sub IntegrationMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadControl()


        'setup the chart
        'Chart1.Titles.Add("Sin Wave Example")
        'Chart1.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)

        With Chart1.ChartAreas(0)
            .AxisX.Title = "Waktu (s)"
            .AxisX.MajorGrid.Enabled = False
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisX.Interval = 5
            .AxisX.IsLabelAutoFit = False
            .AxisX.LabelStyle.Font = New Font("Arial", 10, FontStyle.Regular)
            .AxisX.LabelStyle.Angle = -90
            .AxisX.LabelStyle.IsStaggered = False
            .AxisX.LabelStyle.Enabled = False

            .AxisY.Title = "Jumlah Proses (s)"
            .AxisY.MajorGrid.LineColor = Color.LightGray
            .AxisY.IsInterlaced = True
            .AxisY.InterlacedColor = Color.FloralWhite

            .BackColor = Color.FloralWhite
            .BackSecondaryColor = Color.White
            .BackGradientStyle = GradientStyle.HorizontalCenter
            .BorderColor = Color.Blue
            .BorderDashStyle = ChartDashStyle.Solid
            .BorderWidth = 1
            .ShadowOffset = 2
        End With


    End Sub


    Private Sub IntegrationMonitoring_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub
    Private Sub IntegrationMonitoring_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub


    Sub LoadFailedIntegration()
        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("Select * from V_MonitoringIntegrasi Where SUBSTRING(NoStruk,4,3) ='" & MstrKodeDivisi & "'", KoneksiIvend)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgFailedIntegration.DataSource = table
        dgFailedIntegration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailedIntegration.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailedIntegration.AutoResizeColumns()
    End Sub

    Sub LoadFailedIntegrationAll()
        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("Select * from V_MonitoringIntegrasi", KoneksiIvend)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgFailedIntegration.DataSource = table
        dgFailedIntegration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgFailedIntegration.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgFailedIntegration.AutoResizeColumns()
    End Sub



    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        If chkTampilAll.Checked = True Then
            LoadFailedIntegrationAll()
            lblJumlahErrorIntegrasi.Text = "Jumlah Error Integrasi : " & dgFailedIntegration.RowCount
        Else
            LoadFailedIntegration()
            lblJumlahErrorIntegrasi.Text = "Jumlah Error Integrasi : " & dgFailedIntegration.RowCount
        End If
    End Sub


    Sub LoadControl()
        Call KoneksiDatabase1()

        strSQL = "Select top 1 StatusEnabled From V_ObjectUserAnyarGadget WHERE KodeObject='CHK002' AND KodePegawai ='" & Trim(MstrKodeUser) & "'"
        cmd = New SqlCommand(strSQL, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            dr.GetString(0)

            If dr.GetString(0) = "1" Then
                chkTampilAll.Visible = True
            Else
                chkTampilAll.Visible = False
            End If

            dr.Close()
        Else
            chkTampilAll.Visible = False
            dr.Close()
        End If


    End Sub






    Private Sub dgFailedIntegration_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFailedIntegration.CellContentDoubleClick

        If dgFailedIntegration.RowCount = 0 Then Exit Sub

        DetailFailedItegration.txtIntegrationKey.Text = dgFailedIntegration.Item(2, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtIntegrationKey.ReadOnly = True
        DetailFailedItegration.txtNoStruk.Text = dgFailedIntegration.Item(3, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtNoStruk.ReadOnly = True
        DetailFailedItegration.txtKodeCust.Text = dgFailedIntegration.Item(5, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtKodeCust.ReadOnly = True
        DetailFailedItegration.txtNamaCust.Text = dgFailedIntegration.Item(6, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtCabang.Text = dgFailedIntegration.Item(4, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtNotifError.Text = dgFailedIntegration.Item(7, dgFailedIntegration.CurrentRow.Index).Value
        DetailFailedItegration.txtNotifError.ReadOnly = True

        MstrNoStruk = dgFailedIntegration.Item(3, dgFailedIntegration.CurrentRow.Index).Value


        DetailFailedItegration.ShowDialog()

    End Sub

    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click


        If txtNoStruk.Text = "" Then
            MsgBox("Masukan Nomor Struk Yang Akan Di Cek", vbInformation, "Informasi")
            Exit Sub
        End If



        txtNoDokumenDisplay.Text = ""
        txtNoDokumenDisplay.BackColor = Color.White
        txtIntegrasiSAPDisplay.Text = ""
        txtIntegrasiSAPDisplay.BackColor = Color.White


        dgItemFullfillment.DataSource = Nothing
        dgItemFullfillment.Rows.Clear()
        dgItemFullfillment.Columns.Clear()

        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("Select * from V_CekFullfilments Where NoStruk ='" & Trim(txtNoStruk.Text) & "'", KoneksiIvend)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        lblJumlahItem.Text = "Jumlah Item : " & table.Rows.Count


        dgItemFullfillment.Columns.Add("KodeBarang", "KodeBarang")
        dgItemFullfillment.Columns.Add("NamaBarang", "NamaBarang")
        dgItemFullfillment.Columns.Add("Qty", "Qty")
        dgItemFullfillment.Columns.Add("Keterangan", "Keterangan")


        With table
            For i = 0 To table.Rows.Count - 1
                dgItemFullfillment.Rows.Add(.Rows(i).Item(4).ToString(), .Rows(i).Item(5).ToString(), .Rows(i).Item(6).ToString(), .Rows(i).Item(3).ToString())

                txtAlamatDisplay.Text = .Rows(i).Item(7).ToString()
                txtKdCustomerDisplay.Text = .Rows(i).Item(1).ToString()
                txtNamaCustomerDisplay.Text = .Rows(i).Item(2).ToString()

            Next

        End With


        dgItemFullfillment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgItemFullfillment.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgItemFullfillment.AutoResizeColumns()
        dgItemFullfillment.RowHeadersVisible = False
        loadStatusIntegrasiSAP()


      
    End Sub


    Sub loadStatusIntegrasiSAP()
        KoneksiDatabase2()
        strSQlLogin = "SELECT top 1 Cast(DocNum as varchar(100)) FROM dbo.OINV WHERE U_CXS_TRID='" & Trim(txtNoStruk.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi2)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtIntegrasiSAPDisplay.Text = "Sudah Terintegrasi !"
            txtIntegrasiSAPDisplay.BackColor = Color.Green
            txtNoDokumenDisplay.Text = dr.GetString(0)
            Exit Sub
        Else
            txtIntegrasiSAPDisplay.Text = "Belum Terintegrasi !"
            txtIntegrasiSAPDisplay.BackColor = Color.Yellow
        End If


    End Sub




    Private Sub GunaCirclePictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.DoubleClick
        FormSettingMonitoringDatabase.ShowDialog()
    End Sub


    Sub StartMonitoring()

        Try

            KoneksiMonitoringDatabase()
            Dim cmd As New SqlCommand("SELECT session_id AS Sesi,[Blk by] AS BlockedBy,host_name AS NamaClient,cpu_time,status AS StatusSesi,wait_type AS WaitType,program_name AS NamaProgram ," & _
            " [Wait M] AS DurasiTunggu,command_text AS Query," & _
            " wait_resource ," & _
            " logical_reads,reads,writes From dbo.V_MonitoringTraffic ORDER BY cpu_time DESC ", Koneksi2)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgMonitoringDatabase.DataSource = table
            'aturDGSAP()
            dgMonitoringDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgMonitoringDatabase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgMonitoringDatabase.AutoResizeColumns()
            Koneksi2.Close()
            lblBebanKerja.Text = "Antrian Proses : " & dgMonitoringDatabase.RowCount & " Proses"

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
            Timer1.Stop()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Enabled = True
            Call StartMonitoring()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
            Timer1.Dispose()
            Timer1.Enabled = False
        End Try
    End Sub

    Private Sub cmdStopMonitoring_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
    End Sub

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        Timer2.Start()
    End Sub

    Private Sub GetDataPoint()
        'remove a point
        If ChartDataList.Count > 17 Then
            ChartDataList.Remove(ChartDataList(0))
        End If

        'add next point
        Dim thisDataPoint As DataPointType
        thisDataPoint.x = Angle
        thisDataPoint.y = IsiCounterNew 'BebanKerja
        'Label1.Text = thisDataPoint.x
        lblProsesAntrian.Text = thisDataPoint.y & "  Antrian"

        ChartDataList.Add(thisDataPoint)

        Angle += 1

    End Sub





    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        GetDataPoint()
        GetStream()
        'draw the chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Line Type")
        Chart1.Series(0).IsVisibleInLegend = False
        Chart1.Series(0).Color = Color.Red
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line

        Chart1.ChartAreas(0).AxisX.Minimum = ChartDataList(0).x
        Chart1.ChartAreas(0).AxisX.Maximum = Chart1.ChartAreas(0).AxisX.Minimum + 360

        For i = 0 To ChartDataList.Count - 1
            Chart1.Series(0).Points.AddXY(ChartDataList(i).x, ChartDataList(i).y)
        Next
    End Sub

    Private Sub cmbStartMonitoring_Click_1(sender As Object, e As EventArgs) Handles cmbStartMonitoring.Click


        If My.Settings.ServerNameDB = "" Then
            MsgBox("Konfigurasi Database Belum Diatur" & vbCrLf & " Hubungi IT untuk Aktivasi!", vbInformation, "Informasi !")
            FormSettingMonitoringDatabase.ShowDialog()
            Exit Sub
        End If

        lblDatabase.Text = My.Settings.DatabaseName
        Timer1.Enabled = True

    End Sub

    Private Sub cmdStopMonitoring_Click_1(sender As Object, e As EventArgs) Handles cmdStopMonitoring.Click
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KoneksiDatabaseIvend()
        Dim command As SqlCommand
        command = New SqlCommand("ReplicationMonitor", KoneksiIvend)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@pDestinationSiteID", MstrSiteID)
        command.Parameters.AddWithValue("@pOutRecordCount", 0)
        'cmd.Parameters.Add("@pOutRecordCount", SqlDbType.Int)
        'cmd.Parameters("@pOutRecordCount").Direction = ParameterDirection.Output

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgMonitoringReplikasi.DataSource = table
        dgMonitoringReplikasi.DataSource = table
        dgMonitoringReplikasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgMonitoringReplikasi.AutoResizeColumns()
        dgMonitoringReplikasi.RowHeadersVisible = False
        lblJumlahReplikasi.Text = "Data Untuk Dikirim Ke Ivend Pusat : " & dgMonitoringReplikasi.RowCount

    End Sub
End Class