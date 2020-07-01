Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormValidasiPasswordPengembalianAsset
    Dim strCek As String
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            strCek = "SELECT TOP 1 ISNULL(TanggalKembali,'') As TanggalKembali,PetugasPenerima From Peminjaman WHERE NomorSurat='" & Trim(MstrNoSurat) & "'"
            cmd = New SqlCommand(strCek, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                If dr.GetString(0) = "" Then
                    GoTo Lanjut
                Else
                    MsgBox("Sudah Dikembalikan Tanggal" & dr.GetString(0) & " Diterima Oleh : " & dr.GetString(1), vbInformation, "Informasi!")

                    Exit Sub
                End If
            End If




Lanjut:


            If cmbStatusPengembalian.Text = "" Then
                MsgBox("Status Pengembalian Harus Di Isi!", vbInformation, "Penting!")
                cmbStatusPengembalian.BackColor = Color.Red
                Exit Sub
            End If



            KoneksiDatabase1()
            Dim strSQlLogin As String

            strSQlLogin = "SELECT * From UserLogin WHERE KodePegawai='" & Trim(MstrKodeUser) & "' AND PasswordLogin ='" & Trim(txtPassword.Text) & "'"
            cmd = New SqlCommand(strSQlLogin, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then


                Call KoneksiDatabase1()
                Dim str As String
                str = "Update Peminjaman set StatusKembali = '" & cmbStatusPengembalian.Text & "', TanggalKembali = '" & Now & "',PetugasPenerima='" & MstrNamaUser & "' Where NomorSurat = '" & MstrNoSurat & "'"

                cmd = New SqlCommand(str, Koneksi1)

                cmd.ExecuteNonQuery()


                FormProsesPeminjamanAsset.LoadDetailValidasi()
                MsgBox("Proses Pengembalian Sukses Disimpan", vbInformation, "Pengembalian")
                FormMonitoringPeminjamanAset.BelumKembali()
                Me.Dispose()
            Else

                MsgBox("Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
                dr.Close()
                Exit Sub
            End If
            Exit Sub

        End If

        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



End Class