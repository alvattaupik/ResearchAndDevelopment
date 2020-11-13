Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports System.Net.Sockets


Public Class frmMainMenu

    Dim intDurasiTimer As Integer = 8


    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load


        TimerJam.Start()

        'Dim frm As New frmDashBoard
        'frm.MdiParent = Me
        'frm.Show()


    End Sub

    Private Sub H_User_Click(sender As Object, e As EventArgs)

        'Dim frm As New frmUsers
        'frm.MdiParent = Me
        'frm.BringToFront()
        ''frm.WindowState = FormWindowState.Maximized
        'frm.Show()
    End Sub

    Private Sub TimerPesanError_Tick(sender As Object, e As EventArgs) Handles TimerPesanError.Tick
       


        If intDurasiTimer > 0 Then
            intDurasiTimer = intDurasiTimer - 1
            txtPesanError.Visible = True
            'lblDurasiTimer.Text = intDurasiTimer
        Else
            txtPesanError.Visible = False
            TimerPesanError.Enabled = False
            txtJamDanWaktu.Visible = True
        End If





    End Sub

    Private Sub H_Logout_Click(sender As Object, e As EventArgs) Handles H_Logout.Click
        If MsgBox("Apakah Anda Akan Logout dari Aplikasi Ini?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Dispose()
            frmLogin.Show()
            frmLogin.txtUsernameLogin.Text = ""
            frmLogin.txtPassword.Text = ""
            MsgBox("Terimakasih " & MstrNamaPegawai, vbInformation, "Terimakasih!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub H_Shutdown_Click(sender As Object, e As EventArgs) Handles H_Shutdown.Click
        MsgBox("Terminating The Apps, Please Wait")
        End
    End Sub


    Private Sub InformasiMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformasiMemberToolStripMenuItem.Click
        Dim frm As New frmInformasiCustomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MemberCardGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim frm As New frmDashboard
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ListCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListCustomerToolStripMenuItem.Click
        Dim frm As New frmListCustomer
        frm.Show()
    End Sub


    Private Sub VoucherCodeGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherCodeGeneratorToolStripMenuItem.Click
        Dim frm As New frmVoucherCodeGenerator
        frm.Show()
    End Sub

    Private Sub MemberCardGeneratorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MemberCardGeneratorToolStripMenuItem.Click
        Dim frm As New frmMemberCardGenerator
        frm.Show()
    End Sub

    Private Sub MemberCardStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberCardStockToolStripMenuItem.Click
        Dim frm As New frmMonitoringStokMemberdanVoucher
        frm.Show()
    End Sub

    Private Sub KirimMemberCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KirimMemberCardToolStripMenuItem.Click
        Dim frm As New frmSuratJalan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LainnyaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LainnyaToolStripMenuItem.Click
        Dim frm As New frmLainnya
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NomorMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NomorMemberToolStripMenuItem.Click
        Dim frm As New frmPenggunaanNoMember
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
