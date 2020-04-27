Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports SistemSuratTerpadu.ClassCrypt
Public Class ProsesRequest


    Sub LoadComboJenisSurat()
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
        LoadComboJenisSurat()
    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub cmdTutup_Click(sender As Object, e As EventArgs) Handles cmdTutup.Click
        Close()
    End Sub

    Private Sub cmdApprove_Click(sender As Object, e As EventArgs) Handles cmdApprove.Click
        If MstrLevelUser <> "SPV" Then
            MsgBox("Anda Tidak Berhak Melakukan Approval", vbCritical, "Not Authorise Access!")
            Exit Sub
        End If



        Dim test As Boolean = False
        For Each row In dgDaftarUserApproval.Rows
            If GlobalstrKodeUser = row.Cells("KdUserApproved").Value And row.Cells("TglApproved").Value.ToString <> "" Then
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
            cmdApprove.Enabled = False
            Exit Sub
        End If




    End Sub

    Private Sub ProsesRequest_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaForm = "Proses Request"
        LoadDaftarUserValidasi()
        LoadDetailValidasi()
    End Sub

    Sub LoadDetailValidasi()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT * FROM dbo.V_DetailValidasi WHERE NoValidasi='" & Trim(GlobalstrNoSurat) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtNoDokumen.Text = dr.GetString(0)
            txtJenisRequest.Text = dr.GetString(4)
            txtKomponen.Text = dr.GetString(5)
            txtJenisValidasi.Text = dr.GetString(6)
            txtStatus.Text = dr.GetString(1)
            txtTanggal.Text = dr.GetDateTime(3)
            txtErrorvalidasi.Text = dr.GetString(7)
            txtCreatedBy.Text = dr.GetString(11)
            txtPesanUser.Text = dr.GetString(12)
            txtCatatanAdmin.Text = dr.GetString(13)

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
    Sub AUD_Approval()
        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[AUD_Approval]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("DocEntry", Trim(""))
        cmd.Parameters.AddWithValue("NoValidasi", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("KduserApproved", Trim(GlobalstrKodeUser))
        cmd.Parameters.AddWithValue("Password", Encrypt(GlobalstrPassword, Now))

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
    Sub LoadDaftarUserValidasi()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("Select TglApproved,ApprovedBy,Status,KdUserApproved From V_DaftarUserApproved Where NoValidasi='" & Trim(GlobalstrNoSurat) & "'", Koneksi1)
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
    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[Update_Request]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("NoDokumen", Trim(txtNoDokumen.Text))
        cmd.Parameters.AddWithValue("Status", Trim(cmbStatus.Text))
        cmd.Parameters.AddWithValue("Catatan", Trim(txtCatatanAdmin.Text))
        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()

        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses!")

        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


End Class