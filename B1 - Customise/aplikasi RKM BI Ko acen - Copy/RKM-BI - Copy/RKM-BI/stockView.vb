Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph


Public Class stockView
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
        Koneksi()
        'Dim i As Integer
        Dim awal, akhir As String
        awal = Format(TglAwal.Value, "yyyy-MM-dd") + " 00:00:00"
        akhir = Format(TglAkhir.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        command = New SqlCommand("Lap_Margin_Rep2", MyConnection)
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
        Me.DataGridStock.DataSource = table
        'table.Columns.Add("Letter", GetType(Char))
        'table.Columns.Add("Number", GetType(Integer))
        'DataGridStock.ColumnCount = 15
        DataGridStock.Columns(0).HeaderText = "Tgl"
        DataGridStock.Columns(1).HeaderText = "No Struk"
        DataGridStock.Columns(2).HeaderText = "Kode Barang"
        DataGridStock.Columns(3).HeaderText = "Nama Barang"
        DataGridStock.Columns(4).HeaderText = "Satuan"
        DataGridStock.Columns(5).HeaderText = "Stock"
        DataGridStock.Columns(6).HeaderText = "Qty"
        DataGridStock.Columns(7).HeaderText = "Harga Jual"
        DataGridStock.Columns(8).HeaderText = "Discount"
        DataGridStock.Columns(9).HeaderText = "Harga Beli"
        DataGridStock.Columns(10).HeaderText = "Margin"
        DataGridStock.Columns(11).HeaderText = "Total Jual"
        DataGridStock.Columns(12).HeaderText = "Total Beli"
        DataGridStock.Columns(13).HeaderText = "Total Margin"
        DataGridStock.Columns(14).HeaderText = "Status"
        DataGridStock.Columns(15).HeaderText = "Sales Person"


        DataGridStock.Columns(0).Width = 70
        DataGridStock.Columns(1).Width = 120
        DataGridStock.Columns(2).Width = 80
        DataGridStock.Columns(3).Width = 250
        DataGridStock.Columns(4).Width = 50
        DataGridStock.Columns(5).Width = 50
        DataGridStock.Columns(6).Width = 50
        DataGridStock.Columns(7).Width = 80
        DataGridStock.Columns(8).Width = 80
        DataGridStock.Columns(9).Width = 80
        DataGridStock.Columns(10).Width = 80
        DataGridStock.Columns(11).Width = 80
        DataGridStock.Columns(12).Width = 80
        DataGridStock.Columns(13).Width = 80
        DataGridStock.Columns(14).Width = 80
        DataGridStock.Columns(15).Width = 100


        Dim hasilABM1 As Integer = 0
        For BarisABM1 As Integer = 0 To DataGridStock.RowCount - 1
            hasilABM1 = hasilABM1 + DataGridStock.Rows(BarisABM1).Cells(8).Value
        Next
        ABM1.Text = hasilABM1
        ABM1.Text = FormatCurrency(ABM1.Text)

        Dim hasilABM2 As Integer = 0
        For BarisABM2 As Integer = 0 To DataGridStock.RowCount - 1
            hasilABM2 = hasilABM1 + DataGridStock.Rows(BarisABM2).Cells(10).Value
        Next
        ABM2.Text = hasilABM2
        ABM2.Text = FormatCurrency(ABM2.Text)

        Dim hasilABM3 As Integer = 0
        For BarisABM3 As Integer = 0 To DataGridStock.RowCount - 1
            hasilABM3 = hasilABM3 + DataGridStock.Rows(BarisABM3).Cells(11).Value
        Next
        ABM3.Text = hasilABM3
        ABM3.Text = FormatCurrency(ABM3.Text)


        Dim hasilABM4 As Integer = 0
        For BarisABM4 As Integer = 0 To DataGridStock.RowCount - 1
            hasilABM4 = hasilABM4 + DataGridStock.Rows(BarisABM4).Cells(12).Value
        Next
        ABM4.Text = hasilABM4
        ABM4.Text = FormatCurrency(ABM4.Text)

        Dim hasilABM5 As Integer = 0
        For BarisABM5 As Integer = 0 To DataGridStock.RowCount - 1
            hasilABM5 = hasilABM5 + DataGridStock.Rows(BarisABM5).Cells(13).Value
        Next
        ABM5.Text = hasilABM5
        ABM5.Text = FormatCurrency(ABM5.Text)



        'AYANI
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "003")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewAyani.DataSource = table

        DataGridViewAyani.Columns(0).HeaderText = "Tgl"
        DataGridViewAyani.Columns(1).HeaderText = "No Struk"
        DataGridViewAyani.Columns(2).HeaderText = "Kode Barang"
        DataGridViewAyani.Columns(3).HeaderText = "Nama Barang"
        DataGridViewAyani.Columns(4).HeaderText = "Satuan"
        DataGridViewAyani.Columns(5).HeaderText = "Stock"
        DataGridViewAyani.Columns(6).HeaderText = "Qty"
        DataGridViewAyani.Columns(7).HeaderText = "Harga Jual"
        DataGridViewAyani.Columns(8).HeaderText = "Discount"
        DataGridViewAyani.Columns(9).HeaderText = "Harga Beli"
        DataGridViewAyani.Columns(10).HeaderText = "Margin"
        DataGridViewAyani.Columns(11).HeaderText = "Total Jual"
        DataGridViewAyani.Columns(12).HeaderText = "Total Beli"
        DataGridViewAyani.Columns(13).HeaderText = "Total Margin"
        DataGridViewAyani.Columns(14).HeaderText = "Status"
        DataGridViewAyani.Columns(15).HeaderText = "Sales Person"


        DataGridViewAyani.Columns(0).Width = 70
        DataGridViewAyani.Columns(1).Width = 120
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
        DataGridViewAyani.Columns(15).Width = 100

        Dim hasilAYANI1 As Integer = 0
        For BarisAYANI1 As Integer = 0 To DataGridViewAyani.RowCount - 1
            hasilAYANI1 = hasilAYANI1 + DataGridViewAyani.Rows(BarisAYANI1).Cells(8).Value
        Next
        Label10.Text = hasilAYANI1
        Label10.Text = FormatCurrency(Label10.Text)

        Dim hasilAYANI2 As Integer = 0
        For BarisAYANI2 As Integer = 0 To DataGridViewAyani.RowCount - 1
            hasilAYANI2 = hasilAYANI2 + DataGridViewAyani.Rows(BarisAYANI2).Cells(10).Value
        Next
        AYANI2.Text = hasilAYANI2
        AYANI2.Text = FormatCurrency(AYANI2.Text)

        Dim hasilAYANI3 As Integer = 0
        For BarisAYANI3 As Integer = 0 To DataGridViewAyani.RowCount - 1
            hasilAYANI3 = hasilAYANI3 + DataGridViewAyani.Rows(BarisAYANI3).Cells(11).Value
        Next
        AYANI3.Text = hasilABM3
        AYANI3.Text = FormatCurrency(AYANI3.Text)


        Dim hasilAYANI4 As Integer = 0
        For BarisAYANI4 As Integer = 0 To DataGridViewAyani.RowCount - 1
            hasilAYANI4 = hasilAYANI4 + DataGridViewAyani.Rows(BarisAYANI4).Cells(12).Value
        Next
        AYANI4.Text = hasilAYANI4
        AYANI4.Text = FormatCurrency(AYANI4.Text)

        Dim hasilAYANI5 As Integer = 0
        For BarisAYANI5 As Integer = 0 To DataGridViewAyani.RowCount - 1
            hasilAYANI5 = hasilAYANI5 + DataGridViewAyani.Rows(BarisAYANI5).Cells(13).Value
        Next
        AYANI5.Text = hasilAYANI5
        AYANI5.Text = FormatCurrency(AYANI5.Text)


        'CIBABAT
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "004")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCIBABAT.DataSource = table

        DataGridViewCIBABAT.Columns(0).HeaderText = "Tgl"
        DataGridViewCIBABAT.Columns(1).HeaderText = "No Struk"
        DataGridViewCIBABAT.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCIBABAT.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCIBABAT.Columns(4).HeaderText = "Satuan"
        DataGridViewCIBABAT.Columns(5).HeaderText = "Stock"
        DataGridViewCIBABAT.Columns(6).HeaderText = "Qty"
        DataGridViewCIBABAT.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCIBABAT.Columns(8).HeaderText = "Discount"
        DataGridViewCIBABAT.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCIBABAT.Columns(10).HeaderText = "Margin"
        DataGridViewCIBABAT.Columns(11).HeaderText = "Total Jual"
        DataGridViewCIBABAT.Columns(12).HeaderText = "Total Beli"
        DataGridViewCIBABAT.Columns(13).HeaderText = "Total Margin"
        DataGridViewCIBABAT.Columns(14).HeaderText = "Status"
        DataGridViewCIBABAT.Columns(15).HeaderText = "Sales Person"


        DataGridViewCIBABAT.Columns(0).Width = 70
        DataGridViewCIBABAT.Columns(1).Width = 120
        DataGridViewCIBABAT.Columns(2).Width = 80
        DataGridViewCIBABAT.Columns(3).Width = 250
        DataGridViewCIBABAT.Columns(4).Width = 50
        DataGridViewCIBABAT.Columns(5).Width = 50
        DataGridViewCIBABAT.Columns(6).Width = 50
        DataGridViewCIBABAT.Columns(7).Width = 80
        DataGridViewCIBABAT.Columns(8).Width = 80
        DataGridViewCIBABAT.Columns(9).Width = 80
        DataGridViewCIBABAT.Columns(10).Width = 80
        DataGridViewCIBABAT.Columns(11).Width = 80
        DataGridViewCIBABAT.Columns(12).Width = 80
        DataGridViewCIBABAT.Columns(13).Width = 80
        DataGridViewCIBABAT.Columns(14).Width = 80
        DataGridViewCIBABAT.Columns(15).Width = 100

        Dim hasilCIBABAT1 As Integer = 0
        For BarisCIBABAT1 As Integer = 0 To DataGridViewCIBABAT.RowCount - 1
            hasilCIBABAT1 = hasilCIBABAT1 + DataGridViewCIBABAT.Rows(BarisCIBABAT1).Cells(8).Value
        Next
        CIBABAT1.Text = hasilCIBABAT1
        CIBABAT1.Text = FormatCurrency(CIBABAT1.Text)

        Dim hasilCIBABAT2 As Integer = 0
        For BarisCIBABAT2 As Integer = 0 To DataGridViewCIBABAT.RowCount - 1
            hasilCIBABAT2 = hasilCIBABAT2 + DataGridViewCIBABAT.Rows(BarisCIBABAT2).Cells(10).Value
        Next
        CIBABAT2.Text = hasilCIBABAT2
        CIBABAT2.Text = FormatCurrency(CIBABAT2.Text)

        Dim hasilCIBABAT3 As Integer = 0
        For BarisCIBABAT3 As Integer = 0 To DataGridViewCIBABAT.RowCount - 1
            hasilCIBABAT3 = hasilCIBABAT3 + DataGridViewCIBABAT.Rows(BarisCIBABAT3).Cells(11).Value
        Next
        CIBABAT3.Text = hasilCIBABAT3
        CIBABAT3.Text = FormatCurrency(CIBABAT3.Text)


        Dim hasilCIBABAT4 As Integer = 0
        For BarisCIBABAT4 As Integer = 0 To DataGridViewCIBABAT.RowCount - 1
            hasilCIBABAT4 = hasilCIBABAT4 + DataGridViewCIBABAT.Rows(BarisCIBABAT4).Cells(12).Value
        Next
        CIBABAT4.Text = hasilCIBABAT4
        CIBABAT4.Text = FormatCurrency(CIBABAT4.Text)

        Dim hasilCIBABAT5 As Integer = 0
        For BarisCIBABAT5 As Integer = 0 To DataGridViewCIBABAT.RowCount - 1
            hasilCIBABAT5 = hasilCIBABAT5 + DataGridViewCIBABAT.Rows(BarisCIBABAT5).Cells(13).Value
        Next
        CIBABAT5.Text = hasilCIBABAT5
        CIBABAT5.Text = FormatCurrency(CIBABAT5.Text)


        'KOPO
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "005")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewKOPO.DataSource = table

        DataGridViewKOPO.Columns(0).HeaderText = "Tgl"
        DataGridViewKOPO.Columns(1).HeaderText = "No Struk"
        DataGridViewKOPO.Columns(2).HeaderText = "Kode Barang"
        DataGridViewKOPO.Columns(3).HeaderText = "Nama Barang"
        DataGridViewKOPO.Columns(4).HeaderText = "Satuan"
        DataGridViewKOPO.Columns(5).HeaderText = "Stock"
        DataGridViewKOPO.Columns(6).HeaderText = "Qty"
        DataGridViewKOPO.Columns(7).HeaderText = "Harga Jual"
        DataGridViewKOPO.Columns(8).HeaderText = "Discount"
        DataGridViewKOPO.Columns(9).HeaderText = "Harga Beli"
        DataGridViewKOPO.Columns(10).HeaderText = "Margin"
        DataGridViewKOPO.Columns(11).HeaderText = "Total Jual"
        DataGridViewKOPO.Columns(12).HeaderText = "Total Beli"
        DataGridViewKOPO.Columns(13).HeaderText = "Total Margin"
        DataGridViewKOPO.Columns(14).HeaderText = "Status"
        DataGridViewKOPO.Columns(15).HeaderText = "Sales Person"


        DataGridViewKOPO.Columns(0).Width = 70
        DataGridViewKOPO.Columns(1).Width = 120
        DataGridViewKOPO.Columns(2).Width = 80
        DataGridViewKOPO.Columns(3).Width = 250
        DataGridViewKOPO.Columns(4).Width = 50
        DataGridViewKOPO.Columns(5).Width = 50
        DataGridViewKOPO.Columns(6).Width = 50
        DataGridViewKOPO.Columns(7).Width = 80
        DataGridViewKOPO.Columns(8).Width = 80
        DataGridViewKOPO.Columns(9).Width = 80
        DataGridViewKOPO.Columns(10).Width = 80
        DataGridViewKOPO.Columns(11).Width = 80
        DataGridViewKOPO.Columns(12).Width = 80
        DataGridViewKOPO.Columns(13).Width = 80
        DataGridViewKOPO.Columns(14).Width = 80
        DataGridViewKOPO.Columns(15).Width = 100

        Dim hasilKOPO1 As Integer = 0
        For BarisKOPO1 As Integer = 0 To DataGridViewKOPO.RowCount - 1
            hasilKOPO1 = hasilKOPO1 + DataGridViewKOPO.Rows(BarisKOPO1).Cells(8).Value
        Next
        KOPO1.Text = hasilKOPO1
        KOPO1.Text = FormatCurrency(KOPO1.Text)

        Dim hasilKOPO2 As Integer = 0
        For BarisKOPO2 As Integer = 0 To DataGridViewKOPO.RowCount - 1
            hasilKOPO2 = hasilKOPO2 + DataGridViewKOPO.Rows(BarisKOPO2).Cells(10).Value
        Next
        KOPO2.Text = hasilCIBABAT1
        KOPO2.Text = FormatCurrency(KOPO2.Text)

        Dim hasilKOPO3 As Integer = 0
        For BarisKOPO3 As Integer = 0 To DataGridViewKOPO.RowCount - 1
            hasilKOPO3 = hasilKOPO3 + DataGridViewKOPO.Rows(BarisKOPO3).Cells(11).Value
        Next
        KOPO3.Text = hasilKOPO3
        KOPO3.Text = FormatCurrency(KOPO3.Text)


        Dim hasilKOPO4 As Integer = 0
        For BarisKOPO4 As Integer = 0 To DataGridViewKOPO.RowCount - 1
            hasilKOPO4 = hasilKOPO4 + DataGridViewKOPO.Rows(BarisKOPO4).Cells(12).Value
        Next
        KOPO4.Text = hasilKOPO4
        KOPO4.Text = FormatCurrency(KOPO4.Text)

        Dim hasilKOPO5 As Integer = 0
        For BarisKOPO5 As Integer = 0 To DataGridViewKOPO.RowCount - 1
            hasilKOPO5 = hasilKOPO5 + DataGridViewKOPO.Rows(BarisKOPO5).Cells(13).Value
        Next
        KOPO5.Text = hasilKOPO5
        KOPO5.Text = FormatCurrency(KOPO5.Text)

        'CIBIRU
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "006")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCIBIRU.DataSource = table

        DataGridViewCIBIRU.Columns(0).HeaderText = "Tgl"
        DataGridViewCIBIRU.Columns(1).HeaderText = "No Struk"
        DataGridViewCIBIRU.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCIBIRU.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCIBIRU.Columns(4).HeaderText = "Satuan"
        DataGridViewCIBIRU.Columns(5).HeaderText = "Stock"
        DataGridViewCIBIRU.Columns(6).HeaderText = "Qty"
        DataGridViewCIBIRU.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCIBIRU.Columns(8).HeaderText = "Discount"
        DataGridViewCIBIRU.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCIBIRU.Columns(10).HeaderText = "Margin"
        DataGridViewCIBIRU.Columns(11).HeaderText = "Total Jual"
        DataGridViewCIBIRU.Columns(12).HeaderText = "Total Beli"
        DataGridViewCIBIRU.Columns(13).HeaderText = "Total Margin"
        DataGridViewCIBIRU.Columns(14).HeaderText = "Status"
        DataGridViewCIBIRU.Columns(15).HeaderText = "Sales Person"


        DataGridViewCIBIRU.Columns(0).Width = 70
        DataGridViewCIBIRU.Columns(1).Width = 120
        DataGridViewCIBIRU.Columns(2).Width = 80
        DataGridViewCIBIRU.Columns(3).Width = 250
        DataGridViewCIBIRU.Columns(4).Width = 50
        DataGridViewCIBIRU.Columns(5).Width = 50
        DataGridViewCIBIRU.Columns(6).Width = 50
        DataGridViewCIBIRU.Columns(7).Width = 80
        DataGridViewCIBIRU.Columns(8).Width = 80
        DataGridViewCIBIRU.Columns(9).Width = 80
        DataGridViewCIBIRU.Columns(10).Width = 80
        DataGridViewCIBIRU.Columns(11).Width = 80
        DataGridViewCIBIRU.Columns(12).Width = 80
        DataGridViewCIBIRU.Columns(13).Width = 80
        DataGridViewCIBIRU.Columns(14).Width = 80
        DataGridViewCIBIRU.Columns(15).Width = 100

        Dim hasilCIBIRU1 As Integer = 0
        For BarisCIBIRU1 As Integer = 0 To DataGridViewCIBIRU.RowCount - 1
            hasilCIBIRU1 = hasilCIBIRU1 + DataGridViewCIBIRU.Rows(BarisCIBIRU1).Cells(8).Value
        Next
        CIBIRU1.Text = hasilCIBIRU1
        CIBIRU1.Text = FormatCurrency(CIBIRU1.Text)

        Dim hasilCIBIRU2 As Integer = 0
        For BarisCIBIRU2 As Integer = 0 To DataGridViewCIBIRU.RowCount - 1
            hasilCIBIRU2 = hasilCIBIRU2 + DataGridViewCIBIRU.Rows(BarisCIBIRU2).Cells(10).Value
        Next
        CIBIRU2.Text = hasilCIBIRU2
        CIBIRU2.Text = FormatCurrency(CIBIRU2.Text)

        Dim hasilCIBIRU3 As Integer = 0
        For BarisCIBIRU3 As Integer = 0 To DataGridViewCIBIRU.RowCount - 1
            hasilCIBIRU3 = hasilCIBIRU3 + DataGridViewCIBIRU.Rows(BarisCIBIRU3).Cells(11).Value
        Next
        CIBIRU3.Text = hasilCIBIRU3
        CIBIRU3.Text = FormatCurrency(CIBIRU3.Text)


        Dim hasilCIBIRU4 As Integer = 0
        For BarisCIBIRU4 As Integer = 0 To DataGridViewCIBIRU.RowCount - 1
            hasilCIBIRU4 = hasilCIBIRU4 + DataGridViewCIBIRU.Rows(BarisCIBIRU4).Cells(12).Value
        Next
        CIBIRU4.Text = hasilCIBIRU4
        CIBIRU4.Text = FormatCurrency(CIBIRU4.Text)

        Dim hasilCIBIRU5 As Integer = 0
        For BarisCIBIRU5 As Integer = 0 To DataGridViewCIBIRU.RowCount - 1
            hasilCIBIRU5 = hasilCIBIRU5 + DataGridViewCIBIRU.Rows(BarisCIBIRU5).Cells(13).Value
        Next
        CIBIRU5.Text = hasilCIBIRU5
        CIBIRU5.Text = FormatCurrency(CIBIRU5.Text)


        'GARUT
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "007")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewGARUT.DataSource = table

        DataGridViewGARUT.Columns(0).HeaderText = "Tgl"
        DataGridViewGARUT.Columns(1).HeaderText = "No Struk"
        DataGridViewGARUT.Columns(2).HeaderText = "Kode Barang"
        DataGridViewGARUT.Columns(3).HeaderText = "Nama Barang"
        DataGridViewGARUT.Columns(4).HeaderText = "Satuan"
        DataGridViewGARUT.Columns(5).HeaderText = "Stock"
        DataGridViewGARUT.Columns(6).HeaderText = "Qty"
        DataGridViewGARUT.Columns(7).HeaderText = "Harga Jual"
        DataGridViewGARUT.Columns(8).HeaderText = "Discount"
        DataGridViewGARUT.Columns(9).HeaderText = "Harga Beli"
        DataGridViewGARUT.Columns(10).HeaderText = "Margin"
        DataGridViewGARUT.Columns(11).HeaderText = "Total Jual"
        DataGridViewGARUT.Columns(12).HeaderText = "Total Beli"
        DataGridViewGARUT.Columns(13).HeaderText = "Total Margin"
        DataGridViewGARUT.Columns(14).HeaderText = "Status"
        DataGridViewGARUT.Columns(15).HeaderText = "Sales Person"


        DataGridViewGARUT.Columns(0).Width = 70
        DataGridViewGARUT.Columns(1).Width = 120
        DataGridViewGARUT.Columns(2).Width = 80
        DataGridViewGARUT.Columns(3).Width = 250
        DataGridViewGARUT.Columns(4).Width = 50
        DataGridViewGARUT.Columns(5).Width = 50
        DataGridViewGARUT.Columns(6).Width = 50
        DataGridViewGARUT.Columns(7).Width = 80
        DataGridViewGARUT.Columns(8).Width = 80
        DataGridViewGARUT.Columns(9).Width = 80
        DataGridViewGARUT.Columns(10).Width = 80
        DataGridViewGARUT.Columns(11).Width = 80
        DataGridViewGARUT.Columns(12).Width = 80
        DataGridViewGARUT.Columns(13).Width = 80
        DataGridViewGARUT.Columns(14).Width = 80
        DataGridViewGARUT.Columns(15).Width = 100

        Dim hasilGARUT1 As Integer = 0
        For BarisGARUT1 As Integer = 0 To DataGridViewGARUT.RowCount - 1
            hasilGARUT1 = hasilGARUT1 + DataGridViewGARUT.Rows(BarisGARUT1).Cells(8).Value
        Next
        GARUT1.Text = hasilGARUT1
        GARUT1.Text = FormatCurrency(GARUT1.Text)

        Dim hasilGARUT2 As Integer = 0
        For BarisGARUT2 As Integer = 0 To DataGridViewGARUT.RowCount - 1
            hasilGARUT2 = hasilGARUT2 + DataGridViewGARUT.Rows(BarisGARUT2).Cells(10).Value
        Next
        GARUT2.Text = hasilGARUT2
        GARUT2.Text = FormatCurrency(GARUT2.Text)

        Dim hasilGARUT3 As Integer = 0
        For BarisGARUT3 As Integer = 0 To DataGridViewGARUT.RowCount - 1
            hasilGARUT3 = hasilGARUT3 + DataGridViewGARUT.Rows(BarisGARUT3).Cells(11).Value
        Next
        GARUT3.Text = hasilGARUT3
        GARUT3.Text = FormatCurrency(GARUT3.Text)


        Dim hasilGARUT4 As Integer = 0
        For BarisGARUT4 As Integer = 0 To DataGridViewGARUT.RowCount - 1
            hasilGARUT4 = hasilGARUT4 + DataGridViewGARUT.Rows(BarisGARUT4).Cells(12).Value
        Next
        GARUT4.Text = hasilGARUT4
        GARUT4.Text = FormatCurrency(GARUT4.Text)

        Dim hasilGARUT5 As Integer = 0
        For BarisGARUT5 As Integer = 0 To DataGridViewGARUT.RowCount - 1
            hasilGARUT5 = hasilGARUT5 + DataGridViewGARUT.Rows(BarisGARUT5).Cells(13).Value
        Next
        GARUT5.Text = hasilGARUT5
        GARUT5.Text = FormatCurrency(GARUT5.Text)

        'CIREBON
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "008")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewCIREBON.DataSource = table

        DataGridViewCIREBON.Columns(0).HeaderText = "Tgl"
        DataGridViewCIREBON.Columns(1).HeaderText = "No Struk"
        DataGridViewCIREBON.Columns(2).HeaderText = "Kode Barang"
        DataGridViewCIREBON.Columns(3).HeaderText = "Nama Barang"
        DataGridViewCIREBON.Columns(4).HeaderText = "Satuan"
        DataGridViewCIREBON.Columns(5).HeaderText = "Stock"
        DataGridViewCIREBON.Columns(6).HeaderText = "Qty"
        DataGridViewCIREBON.Columns(7).HeaderText = "Harga Jual"
        DataGridViewCIREBON.Columns(8).HeaderText = "Discount"
        DataGridViewCIREBON.Columns(9).HeaderText = "Harga Beli"
        DataGridViewCIREBON.Columns(10).HeaderText = "Margin"
        DataGridViewCIREBON.Columns(11).HeaderText = "Total Jual"
        DataGridViewCIREBON.Columns(12).HeaderText = "Total Beli"
        DataGridViewCIREBON.Columns(13).HeaderText = "Total Margin"
        DataGridViewCIREBON.Columns(14).HeaderText = "Status"
        DataGridViewCIREBON.Columns(15).HeaderText = "Sales Person"


        DataGridViewCIREBON.Columns(0).Width = 70
        DataGridViewCIREBON.Columns(1).Width = 120
        DataGridViewCIREBON.Columns(2).Width = 80
        DataGridViewCIREBON.Columns(3).Width = 250
        DataGridViewCIREBON.Columns(4).Width = 50
        DataGridViewCIREBON.Columns(5).Width = 50
        DataGridViewCIREBON.Columns(6).Width = 50
        DataGridViewCIREBON.Columns(7).Width = 80
        DataGridViewCIREBON.Columns(8).Width = 80
        DataGridViewCIREBON.Columns(9).Width = 80
        DataGridViewCIREBON.Columns(10).Width = 80
        DataGridViewCIREBON.Columns(11).Width = 80
        DataGridViewCIREBON.Columns(12).Width = 80
        DataGridViewCIREBON.Columns(13).Width = 80
        DataGridViewCIREBON.Columns(14).Width = 80
        DataGridViewCIREBON.Columns(15).Width = 100

        Dim hasilCIREBON1 As Integer = 0
        For BarisCIREBON1 As Integer = 0 To DataGridViewCIREBON.RowCount - 1
            hasilCIREBON1 = hasilCIREBON1 + DataGridViewCIREBON.Rows(BarisCIREBON1).Cells(8).Value
        Next
        CIREBON1.Text = hasilCIREBON1
        CIREBON1.Text = FormatCurrency(CIREBON1.Text)

        Dim hasilCIREBON2 As Integer = 0
        For BarisCIREBON2 As Integer = 0 To DataGridViewCIREBON.RowCount - 1
            hasilCIREBON2 = hasilCIREBON2 + DataGridViewCIREBON.Rows(BarisCIREBON2).Cells(10).Value
        Next
        CIREBON2.Text = hasilCIREBON2
        CIREBON2.Text = FormatCurrency(CIREBON2.Text)

        Dim hasilCIREBON3 As Integer = 0
        For BarisCIREBON3 As Integer = 0 To DataGridViewCIREBON.RowCount - 1
            hasilCIREBON3 = hasilCIREBON3 + DataGridViewCIREBON.Rows(BarisCIREBON3).Cells(11).Value
        Next
        CIREBON3.Text = hasilCIREBON3
        CIREBON3.Text = FormatCurrency(CIREBON3.Text)


        Dim hasilCIREBON4 As Integer = 0
        For BarisCIREBON4 As Integer = 0 To DataGridViewCIREBON.RowCount - 1
            hasilCIREBON4 = hasilCIREBON4 + DataGridViewCIREBON.Rows(BarisCIREBON4).Cells(12).Value
        Next
        CIREBON4.Text = hasilCIREBON4
        CIREBON4.Text = FormatCurrency(CIREBON4.Text)

        Dim hasilCIREBON5 As Integer = 0
        For BarisCIREBON5 As Integer = 0 To DataGridViewCIREBON.RowCount - 1
            hasilCIREBON5 = hasilCIREBON5 + DataGridViewCIREBON.Rows(BarisCIREBON5).Cells(13).Value
        Next
        CIREBON5.Text = hasilCIREBON5
        CIREBON5.Text = FormatCurrency(CIREBON5.Text)

        'SUEMDANG
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "009")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewSUMEDANG.DataSource = table

        DataGridViewSUMEDANG.Columns(0).HeaderText = "Tgl"
        DataGridViewSUMEDANG.Columns(1).HeaderText = "No Struk"
        DataGridViewSUMEDANG.Columns(2).HeaderText = "Kode Barang"
        DataGridViewSUMEDANG.Columns(3).HeaderText = "Nama Barang"
        DataGridViewSUMEDANG.Columns(4).HeaderText = "Satuan"
        DataGridViewSUMEDANG.Columns(5).HeaderText = "Stock"
        DataGridViewSUMEDANG.Columns(6).HeaderText = "Qty"
        DataGridViewSUMEDANG.Columns(7).HeaderText = "Harga Jual"
        DataGridViewSUMEDANG.Columns(8).HeaderText = "Discount"
        DataGridViewSUMEDANG.Columns(9).HeaderText = "Harga Beli"
        DataGridViewSUMEDANG.Columns(10).HeaderText = "Margin"
        DataGridViewSUMEDANG.Columns(11).HeaderText = "Total Jual"
        DataGridViewSUMEDANG.Columns(12).HeaderText = "Total Beli"
        DataGridViewSUMEDANG.Columns(13).HeaderText = "Total Margin"
        DataGridViewSUMEDANG.Columns(14).HeaderText = "Status"
        DataGridViewSUMEDANG.Columns(15).HeaderText = "Sales Person"


        DataGridViewSUMEDANG.Columns(0).Width = 70
        DataGridViewSUMEDANG.Columns(1).Width = 120
        DataGridViewSUMEDANG.Columns(2).Width = 80
        DataGridViewSUMEDANG.Columns(3).Width = 250
        DataGridViewSUMEDANG.Columns(4).Width = 50
        DataGridViewSUMEDANG.Columns(5).Width = 50
        DataGridViewSUMEDANG.Columns(6).Width = 50
        DataGridViewSUMEDANG.Columns(7).Width = 80
        DataGridViewSUMEDANG.Columns(8).Width = 80
        DataGridViewSUMEDANG.Columns(9).Width = 80
        DataGridViewSUMEDANG.Columns(10).Width = 80
        DataGridViewSUMEDANG.Columns(11).Width = 80
        DataGridViewSUMEDANG.Columns(12).Width = 80
        DataGridViewSUMEDANG.Columns(13).Width = 80
        DataGridViewSUMEDANG.Columns(14).Width = 80
        DataGridViewSUMEDANG.Columns(15).Width = 100

        Dim hasilSUMEDANG1 As Integer = 0
        For BarisSUMEDANG1 As Integer = 0 To DataGridViewSUMEDANG.RowCount - 1
            hasilSUMEDANG1 = hasilSUMEDANG1 + DataGridViewSUMEDANG.Rows(BarisSUMEDANG1).Cells(8).Value
        Next
        SUMEDANG1.Text = hasilSUMEDANG1
        SUMEDANG1.Text = FormatCurrency(SUMEDANG1.Text)

        Dim hasilSUMEDANG2 As Integer = 0
        For BarisSUMEDANG2 As Integer = 0 To DataGridViewSUMEDANG.RowCount - 1
            hasilSUMEDANG2 = hasilSUMEDANG2 + DataGridViewSUMEDANG.Rows(BarisSUMEDANG2).Cells(10).Value
        Next
        SUMEDANG2.Text = hasilSUMEDANG2
        SUMEDANG2.Text = FormatCurrency(SUMEDANG2.Text)

        Dim hasilSUMEDANG3 As Integer = 0
        For BarisSUMEDANG3 As Integer = 0 To DataGridViewSUMEDANG.RowCount - 1
            hasilSUMEDANG3 = hasilSUMEDANG3 + DataGridViewSUMEDANG.Rows(BarisSUMEDANG3).Cells(11).Value
        Next
        SUMEDANG3.Text = hasilSUMEDANG3
        SUMEDANG3.Text = FormatCurrency(SUMEDANG3.Text)


        Dim hasilSUMEDANG4 As Integer = 0
        For BarisSUMEDANG4 As Integer = 0 To DataGridViewSUMEDANG.RowCount - 1
            hasilSUMEDANG4 = hasilSUMEDANG4 + DataGridViewSUMEDANG.Rows(BarisSUMEDANG4).Cells(12).Value
        Next
        SUMEDANG4.Text = hasilSUMEDANG4
        SUMEDANG4.Text = FormatCurrency(SUMEDANG4.Text)

        Dim hasilSUMEDANG5 As Integer = 0
        For BarisSUMEDANG5 As Integer = 0 To DataGridViewSUMEDANG.RowCount - 1
            hasilSUMEDANG5 = hasilSUMEDANG5 + DataGridViewSUMEDANG.Rows(BarisSUMEDANG5).Cells(13).Value
        Next
        SUMEDANG5.Text = hasilSUMEDANG5
        SUMEDANG5.Text = FormatCurrency(SUMEDANG5.Text)

        'CIPARAY
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "010")
        table = New DataTable
        adapter.Fill(table)
        Me.datagridviewCIPARAY.DataSource = table

        datagridviewCIPARAY.Columns(0).HeaderText = "Tgl"
        datagridviewCIPARAY.Columns(1).HeaderText = "No Struk"
        datagridviewCIPARAY.Columns(2).HeaderText = "Kode Barang"
        datagridviewCIPARAY.Columns(3).HeaderText = "Nama Barang"
        datagridviewCIPARAY.Columns(4).HeaderText = "Satuan"
        datagridviewCIPARAY.Columns(5).HeaderText = "Stock"
        datagridviewCIPARAY.Columns(6).HeaderText = "Qty"
        datagridviewCIPARAY.Columns(7).HeaderText = "Harga Jual"
        datagridviewCIPARAY.Columns(8).HeaderText = "Discount"
        datagridviewCIPARAY.Columns(9).HeaderText = "Harga Beli"
        datagridviewCIPARAY.Columns(10).HeaderText = "Margin"
        datagridviewCIPARAY.Columns(11).HeaderText = "Total Jual"
        datagridviewCIPARAY.Columns(12).HeaderText = "Total Beli"
        datagridviewCIPARAY.Columns(13).HeaderText = "Total Margin"
        datagridviewCIPARAY.Columns(14).HeaderText = "Status"
        datagridviewCIPARAY.Columns(15).HeaderText = "Sales Person"


        datagridviewCIPARAY.Columns(0).Width = 70
        datagridviewCIPARAY.Columns(1).Width = 120
        datagridviewCIPARAY.Columns(2).Width = 80
        datagridviewCIPARAY.Columns(3).Width = 250
        datagridviewCIPARAY.Columns(4).Width = 50
        datagridviewCIPARAY.Columns(5).Width = 50
        datagridviewCIPARAY.Columns(6).Width = 50
        datagridviewCIPARAY.Columns(7).Width = 80
        datagridviewCIPARAY.Columns(8).Width = 80
        datagridviewCIPARAY.Columns(9).Width = 80
        datagridviewCIPARAY.Columns(10).Width = 80
        datagridviewCIPARAY.Columns(11).Width = 80
        datagridviewCIPARAY.Columns(12).Width = 80
        datagridviewCIPARAY.Columns(13).Width = 80
        datagridviewCIPARAY.Columns(14).Width = 80
        datagridviewCIPARAY.Columns(15).Width = 100

        Dim hasilCIPARAY1 As Integer = 0
        For BarisCIPARAY1 As Integer = 0 To datagridviewCIPARAY.RowCount - 1
            hasilCIPARAY1 = hasilCIPARAY1 + datagridviewCIPARAY.Rows(BarisCIPARAY1).Cells(8).Value
        Next
        CIPARAY1.Text = hasilCIPARAY1
        CIPARAY1.Text = FormatCurrency(CIPARAY1.Text)

        Dim hasilCIPARAY2 As Integer = 0
        For BarisCIPARAY2 As Integer = 0 To datagridviewCIPARAY.RowCount - 1
            hasilCIPARAY2 = hasilCIPARAY2 + datagridviewCIPARAY.Rows(BarisCIPARAY2).Cells(10).Value
        Next
        CIPARAY2.Text = hasilCIPARAY2
        CIPARAY2.Text = FormatCurrency(CIPARAY2.Text)

        Dim hasilCIPARAY3 As Integer = 0
        For BarisCIPARAY3 As Integer = 0 To datagridviewCIPARAY.RowCount - 1
            hasilCIPARAY3 = hasilCIPARAY3 + datagridviewCIPARAY.Rows(BarisCIPARAY3).Cells(11).Value
        Next
        CIPARAY3.Text = hasilCIPARAY3
        CIPARAY3.Text = FormatCurrency(CIPARAY3.Text)


        Dim hasilCIPARAY4 As Integer = 0
        For BarisCIPARAY4 As Integer = 0 To datagridviewCIPARAY.RowCount - 1
            hasilCIPARAY4 = hasilCIPARAY4 + datagridviewCIPARAY.Rows(BarisCIPARAY4).Cells(12).Value
        Next
        CIPARAY4.Text = hasilCIPARAY4
        CIPARAY4.Text = FormatCurrency(CIPARAY4.Text)

        Dim hasilCIPARAY5 As Integer = 0
        For BarisCIPARAY5 As Integer = 0 To datagridviewCIPARAY.RowCount - 1
            hasilCIPARAY5 = hasilCIPARAY5 + datagridviewCIPARAY.Rows(BarisCIPARAY5).Cells(13).Value
        Next
        CIPARAY5.Text = hasilCIPARAY5
        CIPARAY5.Text = FormatCurrency(CIPARAY5.Text)


        'RANCAEKEK
        command = New SqlCommand("Lap_margin_rep2", MyConnection)

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "011")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridViewRANCAEKEK.DataSource = table

        DataGridViewRANCAEKEK.Columns(0).HeaderText = "Tgl"
        DataGridViewRANCAEKEK.Columns(1).HeaderText = "No Struk"
        DataGridViewRANCAEKEK.Columns(2).HeaderText = "Kode Barang"
        DataGridViewRANCAEKEK.Columns(3).HeaderText = "Nama Barang"
        DataGridViewRANCAEKEK.Columns(4).HeaderText = "Satuan"
        DataGridViewRANCAEKEK.Columns(5).HeaderText = "Stock"
        DataGridViewRANCAEKEK.Columns(6).HeaderText = "Qty"
        DataGridViewRANCAEKEK.Columns(7).HeaderText = "Harga Jual"
        DataGridViewRANCAEKEK.Columns(8).HeaderText = "Discount"
        DataGridViewRANCAEKEK.Columns(9).HeaderText = "Harga Beli"
        DataGridViewRANCAEKEK.Columns(10).HeaderText = "Margin"
        DataGridViewRANCAEKEK.Columns(11).HeaderText = "Total Jual"
        DataGridViewRANCAEKEK.Columns(12).HeaderText = "Total Beli"
        DataGridViewRANCAEKEK.Columns(13).HeaderText = "Total Margin"
        DataGridViewRANCAEKEK.Columns(14).HeaderText = "Status"
        DataGridViewRANCAEKEK.Columns(15).HeaderText = "Sales Person"


        DataGridViewRANCAEKEK.Columns(0).Width = 70
        DataGridViewRANCAEKEK.Columns(1).Width = 120
        DataGridViewRANCAEKEK.Columns(2).Width = 80
        DataGridViewRANCAEKEK.Columns(3).Width = 250
        DataGridViewRANCAEKEK.Columns(4).Width = 50
        DataGridViewRANCAEKEK.Columns(5).Width = 50
        DataGridViewRANCAEKEK.Columns(6).Width = 50
        DataGridViewRANCAEKEK.Columns(7).Width = 80
        DataGridViewRANCAEKEK.Columns(8).Width = 80
        DataGridViewRANCAEKEK.Columns(9).Width = 80
        DataGridViewRANCAEKEK.Columns(10).Width = 80
        DataGridViewRANCAEKEK.Columns(11).Width = 80
        DataGridViewRANCAEKEK.Columns(12).Width = 80
        DataGridViewRANCAEKEK.Columns(13).Width = 80
        DataGridViewRANCAEKEK.Columns(14).Width = 80
        DataGridViewRANCAEKEK.Columns(15).Width = 100

        Dim hasilRANCAEKEK1 As Integer = 0
        For BarisRANCAEKEK1 As Integer = 0 To DataGridViewRANCAEKEK.RowCount - 1
            hasilRANCAEKEK1 = hasilRANCAEKEK1 + DataGridViewRANCAEKEK.Rows(BarisRANCAEKEK1).Cells(8).Value
        Next
        RANCAEKEK1.Text = hasilRANCAEKEK1
        RANCAEKEK1.Text = FormatCurrency(RANCAEKEK1.Text)

        Dim hasilRANCAEKEK2 As Integer = 0
        For BarisRANCAEKEK2 As Integer = 0 To DataGridViewRANCAEKEK.RowCount - 1
            hasilRANCAEKEK2 = hasilRANCAEKEK2 + DataGridViewRANCAEKEK.Rows(BarisRANCAEKEK2).Cells(10).Value
        Next
        RANCAEKEK2.Text = hasilRANCAEKEK2
        RANCAEKEK2.Text = FormatCurrency(RANCAEKEK2.Text)

        Dim hasilRANCAEKEK3 As Integer = 0
        For BarisRANCAEKEK3 As Integer = 0 To DataGridViewRANCAEKEK.RowCount - 1
            hasilRANCAEKEK3 = hasilRANCAEKEK3 + DataGridViewRANCAEKEK.Rows(BarisRANCAEKEK3).Cells(11).Value
        Next
        RANCAEKEK3.Text = hasilRANCAEKEK3
        RANCAEKEK3.Text = FormatCurrency(RANCAEKEK3.Text)


        Dim hasilRANCAEKEK4 As Integer = 0
        For BarisRANCAEKEK4 As Integer = 0 To DataGridViewRANCAEKEK.RowCount - 1
            hasilRANCAEKEK4 = hasilRANCAEKEK4 + DataGridViewRANCAEKEK.Rows(BarisRANCAEKEK4).Cells(12).Value
        Next
        RANCAEKEK4.Text = hasilRANCAEKEK4
        RANCAEKEK4.Text = FormatCurrency(RANCAEKEK4.Text)

        Dim hasilRANCAEKEK5 As Integer = 0
        For BarisRANCAEKEK5 As Integer = 0 To DataGridViewRANCAEKEK.RowCount - 1
            hasilRANCAEKEK5 = hasilRANCAEKEK5 + DataGridViewRANCAEKEK.Rows(BarisRANCAEKEK5).Cells(13).Value
        Next
        RANCAEKEK5.Text = hasilRANCAEKEK5
        RANCAEKEK5.Text = FormatCurrency(RANCAEKEK5.Text)



    End Sub

    Private Sub DataGridStock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridStock.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MyCommand = New SqlDataAdapter("select t0.WhsCode,t2.WhsName,t0.OnHand-t0.IsCommited,t0.OnHand,t0.IsCommited,t0.OnOrder from oitw t0 left join oitm t1 on t1.ItemCode=t0.ItemCode left join owhs t2 on t2.WhsCode=t0.WhsCode where (t0.WhsCode not like '%002' and t0.whscode not like '01000001' and t0.WhsCode not like '%003' and t0.WhsCode  not like 'ds') and t0.ItemCode='" + TextBox1.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "oitw")
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = DtSet.Tables("oitw").DefaultView


        DataGridView1.Columns(0).HeaderText = "Kode Warehouse"
        DataGridView1.Columns(1).HeaderText = "Nama Warehouse"
        DataGridView1.Columns(2).HeaderText = "Stock Akhir"
        DataGridView1.Columns(3).HeaderText = "Stock Awal"
        DataGridView1.Columns(4).HeaderText = "Keluar Barang"
        DataGridView1.Columns(5).HeaderText = "On Order"

        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 180
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50

        DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
    End Sub

  

    Private Sub DataGridStock_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridStock.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridStock.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewAyani_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewAyani.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewAyani.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewCIBABAT_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCIBABAT.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewCIBABAT.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewCIBIRU_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCIBIRU.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewCIBIRU.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub datagridviewCIPARAY_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles datagridviewCIPARAY.CellMouseClick
        On Error Resume Next
        TextBox1.Text = datagridviewCIPARAY.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewCIREBON_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCIREBON.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewCIREBON.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewGARUT_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewGARUT.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewGARUT.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewKOPO_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewKOPO.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewKOPO.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewRANCAEKEK_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewRANCAEKEK.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewRANCAEKEK.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewSUMEDANG_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewSUMEDANG.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridViewSUMEDANG.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub
End Class