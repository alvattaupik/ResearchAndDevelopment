Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph



Public Class delivery
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
    Dim i As Integer


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

        PictureBox1.Visible = True
        Button1.Enabled = False
        Me.Refresh()

        Koneksi()
        Dim i As Integer
        'Dim awal, akhir As String
        'awal = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00"
        'akhir = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:00:00"

        Dim command As SqlCommand
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "001")
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridABM.ColumnCount = 7
        DataGridABM.Columns(0).HeaderText = "No"
        DataGridABM.Columns(1).HeaderText = "Tanggal"
        DataGridABM.Columns(2).HeaderText = "No Dokumen"
        DataGridABM.Columns(2).HeaderText = "No Dokumen"
        DataGridABM.Columns(3).HeaderText = "Alamat"
        DataGridABM.Columns(4).HeaderText = "Nama Customer"
        DataGridABM.Columns(5).HeaderText = "Keterangan"
        DataGridABM.Columns(6).HeaderText = "Sales"

        

        


        DataGridABM.Columns(0).Width = 50
        DataGridABM.Columns(1).Width = 70
        DataGridABM.Columns(2).Width = 80
        DataGridABM.Columns(3).Width = 350
        DataGridABM.Columns(4).Width = 100
        DataGridABM.Columns(5).Width = 350
        DataGridABM.Columns(6).Width = 150
        

       


        'DataGridABM.Columns(14).Visible = False

        Dim hasil As Integer = 0
        Dim hasil1 As Integer = 0
        Dim hasil2 As Integer = 0
        Dim hasil3 As Integer = 0
        Dim hasil4 As Integer = 0
        Dim hasil5 As Integer = 0
        Dim hasil6 As Integer = 0

        For i = 0 To DataGridView1.RowCount - 1
            DataGridABM.RowCount = DataGridABM.RowCount + 1
            DataGridABM.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridABM.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridABM.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridABM.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridABM.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridABM.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridABM.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

            
            


        Next

       
        'DataGridABM.Columns(11).DefaultCellStyle.Format = "N0"


        'Ayani
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "003")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewAyani.ColumnCount = 7
        DataGridViewAyani.Columns(0).HeaderText = "No"
        DataGridViewAyani.Columns(1).HeaderText = "Tanggal"
        DataGridViewAyani.Columns(2).HeaderText = "No Dokumen"
        DataGridViewAyani.Columns(3).HeaderText = "Alamat"
        DataGridViewAyani.Columns(4).HeaderText = "Nama Customer"
        DataGridViewAyani.Columns(5).HeaderText = "Keterangan"
        DataGridViewAyani.Columns(6).HeaderText = "Sales"

        DataGridViewAyani.Columns(0).Width = 50
        DataGridViewAyani.Columns(1).Width = 70
        DataGridViewAyani.Columns(2).Width = 80
        DataGridViewAyani.Columns(3).Width = 350
        DataGridViewAyani.Columns(4).Width = 100
        DataGridViewAyani.Columns(5).Width = 350
        DataGridViewAyani.Columns(6).Width = 150
        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewAyani.RowCount = DataGridViewAyani.RowCount + 1
            DataGridViewAyani.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewAyani.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewAyani.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewAyani.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewAyani.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewAyani.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewAyani.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next



        'Cibabat
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "004")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCibabat.ColumnCount = 7
        DataGridViewCibabat.Columns(0).HeaderText = "No"
        DataGridViewCibabat.Columns(1).HeaderText = "Tanggal"
        DataGridViewCibabat.Columns(2).HeaderText = "No Dokumen"
        DataGridViewCibabat.Columns(3).HeaderText = "Alamat"
        DataGridViewCibabat.Columns(4).HeaderText = "Nama Customer"
        DataGridViewCibabat.Columns(5).HeaderText = "Keterangan"
        DataGridViewCibabat.Columns(6).HeaderText = "Sales"


        DataGridViewCibabat.Columns(0).Width = 50
        DataGridViewCibabat.Columns(1).Width = 70
        DataGridViewCibabat.Columns(2).Width = 80
        DataGridViewCibabat.Columns(3).Width = 350
        DataGridViewCibabat.Columns(4).Width = 100
        DataGridViewCibabat.Columns(5).Width = 350
        DataGridViewCibabat.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCibabat.RowCount = DataGridViewCibabat.RowCount + 1
            DataGridViewCibabat.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewCibabat.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewCibabat.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewCibabat.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewCibabat.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCibabat.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewCibabat.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

       

        'Kopo
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "005")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewKopo.ColumnCount = 7
        DataGridViewKopo.Columns(0).HeaderText = "No"
        DataGridViewKopo.Columns(1).HeaderText = "Tanggal"
        DataGridViewKopo.Columns(2).HeaderText = "No Dokumen"
        DataGridViewKopo.Columns(3).HeaderText = "Alamat"
        DataGridViewKopo.Columns(4).HeaderText = "Nama Customer"
        DataGridViewKopo.Columns(5).HeaderText = "Keterangan"
        DataGridViewKopo.Columns(6).HeaderText = "Sales"

        DataGridViewKopo.Columns(0).Width = 50
        DataGridViewKopo.Columns(1).Width = 70
        DataGridViewKopo.Columns(2).Width = 80
        DataGridViewKopo.Columns(3).Width = 350
        DataGridViewKopo.Columns(4).Width = 100
        DataGridViewKopo.Columns(5).Width = 350
        DataGridViewKopo.Columns(6).Width = 150
        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewKopo.RowCount = DataGridViewKopo.RowCount + 1
            DataGridViewKopo.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewKopo.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewKopo.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewKopo.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewKopo.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewKopo.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewKopo.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

   

        'Cibiru
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "006")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCibiru.ColumnCount = 7
        DataGridViewCibiru.Columns(0).HeaderText = "No"
        DataGridViewCibiru.Columns(1).HeaderText = "Tanggal"
        DataGridViewCibiru.Columns(2).HeaderText = "No Dokument"
        DataGridViewCibiru.Columns(3).HeaderText = "Alamat"
        DataGridViewCibiru.Columns(4).HeaderText = "Nama Customer"
        DataGridViewCibiru.Columns(5).HeaderText = "Keterangan"
        DataGridViewCibiru.Columns(6).HeaderText = "Sales"



        DataGridViewCibiru.Columns(0).Width = 50
        DataGridViewCibiru.Columns(1).Width = 70
        DataGridViewCibiru.Columns(2).Width = 80
        DataGridViewCibiru.Columns(3).Width = 350
        DataGridViewCibiru.Columns(4).Width = 100
        DataGridViewCibiru.Columns(5).Width = 350
        DataGridViewCibiru.Columns(6).Width = 150
        
        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCibiru.RowCount = DataGridViewCibiru.RowCount + 1
            DataGridViewCibiru.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewCibiru.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewCibiru.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewCibiru.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewCibiru.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCibiru.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewCibiru.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value
            

        Next

        

        'Garut
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "007")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewGarut.ColumnCount = 7
        DataGridViewGarut.Columns(0).HeaderText = "No"
        DataGridViewGarut.Columns(1).HeaderText = "Tanggal"
        DataGridViewGarut.Columns(2).HeaderText = "No Dokumen"
        DataGridViewGarut.Columns(3).HeaderText = "Alamat"
        DataGridViewGarut.Columns(4).HeaderText = "Nama Customer"
        DataGridViewGarut.Columns(5).HeaderText = "Keterangan"
        DataGridViewGarut.Columns(6).HeaderText = "Sales"
        



        DataGridViewGarut.Columns(0).Width = 50
        DataGridViewGarut.Columns(1).Width = 70
        DataGridViewGarut.Columns(2).Width = 80
        DataGridViewGarut.Columns(3).Width = 350
        DataGridViewGarut.Columns(4).Width = 100
        DataGridViewGarut.Columns(5).Width = 350
        DataGridViewGarut.Columns(6).Width = 150
   
        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewGarut.RowCount = DataGridViewGarut.RowCount + 1
            DataGridViewGarut.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewGarut.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewGarut.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewGarut.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewGarut.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewGarut.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewGarut.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

    

        'Cirebon
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "008")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCirebon.ColumnCount = 7
        DataGridViewCirebon.Columns(0).HeaderText = "No"
        DataGridViewCirebon.Columns(1).HeaderText = "Tanggal"
        DataGridViewCirebon.Columns(2).HeaderText = "No Dokument"
        DataGridViewCirebon.Columns(3).HeaderText = "Alamat"
        DataGridViewCirebon.Columns(4).HeaderText = "Nama Customer"
        DataGridViewCirebon.Columns(5).HeaderText = "Keterangan"
        DataGridViewCirebon.Columns(6).HeaderText = "Sales"
        



        DataGridViewCirebon.Columns(0).Width = 50
        DataGridViewCirebon.Columns(1).Width = 70
        DataGridViewCirebon.Columns(2).Width = 80
        DataGridViewCirebon.Columns(3).Width = 350
        DataGridViewCirebon.Columns(4).Width = 100
        DataGridViewCirebon.Columns(5).Width = 350
        DataGridViewCirebon.Columns(6).Width = 150
      
        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCirebon.RowCount = DataGridViewCirebon.RowCount + 1
            DataGridViewCirebon.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewCirebon.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewCirebon.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewCirebon.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewCirebon.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCirebon.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewCirebon.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

      

        'Sumedang
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "009")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewSumedang.ColumnCount = 7
        DataGridViewSumedang.Columns(0).HeaderText = "No"
        DataGridViewSumedang.Columns(1).HeaderText = "Tanggal"
        DataGridViewSumedang.Columns(2).HeaderText = "No dokument"
        DataGridViewSumedang.Columns(3).HeaderText = "Alamat"
        DataGridViewSumedang.Columns(4).HeaderText = "Nama Customer"
        DataGridViewSumedang.Columns(5).HeaderText = "Keterangan"
        DataGridViewSumedang.Columns(6).HeaderText = "Sales"



        DataGridViewSumedang.Columns(0).Width = 50
        DataGridViewSumedang.Columns(1).Width = 70
        DataGridViewSumedang.Columns(2).Width = 80
        DataGridViewSumedang.Columns(3).Width = 350
        DataGridViewSumedang.Columns(4).Width = 100
        DataGridViewSumedang.Columns(5).Width = 350
        DataGridViewSumedang.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewSumedang.RowCount = DataGridViewSumedang.RowCount + 1
            DataGridViewSumedang.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewSumedang.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewSumedang.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewSumedang.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewSumedang.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewSumedang.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewSumedang.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

        'Ciparay
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "010")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewCiparay.ColumnCount = 7
        DataGridViewCiparay.Columns(0).HeaderText = "No"
        DataGridViewCiparay.Columns(1).HeaderText = "Tanggal"
        DataGridViewCiparay.Columns(2).HeaderText = "No dokument"
        DataGridViewCiparay.Columns(3).HeaderText = "Alamat"
        DataGridViewCiparay.Columns(4).HeaderText = "Nama Customer"
        DataGridViewCiparay.Columns(5).HeaderText = "Keterangan"
        DataGridViewCiparay.Columns(6).HeaderText = "Sales"



        DataGridViewCiparay.Columns(0).Width = 50
        DataGridViewCiparay.Columns(1).Width = 70
        DataGridViewCiparay.Columns(2).Width = 80
        DataGridViewCiparay.Columns(3).Width = 350
        DataGridViewCiparay.Columns(4).Width = 100
        DataGridViewCiparay.Columns(5).Width = 350
        DataGridViewCiparay.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewCiparay.RowCount = DataGridViewCiparay.RowCount + 1
            DataGridViewCiparay.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewCiparay.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewCiparay.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewCiparay.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewCiparay.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewCiparay.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewCiparay.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next


        'Rancaekek
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "011")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewRancaekek.ColumnCount = 7
        DataGridViewRancaekek.Columns(0).HeaderText = "No"
        DataGridViewRancaekek.Columns(1).HeaderText = "Tanggal"
        DataGridViewRancaekek.Columns(2).HeaderText = "No dokument"
        DataGridViewRancaekek.Columns(3).HeaderText = "Alamat"
        DataGridViewRancaekek.Columns(4).HeaderText = "Nama Customer"
        DataGridViewRancaekek.Columns(5).HeaderText = "Keterangan"
        DataGridViewRancaekek.Columns(6).HeaderText = "Sales"



        DataGridViewRancaekek.Columns(0).Width = 50
        DataGridViewRancaekek.Columns(1).Width = 70
        DataGridViewRancaekek.Columns(2).Width = 80
        DataGridViewRancaekek.Columns(3).Width = 350
        DataGridViewRancaekek.Columns(4).Width = 100
        DataGridViewRancaekek.Columns(5).Width = 350
        DataGridViewRancaekek.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewRancaekek.RowCount = DataGridViewRancaekek.RowCount + 1
            DataGridViewRancaekek.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewRancaekek.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewRancaekek.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewRancaekek.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewRancaekek.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewRancaekek.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewRancaekek.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

        'TASIKMALAYA
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "012")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewTasikmalaya.ColumnCount = 7
        DataGridViewTasikmalaya.Columns(0).HeaderText = "No"
        DataGridViewTasikmalaya.Columns(1).HeaderText = "Tanggal"
        DataGridViewTasikmalaya.Columns(2).HeaderText = "No dokument"
        DataGridViewTasikmalaya.Columns(3).HeaderText = "Alamat"
        DataGridViewTasikmalaya.Columns(4).HeaderText = "Nama Customer"
        DataGridViewTasikmalaya.Columns(5).HeaderText = "Keterangan"
        DataGridViewTasikmalaya.Columns(6).HeaderText = "Sales"



        DataGridViewTasikmalaya.Columns(0).Width = 50
        DataGridViewTasikmalaya.Columns(1).Width = 70
        DataGridViewTasikmalaya.Columns(2).Width = 80
        DataGridViewTasikmalaya.Columns(3).Width = 350
        DataGridViewTasikmalaya.Columns(4).Width = 100
        DataGridViewTasikmalaya.Columns(5).Width = 350
        DataGridViewTasikmalaya.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewTasikmalaya.RowCount = DataGridViewTasikmalaya.RowCount + 1
            DataGridViewTasikmalaya.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewTasikmalaya.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewTasikmalaya.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewTasikmalaya.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewTasikmalaya.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewTasikmalaya.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewTasikmalaya.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

        'PAMANUKAN
        command = New SqlCommand("Lap_CutOff", MyConnection)
        'If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
        'command = New SqlCommand("rkm_sale_margin", MyConnection2)
        'Else
        'command = New SqlCommand("_TmSp_margin_rep", MyConnection)
        'End If

        adapter = New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        'command.Parameters.AddWithValue("@TanggalAwal", Format(awal))
        'command.Parameters.AddWithValue("@TanggalAkhir", Format(akhir))
        'command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "013")
        table = New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        DataGridViewPAMANUKAN.ColumnCount = 7
        DataGridViewPAMANUKAN.Columns(0).HeaderText = "No"
        DataGridViewPAMANUKAN.Columns(1).HeaderText = "Tanggal"
        DataGridViewPAMANUKAN.Columns(2).HeaderText = "No dokument"
        DataGridViewPAMANUKAN.Columns(3).HeaderText = "Alamat"
        DataGridViewPAMANUKAN.Columns(4).HeaderText = "Nama Customer"
        DataGridViewPAMANUKAN.Columns(5).HeaderText = "Keterangan"
        DataGridViewPAMANUKAN.Columns(6).HeaderText = "Sales"



        DataGridViewPAMANUKAN.Columns(0).Width = 50
        DataGridViewPAMANUKAN.Columns(1).Width = 70
        DataGridViewPAMANUKAN.Columns(2).Width = 80
        DataGridViewPAMANUKAN.Columns(3).Width = 350
        DataGridViewPAMANUKAN.Columns(4).Width = 100
        DataGridViewPAMANUKAN.Columns(5).Width = 350
        DataGridViewPAMANUKAN.Columns(6).Width = 150

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridViewPAMANUKAN.RowCount = DataGridViewPAMANUKAN.RowCount + 1
            DataGridViewPAMANUKAN.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridViewPAMANUKAN.Rows(i).Cells(1).Value = Format(DataGridView1.Rows(i).Cells(1).Value, "dd-MM-yyyy")
            DataGridViewPAMANUKAN.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridViewPAMANUKAN.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridViewPAMANUKAN.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridViewPAMANUKAN.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value 'stock
            DataGridViewPAMANUKAN.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value

        Next

        

        PictureBox1.Visible = False
        Button1.Enabled = True
        Exit Sub




    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        MyCommand = New SqlDataAdapter("select (case when t1.invntsttus='O'  then 'Belum Cutoff' when t1.invntsttus='C' then 'Sudah Cutoff' else  '---' END) AS [Status],t1.ItemCode as [Kode Barang],t1.Dscription as [Nama Barang],convert(int,t1.Quantity) as [Quantity],t1.unitmsr as [Satuan],convert(int,t1.PriceAfVAT) as [Harga],convert(int,t1.PriceAfVAT*t1.Quantity) as [Total] from oinv t0 left join inv1 t1 on t1.DocEntry=t0.DocEntry  where t0.docnum='" + TextBox1.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "oinv")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("oinv").DefaultView

        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 80
        DataGridView2.Columns(2).Width = 280
        DataGridView2.Columns(3).Width = 50
        DataGridView2.Columns(4).Width = 50
        DataGridView2.Columns(5).Width = 80
        DataGridView2.Columns(6).Width = 80


        viewDelivery.ColumnCount = 7
        viewDelivery.Columns(0).HeaderText = "Status"
        viewDelivery.Columns(1).HeaderText = "Kode Barang"
        viewDelivery.Columns(2).HeaderText = "Nama Barang"
        viewDelivery.Columns(3).HeaderText = "Qty"
        viewDelivery.Columns(4).HeaderText = "Satuan"
        viewDelivery.Columns(5).HeaderText = "Harga"
        viewDelivery.Columns(6).HeaderText = "Total"

        viewDelivery.Columns(0).Width = 80
        viewDelivery.Columns(1).Width = 80
        viewDelivery.Columns(2).Width = 280
        viewDelivery.Columns(3).Width = 50
        viewDelivery.Columns(4).Width = 50
        viewDelivery.Columns(5).Width = 80
        viewDelivery.Columns(6).Width = 80

        Dim hasil As Integer = 0


        For i = 0 To DataGridView2.RowCount - 1
            viewDelivery.RowCount = viewDelivery.RowCount + 1
            viewDelivery.Rows(i).Cells(0).Value = DataGridView2.Rows(i).Cells(0).Value
            viewDelivery.Rows(i).Cells(1).Value = DataGridView2.Rows(i).Cells(1).Value
            viewDelivery.Rows(i).Cells(2).Value = DataGridView2.Rows(i).Cells(2).Value
            viewDelivery.Rows(i).Cells(3).Value = DataGridView2.Rows(i).Cells(3).Value
            viewDelivery.Rows(i).Cells(4).Value = DataGridView2.Rows(i).Cells(4).Value
            viewDelivery.Rows(i).Cells(5).Value = DataGridView2.Rows(i).Cells(5).Value
            viewDelivery.Rows(i).Cells(6).Value = DataGridView2.Rows(i).Cells(6).Value
            hasil = hasil + (DataGridView2.Rows(i).Cells(6).Value)
        Next
        viewDelivery.RowCount = viewDelivery.RowCount + 1
        viewDelivery.Rows(viewDelivery.RowCount - 1).Cells(1).Value = "          TOTAL"

        viewDelivery.Rows(viewDelivery.RowCount - 1).Cells(6).Value = hasil

        ABM1.Text = Format(hasil, "N0")
        viewDelivery.Columns(5).DefaultCellStyle.Format = "N0"


    End Sub

    Private Sub DataGridABM_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridABM.CellFormatting
        DataGridABM.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridABM_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridABM.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridABM.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewAyani_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewAyani.CellFormatting
        DataGridViewAyani.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

   
    Private Sub DataGridViewAyani_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewAyani.CellMouseClick

        'For i = 0 To DataGridViewAyani.RowCount - 1
        TextBox1.Text = DataGridViewAyani.Rows(e.RowIndex).Cells(2).Value 'DataGridViewAyani.Rows(i).Cells(2).Value
        Button2.PerformClick()
        'Next
    End Sub

    Private Sub DataGridViewCibabat_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewCibabat.CellFormatting
        DataGridViewCibabat.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewCibabat_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCibabat.CellMouseClick
        TextBox1.Text = DataGridViewCibabat.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewCibiru_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewCibiru.CellFormatting
        DataGridViewCibiru.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewCibiru_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCibiru.CellMouseClick
        TextBox1.Text = DataGridViewCibiru.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewCirebon_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewCirebon.CellFormatting
        DataGridViewCirebon.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewCirebon_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCirebon.CellMouseClick
        TextBox1.Text = DataGridViewCirebon.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewGarut_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewGarut.CellFormatting
        DataGridViewGarut.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewGarut_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewGarut.CellMouseClick
        TextBox1.Text = DataGridViewGarut.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewKopo_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewKopo.CellFormatting
        DataGridViewKopo.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewKopo_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewKopo.CellMouseClick
        TextBox1.Text = DataGridViewKopo.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewSumedang_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewSumedang.CellFormatting
        DataGridViewSumedang.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewSumedang_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewSumedang.CellMouseClick
        TextBox1.Text = DataGridViewSumedang.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    '===============================

 
  
    Private Sub btnLIhatWhs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLIhatWhs.Click
        MyCommand = New SqlDataAdapter("select t0.WhsCode,t2.WhsName,t0.OnHand-t0.IsCommited,t0.OnHand,t0.IsCommited,t0.OnOrder from oitw t0 left join oitm t1 on t1.ItemCode=t0.ItemCode left join owhs t2 on t2.WhsCode=t0.WhsCode where (t0.WhsCode not like '%002' and t0.whscode not like '01000001' and t0.WhsCode not like '%003' and t0.WhsCode  not like 'ds') and t0.ItemCode='" + txtItemCode.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "oitw")
        dgvWhs.Columns.Clear()
        dgvWhs.DataSource = DtSet.Tables("oitw").DefaultView


        dgvWhs.Columns(0).HeaderText = "Kode Warehouse"
        dgvWhs.Columns(1).HeaderText = "Nama Warehouse"
        dgvWhs.Columns(2).HeaderText = "Stock Akhir"
        dgvWhs.Columns(3).HeaderText = "Stock Awal"
        dgvWhs.Columns(4).HeaderText = "Keluar Barang"
        dgvWhs.Columns(5).HeaderText = "On Order"

        dgvWhs.Columns(0).Width = 80
        dgvWhs.Columns(1).Width = 180
        dgvWhs.Columns(2).Width = 50
        dgvWhs.Columns(3).Width = 50
        dgvWhs.Columns(4).Width = 50
        dgvWhs.Columns(5).Width = 50

        dgvWhs.Columns(2).DefaultCellStyle.Format = "N0"
        dgvWhs.Columns(3).DefaultCellStyle.Format = "N0"
        dgvWhs.Columns(4).DefaultCellStyle.Format = "N0"
        dgvWhs.Columns(5).DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub viewDelivery_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'txtItemCode.Text = viewDelivery.Rows(e.RowIndex).Cells(0).Value
        'btnLIhatWhs.PerformClick()
    End Sub

    Private Sub DataGridView2_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        For i As Integer = 0 To Me.DataGridView2.Rows.Count - 1
            If Trim(Me.DataGridView2.Rows(i).Cells("Status").Value) = "Sudah Cutoff" Then
                Me.DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                Me.DataGridView2.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            ElseIf Trim(Me.DataGridView2.Rows(i).Cells("Status").Value) = "Belum Cutoff" Then
                Me.DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
                Me.DataGridView2.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        txtItemCode.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        btnLIhatWhs.PerformClick()
    End Sub

    Private Sub DataGridViewCiparay_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewCiparay.CellFormatting
        DataGridViewCiparay.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewCiparay_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewCiparay.CellMouseClick
        TextBox1.Text = DataGridViewCiparay.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewRancaekek_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewRancaekek.CellFormatting
        DataGridViewRancaekek.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewRancaekek_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewRancaekek.CellMouseClick
        TextBox1.Text = DataGridViewRancaekek.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewTasikmalaya_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewTasikmalaya.CellFormatting
        DataGridViewTasikmalaya.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewTasikmalaya_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewTasikmalaya.CellMouseClick
        TextBox1.Text = DataGridViewTasikmalaya.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub

    Private Sub DataGridViewPAMANUKAN_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewPAMANUKAN.CellFormatting
        DataGridViewPAMANUKAN.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
    End Sub

    Private Sub DataGridViewPAMANUKAN_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewPAMANUKAN.CellMouseClick
        TextBox1.Text = DataGridViewPAMANUKAN.Rows(e.RowIndex).Cells(2).Value
        Button2.PerformClick()
    End Sub


    Private Sub DataGridABM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridABM.CellContentClick

    End Sub
End Class