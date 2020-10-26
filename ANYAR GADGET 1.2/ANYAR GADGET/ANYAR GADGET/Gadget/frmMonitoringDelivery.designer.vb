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
        Me.cmdShow = New Guna.UI.WinForms.GunaGradientButton()
        Me.dtpTgl2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTgl1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AvailableToPromiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbCabangAll = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblJumlahTransaksi = New System.Windows.Forms.Label()
        Me.dgDaftarDelivery = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbCabangBelumDikirim = New System.Windows.Forms.ComboBox()
        Me.btnShowBelumDikirim = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp2BlmDikirim = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp1BlmDikirim = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDeliveryBelumDikirim = New System.Windows.Forms.Label()
        Me.dgDeliveryBelumDikirim = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmbSudahDikirim = New System.Windows.Forms.ComboBox()
        Me.btnSudahDIkirim = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp2SudahDikirim = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp1SudahDikirim = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDeliverySudahDikirim = New System.Windows.Forms.Label()
        Me.dgDeliverySudahDikirim = New System.Windows.Forms.DataGridView()
        Me.gvListItems = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.dgItemDelivery = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.picExportToExcelSemua = New System.Windows.Forms.PictureBox()
        Me.lblExportSemuaDikirim = New System.Windows.Forms.Label()
        Me.picExportBlmDikirim = New System.Windows.Forms.PictureBox()
        Me.lblExportBelumDikirim = New System.Windows.Forms.Label()
        Me.lblSudahDikirim = New System.Windows.Forms.Label()
        Me.picExportSudahDikirim = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgDaftarDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgDeliveryBelumDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDeliverySudahDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gvListItems.SuspendLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportToExcelSemua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportBlmDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportSudahDikirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmdShow.Location = New System.Drawing.Point(340, 5)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdShow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdShow.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdShow.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdShow.OnHoverImage = Nothing
        Me.cmdShow.OnPressedColor = System.Drawing.Color.Black
        Me.cmdShow.Radius = 2
        Me.cmdShow.Size = New System.Drawing.Size(104, 51)
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
        Me.dtpTgl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTgl2.ForeColor = System.Drawing.Color.Black
        Me.dtpTgl2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl2.Location = New System.Drawing.Point(221, 30)
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
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
        Me.dtpTgl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTgl1.ForeColor = System.Drawing.Color.Black
        Me.dtpTgl1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl1.Location = New System.Drawing.Point(65, 30)
        Me.dtpTgl1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTgl1.Name = "dtpTgl1"
        Me.dtpTgl1.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTgl1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTgl1.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTgl1.Size = New System.Drawing.Size(113, 29)
        Me.dtpTgl1.TabIndex = 1
        Me.dtpTgl1.Text = "26/05/2020"
        Me.dtpTgl1.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 87)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(589, 316)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblExportSemuaDikirim)
        Me.TabPage1.Controls.Add(Me.picExportToExcelSemua)
        Me.TabPage1.Controls.Add(Me.cmbCabangAll)
        Me.TabPage1.Controls.Add(Me.cmdShow)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.dtpTgl2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblJumlahTransaksi)
        Me.TabPage1.Controls.Add(Me.dgDaftarDelivery)
        Me.TabPage1.Controls.Add(Me.dtpTgl1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(581, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semua Delivery"
        '
        'cmbCabangAll
        '
        Me.cmbCabangAll.FormattingEnabled = True
        Me.cmbCabangAll.Location = New System.Drawing.Point(65, 5)
        Me.cmbCabangAll.Name = "cmbCabangAll"
        Me.cmbCabangAll.Size = New System.Drawing.Size(269, 21)
        Me.cmbCabangAll.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cabang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Periode"
        '
        'lblJumlahTransaksi
        '
        Me.lblJumlahTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahTransaksi.AutoSize = True
        Me.lblJumlahTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahTransaksi.ForeColor = System.Drawing.Color.Black
        Me.lblJumlahTransaksi.Location = New System.Drawing.Point(6, 265)
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
        Me.dgDaftarDelivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDaftarDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarDelivery.Location = New System.Drawing.Point(6, 65)
        Me.dgDaftarDelivery.Name = "dgDaftarDelivery"
        Me.dgDaftarDelivery.ReadOnly = True
        Me.dgDaftarDelivery.Size = New System.Drawing.Size(564, 197)
        Me.dgDaftarDelivery.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lblExportBelumDikirim)
        Me.TabPage2.Controls.Add(Me.picExportBlmDikirim)
        Me.TabPage2.Controls.Add(Me.cmbCabangBelumDikirim)
        Me.TabPage2.Controls.Add(Me.btnShowBelumDikirim)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtp2BlmDikirim)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtp1BlmDikirim)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lblDeliveryBelumDikirim)
        Me.TabPage2.Controls.Add(Me.dgDeliveryBelumDikirim)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(581, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Belum Dikirim"
        '
        'cmbCabangBelumDikirim
        '
        Me.cmbCabangBelumDikirim.FormattingEnabled = True
        Me.cmbCabangBelumDikirim.Location = New System.Drawing.Point(65, 6)
        Me.cmbCabangBelumDikirim.Name = "cmbCabangBelumDikirim"
        Me.cmbCabangBelumDikirim.Size = New System.Drawing.Size(269, 21)
        Me.cmbCabangBelumDikirim.TabIndex = 48
        '
        'btnShowBelumDikirim
        '
        Me.btnShowBelumDikirim.AnimationHoverSpeed = 0.07!
        Me.btnShowBelumDikirim.AnimationSpeed = 0.03!
        Me.btnShowBelumDikirim.BackColor = System.Drawing.Color.Transparent
        Me.btnShowBelumDikirim.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnShowBelumDikirim.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnShowBelumDikirim.BorderColor = System.Drawing.Color.Black
        Me.btnShowBelumDikirim.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnShowBelumDikirim.FocusedColor = System.Drawing.Color.Empty
        Me.btnShowBelumDikirim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnShowBelumDikirim.ForeColor = System.Drawing.Color.White
        Me.btnShowBelumDikirim.Image = Nothing
        Me.btnShowBelumDikirim.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnShowBelumDikirim.Location = New System.Drawing.Point(340, 6)
        Me.btnShowBelumDikirim.Name = "btnShowBelumDikirim"
        Me.btnShowBelumDikirim.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnShowBelumDikirim.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowBelumDikirim.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnShowBelumDikirim.OnHoverForeColor = System.Drawing.Color.White
        Me.btnShowBelumDikirim.OnHoverImage = Nothing
        Me.btnShowBelumDikirim.OnPressedColor = System.Drawing.Color.Black
        Me.btnShowBelumDikirim.Radius = 2
        Me.btnShowBelumDikirim.Size = New System.Drawing.Size(101, 57)
        Me.btnShowBelumDikirim.TabIndex = 49
        Me.btnShowBelumDikirim.Text = "Show"
        Me.btnShowBelumDikirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Cabang"
        '
        'dtp2BlmDikirim
        '
        Me.dtp2BlmDikirim.BaseColor = System.Drawing.Color.White
        Me.dtp2BlmDikirim.BorderColor = System.Drawing.Color.Silver
        Me.dtp2BlmDikirim.CustomFormat = Nothing
        Me.dtp2BlmDikirim.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp2BlmDikirim.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2BlmDikirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2BlmDikirim.ForeColor = System.Drawing.Color.Black
        Me.dtp2BlmDikirim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2BlmDikirim.Location = New System.Drawing.Point(221, 31)
        Me.dtp2BlmDikirim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp2BlmDikirim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp2BlmDikirim.Name = "dtp2BlmDikirim"
        Me.dtp2BlmDikirim.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp2BlmDikirim.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2BlmDikirim.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2BlmDikirim.OnPressedColor = System.Drawing.Color.Black
        Me.dtp2BlmDikirim.Size = New System.Drawing.Size(113, 29)
        Me.dtp2BlmDikirim.TabIndex = 45
        Me.dtp2BlmDikirim.Text = "26/05/2020"
        Me.dtp2BlmDikirim.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Periode"
        '
        'dtp1BlmDikirim
        '
        Me.dtp1BlmDikirim.BaseColor = System.Drawing.Color.White
        Me.dtp1BlmDikirim.BorderColor = System.Drawing.Color.Silver
        Me.dtp1BlmDikirim.CustomFormat = Nothing
        Me.dtp1BlmDikirim.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp1BlmDikirim.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1BlmDikirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1BlmDikirim.ForeColor = System.Drawing.Color.Black
        Me.dtp1BlmDikirim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1BlmDikirim.Location = New System.Drawing.Point(65, 31)
        Me.dtp1BlmDikirim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp1BlmDikirim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp1BlmDikirim.Name = "dtp1BlmDikirim"
        Me.dtp1BlmDikirim.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp1BlmDikirim.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1BlmDikirim.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1BlmDikirim.OnPressedColor = System.Drawing.Color.Black
        Me.dtp1BlmDikirim.Size = New System.Drawing.Size(113, 29)
        Me.dtp1BlmDikirim.TabIndex = 43
        Me.dtp1BlmDikirim.Text = "26/05/2020"
        Me.dtp1BlmDikirim.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(185, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "S/D"
        '
        'lblDeliveryBelumDikirim
        '
        Me.lblDeliveryBelumDikirim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeliveryBelumDikirim.AutoSize = True
        Me.lblDeliveryBelumDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryBelumDikirim.ForeColor = System.Drawing.Color.White
        Me.lblDeliveryBelumDikirim.Location = New System.Drawing.Point(6, 266)
        Me.lblDeliveryBelumDikirim.Name = "lblDeliveryBelumDikirim"
        Me.lblDeliveryBelumDikirim.Size = New System.Drawing.Size(280, 20)
        Me.lblDeliveryBelumDikirim.TabIndex = 42
        Me.lblDeliveryBelumDikirim.Text = "Jumlah Delivery Belum Di Kirim : 0"
        '
        'dgDeliveryBelumDikirim
        '
        Me.dgDeliveryBelumDikirim.AllowUserToAddRows = False
        Me.dgDeliveryBelumDikirim.AllowUserToDeleteRows = False
        Me.dgDeliveryBelumDikirim.AllowUserToResizeRows = False
        Me.dgDeliveryBelumDikirim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeliveryBelumDikirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeliveryBelumDikirim.Location = New System.Drawing.Point(6, 78)
        Me.dgDeliveryBelumDikirim.Name = "dgDeliveryBelumDikirim"
        Me.dgDeliveryBelumDikirim.ReadOnly = True
        Me.dgDeliveryBelumDikirim.Size = New System.Drawing.Size(564, 185)
        Me.dgDeliveryBelumDikirim.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.lblSudahDikirim)
        Me.TabPage3.Controls.Add(Me.picExportSudahDikirim)
        Me.TabPage3.Controls.Add(Me.cmbSudahDikirim)
        Me.TabPage3.Controls.Add(Me.btnSudahDIkirim)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.dtp2SudahDikirim)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.dtp1SudahDikirim)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.lblDeliverySudahDikirim)
        Me.TabPage3.Controls.Add(Me.dgDeliverySudahDikirim)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(581, 290)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sudah Dikirim"
        '
        'cmbSudahDikirim
        '
        Me.cmbSudahDikirim.FormattingEnabled = True
        Me.cmbSudahDikirim.Location = New System.Drawing.Point(70, 8)
        Me.cmbSudahDikirim.Name = "cmbSudahDikirim"
        Me.cmbSudahDikirim.Size = New System.Drawing.Size(269, 21)
        Me.cmbSudahDikirim.TabIndex = 55
        '
        'btnSudahDIkirim
        '
        Me.btnSudahDIkirim.AnimationHoverSpeed = 0.07!
        Me.btnSudahDIkirim.AnimationSpeed = 0.03!
        Me.btnSudahDIkirim.BackColor = System.Drawing.Color.Transparent
        Me.btnSudahDIkirim.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btnSudahDIkirim.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnSudahDIkirim.BorderColor = System.Drawing.Color.Black
        Me.btnSudahDIkirim.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSudahDIkirim.FocusedColor = System.Drawing.Color.Empty
        Me.btnSudahDIkirim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSudahDIkirim.ForeColor = System.Drawing.Color.White
        Me.btnSudahDIkirim.Image = Nothing
        Me.btnSudahDIkirim.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSudahDIkirim.Location = New System.Drawing.Point(345, 6)
        Me.btnSudahDIkirim.Name = "btnSudahDIkirim"
        Me.btnSudahDIkirim.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnSudahDIkirim.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSudahDIkirim.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSudahDIkirim.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSudahDIkirim.OnHoverImage = Nothing
        Me.btnSudahDIkirim.OnPressedColor = System.Drawing.Color.Black
        Me.btnSudahDIkirim.Radius = 2
        Me.btnSudahDIkirim.Size = New System.Drawing.Size(114, 56)
        Me.btnSudahDIkirim.TabIndex = 56
        Me.btnSudahDIkirim.Text = "Show"
        Me.btnSudahDIkirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cabang"
        '
        'dtp2SudahDikirim
        '
        Me.dtp2SudahDikirim.BaseColor = System.Drawing.Color.White
        Me.dtp2SudahDikirim.BorderColor = System.Drawing.Color.Silver
        Me.dtp2SudahDikirim.CustomFormat = Nothing
        Me.dtp2SudahDikirim.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp2SudahDikirim.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2SudahDikirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2SudahDikirim.ForeColor = System.Drawing.Color.Black
        Me.dtp2SudahDikirim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2SudahDikirim.Location = New System.Drawing.Point(226, 33)
        Me.dtp2SudahDikirim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp2SudahDikirim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp2SudahDikirim.Name = "dtp2SudahDikirim"
        Me.dtp2SudahDikirim.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp2SudahDikirim.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2SudahDikirim.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp2SudahDikirim.OnPressedColor = System.Drawing.Color.Black
        Me.dtp2SudahDikirim.Size = New System.Drawing.Size(113, 29)
        Me.dtp2SudahDikirim.TabIndex = 52
        Me.dtp2SudahDikirim.Text = "26/05/2020"
        Me.dtp2SudahDikirim.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Periode"
        '
        'dtp1SudahDikirim
        '
        Me.dtp1SudahDikirim.BaseColor = System.Drawing.Color.White
        Me.dtp1SudahDikirim.BorderColor = System.Drawing.Color.Silver
        Me.dtp1SudahDikirim.CustomFormat = Nothing
        Me.dtp1SudahDikirim.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp1SudahDikirim.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1SudahDikirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1SudahDikirim.ForeColor = System.Drawing.Color.Black
        Me.dtp1SudahDikirim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1SudahDikirim.Location = New System.Drawing.Point(70, 33)
        Me.dtp1SudahDikirim.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp1SudahDikirim.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp1SudahDikirim.Name = "dtp1SudahDikirim"
        Me.dtp1SudahDikirim.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtp1SudahDikirim.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1SudahDikirim.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp1SudahDikirim.OnPressedColor = System.Drawing.Color.Black
        Me.dtp1SudahDikirim.Size = New System.Drawing.Size(113, 29)
        Me.dtp1SudahDikirim.TabIndex = 50
        Me.dtp1SudahDikirim.Text = "26/05/2020"
        Me.dtp1SudahDikirim.Value = New Date(2020, 5, 26, 15, 12, 12, 673)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(190, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "S/D"
        '
        'lblDeliverySudahDikirim
        '
        Me.lblDeliverySudahDikirim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeliverySudahDikirim.AutoSize = True
        Me.lblDeliverySudahDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliverySudahDikirim.ForeColor = System.Drawing.Color.White
        Me.lblDeliverySudahDikirim.Location = New System.Drawing.Point(-1, 267)
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
        Me.dgDeliverySudahDikirim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeliverySudahDikirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeliverySudahDikirim.Location = New System.Drawing.Point(3, 68)
        Me.dgDeliverySudahDikirim.Name = "dgDeliverySudahDikirim"
        Me.dgDeliverySudahDikirim.ReadOnly = True
        Me.dgDeliverySudahDikirim.Size = New System.Drawing.Size(572, 196)
        Me.dgDeliverySudahDikirim.TabIndex = 5
        '
        'gvListItems
        '
        Me.gvListItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvListItems.BackColor = System.Drawing.Color.White
        Me.gvListItems.Controls.Add(Me.Label1)
        Me.gvListItems.Controls.Add(Me.txtNamaCustomer)
        Me.gvListItems.Controls.Add(Me.dgItemDelivery)
        Me.gvListItems.Controls.Add(Me.Label5)
        Me.gvListItems.Location = New System.Drawing.Point(603, 3)
        Me.gvListItems.Name = "gvListItems"
        Me.gvListItems.Size = New System.Drawing.Size(588, 403)
        Me.gvListItems.TabIndex = 5
        Me.gvListItems.TabStop = False
        Me.gvListItems.Text = "Daftar Items"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Daftar Items"
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCustomer.Location = New System.Drawing.Point(159, 39)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.ReadOnly = True
        Me.txtNamaCustomer.Size = New System.Drawing.Size(415, 26)
        Me.txtNamaCustomer.TabIndex = 4
        '
        'dgItemDelivery
        '
        Me.dgItemDelivery.AllowUserToAddRows = False
        Me.dgItemDelivery.AllowUserToDeleteRows = False
        Me.dgItemDelivery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgItemDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemDelivery.Location = New System.Drawing.Point(6, 71)
        Me.dgItemDelivery.Name = "dgItemDelivery"
        Me.dgItemDelivery.ReadOnly = True
        Me.dgItemDelivery.RowHeadersVisible = False
        Me.dgItemDelivery.Size = New System.Drawing.Size(568, 326)
        Me.dgItemDelivery.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 78)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Delivery_Gif
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(198, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(265, 31)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Monitoring Delivery"
        '
        'picExportToExcelSemua
        '
        Me.picExportToExcelSemua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picExportToExcelSemua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportToExcelSemua.Image = Global.ANYAR_GADGET.My.Resources.Resources.Export_To_Excel
        Me.picExportToExcelSemua.Location = New System.Drawing.Point(450, 6)
        Me.picExportToExcelSemua.Name = "picExportToExcelSemua"
        Me.picExportToExcelSemua.Size = New System.Drawing.Size(107, 35)
        Me.picExportToExcelSemua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExportToExcelSemua.TabIndex = 37
        Me.picExportToExcelSemua.TabStop = False
        '
        'lblExportSemuaDikirim
        '
        Me.lblExportSemuaDikirim.AutoSize = True
        Me.lblExportSemuaDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportSemuaDikirim.Location = New System.Drawing.Point(450, 44)
        Me.lblExportSemuaDikirim.Name = "lblExportSemuaDikirim"
        Me.lblExportSemuaDikirim.Size = New System.Drawing.Size(88, 15)
        Me.lblExportSemuaDikirim.TabIndex = 38
        Me.lblExportSemuaDikirim.Text = "Meng Export"
        Me.lblExportSemuaDikirim.Visible = False
        '
        'picExportBlmDikirim
        '
        Me.picExportBlmDikirim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picExportBlmDikirim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportBlmDikirim.Image = Global.ANYAR_GADGET.My.Resources.Resources.Export_To_Excel
        Me.picExportBlmDikirim.Location = New System.Drawing.Point(447, 6)
        Me.picExportBlmDikirim.Name = "picExportBlmDikirim"
        Me.picExportBlmDikirim.Size = New System.Drawing.Size(107, 35)
        Me.picExportBlmDikirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExportBlmDikirim.TabIndex = 50
        Me.picExportBlmDikirim.TabStop = False
        '
        'lblExportBelumDikirim
        '
        Me.lblExportBelumDikirim.AutoSize = True
        Me.lblExportBelumDikirim.BackColor = System.Drawing.Color.White
        Me.lblExportBelumDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportBelumDikirim.Location = New System.Drawing.Point(447, 48)
        Me.lblExportBelumDikirim.Name = "lblExportBelumDikirim"
        Me.lblExportBelumDikirim.Size = New System.Drawing.Size(88, 15)
        Me.lblExportBelumDikirim.TabIndex = 51
        Me.lblExportBelumDikirim.Text = "Meng Export"
        Me.lblExportBelumDikirim.Visible = False
        '
        'lblSudahDikirim
        '
        Me.lblSudahDikirim.AutoSize = True
        Me.lblSudahDikirim.BackColor = System.Drawing.Color.White
        Me.lblSudahDikirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSudahDikirim.Location = New System.Drawing.Point(465, 48)
        Me.lblSudahDikirim.Name = "lblSudahDikirim"
        Me.lblSudahDikirim.Size = New System.Drawing.Size(88, 15)
        Me.lblSudahDikirim.TabIndex = 58
        Me.lblSudahDikirim.Text = "Meng Export"
        Me.lblSudahDikirim.Visible = False
        '
        'picExportSudahDikirim
        '
        Me.picExportSudahDikirim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picExportSudahDikirim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportSudahDikirim.Image = Global.ANYAR_GADGET.My.Resources.Resources.Export_To_Excel
        Me.picExportSudahDikirim.Location = New System.Drawing.Point(465, 6)
        Me.picExportSudahDikirim.Name = "picExportSudahDikirim"
        Me.picExportSudahDikirim.Size = New System.Drawing.Size(107, 35)
        Me.picExportSudahDikirim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExportSudahDikirim.TabIndex = 57
        Me.picExportSudahDikirim.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(201, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "V 1.2 Build 24.10.2020"
        '
        'frmMonitoringDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gvListItems)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(229, 3)
        Me.Name = "frmMonitoringDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Monitoring Delivery"
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
        Me.gvListItems.ResumeLayout(False)
        Me.gvListItems.PerformLayout()
        CType(Me.dgItemDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportToExcelSemua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportBlmDikirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportSudahDikirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpTgl2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cmdShow As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblJumlahTransaksi As System.Windows.Forms.Label
    Friend WithEvents dgDaftarDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AvailableToPromiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgDeliveryBelumDikirim As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgDeliverySudahDikirim As System.Windows.Forms.DataGridView
    Friend WithEvents lblDeliverySudahDikirim As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryBelumDikirim As System.Windows.Forms.Label
    Friend WithEvents gvListItems As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents dgItemDelivery As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCabangAll As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCabangBelumDikirim As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowBelumDikirim As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp2BlmDikirim As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp1BlmDikirim As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbSudahDikirim As System.Windows.Forms.ComboBox
    Friend WithEvents btnSudahDIkirim As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp2SudahDikirim As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtp1SudahDikirim As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picExportToExcelSemua As System.Windows.Forms.PictureBox
    Friend WithEvents lblExportSemuaDikirim As System.Windows.Forms.Label
    Friend WithEvents lblExportBelumDikirim As System.Windows.Forms.Label
    Friend WithEvents picExportBlmDikirim As System.Windows.Forms.PictureBox
    Friend WithEvents lblSudahDikirim As System.Windows.Forms.Label
    Friend WithEvents picExportSudahDikirim As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
