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
Public Class AsetMonitoring
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
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.6" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=anyarretailindonesia")
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


        zgc.GraphPane.CurveList.Clear()
        zgc.GraphPane.GraphObjList.Clear()

        ' Set the Titles
        myPane.Title.Text = "GRAFIK HUTANG - ASET - BANK"
        myPane.XAxis.Title.Text = ""
        myPane.YAxis.Title.Text = "Milyar"

        ' Make up some random data points
        Dim labels() As String = {"Garut", "Cirebon", "Ayani", "Cibiru", "Kopo", "Cibabat", "ABM"}

        Dim list = New PointPairList()
        Dim x As Double
        x = 0

        Dim list1 = New PointPairList()
        Dim x1 As Double
        x1 = 0

        Dim list2 = New PointPairList()
        Dim x2 As Double
        x2 = 0

        Koneksi()

        'RKM Garut
        Dim command As New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "7")
        Dim table As New DataTable



        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        Dim total As Double = 0
        Dim k As Integer
        For k = 0 To DataGridView1.RowCount - 1
            total = total + DataGridView1.Rows(k).Cells(0).Value
        Next

        For k = 0 To DataGridView1.RowCount - 1
            total = total - DataGridView1.Rows(k).Cells(4).Value
        Next

        Dim totalall As Double = 0
        totalall = totalall + total

        list.Add(x, total)

        'Dim textLabel As TextObj = New TextObj(total.ToString(), x, total, CoordType.AxisXYScale, AlignH.Center, AlignV.Top)

        x = x + 1


        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "RKM Garut")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        Dim total1 As Double = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next


        Dim totalall1 As Double = 0
        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1


        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003002" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        Dim total2 As Double = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004001" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        Dim totalall2 As Double = 0
        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1


        ' RKM Cirebon
        command = New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "8")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        For k = 0 To DataGridView1.RowCount - 1
            total = total + DataGridView1.Rows(k).Cells(0).Value
        Next

        For k = 0 To DataGridView1.RowCount - 1
            total = total - DataGridView1.Rows(k).Cells(4).Value
        Next

        totalall = totalall + total

        list.Add(x, total)
        x = x + 1


        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "RKM Cirebon")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total1 = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next

        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1


        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003003" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total2 = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004002" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1



        ' RKM AYANI
        command = New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "3")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        total = total + DataGridView1.Rows(0).Cells(0).Value

        list.Add(x, total)
        x = x + 1

        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "RKM A. Yani")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        'total = total - DataGridView1.Rows(0).Cells(0).Value
        'totalall = totalall + total


        total1 = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next

        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1
        'command = New SqlCommand("rkm_Aset_vb", MyConnection2)
        'adapter = New SqlDataAdapter(command)
        'command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@Cabang", "AY")
        'table = New DataTable
        'adapter.Fill(table)
        'Me.DataGridView1.DataSource = table

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003006" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total2 = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004005" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1





        ' RKM CIBIRU
        command = New SqlCommand("rkm_hutang_vb", MyConnection2)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "5")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        total = total + DataGridView1.Rows(0).Cells(0).Value


        command = New SqlCommand("rkm_CnDn_vb", MyConnection2)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "5")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = total - DataGridView1.Rows(0).Cells(0).Value
        totalall = totalall + total

        list.Add(x, total)
        x = x + 1

        command = New SqlCommand("rkm_Aset_vb", MyConnection2)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "CBR")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total1 = 0
        total1 = total1 + DataGridView1.Rows(0).Cells(0).Value
        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1

        command = New SqlCommand("select sum(DbHCAmount)-sum(CrHCAmount) from GLTransDt where SubLedgAcnt like '1105.041%'", MyConnection2)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1

        ' RKM CIBABAT
        command = New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "4")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        total = total + DataGridView1.Rows(0).Cells(0).Value

        list.Add(x, total)
        x = x + 1

        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "RKM Kopo")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total1 = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next

        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003006" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total2 = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004005" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1

        ' RKM KOPO
        command = New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "5")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        total = total + DataGridView1.Rows(0).Cells(0).Value

        list.Add(x, total)
        x = x + 1

        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "RKM Kopo")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total1 = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next

        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003006" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total2 = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004005" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1





        ' RKM ABM
        command = New SqlCommand("_TmSp_Aging_Hutang_VB", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Cabang", "1")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total = 0
        total = total + DataGridView1.Rows(0).Cells(0).Value

        list.Add(x, total)
        x = x + 1

        command = New SqlCommand("_TmSp_StockAset", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@Tanggal", Format("yyyy-mm-dd", Now))
        command.Parameters.AddWithValue("@Cabang", "ABM")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total1 = 0
        For k = 0 To DataGridView1.RowCount - 1
            total1 = total1 + DataGridView1.Rows(k).Cells(5).Value
        Next

        totalall1 = totalall1 + total1

        list1.Add(x1, total1)
        x1 = x1 + 1

        'command = New SqlCommand("rkm_Aset_vb", MyConnection2)
        'adapter = New SqlDataAdapter(command)
        'command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@Cabang", "AB")
        'table = New DataTable
        'adapter.Fill(table)
        'Me.DataGridView1.DataSource = table

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101003008" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        total2 = 0
        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If

        command = New SqlCommand("select sum(jdt1.debit)-sum(jdt1.credit) from ojdt left join jdt1 on jdt1.transid=ojdt.transid where ojdt.refdate<'" + Format("yyyy-mm-dd", Now) + "' and jdt1.account='" + "1101004004" + "'", MyConnection)
        adapter = New SqlDataAdapter(command)
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        If DataGridView1.RowCount > 0 Then
            total2 = total2 + DataGridView1.Rows(0).Cells(0).Value
        End If


        totalall2 = totalall2 + total2

        list2.Add(x2, total2)
        x2 = x2 + 1

        Label13.Text = totalall.ToString("N0")
        Label12.Text = totalall1.ToString("N0")
        Label11.Text = totalall2.ToString("N0")

        Dim akhir As Double = 0
        akhir = totalall1 + totalall2 - totalall
        Label26.Text = akhir.ToString("N0")


        ' Generate a red bar with "Curve 1" in the legend
        Dim myBar As BarItem = myPane.AddBar("Hutang", list, Color.Red)
        myBar.Bar.Fill = New Fill(Color.Red, Color.White, Color.Red)

        ' Generate a blue bar with "Curve 2" in the legend
        myBar = myPane.AddBar("Aset", list1, Color.Blue)
        myBar.Bar.Fill = New Fill(Color.Blue, Color.White, Color.Blue)

        ' Generate a green bar with "Curve 3" in the legend
        myBar = myPane.AddBar("BANK", list2, Color.Green)
        myBar.Bar.Fill = New Fill(Color.Green, Color.White, Color.Green)


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
    End Sub

    Private Sub AsetMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Top = -200
        Button1.PerformClick()
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = CStr(CInt(Label2.Text) - 1)
        If Label2.Text = 0 Then
            Label2.Text = "Refreshing"
            Button1.PerformClick()
            Label2.Text = 30
        End If
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class