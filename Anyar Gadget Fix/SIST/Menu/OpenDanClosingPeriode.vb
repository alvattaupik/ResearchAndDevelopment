Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class OpenDanClosingPeriode

    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String
    Dim strpathAttatchments As String
    Dim strNamaAttachments As String
    Dim strExtentionFile As String
    Private Sub FormValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        JamAwal.Value = Now
        JamAkhir.Value = Now

        txtNamaLengkap.Text = MstrNamaUser
        txtNamaSupervisor.Text = MstrSupervisor
        txtDivisi.Text = MstrKodeDivisi

        MstrNamaForm = "IT005"
    End Sub


    Sub GetExtentionfile()
        ' Input path.
        Dim p As String = txtPathAttachments.Text
        ' Get extension.
        Dim extension As String = Path.GetExtension(p)

        ' Display extension.
        strExtentionFile = extension

    End Sub




    Sub LoadComboCabang()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi NOT LIKE '%Centr%'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbCabang.DataSource = ds.Tables(0)
            cmbCabang.ValueMember = "KodeDivisi"
            cmbCabang.DisplayMember = "NamaDivisi"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub




    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo ErrorLoad
        GetExtentionfile()

        If dgDaftarPeriode.RowCount = 0 Then
            MsgBox("List Periode Yang Akan Dibukan Tidak Boleh Kosong!", vbInformation, "Penting!")
            cmdInputPeriode.PerformClick()
            Exit Sub
        End If


        If cmbTujuan.Text = "" Then
            MsgBox("Tujuan Validasi Harus Di Isi!", vbInformation, "Penting!")
            Exit Sub
        End If





        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar?", vbYesNo, "Konfirmasi") = vbYes Then

            If txtKomponen.Text = "" Then
                MsgBox("Komponen SAP Harus Di Isi!", vbCritical, "Penting!")
                txtKomponen.BackColor = Color.Yellow
                GunaGradientButton2.PerformClick()
                Exit Sub
            End If


            If cmbCabang.Text = "" Then
                MsgBox("Cabang / Lokasi Harus Di Isi!", vbCritical, "Penting!")
                cmbCabang.BackColor = Color.Yellow
                Exit Sub
            End If



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[AU_CloseAndOpenPeriode]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoValidasi.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(lblKdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(cmbTujuan.SelectedValue))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdSupervisor", Trim(MstrKdSupervisor))
            cmd.Parameters.AddWithValue("JenisRequest", Trim("OPEN PERIODE"))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(txtKodeKomponen.Text))
            cmd.Parameters.AddWithValue("PesanUser", Trim(txtPesan.Text))
            cmd.Parameters.AddWithValue("KdCabang", Trim(cmbCabang.SelectedValue))
            cmd.Parameters.AddWithValue("Durasi1", JamAwal.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Durasi2", JamAkhir.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Status", "")
            cmd.Parameters.Add("OutputNoSurat", SqlDbType.VarChar, 50)
            cmd.Parameters("OutputNoSurat").Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("Attatchment", Trim(strpathAttatchments))
            cmd.Parameters.AddWithValue("StatusSP", "A")

            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()
            txtNoValidasi.Text = cmd.Parameters("OutputNoSurat").Value.ToString()

            Call CopyFileKeDirectoryAttachment()



            For i As Integer = 0 To dgDaftarPeriode.Rows.Count - 1



                Call KoneksiDatabase1()
                Dim cmd1 As New SqlCommand



                cmd1.CommandText = "[ADD_DetailSuratMenyurat]"
                cmd1.CommandType = CommandType.StoredProcedure
                cmd1.Parameters.AddWithValue("NomorSurat", Trim(txtNoValidasi.Text))
                cmd1.Parameters.AddWithValue("DocEntry", 0)


       
                cmd1.Parameters.AddWithValue("KodeBarang", dgDaftarPeriode.Rows(i).Cells(0).Value)


                If dgDaftarPeriode.Rows(i).Cells(1).Value = "" Then
                    cmd1.Parameters.AddWithValue("Deskripsi1", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi1", dgDaftarPeriode.Rows(i).Cells(1).Value)
                End If


                'If dgDaftarPeriode.Rows(i).Cells(2).Value = "" Then
                cmd1.Parameters.AddWithValue("Qty", "")
                'Else
                'cmd1.Parameters.AddWithValue("Qty", dgDaftarPeriode.Rows(i).Cells(2).Value)
                'End If

                If dgDaftarPeriode.Rows(i).Cells(2).Value = "" Then
                    cmd1.Parameters.AddWithValue("Deskripsi2", "")
                Else
                    cmd1.Parameters.AddWithValue("Deskripsi2", dgDaftarPeriode.Rows(i).Cells(2).Value)
                End If

                cmd1.Parameters.AddWithValue("Keterangan", "")
                cmd1.Parameters.AddWithValue("StatusSP", "A")

                If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
                cmd1.Connection = Koneksi1
                Koneksi1.Open()
                cmd1.ExecuteNonQuery()

            Next
            Koneksi1.Close()



            MsgBox("Permintaan Open dan Close Periode Berhasil Disimpan Dengan Nomor: " & txtNoValidasi.Text & " Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")
            Call ClearTextBoxes(Me)
            Me.Dispose()
            Exit Sub
        Else

            Exit Sub


        End If

        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Sub CopyFileKeDirectoryAttachment()
        If txtPathAttachments.Text = "" Then Exit Sub
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[OutNamaAttachments]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("NamaAttachments", SqlDbType.VarChar, 50)
        cmd.Parameters("NamaAttachments").Direction = ParameterDirection.Output

        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()
        strNamaAttachments = cmd.Parameters("NamaAttachments").Value.ToString()
        strpathAttatchments = "\\10.1.0.51\Attachments Surat\" & Trim(strNamaAttachments) & strExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(txtPathAttachments.Text), strpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub



    Private Sub cmdCetak_Click(sender As Object, e As EventArgs)
        If txtNoValidasi.Text = "" Then
            MsgBox("Tidak Ada Dokumen Yang akan dicetak!  Silahkan Buat Baru Atau Cetak di menu utama", vbCritical, "Tidak Ada Data")
            Exit Sub
        End If
    End Sub

    Private Sub cmdBuatSuratValidasiBaru_Click(sender As Object, e As EventArgs)
        If txtNoValidasi.Text = "" Then
            If MsgBox("Data Belum disimpan, lanjutkan?", vbYesNo, "Konfirmasi?") = vbYes Then
                txtNoValidasi.Text = ""
                txtPesan.Text = ""
                txtKomponen.Text = ""
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdBrowseAttatchment_Click(sender As Object, e As EventArgs) Handles cmdBrowseAttatchment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathAttachments.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        On Error Resume Next
        FormCariKomponenSAP.ShowDialog()
    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        LoadComboCabang()
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        On Error Resume Next
        Dim row As Integer
        Dim index As Integer


        If dgDaftarPeriode.RowCount = 0 Then Exit Sub

        index = dgDaftarPeriode.SelectedRows.Item(0).Index
        selRow = dgDaftarPeriode.Rows.Item(index)
        dgDaftarPeriode.Rows.Remove(selRow)
        row = row - 1

        lblJumlahPeriode.Text = "Jumlah Periode : " & dgDaftarPeriode.RowCount

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Private Sub cmbTujuan_Click(sender As Object, e As EventArgs) Handles cmbTujuan.Click
        LoadComboBoxDBEMAIL(cmbTujuan, "SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi LIKE '1%'", "KodeDivisi", "NamaDivisi")
    End Sub

    Private Sub cmdInputPeriode_Click(sender As Object, e As EventArgs) Handles cmdInputPeriode.Click
        On Error Resume Next
        FormItemsPostingPeriode.ShowDialog()
    End Sub
End Class