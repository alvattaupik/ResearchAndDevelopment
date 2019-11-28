Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class StorePerform
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
    Private Sub StorePerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button5.Hide()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        Button11.Hide()
        Button12.Hide()
        Button13.Hide()
        aa1.Hide()
        aa2.Hide()
        bb1.Hide()
        bb2.Hide()
        cc1.Hide()
        cc2.Hide()
        dd1.Hide()
        dd2.Hide()
        ee1.Hide()
        ee2.Hide()
        comp.Hide()
        grp.Hide()
        cek.Hide()
        Button14.Hide()
        NumericUpDown1.Value = Format(Format(Now, "yyyy"))
        GridHasil.ColumnCount = 13
        GridHasil.Columns(0).HeaderText = "GROUP"
        GridHasil.Columns(1).HeaderText = "JANUARI"
        GridHasil.Columns(2).HeaderText = "FEBRUARI"
        GridHasil.Columns(3).HeaderText = "MARET"
        GridHasil.Columns(4).HeaderText = "APRIL"
        GridHasil.Columns(5).HeaderText = "MEI"
        GridHasil.Columns(6).HeaderText = "JUNI"
        GridHasil.Columns(7).HeaderText = "JULI"
        GridHasil.Columns(8).HeaderText = "AGUSTUS"
        GridHasil.Columns(9).HeaderText = "SEPTEMBER"
        GridHasil.Columns(10).HeaderText = "OKTOBER"
        GridHasil.Columns(11).HeaderText = "NOVEMBER"
        GridHasil.Columns(12).HeaderText = "DESEMBER"


        GridHasil.RowCount = 11
        GridHasil.Rows(0).Cells(0).Value = "A1 : WALL & FLOOR"
        GridHasil.Rows(1).Cells(0).Value = "A2 : BUILDING MATERIALS"
        GridHasil.Rows(2).Cells(0).Value = "B1 : SANITARIES"
        GridHasil.Rows(3).Cells(0).Value = "B2 : PLUMBING & WATER HEATER"
        GridHasil.Rows(4).Cells(0).Value = "C1 : PAINT & SUNPRIGS"
        GridHasil.Rows(5).Cells(0).Value = "C2 : ELECTRICAL & LIGHTING"
        GridHasil.Rows(6).Cells(0).Value = "D1 : HARDWARE"
        GridHasil.Rows(7).Cells(0).Value = "D2 : TOOLS, HOUSEWARES & APPLIANCES"
        GridHasil.Rows(8).Cells(0).Value = "E1 : KONSINYASI"
        GridHasil.Rows(9).Cells(0).Value = "E2 : MISCELLANEOUS"
        GridHasil.Rows(10).Cells(0).Value = "Grand Total"

        GridHasil.Rows(0).HeaderCell.Value = "A1 : WALL & FLOOR"
        GridHasil.Rows(1).HeaderCell.Value = "A2 : BUILDING MATERIALS"
        GridHasil.Rows(2).HeaderCell.Value = "B1 : SANITARIES"
        GridHasil.Rows(3).HeaderCell.Value = "B2 : PLUMBING & WATER HEATER"
        GridHasil.Rows(4).HeaderCell.Value = "C1 : PAINT & SUNPRIGS"
        GridHasil.Rows(5).HeaderCell.Value = "C2 : ELECTRICAL & LIGHTING"
        GridHasil.Rows(6).HeaderCell.Value = "D1 : HARDWARE"
        GridHasil.Rows(7).HeaderCell.Value = "D2 : TOOLS, HOUSEWARES & APPLIANCES"
        GridHasil.Rows(8).HeaderCell.Value = "E1 : KONSINYASI"
        GridHasil.Rows(9).HeaderCell.Value = "E2 : MISCELLANEOUS"
        GridHasil.Rows(10).HeaderCell.Value = "Grand Total"
        GridHasil.Columns(0).Visible = False

        GridHasil.Rows(0).Height = 15
        GridHasil.Rows(1).Height = 15
        GridHasil.Rows(2).Height = 15
        GridHasil.Rows(3).Height = 15
        GridHasil.Rows(4).Height = 15
        GridHasil.Rows(5).Height = 15
        GridHasil.Rows(6).Height = 15
        GridHasil.Rows(7).Height = 15
        GridHasil.Rows(8).Height = 15
        GridHasil.Rows(9).Height = 15
        GridHasil.Rows(10).Height = 15

        GridHasil.Columns(0).Width = 230

        Dim i As Integer
        For i = 0 To GridHasil.RowCount - 2
            If i Mod 2 = 0 Then
                GridHasil.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
        GridHasil.Rows(GridHasil.RowCount - 1).DefaultCellStyle.BackColor = Color.LightBlue
        For i = 0 To GridHasil.RowCount - 2
            If i Mod 2 = 0 Then
                GridHasil.Rows(i).HeaderCell.Style.BackColor = Color.AliceBlue
            End If
        Next

        Button5.Text = "Total"
        Dim w As Integer = Button5.Width
        Dim h As Integer = Button5.Height
        Dim myBitmap As New Bitmap(w, h)
        Button5.DrawToBitmap(myBitmap, Rectangle.FromLTRB(0, 0, w, h))
        myBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY)
        Button2.Image = myBitmap

        Button8.Text = "Total Group"
        w = Button8.Width
        h = Button8.Height
        Dim myBitmap2 As New Bitmap(w, h)
        Button8.DrawToBitmap(myBitmap2, Rectangle.FromLTRB(0, 0, w, h))
        myBitmap2.RotateFlip(RotateFlipType.Rotate90FlipXY)
        Button3.Image = myBitmap2

        Button6.Text = "Total Sales Person"
        w = Button6.Width
        h = Button6.Height
        Dim myBitmap3 As New Bitmap(w, h)
        Button6.DrawToBitmap(myBitmap3, Rectangle.FromLTRB(0, 0, w, h))
        myBitmap3.RotateFlip(RotateFlipType.Rotate90FlipXY)
        Button10.Image = myBitmap3


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Cabang!!")
            Exit Sub
        End If

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "3"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "4"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "8"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "7"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "5"
        ElseIf ComboBox1.Text = "RKM Sumedang" Then
            cabang = "9"
        End If

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        For i = 1 To 12
            If i = 1 Then
                awal = Format(NumericUpDown1.Value) + "-01-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-01-31 23:59:00.000"
            ElseIf i = 2 Then
                If NumericUpDown1.Value Mod 4 = 0 Then
                    awal = Format(NumericUpDown1.Value) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value) + "-02-29 23:59:00.000"
                Else
                    awal = Format(NumericUpDown1.Value) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value) + "-02-28 23:59:00.000"
                End If
            ElseIf i = 3 Then
                awal = Format(NumericUpDown1.Value) + "-03-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-03-31 23:59:00.000"
            ElseIf i = 4 Then
                awal = Format(NumericUpDown1.Value) + "-04-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-04-30 23:59:00.000"
            ElseIf i = 5 Then
                awal = Format(NumericUpDown1.Value) + "-05-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-05-31 23:59:00.000"
            ElseIf i = 6 Then
                awal = Format(NumericUpDown1.Value) + "-06-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-06-30 23:59:00.000"
            ElseIf i = 7 Then
                awal = Format(NumericUpDown1.Value) + "-07-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-07-31 23:59:00.000"
            ElseIf i = 8 Then
                awal = Format(NumericUpDown1.Value) + "-08-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-08-31 23:59:00.000"
            ElseIf i = 9 Then
                awal = Format(NumericUpDown1.Value) + "-09-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-09-30 23:59:00.000"
            ElseIf i = 10 Then
                awal = Format(NumericUpDown1.Value) + "-10-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-10-31 23:59:00.000"
            ElseIf i = 11 Then
                awal = Format(NumericUpDown1.Value) + "-11-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-11-30 23:59:00.000"
            ElseIf i = 12 Then
                awal = Format(NumericUpDown1.Value) + "-12-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-12-31 23:59:00.000"
            End If

            Dim command As SqlCommand
            If ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ayani" And ComboBox1.Text <> "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Group", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(Command)
            Command.CommandType = CommandType.StoredProcedure
            'Command.Parameters.AddWithValue("@TglAwal", awal)
            'Command.Parameters.AddWithValue("@TglAkhir", akhir)
            Command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView1.DataSource = table

            GridHasil.Rows(0).Cells(i).Value = DataGridView1.Rows(0).Cells(0).Value
            GridHasil.Rows(1).Cells(i).Value = DataGridView1.Rows(0).Cells(1).Value
            GridHasil.Rows(2).Cells(i).Value = DataGridView1.Rows(0).Cells(2).Value
            GridHasil.Rows(3).Cells(i).Value = DataGridView1.Rows(0).Cells(3).Value
            GridHasil.Rows(4).Cells(i).Value = DataGridView1.Rows(0).Cells(4).Value
            GridHasil.Rows(5).Cells(i).Value = DataGridView1.Rows(0).Cells(5).Value
            GridHasil.Rows(6).Cells(i).Value = DataGridView1.Rows(0).Cells(6).Value
            GridHasil.Rows(7).Cells(i).Value = DataGridView1.Rows(0).Cells(7).Value
            GridHasil.Rows(8).Cells(i).Value = DataGridView1.Rows(0).Cells(8).Value
            GridHasil.Rows(9).Cells(i).Value = DataGridView1.Rows(0).Cells(9).Value
            GridHasil.Rows(10).Cells(i).Value = DataGridView1.Rows(0).Cells(0).Value + DataGridView1.Rows(0).Cells(1).Value + DataGridView1.Rows(0).Cells(2).Value + DataGridView1.Rows(0).Cells(3).Value + DataGridView1.Rows(0).Cells(4).Value + DataGridView1.Rows(0).Cells(5).Value + DataGridView1.Rows(0).Cells(6).Value + DataGridView1.Rows(0).Cells(7).Value + DataGridView1.Rows(0).Cells(8).Value + DataGridView1.Rows(0).Cells(9).Value
        Next

        Me.GridHasil.Columns(1).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(2).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(3).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(4).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(5).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(6).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(7).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(8).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(9).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(10).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(11).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(12).DefaultCellStyle.Format = "N0"

        Me.GridHasil.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'Dim command2 As SqlCommand
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" Then
        'command2 = New SqlCommand("rkm_store_performance_2", MyConnection2)
        'Else
        'command2 = New SqlCommand("_TmSp_Store_Performance_Sales", MyConnection)
        'End If
        'Dim adapter2 As New SqlDataAdapter(command2)
        'command2.CommandType = CommandType.StoredProcedure
        'command2.Parameters.AddWithValue("@Tahun", NumericUpDown1.Value)
        'command2.Parameters.AddWithValue("@Cabang", cabang)
        'Dim table2 As New DataTable
        'adapter2.Fill(table2)
        'Me.GridHasilSales.DataSource = table2

        'For i = 0 To GridHasilSales.RowCount - 1
        'GridHasilSales.Rows(i).HeaderCell.Value = GridHasilSales.Rows(i).Cells(0).Value
        'Next
        'GridHasilSales.Columns(0).Visible = False

        'Me.GridHasilSales.Columns(1).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(2).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(3).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(4).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(5).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(6).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(7).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(8).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(9).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(10).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(11).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(12).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(13).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(14).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(15).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(16).DefaultCellStyle.Format = "N0"
        'Me.GridHasilSales.Columns(17).DefaultCellStyle.Format = "N0"

        'Me.GridHasilSales.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.GridHasilSales.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



        'For i = 0 To GridHasilSales.RowCount - 2
        'If i Mod 2 = 0 Then
        'GridHasilSales.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
        'End If
        'Next
        'GridHasilSales.Rows(GridHasil.RowCount - 1).DefaultCellStyle.BackColor = Color.LightBlue
        'For i = 0 To GridHasilSales.RowCount - 2
        'If i Mod 2 = 0 Then
        'GridHasilSales.Rows(i).HeaderCell.Style.BackColor = Color.AliceBlue
        'End If
        'Next

        'For i = GridHasilSales.RowCount - 1 To 0 Step -1
        'If Format(GridHasilSales.Rows(i).Cells(1).Value) * 1 = 0 And Format(GridHasilSales.Rows(i).Cells(15).Value) * 1 = 0 Then
        'GridHasilSales.Rows.RemoveAt(i)
        'End If
        'Next
        If comp.Text <> "" Then
            Button14_Click(sender, e)
        End If

        Button2_Click(sender, e)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim myPane As GraphPane = ZTotal.GraphPane
        ZTotal.GraphPane.CurveList.Clear()
        ZTotal.GraphPane.GraphObjList.Clear()
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"
        Dim labels() As String = {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}

        Dim a1 = New PointPairList()
        Dim b1 = New PointPairList()

        Dim i As Integer
        For i = 1 To 12
            a1.Add(i - 1, Format(GridHasil.Rows(10).Cells(i).Value))
        Next

        If comp.Text <> "" Then
            For i = 1 To 12
                b1.Add(i - 1, Format(GridHasil.Rows(11).Cells(i).Value))
            Next
        End If


        ' Generate a red bar with "Curve 1" in the legend
        Dim myBar As BarItem = myPane.AddBar("TOTAL SALES " + Format(NumericUpDown1.Value), a1, Color.Red)
        myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)


        If comp.Text <> "" Then
            myBar = myPane.AddBar("TOTAL SALES " + comp.Text, b1, Color.Blue)
            myBar.Bar.Fill = New Fill(Color.Blue, Color.White, Color.Blue)
        End If

        ' Draw the X tics between the labels instead of 
        ' at the labels
        myPane.XAxis.MajorTic.IsBetweenLabels = True

        ' Set the XAxis labels
        myPane.XAxis.Scale.TextLabels = labels
        ' Set the XAxis to Text type
        myPane.XAxis.Type = AxisType.Text

        ' Fill the Axis and Pane backgrounds
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))

        ' Tell ZedGraph to refigure the
        ' axes since the data have changed
        ZTotal.AxisChange()
        ZTotal.Refresh()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim myPane As GraphPane = ZTotal.GraphPane
        ZTotal.GraphPane.CurveList.Clear()
        ZTotal.GraphPane.GraphObjList.Clear()
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"
        Dim labels() As String = {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}

        Dim a1 = New PointPairList()
        Dim b1 = New PointPairList()

        Dim i As Integer
        For i = 1 To 12
            a1.Add(i - 1, Format(GridHasil.Rows(10).Cells(i).Value))
        Next

        ' Generate a red bar with "Curve 1" in the legend
        Dim myBar As LineItem = myPane.AddCurve("TOTAL SALES", a1, Color.Red)
        'myBar.Line.Fill = New Fill(Color.Red, Color.White, Color.Red)


        If comp.Text <> "" Then
            For i = 1 To 12
                b1.Add(i - 1, Format(GridHasil.Rows(11).Cells(i).Value))
            Next

        End If

        If comp.Text <> "" Then
            
            myBar = myPane.AddCurve("TOTAL SALES " + comp.Text, b1, Color.Blue)
            'myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)
        End If
        ' Draw the X tics between the labels instead of 
        ' at the labels
        myPane.XAxis.MajorTic.IsBetweenLabels = True

        ' Set the XAxis labels
        myPane.XAxis.Scale.TextLabels = labels
        ' Set the XAxis to Text type
        myPane.XAxis.Type = AxisType.Text

        ' Fill the Axis and Pane backgrounds
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))

        ' Tell ZedGraph to refigure the
        ' axes since the data have changed
        ZTotal.AxisChange()
        ZTotal.Refresh()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim myPane As GraphPane = zgc.GraphPane


        zgc.GraphPane.CurveList.Clear()
        zgc.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}

        Dim a1 = New PointPairList()
        Dim x As Double ', w As Double
        x = 0

        Dim a2 = New PointPairList()
        Dim b1 = New PointPairList()
        Dim b2 = New PointPairList()
        Dim c1 = New PointPairList()
        Dim c2 = New PointPairList()
        Dim d1 = New PointPairList()
        Dim d2 = New PointPairList()
        Dim e1 = New PointPairList()
        Dim e2 = New PointPairList()

        Dim i As Integer
        For i = 1 To 12
            a1.Add(i - 1, GridHasil.Rows(0).Cells(i).Value)
            a2.Add(i - 1, GridHasil.Rows(1).Cells(i).Value)
            b1.Add(i - 1, GridHasil.Rows(2).Cells(i).Value)
            b2.Add(i - 1, GridHasil.Rows(3).Cells(i).Value)
            c1.Add(i - 1, GridHasil.Rows(4).Cells(i).Value)
            c2.Add(i - 1, GridHasil.Rows(5).Cells(i).Value)
            d1.Add(i - 1, GridHasil.Rows(6).Cells(i).Value)
            d2.Add(i - 1, GridHasil.Rows(7).Cells(i).Value)
            e1.Add(i - 1, GridHasil.Rows(8).Cells(i).Value)
            e2.Add(i - 1, GridHasil.Rows(9).Cells(i).Value)
        Next

        Dim myBar As BarItem
        If aa1.Text = "True" Then
            myBar = myPane.AddBar("A1 : WALL & FLOOR", a1, Color.Red)
            myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)
        End If

        If aa2.Text = "True" Then
            myBar = myPane.AddBar("A2 : BUILDING MATERIALS", a2, Color.Blue)
            myBar.Bar.Fill = New Fill(Color.Blue, Color.White, Color.Blue)
        End If

        If bb1.Text = "True" Then
            myBar = myPane.AddBar("B1 : SANITARIES", b1, Color.Green)
            myBar.Bar.Fill = New Fill(Color.Green, Color.White, Color.Green)
        End If

        If bb2.Text = "True" Then
            myBar = myPane.AddBar("B2 : PLUMBING & WATER HEATER", b2, Color.Yellow)
            myBar.Bar.Fill = New Fill(Color.Yellow, Color.White, Color.Yellow)
        End If

        If cc1.Text = "True" Then
            myBar = myPane.AddBar("C1 : PAINT & SUNPRIGS", c1, Color.Brown)
            myBar.Bar.Fill = New Fill(Color.Brown, Color.White, Color.Brown)
        End If

        If cc2.Text = "True" Then
            myBar = myPane.AddBar("C2 : ELECTRICAL & LIGHTING", c2, Color.DarkGray)
            myBar.Bar.Fill = New Fill(Color.DarkGray, Color.White, Color.DarkGray)
        End If

        If dd1.Text = "True" Then
            myBar = myPane.AddBar("D1 : HARDWARE", d1, Color.DeepPink)
            myBar.Bar.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)
        End If

        If dd2.Text = "True" Then
            myBar = myPane.AddBar("D2 : TOOLS, HOUSEWARES & APPLIANCES", d2, Color.DeepPink)
            myBar.Bar.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)
        End If

        If ee1.Text = "True" Then
            myBar = myPane.AddBar("E1 : KONSINYASI", e1, Color.DarkSlateBlue)
            myBar.Bar.Fill = New Fill(Color.DarkSlateBlue, Color.White, Color.DarkSlateBlue)
        End If

        If ee2.Text = "True" Then
            myBar = myPane.AddBar("E2 : MISCELLANEOUS", e2, Color.Honeydew)
            myBar.Bar.Fill = New Fill(Color.Honeydew, Color.White, Color.Honeydew)
        End If

        myPane.XAxis.MajorTic.IsBetweenLabels = True
        myPane.XAxis.Scale.TextLabels = labels
        myPane.XAxis.Type = AxisType.Text
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))
        zgc.AxisChange()
        zgc.Refresh()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim myPane As GraphPane = zgc.GraphPane


        zgc.GraphPane.CurveList.Clear()
        zgc.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}

        Dim a1 = New PointPairList()
        Dim x As Double ', w As Double
        x = 0

        Dim a2 = New PointPairList()
        Dim b1 = New PointPairList()
        Dim b2 = New PointPairList()
        Dim c1 = New PointPairList()
        Dim c2 = New PointPairList()
        Dim d1 = New PointPairList()
        Dim d2 = New PointPairList()
        Dim e1 = New PointPairList()
        Dim e2 = New PointPairList()

        Dim i As Integer
        For i = 1 To 12
            a1.Add(i - 1, GridHasil.Rows(0).Cells(i).Value)
            a2.Add(i - 1, GridHasil.Rows(1).Cells(i).Value)
            b1.Add(i - 1, GridHasil.Rows(2).Cells(i).Value)
            b2.Add(i - 1, GridHasil.Rows(3).Cells(i).Value)
            c1.Add(i - 1, GridHasil.Rows(4).Cells(i).Value)
            c2.Add(i - 1, GridHasil.Rows(5).Cells(i).Value)
            d1.Add(i - 1, GridHasil.Rows(6).Cells(i).Value)
            d2.Add(i - 1, GridHasil.Rows(7).Cells(i).Value)
            e1.Add(i - 1, GridHasil.Rows(8).Cells(i).Value)
            e2.Add(i - 1, GridHasil.Rows(9).Cells(i).Value)
        Next

        Dim myBar As LineItem
        If aa1.Text = "True" Then
            myBar = myPane.AddCurve("A1 : WALL & FLOOR", a1, Color.Red)
            'myBar.Line.Fill = New Fill(Color.Red, Color.White, Color.Red)
        End If

        If aa2.Text = "True" Then
            myBar = myPane.AddCurve("A2 : BUILDING MATERIALS", a2, Color.Blue)
            'myBar.Line.Fill = New Fill(Color.Blue, Color.White, Color.Blue)
        End If

        If bb1.Text = "True" Then
            myBar = myPane.AddCurve("B1 : SANITARIES", b1, Color.Green)
            'myBar.Line.Fill = New Fill(Color.Green, Color.White, Color.Green)
        End If

        If bb2.Text = "True" Then
            myBar = myPane.AddCurve("B2 : PLUMBING & WATER HEATER", b2, Color.Yellow)
            'myBar.Line.Fill = New Fill(Color.Yellow, Color.White, Color.Yellow)
        End If

        If cc1.Text = "True" Then
            myBar = myPane.AddCurve("C1 : PAINT & SUNPRIGS", c1, Color.Brown)
            'myBar.Line.Fill = New Fill(Color.Brown, Color.White, Color.Brown)
        End If

        If cc2.Text = "True" Then
            myBar = myPane.AddCurve("C2 : ELECTRICAL & LIGHTING", c2, Color.DarkGray)
            'myBar.Line.Fill = New Fill(Color.DarkGray, Color.White, Color.DarkGray)
        End If

        If dd1.Text = "True" Then
            myBar = myPane.AddCurve("D1 : HARDWARE", d1, Color.DeepPink)
            'myBar.Line.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)
        End If

        If dd2.Text = "True" Then
            myBar = myPane.AddCurve("D2 : TOOLS, HOUSEWARES & APPLIANCES", d2, Color.DeepPink)
            'myBar.Line.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)
        End If

        If ee1.Text = "True" Then
            myBar = myPane.AddCurve("E1 : KONSINYASI", e1, Color.DarkSlateBlue)
            'myBar.Line.Fill = New Fill(Color.DarkSlateBlue, Color.White, Color.DarkSlateBlue)
        End If

        If ee2.Text = "True" Then
            myBar = myPane.AddCurve("E2 : MISCELLANEOUS", e2, Color.Black)
            'myBar.Line.Fill = New Fill(Color.Honeydew, Color.White, Color.Honeydew)
        End If

        myPane.XAxis.MajorTic.IsBetweenLabels = True
        myPane.XAxis.Scale.TextLabels = labels
        myPane.XAxis.Type = AxisType.Text
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))
        zgc.AxisChange()
        zgc.Refresh()
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button3.Enabled = True
        Button10.Enabled = True
        ZTotal.Visible = True
        zgc.Visible = False
        ZTotalSales.Visible = False
        GridHasil.Visible = True
        GridHasilSales.Visible = False
        If CheckBox1.Checked Then
            Button6_Click(sender, e)
        ElseIf CheckBox2.Checked Then
            Button5_Click(sender, e)
        End If
        Button9.Enabled = True
    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button2.Enabled = True
        Button3.Enabled = False
        Button10.Enabled = True
        ZTotal.Visible = False
        zgc.Visible = True
        ZTotalSales.Visible = False
        GridHasil.Visible = True
        GridHasilSales.Visible = False
        If CheckBox1.Checked Then
            Button7_Click(sender, e)
        Else
            Button8_Click(sender, e)
        End If
        Button9.Enabled = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Button3.Enabled = False Then
            GraphOption1.ShowDialog()
            grp.Text = ""
        End If
        If Button2.Enabled = False Then
            Dialog2.ShowDialog()
        End If
    End Sub

    Public Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button2.Enabled = True
        Button3.Enabled = True
        Button10.Enabled = False
        ZTotal.Visible = False
        zgc.Visible = False
        ZTotalSales.Visible = True
        GridHasil.Visible = False
        GridHasilSales.Visible = True
        Button9.Enabled = False
        If CheckBox1.Checked Then
            Button13_Click(sender, e)
        Else
            Button12_Click(sender, e)
        End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = False

        cek.Text = ""
        cek.Text = "xxx"
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = True
        cek.Text = ""
        cek.Text = "xxx"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "3"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "4"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "8"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "7"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "5"
        ElseIf ComboBox1.Text = "RKM Sumedang" Then
            cabang = "9"
        End If

        Dim myPane As GraphPane = zgc.GraphPane

        zgc.GraphPane.CurveList.Clear()
        zgc.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"}

        Dim a1 = New PointPairList()
        Dim x As Double ', w As Double
        x = 0

        Dim a2 = New PointPairList()
        Dim b1 = New PointPairList()
        Dim b2 = New PointPairList()
        Dim c1 = New PointPairList()
        Dim c2 = New PointPairList()
        Dim d1 = New PointPairList()
        Dim d2 = New PointPairList()
        Dim e1 = New PointPairList()
        Dim e2 = New PointPairList()

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        For i = 1 To 12
            If i = 1 Then
                awal = Format(NumericUpDown1.Value) + "-01-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-01-31 23:59:00.000"
            ElseIf i = 2 Then
                If NumericUpDown1.Value Mod 2 = 0 Then
                    awal = Format(NumericUpDown1.Value) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value) + "-02-29 23:59:00.000"
                Else
                    awal = Format(NumericUpDown1.Value) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value) + "-02-28 23:59:00.000"
                End If
            ElseIf i = 3 Then
                awal = Format(NumericUpDown1.Value) + "-03-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-03-31 23:59:00.000"
            ElseIf i = 4 Then
                awal = Format(NumericUpDown1.Value) + "-04-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-04-30 23:59:00.000"
            ElseIf i = 5 Then
                awal = Format(NumericUpDown1.Value) + "-05-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-05-31 23:59:00.000"
            ElseIf i = 6 Then
                awal = Format(NumericUpDown1.Value) + "-06-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-06-30 23:59:00.000"
            ElseIf i = 7 Then
                awal = Format(NumericUpDown1.Value) + "-07-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-07-31 23:59:00.000"
            ElseIf i = 8 Then
                awal = Format(NumericUpDown1.Value) + "-08-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-08-31 23:59:00.000"
            ElseIf i = 9 Then
                awal = Format(NumericUpDown1.Value) + "-09-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-09-30 23:59:00.000"
            ElseIf i = 10 Then
                awal = Format(NumericUpDown1.Value) + "-10-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-10-31 23:59:00.000"
            ElseIf i = 11 Then
                awal = Format(NumericUpDown1.Value) + "-11-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-11-30 23:59:00.000"
            ElseIf i = 12 Then
                awal = Format(NumericUpDown1.Value) + "-12-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value) + "-12-31 23:59:00.000"
            End If

            'WALL & FLOOR
            Dim command As New SqlCommand("rkm_store_performance", MyConnection2)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            'command.Parameters.AddWithValue("@TglAwal", awal)
            'command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView1.DataSource = table

            GridHasil.Rows(0).Cells(i).Value = DataGridView1.Rows(0).Cells(0).Value
            GridHasil.Rows(1).Cells(i).Value = DataGridView1.Rows(0).Cells(1).Value
            GridHasil.Rows(2).Cells(i).Value = DataGridView1.Rows(0).Cells(2).Value
            GridHasil.Rows(3).Cells(i).Value = DataGridView1.Rows(0).Cells(3).Value
            GridHasil.Rows(4).Cells(i).Value = DataGridView1.Rows(0).Cells(4).Value
            GridHasil.Rows(5).Cells(i).Value = DataGridView1.Rows(0).Cells(5).Value
            GridHasil.Rows(6).Cells(i).Value = DataGridView1.Rows(0).Cells(6).Value
            GridHasil.Rows(7).Cells(i).Value = DataGridView1.Rows(0).Cells(7).Value
            GridHasil.Rows(8).Cells(i).Value = DataGridView1.Rows(0).Cells(8).Value
            GridHasil.Rows(9).Cells(i).Value = DataGridView1.Rows(0).Cells(9).Value
            GridHasil.Rows(10).Cells(i).Value = DataGridView1.Rows(0).Cells(0).Value + DataGridView1.Rows(0).Cells(1).Value + DataGridView1.Rows(0).Cells(2).Value + DataGridView1.Rows(0).Cells(3).Value + DataGridView1.Rows(0).Cells(4).Value + DataGridView1.Rows(0).Cells(5).Value + DataGridView1.Rows(0).Cells(6).Value + DataGridView1.Rows(0).Cells(7).Value + DataGridView1.Rows(0).Cells(8).Value + DataGridView1.Rows(0).Cells(9).Value

            a1.Add(i - 1, DataGridView1.Rows(0).Cells(0).Value)
            a2.Add(i - 1, DataGridView1.Rows(0).Cells(1).Value)
            b1.Add(i - 1, DataGridView1.Rows(0).Cells(2).Value)
            b2.Add(i - 1, DataGridView1.Rows(0).Cells(3).Value)
            c1.Add(i - 1, DataGridView1.Rows(0).Cells(4).Value)
            c2.Add(i - 1, DataGridView1.Rows(0).Cells(5).Value)
            d1.Add(i - 1, DataGridView1.Rows(0).Cells(6).Value)
            d2.Add(i - 1, DataGridView1.Rows(0).Cells(7).Value)
            e1.Add(i - 1, DataGridView1.Rows(0).Cells(8).Value)
            e2.Add(i - 1, DataGridView1.Rows(0).Cells(9).Value)
        Next

        Me.GridHasil.Columns(1).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(2).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(3).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(4).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(5).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(6).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(7).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(8).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(9).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(10).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(11).DefaultCellStyle.Format = "N0"
        Me.GridHasil.Columns(12).DefaultCellStyle.Format = "N0"

        Me.GridHasil.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.GridHasil.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        ' Generate a red bar with "Curve 1" in the legend
        Dim myBar As BarItem = myPane.AddBar("A1 : WALL & FLOOR", a1, Color.Red)
        myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)

        ' Generate a blue bar with "Curve 2" in the legend
        myBar = myPane.AddBar("A2 : BUILDING MATERIALS", a2, Color.Blue)
        myBar.Bar.Fill = New Fill(Color.Blue, Color.White, Color.Blue)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("B1 : SANITARIES", b1, Color.Green)
        myBar.Bar.Fill = New Fill(Color.Green, Color.White, Color.Green)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("B2 : PLUMBING & WATER HEATER", b2, Color.Yellow)
        myBar.Bar.Fill = New Fill(Color.Yellow, Color.White, Color.Yellow)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("C1 : PAINT & SUNPRIGS", c1, Color.Brown)
        myBar.Bar.Fill = New Fill(Color.Brown, Color.White, Color.Brown)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("C2 : ELECTRICAL & LIGHTING", c2, Color.DarkGray)
        myBar.Bar.Fill = New Fill(Color.DarkGray, Color.White, Color.DarkGray)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("D1 : HARDWARE", d1, Color.DeepPink)
        myBar.Bar.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("D2 : TOOLS, HOUSEWARES & APPLIANCES", d2, Color.DeepPink)
        myBar.Bar.Fill = New Fill(Color.DeepPink, Color.White, Color.DeepPink)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("E1 : KONSINYASI", e1, Color.DarkSlateBlue)
        myBar.Bar.Fill = New Fill(Color.DarkSlateBlue, Color.White, Color.DarkSlateBlue)

        ' Generate a green bar with "Curve 4" in the legend
        myBar = myPane.AddBar("E2 : MISCELLANEOUS", e2, Color.Honeydew)
        myBar.Bar.Fill = New Fill(Color.Honeydew, Color.White, Color.Honeydew)


        ' Draw the X tics between the labels instead of 
        ' at the labels
        myPane.XAxis.MajorTic.IsBetweenLabels = True

        ' Set the XAxis labels
        myPane.XAxis.Scale.TextLabels = labels
        ' Set the XAxis to Text type
        myPane.XAxis.Type = AxisType.Text

        ' Fill the Axis and Pane backgrounds
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))

        ' Tell ZedGraph to refigure the
        ' axes since the data have changed
        zgc.AxisChange()

        Dim command2 As New SqlCommand("rkm_store_performance_2", MyConnection2)
        Dim adapter2 As New SqlDataAdapter(command2)
        command2.CommandType = CommandType.StoredProcedure
        command2.Parameters.AddWithValue("@Tahun", NumericUpDown1.Value)
        command2.Parameters.AddWithValue("@Cabang", cabang)
        Dim table2 As New DataTable
        adapter2.Fill(table2)
        Me.GridHasilSales.DataSource = table2

        For i = 0 To GridHasilSales.RowCount - 1
            GridHasilSales.Rows(i).HeaderCell.Value = GridHasilSales.Rows(i).Cells(0).Value
        Next
        GridHasilSales.Columns(0).Visible = False

        Me.GridHasilSales.Columns(1).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(2).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(3).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(4).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(5).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(6).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(7).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(8).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(9).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(10).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(11).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(12).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(13).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(14).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(15).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(16).DefaultCellStyle.Format = "N0"
        Me.GridHasilSales.Columns(17).DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim myPane As GraphPane = ZTotalSales.GraphPane

        ZTotalSales.GraphPane.CurveList.Clear()
        ZTotalSales.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {""}

        Dim a1 = New PointPairList()
        Dim x As Double ', w As Double
        x = 0

        Dim i As Integer
        Dim myBar As BarItem
        For i = 0 To GridHasilSales.RowCount - 1
            labels(1) = GridHasilSales.Rows(i).Cells(0).Value
            a1.Add(0, GridHasilSales.Rows(i).Cells(16).Value)

            myBar = myPane.AddBar(a1, GridHasilSales.Rows(i).Cells(16).Value, Color.Red)
            myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)
        Next


        'myBar = myPane.AddBar("TOTAL SALES", a1, Color.Red)
        'myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)

        myPane.XAxis.MajorTic.IsBetweenLabels = True
        myPane.XAxis.Scale.TextLabels = labels
        myPane.XAxis.Type = AxisType.Text
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))
        ZTotalSales.AxisChange()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim myPane As GraphPane = ZTotalSales.GraphPane

        ZTotalSales.GraphPane.CurveList.Clear()
        ZTotalSales.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "ANYAR GROUP"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {"TOTAL SALES"}

        Dim a1 = New PointPairList()
        'Dim x As Double, w As Double
        'x = 0

        Dim i As Integer
        For i = 0 To GridHasilSales.RowCount - 1
            'MessageBox.Show(GridHasilSales.Rows(i).Cells(16).Value)
            a1.Add(i, GridHasilSales.Rows(i).Cells(16).Value)
        Next

        Dim myBar As LineItem

        myBar = myPane.AddCurve("TOTAL SALES", a1, Color.Red)
        'myBar.Line.Fill = New Fill(Color.Red, Color.White, Color.Red)


        myPane.XAxis.MajorTic.IsBetweenLabels = True
        myPane.XAxis.Scale.TextLabels = labels
        myPane.XAxis.Type = AxisType.Text
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(255, 255, 166), 90.0F)
        myPane.Fill = New Fill(Color.FromArgb(250, 250, 255))
        ZTotalSales.AxisChange()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Public Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "3"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "4"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "8"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "7"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "5"
        ElseIf ComboBox1.Text = "RKM Sumedang" Then
            cabang = "9"
        End If

        GridHasil.RowCount = 12
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        For i = 1 To 12
            If i = 1 Then
                awal = comp.Text + "-01-01 00:00:00.000"
                akhir = comp.Text + "-01-31 23:59:00.000"
            ElseIf i = 2 Then
                If NumericUpDown1.Value Mod 4 = 0 Then
                    awal = comp.Text + "-02-01 00:00:00.000"
                    akhir = comp.Text + "-02-28 23:59:00.000"
                Else
                    awal = comp.Text + "-02-01 00:00:00.000"
                    akhir = comp.Text + "-02-28 23:59:00.000"
                End If
            ElseIf i = 3 Then
                awal = comp.Text + "-03-01 00:00:00.000"
                akhir = comp.Text + "-03-31 23:59:00.000"
            ElseIf i = 4 Then
                awal = comp.Text + "-04-01 00:00:00.000"
                akhir = comp.Text + "-04-30 23:59:00.000"
            ElseIf i = 5 Then
                awal = comp.Text + "-05-01 00:00:00.000"
                akhir = comp.Text + "-05-31 23:59:00.000"
            ElseIf i = 6 Then
                awal = comp.Text + "-06-01 00:00:00.000"
                akhir = comp.Text + "-06-30 23:59:00.000"
            ElseIf i = 7 Then
                awal = comp.Text + "-07-01 00:00:00.000"
                akhir = comp.Text + "-07-31 23:59:00.000"
            ElseIf i = 8 Then
                awal = comp.Text + "-08-01 00:00:00.000"
                akhir = comp.Text + "-08-31 23:59:00.000"
            ElseIf i = 9 Then
                awal = comp.Text + "-09-01 00:00:00.000"
                akhir = comp.Text + "-09-30 23:59:00.000"
            ElseIf i = 10 Then
                awal = comp.Text + "-10-01 00:00:00.000"
                akhir = comp.Text + "-10-31 23:59:00.000"
            ElseIf i = 11 Then
                awal = comp.Text + "-11-01 00:00:00.000"
                akhir = comp.Text + "-11-30 23:59:00.000"
            ElseIf i = 12 Then
                awal = comp.Text + "-12-01 00:00:00.000"
                akhir = comp.Text + "-12-31 23:59:00.000"
            End If

            Dim command As SqlCommand
            If ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" And ComboBox1.Text <> "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Group", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            'command.Parameters.AddWithValue("@TglAwal", DateTime.Parse(awal))
            'command.Parameters.AddWithValue("@TglAkhir", DateTime.Parse(akhir))
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView1.DataSource = table

            GridHasil.Rows(11).Cells(i).Value = DataGridView1.Rows(0).Cells(0).Value + DataGridView1.Rows(0).Cells(1).Value + DataGridView1.Rows(0).Cells(2).Value + DataGridView1.Rows(0).Cells(3).Value + DataGridView1.Rows(0).Cells(4).Value + DataGridView1.Rows(0).Cells(5).Value + DataGridView1.Rows(0).Cells(6).Value + DataGridView1.Rows(0).Cells(7).Value + DataGridView1.Rows(0).Cells(8).Value + DataGridView1.Rows(0).Cells(9).Value


        Next

        GridHasil.Rows(11).Cells(0).Value = "Grand Total " + comp.Text

        GridHasil.Rows(11).HeaderCell.Value = "Grand Total " + comp.Text
        GridHasil.Rows(GridHasil.RowCount - 1).DefaultCellStyle.BackColor = Color.LightBlue
        GridHasil.Rows(11).Height = 15

        Button2_Click(sender, e)
    End Sub

    Private Sub comp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comp.Click

    End Sub

    Private Sub comp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comp.TextChanged
        If comp.Text <> "" Then
            Button14_Click(sender, e)
        Else
            GridHasil.RowCount = 11
            Button2_Click(sender, e)
        End If
    End Sub

    Private Sub grp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp.Click

    End Sub

    Private Sub grp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grp.TextChanged
        If grp.Text <> "" Then
            Button3_Click(sender, e)
        End If
    End Sub

    Private Sub cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek.Click

    End Sub

    Private Sub cek_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cek.TextChanged
        If cek.Text <> "" Then
            If Button2.Enabled = False Then
                Button2_Click(sender, e)
            End If
            If Button3.Enabled = False Then
                Button3_Click(sender, e)
            End If
            If Button10.Enabled = False Then
                Button10_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ' Dim pf As New PowerPacks.Printing.PrintForm(Me)

        'pf.PrinterSettings.PrinterName = "Adobe PDF"
        ' pf.PrintAction = Printing.PrintAction.PrintToPreview
        'pf.PrinterSettings.DefaultPageSettings.Landscape = True

        'pf.PrinterSettings.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(20, 10, 10, 10)



        'For Each size As Printing.PaperSize In pf.PrinterSettings.PaperSizes

        'If Size.Kind = Printing.PaperKind.A4 Then

        'pf.PrinterSettings.DefaultPageSettings.PaperSize = Size

        ' Exit For

        'End If

        'Next



        'pf.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

    Private Sub ZTotalSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZTotalSales.Load

    End Sub
End Class