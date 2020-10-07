Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Sockets

Public Class frmPromoPromo
    Dim source1 As New BindingSource()
    Private myBindingSource As New BindingSource() 'for the datagridview atm
    Sub PromoAKtif()

        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[_tmspCekListPromoDiskonIvend]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("Kode", "-")
        command.Parameters.AddWithValue("Deskripsi", "-")
        command.Parameters.AddWithValue("Function", "Active")

        If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
        command.Connection = KoneksiIvend
        KoneksiIvend.Open()
        command.ExecuteNonQuery()

        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvListPromoAktif.DataSource = myBindingSource

        'Dim view1 As New DataView(table)

        'dgvListPromoAktif.DataSource = view1
        'dgvListPromoAktif.Refresh()
        'source1.DataSource = view1

        ''Me.dgvListPromoAktif.DataSource = table
        'dgvListPromoAktif.DataSource = table
        dgvListPromoAktif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListPromoAktif.AutoResizeColumns()
        dgvListPromoAktif.RowHeadersVisible = False
        lblJumlahPromoAktif.Text = "Jumlah Promo Aktif : " & dgvListPromoAktif.RowCount

    End Sub



    Private Sub frmPromoPromo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call PromoAKtif()
    End Sub






    Sub ApplicableTo()

        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[tmsp_ListApplicableBonusBuys]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("PromotionKey", dgvListPromoAktif.Item(4, dgvListPromoAktif.CurrentRow.Index).Value)
        If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
        command.Connection = KoneksiIvend
        KoneksiIvend.Open()
        command.ExecuteNonQuery()

        panelApplicable.Visible = True
        Dim table As New DataTable
        adapter.Fill(table)

        Me.dgvListApplicable.DataSource = table
        dgvListApplicable.DataSource = table
        dgvListApplicable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListApplicable.AutoResizeColumns()
        dgvListApplicable.RowHeadersVisible = False
    End Sub


    Private Sub btnBerlakuUntuk_Click(sender As Object, e As EventArgs) Handles btnBerlakuUntuk.Click
        If dgvListPromoAktif.Rows.Count = 0 Then Exit Sub
        ApplicableTo()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        panelApplicable.Visible = False
    End Sub
    Private Sub txtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKode.KeyPress

        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            Me.myBindingSource.Filter = "Kode like '%" & txtKode.Text & "%'"
            'source1.Filter = "Kode like '%" & txtKode.Text & "%' Or Description like '" & txtNamaPromo.Text & "%'"
            dgvListPromoAktif.Refresh()
        End If
        Exit Sub

ErrorHandler:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub


    End Sub

  
    Private Sub txtNamaPromo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPromo.KeyPress

        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            Me.myBindingSource.Filter = "Description like '%" & txtNamaPromo.Text & "%'"
            'source1.Filter = "Kode like '%" & txtKode.Text & "%' Or Description like '" & txtNamaPromo.Text & "%'"
            dgvListPromoAktif.Refresh()
        End If
        Exit Sub

ErrorHandler:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub

    End Sub

 
   
    Private Sub btnCekPromoItems_Click(sender As Object, e As EventArgs)

    End Sub


End Class