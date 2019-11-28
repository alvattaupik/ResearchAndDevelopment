Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
'nama, no nik, Status, jabatan, golongan, masa kerja
Public Class SalesMonitoringapter
    Dim MyCommand As SqlDataAdapter
    Dim DtSet As System.Data.DataSet
    Dim MyConnection As SqlConnection
    Dim MyCommand2 As SqlDataAdapter
    Dim DtSet2 As System.Data.DataSet
    Dim MyConnection2 As SqlConnection
    Dim MyCommand3 As SqlDataAdapter
    Dim DtSet3 As System.Data.DataSet
    Dim MyConnection3 As SqlConnection

    Dim ProMyCommand1 As SqlDataAdapter
    Dim ProDtSet1 As System.Data.DataSet
    Dim ProMyCommand2 As SqlDataAdapter
    Dim ProDtSet2 As System.Data.DataSet
    Dim cnt As Integer

    Sub Koneksi()
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.53" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=h0spit4lity#")
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        MyConnection2 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=ProInt_ERP;User ID=sa;Password=stip3ndium")
        If MyConnection2.State = ConnectionState.Closed Then
            MyConnection2.Open()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim myPane As GraphPane = zgc.GraphPane
        myPane.Legend.Position = ZedGraph.LegendPos.BottomCenter
        myPane.Legend.IsVisible = False


        zgc.GraphPane.CurveList.Clear()
        zgc.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "STORE TURNOVER"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = ""

        ' Make up some random data points
        Dim labels() As String = {" "}

        Dim list1 = New PointPairList()
        Dim list2 = New PointPairList()
        Dim list3 = New PointPairList()
        Dim list4 = New PointPairList()
        Dim list5 = New PointPairList()
        Dim list6 = New PointPairList()
        Dim list7 = New PointPairList()
        Dim list8 = New PointPairList()
        Dim list9 = New PointPairList()
        Dim list10 = New PointPairList()
        Dim list11 = New PointPairList()
        Dim list12 = New PointPairList()

        Dim totGarut = 0
        Dim totCirebon = 0
        Dim totABM = 0
        Dim totAyani = 0
        Dim totKopo = 0
        Dim totCibiru = 0
        Dim totCibabat = 0
        Dim totSumedang = 0
        Dim totCiparay = 0
        Dim totRancaekek = 0
        Dim totTasikmalaya = 0
        Dim totPamanukan = 0


        Dim tgl As String = Format(DateTimePicker1.Value, "yyyy-MM-dd 00:00:00.000")
        Dim tgl2 As String = Format(DateTimePicker2.Value, "yyyy-MM-dd 23:59:00.000")

        Koneksi()


        'Dim command2 As SqlCommand
        'command2 = New SqlCommand("rkm_Omset_Harian", MyConnection2)

        'Dim adapter2 As New SqlDataAdapter(command2)
        'command2.CommandType = CommandType.StoredProcedure
        'command2.Parameters.AddWithValue("@TglAwal", tgl)
        'command2.Parameters.AddWithValue("@TglAkhir", tgl2)
        'command.Parameters.AddWithValue("@Cabang", cabang)
        'Dim table2 As New DataTable
        'adapter2.Fill(table2)
        'Me.DataGridViewTotal.DataSource = table2

        'list1.Add(0, DataGridViewTotal.Rows(0).Cells(0).Value)
        'list2.Add(0, DataGridViewTotal.Rows(0).Cells(1).Value)
        'list3.Add(0, DataGridViewTotal.Rows(0).Cells(2).Value)
        'list4.Add(0, DataGridViewTotal.Rows(0).Cells(3).Value)
        'list5.Add(0, DataGridViewTotal.Rows(0).Cells(4).Value)
        'MessageBox.Show(DataGridViewTotal.Rows(0).Cells(0).Value)


        'totABM = DataGridViewTotal.Rows(0).Cells(0).Value
        'totAyani = DataGridViewTotal.Rows(0).Cells(1).Value
        'totKopo = DataGridViewTotal.Rows(0).Cells(2).Value
        'totCibiru = DataGridViewTotal.Rows(0).Cells(3).Value
        'totCibabat = DataGridViewTotal.Rows(0).Cells(4).Value

        Dim command As SqlCommand

        command = New SqlCommand("_tmsp_Omset_Harian", MyConnection)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TglAwal", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TglAkhir", Format(DateTimePicker2.Value, "yyyy-MM-dd"))
        'command.Parameters.AddWithValue("@Cabang", cabang)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridViewTotal.DataSource = table


        list6.Add(0, DataGridViewTotal.Rows(0).Cells(0).Value)
        list7.Add(0, DataGridViewTotal.Rows(0).Cells(1).Value)
        list1.Add(0, DataGridViewTotal.Rows(0).Cells(2).Value)
        list2.Add(0, DataGridViewTotal.Rows(0).Cells(3).Value)
        list8.Add(0, DataGridViewTotal.Rows(0).Cells(4).Value)
        list5.Add(0, DataGridViewTotal.Rows(0).Cells(5).Value)
        list3.Add(0, DataGridViewTotal.Rows(0).Cells(6).Value)
        list4.Add(0, DataGridViewTotal.Rows(0).Cells(7).Value)
        list9.Add(0, DataGridViewTotal.Rows(0).Cells(8).Value)
        list10.Add(0, DataGridViewTotal.Rows(0).Cells(9).Value)
        list11.Add(0, DataGridViewTotal.Rows(0).Cells(10).Value)
        list12.Add(0, DataGridViewTotal.Rows(0).Cells(11).Value)

        totGarut = DataGridViewTotal.Rows(0).Cells(0).Value
        totCirebon = DataGridViewTotal.Rows(0).Cells(1).Value
        totABM = DataGridViewTotal.Rows(0).Cells(2).Value
        totAyani = DataGridViewTotal.Rows(0).Cells(3).Value
        totSumedang = DataGridViewTotal.Rows(0).Cells(4).Value
        totCibabat = DataGridViewTotal.Rows(0).Cells(5).Value
        totKopo = DataGridViewTotal.Rows(0).Cells(6).Value
        totCibiru = DataGridViewTotal.Rows(0).Cells(7).Value
        totCiparay = DataGridViewTotal.Rows(0).Cells(8).Value
        totRancaekek = DataGridViewTotal.Rows(0).Cells(9).Value
        totTasikmalaya = DataGridViewTotal.Rows(0).Cells(10).Value
        totPamanukan = DataGridViewTotal.Rows(0).Cells(11).Value


        Aabm.Text = Format(totABM, "N0")
        AAyani.Text = Format(totAyani, "N0")
        AKopo.Text = Format(totKopo, "N0")
        ACibiru.Text = Format(totCibiru, "N0")
        ACibabat.Text = Format(totCibabat, "N0")
        AGarut.Text = Format(totGarut, "N0")
        ACirebon.Text = Format(totCirebon, "N0")
        ASumedang.Text = Format(totSumedang, "N0")
        ACiparay.Text = Format(totCiparay, "N0")
        ARancaekek.Text = Format(totRancaekek, "N0")
        ATasikmalaya.Text = Format(totTasikmalaya, "N0")
        APamanukan.Text = Format(totPamanukan, "N0")

        totToday.Text = Format(totABM + totAyani + totKopo + totCibiru + totCibabat + totGarut + totCirebon + totSumedang + totCiparay + totRancaekek + totTasikmalaya + totPamanukan, "N0")

        ' Generate a red bar with "Curve 1" in the legend
        Dim myBar As BarItem = myPane.AddBar("ABM" + " - " + Format(totABM, "N0"), list1, Color.Red)
        myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)

        ' Generate a blue bar with "Curve 2" in the legend
        myBar = myPane.AddBar("AYANI" + " - " + Format(totAyani, "N0"), list2, Color.Blue)
        myBar.Bar.Fill = New Fill(Color.Blue, Color.White, Color.Blue)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("KOPO" + " - " + Format(totKopo, "N0"), list3, Color.Yellow)
        myBar.Bar.Fill = New Fill(Color.Yellow, Color.White, Color.Yellow)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("CIBIRU" + " - " + Format(totCibiru, "N0"), list4, Color.Green)
        myBar.Bar.Fill = New Fill(Color.Green, Color.White, Color.Green)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("CIBABAT" + " - " + Format(totCibabat, "N0"), list5, Color.LightBlue)
        myBar.Bar.Fill = New Fill(Color.LightBlue, Color.White, Color.LightBlue)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("GARUT" + " - " + Format(totGarut, "N0"), list6, Color.Gray)
        myBar.Bar.Fill = New Fill(Color.Gray, Color.White, Color.Gray)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("CIREBON" + " - " + Format(totCirebon, "N0"), list7, Color.Purple)
        myBar.Bar.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("SUMEDANG" + " - " + Format(totSumedang, "N0"), list8, Color.Black)
        myBar.Bar.Fill = New Fill(Color.Black, Color.White, Color.Black)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("CIPARAY" + " - " + Format(totCiparay, "N0"), list9, Color.Maroon)
        myBar.Bar.Fill = New Fill(Color.Maroon, Color.White, Color.Maroon)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("RANCAEKEK" + " - " + Format(totRancaekek, "N0"), list10, Color.Orange)
        myBar.Bar.Fill = New Fill(Color.Orange, Color.White, Color.Orange)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("TASIKMALAYA" + " - " + Format(totTasikmalaya, "N0"), list11, Color.Moccasin)
        myBar.Bar.Fill = New Fill(Color.Moccasin, Color.White, Color.Moccasin)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("PAMANUKAN" + " - " + Format(totRancaekek, "N0"), list12, Color.Tan)
        myBar.Bar.Fill = New Fill(Color.Tan, Color.White, Color.Tan)


        ' Draw the X tics between the labels instead of 
        ' at the labels
        myPane.XAxis.MajorTic.IsBetweenLabels = True

        ' Set the XAxis labels
        'myPane.XAxis.Scale.TextLabels = labels
        ' Set the XAxis to Text type
        myPane.XAxis.Type = AxisType.Text

        ' Fill the Axis and Pane backgrounds
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))

        ' Tell ZedGraph to refigure the
        ' axes since the data have changed
        zgc.AxisChange()
        zgc.Refresh()
        Exit Sub

    End Sub

    Private Sub SalesMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Top = -100
        Button3.Top = -100
        Button4.Top = -100
        Button5.Top = -100
        Button3.PerformClick()
        Button1.PerformClick()
        'Button4.PerformClick()
        Button5.PerformClick()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = CStr(CInt(Label2.Text) - 1)
        If Label2.Text = 0 Then
            Label2.Text = "Refreshing"
            Button1.PerformClick()
            Label2.Text = 30
        End If
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim myPane As GraphPane = zgc30.GraphPane
        myPane.Legend.Position = ZedGraph.LegendPos.BottomCenter
        'myPane.Legend.IsVisible = False


        zgc30.GraphPane.CurveList.Clear()
        zgc30.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "STORE TURNOVER - LAST 7 DAYS"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = ""

        ' Make up some random data points
        'Dim labels() As String = {" "}

        Dim list1 = New PointPairList()
        Dim list2 = New PointPairList()
        Dim list3 = New PointPairList()
        Dim list4 = New PointPairList()
        Dim list5 = New PointPairList()
        Dim list6 = New PointPairList()
        Dim list7 = New PointPairList()
        Dim list8 = New PointPairList()
        Dim list9 = New PointPairList()
        Dim list10 = New PointPairList()
        Dim list11 = New PointPairList()
        Dim list12 = New PointPairList()

        Dim totGarut = 0
        Dim totCirebon = 0
        Dim totABM = 0
        Dim totAyani = 0
        Dim totKopo = 0
        Dim totCibiru = 0
        Dim totCibabat = 0
        Dim totSumedang = 0
        Dim totCiparay = 0
        Dim totRancaekek = 0
        Dim totTasikmalaya = 0
        Dim totPamanukan = 0

        Koneksi()

        Dim i As Integer
        Dim labels() As String = {"", "", "", "", "", "", ""}

        For i = 7 To 1 Step -1
            Dim tgl As String = Format((DateTime.Now.AddDays(i * -1)), "yyyy-MM-dd 00:00:00.000")
            Dim tgl2 As String = Format((DateTime.Now.AddDays(i * -1)), "yyyy-MM-dd 23:59:00.000")
            labels(7 - i) = Format((DateTime.Now.AddDays(i * -1)), "yyyy-MM-dd")


            Dim command2 As SqlCommand
            command2 = New SqlCommand("rkm_Omset_Harian", MyConnection2)

            Dim adapter2 As New SqlDataAdapter(command2)
            command2.CommandType = CommandType.StoredProcedure
            command2.Parameters.AddWithValue("@TglAwal", tgl)
            command2.Parameters.AddWithValue("@TglAkhir", tgl2)

            Dim table2 As New DataTable
            adapter2.Fill(table2)
            Me.DataGridViewTotal.DataSource = table2

            'list1.Add(0, DataGridViewTotal.Rows(0).Cells(0).Value)
            'list2.Add(0, DataGridViewTotal.Rows(0).Cells(1).Value)
            'list3.Add(0, DataGridViewTotal.Rows(0).Cells(2).Value)
            list4.Add(0, DataGridViewTotal.Rows(0).Cells(3).Value)
            'list5.Add(0, DataGridViewTotal.Rows(0).Cells(4).Value)


            'totABM = totABM + DataGridViewTotal.Rows(0).Cells(0).Value
            'totAyani = totAyani + DataGridViewTotal.Rows(0).Cells(1).Value
            'totKopo = totKopo + DataGridViewTotal.Rows(0).Cells(2).Value
            totCibiru = totCibiru + DataGridViewTotal.Rows(0).Cells(3).Value
            'totCibabat = totCibabat + DataGridViewTotal.Rows(0).Cells(4).Value

            Dim command As SqlCommand

            command = New SqlCommand("_tmsp_Omset_Harian", MyConnection)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TglAwal", tgl)
            command.Parameters.AddWithValue("@TglAkhir", tgl2)
            'command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridViewTotal.DataSource = table


            list6.Add(0, DataGridViewTotal.Rows(0).Cells(0).Value)
            list7.Add(0, DataGridViewTotal.Rows(0).Cells(1).Value)
            list1.Add(0, DataGridViewTotal.Rows(0).Cells(2).Value)
            list2.Add(0, DataGridViewTotal.Rows(0).Cells(3).Value)
            list8.Add(0, DataGridViewTotal.Rows(0).Cells(4).Value)
            list5.Add(0, DataGridViewTotal.Rows(0).Cells(5).Value)
            list3.Add(0, DataGridViewTotal.Rows(0).Cells(6).Value)
            list9.Add(0, DataGridViewTotal.Rows(0).Cells(7).Value)
            list10.Add(0, DataGridViewTotal.Rows(0).Cells(8).Value)
            list11.Add(0, DataGridViewTotal.Rows(0).Cells(9).Value)
            list12.Add(0, DataGridViewTotal.Rows(0).Cells(10).Value)

            totGarut = totGarut + DataGridViewTotal.Rows(0).Cells(0).Value
            totCirebon = totCirebon + DataGridViewTotal.Rows(0).Cells(1).Value
            totABM = totABM + DataGridViewTotal.Rows(0).Cells(2).Value
            totAyani = totAyani + DataGridViewTotal.Rows(0).Cells(3).Value
            totSumedang = totSumedang + DataGridViewTotal.Rows(0).Cells(4).Value
            totCibabat = totCibabat + DataGridViewTotal.Rows(0).Cells(5).Value
            totKopo = totKopo + DataGridViewTotal.Rows(0).Cells(6).Value
            totCiparay = totCiparay + DataGridViewTotal.Rows(0).Cells(7).Value
            totRancaekek = totRancaekek + DataGridViewTotal.Rows(0).Cells(8).Value
            totTasikmalaya = totTasikmalaya + DataGridViewTotal.Rows(0).Cells(9).Value
            totPamanukan = totPamanukan + DataGridViewTotal.Rows(0).Cells(10).Value

            'Aabm.Text = Format(totABM, "N0")
            'AAyani.Text = Format(totAyani, "N0")
            'AKopo.Text = Format(totKopo, "N0")
            'ACibiru.Text = Format(totCibiru, "N0")
            'ACibabat.Text = Format(totCibabat, "N0")
            'AGarut.Text = Format(totGarut, "N0")
            'ACirebon.Text = Format(totCirebon, "N0")

            'totToday.Text = Format(totABM + totAyani + totKopo + totCibiru + totCibabat + totGarut + totCirebon, "N0")

        Next

        Dim myBar As LineItem = myPane.AddCurve("ABM", list1, Color.Red)
        'myBar.Line.Fill = New Fill(Color.Red, Color.White, Color.Red)

        myBar = myPane.AddCurve("AYANI", list2, Color.Blue)
        'myBar.Line.Fill = New Fill(Color.Blue, Color.White, Color.Blue)

        myBar = myPane.AddCurve("KOPO", list3, Color.Yellow)
        'myBar.Line.Fill = New Fill(Color.Yellow, Color.White, Color.Yellow)

        myBar = myPane.AddCurve("CIBIRU", list4, Color.Green)
        'myBar.Line.Fill = New Fill(Color.Green, Color.White, Color.Green)

        myBar = myPane.AddCurve("CIBABAT", list5, Color.LightBlue)
        'myBar.Line.Fill = New Fill(Color.LightBlue, Color.White, Color.LightBlue)

        myBar = myPane.AddCurve("GARUT", list6, Color.Gray)
        'myBar.Line.Fill = New Fill(Color.Gray, Color.White, Color.Gray)

        myBar = myPane.AddCurve("CIREBON", list7, Color.Purple)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myBar = myPane.AddCurve("SUMEDANG", list8, Color.Black)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myBar = myPane.AddCurve("CIPARAY", list8, Color.Maroon)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myBar = myPane.AddCurve("RANCAEKEK", list8, Color.Orange)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myBar = myPane.AddCurve("TASIKMALAYA", list8, Color.Moccasin)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myBar = myPane.AddCurve("PAMANUKAN", list8, Color.Tan)
        'myBar.Line.Fill = New Fill(Color.Purple, Color.White, Color.Purple)

        myPane.XAxis.MajorTic.IsBetweenLabels = True

        myPane.XAxis.Scale.TextLabels = labels
        myPane.XAxis.Type = AxisType.Text

        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))

        zgc30.AxisChange()
        Exit Sub
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Button2.Visible = False
        ' With 'Me.PrintForm1
        '.PrintAction = Printing.PrintAction.PrintToPreview

        Dim MyMargins As New Printing.Margins

        With MyMargins
            .Left = 20
            .Right = 20
            .Top = 20
            .Bottom = 20
        End With

        ' .PrinterSettings.DefaultPageSettings.Margins = MyMargins
        '.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)
        '.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeFullWindow)


        ' End With

        'PrintForm1.Print()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Button2.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Dim pf As New PowerPacks.Printing.PrintForm(Me)

        'pf.PrinterSettings.PrinterName = "Adobe PDF"
        ' pf.PrintAction = Printing.PrintAction.PrintToPreview
        'pf.PrinterSettings.DefaultPageSettings.Landscape = True

        'pf.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)



        ' For Each size As Printing.PaperSize In pf.PrinterSettings.PaperSizes

        'If Size.Kind = Printing.PaperKind.A4 Then

        'pf.PrinterSettings.DefaultPageSettings.PaperSize = Size

        ' Exit For

        'End If

        ' Next



        ' pf.Print()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Button3.PerformClick()
        Button1.PerformClick()
        Button5.PerformClick()
    End Sub

  
End Class