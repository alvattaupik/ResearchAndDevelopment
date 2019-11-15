Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SalesMonitoringNew2

    Private Sub SalesMonitoringNew2_Load(sender As Object, e As EventArgs) Handles Me.Load

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




        'For Each row As DataRow In Tabel1.Rows


        'ChartPenjualan.Series("Series1").Points.AddXY(row("NamaCabang").ToString, row("Total"))





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




        'Next row

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


End Class