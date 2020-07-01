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
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdConnectNotif = New System.Windows.Forms.Button()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.cmdMonitoringRealstock = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.PanelSideBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdMonitoringRealstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideBar
        '
        Me.PanelSideBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSideBar.BackColor = System.Drawing.Color.Transparent
        Me.PanelSideBar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.lblJam)
        Me.PanelSideBar.Controls.Add(Me.lblHari)
        Me.PanelSideBar.Controls.Add(Me.Label3)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.GunaCirclePictureBox4)
        Me.PanelSideBar.Controls.Add(Me.TabControl1)
        Me.PanelSideBar.Controls.Add(Me.Panel2)
        Me.PanelSideBar.Location = New System.Drawing.Point(-8, 1)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(227, 603)
        Me.PanelSideBar.TabIndex = 8
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.Location = New System.Drawing.Point(127, 95)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(47, 25)
        Me.lblJam.TabIndex = 10
        Me.lblJam.Text = "Jam"
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.Location = New System.Drawing.Point(126, 48)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(50, 25)
        Me.lblHari.TabIndex = 9
        Me.lblHari.Text = "Hari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Build xx.xx.xxx"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Anyar Gadget V1.1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 139)
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
        Me.txtLocation.Location = New System.Drawing.Point(7, 161)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
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
        Me.txtNamaUser.Location = New System.Drawing.Point(7, 126)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaUser.Size = New System.Drawing.Size(174, 30)
        Me.txtNamaUser.TabIndex = 39
        Me.txtNamaUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Halo, Selamat Datang"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.GunaGradientButton2)
        Me.GunaLinePanel1.Controls.Add(Me.GunaGradientButton1)
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
        Me.GunaGradientButton2.Location = New System.Drawing.Point(4, 50)
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(4, 7)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(165, 37)
        Me.GunaGradientButton1.TabIndex = 36
        Me.GunaGradientButton1.Text = "Ubah Foto "
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdMonitoringRealstock)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 37)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Dashboard"
        '
        'TimerJam
        '
        Me.TimerJam.Interval = 1000
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox4.Image = Global.AnyarGadget.My.Resources.Resources.LOGO_ANYAR_BULAT
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(12, 48)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(86, 84)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 5
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BackColor = System.Drawing.Color.LightGray
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(51, 39)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(84, 82)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 0
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'cmdMonitoringRealstock
        '
        Me.cmdMonitoringRealstock.BaseColor = System.Drawing.Color.White
        Me.cmdMonitoringRealstock.Image = Global.AnyarGadget.My.Resources.Resources.marketing_monitoring
        Me.cmdMonitoringRealstock.Location = New System.Drawing.Point(4, 6)
        Me.cmdMonitoringRealstock.Name = "cmdMonitoringRealstock"
        Me.cmdMonitoringRealstock.Size = New System.Drawing.Size(52, 50)
        Me.cmdMonitoringRealstock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cmdMonitoringRealstock.TabIndex = 0
        Me.cmdMonitoringRealstock.TabStop = False
        Me.cmdMonitoringRealstock.UseTransfarantBackground = False
        '
        'SideBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 564)
        Me.Controls.Add(Me.PanelSideBar)
        Me.Location = New System.Drawing.Point(7, 77)
        Me.Name = "SideBar"
        Me.Text = "SideBar"
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelSideBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdMonitoringRealstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents PanelSideBar As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtNamaUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtLocation As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdConnectNotif As System.Windows.Forms.Button
    Friend WithEvents txtSiteID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblHari As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblJam As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents cmdMonitoringRealstock As Guna.UI.WinForms.GunaCirclePictureBox
End Class
