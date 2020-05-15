Imports System.IO
Imports System.Net.Sockets
Public Class FormMonitoringClient
    Dim Rand As New Random
    Dim Counter As Double = 1
    Dim IsiCounterNew As Double
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim isiCounter As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If











        ''setup the chart area
        'Chart1.Titles.Add("Line of x^2") ' specify chart name
        'Chart1.ChartAreas.Clear()
        'Chart1.ChartAreas.Add("Default")

        'With Chart1.ChartAreas("Default")
        '    .AxisX.Title = "X" ' x label
        '    .AxisX.MajorGrid.LineColor = Color.SkyBlue
        '    .AxisY.MajorGrid.LineColor = Color.SkyBlue
        '    .AxisY.Title = "Y" 'y label
        'End With

        ''specify series plot lines 
        'Chart1.Series.Clear()
        'Chart1.Series.Add("plot1")
        'Chart1.Series("plot1").Color = Color.Red
        'Chart1.Series("plot1").ChartType = DataVisualization.Charting.SeriesChartType.Line


        'Dim n As Integer = 5 ' number of points

        'Dim y As Single
        'For x As Integer = 1 To n Step 1
        '    y = x * x
        '    Chart1.Series("plot1").Points.AddXY(x, y)
        'Next
    End Sub


    Private Sub FormMonitoringClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.Minimum = 0
        Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 90
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisX.ScaleView.Size = 5
        Chart1.ChartAreas(0).AxisX.ScrollBar.Size = 5
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(0).IsVisibleInLegend = False
        Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = False

        'Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisY.MajorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisX.MinorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisY.MinorTickMark.Enabled = False


        Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
        Chart1.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
        Chart1.ChartAreas(0).AxisX.ScrollBar.BackColor = Color.LightGray
        Chart1.ChartAreas(0).AxisX.ScrollBar.ButtonColor = Color.Gray
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick




        Chart1.Series(0).Points.AddXY(IsiCounterNew, CDbl(Rand.Next(0, 1)))
        Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Counter - 1, Counter + 1, Now.ToString("HH:mm:ss"))
        Counter += 1
        If Chart1.ChartAreas(0).AxisX.Maximum > Chart1.ChartAreas(0).AxisX.ScaleView.Size Then
            Chart1.ChartAreas(0).AxisX.ScaleView.Scroll(Chart1.ChartAreas(0).AxisX.Maximum)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If


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
                RichTextBox1.Text += "Disconnected" + vbNewLine
            End Try
        End If
        Return True
    End Function


    Function MSG1(ByVal Data As String)
        REM Creates a messageBox for new threads to stop freezing
        MsgBox(Data)
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class