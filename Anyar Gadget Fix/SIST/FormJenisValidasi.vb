Imports System.Data.SqlClient
Public Class FormJenisValidasi



    Sub LoadListValidasi()

        Call KoneksiDatabase2()
        Dim cmd As New SqlCommand("SELECT DISTINCT CAST(U_NamaValidasi AS VARCHAR(300)) AS Jenis,CAST(U_Notifikasi AS VARCHAR(300)) AS Notifikasi,U_Kode_validasi AS Kode,U_KodeCabang AS KodeCabang FROM dbo.[@RKM_MASTER_VALIDASI] Where (CAST(U_NamaValidasi AS VARCHAR(300)) Like '%" & Trim(txtCariValidasi.Text) & "%' Or CAST(U_Notifikasi AS VARCHAR(300)) Like '%" & Trim(txtCariValidasi.Text) & "%' Or U_Kode_validasi Like '%" & Trim(txtCariValidasi.Text) & "%') and U_KodeCabang='" & MstrKodeDivisi & "'", Koneksi2)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarValidasi.DataSource = table
        dgDaftarValidasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarValidasi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarValidasi.AutoResizeColumns()

    End Sub



    Private Sub FormJenisValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadListValidasi()
    End Sub

    Private Sub dgDaftarValidasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarValidasi.CellContentClick
        FormBuatRequestBukaValidasi.txtJenisValidasi.Text = dgDaftarValidasi.Item(2, dgDaftarValidasi.CurrentRow.Index).Value
        FormBuatRequestBukaValidasi.txtError.Text = dgDaftarValidasi.Item(1, dgDaftarValidasi.CurrentRow.Index).Value
        Me.Close()
    End Sub

    Private Sub txtCariValidasi_TextChanged(sender As Object, e As EventArgs) Handles txtCariValidasi.TextChanged
        LoadListValidasi()
    End Sub
End Class