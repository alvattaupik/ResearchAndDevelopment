Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBuatBeritaAcaraSerahTerima

    Private Sub cmbBuatBaru_Click(sender As Object, e As EventArgs) Handles cmbBuatBaru.Click
        txtPenerima.Text = ""
        txtPenutup.Text = "Demikian Berita Acara Serah Terima ini dibuat agar dapat digunakan sebagaimana mestinya"
        txtPerihal.Text = ""
        txtLampiran.Text = ""
        txtNoTelpPenerima.Text = ""
        txtNoSurat.Text = ""
        txtAlamatPenerima.Text = ""
        txtPendahuluan.Text = "Pada Hari ini           Tanggal "
    End Sub

    Private Sub FormBuatBeritaAcaraSerahTerima_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaForm = "Form Berita Acara Serah Terima"
        txtPendahuluan.Text = "Pada Hari ini           Tanggal "
        txtPenutup.Text = "Demikian Berita Acara Serah Terima ini dibuat agar dapat digunakan sebagaimana mestinya"
        txtStaffIT.Text = MstrSupervisor
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        FormBusinessPartner.ShowDialog()
    End Sub



    Sub LoadPenerima()
        txtPenerima.Text = MstrPenerima
        txtNoTelpPenerima.Text = Mstrtelepon
        txtAlamatPenerima.Text = MstrAlamat
    End Sub


    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        If txtPenerima.Text = "" Then
            MsgBox("Nama Penerima Harus Di Isi!", vbInformation, "Penting!")
            txtPenerima.BackColor = Color.Yellow
            Exit Sub
        End If


        For i As Integer = 0 To dgItem.Rows.Count - 1


            If dgItem.Rows(i).Cells(0).Value = "" And dgItem.Rows(i).Cells(1).Value = "" And dgItem.Rows(i).Cells(2).Value = "" Then
                MsgBox("Item Surat Jalan Masih Kosong", vbInformation, "Harus di Isi Min 1")
                Exit Sub
            End If

        Next


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
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(LblkdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("TanggalSurat", dtpTglSurat.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("Pengirim", Trim(txtStaffIT.Text))
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


                If dgItem.Rows(i).Cells(2).Value = "" Then
                    cmd1.Parameters.AddWithValue("Qty", "")
                Else
                    cmd1.Parameters.AddWithValue("Qty", dgItem.Rows(i).Cells(2).Value)
                End If

                If dgItem.Rows(i).Cells(3).Value = "" Then
                    cmd1.Parameters.AddWithValue("Deskripsi2", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi2", dgItem.Rows(i).Cells(3).Value)
                End If

                cmd1.Parameters.AddWithValue("Keterangan", "")
                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()

            Next
            Koneksi1.Close()

            MsgBox("BAP Penyelesaian  Berhasil Disimpan dengan Nomor Surat : " & Trim(txtNoSurat.Text), vbInformation, "Sukses!")
            LoadDaftarSuratMenuUtama()
            Exit Sub

        Else
            Exit Sub

        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub
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
        FormItemsBAPSerahTerima.ShowDialog()
    End Sub

    Private Sub GunaGradientButton4_Click(sender As Object, e As EventArgs) Handles GunaGradientButton4.Click
        On Error GoTo ErrorLoad


        If txtNoSurat.Text = "" Then
            MsgBox("Tidak Ada Surat Yang Akan Dicetak", vbInformation, "Hah Kosong?")
        Else

            MstrNoSurat = txtNoSurat.Text

            Call KoneksiDatabase1()
            Dim strSQlLogin As String

            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='" & LblkdJenisSurat.Text & "' AND StatusEnabled='Y'"
            cmd = New SqlCommand(strSQlLogin, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                MstrPathReport = dr.GetString(0)
                FormTampilkanCetakan.Show()
                dr.Close()
            Else

                MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
                dr.Close()
                Exit Sub
            End If

            Exit Sub
        End If
        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles GunaGradientButton3.Click
        FormTemplate.ShowDialog()
    End Sub
End Class