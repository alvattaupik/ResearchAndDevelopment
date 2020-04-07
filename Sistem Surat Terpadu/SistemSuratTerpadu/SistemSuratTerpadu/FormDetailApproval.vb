Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports SistemSuratTerpadu.ClassCrypt

Public Class FormDetailApproval

    Private Sub cmdApproved_Click(sender As Object, e As EventArgs) Handles cmdApproved.Click

        Dim test As Boolean = False
        For Each row In dgDaftarUserApproval.Rows
            If GlobalstrKodeUser = row.Cells("KdUserApproved").Value Then
                test = True
                Exit For
            End If
        Next

        If test = False Then


            If MsgBox("Apakah Anda Telah yakin menyetujui Request ini?", vbYesNo, "Konfirmasi") = vbYes Then
                cmdApproved.Enabled = False
                Exit Sub
            Else
                Exit Sub
            End If



        Else
            MsgBox("Anda Sudah Pernah Melakukan Approval Untuk Dokumen Ini", vbInformation, "Informasi")
            Exit Sub
        End If





      
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
            txtPesanUser.Text = dr.GetString(12)

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

    Private Sub FormDetailApproval_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDetailValidasi()
        LoadDaftarUserValidasi()

    End Sub
End Class