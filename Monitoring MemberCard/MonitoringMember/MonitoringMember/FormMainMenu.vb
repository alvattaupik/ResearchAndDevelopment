Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.Drawing.Imaging


Public Class FormMainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub


    Sub LoadComboCabang()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            Koneksi_IVEND()
            cmd = New SqlCommand("SELECT LEFT(Id,3) As Id,Description FROM dbo.RtlStore WHERE CashCustomerKey<>0 ORDER BY Id", KoneksiIvend)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            KoneksiIvend.Close()
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
            Koneksi_IVEND()
            cmd = New SqlCommand("SELECT DISTINCT '0' AS Kode, City FROM dbo.LoyLoyaltyCardInformation WHERE City<>''", KoneksiIvend)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            KoneksiIvend.Close()
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

        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT * FROM V_MonitoringMember WHERE SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang.SelectedValue) & "%' And Status='" & Trim(cmbStatus.Text) & "'  ", KoneksiIvend)
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

        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT * FROM V_MonitoringMember WHERE  SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang.SelectedValue) & "%'", KoneksiIvend)
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
        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT Top 10 * FROM V_MonitoringMember WHERE NamaCustomer Like'%" & Trim(txtNamaCustomer.Text) & "%'", KoneksiIvend)
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
            Call Koneksi_IVEND()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "' OR NoMember ='" & Trim(txtNoMember.Text) & "'", KoneksiIvend)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgInformasiMember.DataSource = table

            dgInformasiMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgInformasiMember.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgInformasiMember.AutoResizeColumns()

        Else

            Call Koneksi_IVEND()
            Dim cmd As New SqlCommand("SELECT Top (" & txtDisplayTop.Text & ")  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "'", KoneksiIvend)
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
        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE KodeCustomer ='" & Trim(txtKodeCustomer.Text) & "'", KoneksiIvend)
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
        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE left(NoMember,9) ='" & Trim(txtKodeMember.Text) & "'", KoneksiIvend)
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
        Call Koneksi_IVEND()
        Dim cmd As New SqlCommand("SELECT * FROM V_PembelianCustomer WHERE NoStruk ='" & Trim(txtNoStruk.Text) & "'", KoneksiIvend)
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
        Koneksi_IVEND()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT top 1 * From V_PembelianCustomer WHERE KodeCustomer='" & Trim(txtKodeCustomer.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, KoneksiIvend)
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
            Koneksi_IVEND()
            cmd = New SqlCommand("SELECT LEFT(Id,3) As Id,Description FROM dbo.RtlStore WHERE CashCustomerKey<>0 ORDER BY Id", koneksiIvend)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            KoneksiIvend.Close()
            cmbCabang2.DataSource = ds.Tables(0)
            cmbCabang2.ValueMember = "Id"
            cmbCabang2.DisplayMember = "Description"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        If cmbCabang2.Text = "" Then

            Call Koneksi_IVEND()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE Cast(TglRegistrasi As Date) between '" & dtp1.Value.ToString("yyyy-MM-dd") & "' AND  '" & dtp2.Value.ToString("yyyy-MM-dd") & "' AND Status='Aktif'", KoneksiIvend)
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


            Call Koneksi_IVEND()
            Dim cmd As New SqlCommand("SELECT  * FROM V_MonitoringMember WHERE Cast(TglRegistrasi As Date) between '" & dtp1.Value.ToString("yyyy-MM-dd") & "' AND  '" & dtp2.Value.ToString("yyyy-MM-dd") & "' AND SUBSTRING(NoMember,7,3) Like'%" & Trim(cmbCabang2.SelectedValue) & "%' AND Status='Aktif' ", koneksiIvend)
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
                Call Koneksi_IVEND()
                Dim cmd As New SqlCommand("SELECT Top (" & txtDisplayTop.Text & ")  * FROM V_MonitoringMember WHERE left(NoMember,9) ='" & Trim(txtNoMember.Text) & "'", koneksiIvend)
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


    Sub LoadListGenerateVoucher()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT * FROM dbo.GenerateVoucher", KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgListNoGenerateVoucher.DataSource = table
        lblJumlahGenerateNo.Text = "Jumlah Generate : " & dgListNoGenerateVoucher.RowCount

        dgListNoGenerateVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgListNoGenerateVoucher.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgListNoGenerateVoucher.AutoResizeColumns()
    End Sub


    Sub LoadDetailNoVoucher()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT  NoVoucher,DocEntryVoucher As Kode FROM    dbo.MasterNoVoucher WHERE GenerateNumber='" & dgListNoGenerateVoucher.Item(0, dgListNoGenerateVoucher.CurrentRow.Index).Value() & "' Order By Cast(DocEntryVoucher As Bigint) asc", KoneksiDBEmail)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarNoVoucher.DataSource = table
        lblJumlahNoVoucher.Text = "Jumlah Voucher : " & dgDaftarNoVoucher.RowCount

        dgDaftarNoVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarNoVoucher.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarNoVoucher.AutoResizeColumns()
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


    Private Sub CopyTableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem1.Click
        CopyDataGridViewToClipboard(dgInformasiMember)
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If txtFrom.TextLength > 15 Or txtTo.TextLength > 15 Then
            MsgBox("No Member TelahLebih dari 15 Digit yang diperbolehkan!, Silahkan periksa kembali", vbCritical, "Penting!")
            Exit Sub
        End If


        If txtFrom.Text = "" Or txtTo.Text = "" Then
            MsgBox("No Member From dan To Tidak Boleh Kosong!", vbCritical, "Penting!")
            Exit Sub
        End If



        If txtDibuatOleh.Text = "" Then
            MsgBox("Dibuat Oleh, Harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If


        If txtCatatan.Text = "" Then
            MsgBox("Catatan Harus Di Isi!", vbCritical, "Penting COY!")
            Exit Sub
        End If

        If MsgBox("Apakah yakin Anda Akan Membuat No Member dari " & txtFrom.Text & " Sampai No " & txtTo.Text, vbYesNo, "Konfirmasi") = vbYes Then
            'Call GenerateNoMember()
            AddGenerateNoMember()
            ListNomorYangSUdahDibuat()

        Else
            Exit Sub
        End If
    End Sub



    Sub GenerateNoMember()
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("Fn_GenerateNoMember", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@startnum", Trim(txtFrom.Text))
            command.Parameters.AddWithValue("@endnum", Trim(txtTo.Text))
            command.Parameters.AddWithValue("@status", "R")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgNoMember.DataSource = table
            dgNoMember.DataSource = table

            lblJumlahNo.Text = "Jumlah No: " & dgNoMember.RowCount
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Sub TampilkanNoMember()
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("Fn_GenerateNoMember", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@startnum", Trim(dgListNomor.Item(0, dgListNomor.CurrentRow.Index).Value()))
            command.Parameters.AddWithValue("@endnum", Trim(dgListNomor.Item(1, dgListNomor.CurrentRow.Index).Value()))
            command.Parameters.AddWithValue("@status", "R")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgNoMember.DataSource = table
            dgNoMember.DataSource = table

            lblJumlahNo.Text = "Jumlah No: " & dgNoMember.RowCount
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Sub RefreshStokNoMember()
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AIO_MemberCard]", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Function", "2")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgStokMember.DataSource = table
            dgStokMember.DataSource = table

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub



    Sub ListNomorYangSUdahDibuat()
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AIO_MemberCard]", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Function", "1")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgListNomor.DataSource = table
            dgListNomor.DataSource = table

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub





    Sub AddGenerateNoMember()

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("dbo.Add_GenerateNoMember ", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@catatan", Trim(txtCatatan.Text))
            command.Parameters.AddWithValue("@dibuatoleh", Trim(txtDibuatOleh.Text))
            command.Parameters.AddWithValue("@start", Trim(txtFrom.Text))
            command.Parameters.AddWithValue("@finish", Trim(txtTo.Text))
            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgNoMember.DataSource = table
            dgNoMember.DataSource = table

            lblJumlahNo.Text = "Jumlah No: " & dgNoMember.RowCount

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Private Sub CopyTableToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CopyTableToolStripMenuItem2.Click
        CopyDataGridViewToClipboard(dgNoMember)
    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ListNomorYangSUdahDibuat()
        RefreshStokNoMember()
        LoadListGenerateVoucher()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        RefreshStokNoMember()
    End Sub

    Private Sub cmdTampilkan_Click(sender As Object, e As EventArgs) Handles cmdTampilkan.Click
        If dgListNomor.Rows.Count = 0 Then Exit Sub
        TampilkanNoMember()
    End Sub

    Private Sub cmdExportMemberToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportMemberToExcel.Click
        If dgNoMember.RowCount > 0 Then
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
            For i As Integer = 1 To dgNoMember.Columns.Count
                ApExcel.Cells(1, i).Value = dgNoMember.Columns(i - 1).Name
            Next

            lblExport.Visible = True

            'Tulis data ke excel
            For r = 0 To dgNoMember.RowCount - 1
                For i As Integer = 1 To dgNoMember.Columns.Count
                    ApExcel.Cells(r + 2, i).Value = dgNoMember.Rows(r).Cells(i - 1).Value

                    lblExport.Text = "Mengexport : " & r & " Dari : " & dgNoMember.RowCount

                Next
            Next

            'Membuat Font Bold
            ApExcel.Range("A1:M1").Font.Bold = True

            'Memberi warna backgound
            ApExcel.Range("A1:M1").interior.colorindex = 36

            'Agar nilai cell yang panjang menjadi beberapa baris
            ApExcel.Range("A2:B" & dgNoMember.RowCount + 1).WrapText = True

            'Membuat border hitam
            'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
            ApExcel.Visible = True
            ApExcel = Nothing
            lblExport.Visible = False
        End If
    End Sub







    Sub PreviewGenerateNoVoucher()

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_PreviewGenerateNoVoucher]", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            command.Parameters.AddWithValue("Jumlah", Trim(dgDaftarNoVoucher.RowCount))
            command.Parameters.AddWithValue("From", Trim(txtFromVoucher.Text))
            command.Parameters.AddWithValue("To", Trim(txtToVoucher.Text))
            command.Parameters.AddWithValue("GeneratedBy", Trim(txtDibuatOlehNovoucher.Text))
            command.Parameters.Add("GenerateNumber", SqlDbType.VarChar, 50)
            command.Parameters("GenerateNumber").Direction = ParameterDirection.Output
            command.Parameters.Add("isDuplicate", SqlDbType.VarChar, 50)
            command.Parameters("isDuplicate").Direction = ParameterDirection.Output


            If (koneksiIvend.State = ConnectionState.Open) Then koneksiIvend.Close()
            command.Connection = koneksiIvend
            koneksiIvend.Open()
            command.ExecuteNonQuery()
            txtGenerateNumber.Text = command.Parameters("GenerateNumber").Value.ToString()
            txtisDuplicate.Text = command.Parameters("isDuplicate").Value.ToString()

            lblPreview.Text = "Preview Nomor Voucher"

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgDaftarNoVoucher.DataSource = table
            dgDaftarNoVoucher.DataSource = table

            lblJumlahNoVoucher.Text = "Jumlah Voucher :" & dgDaftarNoVoucher.RowCount

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


  




    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click

        btnProses.Enabled = False


        If txtDibuatOlehNovoucher.Text = "" Then
            MsgBox("Dibuat Oleh Harus Di Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        'If txtJumlah.Text = "" Then
        '    MsgBox("Jumlah Harus Di Isi", vbCritical, "Penting !")
        '    Exit Sub
        'End If

        If txtFromVoucher.Text = "" Then
            MsgBox("From No Harus di Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        If txtToVoucher.Text = "" Then
            MsgBox("To No Harus di Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        PreviewGenerateNoVoucher()

        'If dgDaftarNoVoucher.RowCount > 1000 Then
        '    MsgBox("Maaf maximal Generate Voucher adalah 100", vbCritical, "Warning !@")
        '    dgDaftarNoVoucher.DataSource = Nothing
        '    dgDaftarNoVoucher.Rows.Clear()
        '    Exit Sub

        'End If


    End Sub

    Private Sub btnSimpanGenerateVoucher_Click(sender As Object, e As EventArgs) Handles btnSimpanGenerateVoucher.Click
        If txtGenerateNumber.Text = "" Or dgDaftarNoVoucher.RowCount = 0 Then
            MsgBox("Tidak Ada No Voucher Yang Akan Disimpan Silahkan Klik Preview", vbInformation, "Informasi")
            Exit Sub
        End If

        btnProses.Enabled = False



        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar? Kode Voucher yang telah disimpan tidak dapat dibatalkan", vbYesNo, "Konfirmasi") = vbYes Then
            'AddGenerateNoVoucher()
            AddListDetailNoVoucher()


            LoadListGenerateVoucher()

        Else
            Exit Sub
        End If


    End Sub




    Sub AddListDetailNoVoucher()


        KoneksiDB_EMAIL()
        Dim command As SqlCommand
        command = New SqlCommand("tmsp_AddGenerateNoVoucher", koneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
        command.Parameters.AddWithValue("Jumlah", Trim(dgDaftarNoVoucher.RowCount))
        command.Parameters.AddWithValue("From", Trim(txtFromVoucher.Text))
        command.Parameters.AddWithValue("To", Trim(txtToVoucher.Text))
        command.Parameters.AddWithValue("GeneratedBy", Trim(txtDibuatOlehNovoucher.Text))
        command.Parameters.AddWithValue("GenerateNumber", Trim(txtGenerateNumber.Text))
        command.Parameters.AddWithValue("DocEntry", (""))
        command.Parameters.AddWithValue("NoVoucher", (""))
        command.Parameters.AddWithValue("Status", Trim("L"))

        If (koneksiIvend.State = ConnectionState.Open) Then koneksiIvend.Close()
        command.Connection = koneksiIvend
        koneksiIvend.Open()
        command.ExecuteNonQuery()
        koneksiIvend.Close()
        dgDaftarNoVoucher.DataSource = Nothing
        dgDaftarNoVoucher.Rows.Clear()

        txtGenerateNumber.Text = ""
        txtKeterangan.Text = ""
        txtDibuatOlehNovoucher.Text = ""
        txtFromVoucher.Text = ""
        txtToVoucher.Text = ""
        lblJumlahNoVoucher.Text = "Jumlah Voucher :" & 0


    End Sub








    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        On Error GoTo ErrorLoad

        Call KoneksiDB_EMAIL()
        For i As Integer = 0 To dgDaftarNoVoucher.Rows.Count - 1
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("tmsp_AddGenerateNoVoucher", KoneksiDBEmail)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            command.Parameters.AddWithValue("Jumlah", Trim(dgDaftarNoVoucher.RowCount))
            command.Parameters.AddWithValue("From", Trim(txtFromVoucher.Text))
            command.Parameters.AddWithValue("To", Trim(txtToVoucher.Text))
            command.Parameters.AddWithValue("GeneratedBy", Trim(txtDibuatOlehNovoucher.Text))
            command.Parameters.AddWithValue("GenerateNumber", Trim(txtGenerateNumber.Text))
            command.Parameters.AddWithValue("DocEntry", Trim(dgDaftarNoVoucher.Rows(i).Cells(0).Value))
            command.Parameters.AddWithValue("NoVoucher", Trim(dgDaftarNoVoucher.Rows(i).Cells(1).Value))
            command.Parameters.AddWithValue("Status", Trim("L"))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.CommandTimeout = 0
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


        Next
        KoneksiDBEmail.Close()


        dgDaftarNoVoucher.DataSource = Nothing
        dgDaftarNoVoucher.Rows.Clear()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub
    End Sub

    Private Sub btnRefreshListGenerate_Click(sender As Object, e As EventArgs) Handles btnRefreshListGenerate.Click
        LoadListGenerateVoucher()

        dgDaftarNoVoucher.DataSource = Nothing
        dgDaftarNoVoucher.Rows.Clear()
        lblJumlahNoVoucher.Text = "Jumlah Voucher :" & 0
        btnProses.Enabled = False
    End Sub

    Private Sub btnNewVoucher_Click(sender As Object, e As EventArgs) Handles btnNewVoucher.Click
        If MsgBox("Apakah Anda Yakin akan Membatalkan dan membuat ulang nomor?", vbYesNo, "Konfirmasi") = vbYes Then

            txtGenerateNumber.Text = ""
            txtKeterangan.Text = ""
            txtDibuatOlehNovoucher.Text = ""
            txtFromVoucher.Text = ""
            txtToVoucher.Text = ""
            dgDaftarNoVoucher.DataSource = Nothing
            dgDaftarNoVoucher.Rows.Clear()
            lblJumlahNoVoucher.Text = "Jumlah Voucher :" & 0
        Else
            Exit Sub

        End If

    End Sub

    Private Sub btnBrowseExportBarcode_Click_1(sender As Object, e As EventArgs) Handles btnBrowseExportBarcode.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtpathExportbarcode.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If txtpathExportbarcode.Text = "" Then
            MsgBox("Silahkan Pilih Lokasi Export Barcode", vbInformation, "Penting !")
            Exit Sub
        End If

        GenerateQRCode2()


    End Sub




    Sub GenerateQRCode2()
        For i As Integer = 0 To dgDaftarNoVoucher.Rows.Count - 1

            Dim gen As New QRCoder.QRCodeGenerator
            Dim data = gen.CreateQrCode(dgDaftarNoVoucher.Rows(i).Cells(0).Value, QRCoder.QRCodeGenerator.ECCLevel.H)

            'Dim data = gen.CreateQrCode(strKode, QRCoder.QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCoder.QRCode(data)
            Dim bitMap As Bitmap = code.GetGraphic(5)

            Using ms As MemoryStream = New MemoryStream()
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                picBarcode.Image = bitMap
                picBarcode.Height = bitMap.Height
                picBarcode.Width = bitMap.Width
            End Using

            Dim x1 As Integer = 0
            Dim x2 As Integer = Math.Max(picBarcode.Image.Width, picBarcode.Image.Width)
            Dim y1 As Integer = 0
            Dim y2 As Integer = Math.Max(picBarcode.Image.Height, PictureBox1.Image.Height)
            Dim rect1 As Rectangle = New Rectangle(New Point(x1, y1), picBarcode.Image.Size)
            Dim firstLocation As PointF = New PointF(17.0F, 145.0F)
            'Dim firstLocation As PointF = New PointF(0.0F, 145.0F)
            Dim secondLocation As PointF = New PointF(30.0F, 50.0F)



            Using graphics As Graphics = graphics.FromImage(bitMap)

                'Using arialFont As Font = New Font("Arial", 9)
                '    graphics.DrawString(dgDaftarNoVoucher.Rows(i).Cells(0).Value, arialFont, Brushes.Black, firstLocation)
                '    graphics.DrawImage(picBarcode.Image, rect1)
                'End Using

                'Dim g As Graphics = graphics.FromImage(bitMap)
                'g.DrawString(dgDaftarNoVoucher.Rows(i).Cells(0).Value, New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 18, 130)

                bitMap.Save(txtpathExportbarcode.Text & "\" & dgDaftarNoVoucher.Rows(i).Cells(1).Value & ".png", ImageFormat.Png)
            End Using

        Next

        Exit Sub
    End Sub




    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If dgListNoGenerateVoucher.RowCount = 0 Then Exit Sub


        txtGenerateNumber.Text = ""
        txtKeterangan.Text = ""
        txtDibuatOlehNovoucher.Text = ""
        txtFromVoucher.Text = ""
        txtToVoucher.Text = ""
        dgDaftarNoVoucher.DataSource = Nothing
        dgDaftarNoVoucher.Rows.Clear()
        lblJumlahNoVoucher.Text = "Jumlah Voucher :" & 0


        LoadDetailNoVoucher()
        btnProses.Enabled = True





    End Sub

    Private Sub dgListNoGenerateVoucher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListNoGenerateVoucher.CellContentClick

    End Sub

    Private Sub dgListNoGenerateVoucher_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListNoGenerateVoucher.CellContentDoubleClick

    End Sub

    Private Sub LihatNomorYangBelumTerpakaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatNomorYangBelumTerpakaiToolStripMenuItem.Click
        If dgStokMember.RowCount = 0 Then Exit Sub
        MstrKodeCabang = dgStokMember.Item(0, dgStokMember.CurrentRow.Index).Value()
        ListMemberYangBelumTerpakai.ShowDialog()
    End Sub

    Private Sub dgStokMember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStokMember.CellContentClick

    End Sub

    Private Sub dgStokMember_Click(sender As Object, e As EventArgs) Handles dgStokMember.Click
        If dgStokMember.RowCount = 0 Then Exit Sub
        MstrKodeCabang = dgStokMember.Item(0, dgStokMember.CurrentRow.Index).Value()
        ListMemberYangBelumTerpakai.ShowDialog()
    End Sub
End Class