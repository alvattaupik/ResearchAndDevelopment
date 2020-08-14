<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBergerak = New Guna.UI.WinForms.GunaLabel()
        Me.txtPesanBerjalan = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GadgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SideBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringRealstokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MonitoringDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnyarLocalPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RKMDisplayTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportHargaJualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMyIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnyarChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestFullfillmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringMyRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBukaValidasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBukaPostingPeriodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnyarDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrationMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerubahanHargaJualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnyarLocalPrintServicesTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FotoProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PushNotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLoginDanHakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarBantuanDanPermasalahanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersiSaatIniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporkanMasalahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTimerTime = New Guna.UI.WinForms.GunaLabel()
        Me.lblFormSize = New System.Windows.Forms.Label()
        Me.lblMousePosition = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerRunningText = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerNotifikasi = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MasterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblBergerak)
        Me.Panel1.Controls.Add(Me.txtPesanBerjalan)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 57)
        Me.Panel1.TabIndex = 3
        '
        'lblBergerak
        '
        Me.lblBergerak.AutoSize = True
        Me.lblBergerak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBergerak.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBergerak.ForeColor = System.Drawing.Color.Blue
        Me.lblBergerak.Location = New System.Drawing.Point(5, 30)
        Me.lblBergerak.Name = "lblBergerak"
        Me.lblBergerak.Size = New System.Drawing.Size(124, 21)
        Me.lblBergerak.TabIndex = 32
        Me.lblBergerak.Text = "Selamat Datang"
        '
        'txtPesanBerjalan
        '
        Me.txtPesanBerjalan.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPesanBerjalan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesanBerjalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesanBerjalan.Location = New System.Drawing.Point(3, 27)
        Me.txtPesanBerjalan.Multiline = True
        Me.txtPesanBerjalan.Name = "txtPesanBerjalan"
        Me.txtPesanBerjalan.Size = New System.Drawing.Size(1361, 27)
        Me.txtPesanBerjalan.TabIndex = 31
        Me.txtPesanBerjalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GadgetToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ChangeLogToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ShutDownAppsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ShutDownAppsToolStripMenuItem
        '
        Me.ShutDownAppsToolStripMenuItem.Name = "ShutDownAppsToolStripMenuItem"
        Me.ShutDownAppsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ShutDownAppsToolStripMenuItem.Text = "Shut Down Apps"
        '
        'GadgetToolStripMenuItem
        '
        Me.GadgetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SideBarToolStripMenuItem, Me.MonitoringRealstokToolStripMenuItem, Me.ToolStripSeparator1, Me.MonitoringDeliveryToolStripMenuItem, Me.ToolStripSeparator2, Me.PrintServicesToolStripMenuItem, Me.ExportHargaJualToolStripMenuItem, Me.ShowMyIPToolStripMenuItem, Me.AnyarChatToolStripMenuItem, Me.RequestFullfillmentToolStripMenuItem, Me.AnyarDirectoryToolStripMenuItem, Me.IntegrationMonitoringToolStripMenuItem, Me.PerubahanHargaJualToolStripMenuItem})
        Me.GadgetToolStripMenuItem.Name = "GadgetToolStripMenuItem"
        Me.GadgetToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.GadgetToolStripMenuItem.Text = "Gadget"
        '
        'SideBarToolStripMenuItem
        '
        Me.SideBarToolStripMenuItem.Name = "SideBarToolStripMenuItem"
        Me.SideBarToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SideBarToolStripMenuItem.Text = "Side Bar"
        '
        'MonitoringRealstokToolStripMenuItem
        '
        Me.MonitoringRealstokToolStripMenuItem.Name = "MonitoringRealstokToolStripMenuItem"
        Me.MonitoringRealstokToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MonitoringRealstokToolStripMenuItem.Text = "Monitoring Realstok"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'MonitoringDeliveryToolStripMenuItem
        '
        Me.MonitoringDeliveryToolStripMenuItem.Name = "MonitoringDeliveryToolStripMenuItem"
        Me.MonitoringDeliveryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.MonitoringDeliveryToolStripMenuItem.Text = "Monitoring Delivery"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'PrintServicesToolStripMenuItem
        '
        Me.PrintServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnyarLocalPrintToolStripMenuItem, Me.RKMDisplayTagToolStripMenuItem})
        Me.PrintServicesToolStripMenuItem.Name = "PrintServicesToolStripMenuItem"
        Me.PrintServicesToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PrintServicesToolStripMenuItem.Text = "Print Services"
        '
        'AnyarLocalPrintToolStripMenuItem
        '
        Me.AnyarLocalPrintToolStripMenuItem.Name = "AnyarLocalPrintToolStripMenuItem"
        Me.AnyarLocalPrintToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AnyarLocalPrintToolStripMenuItem.Text = "Anyar Local Print"
        '
        'RKMDisplayTagToolStripMenuItem
        '
        Me.RKMDisplayTagToolStripMenuItem.Name = "RKMDisplayTagToolStripMenuItem"
        Me.RKMDisplayTagToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RKMDisplayTagToolStripMenuItem.Text = "RKM Display Tag"
        '
        'ExportHargaJualToolStripMenuItem
        '
        Me.ExportHargaJualToolStripMenuItem.Name = "ExportHargaJualToolStripMenuItem"
        Me.ExportHargaJualToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ExportHargaJualToolStripMenuItem.Text = "Export Harga Jual"
        '
        'ShowMyIPToolStripMenuItem
        '
        Me.ShowMyIPToolStripMenuItem.Name = "ShowMyIPToolStripMenuItem"
        Me.ShowMyIPToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ShowMyIPToolStripMenuItem.Text = "Ping"
        '
        'AnyarChatToolStripMenuItem
        '
        Me.AnyarChatToolStripMenuItem.Name = "AnyarChatToolStripMenuItem"
        Me.AnyarChatToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AnyarChatToolStripMenuItem.Text = "Anyar Chat"
        '
        'RequestFullfillmentToolStripMenuItem
        '
        Me.RequestFullfillmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonitoringMyRequestToolStripMenuItem, Me.BuatRequestToolStripMenuItem})
        Me.RequestFullfillmentToolStripMenuItem.Name = "RequestFullfillmentToolStripMenuItem"
        Me.RequestFullfillmentToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RequestFullfillmentToolStripMenuItem.Text = "Request Fullfillment"
        '
        'MonitoringMyRequestToolStripMenuItem
        '
        Me.MonitoringMyRequestToolStripMenuItem.Name = "MonitoringMyRequestToolStripMenuItem"
        Me.MonitoringMyRequestToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.MonitoringMyRequestToolStripMenuItem.Text = "Monitoring My Request"
        '
        'BuatRequestToolStripMenuItem
        '
        Me.BuatRequestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormBukaValidasiToolStripMenuItem, Me.FormBukaPostingPeriodeToolStripMenuItem})
        Me.BuatRequestToolStripMenuItem.Name = "BuatRequestToolStripMenuItem"
        Me.BuatRequestToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.BuatRequestToolStripMenuItem.Text = "Buat Request"
        '
        'FormBukaValidasiToolStripMenuItem
        '
        Me.FormBukaValidasiToolStripMenuItem.Name = "FormBukaValidasiToolStripMenuItem"
        Me.FormBukaValidasiToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.FormBukaValidasiToolStripMenuItem.Text = "Form Buka Validasi"
        '
        'FormBukaPostingPeriodeToolStripMenuItem
        '
        Me.FormBukaPostingPeriodeToolStripMenuItem.Name = "FormBukaPostingPeriodeToolStripMenuItem"
        Me.FormBukaPostingPeriodeToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.FormBukaPostingPeriodeToolStripMenuItem.Text = "Form Buka Posting Periode"
        '
        'AnyarDirectoryToolStripMenuItem
        '
        Me.AnyarDirectoryToolStripMenuItem.Name = "AnyarDirectoryToolStripMenuItem"
        Me.AnyarDirectoryToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AnyarDirectoryToolStripMenuItem.Text = "Anyar Repository"
        '
        'IntegrationMonitoringToolStripMenuItem
        '
        Me.IntegrationMonitoringToolStripMenuItem.Name = "IntegrationMonitoringToolStripMenuItem"
        Me.IntegrationMonitoringToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.IntegrationMonitoringToolStripMenuItem.Text = "Integration Monitoring"
        '
        'PerubahanHargaJualToolStripMenuItem
        '
        Me.PerubahanHargaJualToolStripMenuItem.Name = "PerubahanHargaJualToolStripMenuItem"
        Me.PerubahanHargaJualToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PerubahanHargaJualToolStripMenuItem.Text = "Perubahan Harga Jual"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateToolStripMenuItem, Me.FotoProfileToolStripMenuItem, Me.PushNotificationsToolStripMenuItem, Me.UserLoginDanHakAksesToolStripMenuItem, Me.MasterEmployeeToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'TemplateToolStripMenuItem
        '
        Me.TemplateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnyarLocalPrintServicesTemplateToolStripMenuItem})
        Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
        Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.TemplateToolStripMenuItem.Text = "Template"
        '
        'AnyarLocalPrintServicesTemplateToolStripMenuItem
        '
        Me.AnyarLocalPrintServicesTemplateToolStripMenuItem.Name = "AnyarLocalPrintServicesTemplateToolStripMenuItem"
        Me.AnyarLocalPrintServicesTemplateToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AnyarLocalPrintServicesTemplateToolStripMenuItem.Text = "Anyar Local Print Template"
        '
        'FotoProfileToolStripMenuItem
        '
        Me.FotoProfileToolStripMenuItem.Name = "FotoProfileToolStripMenuItem"
        Me.FotoProfileToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FotoProfileToolStripMenuItem.Text = "Ubah Password"
        '
        'PushNotificationsToolStripMenuItem
        '
        Me.PushNotificationsToolStripMenuItem.Name = "PushNotificationsToolStripMenuItem"
        Me.PushNotificationsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.PushNotificationsToolStripMenuItem.Text = "Push Notifications"
        '
        'UserLoginDanHakAksesToolStripMenuItem
        '
        Me.UserLoginDanHakAksesToolStripMenuItem.Name = "UserLoginDanHakAksesToolStripMenuItem"
        Me.UserLoginDanHakAksesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.UserLoginDanHakAksesToolStripMenuItem.Text = "User Login dan Hak Akses"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarBantuanDanPermasalahanToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DaftarBantuanDanPermasalahanToolStripMenuItem
        '
        Me.DaftarBantuanDanPermasalahanToolStripMenuItem.Name = "DaftarBantuanDanPermasalahanToolStripMenuItem"
        Me.DaftarBantuanDanPermasalahanToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.DaftarBantuanDanPermasalahanToolStripMenuItem.Text = "Daftar Bantuan Dan Permasalahan"
        '
        'ChangeLogToolStripMenuItem
        '
        Me.ChangeLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersiSaatIniToolStripMenuItem, Me.LaporkanMasalahToolStripMenuItem})
        Me.ChangeLogToolStripMenuItem.Name = "ChangeLogToolStripMenuItem"
        Me.ChangeLogToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ChangeLogToolStripMenuItem.Text = "Change Logs"
        '
        'VersiSaatIniToolStripMenuItem
        '
        Me.VersiSaatIniToolStripMenuItem.Name = "VersiSaatIniToolStripMenuItem"
        Me.VersiSaatIniToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.VersiSaatIniToolStripMenuItem.Text = "Versi Saat Ini"
        '
        'LaporkanMasalahToolStripMenuItem
        '
        Me.LaporkanMasalahToolStripMenuItem.Name = "LaporkanMasalahToolStripMenuItem"
        Me.LaporkanMasalahToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.LaporkanMasalahToolStripMenuItem.Text = "Laporkan Masalah"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblTimerTime)
        Me.Panel3.Controls.Add(Me.lblFormSize)
        Me.Panel3.Controls.Add(Me.lblMousePosition)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 706)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 23)
        Me.Panel3.TabIndex = 5
        '
        'lblTimerTime
        '
        Me.lblTimerTime.AutoSize = True
        Me.lblTimerTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTimerTime.Location = New System.Drawing.Point(1134, 4)
        Me.lblTimerTime.Name = "lblTimerTime"
        Me.lblTimerTime.Size = New System.Drawing.Size(69, 15)
        Me.lblTimerTime.TabIndex = 9
        Me.lblTimerTime.Text = "GunaLabel1"
        '
        'lblFormSize
        '
        Me.lblFormSize.AutoSize = True
        Me.lblFormSize.Location = New System.Drawing.Point(319, 4)
        Me.lblFormSize.Name = "lblFormSize"
        Me.lblFormSize.Size = New System.Drawing.Size(59, 13)
        Me.lblFormSize.TabIndex = 8
        Me.lblFormSize.Text = "Form Size :"
        '
        'lblMousePosition
        '
        Me.lblMousePosition.AutoSize = True
        Me.lblMousePosition.Location = New System.Drawing.Point(5, 4)
        Me.lblMousePosition.Name = "lblMousePosition"
        Me.lblMousePosition.Size = New System.Drawing.Size(85, 13)
        Me.lblMousePosition.TabIndex = 7
        Me.lblMousePosition.Text = "Mouse Position :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(945, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Anyar Gadget V1.1 Build "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerRunningText
        '
        Me.TimerRunningText.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TimerNotifikasi
        '
        Me.TimerNotifikasi.Interval = 1000
        '
        'MasterEmployeeToolStripMenuItem
        '
        Me.MasterEmployeeToolStripMenuItem.Name = "MasterEmployeeToolStripMenuItem"
        Me.MasterEmployeeToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.MasterEmployeeToolStripMenuItem.Text = "Master Employee"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.LOGO_ANYAR_BULAT
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Anyar Gadget - AnyarGroup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMousePosition As System.Windows.Forms.Label
    Friend WithEvents lblFormSize As System.Windows.Forms.Label
    Friend WithEvents txtPesanBerjalan As System.Windows.Forms.TextBox
    Friend WithEvents TimerRunningText As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutDownAppsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GadgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringRealstokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonitoringDeliveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnyarLocalPrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RKMDisplayTagToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportHargaJualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMyIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnyarChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestFullfillmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringMyRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuatRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormBukaValidasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormBukaPostingPeriodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnyarDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegrationMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnyarLocalPrintServicesTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FotoProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PushNotificationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserLoginDanHakAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarBantuanDanPermasalahanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersiSaatIniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporkanMasalahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblBergerak As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SideBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTimerTime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TimerNotifikasi As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PerubahanHargaJualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
