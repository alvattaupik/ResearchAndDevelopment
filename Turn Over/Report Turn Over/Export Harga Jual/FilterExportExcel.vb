Imports System.IO
Imports System.Data.SqlClient

Public Class FilterExportExcel

    Private Sub FilterExportExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpBulanan.Format = DateTimePickerFormat.Custom
        dtpBulanan.CustomFormat = "MMMM yyyy"


        dtpTglAwal.Format = DateTimePickerFormat.Custom
        dtpTglAwal.CustomFormat = "MMMM yyyy"

        dtpTglAkhir.Format = DateTimePickerFormat.Custom
        dtpTglAkhir.CustomFormat = "MMMM yyyy"


        dtpBulanan.Value = Now
        dtpTglAwal.Value = Now
        dtpTglAkhir.Value = Now

        conn_server = "10.1.0.53"
        conn_user = "sa"
        conn_database = "DB_EMAIL"
        conn_pass = "h0spit4lity#"

        Call koneksi()
        Call LoadComboBox()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ChkCabang.Checked = False Then
            Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim xls As New Microsoft.Office.Interop.Excel.Application
            Dim IntJmlhRow As Integer


            Dim resourcesFolder = IO.Path.GetFullPath(txtTemplate1.Text)


            xlsWorkBook = xls.Workbooks.Open(resourcesFolder)
            xlsWorkSheet = xlsWorkBook.Sheets("Sheet 1")


            strSQl = "SELECT Tahun, Cabang,Persentase,JenisPekerjaanTidakCocok,TidakCocokdenganAtasan,Sakit,MendapatPekerjaanLain,Kabur FROM V_ReportPerBulan  Where BulanRekap ='" & Format(dtpBulanan.Value, "MM yyyy") & "'"
            Dim dscmd As New SqlDataAdapter(strSQl, conn)
            Dim ds As New DataSet
            dscmd.Fill(ds)

            IntJmlhRow = ds.Tables(0).Rows.Count - 1


            If IntJmlhRow = 0 Then
                MsgBox("Tidak Ada Data ", vbInformation, "Informasi")
                Exit Sub
            End If

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    xlsWorkSheet.Cells(i + 3, j + 1) = _
                    ds.Tables(0).Rows(i).Item(j)
                Next
            Next

            xlsWorkBook.Close()
            xls.Quit()


            conn.Close()

        Else
            Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim xls As New Microsoft.Office.Interop.Excel.Application

            Dim resourcesFolder = IO.Path.GetFullPath("C:\Master TurnOver\")
            Dim fileName = "Master OK.xlsx"

            xlsWorkBook = xls.Workbooks.Open(resourcesFolder & fileName)
            xlsWorkSheet = xlsWorkBook.Sheets("DATASOURCE")


            strSQl = "SELECT Cabang,Persentase,JenisPekerjaanTidakCocok,TidakCocokdenganAtasan,Sakit,MendapatPekerjaanLain,Kabur FROM V_ReportPerBulan Where BulanRekap between  '" & Format(dtpTglAwal.Value, "MM yyyy") & "' AND '" & Format(dtpTglAkhir.Value, "MM yyyy") & "' AND KodeCabang ='" & cmbCabang.SelectedValue & "' Order By TanggalRekap"
            Dim dscmd As New SqlDataAdapter(strSQl, conn)
            Dim ds As New DataSet
            dscmd.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    xlsWorkSheet.Cells(i + 3, j + 1) = _
                    ds.Tables(0).Rows(i).Item(j)
                Next
            Next

            xlsWorkBook.Close()
            xls.Quit()

            'MsgBox("Tidak Ada Data")
            conn.Close()


        End If
    End Sub


    Sub LoadComboBox()
        koneksi()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT KodeLokasi,NamaLokasi FROM dbo.V_Lokasi WHERE NamaLokasi NOT LIKE '%Gudang Toko%'", conn)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbCabang.DataSource = dt
            cmbCabang.ValueMember = "KodeLokasi"
            cmbCabang.DisplayMember = "NamaLokasi"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ChkCabang_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCabang.CheckedChanged
        If ChkCabang.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtTemplate1.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        On Error GoTo Errorhandler

        If txtTemplate1.Text = "" Then
            MsgBox("Tidak Ada File Yang Dipilih", vbCritical, "Pilih File")
            Exit Sub
        End If

        Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xls As New Microsoft.Office.Interop.Excel.Application
        Dim IntJmlhRow As Integer


        Dim resourcesFolder = IO.Path.GetFullPath(txtTemplate1.Text)


        xlsWorkBook = xls.Workbooks.Open(resourcesFolder)
        xlsWorkSheet = xlsWorkBook.Sheets("Data Source")


        strSQl = "SELECT Tahun, Cabang,Persentase,JenisPekerjaanTidakCocok,TidakCocokdenganAtasan,Sakit,MendapatPekerjaanLain,Kabur FROM V_ReportPerBulan  Where BulanRekap ='" & Format(dtpBulanan.Value, "MM yyyy") & "'"
        Dim dscmd As New SqlDataAdapter(strSQl, conn)
        Dim ds As New DataSet
        dscmd.Fill(ds)

        IntJmlhRow = ds.Tables(0).Rows.Count - 1


        If IntJmlhRow = 0 Then
            MsgBox("Tidak Ada Data ", vbInformation, "Informasi")
            Exit Sub
        End If

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                xlsWorkSheet.Cells(i + 3, j + 1) = _
                ds.Tables(0).Rows(i).Item(j)
            Next
        Next

        xlsWorkBook.Close()
        xls.Quit()


        conn.Close()
        Exit Sub

Errorhandler:

        MsubPesanError()
        Exit Sub

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo ErrorHandler

        If txtTemplate2.Text = "" Then
            MsgBox("Tidak Ada File Yang Dipilih", vbCritical, "Pilih File")
            Exit Sub
        End If


        Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xls As New Microsoft.Office.Interop.Excel.Application

        Dim resourcesFolder = IO.Path.GetFullPath(txtTemplate2.Text)


        xlsWorkBook = xls.Workbooks.Open(resourcesFolder)
        xlsWorkSheet = xlsWorkBook.Sheets("Data Source")


        strSQl = "SELECT Cabang,Persentase,JenisPekerjaanTidakCocok,TidakCocokdenganAtasan,Sakit,MendapatPekerjaanLain,Kabur FROM V_ReportPerBulan Where BulanRekap between  '" & Format(dtpTglAwal.Value, "MM yyyy") & "' AND '" & Format(dtpTglAkhir.Value, "MM yyyy") & "' AND KodeCabang ='" & cmbCabang.SelectedValue & "' Order By TanggalRekap"
        Dim dscmd As New SqlDataAdapter(strSQl, conn)
        Dim ds As New DataSet
        dscmd.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                xlsWorkSheet.Cells(i + 3, j + 1) = _
                ds.Tables(0).Rows(i).Item(j)
            Next
        Next

        xlsWorkBook.Close()
        xls.Quit()

        'MsgBox("Tidak Ada Data")
        conn.Close()

ErrorHandler:
        MsubPesanError()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtTemplate2.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class