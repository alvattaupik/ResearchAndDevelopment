Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SalesMonitoringNew





    Private Sub SalesMonitoringNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadChart()

    End Sub


    Sub LoadChart()

        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)


        Dim rng As New Random




        For Each row As DataRow In Tabel1.Rows


            ChartPenjualan.Series("Series1").Points.AddXY(row("NamaCabang").ToString, row("Total"))


            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.Interval = 1
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.LightGray
            ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.LightGray
            ChartPenjualan.Series("Series1").IsValueShownAsLabel = True


         

        Next row

        ChartPenjualan.Titles.Add("TURN OVER PENJUALAN")



        ChartPenjualan.Series("Series1").Points(0).Color = Color.Red
        ChartPenjualan.Series("Series1").Points(1).Color = Color.Blue
        ChartPenjualan.Series("Series1").Points(2).Color = Color.Green
        ChartPenjualan.Series("Series1").Points(3).Color = Color.Gray
        ChartPenjualan.Series("Series1").Points(4).Color = Color.Yellow
        ChartPenjualan.Series("Series1").Points(5).Color = Color.Purple
        ChartPenjualan.Series("Series1").Points(6).Color = Color.RoyalBlue
        ChartPenjualan.Series("Series1").Points(7).Color = Color.Salmon
        ChartPenjualan.Series("Series1").Points(8).Color = Color.HotPink
        ChartPenjualan.Series("Series1").Points(9).Color = Color.CadetBlue
        ChartPenjualan.Series("Series1").Points(10).Color = Color.Lavender
        ChartPenjualan.Series("Series1").Points(11).Color = Color.Indigo
        ChartPenjualan.Series("Series1").Points(12).Color = Color.Linen


 



    End Sub



    Sub LoadStaticGraphic()



        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)






        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)

        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        'Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(24, 130)
        Chart1.Name = "STORE TURN OVER"
        Series1.ChartArea = "ChartArea1"
        'Series1.Legend = "Legend1"
        'Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New System.Drawing.Size(1150, 300)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"

        Chart1.Series("Series1").XValueMember = "NamaCabang"
        Chart1.Series("Series1").YValueMembers = "Total"






        'Dim rng As New Random

        'For p As Integer = 1 To 13
        '    Dim thisPoint As DataVisualization.Charting.DataPoint
        '    thisPoint = Chart1.Series("Series1").Points.Add(rng.Next(5) + 5)

        '    Dim someRandomColour As Color = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256))
        '    thisPoint.Color = someRandomColour

        'Next





        Chart1.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = True
        Chart1.ChartAreas("ChartArea1").AxisX.Interval = 1
        Chart1.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
        Chart1.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont





        Chart1.DataSource = Tabel1


    End Sub


    Sub LoadStaticGraphicCustomDate()


        ChartPenjualan.Series("Series1").Points.Clear()
        ChartPenjualan.Titles.Clear()



        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(DateTimePicker1.Value, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(DateTimePicker2.Value, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)


        Dim rng As New Random


        For Each row As DataRow In Tabel1.Rows

            ChartPenjualan.Series("Series1").Points.AddXY(row("NamaCabang").ToString, row("Total"))

            ChartPenjualan.ChartAreas("ChartArea1").AxisY.ScaleBreakStyle.LineWidth = 10

            ChartPenjualan.ChartAreas("ChartArea1").AxisX.ScaleBreakStyle.LineWidth = 10
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.Interval = 1
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
            ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.LightGray
            ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.LightGray
            ChartPenjualan.Series("Series1").IsValueShownAsLabel = True



        Next row

        ChartPenjualan.Titles.Add("TURN OVER PENJUALAN")



        ChartPenjualan.Series("Series1").Points(0).Color = Color.Red
        ChartPenjualan.Series("Series1").Points(1).Color = Color.Blue
        ChartPenjualan.Series("Series1").Points(2).Color = Color.Green
        ChartPenjualan.Series("Series1").Points(3).Color = Color.Gray
        ChartPenjualan.Series("Series1").Points(4).Color = Color.Yellow
        ChartPenjualan.Series("Series1").Points(5).Color = Color.Purple
        ChartPenjualan.Series("Series1").Points(6).Color = Color.RoyalBlue
        ChartPenjualan.Series("Series1").Points(7).Color = Color.Salmon
        ChartPenjualan.Series("Series1").Points(8).Color = Color.HotPink
        ChartPenjualan.Series("Series1").Points(9).Color = Color.CadetBlue
        ChartPenjualan.Series("Series1").Points(10).Color = Color.Lavender
        ChartPenjualan.Series("Series1").Points(11).Color = Color.Indigo
        ChartPenjualan.Series("Series1").Points(12).Color = Color.Linen



    End Sub




    Private Sub cmdTampilkanGrafik_Click(sender As Object, e As EventArgs) Handles cmdTampilkanGrafik.Click
        LoadStaticGraphicCustomDate()
    End Sub
End Class