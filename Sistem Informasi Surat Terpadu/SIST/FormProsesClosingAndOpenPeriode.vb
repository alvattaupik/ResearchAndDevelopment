Imports System.Data.SqlClient
Public Class FormProsesClosingAndOpenPeriode
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long


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

  
    Private Sub cmbStatus_Click(sender As Object, e As EventArgs) Handles cmbStatus.Click
        LoadComboStatusProses()
    End Sub



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

        Else

            MsgBox("Template Tidak Ada" & vbCrLf & "Silahkan Masukan template, Baca Buku Panduan Di Menu Help", vbInformation, "Hubungi Administrator")
            dr.Close()
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
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


    Private Sub FormProsesClosingAndOpenPeriode_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDetailValidasi()
        LoadDaftarPostingPeriode()
        LoadDaftarUserValidasi()
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

    Private Sub cmdSimpanProses_Click(sender As Object, e As EventArgs) Handles cmdSimpanProses.Click
        If cmbStatus.Text = "" Then
            MsgBox("Status Proses Harus Di Isi!", vbInformation, "Penting!")
            Exit Sub
        End If


        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[Update_Request]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("Status", Trim(cmbStatus.Text))
        cmd.Parameters.AddWithValue("Catatan", Trim(txtPesanAdmin.Text))
        cmd.Parameters.AddWithValue("KodeUser", Trim(MstrKodeUser))
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()

        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses!")

        FormMonitoringProsesRequest.LoadDaftarBelumDiProses()
        LoadDetailValidasi()
        LoadDaftarPostingPeriode()
        LoadDaftarUserValidasi()
        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Close()
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

    Private Sub cmdLihatAttchment_Click(sender As Object, e As EventArgs) Handles cmdLihatAttchment.Click
        If txtPathAttachment.Text = "" Then
            MsgBox("Tidak Ada Dokumen Yang Dilampirkan", vbInformation, "Information")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = txtPathAttachment.Text
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub
End Class