Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBuatSuratPengajuanBiayaPerjalananDinas
    Dim index As Integer


    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        dgItem.Rows.Add("", "0", "0", "0", "")
        txtTotal.Text = "0"

        Try
            If dgItem.RowCount > 1 Then
                Dim iTax As Integer = 0
                Dim iCos As Integer = 0
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgItem.RowCount - 1
                    iTotal += Convert.ToInt32(dgItem.Rows(index).Cells(3).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                txtTotal.Text = iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If




        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Dim row As Integer



        If dgItem.RowCount = 0 Then Exit Sub

        index = dgItem.SelectedRows.Item(0).Index
        selRow = dgItem.Rows.Item(index)
        dgItem.Rows.Remove(selRow)
        row = row - 1





        Try
            If dgItem.RowCount > 1 Then
                Dim iTax As Integer = 0
                Dim iCos As Integer = 0
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgItem.RowCount - 1
                    iTotal += Convert.ToInt32(dgItem.Rows(index).Cells(3).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                txtTotal.Text = iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        If dgItem.RowCount = 0 Then txtTotal.Text = "0"



    End Sub

    Private Sub dgItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItem.CellClick
        Try
            Dim iCell1 As Integer
            Dim icell2 As Integer
            Dim icellResult As Integer
            iCell1 = dgItem.CurrentRow.Cells(1).Value
            icell2 = dgItem.CurrentRow.Cells(2).Value
            icellResult = iCell1 * icell2
            dgItem.CurrentRow.Cells(3).Value = icellResult
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        Try
            If dgItem.RowCount > 1 Then
                Dim iTax As Integer = 0
                Dim iCos As Integer = 0
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgItem.RowCount - 1
                    iTotal += Convert.ToInt32(dgItem.Rows(index).Cells(3).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                txtTotal.Text = iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub






    Private Sub dgItem_Click(sender As Object, e As EventArgs) Handles dgItem.Click
        Try
            If dgItem.RowCount > 1 Then
                Dim iTax As Integer = 0
                Dim iCos As Integer = 0
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgItem.RowCount - 1
                    iTotal += Convert.ToInt32(dgItem.Rows(index).Cells(3).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                txtTotal.Text = iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmbBuatBaru_Click(sender As Object, e As EventArgs) Handles cmbBuatBaru.Click
        ClearTextBoxes(Me)
        txtNoSurat.Text = ""
        txtTujuan.Text = ""
        txtPerihal.Text = ""
        txtLampiran.Text = ""
        txtLamaDinas.Text = ""
        txtLampiran.Text = ""
        txtTotal.Text = "0"
        dgItem.Rows.Clear()
        txtPendahuluan.Text = "Berikut ini merupakan estimasi pengajuan biaya guna mendukung kegaiatan perjalanan dinas diatas. Adapun estimasi biaya tersebut adalah sebagai berikut"
        txtPenutup.Text = "Demikian surat pengajuan biaya ini dibuat agar dapat diperguanakan sebagaimana mestinya."

    End Sub

    Private Sub FormBuatSuratPengajuanBiayaPerjalananDinas_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpTglSurat.Value = Now
        dtpTglBerangkat.Value = Now
        txtPendahuluan.Text = "Berikut ini merupakan estimasi pengajuan biaya guna mendukung kegaiatan perjalanan dinas diatas. Adapun estimasi biaya tersebut adalah sebagai berikut"
        txtPenutup.Text = "Demikian surat pengajuan biaya ini dibuat agar dapat diperguanakan sebagaimana mestinya."
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        If txtPerihal.Text = "" Then
            MsgBox("Perihal Harus Di Isi!", vbInformation, "Penting!")
            txtPerihal.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtTujuan.Text = "" Then
            MsgBox("Tujuan Harus Di Isi!", vbInformation, "Penting!")
            txtTujuan.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtLampiran.Text = "" Then
            MsgBox("Lampiran harus Isi!", vbInformation, "Penting!")
            txtLampiran.BackColor = Color.Yellow
            Exit Sub
        End If



        If txtLamaDinas.Text = "" Then
            MsgBox("Lama Dinas Harus Di Isi!", vbInformation, "Penting!")
            txtPerihal.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtPendahuluan.Text = "" Then
            MsgBox("Kalimat Pembuka Harus Di Isi!", vbInformation, "Penting!")
            txtPendahuluan.BackColor = Color.Yellow
            Exit Sub
        End If


        If txtPenutup.Text = "" Then
            MsgBox("Kalimat Penutup Harus Di Isi!", vbInformation, "Penting!")
            txtPenutup.BackColor = Color.Yellow
            Exit Sub
        End If


        If dgItem.RowCount = 0 Then
            MsgBox("Tidak Ada Data Yang Akan Disimpan", vbInformation, "Kosong?")
            Exit Sub
        End If




        For i As Integer = 0 To dgItem.Rows.Count - 1


            If dgItem.Rows(i).Cells(0).Value = "" And dgItem.Rows(i).Cells(1).Value = "" And dgItem.Rows(i).Cells(2).Value = "" Then
                MsgBox("Item Surat Jalan Masih Kosong", vbInformation, "Harus di Isi Min 1")
                Exit Sub
            End If

        Next




        For i As Integer = 0 To dgItem.Rows.Count - 1


            If dgItem.Rows(i).Cells(0).Value = "" Then
                MsgBox("Deskripsi Kebutuhan Harus Di ISi", vbInformation, "Penting!")
                Exit Sub
            End If

        Next


        If MsgBox("Apakah yakin Anda Akan Menyimpan Transaksi Ini?", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad


            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[AU_SuratPengajuanBiaya]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(LblkdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("TanggalSurat", dtpTglSurat.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("Tujuan", Trim(txtTujuan.Text))
            cmd.Parameters.AddWithValue("Perihal", Trim(txtPerihal.Text))
            cmd.Parameters.AddWithValue("LamaDinas", Trim(txtLamaDinas.Text))
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



                cmd1.CommandText = "[ADD_DetailBiayaDinas]"
                cmd1.CommandType = CommandType.StoredProcedure
                cmd1.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
                cmd1.Parameters.AddWithValue("DocEntry", 0)


   
                cmd1.Parameters.AddWithValue("DeskripsiKebutuhan", dgItem.Rows(i).Cells(0).Value)
                cmd1.Parameters.AddWithValue("HargaSatuan", dgItem.Rows(i).Cells(1).Value)
                cmd1.Parameters.AddWithValue("Qty", dgItem.Rows(i).Cells(2).Value)
                cmd1.Parameters.AddWithValue("LineTotal", dgItem.Rows(i).Cells(3).Value)
                cmd1.Parameters.AddWithValue("Keterangan", dgItem.Rows(i).Cells(4).Value)
                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()

            Next
            Koneksi1.Close()

            MsgBox("Surat Pengajuan Biaya Dinas Baru Berhasil Disimpan dengan Nomor Surat : " & Trim(txtNoSurat.Text), vbInformation, "Sukses!")
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