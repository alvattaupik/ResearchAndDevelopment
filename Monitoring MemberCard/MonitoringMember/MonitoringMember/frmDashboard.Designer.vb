<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNamaCabang = New Guna.UI.WinForms.GunaLabel()
        Me.lblKodeCabang = New Guna.UI.WinForms.GunaLabel()
        Me.lblSiteID = New Guna.UI.WinForms.GunaLabel()
        Me.lblNamaUser = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJamDigital = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.timerDashboard = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTransfarantPictureBox7 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox6 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picLogout = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox7)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox6)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox5)
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
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 705)
        Me.Panel1.TabIndex = 40
        '
        'lblNamaCabang
        '
        Me.lblNamaCabang.AutoSize = True
        Me.lblNamaCabang.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaCabang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaCabang.ForeColor = System.Drawing.Color.White
        Me.lblNamaCabang.Location = New System.Drawing.Point(31, 340)
        Me.lblNamaCabang.Name = "lblNamaCabang"
        Me.lblNamaCabang.Size = New System.Drawing.Size(68, 13)
        Me.lblNamaCabang.TabIndex = 11
        Me.lblNamaCabang.Text = "GunaLabel1"
        '
        'lblKodeCabang
        '
        Me.lblKodeCabang.AutoSize = True
        Me.lblKodeCabang.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeCabang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeCabang.ForeColor = System.Drawing.Color.White
        Me.lblKodeCabang.Location = New System.Drawing.Point(31, 390)
        Me.lblKodeCabang.Name = "lblKodeCabang"
        Me.lblKodeCabang.Size = New System.Drawing.Size(68, 13)
        Me.lblKodeCabang.TabIndex = 10
        Me.lblKodeCabang.Text = "GunaLabel1"
        '
        'lblSiteID
        '
        Me.lblSiteID.AutoSize = True
        Me.lblSiteID.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSiteID.ForeColor = System.Drawing.Color.White
        Me.lblSiteID.Location = New System.Drawing.Point(31, 374)
        Me.lblSiteID.Name = "lblSiteID"
        Me.lblSiteID.Size = New System.Drawing.Size(68, 13)
        Me.lblSiteID.TabIndex = 9
        Me.lblSiteID.Text = "GunaLabel1"
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaUser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaUser.ForeColor = System.Drawing.Color.White
        Me.lblNamaUser.Location = New System.Drawing.Point(31, 357)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(68, 13)
        Me.lblNamaUser.TabIndex = 8
        Me.lblNamaUser.Text = "GunaLabel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblJamDigital)
        Me.Panel2.Location = New System.Drawing.Point(12, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 45)
        Me.Panel2.TabIndex = 7
        '
        'lblJamDigital
        '
        Me.lblJamDigital.AutoSize = True
        Me.lblJamDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamDigital.Location = New System.Drawing.Point(44, 7)
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
        Me.WebBrowser1.Location = New System.Drawing.Point(264, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(661, 668)
        Me.WebBrowser1.TabIndex = 41
        '
        'timerDashboard
        '
        Me.timerDashboard.Interval = 1000
        '
        'GunaTransfarantPictureBox7
        '
        Me.GunaTransfarantPictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox7.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox7.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9_rotate
        Me.GunaTransfarantPictureBox7.Location = New System.Drawing.Point(126, 548)
        Me.GunaTransfarantPictureBox7.Name = "GunaTransfarantPictureBox7"
        Me.GunaTransfarantPictureBox7.Size = New System.Drawing.Size(133, 120)
        Me.GunaTransfarantPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox7.TabIndex = 15
        Me.GunaTransfarantPictureBox7.TabStop = False
        '
        'GunaTransfarantPictureBox6
        '
        Me.GunaTransfarantPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox6.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox6.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9_rotate
        Me.GunaTransfarantPictureBox6.Location = New System.Drawing.Point(0, 548)
        Me.GunaTransfarantPictureBox6.Name = "GunaTransfarantPictureBox6"
        Me.GunaTransfarantPictureBox6.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox6.TabIndex = 14
        Me.GunaTransfarantPictureBox6.TabStop = False
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(126, 0)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(133, 120)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 13
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox3.Image = Global.MonitoringMember.My.Resources.Resources.Users_Dashboard
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(56, 243)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(76, 71)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox3.TabIndex = 6
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'picLogout
        '
        Me.picLogout.BaseColor = System.Drawing.Color.White
        Me.picLogout.Image = Global.MonitoringMember.My.Resources.Resources.Logout_Icon
        Me.picLogout.Location = New System.Drawing.Point(184, 223)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(65, 67)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 3
        Me.picLogout.TabStop = False
        Me.picLogout.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Image = Global.MonitoringMember.My.Resources.Resources.Ubah_Password_logo
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(184, 315)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(65, 63)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaCirclePictureBox3.TabIndex = 4
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.Lembar_Kertas_Dashboard
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(12, 223)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(166, 330)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 5
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Hello__yellow_
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(12, 72)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(237, 94)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 2
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 12
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 664)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaTransfarantPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNamaCabang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblKodeCabang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSiteID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblNamaUser As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJamDigital As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents picLogout As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox6 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox7 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents timerDashboard As System.Windows.Forms.Timer
End Class
