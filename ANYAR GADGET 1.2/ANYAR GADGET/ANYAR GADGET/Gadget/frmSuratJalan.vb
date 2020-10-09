Imports System.Data
Imports System.Data.SqlClient
Public Class frmSuratJalan


    Public selRow As New DataGridViewRow

    Dim intRow As Integer

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

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim row As Integer
        Dim index As Integer

        On Error Resume Next

        If dgvListItem.RowCount = 0 Then Exit Sub


        index = dgvListItem.SelectedRows.Item(0).Index
        selRow = dgvListItem.Rows.Item(index)
        dgvListItem.Rows.Remove(selRow)
        row = row - 1
        lblJumlahItem.Text = "Jumlah Item : " & dgvListItem.RowCount

    End Sub


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        If dgvListItem.RowCount = 0 Then
            DisplayPesanError("Isi Surat Min 1 Baris", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        Call AU_SISTER_SJ("CEKFIELD-SJ")

        If MstrErrorCode <> "" Then
            Exit Sub
        Else
            Call AU_SISTER_SJ("ADD-SJ")

            For Me.intRow = 0 To dgvListItem.Rows.Count - 1

                AU_SISTER_DETAILSJ("ADD-DetailSJ", dgvListItem)


            Next



        End If

    End Sub






    Sub AU_SISTER_SJ(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_SISTER_SURAT]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            command.Parameters.AddWithValue("TglSurat", dtpTglSurat.Value)
            command.Parameters.AddWithValue("KodeJenisSurat", Trim(lblKodeSurat.Text))
            command.Parameters.AddWithValue("Lampiran", Trim(txtLampiran.Text))
            command.Parameters.AddWithValue("Perihal", Trim(txtPerihal.Text))
            command.Parameters.AddWithValue("EmpID", Trim(MstrKodePegawai))
            command.Parameters.AddWithValue("EmpLocation", Trim(MstrKodeDivisi))
            command.Parameters.AddWithValue("UsernameLogin", Trim(MstrUsernameLogin))
            command.Parameters.AddWithValue("DitujukanKepada", Trim(txtDitujukanKepada.Text))
            command.Parameters.AddWithValue("NoTeleponPenerima", Trim(txtNoTelp.Text))
            command.Parameters.AddWithValue("AlamatPenerima", Trim(txtAlamat.Text))
            command.Parameters.AddWithValue("SalamPembuka", Trim(txtSalamPembuka.Text))
            command.Parameters.AddWithValue("KalimatPembuka", Trim(txtKalimatPembuka.Text))
            command.Parameters.AddWithValue("KalimatPenutup", Trim(txtKalimatPenutup.Text))
            command.Parameters.AddWithValue("Tembusan", Trim(txtTembusan.Text))
            command.Parameters.AddWithValue("Canceled", Trim(""))
            command.Parameters.AddWithValue("Reasons", Trim(""))


            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
            command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("NomorSuratOUT", SqlDbType.VarChar, 100)
            command.Parameters("NomorSuratOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))
          

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
            MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()
            txtNoSurat.Text = command.Parameters("NomorSuratOUT").Value.ToString()

            If MstrErrorCode = "E-00" Then
                DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





    Sub AU_SISTER_DETAILSJ(strFunction As String, dgvKode As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_SISTER_DETAILSURAT]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            command.Parameters.AddWithValue("KodeBarang", Trim(dgvKode.Rows(intRow).Cells(0).Value))
            command.Parameters.AddWithValue("Deskripsi", Trim(dgvKode.Rows(intRow).Cells(1).Value))
            command.Parameters.AddWithValue("Quantity", Trim(dgvKode.Rows(intRow).Cells(2).Value))
            command.Parameters.AddWithValue("Keterangan", Trim(dgvKode.Rows(intRow).Cells(3).Value))

            command.Parameters.Add("ErrorCodeOUT", SqlDbType.VarChar, 100)
            command.Parameters("ErrorCodeOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("ErrorMessageOUT", SqlDbType.VarChar, 300)
            command.Parameters("ErrorMessageOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            MstrErrorCode = command.Parameters("ErrorCodeOUT").Value.ToString()
            MstrErrorMessage = command.Parameters("ErrorMessageOUT").Value.ToString()


            If MstrErrorCode = "E-00" Then
                DisplayPesanError(MstrErrorMessage, frmMainMenu.txtPesanError, 1000)
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub




End Class