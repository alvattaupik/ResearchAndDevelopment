<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnyarServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnyarServices))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CRVDelivery = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdPreviewDelivery = New System.Windows.Forms.Button()
        Me.txtNoDelivery = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.crvGRPO = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdPreviewGRPO = New System.Windows.Forms.Button()
        Me.txtNoGRPO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.crvInventoryTransfer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdPreviewInventoryTransfer = New System.Windows.Forms.Button()
        Me.txtNoInventoryTransfer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.crvInventoryRequest = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdPreviewInventoryRequest = New System.Windows.Forms.Button()
        Me.txtNoInventoryRequest = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CRVGoodsIssue = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cmdPreviewGoodsIssue = New System.Windows.Forms.Button()
        Me.txtNoGoodsIssue = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNamaUser = New System.Windows.Forms.TextBox()
        Me.ChangeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMyIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem, Me.ExtraToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateLaporanToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'TemplateLaporanToolStripMenuItem
        '
        Me.TemplateLaporanToolStripMenuItem.Name = "TemplateLaporanToolStripMenuItem"
        Me.TemplateLaporanToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TemplateLaporanToolStripMenuItem.Text = "Template Laporan"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeLogToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNamaUser)
        Me.GroupBox1.Controls.Add(Me.cmdLogout)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 566)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User"
        '
        'cmdLogout
        '
        Me.cmdLogout.Location = New System.Drawing.Point(32, 193)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(137, 41)
        Me.cmdLogout.TabIndex = 4
        Me.cmdLogout.Text = "Logout"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apa Kabar ?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Halo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 582)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(854, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(207, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 527)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DAFTAR DOKUMEN"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(17, 33)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 488)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CRVDelivery)
        Me.TabPage1.Controls.Add(Me.cmdPreviewDelivery)
        Me.TabPage1.Controls.Add(Me.txtNoDelivery)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 64)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(604, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Delivery"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CRVDelivery
        '
        Me.CRVDelivery.ActiveViewIndex = -1
        Me.CRVDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVDelivery.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVDelivery.Location = New System.Drawing.Point(6, 48)
        Me.CRVDelivery.Name = "CRVDelivery"
        Me.CRVDelivery.ShowParameterPanelButton = False
        Me.CRVDelivery.Size = New System.Drawing.Size(594, 366)
        Me.CRVDelivery.TabIndex = 7
        '
        'cmdPreviewDelivery
        '
        Me.cmdPreviewDelivery.Location = New System.Drawing.Point(388, 6)
        Me.cmdPreviewDelivery.Name = "cmdPreviewDelivery"
        Me.cmdPreviewDelivery.Size = New System.Drawing.Size(196, 36)
        Me.cmdPreviewDelivery.TabIndex = 6
        Me.cmdPreviewDelivery.Text = "Preview"
        Me.cmdPreviewDelivery.UseVisualStyleBackColor = True
        '
        'txtNoDelivery
        '
        Me.txtNoDelivery.Location = New System.Drawing.Point(180, 11)
        Me.txtNoDelivery.Name = "txtNoDelivery"
        Me.txtNoDelivery.Size = New System.Drawing.Size(202, 31)
        Me.txtNoDelivery.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No Document :"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.crvGRPO)
        Me.TabPage8.Controls.Add(Me.cmdPreviewGRPO)
        Me.TabPage8.Controls.Add(Me.txtNoGRPO)
        Me.TabPage8.Controls.Add(Me.Label3)
        Me.TabPage8.Location = New System.Drawing.Point(4, 64)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(604, 420)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "GRPO"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'crvGRPO
        '
        Me.crvGRPO.ActiveViewIndex = -1
        Me.crvGRPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvGRPO.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvGRPO.Location = New System.Drawing.Point(6, 53)
        Me.crvGRPO.Name = "crvGRPO"
        Me.crvGRPO.Size = New System.Drawing.Size(578, 364)
        Me.crvGRPO.TabIndex = 11
        '
        'cmdPreviewGRPO
        '
        Me.cmdPreviewGRPO.Location = New System.Drawing.Point(388, 11)
        Me.cmdPreviewGRPO.Name = "cmdPreviewGRPO"
        Me.cmdPreviewGRPO.Size = New System.Drawing.Size(196, 36)
        Me.cmdPreviewGRPO.TabIndex = 10
        Me.cmdPreviewGRPO.Text = "Preview"
        Me.cmdPreviewGRPO.UseVisualStyleBackColor = True
        '
        'txtNoGRPO
        '
        Me.txtNoGRPO.Location = New System.Drawing.Point(180, 13)
        Me.txtNoGRPO.Name = "txtNoGRPO"
        Me.txtNoGRPO.Size = New System.Drawing.Size(202, 31)
        Me.txtNoGRPO.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "No Document :"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.crvInventoryTransfer)
        Me.TabPage9.Controls.Add(Me.cmdPreviewInventoryTransfer)
        Me.TabPage9.Controls.Add(Me.txtNoInventoryTransfer)
        Me.TabPage9.Controls.Add(Me.Label5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 64)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(604, 420)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Inventory Transfer"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'crvInventoryTransfer
        '
        Me.crvInventoryTransfer.ActiveViewIndex = -1
        Me.crvInventoryTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInventoryTransfer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInventoryTransfer.Location = New System.Drawing.Point(6, 49)
        Me.crvInventoryTransfer.Name = "crvInventoryTransfer"
        Me.crvInventoryTransfer.Size = New System.Drawing.Size(578, 368)
        Me.crvInventoryTransfer.TabIndex = 11
        '
        'cmdPreviewInventoryTransfer
        '
        Me.cmdPreviewInventoryTransfer.Location = New System.Drawing.Point(388, 7)
        Me.cmdPreviewInventoryTransfer.Name = "cmdPreviewInventoryTransfer"
        Me.cmdPreviewInventoryTransfer.Size = New System.Drawing.Size(196, 36)
        Me.cmdPreviewInventoryTransfer.TabIndex = 10
        Me.cmdPreviewInventoryTransfer.Text = "Preview"
        Me.cmdPreviewInventoryTransfer.UseVisualStyleBackColor = True
        '
        'txtNoInventoryTransfer
        '
        Me.txtNoInventoryTransfer.Location = New System.Drawing.Point(180, 10)
        Me.txtNoInventoryTransfer.Name = "txtNoInventoryTransfer"
        Me.txtNoInventoryTransfer.Size = New System.Drawing.Size(202, 31)
        Me.txtNoInventoryTransfer.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No Document :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.crvInventoryRequest)
        Me.TabPage2.Controls.Add(Me.cmdPreviewInventoryRequest)
        Me.TabPage2.Controls.Add(Me.txtNoInventoryRequest)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 64)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(604, 420)
        Me.TabPage2.TabIndex = 9
        Me.TabPage2.Text = "Inventory Request"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'crvInventoryRequest
        '
        Me.crvInventoryRequest.ActiveViewIndex = -1
        Me.crvInventoryRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInventoryRequest.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInventoryRequest.Location = New System.Drawing.Point(6, 43)
        Me.crvInventoryRequest.Name = "crvInventoryRequest"
        Me.crvInventoryRequest.Size = New System.Drawing.Size(592, 371)
        Me.crvInventoryRequest.TabIndex = 11
        '
        'cmdPreviewInventoryRequest
        '
        Me.cmdPreviewInventoryRequest.Location = New System.Drawing.Point(384, 4)
        Me.cmdPreviewInventoryRequest.Name = "cmdPreviewInventoryRequest"
        Me.cmdPreviewInventoryRequest.Size = New System.Drawing.Size(196, 36)
        Me.cmdPreviewInventoryRequest.TabIndex = 10
        Me.cmdPreviewInventoryRequest.Text = "Preview"
        Me.cmdPreviewInventoryRequest.UseVisualStyleBackColor = True
        '
        'txtNoInventoryRequest
        '
        Me.txtNoInventoryRequest.Location = New System.Drawing.Point(176, 6)
        Me.txtNoInventoryRequest.Name = "txtNoInventoryRequest"
        Me.txtNoInventoryRequest.Size = New System.Drawing.Size(202, 31)
        Me.txtNoInventoryRequest.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "No Document :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CRVGoodsIssue)
        Me.TabPage3.Controls.Add(Me.cmdPreviewGoodsIssue)
        Me.TabPage3.Controls.Add(Me.txtNoGoodsIssue)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 64)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(604, 420)
        Me.TabPage3.TabIndex = 10
        Me.TabPage3.Text = "Goods Issue"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CRVGoodsIssue
        '
        Me.CRVGoodsIssue.ActiveViewIndex = -1
        Me.CRVGoodsIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVGoodsIssue.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVGoodsIssue.Location = New System.Drawing.Point(6, 46)
        Me.CRVGoodsIssue.Name = "CRVGoodsIssue"
        Me.CRVGoodsIssue.Size = New System.Drawing.Size(578, 368)
        Me.CRVGoodsIssue.TabIndex = 15
        '
        'cmdPreviewGoodsIssue
        '
        Me.cmdPreviewGoodsIssue.Location = New System.Drawing.Point(387, 4)
        Me.cmdPreviewGoodsIssue.Name = "cmdPreviewGoodsIssue"
        Me.cmdPreviewGoodsIssue.Size = New System.Drawing.Size(196, 36)
        Me.cmdPreviewGoodsIssue.TabIndex = 14
        Me.cmdPreviewGoodsIssue.Text = "Preview"
        Me.cmdPreviewGoodsIssue.UseVisualStyleBackColor = True
        '
        'txtNoGoodsIssue
        '
        Me.txtNoGoodsIssue.Location = New System.Drawing.Point(179, 6)
        Me.txtNoGoodsIssue.Name = "txtNoGoodsIssue"
        Me.txtNoGoodsIssue.Size = New System.Drawing.Size(202, 31)
        Me.txtNoGoodsIssue.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "No Document :"
        '
        'lblNamaUser
        '
        Me.lblNamaUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaUser.Location = New System.Drawing.Point(32, 160)
        Me.lblNamaUser.Multiline = True
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(137, 27)
        Me.lblNamaUser.TabIndex = 6
        Me.lblNamaUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChangeLogToolStripMenuItem
        '
        Me.ChangeLogToolStripMenuItem.Name = "ChangeLogToolStripMenuItem"
        Me.ChangeLogToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ChangeLogToolStripMenuItem.Text = "Change Log"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMyIPToolStripMenuItem, Me.PingToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'ShowMyIPToolStripMenuItem
        '
        Me.ShowMyIPToolStripMenuItem.Name = "ShowMyIPToolStripMenuItem"
        Me.ShowMyIPToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ShowMyIPToolStripMenuItem.Text = "Show My IP"
        '
        'PingToolStripMenuItem
        '
        Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
        Me.PingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PingToolStripMenuItem.Text = "Ping"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.AnyarLocalPrintServices.My.Resources.Resources.blue_background_with_abstract_dynamic_shapes_1393_161
        Me.PictureBox2.Location = New System.Drawing.Point(3, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 540)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BackgroundImage = Global.AnyarLocalPrintServices.My.Resources.Resources.My_profile_orange
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.AnyarLocalPrintServices.My.Resources.Resources.My_profile_orange
        Me.PictureBox1.Location = New System.Drawing.Point(53, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 85)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'AnyarServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 604)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AnyarServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnyarServices"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemplateLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdPreviewDelivery As System.Windows.Forms.Button
    Friend WithEvents txtNoDelivery As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents CRVDelivery As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvGRPO As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPreviewGRPO As System.Windows.Forms.Button
    Friend WithEvents txtNoGRPO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents crvInventoryTransfer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPreviewInventoryTransfer As System.Windows.Forms.Button
    Friend WithEvents txtNoInventoryTransfer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents crvInventoryRequest As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPreviewInventoryRequest As System.Windows.Forms.Button
    Friend WithEvents txtNoInventoryRequest As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CRVGoodsIssue As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdPreviewGoodsIssue As System.Windows.Forms.Button
    Friend WithEvents txtNoGoodsIssue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents lblNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents ChangeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMyIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
