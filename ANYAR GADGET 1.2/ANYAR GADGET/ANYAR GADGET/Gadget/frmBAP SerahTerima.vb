Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmBAPSerahTerima

    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table
    Public RptDocument As New ReportDocument
    Public reportDocument As New ReportDocument()
    Public paramField As New ParameterField()
    Public paramFields As New ParameterFields()
    Public paramDiscreteValue As New ParameterDiscreteValue()
    Public paramField2 As New ParameterField()
    Public paramFields2 As New ParameterFields()
    Public paramDiscreteValue2 As New ParameterDiscreteValue()

    Public paramField3 As New ParameterField()
    Public paramFields3 As New ParameterFields()
    Public paramDiscreteValue3 As New ParameterDiscreteValue()

    Public selRow As New DataGridViewRow

    Dim intRow As Integer

    Dim userMsg As String

    Private Sub picBrowsBusinessPartner_Click(sender As Object, e As EventArgs) Handles picBrowsBusinessPartner.Click
        frmBrowseBusinessPartnerBAPSerahTerima.ShowDialog()
    End Sub


    Private Sub frmSuratJalan_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDibuatOleh.Text = MstrNamaPegawai
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
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
        frmBrowseItemMasterDataBAPSerahTerima.ShowDialog()
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


        Call AU_SISTER_SJ("CEKFIELD-BAST")

        If MstrErrorCode <> "" Then
            Exit Sub
        Else
            Call AU_SISTER_SJ("ADD-BAST")

            For Me.intRow = 0 To dgvListItem.Rows.Count - 1
                AU_SISTER_DETAILSJ("ADD-DetailSJ", dgvListItem)
            Next

        End If
        Call KoneksiDB_EMAIL()

        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
        dgvListItem.DataSource = Nothing
        dgvListItem.Rows.Clear()
        dgvListItem.Columns.Clear()

        txtSalamPembuka.Text = ""
        txtKalimatPembuka.Text = ""
        txtKalimatPenutup.Text = ""
        txtTembusan.Text = ""
        txtDitujukanKepada.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        txtNoSurat.Text = ""
       

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
            command.Parameters.AddWithValue("Reasons", Trim(userMsg))


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






    Private Sub txtCariSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSurat.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvDaftarSurat, "SELECT  NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima,CANCELED FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "'  AND (Perihal Like '%" & Trim(txtCariSurat.Text) & "%' Or DitujukanKepada Like '%" & Trim(txtCariSurat.Text) & "%' OR NomorSurat Like '%" & Trim(txtCariSurat.Text) & "%' OR EmpName Like '%" & Trim(txtCariSurat.Text) & "%' OR FORMAT(TanggalSurat,'dd-mm-yyyy') Like '%" & Trim(txtCariSurat.Text) & "%' OR FORMAT(CreateDate,'dd-mm-yyyy') Like '%" & Trim(txtCariSurat.Text) & "%' ) AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        If dgvDaftarSurat.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim(lblKodeSurat.Text)
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)

        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)



        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New BA_Serah_Terima_Anyar_Gadget_IT002_01
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")

        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub picCancel_Click(sender As Object, e As EventArgs) Handles picCancel.Click
        If dgvDaftarSurat.RowCount = 0 Then Exit Sub


        If MsgBox("Apakah Yakin Anda Akan Membatalkan Surat Ini? Nomor Surat Tidak Dapat Digunakan Kembali", vbYesNo, "Konfirmasi?!") = vbYes Then

            userMsg = Microsoft.VisualBasic.InputBox("AlasanPembatalan Surat?", "Masukan Alasan Pembatalan", "", 500, 300)

            Call AU_SISTER_SJ("CANCEL-SJ")

            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub dgvDaftarSurat_Click(sender As Object, e As EventArgs) Handles dgvDaftarSurat.Click
        If dgvDaftarSurat.RowCount = 0 Then Exit Sub
        txtNoSurat.Text = dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value
    End Sub
End Class