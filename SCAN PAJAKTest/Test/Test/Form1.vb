Imports System.Net
Imports System.IO
Imports System.Xml

Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient

Imports Microsoft.VisualBasic
Imports BarcodeLib.BarcodeReader
Imports ThoughtWorks.QRCode
Imports System.Text

Imports System.Text.RegularExpressions

Imports SystemUtils = ThoughtWorks.QRCode.Codec.Util.SystemUtils
Imports QRCodeUtility = ThoughtWorks.QRCode.Codec.Util.QRCodeUtility


Public Class Form1

    Dim request As HttpWebRequest
    Dim response As HttpWebResponse = Nothing
    Dim reader As StreamReader
    Dim result As String
    Dim JumlahDuplikat As Integer
    Dim strIntBarisAtas As String
    Dim intBarisNow As Integer
    Dim BolDuplikat As Boolean





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim filePath As String = TextBox1.Text
        Dim xmlFile As XmlReader
        xmlFile = XmlReader.Create(TextBox1.Text, New XmlReaderSettings())
        Dim ds As New DataSet
        ds.ReadXml(xmlFile)
        DgvScan.DataSource = ds
        DgvScan.DataMember = "resValidateFakturPm"
        DgvScan.DataSource = ds
        DgvScan.DataMember = "detailTransaksi"
        'DGVScan.DataSource = ds.Tables(0)

        'DGVDB.Columns(2).DefaultCellStyle.Format = "###.###-##.########"
        'DGVDB.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGVDB.ReadOnly = True


        DataGridView1.ColumnCount = 9
        DataGridView1.Columns(0).HeaderText = "Nama Barang"
        DataGridView1.Columns(1).HeaderText = "Qty"
        DataGridView1.Columns(2).HeaderText = "Harga"
        DataGridView1.Columns(3).HeaderText = "Total Harga"
        DataGridView1.Columns(4).HeaderText = "Diskon"
        DataGridView1.Columns(5).HeaderText = "DPP"
        DataGridView1.Columns(6).HeaderText = "PPN"
        DataGridView1.Columns(7).HeaderText = "Tarif PPNBM"
        DataGridView1.Columns(8).HeaderText = "PPNBM"

        DataGridView1.Columns(0).Width = 250
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100

        'DataGridABM.Columns(14).Visible = False
        For i = 0 To DataGridView1.RowCount - 1
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            DataGridView1.Rows(i).Cells(0).Value = DataGridView1.Rows(i).Cells(0).Value
            DataGridView1.Rows(i).Cells(1).Value = DataGridView1.Rows(i).Cells(2).Value
            DataGridView1.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(1).Value
            DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(3).Value
            DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(4).Value
            DataGridView1.Rows(i).Cells(5).Value = DataGridView1.Rows(i).Cells(5).Value
            DataGridView1.Rows(i).Cells(6).Value = DataGridView1.Rows(i).Cells(6).Value
            DataGridView1.Rows(i).Cells(7).Value = DataGridView1.Rows(i).Cells(7).Value
            DataGridView1.Rows(i).Cells(8).Value = DataGridView1.Rows(i).Cells(8).Value


        Next





    End Sub
End Class
