Imports System.Data.SqlClient

Public Class FormDetailValidasi


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


    Sub LoadDaftarUserValidasi()

        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("Select TglApproved,ApprovedBy,Status From V_DaftarUserApproved Where NoValidasi='" & Trim(GlobalstrNoSurat) & "'", Koneksi1)

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
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtStatus.Text <> "Lengkap Disetujui" Then
            If MsgBox("Status Approval Belum Lengkap, Lanjutkan?", vbYesNo, "Konfirmasi?") = vbYes Then

            Else
                Exit Sub
            End If
        End If
    End Sub
End Class