Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Public Class StockProInt
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
        MyConnection3 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=RKM-Marketing;User ID=sa;Password=stip3ndium")
        If MyConnection2.State = ConnectionState.Closed Then
            MyConnection2.Open()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).HeaderText = "Item Code"
        DataGridView1.Columns(1).HeaderText = "Item Name"
        DataGridView1.Columns(2).HeaderText = "Min Stock"
        DataGridView1.Columns(3).HeaderText = "Max Stock"
        DataGridView1.Columns(4).HeaderText = "Stock"
        DataGridView1.Columns(5).HeaderText = "Order"
        'DataGridView1.Columns(6).HeaderText = "Hari Cek"

        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 85
        DataGridView1.Columns(3).Width = 85
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        'DataGridView1.Columns(6).Width = 75

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Cabang!!")
            Exit Sub
        End If

        'If h1.Checked = False And h2.Checked = False And h3.Checked = False And h4.Checked = False And h5.Checked = False And h6.Checked = False And h7.Checked = False And h8.Checked = False Then
        'MessageBox.Show("Pilih Hari!!")
        'Exit Sub
        'End If

        'Dim hari As String = " and (haricek='' "
        'If h8.Checked = True Then
        'hari = hari + "or haricek like '%' "
        'Else
        'If h1.Checked = True Then
        'hari = hari + "or haricek='Senin' "
        'End If
        'If h2.Checked = True Then
        'hari = hari + "or haricek='Selasa' "
        'End If
        'If h3.Checked = True Then
        'hari = hari + "or haricek='Rabu' "
        'End If
        'If h4.Checked = True Then
        'hari = hari + "or haricek='Kamis' "
        'End If
        'If h5.Checked = True Then
        'hari = hari + "or haricek='Jumat' "
        'End If
        'If h6.Checked = True Then
        'hari = hari + "or haricek='Sabtu' "
        'End If
        'If h7.Checked = True Then
        'hari = hari + "or haricek='Minggu' "
        'End If
        'End If
        'hari = hari + ")"

        Dim cabang As String = ""
        If ComboBox1.Text = "ABM (Anyar Building Material)" Then
            cabang = "1"
        ElseIf ComboBox1.Text = "RKM Ayani" Then
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

        If ComboBox1.Text = "RKM Cibiru" Then
            MyCommand = New SqlDataAdapter("select ProdCode,'',0,0,convert(int,ProdQty),'' from WHCurrentStock where WrhsCode like '" + cabang + "%'", MyConnection2)
            DtSet = New DataSet()
            DtSet.Clear()
            MyCommand.Fill(DtSet, "WHCurrentStock")
            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = DtSet.Tables("WHCurrentStock").DefaultView
        Else
            MyCommand = New SqlDataAdapter("select oitw.itemcode,oitm.itemname,convert(int,isnull(oitw.minstock,0)),convert(int,isnull(oitw.maxstock,0)),convert(int,oitw.onhand),'' from oitw left join oitm on oitm.itemcode=oitw.itemcode where oitw.whscode='0100" + Format(cabang) + "001' and oitm.Validfor='Y' and oitm.itemcode not like '888%'", MyConnection)
            DtSet = New DataSet()
            DtSet.Clear()
            MyCommand.Fill(DtSet, "oitw")
            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = DtSet.Tables("oitw").DefaultView
        End If

        'MyCommand = New SqlDataAdapter("Select itemcode,itemname,convert(int,minstock),convert(int,maxstock),'','',haricek from minmaxproint where cabang='" + ComboBox1.Text + "'" + hari + "and (minstock>0 or maxstock>0) order by itemcode", MyConnection3)
        'DtSet = New DataSet()
        'DtSet.Clear()
        'MyCommand.Fill(DtSet, "minmaxproint")
        'DataGridView1.Columns.Clear()
        'DataGridView1.DataSource = DtSet.Tables("minmaxproint").DefaultView

        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'DataGridView1.Rows(i).Cells(4).Value = 0
        'For j As Integer = 0 To DataGridView2.RowCount - 1
        'If DataGridView2.Rows(j).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value Then
        'DataGridView1.Rows(i).Cells(4).Value = DataGridView2.Rows(j).Cells(1).Value
        'Exit For
        'End If
        'Next
        'Next

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(3).Value - DataGridView1.Rows(i).Cells(4).Value < 0 Then
                DataGridView1.Rows(i).Cells(5).Value = 0
            Else
                DataGridView1.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(3).Value - DataGridView1.Rows(i).Cells(4).Value
            End If
        Next


        DataGridView1.Columns(0).HeaderText = "Item Code"
        DataGridView1.Columns(1).HeaderText = "Item Name"
        DataGridView1.Columns(2).HeaderText = "Min Stock"
        DataGridView1.Columns(3).HeaderText = "Max Stock"
        DataGridView1.Columns(4).HeaderText = "Stock"
        DataGridView1.Columns(5).HeaderText = "Order"
        'DataGridView1.Columns(6).HeaderText = "Hari Cek"

        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 85
        DataGridView1.Columns(3).Width = 85
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        'DataGridView1.Columns(6).Width = 75

        Me.DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        Me.DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"

        Me.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub h4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h4.CheckedChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("Data Kosong!! Inputkan Tabel Transaksi!!")
            Exit Sub
        End If
        Dim dtreport As New DataTable
        With dtreport
            .Columns.Add("itemcode")
            .Columns.Add("itemname")
            .Columns.Add("min")
            .Columns.Add("max")
            .Columns.Add("stok")
            .Columns.Add("order")
            .Columns.Add("cabang")
            .Columns.Add("hari")
        End With

        'For Each row As DataGridViewRow In DataGridView1.Rows
        'dtreport.Rows.Add(row.Cells(1).Value * 1, row.Cells(2).Value * 1, row.Cells(0).Value)
        'Next

        For i As Integer = 0 To DataGridView1.RowCount - 1
            dtreport.Rows.Add(DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(1).Value, DataGridView1.Rows(i).Cells(2).Value, DataGridView1.Rows(i).Cells(3).Value, DataGridView1.Rows(i).Cells(4).Value, DataGridView1.Rows(i).Cells(5).Value, ComboBox1.Text, DataGridView1.Rows(i).Cells(6).Value)
        Next


        'viewminmax.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtreport


        'viewminmax.ShowDialog()
        'viewminmax.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ImportExcel.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
