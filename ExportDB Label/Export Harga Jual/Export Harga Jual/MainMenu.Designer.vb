<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahDataSAP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCariAset = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLokasi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdTambah = New System.Windows.Forms.Button()
        Me.dgAsetSAP = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdExportDB = New System.Windows.Forms.Button()
        Me.dgKeranjangExport = New System.Windows.Forms.DataGridView()
        Me.KodeAset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip5 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahDataSudahDicetak = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdExportDBSudahDicetak = New System.Windows.Forms.Button()
        Me.dgKeranjangExportSudahDicetak = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.test = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahDataSAPSudahDicetak = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCariAsetSudahDicetak = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLokasiSudahDicetak = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdTambahSudahDicetak = New System.Windows.Forms.Button()
        Me.dgAsetSAPSudahDicetak = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.dgAsetSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        CType(Me.dgKeranjangExport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip5.SuspendLayout()
        CType(Me.dgKeranjangExportSudahDicetak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.test.SuspendLayout()
        CType(Me.dgAsetSAPSudahDicetak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbGroup)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.StatusStrip2)
        Me.GroupBox2.Controls.Add(Me.txtCariAset)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbLokasi)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdTambah)
        Me.GroupBox2.Controls.Add(Me.dgAsetSAP)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar Aset SAP"
        '
        'cmbGroup
        '
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(148, 45)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(458, 24)
        Me.cmbGroup.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Group"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahDataSAP})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 265)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(606, 22)
        Me.StatusStrip2.TabIndex = 6
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblJumlahDataSAP
        '
        Me.lblJumlahDataSAP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahDataSAP.Name = "lblJumlahDataSAP"
        Me.lblJumlahDataSAP.Size = New System.Drawing.Size(82, 17)
        Me.lblJumlahDataSAP.Text = "JumlahData"
        '
        'txtCariAset
        '
        Me.txtCariAset.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariAset.Location = New System.Drawing.Point(148, 75)
        Me.txtCariAset.Name = "txtCariAset"
        Me.txtCariAset.Size = New System.Drawing.Size(458, 25)
        Me.txtCariAset.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama  Aset"
        '
        'cmbLokasi
        '
        Me.cmbLokasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLokasi.FormattingEnabled = True
        Me.cmbLokasi.Location = New System.Drawing.Point(148, 15)
        Me.cmbLokasi.Name = "cmbLokasi"
        Me.cmbLokasi.Size = New System.Drawing.Size(458, 24)
        Me.cmbLokasi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lokasi"
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(538, 117)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(68, 141)
        Me.cmdTambah.TabIndex = 1
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'dgAsetSAP
        '
        Me.dgAsetSAP.AllowUserToAddRows = False
        Me.dgAsetSAP.AllowUserToDeleteRows = False
        Me.dgAsetSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAsetSAP.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgAsetSAP.Location = New System.Drawing.Point(11, 117)
        Me.dgAsetSAP.Name = "dgAsetSAP"
        Me.dgAsetSAP.Size = New System.Drawing.Size(517, 145)
        Me.dgAsetSAP.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StatusStrip3)
        Me.GroupBox3.Controls.Add(Me.cmdExportDB)
        Me.GroupBox3.Controls.Add(Me.dgKeranjangExport)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(613, 235)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keranjang Export"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahData})
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 207)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(607, 25)
        Me.StatusStrip3.TabIndex = 3
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'lblJumlahData
        '
        Me.lblJumlahData.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(204, 20)
        Me.lblJumlahData.Text = "Jumlah Data Untuk DiExport"
        '
        'cmdExportDB
        '
        Me.cmdExportDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportDB.Location = New System.Drawing.Point(539, 26)
        Me.cmdExportDB.Name = "cmdExportDB"
        Me.cmdExportDB.Size = New System.Drawing.Size(68, 173)
        Me.cmdExportDB.TabIndex = 2
        Me.cmdExportDB.Text = "Export Data"
        Me.cmdExportDB.UseVisualStyleBackColor = True
        '
        'dgKeranjangExport
        '
        Me.dgKeranjangExport.AllowUserToAddRows = False
        Me.dgKeranjangExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKeranjangExport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeAset, Me.NamaAset, Me.Tahun, Me.ItemName, Me.Lokasi})
        Me.dgKeranjangExport.Location = New System.Drawing.Point(12, 26)
        Me.dgKeranjangExport.Name = "dgKeranjangExport"
        Me.dgKeranjangExport.Size = New System.Drawing.Size(521, 172)
        Me.dgKeranjangExport.TabIndex = 0
        '
        'KodeAset
        '
        Me.KodeAset.HeaderText = "Kode Aset"
        Me.KodeAset.Name = "KodeAset"
        Me.KodeAset.ReadOnly = True
        '
        'NamaAset
        '
        Me.NamaAset.HeaderText = "Nama Aset"
        Me.NamaAset.Name = "NamaAset"
        Me.NamaAset.ReadOnly = True
        '
        'Tahun
        '
        Me.Tahun.HeaderText = "Tahun"
        Me.Tahun.Name = "Tahun"
        Me.Tahun.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Lokasi
        '
        Me.Lokasi.HeaderText = "Lokasi"
        Me.Lokasi.Name = "Lokasi"
        Me.Lokasi.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Export_Database_LabelAset.My.Resources.Resources.blue_background_with_abstract_dynamic_shapes_1393_161
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Export_Database_LabelAset.My.Resources.Resources.images__2_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 77)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(393, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Versi 1.1 Build "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Export Database Label Aset"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 113)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(654, 569)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(646, 543)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BELUM DICETAK"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(646, 543)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SUDAH DICETAK"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Daftar Label Sudah Dicetak"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.StatusStrip5)
        Me.GroupBox5.Controls.Add(Me.cmdExportDBSudahDicetak)
        Me.GroupBox5.Controls.Add(Me.dgKeranjangExportSudahDicetak)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 319)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(613, 218)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Keranjang Export"
        '
        'StatusStrip5
        '
        Me.StatusStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahDataSudahDicetak})
        Me.StatusStrip5.Location = New System.Drawing.Point(3, 190)
        Me.StatusStrip5.Name = "StatusStrip5"
        Me.StatusStrip5.Size = New System.Drawing.Size(607, 25)
        Me.StatusStrip5.TabIndex = 3
        Me.StatusStrip5.Text = "StatusStrip5"
        '
        'lblJumlahDataSudahDicetak
        '
        Me.lblJumlahDataSudahDicetak.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahDataSudahDicetak.Name = "lblJumlahDataSudahDicetak"
        Me.lblJumlahDataSudahDicetak.Size = New System.Drawing.Size(204, 20)
        Me.lblJumlahDataSudahDicetak.Text = "Jumlah Data Untuk DiExport"
        '
        'cmdExportDBSudahDicetak
        '
        Me.cmdExportDBSudahDicetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportDBSudahDicetak.Location = New System.Drawing.Point(543, 19)
        Me.cmdExportDBSudahDicetak.Name = "cmdExportDBSudahDicetak"
        Me.cmdExportDBSudahDicetak.Size = New System.Drawing.Size(64, 168)
        Me.cmdExportDBSudahDicetak.TabIndex = 2
        Me.cmdExportDBSudahDicetak.Text = "Export Data"
        Me.cmdExportDBSudahDicetak.UseVisualStyleBackColor = True
        '
        'dgKeranjangExportSudahDicetak
        '
        Me.dgKeranjangExportSudahDicetak.AllowUserToAddRows = False
        Me.dgKeranjangExportSudahDicetak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKeranjangExportSudahDicetak.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgKeranjangExportSudahDicetak.Location = New System.Drawing.Point(10, 19)
        Me.dgKeranjangExportSudahDicetak.Name = "dgKeranjangExportSudahDicetak"
        Me.dgKeranjangExportSudahDicetak.Size = New System.Drawing.Size(524, 168)
        Me.dgKeranjangExportSudahDicetak.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Aset"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Aset"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tahun"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Item Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lokasi"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.test)
        Me.GroupBox4.Controls.Add(Me.txtCariAsetSudahDicetak)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmbLokasiSudahDicetak)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cmdTambahSudahDicetak)
        Me.GroupBox4.Controls.Add(Me.dgAsetSAPSudahDicetak)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 260)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Daftar Aset SAP"
        '
        'test
        '
        Me.test.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahDataSAPSudahDicetak})
        Me.test.Location = New System.Drawing.Point(3, 235)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(606, 22)
        Me.test.TabIndex = 6
        Me.test.Text = "StatusStrip4"
        '
        'lblJumlahDataSAPSudahDicetak
        '
        Me.lblJumlahDataSAPSudahDicetak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahDataSAPSudahDicetak.Name = "lblJumlahDataSAPSudahDicetak"
        Me.lblJumlahDataSAPSudahDicetak.Size = New System.Drawing.Size(82, 17)
        Me.lblJumlahDataSAPSudahDicetak.Text = "JumlahData"
        '
        'txtCariAsetSudahDicetak
        '
        Me.txtCariAsetSudahDicetak.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariAsetSudahDicetak.Location = New System.Drawing.Point(342, 19)
        Me.txtCariAsetSudahDicetak.Name = "txtCariAsetSudahDicetak"
        Me.txtCariAsetSudahDicetak.Size = New System.Drawing.Size(264, 25)
        Me.txtCariAsetSudahDicetak.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cari Aset"
        '
        'cmbLokasiSudahDicetak
        '
        Me.cmbLokasiSudahDicetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLokasiSudahDicetak.FormattingEnabled = True
        Me.cmbLokasiSudahDicetak.Location = New System.Drawing.Point(76, 22)
        Me.cmbLokasiSudahDicetak.Name = "cmbLokasiSudahDicetak"
        Me.cmbLokasiSudahDicetak.Size = New System.Drawing.Size(178, 24)
        Me.cmbLokasiSudahDicetak.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Lokasi"
        '
        'cmdTambahSudahDicetak
        '
        Me.cmdTambahSudahDicetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambahSudahDicetak.Location = New System.Drawing.Point(538, 57)
        Me.cmdTambahSudahDicetak.Name = "cmdTambahSudahDicetak"
        Me.cmdTambahSudahDicetak.Size = New System.Drawing.Size(68, 172)
        Me.cmdTambahSudahDicetak.TabIndex = 1
        Me.cmdTambahSudahDicetak.Text = "Tambah"
        Me.cmdTambahSudahDicetak.UseVisualStyleBackColor = True
        '
        'dgAsetSAPSudahDicetak
        '
        Me.dgAsetSAPSudahDicetak.AllowUserToAddRows = False
        Me.dgAsetSAPSudahDicetak.AllowUserToDeleteRows = False
        Me.dgAsetSAPSudahDicetak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAsetSAPSudahDicetak.Location = New System.Drawing.Point(15, 57)
        Me.dgAsetSAPSudahDicetak.Name = "dgAsetSAPSudahDicetak"
        Me.dgAsetSAPSudahDicetak.Size = New System.Drawing.Size(517, 176)
        Me.dgAsetSAPSudahDicetak.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 688)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(660, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyTableToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'CopyTableToolStripMenuItem
        '
        Me.CopyTableToolStripMenuItem.Name = "CopyTableToolStripMenuItem"
        Me.CopyTableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyTableToolStripMenuItem.Text = "Copy Table"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 710)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.dgAsetSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        CType(Me.dgKeranjangExport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip5.ResumeLayout(False)
        Me.StatusStrip5.PerformLayout()
        CType(Me.dgKeranjangExportSudahDicetak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.test.ResumeLayout(False)
        Me.test.PerformLayout()
        CType(Me.dgAsetSAPSudahDicetak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCariAset As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLokasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents dgAsetSAP As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgKeranjangExport As System.Windows.Forms.DataGridView
    Friend WithEvents KodeAset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tahun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lokasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdExportDB As System.Windows.Forms.Button
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahDataSAP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip5 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahDataSudahDicetak As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdExportDBSudahDicetak As System.Windows.Forms.Button
    Friend WithEvents dgKeranjangExportSudahDicetak As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents test As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahDataSAPSudahDicetak As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCariAsetSudahDicetak As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbLokasiSudahDicetak As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdTambahSudahDicetak As System.Windows.Forms.Button
    Friend WithEvents dgAsetSAPSudahDicetak As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
