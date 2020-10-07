Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormBuatRequestCloseAndCancel

    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String
    Dim strpathAttatchments As String
    Dim strNamaAttachments As String
    Dim strExtentionFile As String
    Private Sub FormValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaForm = "Buat Request Cancel Dan Close"
        ClearTextBoxes(Me)
        txtNamaLengkap.Text = MstrNamaUser
        txtNamaSupervisor.Text = MstrSupervisor
        txtDivisi.Text = MstrNamaDivisi

    End Sub


    Sub GetExtentionfile()
        ' Input path.
        Dim p As String = txtPathAttachments.Text
        ' Get extension.
        Dim extension As String = Path.GetExtension(p)

        ' Display extension.
        strExtentionFile = extension

    End Sub



    '    Sub CariKodeJenisValidasi()
    '        KoneksiDatabase1()
    '        Dim strSQlLogin As String

    '        strSQlLogin = "SELECT top 1 Cast(KdJenisValidasi As varchar(20)),NamaValidasi FROM dbo.JenisValidasi WHERE Namavalidasi='" & Trim(cmbJenisValidasi.Text) & "'"
    '        cmd = New SqlCommand(strSQlLogin, Koneksi1)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows = True Then

    '            strKodeJenisValidasi = dr.GetString(0)
    '            dr.Close()

    '        Else

    '            dr.Close()
    '            strKodeJenisValidasi = "001"
    '            Exit Sub
    '        End If


    '        Exit Sub

    'ErrorLoad:
    '        MsgBox(Err.Description)
    '        Exit Sub

    '    End Sub





  
    'Private Sub cmbKomponen_Click(sender As Object, e As EventArgs)
    '    LoadComboKomponenValidasi()
    'End Sub



    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo ErrorLoad
        GetExtentionfile()

        Call CopyFileKeDirectoryAttachment()

        'CariKodeJenisValidasi()

        If MsgBox("Apakah Data Yang Di Inputkan Sudah Benar?", vbYesNo, "Konfirmasi") = vbYes Then

            If cmbJenisRequest.Text = "" Then
                MsgBox("Jenis Request Harus Di Isi!", vbCritical, "Penting!")
                cmbJenisRequest.BackColor = Color.Yellow
                Exit Sub
            End If


            If txtKomponen.Text = "" Then
                MsgBox("Komponen Validasi Harus Di Isi!", vbCritical, "Penting!")
                txtKomponen.BackColor = Color.Yellow
                GunaGradientButton2.PerformClick()
                Exit Sub
            End If


            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand

            cmd.CommandText = "[AU_CloseCancel]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("NomorSurat", Trim(txtNoValidasi.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(lblKdJenisSurat.Text))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdSupervisor", Trim(MstrKdSupervisor))
            cmd.Parameters.AddWithValue("JenisRequest", Trim(cmbJenisRequest.Text))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(txtKodeKomponen.Text))
            cmd.Parameters.AddWithValue("PesanUser", Trim(txtPesan.Text))
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
            MsgBox("Permintaan Close dan Cancel Dokumen Berhasil Disimpan Dengan Nomor: " & txtNoValidasi.Text & " Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")
            Call ClearTextBoxes(Me)
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
                txtKomponen.Text = ""
            Else
                Exit Sub
            End If
        End If
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

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        On Error Resume Next
        FormCariKomponenSAP.ShowDialog()
    End Sub
End Class