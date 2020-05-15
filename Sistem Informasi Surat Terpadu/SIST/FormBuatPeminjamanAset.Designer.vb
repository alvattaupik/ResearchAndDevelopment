<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatPeminjamanAset
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.LblkdJenisSurat = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoHP = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlamatEmail = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTglSurat = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdRemove = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdTambah = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdBrowse = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgItem = New Guna.UI.WinForms.GunaDataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCatatanUser = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpPinjam2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLokasi = New Guna.UI.WinForms.GunaTextBox()
        Me.dtpPinjam1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cmbBuatBaru = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNoSurat)
        Me.Panel1.Controls.Add(Me.LblkdJenisSurat)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 114)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(235, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM PEMINJAMAN ASET"
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(16, 25)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(176, 20)
        Me.txtNoSurat.TabIndex = 4
        Me.txtNoSurat.Visible = False
        '
        'LblkdJenisSurat
        '
        Me.LblkdJenisSurat.AutoSize = True
        Me.LblkdJenisSurat.Location = New System.Drawing.Point(13, 9)
        Me.LblkdJenisSurat.Name = "LblkdJenisSurat"
        Me.LblkdJenisSurat.Size = New System.Drawing.Size(35, 13)
        Me.LblkdJenisSurat.TabIndex = 2
        Me.LblkdJenisSurat.Text = "IT006"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.txtNoHP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAlamatEmail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpTglSurat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 112)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Identitas Peminjaman"
        '
        'txtNoHP
        '
        Me.txtNoHP.BaseColor = System.Drawing.Color.White
        Me.txtNoHP.BorderColor = System.Drawing.Color.Silver
        Me.txtNoHP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoHP.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoHP.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoHP.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoHP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoHP.Location = New System.Drawing.Point(241, 78)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoHP.Size = New System.Drawing.Size(244, 26)
        Me.txtNoHP.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "No HP"
        '
        'txtAlamatEmail
        '
        Me.txtAlamatEmail.BaseColor = System.Drawing.Color.White
        Me.txtAlamatEmail.BorderColor = System.Drawing.Color.Silver
        Me.txtAlamatEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlamatEmail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtAlamatEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAlamatEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAlamatEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAlamatEmail.Location = New System.Drawing.Point(241, 46)
        Me.txtAlamatEmail.Name = "txtAlamatEmail"
        Me.txtAlamatEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlamatEmail.Size = New System.Drawing.Size(244, 26)
        Me.txtAlamatEmail.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Alamat Email"
        '
        'dtpTglSurat
        '
        Me.dtpTglSurat.BaseColor = System.Drawing.Color.White
        Me.dtpTglSurat.BorderColor = System.Drawing.Color.Silver
        Me.dtpTglSurat.CustomFormat = Nothing
        Me.dtpTglSurat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTglSurat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglSurat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglSurat.ForeColor = System.Drawing.Color.Black
        Me.dtpTglSurat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglSurat.Location = New System.Drawing.Point(241, 18)
        Me.dtpTglSurat.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTglSurat.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTglSurat.Name = "dtpTglSurat"
        Me.dtpTglSurat.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTglSurat.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglSurat.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglSurat.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTglSurat.Size = New System.Drawing.Size(244, 22)
        Me.dtpTglSurat.TabIndex = 30
        Me.dtpTglSurat.Text = "14/03/2020"
        Me.dtpTglSurat.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tanggal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdRemove)
        Me.GroupBox4.Controls.Add(Me.cmdTambah)
        Me.GroupBox4.Controls.Add(Me.cmdBrowse)
        Me.GroupBox4.Controls.Add(Me.dgItem)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 154)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Daftar Aset"
        '
        'cmdRemove
        '
        Me.cmdRemove.AnimationHoverSpeed = 0.07!
        Me.cmdRemove.AnimationSpeed = 0.03!
        Me.cmdRemove.BackColor = System.Drawing.Color.Transparent
        Me.cmdRemove.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdRemove.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdRemove.BorderColor = System.Drawing.Color.Black
        Me.cmdRemove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdRemove.FocusedColor = System.Drawing.Color.Empty
        Me.cmdRemove.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdRemove.ForeColor = System.Drawing.Color.White
        Me.cmdRemove.Image = Nothing
        Me.cmdRemove.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdRemove.Location = New System.Drawing.Point(557, 70)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRemove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRemove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRemove.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRemove.OnHoverImage = Nothing
        Me.cmdRemove.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRemove.Radius = 2
        Me.cmdRemove.Size = New System.Drawing.Size(74, 34)
        Me.cmdRemove.TabIndex = 34
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdTambah
        '
        Me.cmdTambah.AnimationHoverSpeed = 0.07!
        Me.cmdTambah.AnimationSpeed = 0.03!
        Me.cmdTambah.BackColor = System.Drawing.Color.Transparent
        Me.cmdTambah.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdTambah.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdTambah.BorderColor = System.Drawing.Color.Black
        Me.cmdTambah.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdTambah.Enabled = False
        Me.cmdTambah.FocusedColor = System.Drawing.Color.Empty
        Me.cmdTambah.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdTambah.ForeColor = System.Drawing.Color.White
        Me.cmdTambah.Image = Nothing
        Me.cmdTambah.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdTambah.Location = New System.Drawing.Point(557, 30)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdTambah.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTambah.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdTambah.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdTambah.OnHoverImage = Nothing
        Me.cmdTambah.OnPressedColor = System.Drawing.Color.Black
        Me.cmdTambah.Radius = 2
        Me.cmdTambah.Size = New System.Drawing.Size(74, 30)
        Me.cmdTambah.TabIndex = 33
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdBrowse
        '
        Me.cmdBrowse.AnimationHoverSpeed = 0.07!
        Me.cmdBrowse.AnimationSpeed = 0.03!
        Me.cmdBrowse.BackColor = System.Drawing.Color.Transparent
        Me.cmdBrowse.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdBrowse.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdBrowse.BorderColor = System.Drawing.Color.Black
        Me.cmdBrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdBrowse.FocusedColor = System.Drawing.Color.Empty
        Me.cmdBrowse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdBrowse.ForeColor = System.Drawing.Color.White
        Me.cmdBrowse.Image = Nothing
        Me.cmdBrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdBrowse.Location = New System.Drawing.Point(557, 112)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowse.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowse.OnHoverImage = Nothing
        Me.cmdBrowse.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowse.Radius = 2
        Me.cmdBrowse.Size = New System.Drawing.Size(74, 31)
        Me.cmdBrowse.TabIndex = 32
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgItem
        '
        Me.dgItem.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgItem.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgItem.ColumnHeadersHeight = 21
        Me.dgItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.Deskripsi, Me.Keterangan})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgItem.EnableHeadersVisualStyles = False
        Me.dgItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgItem.Location = New System.Drawing.Point(9, 20)
        Me.dgItem.Name = "dgItem"
        Me.dgItem.RowHeadersVisible = False
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(538, 126)
        Me.dgItem.TabIndex = 28
        Me.dgItem.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgItem.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgItem.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgItem.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgItem.ThemeStyle.HeaderStyle.Height = 21
        Me.dgItem.ThemeStyle.ReadOnly = False
        Me.dgItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgItem.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgItem.ThemeStyle.RowsStyle.Height = 22
        Me.dgItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "KodeBarang"
        Me.KodeBarang.Name = "KodeBarang"
        '
        'Deskripsi
        '
        Me.Deskripsi.HeaderText = "Deskripsi"
        Me.Deskripsi.Name = "Deskripsi"
        '
        'Keterangan
        '
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtCatatanUser)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpPinjam2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLokasi)
        Me.GroupBox2.Controls.Add(Me.dtpPinjam1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 112)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Lokasi dan Durasi"
        '
        'txtCatatanUser
        '
        Me.txtCatatanUser.Location = New System.Drawing.Point(405, 37)
        Me.txtCatatanUser.Name = "txtCatatanUser"
        Me.txtCatatanUser.Size = New System.Drawing.Size(231, 68)
        Me.txtCatatanUser.TabIndex = 43
        Me.txtCatatanUser.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Catatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Lokasi"
        '
        'dtpPinjam2
        '
        Me.dtpPinjam2.BaseColor = System.Drawing.Color.White
        Me.dtpPinjam2.BorderColor = System.Drawing.Color.Silver
        Me.dtpPinjam2.CustomFormat = Nothing
        Me.dtpPinjam2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpPinjam2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpPinjam2.ForeColor = System.Drawing.Color.Black
        Me.dtpPinjam2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPinjam2.Location = New System.Drawing.Point(270, 26)
        Me.dtpPinjam2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpPinjam2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpPinjam2.Name = "dtpPinjam2"
        Me.dtpPinjam2.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpPinjam2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam2.OnPressedColor = System.Drawing.Color.Black
        Me.dtpPinjam2.Size = New System.Drawing.Size(121, 22)
        Me.dtpPinjam2.TabIndex = 40
        Me.dtpPinjam2.Text = "14/03/2020"
        Me.dtpPinjam2.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "S/D"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Dari Tanggal"
        '
        'txtLokasi
        '
        Me.txtLokasi.BaseColor = System.Drawing.Color.White
        Me.txtLokasi.BorderColor = System.Drawing.Color.Silver
        Me.txtLokasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLokasi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLokasi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLokasi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLokasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLokasi.Location = New System.Drawing.Point(114, 54)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLokasi.Size = New System.Drawing.Size(277, 26)
        Me.txtLokasi.TabIndex = 34
        '
        'dtpPinjam1
        '
        Me.dtpPinjam1.BaseColor = System.Drawing.Color.White
        Me.dtpPinjam1.BorderColor = System.Drawing.Color.Silver
        Me.dtpPinjam1.CustomFormat = Nothing
        Me.dtpPinjam1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpPinjam1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpPinjam1.ForeColor = System.Drawing.Color.Black
        Me.dtpPinjam1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPinjam1.Location = New System.Drawing.Point(114, 26)
        Me.dtpPinjam1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpPinjam1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpPinjam1.Name = "dtpPinjam1"
        Me.dtpPinjam1.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpPinjam1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpPinjam1.OnPressedColor = System.Drawing.Color.Black
        Me.dtpPinjam1.Size = New System.Drawing.Size(121, 22)
        Me.dtpPinjam1.TabIndex = 30
        Me.dtpPinjam1.Text = "14/03/2020"
        Me.dtpPinjam1.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'cmbBuatBaru
        '
        Me.cmbBuatBaru.AnimationHoverSpeed = 0.07!
        Me.cmbBuatBaru.AnimationSpeed = 0.03!
        Me.cmbBuatBaru.BackColor = System.Drawing.Color.Transparent
        Me.cmbBuatBaru.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmbBuatBaru.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmbBuatBaru.BorderColor = System.Drawing.Color.Black
        Me.cmbBuatBaru.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmbBuatBaru.FocusedColor = System.Drawing.Color.Empty
        Me.cmbBuatBaru.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBuatBaru.ForeColor = System.Drawing.Color.White
        Me.cmbBuatBaru.Image = Global.SIST.My.Resources.Resources.download
        Me.cmbBuatBaru.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmbBuatBaru.Location = New System.Drawing.Point(513, 120)
        Me.cmbBuatBaru.Name = "cmbBuatBaru"
        Me.cmbBuatBaru.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbBuatBaru.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBuatBaru.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmbBuatBaru.OnHoverForeColor = System.Drawing.Color.White
        Me.cmbBuatBaru.OnHoverImage = Nothing
        Me.cmbBuatBaru.OnPressedColor = System.Drawing.Color.Black
        Me.cmbBuatBaru.Radius = 2
        Me.cmbBuatBaru.Size = New System.Drawing.Size(131, 52)
        Me.cmbBuatBaru.TabIndex = 52
        Me.cmbBuatBaru.Text = "Buat Baru"
        Me.cmbBuatBaru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaGradientButton2.Image = Global.SIST.My.Resources.Resources.icon_save_png_1
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(513, 180)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(131, 54)
        Me.GunaGradientButton2.TabIndex = 51
        Me.GunaGradientButton2.Text = "Simpan"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SIST.My.Resources.Resources.borrow_png
        Me.PictureBox3.Location = New System.Drawing.Point(16, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(83, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SIST.My.Resources.Resources.Vector_PNG_Pic
        Me.PictureBox2.Location = New System.Drawing.Point(133, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(508, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'FormBuatPeminjamanAset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbBuatBaru)
        Me.Controls.Add(Me.GunaGradientButton2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormBuatPeminjamanAset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Peminjaman Aset"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblkdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlamatEmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTglSurat As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemove As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdTambah As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdBrowse As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgItem As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbBuatBaru As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents KodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNoHP As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCatatanUser As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpPinjam2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLokasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dtpPinjam1 As Guna.UI.WinForms.GunaDateTimePicker
End Class
