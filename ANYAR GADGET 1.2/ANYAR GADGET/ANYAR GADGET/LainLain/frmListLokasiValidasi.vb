Imports System.Data.SqlClient

Public Class frmListLokasiValidasi

    Private Sub cmdBukaValidasi_Click(sender As Object, e As EventArgs) Handles cmdBukaValidasi.Click
        If txtkodeCabang.Text = "" Then
            MsgBox("Pilih Cabang Yang Akan di Buka", vbCritical, "Penting !")

            Exit Sub
        End If

        If txtCatatan.Text = "" Then
            MsgBox("Catatan Harus Di Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan membuka validasi " & txtJenisValidasi.Text & " Untuk Cabang : " & txtCabang.Text & " Dengan Notifikasi : " & txtNotifikasi.Text, vbYesNo, "Konfirmasi?!") = vbYes Then

            Call AUD_Validasi("U")
            frmValidationControls.cmdRefreshMaster.PerformClick()
            Me.Dispose()
        Else

            Exit Sub

        End If


    End Sub



    Sub AUD_Validasi(strStatusSP As String)

        Try

            Call Koneksi_SAP()
            Dim cmd As New SqlCommand

            cmd.CommandText = "[_tmsp_AUD_MasterValidasi]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Docnum", Trim(txtCode.Text))
            cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
            cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(""))
            cmd.Parameters.AddWithValue("KodeCabang", Trim(""))
            cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtJenisValidasi.Text))
            cmd.Parameters.AddWithValue("Operation", Trim(""))
            cmd.Parameters.AddWithValue("Fungsi", Trim(""))
            cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim("0"))
            cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaPegawai))
            cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatan.Text))
            cmd.Parameters.AddWithValue("Status", strStatusSP)

            If (KoneksiSAP.State = ConnectionState.Open) Then KoneksiSAP.Close()
            cmd.Connection = KoneksiSAP
            KoneksiSAP.Open()
            cmd.ExecuteNonQuery()

            DisplayPesanOK("Operation Success!", frmMainMenu.txtPesanError, 1000)
            frmValidationControls.cmdRefresh.PerformClick()
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub



    Private Sub FormListValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call Koneksi_SAP()
        LoadDataGrid(dgvListLokasi, "SELECT Code,KodeCabang,NamaCabang FROM dbo.V_DaftarKontrolValidasi WHERE StatusEnabled='1' AND KodeValidasi='" & Trim(txtKodeValidasi.Text) & "'", KoneksiSAP)

    End Sub




   
    Private Sub dgvListLokasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListLokasi.CellClick
        txtCode.Text = dgvListLokasi.Item(0, dgvListLokasi.CurrentRow.Index).Value()
        txtCabang.Text = dgvListLokasi.Item(2, dgvListLokasi.CurrentRow.Index).Value()
        txtkodeCabang.Text = dgvListLokasi.Item(1, dgvListLokasi.CurrentRow.Index).Value()
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        frmBrowseNoSisterRequestFullfill.ShowDialog()
    End Sub
End Class