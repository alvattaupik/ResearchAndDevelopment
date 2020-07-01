Imports System.Data.SqlClient
Public Class FormAddControl
    Dim strSQL As String

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        txtKodeValidasi.Text = ""
        txtKodeJenis.Text = ""
        cmbLokasi.Text = ""
        txtNamaValidasi.Text = ""
        txtJenisOperasi.Text = ""
        txtFungsi.Text = ""
        txtNotifikasi.Text = ""

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

        KoneksiDatabase2()
        strSQL = "SELECT * FROM dbo.V_DaftarKontrolValidasi WHERE KodeCabang='" & cmbLokasi.SelectedValue & "' AND KodeValidasi='" & txtKodeValidasi.Text & "'"
        cmd = New SqlCommand(strSQL, Koneksi2)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Perhatian! " & vbCrLf & "Validasi :" & dr.GetString(0) & vbCrLf & "Untuk Cabang :" & dr.GetString(1) & vbCrLf & "Sudah Ada Dalam Database!", vbInformation)
            Exit Sub
        Else

            AUD_Validasi()

            cmdNew.Visible = True


        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub


    Sub AUD_Validasi()


        Call KoneksiDatabase2()
        Dim cmd As New SqlCommand



        cmd.CommandText = "[_tmsp_AUD_MasterValidasi]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
        cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
        cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(txtKodeJenis.Text))
        cmd.Parameters.AddWithValue("KodeCabang", Trim(cmbLokasi.SelectedValue))
        cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtNamaValidasi.Text))
        cmd.Parameters.AddWithValue("Operation", Trim(txtJenisOperasi.Text))
        cmd.Parameters.AddWithValue("Fungsi", Trim(txtFungsi.Text))
        cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
        cmd.Parameters.AddWithValue("Status", "A")


        If (Koneksi2.State = ConnectionState.Open) Then Koneksi2.Close()
        cmd.Connection = Koneksi2
        Koneksi2.Open()
        cmd.ExecuteNonQuery()

        MainMenu.LoadMasterValidasi()

        MsgBox("Kontrol Baru Berhasil Ditambahkan", vbInformation, "Sukses!")

    End Sub




    Sub AUD_Validasi2()


        Call KoneksiDatabase2()
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
        cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
        cmd.Parameters.AddWithValue("Status", "A")


        If (Koneksi2.State = ConnectionState.Open) Then Koneksi2.Close()
        cmd.Connection = Koneksi2
        Koneksi2.Open()
        cmd.ExecuteNonQuery()

        MainMenu.LoadMasterValidasi()

        MsgBox("Kontrol Baru Berhasil Ditambahkan", vbInformation, "Sukses!")

    End Sub








    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        FormCariKomponenSAP.ShowDialog()
    End Sub

    Private Sub cmbLokasi_Click(sender As Object, e As EventArgs) Handles cmbLokasi.Click
        LoadComboBox2(cmbLokasi, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode LIKE '%0%'", "PrcCode", "PrcName")
    End Sub




    Sub LoadMasterCabang()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode LIKE '%0%' AND PrcCode NOT IN	('002','110')", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgAllCabang.DataSource = table
        dgAllCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgAllCabang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgAllCabang.AutoResizeColumns()

    End Sub






    Private Sub cmdSaveAll_Click(sender As Object, e As EventArgs) Handles cmdSaveAll.Click
        On Error GoTo ErrorLoad

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

        KoneksiDatabase2()
        strSQL = "SELECT * FROM dbo.V_DaftarKontrolValidasi WHERE KodeValidasi='" & txtKodeValidasi.Text & "'"
        cmd = New SqlCommand(strSQL, Koneksi2)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Perhatian! " & vbCrLf & "Validasi :" & dr.GetString(0) & vbCrLf & "Untuk Cabang :" & dr.GetString(1) & vbCrLf & "Sudah Ada Dalam Database!", vbInformation)
            Exit Sub
        Else


            If MsgBox("Anda Akan Menerapkan Kontrol Validasi Berikut Untuk Semua Lokasi/Cabang", vbYesNo, "Lanjutkan?") = vbYes Then



                For i As Integer = 0 To dgAllCabang.Rows.Count - 1

                    Call KoneksiDatabase2()
                    Dim cmd As New SqlCommand



                    cmd.CommandText = "[_tmsp_AUD_MasterValidasi]"
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("Docnum", Trim(txtDocNum.Text))
                    cmd.Parameters.AddWithValue("KodeValidasi", Trim(txtKodeValidasi.Text))
                    cmd.Parameters.AddWithValue("kdJnsValidasi", Trim(txtKodeJenis.Text))
                    cmd.Parameters.AddWithValue("KodeCabang", Trim(dgAllCabang.Rows(i).Cells(0).Value))
                    cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtNamaValidasi.Text))
                    cmd.Parameters.AddWithValue("Operation", Trim(txtJenisOperasi.Text))
                    cmd.Parameters.AddWithValue("Fungsi", Trim(txtFungsi.Text))
                    cmd.Parameters.AddWithValue("Notifikasi", Trim(txtNotifikasi.Text))
                    cmd.Parameters.AddWithValue("StatusEnabled", Trim("1"))
                    cmd.Parameters.AddWithValue("Status", "A")


                    If (Koneksi2.State = ConnectionState.Open) Then Koneksi2.Close()
                    cmd.Connection = Koneksi2
                    Koneksi2.Open()
                    cmd.ExecuteNonQuery()

                Next
                Koneksi2.Close()
                cmdNew.Visible = True
                MainMenu.LoadMasterValidasi()
                MainMenu.LoadUnlockControl()
                MsgBox("Kontrol Validasi Baru Untuk All Cabang Berhasil Disimpan", vbInformation, "Sukses!")
                Exit Sub


            Else
                Exit Sub
            End If



        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub














    End Sub

    Private Sub FormAddControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMasterCabang()
    End Sub
End Class