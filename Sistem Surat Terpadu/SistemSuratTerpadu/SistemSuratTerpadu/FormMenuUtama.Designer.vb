<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatSuratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratJalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratTerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeritaAcaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyelesaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerahTerimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestValidasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.cmdLogout = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtNamaUser = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaAdvenceButton4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdLihatSurat = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgSuratSaya = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.ApprovalValidasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.dgSuratSaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BuatSuratToolStripMenuItem, Me.SettingToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.MonitoringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BuatSuratToolStripMenuItem
        '
        Me.BuatSuratToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuratJalanToolStripMenuItem, Me.BeritaAcaraToolStripMenuItem, Me.ValidasiToolStripMenuItem})
        Me.BuatSuratToolStripMenuItem.Name = "BuatSuratToolStripMenuItem"
        Me.BuatSuratToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.BuatSuratToolStripMenuItem.Text = "Buat Surat"
        '
        'SuratJalanToolStripMenuItem
        '
        Me.SuratJalanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SurToolStripMenuItem, Me.SuratTerimaToolStripMenuItem})
        Me.SuratJalanToolStripMenuItem.Name = "SuratJalanToolStripMenuItem"
        Me.SuratJalanToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.SuratJalanToolStripMenuItem.Text = "Surat"
        '
        'SurToolStripMenuItem
        '
        Me.SurToolStripMenuItem.Name = "SurToolStripMenuItem"
        Me.SurToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.SurToolStripMenuItem.Text = "Surat Jalan"
        '
        'SuratTerimaToolStripMenuItem
        '
        Me.SuratTerimaToolStripMenuItem.Name = "SuratTerimaToolStripMenuItem"
        Me.SuratTerimaToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.SuratTerimaToolStripMenuItem.Text = "Surat Terima"
        '
        'BeritaAcaraToolStripMenuItem
        '
        Me.BeritaAcaraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenyelesaianToolStripMenuItem, Me.SerahTerimaToolStripMenuItem})
        Me.BeritaAcaraToolStripMenuItem.Name = "BeritaAcaraToolStripMenuItem"
        Me.BeritaAcaraToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.BeritaAcaraToolStripMenuItem.Text = "Berita Acara"
        '
        'PenyelesaianToolStripMenuItem
        '
        Me.PenyelesaianToolStripMenuItem.Name = "PenyelesaianToolStripMenuItem"
        Me.PenyelesaianToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.PenyelesaianToolStripMenuItem.Text = "Penyelesaian"
        '
        'SerahTerimaToolStripMenuItem
        '
        Me.SerahTerimaToolStripMenuItem.Name = "SerahTerimaToolStripMenuItem"
        Me.SerahTerimaToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SerahTerimaToolStripMenuItem.Text = "Serah Terima"
        '
        'ValidasiToolStripMenuItem
        '
        Me.ValidasiToolStripMenuItem.Name = "ValidasiToolStripMenuItem"
        Me.ValidasiToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.ValidasiToolStripMenuItem.Text = "Validasi"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateToolStripMenuItem, Me.MasterToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(75, 25)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'TemplateToolStripMenuItem
        '
        Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
        Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.TemplateToolStripMenuItem.Text = "Template"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.MasterToolStripMenuItem.Text = "Master Validasi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(81, 25)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestValidasiToolStripMenuItem, Me.ApprovalValidasiToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'RequestValidasiToolStripMenuItem
        '
        Me.RequestValidasiToolStripMenuItem.Name = "RequestValidasiToolStripMenuItem"
        Me.RequestValidasiToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.RequestValidasiToolStripMenuItem.Text = "Request Validasi"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.cmdLogout)
        Me.GunaPanel1.Controls.Add(Me.txtNamaUser)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton4)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 29)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(155, 615)
        Me.GunaPanel1.TabIndex = 4
        '
        'cmdLogout
        '
        Me.cmdLogout.AnimationHoverSpeed = 0.07!
        Me.cmdLogout.AnimationSpeed = 0.03!
        Me.cmdLogout.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogout.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdLogout.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdLogout.BorderColor = System.Drawing.Color.Black
        Me.cmdLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdLogout.FocusedColor = System.Drawing.Color.Empty
        Me.cmdLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdLogout.ForeColor = System.Drawing.Color.White
        Me.cmdLogout.Image = Nothing
        Me.cmdLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdLogout.Location = New System.Drawing.Point(12, 197)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLogout.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLogout.OnHoverImage = Nothing
        Me.cmdLogout.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLogout.Radius = 2
        Me.cmdLogout.Size = New System.Drawing.Size(128, 37)
        Me.cmdLogout.TabIndex = 27
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNamaUser
        '
        Me.txtNamaUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNamaUser.Location = New System.Drawing.Point(12, 154)
        Me.txtNamaUser.Multiline = True
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(128, 37)
        Me.txtNamaUser.TabIndex = 6
        Me.txtNamaUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(10, 21)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(130, 21)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Halo Apa Kabar?"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.SistemSuratTerpadu.My.Resources.Resources.Icon1
        Me.GunaPictureBox2.Location = New System.Drawing.Point(20, 45)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(105, 103)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 4
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 592)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(107, 12)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Software Version: 1.0.5.3"
        '
        'GunaAdvenceButton4
        '
        Me.GunaAdvenceButton4.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton4.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.CheckedImage = CType(resources.GetObject("GunaAdvenceButton4.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaAdvenceButton4.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.Image = CType(resources.GetObject("GunaAdvenceButton4.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton4.ImageOffsetX = 20
        Me.GunaAdvenceButton4.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton4.LineTop = 1
        Me.GunaAdvenceButton4.Location = New System.Drawing.Point(0, 521)
        Me.GunaAdvenceButton4.Name = "GunaAdvenceButton4"
        Me.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton4.OnHoverImage = Nothing
        Me.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton4.OnPressedDepth = 0
        Me.GunaAdvenceButton4.Size = New System.Drawing.Size(155, 68)
        Me.GunaAdvenceButton4.TabIndex = 3
        Me.GunaAdvenceButton4.Text = "SETTINGS"
        Me.GunaAdvenceButton4.TextOffsetX = 10
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.Gray
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaGroupBox1.Controls.Add(Me.cmdLihatSurat)
        Me.GunaGroupBox1.Controls.Add(Me.dgSuratSaya)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(174, 62)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(628, 477)
        Me.GunaGroupBox1.TabIndex = 6
        Me.GunaGroupBox1.Text = "Daftar Surat Departement Saya"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(171, 414)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(126, 37)
        Me.GunaGradientButton1.TabIndex = 28
        Me.GunaGradientButton1.Text = "Buka Attachment"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdLihatSurat
        '
        Me.cmdLihatSurat.AnimationHoverSpeed = 0.07!
        Me.cmdLihatSurat.AnimationSpeed = 0.03!
        Me.cmdLihatSurat.BackColor = System.Drawing.Color.Transparent
        Me.cmdLihatSurat.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdLihatSurat.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdLihatSurat.BorderColor = System.Drawing.Color.Black
        Me.cmdLihatSurat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdLihatSurat.FocusedColor = System.Drawing.Color.Empty
        Me.cmdLihatSurat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdLihatSurat.ForeColor = System.Drawing.Color.White
        Me.cmdLihatSurat.Image = Nothing
        Me.cmdLihatSurat.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdLihatSurat.Location = New System.Drawing.Point(22, 414)
        Me.cmdLihatSurat.Name = "cmdLihatSurat"
        Me.cmdLihatSurat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLihatSurat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLihatSurat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLihatSurat.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLihatSurat.OnHoverImage = Nothing
        Me.cmdLihatSurat.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLihatSurat.Radius = 2
        Me.cmdLihatSurat.Size = New System.Drawing.Size(126, 37)
        Me.cmdLihatSurat.TabIndex = 26
        Me.cmdLihatSurat.Text = "Lihat"
        Me.cmdLihatSurat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgSuratSaya
        '
        Me.dgSuratSaya.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgSuratSaya.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSuratSaya.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSuratSaya.BackgroundColor = System.Drawing.Color.White
        Me.dgSuratSaya.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSuratSaya.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSuratSaya.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSuratSaya.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSuratSaya.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSuratSaya.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSuratSaya.EnableHeadersVisualStyles = False
        Me.dgSuratSaya.GridColor = System.Drawing.Color.Blue
        Me.dgSuratSaya.Location = New System.Drawing.Point(22, 48)
        Me.dgSuratSaya.Name = "dgSuratSaya"
        Me.dgSuratSaya.ReadOnly = True
        Me.dgSuratSaya.RowHeadersVisible = False
        Me.dgSuratSaya.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSuratSaya.Size = New System.Drawing.Size(589, 338)
        Me.dgSuratSaya.TabIndex = 0
        Me.dgSuratSaya.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgSuratSaya.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgSuratSaya.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgSuratSaya.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgSuratSaya.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgSuratSaya.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgSuratSaya.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgSuratSaya.ThemeStyle.GridColor = System.Drawing.Color.Blue
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgSuratSaya.ThemeStyle.HeaderStyle.Height = 30
        Me.dgSuratSaya.ThemeStyle.ReadOnly = True
        Me.dgSuratSaya.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgSuratSaya.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSuratSaya.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgSuratSaya.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgSuratSaya.ThemeStyle.RowsStyle.Height = 22
        Me.dgSuratSaya.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgSuratSaya.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.GunaGradientButton2.Location = New System.Drawing.Point(779, 0)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(35, 29)
        Me.GunaGradientButton2.TabIndex = 28
        Me.GunaGradientButton2.Text = "X"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(155, 550)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(659, 94)
        Me.GunaPictureBox1.TabIndex = 29
        Me.GunaPictureBox1.TabStop = False
        '
        'ApprovalValidasiToolStripMenuItem
        '
        Me.ApprovalValidasiToolStripMenuItem.Name = "ApprovalValidasiToolStripMenuItem"
        Me.ApprovalValidasiToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ApprovalValidasiToolStripMenuItem.Text = "Approval Validasi"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 644)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaGradientButton2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        CType(Me.dgSuratSaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuatSuratToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents cmdLogout As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdLihatSurat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgSuratSaya As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents SuratJalanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeritaAcaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ValidasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestValidasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratTerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenyelesaianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerahTerimaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApprovalValidasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
