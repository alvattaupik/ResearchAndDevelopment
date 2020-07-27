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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitoringDelivery))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkAllDelivey = New Guna.UI.WinForms.GunaCheckBox()
        Me.cmdShow = New Guna.UI.WinForms.GunaGradientButton()
        Me.dtpTgl2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTgl1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblJumlahItemTransaksi = New System.Windows.Forms.Label()
        Me.dgItemDelivery = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AvailableToPromiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblJumlahTransaksi = New System.Windows.Forms.Label()
        Me.dgDaftarDelivery = New System.Windows.Forms.DataGridView()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitoring Delivery"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.chkAllDelivey)
        Me.Panel2.Controls.Add(Me.cmdShow)
        Me.Panel2.Controls.Add(Me.dtpTgl2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpTgl1)
        Me.Panel2.Location = New System.Drawing.Point(1, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 126)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnyarGadget.My.Resources.Resources.Inventory_PNG_HD
        Me.PictureBox1.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'chkAllDelivey
        '
        Me.chkAllDelivey.BaseColor = System.Drawing.Color.White
        Me.chkAllDelivey.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkAllDelivey.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAllDelivey.FillColor = System.Drawing.Color.White
        Me.chkAllDelivey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllDelivey.Location = New System.Drawing.Point(168, 91)
        Me.chkAllDelivey.Name = "chkAllDelivey"
        Me.chkAllDelivey.Size = New System.Drawing.Size(316, 21)
        Me.chkAllDelivey.TabIndex = 37
        Me.chkAllDelivey.Text = "Tampilkan Delivery Dari Semua Cabang"
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
        Me.cmdShow.Location = New System.Drawing.Point(483, 4)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShow.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdShow.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdShow.OnHoverImage = Nothing
        Me.cmdShow.OnPressedColor = System.Drawing.Color.Black
        Me.cmdShow.Radius = 2
        Me.cmdShow.Size = New System.Drawing.Size(91, 81)
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
        Me.dtpTgl2.Location = New System.Drawing.Point(168, 56)
        Me.dtpTgl2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl2.Name = "dtpTgl2"
        Me.dtpTgl2.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl2.Size = New System.Drawing.Size(309, 29)
        Me.dtpTgl2.TabIndex = 3
        Me.dtpTgl2.Text = "26/05/2020"
        Me.dtpTgl2.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 33)
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
        Me.dtpTgl1.Location = New System.Drawing.Point(168, 3)
        Me.dtpTgl1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl1.Name = "dtpTgl1"
        Me.dtpTgl1.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl1.Size = New System.Drawing.Size(309, 29)
        Me.dtpTgl1.TabIndex = 1
        Me.dtpTgl1.Text = "26/05/2020"
        Me.dtpTgl1.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GunaPictureBox2)
        Me.Panel3.Controls.Add(Me.lblJumlahItemTransaksi)
        Me.Panel3.Controls.Add(Me.dgItemDelivery)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(588, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(779, 742)
        Me.Panel3.TabIndex = 3
        '
        'lblJumlahItemTransaksi
        '
        Me.lblJumlahItemTransaksi.AutoSize = True
        Me.lblJumlahItemTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahItemTransaksi.ForeColor = System.Drawing.Color.White
        Me.lblJumlahItemTransaksi.Location = New System.Drawing.Point(10, 582)
        Me.lblJumlahItemTransaksi.Name = "lblJumlahItemTransaksi"
        Me.lblJumlahItemTransaksi.Size = New System.Drawing.Size(107, 20)
        Me.lblJumlahItemTransaksi.TabIndex = 3
        Me.lblJumlahItemTransaksi.Text = "Jumlah Item"
        '
        'dgItemDelivery
        '
        Me.dgItemDelivery.AllowUserToAddRows = False
        Me.dgItemDelivery.AllowUserToDeleteRows = False
        Me.dgItemDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemDelivery.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgItemDelivery.Location = New System.Drawing.Point(14, 38)
        Me.dgItemDelivery.Name = "dgItemDelivery"
        Me.dgItemDelivery.ReadOnly = True
        Me.dgItemDelivery.Size = New System.Drawing.Size(756, 541)
        Me.dgItemDelivery.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvailableToPromiseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 26)
        '
        'AvailableToPromiseToolStripMenuItem
        '
        Me.AvailableToPromiseToolStripMenuItem.Name = "AvailableToPromiseToolStripMenuItem"
        Me.AvailableToPromiseToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AvailableToPromiseToolStripMenuItem.Text = "Available To Promise"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(339, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Item"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 202)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(584, 548)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GunaPictureBox1)
        Me.TabPage1.Controls.Add(Me.lblJumlahTransaksi)
        Me.TabPage1.Controls.Add(Me.dgDaftarDelivery)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(576, 522)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Delivery"
        '
        'lblJumlahTransaksi
        '
        Me.lblJumlahTransaksi.AutoSize = True
        Me.lblJumlahTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahTransaksi.ForeColor = System.Drawing.Color.White
        Me.lblJumlahTransaksi.Location = New System.Drawing.Point(3, 362)
        Me.lblJumlahTransaksi.Name = "lblJumlahTransaksi"
        Me.lblJumlahTransaksi.Size = New System.Drawing.Size(292, 20)
        Me.lblJumlahTransaksi.TabIndex = 4
        Me.lblJumlahTransaksi.Text = "Jumlah Transaksi Untuk Di Kirim : 0"
        '
        'dgDaftarDelivery
        '
        Me.dgDaftarDelivery.AllowUserToAddRows = False
        Me.dgDaftarDelivery.AllowUserToDeleteRows = False
        Me.dgDaftarDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarDelivery.Location = New System.Drawing.Point(6, 6)
        Me.dgDaftarDelivery.Name = "dgDaftarDelivery"
        Me.dgDaftarDelivery.ReadOnly = True
        Me.dgDaftarDelivery.Size = New System.Drawing.Size(564, 353)
        Me.dgDaftarDelivery.TabIndex = 3
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(3, 439)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(570, 80)
        Me.GunaPictureBox1.TabIndex = 39
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 662)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(779, 80)
        Me.GunaPictureBox2.TabIndex = 40
        Me.GunaPictureBox2.TabStop = False
        '
        'MonitoringDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(229, 3)
        Me.Name = "MonitoringDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monitoring Delivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpTgl2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cmdShow As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblJumlahItemTransaksi As System.Windows.Forms.Label
    Friend WithEvents dgItemDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblJumlahTransaksi As System.Windows.Forms.Label
    Friend WithEvents dgDaftarDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents chkAllDelivey As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AvailableToPromiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
