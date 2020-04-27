﻿Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormManagementApproval


    Sub LoadDaftarRequestValidasiBelumApproved()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,NamaUser AS RequestName,Pesan AS PesanUser,CreateDate,JenisRequest,Komponen,JenisValidasi FROM dbo.V_DetailValidasi WHERE StatusApproval='Belum DiApprove' AND KodeSPV in ('" & MstrKdSupervisor & "','-','" & GlobalstrKodeUser & "')", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestApproval.DataSource = table
        dgRequestApproval.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestApproval.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestApproval.AutoResizeColumns()

        lblJumlahData.Text = "Jumlah Data : " & dgRequestApproval.RowCount
    End Sub



    Sub LoadDaftarRequestValidasiALL()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT NoValidasi,StatusApproval,NamaUser AS RequestName,Pesan AS PesanUser,CreateDate,JenisRequest,Komponen,JenisValidasi FROM dbo.V_DetailValidasi WHERE NamaUser Like '%" & Trim(txtDibuatOleh.Text) & "%' AND  Cast(CreateDate As Date) between '" & dtpAwal.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpAkhir.Value.ToString("yyyy-MM-dd") & "' AND KodeSPV in ('" & MstrKdSupervisor & "','-','" & GlobalstrKodeUser & "') Order by CreateDate desc", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgRequestApproval.DataSource = table
        dgRequestApproval.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgRequestApproval.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgRequestApproval.AutoResizeColumns()
        lblJumlahData.Text = "Jumlah Data : " & dgRequestApproval.RowCount

    End Sub



    Private Sub FormManagementApproval_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarRequestValidasiBelumApproved()
        dtpAwal.Value = Now
        dtpAkhir.Value = Now
    End Sub

    Private Sub cmdCari_Click(sender As Object, e As EventArgs) Handles cmdCari.Click
        LoadDaftarRequestValidasiALL()
    End Sub

    Private Sub txtDibuatOleh_TextChanged(sender As Object, e As EventArgs) Handles txtDibuatOleh.TextChanged
        LoadDaftarRequestValidasiALL()
    End Sub

    Private Sub cmdLihatDetail_Click(sender As Object, e As EventArgs) Handles cmdLihatDetail.Click
        If dgRequestApproval.RowCount = 0 Then Exit Sub

        GlobalstrNoSurat = dgRequestApproval.Item(0, dgRequestApproval.CurrentRow.Index).Value
        FormDetailApproval.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class