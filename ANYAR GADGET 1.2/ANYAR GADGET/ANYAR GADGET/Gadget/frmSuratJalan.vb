Public Class frmSuratJalan

   

 
  

    Private Sub picBrowsBusinessPartner_Click(sender As Object, e As EventArgs) Handles picBrowsBusinessPartner.Click
        frmBrowseBusinessPartner.ShowDialog()
    End Sub


    Private Sub frmSuratJalan_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDibuatOleh.Text = MstrNamaPegawai
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtDeskripsi.Text = "" Then
            DisplayPesanError("Deskripsi Harus Di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        dgvListItem.Rows.Add(txtKode.Text, txtDeskripsi.Text, txtQty.Text, txtKeterangan.Text)
        lblJumlahItem.Text = "Jumlah Lampiran : " & dgvListItem.RowCount
        dgvListItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListItem.AutoResizeColumns()
        txtKode.Text = ""
        txtDeskripsi.Text = ""
        txtQty.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmBrowseItemMasterData.ShowDialog()
    End Sub
End Class