﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.cmdBatal = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBatal
        '
        Me.cmdBatal.AnimationHoverSpeed = 0.07!
        Me.cmdBatal.AnimationSpeed = 0.03!
        Me.cmdBatal.BackColor = System.Drawing.Color.Transparent
        Me.cmdBatal.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdBatal.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdBatal.BorderColor = System.Drawing.Color.Black
        Me.cmdBatal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdBatal.FocusedColor = System.Drawing.Color.Empty
        Me.cmdBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdBatal.ForeColor = System.Drawing.Color.White
        Me.cmdBatal.Image = Nothing
        Me.cmdBatal.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdBatal.Location = New System.Drawing.Point(361, 234)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBatal.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBatal.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBatal.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBatal.OnHoverImage = Nothing
        Me.cmdBatal.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBatal.Radius = 2
        Me.cmdBatal.Size = New System.Drawing.Size(126, 37)
        Me.cmdBatal.TabIndex = 47
        Me.cmdBatal.Text = "Cancel"
        Me.cmdBatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(229, 234)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(126, 37)
        Me.GunaGradientButton1.TabIndex = 45
        Me.GunaGradientButton1.Text = "Login"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(210, 291)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(126, 15)
        Me.GunaLinkLabel1.TabIndex = 46
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "Forget your password?"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(229, 188)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Radius = 2
        Me.txtPassword.Size = New System.Drawing.Size(258, 37)
        Me.txtPassword.TabIndex = 44
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(150, 188)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel4.TabIndex = 43
        Me.GunaLabel4.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.txtUsername.BorderSize = 1
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(229, 145)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Radius = 2
        Me.txtUsername.Size = New System.Drawing.Size(258, 37)
        Me.txtUsername.TabIndex = 42
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(146, 145)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(71, 19)
        Me.GunaLabel3.TabIndex = 41
        Me.GunaLabel3.Text = "Username"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(226, 110)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel2.TabIndex = 40
        Me.GunaLabel2.Text = "Let's join us :)"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(224, 71)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(191, 28)
        Me.GunaLabel1.TabIndex = 39
        Me.GunaLabel1.Text = "Here you can login"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 231)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(553, 106)
        Me.GunaPictureBox1.TabIndex = 38
        Me.GunaPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.transfer_db
        Me.PictureBox1.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "E-Comm DTW 1.0"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(553, 337)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents cmdBatal As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
