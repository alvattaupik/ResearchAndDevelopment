<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoringDelivery
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdShow = New Guna.UI.WinForms.GunaGradientButton()
        Me.dtpTgl2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTgl1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgItemDelivery = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgDaftarDelivery = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgDaftarTransfer = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgDaftarTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitoring Delivery"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cmdShow)
        Me.Panel2.Controls.Add(Me.dtpTgl2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpTgl1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 50)
        Me.Panel2.TabIndex = 1
        '
        'cmdShow
        '
        Me.cmdShow.AnimationHoverSpeed = 0.07!
        Me.cmdShow.AnimationSpeed = 0.03!
        Me.cmdShow.BackColor = System.Drawing.Color.Transparent
        Me.cmdShow.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdShow.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdShow.BorderColor = System.Drawing.Color.Black
        Me.cmdShow.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdShow.FocusedColor = System.Drawing.Color.Empty
        Me.cmdShow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdShow.ForeColor = System.Drawing.Color.White
        Me.cmdShow.Image = Nothing
        Me.cmdShow.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdShow.Location = New System.Drawing.Point(399, 6)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShow.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdShow.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdShow.OnHoverImage = Nothing
        Me.cmdShow.OnPressedColor = System.Drawing.Color.Black
        Me.cmdShow.Radius = 2
        Me.cmdShow.Size = New System.Drawing.Size(91, 37)
        Me.cmdShow.TabIndex = 36
        Me.cmdShow.Text = "Show"
        Me.cmdShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpTgl2
        '
        Me.dtpTgl2.BaseColor = System.Drawing.Color.White
        Me.dtpTgl2.BorderColor = System.Drawing.Color.Silver
        Me.dtpTgl2.CustomFormat = Nothing
        Me.dtpTgl2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTgl2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTgl2.ForeColor = System.Drawing.Color.Black
        Me.dtpTgl2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl2.Location = New System.Drawing.Point(272, 11)
        Me.dtpTgl2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl2.Name = "dtpTgl2"
        Me.dtpTgl2.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl2.Size = New System.Drawing.Size(121, 29)
        Me.dtpTgl2.TabIndex = 3
        Me.dtpTgl2.Text = "26/05/2020"
        Me.dtpTgl2.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "S/D"
        '
        'dtpTgl1
        '
        Me.dtpTgl1.BaseColor = System.Drawing.Color.White
        Me.dtpTgl1.BorderColor = System.Drawing.Color.Silver
        Me.dtpTgl1.CustomFormat = Nothing
        Me.dtpTgl1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTgl1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTgl1.ForeColor = System.Drawing.Color.Black
        Me.dtpTgl1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl1.Location = New System.Drawing.Point(100, 11)
        Me.dtpTgl1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl1.Name = "dtpTgl1"
        Me.dtpTgl1.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl1.Size = New System.Drawing.Size(121, 29)
        Me.dtpTgl1.TabIndex = 1
        Me.dtpTgl1.Text = "26/05/2020"
        Me.dtpTgl1.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Parameter"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.dgItemDelivery)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(502, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(607, 572)
        Me.Panel3.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah Item"
        '
        'dgItemDelivery
        '
        Me.dgItemDelivery.AllowUserToAddRows = False
        Me.dgItemDelivery.AllowUserToDeleteRows = False
        Me.dgItemDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemDelivery.Location = New System.Drawing.Point(3, 28)
        Me.dgItemDelivery.Name = "dgItemDelivery"
        Me.dgItemDelivery.ReadOnly = True
        Me.dgItemDelivery.Size = New System.Drawing.Size(595, 517)
        Me.dgItemDelivery.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Item"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 450)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dgDaftarDelivery)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaksi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jumlah Transaksi Customer"
        '
        'dgDaftarDelivery
        '
        Me.dgDaftarDelivery.AllowUserToAddRows = False
        Me.dgDaftarDelivery.AllowUserToDeleteRows = False
        Me.dgDaftarDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarDelivery.Location = New System.Drawing.Point(7, 6)
        Me.dgDaftarDelivery.Name = "dgDaftarDelivery"
        Me.dgDaftarDelivery.ReadOnly = True
        Me.dgDaftarDelivery.Size = New System.Drawing.Size(474, 391)
        Me.dgDaftarDelivery.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.dgDaftarTransfer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(487, 282)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transfer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jumlah Transaksi Transfer"
        '
        'dgDaftarTransfer
        '
        Me.dgDaftarTransfer.AllowUserToAddRows = False
        Me.dgDaftarTransfer.AllowUserToDeleteRows = False
        Me.dgDaftarTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarTransfer.Location = New System.Drawing.Point(6, 6)
        Me.dgDaftarTransfer.Name = "dgDaftarTransfer"
        Me.dgDaftarTransfer.ReadOnly = True
        Me.dgDaftarTransfer.Size = New System.Drawing.Size(474, 249)
        Me.dgDaftarTransfer.TabIndex = 4
        '
        'MonitoringDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(229, 3)
        Me.Name = "MonitoringDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MonitoringDelivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgDaftarTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpTgl2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdShow As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgItemDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgDaftarDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgDaftarTransfer As System.Windows.Forms.DataGridView
End Class
