Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmMonitoringAndControlling

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



    Private Sub cmbCabangDaftarAsset_Click(sender As Object, e As EventArgs) Handles cmbCabangDaftarAsset.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabangDaftarAsset, "Select PrcCode,PrcName From OPRC WHere PrcCode NOT Like 'Centr%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub


    Private Sub cmbkategori_Click(sender As Object, e As EventArgs) Handles cmbkategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbkategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE IDCategories='" & cmbkategori.SelectedValue & "' AND StatusEnabled='Y'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub



    Sub LoadListAsset()

        Dim strQuery2 As String = "SELECT ItemCode,ItemName,Spesifikasi,ID FROM dbo.OAssetsManagement Where KodeCabang='" & cmbCabangDaftarAsset.SelectedValue & "' AND IDCategories='" & cmbkategori.SelectedValue & "' AND IDSub ='" & cmbSubKategori.SelectedValue & "'"

        Try
            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvListAsset, strQuery2, KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub



    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        LoadListAsset()
    End Sub

    Private Sub btnAssesment_Click(sender As Object, e As EventArgs) Handles btnAssesment.Click
        If dgvListAsset.RowCount = 0 Then
            DisplayPesanError("Tidak Ada Kode Asset Yang Dipilih, Silahkan Isi Parameter", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        dgvDaftarAssesment.DataSource = Nothing
        dgvDaftarAssesment.Rows.Clear()
        dgvDaftarAssesment.Columns.Clear()
        txtKodeBarang.Text = dgvListAsset.Item(0, dgvListAsset.CurrentRow.Index).Value
        txtNamaBarang.Text = dgvListAsset.Item(1, dgvListAsset.CurrentRow.Index).Value
        txtSpesifikasi.Text = dgvListAsset.Item(2, dgvListAsset.CurrentRow.Index).Value
        BuatParameterUji("Buat-Parameter")
    End Sub



    Sub BuatParameterUji(strFunction As String)
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_BuatParameterUji]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("Kategori", Trim(cmbkategori.SelectedValue))
            command.Parameters.AddWithValue("SubKategori", Trim(cmbSubKategori.SelectedValue))
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




            Dim table As New DataTable
            adapter.Fill(table)
            dgvDaftarAssesment.Columns.Add("ParameterUji", "ParameterUji")

            Dim chk As New DataGridViewCheckBoxColumn()
            dgvDaftarAssesment.Columns.Add(chk)
            chk.HeaderText = "Kondisi"
            chk.Name = "Kondisi"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgvDaftarAssesment.Columns.Add("Skor", "Skor")
            dgvDaftarAssesment.Columns.Add("Catatan", "Catatan")
            dgvDaftarAssesment.Columns.Add("Indikator", "Indikator")

            dgvDaftarAssesment.Columns(0).ReadOnly = True
            dgvDaftarAssesment.Columns(1).ReadOnly = False
            dgvDaftarAssesment.Columns(2).ReadOnly = False
            dgvDaftarAssesment.Columns(3).ReadOnly = False
            dgvDaftarAssesment.Columns(4).ReadOnly = True

            With table
                For i = 0 To table.Rows.Count - 1
                    dgvDaftarAssesment.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString(), .Rows(i).Item(3).ToString(), .Rows(i).Item(4).ToString())
                Next

            End With




        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub




    Sub AU_SISTER(strFunction As String, strReason As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_SISTER_SURAT]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            command.Parameters.AddWithValue("TglSurat", dtpTglSurat.Value)
            command.Parameters.AddWithValue("KodeJenisSurat", Trim(lblKodeJenisSurat.Text))
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
            command.Parameters.AddWithValue("Reasons", Trim(strReason))


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


                For Me.intRow = 0 To dgvDaftarAssesment.Rows.Count - 1

                    ADD_DETAILASSESMENT("ADD-DetailAssesment", dgvDaftarAssesment)

                Next


            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub




    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dgvDaftarAssesment.RowCount = 0 Then
            DisplayPesanError("Tidak Ada Parameter Uji, Silahkan Pilih Asset dan tekan tombol LAKUKAN ASSESMENT", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        Call AU_SISTER("ADD-MONITORING", "")

        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeJenisSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

        dgvDaftarAssesment.DataSource = Nothing
        dgvDaftarAssesment.Rows.Clear()
        dgvDaftarAssesment.Columns.Clear()

        txtSalamPembuka.Text = ""
        txtKalimatPembuka.Text = ""
        txtKalimatPenutup.Text = ""
        txtTembusan.Text = ""
        txtDitujukanKepada.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        txtNoSurat.Text = ""


    End Sub


    Sub ADD_DETAILASSESMENT(strFunction As String, dgvKode As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_DETAIL_ASSESMENT]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            command.Parameters.AddWithValue("ItemCode", Trim(txtKodeBarang.Text))
            command.Parameters.AddWithValue("IDCategori", Trim(cmbkategori.SelectedValue))
            command.Parameters.AddWithValue("IDSubKategori", Trim(cmbSubKategori.SelectedValue))
            command.Parameters.AddWithValue("ParameterUji", Trim(dgvKode.Rows(intRow).Cells(0).Value))
            command.Parameters.AddWithValue("Indikator", Trim(dgvKode.Rows(intRow).Cells(4).Value))
            command.Parameters.AddWithValue("Kondisi", Trim(dgvKode.Rows(intRow).Cells(1).Value))
            command.Parameters.AddWithValue("Skor", Trim(dgvKode.Rows(intRow).Cells(2).Value))
            command.Parameters.AddWithValue("Catatan", Trim(dgvKode.Rows(intRow).Cells(3).Value))

            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub


    Private Sub picBrowsBusinessPartner_Click(sender As Object, e As EventArgs) Handles picBrowsBusinessPartner.Click
        frmBrowseBusinessPartnerMonitoring.ShowDialog()
    End Sub

    Private Sub frmMonitoringAndControlling_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDibuatOleh.Text = MstrNamaPegawai
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeJenisSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
    End Sub

    Private Sub picPrint_Click(sender As Object, e As EventArgs) Handles picPrint.Click
        If dgvDaftarSurat.RowCount = 0 Then Exit Sub
        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim(lblKodeJenisSurat.Text)
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)

        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)




        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New MaintenanceForm
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
            LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeJenisSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

        Else
            Exit Sub
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
            command.Parameters.AddWithValue("KodeJenisSurat", Trim(lblKodeJenisSurat.Text))
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

    Private Sub dgvDaftarSurat_Click(sender As Object, e As EventArgs) Handles dgvDaftarSurat.Click
        txtNoSurat.Text = dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value
    End Sub
End Class