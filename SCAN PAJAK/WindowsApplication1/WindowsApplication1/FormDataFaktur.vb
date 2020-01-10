Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class FormDataFaktur

    Public strNamaGrid As String

    Private Sub cmdTampilkan_Click(sender As Object, e As EventArgs) Handles cmdTampilkan.Click

        Dim oDateAwal As DateTime = Convert.ToDateTime(dtpAwal.Value)
        Dim oDateAkhir As DateTime = Convert.ToDateTime(dtpAkhir.Value)

        KoneksiDatabase()

        Dim cmd As New SqlCommand("Select Distinct NoFakturPajak,TanggalFakturPajak,NamaPengusahaKenaPajak,AlamatPengusahaKenaPajak,NoNPWPKenaPajak,NamaPembeliKenaPajak,AlamatPembeliKenaPajak,NPWPPembeliKenaPajak,DPPTOTAL,PPNTOTAL,PPNBMTOTAL,TotalALL,DiscountALL,UangMukaALL from V_TransaksiFakturPajak Where TanggalFakturPajak between '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' And '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)
        'Dim cmd As New SqlCommand("Select * from V_TransaksiFakturPajak Where TanggalFakturPajak between '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' And '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgTransaksiFakturPajak.DataSource = table
        dgTransaksiFakturPajak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgTransaksiFakturPajak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgTransaksiFakturPajak.AutoResizeColumns()

        Koneksi.Close()
        lblJumlahDataFaktur.Text = "Jumlah Data : " & dgTransaksiFakturPajak.RowCount


        LoadDGExport()

    End Sub

    Sub LoadDGExport()
        Dim oDateAwal As DateTime = Convert.ToDateTime(dtpAwal.Value)
        Dim oDateAkhir As DateTime = Convert.ToDateTime(dtpAkhir.Value)

        KoneksiDatabase()

        'Dim cmd As New SqlCommand("Select NoFakturPajak,TanggalFakturPajak,NamaPengusahaKenaPajak,NamaBarang,Qty,Jumlah As Total,PPN from V_TransaksiFakturPajak Where TanggalFakturPajak between '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' And '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)
        Dim cmd As New SqlCommand("Select * from V_TransaksiFakturPajak Where TanggalFakturPajak between '" & Format(dtpAwal.Value, "yyyy-MM-dd") & "' And '" & Format(dtpAkhir.Value, "yyyy-MM-dd") & "'", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgExport.DataSource = table
        dgExport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgExport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgExport.AutoResizeColumns()

        Koneksi.Close()

    End Sub



    Private Sub FormDataFaktur_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpAwal.Value = Now
        dtpAkhir.Value = Now

        strNamaGrid = "datagrid header"

    End Sub


    Private Sub CopyDataGridViewToClipboardHeader(ByRef dgv As DataGridView)
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

    Private Sub CopyDataGridViewToClipboardDetail(ByRef dgv As DataGridView)
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
        'Clipboard.SetDataObject(o, True)
        'Clipboard.SetDataObject(o, True, 2, 10)
        Clipboard.ContainsText()
        Clipboard.SetDataObject(o, True, 10, 200)

    End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CopyDataGridViewToClipboardHeader(dgTransaksiFakturPajak)
    End Sub






    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim saveFileDialog1 As New SaveFileDialog

        Try
            Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer

            ExcelApp = New Microsoft.Office.Interop.Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")

            ProgressBar1.Visible = True

            For a = 0 To dgExport.RowCount - 2
                For b = 0 To dgExport.ColumnCount - 1
                    For c As Integer = 1 To dgExport.Columns.Count

                        ExcelWorkSheet.Cells(1, c) = dgExport.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 2, b + 1) = dgExport(b, a).Value.ToString()


                    Next
                Next
                ProgressBar1.Value = ProgressBar1.Value + 1
            Next



            saveFileDialog1.Filter = "Excel File|*.xlsx"
            saveFileDialog1.Title = "Save an Excel File"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                ExcelWorkSheet.SaveAs(saveFileDialog1.FileName)
            Else
                Exit Sub
                ProgressBar1.Visible = False
            End If

            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            MsgBox("Hasil Export Tersimpan di" & (saveFileDialog1.FileName))
            ProgressBar1.Visible = False
        Catch ex As Exception

        End Try



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

    Private Sub dgTransaksiFakturPajak_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTransaksiFakturPajak.CellContentClick
        'strjenisTransaksi = dgvDB.Item(0, dgvDB.CurrentRow.Index).Value.ToString
        'strFakturPengganti = dgvDB.Item(1, dgvDB.CurrentRow.Index).Value.ToString

        txtNoFakturPajak.Text = dgTransaksiFakturPajak.Item(0, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString
        txtTglFakturpajak.Text = dgTransaksiFakturPajak.Item(1, dgTransaksiFakturPajak.CurrentRow.Index).Value
        txtNamaPengusahakenaPajak.Text = dgTransaksiFakturPajak.Item(2, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString
        txtAlamatPengusahaKenaPajak.Text = dgTransaksiFakturPajak.Item(3, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString
        txtNPWPKenaPajak.Text = dgTransaksiFakturPajak.Item(4, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString


        txtNamaLawan.Text = dgTransaksiFakturPajak.Item(5, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString
        txtAlamatlawan.Text = dgTransaksiFakturPajak.Item(6, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString
        txtNPWPLawan.Text = dgTransaksiFakturPajak.Item(7, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString



        txtDPPTotal.Text = CDbl(dgTransaksiFakturPajak.Item(8, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtPPnTotal.Text = CDbl(dgTransaksiFakturPajak.Item(9, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtPPNBMTotal.Text = CDbl(dgTransaksiFakturPajak.Item(10, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")


        txtHargaTotal.Text = CDbl(dgTransaksiFakturPajak.Item(11, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtDiskonTotal.Text = CDbl(dgTransaksiFakturPajak.Item(12, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtUangMukaTotal.Text = CDbl(dgTransaksiFakturPajak.Item(13, dgTransaksiFakturPajak.CurrentRow.Index).Value.ToString).ToString("##,0")


        'strStatusApproval = dgvDB.Item(13, dgvDB.CurrentRow.Index).Value.ToString
        'strSTatusFaktur = dgvDB.Item(14, dgvDB.CurrentRow.Index).Value.ToString

    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click


        strNamaGrid = "datagrid detail faktur"


        If txtNoFakturPajak.Text = "" Then
            MsgBox("Tidak Ada Nomor Faktur Pajak yang Dipilih", vbInformation, "Tidak Ada Data")
            dgDetailFaktur.Visible = False
            cmdLihatDetail.Visible = True
            Exit Sub
        Else
            dgDetailFaktur.Visible = True
            gbDetailFaktur.Visible = True
            cmdExport.Enabled = False
        End If

        dgDetailFaktur.Visible = True

        KoneksiDatabase()

        Dim cmd As New SqlCommand("Select * from V_TransaksiFakturPajak Where NoFakturPajak='" & Trim(txtNoFakturPajak.Text) & "'", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgDetailFaktur.DataSource = table
        dgDetailFaktur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDetailFaktur.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgDetailFaktur.AutoResizeColumns()

        Koneksi.Close()
        lblJumlahItemDetail.Text = "Jumlah Items : " & dgDetailFaktur.RowCount

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        CopyDataGridViewToClipboardDetail(dgDetailFaktur)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbDetailFaktur.Visible = False
        dgDetailFaktur.Visible = False
        cmdLihatDetail.Visible = True
        cmdExport.Enabled = True

        strNamaGrid = "datagrid header"


    End Sub




    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click
        If strNamaGrid = "datagrid header" Then
            Call CopyDataGridViewToClipboardHeader(dgExport)
        Else
            Call CopyDataGridViewToClipboardDetail(dgDetailFaktur)
        End If


    End Sub


End Class