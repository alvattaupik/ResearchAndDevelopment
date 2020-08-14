Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormMainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub


    Sub LoadComboCabang()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabaseIvend()
            cmd = New SqlCommand("SELECT LEFT(Id,3) As Id,Description FROM dbo.RtlStore WHERE CashCustomerKey<>0 ORDER BY Id", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbCabang.DataSource = ds.Tables(0)
            cmbCabang.ValueMember = "Id"
            cmbCabang.DisplayMember = "Description"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Sub LoadComboKota()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabaseIvend()
            cmd = New SqlCommand("SELECT DISTINCT '0' AS Kode, City FROM dbo.LoyLoyaltyCardInformation WHERE City<>''", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbKota.DataSource = ds.Tables(0)
            cmbKota.ValueMember = "Kode"
            cmbKota.DisplayMember = "City"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        LoadComboCabang()
    End Sub

    Private Sub cmbKota_Click(sender As Object, e As EventArgs)
        LoadComboKota()
    End Sub



    Sub LoadDaftarMember()

        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("SELECT * FROM V_MonitoringMember WHERE SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang.SelectedValue) & "%' And Status='" & Trim(cmbStatus.Text) & "'  ", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarMember.DataSource = table
        lblJumlahMember.Text = "Jumlah Member : " & dgDaftarMember.RowCount
        dgDaftarMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarMember.AutoResizeColumns()

    End Sub



    Sub LoadDaftarMemberAll()

        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("SELECT * FROM V_MonitoringMember WHERE  SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang.SelectedValue) & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarMember.DataSource = table
        lblJumlahMember.Text = "Jumlah Member : " & dgDaftarMember.RowCount
        dgDaftarMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarMember.AutoResizeColumns()

    End Sub



    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        If cmbCabang.Text = "" Then
            MsgBox("Pilih Cabang", vbCritical, "Cabang Harus Di Isi!")
            Exit Sub
        End If

        If cmbStatus.Text = "" Then
            LoadDaftarMemberAll()
        Else
            LoadDaftarMember()
        End If



    End Sub



    Private Sub cmbKota_Click1(sender As Object, e As EventArgs) Handles cmbKota.Click
        LoadComboKota()
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



    Private Sub CopyTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgDaftarMember)
    End Sub

    Private Sub txtNamaCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaCustomer.KeyPress
       

        If (e.KeyChar = Chr(13)) Then

            If txtNamaCustomer.Text = "" Then
                MsgBox("Masukan Beberapa Karakter", vbCritical, "Tidak Boleh Kosong")
                Exit Sub
            Else
                LoadInformasiCustomer()
            End If



        End If
    End Sub



    Sub LoadInformasiCustomer()
        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("SELECT Top 10 * FROM V_MonitoringMember WHERE NamaCustomer Like'%" & Trim(txtNamaCustomer.Text) & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgInformasiMember.DataSource = table

        dgInformasiMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgInformasiMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgInformasiMember.AutoResizeColumns()
    End Sub


    Sub LoadInformasiCustomerByNoMember()

        If txtDisplayTop.Text = "" Then
            Call KoneksiDatabaseIvend()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "'", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgInformasiMember.DataSource = table

            dgInformasiMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgInformasiMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgInformasiMember.AutoResizeColumns()

        Else

            Call KoneksiDatabaseIvend()
            Dim cmd As New SqlCommand("SELECT Top (" & txtDisplayTop.Text & ")  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "'", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgInformasiMember.DataSource = table

            dgInformasiMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgInformasiMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgInformasiMember.AutoResizeColumns()


        End If

       
    End Sub



    Sub LoadRiwayatTransaksiCustomer()
        Call KoneksiDatabaseSAP()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE KodeCustomer ='" & Trim(txtKodeCustomer.Text) & "'", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgHistoryTransaksiCustomer.DataSource = table

        dgHistoryTransaksiCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHistoryTransaksiCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHistoryTransaksiCustomer.AutoResizeColumns()
    End Sub


    Sub LoadRiwayatTransaksiCustomerByNoMember()
        Call KoneksiDatabaseSAP()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE left(NoMember,9) ='" & Trim(txtKodeMember.Text) & "'", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgHistoryTransaksiCustomer.DataSource = table

        dgHistoryTransaksiCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHistoryTransaksiCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHistoryTransaksiCustomer.AutoResizeColumns()
    End Sub




    Sub LoadRiwayatTransaksiCustomerByNoStruk()
        Call KoneksiDatabaseSAP()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE NoStruk ='" & Trim(txtNoStruk.Text) & "'", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgHistoryTransaksiCustomer.DataSource = table

        dgHistoryTransaksiCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgHistoryTransaksiCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgHistoryTransaksiCustomer.AutoResizeColumns()
    End Sub




    Sub LoadDataCustomer()
        On Error GoTo ErrorLoad
        KoneksiDatabaseSAP()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT top 1 * From V_PembelianCustomer WHERE KodeCustomer='" & Trim(txtKodeCustomer.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi2)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtNamaCustomerHistory.Text = dr.GetString(5)
            txtCabang.Text = dr.GetString(2)
            dr.Close()

        Else

            MsgBox("Tidak Ada Riwayat Pembelanjaan", vbInformation, "Informasi")
            dr.Close()
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Private Sub cmdCari_Click(sender As Object, e As EventArgs) Handles cmdCari.Click


        LoadDataCustomer()

        LoadRiwayatTransaksiCustomer()


        Dim LongMargin As Long = 0
        Dim LongTotalJual As Long = 0
        Dim LongTotalBeli As Long = 0
        Dim LongTotalMargin As Long = 0


        For i = 0 To dgHistoryTransaksiCustomer.RowCount - 1



            dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value = dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value 'Total Jual
            LongTotalJual = LongTotalJual + dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value




        Next



        lblTotalTransaksi.Text = "Total Transaksi: " & Format(LongTotalJual, "N0")



    End Sub

    Private Sub txtNoMember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoMember.KeyPress
        If (e.KeyChar = Chr(13)) Then
            LoadInformasiCustomerByNoMember()
            lblJumlahMemberPencarian.Text = "Jumlah Member : " & dgInformasiMember.RowCount
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click

        LoadRiwayatTransaksiCustomerByNoMember()


        Dim LongMargin As Long = 0
        Dim LongTotalJual As Long = 0
        Dim LongTotalBeli As Long = 0
        Dim LongTotalMargin As Long = 0


        For i = 0 To dgHistoryTransaksiCustomer.RowCount - 1



            dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value = dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value 'Total Jual
            LongTotalJual = LongTotalJual + dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value




        Next



        lblTotalTransaksi.Text = "Total Transaksi: " & Format(LongTotalJual, "N0")



    End Sub

    Private Sub LihatRiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatRiwayatTransaksiToolStripMenuItem.Click
        If dgDaftarMember.RowCount = 0 Then Exit Sub

        MstrNoMember = dgDaftarMember.Item(3, dgDaftarMember.CurrentRow.Index).Value
        FormRiwayatTransaksi.ShowDialog()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        LoadRiwayatTransaksiCustomerByNoStruk()

        Dim LongMargin As Long = 0
        Dim LongTotalJual As Long = 0
        Dim LongTotalBeli As Long = 0
        Dim LongTotalMargin As Long = 0


        For i = 0 To dgHistoryTransaksiCustomer.RowCount - 1

            dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value = dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value 'Total Jual
            LongTotalJual = LongTotalJual + dgHistoryTransaksiCustomer.Rows(i).Cells(9).Value


        Next



        lblTotalTransaksi.Text = "Total Transaksi: " & Format(LongTotalJual, "N0")


    End Sub

    Private Sub cmbCabang2_Click(sender As Object, e As EventArgs) Handles cmbCabang2.Click
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabaseIvend()
            cmd = New SqlCommand("SELECT LEFT(Id,3) As Id,Description FROM dbo.RtlStore WHERE CashCustomerKey<>0 ORDER BY Id", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbCabang2.DataSource = ds.Tables(0)
            cmbCabang2.ValueMember = "Id"
            cmbCabang2.DisplayMember = "Description"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        If cmbCabang2.Text = "" Then

            Call KoneksiDatabaseIvend()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE Cast(TglRegistrasi As Date) between '" & dtp1.Value.ToString("yyyy-MM-dd") & "' AND  '" & dtp2.Value.ToString("yyyy-MM-dd") & "' AND Status='Aktif'", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgDaftarMember.DataSource = table
            lblJumlahMember.Text = "Jumlah Member : " & dgDaftarMember.RowCount
            dgDaftarMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgDaftarMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgDaftarMember.AutoResizeColumns()


        Else


            Call KoneksiDatabaseIvend()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE Cast(TglRegistrasi As Date) between '" & dtp1.Value.ToString("yyyy-MM-dd") & "' AND  '" & dtp2.Value.ToString("yyyy-MM-dd") & "' AND SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang2.SelectedValue) & "%' AND Status='Aktif' ", Koneksi1)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgDaftarMember.DataSource = table
            lblJumlahMember.Text = "Jumlah Member : " & dgDaftarMember.RowCount
            dgDaftarMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgDaftarMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgDaftarMember.AutoResizeColumns()



        End If
    End Sub

 

    Private Sub txtDisplayTop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDisplayTop.KeyPress


        If (e.KeyChar = Chr(13)) Then

            If txtDisplayTop.Text = "" Then
                MsgBox("Jumlah Yang Ingin Ditampilkan", vbCritical, "Tidak Boleh Kosong")
                Exit Sub
            Else
                Call KoneksiDatabaseIvend()
                Dim cmd As New SqlCommand("SELECT Top (" & txtDisplayTop.Text & ")  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "'", Koneksi1)
                cmd.CommandTimeout = 0
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                dgInformasiMember.DataSource = table
                lblJumlahMemberPencarian.Text = "Jumlah Member : " & dgInformasiMember.RowCount

                dgInformasiMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgInformasiMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgInformasiMember.AutoResizeColumns()
            End If



        End If








       
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        If dgDaftarMember.RowCount > 0 Then
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
            For i As Integer = 1 To dgDaftarMember.Columns.Count
                ApExcel.Cells(1, i).Value = dgDaftarMember.Columns(i - 1).Name
            Next

            lblExport.Visible = True

            'Tulis data ke excel
            For r = 0 To dgDaftarMember.RowCount - 1
                For i As Integer = 1 To dgDaftarMember.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dgDaftarMember.Rows(r).Cells(i - 1).Value

                    lblExport.Text = "Mengexport : " & r & " Dari : " & dgDaftarMember.RowCount

                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:M1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:M1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:B" & dgDaftarMember.RowCount + 1).WrapText = True

            'Membuat border hitam
            'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
            ApExcel.Visible = True
            ApExcel = Nothing
            lblExport.Visible = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If dgHistoryTransaksiCustomer.RowCount > 0 Then
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
            For i As Integer = 1 To dgHistoryTransaksiCustomer.Columns.Count
                ApExcel.Cells(1, i).Value = dgHistoryTransaksiCustomer.Columns(i - 1).Name
            Next

            lblExport.Visible = True

            'Tulis data ke excel
            For r = 0 To dgHistoryTransaksiCustomer.RowCount - 1
                For i As Integer = 1 To dgHistoryTransaksiCustomer.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dgHistoryTransaksiCustomer.Rows(r).Cells(i - 1).Value

                    lblExport.Text = "Mengexport : " & r & " Dari : " & dgHistoryTransaksiCustomer.RowCount

                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:M1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:M1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:B" & dgHistoryTransaksiCustomer.RowCount + 1).WrapText = True

            'Membuat border hitam
            'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
            ApExcel.Visible = True
            ApExcel = Nothing
            lblExport.Visible = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgInformasiMember.RowCount > 0 Then
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
            For i As Integer = 1 To dgInformasiMember.Columns.Count
                ApExcel.Cells(1, i).Value = dgInformasiMember.Columns(i - 1).Name
            Next

            lblExport.Visible = True

            'Tulis data ke excel
            For r = 0 To dgInformasiMember.RowCount - 1
                For i As Integer = 1 To dgInformasiMember.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dgInformasiMember.Rows(r).Cells(i - 1).Value

                    lblExport.Text = "Mengexport : " & r & " Dari : " & dgInformasiMember.RowCount

                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:M1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:M1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:B" & dgInformasiMember.RowCount + 1).WrapText = True

            'Membuat border hitam
            'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
            ApExcel.Visible = True
            ApExcel = Nothing
            lblExport.Visible = False

        End If
    End Sub
End Class