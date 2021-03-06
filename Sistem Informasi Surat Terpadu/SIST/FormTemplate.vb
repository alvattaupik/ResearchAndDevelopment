﻿Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormTemplate
    Dim strTempkodeJenisSurat As String
    Dim strStatusEnabled As String
    Dim strKodeJenisSurat As String
    Dim strStatusAktif As String
    Private Sub cmdbrowse_Click(sender As Object, e As EventArgs) Handles cmdbrowse.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtpathtemplate.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs)
        CariKodeJenisSurat()

        If chkStatus.Checked = True Then
            strStatusEnabled = "Y"
        Else
            strStatusEnabled = "N"
        End If

        If txtpathtemplate.Text = "" Then
            MsgBox("Path Template Tidak Boleh Kosong", vbInformation, "Penting Coyyyy!")
            Exit Sub
        End If


        If cmbJenisSurat.Text = "" Then
            MsgBox("Jenis Surat Tidak Boleh Kosong", vbInformation, "Penting Coyyyy!")
            Exit Sub
        End If


        If MsgBox("Apakah yakin Anda Akan Menyimpan Setting Ini?", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand



            cmd.CommandText = "[AUD_KonfigurasiTemplate]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("DocEntry", Trim(txtDocEntry.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(strTempkodeJenisSurat))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("PathTemplate", Trim(txtpathtemplate.Text))
            cmd.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))
            cmd.Parameters.AddWithValue("StatusSP", "A")

            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Konfigurasi Template Berhasil Disimpan", vbInformation, "Sukses")
            LoadKonfigurasiSurat()
            Bersihkan()

        Else
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub


    End Sub

    Sub LoadComboJenisSurat()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT KdJenisSurat,NamaSurat FROM dbo.JenisSurat WHERE StatusEnabled='Y'", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbJenisSurat.DataSource = ds.Tables(0)
            cmbJenisSurat.ValueMember = "KdJenisSurat"
            cmbJenisSurat.DisplayMember = "NamaSurat"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub


    Sub CariKodeJenisSurat()


        KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT KdJenisSurat From JenisSurat WHERE NamaSurat='" & Trim(cmbJenisSurat.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            strTempkodeJenisSurat = dr.GetString(0)
            dr.Close()

        Else

            dr.Close()
            strTempkodeJenisSurat = "001"
            Exit Sub
        End If


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub

    End Sub

    Sub Bersihkan()
        txtpathtemplate.Text = ""
        txtKeterangan.Text = ""
        cmbJenisSurat.Text = ""
        txtDocEntry.Text = ""
    End Sub



    Private Sub cmbJenisSurat_Click(sender As Object, e As EventArgs) Handles cmbJenisSurat.Click
        LoadComboJenisSurat()
    End Sub


    Sub LoadKonfigurasiSurat()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT * FROM V_MasterKonfigurasiSurat Where KdUser='" & Trim(MstrKodeUser) & "' And Keterangan Like'%" & Trim(txtCariSettingTemplate.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgSettingTemplate.DataSource = table
        dgSettingTemplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSettingTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSettingTemplate.AutoResizeColumns()

    End Sub


    Private Sub FormKonfigurasiCetakanSurat_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadKonfigurasiSurat()
        LoadDaftarTemplate()
    End Sub



    Private Sub dgSettingTemplate_Click(sender As Object, e As EventArgs) Handles dgSettingTemplate.Click
        txtDocEntry.Text = dgSettingTemplate.Item(4, dgSettingTemplate.CurrentRow.Index).Value
        txtpathtemplate.Text = dgSettingTemplate.Item(3, dgSettingTemplate.CurrentRow.Index).Value
        txtKeterangan.Text = dgSettingTemplate.Item(2, dgSettingTemplate.CurrentRow.Index).Value
        cmbJenisSurat.Text = dgSettingTemplate.Item(1, dgSettingTemplate.CurrentRow.Index).Value
        strStatusAktif = dgSettingTemplate.Item(0, dgSettingTemplate.CurrentRow.Index).Value

        If strStatusAktif = "1" Then
            chkStatus.Checked = True
        Else
            chkStatus.Checked = False
        End If

    End Sub


    Private Sub txtCariSettingTemplate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSettingTemplate.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        'Call NumberOnly(tombol, e)

        If tombol = 13 Then
            'LoadKonfigurasiSurat()
            LoadDaftarTemplate()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs)
        MsgBox("Anda Akan Menambahkan Konfigurasi Baru", vbInformation, "Informasi")
        txtDocEntry.Text = ""
        txtKeterangan.Text = ""
        txtpathtemplate.Text = ""
        cmbJenisSurat.Text = ""
        chkStatus.Checked = False
        Exit Sub

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub




    Sub LoadDaftarTemplate()


        On Error Resume Next


        dgSettingTemplate.DataSource = Nothing
        dgSettingTemplate.Rows.Clear()
        dgSettingTemplate.Columns.Clear()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT Aktif,JenisSurat,Keterangan,PathTemplate,DocEntry FROM V_MasterKonfigurasiSurat Where KdUser='" & Trim(MstrKodeUser) & "' And Keterangan Like'%" & Trim(txtCariSettingTemplate.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        Dim chk As New DataGridViewCheckBoxColumn()
        dgSettingTemplate.Columns.Add(chk)
        chk.HeaderText = "Aktif"
        chk.Name = "Aktif"
        chk.TrueValue = "1"
        chk.FalseValue = "0"
        dgSettingTemplate.Columns.Add("JenisSurat", "JenisSurat")
        dgSettingTemplate.Columns.Add("Keterangan", "Keterangan")
        dgSettingTemplate.Columns.Add("PathTemplate", "PathTemplate")
        'dgSettingTemplate.Columns.Add("KdJenisSurat", "KdJenisSurat")
        dgSettingTemplate.Columns.Add("DocEntry", "DocEntry")

        dgSettingTemplate.Columns(0).ReadOnly = True
        dgSettingTemplate.Columns(1).ReadOnly = True
        dgSettingTemplate.Columns(2).ReadOnly = True
        dgSettingTemplate.Columns(3).ReadOnly = True
        dgSettingTemplate.Columns(4).ReadOnly = True
        'dgSettingTemplate.Columns(5).ReadOnly = True




        With table
            For i = 0 To table.Rows.Count - 1

                dgSettingTemplate.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString(), .Rows(i).Item(3).ToString(), .Rows(i).Item(4).ToString())
            Next

            dgSettingTemplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgSettingTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgSettingTemplate.AutoResizeColumns()

        End With



    End Sub



    Private Sub cmdTambah_Click_1(sender As Object, e As EventArgs) Handles cmdTambah.Click
        txtDocEntry.Text = ""
        txtpathtemplate.Text = ""
        txtKeterangan.Text = ""
        cmbJenisSurat.Text = ""
        chkStatus.Checked = True
    End Sub

    Private Sub cmdSimpan_Click_1(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        'CariKodeJenisSurat()

        If chkStatus.Checked = True Then
            strStatusEnabled = "1"
        Else
            strStatusEnabled = "0"
        End If

        If txtpathtemplate.Text = "" Then
            MsgBox("Path Template Tidak Boleh Kosong", vbInformation, "Penting Coyyyy!")
            MsgBox("Masukan Lokasi Template!", vbInformation, "Penting Coyyyy!")
            cmdbrowse.PerformClick()
            Exit Sub
        End If


        If cmbJenisSurat.Text = "" Then
            MsgBox("Jenis Surat Tidak Boleh Kosong", vbInformation, "Penting Coyyyy!")
            Exit Sub
        End If


        If MsgBox("Apakah yakin Anda Akan Menyimpan Setting Ini?", vbYesNo, "Konfirmasi") = vbYes Then

            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand



            cmd.CommandText = "[AUD_KonfigurasiTemplate]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("DocEntry", Trim(txtDocEntry.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(cmbJenisSurat.SelectedValue))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("PathTemplate", Trim(txtpathtemplate.Text))
            cmd.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))
            cmd.Parameters.AddWithValue("StatusSP", "A")

            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Konfigurasi Template Berhasil Disimpan", vbInformation, "Sukses")
            LoadDaftarTemplate()
            Bersihkan()

        Else
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub
    End Sub

    Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
        If MsgBox("Apakah yakin anda akan menghapus konfigurasi ini?", vbYesNo, "Konfirmasi") = vbYes Then
            On Error GoTo ErrorLoad



            Call KoneksiDatabase1()
            Dim cmd As New SqlCommand
            cmd.CommandText = "[AUD_KonfigurasiTemplate]"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("DocEntry", Trim(txtDocEntry.Text))
            cmd.Parameters.AddWithValue("KdJenisSurat", Trim(strTempkodeJenisSurat))
            cmd.Parameters.AddWithValue("KdUser", Trim(MstrKodeUser))
            cmd.Parameters.AddWithValue("KdDivisi", Trim(MstrKodeDivisi))
            cmd.Parameters.AddWithValue("PathTemplate", Trim(txtpathtemplate.Text))
            cmd.Parameters.AddWithValue("Keterangan", Trim(txtKeterangan.Text))
            cmd.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))
            cmd.Parameters.AddWithValue("StatusSP", "D")

            If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
            cmd.Connection = Koneksi1
            Koneksi1.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Konfigurasi Template Berhasil Dihapus", vbInformation, "Sukses")
            LoadKonfigurasiSurat()
            Bersihkan()

        Else
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub

    End Sub
End Class