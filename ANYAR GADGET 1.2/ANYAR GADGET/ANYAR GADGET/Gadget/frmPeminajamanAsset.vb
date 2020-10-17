Imports System.Data.Sql
Imports System.Data.SqlClient

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPeminajamanAsset
    Public selRow As New DataGridViewRow
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


    Dim userMsg As String
    Dim intRow As Integer
    Private Sub picBrowseAssets_Click(sender As Object, e As EventArgs) Handles picBrowseAssets.Click
        frmBrowseItemMasterDataPeminjamanAsset.ShowDialog()
    End Sub


    Private Sub btnSimpanKeDaftar_Click(sender As Object, e As EventArgs) Handles btnSimpanKeDaftar.Click
        If txtItemCode.Text = "" Then
            DisplayPesanError("Item Code Is Required!", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        ElseIf txtCatatan.Text = "" Then
            DisplayPesanError("Catatan Is Required!", frmMainMenu.txtPesanError, 1000)
        Else


            Dim IsFound As Boolean = False
            For Each row As DataGridViewRow In dgvListAssetYangDipinjam.Rows
                For i As Integer = 0 To dgvListAssetYangDipinjam.Columns.Count - 1
                    If row.Cells(i).Value.ToString = txtItemCode.Text Then
                        IsFound = True
                        Exit For
                    End If
                Next
            Next
            If (IsFound) Then
                DisplayPesanError("Item Sudah Ada dalam Daftar Pinjam", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            Else
                dgvListAssetYangDipinjam.Rows.Add(txtItemCode.Text, txtItemName.Text, txtSpesifikasi.Text, dtpAwal.Value, dtpAkhir.Value, txtCatatan.Text)
                DisplayPesanOK("Successfully Add", frmMainMenu.txtPesanError, 1000)
            End If
        End If


    End Sub

    Private Sub frmPeminajamanAsset_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtDibuatOleh.Text = MstrNamaPegawai
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopPeminjaman Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dgvListAssetYangDipinjam.RowCount = 0 Then
            DisplayPesanError("Isi Surat Min 1 Baris", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        Call AU_PEMINJAMAN("ADD-PEMINJAMAN")

        
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopSurat Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

        dgvListAssetYangDipinjam.DataSource = Nothing
        dgvListAssetYangDipinjam.Rows.Clear()
        'dgvListAssetYangDipinjam.Columns.Clear()

        'txtSalamPembuka.Text = ""
        'txtKalimatPembuka.Text = ""
        'txtKalimatPenutup.Text = ""
        'txtTembusan.Text = ""
        'txtDitujukanKepada.Text = ""
        'txtAlamat.Text = ""
        'txtNoTelp.Text = ""
        txtNoSurat.Text = ""

    End Sub


    Sub AU_PEMINJAMAN(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_PEMINJAMAN]", KoneksiDBEmail)

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
            command.Parameters.AddWithValue("EmpIDProcess", Trim(""))
            command.Parameters.AddWithValue("DocStatus", Trim(""))
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
                Exit Sub
            Else
                DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

                For Me.intRow = 0 To dgvListAssetYangDipinjam.Rows.Count - 1
                    AU_DETAIL_PEMINJAMAN("ADD-DetailPinjam", dgvListAssetYangDipinjam)
                Next


            End If

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopPeminjaman Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub




    Sub AU_DETAIL_PEMINJAMAN(strFunction As String, dgvKode As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AU_DETAIL_PEMINJAMAN]", KoneksiDBEmail)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("NomorSurat", Trim(txtNoSurat.Text))
            command.Parameters.AddWithValue("ItemCode", Trim(dgvKode.Rows(intRow).Cells(0).Value))
            command.Parameters.AddWithValue("ItemName", Trim(dgvKode.Rows(intRow).Cells(1).Value))
            command.Parameters.AddWithValue("Spesifikasi", Trim(dgvKode.Rows(intRow).Cells(2).Value))
            command.Parameters.AddWithValue("FromDate", Trim(dgvKode.Rows(intRow).Cells(3).Value))
            command.Parameters.AddWithValue("ToDate", Trim(dgvKode.Rows(intRow).Cells(4).Value))
            command.Parameters.AddWithValue("Catatan", Trim(dgvKode.Rows(intRow).Cells(5).Value))
            command.Parameters.AddWithValue("StatusPinjam", Trim(""))
            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





    Private Sub picCancel_Click(sender As Object, e As EventArgs) Handles picCancel.Click
        If dgvDaftarSurat.RowCount = 0 Then Exit Sub

        'txtNoSurat.Text = dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value

        If MsgBox("Apakah Yakin Anda Akan Membatalkan Surat Ini? Nomor Surat Tidak Dapat Digunakan Kembali", vbYesNo, "Konfirmasi?!") = vbYes Then

            userMsg = Microsoft.VisualBasic.InputBox("AlasanPembatalan Surat?", "Masukan Alasan Pembatalan", "", 500, 300)

            Call AU_PEMINJAMAN("CANCEL-PEMINJAMAN")
            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopPeminjaman Where EmpLocation='" & MstrKodeDivisi & "' AND Canceled='N' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)

        Else
            Exit Sub
        End If
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
        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField2.CurrentValues.Add(paramDiscreteValue3)

        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New FormPeminjamanAsset_Anyar_Gadget_IT006_01
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")

        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()


    End Sub

    Private Sub dgvDaftarSurat_Click(sender As Object, e As EventArgs) Handles dgvDaftarSurat.Click
        txtNoSurat.Text = dgvDaftarSurat.Item(0, dgvDaftarSurat.CurrentRow.Index).Value
    End Sub

    Private Sub txtCariSurat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSurat.KeyPress

        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvDaftarSurat, "SELECT Top 15 NomorSurat,CAST(TanggalSurat AS DATE) AS TglSurat,EmpName AS DibuatOleh,Perihal,DitujukanKepada AS Penerima FROM dbo.KopPeminjaman Where EmpLocation='" & MstrKodeDivisi & "' AND KdJenisSurat='" & lblKodeSurat.Text & "' Order By CreateDate Desc", KoneksiDBEmail)
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

        
    End Sub

    Private Sub btnHapusDariDaftarPinjam_Click(sender As Object, e As EventArgs) Handles btnHapusDariDaftarPinjam.Click
        Dim row As Integer
        Dim index As Integer

        On Error Resume Next

        If dgvListAssetYangDipinjam.RowCount = 0 Then Exit Sub


        index = dgvListAssetYangDipinjam.SelectedRows.Item(0).Index
        selRow = dgvListAssetYangDipinjam.Rows.Item(index)
        dgvListAssetYangDipinjam.Rows.Remove(selRow)
        row = row - 1
        lblJumlahItem.Text = "Jumlah Item : " & dgvListAssetYangDipinjam.RowCount
    End Sub
End Class