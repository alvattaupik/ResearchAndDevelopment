Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormBuatSuratJalan
    Public selRow As New DataGridViewRow
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        FormBusinessPartner.ShowDialog()
    End Sub


    Sub LoadPenerima()
        txtPenerima.Text = GlobalstrPenerima
        txtNoTelpPenerima.Text = Globalstrtelepon
        txtAlamatPenerima.Text = GlobalstrAlamat
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

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItemsSuratjalan.ShowDialog()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If dgItem.RowCount = 0 Then
            MsgBox("Item Surat Jalan Masih Kosong", vbInformation, "Harus di Isi Min 1")
            Exit Sub
        End If


        For i As Integer = 0 To dgItem.Rows.Count - 1


            If dgItem.Rows(i).Cells(0).Value = "" And dgItem.Rows(i).Cells(1).Value = "" And dgItem.Rows(i).Cells(2).Value = "" Then
                MsgBox("Item Surat Jalan Masih Kosong", vbInformation, "Harus di Isi Min 1")
                Exit Sub
            End If

        Next






        If MsgBox("Apakah yakin Anda Akan Menyimpan Surat Ini?, Surat yang telah dibuat tidak dapat dihapus", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand



            cmd.CommandText = "[AU_SuratMenyurat]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(lblKdJenisSurat.Text))
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

                If dgItem.Rows(i).Cells(0).Value = Nothing Then
                    cmd1.Parameters.AddWithValue("KodeBarang", "")
                Else
                    cmd1.Parameters.AddWithValue("KodeBarang", dgItem.Rows(i).Cells(0).Value)

                End If

                If dgItem.Rows(i).Cells(1).Value = Nothing Then

                    cmd1.Parameters.AddWithValue("Deskripsi1", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi1", dgItem.Rows(i).Cells(1).Value)
                End If

                If dgItem.Rows(i).Cells(2).Value = Nothing Then
                    cmd1.Parameters.AddWithValue("Qty", "")
                Else

                    cmd1.Parameters.AddWithValue("Qty", dgItem.Rows(i).Cells(2).Value)
                End If

                cmd1.Parameters.AddWithValue("Deskripsi2", "")

                If dgItem.Rows(i).Cells(3).Value = Nothing Then
                    cmd1.Parameters.AddWithValue("Keterangan", "")
                Else
                    cmd1.Parameters.AddWithValue("Keterangan", dgItem.Rows(i).Cells(3).Value)
                End If

                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()


            Next
            Koneksi1.Close()

            MsgBox("Surat Baru Berhasil Disimpan dengan Nomor Surat : " & Trim(txtNoSurat.Text), vbInformation, "Sukses!")
            FormMenuUtama.LoadDaftarSurat()
            Exit Sub

        Else
            Exit Sub

        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub

    End Sub


    Private Sub FormBuatSuratJalan_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPengirim.Text = GlobalstrNamaUser
        MstrNamaForm = "Surat Jalan"
        dtpTglSurat.Value = Now
    End Sub
End Class