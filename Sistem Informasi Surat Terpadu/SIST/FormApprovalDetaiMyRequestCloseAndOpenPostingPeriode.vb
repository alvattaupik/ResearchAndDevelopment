Imports System.Data.SqlClient
Imports SISTER.ClassCrypt

Public Class FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode
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
            txtStatusApproval.Text = dr.GetString(1)
            txtStatusProses.Text = dr.GetString(2)
            txtTanggal.Text = dr.GetDateTime(3)
            txtJenisRequest.Text = dr.GetString(4)
            txtKomponen.Text = dr.GetString(5)
            txtDurasi.Text = dr.GetString(8)
            txtPesanUser.Text = dr.GetString(12)
            txtPesanAdmin.Text = dr.GetString(13)
            txtPathAttachment.Text = dr.GetString(16)
            txtJenisForm.Text = dr.GetString(17)
            txtCabang.Text = dr.GetString(23)

            txtNamaUser.Text = dr.GetString(11)
            txtSPV.Text = dr.GetString(18)

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
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs)
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
        LoadDaftarUserValidasi()
        LoadDetailValidasi()
        LoadDaftarPostingPeriode()
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


    Sub LoadDaftarPostingPeriode()

        On Error Resume Next

        Call KoneksiDatabase1()

        Dim cmd As New SqlCommand("SELECT Deskripsi1 As Periode,Deskripsi2 As Status FROM dbo.DetailSuratMenyurat Where NoSurat = '" & Trim(txtNoDokumen.Text) & "'", Koneksi1)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgListPeriode.DataSource = table
        dgListPeriode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgListPeriode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgListPeriode.AutoResizeColumns()
        lblJumlahPeriode.Text = "Jumlah Periode :" & dgListPeriode.RowCount

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        cmdSetujui.Enabled = True
    End Sub

    Private Sub GunaGradientButton1_Click_1(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Close()
        cmdSetujui.Enabled = True
    End Sub

    Private Sub cmdCetak_Click(sender As Object, e As EventArgs) Handles cmdCetak.Click
        On Error GoTo ErrorLoad
        If dgDaftarUserApproval.RowCount = 0 Then

            If MsgBox("Status Approval Belum Disetujui, Lanjutkan Cetak?", vbYesNo, "Konfirmasi?") = vbYes Then
                LoadTemplateSurat()
            Else
                Exit Sub
            End If

        Else
            LoadTemplateSurat()
        End If
        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub cmdSetujui_Click(sender As Object, e As EventArgs) Handles cmdSetujui.Click
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
            cmdSetujui.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub cmdLihatAttchment_Click_1(sender As Object, e As EventArgs) Handles cmdLihatAttchment.Click
        If txtPathAttachment.Text = "" Then
            MsgBox("Tidak Ada Dokumen Yang Dilampirkan", vbInformation, "Information")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = txtPathAttachment.Text
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub
End Class