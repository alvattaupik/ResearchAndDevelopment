﻿Imports System.Data.SqlClient
Public Class FormUserLoginDanHakAkses
    Dim strKodeDivisi As String
    Dim bolStatusUpdate As Boolean
    Dim bolRecordExist As Boolean
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Close()
    End Sub

    Private Sub cmbSource1_Click(sender As Object, e As EventArgs) Handles cmdSource1.Click
        MstrNamaForm = "Cari kode User"
        FormUserSAP.ShowDialog()
    End Sub

    Private Sub cmbSource2_Click(sender As Object, e As EventArgs) Handles cmdSource2.Click
        MstrNamaForm = "Cari kode SPV"
        FormUserSAP.ShowDialog()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        bolStatusUpdate = False
        txtKodeSPV.Text = ""
        txtKodeUser.Text = ""
        txtNamaLengkap.Text = ""
        txtNamaSPV.Text = ""
        cmbLevelUser.Text = ""
        txtusername.Text = ""
        txtPassword.Text = ""
        chkAktif.Checked = True
        cmbDivisi.Text = ""
        cmbLevelUser.Text = ""
        txtKodeUser.Enabled = True
    End Sub

    Sub LoadDaftarUserSAP()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("Select * from V_DaftarUserAplikasi Where KodeAplikasi ='" & MstrNamaAplikasi & "'", Koneksi1)

        cmd.CommandTimeout = 0


        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarUserAplikasi.DataSource = table
        dgDaftarUserAplikasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUserAplikasi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUserAplikasi.AutoResizeColumns()


    End Sub


    Private Sub FormUserLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarUserSAP()
    End Sub

    Private Sub txtCariUser_TextChanged(sender As Object, e As EventArgs) Handles txtCariUser.TextChanged
        LoadDaftarUserSAP()
    End Sub




    Sub LoadComboDivisi()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT * FROM dbo.V_Divisi WHERE KodeDivisi NOT LIKE '%Centr%'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbDivisi.DataSource = ds.Tables(0)
            cmbDivisi.ValueMember = "KodeDivisi"
            cmbDivisi.DisplayMember = "NamaDivisi"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Sub CariKodeDivisi()


        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT KodeDivisi,NamaDivisi from V_Divisi WHERE NamaDivisi='" & Trim(cmbDivisi.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strKodeDivisi = dr.GetString(0)
            dr.Close()

        Else

            dr.Close()
            strKodeDivisi = "001"
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub

    Private Sub dgDaftarUserAplikasi_Click(sender As Object, e As EventArgs) Handles dgDaftarUserAplikasi.Click
        bolStatusUpdate = True
        txtKodeUser.Enabled = False
        LoadDetailUser()
    End Sub

    Private Sub cmbDivisi_Click1(sender As Object, e As EventArgs) Handles cmbDivisi.Click
        LoadComboDivisi()

    End Sub


    Sub LoadDetailUser()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String
        Dim strStatusAktif As String

        strSQlLogin = "SELECT * FROM dbo.V_DataUser WHERE KodePegawai='" & Trim(dgDaftarUserAplikasi.Item(0, dgDaftarUserAplikasi.CurrentRow.Index).Value) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtKodeUser.Text = dr.GetString(0)
            txtNamaLengkap.Text = dr.GetString(1)
            cmbDivisi.Text = dr.GetString(3)
            txtNamaDivisi.Text = dr.GetString(4)
            cmbLevelUser.Text = dr.GetString(9)
            txtKodeSPV.Text = dr.GetString(5)
            txtNamaSPV.Text = dr.GetString(6)
            txtusername.Text = dr.GetString(7)
            txtPassword.Text = dr.GetString(8)
            strStatusAktif = dr.GetString(10)

            If strStatusAktif = "Y" Then
                chkAktif.Checked = True
            Else
                chkAktif.Checked = False
            End If




        Else

            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub



    Private Sub cmbDivisi_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDivisi.SelectedValueChanged
        txtNamaDivisi.Text = Microsoft.VisualBasic.Left(cmbDivisi.Text, 3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call ClearTextBoxes(Me)
        Me.Dispose()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        On Error GoTo ErrorLoad
        If txtKodeUser.Text = "" Then
            MsgBox("Kode Pegawai Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtNamaLengkap.Text = "" Then
            MsgBox("Nama Pegawai Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtKodeSPV.Text = "" Then
            MsgBox("Kode SPV Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If


        If txtNamaSPV.Text = "" Then
            MsgBox("Nama SPV Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtusername.Text = "" Then
            MsgBox("Username Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtusername.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", vbCritical, "Penting!")
            Exit Sub
        End If



        If bolStatusUpdate = True Then
            'Call KoneksiDatabase1()
            'strSQL = "SELECT * FROM dbo.V_DataUser WHERE UserNameLogin='" & Trim(txtusername.Text) & "'"
            'cmd = New SqlCommand(strSQL, Koneksi1)
            'dr = cmd.ExecuteReader
            'dr.Read()

            AUD_UserLogin("U")

            MsgBox("Data user Berhasil Di Update", vbInformation, "Sukses ")
            Exit Sub
        End If



        If bolStatusUpdate = False Then
            CekKodePegawai()

            If bolRecordExist = True Then
                Exit Sub
            End If
            AUD_UserLogin("A")
            MsgBox("Data user Berhasil Di Simpan", vbInformation, "Sukses ")
            Exit Sub
        End If





        Exit Sub
ErrorLoad:
        MsubPesanError()

    End Sub


    Sub CekKodePegawai()
        Call KoneksiDatabase1()
        strSQlLogin = "SELECT * FROM dbo.V_DataUser WHERE KodePegawai='" & Trim(txtKodeUser.Text) & "' AND KodeAplikasi='AG'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Kode Pegawai Sudah Dipakai", vbCritical, "Warning!")
            bolRecordExist = True
            Exit Sub
        Else
            bolRecordExist = False
            Exit Sub
        End If
    End Sub




    Sub CekUserName()
        Call KoneksiDatabase1()
        strSQlLogin = "SELECT * FROM dbo.V_DataUser WHERE UserNameLogin='" & Trim(txtusername.Text) & "' "
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Ganti Username, Username Sudah Digunakan", vbCritical, "Warning!")
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub
    Sub CekPassword()
        Call KoneksiDatabase1()
        strSQlLogin = "SELECT * FROM dbo.V_DataUser WHERE UsernamePasswordLogin='" & Trim(txtPassword.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MsgBox("Password Sudah Dipakai", vbCritical, "Warning!")
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub


    Sub AUD_UserLogin(strSTatusSP As String)

        'Dim strStatusSp As String

        'If bolStatusUpdate = True Then
        '    strStatusSp = "U"
        'Else
        '    strStatusSp = "A"
        'End If

        On Error GoTo ErrorLoad
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[AUD_DataPegawai]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("KodePegawai", Trim(txtKodeUser.Text))
        cmd.Parameters.AddWithValue("NamaPegawai", Trim(txtNamaLengkap.Text))
        cmd.Parameters.AddWithValue("NamaDivisi", Trim(cmbDivisi.Text))
        cmd.Parameters.AddWithValue("KdSupervisor", Trim(txtKodeSPV.Text))
        cmd.Parameters.AddWithValue("NamaSupervisor", Trim(txtNamaSPV.Text))
        cmd.Parameters.AddWithValue("LevelUser", Trim(cmbLevelUser.Text))
        cmd.Parameters.AddWithValue("Username", Trim(txtusername.Text))
        cmd.Parameters.AddWithValue("Password", Trim(txtPassword.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim(chkAktif.CheckState))
        cmd.Parameters.AddWithValue("KodeAplikasi", Trim(MstrNamaAplikasi))
        cmd.Parameters.AddWithValue("StatusSP", Trim(strStatusSp))

        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()
        LoadDaftarUserSAP()

        Exit Sub



ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub


    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        If txtKodeUser.Text = "" Then
            MsgBox("Tidak Ada User Yang Dipilih", vbInformation, "Informasi")
            Exit Sub
        End If

        FormDetailHakAkses.ShowDialog()
    End Sub

    Private Sub FormUserLoginDanHakAkses_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub FormUserLoginDanHakAkses_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

    Private Sub cmbLevelUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevelUser.SelectedIndexChanged
        If cmbLevelUser.Text = "SPV" Then
            txtKodeSPV.Text = "MAN"
            txtNamaSPV.Text = "MANAGEMENT"
        Else
            txtKodeSPV.Text = ""
            txtNamaSPV.Text = ""
        End If
    End Sub
End Class