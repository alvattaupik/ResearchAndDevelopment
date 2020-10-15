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
        Call KoneksiDB_EMAIL()
        Call LoadDataGrid(dgListMenu, "Select Kode,StatusEnabled From V_MenuAplikasi Where UsernameLogin='" & MstrUsernameLogin & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'", KoneksiDBEmail)
       
        LoadMenuAplikasi(dgListMenu)

        TimerJam.Start()

        Dim frm As New frmDashBoard
        frm.MdiParent = Me
        frm.Show()


    End Sub




    Private Sub H_Sidebar_Click(sender As Object, e As EventArgs) Handles H_Sidebar.Click
        Dim frm As New frmDashBoard
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub I_Realstock_Click(sender As Object, e As EventArgs) Handles I_Realstock.Click
        Dim frm As New frmMonitoringRealStock
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub H_User_Click(sender As Object, e As EventArgs) Handles H_User.Click

        Dim frm As New frmUsers
        frm.MdiParent = Me
        frm.BringToFront()
        'frm.WindowState = FormWindowState.Maximized
        frm.Show()
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

    Private Sub H_Pegawai_Click(sender As Object, e As EventArgs) Handles H_Pegawai.Click

        Dim frm As New frmMasterPegawai
        frm.MdiParent = Me
        frm.BringToFront()
        'frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub I_Header_Click(sender As Object, e As EventArgs) Handles I_HeaderMenu.Click
        Dim frm As New frmHeaderMenu
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub HeaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles I_HeaderForm.Click
        Dim frm As New frmHeaderForm
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub I_ItemsForm_Click(sender As Object, e As EventArgs) Handles I_ItemsForm.Click
        Dim frm As New frmDetailForm
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
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

    Private Sub I_ItemsMenu_Click(sender As Object, e As EventArgs) Handles I_ItemsMenu.Click
        Dim frm As New frmDetailMenu
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub I_Delivery_Click(sender As Object, e As EventArgs) Handles I_Delivery.Click
        Dim frm As New frmMonitoringDelivery
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub I_AnyarLocalPrint_Click(sender As Object, e As EventArgs) Handles I_AnyarLocalPrint.Click
        Dim frm As New frmAnyarLocalPrint
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub H_Ping_Click(sender As Object, e As EventArgs) Handles H_Ping.Click
        frmPing.ShowDialog()
    End Sub

    Private Sub I_AnyarRepository_Click(sender As Object, e As EventArgs) Handles I_AnyarRepository.Click
        Dim frm As New frmAnyarRepository
        frm.MdiParent = Me
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub I_IntegrationMonitor_Click(sender As Object, e As EventArgs) Handles I_IntegrationMonitor.Click
        Dim frm As New frmIntegrationMonitoring
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_ReplicationMonitor_Click(sender As Object, e As EventArgs) Handles I_ReplicationMonitor.Click
        Dim frm As New frmReplicationMonitoring
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_FullfilmentChecker_Click(sender As Object, e As EventArgs) Handles I_FullfilmentChecker.Click
        Dim frm As New frmFullfillmentChecker
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_StoreDatabaseMonitor_Click(sender As Object, e As EventArgs) Handles I_StoreDatabaseMonitor.Click
        Dim frm As New frmDatabasePerformance
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_ExportHargaJual_Click(sender As Object, e As EventArgs) Handles I_ExportHargaJual.Click
        Dim frm As New frmExportHargaJual
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub H_Template_Click(sender As Object, e As EventArgs) Handles H_Template.Click
        Dim frm As New frmTemplate
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_PerubahanHarga_Click(sender As Object, e As EventArgs) Handles I_PerubahanHarga.Click
        Dim frm As New frmDetailPerubahanHargaJual
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_Promo_Click(sender As Object, e As EventArgs) Handles I_Promo.Click
        Dim frm As New frmPromoPromo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_LapInventoryCheck_Click(sender As Object, e As EventArgs) Handles I_LapInventoryCheck.Click

        Dim frm As New frmFilterLaporanInventoryCheck
        frm.Show()

    End Sub

    Private Sub I_MutasiStock_Click(sender As Object, e As EventArgs) Handles I_MutasiStock.Click
        Dim frm As New frmFilterLaporanMutasiStok
        frm.Show()
    End Sub

    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        txtJamDanWaktu.Text = Date.Today.ToString("dddd") & "  " & TimeOfDay
    End Sub

    Private Sub H_UbahPassword_Click(sender As Object, e As EventArgs) Handles H_UbahPassword.Click
        frmUbahPassword.ShowDialog()
    End Sub

    Private Sub H_LaporkanMasalah_Click(sender As Object, e As EventArgs) Handles H_LaporkanMasalah.Click
        Dim frm As New frmLaporkanMasalah
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub IncidentCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentCategoriesToolStripMenuItem.Click
        Dim frm As New frmHeaderCategories
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SubCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriesToolStripMenuItem.Click
        Dim frm As New frmDetailSubCategories
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SpecificCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecificCategoriesToolStripMenuItem.Click
        Dim frm As New frmDetailSpecificCategories
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub H_CaraPenggunaan_Click(sender As Object, e As EventArgs) Handles H_CaraPenggunaan.Click
        Dim frm As New frmBantuan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub H_Konten_Click(sender As Object, e As EventArgs) Handles H_Konten.Click
        Dim frm As New frmMasterKontenBantuan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_SuratJalan_Click(sender As Object, e As EventArgs) Handles I_SuratJalan.Click
        Dim frm As New frmSuratJalan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_SuratTerima_Click(sender As Object, e As EventArgs) Handles I_SuratTerima.Click
        Dim frm As New frmSuratTerima
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_BAPSerahTerima_Click(sender As Object, e As EventArgs) Handles I_BAPSerahTerima.Click
        Dim frm As New frmBAPSerahTerima
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_BAPPenyelesaian_Click(sender As Object, e As EventArgs) Handles I_BAPPenyelesaian.Click
        Dim frm As New frmBAPPenyelesaian
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_ListKendaraan_Click(sender As Object, e As EventArgs) Handles I_ListKendaraan.Click
        frmListKendaraan.ShowDialog()
    End Sub

    Private Sub I_ValidationControl_Click(sender As Object, e As EventArgs) Handles I_ValidationControl.Click
        frmValidationControls.ShowDialog()
    End Sub

    Private Sub NewAssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles I_RegNewAsset.Click
        Dim frm As New frmMasterNewAssets
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_BuatControlling_Click(sender As Object, e As EventArgs) Handles I_BuatControlling.Click
        Dim frm As New frmMonitoringAndControlling
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub I_ParameterUji_Click(sender As Object, e As EventArgs) Handles I_ParameterUji.Click
        Dim frm As New frmMasterParameterUji
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
