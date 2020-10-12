Imports System.Data.SqlClient
Public Class frmAddNewControl
    Dim intRow As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmBrowseKomponenSAP.ShowDialog()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtKodeValidasi.Text = "" Then
            MsgBox("Kode Validasi Harus Di Isi", vbInformation, "Penting !")
            txtKodeValidasi.BackColor = Color.Yellow
            Exit Sub
        End If


        If txtNamaValidasi.Text = "" Then
            MsgBox("Nama Validasi Harus Di Isi", vbInformation, "Penting !")
            txtNamaValidasi.BackColor = Color.Yellow
            Exit Sub
        End If



        If txtFungsi.Text = "" Then
            MsgBox("Fungsi Validasi Harus Di Isi", vbInformation, "Penting !")
            txtFungsi.BackColor = Color.Yellow
            Exit Sub
        End If

        If txtNotifikasi.Text = "" Then
            MsgBox("Notifikasi Validasi Harus Di Isi", vbInformation, "Penting !")
            txtNotifikasi.BackColor = Color.Yellow
            Exit Sub
        End If


        If cmbLokasi.Text = "" Then
            MsgBox("Lokasi Kontrol Harus Di Isi", vbInformation, "Penting !")
            cmbLokasi.BackColor = Color.Yellow
            Exit Sub
        End If



        On Error GoTo ErrorLoad

        Koneksi_SAP()
        Dim strSQL As String = "SELECT * FROM dbo.V_DaftarKontrolValidasi WHERE KodeCabang='" & cmbLokasi.SelectedValue & "' AND KodeValidasi='" & txtKodeValidasi.Text & "'"
        cmd = New SqlCommand(strSQL, KoneksiSAP)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Perhatian! " & vbCrLf & "Validasi :" & dr.GetString(0) & vbCrLf & "Untuk Cabang :" & dr.GetString(1) & vbCrLf & "Sudah Ada Dalam Database!", vbInformation)
            Exit Sub
        Else

            Call AUD_Validasi("ADD SINGLE")


        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



    Sub AUD_Validasi(strStatusSP As String)

        Try
            Call Koneksi_SAP()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[_tmsp_AUD_MasterValidasi2]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
            cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
            cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(txtKodeJenis.Text))
            cmd.Parameters.AddWithValue("KodeCabang", Trim(cmbLokasi.SelectedValue))
            cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtNamaValidasi.Text))
            cmd.Parameters.AddWithValue("Operation", Trim(txtJenisOperasi.Text))
            cmd.Parameters.AddWithValue("Fungsi", Trim(txtFungsi.Text))
            cmd.Parameters.AddWithValue("Ref", Trim(""))
            cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
            cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaPegawai))
            cmd.Parameters.AddWithValue("Catatan", Trim(""))
            cmd.Parameters.AddWithValue("Status", strStatusSP)

            If (KoneksiSAP.State = ConnectionState.Open) Then KoneksiSAP.Close()
            cmd.Connection = KoneksiSAP
            KoneksiSAP.Open()
            cmd.ExecuteNonQuery()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)


        Catch ex As Exception
            DisplayPesanOK(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub



    Sub AUD_Validasi2(strStatusSP As String)

        Try
            Call Koneksi_SAP()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[_tmsp_AUD_MasterValidasi2]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
            cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
            cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(txtKodeJenis.Text))
            cmd.Parameters.AddWithValue("KodeCabang", Trim(dgvListCabang.Rows(intRow).Cells(0).Value))
            cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtNamaValidasi.Text))
            cmd.Parameters.AddWithValue("Operation", Trim(txtJenisOperasi.Text))
            cmd.Parameters.AddWithValue("Fungsi", Trim(txtFungsi.Text))
            cmd.Parameters.AddWithValue("Ref", Trim(""))
            cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
            cmd.Parameters.AddWithValue("NamaUser", Trim(MstrNamaPegawai))
            cmd.Parameters.AddWithValue("Catatan", Trim(""))
            cmd.Parameters.AddWithValue("Status", strStatusSP)

            If (KoneksiSAP.State = ConnectionState.Open) Then KoneksiSAP.Close()
            cmd.Connection = KoneksiSAP
            KoneksiSAP.Open()
            cmd.ExecuteNonQuery()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)


        Catch ex As Exception
            DisplayPesanOK(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub



    Private Sub cmbLokasi_Click(sender As Object, e As EventArgs) Handles cmbLokasi.Click
        Koneksi_SAP()
        LoadComboBox(cmbLokasi, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode LIKE '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub cmdSaveAll_Click(sender As Object, e As EventArgs) Handles cmdSaveAll.Click
        For intRow = 0 To dgvListCabang.Rows.Count - 1

            Call AUD_Validasi2("ADD SINGLE")
        Next
    End Sub

    Private Sub frmAddNewControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi_SAP()
        LoadDataGrid(dgvListCabang, "select PrcCode from OPRC Where PrcCode like '0%'", KoneksiSAP)
    End Sub
End Class