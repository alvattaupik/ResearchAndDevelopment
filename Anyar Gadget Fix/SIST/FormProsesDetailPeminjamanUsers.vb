﻿Imports System.Data.SqlClient
Imports AnyarGadget.ClassCrypt

Public Class FormProsesDetailPeminjamanUsers
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long

    Sub LoadDetailValidasi()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT * FROM dbo.V_DetailRequestUsers WHERE NoValidasi='" & Trim(MstrNoSurat) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            txtNoDokumen.Text = dr.GetString(0)

            If dr.GetString(2) <> "" Then
                cmbStatus.Text = dr.GetString(2)
                cmbStatus.BackColor = Color.Green
            Else
                cmbStatus.Text = dr.GetString(2)
                cmbStatus.BackColor = Color.White
            End If
            txtNamaUser.Text = dr.GetString(11)
            txtJenisRequest.Text = dr.GetString(4)
            txtKomponen.Text = dr.GetString(5)
            txtJenisValidasi.Text = dr.GetString(6)
            txtStatus.Text = dr.GetString(1)
            txtTanggal.Text = dr.GetDateTime(3)
            txtErrorvalidasi.Text = dr.GetString(7)
            txtLamanya.Text = dr.GetString(8)
            txtDurasi1.Text = dr.GetDateTime(9)
            txtDurasi2.Text = dr.GetDateTime(10)


            txtPesanUser.Text = dr.GetString(12)
            txtCatatanAdmin.Text = dr.GetString(13)
            txtPathAttachment.Text = dr.GetString(16)
            txtJenisForm.Text = dr.GetString(17)
            txtDiprosesOleh.Text = dr.GetString(19)
            txtTglKembali.Text = dr.GetString(20)
            txtPenerima.Text = dr.GetString(21)
            txtLokasi.Text = dr.GetString(22)

        Else

            MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

            Exit Sub

ErrorLoad:
            MsgBox(Err.Description)
            Exit Sub
    End Sub
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Close()
    End Sub


    Sub LoadDaftarUserValidasi()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("Select TglApproved,ApprovedBy,Status,KdUserApproved From V_DaftarUserApproved Where NoValidasi='" & Trim(MstrNoSurat) & "'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarUserApproval.DataSource = table
        dgDaftarUserApproval.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUserApproval.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUserApproval.AutoResizeColumns()

        lblJumlahUserApproved.Text = "Jumlah Approved User: " & dgDaftarUserApproval.RowCount

    End Sub

    Private Sub FormDetailValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadDaftarUserValidasi()
        LoadDetailValidasi()
        LoadDaftarItemDiPinjam()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtStatus.Text <> "Lengkap Disetujui" Then
            If MsgBox("Status Approval Belum Lengkap, Lanjutkan?", vbYesNo, "Konfirmasi?") = vbYes Then



                MstrNoSurat = Trim(txtNoDokumen.Text)

                Call KoneksiDatabase1()
                Dim strSQlLogin As String

                strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='Y'"
                cmd = New SqlCommand(strSQlLogin, Koneksi1)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then

                    MstrPathReport = dr.GetString(0)
                    FormTampilkanCetakan.Show()
                    dr.Close()

                Else

                    MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
                    dr.Close()
                    Exit Sub
                End If

                Exit Sub
            Else


                MstrNoSurat = Trim(txtNoDokumen.Text)

                Call KoneksiDatabase1()
                Dim strSQlLogin As String

                strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='Y'"
                cmd = New SqlCommand(strSQlLogin, Koneksi1)
                dr = cmd.ExecuteReader
                dr.Read()

                If dr.HasRows = True Then

                    MstrPathReport = dr.GetString(0)
                    FormTampilkanCetakan.Show()
                    dr.Close()

                Else

                    MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
                    dr.Close()
                    Exit Sub
                End If

                Exit Sub
            End If
        Else

            MstrNoSurat = Trim(txtNoDokumen.Text)

            Call KoneksiDatabase1()
            Dim strSQlLogin As String

            strSQlLogin = "SELECT TOP 1 PathTemplate FROM dbo.MasterKonfigurasiTemplate WHERE KdUser='" & Trim(MstrKodeUser) & "' AND KdJenisSurat='IT003' AND StatusEnabled='Y'"
            cmd = New SqlCommand(strSQlLogin, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows = True Then

                MstrPathReport = dr.GetString(0)
                FormTampilkanCetakan.Show()
                dr.Close()

            Else

                MsgBox("Template Tidak Ada!!!", vbInformation, "Hubungi Administrator")
                dr.Close()
                Exit Sub
            End If

        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdLihatAttchment_Click(sender As Object, e As EventArgs) Handles cmdLihatAttchment.Click
        If txtPathAttachment.Text = "" Then
            MsgBox("Tidak Ada Attatchment Yang Dilampirkan", vbInformation, "Information")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = txtPathAttachment.Text
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub


    Sub AUD_Approval()
        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[AUD_Approval]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("DocEntry", Trim(""))
        cmd.Parameters.AddWithValue("NoValidasi", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("KduserApproved", Trim(MstrKodeUser))
        cmd.Parameters.AddWithValue("Password", Encrypt(MstrPassword, Now))

        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()

        MsgBox("Approval Validasi Berhasil Disimpan! Silahkan Cek Monitoring Request!", vbInformation, "Sukses!")

        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



    Private Sub cmbSetujui_Click(sender As Object, e As EventArgs)
        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[Update_Request]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("Status", Trim(cmbStatus.Text))
        cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatanAdmin.Text))
        cmd.Parameters.AddWithValue("KodeUser", Trim(MstrKodeUser))
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()

        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses!")

        FormMonitoringProsesRequest.LoadDaftarRequestValidasiALL()
        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs)
        Dim test As Boolean = False
        For Each row In dgDaftarUserApproval.Rows
            If MstrKodeUser = row.Cells("KdUserApproved").Value And row.Cells("TglApproved").Value.ToString <> "" Then
                test = True
                Exit For
            End If
        Next

        If test = False Then


            If MsgBox("Apakah Anda Telah yakin menyetujui Request ini?", vbYesNo, "Konfirmasi") = vbYes Then
                FormValidasiPassword.ShowDialog()
                Exit Sub
            Else

                Exit Sub
            End If



        Else
            MsgBox("Anda Sudah Pernah Melakukan Approval Untuk Dokumen Ini", vbInformation, "Informasi")

            Exit Sub
        End If
    End Sub
    Sub LoadComboStatusProses()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdStatus,NamaStatus FROM dbo.MasterStatus WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbStatus.DataSource = ds.Tables(0)
            cmbStatus.ValueMember = "KdStatus"
            cmbStatus.DisplayMember = "NamaStatus"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Sub LoadDaftarItemDiPinjam()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT KodeBarang AS Kode,Deskripsi1 AS Namabarang,Deskripsi2 AS Keterangan FROM dbo.DetailSuratMenyurat Where NoSurat='" & Trim(MstrNoSurat) & "'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarUserApproval.DataSource = table
        dgDaftarUserApproval.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUserApproval.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUserApproval.AutoResizeColumns()

        lblJumlahUserApproved.Text = "Jumlah Asset Yang Dipinjam : " & dgDaftarUserApproval.RowCount

    End Sub


    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        If cmbStatus.Text = "" Then
            MsgBox("Status Proses Harus Di Isi!", vbInformation, "Penting!")
            cmbStatus.BackColor = Color.Red
            Exit Sub
        End If

        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[Update_Request]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("Status", Trim(cmbStatus.Text))
        cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatanAdmin.Text))
        cmd.Parameters.AddWithValue("KodeUser", Trim(MstrKodeUser))
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()

        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses!")
        LoadDetailValidasi()
        FormMonitoringProsesRequest.RefreshData()
        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub cmbStatus_Click(sender As Object, e As EventArgs) Handles cmbStatus.Click
        LoadComboStatusProses()
        cmbStatus.BackColor = Color.White
    End Sub
End Class