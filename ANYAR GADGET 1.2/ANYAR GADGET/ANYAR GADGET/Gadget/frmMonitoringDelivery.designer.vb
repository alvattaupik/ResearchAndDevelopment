<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoringDelivery
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDeliveryBelumDikirim = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblDeliverySudahDikirim = New System.Windows.Forms.Label()
        Me.dgDeliverySudahDikirim = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvMonitoringDeliveryOnline = New System.Windows.Forms.DataGridView()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.gbAvailableToPromise = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgDeliveryBelumDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDeliverySudahDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvMonitoringDeliveryOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAvailableToPromise.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitoring Delivery"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.chkAllDelivey)
        Me.Panel2.Controls.Add(Me.cmdShow)
        Me.Panel2.Controls.Add(Me.dtpTgl2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpTgl1)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 109)
        Me.Panel2.TabIndex = 1
        '
        'chkAllDelivey
        '
        Me.chkAllDelivey.BaseColor = System.Drawing.Color.White
        Me.chkAllDelivey.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkAllDelivey.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkAllDelivey.Enabled = False
        Me.chkAllDelivey.FillColor = System.Drawing.Color.White
        Me.chkAllDelivey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllDelivey.Location = New System.Drawing.Point(135, 78)
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
        Me.cmdShow.Location = New System.Drawing.Point(447, 36)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShow.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdShow.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdShow.OnHoverImage = Nothing
        Me.cmdShow.OnPressedColor = System.Drawing.Color.Black
        Me.cmdShow.Radius = 2
        Me.cmdShow.Size = New System.Drawing.Size(133, 41)
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
        Me.dtpTgl2.Location = New System.Drawing.Point(312, 36)
        Me.dtpTgl2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl2.Name = "dtpTgl2"
        Me.dtpTgl2.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl2.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl2.Size = New System.Drawing.Size(113, 29)
        Me.dtpTgl2.TabIndex = 3
        Me.dtpTgl2.Text = "26/05/2020"
        Me.dtpTgl2.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 43)
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
        Me.dtpTgl1.Location = New System.Drawing.Point(135, 38)
        Me.dtpTgl1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl1.Name = "dtpTgl1"
        Me.dtpTgl1.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl1.Size = New System.Drawing.Size(126, 29)
        Me.dtpTgl1.TabIndex = 1
        Me.dtpTgl1.Text = "26/05/2020"
        Me.dtpTgl1.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dgItemDelivery)
        Me.Panel3.Controls.Add(Me.lblJumlahItemTransaksi)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(3, 436)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 10)
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
        Me.dgItemDelivery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgItemDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemDelivery.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgItemDelivery.Location = New System.Drawing.Point(10, 29)
        Me.dgItemDelivery.Name = "dgItemDelivery"
        Me.dgItemDelivery.ReadOnly = True
        Me.dgItemDelivery.Size = New System.Drawing.Size(568, 0)
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
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Item"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(3, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(589, 310)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblJumlahTransaksi)
        Me.TabPage1.Controls.Add(Me.dgDaftarDelivery)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(581, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semua Delivery"
        '
        'lblJumlahTransaksi
        '
        Me.lblJumlahTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahTransaksi.AutoSize = True
        Me.lblJumlahTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahTransaksi.ForeColor = System.Drawing.Color.Black
        Me.lblJumlahTransaksi.Location = New System.Drawing.Point(6, 258)
        Me.lblJumlahTransaksi.Name = "lblJumlahTransaksi"
        Me.lblJumlahTransaksi.Size = New System.Drawing.Size(209, 20)
        Me.lblJumlahTransaksi.TabIndex = 4
        Me.lblJumlahTransaksi.Text = "Total Seluruh Delivery : 0"
        '
        'dgDaftarDelivery
        '
        Me.dgDaftarDelivery.AllowUserToAddRows = False
        Me.dgDaftarDelivery.AllowUserToDeleteRows = False
        Me.dgDaftarDelivery.AllowUserToResizeRows = False
        Me.dgDaftarDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarDelivery.Location = New System.Drawing.Point(6, 6)
        Me.dgDaftarDelivery.Name = "dgDaftarDelivery"
        Me.dgDaftarDelivery.ReadOnly = True
        Me.dgDaftarDelivery.Size = New System.Drawing.Size(564, 249)
        Me.dgDaftarDelivery.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.dgDeliveryBelumDikirim)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(581, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Belum Dikirim"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Jumlah Delivery Belum Di Kirim : 0"
        '
        'dgDeliveryBelumDikirim
        '
        Me.dgDeliveryBelumDikirim.AllowUserToAddRows = False
        Me.dgDeliveryBelumDikirim.AllowUserToDeleteRows = False
        Me.dgDeliveryBelumDikirim.AllowUserToResizeRows = False
        Me.dgDeliveryBelumDikirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeliveryBelumDikirim.Location = New System.Drawing.Point(6, 6)
        Me.dgDeliveryBelumDikirim.Name = "dgDeliveryBelumDikirim"
        Me.dgDeliveryBelumDikirim.ReadOnly = True
        Me.dgDeliveryBelumDikirim.Size = New System.Drawing.Size(564, 250)
        Me.dgDeliveryBelumDikirim.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.lblDeliverySudahDikirim)
        Me.TabPage3.Controls.Add(Me.dgDeliverySudahDikirim)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(581, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sudah Dikirim"
        '
        'lblDeliverySudahDikirim
        '
        Me.lblDeliverySudahDikirim.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblDeliverySudahDikirim.AutoSize = True
        Me.lblDeliverySudahDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliverySudahDikirim.ForeColor = System.Drawing.Color.White
        Me.lblDeliverySudahDikirim.Location = New System.Drawing.Point(-1, 257)
        Me.lblDeliverySudahDikirim.Name = "lblDeliverySudahDikirim"
        Me.lblDeliverySudahDikirim.Size = New System.Drawing.Size(282, 20)
        Me.lblDeliverySudahDikirim.TabIndex = 41
        Me.lblDeliverySudahDikirim.Text = "Jumlah Delivery Sudah Di Kirim : 0"
        '
        'dgDeliverySudahDikirim
        '
        Me.dgDeliverySudahDikirim.AllowUserToAddRows = False
        Me.dgDeliverySudahDikirim.AllowUserToDeleteRows = False
        Me.dgDeliverySudahDikirim.AllowUserToResizeRows = False
        Me.dgDeliverySudahDikirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeliverySudahDikirim.Location = New System.Drawing.Point(3, 6)
        Me.dgDeliverySudahDikirim.Name = "dgDeliverySudahDikirim"
        Me.dgDeliverySudahDikirim.ReadOnly = True
        Me.dgDeliverySudahDikirim.Size = New System.Drawing.Size(564, 248)
        Me.dgDeliverySudahDikirim.TabIndex = 5
        '
        'PictureBox1
        '
        'Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Delivery
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnTampilkan)
        Me.TabPage4.Controls.Add(Me.dgvMonitoringDeliveryOnline)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(581, 284)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tracking Delivery Online"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvMonitoringDeliveryOnline
        '
        Me.dgvMonitoringDeliveryOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvMonitoringDeliveryOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonitoringDeliveryOnline.Location = New System.Drawing.Point(4, 7)
        Me.dgvMonitoringDeliveryOnline.Name = "dgvMonitoringDeliveryOnline"
        Me.dgvMonitoringDeliveryOnline.Size = New System.Drawing.Size(563, 229)
        Me.dgvMonitoringDeliveryOnline.TabIndex = 0
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnTampilkan.Location = New System.Drawing.Point(434, 243)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(133, 35)
        Me.btnTampilkan.TabIndex = 1
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'gbAvailableToPromise
        '
        Me.gbAvailableToPromise.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAvailableToPromise.BackColor = System.Drawing.Color.White
        Me.gbAvailableToPromise.Controls.Add(Me.Label5)
        Me.gbAvailableToPromise.Controls.Add(Me.DataGridView1)
        Me.gbAvailableToPromise.Location = New System.Drawing.Point(602, 4)
        Me.gbAvailableToPromise.Name = "gbAvailableToPromise"
        Me.gbAvailableToPromise.Size = New System.Drawing.Size(761, 358)
        Me.gbAvailableToPromise.TabIndex = 5
        Me.gbAvailableToPromise.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(748, 286)
        Me.DataGridView1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "AVAILABLE TO PROMISE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox1.Location = New System.Drawing.Point(602, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 365)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Viewer"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(755, 346)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'frmMonitoringDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbAvailableToPromise)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(229, 3)
        Me.Name = "frmMonitoringDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monitoring Delivery"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgDeliveryBelumDikirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgDeliverySudahDikirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvMonitoringDeliveryOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAvailableToPromise.ResumeLayout(False)
        Me.gbAvailableToPromise.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgDeliveryBelumDikirim As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgDeliverySudahDikirim As System.Windows.Forms.DataGridView
    Friend WithEvents lblDeliverySudahDikirim As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents dgvMonitoringDeliveryOnline As System.Windows.Forms.DataGridView
    Friend WithEvents gbAvailableToPromise As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
