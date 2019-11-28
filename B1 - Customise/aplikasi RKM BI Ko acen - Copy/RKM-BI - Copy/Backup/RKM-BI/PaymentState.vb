Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class PaymentState
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
        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Cabang!!")
            Exit Sub
        End If

        DataGridView1.Columns.Clear()

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "ABM"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "RKM A. YANI"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "RKM Cibabat"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "RKM Cirebon"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "RKM Garut"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "RKM Kopo"
        ElseIf ComboBox1.Text = "RKM Sumedang" Then
            cabang = "RKM Sumedang"
        End If

        Koneksi()

        Dim awal As String = Format(DateTimePicker1.Value, "yyyy-MM-dd") + " 00:00:00.000"
        Dim akhir As String = Format(DateTimePicker2.Value, "yyyy-MM-dd") + " 23:59:00.000"

        Dim command As SqlCommand
        If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Cibabat" And ComboBox1.Text <> "RKM Kopo" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ayani" And ComboBox1.Text <> "RKM Sumedang" Then
            command = New SqlCommand("rkm_payment_state", MyConnection2)
        Else
            command = New SqlCommand("_TmSp_Total_Payment_By_Type2", MyConnection)
        End If
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TglAwal", awal)
        command.Parameters.AddWithValue("@TglAkhir", akhir)
        command.Parameters.AddWithValue("@Cabang", cabang)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table



        For i As Integer = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(1).Value + DataGridView1.Rows(i).Cells(2).Value + DataGridView1.Rows(i).Cells(3).Value + DataGridView1.Rows(i).Cells(4).Value + DataGridView1.Rows(i).Cells(5).Value + DataGridView1.Rows(i).Cells(6).Value
        Next

        DataGridView1.Columns(0).HeaderText = "Tanggal"
        DataGridView1.Columns(1).HeaderText = "CASH"
        DataGridView1.Columns(2).HeaderText = "DEBIT CARD BCA"
        DataGridView1.Columns(3).HeaderText = "CREDIT CARD BCA"
        DataGridView1.Columns(4).HeaderText = "DEBIT CARD MANDIRI"
        DataGridView1.Columns(5).HeaderText = "CREDIT CARD MANDIRI"
        DataGridView1.Columns(6).HeaderText = "TRANSFER BANK"
        DataGridView1.Columns(7).HeaderText = "TOTAL"


        Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"

        Me.DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub PaymentState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 8
        DataGridView1.Columns(0).HeaderText = "Tanggal"
        DataGridView1.Columns(1).HeaderText = "CASH"
        DataGridView1.Columns(2).HeaderText = "DEBIT CARD BCA"
        DataGridView1.Columns(3).HeaderText = "CREDIT CARD BCA"
        DataGridView1.Columns(4).HeaderText = "DEBIT CARD MANDIRI"
        DataGridView1.Columns(5).HeaderText = "CREDIT CARD MANDIRI"
        DataGridView1.Columns(6).HeaderText = "TRANSFER BANK"
        DataGridView1.Columns(7).HeaderText = "TOTAL"
    End Sub
End Class