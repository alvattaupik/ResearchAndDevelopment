<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainMenu
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmbKota = New System.Windows.Forms.ComboBox()
        Me.cmbBatal = New Guna.UI.WinForms.GunaGradientButton()
        Me.lblJumlahMember = New System.Windows.Forms.Label()
        Me.cmdProses = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCabang = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDaftarMember = New Guna.UI.WinForms.GunaDataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblTotalTransaksi = New System.Windows.Forms.Label()
        Me.dgHistoryTransaksiCustomer = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCabang = New System.Windows.Forms.TextBox()
        Me.txtNamaCustomerHistory = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCari = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtKodeCustomer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtNoMember = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgInformasiMember = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKodeMember = New System.Windows.Forms.TextBox()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LihatRiwayatTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNoStruk = New System.Windows.Forms.TextBox()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgDaftarMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgHistoryTransaksiCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgInformasiMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarMemberToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DaftarMemberToolStripMenuItem
        '
        Me.DaftarMemberToolStripMenuItem.Name = "DaftarMemberToolStripMenuItem"
        Me.DaftarMemberToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DaftarMemberToolStripMenuItem.Text = "Daftar Member"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 50)
        Me.TabControl1.Location = New System.Drawing.Point(10, 136)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(791, 529)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbKota)
        Me.TabPage1.Controls.Add(Me.cmbBatal)
        Me.TabPage1.Controls.Add(Me.lblJumlahMember)
        Me.TabPage1.Controls.Add(Me.cmdProses)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmbCabang)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgDaftarMember)
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(783, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daftar Monitoring  Member"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbKota
        '
        Me.cmbKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKota.FormattingEnabled = True
        Me.cmbKota.Location = New System.Drawing.Point(130, 45)
        Me.cmbKota.Name = "cmbKota"
        Me.cmbKota.Size = New System.Drawing.Size(353, 28)
        Me.cmbKota.TabIndex = 31
        '
        'cmbBatal
        '
        Me.cmbBatal.AnimationHoverSpeed = 0.07!
        Me.cmbBatal.AnimationSpeed = 0.03!
        Me.cmbBatal.BackColor = System.Drawing.Color.Transparent
        Me.cmbBatal.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmbBatal.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmbBatal.BorderColor = System.Drawing.Color.Black
        Me.cmbBatal.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmbBatal.FocusedColor = System.Drawing.Color.Empty
        Me.cmbBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBatal.ForeColor = System.Drawing.Color.White
        Me.cmbBatal.Image = Nothing
        Me.cmbBatal.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmbBatal.Location = New System.Drawing.Point(638, 9)
        Me.cmbBatal.Name = "cmbBatal"
        Me.cmbBatal.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbBatal.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBatal.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmbBatal.OnHoverForeColor = System.Drawing.Color.White
        Me.cmbBatal.OnHoverImage = Nothing
        Me.cmbBatal.OnPressedColor = System.Drawing.Color.Black
        Me.cmbBatal.Radius = 2
        Me.cmbBatal.Size = New System.Drawing.Size(138, 60)
        Me.cmbBatal.TabIndex = 30
        Me.cmbBatal.Text = "Batal"
        Me.cmbBatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblJumlahMember
        '
        Me.lblJumlahMember.AutoSize = True
        Me.lblJumlahMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahMember.Location = New System.Drawing.Point(0, 439)
        Me.lblJumlahMember.Name = "lblJumlahMember"
        Me.lblJumlahMember.Size = New System.Drawing.Size(242, 29)
        Me.lblJumlahMember.TabIndex = 29
        Me.lblJumlahMember.Text = "Jumlah Member = 0"
        '
        'cmdProses
        '
        Me.cmdProses.AnimationHoverSpeed = 0.07!
        Me.cmdProses.AnimationSpeed = 0.03!
        Me.cmdProses.BackColor = System.Drawing.Color.Transparent
        Me.cmdProses.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdProses.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdProses.BorderColor = System.Drawing.Color.Black
        Me.cmdProses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdProses.FocusedColor = System.Drawing.Color.Empty
        Me.cmdProses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdProses.ForeColor = System.Drawing.Color.White
        Me.cmdProses.Image = Nothing
        Me.cmdProses.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdProses.Location = New System.Drawing.Point(495, 9)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdProses.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdProses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdProses.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdProses.OnHoverImage = Nothing
        Me.cmdProses.OnPressedColor = System.Drawing.Color.Black
        Me.cmdProses.Radius = 2
        Me.cmdProses.Size = New System.Drawing.Size(138, 60)
        Me.cmdProses.TabIndex = 28
        Me.cmdProses.Text = "Proses"
        Me.cmdProses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kota"
        '
        'cmbCabang
        '
        Me.cmbCabang.BackColor = System.Drawing.Color.Transparent
        Me.cmbCabang.BaseColor = System.Drawing.Color.White
        Me.cmbCabang.BorderColor = System.Drawing.Color.Silver
        Me.cmbCabang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCabang.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCabang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCabang.ForeColor = System.Drawing.Color.Black
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(128, 11)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCabang.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCabang.Size = New System.Drawing.Size(356, 26)
        Me.cmbCabang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cabang"
        '
        'dgDaftarMember
        '
        Me.dgDaftarMember.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgDaftarMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDaftarMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarMember.BackgroundColor = System.Drawing.Color.Gray
        Me.dgDaftarMember.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDaftarMember.ColumnHeadersHeight = 30
        Me.dgDaftarMember.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarMember.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgDaftarMember.EnableHeadersVisualStyles = False
        Me.dgDaftarMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarMember.Location = New System.Drawing.Point(6, 79)
        Me.dgDaftarMember.Name = "dgDaftarMember"
        Me.dgDaftarMember.ReadOnly = True
        Me.dgDaftarMember.RowHeadersVisible = False
        Me.dgDaftarMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgDaftarMember.Size = New System.Drawing.Size(770, 357)
        Me.dgDaftarMember.TabIndex = 0
        Me.dgDaftarMember.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgDaftarMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarMember.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgDaftarMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgDaftarMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgDaftarMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgDaftarMember.ThemeStyle.BackColor = System.Drawing.Color.Gray
        Me.dgDaftarMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgDaftarMember.ThemeStyle.HeaderStyle.Height = 30
        Me.dgDaftarMember.ThemeStyle.ReadOnly = True
        Me.dgDaftarMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarMember.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgDaftarMember.ThemeStyle.RowsStyle.Height = 22
        Me.dgDaftarMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyTableToolStripMenuItem, Me.LihatRiwayatTransaksiToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 48)
        '
        'CopyTableToolStripMenuItem
        '
        Me.CopyTableToolStripMenuItem.Name = "CopyTableToolStripMenuItem"
        Me.CopyTableToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CopyTableToolStripMenuItem.Text = "Copy Table"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GunaGradientButton2)
        Me.TabPage2.Controls.Add(Me.txtNoStruk)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.GunaGradientButton1)
        Me.TabPage2.Controls.Add(Me.txtKodeMember)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.lblTotalTransaksi)
        Me.TabPage2.Controls.Add(Me.dgHistoryTransaksiCustomer)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.cmdCari)
        Me.TabPage2.Controls.Add(Me.txtKodeCustomer)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(783, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lihat Transaksi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblTotalTransaksi
        '
        Me.lblTotalTransaksi.AutoSize = True
        Me.lblTotalTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTransaksi.Location = New System.Drawing.Point(454, 443)
        Me.lblTotalTransaksi.Name = "lblTotalTransaksi"
        Me.lblTotalTransaksi.Size = New System.Drawing.Size(175, 25)
        Me.lblTotalTransaksi.TabIndex = 33
        Me.lblTotalTransaksi.Text = "Total Transaksi"
        '
        'dgHistoryTransaksiCustomer
        '
        Me.dgHistoryTransaksiCustomer.AllowUserToAddRows = False
        Me.dgHistoryTransaksiCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistoryTransaksiCustomer.Location = New System.Drawing.Point(23, 242)
        Me.dgHistoryTransaksiCustomer.Name = "dgHistoryTransaksiCustomer"
        Me.dgHistoryTransaksiCustomer.ReadOnly = True
        Me.dgHistoryTransaksiCustomer.Size = New System.Drawing.Size(751, 198)
        Me.dgHistoryTransaksiCustomer.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(230, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(276, 25)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Daftar Riwayat Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCabang)
        Me.GroupBox1.Controls.Add(Me.txtNamaCustomerHistory)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 92)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'txtCabang
        '
        Me.txtCabang.Enabled = False
        Me.txtCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabang.Location = New System.Drawing.Point(190, 53)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.Size = New System.Drawing.Size(328, 31)
        Me.txtCabang.TabIndex = 6
        '
        'txtNamaCustomerHistory
        '
        Me.txtNamaCustomerHistory.Enabled = False
        Me.txtNamaCustomerHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCustomerHistory.Location = New System.Drawing.Point(190, 14)
        Me.txtNamaCustomerHistory.Name = "txtNamaCustomerHistory"
        Me.txtNamaCustomerHistory.Size = New System.Drawing.Size(328, 31)
        Me.txtNamaCustomerHistory.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cabang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Nama Customer"
        '
        'cmdCari
        '
        Me.cmdCari.AnimationHoverSpeed = 0.07!
        Me.cmdCari.AnimationSpeed = 0.03!
        Me.cmdCari.BackColor = System.Drawing.Color.Transparent
        Me.cmdCari.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdCari.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdCari.BorderColor = System.Drawing.Color.Black
        Me.cmdCari.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdCari.FocusedColor = System.Drawing.Color.Empty
        Me.cmdCari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdCari.ForeColor = System.Drawing.Color.White
        Me.cmdCari.Image = Nothing
        Me.cmdCari.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdCari.Location = New System.Drawing.Point(565, 3)
        Me.cmdCari.Name = "cmdCari"
        Me.cmdCari.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCari.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCari.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCari.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCari.OnHoverImage = Nothing
        Me.cmdCari.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCari.Radius = 2
        Me.cmdCari.Size = New System.Drawing.Size(203, 33)
        Me.cmdCari.TabIndex = 29
        Me.cmdCari.Text = "Cari"
        Me.cmdCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKodeCustomer
        '
        Me.txtKodeCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeCustomer.Location = New System.Drawing.Point(204, 6)
        Me.txtKodeCustomer.Name = "txtKodeCustomer"
        Me.txtKodeCustomer.Size = New System.Drawing.Size(328, 31)
        Me.txtKodeCustomer.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kode Customer"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtNoMember)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.dgInformasiMember)
        Me.TabPage3.Controls.Add(Me.txtNamaCustomer)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 54)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(783, 471)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Informasi Member"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtNoMember
        '
        Me.txtNoMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMember.Location = New System.Drawing.Point(220, 49)
        Me.txtNoMember.Name = "txtNoMember"
        Me.txtNoMember.Size = New System.Drawing.Size(535, 29)
        Me.txtNoMember.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "No Member"
        '
        'dgInformasiMember
        '
        Me.dgInformasiMember.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgInformasiMember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInformasiMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInformasiMember.BackgroundColor = System.Drawing.Color.Silver
        Me.dgInformasiMember.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInformasiMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInformasiMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInformasiMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInformasiMember.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInformasiMember.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInformasiMember.EnableHeadersVisualStyles = False
        Me.dgInformasiMember.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInformasiMember.Location = New System.Drawing.Point(12, 83)
        Me.dgInformasiMember.Name = "dgInformasiMember"
        Me.dgInformasiMember.ReadOnly = True
        Me.dgInformasiMember.RowHeadersVisible = False
        Me.dgInformasiMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgInformasiMember.Size = New System.Drawing.Size(751, 371)
        Me.dgInformasiMember.TabIndex = 4
        Me.dgInformasiMember.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgInformasiMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgInformasiMember.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgInformasiMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgInformasiMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgInformasiMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgInformasiMember.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgInformasiMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgInformasiMember.ThemeStyle.HeaderStyle.Height = 30
        Me.dgInformasiMember.ThemeStyle.ReadOnly = True
        Me.dgInformasiMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgInformasiMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInformasiMember.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInformasiMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgInformasiMember.ThemeStyle.RowsStyle.Height = 22
        Me.dgInformasiMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInformasiMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCustomer.Location = New System.Drawing.Point(220, 14)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(535, 29)
        Me.txtNamaCustomer.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Customer"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 682)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(801, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(140, 17)
        Me.ToolStripStatusLabel1.Text = "Member Monitoring V1.0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(10, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 93)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monitoring Card V1.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Kode Member"
        '
        'txtKodeMember
        '
        Me.txtKodeMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeMember.Location = New System.Drawing.Point(204, 46)
        Me.txtKodeMember.Name = "txtKodeMember"
        Me.txtKodeMember.Size = New System.Drawing.Size(328, 31)
        Me.txtKodeMember.TabIndex = 35
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(565, 46)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(203, 33)
        Me.GunaGradientButton1.TabIndex = 36
        Me.GunaGradientButton1.Text = "Cari"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Build 08.05.2020"
        '
        'LihatRiwayatTransaksiToolStripMenuItem
        '
        Me.LihatRiwayatTransaksiToolStripMenuItem.Name = "LihatRiwayatTransaksiToolStripMenuItem"
        Me.LihatRiwayatTransaksiToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.LihatRiwayatTransaksiToolStripMenuItem.Text = "Lihat Riwayat Transaksi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.logo_jpeg
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 25)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "No Struk"
        '
        'txtNoStruk
        '
        Me.txtNoStruk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoStruk.Location = New System.Drawing.Point(204, 84)
        Me.txtNoStruk.Name = "txtNoStruk"
        Me.txtNoStruk.Size = New System.Drawing.Size(328, 31)
        Me.txtNoStruk.TabIndex = 38
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(565, 85)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(203, 33)
        Me.GunaGradientButton2.TabIndex = 39
        Me.GunaGradientButton2.Text = "Cari"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 704)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgDaftarMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgHistoryTransaksiCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgInformasiMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJumlahMember As System.Windows.Forms.Label
    Friend WithEvents cmdProses As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgDaftarMember As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgHistoryTransaksiCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCabang As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaCustomerHistory As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdCari As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtKodeCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTransaksi As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cmbBatal As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbKota As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgInformasiMember As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoMember As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtKodeMember As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LihatRiwayatTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtNoStruk As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
