Imports System.Data.SqlClient

Public Class FormUpdateControlValidasi


    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtDocNum.Text = "" Then Exit Sub

        If MsgBox("Apakah Anda yakin akan Menutup validasi " & txtNotifikasi.Text & " Untuk Cabang : " & txtCabang.Text & txtNotifikasi.Text, vbYesNo, "Konfirmasi?!") = vbYes Then

            Call AUD_Validasi("U")
            Me.Dispose()
        Else
            Exit Sub
        End If

    End Sub

    Sub AUD_Validasi(strStatusSP As String)


        Call KoneksiDatabase2()
        Dim cmd As New SqlCommand



        cmd.CommandText = "[_tmsp_AUD_MasterValidasi]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
        cmd.Parameters.AddWithValue("KodeValidasi", Trim(MstrKodeValidasi))
        cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(""))
        cmd.Parameters.AddWithValue("KodeCabang", Trim(txtCabang.Text))
        cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtJenisvalidasi.Text))
        cmd.Parameters.AddWithValue("Operation", Trim(""))
        cmd.Parameters.AddWithValue("Fungsi", Trim(""))
        cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
        cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaUser))
        cmd.Parameters.AddWithValue("Catatan", Trim("Close Validation"))
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
        'txtKodeValidasi.Text = MstrKodeValidasi
        txtJenisvalidasi.Text = MstrNamaValidasi

        txtCabang.Text = MstrNamaCabang
        'txtFungsi.Text = MstrFungsi
        txtNotifikasi.Text = MstrNotifikasi


      
    End Sub


End Class