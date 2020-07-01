<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnyarChat
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
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.cmbListIp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdHubungkan = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.SISTER.My.Resources.Resources.Logo_Anyar_PNG
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(2, 12)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'cmbListIp
        '
        Me.cmbListIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbListIp.FormattingEnabled = True
        Me.cmbListIp.Location = New System.Drawing.Point(240, 24)
        Me.cmbListIp.Name = "cmbListIp"
        Me.cmbListIp.Size = New System.Drawing.Size(248, 26)
        Me.cmbListIp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Kontak"
        '
        'cmdHubungkan
        '
        Me.cmdHubungkan.AnimationHoverSpeed = 0.07!
        Me.cmdHubungkan.AnimationSpeed = 0.03!
        Me.cmdHubungkan.BackColor = System.Drawing.Color.Transparent
        Me.cmdHubungkan.BaseColor1 = System.Drawing.Color.Crimson
        Me.cmdHubungkan.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdHubungkan.BorderColor = System.Drawing.Color.Black
        Me.cmdHubungkan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdHubungkan.FocusedColor = System.Drawing.Color.Empty
        Me.cmdHubungkan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdHubungkan.ForeColor = System.Drawing.Color.White
        Me.cmdHubungkan.Image = Nothing
        Me.cmdHubungkan.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdHubungkan.Location = New System.Drawing.Point(240, 95)
        Me.cmdHubungkan.Name = "cmdHubungkan"
        Me.cmdHubungkan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdHubungkan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdHubungkan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdHubungkan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdHubungkan.OnHoverImage = Nothing
        Me.cmdHubungkan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdHubungkan.Radius = 2
        Me.cmdHubungkan.Size = New System.Drawing.Size(248, 37)
        Me.cmdHubungkan.TabIndex = 28
        Me.cmdHubungkan.Text = "Hubungkan"
        Me.cmdHubungkan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Display Name"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(240, 57)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(246, 24)
        Me.txtDisplayName.TabIndex = 30
        '
        'FormAnyarChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 140)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdHubungkan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbListIp)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Name = "FormAnyarChat"
        Me.Text = "FormAnyarChat"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents cmbListIp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdHubungkan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
End Class
