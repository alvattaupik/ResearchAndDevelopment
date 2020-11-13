<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnCancel = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnLogin = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsernameLogin = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnCancel.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(197, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 2
        Me.btnCancel.Size = New System.Drawing.Size(92, 37)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnLogin.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(83, 212)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 2
        Me.btnLogin.Size = New System.Drawing.Size(96, 37)
        Me.btnLogin.TabIndex = 35
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(6, 168)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Radius = 2
        Me.txtPassword.Size = New System.Drawing.Size(282, 37)
        Me.txtPassword.TabIndex = 34
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 146)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(67, 19)
        Me.GunaLabel4.TabIndex = 33
        Me.GunaLabel4.Text = "Password"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(2, 86)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(71, 19)
        Me.GunaLabel3.TabIndex = 31
        Me.GunaLabel3.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(57, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 37)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Monitoring"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(90, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Member"
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.BackColor = System.Drawing.Color.Transparent
        Me.txtUsernameLogin.BaseColor = System.Drawing.Color.Gainsboro
        Me.txtUsernameLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.txtUsernameLogin.BorderSize = 1
        Me.txtUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameLogin.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsernameLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsernameLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsernameLogin.ForeColor = System.Drawing.Color.White
        Me.txtUsernameLogin.Location = New System.Drawing.Point(7, 105)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameLogin.Radius = 2
        Me.txtUsernameLogin.Size = New System.Drawing.Size(282, 37)
        Me.txtUsernameLogin.TabIndex = 42
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.MonitoringMember.My.Resources.Resources.Batik_6
        Me.PictureBox3.Location = New System.Drawing.Point(305, -8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(309, 317)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Batik_3
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 255)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(518, 54)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 37
        Me.GunaPictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(518, 309)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtUsernameLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsernameLogin As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
