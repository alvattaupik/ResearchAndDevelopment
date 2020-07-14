Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class BukaValidasi

    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String
    Dim strpathAttatchments As String
    Dim strNamaAttachments As String
    Dim strExtentionFile As String

    Private Sub BukaValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDisplayNama.Text = MstrNamaUser
        txtDisplayNamaSupervisor.Text = MstrSupervisor
        txtDisplayLokasi.Text = MstrKodeDivisi
        JamAwal.Value = Now
        JamAkhir.Value = Now
        MstrNamaForm = "IT003"
    End Sub

    Sub GetExtentionfile()
        Dim p As String = txtPathLampiran.Text
        Dim extension As String = Path.GetExtension(p)
        strExtentionFile = extension
    End Sub

    Sub CopyFileKeDirectoryAttachment()
        If txtPathLampiran.Text = "" Then Exit Sub
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
        My.Computer.FileSystem.CopyFile(Trim(txtPathLampiran.Text), strpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub

    Private Sub BukaValidasi_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub BukaValidasi_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

    Private Sub cmdKirimValidasi_Click(sender As Object, e As EventArgs) Handles cmdKirimValidasi.Click
        On Error GoTo ErrorLoad


        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar?", vbYesNo, "Konfirmasi") = vbYes Then


            If cmbTujuan.Text = "" Then
                MsgBox("Tujuan Validasi Harus Di Isi", vbInformation, "Penting!")
                cmbTujuan.BackColor = Color.Yellow
                Exit Sub
            End If

            If txtKomponenSAP.Text = "" Then
                MsgBox("Komponen SAP Harus Di Isi!", vbCritical, "Penting!")
                cmdCariKomponenSAP.PerformClick()
                txtKodeKomponenSAP.BackColor = Color.Yellow
                Exit Sub
            End If


            If txtKomponenValidasi.Text = "" Then
                MsgBox("Komponen Validasi Harus Di Isi!", vbCritical, "Penting!")
                cmdCariKomponenValidasi.PerformClick()
                txtKodeKomponenValidasi.BackColor = Color.Yellow
                Exit Sub
            End If



            If txtPesanUser.Text = "" Then
                MsgBox("Deskripsi Kebutuhan tidak boleh kosong!", vbCritical, "Penting!")
                txtPesanUser.BackColor = Color.Yellow
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
            cmd.Parameters.AddWithValue("NomorSurat", "")
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(lblKdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(cmbTujuan.SelectedValue))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdSupervisor", Trim(MstrKdSupervisor))
            cmd.Parameters.AddWithValue("Pesan", Trim(txtPesanUser.Text))
            cmd.Parameters.AddWithValue("KdCabang", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("JenisRequest", Trim("BUKA VALIDASI"))
            cmd.Parameters.AddWithValue("Durasi1", JamAwal.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Durasi2", JamAkhir.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(txtKodeKomponenSAP.Text))
            cmd.Parameters.AddWithValue("KdJenisValidasi", Trim(txtKodeKomponenValidasi.Text))
            cmd.Parameters.AddWithValue("PesanError", Trim(txtNotifValidasi.Text))
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
            MsgBox("Permintaan Validasi Berhasil Disimpan Dengan Nomor: " & cmd.Parameters("OutputNoSurat").Value.ToString() & " Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")
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

    Private Sub cmbTujuan_Click(sender As Object, e As EventArgs) Handles cmbTujuan.Click
        LoadComboBoxDBEMAIL(cmbTujuan, "SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi LIKE '1%'", "KodeDivisi", "NamaDivisi")
    End Sub

    Sub Bersihkan()
        txtPesanUser.Text = ""
        'cmbTujuan.Items.Clear()
        JamAwal.Value = Now
        JamAkhir.Value = Now
        txtKodeKomponenSAP.Text = ""
        txtKomponenSAP.Text = ""


        txtKodeKomponenValidasi.Text = ""
        txtKomponenValidasi.Text = ""


        txtNotifValidasi.Text = ""
        txtPathLampiran.Text = ""
        Me.Dispose()
    End Sub


    Private Sub cmdBrowseLampiran_Click(sender As Object, e As EventArgs) Handles cmdBrowseLampiran.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathLampiran.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdCariKomponenSAP_Click(sender As Object, e As EventArgs) Handles cmdCariKomponenSAP.Click
        On Error Resume Next
        FormCariKomponenSAP.ShowDialog()
    End Sub

    Private Sub cmdCariKomponenValidasi_Click(sender As Object, e As EventArgs) Handles cmdCariKomponenValidasi.Click
        On Error Resume Next
        FormJenisValidasi.ShowDialog()
    End Sub
End Class