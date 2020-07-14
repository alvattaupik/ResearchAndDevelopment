Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormBuatRequestBukaValidasi

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
        MstrNamaForm = "IT003"

    End Sub


    Sub GetExtentionfile()
        ' Input path.
        Dim p As String = txtPathAttachments.Text
        ' Get extension.
        Dim extension As String = Path.GetExtension(p)

        ' Display extension.
        strExtentionFile = extension

    End Sub


    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo ErrorLoad
  

        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar?", vbYesNo, "Konfirmasi") = vbYes Then

            If cmbJenisRequest.Text = "" Then
                MsgBox("Jenis Request Harus Di Isi!", vbCritical, "Penting!")
                cmbJenisRequest.BackColor = Color.Yellow
                Exit Sub
            End If


            If cmbTujuan.Text = "" Then
                MsgBox("Tujuan Validasi Harus Di Isi", vbInformation, "Penting!")
                cmbTujuan.BackColor = Color.Yellow
                Exit Sub
            End If

            If txtKomponen.Text = "" Then
                MsgBox("Komponen SAP Harus Di Isi!", vbCritical, "Penting!")
                cmdBrowse.PerformClick()
                txtKomponen.BackColor = Color.Yellow
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

            GetExtentionfile()

            Call CopyFileKeDirectoryAttachment()

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
            cmd.Parameters.AddWithValue("JenisRequest", Trim(cmbJenisRequest.Text))
            cmd.Parameters.AddWithValue("Durasi1", JamAwal.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Durasi2", JamAkhir.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(txtKdKomponenSAP.Text))
            cmd.Parameters.AddWithValue("KdJenisValidasi", Trim(txtKdJenisValidasi.Text))
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
            Bersihkan()
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

    Private Sub cmdBrowseAttatchment_Click(sender As Object, e As EventArgs) Handles cmdBrowseAttatchment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathAttachments.Text = O.FileName
            End If
        End Using

    End Sub


    Private Sub cmdBrowseJenisValidasi_Click(sender As Object, e As EventArgs) Handles cmdBrowseJenisValidasi.Click
        On Error Resume Next
        FormJenisValidasi.ShowDialog()
    End Sub

 
    Private Sub cmbTujuan_Click(sender As Object, e As EventArgs) Handles cmbTujuan.Click
        LoadComboBoxDBEMAIL(cmbTujuan, "SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi LIKE '1%'", "KodeDivisi", "NamaDivisi")
    End Sub
End Class