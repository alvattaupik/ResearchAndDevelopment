Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports OutlookStyleControls

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Text
'Imports System.Windows.data
Imports System.Windows.Forms
Imports System.Collections.ObjectModel
Imports OutlookStyleControls.OutlookgGridDefaultGroup
Imports System.Data.DataRow
Imports System.Collections.Generic.Comparer(Of String)


Public Class Testing
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
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.6" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=anyarretailindonesia")
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If
        MyConnection2 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=ProInt_ERP;User ID=sa;Password=stip3ndium")
        If MyConnection2.State = ConnectionState.Closed Then
            MyConnection2.Open()
        End If
    End Sub

    Private Sub Testing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' first clear any previous bindings (if they were set)
        'OutlookGrid1.BindData()

        ' setup the column headers 
        OutlookGrid1.Columns.Add("column1", "Id")
        OutlookGrid1.Columns.Add("column2", "Name")


        'then create the rows
        ' row 1:
        Dim row As OutlookGridRow = New OutlookGridRow()
        row.CreateCells(OutlookGrid1, "111", "xxx")
        OutlookGrid1.Rows.Add(row)

        ' row 2:
        'Dim row As OutlookGridRow = New OutlookGridRow()
        row.CreateCells(OutlookGrid1, "222", "yyy")
        OutlookGrid1.Rows.Add(row)

        ' set the column to be used for grouping
        OutlookGrid1.GroupTemplate.Column = OutlookGrid1.Columns(0)

        ' then select one of 2 ways of sorting.
        ' option 1: the easy way, use the OutlookGridRowComparer object
        'OutlookGrid1.Sort(New OutlookGridRowComparer("0", direction))

        ' option 2: the even easier way, specify which column to sort on
        OutlookGrid1.Sort(OutlookGrid1.Columns(0), "desc")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Koneksi()
        Dim command As SqlCommand

        command = New SqlCommand("_TmSp_margin_rep", MyConnection)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", "2017-08-10 00:00:00")
        command.Parameters.AddWithValue("@TanggalAkhir", "2017-08-10 23:00:00")
        command.Parameters.AddWithValue("@PrintByUserName", "xxx")
        command.Parameters.AddWithValue("@Cabang", "8")
        Dim table As New DataTable
        adapter.Fill(table)

        DtSet = New System.Data.DataSet
        adapter.Fill(DtSet, "oinv")

        ' Me.DataGrid1.DataSource = table


        'Dim cvTasks As ICollectionView = New CollectionViewSource.GetDefaultView(DataGrid1.ItemsSource)
        'If cvTasks IsNot Nothing And cvTasks.CanGroup = True Then
        'cvTasks.GroupDescriptions.Clear()
        'cvTasks.GroupDescriptions.Add(New PropertyGroupDescription("ProjectName"))
        'cvTasks.GroupDescriptions.Add(New PropertyGroupDescription("Complete"))
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim dtstudent As DataTable = New DataTable()
        ' add column to datatable  
        dtstudent.Columns.Add("Student_ID")

        'Child table  
        Dim dtstudentMarks As DataTable = New DataTable()
        dtstudentMarks.Columns.Add("Student_ID")
        dtstudentMarks.Columns.Add("Subject_ID")


        ' Adding Rows  
        dtstudent.Rows.Add(111)
        dtstudent.Rows.Add(222)
        dtstudent.Rows.Add(333)
        dtstudent.Rows.Add(444)

        ' data for devesh ID=111  
        dtstudentMarks.Rows.Add(111, "01")
        dtstudentMarks.Rows.Add(222, "02")
        dtstudentMarks.Rows.Add(333, "03")
        dtstudentMarks.Rows.Add(444, "01")

        Dim dsDataset As DataSet = New DataSet()
        'Add two DataTables in Dataset  
        dsDataset.Tables.Add(dtstudent)
        dsDataset.Tables.Add(dtstudentMarks)

        'Dim Datatablerelation As DataRelation = New DataRelation("DetailsMarks", dsDataset.Tables(0).Columns(0), dsDataset.Tables(1).Columns(0), False)
        Dim Datatablerelation As DataRelation = New DataRelation("DetailsMarks", dsDataset.Tables(0).Columns(0), dsDataset.Tables(1).Columns(0), False)
        dsDataset.Relations.Add(Datatablerelation)
        ' DataGrid1.DataSource = dsDataset.Tables(0)
    End Sub
End Class