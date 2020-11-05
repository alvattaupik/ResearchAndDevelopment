Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.Drawing.Imaging

Public Class frmVoucherCodeGenerator

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        picExportToExcel.Visible = False
        dgvRincianNomor.DataSource = Nothing
        dgvRincianNomor.Rows.Clear()
        If txtFromVoucher.Text = "" Then
            DisplayPesanError("From No Harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        If txtToVoucher.Text = "" Then
            DisplayPesanError("To No Harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        If cmbCabang.Text = "" Then
            DisplayPesanError("Cabang Harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If
        PreviewGenerateNoVoucher()

    End Sub


    Sub PreviewGenerateNoVoucher()

        Try
            gbRincianNomor.Visible = True
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_PreviewOVoucher]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            command.Parameters.AddWithValue("Jumlah", Trim(dgvListGenerate.RowCount))
            command.Parameters.AddWithValue("From", Trim(txtFromVoucher.Text))
            command.Parameters.AddWithValue("To", Trim(txtToVoucher.Text))
            command.Parameters.AddWithValue("GeneratedBy", Trim(MstrNamaPegawai))
            command.Parameters.Add("GenerateNumber", SqlDbType.VarChar, 50)
            command.Parameters("GenerateNumber").Direction = ParameterDirection.Output
            command.Parameters.Add("isDuplicate", SqlDbType.VarChar, 50)
            command.Parameters("isDuplicate").Direction = ParameterDirection.Output


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()
            txtGenerateNumber.Text = command.Parameters("GenerateNumber").Value.ToString()



            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvRincianNomor.DataSource = table
            dgvRincianNomor.DataSource = table

            lblJumlahVoucher.Text = "Jumlah Voucher :" & dgvRincianNomor.RowCount
            Label5.Text = "Preview Voucher"
            If command.Parameters("isDuplicate").Value.ToString() <> "0" Then
                MsgBox("Terdapat Voucher Yang Duplikat", vbCritical, "Perhatian!!")
                Exit Sub
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode Like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gbRincianNomor.Visible = False
    End Sub

    Private Sub btnSimpanGenerateVoucher_Click(sender As Object, e As EventArgs) Handles btnSimpanGenerateVoucher.Click

        Call AddGenerateNoVoucher()
        txtGenerateNumber.Text = ""
        txtKeterangan.Text = ""
        txtFromVoucher.Text = ""
        txtToVoucher.Text = ""
        dgvRincianNomor.DataSource = Nothing
        dgvRincianNomor.Rows.Clear()
        lblJumlahVoucher.Text = "Jumlah Voucher :" & 0
    End Sub

    Sub AddGenerateNoVoucher()

        If txtGenerateNumber.Text = "" Then
            DisplayPesanError("Generate Nomor Kosong, Silahkan Preview Terlebih Dahulu", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        Try

            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AddVoucher]", KoneksiDBEmail)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            command.Parameters.AddWithValue("From", Trim(txtFromVoucher.Text))
            command.Parameters.AddWithValue("To", Trim(txtToVoucher.Text))
            command.Parameters.AddWithValue("KodeCabang", Trim(cmbCabang.SelectedValue))
            command.Parameters.AddWithValue("GeneratedBy", Trim(MstrNamaPegawai))
            command.Parameters.AddWithValue("GenerateNumber", Trim(txtGenerateNumber.Text))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            DisplayPesanOK("Sukses Disimpan", frmMainMenu.txtPesanError, 1000)
            LoadListGenerateVoucher()

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Sub LoadListGenerateVoucher()
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListGenerate, "SELECT GenerateNumber,Keterangan,Jumlah,[From],[To],GeneratedBy,GeneratedDate FROM dbo.Ovoucher", KoneksiDBEmail)
        lblJumlahDataNomor.Text = "Jumlah Dokumen : " & dgvListGenerate.RowCount

    End Sub


    Private Sub frmVoucherCodeGenerator_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadListGenerateVoucher()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try

            If dgvListGenerate.RowCount = 0 Then Exit Sub
            gbRincianNomor.Visible = True
            Label5.Text = "Rincian Voucher"


            txtGenerateNumber.Text = ""
            txtKeterangan.Text = ""
            txtFromVoucher.Text = ""
            txtToVoucher.Text = ""
            dgvRincianNomor.DataSource = Nothing
            dgvRincianNomor.Rows.Clear()
            lblJumlahVoucher.Text = "Jumlah Voucher :" & 0

            KoneksiDB_EMAIL()
            LoadDataGrid(dgvRincianNomor, "SELECT  NoVoucher,DocEntryVoucher As Kode FROM    dbo.Voucher1 WHERE GenerateNumber='" & dgvListGenerate.Item(0, dgvListGenerate.CurrentRow.Index).Value() & "' Order By Cast(DocEntryVoucher As Bigint) asc", KoneksiDBEmail)
            picExportToExcel.Visible = True
            lblJumlahVoucher.Text = "Jumlah Voucher :" & dgvRincianNomor.RowCount


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnNewVoucher_Click(sender As Object, e As EventArgs) Handles btnNewVoucher.Click
        If MsgBox("Apakah Anda Yakin akan Membatalkan dan membuat ulang nomor?", vbYesNo, "Konfirmasi") = vbYes Then

            txtGenerateNumber.Text = ""
            txtKeterangan.Text = ""
            txtFromVoucher.Text = ""
            txtToVoucher.Text = ""
            dgvRincianNomor.DataSource = Nothing
            dgvRincianNomor.Rows.Clear()
            lblJumlahVoucher.Text = "Jumlah Voucher :" & 0
        Else
            Exit Sub

        End If
    End Sub

    Private Sub picExportToExcel_Click(sender As Object, e As EventArgs) Handles picExportToExcel.Click
        If txtPathExport.Text = "" Then
            MsgBox("Silahkan Pilih Lokasi Export Barcode", vbInformation, "Penting !")
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                txtPathExport.Text = FolderBrowserDialog1.SelectedPath
            End If
            Exit Sub
        Else
            GenerateQRCode2()
        End If


    End Sub

    Sub GenerateQRCode2()
        For i As Integer = 0 To dgvRincianNomor.Rows.Count - 1

            Dim gen As New QRCoder.QRCodeGenerator
            Dim data = gen.CreateQrCode(dgvRincianNomor.Rows(i).Cells(0).Value, QRCoder.QRCodeGenerator.ECCLevel.H)

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
            Dim secondLocation As PointF = New PointF(30.0F, 50.0F)



            Using graphics As Graphics = graphics.FromImage(bitMap)
                bitMap.Save(txtPathExport.Text & "\" & dgvRincianNomor.Rows(i).Cells(1).Value & ".png", ImageFormat.Png)
            End Using

        Next

        DisplayPesanOK("Sukses Di Export Ke" & txtPathExport.Text, frmMainMenu.txtPesanError, 1000)

        Exit Sub
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtPathExport.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class