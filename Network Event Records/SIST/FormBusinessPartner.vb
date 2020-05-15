Imports System.Data.SqlClient

Public Class FormBusinessPartner


    Sub LoadDaftarCabang()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("SELECT RKM_LIVE_2.dbo.OPRC.PrcName AS NamaCabang,Street,COALESCE(City,'') AS NoTelp FROM RKM_LIVE_2.dbo.OWHS LEFT OUTER JOIN RKM_LIVE_2.dbo.OPRC ON RKM_LIVE_2.dbo.OPRC.PrcCode=U_CXS_PRCD WHERE U_CXS_PRCD IS NOT NULL and RKM_LIVE_2.dbo.OPRC.PrcName Like '%" & Trim(txtCariCabang.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarCabang.DataSource = table
        dgDaftarCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarCabang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarCabang.AutoResizeColumns()

    End Sub




    Sub LoadDaftarVendor()

        Call KoneksiDatabase1()

        Dim cmd As New SqlCommand("SELECT Top 10 CardName AS NamaVendor,Address AS Alamat,Phone1 AS Telepon FROM RKM_LIVE_2.dbo.OCRD WHERE CardType='S' and RKM_LIVE_2.dbo.OCRD.CardName Like '%" & Trim(txtCariVendor.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarvendor.DataSource = table
        dgDaftarvendor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarvendor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarvendor.AutoResizeColumns()

    End Sub







    Private Sub FormBusinessPartner_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarCabang()
        LoadDaftarVendor()
    End Sub

    Private Sub txtCariCabang_TextChanged(sender As Object, e As EventArgs) Handles txtCariCabang.TextChanged
        LoadDaftarCabang()
    End Sub

    Private Sub dgDaftarCabang_Click(sender As Object, e As EventArgs) Handles dgDaftarCabang.Click

        MstrPenerima = dgDaftarCabang.Item(0, dgDaftarCabang.CurrentRow.Index).Value
        MstrAlamat = dgDaftarCabang.Item(1, dgDaftarCabang.CurrentRow.Index).Value
        Mstrtelepon = dgDaftarCabang.Item(2, dgDaftarCabang.CurrentRow.Index).Value
        Me.Close()

        If MstrNamaForm = "Surat Jalan" Then
            FormBuatSuratJalan.LoadPenerima()
        End If

        If MstrNamaForm = "Surat Serah Terima" Then
            FormBuatSuratTerima.LoadPenerima()
        End If





    End Sub

    Private Sub txtCariVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariVendor.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)

        If tombol = 13 Then
            LoadDaftarVendor()
        Else
            Exit Sub
        End If
    End Sub

 





    Private Sub dgDaftarvendor_Click(sender As Object, e As EventArgs) Handles dgDaftarvendor.Click
       
        MstrPenerima = dgDaftarvendor.Item(0, dgDaftarvendor.CurrentRow.Index).Value
        MstrAlamat = dgDaftarvendor.Item(1, dgDaftarvendor.CurrentRow.Index).Value
        Mstrtelepon = dgDaftarvendor.Item(2, dgDaftarvendor.CurrentRow.Index).Value
        Me.Close()

        If MstrNamaForm = "Surat Jalan" Then
            FormBuatSuratJalan.LoadPenerima()
        End If

        If MstrNamaForm = "Surat Serah Terima" Then
            FormBuatSuratTerima.LoadPenerima()
        End If


    End Sub

End Class