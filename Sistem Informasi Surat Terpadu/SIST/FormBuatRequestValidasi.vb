Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormBuatRequestValidasi

    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String
    Dim strpathAttatchments As String
    Dim strNamaAttachments As String
    Dim strExtentionFile As String
    Private Sub FormValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNamaLengkap.Text = MstrNamaUser
        txtNamaSupervisor.Text = MstrSupervisor
        txtDivisi.Text = MstrNamaDivisi
        JamAwal.Value = Now
        JamAkhir.Value = Now
        MstrNamaForm = "Buat Request Validasi"

    End Sub


    Sub GetExtentionfile()
        ' Input path.
        Dim p As String = txtPathAttachments.Text
        ' Get extension.
        Dim extension As String = Path.GetExtension(p)

        ' Display extension.
        strExtentionFile = extension

    End Sub



    Sub CariKodeJenisValidasi()
        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT top 1 Cast(KdJenisValidasi As varchar(20)),NamaValidasi FROM dbo.JenisValidasi WHERE Namavalidasi='" & Trim(cmbJenisValidasi.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strKodeJenisValidasi = dr.GetString(0)
            dr.Close()

        Else

            dr.Close()
            strKodeJenisValidasi = "001"
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub





    Sub LoadComboJenisValidasi()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdJenisValidasi,NamaValidasi FROM dbo.JenisValidasi WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbJenisValidasi.DataSource = ds.Tables(0)
            cmbJenisValidasi.ValueMember = "KdJenisValidasi"
            cmbJenisValidasi.DisplayMember = "NamaValidasi"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub



    Sub LoadComboCabang()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi LIKE '%1%'", Koneksi1)
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





    'Private Sub cmbKomponen_Click(sender As Object, e As EventArgs)
    '    LoadComboKomponenValidasi()
    'End Sub

    Private Sub cmbJenisValidasi_Click(sender As Object, e As EventArgs) Handles cmbJenisValidasi.Click
        LoadComboJenisValidasi()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo ErrorLoad
        GetExtentionfile()

        Call CopyFileKeDirectoryAttachment()

        CariKodeJenisValidasi()

        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar?", vbYesNo, "Konfirmasi") = vbYes Then

            If cmbJenisRequest.Text = "" Then
                MsgBox("Jenis Request Harus Di Isi!", vbCritical, "Penting!")
                cmbJenisRequest.BackColor = Color.Yellow
                Exit Sub
            End If

            If cmbJenisValidasi.Text = "" Then
                MsgBox("Jenis Validasi Harus Di Isi!", vbCritical, "Penting!")
                cmbJenisValidasi.BackColor = Color.Yellow
                Exit Sub
            End If



            If cmbCabang.Text = "" Then
                MsgBox("Cabang / Lokasi Harus DI Isi!", vbCritical, "Penting!")
                cmbCabang.BackColor = Color.Yellow
                Exit Sub
            End If



            If txtKomponen.Text = "" Then
                MsgBox("Komponen SAP Harus Di Isi!", vbCritical, "Penting!")
                cmdBrowse.PerformClick()
                txtKomponen.BackColor = Color.Yellow
                cmdBrowse.PerformClick()
                Exit Sub
            End If


            If txtPesan.Text = "" Then
                MsgBox("Deskripsi Kebutuhan tidak boleh kosong!", vbCritical, "Penting!")
                txtPesan.BackColor = Color.Yellow
                Exit Sub
            End If


            If JamAwal.Value.ToString("H:mm") = JamAkhir.Value.ToString("H:mm") Then
                If MsgBox("Apakah Anda Yakin Telah Mengatur Durasi Permintaan ini Dengan Benar?", vbYesNo, "Konfirmasi") = vbYes Then
                    GoTo Lanjut
                Else
                    Exit Sub
                End If
                Exit Sub
            End If


Lanjut:


            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand

            cmd.CommandText = "[AU_Validasi]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoValidasi.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(lblKdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdSupervisor", Trim(MstrKdSupervisor))
            cmd.Parameters.AddWithValue("Pesan", Trim(txtPesan.Text))
            cmd.Parameters.AddWithValue("KdCabang", Trim(cmbCabang.SelectedValue))
            cmd.Parameters.AddWithValue("JenisRequest", Trim(cmbJenisRequest.Text))
            cmd.Parameters.AddWithValue("Durasi1", JamAwal.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Durasi2", JamAkhir.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(txtKodeKomponen.Text))
            cmd.Parameters.AddWithValue("KdJenisValidasi", Trim(cmbJenisValidasi.Text))
            cmd.Parameters.AddWithValue("PesanError", Trim(txtError.Text))
            cmd.Parameters.AddWithValue("Catatan", Trim(""))
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
            MsgBox("Permintaan Validasi Berhasil Disimpan Dengan Nomor: " & txtNoValidasi.Text & " Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")
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
        strpathAttatchments = "\\10.1.0.52\Attachments Surat\" & Trim(strNamaAttachments) & strExtentionFile
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
                cmbJenisRequest.Text = ""
                JamAwal.Value = Now
                JamAkhir.Value = Now
                txtKomponen.Text = ""
                txtError.Text = ""
            Else
                Exit Sub
            End If
        End If
    End Sub

    Sub Bersihkan()
        txtNoValidasi.Text = ""
        txtPesan.Text = ""
        cmbJenisRequest.Items.Clear()
        cmbJenisValidasi.DataSource = Nothing
        JamAwal.Value = Now
        JamAkhir.Value = Now
        txtKomponen.Text = ""
        txtError.Text = ""
        txtPathAttachments.Text = ""
    End Sub


    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        On Error Resume Next
        FormCariKomponenSAP.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdBrowseAttatchment_Click(sender As Object, e As EventArgs) Handles cmdBrowseAttatchment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathAttachments.Text = O.FileName
            End If
        End Using

    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        LoadComboCabang()
    End Sub

    Private Sub cmbJenisRequest_Click(sender As Object, e As EventArgs) Handles cmbJenisRequest.Click

    End Sub
End Class