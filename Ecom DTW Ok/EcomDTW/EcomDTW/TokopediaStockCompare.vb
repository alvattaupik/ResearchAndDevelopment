Imports System.IO
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class TokopediaStockCompare


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgTokopediaSKU.DataSource = Nothing
        dgTokopediaSKU.Rows.Clear()
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathTokpedSKU.Text = O.FileName
                LoadtxtFile()
                'UploadDatamaster()
            End If
        End Using
    End Sub

    Sub LoadtxtFile()
        Using objReader As New StreamReader(txtPathTokpedSKU.Text)
            Do While objReader.Peek() <> -1
                Dim line As String = objReader.ReadLine()
                Dim splitLine() As String = line.Split(vbTab)
                Dim IdProduk As String = splitLine(0)

                dgTokopediaSKU.Rows.Add(splitLine(0))
            Loop
            lblJumlahProdukTokped.Text = "Jumlah Produk: " & dgTokopediaSKU.Rows.Count
        End Using
    End Sub


    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        On Error GoTo ErrorLoad

        If dgTokopediaSKU.Rows.Count = 0 Then
            MsgBox("Please Insert Tokopedia SKU")
            Exit Sub
        End If


        dgSAPStock.DataSource = Nothing
        dgSAPStock.Rows.Clear()

        Call KoneksiDB_EMAIL()
        Dim cmd1 As New SqlCommand
        cmd1.CommandText = "[Delete_TokopediaSKU]"
        cmd1.CommandType = CommandType.StoredProcedure
        If (KoneksiSQLSRV.State = ConnectionState.Open) Then KoneksiSQLSRV.Close()
        cmd1.Connection = KoneksiSQLSRV
        KoneksiSQLSRV.Open()
        cmd1.ExecuteNonQuery()

        KoneksiSQLSRV.Close()

        UploadSKU()

        CekRealtimeStock()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)


    End Sub



    Sub CekRealtimeStock()
        KoneksiDatabaseSQLSERVER()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_GetAvailableStockForEcomFromAllWHS", KoneksiSQLSRV)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgSAPStock.DataSource = table
        dgSAPStock.DataSource = table
        dgSAPStock.RowHeadersVisible = False
        lblJumlahProduk2.Text = "Jumlah Produk : " & dgSAPStock.Rows.Count

        If dgSAPStock.Rows.Count = 0 Then
            btnExportTo.Enabled = False
        Else
            btnExportTo.Enabled = True
        End If

    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
      
    End Sub


    Sub UploadSKU()
        On Error GoTo ErrorLoad
        For i As Integer = 0 To dgTokopediaSKU.Rows.Count - 1

            Call KoneksiDB_EMAIL()
            Dim cmd2 As New SqlCommand
            cmd2.CommandText = "[AD_TokopediaSKU]"
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters.AddWithValue("KodeBarang", Trim(dgTokopediaSKU.Rows(i).Cells(0).Value))

            If (KoneksiSQLSRV.State = ConnectionState.Open) Then KoneksiSQLSRV.Close()
            cmd2.Connection = KoneksiSQLSRV
            cmd2.CommandTimeout = 0
            KoneksiSQLSRV.Open()
            cmd2.ExecuteNonQuery()



        Next

        KoneksiSQLSRV.Close()
        dgTokopediaSKU.DataSource = Nothing
        dgTokopediaSKU.Rows.Clear()



        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
    End Sub


    Private Sub TokopediaStockCompare_Load(sender As Object, e As EventArgs) Handles Me.Load

        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True


        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnExportTo_Click(sender As Object, e As EventArgs) Handles btnExportTo.Click
        If dgSAPStock.RowCount > 0 Then
            'Deklarasi Object
            Dim ApExcel As Object

            'Set sebagai excel  object
            ApExcel = CreateObject("Excel.application")

            'Menyembunyikan proses excel
            ApExcel.Visible = False

            'Membuat/menambah workbook baru
            ApExcel.Workbooks.Add()

            'Lebar Kolom
            ApExcel.Columns(1).ColumnWidth = 15
            ApExcel.Columns(2).ColumnWidth = 20

            'Tulis nama kolom ke excel
            For i As Integer = 1 To dgSAPStock.Columns.Count
                ApExcel.Cells(1, i).Value = dgSAPStock.Columns(i - 1).Name
            Next

            'lblExport.Visible = True

            'Tulis data ke excel
            For r = 0 To dgSAPStock.RowCount - 1
                For i As Integer = 1 To dgSAPStock.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dgSAPStock.Rows(r).Cells(i - 1).Value

                    'lblExport.Text = "Mengexport : " & r & " Dari : " & dgSAPStock.RowCount

                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:M1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:M1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:B" & dgSAPStock.RowCount + 1).WrapText = True

            'Membuat border hitam
            'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
            ApExcel.Visible = True
            ApExcel = Nothing

        End If
    End Sub

    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click
        Call CopyDataGridViewToClipboard(dgSAPStock)
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



    End Sub



End Class