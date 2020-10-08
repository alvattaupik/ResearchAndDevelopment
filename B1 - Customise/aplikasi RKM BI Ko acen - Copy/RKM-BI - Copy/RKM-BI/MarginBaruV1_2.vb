Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class MarginBaruV1_2

    Public kodeBarang As String
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

    Public strNamaGrid As String
    Const DOUBLE_CLICK_SPEED As Integer = 270   'mouse DoubleClick speed
    Dim isDoubleTriggered As Boolean = False

    Dim hasil As Long = 0
    Dim hasil1 As Long = 0
    Dim hasil2 As Long = 0
    Dim hasil3 As Long = 0
    Dim hasil4 As Long = 0
    Dim hasil5 As Long = 0
    Dim hasil6 As Long = 0


    Sub Koneksi()
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.53" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=h0spit4lity#")
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

    End Sub




    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "001")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridABM.DataSource = table
        DataGridABM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'DataGridABM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridABM.AutoResizeColumns()



        'DataGridABM.Columns(0).HeaderText = "No Struk"
        'DataGridABM.Columns(1).HeaderText = "Tgl"
        'DataGridABM.Columns(2).HeaderText = "Kode Barang"
        'DataGridABM.Columns(3).HeaderText = "Nama Barang"
        'DataGridABM.Columns(4).HeaderText = "Satuan"
        'DataGridABM.Columns(5).HeaderText = "Stock"
        'DataGridABM.Columns(6).HeaderText = "Qty"
        'DataGridABM.Columns(7).HeaderText = "Harga Beli"
        'DataGridABM.Columns(8).HeaderText = "Harga Jual"
        'DataGridABM.Columns(9).HeaderText = "Margin"
        'DataGridABM.Columns(10).HeaderText = "Total Beli"
        'DataGridABM.Columns(11).HeaderText = "Total Jual"
        'DataGridABM.Columns(12).HeaderText = "Total Margin"
        'DataGridABM.Columns(13).HeaderText = "Status"
        'DataGridABM.Columns(14).HeaderText = "Sales Person"

        'DataGridABM.Columns(0).Width = 110
        'DataGridABM.Columns(1).Width = 70
        'DataGridABM.Columns(2).Width = 80
        'DataGridABM.Columns(3).Width = 250
        'DataGridABM.Columns(4).Width = 50
        'DataGridABM.Columns(5).Width = 50
        'DataGridABM.Columns(6).Width = 50
        'DataGridABM.Columns(7).Width = 80
        'DataGridABM.Columns(8).Width = 80
        'DataGridABM.Columns(9).Width = 80
        'DataGridABM.Columns(10).Width = 80
        'DataGridABM.Columns(11).Width = 80
        'DataGridABM.Columns(12).Width = 80
        'DataGridABM.Columns(13).Width = 80
        'DataGridABM.Columns(14).Width = 80


        'Dim hasil As Long = 0
        'Dim hasil1 As Long = 0
        'Dim hasil2 As Long = 0
        'Dim hasil3 As Long = 0
        'Dim hasil4 As Long = 0
        'Dim hasil5 As Long = 0
        'Dim hasil6 As Long = 0


        Dim LongMargin As Long = 0
        Dim LongTotalJual As Long = 0
        Dim LongTotalBeli As Long = 0
        Dim LongTotalMargin As Long = 0


        For i = 0 To DataGridABM.RowCount - 1
            DataGridABM.Rows(i).Cells(0).Value = DataGridABM.Rows(i).Cells(0).Value 'No struk
            DataGridABM.Rows(i).Cells(1).Value = Format(DataGridABM.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridABM.Rows(i).Cells(2).Value = DataGridABM.Rows(i).Cells(2).Value 'Kode barang
            DataGridABM.Rows(i).Cells(3).Value = DataGridABM.Rows(i).Cells(3).Value 'nama baarang
            DataGridABM.Rows(i).Cells(4).Value = DataGridABM.Rows(i).Cells(4).Value 'satuan
            DataGridABM.Rows(i).Cells(5).Value = DataGridABM.Rows(i).Cells(5).Value 'stock
            DataGridABM.Rows(i).Cells(6).Value = DataGridABM.Rows(i).Cells(6).Value 'Qty

            DataGridABM.Rows(i).Cells(7).Value = DataGridABM.Rows(i).Cells(7).Value 'Harga beli
            DataGridABM.Rows(i).Cells(8).Value = DataGridABM.Rows(i).Cells(8).Value 'Harga jual

            DataGridABM.Rows(i).Cells(9).Value = DataGridABM.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridABM.Rows(i).Cells(9).Value


            DataGridABM.Rows(i).Cells(10).Value = DataGridABM.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridABM.Rows(i).Cells(10).Value

            DataGridABM.Rows(i).Cells(11).Value = DataGridABM.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridABM.Rows(i).Cells(11).Value

            DataGridABM.Rows(i).Cells(12).Value = DataGridABM.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridABM.Rows(i).Cells(12).Value

            DataGridABM.Rows(i).Cells(13).Value = DataGridABM.Rows(i).Cells(13).Value 'status
            DataGridABM.Rows(i).Cells(14).Value = DataGridABM.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualABM.Text = Format(LongTotalJual, "N0")
        txtTotalBeliABM.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginABM.Text = Format(LongTotalMargin, "N0")

        DataGridABM.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridABM.Columns(12).DefaultCellStyle.Format = "N0"














        'AYANI
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "003")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewAyani.DataSource = table
        DataGridViewAyani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'DataGridViewAyani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewAyani.AutoResizeColumns()
        'DataGridViewAyani.Columns(0).HeaderText = "No Struk"
        'DataGridViewAyani.Columns(1).HeaderText = "Tgl"
        'DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewAyani.Columns(4).HeaderText = "Satuan"
        'DataGridViewAyani.Columns(5).HeaderText = "Stock"
        'DataGridViewAyani.Columns(6).HeaderText = "Qty"
        'DataGridViewAyani.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewAyani.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewAyani.Columns(9).HeaderText = "Margin"
        'DataGridViewAyani.Columns(10).HeaderText = "Total Beli"
        'DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
        'DataGridViewAyani.Columns(12).HeaderText = "Total Margin"
        'DataGridViewAyani.Columns(13).HeaderText = "Status"
        'DataGridViewAyani.Columns(14).HeaderText = "Sales Person"

        'DataGridViewAyani.Columns(0).Width = 110
        'DataGridViewAyani.Columns(1).Width = 70
        'DataGridViewAyani.Columns(2).Width = 80
        'DataGridViewAyani.Columns(3).Width = 250
        'DataGridViewAyani.Columns(4).Width = 50
        'DataGridViewAyani.Columns(5).Width = 50
        'DataGridViewAyani.Columns(6).Width = 50
        'DataGridViewAyani.Columns(7).Width = 80
        'DataGridViewAyani.Columns(8).Width = 80
        'DataGridViewAyani.Columns(9).Width = 80
        'DataGridViewAyani.Columns(10).Width = 80
        'DataGridViewAyani.Columns(11).Width = 80
        'DataGridViewAyani.Columns(12).Width = 80
        'DataGridViewAyani.Columns(13).Width = 80
        'DataGridViewAyani.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewAyani.RowCount - 1

            DataGridViewAyani.Rows(i).Cells(0).Value = DataGridViewAyani.Rows(i).Cells(0).Value 'No struk
            DataGridViewAyani.Rows(i).Cells(1).Value = Format(DataGridViewAyani.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewAyani.Rows(i).Cells(2).Value = DataGridViewAyani.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewAyani.Rows(i).Cells(3).Value = DataGridViewAyani.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewAyani.Rows(i).Cells(4).Value = DataGridViewAyani.Rows(i).Cells(4).Value 'satuan
            DataGridViewAyani.Rows(i).Cells(5).Value = DataGridViewAyani.Rows(i).Cells(5).Value 'stock
            DataGridViewAyani.Rows(i).Cells(6).Value = DataGridViewAyani.Rows(i).Cells(6).Value 'Qty
            DataGridViewAyani.Rows(i).Cells(7).Value = DataGridViewAyani.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewAyani.Rows(i).Cells(8).Value = DataGridViewAyani.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewAyani.Rows(i).Cells(9).Value = DataGridViewAyani.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewAyani.Rows(i).Cells(9).Value

            DataGridViewAyani.Rows(i).Cells(10).Value = DataGridViewAyani.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewAyani.Rows(i).Cells(10).Value

            DataGridViewAyani.Rows(i).Cells(11).Value = DataGridViewAyani.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewAyani.Rows(i).Cells(11).Value


            DataGridViewAyani.Rows(i).Cells(12).Value = DataGridViewAyani.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewAyani.Rows(i).Cells(12).Value


            DataGridViewAyani.Rows(i).Cells(13).Value = DataGridViewAyani.Rows(i).Cells(13).Value 'status
            DataGridViewAyani.Rows(i).Cells(14).Value = DataGridViewAyani.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualAyani.Text = Format(LongTotalJual, "N0")
        txtTotalBeliAyani.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginAyani.Text = Format(LongTotalMargin, "N0")


        DataGridViewAyani.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewAyani.Columns(12).DefaultCellStyle.Format = "N0"



        'CIBABAT
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "004")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCibabat.DataSource = table
        'DataGridViewCibabat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCibabat.AutoResizeColumns()


        'DataGridViewCibabat.Columns(0).HeaderText = "No Struk"
        'DataGridViewCibabat.Columns(1).HeaderText = "Tgl"
        'DataGridViewCibabat.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewCibabat.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewCibabat.Columns(4).HeaderText = "Satuan"
        'DataGridViewCibabat.Columns(5).HeaderText = "Stock"
        'DataGridViewCibabat.Columns(6).HeaderText = "Qty"
        'DataGridViewCibabat.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewCibabat.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewCibabat.Columns(9).HeaderText = "Margin"
        'DataGridViewCibabat.Columns(10).HeaderText = "Total Beli"
        'DataGridViewCibabat.Columns(11).HeaderText = "Total Jual"
        'DataGridViewCibabat.Columns(12).HeaderText = "Total Margin"
        'DataGridViewCibabat.Columns(13).HeaderText = "Status"
        'DataGridViewCibabat.Columns(14).HeaderText = "Sales Person"

        'DataGridViewCibabat.Columns(0).Width = 110
        'DataGridViewCibabat.Columns(1).Width = 70
        'DataGridViewCibabat.Columns(2).Width = 80
        'DataGridViewCibabat.Columns(3).Width = 250
        'DataGridViewCibabat.Columns(4).Width = 50
        'DataGridViewCibabat.Columns(5).Width = 50
        'DataGridViewCibabat.Columns(6).Width = 50
        'DataGridViewCibabat.Columns(7).Width = 80
        'DataGridViewCibabat.Columns(8).Width = 80
        'DataGridViewCibabat.Columns(9).Width = 80
        'DataGridViewCibabat.Columns(10).Width = 80
        'DataGridViewCibabat.Columns(11).Width = 80
        'DataGridViewCibabat.Columns(12).Width = 80
        'DataGridViewCibabat.Columns(13).Width = 80
        'DataGridViewCibabat.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewCibabat.RowCount - 1

            DataGridViewCibabat.Rows(i).Cells(0).Value = DataGridViewCibabat.Rows(i).Cells(0).Value 'No struk
            DataGridViewCibabat.Rows(i).Cells(1).Value = Format(DataGridViewCibabat.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCibabat.Rows(i).Cells(2).Value = DataGridViewCibabat.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCibabat.Rows(i).Cells(3).Value = DataGridViewCibabat.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCibabat.Rows(i).Cells(4).Value = DataGridViewCibabat.Rows(i).Cells(4).Value 'satuan
            DataGridViewCibabat.Rows(i).Cells(5).Value = DataGridViewCibabat.Rows(i).Cells(5).Value 'stock
            DataGridViewCibabat.Rows(i).Cells(6).Value = DataGridViewCibabat.Rows(i).Cells(6).Value 'Qty
            DataGridViewCibabat.Rows(i).Cells(7).Value = DataGridViewCibabat.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewCibabat.Rows(i).Cells(8).Value = DataGridViewCibabat.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewCibabat.Rows(i).Cells(9).Value = DataGridViewCibabat.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewCibabat.Rows(i).Cells(9).Value

            DataGridViewCibabat.Rows(i).Cells(10).Value = DataGridViewCibabat.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewCibabat.Rows(i).Cells(10).Value

            DataGridViewCibabat.Rows(i).Cells(11).Value = DataGridViewCibabat.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewCibabat.Rows(i).Cells(11).Value


            DataGridViewCibabat.Rows(i).Cells(12).Value = DataGridViewCibabat.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewCibabat.Rows(i).Cells(12).Value


            DataGridViewCibabat.Rows(i).Cells(13).Value = DataGridViewCibabat.Rows(i).Cells(13).Value 'status
            DataGridViewCibabat.Rows(i).Cells(14).Value = DataGridViewCibabat.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualCibabat.Text = Format(LongTotalJual, "N0")
        txtTotalBeliCibabat.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginCibabat.Text = Format(LongTotalMargin, "N0")


        DataGridViewCibabat.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(12).DefaultCellStyle.Format = "N0"


        'KOPO
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "005")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewKopo.DataSource = table
        'DataGridViewKopo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewKopo.AutoResizeColumns()


        'DataGridViewKopo.Columns(0).HeaderText = "No Struk"
        'DataGridViewKopo.Columns(1).HeaderText = "Tgl"
        'DataGridViewKopo.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewKopo.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewKopo.Columns(4).HeaderText = "Satuan"
        'DataGridViewKopo.Columns(5).HeaderText = "Stock"
        'DataGridViewKopo.Columns(6).HeaderText = "Qty"
        'DataGridViewKopo.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewKopo.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewKopo.Columns(9).HeaderText = "Margin"
        'DataGridViewKopo.Columns(10).HeaderText = "Total Beli"
        'DataGridViewKopo.Columns(11).HeaderText = "Total Jual"
        'DataGridViewKopo.Columns(12).HeaderText = "Total Margin"
        'DataGridViewKopo.Columns(13).HeaderText = "Status"
        'DataGridViewKopo.Columns(14).HeaderText = "Sales Person"

        'DataGridViewKopo.Columns(0).Width = 110
        'DataGridViewKopo.Columns(1).Width = 70
        'DataGridViewKopo.Columns(2).Width = 80
        'DataGridViewKopo.Columns(3).Width = 250
        'DataGridViewKopo.Columns(4).Width = 50
        'DataGridViewKopo.Columns(5).Width = 50
        'DataGridViewKopo.Columns(6).Width = 50
        'DataGridViewKopo.Columns(7).Width = 80
        'DataGridViewKopo.Columns(8).Width = 80
        'DataGridViewKopo.Columns(9).Width = 80
        'DataGridViewKopo.Columns(10).Width = 80
        'DataGridViewKopo.Columns(11).Width = 80
        'DataGridViewKopo.Columns(12).Width = 80
        'DataGridViewKopo.Columns(13).Width = 80
        'DataGridViewKopo.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewKopo.RowCount - 1

            DataGridViewKopo.Rows(i).Cells(0).Value = DataGridViewKopo.Rows(i).Cells(0).Value 'No struk
            DataGridViewKopo.Rows(i).Cells(1).Value = Format(DataGridViewKopo.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewKopo.Rows(i).Cells(2).Value = DataGridViewKopo.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewKopo.Rows(i).Cells(3).Value = DataGridViewKopo.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewKopo.Rows(i).Cells(4).Value = DataGridViewKopo.Rows(i).Cells(4).Value 'satuan
            DataGridViewKopo.Rows(i).Cells(5).Value = DataGridViewKopo.Rows(i).Cells(5).Value 'stock
            DataGridViewKopo.Rows(i).Cells(6).Value = DataGridViewKopo.Rows(i).Cells(6).Value 'Qty
            DataGridViewKopo.Rows(i).Cells(7).Value = DataGridViewKopo.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewKopo.Rows(i).Cells(8).Value = DataGridViewKopo.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewKopo.Rows(i).Cells(9).Value = DataGridViewKopo.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewKopo.Rows(i).Cells(9).Value

            DataGridViewKopo.Rows(i).Cells(10).Value = DataGridViewKopo.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewKopo.Rows(i).Cells(10).Value

            DataGridViewKopo.Rows(i).Cells(11).Value = DataGridViewKopo.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewKopo.Rows(i).Cells(11).Value


            DataGridViewKopo.Rows(i).Cells(12).Value = DataGridViewKopo.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewKopo.Rows(i).Cells(12).Value


            DataGridViewKopo.Rows(i).Cells(13).Value = DataGridViewKopo.Rows(i).Cells(13).Value 'status
            DataGridViewKopo.Rows(i).Cells(14).Value = DataGridViewKopo.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualKopo.Text = Format(LongTotalJual, "N0")
        txtTotalBeliKopo.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginKopo.Text = Format(LongTotalMargin, "N0")


        DataGridViewKopo.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(12).DefaultCellStyle.Format = "N0"




        'CIBIRU
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "006")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCibiru.DataSource = table
        'DataGridViewCibiru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCibiru.AutoResizeColumns()


        'DataGridViewCibiru.Columns(0).HeaderText = "No Struk"
        'DataGridViewCibiru.Columns(1).HeaderText = "Tgl"
        'DataGridViewCibiru.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewCibiru.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewCibiru.Columns(4).HeaderText = "Satuan"
        'DataGridViewCibiru.Columns(5).HeaderText = "Stock"
        'DataGridViewCibiru.Columns(6).HeaderText = "Qty"
        'DataGridViewCibiru.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewCibiru.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewCibiru.Columns(9).HeaderText = "Margin"
        'DataGridViewCibiru.Columns(10).HeaderText = "Total Beli"
        'DataGridViewCibiru.Columns(11).HeaderText = "Total Jual"
        'DataGridViewCibiru.Columns(12).HeaderText = "Total Margin"
        'DataGridViewCibiru.Columns(13).HeaderText = "Status"
        'DataGridViewCibiru.Columns(14).HeaderText = "Sales Person"

        'DataGridViewCibiru.Columns(0).Width = 110
        'DataGridViewCibiru.Columns(1).Width = 70
        'DataGridViewCibiru.Columns(2).Width = 80
        'DataGridViewCibiru.Columns(3).Width = 250
        'DataGridViewCibiru.Columns(4).Width = 50
        'DataGridViewCibiru.Columns(5).Width = 50
        'DataGridViewCibiru.Columns(6).Width = 50
        'DataGridViewCibiru.Columns(7).Width = 80
        'DataGridViewCibiru.Columns(8).Width = 80
        'DataGridViewCibiru.Columns(9).Width = 80
        'DataGridViewCibiru.Columns(10).Width = 80
        'DataGridViewCibiru.Columns(11).Width = 80
        'DataGridViewCibiru.Columns(12).Width = 80
        'DataGridViewCibiru.Columns(13).Width = 80
        'DataGridViewCibiru.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewCibiru.RowCount - 1

            DataGridViewCibiru.Rows(i).Cells(0).Value = DataGridViewCibiru.Rows(i).Cells(0).Value 'No struk
            DataGridViewCibiru.Rows(i).Cells(1).Value = Format(DataGridViewCibiru.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCibiru.Rows(i).Cells(2).Value = DataGridViewCibiru.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCibiru.Rows(i).Cells(3).Value = DataGridViewCibiru.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCibiru.Rows(i).Cells(4).Value = DataGridViewCibiru.Rows(i).Cells(4).Value 'satuan
            DataGridViewCibiru.Rows(i).Cells(5).Value = DataGridViewCibiru.Rows(i).Cells(5).Value 'stock
            DataGridViewCibiru.Rows(i).Cells(6).Value = DataGridViewCibiru.Rows(i).Cells(6).Value 'Qty
            DataGridViewCibiru.Rows(i).Cells(7).Value = DataGridViewCibiru.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewCibiru.Rows(i).Cells(8).Value = DataGridViewCibiru.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewCibiru.Rows(i).Cells(9).Value = DataGridViewCibiru.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewCibiru.Rows(i).Cells(9).Value

            DataGridViewCibiru.Rows(i).Cells(10).Value = DataGridViewCibiru.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewCibiru.Rows(i).Cells(10).Value

            DataGridViewCibiru.Rows(i).Cells(11).Value = DataGridViewCibiru.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewCibiru.Rows(i).Cells(11).Value


            DataGridViewCibiru.Rows(i).Cells(12).Value = DataGridViewCibiru.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewCibiru.Rows(i).Cells(12).Value


            DataGridViewCibiru.Rows(i).Cells(13).Value = DataGridViewCibiru.Rows(i).Cells(13).Value 'status
            DataGridViewCibiru.Rows(i).Cells(14).Value = DataGridViewCibiru.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualCibiru.Text = Format(LongTotalJual, "N0")
        txtTotalBeliCibiru.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginCibiru.Text = Format(LongTotalMargin, "N0")


        DataGridViewCibiru.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(12).DefaultCellStyle.Format = "N0"





        'GARUT
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "007")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewGarut.DataSource = table
        'DataGridViewGarut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewGarut.AutoResizeColumns()


        'DataGridViewGarut.Columns(0).HeaderText = "No Struk"
        'DataGridViewGarut.Columns(1).HeaderText = "Tgl"
        'DataGridViewGarut.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewGarut.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewGarut.Columns(4).HeaderText = "Satuan"
        'DataGridViewGarut.Columns(5).HeaderText = "Stock"
        'DataGridViewGarut.Columns(6).HeaderText = "Qty"
        'DataGridViewGarut.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewGarut.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewGarut.Columns(9).HeaderText = "Margin"
        'DataGridViewGarut.Columns(10).HeaderText = "Total Beli"
        'DataGridViewGarut.Columns(11).HeaderText = "Total Jual"
        'DataGridViewGarut.Columns(12).HeaderText = "Total Margin"
        'DataGridViewGarut.Columns(13).HeaderText = "Status"
        'DataGridViewGarut.Columns(14).HeaderText = "Sales Person"

        'DataGridViewGarut.Columns(0).Width = 110
        'DataGridViewGarut.Columns(1).Width = 70
        'DataGridViewGarut.Columns(2).Width = 80
        'DataGridViewGarut.Columns(3).Width = 250
        'DataGridViewGarut.Columns(4).Width = 50
        'DataGridViewGarut.Columns(5).Width = 50
        'DataGridViewGarut.Columns(6).Width = 50
        'DataGridViewGarut.Columns(7).Width = 80
        'DataGridViewGarut.Columns(8).Width = 80
        'DataGridViewGarut.Columns(9).Width = 80
        'DataGridViewGarut.Columns(10).Width = 80
        'DataGridViewGarut.Columns(11).Width = 80
        'DataGridViewGarut.Columns(12).Width = 80
        'DataGridViewGarut.Columns(13).Width = 80
        'DataGridViewGarut.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewGarut.RowCount - 1

            DataGridViewGarut.Rows(i).Cells(0).Value = DataGridViewGarut.Rows(i).Cells(0).Value 'No struk
            DataGridViewGarut.Rows(i).Cells(1).Value = Format(DataGridViewGarut.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewGarut.Rows(i).Cells(2).Value = DataGridViewGarut.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewGarut.Rows(i).Cells(3).Value = DataGridViewGarut.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewGarut.Rows(i).Cells(4).Value = DataGridViewGarut.Rows(i).Cells(4).Value 'satuan
            DataGridViewGarut.Rows(i).Cells(5).Value = DataGridViewGarut.Rows(i).Cells(5).Value 'stock
            DataGridViewGarut.Rows(i).Cells(6).Value = DataGridViewGarut.Rows(i).Cells(6).Value 'Qty
            DataGridViewGarut.Rows(i).Cells(7).Value = DataGridViewGarut.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewGarut.Rows(i).Cells(8).Value = DataGridViewGarut.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewGarut.Rows(i).Cells(9).Value = DataGridViewGarut.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewGarut.Rows(i).Cells(9).Value

            DataGridViewGarut.Rows(i).Cells(10).Value = DataGridViewGarut.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewGarut.Rows(i).Cells(10).Value

            DataGridViewGarut.Rows(i).Cells(11).Value = DataGridViewGarut.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewGarut.Rows(i).Cells(11).Value


            DataGridViewGarut.Rows(i).Cells(12).Value = DataGridViewGarut.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewGarut.Rows(i).Cells(12).Value


            DataGridViewGarut.Rows(i).Cells(13).Value = DataGridViewGarut.Rows(i).Cells(13).Value 'status
            DataGridViewGarut.Rows(i).Cells(14).Value = DataGridViewGarut.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualGarut.Text = Format(LongTotalJual, "N0")
        txtTotalBeligarut.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginGarut.Text = Format(LongTotalMargin, "N0")


        DataGridViewGarut.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(12).DefaultCellStyle.Format = "N0"







        'Cirebon
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "008")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCirebon.DataSource = table
        'DataGridViewCirebon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCirebon.AutoResizeColumns()

        'DataGridViewCirebon.Columns(0).HeaderText = "No Struk"
        'DataGridViewCirebon.Columns(1).HeaderText = "Tgl"
        'DataGridViewCirebon.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewCirebon.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewCirebon.Columns(4).HeaderText = "Satuan"
        'DataGridViewCirebon.Columns(5).HeaderText = "Stock"
        'DataGridViewCirebon.Columns(6).HeaderText = "Qty"
        'DataGridViewCirebon.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewCirebon.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewCirebon.Columns(9).HeaderText = "Margin"
        'DataGridViewCirebon.Columns(10).HeaderText = "Total Beli"
        'DataGridViewCirebon.Columns(11).HeaderText = "Total Jual"
        'DataGridViewCirebon.Columns(12).HeaderText = "Total Margin"
        'DataGridViewCirebon.Columns(13).HeaderText = "Status"
        'DataGridViewCirebon.Columns(14).HeaderText = "Sales Person"

        'DataGridViewCirebon.Columns(0).Width = 110
        'DataGridViewCirebon.Columns(1).Width = 70
        'DataGridViewCirebon.Columns(2).Width = 80
        'DataGridViewCirebon.Columns(3).Width = 250
        'DataGridViewCirebon.Columns(4).Width = 50
        'DataGridViewCirebon.Columns(5).Width = 50
        'DataGridViewCirebon.Columns(6).Width = 50
        'DataGridViewCirebon.Columns(7).Width = 80
        'DataGridViewCirebon.Columns(8).Width = 80
        'DataGridViewCirebon.Columns(9).Width = 80
        'DataGridViewCirebon.Columns(10).Width = 80
        'DataGridViewCirebon.Columns(11).Width = 80
        'DataGridViewCirebon.Columns(12).Width = 80
        'DataGridViewCirebon.Columns(13).Width = 80
        'DataGridViewCirebon.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewCirebon.RowCount - 1

            DataGridViewCirebon.Rows(i).Cells(0).Value = DataGridViewCirebon.Rows(i).Cells(0).Value 'No struk
            DataGridViewCirebon.Rows(i).Cells(1).Value = Format(DataGridViewCirebon.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCirebon.Rows(i).Cells(2).Value = DataGridViewCirebon.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCirebon.Rows(i).Cells(3).Value = DataGridViewCirebon.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCirebon.Rows(i).Cells(4).Value = DataGridViewCirebon.Rows(i).Cells(4).Value 'satuan
            DataGridViewCirebon.Rows(i).Cells(5).Value = DataGridViewCirebon.Rows(i).Cells(5).Value 'stock
            DataGridViewCirebon.Rows(i).Cells(6).Value = DataGridViewCirebon.Rows(i).Cells(6).Value 'Qty
            DataGridViewCirebon.Rows(i).Cells(7).Value = DataGridViewCirebon.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewCirebon.Rows(i).Cells(8).Value = DataGridViewCirebon.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewCirebon.Rows(i).Cells(9).Value = DataGridViewCirebon.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewCirebon.Rows(i).Cells(9).Value

            DataGridViewCirebon.Rows(i).Cells(10).Value = DataGridViewCirebon.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewCirebon.Rows(i).Cells(10).Value

            DataGridViewCirebon.Rows(i).Cells(11).Value = DataGridViewCirebon.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewCirebon.Rows(i).Cells(11).Value


            DataGridViewCirebon.Rows(i).Cells(12).Value = DataGridViewCirebon.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewCirebon.Rows(i).Cells(12).Value


            DataGridViewCirebon.Rows(i).Cells(13).Value = DataGridViewCirebon.Rows(i).Cells(13).Value 'status
            DataGridViewCirebon.Rows(i).Cells(14).Value = DataGridViewCirebon.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualCirebon.Text = Format(LongTotalJual, "N0")
        txtTotalBeliCirebon.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginCirebon.Text = Format(LongTotalMargin, "N0")


        DataGridViewCirebon.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(12).DefaultCellStyle.Format = "N0"



        'Sumedang
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "009")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSumedang.DataSource = table
        'DataGridViewSumedang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewSumedang.AutoResizeColumns()


        'DataGridViewSumedang.Columns(0).HeaderText = "No Struk"
        'DataGridViewSumedang.Columns(1).HeaderText = "Tgl"
        'DataGridViewSumedang.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewSumedang.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewSumedang.Columns(4).HeaderText = "Satuan"
        'DataGridViewSumedang.Columns(5).HeaderText = "Stock"
        'DataGridViewSumedang.Columns(6).HeaderText = "Qty"
        'DataGridViewSumedang.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewSumedang.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewSumedang.Columns(9).HeaderText = "Margin"
        'DataGridViewSumedang.Columns(10).HeaderText = "Total Beli"
        'DataGridViewSumedang.Columns(11).HeaderText = "Total Jual"
        'DataGridViewSumedang.Columns(12).HeaderText = "Total Margin"
        'DataGridViewSumedang.Columns(13).HeaderText = "Status"
        'DataGridViewSumedang.Columns(14).HeaderText = "Sales Person"

        'DataGridViewSumedang.Columns(0).Width = 110
        'DataGridViewSumedang.Columns(1).Width = 70
        'DataGridViewSumedang.Columns(2).Width = 80
        'DataGridViewSumedang.Columns(3).Width = 250
        'DataGridViewSumedang.Columns(4).Width = 50
        'DataGridViewSumedang.Columns(5).Width = 50
        'DataGridViewSumedang.Columns(6).Width = 50
        'DataGridViewSumedang.Columns(7).Width = 80
        'DataGridViewSumedang.Columns(8).Width = 80
        'DataGridViewSumedang.Columns(9).Width = 80
        'DataGridViewSumedang.Columns(10).Width = 80
        'DataGridViewSumedang.Columns(11).Width = 80
        'DataGridViewSumedang.Columns(12).Width = 80
        'DataGridViewSumedang.Columns(13).Width = 80
        'DataGridViewSumedang.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewSumedang.RowCount - 1

            DataGridViewSumedang.Rows(i).Cells(0).Value = DataGridViewSumedang.Rows(i).Cells(0).Value 'No struk
            DataGridViewSumedang.Rows(i).Cells(1).Value = Format(DataGridViewSumedang.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewSumedang.Rows(i).Cells(2).Value = DataGridViewSumedang.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewSumedang.Rows(i).Cells(3).Value = DataGridViewSumedang.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewSumedang.Rows(i).Cells(4).Value = DataGridViewSumedang.Rows(i).Cells(4).Value 'satuan
            DataGridViewSumedang.Rows(i).Cells(5).Value = DataGridViewSumedang.Rows(i).Cells(5).Value 'stock
            DataGridViewSumedang.Rows(i).Cells(6).Value = DataGridViewSumedang.Rows(i).Cells(6).Value 'Qty
            DataGridViewSumedang.Rows(i).Cells(7).Value = DataGridViewSumedang.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewSumedang.Rows(i).Cells(8).Value = DataGridViewSumedang.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewSumedang.Rows(i).Cells(9).Value = DataGridViewSumedang.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewSumedang.Rows(i).Cells(9).Value

            DataGridViewSumedang.Rows(i).Cells(10).Value = DataGridViewSumedang.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewSumedang.Rows(i).Cells(10).Value

            DataGridViewSumedang.Rows(i).Cells(11).Value = DataGridViewSumedang.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewSumedang.Rows(i).Cells(11).Value


            DataGridViewSumedang.Rows(i).Cells(12).Value = DataGridViewSumedang.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewSumedang.Rows(i).Cells(12).Value


            DataGridViewSumedang.Rows(i).Cells(13).Value = DataGridViewSumedang.Rows(i).Cells(13).Value 'status
            DataGridViewSumedang.Rows(i).Cells(14).Value = DataGridViewSumedang.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualSumedang.Text = Format(LongTotalJual, "N0")
        txtTotalbeliSumedang.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginSumedang.Text = Format(LongTotalMargin, "N0")


        DataGridViewSumedang.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(12).DefaultCellStyle.Format = "N0"



        'Ciparay
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "010")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCiparay.DataSource = table
        'DataGridViewCiparay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCiparay.AutoResizeColumns()


        'DataGridViewCiparay.Columns(0).HeaderText = "No Struk"
        'DataGridViewCiparay.Columns(1).HeaderText = "Tgl"
        'DataGridViewCiparay.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewCiparay.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewCiparay.Columns(4).HeaderText = "Satuan"
        'DataGridViewCiparay.Columns(5).HeaderText = "Stock"
        'DataGridViewCiparay.Columns(6).HeaderText = "Qty"
        'DataGridViewCiparay.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewCiparay.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewCiparay.Columns(9).HeaderText = "Margin"
        'DataGridViewCiparay.Columns(10).HeaderText = "Total Beli"
        'DataGridViewCiparay.Columns(11).HeaderText = "Total Jual"
        'DataGridViewCiparay.Columns(12).HeaderText = "Total Margin"
        'DataGridViewCiparay.Columns(13).HeaderText = "Status"
        'DataGridViewCiparay.Columns(14).HeaderText = "Sales Person"

        'DataGridViewCiparay.Columns(0).Width = 110
        'DataGridViewCiparay.Columns(1).Width = 70
        'DataGridViewCiparay.Columns(2).Width = 80
        'DataGridViewCiparay.Columns(3).Width = 250
        'DataGridViewCiparay.Columns(4).Width = 50
        'DataGridViewCiparay.Columns(5).Width = 50
        'DataGridViewCiparay.Columns(6).Width = 50
        'DataGridViewCiparay.Columns(7).Width = 80
        'DataGridViewCiparay.Columns(8).Width = 80
        'DataGridViewCiparay.Columns(9).Width = 80
        'DataGridViewCiparay.Columns(10).Width = 80
        'DataGridViewCiparay.Columns(11).Width = 80
        'DataGridViewCiparay.Columns(12).Width = 80
        'DataGridViewCiparay.Columns(13).Width = 80
        'DataGridViewCiparay.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewCiparay.RowCount - 1

            DataGridViewCiparay.Rows(i).Cells(0).Value = DataGridViewCiparay.Rows(i).Cells(0).Value 'No struk
            DataGridViewCiparay.Rows(i).Cells(1).Value = Format(DataGridViewCiparay.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCiparay.Rows(i).Cells(2).Value = DataGridViewCiparay.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCiparay.Rows(i).Cells(3).Value = DataGridViewCiparay.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCiparay.Rows(i).Cells(4).Value = DataGridViewCiparay.Rows(i).Cells(4).Value 'satuan
            DataGridViewCiparay.Rows(i).Cells(5).Value = DataGridViewCiparay.Rows(i).Cells(5).Value 'stock
            DataGridViewCiparay.Rows(i).Cells(6).Value = DataGridViewCiparay.Rows(i).Cells(6).Value 'Qty
            DataGridViewCiparay.Rows(i).Cells(7).Value = DataGridViewCiparay.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewCiparay.Rows(i).Cells(8).Value = DataGridViewCiparay.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewCiparay.Rows(i).Cells(9).Value = DataGridViewCiparay.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewCiparay.Rows(i).Cells(9).Value

            DataGridViewCiparay.Rows(i).Cells(10).Value = DataGridViewCiparay.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewCiparay.Rows(i).Cells(10).Value

            DataGridViewCiparay.Rows(i).Cells(11).Value = DataGridViewCiparay.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewCiparay.Rows(i).Cells(11).Value


            DataGridViewCiparay.Rows(i).Cells(12).Value = DataGridViewCiparay.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewCiparay.Rows(i).Cells(12).Value


            DataGridViewCiparay.Rows(i).Cells(13).Value = DataGridViewCiparay.Rows(i).Cells(13).Value 'status
            DataGridViewCiparay.Rows(i).Cells(14).Value = DataGridViewCiparay.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualCiparay.Text = Format(LongTotalJual, "N0")
        txtTotalBeliCiparay.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginCiparay.Text = Format(LongTotalMargin, "N0")


        DataGridViewCiparay.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(12).DefaultCellStyle.Format = "N0"




        'Rancaekek
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "011")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewRancaekek.DataSource = table
        'DataGridViewRancaekek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewRancaekek.AutoResizeColumns()

        'DataGridViewRancaekek.Columns(0).HeaderText = "No Struk"
        'DataGridViewRancaekek.Columns(1).HeaderText = "Tgl"
        'DataGridViewRancaekek.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewRancaekek.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewRancaekek.Columns(4).HeaderText = "Satuan"
        'DataGridViewRancaekek.Columns(5).HeaderText = "Stock"
        'DataGridViewRancaekek.Columns(6).HeaderText = "Qty"
        'DataGridViewRancaekek.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewRancaekek.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewRancaekek.Columns(9).HeaderText = "Margin"
        'DataGridViewRancaekek.Columns(10).HeaderText = "Total Beli"
        'DataGridViewRancaekek.Columns(11).HeaderText = "Total Jual"
        'DataGridViewRancaekek.Columns(12).HeaderText = "Total Margin"
        'DataGridViewRancaekek.Columns(13).HeaderText = "Status"
        'DataGridViewRancaekek.Columns(14).HeaderText = "Sales Person"

        'DataGridViewRancaekek.Columns(0).Width = 110
        'DataGridViewRancaekek.Columns(1).Width = 70
        'DataGridViewRancaekek.Columns(2).Width = 80
        'DataGridViewRancaekek.Columns(3).Width = 250
        'DataGridViewRancaekek.Columns(4).Width = 50
        'DataGridViewRancaekek.Columns(5).Width = 50
        'DataGridViewRancaekek.Columns(6).Width = 50
        'DataGridViewRancaekek.Columns(7).Width = 80
        'DataGridViewRancaekek.Columns(8).Width = 80
        'DataGridViewRancaekek.Columns(9).Width = 80
        'DataGridViewRancaekek.Columns(10).Width = 80
        'DataGridViewRancaekek.Columns(11).Width = 80
        'DataGridViewRancaekek.Columns(12).Width = 80
        'DataGridViewRancaekek.Columns(13).Width = 80
        'DataGridViewRancaekek.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewRancaekek.RowCount - 1

            DataGridViewRancaekek.Rows(i).Cells(0).Value = DataGridViewRancaekek.Rows(i).Cells(0).Value 'No struk
            DataGridViewRancaekek.Rows(i).Cells(1).Value = Format(DataGridViewRancaekek.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewRancaekek.Rows(i).Cells(2).Value = DataGridViewRancaekek.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewRancaekek.Rows(i).Cells(3).Value = DataGridViewRancaekek.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewRancaekek.Rows(i).Cells(4).Value = DataGridViewRancaekek.Rows(i).Cells(4).Value 'satuan
            DataGridViewRancaekek.Rows(i).Cells(5).Value = DataGridViewRancaekek.Rows(i).Cells(5).Value 'stock
            DataGridViewRancaekek.Rows(i).Cells(6).Value = DataGridViewRancaekek.Rows(i).Cells(6).Value 'Qty
            DataGridViewRancaekek.Rows(i).Cells(7).Value = DataGridViewRancaekek.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewRancaekek.Rows(i).Cells(8).Value = DataGridViewRancaekek.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewRancaekek.Rows(i).Cells(9).Value = DataGridViewRancaekek.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewRancaekek.Rows(i).Cells(9).Value

            DataGridViewRancaekek.Rows(i).Cells(10).Value = DataGridViewRancaekek.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewRancaekek.Rows(i).Cells(10).Value

            DataGridViewRancaekek.Rows(i).Cells(11).Value = DataGridViewRancaekek.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewRancaekek.Rows(i).Cells(11).Value


            DataGridViewRancaekek.Rows(i).Cells(12).Value = DataGridViewRancaekek.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewRancaekek.Rows(i).Cells(12).Value


            DataGridViewRancaekek.Rows(i).Cells(13).Value = DataGridViewRancaekek.Rows(i).Cells(13).Value 'status
            DataGridViewRancaekek.Rows(i).Cells(14).Value = DataGridViewRancaekek.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualRancaekek.Text = Format(LongTotalJual, "N0")
        txtTotalBeliRancaekek.Text = Format(LongTotalBeli, "N0")
        txtTotalmarginRancaekek.Text = Format(LongTotalMargin, "N0")


        DataGridViewRancaekek.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(12).DefaultCellStyle.Format = "N0"



        'Tasikmalaya
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "012")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewTASIKMALAYA.DataSource = table

        'DataGridViewTASIKMALAYA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewTASIKMALAYA.AutoResizeColumns()

        'DataGridViewTASIKMALAYA.Columns(0).HeaderText = "No Struk"
        'DataGridViewTASIKMALAYA.Columns(1).HeaderText = "Tgl"
        'DataGridViewTASIKMALAYA.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewTASIKMALAYA.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewTASIKMALAYA.Columns(4).HeaderText = "Satuan"
        'DataGridViewTASIKMALAYA.Columns(5).HeaderText = "Stock"
        'DataGridViewTASIKMALAYA.Columns(6).HeaderText = "Qty"
        'DataGridViewTASIKMALAYA.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewTASIKMALAYA.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewTASIKMALAYA.Columns(9).HeaderText = "Margin"
        'DataGridViewTASIKMALAYA.Columns(10).HeaderText = "Total Beli"
        'DataGridViewTASIKMALAYA.Columns(11).HeaderText = "Total Jual"
        'DataGridViewTASIKMALAYA.Columns(12).HeaderText = "Total Margin"
        'DataGridViewTASIKMALAYA.Columns(13).HeaderText = "Status"
        'DataGridViewTASIKMALAYA.Columns(14).HeaderText = "Sales Person"

        'DataGridViewTASIKMALAYA.Columns(0).Width = 110
        'DataGridViewTASIKMALAYA.Columns(1).Width = 70
        'DataGridViewTASIKMALAYA.Columns(2).Width = 80
        'DataGridViewTASIKMALAYA.Columns(3).Width = 250
        'DataGridViewTASIKMALAYA.Columns(4).Width = 50
        'DataGridViewTASIKMALAYA.Columns(5).Width = 50
        'DataGridViewTASIKMALAYA.Columns(6).Width = 50
        'DataGridViewTASIKMALAYA.Columns(7).Width = 80
        'DataGridViewTASIKMALAYA.Columns(8).Width = 80
        'DataGridViewTASIKMALAYA.Columns(9).Width = 80
        'DataGridViewTASIKMALAYA.Columns(10).Width = 80
        'DataGridViewTASIKMALAYA.Columns(11).Width = 80
        'DataGridViewTASIKMALAYA.Columns(12).Width = 80
        'DataGridViewTASIKMALAYA.Columns(13).Width = 80
        'DataGridViewTASIKMALAYA.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewTASIKMALAYA.RowCount - 1

            DataGridViewTASIKMALAYA.Rows(i).Cells(0).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(0).Value 'No struk
            DataGridViewTASIKMALAYA.Rows(i).Cells(1).Value = Format(DataGridViewTASIKMALAYA.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewTASIKMALAYA.Rows(i).Cells(2).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewTASIKMALAYA.Rows(i).Cells(3).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewTASIKMALAYA.Rows(i).Cells(4).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(4).Value 'satuan
            DataGridViewTASIKMALAYA.Rows(i).Cells(5).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(5).Value 'stock
            DataGridViewTASIKMALAYA.Rows(i).Cells(6).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(6).Value 'Qty
            DataGridViewTASIKMALAYA.Rows(i).Cells(7).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value

            DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value

            DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value


            DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value


            DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value 'status
            DataGridViewTASIKMALAYA.Rows(i).Cells(14).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualTasik.Text = Format(LongTotalJual, "N0")
        txtTotalBeliTasik.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginTasik.Text = Format(LongTotalMargin, "N0")


        DataGridViewTASIKMALAYA.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewTASIKMALAYA.Columns(12).DefaultCellStyle.Format = "N0"



        'Pamanukan
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "013")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewPAMANUKAN.DataSource = table
        'DataGridViewPAMANUKAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewPAMANUKAN.AutoResizeColumns()

        'DataGridViewPAMANUKAN.Columns(0).HeaderText = "No Struk"
        'DataGridViewPAMANUKAN.Columns(1).HeaderText = "Tgl"
        'DataGridViewPAMANUKAN.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewPAMANUKAN.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewPAMANUKAN.Columns(4).HeaderText = "Satuan"
        'DataGridViewPAMANUKAN.Columns(5).HeaderText = "Stock"
        'DataGridViewPAMANUKAN.Columns(6).HeaderText = "Qty"
        'DataGridViewPAMANUKAN.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewPAMANUKAN.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewPAMANUKAN.Columns(9).HeaderText = "Margin"
        'DataGridViewPAMANUKAN.Columns(10).HeaderText = "Total Beli"
        'DataGridViewPAMANUKAN.Columns(11).HeaderText = "Total Jual"
        'DataGridViewPAMANUKAN.Columns(12).HeaderText = "Total Margin"
        'DataGridViewPAMANUKAN.Columns(13).HeaderText = "Status"
        'DataGridViewPAMANUKAN.Columns(14).HeaderText = "Sales Person"

        'DataGridViewPAMANUKAN.Columns(0).Width = 110
        'DataGridViewPAMANUKAN.Columns(1).Width = 70
        'DataGridViewPAMANUKAN.Columns(2).Width = 80
        'DataGridViewPAMANUKAN.Columns(3).Width = 250
        'DataGridViewPAMANUKAN.Columns(4).Width = 50
        'DataGridViewPAMANUKAN.Columns(5).Width = 50
        'DataGridViewPAMANUKAN.Columns(6).Width = 50
        'DataGridViewPAMANUKAN.Columns(7).Width = 80
        'DataGridViewPAMANUKAN.Columns(8).Width = 80
        'DataGridViewPAMANUKAN.Columns(9).Width = 80
        'DataGridViewPAMANUKAN.Columns(10).Width = 80
        'DataGridViewPAMANUKAN.Columns(11).Width = 80
        'DataGridViewPAMANUKAN.Columns(12).Width = 80
        'DataGridViewPAMANUKAN.Columns(13).Width = 80
        'DataGridViewPAMANUKAN.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewPAMANUKAN.RowCount - 1

            DataGridViewPAMANUKAN.Rows(i).Cells(0).Value = DataGridViewPAMANUKAN.Rows(i).Cells(0).Value 'No struk
            DataGridViewPAMANUKAN.Rows(i).Cells(1).Value = Format(DataGridViewPAMANUKAN.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewPAMANUKAN.Rows(i).Cells(2).Value = DataGridViewPAMANUKAN.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewPAMANUKAN.Rows(i).Cells(3).Value = DataGridViewPAMANUKAN.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewPAMANUKAN.Rows(i).Cells(4).Value = DataGridViewPAMANUKAN.Rows(i).Cells(4).Value 'satuan
            DataGridViewPAMANUKAN.Rows(i).Cells(5).Value = DataGridViewPAMANUKAN.Rows(i).Cells(5).Value 'stock
            DataGridViewPAMANUKAN.Rows(i).Cells(6).Value = DataGridViewPAMANUKAN.Rows(i).Cells(6).Value 'Qty
            DataGridViewPAMANUKAN.Rows(i).Cells(7).Value = DataGridViewPAMANUKAN.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewPAMANUKAN.Rows(i).Cells(8).Value = DataGridViewPAMANUKAN.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewPAMANUKAN.Rows(i).Cells(9).Value = DataGridViewPAMANUKAN.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewPAMANUKAN.Rows(i).Cells(9).Value

            DataGridViewPAMANUKAN.Rows(i).Cells(10).Value = DataGridViewPAMANUKAN.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewPAMANUKAN.Rows(i).Cells(10).Value

            DataGridViewPAMANUKAN.Rows(i).Cells(11).Value = DataGridViewPAMANUKAN.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewPAMANUKAN.Rows(i).Cells(11).Value


            DataGridViewPAMANUKAN.Rows(i).Cells(12).Value = DataGridViewPAMANUKAN.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewPAMANUKAN.Rows(i).Cells(12).Value


            DataGridViewPAMANUKAN.Rows(i).Cells(13).Value = DataGridViewPAMANUKAN.Rows(i).Cells(13).Value 'status
            DataGridViewPAMANUKAN.Rows(i).Cells(14).Value = DataGridViewPAMANUKAN.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualPamanukan.Text = Format(LongTotalJual, "N0")
        txtTotalBeliPamanukan.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginPamanukan.Text = Format(LongTotalMargin, "N0")


        DataGridViewPAMANUKAN.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(12).DefaultCellStyle.Format = "N0"




        'SOETTA
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "014")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSOEKARNOHATTA.DataSource = table
        'DataGridViewSOEKARNOHATTA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewSOEKARNOHATTA.AutoResizeColumns()

        'DataGridViewSOEKARNOHATTA.Columns(0).HeaderText = "No Struk"
        'DataGridViewSOEKARNOHATTA.Columns(1).HeaderText = "Tgl"
        'DataGridViewSOEKARNOHATTA.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewSOEKARNOHATTA.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewSOEKARNOHATTA.Columns(4).HeaderText = "Satuan"
        'DataGridViewSOEKARNOHATTA.Columns(5).HeaderText = "Stock"
        'DataGridViewSOEKARNOHATTA.Columns(6).HeaderText = "Qty"
        'DataGridViewSOEKARNOHATTA.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewSOEKARNOHATTA.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewSOEKARNOHATTA.Columns(9).HeaderText = "Margin"
        'DataGridViewSOEKARNOHATTA.Columns(10).HeaderText = "Total Beli"
        'DataGridViewSOEKARNOHATTA.Columns(11).HeaderText = "Total Jual"
        'DataGridViewSOEKARNOHATTA.Columns(12).HeaderText = "Total Margin"
        'DataGridViewSOEKARNOHATTA.Columns(13).HeaderText = "Status"
        'DataGridViewSOEKARNOHATTA.Columns(14).HeaderText = "Sales Person"

        'DataGridViewSOEKARNOHATTA.Columns(0).Width = 110
        'DataGridViewSOEKARNOHATTA.Columns(1).Width = 70
        'DataGridViewSOEKARNOHATTA.Columns(2).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(3).Width = 250
        'DataGridViewSOEKARNOHATTA.Columns(4).Width = 50
        'DataGridViewSOEKARNOHATTA.Columns(5).Width = 50
        'DataGridViewSOEKARNOHATTA.Columns(6).Width = 50
        'DataGridViewSOEKARNOHATTA.Columns(7).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(8).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(9).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(10).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(11).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(12).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(13).Width = 80
        'DataGridViewSOEKARNOHATTA.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewSOEKARNOHATTA.RowCount - 1

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(0).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(0).Value 'No struk
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(1).Value = Format(DataGridViewSOEKARNOHATTA.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(2).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(3).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(4).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(4).Value 'satuan
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(5).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(5).Value 'stock
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(6).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(6).Value 'Qty
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(7).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(9).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewSOEKARNOHATTA.Rows(i).Cells(9).Value

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value


            DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value


            DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value 'status
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(14).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualSoetta.Text = Format(LongTotalJual, "N0")
        txtTotalBeliSoetta.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginSoetta.Text = Format(LongTotalMargin, "N0")


        DataGridViewSOEKARNOHATTA.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(12).DefaultCellStyle.Format = "N0"














        'SUBANG
        command = New SqlCommand("Lap_Margin_Rep4", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "015")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSUBANG.DataSource = table
        'DataGridViewSUBANG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewSUBANG.AutoResizeColumns()

        'DataGridViewSUBANG.Columns(0).HeaderText = "No Struk"
        'DataGridViewSUBANG.Columns(1).HeaderText = "Tgl"
        'DataGridViewSUBANG.Columns(2).HeaderText = "Kode Barang"
        'DataGridViewSUBANG.Columns(3).HeaderText = "Nama Barang"
        'DataGridViewSUBANG.Columns(4).HeaderText = "Satuan"
        'DataGridViewSUBANG.Columns(5).HeaderText = "Stock"
        'DataGridViewSUBANG.Columns(6).HeaderText = "Qty"
        'DataGridViewSUBANG.Columns(7).HeaderText = "Harga Beli"
        'DataGridViewSUBANG.Columns(8).HeaderText = "Harga Jual"
        'DataGridViewSUBANG.Columns(9).HeaderText = "Margin"
        'DataGridViewSUBANG.Columns(10).HeaderText = "Total Beli"
        'DataGridViewSUBANG.Columns(11).HeaderText = "Total Jual"
        'DataGridViewSUBANG.Columns(12).HeaderText = "Total Margin"
        'DataGridViewSUBANG.Columns(13).HeaderText = "Status"
        'DataGridViewSUBANG.Columns(14).HeaderText = "Sales Person"

        'DataGridViewSUBANG.Columns(0).Width = 110
        'DataGridViewSUBANG.Columns(1).Width = 70
        'DataGridViewSUBANG.Columns(2).Width = 80
        'DataGridViewSUBANG.Columns(3).Width = 250
        'DataGridViewSUBANG.Columns(4).Width = 50
        'DataGridViewSUBANG.Columns(5).Width = 50
        'DataGridViewSUBANG.Columns(6).Width = 50
        'DataGridViewSUBANG.Columns(7).Width = 80
        'DataGridViewSUBANG.Columns(8).Width = 80
        'DataGridViewSUBANG.Columns(9).Width = 80
        'DataGridViewSUBANG.Columns(10).Width = 80
        'DataGridViewSUBANG.Columns(11).Width = 80
        'DataGridViewSUBANG.Columns(12).Width = 80
        'DataGridViewSUBANG.Columns(13).Width = 80
        'DataGridViewSUBANG.Columns(14).Width = 80


        LongMargin = 0
        LongTotalJual = 0
        LongTotalBeli = 0
        LongTotalMargin = 0


        For i = 0 To DataGridViewSUBANG.RowCount - 1

            DataGridViewSUBANG.Rows(i).Cells(0).Value = DataGridViewSUBANG.Rows(i).Cells(0).Value 'No struk
            DataGridViewSUBANG.Rows(i).Cells(1).Value = Format(DataGridViewSUBANG.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewSUBANG.Rows(i).Cells(2).Value = DataGridViewSUBANG.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewSUBANG.Rows(i).Cells(3).Value = DataGridViewSUBANG.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewSUBANG.Rows(i).Cells(4).Value = DataGridViewSUBANG.Rows(i).Cells(4).Value 'satuan
            DataGridViewSUBANG.Rows(i).Cells(5).Value = DataGridViewSUBANG.Rows(i).Cells(5).Value 'stock
            DataGridViewSUBANG.Rows(i).Cells(6).Value = DataGridViewSUBANG.Rows(i).Cells(6).Value 'Qty
            DataGridViewSUBANG.Rows(i).Cells(7).Value = DataGridViewSUBANG.Rows(i).Cells(7).Value 'Harga beli
            DataGridViewSUBANG.Rows(i).Cells(8).Value = DataGridViewSUBANG.Rows(i).Cells(8).Value 'Harga jual

            DataGridViewSUBANG.Rows(i).Cells(9).Value = DataGridViewSUBANG.Rows(i).Cells(9).Value 'Margin
            LongMargin = LongMargin + DataGridViewSUBANG.Rows(i).Cells(9).Value

            DataGridViewSUBANG.Rows(i).Cells(10).Value = DataGridViewSUBANG.Rows(i).Cells(10).Value 'Total Beli
            LongTotalBeli = LongTotalBeli + DataGridViewSUBANG.Rows(i).Cells(10).Value

            DataGridViewSUBANG.Rows(i).Cells(11).Value = DataGridViewSUBANG.Rows(i).Cells(11).Value 'Total Jual
            LongTotalJual = LongTotalJual + DataGridViewSUBANG.Rows(i).Cells(11).Value


            DataGridViewSUBANG.Rows(i).Cells(12).Value = DataGridViewSUBANG.Rows(i).Cells(12).Value 'Total Margin
            LongTotalMargin = LongTotalMargin + DataGridViewSUBANG.Rows(i).Cells(12).Value


            DataGridViewSUBANG.Rows(i).Cells(13).Value = DataGridViewSUBANG.Rows(i).Cells(13).Value 'status
            DataGridViewSUBANG.Rows(i).Cells(14).Value = DataGridViewSUBANG.Rows(i).Cells(14).Value 'persion


        Next



        txtTotalJualSubang.Text = Format(LongTotalJual, "N0")
        txtTotalBeliSubang.Text = Format(LongTotalBeli, "N0")
        txtTotalMarginSubang.Text = Format(LongTotalMargin, "N0")


        DataGridViewSUBANG.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSUBANG.Columns(12).DefaultCellStyle.Format = "N0"



















    End Sub

    Private Sub DataGridViewAyani_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAyani.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewAyani.Item(0, DataGridViewAyani.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewAyani.Item(0, DataGridViewAyani.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub






    Private Sub DataGridViewAyani_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewAyani.Sorted
        DataGridViewAyani.ClearSelection()
        ViewStockWarehouse.Close()
        'TxtCek.Focus()
    End Sub
    Private Sub TxtCek_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ViewStockWarehouse.ShowDialog()
    End Sub

    Private Sub DataGridViewAyani_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewAyani.SortCompare
        If (e.RowIndex2 = DataGridViewAyani.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

  

    Private Sub DataGridViewCibabat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCibabat.CellContentClick

        strNamaGrid = "004"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewCibabat.Item(2, DataGridViewCibabat.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCibabat.Item(3, DataGridViewCibabat.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCibabat.Item(0, DataGridViewCibabat.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewCibabat.Item(2, DataGridViewCibabat.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCibabat.Item(3, DataGridViewCibabat.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCibabat.Item(0, DataGridViewCibabat.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()
        End If

    End Sub

    Private Sub DataGridViewCibabat_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCibabat.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewCibabat.Item(0, DataGridViewCibabat.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewCibabat.Item(0, DataGridViewCibabat.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub





    Private Sub DataGridViewCibabat_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibabat.SortCompare
        If (e.RowIndex2 = DataGridViewCibabat.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCibiru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCibiru.CellContentClick

        strNamaGrid = "006"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewCibiru.Item(2, DataGridViewCibiru.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCibiru.Item(3, DataGridViewCibiru.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCibiru.Item(0, DataGridViewCibiru.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewCibiru.Item(2, DataGridViewCibiru.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCibiru.Item(3, DataGridViewCibiru.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCibiru.Item(0, DataGridViewCibiru.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
     
    End Sub

    Private Sub DataGridViewCibiru_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCibiru.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewCibiru.Item(0, DataGridViewCibiru.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewCibiru.Item(0, DataGridViewCibiru.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub


    Private Sub DataGridViewCibiru_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibiru.SortCompare
        If (e.RowIndex2 = DataGridViewCibiru.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCiparay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCiparay.CellContentClick
 
        strNamaGrid = "010"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewCiparay.Item(2, DataGridViewCiparay.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCiparay.Item(3, DataGridViewCiparay.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCiparay.Item(0, DataGridViewCiparay.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewCiparay.Item(2, DataGridViewCiparay.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCiparay.Item(3, DataGridViewCiparay.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCiparay.Item(0, DataGridViewCiparay.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewCiparay_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCiparay.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewCiparay.Item(0, DataGridViewCiparay.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewCiparay.Item(0, DataGridViewCiparay.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub




    Private Sub DataGridViewCiparay_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCiparay.SortCompare
        If (e.RowIndex2 = DataGridViewCiparay.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCirebon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCirebon.CellContentClick

        strNamaGrid = "008"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewCirebon.Item(2, DataGridViewCirebon.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCirebon.Item(3, DataGridViewCirebon.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCirebon.Item(0, DataGridViewCirebon.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewCirebon.Item(2, DataGridViewCirebon.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewCirebon.Item(3, DataGridViewCirebon.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewCirebon.Item(0, DataGridViewCirebon.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewCirebon_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCirebon.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewCirebon.Item(0, DataGridViewCirebon.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewCirebon.Item(0, DataGridViewCirebon.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewCirebon_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCirebon.SortCompare
        If (e.RowIndex2 = DataGridViewCirebon.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewGarut_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewGarut.CellContentClick

        strNamaGrid = "007"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewGarut.Item(2, DataGridViewGarut.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewGarut.Item(3, DataGridViewGarut.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewGarut.Item(0, DataGridViewGarut.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewGarut.Item(2, DataGridViewGarut.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewGarut.Item(3, DataGridViewGarut.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewGarut.Item(0, DataGridViewGarut.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewGarut_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewGarut.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewGarut.Item(0, DataGridViewGarut.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewGarut.Item(0, DataGridViewGarut.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewGarut_Click(sender As Object, e As EventArgs) Handles DataGridViewGarut.Click

    End Sub



    Private Sub DataGridViewGarut_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewGarut.SortCompare
        If (e.RowIndex2 = DataGridViewGarut.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewKopo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKopo.CellContentClick

        strNamaGrid = "005"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewKopo.Item(2, DataGridViewKopo.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewKopo.Item(3, DataGridViewKopo.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewKopo.Item(0, DataGridViewKopo.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewKopo.Item(2, DataGridViewKopo.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewKopo.Item(3, DataGridViewKopo.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewKopo.Item(0, DataGridViewKopo.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewKopo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKopo.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewKopo.Item(0, DataGridViewKopo.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewKopo.Item(0, DataGridViewKopo.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewKopo_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewKopo.SortCompare
        If (e.RowIndex2 = DataGridViewKopo.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewPAMANUKAN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPAMANUKAN.CellContentClick

        strNamaGrid = "003"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewPAMANUKAN.Item(2, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewPAMANUKAN.Item(3, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewPAMANUKAN.Item(0, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewPAMANUKAN.Item(2, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewPAMANUKAN.Item(3, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewPAMANUKAN.Item(0, DataGridViewPAMANUKAN.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewPAMANUKAN_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPAMANUKAN.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewPAMANUKAN.Item(0, DataGridViewPAMANUKAN.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewPAMANUKAN.Item(0, DataGridViewPAMANUKAN.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub



    Private Sub DataGridViewPAMANUKAN_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewPAMANUKAN.SortCompare
        If (e.RowIndex2 = DataGridViewPAMANUKAN.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewRancaekek_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRancaekek.CellContentClick
         
        strNamaGrid = "011"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewRancaekek.Item(2, DataGridViewRancaekek.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewRancaekek.Item(3, DataGridViewRancaekek.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewRancaekek.Item(0, DataGridViewRancaekek.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewRancaekek.Item(2, DataGridViewRancaekek.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewRancaekek.Item(3, DataGridViewRancaekek.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewRancaekek.Item(0, DataGridViewRancaekek.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewRancaekek_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRancaekek.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewRancaekek.Item(0, DataGridViewRancaekek.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewRancaekek.Item(0, DataGridViewRancaekek.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub


    Private Sub DataGridViewRancaekek_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewRancaekek.SortCompare
        If (e.RowIndex2 = DataGridViewRancaekek.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewSumedang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSumedang.CellContentClick
        
        strNamaGrid = "009"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewSumedang.Item(2, DataGridViewSumedang.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSumedang.Item(3, DataGridViewSumedang.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSumedang.Item(0, DataGridViewSumedang.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewSumedang.Item(2, DataGridViewSumedang.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSumedang.Item(3, DataGridViewSumedang.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSumedang.Item(0, DataGridViewSumedang.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If

    End Sub

    Private Sub DataGridViewSumedang_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSumedang.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewSumedang.Item(0, DataGridViewSumedang.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewSumedang.Item(0, DataGridViewSumedang.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewSumedang_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewSumedang.SortCompare
        If (e.RowIndex2 = DataGridViewSumedang.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewTASIKMALAYA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTASIKMALAYA.CellContentClick
       
        strNamaGrid = "012"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewTASIKMALAYA.Item(2, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewTASIKMALAYA.Item(3, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewTASIKMALAYA.Item(0, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewTASIKMALAYA.Item(2, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewTASIKMALAYA.Item(3, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewTASIKMALAYA.Item(0, DataGridViewTASIKMALAYA.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If

    End Sub

    Private Sub DataGridViewTASIKMALAYA_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTASIKMALAYA.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewTASIKMALAYA.Item(0, DataGridViewTASIKMALAYA.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewTASIKMALAYA.Item(0, DataGridViewTASIKMALAYA.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewTASIKMALAYA_Click(sender As Object, e As EventArgs) Handles DataGridViewTASIKMALAYA.Click

    End Sub


    Private Sub DataGridViewTASIKMALAYA_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewTASIKMALAYA.SortCompare
        If (e.RowIndex2 = DataGridViewTASIKMALAYA.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub


    Private Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)
        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Do
            s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, _
               DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Loop Until oCurrentCol Is Nothing
        s = s.Substring(0, s.Length - 1)
        s &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, _
                      DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)

        Clipboard.ContainsText()
        Clipboard.SetDataObject(o, True, 10, 200)



    End Sub


    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click

        If strNamaGrid = "DataGridViewABM" Then
            Call CopyDataGridViewToClipboard(DataGridABM)
        End If

        If strNamaGrid = "DataGridViewAyani" Then
            Call CopyDataGridViewToClipboard(DataGridViewAyani)
        End If


        If strNamaGrid = "DataGridViewCibabat" Then
            Call CopyDataGridViewToClipboard(DataGridViewCibabat)
        End If

        If strNamaGrid = "DataGridViewKopo" Then
            Call CopyDataGridViewToClipboard(DataGridViewKopo)
        End If

        If strNamaGrid = "DataGridViewCibiru" Then
            Call CopyDataGridViewToClipboard(DataGridViewCibiru)
        End If

        If strNamaGrid = "DataGridViewGarut" Then
            Call CopyDataGridViewToClipboard(DataGridViewGarut)
        End If

        If strNamaGrid = "DataGridViewCirebon" Then
            Call CopyDataGridViewToClipboard(DataGridViewCirebon)
        End If

        If strNamaGrid = "DataGridViewSumedang" Then
            Call CopyDataGridViewToClipboard(DataGridViewSumedang)
        End If

        If strNamaGrid = "DataGridViewCiparay" Then
            Call CopyDataGridViewToClipboard(DataGridViewCiparay)
        End If

        If strNamaGrid = "DataGridViewRancaekek" Then
            Call CopyDataGridViewToClipboard(DataGridViewRancaekek)
        End If

        If strNamaGrid = "DataGridViewTASIK" Then
            Call CopyDataGridViewToClipboard(DataGridViewTASIKMALAYA)
        End If

        If strNamaGrid = "DataGridViewPAMANUKAN" Then
            Call CopyDataGridViewToClipboard(DataGridViewPAMANUKAN)
        End If

        If strNamaGrid = "DataGridViewSoetta" Then
            Call CopyDataGridViewToClipboard(DataGridViewSOEKARNOHATTA)
        End If

    End Sub


    Private Sub DataGridABM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridABM.CellContentClick
        strNamaGrid = "001"

        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridABM.Item(2, DataGridABM.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridABM.Item(3, DataGridABM.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridABM.Item(0, DataGridABM.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridABM.Item(2, DataGridABM.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridABM.Item(3, DataGridABM.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridABM.Item(0, DataGridABM.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If







    End Sub







    Private Sub DataGridViewAyani_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAyani.CellContentClick
        strNamaGrid = "003"

        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewAyani.Item(2, DataGridViewAyani.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewAyani.Item(3, DataGridViewAyani.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewAyani.Item(0, DataGridViewAyani.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewAyani.Item(2, DataGridViewAyani.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewAyani.Item(3, DataGridViewAyani.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewAyani.Item(0, DataGridViewAyani.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If



    End Sub

    Private Sub DataGridViewSOEKARNOHATTA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSOEKARNOHATTA.CellContentClick
        
        strNamaGrid = "014"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewSOEKARNOHATTA.Item(2, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSOEKARNOHATTA.Item(3, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSOEKARNOHATTA.Item(0, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewSOEKARNOHATTA.Item(2, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSOEKARNOHATTA.Item(3, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSOEKARNOHATTA.Item(0, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridABM_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridABM.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridABM.Item(0, DataGridABM.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridABM.Item(0, DataGridABM.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewSUBANG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSUBANG.CellContentClick

        strNamaGrid = "015"
        If e.ColumnIndex = 2 Then

            GlobalstrKodeBarang = DataGridViewSUBANG.Item(2, DataGridViewSUBANG.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSUBANG.Item(3, DataGridViewSUBANG.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSUBANG.Item(0, DataGridViewSUBANG.CurrentRow.Index).Value
            FormAuditItems.ShowDialog()
        End If

        If e.ColumnIndex = 5 Then
            GlobalstrKodeBarang = DataGridViewSUBANG.Item(2, DataGridViewSUBANG.CurrentRow.Index).Value
            GlobalStrNamaBarang = DataGridViewSUBANG.Item(3, DataGridViewSUBANG.CurrentRow.Index).Value
            GlobalStrKodeCabang = DataGridViewSUBANG.Item(0, DataGridViewSUBANG.CurrentRow.Index).Value
            ViewStockWarehouse.ShowDialog()

        End If
    End Sub

    Private Sub DataGridViewSOEKARNOHATTA_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSOEKARNOHATTA.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewSOEKARNOHATTA.Item(0, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewSOEKARNOHATTA.Item(0, DataGridViewSOEKARNOHATTA.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub

    Private Sub DataGridViewSUBANG_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSUBANG.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            Koneksi()
            Dim strSQL As String = "SELECT  TOP 1 U_CXS_TRID FROM dbo.OINV WHERE U_CXS_TRID='" & DataGridViewSUBANG.Item(0, DataGridViewSUBANG.CurrentRow.Index).Value & "' AND isIns='Y'"
            cmd = New SqlCommand(strSQL, MyConnection)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                MstrNoStruk = DataGridViewSUBANG.Item(0, DataGridViewSUBANG.CurrentRow.Index).Value

                FormMonitoringDelivery.ShowDialog()

                Exit Sub
            Else
                MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")
            End If
        End If
    End Sub
End Class