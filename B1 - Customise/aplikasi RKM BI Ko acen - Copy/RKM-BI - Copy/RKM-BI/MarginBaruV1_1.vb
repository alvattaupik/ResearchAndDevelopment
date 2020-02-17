Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class MarginBaruV1_1
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

        DataGridABM.Columns(0).HeaderText = "No Struk"
        DataGridABM.Columns(1).HeaderText = "Tgl"
        DataGridABM.Columns(2).HeaderText = "Kode Barang"
        DataGridABM.Columns(3).HeaderText = "Nama Barang"
        DataGridABM.Columns(4).HeaderText = "Satuan"
        DataGridABM.Columns(5).HeaderText = "Stock"
        DataGridABM.Columns(6).HeaderText = "Qty"
        DataGridABM.Columns(7).HeaderText = "Harga Beli"
        DataGridABM.Columns(8).HeaderText = "Harga Jual"
        DataGridABM.Columns(9).HeaderText = "Margin"
        DataGridABM.Columns(10).HeaderText = "Total Beli"
        DataGridABM.Columns(11).HeaderText = "Total Jual"
        DataGridABM.Columns(12).HeaderText = "Total Margin"
        DataGridABM.Columns(13).HeaderText = "Status"
        DataGridABM.Columns(14).HeaderText = "Sales Person"

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

        DataGridViewAyani.Columns(0).HeaderText = "No Struk"
        DataGridViewAyani.Columns(1).HeaderText = "Tgl"
        DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
        DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
        DataGridViewAyani.Columns(4).HeaderText = "Satuan"
        DataGridViewAyani.Columns(5).HeaderText = "Stock"
        DataGridViewAyani.Columns(6).HeaderText = "Qty"
        DataGridViewAyani.Columns(7).HeaderText = "Harga Beli"
        DataGridViewAyani.Columns(8).HeaderText = "Harga Jual"
        DataGridViewAyani.Columns(9).HeaderText = "Margin"
        DataGridViewAyani.Columns(10).HeaderText = "Total Beli"
        DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
        DataGridViewAyani.Columns(12).HeaderText = "Total Margin"
        DataGridViewAyani.Columns(13).HeaderText = "Status"
        DataGridViewAyani.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewAyani.Columns(14).Width = 80


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

        DataGridViewCibabat.Columns(0).HeaderText = "No Struk"
        DataGridViewCibabat.Columns(1).HeaderText = "Tgl"
        DataGridViewCibabat.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibabat.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibabat.Columns(4).HeaderText = "Satuan"
        DataGridViewCibabat.Columns(5).HeaderText = "Stock"
        DataGridViewCibabat.Columns(6).HeaderText = "Qty"
        DataGridViewCibabat.Columns(7).HeaderText = "Harga Beli"
        DataGridViewCibabat.Columns(8).HeaderText = "Harga Jual"
        DataGridViewCibabat.Columns(9).HeaderText = "Margin"
        DataGridViewCibabat.Columns(10).HeaderText = "Total Beli"
        DataGridViewCibabat.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibabat.Columns(12).HeaderText = "Total Margin"
        DataGridViewCibabat.Columns(13).HeaderText = "Status"
        DataGridViewCibabat.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewCibabat.Columns(14).Width = 80


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

        DataGridViewKopo.Columns(0).HeaderText = "No Struk"
        DataGridViewKopo.Columns(1).HeaderText = "Tgl"
        DataGridViewKopo.Columns(2).HeaderText = "Kode Barang"
        DataGridViewKopo.Columns(3).HeaderText = "Nama Barang"
        DataGridViewKopo.Columns(4).HeaderText = "Satuan"
        DataGridViewKopo.Columns(5).HeaderText = "Stock"
        DataGridViewKopo.Columns(6).HeaderText = "Qty"
        DataGridViewKopo.Columns(7).HeaderText = "Harga Beli"
        DataGridViewKopo.Columns(8).HeaderText = "Harga Jual"
        DataGridViewKopo.Columns(9).HeaderText = "Margin"
        DataGridViewKopo.Columns(10).HeaderText = "Total Beli"
        DataGridViewKopo.Columns(11).HeaderText = "Total Jual"
        DataGridViewKopo.Columns(12).HeaderText = "Total Margin"
        DataGridViewKopo.Columns(13).HeaderText = "Status"
        DataGridViewKopo.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewKopo.Columns(14).Width = 80


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

        DataGridViewCibiru.Columns(0).HeaderText = "No Struk"
        DataGridViewCibiru.Columns(1).HeaderText = "Tgl"
        DataGridViewCibiru.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibiru.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibiru.Columns(4).HeaderText = "Satuan"
        DataGridViewCibiru.Columns(5).HeaderText = "Stock"
        DataGridViewCibiru.Columns(6).HeaderText = "Qty"
        DataGridViewCibiru.Columns(7).HeaderText = "Harga Beli"
        DataGridViewCibiru.Columns(8).HeaderText = "Harga Jual"
        DataGridViewCibiru.Columns(9).HeaderText = "Margin"
        DataGridViewCibiru.Columns(10).HeaderText = "Total Beli"
        DataGridViewCibiru.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibiru.Columns(12).HeaderText = "Total Margin"
        DataGridViewCibiru.Columns(13).HeaderText = "Status"
        DataGridViewCibiru.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewCibiru.Columns(14).Width = 80


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

        DataGridViewGarut.Columns(0).HeaderText = "No Struk"
        DataGridViewGarut.Columns(1).HeaderText = "Tgl"
        DataGridViewGarut.Columns(2).HeaderText = "Kode Barang"
        DataGridViewGarut.Columns(3).HeaderText = "Nama Barang"
        DataGridViewGarut.Columns(4).HeaderText = "Satuan"
        DataGridViewGarut.Columns(5).HeaderText = "Stock"
        DataGridViewGarut.Columns(6).HeaderText = "Qty"
        DataGridViewGarut.Columns(7).HeaderText = "Harga Beli"
        DataGridViewGarut.Columns(8).HeaderText = "Harga Jual"
        DataGridViewGarut.Columns(9).HeaderText = "Margin"
        DataGridViewGarut.Columns(10).HeaderText = "Total Beli"
        DataGridViewGarut.Columns(11).HeaderText = "Total Jual"
        DataGridViewGarut.Columns(12).HeaderText = "Total Margin"
        DataGridViewGarut.Columns(13).HeaderText = "Status"
        DataGridViewGarut.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewGarut.Columns(14).Width = 80


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

        DataGridViewCirebon.Columns(0).HeaderText = "No Struk"
        DataGridViewCirebon.Columns(1).HeaderText = "Tgl"
        DataGridViewCirebon.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCirebon.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCirebon.Columns(4).HeaderText = "Satuan"
        DataGridViewCirebon.Columns(5).HeaderText = "Stock"
        DataGridViewCirebon.Columns(6).HeaderText = "Qty"
        DataGridViewCirebon.Columns(7).HeaderText = "Harga Beli"
        DataGridViewCirebon.Columns(8).HeaderText = "Harga Jual"
        DataGridViewCirebon.Columns(9).HeaderText = "Margin"
        DataGridViewCirebon.Columns(10).HeaderText = "Total Beli"
        DataGridViewCirebon.Columns(11).HeaderText = "Total Jual"
        DataGridViewCirebon.Columns(12).HeaderText = "Total Margin"
        DataGridViewCirebon.Columns(13).HeaderText = "Status"
        DataGridViewCirebon.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewCirebon.Columns(14).Width = 80


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

        DataGridViewSumedang.Columns(0).HeaderText = "No Struk"
        DataGridViewSumedang.Columns(1).HeaderText = "Tgl"
        DataGridViewSumedang.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSumedang.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSumedang.Columns(4).HeaderText = "Satuan"
        DataGridViewSumedang.Columns(5).HeaderText = "Stock"
        DataGridViewSumedang.Columns(6).HeaderText = "Qty"
        DataGridViewSumedang.Columns(7).HeaderText = "Harga Beli"
        DataGridViewSumedang.Columns(8).HeaderText = "Harga Jual"
        DataGridViewSumedang.Columns(9).HeaderText = "Margin"
        DataGridViewSumedang.Columns(10).HeaderText = "Total Beli"
        DataGridViewSumedang.Columns(11).HeaderText = "Total Jual"
        DataGridViewSumedang.Columns(12).HeaderText = "Total Margin"
        DataGridViewSumedang.Columns(13).HeaderText = "Status"
        DataGridViewSumedang.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewSumedang.Columns(14).Width = 80


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

        DataGridViewCiparay.Columns(0).HeaderText = "No Struk"
        DataGridViewCiparay.Columns(1).HeaderText = "Tgl"
        DataGridViewCiparay.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCiparay.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCiparay.Columns(4).HeaderText = "Satuan"
        DataGridViewCiparay.Columns(5).HeaderText = "Stock"
        DataGridViewCiparay.Columns(6).HeaderText = "Qty"
        DataGridViewCiparay.Columns(7).HeaderText = "Harga Beli"
        DataGridViewCiparay.Columns(8).HeaderText = "Harga Jual"
        DataGridViewCiparay.Columns(9).HeaderText = "Margin"
        DataGridViewCiparay.Columns(10).HeaderText = "Total Beli"
        DataGridViewCiparay.Columns(11).HeaderText = "Total Jual"
        DataGridViewCiparay.Columns(12).HeaderText = "Total Margin"
        DataGridViewCiparay.Columns(13).HeaderText = "Status"
        DataGridViewCiparay.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewCiparay.Columns(14).Width = 80


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

        DataGridViewRancaekek.Columns(0).HeaderText = "No Struk"
        DataGridViewRancaekek.Columns(1).HeaderText = "Tgl"
        DataGridViewRancaekek.Columns(2).HeaderText = "Kode Barang"
        DataGridViewRancaekek.Columns(3).HeaderText = "Nama Barang"
        DataGridViewRancaekek.Columns(4).HeaderText = "Satuan"
        DataGridViewRancaekek.Columns(5).HeaderText = "Stock"
        DataGridViewRancaekek.Columns(6).HeaderText = "Qty"
        DataGridViewRancaekek.Columns(7).HeaderText = "Harga Beli"
        DataGridViewRancaekek.Columns(8).HeaderText = "Harga Jual"
        DataGridViewRancaekek.Columns(9).HeaderText = "Margin"
        DataGridViewRancaekek.Columns(10).HeaderText = "Total Beli"
        DataGridViewRancaekek.Columns(11).HeaderText = "Total Jual"
        DataGridViewRancaekek.Columns(12).HeaderText = "Total Margin"
        DataGridViewRancaekek.Columns(13).HeaderText = "Status"
        DataGridViewRancaekek.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewRancaekek.Columns(14).Width = 80


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

        DataGridViewTASIKMALAYA.Columns(0).HeaderText = "No Struk"
        DataGridViewTASIKMALAYA.Columns(1).HeaderText = "Tgl"
        DataGridViewTASIKMALAYA.Columns(2).HeaderText = "Kode Barang"
        DataGridViewTASIKMALAYA.Columns(3).HeaderText = "Nama Barang"
        DataGridViewTASIKMALAYA.Columns(4).HeaderText = "Satuan"
        DataGridViewTASIKMALAYA.Columns(5).HeaderText = "Stock"
        DataGridViewTASIKMALAYA.Columns(6).HeaderText = "Qty"
        DataGridViewTASIKMALAYA.Columns(7).HeaderText = "Harga Beli"
        DataGridViewTASIKMALAYA.Columns(8).HeaderText = "Harga Jual"
        DataGridViewTASIKMALAYA.Columns(9).HeaderText = "Margin"
        DataGridViewTASIKMALAYA.Columns(10).HeaderText = "Total Beli"
        DataGridViewTASIKMALAYA.Columns(11).HeaderText = "Total Jual"
        DataGridViewTASIKMALAYA.Columns(12).HeaderText = "Total Margin"
        DataGridViewTASIKMALAYA.Columns(13).HeaderText = "Status"
        DataGridViewTASIKMALAYA.Columns(14).HeaderText = "Sales Person"

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
        DataGridViewTASIKMALAYA.Columns(14).Width = 80


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

        DataGridViewPAMANUKAN.Columns(0).HeaderText = "No Struk"
        DataGridViewPAMANUKAN.Columns(1).HeaderText = "Tgl"
        DataGridViewPAMANUKAN.Columns(2).HeaderText = "Kode Barang"
        DataGridViewPAMANUKAN.Columns(3).HeaderText = "Nama Barang"
        DataGridViewPAMANUKAN.Columns(4).HeaderText = "Satuan"
        DataGridViewPAMANUKAN.Columns(5).HeaderText = "Stock"
        DataGridViewPAMANUKAN.Columns(6).HeaderText = "Qty"
        DataGridViewPAMANUKAN.Columns(7).HeaderText = "Harga Beli"
        DataGridViewPAMANUKAN.Columns(8).HeaderText = "Harga Jual"
        DataGridViewPAMANUKAN.Columns(9).HeaderText = "Margin"
        DataGridViewPAMANUKAN.Columns(10).HeaderText = "Total Beli"
        DataGridViewPAMANUKAN.Columns(11).HeaderText = "Total Jual"
        DataGridViewPAMANUKAN.Columns(12).HeaderText = "Total Margin"
        DataGridViewPAMANUKAN.Columns(13).HeaderText = "Status"
        DataGridViewPAMANUKAN.Columns(14).HeaderText = "Sales Person"

        DataGridViewPAMANUKAN.Columns(0).Width = 110
        DataGridViewPAMANUKAN.Columns(1).Width = 70
        DataGridViewPAMANUKAN.Columns(2).Width = 80
        DataGridViewPAMANUKAN.Columns(3).Width = 250
        DataGridViewPAMANUKAN.Columns(4).Width = 50
        DataGridViewPAMANUKAN.Columns(5).Width = 50
        DataGridViewPAMANUKAN.Columns(6).Width = 50
        DataGridViewPAMANUKAN.Columns(7).Width = 80
        DataGridViewPAMANUKAN.Columns(8).Width = 80
        DataGridViewPAMANUKAN.Columns(9).Width = 80
        DataGridViewPAMANUKAN.Columns(10).Width = 80
        DataGridViewPAMANUKAN.Columns(11).Width = 80
        DataGridViewPAMANUKAN.Columns(12).Width = 80
        DataGridViewPAMANUKAN.Columns(13).Width = 80
        DataGridViewPAMANUKAN.Columns(14).Width = 80


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

        DataGridViewSOEKARNOHATTA.Columns(0).HeaderText = "No Struk"
        DataGridViewSOEKARNOHATTA.Columns(1).HeaderText = "Tgl"
        DataGridViewSOEKARNOHATTA.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSOEKARNOHATTA.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSOEKARNOHATTA.Columns(4).HeaderText = "Satuan"
        DataGridViewSOEKARNOHATTA.Columns(5).HeaderText = "Stock"
        DataGridViewSOEKARNOHATTA.Columns(6).HeaderText = "Qty"
        DataGridViewSOEKARNOHATTA.Columns(7).HeaderText = "Harga Beli"
        DataGridViewSOEKARNOHATTA.Columns(8).HeaderText = "Harga Jual"
        DataGridViewSOEKARNOHATTA.Columns(9).HeaderText = "Margin"
        DataGridViewSOEKARNOHATTA.Columns(10).HeaderText = "Total Beli"
        DataGridViewSOEKARNOHATTA.Columns(11).HeaderText = "Total Jual"
        DataGridViewSOEKARNOHATTA.Columns(12).HeaderText = "Total Margin"
        DataGridViewSOEKARNOHATTA.Columns(13).HeaderText = "Status"
        DataGridViewSOEKARNOHATTA.Columns(14).HeaderText = "Sales Person"

        DataGridViewSOEKARNOHATTA.Columns(0).Width = 110
        DataGridViewSOEKARNOHATTA.Columns(1).Width = 70
        DataGridViewSOEKARNOHATTA.Columns(2).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(3).Width = 250
        DataGridViewSOEKARNOHATTA.Columns(4).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(5).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(6).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(7).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(8).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(9).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(10).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(11).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(12).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(13).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(14).Width = 80


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









    End Sub
  



    'Sub LoadDataMarginABM()
    '    Koneksi()
    '    Dim i As Integer
    '    Dim awal, akhir As String
    '    awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
    '    akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

    '    Dim command As SqlCommand
    '    command = New SqlCommand("Lap_Margin_Rep3", MyConnection)

    '    Dim adapter As New SqlDataAdapter(command)
    '    command.CommandType = CommandType.StoredProcedure
    '    command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
    '    command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
    '    command.Parameters.AddWithValue("@PrintByUserName", "xxx")
    '    command.Parameters.AddWithValue("@Cabang", "001")
    '    Dim table As New DataTable
    '    adapter.Fill(table)
    '    Me.DataGridViewAyani.DataSource = table

    '    DataGridViewAyani.Columns(0).HeaderText = "No Struk"
    '    DataGridViewAyani.Columns(1).HeaderText = "Tgl"
    '    DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
    '    DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
    '    DataGridViewAyani.Columns(4).HeaderText = "Satuan"
    '    DataGridViewAyani.Columns(5).HeaderText = "Stock"
    '    DataGridViewAyani.Columns(6).HeaderText = "Qty"
    '    DataGridViewAyani.Columns(7).HeaderText = "Harga Jual"
    '    DataGridViewAyani.Columns(8).HeaderText = "Discount"
    '    DataGridViewAyani.Columns(9).HeaderText = "Harga Beli"
    '    DataGridViewAyani.Columns(10).HeaderText = "Margin"
    '    DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
    '    DataGridViewAyani.Columns(12).HeaderText = "Total Beli"
    '    DataGridViewAyani.Columns(13).HeaderText = "Total Margin"
    '    DataGridViewAyani.Columns(14).HeaderText = "Status"
    '    DataGridViewAyani.Columns(15).HeaderText = "Sales Person"

    '    DataGridViewAyani.Columns(0).Width = 110
    '    DataGridViewAyani.Columns(1).Width = 70
    '    DataGridViewAyani.Columns(2).Width = 80
    '    DataGridViewAyani.Columns(3).Width = 250
    '    DataGridViewAyani.Columns(4).Width = 50
    '    DataGridViewAyani.Columns(5).Width = 50
    '    DataGridViewAyani.Columns(6).Width = 50
    '    DataGridViewAyani.Columns(7).Width = 80
    '    DataGridViewAyani.Columns(8).Width = 80
    '    DataGridViewAyani.Columns(9).Width = 80
    '    DataGridViewAyani.Columns(10).Width = 80
    '    DataGridViewAyani.Columns(11).Width = 80
    '    DataGridViewAyani.Columns(12).Width = 80
    '    DataGridViewAyani.Columns(13).Width = 80
    '    DataGridViewAyani.Columns(14).Width = 80
    '    DataGridViewAyani.Columns(15).Width = 50

    '    Dim hasil As Long = 0
    '    Dim hasil1 As Long = 0
    '    Dim hasil2 As Long = 0
    '    Dim hasil3 As Long = 0
    '    Dim hasil4 As Long = 0
    '    Dim hasil5 As Long = 0
    '    Dim hasil6 As Long = 0

    '    For i = 0 To DataGridViewAyani.RowCount - 1
    '        DataGridViewAyani.Rows(i).Cells(0).Value = DataGridViewAyani.Rows(i).Cells(0).Value 'No struk
    '        DataGridViewAyani.Rows(i).Cells(1).Value = Format(DataGridViewAyani.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
    '        DataGridViewAyani.Rows(i).Cells(2).Value = DataGridViewAyani.Rows(i).Cells(2).Value 'Kode barang
    '        DataGridViewAyani.Rows(i).Cells(3).Value = DataGridViewAyani.Rows(i).Cells(3).Value 'nama baarang
    '        DataGridViewAyani.Rows(i).Cells(4).Value = DataGridViewAyani.Rows(i).Cells(4).Value 'satuan
    '        DataGridViewAyani.Rows(i).Cells(5).Value = DataGridViewAyani.Rows(i).Cells(5).Value 'stock
    '        DataGridViewAyani.Rows(i).Cells(6).Value = DataGridViewAyani.Rows(i).Cells(6).Value 'Qty
    '        DataGridViewAyani.Rows(i).Cells(7).Value = DataGridViewAyani.Rows(i).Cells(7).Value 'Harga Jual

    '        DataGridViewAyani.Rows(i).Cells(8).Value = DataGridViewAyani.Rows(i).Cells(8).Value 'Discount
    '        hasil4 = hasil4 + (DataGridViewAyani.Rows(i).Cells(8).Value)

    '        DataGridViewAyani.Rows(i).Cells(9).Value = DataGridViewAyani.Rows(i).Cells(9).Value 'harga beli

    '        DataGridViewAyani.Rows(i).Cells(10).Value = DataGridViewAyani.Rows(i).Cells(10).Value 'margin
    '        hasil = hasil + (DataGridViewAyani.Rows(i).Cells(10).Value)

    '        DataGridViewAyani.Rows(i).Cells(11).Value = DataGridViewAyani.Rows(i).Cells(11).Value 'total jual
    '        hasil1 = hasil1 + (DataGridViewAyani.Rows(i).Cells(11).Value)

    '        DataGridViewAyani.Rows(i).Cells(12).Value = DataGridViewAyani.Rows(i).Cells(12).Value 'total beli
    '        hasil2 = hasil2 + (DataGridViewAyani.Rows(i).Cells(12).Value)

    '        DataGridViewAyani.Rows(i).Cells(13).Value = DataGridViewAyani.Rows(i).Cells(13).Value ' total margin
    '        hasil3 = hasil3 + (DataGridViewAyani.Rows(i).Cells(13).Value)

    '        DataGridViewAyani.Rows(i).Cells(14).Value = DataGridViewAyani.Rows(i).Cells(14).Value 'status
    '        DataGridViewAyani.Rows(i).Cells(15).Value = DataGridViewAyani.Rows(i).Cells(15).Value 'persion


    '    Next



    '    txtMarginABM.Text = Format(hasil, "N0")
    '    txtTotalJualABM.Text = Format(hasil1, "N0")
    '    txtTotalBeliABM.Text = Format(hasil2, "N0")
    '    txtTotalMarginABM.Text = Format(hasil3, "N0")

    '    DataGridViewAyani.Columns(4).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(5).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(7).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(8).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(9).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(10).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(11).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(12).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(13).DefaultCellStyle.Format = "N0"

    'End Sub
    'Sub LoadDataMarginAYANI()

    '    Koneksi()
    '    Dim i As Integer
    '    Dim awal, akhir As String
    '    awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
    '    akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

    '    Dim command As SqlCommand
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim table As New DataTable

    '    Command = New SqlCommand("Lap_margin_rep3", MyConnection)
    '    adapter = New SqlDataAdapter(Command)
    '    Command.CommandType = CommandType.StoredProcedure
    '    Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
    '    Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
    '    Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
    '    Command.Parameters.AddWithValue("@Cabang", "003")
    '    table = New DataTable
    '    adapter.Fill(table)

    '    Me.DataGridViewAyani.DataSource = table
    '    DataGridViewAyani.Columns(0).HeaderText = "No Struk"
    '    DataGridViewAyani.Columns(1).HeaderText = "Tgl"
    '    DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
    '    DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
    '    DataGridViewAyani.Columns(4).HeaderText = "Satuan"
    '    DataGridViewAyani.Columns(5).HeaderText = "Stock"
    '    DataGridViewAyani.Columns(6).HeaderText = "Qty"
    '    DataGridViewAyani.Columns(7).HeaderText = "Harga Jual"
    '    DataGridViewAyani.Columns(8).HeaderText = "Discount"
    '    DataGridViewAyani.Columns(9).HeaderText = "Harga Beli"
    '    DataGridViewAyani.Columns(10).HeaderText = "Margin"
    '    DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
    '    DataGridViewAyani.Columns(12).HeaderText = "Total Beli"
    '    DataGridViewAyani.Columns(13).HeaderText = "Total Margin"
    '    DataGridViewAyani.Columns(14).HeaderText = "Status"
    '    DataGridViewAyani.Columns(15).HeaderText = "Sales Person"

    '    DataGridViewAyani.Columns(0).Width = 110
    '    DataGridViewAyani.Columns(1).Width = 70
    '    DataGridViewAyani.Columns(2).Width = 80
    '    DataGridViewAyani.Columns(3).Width = 250
    '    DataGridViewAyani.Columns(4).Width = 50
    '    DataGridViewAyani.Columns(5).Width = 50
    '    DataGridViewAyani.Columns(6).Width = 50
    '    DataGridViewAyani.Columns(7).Width = 80
    '    DataGridViewAyani.Columns(8).Width = 80
    '    DataGridViewAyani.Columns(9).Width = 80
    '    DataGridViewAyani.Columns(10).Width = 80
    '    DataGridViewAyani.Columns(11).Width = 80
    '    DataGridViewAyani.Columns(12).Width = 80
    '    DataGridViewAyani.Columns(13).Width = 80
    '    DataGridViewAyani.Columns(14).Width = 80
    '    DataGridViewAyani.Columns(15).Width = 50
    '    'DataGridViewAyani.Columns(16).Width = 100

    '    hasil = 0
    '    hasil1 = 0
    '    hasil2 = 0
    '    hasil3 = 0
    '    hasil4 = 0
    '    hasil5 = 0
    '    hasil6 = 0

    '    For i = 0 To DataGridViewAyani.RowCount - 1
    '        'DataGridViewAyani.RowCount = DataGridViewAyani.RowCount + 1
    '        DataGridViewAyani.Rows(i).Cells(0).Value = DataGridViewAyani.Rows(i).Cells(0).Value 'No struk
    '        DataGridViewAyani.Rows(i).Cells(1).Value = Format(DataGridViewAyani.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
    '        DataGridViewAyani.Rows(i).Cells(2).Value = DataGridViewAyani.Rows(i).Cells(2).Value 'Kode barang
    '        DataGridViewAyani.Rows(i).Cells(3).Value = DataGridViewAyani.Rows(i).Cells(3).Value 'nama baarang
    '        DataGridViewAyani.Rows(i).Cells(4).Value = DataGridViewAyani.Rows(i).Cells(4).Value 'satuan
    '        DataGridViewAyani.Rows(i).Cells(5).Value = DataGridViewAyani.Rows(i).Cells(5).Value 'stock
    '        DataGridViewAyani.Rows(i).Cells(6).Value = DataGridViewAyani.Rows(i).Cells(6).Value 'Qty
    '        DataGridViewAyani.Rows(i).Cells(7).Value = DataGridViewAyani.Rows(i).Cells(7).Value 'Harga Jual

    '        DataGridViewAyani.Rows(i).Cells(8).Value = DataGridViewAyani.Rows(i).Cells(8).Value 'Discount
    '        hasil4 = hasil4 + (DataGridViewAyani.Rows(i).Cells(8).Value)

    '        DataGridViewAyani.Rows(i).Cells(9).Value = DataGridViewAyani.Rows(i).Cells(9).Value 'harga beli

    '        DataGridViewAyani.Rows(i).Cells(10).Value = DataGridViewAyani.Rows(i).Cells(10).Value 'margin
    '        hasil = hasil + (DataGridViewAyani.Rows(i).Cells(10).Value)

    '        DataGridViewAyani.Rows(i).Cells(11).Value = DataGridViewAyani.Rows(i).Cells(11).Value 'total jual
    '        hasil1 = hasil1 + (DataGridViewAyani.Rows(i).Cells(11).Value)

    '        DataGridViewAyani.Rows(i).Cells(12).Value = DataGridViewAyani.Rows(i).Cells(12).Value 'total beli
    '        hasil2 = hasil2 + (DataGridViewAyani.Rows(i).Cells(12).Value)

    '        DataGridViewAyani.Rows(i).Cells(13).Value = DataGridViewAyani.Rows(i).Cells(13).Value ' total margin
    '        hasil3 = hasil3 + (DataGridViewAyani.Rows(i).Cells(13).Value)

    '        DataGridViewAyani.Rows(i).Cells(14).Value = DataGridViewAyani.Rows(i).Cells(14).Value 'status
    '        'hasil5 = hasil5 + (DataGridViewAyani.Rows(i).Cells(14).Value)
    '        DataGridViewAyani.Rows(i).Cells(15).Value = DataGridViewAyani.Rows(i).Cells(15).Value 'persion


    '    Next


    '    Ayani1.Text = Format(hasil4, "N0")
    '    Ayani2.Text = Format(hasil, "N0")
    '    Ayani3.Text = Format(hasil1, "N0")
    '    Ayani4.Text = Format(hasil2, "N0")
    '    Ayani5.Text = Format(hasil3, "N0")

    '    DataGridViewAyani.Columns(4).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(5).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(7).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(8).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(9).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(10).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(11).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(12).DefaultCellStyle.Format = "N0"
    '    DataGridViewAyani.Columns(13).DefaultCellStyle.Format = "N0"
    'End Sub
    Sub LoadDataMarginCIBABAT()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "004")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCibabat.DataSource = table

        DataGridViewCibabat.Columns(0).HeaderText = "No Struk"
        DataGridViewCibabat.Columns(1).HeaderText = "Tgl"
        DataGridViewCibabat.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibabat.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibabat.Columns(4).HeaderText = "Satuan"
        DataGridViewCibabat.Columns(5).HeaderText = "Stock"
        DataGridViewCibabat.Columns(6).HeaderText = "Qty"
        DataGridViewCibabat.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCibabat.Columns(8).HeaderText = "Discount"
        DataGridViewCibabat.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCibabat.Columns(10).HeaderText = "Margin"
        DataGridViewCibabat.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibabat.Columns(12).HeaderText = "Total Beli"
        DataGridViewCibabat.Columns(13).HeaderText = "Total Margin"
        DataGridViewCibabat.Columns(14).HeaderText = "Status"
        DataGridViewCibabat.Columns(15).HeaderText = "Sales Person"
        'DataGridViewCibabat.Columns(16).HeaderText = "Sales Person"

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
        DataGridViewCibabat.Columns(14).Width = 80
        DataGridViewCibabat.Columns(15).Width = 50
        'DataGridViewCibabat.Columns(16).Width = 100

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewCibabat.RowCount - 1
            DataGridViewCibabat.Rows(i).Cells(0).Value = DataGridViewCibabat.Rows(i).Cells(0).Value 'No struk
            DataGridViewCibabat.Rows(i).Cells(1).Value = Format(DataGridViewCibabat.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCibabat.Rows(i).Cells(2).Value = DataGridViewCibabat.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCibabat.Rows(i).Cells(3).Value = DataGridViewCibabat.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCibabat.Rows(i).Cells(4).Value = DataGridViewCibabat.Rows(i).Cells(4).Value 'satuan
            DataGridViewCibabat.Rows(i).Cells(5).Value = DataGridViewCibabat.Rows(i).Cells(5).Value 'stock
            DataGridViewCibabat.Rows(i).Cells(6).Value = DataGridViewCibabat.Rows(i).Cells(6).Value 'Qty
            DataGridViewCibabat.Rows(i).Cells(7).Value = DataGridViewCibabat.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewCibabat.Rows(i).Cells(8).Value = DataGridViewCibabat.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewCibabat.Rows(i).Cells(8).Value)

            DataGridViewCibabat.Rows(i).Cells(9).Value = DataGridViewCibabat.Rows(i).Cells(9).Value 'harga beli

            DataGridViewCibabat.Rows(i).Cells(10).Value = DataGridViewCibabat.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewCibabat.Rows(i).Cells(10).Value)

            DataGridViewCibabat.Rows(i).Cells(11).Value = DataGridViewCibabat.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewCibabat.Rows(i).Cells(11).Value)

            DataGridViewCibabat.Rows(i).Cells(12).Value = DataGridViewCibabat.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewCibabat.Rows(i).Cells(12).Value)

            DataGridViewCibabat.Rows(i).Cells(13).Value = DataGridViewCibabat.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewCibabat.Rows(i).Cells(13).Value)

            DataGridViewCibabat.Rows(i).Cells(14).Value = DataGridViewCibabat.Rows(i).Cells(14).Value 'status
            DataGridViewCibabat.Rows(i).Cells(15).Value = DataGridViewCibabat.Rows(i).Cells(15).Value 'persion


        Next


      
        txtTotalJualCibabat.Text = Format(hasil1, "N0")
        txtTotalBeliCibabat.Text = Format(hasil2, "N0")
        txtTotalMarginCibabat.Text = Format(hasil3, "N0")

        DataGridViewCibabat.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCibabat.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginKOPO()

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(Command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "005")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewKopo.DataSource = table

        DataGridViewKopo.Columns(0).HeaderText = "No Struk"
        DataGridViewKopo.Columns(1).HeaderText = "Tgl"
        DataGridViewKopo.Columns(2).HeaderText = "Kode Barang"
        DataGridViewKopo.Columns(3).HeaderText = "Nama Barang"
        DataGridViewKopo.Columns(4).HeaderText = "Satuan"
        DataGridViewKopo.Columns(5).HeaderText = "Stock"
        DataGridViewKopo.Columns(6).HeaderText = "Qty"
        DataGridViewKopo.Columns(7).HeaderText = "Harga Jual"
        DataGridViewKopo.Columns(8).HeaderText = "Discount"
        DataGridViewKopo.Columns(9).HeaderText = "Harga Beli"
        DataGridViewKopo.Columns(10).HeaderText = "Margin"
        DataGridViewKopo.Columns(11).HeaderText = "Total Jual"
        DataGridViewKopo.Columns(12).HeaderText = "Total Beli"
        DataGridViewKopo.Columns(13).HeaderText = "Total Margin"
        DataGridViewKopo.Columns(14).HeaderText = "Status"
        DataGridViewKopo.Columns(15).HeaderText = "Sales Person"
        'DataGridViewKopo.Columns(16).HeaderText = "Sales Person"

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
        DataGridViewKopo.Columns(14).Width = 80
        DataGridViewKopo.Columns(15).Width = 50
        'DataGridViewKopo.Columns(16).Width = 100

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewKopo.RowCount - 1
            'DataGridViewKopo.RowCount = DataGridViewKopo.RowCount + 1
            DataGridViewKopo.Rows(i).Cells(0).Value = DataGridViewKopo.Rows(i).Cells(0).Value 'No struk
            DataGridViewKopo.Rows(i).Cells(1).Value = Format(DataGridViewKopo.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewKopo.Rows(i).Cells(2).Value = DataGridViewKopo.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewKopo.Rows(i).Cells(3).Value = DataGridViewKopo.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewKopo.Rows(i).Cells(4).Value = DataGridViewKopo.Rows(i).Cells(4).Value 'satuan
            DataGridViewKopo.Rows(i).Cells(5).Value = DataGridViewKopo.Rows(i).Cells(5).Value 'stock
            DataGridViewKopo.Rows(i).Cells(6).Value = DataGridViewKopo.Rows(i).Cells(6).Value 'Qty
            DataGridViewKopo.Rows(i).Cells(7).Value = DataGridViewKopo.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewKopo.Rows(i).Cells(8).Value = DataGridViewKopo.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewKopo.Rows(i).Cells(8).Value)

            DataGridViewKopo.Rows(i).Cells(9).Value = DataGridViewKopo.Rows(i).Cells(9).Value 'harga beli

            DataGridViewKopo.Rows(i).Cells(10).Value = DataGridViewKopo.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewKopo.Rows(i).Cells(10).Value)

            DataGridViewKopo.Rows(i).Cells(11).Value = DataGridViewKopo.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewKopo.Rows(i).Cells(11).Value)

            DataGridViewKopo.Rows(i).Cells(12).Value = DataGridViewKopo.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewKopo.Rows(i).Cells(12).Value)

            DataGridViewKopo.Rows(i).Cells(13).Value = DataGridViewKopo.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewKopo.Rows(i).Cells(13).Value)

            DataGridViewKopo.Rows(i).Cells(14).Value = DataGridViewKopo.Rows(i).Cells(14).Value 'status
            'hasil5 = hasil5 + (DataGridViewKopo.Rows(i).Cells(14).Value)
            DataGridViewKopo.Rows(i).Cells(15).Value = DataGridViewKopo.Rows(i).Cells(15).Value 'persion


        Next

        'DataGridViewKopo.RowCount = DataGridViewKopo.RowCount - 1
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(3).Value = "          TOTAL"

        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(6).Value = hasil4
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(11).Value = hasil
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(12).Value = hasil1
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(13).Value = hasil2
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(14).Value = hasil3
        'DataGridViewKopo.Rows(DataGridViewKopo.RowCount - 1).Cells(14).Value = hasil5

        txtTotalJualKopo.Text = Format(hasil1, "N0")
        txtTotalBeliKopo.Text = Format(hasil2, "N0")
        txtTotalMarginKopo.Text = Format(hasil3, "N0")

        DataGridViewKopo.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewKopo.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginCIBIRU()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "006")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCibiru.DataSource = table

        DataGridViewCibiru.Columns(0).HeaderText = "No Struk"
        DataGridViewCibiru.Columns(1).HeaderText = "Tgl"
        DataGridViewCibiru.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCibiru.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCibiru.Columns(4).HeaderText = "Satuan"
        DataGridViewCibiru.Columns(5).HeaderText = "Stock"
        DataGridViewCibiru.Columns(6).HeaderText = "Qty"
        DataGridViewCibiru.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCibiru.Columns(8).HeaderText = "Discount"
        DataGridViewCibiru.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCibiru.Columns(10).HeaderText = "Margin"
        DataGridViewCibiru.Columns(11).HeaderText = "Total Jual"
        DataGridViewCibiru.Columns(12).HeaderText = "Total Beli"
        DataGridViewCibiru.Columns(13).HeaderText = "Total Margin"
        DataGridViewCibiru.Columns(14).HeaderText = "Status"
        DataGridViewCibiru.Columns(15).HeaderText = "Sales Person"
        'DataGridViewCibiru.Columns(16).HeaderText = "Sales Person"

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
        DataGridViewCibiru.Columns(14).Width = 80
        DataGridViewCibiru.Columns(15).Width = 50
        'DataGridViewCibiru.Columns(16).Width = 100

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewCibiru.RowCount - 1
            'DataGridViewCibiru.RowCount = DataGridViewCibiru.RowCount + 1
            DataGridViewCibiru.Rows(i).Cells(0).Value = DataGridViewCibiru.Rows(i).Cells(0).Value 'No struk
            DataGridViewCibiru.Rows(i).Cells(1).Value = Format(DataGridViewCibiru.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCibiru.Rows(i).Cells(2).Value = DataGridViewCibiru.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCibiru.Rows(i).Cells(3).Value = DataGridViewCibiru.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCibiru.Rows(i).Cells(4).Value = DataGridViewCibiru.Rows(i).Cells(4).Value 'satuan
            DataGridViewCibiru.Rows(i).Cells(5).Value = DataGridViewCibiru.Rows(i).Cells(5).Value 'stock
            DataGridViewCibiru.Rows(i).Cells(6).Value = DataGridViewCibiru.Rows(i).Cells(6).Value 'Qty
            DataGridViewCibiru.Rows(i).Cells(7).Value = DataGridViewCibiru.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewCibiru.Rows(i).Cells(8).Value = DataGridViewCibiru.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewCibiru.Rows(i).Cells(8).Value)

            DataGridViewCibiru.Rows(i).Cells(9).Value = DataGridViewCibiru.Rows(i).Cells(9).Value 'harga beli

            DataGridViewCibiru.Rows(i).Cells(10).Value = DataGridViewCibiru.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewCibiru.Rows(i).Cells(10).Value)

            DataGridViewCibiru.Rows(i).Cells(11).Value = DataGridViewCibiru.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewCibiru.Rows(i).Cells(11).Value)

            DataGridViewCibiru.Rows(i).Cells(12).Value = DataGridViewCibiru.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewCibiru.Rows(i).Cells(12).Value)

            DataGridViewCibiru.Rows(i).Cells(13).Value = DataGridViewCibiru.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewCibiru.Rows(i).Cells(13).Value)

            DataGridViewCibiru.Rows(i).Cells(14).Value = DataGridViewCibiru.Rows(i).Cells(14).Value 'status
            'hasil5 = hasil5 + (DataGridViewCibiru.Rows(i).Cells(14).Value)
            DataGridViewCibiru.Rows(i).Cells(15).Value = DataGridViewCibiru.Rows(i).Cells(15).Value 'persion


        Next

        'DataGridViewCibiru.RowCount = DataGridViewCibiru.RowCount - 1
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(3).Value = "          TOTAL"

        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(6).Value = hasil4
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(11).Value = hasil
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(12).Value = hasil1
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(13).Value = hasil2
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(14).Value = hasil3
        'DataGridViewCibiru.Rows(DataGridViewCibiru.RowCount - 1).Cells(14).Value = hasil5

       
        txtTotalJualCibiru.Text = Format(hasil1, "N0")
        txtTotalBeliCibiru.Text = Format(hasil2, "N0")
        txtTotalMarginCibiru.Text = Format(hasil3, "N0")

        DataGridViewCibiru.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCibiru.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginGARUT()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "007")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewGarut.DataSource = table

        DataGridViewGarut.Columns(0).HeaderText = "No Struk"
        DataGridViewGarut.Columns(1).HeaderText = "Tgl"
        DataGridViewGarut.Columns(2).HeaderText = "Kode Barang"
        DataGridViewGarut.Columns(3).HeaderText = "Nama Barang"
        DataGridViewGarut.Columns(4).HeaderText = "Satuan"
        DataGridViewGarut.Columns(5).HeaderText = "Stock"
        DataGridViewGarut.Columns(6).HeaderText = "Qty"
        DataGridViewGarut.Columns(7).HeaderText = "Harga Jual"
        DataGridViewGarut.Columns(8).HeaderText = "Discount"
        DataGridViewGarut.Columns(9).HeaderText = "Harga Beli"
        DataGridViewGarut.Columns(10).HeaderText = "Margin"
        DataGridViewGarut.Columns(11).HeaderText = "Total Jual"
        DataGridViewGarut.Columns(12).HeaderText = "Total Beli"
        DataGridViewGarut.Columns(13).HeaderText = "Total Margin"
        DataGridViewGarut.Columns(14).HeaderText = "Status"
        DataGridViewGarut.Columns(15).HeaderText = "Sales Person"


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
        DataGridViewGarut.Columns(14).Width = 80
        DataGridViewGarut.Columns(15).Width = 50


        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewGarut.RowCount - 1

            DataGridViewGarut.Rows(i).Cells(0).Value = DataGridViewGarut.Rows(i).Cells(0).Value 'No struk
            DataGridViewGarut.Rows(i).Cells(1).Value = Format(DataGridViewGarut.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewGarut.Rows(i).Cells(2).Value = DataGridViewGarut.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewGarut.Rows(i).Cells(3).Value = DataGridViewGarut.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewGarut.Rows(i).Cells(4).Value = DataGridViewGarut.Rows(i).Cells(4).Value 'satuan
            DataGridViewGarut.Rows(i).Cells(5).Value = DataGridViewGarut.Rows(i).Cells(5).Value 'stock
            DataGridViewGarut.Rows(i).Cells(6).Value = DataGridViewGarut.Rows(i).Cells(6).Value 'Qty
            DataGridViewGarut.Rows(i).Cells(7).Value = DataGridViewGarut.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewGarut.Rows(i).Cells(8).Value = DataGridViewGarut.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewGarut.Rows(i).Cells(8).Value)

            DataGridViewGarut.Rows(i).Cells(9).Value = DataGridViewGarut.Rows(i).Cells(9).Value 'harga beli

            DataGridViewGarut.Rows(i).Cells(10).Value = DataGridViewGarut.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewGarut.Rows(i).Cells(10).Value)

            DataGridViewGarut.Rows(i).Cells(11).Value = DataGridViewGarut.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewGarut.Rows(i).Cells(11).Value)

            DataGridViewGarut.Rows(i).Cells(12).Value = DataGridViewGarut.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewGarut.Rows(i).Cells(12).Value)

            DataGridViewGarut.Rows(i).Cells(13).Value = DataGridViewGarut.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewGarut.Rows(i).Cells(13).Value)

            DataGridViewGarut.Rows(i).Cells(14).Value = DataGridViewGarut.Rows(i).Cells(14).Value 'status
            DataGridViewGarut.Rows(i).Cells(15).Value = DataGridViewGarut.Rows(i).Cells(15).Value 'persion


        Next


       
        txtTotalJualGarut.Text = Format(hasil1, "N0")
        txtTotalBeligarut.Text = Format(hasil2, "N0")
        txtTotalMarginGarut.Text = Format(hasil3, "N0")

        DataGridViewGarut.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewGarut.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginCIREBON()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "008")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCirebon.DataSource = table

        DataGridViewCirebon.Columns(0).HeaderText = "No Struk"
        DataGridViewCirebon.Columns(1).HeaderText = "Tgl"
        DataGridViewCirebon.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCirebon.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCirebon.Columns(4).HeaderText = "Satuan"
        DataGridViewCirebon.Columns(5).HeaderText = "Stock"
        DataGridViewCirebon.Columns(6).HeaderText = "Qty"
        DataGridViewCirebon.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCirebon.Columns(8).HeaderText = "Discount"
        DataGridViewCirebon.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCirebon.Columns(10).HeaderText = "Margin"
        DataGridViewCirebon.Columns(11).HeaderText = "Total Jual"
        DataGridViewCirebon.Columns(12).HeaderText = "Total Beli"
        DataGridViewCirebon.Columns(13).HeaderText = "Total Margin"
        DataGridViewCirebon.Columns(14).HeaderText = "Status"
        DataGridViewCirebon.Columns(15).HeaderText = "Sales Person"


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
        DataGridViewCirebon.Columns(14).Width = 80
        DataGridViewCirebon.Columns(15).Width = 50


        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewCirebon.RowCount - 1

            DataGridViewCirebon.Rows(i).Cells(0).Value = DataGridViewCirebon.Rows(i).Cells(0).Value 'No struk
            DataGridViewCirebon.Rows(i).Cells(1).Value = Format(DataGridViewCirebon.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCirebon.Rows(i).Cells(2).Value = DataGridViewCirebon.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCirebon.Rows(i).Cells(3).Value = DataGridViewCirebon.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCirebon.Rows(i).Cells(4).Value = DataGridViewCirebon.Rows(i).Cells(4).Value 'satuan
            DataGridViewCirebon.Rows(i).Cells(5).Value = DataGridViewCirebon.Rows(i).Cells(5).Value 'stock
            DataGridViewCirebon.Rows(i).Cells(6).Value = DataGridViewCirebon.Rows(i).Cells(6).Value 'Qty
            DataGridViewCirebon.Rows(i).Cells(7).Value = DataGridViewCirebon.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewCirebon.Rows(i).Cells(8).Value = DataGridViewCirebon.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewCirebon.Rows(i).Cells(8).Value)

            DataGridViewCirebon.Rows(i).Cells(9).Value = DataGridViewCirebon.Rows(i).Cells(9).Value 'harga beli

            DataGridViewCirebon.Rows(i).Cells(10).Value = DataGridViewCirebon.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewCirebon.Rows(i).Cells(10).Value)

            DataGridViewCirebon.Rows(i).Cells(11).Value = DataGridViewCirebon.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewCirebon.Rows(i).Cells(11).Value)

            DataGridViewCirebon.Rows(i).Cells(12).Value = DataGridViewCirebon.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewCirebon.Rows(i).Cells(12).Value)

            DataGridViewCirebon.Rows(i).Cells(13).Value = DataGridViewCirebon.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewCirebon.Rows(i).Cells(13).Value)

            DataGridViewCirebon.Rows(i).Cells(14).Value = DataGridViewCirebon.Rows(i).Cells(14).Value 'status
            DataGridViewCirebon.Rows(i).Cells(15).Value = DataGridViewCirebon.Rows(i).Cells(15).Value 'persion


        Next


       
        txtTotalJualCirebon.Text = Format(hasil1, "N0")
        txtTotalBeliCirebon.Text = Format(hasil2, "N0")
        txtTotalMarginCirebon.Text = Format(hasil3, "N0")

        DataGridViewCirebon.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCirebon.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginSUMEDANG()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "009")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSumedang.DataSource = table

        DataGridViewSumedang.Columns(0).HeaderText = "No Struk"
        DataGridViewSumedang.Columns(1).HeaderText = "Tgl"
        DataGridViewSumedang.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSumedang.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSumedang.Columns(4).HeaderText = "Satuan"
        DataGridViewSumedang.Columns(5).HeaderText = "Stock"
        DataGridViewSumedang.Columns(6).HeaderText = "Qty"
        DataGridViewSumedang.Columns(7).HeaderText = "Harga Jual"
        DataGridViewSumedang.Columns(8).HeaderText = "Discount"
        DataGridViewSumedang.Columns(9).HeaderText = "Harga Beli"
        DataGridViewSumedang.Columns(10).HeaderText = "Margin"
        DataGridViewSumedang.Columns(11).HeaderText = "Total Jual"
        DataGridViewSumedang.Columns(12).HeaderText = "Total Beli"
        DataGridViewSumedang.Columns(13).HeaderText = "Total Margin"
        DataGridViewSumedang.Columns(14).HeaderText = "Status"
        DataGridViewSumedang.Columns(15).HeaderText = "Sales Person"

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
        DataGridViewSumedang.Columns(14).Width = 80
        DataGridViewSumedang.Columns(15).Width = 50


        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewSumedang.RowCount - 1

            DataGridViewSumedang.Rows(i).Cells(0).Value = DataGridViewSumedang.Rows(i).Cells(0).Value 'No struk
            DataGridViewSumedang.Rows(i).Cells(1).Value = Format(DataGridViewSumedang.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewSumedang.Rows(i).Cells(2).Value = DataGridViewSumedang.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewSumedang.Rows(i).Cells(3).Value = DataGridViewSumedang.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewSumedang.Rows(i).Cells(4).Value = DataGridViewSumedang.Rows(i).Cells(4).Value 'satuan
            DataGridViewSumedang.Rows(i).Cells(5).Value = DataGridViewSumedang.Rows(i).Cells(5).Value 'stock
            DataGridViewSumedang.Rows(i).Cells(6).Value = DataGridViewSumedang.Rows(i).Cells(6).Value 'Qty
            DataGridViewSumedang.Rows(i).Cells(7).Value = DataGridViewSumedang.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewSumedang.Rows(i).Cells(8).Value = DataGridViewSumedang.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewSumedang.Rows(i).Cells(8).Value)

            DataGridViewSumedang.Rows(i).Cells(9).Value = DataGridViewSumedang.Rows(i).Cells(9).Value 'harga beli

            DataGridViewSumedang.Rows(i).Cells(10).Value = DataGridViewSumedang.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewSumedang.Rows(i).Cells(10).Value)

            DataGridViewSumedang.Rows(i).Cells(11).Value = DataGridViewSumedang.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewSumedang.Rows(i).Cells(11).Value)

            DataGridViewSumedang.Rows(i).Cells(12).Value = DataGridViewSumedang.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewSumedang.Rows(i).Cells(12).Value)

            DataGridViewSumedang.Rows(i).Cells(13).Value = DataGridViewSumedang.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewSumedang.Rows(i).Cells(13).Value)

            DataGridViewSumedang.Rows(i).Cells(14).Value = DataGridViewSumedang.Rows(i).Cells(14).Value 'status

            DataGridViewSumedang.Rows(i).Cells(15).Value = DataGridViewSumedang.Rows(i).Cells(15).Value 'persion


        Next



       
        txtTotalJualSumedang.Text = Format(hasil1, "N0")
        txtTotalbeliSumedang.Text = Format(hasil2, "N0")
        txtTotalMarginSumedang.Text = Format(hasil3, "N0")

        DataGridViewSumedang.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewSumedang.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginCIPARAY()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "010")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCiparay.DataSource = table

        DataGridViewCiparay.Columns(0).HeaderText = "No Struk"
        DataGridViewCiparay.Columns(1).HeaderText = "Tgl"
        DataGridViewCiparay.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCiparay.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCiparay.Columns(4).HeaderText = "Satuan"
        DataGridViewCiparay.Columns(5).HeaderText = "Stock"
        DataGridViewCiparay.Columns(6).HeaderText = "Qty"
        DataGridViewCiparay.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCiparay.Columns(8).HeaderText = "Discount"
        DataGridViewCiparay.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCiparay.Columns(10).HeaderText = "Margin"
        DataGridViewCiparay.Columns(11).HeaderText = "Total Jual"
        DataGridViewCiparay.Columns(12).HeaderText = "Total Beli"
        DataGridViewCiparay.Columns(13).HeaderText = "Total Margin"
        DataGridViewCiparay.Columns(14).HeaderText = "Status"
        DataGridViewCiparay.Columns(15).HeaderText = "Sales Person"
        'DataGridViewciparay.Columns(16).HeaderText = "Sales Person"

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
        DataGridViewCiparay.Columns(14).Width = 80
        DataGridViewCiparay.Columns(15).Width = 50

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewCiparay.RowCount - 1

            DataGridViewCiparay.Rows(i).Cells(0).Value = DataGridViewCiparay.Rows(i).Cells(0).Value 'No struk
            DataGridViewCiparay.Rows(i).Cells(1).Value = Format(DataGridViewCiparay.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewCiparay.Rows(i).Cells(2).Value = DataGridViewCiparay.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewCiparay.Rows(i).Cells(3).Value = DataGridViewCiparay.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewCiparay.Rows(i).Cells(4).Value = DataGridViewCiparay.Rows(i).Cells(4).Value 'satuan
            DataGridViewCiparay.Rows(i).Cells(5).Value = DataGridViewCiparay.Rows(i).Cells(5).Value 'stock
            DataGridViewCiparay.Rows(i).Cells(6).Value = DataGridViewCiparay.Rows(i).Cells(6).Value 'Qty
            DataGridViewCiparay.Rows(i).Cells(7).Value = DataGridViewCiparay.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewCiparay.Rows(i).Cells(8).Value = DataGridViewCiparay.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewCiparay.Rows(i).Cells(8).Value)

            DataGridViewCiparay.Rows(i).Cells(9).Value = DataGridViewCiparay.Rows(i).Cells(9).Value 'harga beli

            DataGridViewCiparay.Rows(i).Cells(10).Value = DataGridViewCiparay.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewCiparay.Rows(i).Cells(10).Value)

            DataGridViewCiparay.Rows(i).Cells(11).Value = DataGridViewCiparay.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewCiparay.Rows(i).Cells(11).Value)

            DataGridViewCiparay.Rows(i).Cells(12).Value = DataGridViewCiparay.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewCiparay.Rows(i).Cells(12).Value)

            DataGridViewCiparay.Rows(i).Cells(13).Value = DataGridViewCiparay.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewCiparay.Rows(i).Cells(13).Value)

            DataGridViewCiparay.Rows(i).Cells(14).Value = DataGridViewCiparay.Rows(i).Cells(14).Value 'status
            DataGridViewCiparay.Rows(i).Cells(15).Value = DataGridViewCiparay.Rows(i).Cells(15).Value 'persion


        Next


      
        txtTotalJualCiparay.Text = Format(hasil1, "N0")
        txtTotalBeliCiparay.Text = Format(hasil2, "N0")
        txtTotalMarginCiparay.Text = Format(hasil3, "N0")

        DataGridViewCiparay.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewCiparay.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginRANCAEKEK()
        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "011")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewRancaekek.DataSource = table

        DataGridViewRancaekek.Columns(0).HeaderText = "No Struk"
        DataGridViewRancaekek.Columns(1).HeaderText = "Tgl"
        DataGridViewRancaekek.Columns(2).HeaderText = "Kode Barang"
        DataGridViewRancaekek.Columns(3).HeaderText = "Nama Barang"
        DataGridViewRancaekek.Columns(4).HeaderText = "Satuan"
        DataGridViewRancaekek.Columns(5).HeaderText = "Stock"
        DataGridViewRancaekek.Columns(6).HeaderText = "Qty"
        DataGridViewRancaekek.Columns(7).HeaderText = "Harga Jual"
        DataGridViewRancaekek.Columns(8).HeaderText = "Discount"
        DataGridViewRancaekek.Columns(9).HeaderText = "Harga Beli"
        DataGridViewRancaekek.Columns(10).HeaderText = "Margin"
        DataGridViewRancaekek.Columns(11).HeaderText = "Total Jual"
        DataGridViewRancaekek.Columns(12).HeaderText = "Total Beli"
        DataGridViewRancaekek.Columns(13).HeaderText = "Total Margin"
        DataGridViewRancaekek.Columns(14).HeaderText = "Status"
        DataGridViewRancaekek.Columns(15).HeaderText = "Sales Person"

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
        DataGridViewRancaekek.Columns(14).Width = 80
        DataGridViewRancaekek.Columns(15).Width = 50


        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewRancaekek.RowCount - 1

            DataGridViewRancaekek.Rows(i).Cells(0).Value = DataGridViewRancaekek.Rows(i).Cells(0).Value 'No struk
            DataGridViewRancaekek.Rows(i).Cells(1).Value = Format(DataGridViewRancaekek.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewRancaekek.Rows(i).Cells(2).Value = DataGridViewRancaekek.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewRancaekek.Rows(i).Cells(3).Value = DataGridViewRancaekek.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewRancaekek.Rows(i).Cells(4).Value = DataGridViewRancaekek.Rows(i).Cells(4).Value 'satuan
            DataGridViewRancaekek.Rows(i).Cells(5).Value = DataGridViewRancaekek.Rows(i).Cells(5).Value 'stock
            DataGridViewRancaekek.Rows(i).Cells(6).Value = DataGridViewRancaekek.Rows(i).Cells(6).Value 'Qty
            DataGridViewRancaekek.Rows(i).Cells(7).Value = DataGridViewRancaekek.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewRancaekek.Rows(i).Cells(8).Value = DataGridViewRancaekek.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewRancaekek.Rows(i).Cells(8).Value)

            DataGridViewRancaekek.Rows(i).Cells(9).Value = DataGridViewRancaekek.Rows(i).Cells(9).Value 'harga beli

            DataGridViewRancaekek.Rows(i).Cells(10).Value = DataGridViewRancaekek.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewRancaekek.Rows(i).Cells(10).Value)

            DataGridViewRancaekek.Rows(i).Cells(11).Value = DataGridViewRancaekek.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewRancaekek.Rows(i).Cells(11).Value)

            DataGridViewRancaekek.Rows(i).Cells(12).Value = DataGridViewRancaekek.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewRancaekek.Rows(i).Cells(12).Value)

            DataGridViewRancaekek.Rows(i).Cells(13).Value = DataGridViewRancaekek.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewRancaekek.Rows(i).Cells(13).Value)

            DataGridViewRancaekek.Rows(i).Cells(14).Value = DataGridViewRancaekek.Rows(i).Cells(14).Value 'status
            DataGridViewRancaekek.Rows(i).Cells(15).Value = DataGridViewRancaekek.Rows(i).Cells(15).Value 'persion


        Next


       
        txtTotalJualRancaekek.Text = Format(hasil1, "N0")
        txtTotalBeliRancaekek.Text = Format(hasil2, "N0")
        txtTotalmarginRancaekek.Text = Format(hasil3, "N0")

        DataGridViewRancaekek.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewRancaekek.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub
    Sub LoadDataMarginTASIKMALAYA()

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "012")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewTASIKMALAYA.DataSource = table

        DataGridViewTASIKMALAYA.Columns(0).HeaderText = "No Struk"
        DataGridViewTASIKMALAYA.Columns(1).HeaderText = "Tgl"
        DataGridViewTASIKMALAYA.Columns(2).HeaderText = "Kode Barang"
        DataGridViewTASIKMALAYA.Columns(3).HeaderText = "Nama Barang"
        DataGridViewTASIKMALAYA.Columns(4).HeaderText = "Satuan"
        DataGridViewTASIKMALAYA.Columns(5).HeaderText = "Stock"
        DataGridViewTASIKMALAYA.Columns(6).HeaderText = "Qty"
        DataGridViewTASIKMALAYA.Columns(7).HeaderText = "Harga Jual"
        DataGridViewTASIKMALAYA.Columns(8).HeaderText = "Discount"
        DataGridViewTASIKMALAYA.Columns(9).HeaderText = "Harga Beli"
        DataGridViewTASIKMALAYA.Columns(10).HeaderText = "Margin"
        DataGridViewTASIKMALAYA.Columns(11).HeaderText = "Total Jual"
        DataGridViewTASIKMALAYA.Columns(12).HeaderText = "Total Beli"
        DataGridViewTASIKMALAYA.Columns(13).HeaderText = "Total Margin"
        DataGridViewTASIKMALAYA.Columns(14).HeaderText = "Status"
        DataGridViewTASIKMALAYA.Columns(15).HeaderText = "Sales Person"
        'DataGridViewtasikmalaya.Columns(16).HeaderText = "Sales Person"

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
        DataGridViewTASIKMALAYA.Columns(14).Width = 80
        DataGridViewTASIKMALAYA.Columns(15).Width = 50

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewTASIKMALAYA.RowCount - 1
            DataGridViewTASIKMALAYA.Rows(i).Cells(0).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(0).Value 'No struk
            DataGridViewTASIKMALAYA.Rows(i).Cells(1).Value = Format(DataGridViewTASIKMALAYA.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewTASIKMALAYA.Rows(i).Cells(2).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewTASIKMALAYA.Rows(i).Cells(3).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewTASIKMALAYA.Rows(i).Cells(4).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(4).Value 'satuan
            DataGridViewTASIKMALAYA.Rows(i).Cells(5).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(5).Value 'stock
            DataGridViewTASIKMALAYA.Rows(i).Cells(6).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(6).Value 'Qty
            DataGridViewTASIKMALAYA.Rows(i).Cells(7).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + (DataGridViewTASIKMALAYA.Rows(i).Cells(8).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(9).Value 'harga beli

            DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value 'margin
            hasil = hasil + (DataGridViewTASIKMALAYA.Rows(i).Cells(10).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + (DataGridViewTASIKMALAYA.Rows(i).Cells(11).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + (DataGridViewTASIKMALAYA.Rows(i).Cells(12).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + (DataGridViewTASIKMALAYA.Rows(i).Cells(13).Value)

            DataGridViewTASIKMALAYA.Rows(i).Cells(14).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(14).Value 'status
            DataGridViewTASIKMALAYA.Rows(i).Cells(15).Value = DataGridViewTASIKMALAYA.Rows(i).Cells(15).Value 'persion


        Next


       
        txtTotalJualTasik.Text = Format(hasil1, "N0")
        txtTotalBeliTasik.Text = Format(hasil2, "N0")
        txtTotalMarginTasik.Text = Format(hasil3, "N0")

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
    Sub LoadDataMarginPAMANUKAN()


        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        Dim adapter As New SqlDataAdapter(command)
        'adapter = New SqlDataAdapter(command)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "013")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewPAMANUKAN.DataSource = table

        DataGridViewPAMANUKAN.Columns(0).HeaderText = "No Struk"
        DataGridViewPAMANUKAN.Columns(1).HeaderText = "Tgl"
        DataGridViewPAMANUKAN.Columns(2).HeaderText = "Kode Barang"
        DataGridViewPAMANUKAN.Columns(3).HeaderText = "Nama Barang"
        DataGridViewPAMANUKAN.Columns(4).HeaderText = "Satuan"
        DataGridViewPAMANUKAN.Columns(5).HeaderText = "Stock"
        DataGridViewPAMANUKAN.Columns(6).HeaderText = "Qty"
        DataGridViewPAMANUKAN.Columns(7).HeaderText = "Harga Jual"
        DataGridViewPAMANUKAN.Columns(8).HeaderText = "Discount"
        DataGridViewPAMANUKAN.Columns(9).HeaderText = "Harga Beli"
        DataGridViewPAMANUKAN.Columns(10).HeaderText = "Margin"
        DataGridViewPAMANUKAN.Columns(11).HeaderText = "Total Jual"
        DataGridViewPAMANUKAN.Columns(12).HeaderText = "Total Beli"
        DataGridViewPAMANUKAN.Columns(13).HeaderText = "Total Margin"
        DataGridViewPAMANUKAN.Columns(14).HeaderText = "Status"
        DataGridViewPAMANUKAN.Columns(15).HeaderText = "Sales Person"

        DataGridViewPAMANUKAN.Columns(0).Width = 110
        DataGridViewPAMANUKAN.Columns(1).Width = 70
        DataGridViewPAMANUKAN.Columns(2).Width = 80
        DataGridViewPAMANUKAN.Columns(3).Width = 250
        DataGridViewPAMANUKAN.Columns(4).Width = 50
        DataGridViewPAMANUKAN.Columns(5).Width = 50
        DataGridViewPAMANUKAN.Columns(6).Width = 50
        DataGridViewPAMANUKAN.Columns(7).Width = 80
        DataGridViewPAMANUKAN.Columns(8).Width = 80
        DataGridViewPAMANUKAN.Columns(9).Width = 80
        DataGridViewPAMANUKAN.Columns(10).Width = 80
        DataGridViewPAMANUKAN.Columns(11).Width = 80
        DataGridViewPAMANUKAN.Columns(12).Width = 80
        DataGridViewPAMANUKAN.Columns(13).Width = 80
        DataGridViewPAMANUKAN.Columns(14).Width = 80
        DataGridViewPAMANUKAN.Columns(15).Width = 50

        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewPAMANUKAN.RowCount - 1
            DataGridViewPAMANUKAN.Rows(i).Cells(0).Value = DataGridViewPAMANUKAN.Rows(i).Cells(0).Value 'No struk
            DataGridViewPAMANUKAN.Rows(i).Cells(1).Value = Format(DataGridViewPAMANUKAN.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewPAMANUKAN.Rows(i).Cells(2).Value = DataGridViewPAMANUKAN.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewPAMANUKAN.Rows(i).Cells(3).Value = DataGridViewPAMANUKAN.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewPAMANUKAN.Rows(i).Cells(4).Value = DataGridViewPAMANUKAN.Rows(i).Cells(4).Value 'satuan
            DataGridViewPAMANUKAN.Rows(i).Cells(5).Value = DataGridViewPAMANUKAN.Rows(i).Cells(5).Value 'stock
            DataGridViewPAMANUKAN.Rows(i).Cells(6).Value = DataGridViewPAMANUKAN.Rows(i).Cells(6).Value 'Qty
            DataGridViewPAMANUKAN.Rows(i).Cells(7).Value = DataGridViewPAMANUKAN.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewPAMANUKAN.Rows(i).Cells(8).Value = DataGridViewPAMANUKAN.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(8).Value) = True, 0, DataGridViewPAMANUKAN.Rows(i).Cells(8).Value)
            DataGridViewPAMANUKAN.Rows(i).Cells(9).Value = DataGridViewPAMANUKAN.Rows(i).Cells(9).Value 'harga beli

            DataGridViewPAMANUKAN.Rows(i).Cells(10).Value = DataGridViewPAMANUKAN.Rows(i).Cells(10).Value 'margin
            hasil = hasil + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(10).Value) = True, 0, DataGridViewPAMANUKAN.Rows(i).Cells(10).Value)


            DataGridViewPAMANUKAN.Rows(i).Cells(11).Value = DataGridViewPAMANUKAN.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(11).Value) = True, 0, DataGridViewPAMANUKAN.Rows(i).Cells(11).Value)


            DataGridViewPAMANUKAN.Rows(i).Cells(12).Value = DataGridViewPAMANUKAN.Rows(i).Cells(12).Value 'total beli

            hasil2 = hasil2 + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(12).Value) = True, 0, DataGridViewPAMANUKAN.Rows(i).Cells(12).Value)

            DataGridViewPAMANUKAN.Rows(i).Cells(13).Value = DataGridViewPAMANUKAN.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(13).Value) = True, 0, DataGridViewPAMANUKAN.Rows(i).Cells(13).Value)

            DataGridViewPAMANUKAN.Rows(i).Cells(14).Value = DataGridViewPAMANUKAN.Rows(i).Cells(14).Value 'status
            DataGridViewPAMANUKAN.Rows(i).Cells(15).Value = DataGridViewPAMANUKAN.Rows(i).Cells(15).Value 'persion

        Next


       
        txtTotalJualPamanukan.Text = Format(hasil1, "N0")
        txtTotalBeliPamanukan.Text = Format(hasil2, "N0")
        txtTotalMarginPamanukan.Text = Format(hasil3, "N0")

        DataGridViewPAMANUKAN.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewPAMANUKAN.Columns(13).DefaultCellStyle.Format = "N0"

    End Sub
    Sub LoadDataMarginSOETTA()

        Dim i As Integer
        Dim awal, akhir As String
        awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        Dim table As New DataTable

        command = New SqlCommand("Lap_margin_rep3", MyConnection)
        Dim adapter As New SqlDataAdapter(command)
        adapter = New SqlDataAdapter(command)
        Command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        Command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        Command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        Command.Parameters.AddWithValue("@Cabang", "014")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSOEKARNOHATTA.DataSource = table

        DataGridViewSOEKARNOHATTA.Columns(0).HeaderText = "No Struk"
        DataGridViewSOEKARNOHATTA.Columns(1).HeaderText = "Tgl"
        DataGridViewSOEKARNOHATTA.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSOEKARNOHATTA.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSOEKARNOHATTA.Columns(4).HeaderText = "Satuan"
        DataGridViewSOEKARNOHATTA.Columns(5).HeaderText = "Stock"
        DataGridViewSOEKARNOHATTA.Columns(6).HeaderText = "Qty"
        DataGridViewSOEKARNOHATTA.Columns(7).HeaderText = "Harga Jual"
        DataGridViewSOEKARNOHATTA.Columns(8).HeaderText = "Discount"
        DataGridViewSOEKARNOHATTA.Columns(9).HeaderText = "Harga Beli"
        DataGridViewSOEKARNOHATTA.Columns(10).HeaderText = "Margin"
        DataGridViewSOEKARNOHATTA.Columns(11).HeaderText = "Total Jual"
        DataGridViewSOEKARNOHATTA.Columns(12).HeaderText = "Total Beli"
        DataGridViewSOEKARNOHATTA.Columns(13).HeaderText = "Total Margin"
        DataGridViewSOEKARNOHATTA.Columns(14).HeaderText = "Status"
        DataGridViewSOEKARNOHATTA.Columns(15).HeaderText = "Sales Person"


        DataGridViewSOEKARNOHATTA.Columns(0).Width = 110
        DataGridViewSOEKARNOHATTA.Columns(1).Width = 70
        DataGridViewSOEKARNOHATTA.Columns(2).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(3).Width = 250
        DataGridViewSOEKARNOHATTA.Columns(4).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(5).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(6).Width = 50
        DataGridViewSOEKARNOHATTA.Columns(7).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(8).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(9).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(10).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(11).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(12).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(13).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(14).Width = 80
        DataGridViewSOEKARNOHATTA.Columns(15).Width = 50


        hasil = 0
        hasil1 = 0
        hasil2 = 0
        hasil3 = 0
        hasil4 = 0
        hasil5 = 0
        hasil6 = 0

        For i = 0 To DataGridViewSOEKARNOHATTA.RowCount - 1
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(0).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(0).Value 'No struk
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(1).Value = Format(DataGridViewSOEKARNOHATTA.Rows(i).Cells(1).Value, "dd-MM-yyyy") 'Tanggal
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(2).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(2).Value 'Kode barang
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(3).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(3).Value 'nama baarang
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(4).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(4).Value 'satuan
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(5).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(5).Value 'stock
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(6).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(6).Value 'Qty
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(7).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(7).Value 'Harga Jual

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value 'Discount
            hasil4 = hasil4 + IIf(IsDBNull(DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value) = True, 0, DataGridViewSOEKARNOHATTA.Rows(i).Cells(8).Value)
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(9).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(9).Value 'harga beli

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value 'margin
            hasil = hasil + IIf(IsDBNull(DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value) = True, 0, DataGridViewSOEKARNOHATTA.Rows(i).Cells(10).Value)


            DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value 'total jual
            hasil1 = hasil1 + IIf(IsDBNull(DataGridViewPAMANUKAN.Rows(i).Cells(11).Value) = True, 0, DataGridViewSOEKARNOHATTA.Rows(i).Cells(11).Value)


            DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value 'total beli
            hasil2 = hasil2 + IIf(IsDBNull(DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value) = True, 0, DataGridViewSOEKARNOHATTA.Rows(i).Cells(12).Value)

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value ' total margin
            hasil3 = hasil3 + IIf(IsDBNull(DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value) = True, 0, DataGridViewSOEKARNOHATTA.Rows(i).Cells(13).Value)

            DataGridViewSOEKARNOHATTA.Rows(i).Cells(14).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(14).Value 'status
            DataGridViewSOEKARNOHATTA.Rows(i).Cells(15).Value = DataGridViewSOEKARNOHATTA.Rows(i).Cells(15).Value 'persion

        Next


       
        txtTotalJualSoetta.Text = Format(hasil1, "N0")
        txtTotalBeliSoetta.Text = Format(hasil2, "N0")
        txtTotalMarginSoetta.Text = Format(hasil3, "N0")

        DataGridViewSOEKARNOHATTA.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridViewSOEKARNOHATTA.Columns(13).DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub DataGridViewAyani_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAyani.CellClick
        strNamaGrid = "DataGridViewAyani"
    End Sub



    Private Sub DataGridViewAyani_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewAyani.Sorted
        DataGridViewAyani.ClearSelection()
        ViewStockWarehouse.Close()
        TxtCek.Focus()
    End Sub
    Private Sub TxtCek_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCek.TextChanged
        ViewStockWarehouse.ShowDialog()
    End Sub

    Private Sub DataGridViewAyani_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAyani.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewAyani.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewAyani_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewAyani.SortCompare
        If (e.RowIndex2 = DataGridViewAyani.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCibabat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCibabat.CellClick
        strNamaGrid = "DataGridViewCibabat"
    End Sub

    Private Sub DataGridViewCibabat_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCibabat.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewCibabat.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewCibabat_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibabat.SortCompare
        If (e.RowIndex2 = DataGridViewCibabat.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCibiru_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCibiru.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewCibiru.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewCibiru_Click(sender As Object, e As EventArgs) Handles DataGridViewCibiru.Click
        strNamaGrid = "DataGridViewCibiru"
    End Sub

    Private Sub DataGridViewCibiru_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCibiru.SortCompare
        If (e.RowIndex2 = DataGridViewCibiru.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCiparay_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCiparay.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewCiparay.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewCiparay_Click(sender As Object, e As EventArgs) Handles DataGridViewCiparay.Click
        strNamaGrid = "DataGridViewCiparay"
    End Sub

    Private Sub DataGridViewCiparay_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCiparay.SortCompare
        If (e.RowIndex2 = DataGridViewCiparay.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewCirebon_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewCirebon.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewCirebon.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewCirebon_Click(sender As Object, e As EventArgs) Handles DataGridViewCirebon.Click
        strNamaGrid = "DataGridViewCirebon"
    End Sub

    Private Sub DataGridViewCirebon_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewCirebon.SortCompare
        If (e.RowIndex2 = DataGridViewCirebon.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewGarut_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewGarut.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewGarut.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub DataGridViewGarut_Click(sender As Object, e As EventArgs) Handles DataGridViewGarut.Click
        strNamaGrid = "DataGridViewGarut"
    End Sub

    Private Sub DataGridViewGarut_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewGarut.SortCompare
        If (e.RowIndex2 = DataGridViewGarut.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewKopo_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewKopo.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewGarut.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewKopo_Click(sender As Object, e As EventArgs) Handles DataGridViewKopo.Click
        strNamaGrid = "DataGridViewKopo"
    End Sub

    Private Sub DataGridViewKopo_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewKopo.SortCompare
        If (e.RowIndex2 = DataGridViewKopo.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewPAMANUKAN_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPAMANUKAN.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewPAMANUKAN.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewPAMANUKAN_Click(sender As Object, e As EventArgs) Handles DataGridViewPAMANUKAN.Click
        strNamaGrid = "DataGridViewPamanukan"
    End Sub

    Private Sub DataGridViewPAMANUKAN_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewPAMANUKAN.SortCompare
        If (e.RowIndex2 = DataGridViewPAMANUKAN.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewRancaekek_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewRancaekek.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewRancaekek.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewRancaekek_Click(sender As Object, e As EventArgs) Handles DataGridViewRancaekek.Click
        strNamaGrid = "DataGridViewRancaekek"
    End Sub

    Private Sub DataGridViewRancaekek_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewRancaekek.SortCompare
        If (e.RowIndex2 = DataGridViewRancaekek.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewSumedang_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSumedang.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewSumedang.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewSumedang_Click(sender As Object, e As EventArgs) Handles DataGridViewSumedang.Click
        strNamaGrid = "DataGridViewSumedang"
    End Sub

    Private Sub DataGridViewSumedang_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewSumedang.SortCompare
        If (e.RowIndex2 = DataGridViewSumedang.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridViewTASIKMALAYA_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewTASIKMALAYA.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewTASIKMALAYA.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub DataGridViewTASIKMALAYA_SortCompare(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles DataGridViewTASIKMALAYA.SortCompare
        If (e.RowIndex2 = DataGridViewTASIKMALAYA.Rows.Count - 1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgSoekarnoHatta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSOEKARNOHATTA.CellContentClick
        On Error Resume Next
        TxtCek.Text = DataGridViewSOEKARNOHATTA.Rows(e.RowIndex).Cells(2).Value
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
        On Error Resume Next
        TxtCek.Text = DataGridABM.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub DataGridViewSOEKARNOHATTA_Click(sender As Object, e As EventArgs) Handles DataGridViewSOEKARNOHATTA.Click
        strNamaGrid = "DataGridViewSoetta"
    End Sub

    Private Sub DataGridABM_Click(sender As Object, e As EventArgs) Handles DataGridABM.Click
        strNamaGrid = "DataGridViewABM"
    End Sub
End Class