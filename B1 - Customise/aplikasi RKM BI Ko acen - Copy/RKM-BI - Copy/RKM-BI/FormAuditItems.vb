Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Public Class FormAuditItems

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



    Sub Koneksi()
        MyConnection = New SqlConnection("Data Source=" + "10.1.0.53" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=h0spit4lity#")
        If MyConnection.State = ConnectionState.Closed Then
            MyConnection.Open()
        End If

    End Sub

    Sub LoadAuditItems()
        Dim i As Integer
        Dim longStokAkhir As Long
        Koneksi()

        Dim command As SqlCommand
        command = New SqlCommand("_tmspBIAuditReport", MyConnection)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("Cabang", Trim(GlobalStrKodeCabang))
        command.Parameters.AddWithValue("KodeBarang", GlobalstrKodeBarang)
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgAuditItems.DataSource = table
        dgAuditItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgAuditItems.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgAuditItems.AutoResizeColumns()


        'For i = 0 To dgAuditItems.RowCount - 1


        '    dgAuditItems.Rows(i).Cells(2).Value = dgAuditItems.Rows(i).Cells(2).Value 'Margin
        '    longStokAkhir = longStokAkhir + dgAuditItems.Rows(i).Cells(2).Value

        'Next

        'lblStokAkhir.Text = Format(longStokAkhir, "N0")


    End Sub


    Private Sub FormAuditItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAuditItems()
        txtKodeBarang.Text = GlobalstrKodeBarang
        txtNamaBarang.Text = GlobalStrNamaBarang
    End Sub
End Class