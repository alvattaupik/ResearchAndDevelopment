<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTimerTime = New Guna.UI.WinForms.GunaLabel()
        Me.lblFormSize = New System.Windows.Forms.Label()
        Me.lblMousePosition = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Shutdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.GadgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Sidebar = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Monitoring = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_Realstock = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_Delivery = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_Request = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_PrintServices = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_AnyarLocalPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_RKMDisplayTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Ping = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Request = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_ReqFullfillment = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_BukaValidasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_BukaPostingPeriode = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_BukaAuthorisasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Repository = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_AnyarRepository = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_AIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_IntegrationMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_FullfilmentChecker = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_ReplicationMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_StoreDatabaseMonitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_PricingAndPromotion = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_ExportHargaJual = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_PerubahanHarga = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_Promo = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_AnyarChat = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_LaporanLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_LapInventoryCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_MutasiStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Template = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_UbahPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_PushNotification = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_User = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Pegawai = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_HeaderMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_ItemsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_ObjectForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_HeaderForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.I_ItemsForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_LaporkanMasalah = New System.Windows.Forms.ToolStripMenuItem()
        Me.H_CaraPenggunaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgListMenu = New System.Windows.Forms.DataGridView()
        Me.txtPesanError = New System.Windows.Forms.TextBox()
        Me.TimerPesanError = New System.Windows.Forms.Timer(Me.components)
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.txtJamDanWaktu = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        CType(Me.dgListMenu,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        Me.lblTimerTime.AutoSize = true
        Me.lblTimerTime.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.lblTimerTime.Location = New System.Drawing.Point(598, 3)
        Me.lblTimerTime.Name = "lblTimerTime"
        Me.lblTimerTime.Size = New System.Drawing.Size(69, 15)
        Me.lblTimerTime.TabIndex = 9
        Me.lblTimerTime.Text = "GunaLabel1"
        '
        'lblFormSize
        '
        Me.lblFormSize.AutoSize = true
        Me.lblFormSize.Location = New System.Drawing.Point(319, 4)
        Me.lblFormSize.Name = "lblFormSize"
        Me.lblFormSize.Size = New System.Drawing.Size(59, 13)
        Me.lblFormSize.TabIndex = 8
        Me.lblFormSize.Text = "Form Size :"
        '
        'lblMousePosition
        '
        Me.lblMousePosition.AutoSize = true
        Me.lblMousePosition.Location = New System.Drawing.Point(5, 4)
        Me.lblMousePosition.Name = "lblMousePosition"
        Me.lblMousePosition.Size = New System.Drawing.Size(85, 13)
        Me.lblMousePosition.TabIndex = 7
        Me.lblMousePosition.Text = "Mouse Position :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(945, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Anyar Gadget V1.1 Build "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GadgetToolStripMenuItem, Me.SettingToolStripMenuItem, Me.MasterToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_Logout, Me.H_Shutdown})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'H_Logout
        '
        Me.H_Logout.Name = "H_Logout"
        Me.H_Logout.Size = New System.Drawing.Size(172, 22)
        Me.H_Logout.Text = "Logout"
        Me.H_Logout.Visible = false
        '
        'H_Shutdown
        '
        Me.H_Shutdown.Name = "H_Shutdown"
        Me.H_Shutdown.Size = New System.Drawing.Size(172, 22)
        Me.H_Shutdown.Text = "Shutdown Aplikasi"
        Me.H_Shutdown.Visible = false
        '
        'GadgetToolStripMenuItem
        '
        Me.GadgetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_Sidebar, Me.H_Monitoring, Me.H_PrintServices, Me.H_Ping, Me.H_Request, Me.H_Repository, Me.H_AIO, Me.H_PricingAndPromotion, Me.H_AnyarChat, Me.H_LaporanLaporan})
        Me.GadgetToolStripMenuItem.Name = "GadgetToolStripMenuItem"
        Me.GadgetToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.GadgetToolStripMenuItem.Text = "GADGET"
        '
        'H_Sidebar
        '
        Me.H_Sidebar.Name = "H_Sidebar"
        Me.H_Sidebar.Size = New System.Drawing.Size(196, 22)
        Me.H_Sidebar.Text = "Side Bar"
        Me.H_Sidebar.Visible = false
        '
        'H_Monitoring
        '
        Me.H_Monitoring.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_Realstock, Me.I_Delivery, Me.I_Request})
        Me.H_Monitoring.Name = "H_Monitoring"
        Me.H_Monitoring.Size = New System.Drawing.Size(196, 22)
        Me.H_Monitoring.Text = "Monitoring"
        Me.H_Monitoring.Visible = false
        '
        'I_Realstock
        '
        Me.I_Realstock.Name = "I_Realstock"
        Me.I_Realstock.Size = New System.Drawing.Size(128, 22)
        Me.I_Realstock.Text = "Real Stock"
        Me.I_Realstock.Visible = False
        '
        'I_Delivery
        '
        Me.I_Delivery.Name = "I_Delivery"
        Me.I_Delivery.Size = New System.Drawing.Size(128, 22)
        Me.I_Delivery.Text = "Delivery"
        Me.I_Delivery.Visible = False
        '
        'I_Request
        '
        Me.I_Request.Name = "I_Request"
        Me.I_Request.Size = New System.Drawing.Size(128, 22)
        Me.I_Request.Text = "Request"
        Me.I_Request.Visible = False
        '
        'H_PrintServices
        '
        Me.H_PrintServices.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_AnyarLocalPrint, Me.I_RKMDisplayTag})
        Me.H_PrintServices.Name = "H_PrintServices"
        Me.H_PrintServices.Size = New System.Drawing.Size(196, 22)
        Me.H_PrintServices.Text = "Print Services"
        Me.H_PrintServices.Visible = False
        '
        'I_AnyarLocalPrint
        '
        Me.I_AnyarLocalPrint.Name = "I_AnyarLocalPrint"
        Me.I_AnyarLocalPrint.Size = New System.Drawing.Size(164, 22)
        Me.I_AnyarLocalPrint.Text = "Anyar Local Print"
        Me.I_AnyarLocalPrint.Visible = False
        '
        'I_RKMDisplayTag
        '
        Me.I_RKMDisplayTag.Name = "I_RKMDisplayTag"
        Me.I_RKMDisplayTag.Size = New System.Drawing.Size(164, 22)
        Me.I_RKMDisplayTag.Text = "RKM Display Tag"
        Me.I_RKMDisplayTag.Visible = False
        '
        'H_Ping
        '
        Me.H_Ping.Name = "H_Ping"
        Me.H_Ping.Size = New System.Drawing.Size(196, 22)
        Me.H_Ping.Text = "Ping"
        Me.H_Ping.Visible = False
        '
        'H_Request
        '
        Me.H_Request.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_ReqFullfillment, Me.I_BukaValidasi, Me.I_BukaPostingPeriode, Me.I_BukaAuthorisasi})
        Me.H_Request.Name = "H_Request"
        Me.H_Request.Size = New System.Drawing.Size(196, 22)
        Me.H_Request.Text = "Request"
        Me.H_Request.Visible = False
        '
        'I_ReqFullfillment
        '
        Me.I_ReqFullfillment.Name = "I_ReqFullfillment"
        Me.I_ReqFullfillment.Size = New System.Drawing.Size(186, 22)
        Me.I_ReqFullfillment.Text = "Req Fullfilment"
        Me.I_ReqFullfillment.Visible = False
        '
        'I_BukaValidasi
        '
        Me.I_BukaValidasi.Name = "I_BukaValidasi"
        Me.I_BukaValidasi.Size = New System.Drawing.Size(186, 22)
        Me.I_BukaValidasi.Text = "Buka Validasi"
        Me.I_BukaValidasi.Visible = False
        '
        'I_BukaPostingPeriode
        '
        Me.I_BukaPostingPeriode.Name = "I_BukaPostingPeriode"
        Me.I_BukaPostingPeriode.Size = New System.Drawing.Size(186, 22)
        Me.I_BukaPostingPeriode.Text = "Buka Posting Periode"
        Me.I_BukaPostingPeriode.Visible = False
        '
        'I_BukaAuthorisasi
        '
        Me.I_BukaAuthorisasi.Name = "I_BukaAuthorisasi"
        Me.I_BukaAuthorisasi.Size = New System.Drawing.Size(186, 22)
        Me.I_BukaAuthorisasi.Text = "Buka Authorisasi"
        Me.I_BukaAuthorisasi.Visible = False
        '
        'H_Repository
        '
        Me.H_Repository.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_AnyarRepository})
        Me.H_Repository.Name = "H_Repository"
        Me.H_Repository.Size = New System.Drawing.Size(196, 22)
        Me.H_Repository.Text = "Repository"
        Me.H_Repository.Visible = False
        '
        'I_AnyarRepository
        '
        Me.I_AnyarRepository.Name = "I_AnyarRepository"
        Me.I_AnyarRepository.Size = New System.Drawing.Size(164, 22)
        Me.I_AnyarRepository.Text = "Anyar Repository"
        Me.I_AnyarRepository.Visible = False
        '
        'H_AIO
        '
        Me.H_AIO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_IntegrationMonitor, Me.I_FullfilmentChecker, Me.I_ReplicationMonitor, Me.I_StoreDatabaseMonitor})
        Me.H_AIO.Name = "H_AIO"
        Me.H_AIO.Size = New System.Drawing.Size(196, 22)
        Me.H_AIO.Text = "AIO"
        Me.H_AIO.Visible = False
        '
        'I_IntegrationMonitor
        '
        Me.I_IntegrationMonitor.Name = "I_IntegrationMonitor"
        Me.I_IntegrationMonitor.Size = New System.Drawing.Size(198, 22)
        Me.I_IntegrationMonitor.Text = "Integration Monitor"
        Me.I_IntegrationMonitor.Visible = False
        '
        'I_FullfilmentChecker
        '
        Me.I_FullfilmentChecker.Name = "I_FullfilmentChecker"
        Me.I_FullfilmentChecker.Size = New System.Drawing.Size(198, 22)
        Me.I_FullfilmentChecker.Text = "Fullfillment Checker"
        Me.I_FullfilmentChecker.Visible = False
        '
        'I_ReplicationMonitor
        '
        Me.I_ReplicationMonitor.Name = "I_ReplicationMonitor"
        Me.I_ReplicationMonitor.Size = New System.Drawing.Size(198, 22)
        Me.I_ReplicationMonitor.Text = "Replication Monitor"
        Me.I_ReplicationMonitor.Visible = False
        '
        'I_StoreDatabaseMonitor
        '
        Me.I_StoreDatabaseMonitor.Name = "I_StoreDatabaseMonitor"
        Me.I_StoreDatabaseMonitor.Size = New System.Drawing.Size(198, 22)
        Me.I_StoreDatabaseMonitor.Text = "Store Database Monitor"
        Me.I_StoreDatabaseMonitor.Visible = False
        '
        'H_PricingAndPromotion
        '
        Me.H_PricingAndPromotion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_ExportHargaJual, Me.I_PerubahanHarga, Me.I_Promo})
        Me.H_PricingAndPromotion.Name = "H_PricingAndPromotion"
        Me.H_PricingAndPromotion.Size = New System.Drawing.Size(196, 22)
        Me.H_PricingAndPromotion.Text = "Pricing And Promotion"
        Me.H_PricingAndPromotion.Visible = False
        '
        'I_ExportHargaJual
        '
        Me.I_ExportHargaJual.Name = "I_ExportHargaJual"
        Me.I_ExportHargaJual.Size = New System.Drawing.Size(166, 22)
        Me.I_ExportHargaJual.Text = "Export Harga Jual"
        Me.I_ExportHargaJual.Visible = False
        '
        'I_PerubahanHarga
        '
        Me.I_PerubahanHarga.Name = "I_PerubahanHarga"
        Me.I_PerubahanHarga.Size = New System.Drawing.Size(166, 22)
        Me.I_PerubahanHarga.Text = "Perubahan Harga"
        Me.I_PerubahanHarga.Visible = False
        '
        'I_Promo
        '
        Me.I_Promo.Name = "I_Promo"
        Me.I_Promo.Size = New System.Drawing.Size(166, 22)
        Me.I_Promo.Text = "Promo"
        Me.I_Promo.Visible = False
        '
        'H_AnyarChat
        '
        Me.H_AnyarChat.Name = "H_AnyarChat"
        Me.H_AnyarChat.Size = New System.Drawing.Size(196, 22)
        Me.H_AnyarChat.Text = "Anyar Chat"
        Me.H_AnyarChat.Visible = False
        '
        'H_LaporanLaporan
        '
        Me.H_LaporanLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_LapInventoryCheck, Me.I_MutasiStock})
        Me.H_LaporanLaporan.Name = "H_LaporanLaporan"
        Me.H_LaporanLaporan.Size = New System.Drawing.Size(196, 22)
        Me.H_LaporanLaporan.Text = "Laporan - Laporan"
        Me.H_LaporanLaporan.Visible = False
        '
        'I_LapInventoryCheck
        '
        Me.I_LapInventoryCheck.Name = "I_LapInventoryCheck"
        Me.I_LapInventoryCheck.Size = New System.Drawing.Size(160, 22)
        Me.I_LapInventoryCheck.Text = "Inventory Check"
        Me.I_LapInventoryCheck.Visible = False
        '
        'I_MutasiStock
        '
        Me.I_MutasiStock.Name = "I_MutasiStock"
        Me.I_MutasiStock.Size = New System.Drawing.Size(160, 22)
        Me.I_MutasiStock.Text = "Mutasi Stok"
        Me.I_MutasiStock.Visible = False
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_Template, Me.H_UbahPassword, Me.H_PushNotification, Me.H_User})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SettingToolStripMenuItem.Text = "SETTING"
        '
        'H_Template
        '
        Me.H_Template.Name = "H_Template"
        Me.H_Template.Size = New System.Drawing.Size(171, 22)
        Me.H_Template.Text = "Template"
        Me.H_Template.Visible = False
        '
        'H_UbahPassword
        '
        Me.H_UbahPassword.Name = "H_UbahPassword"
        Me.H_UbahPassword.Size = New System.Drawing.Size(171, 22)
        Me.H_UbahPassword.Text = "Ubah Password"
        Me.H_UbahPassword.Visible = False
        '
        'H_PushNotification
        '
        Me.H_PushNotification.Name = "H_PushNotification"
        Me.H_PushNotification.Size = New System.Drawing.Size(171, 22)
        Me.H_PushNotification.Text = "Push Notifications"
        Me.H_PushNotification.Visible = False
        '
        'H_User
        '
        Me.H_User.Name = "H_User"
        Me.H_User.Size = New System.Drawing.Size(171, 22)
        Me.H_User.Text = "Users"
        Me.H_User.Visible = False
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_Pegawai, Me.H_Menu})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.MasterToolStripMenuItem.Text = "MASTER"
        '
        'H_Pegawai
        '
        Me.H_Pegawai.Name = "H_Pegawai"
        Me.H_Pegawai.Size = New System.Drawing.Size(152, 22)
        Me.H_Pegawai.Text = "Pegawai"
        Me.H_Pegawai.Visible = False
        '
        'H_Menu
        '
        Me.H_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_HeaderMenu, Me.I_ItemsMenu, Me.H_ObjectForm})
        Me.H_Menu.Name = "H_Menu"
        Me.H_Menu.Size = New System.Drawing.Size(152, 22)
        Me.H_Menu.Text = "Menu"
        Me.H_Menu.Visible = false
        '
        'I_HeaderMenu
        '
        Me.I_HeaderMenu.Name = "I_HeaderMenu"
        Me.I_HeaderMenu.Size = New System.Drawing.Size(140, 22)
        Me.I_HeaderMenu.Text = "Header"
        Me.I_HeaderMenu.Visible = false
        '
        'I_ItemsMenu
        '
        Me.I_ItemsMenu.Name = "I_ItemsMenu"
        Me.I_ItemsMenu.Size = New System.Drawing.Size(140, 22)
        Me.I_ItemsMenu.Text = "Detail"
        Me.I_ItemsMenu.Visible = false
        '
        'H_ObjectForm
        '
        Me.H_ObjectForm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.I_HeaderForm, Me.I_ItemsForm})
        Me.H_ObjectForm.Name = "H_ObjectForm"
        Me.H_ObjectForm.Size = New System.Drawing.Size(140, 22)
        Me.H_ObjectForm.Text = "Object Form"
        '
        'I_HeaderForm
        '
        Me.I_HeaderForm.Name = "I_HeaderForm"
        Me.I_HeaderForm.Size = New System.Drawing.Size(112, 22)
        Me.I_HeaderForm.Text = "Header"
        Me.I_HeaderForm.Visible = false
        '
        'I_ItemsForm
        '
        Me.I_ItemsForm.Name = "I_ItemsForm"
        Me.I_ItemsForm.Size = New System.Drawing.Size(112, 22)
        Me.I_ItemsForm.Text = "Items"
        Me.I_ItemsForm.Visible = false
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.H_LaporkanMasalah, Me.H_CaraPenggunaan})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'H_LaporkanMasalah
        '
        Me.H_LaporkanMasalah.Name = "H_LaporkanMasalah"
        Me.H_LaporkanMasalah.Size = New System.Drawing.Size(170, 22)
        Me.H_LaporkanMasalah.Text = "Laporkan Masalah"
        Me.H_LaporkanMasalah.Visible = false
        '
        'H_CaraPenggunaan
        '
        Me.H_CaraPenggunaan.Name = "H_CaraPenggunaan"
        Me.H_CaraPenggunaan.Size = New System.Drawing.Size(170, 22)
        Me.H_CaraPenggunaan.Text = "Cara Penggunaan"
        Me.H_CaraPenggunaan.Visible = false
        '
        'dgListMenu
        '
        Me.dgListMenu.AllowUserToAddRows = false
        Me.dgListMenu.AllowUserToDeleteRows = false
        Me.dgListMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListMenu.Location = New System.Drawing.Point(281, 46)
        Me.dgListMenu.Name = "dgListMenu"
        Me.dgListMenu.RowHeadersVisible = false
        Me.dgListMenu.Size = New System.Drawing.Size(226, 329)
        Me.dgListMenu.TabIndex = 8
        Me.dgListMenu.Visible = false
        '
        'txtPesanError
        '
        Me.txtPesanError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesanError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPesanError.Location = New System.Drawing.Point(281, 3)
        Me.txtPesanError.Name = "txtPesanError"
        Me.txtPesanError.ReadOnly = true
        Me.txtPesanError.Size = New System.Drawing.Size(1047, 19)
        Me.txtPesanError.TabIndex = 10
        Me.txtPesanError.Visible = false
        '
        'TimerPesanError
        '
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = true
        Me.TimerJam.Interval = 1000
        '
        'txtJamDanWaktu
        '
        Me.txtJamDanWaktu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJamDanWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtJamDanWaktu.Location = New System.Drawing.Point(367, 3)
        Me.txtJamDanWaktu.Name = "txtJamDanWaktu"
        Me.txtJamDanWaktu.ReadOnly = true
        Me.txtJamDanWaktu.Size = New System.Drawing.Size(909, 19)
        Me.txtJamDanWaktu.TabIndex = 12
        Me.txtJamDanWaktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        'Me.BackgroundImage = Global.ANYAR_GADGET.My.Resources.Resources.Indonesia_Maps2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.Controls.Add(Me.txtJamDanWaktu)
        Me.Controls.Add(Me.txtPesanError)
        Me.Controls.Add(Me.dgListMenu)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmMainMenu"
        Me.Text = "Anyar Gadget - AnyarGroup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.dgListMenu,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMousePosition As System.Windows.Forms.Label
    Friend WithEvents lblFormSize As System.Windows.Forms.Label
    Friend WithEvents lblTimerTime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Shutdown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GadgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Sidebar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Monitoring As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_Realstock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_Delivery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_Request As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_PrintServices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_AnyarLocalPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_RKMDisplayTag As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Ping As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Request As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_ReqFullfillment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_BukaValidasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_BukaPostingPeriode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_BukaAuthorisasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Repository As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_AnyarRepository As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_AIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_IntegrationMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_FullfilmentChecker As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_ReplicationMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_StoreDatabaseMonitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_PricingAndPromotion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_ExportHargaJual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_PerubahanHarga As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_Promo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_AnyarChat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Template As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_UbahPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_PushNotification As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_User As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Pegawai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_HeaderMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_ItemsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_ObjectForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgListMenu As System.Windows.Forms.DataGridView
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_LaporkanMasalah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_CaraPenggunaan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPesanError As System.Windows.Forms.TextBox
    Friend WithEvents TimerPesanError As System.Windows.Forms.Timer
    Friend WithEvents I_HeaderForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_ItemsForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents H_LaporanLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_LapInventoryCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents I_MutasiStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents txtJamDanWaktu As System.Windows.Forms.TextBox

End Class
