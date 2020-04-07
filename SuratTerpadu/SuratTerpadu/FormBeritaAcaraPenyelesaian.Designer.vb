<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBeritaAcaraPenyelesaian
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtJabatan = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtNoTelepon = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKepada = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaDateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgItem = New Guna.UI.WinForms.GunaDataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdRemove = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdTambah = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdBrowse = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDibuatOleh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupervisor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdSimpanSurat = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM BERITA ACARA PENYELESAIAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJabatan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GunaGradientButton1)
        Me.GroupBox1.Controls.Add(Me.txtNoTelepon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKepada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GunaDateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 155)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tujuan"
        '
        'txtJabatan
        '
        Me.txtJabatan.BaseColor = System.Drawing.Color.White
        Me.txtJabatan.BorderColor = System.Drawing.Color.Silver
        Me.txtJabatan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJabatan.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJabatan.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJabatan.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJabatan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJabatan.Location = New System.Drawing.Point(116, 77)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJabatan.Size = New System.Drawing.Size(242, 26)
        Me.txtJabatan.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Jabatan"
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(376, 48)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(68, 26)
        Me.GunaGradientButton1.TabIndex = 27
        Me.GunaGradientButton1.Text = "Cari"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.BaseColor = System.Drawing.Color.White
        Me.txtNoTelepon.BorderColor = System.Drawing.Color.Silver
        Me.txtNoTelepon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoTelepon.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoTelepon.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoTelepon.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoTelepon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoTelepon.Location = New System.Drawing.Point(449, 78)
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoTelepon.Size = New System.Drawing.Size(222, 26)
        Me.txtNoTelepon.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NoTelp"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(116, 109)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(628, 39)
        Me.txtAlamat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'txtKepada
        '
        Me.txtKepada.BaseColor = System.Drawing.Color.White
        Me.txtKepada.BorderColor = System.Drawing.Color.Silver
        Me.txtKepada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKepada.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKepada.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKepada.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKepada.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKepada.Location = New System.Drawing.Point(116, 48)
        Me.txtKepada.Name = "txtKepada"
        Me.txtKepada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKepada.Size = New System.Drawing.Size(242, 26)
        Me.txtKepada.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kepada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Surat"
        '
        'GunaDateTimePicker1
        '
        Me.GunaDateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.GunaDateTimePicker1.CustomFormat = Nothing
        Me.GunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.GunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaDateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.GunaDateTimePicker1.Location = New System.Drawing.Point(115, 14)
        Me.GunaDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.GunaDateTimePicker1.Name = "GunaDateTimePicker1"
        Me.GunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaDateTimePicker1.Size = New System.Drawing.Size(123, 30)
        Me.GunaDateTimePicker1.TabIndex = 0
        Me.GunaDateTimePicker1.Text = "20/03/2020"
        Me.GunaDateTimePicker1.Value = New Date(2020, 3, 20, 10, 29, 8, 401)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 87)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pendahuluan"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 21)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(737, 60)
        Me.TextBox2.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgItem)
        Me.GroupBox3.Controls.Add(Me.cmdRemove)
        Me.GroupBox3.Controls.Add(Me.cmdTambah)
        Me.GroupBox3.Controls.Add(Me.cmdBrowse)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(751, 166)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Isi"
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
        Me.dgItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.Deskripsi, Me.Qty, Me.Keterangan})
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
        Me.dgItem.Location = New System.Drawing.Point(9, 21)
        Me.dgItem.Name = "dgItem"
        Me.dgItem.RowHeadersVisible = False
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(674, 135)
        Me.dgItem.TabIndex = 38
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
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Keterangan
        '
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
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
        Me.cmdRemove.Location = New System.Drawing.Point(689, 68)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRemove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRemove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRemove.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRemove.OnHoverImage = Nothing
        Me.cmdRemove.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRemove.Radius = 2
        Me.cmdRemove.Size = New System.Drawing.Size(56, 41)
        Me.cmdRemove.TabIndex = 37
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
        Me.cmdTambah.FocusedColor = System.Drawing.Color.Empty
        Me.cmdTambah.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdTambah.ForeColor = System.Drawing.Color.White
        Me.cmdTambah.Image = Nothing
        Me.cmdTambah.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdTambah.Location = New System.Drawing.Point(689, 21)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdTambah.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTambah.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdTambah.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdTambah.OnHoverImage = Nothing
        Me.cmdTambah.OnPressedColor = System.Drawing.Color.Black
        Me.cmdTambah.Radius = 2
        Me.cmdTambah.Size = New System.Drawing.Size(56, 41)
        Me.cmdTambah.TabIndex = 36
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
        Me.cmdBrowse.Location = New System.Drawing.Point(689, 115)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowse.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowse.OnHoverImage = Nothing
        Me.cmdBrowse.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowse.Radius = 2
        Me.cmdBrowse.Size = New System.Drawing.Size(56, 41)
        Me.cmdBrowse.TabIndex = 35
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 444)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(751, 92)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Penutup"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(6, 21)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(739, 60)
        Me.TextBox3.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDibuatOleh)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtSupervisor)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(414, 535)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(349, 63)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Object Footer"
        '
        'txtDibuatOleh
        '
        Me.txtDibuatOleh.Location = New System.Drawing.Point(84, 39)
        Me.txtDibuatOleh.Name = "txtDibuatOleh"
        Me.txtDibuatOleh.Size = New System.Drawing.Size(259, 20)
        Me.txtDibuatOleh.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Dibuat Oleh"
        '
        'txtSupervisor
        '
        Me.txtSupervisor.Location = New System.Drawing.Point(84, 16)
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.Size = New System.Drawing.Size(259, 20)
        Me.txtSupervisor.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Supervisor"
        '
        'cmdSimpanSurat
        '
        Me.cmdSimpanSurat.AnimationHoverSpeed = 0.07!
        Me.cmdSimpanSurat.AnimationSpeed = 0.03!
        Me.cmdSimpanSurat.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpanSurat.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpanSurat.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpanSurat.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpanSurat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpanSurat.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpanSurat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpanSurat.ForeColor = System.Drawing.Color.White
        Me.cmdSimpanSurat.Image = Nothing
        Me.cmdSimpanSurat.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpanSurat.Location = New System.Drawing.Point(11, 538)
        Me.cmdSimpanSurat.Name = "cmdSimpanSurat"
        Me.cmdSimpanSurat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpanSurat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpanSurat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpanSurat.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpanSurat.OnHoverImage = Nothing
        Me.cmdSimpanSurat.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpanSurat.Radius = 2
        Me.cmdSimpanSurat.Size = New System.Drawing.Size(383, 55)
        Me.cmdSimpanSurat.TabIndex = 37
        Me.cmdSimpanSurat.Text = "Simpan"
        Me.cmdSimpanSurat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(535, 8)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(222, 20)
        Me.txtNoSurat.TabIndex = 38
        Me.txtNoSurat.Visible = False
        '
        'FormBeritaAcaraPenyelesaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 603)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoSurat)
        Me.Controls.Add(Me.cmdSimpanSurat)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FormBeritaAcaraPenyelesaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBeritaAcaraPenyelesaian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoTelepon As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKepada As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaDateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents txtJabatan As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemove As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdTambah As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdBrowse As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDibuatOleh As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSupervisor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpanSurat As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents dgItem As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents KodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
