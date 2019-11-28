Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class omsetsale
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

    Private Sub omsetsale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).HeaderText = "Kode Barang"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Cabang"
        DataGridView1.Columns(3).HeaderText = "Stock"
        DataGridView1.Columns(4).HeaderText = "Terjual"

        DataGridView1.Columns(2).Visible = False
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"

        Me.DataGridView1.Columns(0).Width = 120
        Me.DataGridView1.Columns(1).Width = 330
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Columns.Clear()
        Koneksi()
        Dim cabang As String = ""
        Dim cabang2 As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
            cabang2 = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
            cabang = "3"
            cabang2 = "3"
        ElseIf ComboBox1.Text = "RKM Cibabat" Then
            cabang = "CBT"
            cabang2 = "CB1"
        ElseIf ComboBox1.Text = "RKM Cibiru" Then
            cabang = "CBR"
            cabang2 = "CBR"
        ElseIf ComboBox1.Text = "RKM Cirebon" Then
            cabang = "8"
            cabang2 = "8"
        ElseIf ComboBox1.Text = "RKM Garut" Then
            cabang = "7"
            cabang2 = "7"
        ElseIf ComboBox1.Text = "RKM Kopo" Then
            cabang = "KOP"
            cabang2 = "KOP"
        ElseIf ComboBox1.Text = "RKM Sumedang" Then
            cabang = "9"
            cabang2 = "9"
        End If

        Dim akhir As String = Format(Now, "yyyy-MM-dd 00:00:00")
        Dim awal As String = Format(Date.Today.AddDays(-30), "yyyy-MM-dd 23:00:00")


        Dim command As SqlCommand
        If ComboBox1.Text <> "RKM Cirebon" And ComboBox1.Text <> "RKM Garut" And ComboBox1.Text <> "RKM Sumedang" And ComboBox1.Text <> "ABM (Anyar Building Material)" And ComboBox1.Text <> "RKM Ahmad Yani" Then
            command = New SqlCommand("rkm_omset_30Hari", MyConnection2)
        Else
            command = New SqlCommand("_TmSp_omset_30Hari", MyConnection)
        End If
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TglAwal", Format(Now, "yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TglAkhir", Format(Date.Today.AddDays(-30), "yyyy-MM-dd"))
        command.Parameters.AddWithValue("@Cabang", cabang)
        command.Parameters.AddWithValue("@Cabang2", cabang2)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.DataGridView1.DataSource = table

        'DataGridView1.DataSource = DtSet3.Tables("itemmaster").DefaultView

        DataGridView1.Columns(0).HeaderText = "Kode Barang"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Cabang"
        DataGridView1.Columns(3).HeaderText = "Stock"
        DataGridView1.Columns(4).HeaderText = "Terjual"

        DataGridView1.Columns(2).Visible = False
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"

        Me.DataGridView1.Columns(0).Width = 120
        Me.DataGridView1.Columns(1).Width = 330

    End Sub
End Class