Imports System.Data.SqlClient

Public Class FormDetailPeminjamanSaya
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
            txtStatusRequest.Text = MstrStatusRequest
            txtJenisRequest.Text = dr.GetString(4)
            txtKomponen.Text = dr.GetString(5)
            txtJenisValidasi.Text = dr.GetString(6)
            txtStatus.Text = dr.GetString(1)
            txtTanggal.Text = dr.GetDateTime(3)
            txtErrorvalidasi.Text = dr.GetString(7)
            txtPesanUser.Text = dr.GetString(12)
            txtPesanAdmin.Text = dr.GetString(13)
            txtPathAttachment.Text = dr.GetString(16)
            txtJenisForm.Text = dr.GetString(17)
            txtDiprosesOleh.Text = dr.GetString(19)
            txtTglKembali.Text = dr.GetString(20)
            txtPenerima.Text = dr.GetString(21)

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


    Sub LoadDetailPeminjaman()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT * FROM dbo.V_DetailRequestUsers WHERE NoValidasi='" & Trim(MstrNoSurat) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then


            txtNoDokumen.Text = dr.GetString(0)

            If dr.GetString(2) <> "" Then
                txtStatusRequest.Text = dr.GetString(2)
                txtStatusRequest.BackColor = Color.Yellow
            Else
                txtStatusRequest.Text = dr.GetString(2)
                txtStatusRequest.BackColor = Color.White
            End If
            'txtNamaUser.Text = dr.GetString(11)
            txtJenisRequest.Text = dr.GetString(4)
            txtKomponen.Text = dr.GetString(5)
            txtJenisValidasi.Text = dr.GetString(6)
            txtStatus.Text = dr.GetString(1)
            txtTanggal.Text = dr.GetDateTime(3)
            txtErrorvalidasi.Text = dr.GetString(7)
            txtDurasi.Text = dr.GetString(8)
            txtTgl1.Text = dr.GetDateTime(9)
            txtTgl2.Text = dr.GetDateTime(10)


            txtPesanUser.Text = dr.GetString(12)
            txtPesanAdmin.Text = dr.GetString(13)
            txtPathAttachment.Text = dr.GetString(16)
            txtJenisForm.Text = dr.GetString(17)
            txtDiprosesOleh.Text = dr.GetString(19)
            txtTglKembali.Text = dr.GetString(20)
            txtPenerima.Text = dr.GetString(21)
            txtLokasi.Text = dr.GetString(22)








            'txtNoDokumen.Text = dr.GetString(0)
            'txtStatusRequest.Text = MstrStatusRequest
            'txtJenisRequest.Text = dr.GetString(4)
            'txtKomponen.Text = dr.GetString(5)
            'txtJenisValidasi.Text = dr.GetString(6)
            'txtStatus.Text = dr.GetString(1)
            'txtTanggal.Text = dr.GetDateTime(3)
            'txtErrorvalidasi.Text = dr.GetString(7)
            'txtPesanUser.Text = dr.GetString(12)
            'txtPesanAdmin.Text = dr.GetString(13)
            'txtPathAttachment.Text = dr.GetString(16)
            'txtJenisForm.Text = dr.GetString(17)
            'txtDiprosesOleh.Text = dr.GetString(19)
            'txtTglKembali.Text = dr.GetString(20)
            'txtPenerima.Text = dr.GetString(21)

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


        Dim cmd As New SqlCommand("Select TglApproved,ApprovedBy,Status From V_DaftarUserApproved Where NoValidasi='" & Trim(MstrNoSurat) & "'", Koneksi1)

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




    Private Sub FormDetailValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadDaftarUserValidasi()
        LoadDaftarItemDiPinjam()
        LoadDetailPeminjaman()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub cmdLihatAttchment_Click(sender As Object, e As EventArgs)
        If txtPathAttachment.Text = "" Then
            MsgBox("Tidak Ada Attatchment Yang Dilampirkan", vbInformation, "Information")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = txtPathAttachment.Text
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class