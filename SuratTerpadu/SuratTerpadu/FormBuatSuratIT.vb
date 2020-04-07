Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBuatSuratIT

    Dim strTempkodeJenisSurat As String
    Public selRow As New DataGridViewRow
    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        CariKodeJenisSurat()
        If dgItem.RowCount = 0 Then
            MsgBox("Tidak Ada Data Yang Akan Disimpan", vbInformation, "Kosong?")
            Exit Sub
        End If



        If MsgBox("Apakah yakin Anda Akan Menyimpan Transaksi Ini?", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[AU_SuratMenyurat]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(strTempkodeJenisSurat))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(GlobalstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(GlobalstrKodeUser))
            cmd.Parameters.AddWithValue("TanggalSurat", dtpTglSurat.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("Pengirim", Trim(txtPengirim.Text))
            cmd.Parameters.AddWithValue("Penerima", Trim(txtPenerima.Text))
            cmd.Parameters.AddWithValue("AlamatPenerima", Trim(txtAlamatPenerima.Text))
            cmd.Parameters.AddWithValue("NoTelpPenerima", Trim(txtNoTelpPenerima.Text))
            cmd.Parameters.AddWithValue("Perihal", Trim(txtPerihal.Text))
            cmd.Parameters.AddWithValue("Lampiran", Trim(txtLampiran.Text))
            cmd.Parameters.AddWithValue("Attachment", "")
            cmd.Parameters.AddWithValue("Pendahuluan", Trim(txtPendahuluan.Text))
            cmd.Parameters.AddWithValue("Penutup", Trim(txtPenutup.Text))
            cmd.Parameters.AddWithValue("Canceled", "N")
            cmd.Parameters.AddWithValue("UserCanceled", "")
            cmd.Parameters.AddWithValue("Reasons", "")
            cmd.Parameters.AddWithValue("CancelDate", Now)
            cmd.Parameters.Add("OutputNoSurat", SqlDbType.VarChar, 50)
            cmd.Parameters("OutputNoSurat").Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("Supervisor", Trim(GlobalstrSupervisor))
            cmd.Parameters.AddWithValue("StatusSP", "A")



            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()


            txtNoSurat.Text = cmd.Parameters("OutputNoSurat").Value.ToString()




            For i As Integer = 0 To dgItem.Rows.Count - 1



                Call KoneksiDatabase1()
                Dim cmd1 As New SqlCommand



                cmd1.CommandText = "[ADD_DetailSuratMenyurat]"
                cmd1.CommandType = CommandType.StoredProcedure
                cmd1.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
                cmd1.Parameters.AddWithValue("DocEntry", 0)
                cmd1.Parameters.AddWithValue("KodeBarang", dgItem.Rows(i).Cells(0).Value)
                cmd1.Parameters.AddWithValue("Deskripsi1", dgItem.Rows(i).Cells(1).Value)
                cmd1.Parameters.AddWithValue("Qty", dgItem.Rows(i).Cells(2).Value)
                cmd1.Parameters.AddWithValue("Deskripsi2", dgItem.Rows(i).Cells(3).Value)
                cmd1.Parameters.AddWithValue("Keterangan", "")
                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()


            Next
            Koneksi1.Close()

            MsgBox("Surat Baru Berhasil Disimpan dengan Nomor Surat : " & Trim(txtNoSurat.Text), vbInformation, "Sukses!")
            MenuUtama.LoadDaftarSurat()
            Exit Sub

        Else
            Exit Sub

        End If



ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub

    End Sub


    Sub Bersihkan()
        cmbJenisSurat.Text = ""
        txtNoSurat.Text = ""
        txtAlamatPenerima.Text = ""
        txtPengirim.Text = ""
        txtPendahuluan.Text = ""
        txtPenerima.Text = ""
        txtPenutup.Text = ""
        txtPerihal.Text = ""
    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Sub LoadComboJenisSurat()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdJenisSurat,NamaSurat FROM dbo.JenisSurat WHERE StatusEnabled='Y' AND KodeExternal<>'General'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            conn.Close()
            cmbJenisSurat.DataSource = ds.Tables(0)
            cmbJenisSurat.ValueMember = "KdJenisSurat"
            cmbJenisSurat.DisplayMember = "NamaSurat"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Sub CariKodeJenisSurat()


        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT KdJenisSurat From JenisSurat WHERE NamaSurat='" & Trim(cmbJenisSurat.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strTempkodeJenisSurat = dr.GetString(0)
            dr.Close()

        Else

            dr.Close()
            strTempkodeJenisSurat = "001"
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub








    Private Sub cmbJenisSurat_Click(sender As Object, e As EventArgs) Handles cmbJenisSurat.Click
        LoadComboJenisSurat()



    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        dgItem.Rows.Add("", "", "", "")

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Dim row As Integer
        Dim index As Integer


        If dgItem.RowCount = 0 Then Exit Sub

        index = dgItem.SelectedRows.Item(0).Index
        selRow = dgItem.Rows.Item(index)
        dgItem.Rows.Remove(selRow)
        row = row - 1
    End Sub

    Private Sub FormBuatSurat_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPengirim.Text = GlobalstrNamaUser
        txtSupervisor.Text = GlobalstrSupervisor
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        FormBusinessPartner.ShowDialog()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItems.ShowDialog()
    End Sub


    Private Sub cmbJenisSurat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisSurat.SelectedIndexChanged
        If cmbJenisSurat.Text = "Surat Jalan" Then
            LblPenerima.Text = "Penerima"
            LblPengirim.Text = "Pengirim"
        Else
            LblPenerima.Text = "Yang Menyerahkan"
            LblPengirim.Text = "Yang Menerima"
        End If
    End Sub
End Class