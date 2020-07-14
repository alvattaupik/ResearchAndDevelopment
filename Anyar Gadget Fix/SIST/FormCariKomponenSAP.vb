Imports System.Data.SqlClient
Public Class FormCariKomponenSAP


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
        dgDaftarKomponenSAP.RowHeadersVisible = False
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
        If MstrNamaForm = "IT003" Then
            BukaValidasi.txtKodeKomponenSAP.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value
            BukaValidasi.txtKomponenSAP.Text = dgDaftarKomponenSAP.Item(2, dgDaftarKomponenSAP.CurrentRow.Index).Value
            Me.Close()
        End If


        If MstrNamaForm = "IT005" Then
            OpenDanClosingPeriode.txtKodeKomponen.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value
            OpenDanClosingPeriode.txtKomponen.Text = dgDaftarKomponenSAP.Item(2, dgDaftarKomponenSAP.CurrentRow.Index).Value
            Me.Close()
        End If



    End Sub

   
    'Private Sub dgDaftarKomponenSAP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarKomponenSAP.CellContentClick
    '    If MstrNamaForm = "IT003" Then

    '        BukaValidasi.txtKodeKomponenSAP.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value
    '        BukaValidasi.txtKomponenSAP.Text = dgDaftarKomponenSAP.Item(2, dgDaftarKomponenSAP.CurrentRow.Index).Value
    '        'dgDaftarKomponenSAP.DataSource = Nothing
    '        Me.Close()
    '    End If
    'End Sub
End Class