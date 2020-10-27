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
        Me.txtPesanError = New System.Windows.Forms.TextBox()
        Me.TimerPesanError = New System.Windows.Forms.Timer(Me.components)
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.txtJamDanWaktu = New System.Windows.Forms.TextBox()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberCardGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoucherCodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberCardStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoucherCodeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 706)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 23)
        Me.Panel3.TabIndex = 5
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MemberToolStripMenuItem, Me.PromotionToolStripMenuItem, Me.MonitoringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.H_Logout, Me.H_Shutdown})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'H_Logout
        '
        Me.H_Logout.Name = "H_Logout"
        Me.H_Logout.Size = New System.Drawing.Size(172, 22)
        Me.H_Logout.Text = "Logout"
        '
        'H_Shutdown
        '
        Me.H_Shutdown.Name = "H_Shutdown"
        Me.H_Shutdown.Size = New System.Drawing.Size(172, 22)
        Me.H_Shutdown.Text = "Shutdown Aplikasi"
        '
        'txtPesanError
        '
        Me.txtPesanError.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPesanError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesanError.Location = New System.Drawing.Point(367, 3)
        Me.txtPesanError.Name = "txtPesanError"
        Me.txtPesanError.ReadOnly = True
        Me.txtPesanError.Size = New System.Drawing.Size(961, 19)
        Me.txtPesanError.TabIndex = 10
        Me.txtPesanError.Visible = False
        '
        'TimerPesanError
        '
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'txtJamDanWaktu
        '
        Me.txtJamDanWaktu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJamDanWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJamDanWaktu.Location = New System.Drawing.Point(380, 3)
        Me.txtJamDanWaktu.Name = "txtJamDanWaktu"
        Me.txtJamDanWaktu.ReadOnly = True
        Me.txtJamDanWaktu.Size = New System.Drawing.Size(896, 19)
        Me.txtJamDanWaktu.TabIndex = 12
        Me.txtJamDanWaktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformasiMemberToolStripMenuItem, Me.MemberCardGeneratorToolStripMenuItem})
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'InformasiMemberToolStripMenuItem
        '
        Me.InformasiMemberToolStripMenuItem.Name = "InformasiMemberToolStripMenuItem"
        Me.InformasiMemberToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.InformasiMemberToolStripMenuItem.Text = "Informasi Member"
        '
        'MemberCardGeneratorToolStripMenuItem
        '
        Me.MemberCardGeneratorToolStripMenuItem.Name = "MemberCardGeneratorToolStripMenuItem"
        Me.MemberCardGeneratorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.MemberCardGeneratorToolStripMenuItem.Text = "Member Card Generator"
        '
        'PromotionToolStripMenuItem
        '
        Me.PromotionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoucherCodeGeneratorToolStripMenuItem})
        Me.PromotionToolStripMenuItem.Name = "PromotionToolStripMenuItem"
        Me.PromotionToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PromotionToolStripMenuItem.Text = "Promotion"
        '
        'VoucherCodeGeneratorToolStripMenuItem
        '
        Me.VoucherCodeGeneratorToolStripMenuItem.Name = "VoucherCodeGeneratorToolStripMenuItem"
        Me.VoucherCodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.VoucherCodeGeneratorToolStripMenuItem.Text = "Voucher Code Generator"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem1, Me.MemberCardStockToolStripMenuItem, Me.VoucherCodeStockToolStripMenuItem, Me.TransaksiMemberToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'MemberToolStripMenuItem1
        '
        Me.MemberToolStripMenuItem1.Name = "MemberToolStripMenuItem1"
        Me.MemberToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MemberToolStripMenuItem1.Text = "Member"
        '
        'MemberCardStockToolStripMenuItem
        '
        Me.MemberCardStockToolStripMenuItem.Name = "MemberCardStockToolStripMenuItem"
        Me.MemberCardStockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MemberCardStockToolStripMenuItem.Text = "Member Card Stock"
        '
        'VoucherCodeStockToolStripMenuItem
        '
        Me.VoucherCodeStockToolStripMenuItem.Name = "VoucherCodeStockToolStripMenuItem"
        Me.VoucherCodeStockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VoucherCodeStockToolStripMenuItem.Text = "Voucher Code Stock"
        '
        'TransaksiMemberToolStripMenuItem
        '
        Me.TransaksiMemberToolStripMenuItem.Name = "TransaksiMemberToolStripMenuItem"
        Me.TransaksiMemberToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TransaksiMemberToolStripMenuItem.Text = "Transaksi Member"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MonitoringMember.My.Resources.Resources.Batik_7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.Controls.Add(Me.txtJamDanWaktu)
        Me.Controls.Add(Me.txtPesanError)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMainMenu"
        Me.Text = "Monitoring Member"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents txtPesanError As System.Windows.Forms.TextBox
    Friend WithEvents TimerPesanError As System.Windows.Forms.Timer
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents txtJamDanWaktu As System.Windows.Forms.TextBox
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformasiMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberCardGeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PromotionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherCodeGeneratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberCardStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoucherCodeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
