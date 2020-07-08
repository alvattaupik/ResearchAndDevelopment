Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBuatPeminjamanAset

    Private Sub cmbBuatBaru_Click(sender As Object, e As EventArgs) Handles cmbBuatBaru.Click
        txtCatatanUser.Text = ""
        txtNoHP.Text = ""
        txtNoSurat.Text = ""
        txtAlamatEmail.Text = ""
        txtLokasi.Text = ""
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItemsAset.ShowDialog()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        If txtNoHP.Text = "" Then
            MsgBox("No HP Harus Di Isi!", vbInformation, "Penting!")
            txtNoHP.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtAlamatEmail.Text = "" Then
            MsgBox("Alamat Email Harus Di Isi!", vbInformation, "Penting!")
            txtAlamatEmail.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtLokasi.Text = "" Then
            MsgBox("Lokasi Harus Di Isi!", vbInformation, "Penting!")
            txtLokasi.BackColor = Color.Yellow
            Exit Sub
        End If



        For i As Integer = 0 To dgItem.Rows.Count - 1


            If dgItem.Rows(i).Cells(0).Value = "" And dgItem.Rows(i).Cells(1).Value = "" And dgItem.Rows(i).Cells(2).Value = "" Then
                MsgBox("Baris Asset Yang akan Dipinjam Tidak Boleh Kosong!", vbInformation, "Penting!")
                Exit Sub
            End If

        Next


        If dgItem.RowCount = 0 Then
            MsgBox("Item Asset Yang Harus Dipinjam Minimal Harus 1 Baris", vbInformation, "Penting!")
            Exit Sub
        End If



        If MsgBox("Apakah yakin Anda Akan Menyimpan Transaksi Ini?", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand



            cmd.CommandText = "[AU_SuratPeminjamanAset]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(LblkdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("TanggalPeminjaman", dtpTglSurat.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("AlamatEmail", Trim(txtAlamatEmail.Text))
            cmd.Parameters.AddWithValue("NoTelepon", Trim(txtNoHP.Text))
            cmd.Parameters.AddWithValue("NamaPeminjam", Trim(MstrNamaUser))
            cmd.Parameters.AddWithValue("Durasi1", dtpPinjam1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("Durasi2", dtpPinjam2.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("Lokasi", Trim(txtLokasi.Text))
            cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatanUser.Text))
            cmd.Parameters.Add("OutputNoSurat", SqlDbType.VarChar, 50)
            cmd.Parameters("OutputNoSurat").Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("Supervisor", Trim(MstrSupervisor))
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


                If dgItem.Rows(i).Cells(0).Value = "" Then
                    cmd1.Parameters.AddWithValue("KodeBarang", "")
                Else
                    cmd1.Parameters.AddWithValue("KodeBarang", dgItem.Rows(i).Cells(0).Value)
                End If

                If dgItem.Rows(i).Cells(1).Value = "" Then
                    cmd1.Parameters.AddWithValue("Deskripsi1", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi1", dgItem.Rows(i).Cells(1).Value)
                End If


                'If dgItem.Rows(i).Cells(2).Value = "" Then
                cmd1.Parameters.AddWithValue("Qty", "")
                'Else
                'cmd1.Parameters.AddWithValue("Qty", dgItem.Rows(i).Cells(2).Value)
                'End If

                If dgItem.Rows(i).Cells(2).Value = "" Then
                    cmd1.Parameters.AddWithValue("Deskripsi2", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi2", dgItem.Rows(i).Cells(2).Value)
                End If

                cmd1.Parameters.AddWithValue("Keterangan", "")
                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()

            Next
            Koneksi1.Close()

            MsgBox("Surat Peminjaman  Berhasil Disimpan dengan Nomor Surat : " & Trim(txtNoSurat.Text) & " Silahkan Cek Status Request di Monitoring My Request", vbInformation, "Sukses!")
            'LoadDaftarSuratMenuUtama()
            Exit Sub

        Else
            Exit Sub

        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub




    End Sub

    Private Sub FormBuatPeminjamanAset_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpTglSurat.Value = Now
        dtpPinjam1.Value = Now
        dtpPinjam2.Value = Now
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        dgItem.Rows.Add("", "0", "0", "0", "")
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
End Class