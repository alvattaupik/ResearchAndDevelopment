<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatSuratPengajuanBiayaPerjalananDinas
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoSurat = New System.Windows.Forms.TextBox()
        Me.LblkdJenisSurat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpTglBerangkat = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.txtLampiran = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTglSurat = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPenerima = New Guna.UI.WinForms.GunaTextBox()
        Me.LblPenerima = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPendahuluan = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdRemove = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdTambah = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgItem = New Guna.UI.WinForms.GunaDataGridView()
        Me.DeskripsiKebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimasiBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPenutup = New System.Windows.Forms.RichTextBox()
        Me.txtHRD = New Guna.UI.WinForms.GunaTextBox()
        Me.LblPengirim = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupervisor = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbBuatBaru = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNoSurat)
        Me.Panel1.Controls.Add(Me.LblkdJenisSurat)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 114)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(288, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PERJALANAN DINAS"
        '
        'txtNoSurat
        '
        Me.txtNoSurat.Location = New System.Drawing.Point(106, 25)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.Size = New System.Drawing.Size(176, 20)
        Me.txtNoSurat.TabIndex = 4
        Me.txtNoSurat.Visible = False
        '
        'LblkdJenisSurat
        '
        Me.LblkdJenisSurat.AutoSize = True
        Me.LblkdJenisSurat.Location = New System.Drawing.Point(111, 9)
        Me.LblkdJenisSurat.Name = "LblkdJenisSurat"
        Me.LblkdJenisSurat.Size = New System.Drawing.Size(40, 13)
        Me.LblkdJenisSurat.TabIndex = 2
        Me.LblkdJenisSurat.Text = "GA002"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(231, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SURAT PENGAJUAN BIAYA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpTglBerangkat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GunaTextBox1)
        Me.GroupBox1.Controls.Add(Me.txtLampiran)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpTglSurat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPenerima)
        Me.GroupBox1.Controls.Add(Me.LblPenerima)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 142)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Tujuan Dinas"
        '
        'dtpTglBerangkat
        '
        Me.dtpTglBerangkat.BaseColor = System.Drawing.Color.White
        Me.dtpTglBerangkat.BorderColor = System.Drawing.Color.Silver
        Me.dtpTglBerangkat.CustomFormat = Nothing
        Me.dtpTglBerangkat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTglBerangkat.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglBerangkat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglBerangkat.ForeColor = System.Drawing.Color.Black
        Me.dtpTglBerangkat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglBerangkat.Location = New System.Drawing.Point(381, 110)
        Me.dtpTglBerangkat.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTglBerangkat.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTglBerangkat.Name = "dtpTglBerangkat"
        Me.dtpTglBerangkat.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTglBerangkat.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglBerangkat.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglBerangkat.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTglBerangkat.Size = New System.Drawing.Size(250, 22)
        Me.dtpTglBerangkat.TabIndex = 38
        Me.dtpTglBerangkat.Text = "14/03/2020"
        Me.dtpTglBerangkat.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Tanggal Berangkat"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(96, 78)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(535, 26)
        Me.GunaTextBox1.TabIndex = 36
        '
        'txtLampiran
        '
        Me.txtLampiran.BaseColor = System.Drawing.Color.White
        Me.txtLampiran.BorderColor = System.Drawing.Color.Silver
        Me.txtLampiran.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLampiran.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLampiran.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLampiran.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLampiran.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLampiran.Location = New System.Drawing.Point(96, 46)
        Me.txtLampiran.Name = "txtLampiran"
        Me.txtLampiran.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLampiran.Size = New System.Drawing.Size(535, 26)
        Me.txtLampiran.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Lampiran"
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
        Me.dtpTglSurat.Location = New System.Drawing.Point(96, 18)
        Me.dtpTglSurat.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTglSurat.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTglSurat.Name = "dtpTglSurat"
        Me.dtpTglSurat.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTglSurat.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglSurat.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTglSurat.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTglSurat.Size = New System.Drawing.Size(214, 22)
        Me.dtpTglSurat.TabIndex = 30
        Me.dtpTglSurat.Text = "14/03/2020"
        Me.dtpTglSurat.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tujuan"
        '
        'txtPenerima
        '
        Me.txtPenerima.BaseColor = System.Drawing.Color.White
        Me.txtPenerima.BorderColor = System.Drawing.Color.Silver
        Me.txtPenerima.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPenerima.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPenerima.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPenerima.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPenerima.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPenerima.Location = New System.Drawing.Point(96, 110)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPenerima.Size = New System.Drawing.Size(132, 26)
        Me.txtPenerima.TabIndex = 5
        '
        'LblPenerima
        '
        Me.LblPenerima.AutoSize = True
        Me.LblPenerima.Location = New System.Drawing.Point(3, 113)
        Me.LblPenerima.Name = "LblPenerima"
        Me.LblPenerima.Size = New System.Drawing.Size(90, 16)
        Me.LblPenerima.TabIndex = 4
        Me.LblPenerima.Text = "Lama Dinas"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPendahuluan)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(7, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(774, 93)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kalimat Pembuka"
        '
        'txtPendahuluan
        '
        Me.txtPendahuluan.Location = New System.Drawing.Point(6, 21)
        Me.txtPendahuluan.Name = "txtPendahuluan"
        Me.txtPendahuluan.Size = New System.Drawing.Size(762, 64)
        Me.txtPendahuluan.TabIndex = 0
        Me.txtPendahuluan.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdRemove)
        Me.GroupBox4.Controls.Add(Me.cmdTambah)
        Me.GroupBox4.Controls.Add(Me.dgItem)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 348)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(774, 154)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Anggaran Yang Dibutuhkan"
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
        Me.cmdRemove.Location = New System.Drawing.Point(712, 86)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRemove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRemove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRemove.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRemove.OnHoverImage = Nothing
        Me.cmdRemove.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRemove.Radius = 2
        Me.cmdRemove.Size = New System.Drawing.Size(56, 41)
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
        Me.cmdTambah.FocusedColor = System.Drawing.Color.Empty
        Me.cmdTambah.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdTambah.ForeColor = System.Drawing.Color.White
        Me.cmdTambah.Image = Nothing
        Me.cmdTambah.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdTambah.Location = New System.Drawing.Point(712, 39)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdTambah.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTambah.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdTambah.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdTambah.OnHoverImage = Nothing
        Me.cmdTambah.OnPressedColor = System.Drawing.Color.Black
        Me.cmdTambah.Radius = 2
        Me.cmdTambah.Size = New System.Drawing.Size(56, 41)
        Me.cmdTambah.TabIndex = 33
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.dgItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeskripsiKebutuhan, Me.Qty, Me.EstimasiBiaya})
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
        Me.dgItem.Location = New System.Drawing.Point(13, 20)
        Me.dgItem.Name = "dgItem"
        Me.dgItem.RowHeadersVisible = False
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(693, 126)
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
        'DeskripsiKebutuhan
        '
        Me.DeskripsiKebutuhan.HeaderText = "Deskripsi Kebutuhan"
        Me.DeskripsiKebutuhan.Name = "DeskripsiKebutuhan"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'EstimasiBiaya
        '
        Me.EstimasiBiaya.HeaderText = "Estimasi Biaya"
        Me.EstimasiBiaya.Name = "EstimasiBiaya"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPenutup)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 508)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(478, 126)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kalimat Penutup"
        '
        'txtPenutup
        '
        Me.txtPenutup.Location = New System.Drawing.Point(10, 21)
        Me.txtPenutup.Name = "txtPenutup"
        Me.txtPenutup.Size = New System.Drawing.Size(460, 96)
        Me.txtPenutup.TabIndex = 0
        Me.txtPenutup.Text = ""
        '
        'txtHRD
        '
        Me.txtHRD.BaseColor = System.Drawing.Color.White
        Me.txtHRD.BorderColor = System.Drawing.Color.Silver
        Me.txtHRD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHRD.FocusedBaseColor = System.Drawing.Color.White
        Me.txtHRD.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHRD.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHRD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHRD.Location = New System.Drawing.Point(596, 529)
        Me.txtHRD.Name = "txtHRD"
        Me.txtHRD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHRD.Size = New System.Drawing.Size(190, 29)
        Me.txtHRD.TabIndex = 48
        '
        'LblPengirim
        '
        Me.LblPengirim.AutoSize = True
        Me.LblPengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPengirim.Location = New System.Drawing.Point(496, 529)
        Me.LblPengirim.Name = "LblPengirim"
        Me.LblPengirim.Size = New System.Drawing.Size(48, 20)
        Me.LblPengirim.TabIndex = 47
        Me.LblPengirim.Text = "HRD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 573)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Supervisor"
        Me.Label3.Visible = False
        '
        'txtSupervisor
        '
        Me.txtSupervisor.BaseColor = System.Drawing.Color.White
        Me.txtSupervisor.BorderColor = System.Drawing.Color.Silver
        Me.txtSupervisor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupervisor.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSupervisor.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupervisor.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSupervisor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSupervisor.Location = New System.Drawing.Point(596, 573)
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSupervisor.Size = New System.Drawing.Size(190, 29)
        Me.txtSupervisor.TabIndex = 50
        Me.txtSupervisor.Visible = False
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
        Me.cmbBuatBaru.Location = New System.Drawing.Point(655, 120)
        Me.cmbBuatBaru.Name = "cmbBuatBaru"
        Me.cmbBuatBaru.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmbBuatBaru.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbBuatBaru.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmbBuatBaru.OnHoverForeColor = System.Drawing.Color.White
        Me.cmbBuatBaru.OnHoverImage = Nothing
        Me.cmbBuatBaru.OnPressedColor = System.Drawing.Color.Black
        Me.cmbBuatBaru.Radius = 2
        Me.cmbBuatBaru.Size = New System.Drawing.Size(131, 62)
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
        Me.GunaGradientButton2.Location = New System.Drawing.Point(655, 188)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(131, 63)
        Me.GunaGradientButton2.TabIndex = 51
        Me.GunaGradientButton2.Text = "Simpan"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIST.My.Resources.Resources.expense_tracking
        Me.PictureBox1.Location = New System.Drawing.Point(5, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SIST.My.Resources.Resources.Vector_31
        Me.PictureBox2.Location = New System.Drawing.Point(101, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(693, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'FormBuatSuratPengajuanBiayaPerjalananDinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 635)
        Me.Controls.Add(Me.cmbBuatBaru)
        Me.Controls.Add(Me.GunaGradientButton2)
        Me.Controls.Add(Me.txtSupervisor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHRD)
        Me.Controls.Add(Me.LblPengirim)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormBuatSuratPengajuanBiayaPerjalananDinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBuatSuratJalan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblkdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents txtNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLampiran As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTglSurat As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPenerima As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblPenerima As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPendahuluan As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemove As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdTambah As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgItem As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPenutup As System.Windows.Forms.RichTextBox
    Friend WithEvents txtHRD As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblPengirim As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSupervisor As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbBuatBaru As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTglBerangkat As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DeskripsiKebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstimasiBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
