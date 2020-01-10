Imports System.Xml
Imports System.Net
Imports System.IO
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormMenuUtama
    'create a temp file
    Dim path = IO.Path.GetTempPath()
    Dim fileName = Guid.NewGuid().ToString() + ".xml"
    Dim fullyQualifiedPath = IO.Path.Combine(path, fileName)




    Private Sub txtUrl_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUrl.KeyDown

        If e.KeyCode = Keys.Enter Then

            'Dim filePath As String = TextBox1.Text
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create(txtUrl.Text, New XmlReaderSettings())
            Dim ds As New DataSet
            ds.ReadXml(xmlFile)
            dgvDB.DataSource = ds
            dgvDB.DataMember = "resValidateFakturPm"
            dgvScan.DataSource = ds
            dgvScan.DataMember = "detailTransaksi"


            Call HeaderFaktur()



            dgItemList.ColumnCount = 9
            dgItemList.Columns(0).HeaderText = "Nama Barang"
            dgItemList.Columns(1).HeaderText = "Qty"
            dgItemList.Columns(2).HeaderText = "Harga"
            dgItemList.Columns(3).HeaderText = "Total Harga"
            dgItemList.Columns(4).HeaderText = "Diskon"
            dgItemList.Columns(5).HeaderText = "DPP"
            dgItemList.Columns(6).HeaderText = "PPN"
            dgItemList.Columns(7).HeaderText = "Tarif PPNBM"
            dgItemList.Columns(8).HeaderText = "PPNBM"

            dgItemList.Columns(0).Width = 250
            dgItemList.Columns(1).Width = 50
            dgItemList.Columns(2).Width = 100
            dgItemList.Columns(3).Width = 100
            dgItemList.Columns(4).Width = 100
            dgItemList.Columns(5).Width = 100
            dgItemList.Columns(6).Width = 100
            dgItemList.Columns(7).Width = 100
            dgItemList.Columns(8).Width = 100

            For i = 0 To dgvScan.RowCount - 1
                dgItemList.RowCount = dgItemList.RowCount + 1
                dgItemList.Rows(i).Cells(0).Value = dgvScan.Rows(i).Cells(0).Value
                dgItemList.Rows(i).Cells(1).Value = dgvScan.Rows(i).Cells(2).Value
                dgItemList.Rows(i).Cells(2).Value = dgvScan.Rows(i).Cells(1).Value
                dgItemList.Rows(i).Cells(3).Value = dgvScan.Rows(i).Cells(3).Value
                dgItemList.Rows(i).Cells(4).Value = dgvScan.Rows(i).Cells(4).Value
                dgItemList.Rows(i).Cells(5).Value = dgvScan.Rows(i).Cells(5).Value.Replace(".", "")
                dgItemList.Rows(i).Cells(6).Value = dgvScan.Rows(i).Cells(6).Value.Replace(".", "")
                dgItemList.Rows(i).Cells(7).Value = dgvScan.Rows(i).Cells(7).Value
                dgItemList.Rows(i).Cells(8).Value = dgvScan.Rows(i).Cells(8).Value
            Next


            lblStatus.Text = "Jumlah Item :" & dgItemList.RowCount



            If dgItemList.RowCount > 0 Then
                Dim intTotalHarga As Integer = 0
                Dim intTotalDiskon As Integer = 0
                Dim intTotalUangMuka As Integer = 0
                Dim intDPP As Integer = 0
                Dim intPPN As Integer = 0
                Dim intTotalPPNBM As Integer = 0

                For index As Integer = 0 To dgItemList.RowCount - 1
                    intTotalHarga += Convert.ToInt32(dgItemList.Rows(index).Cells(5).Value)
                    intTotalDiskon += Convert.ToInt32(dgItemList.Rows(index).Cells(6).Value)
                    intTotalUangMuka = 0

                Next
                txtTotalHargaJual.Text = CDbl(intTotalHarga).ToString("##,0")
                txtTotalPotonganHarga.Text = CDbl(intTotalDiskon).ToString("##,0")
                txtUangMuka.Text = CDbl(intTotalUangMuka).ToString("##,0")

            End If

        End If


    End Sub




    Sub HeaderFaktur()
        Dim strjenisTransaksi As String
        Dim strFakturPengganti As String
        Dim strSTatusFaktur As String
        Dim strStatusApproval As String

        Dim strTempNoFaktur As String


        strjenisTransaksi = dgvDB.Item(0, dgvDB.CurrentRow.Index).Value.ToString
        strFakturPengganti = dgvDB.Item(1, dgvDB.CurrentRow.Index).Value.ToString
        'strTempNoFaktur = dgvDB.Item(2, dgvDB.CurrentRow.Index).Value.ToString


        txtNomorFakturPajak.Text = strjenisTransaksi & strFakturPengganti & dgvDB.Item(2, dgvDB.CurrentRow.Index).Value.ToString
        txtTglFakturPajak.Text = dgvDB.Item(3, dgvDB.CurrentRow.Index).Value.ToString
        txtNPWPPengusahaKenaPajak.Text = dgvDB.Item(4, dgvDB.CurrentRow.Index).Value.ToString
        txtNamaPengusahaKenaPajak.Text = dgvDB.Item(5, dgvDB.CurrentRow.Index).Value.ToString
        txtAlamatPengusahaKenaPajak.Text = dgvDB.Item(6, dgvDB.CurrentRow.Index).Value.ToString

        txtNpwpLawan.Text = dgvDB.Item(7, dgvDB.CurrentRow.Index).Value.ToString
        txtNamaLawan.Text = dgvDB.Item(8, dgvDB.CurrentRow.Index).Value.ToString
        txtAlamatLawan.Text = dgvDB.Item(9, dgvDB.CurrentRow.Index).Value.ToString
        txtDPP.Text = CDbl(dgvDB.Item(10, dgvDB.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtPPN.Text = CDbl(dgvDB.Item(11, dgvDB.CurrentRow.Index).Value.ToString).ToString("##,0")
        txtPPNBM.Text = CDbl(dgvDB.Item(12, dgvDB.CurrentRow.Index).Value.ToString).ToString("##,0")

        strStatusApproval = dgvDB.Item(13, dgvDB.CurrentRow.Index).Value.ToString
        strSTatusFaktur = dgvDB.Item(14, dgvDB.CurrentRow.Index).Value.ToString


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUrl.Select()
        Call KoneksiDatabase()
    End Sub

    Private Sub cmdNewScan_Click(sender As Object, e As EventArgs) Handles cmdNewScan.Click

        txtUrl.Text = ""
        txtAlamatLawan.Text = ""
        txtAlamatPengusahaKenaPajak.Text = ""
        txtDPP.Text = ""
        txtNamaLawan.Text = ""
        txtNamaPengusahaKenaPajak.Text = ""
        txtNomorFakturPajak.Text = ""
        txtNpwpLawan.Text = ""
        txtNPWPPengusahaKenaPajak.Text = ""
        txtPPN.Text = ""
        txtPPNBM.Text = ""
        txtTglFakturPajak.Text = ""
        txtTotalHargaJual.Text = ""
        txtTotalPotonganHarga.Text = ""
        txtUangMuka.Text = ""


        dgItemList.DataSource = Nothing
        dgItemList.Rows.Clear()
        dgvDB.DataSource = Nothing
        dgvDB.Rows.Clear()
        dgvScan.DataSource = Nothing
        dgvScan.Rows.Clear()


        txtUrl.Select()
    End Sub


    Sub NewScan()
        txtUrl.Text = ""
        txtAlamatLawan.Text = ""
        txtAlamatPengusahaKenaPajak.Text = ""
        txtDPP.Text = ""
        txtNamaLawan.Text = ""
        txtNamaPengusahaKenaPajak.Text = ""
        txtNomorFakturPajak.Text = ""
        txtNpwpLawan.Text = ""
        txtNPWPPengusahaKenaPajak.Text = ""
        txtPPN.Text = ""
        txtPPNBM.Text = ""
        txtTglFakturPajak.Text = ""
        txtTotalHargaJual.Text = ""
        txtTotalPotonganHarga.Text = ""
        txtUangMuka.Text = ""


        dgItemList.DataSource = Nothing
        dgItemList.Rows.Clear()
        dgvDB.DataSource = Nothing
        dgvDB.Rows.Clear()
        dgvScan.DataSource = Nothing
        dgvScan.Rows.Clear()

        txtUrl.Select()
    End Sub


    Private Sub cmdSimpanData_Click(sender As Object, e As EventArgs) Handles cmdSimpanData.Click

        On Error GoTo ErrorLoad


        If dgItemList.RowCount = 0 Then
            MsgBox("Tidak Ada Data Untuk Disimpan", vbCritical, "Perhatian!")
            Exit Sub
        End If


        Call KoneksiDatabase()

        Dim cmd As New SqlCommand
        Dim oDate As DateTime = Convert.ToDateTime(Trim(txtTglFakturPajak.Text))


        cmd.CommandText = "[ADD_FakturPajak]"
        cmd.CommandType = CommandType.StoredProcedure



        cmd.Parameters.AddWithValue("NoFakturPajak", Trim(txtNomorFakturPajak.Text))
        cmd.Parameters.AddWithValue("Tanggal", oDate)
        cmd.Parameters.AddWithValue("NamaPengusahaKenaPajak", Trim(txtNamaPengusahaKenaPajak.Text))

        cmd.Parameters.AddWithValue("NoNPWPKenaPajak", Trim(txtNPWPPengusahaKenaPajak.Text))
        cmd.Parameters.AddWithValue("AlamatPengusahaKenaPajak", Trim(txtAlamatPengusahaKenaPajak.Text))

        cmd.Parameters.AddWithValue("NamaPembeliKenaPajak", Trim(txtNamaLawan.Text))
        cmd.Parameters.AddWithValue("AlamatPembeliKenaPajak", Trim(txtAlamatLawan.Text))
        cmd.Parameters.AddWithValue("NPWPPembeliKenaPajak", Trim(txtNpwpLawan.Text))


        cmd.Parameters.AddWithValue("TotalALL", Trim(txtTotalHargaJual.Text))
        cmd.Parameters.AddWithValue("DiscountAll", Trim(txtTotalPotonganHarga.Text))
        cmd.Parameters.AddWithValue("UangMukaALL", Trim(txtUangMuka.Text))

        cmd.Parameters.AddWithValue("DPPTOTAL", Trim(txtDPP.Text))
        cmd.Parameters.AddWithValue("PPNTOTAL", Trim(txtPPN.Text))
        cmd.Parameters.AddWithValue("PPNBMTOTAL", Trim(txtPPNBM.Text))


        If (Koneksi.State = ConnectionState.Open) Then Koneksi.Close()
        cmd.Connection = Koneksi
        Koneksi.Open()

        cmd.ExecuteNonQuery()







        For i As Integer = 0 To dgItemList.Rows.Count - 1

            If (Koneksi.State = ConnectionState.Open) Then Koneksi.Close()

            Dim cmd1 As New SqlCommand

            cmd1.Connection = Koneksi

            cmd1.CommandText = "[ADD_FakturPajakItems]"
            cmd1.CommandType = CommandType.StoredProcedure

            cmd1.Parameters.AddWithValue("NoFakturPajak", Trim(txtNomorFakturPajak.Text))
            cmd1.Parameters.AddWithValue("NamaBarang", Trim(dgItemList.Rows(i).Cells(0).Value))
            cmd1.Parameters.AddWithValue("QTY", Trim(dgItemList.Rows(i).Cells(1).Value))
            cmd1.Parameters.AddWithValue("Harga", Trim(dgItemList.Rows(i).Cells(2).Value))
            cmd1.Parameters.AddWithValue("Jumlah", Trim(dgItemList.Rows(i).Cells(3).Value))
            cmd1.Parameters.AddWithValue("Diskon", Trim(dgItemList.Rows(i).Cells(4).Value))
            cmd1.Parameters.AddWithValue("DPP", Trim(dgItemList.Rows(i).Cells(5).Value))
            cmd1.Parameters.AddWithValue("PPN", Trim(dgItemList.Rows(i).Cells(6).Value))
            cmd1.Parameters.AddWithValue("TarifPPNBM", Trim(dgItemList.Rows(i).Cells(7).Value))
            cmd1.Parameters.AddWithValue("PPNBM", Trim(dgItemList.Rows(i).Cells(8).Value))

            Koneksi.Open()

            cmd1.ExecuteNonQuery()


        Next
        Koneksi.Close()

        MsgBox("Data Berhasil Disimpan", vbInformation, "Suksesss!!!")

        Call NewScan()
        txtUrl.Select()
        Exit Sub





ErrorLoad:
        MsgBox("Kesalahan :" & Err.Description, vbCritical, "Silahkan Hubungi IT - Department")
        Koneksi.Close()




    End Sub

    Private Sub LihatDataFakturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataFakturToolStripMenuItem.Click
        FormDataFaktur.ShowDialog()
    End Sub
End Class

