Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormValidasi

    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String

    Private Sub FormValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNamaLengkap.Text = GlobalstrNamaUser
        txtNamaSupervisor.Text = GlobalstrSupervisor
        txtDivisi.Text = GlobalstrNamaDivisi
        JamAwal.Value = Now
        JamAkhir.Value = Now
    End Sub

    Sub LoadComboKomponenValidasi()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT DocCode,NamaDokumen FROM dbo.KomponenValidasi WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbKomponen.DataSource = ds.Tables(0)
            cmbKomponen.ValueMember = "DocCode"
            cmbKomponen.DisplayMember = "NamaDokumen"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Sub CariKodeKomponen()
        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT DocCode,NamaDokumen FROM dbo.KomponenValidasi WHERE NamaDokumen='" & Trim(cmbKomponen.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strKodeKomponen = dr.GetString(0)
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
    Sub CariKodeJenisValidasi()
        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT top 1 KdJenisValidasi,NamaValidasi FROM dbo.JenisValidasi WHERE Namavalidasi='" & Trim(cmbJenisValidasi.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strKodeJenisValidasi = dr.GetString(0)
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
    Private Sub cmbKomponen_Click(sender As Object, e As EventArgs) Handles cmbKomponen.Click
        LoadComboKomponenValidasi()
    End Sub

    Private Sub cmbJenisValidasi_Click(sender As Object, e As EventArgs) Handles cmbJenisValidasi.Click
        LoadComboJenisValidasi()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        On Error GoTo Errorload

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
            cmd.Parameters.AddWithValue("KdDivisi", Trim(GlobalstrKodeDivisi))
            cmd.Parameters.AddWithValue("KdUser", Trim(GlobalstrKodeUser))
            cmd.Parameters.AddWithValue("Pesan", Trim(txtPesan.Text))
            cmd.Parameters.AddWithValue("JenisRequest", Trim(cmbJenisRequest.Text))
            cmd.Parameters.AddWithValue("Durasi1", JamAwal.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("Durasi2", JamAkhir.Value.ToString("HH:mm"))
            cmd.Parameters.AddWithValue("KdKomponen", Trim(strKodeKomponen))
            cmd.Parameters.AddWithValue("KdJenisValidasi", Trim(strKodeJenisValidasi))
            cmd.Parameters.AddWithValue("PesanError", Trim(txtError.Text))
            cmd.Parameters.AddWithValue("Catatan", Trim(""))
            cmd.Parameters.AddWithValue("Status", "")
            cmd.Parameters.Add("OutputNoSurat", SqlDbType.VarChar, 50)
            cmd.Parameters("OutputNoSurat").Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("StatusSP", "A")

            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()
            txtNoValidasi.Text = cmd.Parameters("OutputNoSurat").Value.ToString()
            MsgBox("Permintaan Validasi Berhasil Disimpan Dengan Nomor: " & txtNoValidasi.Text & " Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")

            Exit Sub
        Else

            Exit Sub


        End If

        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub cmdCetak_Click(sender As Object, e As EventArgs)
        If txtNoValidasi.Text = "" Then
            MsgBox("Tidak Ada Dokumen Yang akan dicetak!  Silahkan Buat Baru Atau Cetak di menu utama", vbCritical, "Tidak Ada Data")
            Exit Sub
        End If
    End Sub

    Private Sub cmdBuatSuratValidasiBaru_Click(sender As Object, e As EventArgs) Handles cmdBuatSuratValidasiBaru.Click
        If txtNoValidasi.Text = "" Then
            If MsgBox("Data Belum disimpan, lanjutkan?", vbYesNo, "Konfirmasi?") = vbYes Then

                txtNoValidasi.Text = ""
                txtPesan.Text = ""
                cmbJenisRequest.Text = ""
                JamAwal.Value = Now
                JamAkhir.Value = Now
                cmbKomponen.Text = ""
                txtError.Text = ""

            Else
                Exit Sub
            End If
        End If

      
    End Sub
End Class