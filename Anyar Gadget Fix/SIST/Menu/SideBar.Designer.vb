<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SideBar))
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAnyarLocalPrint = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdMonitoringDelivery = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdMonitoringRealStok = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdAnyarRepository = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdExportHargaJual = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdAIO = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmdAnyarNotifications = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PanelSideBar = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblJam = New Guna.UI.WinForms.GunaLabel()
        Me.lblHari = New Guna.UI.WinForms.GunaLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSiteID = New Guna.UI.WinForms.GunaTextBox()
        Me.txtLocation = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNamaUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdUbahPassword = New Guna.UI.WinForms.GunaGradientButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdConnectNotif = New System.Windows.Forms.Button()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PanelSideBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerJam
        '
        Me.TimerJam.Interval = 1000
        '
        'cmdAnyarLocalPrint
        '
        Me.cmdAnyarLocalPrint.AnimationHoverSpeed = 0.07!
        Me.cmdAnyarLocalPrint.AnimationSpeed = 0.03!
        Me.cmdAnyarLocalPrint.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.anyar_local_Print
        Me.cmdAnyarLocalPrint.BaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarLocalPrint.BorderColor = System.Drawing.Color.Black
        Me.cmdAnyarLocalPrint.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdAnyarLocalPrint.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarLocalPrint.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarLocalPrint.CheckedForeColor = System.Drawing.Color.White
        Me.cmdAnyarLocalPrint.CheckedImage = Global.AnyarGadget.My.Resources.Resources.anyar_local_Print
        Me.cmdAnyarLocalPrint.CheckedLineColor = System.Drawing.Color.White
        Me.cmdAnyarLocalPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdAnyarLocalPrint.FocusedColor = System.Drawing.Color.Empty
        Me.cmdAnyarLocalPrint.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdAnyarLocalPrint.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAnyarLocalPrint.Image = Global.AnyarGadget.My.Resources.Resources.anyar_local_Print
        Me.cmdAnyarLocalPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdAnyarLocalPrint.ImageOffsetX = 20
        Me.cmdAnyarLocalPrint.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdAnyarLocalPrint.LineColor = System.Drawing.Color.White
        Me.cmdAnyarLocalPrint.LineTop = 1
        Me.cmdAnyarLocalPrint.Location = New System.Drawing.Point(131, 6)
        Me.cmdAnyarLocalPrint.Name = "cmdAnyarLocalPrint"
        Me.cmdAnyarLocalPrint.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarLocalPrint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarLocalPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdAnyarLocalPrint.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.anyar_local_Print
        Me.cmdAnyarLocalPrint.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdAnyarLocalPrint.OnPressedColor = System.Drawing.Color.Black
        Me.cmdAnyarLocalPrint.OnPressedDepth = 0
        Me.cmdAnyarLocalPrint.Size = New System.Drawing.Size(50, 53)
        Me.cmdAnyarLocalPrint.TabIndex = 42
        Me.cmdAnyarLocalPrint.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdAnyarLocalPrint, "Anyar Local Print")
        '
        'cmdMonitoringDelivery
        '
        Me.cmdMonitoringDelivery.AnimationHoverSpeed = 0.07!
        Me.cmdMonitoringDelivery.AnimationSpeed = 0.03!
        Me.cmdMonitoringDelivery.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.Circle_Delivery
        Me.cmdMonitoringDelivery.BaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringDelivery.BorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringDelivery.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdMonitoringDelivery.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringDelivery.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringDelivery.CheckedForeColor = System.Drawing.Color.White
        Me.cmdMonitoringDelivery.CheckedImage = Global.AnyarGadget.My.Resources.Resources.Circle_Delivery
        Me.cmdMonitoringDelivery.CheckedLineColor = System.Drawing.Color.White
        Me.cmdMonitoringDelivery.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdMonitoringDelivery.FocusedColor = System.Drawing.Color.Empty
        Me.cmdMonitoringDelivery.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdMonitoringDelivery.ForeColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringDelivery.Image = Global.AnyarGadget.My.Resources.Resources.Circle_Delivery
        Me.cmdMonitoringDelivery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdMonitoringDelivery.ImageOffsetX = 20
        Me.cmdMonitoringDelivery.ImageSize = New System.Drawing.Size(53, 53)
        Me.cmdMonitoringDelivery.LineColor = System.Drawing.Color.White
        Me.cmdMonitoringDelivery.LineTop = 1
        Me.cmdMonitoringDelivery.Location = New System.Drawing.Point(63, 5)
        Me.cmdMonitoringDelivery.Name = "cmdMonitoringDelivery"
        Me.cmdMonitoringDelivery.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringDelivery.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringDelivery.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdMonitoringDelivery.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.Circle_Delivery
        Me.cmdMonitoringDelivery.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdMonitoringDelivery.OnPressedColor = System.Drawing.Color.Black
        Me.cmdMonitoringDelivery.OnPressedDepth = 0
        Me.cmdMonitoringDelivery.Size = New System.Drawing.Size(57, 54)
        Me.cmdMonitoringDelivery.TabIndex = 43
        Me.cmdMonitoringDelivery.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdMonitoringDelivery, "Monitoring Delivery")
        '
        'cmdMonitoringRealStok
        '
        Me.cmdMonitoringRealStok.AnimationHoverSpeed = 0.07!
        Me.cmdMonitoringRealStok.AnimationSpeed = 0.03!
        Me.cmdMonitoringRealStok.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.marketing_monitoring
        Me.cmdMonitoringRealStok.BaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringRealStok.BorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringRealStok.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdMonitoringRealStok.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringRealStok.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringRealStok.CheckedForeColor = System.Drawing.Color.White
        Me.cmdMonitoringRealStok.CheckedImage = Global.AnyarGadget.My.Resources.Resources.marketing_monitoring
        Me.cmdMonitoringRealStok.CheckedLineColor = System.Drawing.Color.White
        Me.cmdMonitoringRealStok.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdMonitoringRealStok.FocusedColor = System.Drawing.Color.Empty
        Me.cmdMonitoringRealStok.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdMonitoringRealStok.ForeColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringRealStok.Image = Global.AnyarGadget.My.Resources.Resources.marketing_monitoring
        Me.cmdMonitoringRealStok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdMonitoringRealStok.ImageOffsetX = 20
        Me.cmdMonitoringRealStok.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdMonitoringRealStok.LineColor = System.Drawing.Color.White
        Me.cmdMonitoringRealStok.LineTop = 1
        Me.cmdMonitoringRealStok.Location = New System.Drawing.Point(4, 6)
        Me.cmdMonitoringRealStok.Name = "cmdMonitoringRealStok"
        Me.cmdMonitoringRealStok.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdMonitoringRealStok.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdMonitoringRealStok.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdMonitoringRealStok.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.marketing_monitoring
        Me.cmdMonitoringRealStok.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdMonitoringRealStok.OnPressedColor = System.Drawing.Color.Black
        Me.cmdMonitoringRealStok.OnPressedDepth = 0
        Me.cmdMonitoringRealStok.Size = New System.Drawing.Size(50, 53)
        Me.cmdMonitoringRealStok.TabIndex = 44
        Me.cmdMonitoringRealStok.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdMonitoringRealStok, "Monitoring Realstok")
        '
        'cmdAnyarRepository
        '
        Me.cmdAnyarRepository.AnimationHoverSpeed = 0.07!
        Me.cmdAnyarRepository.AnimationSpeed = 0.03!
        Me.cmdAnyarRepository.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.repository
        Me.cmdAnyarRepository.BaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarRepository.BorderColor = System.Drawing.Color.Black
        Me.cmdAnyarRepository.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdAnyarRepository.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarRepository.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarRepository.CheckedForeColor = System.Drawing.Color.White
        Me.cmdAnyarRepository.CheckedImage = Global.AnyarGadget.My.Resources.Resources.repository
        Me.cmdAnyarRepository.CheckedLineColor = System.Drawing.Color.White
        Me.cmdAnyarRepository.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdAnyarRepository.FocusedColor = System.Drawing.Color.Empty
        Me.cmdAnyarRepository.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdAnyarRepository.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAnyarRepository.Image = Global.AnyarGadget.My.Resources.Resources.repository
        Me.cmdAnyarRepository.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdAnyarRepository.ImageOffsetX = 20
        Me.cmdAnyarRepository.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdAnyarRepository.LineColor = System.Drawing.Color.White
        Me.cmdAnyarRepository.LineTop = 1
        Me.cmdAnyarRepository.Location = New System.Drawing.Point(67, 65)
        Me.cmdAnyarRepository.Name = "cmdAnyarRepository"
        Me.cmdAnyarRepository.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarRepository.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarRepository.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdAnyarRepository.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.repository
        Me.cmdAnyarRepository.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdAnyarRepository.OnPressedColor = System.Drawing.Color.Black
        Me.cmdAnyarRepository.OnPressedDepth = 0
        Me.cmdAnyarRepository.Size = New System.Drawing.Size(50, 53)
        Me.cmdAnyarRepository.TabIndex = 45
        Me.cmdAnyarRepository.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdAnyarRepository, "Anyar Repository")
        '
        'cmdExportHargaJual
        '
        Me.cmdExportHargaJual.AnimationHoverSpeed = 0.07!
        Me.cmdExportHargaJual.AnimationSpeed = 0.03!
        Me.cmdExportHargaJual.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.Price_Tag_PNG_Clipart
        Me.cmdExportHargaJual.BaseColor = System.Drawing.Color.Transparent
        Me.cmdExportHargaJual.BorderColor = System.Drawing.Color.Black
        Me.cmdExportHargaJual.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdExportHargaJual.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdExportHargaJual.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdExportHargaJual.CheckedForeColor = System.Drawing.Color.White
        Me.cmdExportHargaJual.CheckedImage = Global.AnyarGadget.My.Resources.Resources.Price_Tag_PNG_Clipart
        Me.cmdExportHargaJual.CheckedLineColor = System.Drawing.Color.White
        Me.cmdExportHargaJual.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdExportHargaJual.FocusedColor = System.Drawing.Color.Empty
        Me.cmdExportHargaJual.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdExportHargaJual.ForeColor = System.Drawing.Color.Transparent
        Me.cmdExportHargaJual.Image = Global.AnyarGadget.My.Resources.Resources.Price_Tag_PNG_Clipart
        Me.cmdExportHargaJual.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdExportHargaJual.ImageOffsetX = 20
        Me.cmdExportHargaJual.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdExportHargaJual.LineColor = System.Drawing.Color.White
        Me.cmdExportHargaJual.LineTop = 1
        Me.cmdExportHargaJual.Location = New System.Drawing.Point(6, 65)
        Me.cmdExportHargaJual.Name = "cmdExportHargaJual"
        Me.cmdExportHargaJual.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdExportHargaJual.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdExportHargaJual.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdExportHargaJual.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.Price_Tag_PNG_Clipart
        Me.cmdExportHargaJual.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdExportHargaJual.OnPressedColor = System.Drawing.Color.Black
        Me.cmdExportHargaJual.OnPressedDepth = 0
        Me.cmdExportHargaJual.Size = New System.Drawing.Size(50, 53)
        Me.cmdExportHargaJual.TabIndex = 46
        Me.cmdExportHargaJual.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdExportHargaJual, "Anyar Repository")
        '
        'cmdAIO
        '
        Me.cmdAIO.AnimationHoverSpeed = 0.07!
        Me.cmdAIO.AnimationSpeed = 0.03!
        Me.cmdAIO.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.anyar_local_Print
        Me.cmdAIO.BaseColor = System.Drawing.Color.Transparent
        Me.cmdAIO.BorderColor = System.Drawing.Color.Black
        Me.cmdAIO.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdAIO.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdAIO.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdAIO.CheckedForeColor = System.Drawing.Color.White
        Me.cmdAIO.CheckedImage = Global.AnyarGadget.My.Resources.Resources.api
        Me.cmdAIO.CheckedLineColor = System.Drawing.Color.White
        Me.cmdAIO.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdAIO.FocusedColor = System.Drawing.Color.Empty
        Me.cmdAIO.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdAIO.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAIO.Image = Global.AnyarGadget.My.Resources.Resources.api
        Me.cmdAIO.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdAIO.ImageOffsetX = 20
        Me.cmdAIO.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdAIO.LineColor = System.Drawing.Color.White
        Me.cmdAIO.LineTop = 1
        Me.cmdAIO.Location = New System.Drawing.Point(131, 65)
        Me.cmdAIO.Name = "cmdAIO"
        Me.cmdAIO.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdAIO.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdAIO.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdAIO.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.api
        Me.cmdAIO.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdAIO.OnPressedColor = System.Drawing.Color.Black
        Me.cmdAIO.OnPressedDepth = 0
        Me.cmdAIO.Size = New System.Drawing.Size(50, 53)
        Me.cmdAIO.TabIndex = 47
        Me.cmdAIO.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdAIO, "Anyar A.I.O")
        '
        'cmdAnyarNotifications
        '
        Me.cmdAnyarNotifications.AnimationHoverSpeed = 0.07!
        Me.cmdAnyarNotifications.AnimationSpeed = 0.03!
        Me.cmdAnyarNotifications.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.giphy
        Me.cmdAnyarNotifications.BaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarNotifications.BorderColor = System.Drawing.Color.Black
        Me.cmdAnyarNotifications.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.cmdAnyarNotifications.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarNotifications.CheckedBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarNotifications.CheckedForeColor = System.Drawing.Color.White
        Me.cmdAnyarNotifications.CheckedImage = Global.AnyarGadget.My.Resources.Resources.giphy
        Me.cmdAnyarNotifications.CheckedLineColor = System.Drawing.Color.White
        Me.cmdAnyarNotifications.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdAnyarNotifications.FocusedColor = System.Drawing.Color.Empty
        Me.cmdAnyarNotifications.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cmdAnyarNotifications.ForeColor = System.Drawing.Color.Transparent
        Me.cmdAnyarNotifications.Image = Global.AnyarGadget.My.Resources.Resources._772409_music_512x5121
        Me.cmdAnyarNotifications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdAnyarNotifications.ImageOffsetX = 20
        Me.cmdAnyarNotifications.ImageSize = New System.Drawing.Size(50, 50)
        Me.cmdAnyarNotifications.LineColor = System.Drawing.Color.White
        Me.cmdAnyarNotifications.LineTop = 1
        Me.cmdAnyarNotifications.Location = New System.Drawing.Point(6, 134)
        Me.cmdAnyarNotifications.Name = "cmdAnyarNotifications"
        Me.cmdAnyarNotifications.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.cmdAnyarNotifications.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdAnyarNotifications.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdAnyarNotifications.OnHoverImage = Global.AnyarGadget.My.Resources.Resources.giphy
        Me.cmdAnyarNotifications.OnHoverLineColor = System.Drawing.Color.White
        Me.cmdAnyarNotifications.OnPressedColor = System.Drawing.Color.Black
        Me.cmdAnyarNotifications.OnPressedDepth = 0
        Me.cmdAnyarNotifications.Size = New System.Drawing.Size(50, 53)
        Me.cmdAnyarNotifications.TabIndex = 48
        Me.cmdAnyarNotifications.TextOffsetX = 10
        Me.ToolTip1.SetToolTip(Me.cmdAnyarNotifications, "Anyar Notifications")
        '
        'PanelSideBar
        '
        Me.PanelSideBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSideBar.BackColor = System.Drawing.Color.Transparent
        Me.PanelSideBar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.lblJam)
        Me.PanelSideBar.Controls.Add(Me.lblHari)
        Me.PanelSideBar.Controls.Add(Me.Label3)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.GunaCirclePictureBox4)
        Me.PanelSideBar.Controls.Add(Me.TabControl1)
        Me.PanelSideBar.Controls.Add(Me.GunaPictureBox1)
        Me.PanelSideBar.Location = New System.Drawing.Point(3, 3)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(233, 521)
        Me.PanelSideBar.TabIndex = 10
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.White
        Me.lblJam.Location = New System.Drawing.Point(104, 64)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(47, 25)
        Me.lblJam.TabIndex = 10
        Me.lblJam.Text = "Jam"
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.ForeColor = System.Drawing.Color.White
        Me.lblHari.Location = New System.Drawing.Point(104, 6)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(50, 25)
        Me.lblHari.TabIndex = 9
        Me.lblHari.Text = "Hari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Build xx.xx.xxx"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Anyar Gadget V1.1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 93)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(195, 358)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.txtSiteID)
        Me.TabPage1.Controls.Add(Me.txtLocation)
        Me.TabPage1.Controls.Add(Me.txtNamaUser)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.GunaCirclePictureBox3)
        Me.TabPage1.Controls.Add(Me.GunaLinePanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(187, 332)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Administration"
        '
        'txtSiteID
        '
        Me.txtSiteID.BaseColor = System.Drawing.Color.LightGray
        Me.txtSiteID.BorderColor = System.Drawing.Color.Silver
        Me.txtSiteID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSiteID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSiteID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSiteID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSiteID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSiteID.Location = New System.Drawing.Point(6, 196)
        Me.txtSiteID.Name = "txtSiteID"
        Me.txtSiteID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSiteID.ReadOnly = True
        Me.txtSiteID.Size = New System.Drawing.Size(174, 30)
        Me.txtSiteID.TabIndex = 41
        Me.txtSiteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLocation
        '
        Me.txtLocation.BaseColor = System.Drawing.Color.LightGray
        Me.txtLocation.BorderColor = System.Drawing.Color.Silver
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLocation.Location = New System.Drawing.Point(6, 148)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(174, 30)
        Me.txtLocation.TabIndex = 40
        Me.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNamaUser
        '
        Me.txtNamaUser.BaseColor = System.Drawing.Color.LightGray
        Me.txtNamaUser.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaUser.Location = New System.Drawing.Point(6, 112)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaUser.ReadOnly = True
        Me.txtNamaUser.Size = New System.Drawing.Size(174, 30)
        Me.txtNamaUser.TabIndex = 39
        Me.txtNamaUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Halo, Selamat Datang"
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BackColor = System.Drawing.Color.LightGray
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(51, 24)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(84, 82)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 0
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.White
        Me.GunaLinePanel1.Controls.Add(Me.GunaGradientButton2)
        Me.GunaLinePanel1.Controls.Add(Me.cmdUbahPassword)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(3, 232)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(177, 95)
        Me.GunaLinePanel1.TabIndex = 37
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(5, 50)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(165, 37)
        Me.GunaGradientButton2.TabIndex = 37
        Me.GunaGradientButton2.Text = "Logout"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdUbahPassword
        '
        Me.cmdUbahPassword.AnimationHoverSpeed = 0.07!
        Me.cmdUbahPassword.AnimationSpeed = 0.03!
        Me.cmdUbahPassword.BackColor = System.Drawing.Color.Transparent
        Me.cmdUbahPassword.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdUbahPassword.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdUbahPassword.BorderColor = System.Drawing.Color.Black
        Me.cmdUbahPassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdUbahPassword.FocusedColor = System.Drawing.Color.Empty
        Me.cmdUbahPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdUbahPassword.ForeColor = System.Drawing.Color.White
        Me.cmdUbahPassword.Image = Nothing
        Me.cmdUbahPassword.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdUbahPassword.Location = New System.Drawing.Point(6, 7)
        Me.cmdUbahPassword.Name = "cmdUbahPassword"
        Me.cmdUbahPassword.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdUbahPassword.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdUbahPassword.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdUbahPassword.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdUbahPassword.OnHoverImage = Nothing
        Me.cmdUbahPassword.OnPressedColor = System.Drawing.Color.Black
        Me.cmdUbahPassword.Radius = 2
        Me.cmdUbahPassword.Size = New System.Drawing.Size(165, 37)
        Me.cmdUbahPassword.TabIndex = 36
        Me.cmdUbahPassword.Text = "Ubah Passsword"
        Me.cmdUbahPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdAnyarNotifications)
        Me.TabPage2.Controls.Add(Me.cmdAIO)
        Me.TabPage2.Controls.Add(Me.cmdExportHargaJual)
        Me.TabPage2.Controls.Add(Me.cmdAnyarRepository)
        Me.TabPage2.Controls.Add(Me.cmdMonitoringRealStok)
        Me.TabPage2.Controls.Add(Me.cmdMonitoringDelivery)
        Me.TabPage2.Controls.Add(Me.cmdAnyarLocalPrint)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(187, 332)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Menu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmdConnectNotif)
        Me.TabPage3.Controls.Add(Me.txtNotifikasi)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(187, 332)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pusat Info"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmdConnectNotif
        '
        Me.cmdConnectNotif.Location = New System.Drawing.Point(5, 296)
        Me.cmdConnectNotif.Name = "cmdConnectNotif"
        Me.cmdConnectNotif.Size = New System.Drawing.Size(176, 30)
        Me.cmdConnectNotif.TabIndex = 1
        Me.cmdConnectNotif.Text = "Connect"
        Me.cmdConnectNotif.UseVisualStyleBackColor = True
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(5, 4)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.Size = New System.Drawing.Size(176, 286)
        Me.txtNotifikasi.TabIndex = 0
        Me.txtNotifikasi.Text = ""
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox4.Image = Global.AnyarGadget.My.Resources.Resources.LOGO_ANYAR_BULAT
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(12, 5)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(86, 84)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 5
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 441)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(233, 80)
        Me.GunaPictureBox1.TabIndex = 38
        Me.GunaPictureBox1.TabStop = False
        '
        'SideBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 524)
        Me.Controls.Add(Me.PanelSideBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(7, 77)
        Me.MaximizeBox = False
        Me.Name = "SideBar"
        Me.Text = "SideBar"
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelSideBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents PanelSideBar As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblJam As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblHari As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtSiteID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtLocation As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNamaUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdUbahPassword As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmdConnectNotif As System.Windows.Forms.Button
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdAnyarLocalPrint As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdMonitoringDelivery As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdMonitoringRealStok As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdAnyarRepository As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdExportHargaJual As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdAIO As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmdAnyarNotifications As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
