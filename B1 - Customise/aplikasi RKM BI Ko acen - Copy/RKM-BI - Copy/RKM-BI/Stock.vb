Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
'Imports Excel = Microsoft.Office.Interop.Excel

Public Class Stock
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
    Dim source1 As New BindingSource()

    Dim thread As System.Threading.Thread
    Dim thread2 As System.Threading.Thread

    Sub Koneksi()
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.53" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=h0spit4lity#")
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        'MyConnection2 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=ProInt_ERP;User ID=sa;Password=stip3ndium")
        'If MyConnection2.State = ConnectionState.Closed Then
        'MyConnection2.Open()
        'End If
    End Sub
    Sub hitungStock()
        Dim hitung1 As Integer
        Dim hitung2 As Integer
        Dim hitung3 As Integer
        Dim hitung4 As Integer
        Dim hitung5 As Integer
        Dim hitung6 As Integer
        Dim hitung7 As Integer
        Dim hitung8 As Integer
        Dim hitung9 As Integer
        Dim hitung10 As Integer
        Dim hitung11 As Integer


        For i As Integer = 0 To DataGridView1.RowCount - 1
            hitung1 = hitung1 + DataGridView1.Rows(i).Cells(2).Value
            hitung2 = hitung2 + DataGridView1.Rows(i).Cells(3).Value
            hitung3 = hitung3 + DataGridView1.Rows(i).Cells(4).Value
            hitung4 = hitung4 + DataGridView1.Rows(i).Cells(5).Value
            hitung5 = hitung5 + DataGridView1.Rows(i).Cells(6).Value
            hitung6 = hitung6 + DataGridView1.Rows(i).Cells(7).Value
            hitung7 = hitung7 + DataGridView1.Rows(i).Cells(8).Value
            hitung8 = hitung8 + DataGridView1.Rows(i).Cells(9).Value
            hitung9 = hitung9 + DataGridView1.Rows(i).Cells(10).Value
            hitung10 = hitung10 + DataGridView1.Rows(i).Cells(11).Value
            hitung11 = hitung11 + DataGridView1.Rows(i).Cells(12).Value


        Next
        r1.Text = hitung1
        r2.Text = hitung2
        r3.Text = hitung3
        r4.Text = hitung4
        r5.Text = hitung5
        r6.Text = hitung6
        r7.Text = hitung7
        r8.Text = hitung8
        r9.Text = hitung9
        r10.Text = hitung10
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        PictureBox1.Visible = True
        Button1.Enabled = False
        Button2.Enabled = False
        brand.Enabled = False
        vendor.Enabled = False
        TextBox1.Enabled = False
        TextBox1.Text = ""
        Me.Refresh()
        Koneksi()

        Dim command As SqlCommand
        command = New SqlCommand("_TmSp_Stock", MyConnection)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Dim table As New DataTable
        adapter.Fill(table)
        'Me.DataGridView1.DataSource = table

        Dim view1 As New DataView(table)
        source1.DataSource = view1
        DataGridView1.DataSource = view1
        DataGridView1.Refresh()

        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(1).Width = 350
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 70
        DataGridView1.Columns(4).Width = 70
        DataGridView1.Columns(5).Width = 70
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 70
        DataGridView1.Columns(8).Width = 70
        DataGridView1.Columns(9).Width = 70
        DataGridView1.Columns(10).Width = 70
        DataGridView1.Columns(11).Width = 70
        DataGridView1.Columns(12).Width = 100
        DataGridView1.Columns(13).Width = 100
        DataGridView1.Columns(14).Width = 100
        DataGridView1.Columns(15).Width = 100
        DataGridView1.Columns(16).Width = 100
        DataGridView1.Columns(17).Width = 100
        DataGridView1.Columns(18).Width = 100
        DataGridView1.Columns(19).Width = 100
        DataGridView1.Columns(20).Width = 100
        DataGridView1.Columns(21).Width = 100
        DataGridView1.Columns(22).Width = 100
        DataGridView1.Columns(23).Width = 100
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.LightGreen
        DataGridView1.Columns(4).HeaderCell.Style.BackColor = Color.LightGreen
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(13).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(14).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(15).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(16).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(17).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(18).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(19).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(20).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(21).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(22).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(23).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(24).DefaultCellStyle.Format = "N0"

        DataGridView1.Columns(25).Visible = False
        DataGridView1.Columns(26).Visible = False

        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'Dim hasil8 As Double = 0

        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'hasil8 = hasil2 + DataGridView1.Rows(i).Cells(10).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")
        'r9.Text = Format(hasil8, "NO")



        PictureBox1.Visible = False

        d1.Text = Format(Now(), "dd-MM-yyyy")
        d2.Text = Format(Now(), "hh:mm:ss")

        Button1.Enabled = True
        Button2.Enabled = True
        brand.Enabled = True
        vendor.Enabled = True
        TextBox1.Enabled = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Koneksi()
        MyCommand = New SqlDataAdapter("select cardcode from ocrd where cardname='" + vendor.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        Dim supplay As String = ""
        If DataGridView2.RowCount > 0 Then
            supplay = DataGridView2.Rows(0).Cells(0).Value
        End If

        source1.Filter = "[Nama Barang] like '%" & TextBox1.Text & "%' and [brand] like '" & brand.Text & "%' and [vendor] like '%" & supplay & "%'"
        DataGridView1.Refresh()
        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")




    End Sub

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        Me.Refresh()
        'Me.CheckForIllegalCrossThreadCalls = False

        Koneksi()
        MyCommand = New SqlDataAdapter("select firmname from omrc order by firmname", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "omrc")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("omrc").DefaultView

        brand.Items.Clear()
        For i As Integer = 0 To DataGridView2.RowCount - 1
            brand.Items.Add(DataGridView2.Rows(i).Cells(0).Value)
        Next

        MyCommand = New SqlDataAdapter("select cardname from ocrd where cardcode like 'VL%' order by cardname", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        vendor.Items.Clear()
        For i As Integer = 0 To DataGridView2.RowCount - 1
            vendor.Items.Add(DataGridView2.Rows(i).Cells(0).Value)
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

        'Clipboard.SetDataObject(o, True, 10, 2)

    End Sub









    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim alamat As String = ""
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName <> "" Then
            alamat = SaveFileDialog1.FileName
        Else
            Exit Sub
        End If

        Button1.Enabled = False
        Button2.Enabled = False
        brand.Enabled = False
        vendor.Enabled = False
        TextBox1.Enabled = False

        'Dim xlApp As Microsoft.Office.Interop.Excel.Application
        'Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        ' Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ' xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        ' xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")

        Label11.Visible = True

        For k As Integer = 1 To DataGridView1.Columns.Count
            '  xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        Next

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                '    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
            Label11.Text = "Importing Data " + Format(i) + " of " + Format(DataGridView1.RowCount)
            Me.Refresh()
        Next

        ' xlWorkSheet.SaveAs(alamat)
        'xlWorkBook.Close()
        'xlApp.Quit()
        Label11.Visible = False

        ' releaseObject(xlApp)
        ' releaseObject(xlWorkBook)
        ' releaseObject(xlWorkSheet)

        Button1.Enabled = True
        Button2.Enabled = True
        brand.Enabled = True
        vendor.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub brand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brand.SelectedIndexChanged
        Koneksi()
        MyCommand = New SqlDataAdapter("select cardcode from ocrd where cardname='" + vendor.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        Dim supplay As String = ""
        If DataGridView2.RowCount > 0 Then
            supplay = DataGridView2.Rows(0).Cells(0).Value
        End If

        source1.Filter = "[Nama Barang] like '%" & TextBox1.Text & "%' and [brand] like '" & brand.Text & " ' and [vendor] like '%" & supplay & "%'"
        DataGridView1.Refresh()
        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")

    End Sub

    Private Sub vendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vendor.SelectedIndexChanged
        Koneksi()
        MyCommand = New SqlDataAdapter("select cardcode from ocrd where cardname='" + vendor.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        Dim supplay As String = ""
        If DataGridView2.RowCount > 0 Then
            supplay = DataGridView2.Rows(0).Cells(0).Value
        End If

        source1.Filter = "[Nama Barang] like '%" & TextBox1.Text & "%' and [brand] like '" & brand.Text & " ' and [vendor] like '%" & supplay & "%'"
        DataGridView1.Refresh()
        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")

    End Sub

    Private Sub vendor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vendor.TextChanged
        Koneksi()
        MyCommand = New SqlDataAdapter("select cardcode from ocrd where cardname='" + vendor.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        Dim supplay As String = ""
        If DataGridView2.RowCount > 0 Then
            supplay = DataGridView2.Rows(0).Cells(0).Value
        End If

        source1.Filter = "[Nama Barang] like '%" & TextBox1.Text & "%' and [brand] like '" & brand.Text & "%' and [vendor] like '%" & supplay & "%'"
        DataGridView1.Refresh()
        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")

    End Sub

    Private Sub brand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles brand.TextChanged
        Koneksi()
        MyCommand = New SqlDataAdapter("select cardcode from ocrd where cardname='" + vendor.Text + "'", MyConnection)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "ocrd")
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = DtSet.Tables("ocrd").DefaultView

        Dim supplay As String = ""
        If DataGridView2.RowCount > 0 Then
            supplay = DataGridView2.Rows(0).Cells(0).Value
        End If

        source1.Filter = "[Nama Barang] like '%" & TextBox1.Text & "%' and [brand] like '" & brand.Text & "%' and [vendor] like '%" & supplay & "%'"
        DataGridView1.Refresh()
        Call hitungStock()
        'Dim hasil As Double = 0
        'Dim hasil1 As Double = 0
        'Dim hasil2 As Double = 0
        'Dim hasil3 As Double = 0
        'Dim hasil4 As Double = 0
        'Dim hasil5 As Double = 0
        'Dim hasil6 As Double = 0
        'Dim hasil7 As Double = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        'hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
        'hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
        'hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
        'hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
        'hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
        'hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
        'hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
        'hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        'Next

        'r1.Text = Format(hasil, "N0")
        'r2.Text = Format(hasil1, "N0")
        'r3.Text = Format(hasil2, "N0")
        'r4.Text = Format(hasil3, "N0")
        'r5.Text = Format(hasil4, "N0")
        'r6.Text = Format(hasil5, "N0")
        'r7.Text = Format(hasil6, "N0")
        'r8.Text = Format(hasil7, "NO")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        thread = New System.Threading.Thread(AddressOf coba)
        thread.Start()
    End Sub

    Private Sub coba()
        PictureBox1.Visible = True
        Button1.Enabled = False
        Button2.Enabled = False
        brand.Enabled = False
        vendor.Enabled = False
        TextBox1.Enabled = False
        TextBox1.Text = ""
        Me.Refresh()
        Koneksi()

        Dim command As SqlCommand
        command = New SqlCommand("Lap_VB_Stock", MyConnection)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Dim table As New DataTable
        adapter.Fill(table)
        'Me.DataGridView1.DataSource = table

        Dim view1 As New DataView(table)
        source1.DataSource = view1
        DataGridView1.DataSource = view1
        DataGridView1.Refresh()

        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 40
        DataGridView1.Columns(3).Width = 40
        DataGridView1.Columns(4).Width = 40
        DataGridView1.Columns(5).Width = 40
        DataGridView1.Columns(6).Width = 40
        DataGridView1.Columns(7).Width = 40
        DataGridView1.Columns(8).Width = 40
        DataGridView1.Columns(9).Width = 40
        DataGridView1.Columns(10).Width = 70
        DataGridView1.Columns(11).Width = 70
        DataGridView1.Columns(12).Width = 50
        DataGridView1.Columns(13).Width = 70
        DataGridView1.Columns(14).Width = 70
        DataGridView1.Columns(15).Width = 50
        DataGridView1.Columns(16).Width = 70
        DataGridView1.Columns(17).Width = 70
        DataGridView1.Columns(18).Width = 50
        DataGridView1.Columns(19).Width = 70
        DataGridView1.Columns(20).Width = 70
        DataGridView1.Columns(21).Width = 50
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(2).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(9).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(10).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(11).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(12).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(13).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(14).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(15).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(16).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(17).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(18).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(19).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(20).DefaultCellStyle.Format = "N0"
        DataGridView1.Columns(21).DefaultCellStyle.Format = "N0"

        'DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(22).Visible = False
        DataGridView1.Columns(23).Visible = False

        Dim hasil As Double = 0
        Dim hasil1 As Double = 0
        Dim hasil2 As Double = 0
        Dim hasil3 As Double = 0
        Dim hasil4 As Double = 0
        Dim hasil5 As Double = 0
        Dim hasil6 As Double = 0
        Dim hasil7 As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            hasil = hasil + DataGridView1.Rows(i).Cells(2).Value
            hasil1 = hasil1 + DataGridView1.Rows(i).Cells(3).Value
            hasil2 = hasil2 + DataGridView1.Rows(i).Cells(4).Value
            hasil3 = hasil2 + DataGridView1.Rows(i).Cells(5).Value
            hasil7 = hasil2 + DataGridView1.Rows(i).Cells(6).Value
            hasil4 = hasil2 + DataGridView1.Rows(i).Cells(7).Value
            hasil5 = hasil2 + DataGridView1.Rows(i).Cells(8).Value
            hasil6 = hasil2 + DataGridView1.Rows(i).Cells(9).Value
        Next

        r1.Text = Format(hasil, "N0")
        r2.Text = Format(hasil1, "N0")
        r3.Text = Format(hasil2, "N0")
        r4.Text = Format(hasil3, "N0")
        r5.Text = Format(hasil4, "N0")
        r6.Text = Format(hasil5, "N0")
        r7.Text = Format(hasil6, "N0")
        r8.Text = Format(hasil7, "NO")



        PictureBox1.Visible = False

        d1.Text = Format(Now(), "dd-MM-yyyy")
        d2.Text = Format(Now(), "hh:mm:ss")

        Button1.Enabled = True
        Button2.Enabled = True
        brand.Enabled = True
        vendor.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click
        CopyDataGridViewToClipboard(DataGridView1)
    End Sub
End Class