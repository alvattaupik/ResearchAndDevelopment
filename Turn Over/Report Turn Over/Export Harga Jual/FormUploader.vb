Imports System.Data.SqlClient

Public Class FormUploader

    Dim BolEdit As Boolean

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo ErrorHandler

        conn_server = "10.1.0.53"
        conn_user = "sa"
        conn_database = "DB_EMAIL"
        conn_pass = "h0spit4lity#"


        Call koneksi()
        Call LoadComboBox()
        LoadGridView()
        lblNamaKomputer.Text = Environment.MachineName()

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        lblIP.Text = h.AddressList.GetValue(0).ToString






        If Err.Description = "" Then Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub

    Private Sub LoadComboBox()
        ' siapkan koneksi database
        koneksi()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.V_Lokasi WHERE NamaLokasi Not LIKE '%Gudang Toko%'", conn)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            dcCabang.DataSource = dt
            dcCabang.ValueMember = "KodeLokasi"
            dcCabang.DisplayMember = "NamaLokasi"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Sub LoadGridView()
        Call koneksi()



        conn = New SqlConnection(server)
        Dim cmd As New SqlCommand("SELECT * FROM dbo.V_ReportPerBulan order By TanggalRekap", conn)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgReport.DataSource = table
        dgReport.Columns(0).Width = 0

        'dgReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'dgReport.AutoResizeColumns()


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.txt")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Write As New IO.StreamWriter(sfile.FileName)
            'Dim k As DataGridView1.column = DataGridView1.Columns
            'For Each x As ListViewItem In ListView1.Items
            '    Dim StrLn As String = ""
            '    For i = 1 To x.SubItems.Count - 1
            '        StrLn += x.SubItems(i).Text + vbTab
            '    Next
            '    Write.WriteLine(StrLn)
            'Next
            'Write.Close() 'Or  Write.Flush()
        End If

        Exit Sub




    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        MsgBox("Anda Akan menambahkan Data baru", vbInformation, "Informasi")
        dtpInput.Value = Now
        dcCabang.Text = ""
        txtAtasan.Text = ""
        txtKabur.Text = ""
        txtPekerjaanLain.Text = ""
        txtPersen.Text = ""
        txtSakit.Text = ""
        txtTidakCocok.Text = ""
    End Sub

    Private Sub dgReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReport.CellClick

        BolEdit = True

        txtDocEntry.Text = dgReport.Item(0, dgReport.CurrentRow.Index).Value
        dtpInput.Text = dgReport.Item(1, dgReport.CurrentRow.Index).Value
        dcCabang.Text = dgReport.Item(4, dgReport.CurrentRow.Index).Value
        txtPersen.Text = dgReport.Item(5, dgReport.CurrentRow.Index).Value
        txtTidakCocok.Text = dgReport.Item(6, dgReport.CurrentRow.Index).Value
        txtAtasan.Text = dgReport.Item(7, dgReport.CurrentRow.Index).Value
        txtSakit.Text = dgReport.Item(8, dgReport.CurrentRow.Index).Value
        txtPekerjaanLain.Text = dgReport.Item(9, dgReport.CurrentRow.Index).Value
        txtKabur.Text = dgReport.Item(10, dgReport.CurrentRow.Index).Value

    End Sub

    Private Sub dgReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgReport.CellContentClick

    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        If dcCabang.Text = "" Then
            MsgBox("Nama Cabang Tidak boleh Kosong", vbInformation, "Informasi")
            Exit Sub
        End If


        If dcCabang.Text = "" Then
            MsgBox("Nama Cabang Tidak boleh Kosong", vbInformation, "Informasi")
            Exit Sub
        End If



        Using (conn)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = conn


            sqlComm.CommandText = "[AUD_Rekap]"
            sqlComm.CommandType = CommandType.StoredProcedure

            If BolEdit = True Then
                sqlComm.Parameters.AddWithValue("DocEntry", txtDocEntry.Text)
            Else
                sqlComm.Parameters.AddWithValue("DocEntry", "")
            End If

            sqlComm.Parameters.AddWithValue("TanggalRekap", dtpInput.Value)
            sqlComm.Parameters.AddWithValue("KodeCabang", dcCabang.SelectedValue)
            sqlComm.Parameters.AddWithValue("Persentase", txtPersen.Text)
            sqlComm.Parameters.AddWithValue("PekerjaanTidakCocok", txtTidakCocok.Text)
            sqlComm.Parameters.AddWithValue("TidakCocokAtasan", txtAtasan.Text)
            sqlComm.Parameters.AddWithValue("Sakit", txtSakit.Text)
            sqlComm.Parameters.AddWithValue("DapatPekerjaanLain", txtPekerjaanLain.Text)
            sqlComm.Parameters.AddWithValue("Kabur", txtKabur.Text)
            sqlComm.Parameters.AddWithValue("Status", "A")

            conn.Open()

            sqlComm.ExecuteNonQuery()

        End Using
        MsgBox("Data Berhasil Disimpan", vbInformation, "Informasi")
        bersihkan()

        LoadGridView()





    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        FilterExportExcel.ShowDialog()

        'Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim xls As New Microsoft.Office.Interop.Excel.Application

        'Dim resourcesFolder = IO.Path.GetFullPath(Application.StartupPath & "\")
        'Dim fileName = "Master Perbulan.xlsx"

        'xlsWorkBook = xls.Workbooks.Open(resourcesFolder & fileName)
        'xlsWorkSheet = xlsWorkBook.Sheets("Sheet 1")


        'conn.Open()
        'strSQl = "SELECT Tahun, Cabang,Persentase,JenisPekerjaanTidakCocok,TidakCocokdenganAtasan,Sakit,MendapatPekerjaanLain,Kabur FROM V_ReportPerBulan"
        'Dim dscmd As New SqlDataAdapter(strSQl, conn)
        'Dim ds As New DataSet
        'dscmd.Fill(ds)

        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    For j = 0 To ds.Tables(0).Columns.Count - 1
        '        xlsWorkSheet.Cells(i + 3, j + 1) = _
        '        ds.Tables(0).Rows(i).Item(j)
        '    Next
        'Next

        'xlsWorkBook.Close()
        'xls.Quit()

        'MsgBox("file saved to " & resourcesFolder)
        'conn.Close()

    End Sub






    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        Using (conn)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = conn


            sqlComm.CommandText = "[AUD_Rekap]"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("DocEntry", txtDocEntry.Text)
            sqlComm.Parameters.AddWithValue("TanggalRekap", dtpInput.Value)
            sqlComm.Parameters.AddWithValue("KodeCabang", (dcCabang.SelectedValue))
            sqlComm.Parameters.AddWithValue("Persentase", txtPersen.Text)
            sqlComm.Parameters.AddWithValue("PekerjaanTidakCocok", txtTidakCocok.Text)
            sqlComm.Parameters.AddWithValue("TidakCocokAtasan", txtAtasan.Text)
            sqlComm.Parameters.AddWithValue("Sakit", txtSakit.Text)
            sqlComm.Parameters.AddWithValue("DapatPekerjaanLain", txtPekerjaanLain.Text)
            sqlComm.Parameters.AddWithValue("Kabur", txtKabur.Text)
            sqlComm.Parameters.AddWithValue("Status", "D")

            conn.Open()

            sqlComm.ExecuteNonQuery()

        End Using
        MsgBox("Data Berhasil Dihapus", vbInformation, "Informasi")
        bersihkan()

        LoadGridView()

    End Sub


    Sub bersihkan()
        dtpInput.Value = Now
        dcCabang.Text = ""
        txtAtasan.Text = ""
        txtKabur.Text = ""
        txtPekerjaanLain.Text = ""
        txtPersen.Text = ""
        txtSakit.Text = ""
        txtTidakCocok.Text = ""
    End Sub

End Class