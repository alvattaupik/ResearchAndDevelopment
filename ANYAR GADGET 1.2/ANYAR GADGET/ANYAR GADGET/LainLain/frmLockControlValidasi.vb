Imports System.Data.SqlClient
Public Class frmLockControlValidasi

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtDocNum.Text = "" Then Exit Sub

        If MsgBox("Apakah Anda yakin akan Menutup validasi " & txtNotifikasi.Text & " Untuk Cabang : " & txtCabang.Text & txtNotifikasi.Text, vbYesNo, "Konfirmasi?!") = vbYes Then

            Call AUD_Validasi("UPDATE")
            Me.Dispose()
            frmValidationControls.cmdRefresh.PerformClick()
        Else
            Exit Sub
        End If
    End Sub


    Sub AUD_Validasi(strStatusSP As String)

        Try
            Call Koneksi_SAP()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[_tmsp_AUD_MasterValidasi2]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
            cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtJenisvalidasi.Text))
            cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(""))
            cmd.Parameters.AddWithValue("KodeCabang", Trim(txtCabang.Text))
            cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtJenisvalidasi.Text))
            cmd.Parameters.AddWithValue("Operation", Trim(""))
            cmd.Parameters.AddWithValue("Fungsi", Trim(""))
            cmd.Parameters.AddWithValue("Ref", Trim(txtRef.Text))
            cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
            cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaPegawai))
            cmd.Parameters.AddWithValue("Catatan", Trim("Close Validation"))
            cmd.Parameters.AddWithValue("Status", strStatusSP)

            If (KoneksiSAP.State = ConnectionState.Open) Then KoneksiSAP.Close()
            cmd.Connection = KoneksiSAP
            KoneksiSAP.Open()
            cmd.ExecuteNonQuery()

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

        Catch ex As Exception
            DisplayPesanOK(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub




End Class