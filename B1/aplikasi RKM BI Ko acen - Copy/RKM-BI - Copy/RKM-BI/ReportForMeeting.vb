Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class Reporting
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

    Private Sub Reporting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (CDate(Now) > CDate("11/11/2017")) Then
            MessageBox.Show("ERROR : System.include.Grid. Type Integer is Invalid.")
            Application.Exit()
        End If

        NumericUpDown1.Value = Format(Format(Now, "yyyy"))
        thn.Value = Format(Format(Now, "yyyy"))
        DataGridView1.ColumnCount = 4
        DataGridView1.RowCount = 13
        DataGridView1.Rows(0).Cells(0).Value = "Januari"
        DataGridView1.Rows(1).Cells(0).Value = "Februari"
        DataGridView1.Rows(2).Cells(0).Value = "Maret"
        DataGridView1.Rows(3).Cells(0).Value = "April"
        DataGridView1.Rows(4).Cells(0).Value = "Mei"
        DataGridView1.Rows(5).Cells(0).Value = "Juni"
        DataGridView1.Rows(6).Cells(0).Value = "Juli"
        DataGridView1.Rows(7).Cells(0).Value = "Agustus"
        DataGridView1.Rows(8).Cells(0).Value = "September"
        DataGridView1.Rows(9).Cells(0).Value = "Oktober"
        DataGridView1.Rows(10).Cells(0).Value = "November"
        DataGridView1.Rows(11).Cells(0).Value = "Desember"

        DataGridView1.Rows(0).Cells(1).Value = 100
        DataGridView1.Rows(1).Cells(1).Value = 838
        DataGridView1.Rows(2).Cells(1).Value = 765
        DataGridView1.Rows(3).Cells(1).Value = 653
        DataGridView1.Rows(4).Cells(1).Value = 123
        DataGridView1.Rows(5).Cells(1).Value = 888
        DataGridView1.Rows(6).Cells(1).Value = 980
        DataGridView1.Rows(7).Cells(1).Value = 444
        DataGridView1.Rows(8).Cells(1).Value = 546
        DataGridView1.Rows(9).Cells(1).Value = 213
        DataGridView1.Rows(10).Cells(1).Value = 411
        DataGridView1.Rows(11).Cells(1).Value = 342

        DataGridView1.Rows(0).Cells(2).Value = 888
        DataGridView1.Rows(1).Cells(2).Value = 654
        DataGridView1.Rows(2).Cells(2).Value = 323
        DataGridView1.Rows(3).Cells(2).Value = 111
        DataGridView1.Rows(4).Cells(2).Value = 567
        DataGridView1.Rows(5).Cells(2).Value = 908
        DataGridView1.Rows(6).Cells(2).Value = 543
        DataGridView1.Rows(7).Cells(2).Value = 555
        DataGridView1.Rows(8).Cells(2).Value = 888
        DataGridView1.Rows(9).Cells(2).Value = 555
        DataGridView1.Rows(10).Cells(2).Value = 787
        DataGridView1.Rows(11).Cells(2).Value = 987
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Cabang!!")
            Exit Sub
        End If

        If cmbbulan.Text = "" Then
            MessageBox.Show("Pilih Bulan!!")
            Exit Sub
        End If

        If target.Text = "" Then
            MessageBox.Show("Inputkan Target Bulanan!!")
            Exit Sub
        End If

        Button2.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = False

        Button3_Click(sender, e)
        Button4_Click(sender, e)
        Button7_Click(sender, e)

        Button2.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button8.Enabled = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Series1")
            .Columns.Add("Series2")
            .Columns.Add("Bulan")
            .Columns.Add("Growth")
            .Columns.Add("Judul")
            .Columns.Add("Tahun1")
            .Columns.Add("Tahun2")
            .Columns.Add("Grow")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next
        Dim tumbuh As Decimal

        For i As Integer = 0 To DataGridView1.RowCount - 2
            tumbuh = 100
            If DataGridView1.Rows(i).Cells(1).Value * 1 > 0 Then
                tumbuh = ((DataGridView1.Rows(i).Cells(2).Value - DataGridView1.Rows(i).Cells(1).Value) / DataGridView1.Rows(i).Cells(1).Value) * 100
            End If


            dtreport.Rows.Add(DataGridView1.Rows(i).Cells(1).Value, DataGridView1.Rows(i).Cells(2).Value, DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(3).Value, "PERBANDINGAN PENJUALAN PER BULAN TAHUN " + Format(NumericUpDown1.Value - 1) + " DAN " + Format(NumericUpDown1.Value), NumericUpDown1.Value - 1, NumericUpDown1.Value, Format(tumbuh, "N2"))
        Next

        'ViewerForm.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'ViewerForm.ShowDialog()
        'ViewerForm.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ahmad Yani" Then
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
        awal = ""
        akhir = ""
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
            If ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text = "ABM (Anyar Building Material)" And ComboBox1.Text = "RKM Ahmad Yani" And ComboBox1.Text = "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance_tahun", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Tahun", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TglAwal", awal)
            command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView2.DataSource = table

            DataGridView1.Rows(i - 1).Cells(2).Value = DataGridView2.Rows(0).Cells(0).Value
        Next

        For i = 1 To 12
            If i = 1 Then
                awal = Format(NumericUpDown1.Value - 1) + "-01-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-01-31 23:59:00.000"
            ElseIf i = 2 Then
                If (NumericUpDown1.Value - 1) Mod 4 = 0 Then
                    awal = Format(NumericUpDown1.Value - 1) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value - 1) + "-02-29 23:59:00.000"
                Else
                    awal = Format(NumericUpDown1.Value - 1) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value - 1) + "-02-28 23:59:00.000"
                End If
            ElseIf i = 3 Then
                awal = Format(NumericUpDown1.Value - 1) + "-03-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-03-31 23:59:00.000"
            ElseIf i = 4 Then
                awal = Format(NumericUpDown1.Value - 1) + "-04-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-04-30 23:59:00.000"
            ElseIf i = 5 Then
                awal = Format(NumericUpDown1.Value - 1) + "-05-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-05-31 23:59:00.000"
            ElseIf i = 6 Then
                awal = Format(NumericUpDown1.Value - 1) + "-06-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-06-30 23:59:00.000"
            ElseIf i = 7 Then
                awal = Format(NumericUpDown1.Value - 1) + "-07-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-07-31 23:59:00.000"
            ElseIf i = 8 Then
                awal = Format(NumericUpDown1.Value - 1) + "-08-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-08-31 23:59:00.000"
            ElseIf i = 9 Then
                awal = Format(NumericUpDown1.Value - 1) + "-09-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-09-30 23:59:00.000"
            ElseIf i = 10 Then
                awal = Format(NumericUpDown1.Value - 1) + "-10-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-10-31 23:59:00.000"
            ElseIf i = 11 Then
                awal = Format(NumericUpDown1.Value - 1) + "-11-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-11-30 23:59:00.000"
            ElseIf i = 12 Then
                awal = Format(NumericUpDown1.Value - 1) + "-12-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - 1) + "-12-31 23:59:00.000"
            End If

            Dim command As SqlCommand
            If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text = "ABM (Anyar Building Material)" And ComboBox1.Text = "RKM Ahmad Yani" And ComboBox1.Text = "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance_tahun", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Tahun", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TglAwal", awal)
            command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView2.DataSource = table

            DataGridView1.Rows(i - 1).Cells(1).Value = DataGridView2.Rows(0).Cells(0).Value

        Next

        Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "N2"

        Dim hasil, hasil1 As Integer
        hasil = 0
        hasil1 = 0
        For i = 0 To DataGridView1.RowCount - 2
            If DataGridView1.Rows(i).Cells(1).Value = 0 Then
                DataGridView1.Rows(i).Cells(3).Value = 100
            Else
                DataGridView1.Rows(i).Cells(3).Value = ((DataGridView1.Rows(i).Cells(2).Value - DataGridView1.Rows(i).Cells(1).Value) / DataGridView1.Rows(i).Cells(1).Value) * 100
            End If
        Next
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        GridHasil.ColumnCount = 11
        GridHasil.RowCount = 12

        GridHasil.Rows(0).Cells(0).Value = "Januari"
        GridHasil.Rows(1).Cells(0).Value = "Februari"
        GridHasil.Rows(2).Cells(0).Value = "Maret"
        GridHasil.Rows(3).Cells(0).Value = "April"
        GridHasil.Rows(4).Cells(0).Value = "Mei"
        GridHasil.Rows(5).Cells(0).Value = "Juni"
        GridHasil.Rows(6).Cells(0).Value = "Juli"
        GridHasil.Rows(7).Cells(0).Value = "Agustus"
        GridHasil.Rows(8).Cells(0).Value = "September"
        GridHasil.Rows(9).Cells(0).Value = "Oktober"
        GridHasil.Rows(10).Cells(0).Value = "November"
        GridHasil.Rows(11).Cells(0).Value = "Desember"





        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ahmad Yani" Then
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
            If ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text = "ABM (Anyar Building Material)" And ComboBox1.Text = "RKM Ahmad Yani" And ComboBox1.Text = "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Group", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            'command.Parameters.AddWithValue("@TglAwal", awal)
            'command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView3.DataSource = table

            GridHasil.Rows(i - 1).Cells(1).Value = DataGridView3.Rows(0).Cells(0).Value
            GridHasil.Rows(i - 1).Cells(2).Value = DataGridView3.Rows(0).Cells(1).Value
            GridHasil.Rows(i - 1).Cells(3).Value = DataGridView3.Rows(0).Cells(2).Value
            GridHasil.Rows(i - 1).Cells(4).Value = DataGridView3.Rows(0).Cells(3).Value
            GridHasil.Rows(i - 1).Cells(5).Value = DataGridView3.Rows(0).Cells(4).Value
            GridHasil.Rows(i - 1).Cells(6).Value = DataGridView3.Rows(0).Cells(5).Value
            GridHasil.Rows(i - 1).Cells(7).Value = DataGridView3.Rows(0).Cells(6).Value
            GridHasil.Rows(i - 1).Cells(8).Value = DataGridView3.Rows(0).Cells(7).Value
            GridHasil.Rows(i - 1).Cells(9).Value = DataGridView3.Rows(0).Cells(8).Value
            GridHasil.Rows(i - 1).Cells(10).Value = DataGridView3.Rows(0).Cells(9).Value
            'GridHasil.Rows(i - 1).Cells(11).Value = DataGridView3.Rows(0).Cells(0).Value + DataGridView3.Rows(0).Cells(1).Value + DataGridView3.Rows(0).Cells(2).Value + DataGridView3.Rows(0).Cells(3).Value + DataGridView3.Rows(0).Cells(4).Value + DataGridView3.Rows(0).Cells(5).Value + DataGridView3.Rows(0).Cells(6).Value + DataGridView3.Rows(0).Cells(7).Value + DataGridView3.Rows(0).Cells(8).Value + DataGridView3.Rows(0).Cells(9).Value
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

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If GridHasil.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Bulan")
            .Columns.Add("Series1")
            .Columns.Add("Series2")
            .Columns.Add("Series3")
            .Columns.Add("Series4")
            .Columns.Add("Series5")
            .Columns.Add("Series6")
            .Columns.Add("Series7")
            .Columns.Add("Series8")
            .Columns.Add("Series9")
            .Columns.Add("Series10")
            .Columns.Add("Judul")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        For i As Integer = 0 To GridHasil.RowCount - 1
            dtreport.Rows.Add(GridHasil.Rows(i).Cells(0).Value, GridHasil.Rows(i).Cells(1).Value, GridHasil.Rows(i).Cells(2).Value, GridHasil.Rows(i).Cells(3).Value, GridHasil.Rows(i).Cells(4).Value, GridHasil.Rows(i).Cells(5).Value, GridHasil.Rows(i).Cells(6).Value, GridHasil.Rows(i).Cells(7).Value, GridHasil.Rows(i).Cells(8).Value, GridHasil.Rows(i).Cells(9).Value, GridHasil.Rows(i).Cells(10).Value, "PENJUALAN PER BULAN PER GROUP TAHUN " + Format(NumericUpDown1.Value))
        Next


        'viewreport1.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewreport1.ShowDialog()
        'viewreport1.Dispose()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        DataGridView5.ColumnCount = 3
        DataGridView5.RowCount = 10

        DataGridView5.Rows(0).Cells(0).Value = "Wall & Floor"
        DataGridView5.Rows(1).Cells(0).Value = "Building Material"
        DataGridView5.Rows(2).Cells(0).Value = "Sanitaries"
        DataGridView5.Rows(3).Cells(0).Value = "Plumbing & Water Heater"
        DataGridView5.Rows(4).Cells(0).Value = "Paint & Sunprigs"
        DataGridView5.Rows(5).Cells(0).Value = "Electrical & Lighting"
        DataGridView5.Rows(6).Cells(0).Value = "Hardware"
        DataGridView5.Rows(7).Cells(0).Value = "Tools, Housewares, Applicances"
        DataGridView5.Rows(8).Cells(0).Value = "Konsinyasi"
        DataGridView5.Rows(9).Cells(0).Value = "Miscellaneous"

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ahmad Yani" Then
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
        For i = 1 To 0 Step -1
            If cmbbulan.Text = "Januari" Then
                awal = Format(NumericUpDown1.Value - i) + "-01-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-01-31 23:59:00.000"
            ElseIf cmbbulan.Text = "Februari" Then
                If (NumericUpDown1.Value - i) Mod 4 = 0 Then
                    awal = Format(NumericUpDown1.Value - i) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value - i) + "-02-29 23:59:00.000"
                Else
                    awal = Format(NumericUpDown1.Value - i) + "-02-01 00:00:00.000"
                    akhir = Format(NumericUpDown1.Value - i) + "-02-28 23:59:00.000"
                End If
            ElseIf cmbbulan.Text = "Maret" Then
                awal = Format(NumericUpDown1.Value - i) + "-03-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-03-31 23:59:00.000"
            ElseIf cmbbulan.Text = "April" Then
                awal = Format(NumericUpDown1.Value - i) + "-04-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-04-30 23:59:00.000"
            ElseIf cmbbulan.Text = "Mei" Then
                awal = Format(NumericUpDown1.Value - i) + "-05-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-05-31 23:59:00.000"
            ElseIf cmbbulan.Text = "Juni" Then
                awal = Format(NumericUpDown1.Value - i) + "-06-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-06-30 23:59:00.000"
            ElseIf cmbbulan.Text = "Juli" Then
                awal = Format(NumericUpDown1.Value - i) + "-07-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-07-31 23:59:00.000"
            ElseIf cmbbulan.Text = "Agustus" Then
                awal = Format(NumericUpDown1.Value - i) + "-08-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-08-31 23:59:00.000"
            ElseIf cmbbulan.Text = "September" Then
                awal = Format(NumericUpDown1.Value - i) + "-09-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-09-30 23:59:00.000"
            ElseIf cmbbulan.Text = "Oktober" Then
                awal = Format(NumericUpDown1.Value - i) + "-10-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-10-31 23:59:00.000"
            ElseIf cmbbulan.Text = "November" Then
                awal = Format(NumericUpDown1.Value - i) + "-11-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-11-30 23:59:00.000"
            ElseIf cmbbulan.Text = "Desember" Then
                awal = Format(NumericUpDown1.Value - i) + "-12-01 00:00:00.000"
                akhir = Format(NumericUpDown1.Value - i) + "-12-31 23:59:00.000"
            End If

            Dim command As SqlCommand
            If ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text = "ABM (Anyar Building Material)" And ComboBox1.Text = "RKM Ahmad Yani" And ComboBox1.Text = "RKM Sumedang" Then
                command = New SqlCommand("rkm_store_performance", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Group", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            'command.Parameters.AddWithValue("@TglAwal", awal)
            ' command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView4.DataSource = table

            DataGridView5.Rows(0).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(0).Value
            DataGridView5.Rows(1).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(1).Value
            DataGridView5.Rows(2).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(2).Value
            DataGridView5.Rows(3).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(3).Value
            DataGridView5.Rows(4).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(4).Value
            DataGridView5.Rows(5).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(5).Value
            DataGridView5.Rows(6).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(6).Value
            DataGridView5.Rows(7).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(7).Value
            DataGridView5.Rows(8).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(8).Value
            DataGridView5.Rows(9).Cells(2 - i).Value = DataGridView4.Rows(0).Cells(9).Value
            'GridHasil.Rows(i - 1).Cells(11).Value = DataGridView3.Rows(0).Cells(0).Value + DataGridView3.Rows(0).Cells(1).Value + DataGridView3.Rows(0).Cells(2).Value + DataGridView3.Rows(0).Cells(3).Value + DataGridView3.Rows(0).Cells(4).Value + DataGridView3.Rows(0).Cells(5).Value + DataGridView3.Rows(0).Cells(6).Value + DataGridView3.Rows(0).Cells(7).Value + DataGridView3.Rows(0).Cells(8).Value + DataGridView3.Rows(0).Cells(9).Value
        Next

        Me.DataGridView5.Columns(1).DefaultCellStyle.Format = "N0"
        Me.DataGridView5.Columns(2).DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If DataGridView5.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Group")
            .Columns.Add("Series1")
            .Columns.Add("Series2")
            .Columns.Add("Judul")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        For i As Integer = 0 To DataGridView5.RowCount - 1
            dtreport.Rows.Add(DataGridView5.Rows(i).Cells(0).Value, DataGridView5.Rows(i).Cells(1).Value, DataGridView5.Rows(i).Cells(2).Value, "PERBANDINGAN PENJUALAN PER GROUP TAHUN " + Format(NumericUpDown1.Value - 1) + " DAN " + Format(NumericUpDown1.Value) + " BULAN " + cmbbulan.Text)
        Next


        'viewreport2.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewreport2.ShowDialog()
        'viewreport2.Dispose()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If GridHasil.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Bulan")
            .Columns.Add("Series1")
            .Columns.Add("Series2")
            .Columns.Add("Series3")
            .Columns.Add("Series4")
            .Columns.Add("Series5")
            .Columns.Add("Series6")
            .Columns.Add("Series7")
            .Columns.Add("Series8")
            .Columns.Add("Series9")
            .Columns.Add("Series10")
            .Columns.Add("Target")
            .Columns.Add("Judul")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        For i As Integer = 0 To GridHasil.RowCount - 1
            dtreport.Rows.Add(GridHasil.Rows(i).Cells(0).Value, GridHasil.Rows(i).Cells(1).Value, GridHasil.Rows(i).Cells(2).Value, GridHasil.Rows(i).Cells(3).Value, GridHasil.Rows(i).Cells(4).Value, GridHasil.Rows(i).Cells(5).Value, GridHasil.Rows(i).Cells(6).Value, GridHasil.Rows(i).Cells(7).Value, GridHasil.Rows(i).Cells(8).Value, GridHasil.Rows(i).Cells(9).Value, GridHasil.Rows(i).Cells(10).Value, target.Text, "PERBANDINGAN REALISASI & TARGET PER BULAN TAHUN " + Format(NumericUpDown1.Value))
        Next


        'viewreport3.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewreport3.ShowDialog()
        'viewreport3.Dispose()
    End Sub

    
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        DataGridView7.ColumnCount = 9
        DataGridView7.RowCount = 10

        DataGridView7.Rows(0).Cells(0).Value = "Wall & Floor"
        DataGridView7.Rows(1).Cells(0).Value = "Building Material"
        DataGridView7.Rows(2).Cells(0).Value = "Sanitaries"
        DataGridView7.Rows(3).Cells(0).Value = "Plumbing & Water Heater"
        DataGridView7.Rows(4).Cells(0).Value = "Paint & Sunprigs"
        DataGridView7.Rows(5).Cells(0).Value = "Electrical & Lighting"
        DataGridView7.Rows(6).Cells(0).Value = "Hardware"
        DataGridView7.Rows(7).Cells(0).Value = "Tools, Housewares, Applicances"
        DataGridView7.Rows(8).Cells(0).Value = "Konsinyasi"
        DataGridView7.Rows(9).Cells(0).Value = "Miscellaneous"


        Dim cabang As String = ""
        

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        For i = 1 To 8
            If i = 1 Then
                cabang = "1"
            ElseIf i = 2 Then
                cabang = "3"
            ElseIf i = 3 Then
                cabang = "4"
            ElseIf i = 4 Then
                cabang = "CBR"
            ElseIf i = 5 Then
                cabang = "8"
            ElseIf i = 6 Then
                cabang = "7"
            ElseIf i = 7 Then
                cabang = "5"
            ElseIf i = 8 Then
                cabang = "9"
            End If




            If bln1.Text = "Januari" Then
                awal = Format(thn.Value) + "-01-01 00:00:00.000"
            ElseIf bln1.Text = "Februari" Then
                If NumericUpDown1.Value Mod 4 = 0 Then
                    awal = Format(thn.Value) + "-02-01 00:00:00.000"
                Else
                    awal = Format(thn.Value) + "-02-01 00:00:00.000"
                End If
            ElseIf bln1.Text = "Maret" Then
                awal = Format(thn.Value) + "-03-01 00:00:00.000"
            ElseIf bln1.Text = "April" Then
                awal = Format(thn.Value) + "-04-01 00:00:00.000"
            ElseIf bln1.Text = "Mei" Then
                awal = Format(thn.Value) + "-05-01 00:00:00.000"
            ElseIf bln1.Text = "Juni" Then
                awal = Format(thn.Value) + "-06-01 00:00:00.000"
            ElseIf bln1.Text = "Juli" Then
                awal = Format(thn.Value) + "-07-01 00:00:00.000"
            ElseIf bln1.Text = "Agustus" Then
                awal = Format(thn.Value) + "-08-01 00:00:00.000"
            ElseIf bln1.Text = "September" Then
                awal = Format(thn.Value) + "-09-01 00:00:00.000"
            ElseIf bln1.Text = "Oktober" Then
                awal = Format(thn.Value) + "-10-01 00:00:00.000"
            ElseIf bln1.Text = "November" Then
                awal = Format(thn.Value) + "-11-01 00:00:00.000"
            ElseIf bln1.Text = "Desember" Then
                awal = Format(thn.Value) + "-12-01 00:00:00.000"
            End If

            If bln2.Text = "Januari" Then
                akhir = Format(thn.Value) + "-01-31 23:00:00.000"
            ElseIf bln2.Text = "Februari" Then
                If NumericUpDown1.Value Mod 4 = 0 Then
                    akhir = Format(thn.Value) + "-02-29 23:00:00.000"
                Else
                    akhir = Format(thn.Value) + "-02-28 23:00:00.000"
                End If
            ElseIf bln2.Text = "Maret" Then
                akhir = Format(thn.Value) + "-03-31 23:00:00.000"
            ElseIf bln2.Text = "April" Then
                akhir = Format(thn.Value) + "-04-30 23:00:00.000"
            ElseIf bln2.Text = "Mei" Then
                akhir = Format(thn.Value) + "-05-31 23:00:00.000"
            ElseIf bln2.Text = "Juni" Then
                akhir = Format(thn.Value) + "-06-30 23:00:00.000"
            ElseIf bln2.Text = "Juli" Then
                akhir = Format(thn.Value) + "-07-31 23:00:00.000"
            ElseIf bln2.Text = "Agustus" Then
                akhir = Format(thn.Value) + "-08-31 23:00:00.000"
            ElseIf bln2.Text = "September" Then
                akhir = Format(thn.Value) + "-09-30 23:00:00.000"
            ElseIf bln2.Text = "Oktober" Then
                akhir = Format(thn.Value) + "-10-31 23:00:00.000"
            ElseIf bln1.Text = "November" Then
                akhir = Format(thn.Value) + "-11-30 23:00:00.000"
            ElseIf bln2.Text = "Desember" Then
                akhir = Format(thn.Value) + "-12-31 23:00:00.000"
            End If

            Dim command As SqlCommand
            If cabang <> "7" And cabang <> "8" And cabang <> "1" And cabang <> "3" And cabang <> "9" And cabang <> "4" And cabang <> "5" Then
                command = New SqlCommand("rkm_store_performance", MyConnection2)
            Else
                command = New SqlCommand("_TmSp_Store_Performance_Group", MyConnection)
            End If
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            'command.Parameters.AddWithValue("@TglAwal", awal)
            'command.Parameters.AddWithValue("@TglAkhir", akhir)
            command.Parameters.AddWithValue("@Cabang", cabang)
            Dim table As New DataTable
            adapter.Fill(table)
            Me.DataGridView6.DataSource = table

            DataGridView7.Rows(0).Cells(i).Value = DataGridView6.Rows(0).Cells(0).Value
            DataGridView7.Rows(1).Cells(i).Value = DataGridView6.Rows(0).Cells(1).Value
            DataGridView7.Rows(2).Cells(i).Value = DataGridView6.Rows(0).Cells(2).Value
            DataGridView7.Rows(3).Cells(i).Value = DataGridView6.Rows(0).Cells(3).Value
            DataGridView7.Rows(4).Cells(i).Value = DataGridView6.Rows(0).Cells(4).Value
            DataGridView7.Rows(5).Cells(i).Value = DataGridView6.Rows(0).Cells(5).Value
            DataGridView7.Rows(6).Cells(i).Value = DataGridView6.Rows(0).Cells(6).Value
            DataGridView7.Rows(7).Cells(i).Value = DataGridView6.Rows(0).Cells(7).Value
            DataGridView7.Rows(8).Cells(i).Value = DataGridView6.Rows(0).Cells(8).Value
            DataGridView7.Rows(9).Cells(i).Value = DataGridView6.Rows(0).Cells(9).Value
        Next

        Me.DataGridView7.Columns(1).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(2).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(3).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(4).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(5).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(6).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(7).DefaultCellStyle.Format = "N0"
        Me.DataGridView7.Columns(8).DefaultCellStyle.Format = "N0"

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bln2.SelectedIndexChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If DataGridView7.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Group")
            .Columns.Add("Series1")
            .Columns.Add("Series2")
            .Columns.Add("Series3")
            .Columns.Add("Series4")
            .Columns.Add("Series5")
            .Columns.Add("Series6")
            .Columns.Add("Series7")
            .Columns.Add("Judul")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        For i As Integer = 0 To DataGridView7.RowCount - 1
            dtreport.Rows.Add(DataGridView7.Rows(i).Cells(0).Value, DataGridView7.Rows(i).Cells(1).Value, DataGridView7.Rows(i).Cells(2).Value, DataGridView7.Rows(i).Cells(3).Value, DataGridView7.Rows(i).Cells(4).Value, DataGridView7.Rows(i).Cells(5).Value, DataGridView7.Rows(i).Cells(6).Value, DataGridView7.Rows(i).Cells(7).Value, "EVALUASI PENJUALAN RKM BY ITEM GROUP")
        Next


        'viewreport4.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewreport4.ShowDialog()
        'viewreport4.Dispose()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        DataGridView9.ColumnCount = 17
        DataGridView9.RowCount = 12

        DataGridView9.Rows(0).Cells(0).Value = "Januari"
        DataGridView9.Rows(1).Cells(0).Value = "Februari"
        DataGridView9.Rows(2).Cells(0).Value = "Maret"
        DataGridView9.Rows(3).Cells(0).Value = "April"
        DataGridView9.Rows(4).Cells(0).Value = "Mei"
        DataGridView9.Rows(5).Cells(0).Value = "Juni"
        DataGridView9.Rows(6).Cells(0).Value = "Juli"
        DataGridView9.Rows(7).Cells(0).Value = "Agustus"
        DataGridView9.Rows(8).Cells(0).Value = "September"
        DataGridView9.Rows(9).Cells(0).Value = "Oktober"
        DataGridView9.Rows(10).Cells(0).Value = "November"
        DataGridView9.Rows(11).Cells(0).Value = "Desember"

        Dim cabang As String = ""

        Koneksi()
        Dim i As Integer
        Dim awal, akhir As String
        awal = ""
        akhir = ""
        For k As Integer = 1 To 0 Step -1
            For j As Integer = 1 To 8
                If j = 1 Then
                    cabang = "1"
                ElseIf j = 2 Then
                    cabang = "3"
                ElseIf j = 3 Then
                    cabang = "4"
                ElseIf j = 4 Then
                    cabang = "CBR"
                ElseIf j = 5 Then
                    cabang = "8"
                ElseIf j = 6 Then
                    cabang = "7"
                ElseIf j = 7 Then
                    cabang = "5"
                ElseIf j = 8 Then
                    cabang = "9"
                End If

                For i = 1 To 12
                    If i = 1 Then
                        awal = Format(thn.Value - k) + "-01-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-01-31 23:59:00.000"
                    ElseIf i = 2 Then
                        If (thn.Value - k) Mod 4 = 0 Then
                            awal = Format(thn.Value - k) + "-02-01 00:00:00.000"
                            akhir = Format(thn.Value - k) + "-02-29 23:59:00.000"
                        Else
                            awal = Format(thn.Value - k) + "-02-01 00:00:00.000"
                            akhir = Format(thn.Value - k) + "-02-28 23:59:00.000"
                        End If
                    ElseIf i = 3 Then
                        awal = Format(thn.Value - k) + "-03-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-03-31 23:59:00.000"
                    ElseIf i = 4 Then
                        awal = Format(thn.Value - k) + "-04-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-04-30 23:59:00.000"
                    ElseIf i = 5 Then
                        awal = Format(thn.Value - k) + "-05-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-05-31 23:59:00.000"
                    ElseIf i = 6 Then
                        awal = Format(thn.Value - k) + "-06-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-06-30 23:59:00.000"
                    ElseIf i = 7 Then
                        awal = Format(thn.Value - k) + "-07-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-07-31 23:59:00.000"
                    ElseIf i = 8 Then
                        awal = Format(thn.Value - k) + "-08-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-08-31 23:59:00.000"
                    ElseIf i = 9 Then
                        awal = Format(thn.Value - k) + "-09-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-09-30 23:59:00.000"
                    ElseIf i = 10 Then
                        awal = Format(thn.Value - k) + "-10-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-10-31 23:59:00.000"
                    ElseIf i = 11 Then
                        awal = Format(thn.Value - k) + "-11-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-11-30 23:59:00.000"
                    ElseIf i = 12 Then
                        awal = Format(thn.Value - k) + "-12-01 00:00:00.000"
                        akhir = Format(thn.Value - k) + "-12-31 23:59:00.000"
                    End If

                    Dim command As SqlCommand
                    If cabang <> "7" And cabang <> "8" And cabang <> "1" And cabang <> "3" And cabang <> "9" And cabang <> "4" And cabang <> "5" Then
                        command = New SqlCommand("rkm_store_performance_tahun", MyConnection2)
                    Else
                        command = New SqlCommand("_TmSp_Store_Performance_Tahun", MyConnection)
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@TglAwal", awal)
                    command.Parameters.AddWithValue("@TglAkhir", akhir)
                    command.Parameters.AddWithValue("@Cabang", cabang)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    Me.DataGridView8.DataSource = table

                    DataGridView9.Rows(i - 1).Cells((j * 2) - k).Value = DataGridView8.Rows(0).Cells(0).Value
                    'MessageBox.Show("no")
                Next
            Next
        Next



    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If DataGridView9.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Bulan")
            .Columns.Add("Series11")
            .Columns.Add("Series12")
            .Columns.Add("Series21")
            .Columns.Add("Series22")
            .Columns.Add("Series31")
            .Columns.Add("Series32")
            .Columns.Add("Series41")
            .Columns.Add("Series42")
            .Columns.Add("Series51")
            .Columns.Add("Series52")
            .Columns.Add("Series61")
            .Columns.Add("Series62")
            .Columns.Add("Series71")
            .Columns.Add("Series72")
            .Columns.Add("Judul")
            .Columns.Add("Tahun1")
            .Columns.Add("Tahun2")
            .Columns.Add("Grow")
            .Columns.Add("Grow1")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        Dim gro1, gro2 As Double

        For i As Integer = 0 To DataGridView9.RowCount - 1
            gro1 = 0
            gro2 = 0
            If DataGridView9.Rows(i).Cells(9).Value * 1 <> 0 Then
                gro1 = ((DataGridView9.Rows(i).Cells(10).Value - DataGridView9.Rows(i).Cells(9).Value) / DataGridView9.Rows(i).Cells(9).Value) * 100
            End If
            If DataGridView9.Rows(i).Cells(11).Value * 1 <> 0 Then
                gro2 = ((DataGridView9.Rows(i).Cells(12).Value - DataGridView9.Rows(i).Cells(11).Value) / DataGridView9.Rows(i).Cells(11).Value) * 100
            End If


            dtreport.Rows.Add(DataGridView9.Rows(i).Cells(0).Value, DataGridView9.Rows(i).Cells(1).Value, DataGridView9.Rows(i).Cells(2).Value, DataGridView9.Rows(i).Cells(3).Value, DataGridView9.Rows(i).Cells(4).Value, DataGridView9.Rows(i).Cells(5).Value, DataGridView9.Rows(i).Cells(6).Value, DataGridView9.Rows(i).Cells(7).Value, DataGridView9.Rows(i).Cells(8).Value, DataGridView9.Rows(i).Cells(9).Value, DataGridView9.Rows(i).Cells(10).Value, DataGridView9.Rows(i).Cells(11).Value, DataGridView9.Rows(i).Cells(12).Value, DataGridView9.Rows(i).Cells(13).Value, DataGridView9.Rows(i).Cells(14).Value, "PERFORMANCE PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value - 1) + " DAN " + Format(thn.Value), thn.Value - 1, thn.Value, Format(gro1, "N2"), Format(gro2, "N2"))
        Next


        'viewreport5.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewreport5.ShowDialog()
        'viewreport5.Dispose()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        If DataGridView9.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("Toko")
            .Columns.Add("Omset")
            .Columns.Add("Judul")
            .Columns.Add("Target")
        End With

        Dim hasil As Double = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(2).Value
        Next
        dtreport.Rows.Add("ABM", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g1.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(4).Value
        Next
        dtreport.Rows.Add("AHMAD YANI", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g2.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(6).Value
        Next
        dtreport.Rows.Add("CIBABAT", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g5.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(8).Value
        Next
        dtreport.Rows.Add("CIBIRU", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g4.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(10).Value
        Next
        dtreport.Rows.Add("CIREBON", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g7.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(12).Value
        Next
        dtreport.Rows.Add("GARUT", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g6.Text)

        hasil = 0
        For i As Integer = 0 To DataGridView9.RowCount - 1
            hasil = hasil + DataGridView9.Rows(i).Cells(14).Value
        Next
        dtreport.Rows.Add("KOPO", hasil, "REALISASI TARGET PENJUALAN RKM BY STORE TAHUN " + Format(thn.Value), g3.Text)

        'viewreport6.ReportViewer1.LocalReport.DataSources.Item(1).Value = dtreport


        'viewreport6.ShowDialog()
        'viewreport6.Dispose()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If bln1.Text = "" Or bln2.Text = "" Then
            MessageBox.Show("Inputkan Periode Bulan!!")
            Exit Sub
        End If

        If thn.Text = "" Then
            MessageBox.Show("Inputkan Tahun!!")
            Exit Sub
        End If

        If g1.Text = "" Or g2.Text = "" Or g3.Text = "" Or g4.Text = "" Or g5.Text = "" Or g6.Text = "" Or g7.Text = "" Or g8.Text = "" Then
            MessageBox.Show("Inputkan Semua Target Tahunan Seluruh Toko!!")
            Exit Sub
        End If

        Button10.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False

        Button11_Click(sender, e)
        Button12_Click(sender, e)

        Button10.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class