Imports System.Data.SqlClient

Public Class FormListValidasi

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

            LoadMasterValidasi()
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
        cmd.Parameters.AddWithValue("Docnum", Trim(txtCode.Text))
        cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
        cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(""))
        cmd.Parameters.AddWithValue("KodeCabang", Trim(""))
        cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtJenisValidasi.Text))
        cmd.Parameters.AddWithValue("Operation", Trim(""))
        cmd.Parameters.AddWithValue("Fungsi", Trim(""))
        cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim("0"))
        cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaUser))
        cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatan.Text))
        cmd.Parameters.AddWithValue("Status", strStatusSP)

        If (Koneksi2.State = ConnectionState.Open) Then Koneksi2.Close()
        cmd.Connection = Koneksi2
        Koneksi2.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Status Enabled validasi Berhasil Di Update", vbInformation, "Sukses!")
        MainMenu.LoadMasterValidasi()
        MainMenu.LoadUnlockControl()

    End Sub



    Private Sub FormListValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtKodeValidasi.Text = MstrKodeValidasi
        txtFungsiValidasi.Text = MstrFungsi
        txtNotifikasi.Text = MstrNotifikasi
        txtJenisValidasi.Text = MstrNamaValidasi

        LoadMasterValidasi()

    End Sub




    Sub LoadMasterValidasi()

        Call KoneksiDatabase2()

        'Dim cmd As New SqlCommand("Select * from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%' AND StatusEnabled='1'", Koneksi2)

        Dim cmd As New SqlCommand("SELECT Code,KodeCabang,NamaCabang FROM dbo.V_DaftarKontrolValidasi WHERE StatusEnabled='1' AND KodeValidasi='" & Trim(txtKodeValidasi.Text) & "'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgvListLokasi.DataSource = table

        dgvListLokasi.Columns(0).Width = 0
        dgvListLokasi.Columns(1).Width = 0
        dgvListLokasi.Columns(2).Width = 300
        dgvListLokasi.Columns(2).ReadOnly = True

    End Sub

    Private Sub dgvListLokasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListLokasi.CellClick
        txtCode.Text = dgvListLokasi.Item(0, dgvListLokasi.CurrentRow.Index).Value()
        txtCabang.Text = dgvListLokasi.Item(2, dgvListLokasi.CurrentRow.Index).Value()
        txtkodeCabang.Text = dgvListLokasi.Item(1, dgvListLokasi.CurrentRow.Index).Value()
    End Sub

End Class