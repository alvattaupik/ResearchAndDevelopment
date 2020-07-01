Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets
Public Class Formtest

    Dim Rand As New Random
    Dim Counter As Double = 1
    Dim IsiCounterNew As Double
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim isiCounter As Integer



    Private Angle As Integer


    Structure DataPointType
        Public x As Double
        Public y As Double

    End Structure


    Private ChartDataList As New List(Of DataPointType)
    Private Sub GetDataPoint()
        'remove a point
        If ChartDataList.Count > 17 Then
            ChartDataList.Remove(ChartDataList(0))
        End If

        'add next point
        Dim thisDataPoint As DataPointType
        thisDataPoint.x = Angle
        thisDataPoint.y = IsiCounterNew 'BebanKerja
        Label1.Text = thisDataPoint.x
        Label2.Text = thisDataPoint.y

        ChartDataList.Add(thisDataPoint)

        Angle += 1

    End Sub




    Private Sub Formtest_Load(sender As Object, e As EventArgs) Handles Me.Load
        'setup the chart
        Chart1.Titles.Add("Sin Wave Example")
        Chart1.Titles(0).Font = New Font("Arial", 10, FontStyle.Bold)

        With Chart1.ChartAreas(0)
            .AxisX.Title = "Waktu (s)"
            .AxisX.MajorGrid.Enabled = False
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisX.Interval = 5
            .AxisX.IsLabelAutoFit = False
            .AxisX.LabelStyle.Font = New Font("Arial", 10, FontStyle.Regular)
            .AxisX.LabelStyle.Angle = -90
            .AxisX.LabelStyle.IsStaggered = False
            .AxisX.LabelStyle.Enabled = True

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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
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
            Client = New TcpClient("10.1.0.55", 4305)
            If Client.GetStream.CanRead = True Then
                RX = New StreamReader(Client.GetStream)
                TX = New StreamWriter(Client.GetStream)
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Connected)
            End If
        Catch ex As Exception
            RichTextBox1.Text += "Failed to connect, E: " + ex.Message + vbNewLine
        End Try
    End Sub

End Class