Imports System.Data.SqlClient
Public Class FormCariKomponenSAP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub


    Sub LoadDaftarKomponenSAP()

        Call KoneksiDatabase1()

        Dim cmd As New SqlCommand("SELECT Top 10 * FROM V_KomponenSAP Where NamaKomponen Like '%" & Trim(txtCariKomponen.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgDaftarKomponenSAP.DataSource = table
        dgDaftarKomponenSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarKomponenSAP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarKomponenSAP.AutoResizeColumns()

    End Sub



    Private Sub txtCariKomponen_TextChanged(sender As Object, e As EventArgs) Handles txtCariKomponen.TextChanged
        LoadDaftarKomponenSAP()
    End Sub

    Private Sub FormCariKomponenSAP_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        LoadDaftarKomponenSAP()
    End Sub



    Private Sub dgDaftarKomponenSAP_Click(sender As Object, e As EventArgs) Handles dgDaftarKomponenSAP.Click
        FormBuatRequestValidasi.txtKodeKomponen.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value
        FormBuatRequestValidasi.txtKomponen.Text = dgDaftarKomponenSAP.Item(2, dgDaftarKomponenSAP.CurrentRow.Index).Value
        dgDaftarKomponenSAP.DataSource = Nothing
        Me.Close()
    End Sub
End Class