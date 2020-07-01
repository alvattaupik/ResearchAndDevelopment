Imports System.Data.SqlClient
Public Class FormProsesPeminjamanAsset
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
            txtNamaUser.Text = dr.GetString(11)
            txtDurasi.Text = dr.GetString(8)
            txtTgl1.Text = dr.GetDateTime(9)
            txtTgl2.Text = dr.GetDateTime(10)
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


    Private Sub FormProsesPeminjamanAsset_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadDetailValidasi()
        LoadDaftarItemDiPinjam()
    End Sub


    Private Sub cmbStatus_Click(sender As Object, e As EventArgs) Handles cmbStatus.Click
        LoadComboStatusProses()
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
        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        On Error GoTo ErrorLoad
        If txtDiprosesOleh.Text = "" Then

            If MsgBox("Status Belum Diproses, Lanjutkan Cetak?", vbYesNo, "Konfirmasi?") = vbYes Then
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

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Close()
    End Sub
End Class