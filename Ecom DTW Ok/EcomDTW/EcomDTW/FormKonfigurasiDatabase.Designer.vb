<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonfigurasiDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKonfigurasiDatabase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaServer = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNamaDatabase = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdSimpanKonfigurasi = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MYSQL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(160, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database Configurations"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNamaDatabase)
        Me.GroupBox1.Controls.Add(Me.txtNamaServer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 199)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Konfigurasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Server"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Database"
        '
        'txtNamaServer
        '
        Me.txtNamaServer.BaseColor = System.Drawing.Color.White
        Me.txtNamaServer.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaServer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaServer.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaServer.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaServer.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaServer.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaServer.Location = New System.Drawing.Point(191, 16)
        Me.txtNamaServer.Name = "txtNamaServer"
        Me.txtNamaServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaServer.Size = New System.Drawing.Size(276, 38)
        Me.txtNamaServer.TabIndex = 5
        '
        'txtNamaDatabase
        '
        Me.txtNamaDatabase.BaseColor = System.Drawing.Color.White
        Me.txtNamaDatabase.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaDatabase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaDatabase.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaDatabase.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaDatabase.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaDatabase.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDatabase.Location = New System.Drawing.Point(191, 59)
        Me.txtNamaDatabase.Name = "txtNamaDatabase"
        Me.txtNamaDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaDatabase.Size = New System.Drawing.Size(276, 38)
        Me.txtNamaDatabase.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BaseColor = System.Drawing.Color.White
        Me.txtUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(191, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Size = New System.Drawing.Size(276, 38)
        Me.txtUsername.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BaseColor = System.Drawing.Color.White
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(191, 147)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.Size = New System.Drawing.Size(276, 38)
        Me.txtPassword.TabIndex = 10
        '
        'cmdSimpanKonfigurasi
        '
        Me.cmdSimpanKonfigurasi.AnimationHoverSpeed = 0.07!
        Me.cmdSimpanKonfigurasi.AnimationSpeed = 0.03!
        Me.cmdSimpanKonfigurasi.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpanKonfigurasi.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpanKonfigurasi.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpanKonfigurasi.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpanKonfigurasi.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpanKonfigurasi.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpanKonfigurasi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpanKonfigurasi.ForeColor = System.Drawing.Color.White
        Me.cmdSimpanKonfigurasi.Image = Nothing
        Me.cmdSimpanKonfigurasi.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpanKonfigurasi.Location = New System.Drawing.Point(382, 315)
        Me.cmdSimpanKonfigurasi.Name = "cmdSimpanKonfigurasi"
        Me.cmdSimpanKonfigurasi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpanKonfigurasi.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpanKonfigurasi.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpanKonfigurasi.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpanKonfigurasi.OnHoverImage = Nothing
        Me.cmdSimpanKonfigurasi.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpanKonfigurasi.Radius = 2
        Me.cmdSimpanKonfigurasi.Size = New System.Drawing.Size(126, 37)
        Me.cmdSimpanKonfigurasi.TabIndex = 36
        Me.cmdSimpanKonfigurasi.Text = "Simpan"
        Me.cmdSimpanKonfigurasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.mysql_logo
        Me.PictureBox1.Location = New System.Drawing.Point(30, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 299)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(534, 68)
        Me.GunaPictureBox1.TabIndex = 39
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(534, 68)
        Me.GunaPictureBox2.TabIndex = 40
        Me.GunaPictureBox2.TabStop = False
        '
        'FormKonfigurasiDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 364)
        Me.Controls.Add(Me.cmdSimpanKonfigurasi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKonfigurasiDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKonfigurasiDatabase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaServer As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDatabase As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdSimpanKonfigurasi As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
