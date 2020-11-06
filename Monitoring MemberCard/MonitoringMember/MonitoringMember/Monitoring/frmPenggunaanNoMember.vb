Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmPenggunaanNoMember



    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub cmbPekerjaan_Click(sender As Object, e As EventArgs) Handles cmbPekerjaan.Click
        Call Koneksi_IVEND()
        LoadComboBox(cmbPekerjaan, "SELECT Cast(CustomerGroupKey As varchar(100)) As CustomerGroupKey ,Id FROM dbo.CusCustomerGroup", "CustomerGroupKey", "Id", KoneksiIvend)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboTglRegistrasi.Checked = False
        cmbCabang.SelectedValue = ""
        cmbCabang.Text = ""
        cmbStatus.Text = ""
        cmbJenisKelamin.Text = ""
        cmbPekerjaan.SelectedValue = ""
        cmbPekerjaan.Text = ""
        txtKota.Text = ""
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        MonitoringMember_VM("-", dgvSudahRegistrasi, lblSudahDiregistrasi)
    End Sub



    Sub MonitoringMember_VM(strFunction As String, dgv As DataGridView, lbl As Label)

        Try
            Koneksi_IVEND()
            Dim command As SqlCommand
            command = New SqlCommand("dbo.tmsp_Monitoring_Member_VM ", KoneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Cabang", Trim(cmbCabang.SelectedValue))
            command.Parameters.AddWithValue("@Status", Trim(cmbStatus.Text))
            command.Parameters.AddWithValue("@JenisKelamin", Trim(cmbJenisKelamin.Text))
            command.Parameters.AddWithValue("@Pekerjaan", Trim(cmbPekerjaan.SelectedValue))
            command.Parameters.AddWithValue("@Kota", Trim(txtKota.Text))
            command.Parameters.AddWithValue("@ChktglRegistrasi", Trim(cboTglRegistrasi.CheckState))
            command.Parameters.AddWithValue("@TglAwal", dtpAwal.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@TglAKhir", dtpAkhir.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@Function", Trim(strFunction))


            Dim table As New DataTable
            adapter.Fill(table)
            dgv.DataSource = table
            dgv.DataSource = table
            lbl.Text = dgv.RowCount

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub txtNoMember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoMember.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        If Tombol = 13 Then
            Try
                Koneksi_IVEND()
                Dim command As SqlCommand
                command = New SqlCommand("dbo.tmsp_Pemakaian_Member_VM ", KoneksiIvend)

                Dim adapter As New SqlDataAdapter(command)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@NoMember", Trim(txtNoMember.Text))
                Dim table As New DataTable
                adapter.Fill(table)
                dgvPenggunaMember.DataSource = table
            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
            End Try

        End If
    End Sub



    Sub LihatTransaksiMemberVM()
        Try
            Koneksi_SAP()
            Dim command As SqlCommand
            command = New SqlCommand("dbo.tmsp_Lihat_Member_VM ", KoneksiSAP)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@NoStruk", Trim(dgvPenggunaMember.Item(3, dgvPenggunaMember.CurrentRow.Index).Value))
            Dim table As New DataTable
            adapter.Fill(table)
            dgvRincianTransaksi.DataSource = table
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub btnLihatTransaksi_Click(sender As Object, e As EventArgs) Handles btnLihatTransaksi.Click
        If dgvPenggunaMember.RowCount = 0 Then Exit Sub

        LihatTransaksiMemberVM()
    End Sub
End Class