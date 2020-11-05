Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class frmLainnya



    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode Like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cmbCabang.SelectedValue = ""
        cmbCabang.Text = ""
        cmbKategori.Text = ""
        cmbKategori.SelectedValue = ""
        txtDeskripsi.Text = ""
        txtRef.Text = ""
        txtQty.Text = ""
        txtKeterangan.Text = ""
        txtKode.Text = ""

        btnProses.Text = "Proses"

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        If btnProses.Text = "Ok" Then Me.Dispose()

        If cmbKategori.Text = "" Or cmbKategori.SelectedValue = "" Then
            DisplayPesanError("kategori Koreksi harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If txtRef.Text = "" Then
            DisplayPesanError("Referensi harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If txtKode.Text = "" Then
            DisplayPesanError("Kode Barang harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If txtQty.Text = "" Then
            DisplayPesanError("Quantity Barang harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If txtKeterangan.Text = "" Then
            DisplayPesanError("Keterangan Koreksi harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If cmbCabang.Text = "" Or cmbCabang.SelectedValue = "" Then
            DisplayPesanError("Cabang harus di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        Add_Koreksi()

    End Sub

    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT Cast(ID As Varchar(100)) As ID,Deskripsi FROM dbo.OVMCategories Where StatusEnabled='Y'", "ID", "Deskripsi", KoneksiDBEmail)
    End Sub




    Sub Add_Koreksi()

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[Add_KoreksiStok_VM]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtRef.Text))
            command.Parameters.AddWithValue("EmpName", Trim(MstrNamaPegawai))
            command.Parameters.AddWithValue("KodeBarang", Trim(txtKode.Text))
            command.Parameters.AddWithValue("Deskripsi", Trim(txtDeskripsi.Text))
            command.Parameters.AddWithValue("Quantity", Trim(txtQty.Text))
            command.Parameters.AddWithValue("Cabang", Trim(cmbCabang.SelectedValue))
            command.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            command.Parameters.AddWithValue("JenisKoreksi", Trim(cmbKategori.SelectedValue))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

            cmbCabang.SelectedValue = ""
            cmbCabang.Text = ""
            cmbKategori.Text = ""
            cmbKategori.SelectedValue = ""
            txtDeskripsi.Text = ""
            txtRef.Text = ""
            txtQty.Text = ""
            txtKeterangan.Text = ""
            txtKode.Text = ""

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmBrowseItemMasterDataKoreksi.ShowDialog()
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

  
End Class