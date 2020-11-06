<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherCodeGenerator
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
        Me.CopyToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaTransfarantPictureBox13 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox12 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNewVoucher = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtGenerateNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtPathExport = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpanGenerateVoucher = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtToVoucher = New System.Windows.Forms.TextBox()
        Me.txtFromVoucher = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gbRincianNomor = New System.Windows.Forms.GroupBox()
        Me.picExportToExcel = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvRincianNomor = New System.Windows.Forms.DataGridView()
        Me.lblJumlahVoucher = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListGenerate = New System.Windows.Forms.DataGridView()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblJumlahDataNomor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox8 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbRincianNomor.SuspendLayout()
        CType(Me.picExportToExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRincianNomor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CopyToExcelToolStripMenuItem
        '
        Me.CopyToExcelToolStripMenuItem.Name = "CopyToExcelToolStripMenuItem"
        Me.CopyToExcelToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CopyToExcelToolStripMenuItem.Text = "Copy To Excel"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToExcelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 26)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox13)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox12)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox5)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.gbRincianNomor)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox8)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 722)
        Me.Panel1.TabIndex = 43
        '
        'GunaTransfarantPictureBox13
        '
        Me.GunaTransfarantPictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox13.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox13.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox13.Location = New System.Drawing.Point(555, 1)
        Me.GunaTransfarantPictureBox13.Name = "GunaTransfarantPictureBox13"
        Me.GunaTransfarantPictureBox13.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox13.TabIndex = 28
        Me.GunaTransfarantPictureBox13.TabStop = False
        '
        'GunaTransfarantPictureBox12
        '
        Me.GunaTransfarantPictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox12.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox12.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox12.Location = New System.Drawing.Point(463, 1)
        Me.GunaTransfarantPictureBox12.Name = "GunaTransfarantPictureBox12"
        Me.GunaTransfarantPictureBox12.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox12.TabIndex = 27
        Me.GunaTransfarantPictureBox12.TabStop = False
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(278, 1)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 26
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(185, 0)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 25
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(93, 0)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 24
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 23
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Silver
        Me.GroupBox5.Controls.Add(Me.cmbCabang)
        Me.GroupBox5.Controls.Add(Me.Panel3)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.txtKeterangan)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtGenerateNumber)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 77)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(646, 115)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(212, 81)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(418, 21)
        Me.cmbCabang.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnNewVoucher)
        Me.Panel3.Location = New System.Drawing.Point(3, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(84, 98)
        Me.Panel3.TabIndex = 13
        '
        'btnNewVoucher
        '
        Me.btnNewVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNewVoucher.Location = New System.Drawing.Point(4, 4)
        Me.btnNewVoucher.Name = "btnNewVoucher"
        Me.btnNewVoucher.Size = New System.Drawing.Size(75, 87)
        Me.btnNewVoucher.TabIndex = 7
        Me.btnNewVoucher.Text = "New"
        Me.btnNewVoucher.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(96, 86)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 13)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Cabang"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(212, 32)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(418, 42)
        Me.txtKeterangan.TabIndex = 3
        Me.txtKeterangan.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(96, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Keterangan"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(95, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(91, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Generate Number"
        '
        'txtGenerateNumber
        '
        Me.txtGenerateNumber.Location = New System.Drawing.Point(212, 8)
        Me.txtGenerateNumber.Name = "txtGenerateNumber"
        Me.txtGenerateNumber.ReadOnly = True
        Me.txtGenerateNumber.Size = New System.Drawing.Size(418, 20)
        Me.txtGenerateNumber.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox6.Controls.Add(Me.btnBrowse)
        Me.GroupBox6.Controls.Add(Me.txtPathExport)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.btnSimpanGenerateVoucher)
        Me.GroupBox6.Controls.Add(Me.btnPreview)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.txtToVoucher)
        Me.GroupBox6.Controls.Add(Me.txtFromVoucher)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 197)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(646, 84)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Parameters"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(133, 52)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 24
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPathExport
        '
        Me.txtPathExport.Location = New System.Drawing.Point(214, 54)
        Me.txtPathExport.Name = "txtPathExport"
        Me.txtPathExport.ReadOnly = True
        Me.txtPathExport.Size = New System.Drawing.Size(264, 20)
        Me.txtPathExport.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Lokasi Export"
        '
        'btnSimpanGenerateVoucher
        '
        Me.btnSimpanGenerateVoucher.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSimpanGenerateVoucher.Location = New System.Drawing.Point(497, 46)
        Me.btnSimpanGenerateVoucher.Name = "btnSimpanGenerateVoucher"
        Me.btnSimpanGenerateVoucher.Size = New System.Drawing.Size(133, 31)
        Me.btnSimpanGenerateVoucher.TabIndex = 5
        Me.btnSimpanGenerateVoucher.Text = "Simpan"
        Me.btnSimpanGenerateVoucher.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPreview.Location = New System.Drawing.Point(498, 8)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(133, 31)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(321, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 20)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "To"
        '
        'txtToVoucher
        '
        Me.txtToVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToVoucher.Location = New System.Drawing.Point(371, 12)
        Me.txtToVoucher.Name = "txtToVoucher"
        Me.txtToVoucher.Size = New System.Drawing.Size(107, 26)
        Me.txtToVoucher.TabIndex = 2
        '
        'txtFromVoucher
        '
        Me.txtFromVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromVoucher.Location = New System.Drawing.Point(214, 12)
        Me.txtFromVoucher.Name = "txtFromVoucher"
        Me.txtFromVoucher.Size = New System.Drawing.Size(98, 26)
        Me.txtFromVoucher.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(2, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(199, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Voucher Number From :"
        '
        'gbRincianNomor
        '
        Me.gbRincianNomor.BackColor = System.Drawing.Color.LightGray
        Me.gbRincianNomor.Controls.Add(Me.picExportToExcel)
        Me.gbRincianNomor.Controls.Add(Me.Button1)
        Me.gbRincianNomor.Controls.Add(Me.Label5)
        Me.gbRincianNomor.Controls.Add(Me.dgvRincianNomor)
        Me.gbRincianNomor.Controls.Add(Me.lblJumlahVoucher)
        Me.gbRincianNomor.Location = New System.Drawing.Point(424, 282)
        Me.gbRincianNomor.Name = "gbRincianNomor"
        Me.gbRincianNomor.Size = New System.Drawing.Size(225, 290)
        Me.gbRincianNomor.TabIndex = 21
        Me.gbRincianNomor.TabStop = False
        Me.gbRincianNomor.Visible = False
        '
        'picExportToExcel
        '
        Me.picExportToExcel.BackColor = System.Drawing.Color.Transparent
        Me.picExportToExcel.BaseColor = System.Drawing.Color.Lime
        Me.picExportToExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportToExcel.Image = Global.MonitoringMember.My.Resources.Resources.Export
        Me.picExportToExcel.Location = New System.Drawing.Point(6, 251)
        Me.picExportToExcel.Name = "picExportToExcel"
        Me.picExportToExcel.Size = New System.Drawing.Size(82, 31)
        Me.picExportToExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExportToExcel.TabIndex = 16
        Me.picExportToExcel.TabStop = False
        Me.picExportToExcel.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(175, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Rincian Voucher"
        '
        'dgvRincianNomor
        '
        Me.dgvRincianNomor.AllowUserToAddRows = False
        Me.dgvRincianNomor.AllowUserToDeleteRows = False
        Me.dgvRincianNomor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRincianNomor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvRincianNomor.Location = New System.Drawing.Point(6, 36)
        Me.dgvRincianNomor.Name = "dgvRincianNomor"
        Me.dgvRincianNomor.ReadOnly = True
        Me.dgvRincianNomor.RowHeadersVisible = False
        Me.dgvRincianNomor.Size = New System.Drawing.Size(213, 213)
        Me.dgvRincianNomor.TabIndex = 4
        '
        'lblJumlahVoucher
        '
        Me.lblJumlahVoucher.AutoSize = True
        Me.lblJumlahVoucher.Location = New System.Drawing.Point(89, 259)
        Me.lblJumlahVoucher.Name = "lblJumlahVoucher"
        Me.lblJumlahVoucher.Size = New System.Drawing.Size(89, 13)
        Me.lblJumlahVoucher.TabIndex = 3
        Me.lblJumlahVoucher.Text = "Jumlah Nomor : 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dgvListGenerate)
        Me.GroupBox1.Controls.Add(Me.picBarcode)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblJumlahDataNomor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 281)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'dgvListGenerate
        '
        Me.dgvListGenerate.AllowUserToAddRows = False
        Me.dgvListGenerate.AllowUserToDeleteRows = False
        Me.dgvListGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListGenerate.Location = New System.Drawing.Point(8, 39)
        Me.dgvListGenerate.Name = "dgvListGenerate"
        Me.dgvListGenerate.ReadOnly = True
        Me.dgvListGenerate.RowHeadersVisible = False
        Me.dgvListGenerate.Size = New System.Drawing.Size(340, 213)
        Me.dgvListGenerate.TabIndex = 0
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(324, 118)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(90, 88)
        Me.picBarcode.TabIndex = 5
        Me.picBarcode.TabStop = False
        Me.picBarcode.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.See
        Me.PictureBox1.Location = New System.Drawing.Point(354, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblJumlahDataNomor
        '
        Me.lblJumlahDataNomor.AutoSize = True
        Me.lblJumlahDataNomor.Location = New System.Drawing.Point(194, 261)
        Me.lblJumlahDataNomor.Name = "lblJumlahDataNomor"
        Me.lblJumlahDataNomor.Size = New System.Drawing.Size(81, 13)
        Me.lblJumlahDataNomor.TabIndex = 2
        Me.lblJumlahDataNomor.Text = "Jumlah Data : 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Voucher Yang Telah Dibuat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(138, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 33)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Voucher Code Generator"
        '
        'GunaTransfarantPictureBox8
        '
        Me.GunaTransfarantPictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox8.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox8.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox8.Location = New System.Drawing.Point(370, 1)
        Me.GunaTransfarantPictureBox8.Name = "GunaTransfarantPictureBox8"
        Me.GunaTransfarantPictureBox8.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox8.TabIndex = 19
        Me.GunaTransfarantPictureBox8.TabStop = False
        '
        'frmVoucherCodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 579)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVoucherCodeGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Code Generator"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaTransfarantPictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbRincianNomor.ResumeLayout(False)
        Me.gbRincianNomor.PerformLayout()
        CType(Me.picExportToExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRincianNomor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CopyToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbRincianNomor As System.Windows.Forms.GroupBox
    Friend WithEvents picExportToExcel As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvRincianNomor As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlahVoucher As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJumlahDataNomor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvListGenerate As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox8 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnNewVoucher As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtGenerateNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpanGenerateVoucher As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtToVoucher As System.Windows.Forms.TextBox
    Friend WithEvents txtFromVoucher As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox13 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox12 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents picBarcode As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtPathExport As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
