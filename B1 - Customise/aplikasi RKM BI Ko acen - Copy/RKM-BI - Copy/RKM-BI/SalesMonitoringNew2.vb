Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

'Untuk Programmer selanjutnya, disini saya akan meninggalkan beberapa jejak
'Semoga bermanfaat untuk mempermudah dalam pengembangan selanjutnya.
'1.Dalam menggunakan object graphic tidak disarankan untuk melakukan hard design pada chart yang ada
'karena akan ada ketidaksinkronan graphic dalam render dan hard design yang ada, contoh bisa dilihat di form salesmonitoring.vb
'2. Ada beberapa Properti yang sangat bermanfaat disini, saya akan berikan comment pada tiap block kodingnya
'Salam @netizen



Public Class SalesMonitoringNew2

    Private Sub SalesMonitoringNew2_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")

        LoadChart()

    End Sub


    Sub LoadChart()
        Dim TotalALlFix As Integer
        Dim totalTemp As Integer


        ' Stored Procedure, bagaimana kita memanggil SP sebagai sumber data,
        ' Hasil dari SP tersebut akan kita tampung dalam data table,
        ' nah data tabel tersebut akan menjadi source untuk grafik kita.

        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi) ' Stored Procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable         ' Data tabel untuk menampung Data dari SP
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)




        ' Fungsi Untuk menghitung total semuanya

        If Tabel1.Rows.Count > 0 Then
            For i As Integer = 0 To Tabel1.Rows.Count - 1

                totalTemp = Tabel1.Rows(i).Item(1)

                TotalALlFix = TotalALlFix + totalTemp

            Next
        End If





        'Disini merupakan deklarasi Untuk Chart, pada nama yang berwarna merah
        'Merupakan Sumbu X , ini bisa di deklarasikan secara dinamis dengan Query Looping
        'Atau dideklarasikan secara statis dengan hardcode, pada bagian selanjutnya merupakan sumbu Y nya
        ' Disini sebagai value dari grafik yang dibuat

        ChartPenjualan.Series(0).Points.AddXY("ABM", FormatCurrency(Tabel1.Rows(0).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("AYANI", FormatCurrency(Tabel1.Rows(1).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("CBT", FormatCurrency(Tabel1.Rows(2).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("KOPO", FormatCurrency(Tabel1.Rows(3).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("CBR", FormatCurrency(Tabel1.Rows(4).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("GRT", FormatCurrency(Tabel1.Rows(5).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("CRBN", FormatCurrency(Tabel1.Rows(6).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("SMD", FormatCurrency(Tabel1.Rows(7).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("CPRY", FormatCurrency(Tabel1.Rows(8).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RCK", FormatCurrency(Tabel1.Rows(9).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("TSK", FormatCurrency(Tabel1.Rows(10).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("PMNK", FormatCurrency(Tabel1.Rows(11).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("SOETTA", FormatCurrency(Tabel1.Rows(12).Item(1)))



        'Bagian ini merupakan fungsi style, yang dilakukan dengan coding

        ChartPenjualan.Titles.Add("TURN OVER PENJUALAN").Font = New Font("Arial", 14, FontStyle.Bold) ' Judul Grafik
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = False 'garis bantu
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.Interval = 1 ' Interval dari Sumbu X
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True ' label Sumbu X akan autofit
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = False ' Jika diaktifkan label Sumbu X akan ada jarak top and down
        ChartPenjualan.Series("Series1").IsValueShownAsLabel = True ' Untuk menampilkan nilai diatas grafik
        ChartPenjualan.Series("Series1").Font = New Font("Times", 10, FontStyle.Bold)  ' Style untuk label nilai grafiknya

        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.LightGray
        ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.LightGray


        'Dibawah ini merupakan fungsi warna yang dideklarasikan secara statis
        ChartPenjualan.Series("Series1").Points(0).Color = Color.CadetBlue
        ChartPenjualan.Series("Series1").Points(1).Color = Color.Firebrick
        ChartPenjualan.Series("Series1").Points(2).Color = Color.ForestGreen
        ChartPenjualan.Series("Series1").Points(3).Color = Color.MediumSlateBlue
        ChartPenjualan.Series("Series1").Points(4).Color = Color.Orange
        ChartPenjualan.Series("Series1").Points(5).Color = Color.Purple
        ChartPenjualan.Series("Series1").Points(6).Color = Color.RoyalBlue
        ChartPenjualan.Series("Series1").Points(7).Color = Color.Tomato
        ChartPenjualan.Series("Series1").Points(8).Color = Color.LimeGreen
        ChartPenjualan.Series("Series1").Points(9).Color = Color.SkyBlue
        ChartPenjualan.Series("Series1").Points(10).Color = Color.Red
        ChartPenjualan.Series("Series1").Points(11).Color = Color.Magenta
        ChartPenjualan.Series("Series1").Points(12).Color = Color.Fuchsia





        txtTotalALL.Text = "Rp. " & Format(TotalALlFix, "##,0")







        'ChartPenjualan.Series("Series1").Points(0).Color = Color.Red
        'ChartPenjualan.Series("Series1").Points(1).Color = Color.Blue
        'ChartPenjualan.Series("Series1").Points(2).Color = Color.Green
        'ChartPenjualan.Series("Series1").Points(3).Color = Color.Gray
        'ChartPenjualan.Series("Series1").Points(4).Color = Color.Yellow
        'ChartPenjualan.Series("Series1").Points(5).Color = Color.Purple
        'ChartPenjualan.Series("Series1").Points(6).Color = Color.RoyalBlue
        'ChartPenjualan.Series("Series1").Points(7).Color = Color.Salmon
        'ChartPenjualan.Series("Series1").Points(8).Color = Color.HotPink
        'ChartPenjualan.Series("Series1").Points(9).Color = Color.CadetBlue
        'ChartPenjualan.Series("Series1").Points(10).Color = Color.Lavender
        'ChartPenjualan.Series("Series1").Points(11).Color = Color.Indigo
        'ChartPenjualan.Series("Series1").Points(12).Color = Color.Linen










    End Sub



    Sub LoadChartCustomDate()

        ChartPenjualan.Series("Series1").Points.Clear()
        ChartPenjualan.Titles.Clear()

        Dim TotalALlFix As Long
        Dim totalTemp As Long


        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(dtpAwal.Value, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(dtpAkhir.Value, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)



        If Tabel1.Rows.Count > 0 Then
            For i As Integer = 0 To Tabel1.Rows.Count - 1

                totalTemp = Tabel1.Rows(i).Item(1)

                TotalALlFix = TotalALlFix + totalTemp

            Next
        End If


        ChartPenjualan.Titles.Add("TURN OVER PENJUALAN").Font = New Font("Arial", 14, FontStyle.Bold)
        'ChartPenjualan.Titles.Add("TURN OVER PENJUALAN")
        'ChartPenjualan.Titles("Title1").Font = New System.Drawing.Font("Times New Roman", 25, System.Drawing.FontStyle.Bold)
        ChartPenjualan.Series(0).Points.AddXY("ABM", FormatCurrency(Tabel1.Rows(0).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM AYANI", FormatCurrency(Tabel1.Rows(1).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM CIBABAT", FormatCurrency(Tabel1.Rows(2).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM KOPO", FormatCurrency(Tabel1.Rows(3).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM CIBIRU", FormatCurrency(Tabel1.Rows(4).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM GARUT", FormatCurrency(Tabel1.Rows(5).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM CIREBON", FormatCurrency(Tabel1.Rows(6).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM SUMEDANG", FormatCurrency(Tabel1.Rows(7).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM CIAPARAY", FormatCurrency(Tabel1.Rows(8).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM RANCAEKEK", FormatCurrency(Tabel1.Rows(9).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM TASIKMALAYA", FormatCurrency(Tabel1.Rows(10).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM PAMANUKAN", FormatCurrency(Tabel1.Rows(11).Item(1)))
        ChartPenjualan.Series(0).Points.AddXY("RKM SOEKARNO HATTA", FormatCurrency(Tabel1.Rows(12).Item(1)))



        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MinorTickMark.Enabled = False
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.Interval = 1
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.IsLabelAutoFit = True
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelStyle.IsStaggered = True
        'ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelStyle.Angle = 70
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = False
        ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = False
        ChartPenjualan.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.LightGray
        ChartPenjualan.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.LightGray



        ChartPenjualan.Series("Series1").Points(0).Color = Color.LightBlue
        ChartPenjualan.Series("Series1").Points(1).Color = Color.LightCoral
        ChartPenjualan.Series("Series1").Points(2).Color = Color.LightCyan
        ChartPenjualan.Series("Series1").Points(3).Color = Color.LightPink
        ChartPenjualan.Series("Series1").Points(4).Color = Color.LightSalmon
        ChartPenjualan.Series("Series1").Points(5).Color = Color.LightSkyBlue
        ChartPenjualan.Series("Series1").Points(6).Color = Color.LightYellow
        ChartPenjualan.Series("Series1").Points(7).Color = Color.LightSteelBlue
        ChartPenjualan.Series("Series1").Points(8).Color = Color.LimeGreen
        ChartPenjualan.Series("Series1").Points(9).Color = Color.LightSlateGray
        ChartPenjualan.Series("Series1").Points(10).Color = Color.LightGoldenrodYellow
        ChartPenjualan.Series("Series1").Points(11).Color = Color.LemonChiffon
        ChartPenjualan.Series("Series1").Points(12).Color = Color.Linen


        txtTotalALL.Text = "Rp. " & Format(TotalALlFix, "##,0")


        ChartPenjualan.Series("Series1").IsValueShownAsLabel = True
        ChartPenjualan.Series("Series1").Font = New Font("Times", 7, FontStyle.Bold)  ' will


    End Sub




    Private Sub cmdTampilkanGrafik_Click(sender As Object, e As EventArgs) Handles cmdTampilkanGrafik.Click
        LoadChartCustomDate()
    End Sub
End Class