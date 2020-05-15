<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUsernamePassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPathAplikasi = New System.Windows.Forms.TextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BaseColor = System.Drawing.Color.White
        Me.txtUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Enabled = False
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(215, 46)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Size = New System.Drawing.Size(181, 26)
        Me.txtUsername.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.BaseColor = System.Drawing.Color.White
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(215, 86)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.Size = New System.Drawing.Size(181, 26)
        Me.txtPassword.TabIndex = 9
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(6, 143)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(125, 33)
        Me.cmdBrowse.TabIndex = 10
        Me.cmdBrowse.Text = "Browse..."
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.AnimationHoverSpeed = 0.07!
        Me.cmdSimpan.AnimationSpeed = 0.03!
        Me.cmdSimpan.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpan.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpan.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpan.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpan.ForeColor = System.Drawing.Color.White
        Me.cmdSimpan.Image = Nothing
        Me.cmdSimpan.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpan.Location = New System.Drawing.Point(265, 137)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(128, 37)
        Me.cmdSimpan.TabIndex = 28
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPathAplikasi
        '
        Me.txtPathAplikasi.Location = New System.Drawing.Point(6, 3)
        Me.txtPathAplikasi.Name = "txtPathAplikasi"
        Me.txtPathAplikasi.Size = New System.Drawing.Size(125, 20)
        Me.txtPathAplikasi.TabIndex = 29
        Me.txtPathAplikasi.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaPictureBox1.Location = New System.Drawing.Point(8, 28)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(123, 109)
        Me.GunaPictureBox1.TabIndex = 30
        Me.GunaPictureBox1.TabStop = False
        '
        'EditUsernamePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 184)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txtPathAplikasi)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "EditUsernamePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditUsernamePassword"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPathAplikasi As System.Windows.Forms.TextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
