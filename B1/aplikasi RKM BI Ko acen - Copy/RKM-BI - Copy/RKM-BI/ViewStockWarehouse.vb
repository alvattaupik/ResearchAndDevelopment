Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Imports RKM_BI.MarginBaru




Public Class ViewStockWarehouse
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

    Private Sub ViewStockWarehouse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Koneksi()
        GroupBox1.Text = MarginBaru.TxtCek.Text
        MyCommand = New SqlDataAdapter("select t0.WhsCode,t2.WhsName,t0.OnHand-t0.IsCommited,t0.OnHand,t0.IsCommited,t0.OnOrder from oitw t0 left join oitm t1 on t1.ItemCode=t0.ItemCode left join owhs t2 on t2.WhsCode=t0.WhsCode where (t0.WhsCode not like '%002' and t0.whscode not like '01000001' and t0.WhsCode not like '%003' and t0.WhsCode  not like 'ds') and t0.ItemCode='" + Trim(MarginBaru.TxtCek.Text) + "'", MyConnection)
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
End Class