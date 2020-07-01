Imports System.Data.SqlClient
Public Class FormCariKomponenSAP

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Sub LoadDaftarKomponenSAP()

        Call KoneksiDatabase1()

        Dim cmd As New SqlCommand("SELECT Top 10 * FROM V_KomponenSAP Where NamaKomponen Like '%" & Trim(txtCariKomponen.Text) & "%' Or DocCode  Like '%" & Trim(txtCariKomponen.Text) & "%' ", Koneksi1)

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
       
        FormAddControl.txtKodeJenis.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value

        dgDaftarKomponenSAP.DataSource = Nothing
        Me.Dispose()
    End Sub
End Class