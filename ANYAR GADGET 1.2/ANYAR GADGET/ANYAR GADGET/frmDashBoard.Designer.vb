<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashBoard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNamaCabang = New Guna.UI.WinForms.GunaLabel()
        Me.lblKodeCabang = New Guna.UI.WinForms.GunaLabel()
        Me.lblSiteID = New Guna.UI.WinForms.GunaLabel()
        Me.lblNamaUser = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJamDigital = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.timerDashboard = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picLogout = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblNamaCabang)
        Me.Panel1.Controls.Add(Me.lblKodeCabang)
        Me.Panel1.Controls.Add(Me.lblSiteID)
        Me.Panel1.Controls.Add(Me.lblNamaUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox3)
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.GunaCirclePictureBox3)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 601)
        Me.Panel1.TabIndex = 39
        '
        'lblNamaCabang
        '
        Me.lblNamaCabang.AutoSize = True
        Me.lblNamaCabang.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaCabang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaCabang.ForeColor = System.Drawing.Color.White
        Me.lblNamaCabang.Location = New System.Drawing.Point(31, 325)
        Me.lblNamaCabang.Name = "lblNamaCabang"
        Me.lblNamaCabang.Size = New System.Drawing.Size(69, 15)
        Me.lblNamaCabang.TabIndex = 11
        Me.lblNamaCabang.Text = "GunaLabel1"
        '
        'lblKodeCabang
        '
        Me.lblKodeCabang.AutoSize = True
        Me.lblKodeCabang.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeCabang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKodeCabang.ForeColor = System.Drawing.Color.White
        Me.lblKodeCabang.Location = New System.Drawing.Point(31, 383)
        Me.lblKodeCabang.Name = "lblKodeCabang"
        Me.lblKodeCabang.Size = New System.Drawing.Size(69, 15)
        Me.lblKodeCabang.TabIndex = 10
        Me.lblKodeCabang.Text = "GunaLabel1"
        '
        'lblSiteID
        '
        Me.lblSiteID.AutoSize = True
        Me.lblSiteID.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSiteID.ForeColor = System.Drawing.Color.White
        Me.lblSiteID.Location = New System.Drawing.Point(31, 364)
        Me.lblSiteID.Name = "lblSiteID"
        Me.lblSiteID.Size = New System.Drawing.Size(69, 15)
        Me.lblSiteID.TabIndex = 9
        Me.lblSiteID.Text = "GunaLabel1"
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaUser.ForeColor = System.Drawing.Color.White
        Me.lblNamaUser.Location = New System.Drawing.Point(31, 344)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(69, 15)
        Me.lblNamaUser.TabIndex = 8
        Me.lblNamaUser.Text = "GunaLabel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblJamDigital)
        Me.Panel2.Location = New System.Drawing.Point(8, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 89)
        Me.Panel2.TabIndex = 7
        '
        'lblJamDigital
        '
        Me.lblJamDigital.AutoSize = True
        Me.lblJamDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamDigital.Location = New System.Drawing.Point(66, 27)
        Me.lblJamDigital.Name = "lblJamDigital"
        Me.lblJamDigital.Size = New System.Drawing.Size(71, 31)
        Me.lblJamDigital.TabIndex = 0
        Me.lblJamDigital.Text = "JAM"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(265, 1)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(811, 601)
        Me.WebBrowser1.TabIndex = 40
        '
        'timerDashboard
        '
        Me.timerDashboard.Enabled = True
        Me.timerDashboard.Interval = 1000
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        'Me.GunaTransfarantPictureBox3.Image = Global.ANYAR_GADGET.My.Resources.Resources._62681_flat_icons_face_computer_design_avatar_icon
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(56, 238)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(75, 73)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox3.TabIndex = 6
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'picLogout
        '
        Me.picLogout.BaseColor = System.Drawing.Color.White
        'Me.picLogout.Image = Global.ANYAR_GADGET.My.Resources.Resources._89754008_logout_isolated_on_elegant_brown_round_button_abstract_illustration
        Me.picLogout.Location = New System.Drawing.Point(184, 211)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(65, 67)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogout.TabIndex = 3
        Me.picLogout.TabStop = False
        Me.picLogout.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        'Me.GunaCirclePictureBox3.Image = Global.ANYAR_GADGET.My.Resources.Resources.download__1_
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(184, 291)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(65, 68)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 4
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        'Me.GunaTransfarantPictureBox2.Image = Global.ANYAR_GADGET.My.Resources.Resources.b0eca009f960c22eb55b3e3137af97e4
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(12, 211)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(166, 381)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 5
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        'Me.GunaTransfarantPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Hello__yellow_
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(72, 72)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(116, 38)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 2
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        'Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.unnamed__3_
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1075, 604)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents picLogout As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents lblKodeCabang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSiteID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblNamaUser As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNamaCabang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblJamDigital As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents timerDashboard As System.Windows.Forms.Timer
End Class
