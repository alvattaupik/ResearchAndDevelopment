Imports System.Data.SqlClient

Public Class FormUpdateControl
    Dim strStatusEnabled As String

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If cmbStatusEnabled.Text = "" Then
            MsgBox("Status Enabled Harus Di Pilih", vbInformation, "Penting!")
            Exit Sub
        End If

        If cmbStatusEnabled.Text = "ENABLED" Then
            strStatusEnabled = "1"
        Else
            strStatusEnabled = "0"
        End If


        Call AUD_Validasi("U")



    End Sub

    Sub AUD_Validasi(strStatusSP As String)


        Call KoneksiDatabase2()
        Dim cmd As New SqlCommand



        cmd.CommandText = "[_tmsp_AUD_MasterValidasi]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
        cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
        cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(""))
        cmd.Parameters.AddWithValue("KodeCabang", Trim(""))
        cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtNamaValidasi.Text))
        cmd.Parameters.AddWithValue("Operation", Trim(""))
        cmd.Parameters.AddWithValue("Fungsi", Trim(txtFungsi.Text))
        cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))
        cmd.Parameters.AddWithValue("Status", strStatusSP)

        If (Koneksi2.State = ConnectionState.Open) Then Koneksi2.Close()
        cmd.Connection = Koneksi2
        Koneksi2.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Status Enabled validasi Berhasil Di Update", vbInformation, "Sukses!")
        MainMenu.LoadMasterValidasi()
        MainMenu.LoadUnlockControl()

    End Sub


    Private Sub FormUpdateControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDocNum.Text = MstrDocNum
        txtKodeValidasi.Text = MstrKodeValidasi
        txtNamaValidasi.Text = MstrNamaValidasi

        txtCabang.Text = MstrNamaCabang
        txtFungsi.Text = MstrFungsi
        txtNotifikasi.Text = MstrNotifikasi


        If MstrStatusEnabled = "1" Then
            cmbStatusEnabled.Text = "ENABLED"
        Else
            cmbStatusEnabled.Text = "DISABLED"
        End If




    End Sub

    Private Sub cmdUpdateAllLocation_Click(sender As Object, e As EventArgs) Handles cmdUpdateAllLocation.Click
        If cmbStatusEnabled.Text = "" Then
            MsgBox("Status Enabled Harus Di Pilih", vbInformation, "Penting!")
            Exit Sub
        End If

        If cmbStatusEnabled.Text = "ENABLED" Then
            strStatusEnabled = "1"
        Else
            strStatusEnabled = "0"
        End If

        If MsgBox("Anda Akan Mengupdate Konfigurasi ini Untuk Seluruh Cabang", vbYesNo, "Konfirmasi") = vbYes Then

            Call AUD_Validasi("Y")
        Else
            Exit Sub

        End If
    End Sub
End Class