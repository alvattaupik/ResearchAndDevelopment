Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph

Public Class MarginStore
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

    Private Sub MarginStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.AutoScroll = True
        Panel1.HorizontalScroll.Visible = True
        Panel1.VerticalScroll.Visible = True

        ComboBox2.Items.Clear()
        Koneksi()
        MyCommand3 = New SqlDataAdapter("select ItmsGrpNam from oitb order by ItmsGrpNam", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand3.Fill(DtSet, "opch")
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = DtSet.Tables("opch").DefaultView

        For i As Integer = 0 To DataGridView1.RowCount - 1
            ComboBox2.Items.Add(DataGridView1.Rows(i).Cells(0).Value)
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DataGridView1.DataSource = Nothing
        DataGridABM.DataSource = Nothing
        DataGridABM.Rows.Clear()
        DataGridView1.Rows.Clear()

        DataGridViewAyani.DataSource = Nothing
        DataGridViewAyani.Rows.Clear()
        DataGridViewKopo.DataSource = Nothing
        DataGridViewKopo.Rows.Clear()
        DataGridViewCibiru.DataSource = Nothing
        DataGridViewCibiru.Rows.Clear()
        DataGridViewCibabat.DataSource = Nothing
        DataGridViewCibabat.Rows.Clear()
        DataGridViewGarut.DataSource = Nothing
        DataGridViewGarut.Rows.Clear()
        DataGridViewCirebon.DataSource = Nothing
        DataGridViewCirebon.Rows.Clear()
        DataGridViewSumedang.DataSource = Nothing
        DataGridViewSumedang.Rows.Clear()



        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "3"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "CBT"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "8"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "7"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "KOP"
        End If

        'PictureBox1.Visible = True
        Button1.Enabled = False
        Me.Refresh()

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        command = New SqlCommand("Lap_Margin_Rep", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "001")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table
        'table.Columns.Add("Letter", GetType(Char))
        'table.Columns.Add("Number", GetType(Integer))


        DataGridABM.ColumnCount = 17
        DataGridABM.Columns(0).HeaderText = "No Struk"
        DataGridABM.Columns(1).HeaderText = "Tgl"
        DataGridABM.Columns(2).HeaderText = "Kode Barang"
        DataGridABM.Columns(3).HeaderText = "Nama Barang"
        DataGridABM.Columns(4).HeaderText = "Stock"
        DataGridABM.Columns(5).HeaderText = "Qty"
        DataGridABM.Columns(6).HeaderText = "Satuan"
        DataGridABM.Columns(7).HeaderText = "Harga Jual"
        DataGridABM.Columns(8).HeaderText = "Discount"
        DataGridABM.Columns(9).HeaderText = "Harga Beli"
        DataGridABM.Columns(10).HeaderText = "Margin"
        DataGridABM.Columns(11).HeaderText = "Total Jual"
        DataGridABM.Columns(12).HeaderText = "Total Beli"
        DataGridABM.Columns(13).HeaderText = "Total Margin"
        DataGridABM.Columns(14).HeaderText = "Total Akhir"
        DataGridABM.Columns(15).HeaderText = "Status"
        DataGridABM.Columns(16).HeaderText = "Sales Person"

        DataGridABM.Columns(0).Width = 110
        DataGridABM.Columns(1).Width = 70
        DataGridABM.Columns(2).Width = 80
        DataGridABM.Columns(3).Width = 250
        DataGridABM.Columns(4).Width = 50
        DataGridABM.Columns(5).Width = 50
        DataGridABM.Columns(6).Width = 50
        DataGridABM.Columns(7).Width = 80
        DataGridABM.Columns(8).Width = 80
        DataGridABM.Columns(9).Width = 80
        DataGridABM.Columns(10).Width = 80
        DataGridABM.Columns(11).Width = 80
        DataGridABM.Columns(12).Width = 80
        DataGridABM.Columns(13).Width = 80
        DataGridABM.Columns(14).Width = 80
        DataGridABM.Columns(15).Width = 50
        DataGridABM.Columns(16).Width = 100

        DataGridABM.Columns(14).Visible = False

        Dim hasil As Integer = 0
        Dim hasil1 As Integer = 0
        Dim hasil2 As Integer = 0
        Dim hasil3 As Integer = 0
        Dim hasil4 As Integer = 0
        Dim hasil5 As Integer = 0
        Dim hasil6 As Integer = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridABM.RowCount = DataGridABM.RowCount + 1
            DataGridABM.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridABM.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridABM.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridABM.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridABM.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridABM.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridABM.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridABM.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridABM.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridABM.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridABM.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridABM.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridABM.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridABM.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridABM.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridABM.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridABM.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridABM.RowCount = DataGridABM.RowCount + 1
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(8).Value = hasil4
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(10).Value = hasil
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(11).Value = hasil1
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(12).Value = hasil2
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(13).Value = hasil3
        DataGridABM.Rows(DataGridABM.RowCount - 1).Cells(14).Value = hasil5

        ABM1.Text = Format(hasil4, "N0")
        ABM2.Text = Format(hasil, "N0")
        ABM3.Text = Format(hasil1, "N0")
        ABM4.Text = Format(hasil2, "N0")
        ABM5.Text = Format(hasil3, "N0")

        DataGridABM.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(13).DefaultCellStyle.Format = "N0"

        'AYANI
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "003")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewAyani.ColumnCount = 17
        DataGridViewAyani.Columns(0).HeaderText = "No Struk"
        DataGridViewAyani.Columns(1).HeaderText = "Tgl"
        DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
        DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
        DataGridViewAyani.Columns(4).HeaderText = "Stock"
        DataGridViewAyani.Columns(5).HeaderText = "Qty"
        DataGridViewAyani.Columns(6).HeaderText = "Satuan"
        DataGridViewAyani.Columns(7).HeaderText = "Harga Jual"
        DataGridViewAyani.Columns(8).HeaderText = "Discount"
        DataGridViewAyani.Columns(9).HeaderText = "Harga Beli"
        DataGridViewAyani.Columns(10).HeaderText = "Margin"
        DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
        DataGridViewAyani.Columns(12).HeaderText = "Total Beli"
        DataGridViewAyani.Columns(13).HeaderText = "Total Margin"
        DataGridViewAyani.Columns(14).HeaderText = "Total Akhir"
        DataGridViewAyani.Columns(15).HeaderText = "Status"
        DataGridViewAyani.Columns(16).HeaderText = "Sales Person"

        DataGridViewAyani.Columns(0).Width = 110
        DataGridViewAyani.Columns(1).Width = 70
        DataGridViewAyani.Columns(2).Width = 80
        DataGridViewAyani.Columns(3).Width = 250
        DataGridViewAyani.Columns(4).Width = 50
        DataGridViewAyani.Columns(5).Width = 50
        DataGridViewAyani.Columns(6).Width = 50
        DataGridViewAyani.Columns(7).Width = 80
        DataGridViewAyani.Columns(8).Width = 80
        DataGridViewAyani.Columns(9).Width = 80
        DataGridViewAyani.Columns(10).Width = 80
        DataGridViewAyani.Columns(11).Width = 80
        DataGridViewAyani.Columns(12).Width = 80
        DataGridViewAyani.Columns(13).Width = 80
        DataGridViewAyani.Columns(14).Width = 50
        DataGridViewAyani.Columns(15).Width = 50
        DataGridViewAyani.Columns(16).Width = 100

       

        DataGridViewAyani.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewAyani.RowCount = DataGridViewAyani.RowCount + 1
            DataGridViewAyani.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewAyani.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewAyani.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewAyani.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewAyani.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewAyani.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewAyani.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewAyani.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewAyani.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewAyani.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewAyani.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewAyani.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewAyani.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewAyani.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewAyani.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewAyani.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewAyani.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridViewAyani.RowCount = DataGridViewAyani.RowCount + 1
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(10).Value = hasil
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewAyani.Rows(DataGridViewAyani.RowCount - 1).Cells(14).Value = hasil5

        Ayani1.Text = Format(hasil4, "N0")
        Ayani2.Text = Format(hasil, "N0")
        Ayani3.Text = Format(hasil1, "N0")
        Ayani4.Text = Format(hasil2, "N0")
        Ayani5.Text = Format(hasil3, "N0")

        DataGridViewAyani.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height


        'GARUT
        command = New SqlCommand("Lap_Margin_Rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "007")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewGarut.ColumnCount = 17
        DataGridViewGarut.Columns(0).HeaderText = "No Struk"
        DataGridViewGarut.Columns(1).HeaderText = "Tgl"
        DataGridViewGarut.Columns(2).HeaderText = "Kode Barang"
        DataGridViewGarut.Columns(3).HeaderText = "Nama Barang"
        DataGridViewGarut.Columns(4).HeaderText = "Stock"
        DataGridViewGarut.Columns(5).HeaderText = "Qty"
        DataGridViewGarut.Columns(6).HeaderText = "Satuan"
        DataGridViewGarut.Columns(7).HeaderText = "Harga Jual"
        DataGridViewGarut.Columns(8).HeaderText = "Discount"
        DataGridViewGarut.Columns(9).HeaderText = "Harga Beli"
        DataGridViewGarut.Columns(10).HeaderText = "Margin"
        DataGridViewGarut.Columns(11).HeaderText = "Total Jual"
        DataGridViewGarut.Columns(12).HeaderText = "Total Beli"
        DataGridViewGarut.Columns(13).HeaderText = "Total Margin"
        DataGridViewGarut.Columns(14).HeaderText = "Total Akhir"
        DataGridViewGarut.Columns(15).HeaderText = "Status"
        DataGridViewGarut.Columns(16).HeaderText = "Sales Person"

        DataGridViewGarut.Columns(0).Width = 110
        DataGridViewGarut.Columns(1).Width = 70
        DataGridViewGarut.Columns(2).Width = 80
        DataGridViewGarut.Columns(3).Width = 250
        DataGridViewGarut.Columns(4).Width = 50
        DataGridViewGarut.Columns(5).Width = 50
        DataGridViewGarut.Columns(6).Width = 50
        DataGridViewGarut.Columns(7).Width = 80
        DataGridViewGarut.Columns(8).Width = 80
        DataGridViewGarut.Columns(9).Width = 80
        DataGridViewGarut.Columns(10).Width = 80
        DataGridViewGarut.Columns(11).Width = 80
        DataGridViewGarut.Columns(12).Width = 80
        DataGridViewGarut.Columns(13).Width = 80
        DataGridViewGarut.Columns(14).Width = 50
        DataGridViewGarut.Columns(15).Width = 50
        DataGridViewGarut.Columns(16).Width = 100


        DataGridViewGarut.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewGarut.RowCount = DataGridViewGarut.RowCount + 1
            DataGridViewGarut.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewGarut.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewGarut.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewGarut.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewGarut.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewGarut.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewGarut.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewGarut.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewGarut.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewGarut.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewGarut.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewGarut.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewGarut.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewGarut.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewGarut.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewGarut.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewGarut.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridViewGarut.RowCount = DataGridViewGarut.RowCount + 1
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(10).Value = hasil
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewGarut.Rows(DataGridViewGarut.RowCount - 1).Cells(14).Value = hasil5

        Garut1.Text = Format(hasil4, "N0")
        Garut2.Text = Format(hasil, "N0")
        Garut3.Text = Format(hasil1, "N0")
        Garut4.Text = Format(hasil2, "N0")
        Garut5.Text = Format(hasil3, "N0")

        DataGridViewGarut.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height


        'CIREBON
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "008")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCirebon.ColumnCount = 17
        DataGridViewCirebon.Columns(0).HeaderText = "No Struk"
        DataGridViewCirebon.Columns(1).HeaderText = "Tgl"
        DataGridViewCirebon.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCirebon.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCirebon.Columns(4).HeaderText = "Stock"
        DataGridViewCirebon.Columns(5).HeaderText = "Qty"
        DataGridViewCirebon.Columns(6).HeaderText = "Satuan"
        DataGridViewCirebon.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCirebon.Columns(8).HeaderText = "Discount"
        DataGridViewCirebon.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCirebon.Columns(10).HeaderText = "Margin"
        DataGridViewCirebon.Columns(11).HeaderText = "Total Jual"
        DataGridViewCirebon.Columns(12).HeaderText = "Total Beli"
        DataGridViewCirebon.Columns(13).HeaderText = "Total Margin"
        DataGridViewCirebon.Columns(14).HeaderText = "Total Akhir"
        DataGridViewCirebon.Columns(15).HeaderText = "Status"
        DataGridViewCirebon.Columns(16).HeaderText = "Sales Person"

        DataGridViewCirebon.Columns(0).Width = 110
        DataGridViewCirebon.Columns(1).Width = 70
        DataGridViewCirebon.Columns(2).Width = 80
        DataGridViewCirebon.Columns(3).Width = 250
        DataGridViewCirebon.Columns(4).Width = 50
        DataGridViewCirebon.Columns(5).Width = 50
        DataGridViewCirebon.Columns(6).Width = 50
        DataGridViewCirebon.Columns(7).Width = 80
        DataGridViewCirebon.Columns(8).Width = 80
        DataGridViewCirebon.Columns(9).Width = 80
        DataGridViewCirebon.Columns(10).Width = 80
        DataGridViewCirebon.Columns(11).Width = 80
        DataGridViewCirebon.Columns(12).Width = 80
        DataGridViewCirebon.Columns(13).Width = 80
        DataGridViewCirebon.Columns(14).Width = 50
        DataGridViewCirebon.Columns(15).Width = 50
        DataGridViewCirebon.Columns(16).Width = 100


        DataGridViewCirebon.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCirebon.RowCount = DataGridViewCirebon.RowCount + 1
            DataGridViewCirebon.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCirebon.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewCirebon.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewCirebon.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewCirebon.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewCirebon.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewCirebon.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewCirebon.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewCirebon.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewCirebon.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewCirebon.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewCirebon.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewCirebon.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCirebon.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCirebon.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewCirebon.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewCirebon.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value
        Next

        DataGridViewCirebon.RowCount = DataGridViewCirebon.RowCount + 1
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(10).Value = hasil
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewCirebon.Rows(DataGridViewCirebon.RowCount - 1).Cells(14).Value = hasil5

        Cirebon1.Text = Format(hasil4, "N0")
        Cirebon2.Text = Format(hasil, "N0")
        Cirebon3.Text = Format(hasil1, "N0")
        Cirebon4.Text = Format(hasil2, "N0")
        Cirebon5.Text = Format(hasil3, "N0")

        DataGridViewCirebon.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height


        'KOPO
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "005")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewKopo.ColumnCount = 17
        DataGridViewKopo.Columns(0).HeaderText = "No Struk"
        DataGridViewKopo.Columns(1).HeaderText = "Tgl"
        DataGridViewKopo.Columns(2).HeaderText = "Kode Barang"
        DataGridViewKopo.Columns(3).HeaderText = "Nama Barang"
        DataGridViewKopo.Columns(4).HeaderText = "Stock"
        DataGridViewKopo.Columns(5).HeaderText = "Qty"
        DataGridViewKopo.Columns(6).HeaderText = "Satuan"
        DataGridViewKopo.Columns(7).HeaderText = "Harga Jual"
        DataGridViewKopo.Columns(8).HeaderText = "Discount"
        DataGridViewKopo.Columns(9).HeaderText = "Harga Beli"
        DataGridViewKopo.Columns(10).HeaderText = "Margin"
        DataGridViewKopo.Columns(11).HeaderText = "Total Jual"
        DataGridViewKopo.Columns(12).HeaderText = "Total Beli"
        DataGridViewKopo.Columns(13).HeaderText = "Total Margin"
        DataGridViewKopo.Columns(14).HeaderText = "Total Akhir"
        DataGridViewKopo.Columns(15).HeaderText = "Status"
        DataGridViewKopo.Columns(16).HeaderText = "Sales Person"

        DataGridViewKopo.Columns(0).Width = 110
        DataGridViewKopo.Columns(1).Width = 70
        DataGridViewKopo.Columns(2).Width = 80
        DataGridViewKopo.Columns(3).Width = 250
        DataGridViewKopo.Columns(4).Width = 50
        DataGridViewKopo.Columns(5).Width = 50
        DataGridViewKopo.Columns(6).Width = 50
        DataGridViewKopo.Columns(7).Width = 80
        DataGridViewKopo.Columns(8).Width = 80
        DataGridViewKopo.Columns(9).Width = 80
        DataGridViewKopo.Columns(10).Width = 80
        DataGridViewKopo.Columns(11).Width = 80
        DataGridViewKopo.Columns(12).Width = 80
        DataGridViewKopo.Columns(13).Width = 80
        DataGridViewKopo.Columns(14).Width = 50
        DataGridViewKopo.Columns(15).Width = 50
        DataGridViewKopo.Columns(16).Width = 100

        DataGridViewKopo.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewKopo.RowCount = DataGridViewKopo.RowCount + 1
            DataGridViewKopo.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewKopo.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewKopo.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewKopo.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewKopo.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewKopo.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewKopo.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewKopo.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewKopo.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewKopo.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewKopo.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewKopo.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewKopo.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewKopo.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewKopo.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewKopo.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewKopo.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridViewKopo.RowCount = DataGridViewKopo.RowCount + 1
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(10).Value = hasil
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(14).Value = hasil5

        Kopo1.Text = Format(hasil4, "N0")
        Kopo2.Text = Format(hasil, "N0")
        Kopo3.Text = Format(hasil1, "N0")
        Kopo4.Text = Format(hasil2, "N0")
        Kopo5.Text = Format(hasil3, "N0")

        DataGridViewKopo.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height

        'CIBABAT
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "004")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCibabat.ColumnCount = 17
        DataGridViewCibabat.Columns(0).HeaderText = "No Struk"
        DataGridViewCibabat.Columns(1).HeaderText = "Tgl"
        DataGridViewCibabat.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibabat.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibabat.Columns(4).HeaderText = "Stock"
        DataGridViewCibabat.Columns(5).HeaderText = "Qty"
        DataGridViewCibabat.Columns(6).HeaderText = "Satuan"
        DataGridViewCibabat.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCibabat.Columns(8).HeaderText = "Discount"
        DataGridViewCibabat.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCibabat.Columns(10).HeaderText = "Margin"
        DataGridViewCibabat.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibabat.Columns(12).HeaderText = "Total Beli"
        DataGridViewCibabat.Columns(13).HeaderText = "Total Margin"
        DataGridViewCibabat.Columns(14).HeaderText = "Total Akhir"
        DataGridViewCibabat.Columns(15).HeaderText = "Status"
        DataGridViewCibabat.Columns(16).HeaderText = "Sales Person"

        DataGridViewCibabat.Columns(0).Width = 110
        DataGridViewCibabat.Columns(1).Width = 70
        DataGridViewCibabat.Columns(2).Width = 80
        DataGridViewCibabat.Columns(3).Width = 250
        DataGridViewCibabat.Columns(4).Width = 50
        DataGridViewCibabat.Columns(5).Width = 50
        DataGridViewCibabat.Columns(6).Width = 50
        DataGridViewCibabat.Columns(7).Width = 80
        DataGridViewCibabat.Columns(8).Width = 80
        DataGridViewCibabat.Columns(9).Width = 80
        DataGridViewCibabat.Columns(10).Width = 80
        DataGridViewCibabat.Columns(11).Width = 80
        DataGridViewCibabat.Columns(12).Width = 80
        DataGridViewCibabat.Columns(13).Width = 80
        DataGridViewCibabat.Columns(14).Width = 50
        DataGridViewCibabat.Columns(15).Width = 50
        DataGridViewCibabat.Columns(16).Width = 100

        DataGridViewCibabat.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCibabat.RowCount = DataGridViewCibabat.RowCount + 1
            DataGridViewCibabat.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCibabat.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewCibabat.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewCibabat.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewCibabat.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewCibabat.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewCibabat.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewCibabat.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewCibabat.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewCibabat.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewCibabat.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewCibabat.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewCibabat.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCibabat.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCibabat.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewCibabat.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewCibabat.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridViewCibabat.RowCount = DataGridViewCibabat.RowCount + 1
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(10).Value = hasil
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewCibabat.Rows(DataGridViewCibabat.RowCount - 1).Cells(14).Value = hasil5

        Cibabat1.Text = Format(hasil4, "N0")
        Cibabat2.Text = Format(hasil, "N0")
        Cibabat3.Text = Format(hasil1, "N0")
        Cibabat4.Text = Format(hasil2, "N0")
        Cibabat5.Text = Format(hasil3, "N0")

        DataGridViewCibabat.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height

        'Cibiru
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "006")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCibiru.ColumnCount = 17
        DataGridViewCibiru.Columns(0).HeaderText = "No Struk"
        DataGridViewCibiru.Columns(1).HeaderText = "Tgl"
        DataGridViewCibiru.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibiru.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibiru.Columns(4).HeaderText = "Stock"
        DataGridViewCibiru.Columns(5).HeaderText = "Qty"
        DataGridViewCibiru.Columns(6).HeaderText = "Satuan"
        DataGridViewCibiru.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCibiru.Columns(8).HeaderText = "Discount"
        DataGridViewCibiru.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCibiru.Columns(10).HeaderText = "Margin"
        DataGridViewCibiru.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibiru.Columns(12).HeaderText = "Total Beli"
        DataGridViewCibiru.Columns(13).HeaderText = "Total Margin"
        DataGridViewCibiru.Columns(14).HeaderText = "Total Akhir"
        DataGridViewCibiru.Columns(15).HeaderText = "Status"
        DataGridViewCibiru.Columns(16).HeaderText = "Sales Person"

        DataGridViewCibiru.Columns(0).Width = 110
        DataGridViewCibiru.Columns(1).Width = 70
        DataGridViewCibiru.Columns(2).Width = 80
        DataGridViewCibiru.Columns(3).Width = 250
        DataGridViewCibiru.Columns(4).Width = 50
        DataGridViewCibiru.Columns(5).Width = 50
        DataGridViewCibiru.Columns(6).Width = 50
        DataGridViewCibiru.Columns(7).Width = 80
        DataGridViewCibiru.Columns(8).Width = 80
        DataGridViewCibiru.Columns(9).Width = 80
        DataGridViewCibiru.Columns(10).Width = 80
        DataGridViewCibiru.Columns(11).Width = 80
        DataGridViewCibiru.Columns(12).Width = 80
        DataGridViewCibiru.Columns(13).Width = 80
        DataGridViewCibiru.Columns(14).Width = 50
        DataGridViewCibiru.Columns(15).Width = 50
        DataGridViewCibiru.Columns(16).Width = 100

        DataGridViewCibiru.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCibiru.RowCount = DataGridViewCibiru.RowCount + 1
            DataGridViewCibiru.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCibiru.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewCibiru.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewCibiru.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewCibiru.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewCibiru.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewCibiru.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewCibiru.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewCibiru.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewCibiru.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewCibiru.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewCibiru.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewCibiru.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCibiru.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCibiru.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewCibiru.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewCibiru.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value

        Next

        DataGridViewCibiru.RowCount = DataGridViewCibiru.RowCount + 1
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(10).Value = hasil
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(14).Value = hasil5

        Cibiru1.Text = Format(hasil4, "N0")
        Cibiru2.Text = Format(hasil, "N0")
        Cibiru3.Text = Format(hasil1, "N0")
        Cibiru4.Text = Format(hasil2, "N0")
        Cibiru5.Text = Format(hasil3, "N0")

        DataGridViewCibiru.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height


        'SUMEDANG
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "009")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewSumedang.ColumnCount = 17
        DataGridViewSumedang.Columns(0).HeaderText = "No Struk"
        DataGridViewSumedang.Columns(1).HeaderText = "Tgl"
        DataGridViewSumedang.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSumedang.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSumedang.Columns(4).HeaderText = "Stock"
        DataGridViewSumedang.Columns(5).HeaderText = "Qty"
        DataGridViewSumedang.Columns(6).HeaderText = "Satuan"
        DataGridViewSumedang.Columns(7).HeaderText = "Harga Jual"
        DataGridViewSumedang.Columns(8).HeaderText = "Discount"
        DataGridViewSumedang.Columns(9).HeaderText = "Harga Beli"
        DataGridViewSumedang.Columns(10).HeaderText = "Margin"
        DataGridViewSumedang.Columns(11).HeaderText = "Total Jual"
        DataGridViewSumedang.Columns(12).HeaderText = "Total Beli"
        DataGridViewSumedang.Columns(13).HeaderText = "Total Margin"
        DataGridViewSumedang.Columns(14).HeaderText = "Total Akhir"
        DataGridViewSumedang.Columns(15).HeaderText = "Status"
        DataGridViewSumedang.Columns(16).HeaderText = "Sales Person"

        DataGridViewSumedang.Columns(0).Width = 110
        DataGridViewSumedang.Columns(1).Width = 70
        DataGridViewSumedang.Columns(2).Width = 80
        DataGridViewSumedang.Columns(3).Width = 250
        DataGridViewSumedang.Columns(4).Width = 50
        DataGridViewSumedang.Columns(5).Width = 50
        DataGridViewSumedang.Columns(6).Width = 50
        DataGridViewSumedang.Columns(7).Width = 80
        DataGridViewSumedang.Columns(8).Width = 80
        DataGridViewSumedang.Columns(9).Width = 80
        DataGridViewSumedang.Columns(10).Width = 80
        DataGridViewSumedang.Columns(11).Width = 80
        DataGridViewSumedang.Columns(12).Width = 80
        DataGridViewSumedang.Columns(13).Width = 80
        DataGridViewSumedang.Columns(14).Width = 50
        DataGridViewSumedang.Columns(15).Width = 50
        DataGridViewSumedang.Columns(16).Width = 100


        DataGridViewSumedang.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewSumedang.RowCount = DataGridViewSumedang.RowCount + 1
            DataGridViewSumedang.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewSumedang.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewSumedang.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewSumedang.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewSumedang.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewSumedang.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewSumedang.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewSumedang.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewSumedang.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewSumedang.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewSumedang.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewSumedang.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewSumedang.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewSumedang.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewSumedang.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewSumedang.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewSumedang.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value
        Next

        DataGridViewSumedang.RowCount = DataGridViewSumedang.RowCount + 1
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(10).Value = hasil
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewSumedang.Rows(DataGridViewSumedang.RowCount - 1).Cells(14).Value = hasil5

        Sumedang1.Text = Format(hasil4, "N0")
        Sumedang2.Text = Format(hasil, "N0")
        Sumedang3.Text = Format(hasil1, "N0")
        Sumedang4.Text = Format(hasil2, "N0")
        Sumedang5.Text = Format(hasil3, "N0")

        DataGridViewSumedang.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height



        'CIPARAY
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "010")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCiparay.ColumnCount = 17
        DataGridViewCiparay.Columns(0).HeaderText = "No Struk"
        DataGridViewCiparay.Columns(1).HeaderText = "Tgl"
        DataGridViewCiparay.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCiparay.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCiparay.Columns(4).HeaderText = "Stock"
        DataGridViewCiparay.Columns(5).HeaderText = "Qty"
        DataGridViewCiparay.Columns(6).HeaderText = "Satuan"
        DataGridViewCiparay.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCiparay.Columns(8).HeaderText = "Discount"
        DataGridViewCiparay.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCiparay.Columns(10).HeaderText = "Margin"
        DataGridViewCiparay.Columns(11).HeaderText = "Total Jual"
        DataGridViewCiparay.Columns(12).HeaderText = "Total Beli"
        DataGridViewCiparay.Columns(13).HeaderText = "Total Margin"
        DataGridViewCiparay.Columns(14).HeaderText = "Total Akhir"
        DataGridViewCiparay.Columns(15).HeaderText = "Status"
        DataGridViewCiparay.Columns(16).HeaderText = "Sales Person"

        DataGridViewCiparay.Columns(0).Width = 110
        DataGridViewCiparay.Columns(1).Width = 70
        DataGridViewCiparay.Columns(2).Width = 80
        DataGridViewCiparay.Columns(3).Width = 250
        DataGridViewCiparay.Columns(4).Width = 50
        DataGridViewCiparay.Columns(5).Width = 50
        DataGridViewCiparay.Columns(6).Width = 50
        DataGridViewCiparay.Columns(7).Width = 80
        DataGridViewCiparay.Columns(8).Width = 80
        DataGridViewCiparay.Columns(9).Width = 80
        DataGridViewCiparay.Columns(10).Width = 80
        DataGridViewCiparay.Columns(11).Width = 80
        DataGridViewCiparay.Columns(12).Width = 80
        DataGridViewCiparay.Columns(13).Width = 80
        DataGridViewCiparay.Columns(14).Width = 50
        DataGridViewCiparay.Columns(15).Width = 50
        DataGridViewCiparay.Columns(16).Width = 100


        DataGridViewCiparay.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCiparay.RowCount = DataGridViewCiparay.RowCount + 1
            DataGridViewCiparay.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCiparay.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewCiparay.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewCiparay.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewCiparay.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewCiparay.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewCiparay.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewCiparay.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewCiparay.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewCiparay.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewCiparay.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewCiparay.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewCiparay.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCiparay.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewCiparay.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewCiparay.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewCiparay.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value
        Next

        DataGridViewCiparay.RowCount = DataGridViewCiparay.RowCount + 1
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(10).Value = hasil
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewCiparay.Rows(DataGridViewCiparay.RowCount - 1).Cells(14).Value = hasil5

        Ciparay1.Text = Format(hasil4, "N0")
        Ciparay2.Text = Format(hasil, "N0")
        Ciparay3.Text = Format(hasil1, "N0")
        Ciparay4.Text = Format(hasil2, "N0")
        Ciparay5.Text = Format(hasil3, "N0")

        DataGridViewCiparay.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height

        'RANCAEKEK
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "011")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewRancaekek.ColumnCount = 17
        DataGridViewRancaekek.Columns(0).HeaderText = "No Struk"
        DataGridViewRancaekek.Columns(1).HeaderText = "Tgl"
        DataGridViewRancaekek.Columns(2).HeaderText = "Kode Barang"
        DataGridViewRancaekek.Columns(3).HeaderText = "Nama Barang"
        DataGridViewRancaekek.Columns(4).HeaderText = "Stock"
        DataGridViewRancaekek.Columns(5).HeaderText = "Qty"
        DataGridViewRancaekek.Columns(6).HeaderText = "Satuan"
        DataGridViewRancaekek.Columns(7).HeaderText = "Harga Jual"
        DataGridViewRancaekek.Columns(8).HeaderText = "Discount"
        DataGridViewRancaekek.Columns(9).HeaderText = "Harga Beli"
        DataGridViewRancaekek.Columns(10).HeaderText = "Margin"
        DataGridViewRancaekek.Columns(11).HeaderText = "Total Jual"
        DataGridViewRancaekek.Columns(12).HeaderText = "Total Beli"
        DataGridViewRancaekek.Columns(13).HeaderText = "Total Margin"
        DataGridViewRancaekek.Columns(14).HeaderText = "Total Akhir"
        DataGridViewRancaekek.Columns(15).HeaderText = "Status"
        DataGridViewRancaekek.Columns(16).HeaderText = "Sales Person"

        DataGridViewRancaekek.Columns(0).Width = 110
        DataGridViewRancaekek.Columns(1).Width = 70
        DataGridViewRancaekek.Columns(2).Width = 80
        DataGridViewRancaekek.Columns(3).Width = 250
        DataGridViewRancaekek.Columns(4).Width = 50
        DataGridViewRancaekek.Columns(5).Width = 50
        DataGridViewRancaekek.Columns(6).Width = 50
        DataGridViewRancaekek.Columns(7).Width = 80
        DataGridViewRancaekek.Columns(8).Width = 80
        DataGridViewRancaekek.Columns(9).Width = 80
        DataGridViewRancaekek.Columns(10).Width = 80
        DataGridViewRancaekek.Columns(11).Width = 80
        DataGridViewRancaekek.Columns(12).Width = 80
        DataGridViewRancaekek.Columns(13).Width = 80
        DataGridViewRancaekek.Columns(14).Width = 50
        DataGridViewRancaekek.Columns(15).Width = 50
        DataGridViewRancaekek.Columns(16).Width = 100


        DataGridViewRancaekek.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewRancaekek.RowCount = DataGridViewRancaekek.RowCount + 1
            DataGridViewRancaekek.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewRancaekek.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewRancaekek.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewRancaekek.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewRancaekek.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewRancaekek.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewRancaekek.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewRancaekek.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewRancaekek.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewRancaekek.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewRancaekek.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewRancaekek.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewRancaekek.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewRancaekek.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewRancaekek.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewRancaekek.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewRancaekek.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value
        Next

        DataGridViewRancaekek.RowCount = DataGridViewRancaekek.RowCount + 1
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(10).Value = hasil
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewRancaekek.Rows(DataGridViewRancaekek.RowCount - 1).Cells(14).Value = hasil5

        Rancaekek1.Text = Format(hasil4, "N0")
        Rancaekek2.Text = Format(hasil, "N0")
        Rancaekek3.Text = Format(hasil1, "N0")
        Rancaekek4.Text = Format(hasil2, "N0")
        Rancaekek5.Text = Format(hasil3, "N0")

        DataGridViewRancaekek.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(13).DefaultCellStyle.Format = "N0"
        'DataGridView2.Height = DataGridView2.Rows.Count() * DataGridView2.Rows(0).Height

        'TASIKMALAYA
        command = New SqlCommand("Lap_margin_rep", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "012")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewTASIKMALAYA.ColumnCount = 17
        DataGridViewTASIKMALAYA.Columns(0).HeaderText = "No Struk"
        DataGridViewTASIKMALAYA.Columns(1).HeaderText = "Tgl"
        DataGridViewTASIKMALAYA.Columns(2).HeaderText = "Kode Barang"
        DataGridViewTASIKMALAYA.Columns(3).HeaderText = "Nama Barang"
        DataGridViewTASIKMALAYA.Columns(4).HeaderText = "Stock"
        DataGridViewTASIKMALAYA.Columns(5).HeaderText = "Qty"
        DataGridViewTASIKMALAYA.Columns(6).HeaderText = "Satuan"
        DataGridViewTASIKMALAYA.Columns(7).HeaderText = "Harga Jual"
        DataGridViewTASIKMALAYA.Columns(8).HeaderText = "Discount"
        DataGridViewTASIKMALAYA.Columns(9).HeaderText = "Harga Beli"
        DataGridViewTASIKMALAYA.Columns(10).HeaderText = "Margin"
        DataGridViewTASIKMALAYA.Columns(11).HeaderText = "Total Jual"
        DataGridViewTASIKMALAYA.Columns(12).HeaderText = "Total Beli"
        DataGridViewTASIKMALAYA.Columns(13).HeaderText = "Total Margin"
        DataGridViewTASIKMALAYA.Columns(14).HeaderText = "Total Akhir"
        DataGridViewTASIKMALAYA.Columns(15).HeaderText = "Status"
        DataGridViewTASIKMALAYA.Columns(16).HeaderText = "Sales Person"

        DataGridViewTASIKMALAYA.Columns(0).Width = 110
        DataGridViewTASIKMALAYA.Columns(1).Width = 70
        DataGridViewTASIKMALAYA.Columns(2).Width = 80
        DataGridViewTASIKMALAYA.Columns(3).Width = 250
        DataGridViewTASIKMALAYA.Columns(4).Width = 50
        DataGridViewTASIKMALAYA.Columns(5).Width = 50
        DataGridViewTASIKMALAYA.Columns(6).Width = 50
        DataGridViewTASIKMALAYA.Columns(7).Width = 80
        DataGridViewTASIKMALAYA.Columns(8).Width = 80
        DataGridViewTASIKMALAYA.Columns(9).Width = 80
        DataGridViewTASIKMALAYA.Columns(10).Width = 80
        DataGridViewTASIKMALAYA.Columns(11).Width = 80
        DataGridViewTASIKMALAYA.Columns(12).Width = 80
        DataGridViewTASIKMALAYA.Columns(13).Width = 80
        DataGridViewTASIKMALAYA.Columns(14).Width = 50
        DataGridViewTASIKMALAYA.Columns(15).Width = 50
        DataGridViewTASIKMALAYA.Columns(16).Width = 100


        DataGridViewTASIKMALAYA.Columns(14).Visible = False

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewTASIKMALAYA.RowCount = DataGridViewTASIKMALAYA.RowCount + 1
            DataGridViewTASIKMALAYA.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(2).Value, "dd-MM-yyyy")
            DataGridViewTASIKMALAYA.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(7).Value 'stock
            DataGridViewTASIKMALAYA.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(8).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(16).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(14).Value

            DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(15).Value
            hasil4 = hasil4 + (DataGridView1.Rows(i).Cells(15).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value = DataGridView1.Rows(i).Cells(10).Value

            DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value = DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value
            hasil = hasil + (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value = (DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value)
            hasil1 = hasil1 + ((DataGridView1.Rows(i).Cells(14).Value * DataGridView1.Rows(i).Cells(8).Value) - (DataGridView1.Rows(i).Cells(15).Value * DataGridView1.Rows(i).Cells(8).Value))

            DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value = DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value
            hasil2 = hasil2 + (DataGridView1.Rows(i).Cells(10).Value * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value = (DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value
            hasil3 = hasil3 + ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(15).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(14).Value = ((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value
            hasil5 = hasil5 + (((DataGridView1.Rows(i).Cells(14).Value - DataGridView1.Rows(i).Cells(10).Value) * DataGridView1.Rows(i).Cells(8).Value) - DataGridView1.Rows(i).Cells(15).Value)
            DataGridViewTASIKMALAYA.Rows(i).Cells(15).Value = DataGridView1.Rows(i).Cells(13).Value
            DataGridViewTASIKMALAYA.Rows(i).Cells(16).Value = DataGridView1.Rows(i).Cells(18).Value
        Next

        DataGridViewTASIKMALAYA.RowCount = DataGridViewTASIKMALAYA.RowCount + 1
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(3).Value = "          TOTAL"

        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(8).Value = hasil4
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(10).Value = hasil
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(11).Value = hasil1
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(12).Value = hasil2
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(13).Value = hasil3
        DataGridViewTASIKMALAYA.Rows(DataGridViewTASIKMALAYA.RowCount - 1).Cells(14).Value = hasil5

        TASIKMALAYA1.Text = Format(hasil4, "N0")
        TASIKMALAYA2.Text = Format(hasil, "N0")
        TASIKMALAYA3.Text = Format(hasil1, "N0")
        TASIKMALAYA4.Text = Format(hasil2, "N0")
        TASIKMALAYA5.Text = Format(hasil3, "N0")

        DataGridViewTASIKMALAYA.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(13).DefaultCellStyle.Format = "N0"


        
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        CheckBox2.Checked = True
        CheckBox1.Checked = False
    End Sub

    Private Sub DataGridView2_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridABM.SortCompare
        If (e.RowIndex2 = DataGridABM.Rows.Count - 1) Then
            e.Handled = True
        End If

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tab.DrawItem
        Dim tabctl As TabControl = DirectCast(sender, TabControl)
        Dim g As Graphics = e.Graphics
        Dim font As Font = tabctl.Font
        Dim brush As New SolidBrush(Color.Black)
        Dim tabTextArea As RectangleF = RectangleF.op_Implicit(tabctl.GetTabRect(e.Index))
        If tabctl.SelectedIndex = e.Index Then
            font = New Font(font, FontStyle.Bold)
            brush = New SolidBrush(Color.Red)
        End If
        g.DrawString(tabctl.TabPages(e.Index).Text, font, brush, tabTextArea)
    End Sub


    Private Sub DataGridViewAyani_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewAyani.SortCompare
        If (e.RowIndex2 = DataGridViewAyani.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub



    Private Sub DataGridViewCibabat_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibabat.SortCompare
        If (e.RowIndex2 = DataGridViewCibabat.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub



    Private Sub DataGridViewKopo_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewKopo.SortCompare
        If (e.RowIndex2 = DataGridViewKopo.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub



    Private Sub DataGridViewCibiru_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibiru.SortCompare
        If (e.RowIndex2 = DataGridViewCibiru.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub



    Private Sub DataGridViewGarut_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewGarut.SortCompare
        If (e.RowIndex2 = DataGridViewGarut.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub



    Private Sub DataGridViewCirebon_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCirebon.SortCompare
        If (e.RowIndex2 = DataGridViewCirebon.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

 

    Private Sub DataGridViewSumedang_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewSumedang.SortCompare
        If (e.RowIndex2 = DataGridViewSumedang.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCiparay_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewSumedang.SortCompare
        If (e.RowIndex2 = DataGridViewCiparay.Rows.Count - 1) Then
            e.Handled = True
        End If
     

    End Sub

  


    Private Sub DataGridViewRancaekek_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewRancaekek.SortCompare
        If (e.RowIndex2 = DataGridViewRancaekek.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub
End Class