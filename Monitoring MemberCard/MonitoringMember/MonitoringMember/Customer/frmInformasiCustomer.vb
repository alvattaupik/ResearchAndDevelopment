Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmInformasiCustomer
    Private myBindingSource As New BindingSource()
    Private Sub timerInformasiMember_Tick(sender As Object, e As EventArgs) Handles timerInformasiMember.Tick
        lblJamDigital.Text = TimeOfDay
    End Sub




    Private Sub picLogout_Click(sender As Object, e As EventArgs) Handles picLogout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Dispose()
            frmMainMenu.Dispose()
            frmLogin.Show()
            frmLogin.txtUsernameLogin.Text = ""
            frmLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaPegawai, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmInformasiCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNamaCabang.Text = MstrNamaCabang
        lblNamaUser.Text = MstrNamaPegawai
    End Sub


    Private Sub picCariCustomer_Click(sender As Object, e As EventArgs) Handles picCariCustomer.Click
        Dim frm As New frmCariCustomer
        frm.Show()
    End Sub

    Private Sub txtKodeCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtKodeCustomer.TextChanged
        LoadDataGrid(dgvListAlamatCustomer, "Select * From V_ListAlamatCustomer Where KodeCustomer='" & Trim(txtKodeCustomer.Text) & "'", KoneksiSAP)
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        If dgvListAlamatCustomer.RowCount = 0 Then
            DisplayPesanError("No Records To Export", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            ExportToExcel(lblExportToExcel, dgvListAlamatCustomer)
        End If

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If txtKodeCustomer.Text = "" Then
            DisplayPesanError("Kode Customer Is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("[Lap_RiwayatTransaksi_VM]", KoneksiSAP)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@TanggalAwal", dtpTglAwal.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@TanggalAkhir", dtpAkhir.Value.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@KodeCustomer", txtKodeCustomer.Text)

        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvListTransaksi.DataSource = myBindingSource


        Me.dgvListTransaksi.DataSource = table
        dgvListTransaksi.DataSource = table
        dgvListTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListTransaksi.AutoResizeColumns()
        dgvListTransaksi.RowHeadersVisible = False


    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "KodeBarang Like '%" & txtCari.Text & "%' OR NamaBarang Like '%" & txtCari.Text & "%' OR NoStruk Like '%" & txtCari.Text & "%'"
                dgvListTransaksi.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub picExportTransaksi_Click(sender As Object, e As EventArgs) Handles picExportTransaksi.Click
        If dgvListTransaksi.RowCount = 0 Then
            DisplayPesanError("No Records To Export", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            ExportToExcel(lblExportTransaksi, dgvListTransaksi)
        End If
    End Sub
End Class