<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatSuratTerima
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPendahuluan = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoSurat = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPenutup = New System.Windows.Forms.RichTextBox()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPenerima = New Guna.UI.WinForms.GunaTextBox()
        Me.LblPengirim = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdRemove = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdTambah = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdBrowse = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgItem = New Guna.UI.WinForms.GunaDataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblKdJenisSurat = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAlamatPenerima = New System.Windows.Forms.RichTextBox()
        Me.txtNoTelpPenerima = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLampiran = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTglSurat = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPengirim = New Guna.UI.WinForms.GunaTextBox()
        Me.LblPenerima = New System.Windows.Forms.Label()
        Me.txtPerihal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPendahuluan)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 237)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(708, 114)
        Me.GroupBox5.TabIndex = 54
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kalimat Pembuka"
        '
        'txtPendahuluan
        '
        Me.txtPendahuluan.Location = New System.Drawing.Point(6, 21)
        Me.txtPendahuluan.Name = "txtPendahuluan"
        Me.txtPendahuluan.Size = New System.Drawing.Size(683, 85)
        Me.txtPendahuluan.TabIndex = 0
        Me.txtPendahuluan.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Nomor"
        '
        'txtNoSurat
        '
        Me.txtNoSurat.BaseColor = System.Drawing.Color.White
        Me.txtNoSurat.BorderColor = System.Drawing.Color.Silver
        Me.txtNoSurat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoSurat.Enabled = False
        Me.txtNoSurat.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoSurat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoSurat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoSurat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoSurat.Location = New System.Drawing.Point(309, 44)
        Me.txtNoSurat.Name = "txtNoSurat"
        Me.txtNoSurat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoSurat.Size = New System.Drawing.Size(174, 26)
        Me.txtNoSurat.TabIndex = 52
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPenutup)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 509)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(697, 114)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kalimat Penutup"
        '
        'txtPenutup
        '
        Me.txtPenutup.Location = New System.Drawing.Point(10, 21)
        Me.txtPenutup.Name = "txtPenutup"
        Me.txtPenutup.Size = New System.Drawing.Size(679, 85)
        Me.txtPenutup.TabIndex = 0
        Me.txtPenutup.Text = ""
        '
        'cmdSimpan
        '
        Me.cmdSimpan.AnimationHoverSpeed = 0.07!
        Me.cmdSimpan.AnimationSpeed = 0.03!
        Me.cmdSimpan.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpan.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpan.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpan.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpan.ForeColor = System.Drawing.Color.White
        Me.cmdSimpan.Image = Nothing
        Me.cmdSimpan.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpan.Location = New System.Drawing.Point(23, 629)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(146, 41)
        Me.cmdSimpan.TabIndex = 50
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtPenerima.Location = New System.Drawing.Point(434, 640)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPenerima.Size = New System.Drawing.Size(266, 26)
        Me.txtPenerima.TabIndex = 49
        '
        'LblPengirim
        '
        Me.LblPengirim.AutoSize = True
        Me.LblPengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPengirim.Location = New System.Drawing.Point(350, 643)
        Me.LblPengirim.Name = "LblPengirim"
        Me.LblPengirim.Size = New System.Drawing.Size(84, 20)
        Me.LblPengirim.TabIndex = 48
        Me.LblPengirim.Text = "Penerima"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdRemove)
        Me.GroupBox4.Controls.Add(Me.cmdTambah)
        Me.GroupBox4.Controls.Add(Me.cmdBrowse)
        Me.GroupBox4.Controls.Add(Me.dgItem)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(15, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(697, 154)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Isi"
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
        Me.cmdRemove.Location = New System.Drawing.Point(633, 61)
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
        Me.cmdTambah.Location = New System.Drawing.Point(633, 16)
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
        Me.cmdBrowse.Location = New System.Drawing.Point(633, 105)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowse.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowse.OnHoverImage = Nothing
        Me.cmdBrowse.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowse.Radius = 2
        Me.cmdBrowse.Size = New System.Drawing.Size(56, 41)
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
        Me.dgItem.Location = New System.Drawing.Point(13, 20)
        Me.dgItem.Name = "dgItem"
        Me.dgItem.RowHeadersVisible = False
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(614, 126)
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblKdJenisSurat)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 84)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'lblKdJenisSurat
        '
        Me.lblKdJenisSurat.AutoSize = True
        Me.lblKdJenisSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdJenisSurat.Location = New System.Drawing.Point(21, 34)
        Me.lblKdJenisSurat.Name = "lblKdJenisSurat"
        Me.lblKdJenisSurat.Size = New System.Drawing.Size(58, 24)
        Me.lblKdJenisSurat.TabIndex = 0
        Me.lblKdJenisSurat.Text = "G001"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAlamatPenerima)
        Me.GroupBox1.Controls.Add(Me.txtNoTelpPenerima)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLampiran)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpTglSurat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GunaGradientButton1)
        Me.GroupBox1.Controls.Add(Me.txtPengirim)
        Me.GroupBox1.Controls.Add(Me.LblPenerima)
        Me.GroupBox1.Controls.Add(Me.txtPerihal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 142)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail Surat"
        '
        'txtAlamatPenerima
        '
        Me.txtAlamatPenerima.Location = New System.Drawing.Point(434, 51)
        Me.txtAlamatPenerima.Name = "txtAlamatPenerima"
        Me.txtAlamatPenerima.Size = New System.Drawing.Size(276, 84)
        Me.txtAlamatPenerima.TabIndex = 35
        Me.txtAlamatPenerima.Text = ""
        '
        'txtNoTelpPenerima
        '
        Me.txtNoTelpPenerima.BaseColor = System.Drawing.Color.White
        Me.txtNoTelpPenerima.BorderColor = System.Drawing.Color.Silver
        Me.txtNoTelpPenerima.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoTelpPenerima.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoTelpPenerima.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoTelpPenerima.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoTelpPenerima.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoTelpPenerima.Location = New System.Drawing.Point(433, 14)
        Me.txtNoTelpPenerima.Name = "txtNoTelpPenerima"
        Me.txtNoTelpPenerima.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoTelpPenerima.Size = New System.Drawing.Size(278, 26)
        Me.txtNoTelpPenerima.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(362, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Telepon"
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
        Me.txtLampiran.Location = New System.Drawing.Point(96, 78)
        Me.txtLampiran.Name = "txtLampiran"
        Me.txtLampiran.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLampiran.Size = New System.Drawing.Size(255, 26)
        Me.txtLampiran.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 83)
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
        Me.dtpTglSurat.Size = New System.Drawing.Size(255, 22)
        Me.dtpTglSurat.TabIndex = 30
        Me.dtpTglSurat.Text = "14/03/2020"
        Me.dtpTglSurat.Value = New Date(2020, 3, 14, 16, 16, 28, 131)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Alamat"
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(357, 111)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(73, 26)
        Me.GunaGradientButton1.TabIndex = 26
        Me.GunaGradientButton1.Text = "Cari"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPengirim
        '
        Me.txtPengirim.BaseColor = System.Drawing.Color.White
        Me.txtPengirim.BorderColor = System.Drawing.Color.Silver
        Me.txtPengirim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPengirim.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPengirim.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPengirim.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPengirim.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPengirim.Location = New System.Drawing.Point(158, 110)
        Me.txtPengirim.Name = "txtPengirim"
        Me.txtPengirim.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPengirim.Size = New System.Drawing.Size(193, 26)
        Me.txtPengirim.TabIndex = 5
        '
        'LblPenerima
        '
        Me.LblPenerima.AutoSize = True
        Me.LblPenerima.Location = New System.Drawing.Point(11, 113)
        Me.LblPenerima.Name = "LblPenerima"
        Me.LblPenerima.Size = New System.Drawing.Size(141, 16)
        Me.LblPenerima.TabIndex = 4
        Me.LblPenerima.Text = "Telah Diterima dari"
        '
        'txtPerihal
        '
        Me.txtPerihal.BaseColor = System.Drawing.Color.White
        Me.txtPerihal.BorderColor = System.Drawing.Color.Silver
        Me.txtPerihal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerihal.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPerihal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPerihal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPerihal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPerihal.Location = New System.Drawing.Point(96, 46)
        Me.txtPerihal.Name = "txtPerihal"
        Me.txtPerihal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPerihal.Size = New System.Drawing.Size(255, 26)
        Me.txtPerihal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Perihal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 25)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "FORM SURAT TERIMA"
        '
        'FormBuatSuratTerima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 684)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoSurat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.txtPenerima)
        Me.Controls.Add(Me.LblPengirim)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FormBuatSuratTerima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSuratTerima"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPendahuluan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSurat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPenutup As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPenerima As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblPengirim As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRemove As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdTambah As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdBrowse As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgItem As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents KodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAlamatPenerima As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNoTelpPenerima As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLampiran As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTglSurat As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPengirim As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LblPenerima As System.Windows.Forms.Label
    Friend WithEvents txtPerihal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
