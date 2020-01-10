<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataFaktur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataFaktur))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbDetailFaktur = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahItemDetail = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgDetailFaktur = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahDataFaktur = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdLihatDetail = New System.Windows.Forms.Button()
        Me.dgTransaksiFakturPajak = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdTampilkan = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dgExport = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNPWPLawan = New System.Windows.Forms.TextBox()
        Me.txtAlamatlawan = New System.Windows.Forms.TextBox()
        Me.txtNamaLawan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNPWPKenaPajak = New System.Windows.Forms.TextBox()
        Me.txtAlamatPengusahaKenaPajak = New System.Windows.Forms.TextBox()
        Me.txtNamaPengusahakenaPajak = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTglFakturpajak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoFakturPajak = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPPNBMTotal = New System.Windows.Forms.TextBox()
        Me.txtPPnTotal = New System.Windows.Forms.TextBox()
        Me.txtDPPTotal = New System.Windows.Forms.TextBox()
        Me.txtUangMukaTotal = New System.Windows.Forms.TextBox()
        Me.txtDiskonTotal = New System.Windows.Forms.TextBox()
        Me.txtHargaTotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.gbDetailFaktur.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgDetailFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.dgTransaksiFakturPajak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.cmdLihatDetail)
        Me.GroupBox1.Controls.Add(Me.dgTransaksiFakturPajak)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 487)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gbDetailFaktur
        '
        Me.gbDetailFaktur.Controls.Add(Me.StatusStrip1)
        Me.gbDetailFaktur.Controls.Add(Me.Button1)
        Me.gbDetailFaktur.Controls.Add(Me.dgDetailFaktur)
        Me.gbDetailFaktur.Location = New System.Drawing.Point(329, 208)
        Me.gbDetailFaktur.Name = "gbDetailFaktur"
        Me.gbDetailFaktur.Size = New System.Drawing.Size(467, 385)
        Me.gbDetailFaktur.TabIndex = 5
        Me.gbDetailFaktur.TabStop = False
        Me.gbDetailFaktur.Text = "Detail Faktur Pajak"
        Me.gbDetailFaktur.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahItemDetail})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 360)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(461, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblJumlahItemDetail
        '
        Me.lblJumlahItemDetail.Name = "lblJumlahItemDetail"
        Me.lblJumlahItemDetail.Size = New System.Drawing.Size(72, 17)
        Me.lblJumlahItemDetail.Text = "Jumlah Item"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(432, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgDetailFaktur
        '
        Me.dgDetailFaktur.AllowUserToAddRows = False
        Me.dgDetailFaktur.AllowUserToDeleteRows = False
        Me.dgDetailFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetailFaktur.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgDetailFaktur.Location = New System.Drawing.Point(10, 44)
        Me.dgDetailFaktur.Name = "dgDetailFaktur"
        Me.dgDetailFaktur.ReadOnly = True
        Me.dgDetailFaktur.Size = New System.Drawing.Size(457, 295)
        Me.dgDetailFaktur.TabIndex = 6
        Me.dgDetailFaktur.Visible = False
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
        Me.CopyTableToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CopyTableToolStripMenuItem.Text = "Copy Table"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.StatusStrip2)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 411)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(450, 39)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahDataFaktur})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 14)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(444, 22)
        Me.StatusStrip2.TabIndex = 0
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblJumlahDataFaktur
        '
        Me.lblJumlahDataFaktur.Name = "lblJumlahDataFaktur"
        Me.lblJumlahDataFaktur.Size = New System.Drawing.Size(108, 17)
        Me.lblJumlahDataFaktur.Text = "Jumlah Data Faktur"
        '
        'cmdLihatDetail
        '
        Me.cmdLihatDetail.Location = New System.Drawing.Point(362, 453)
        Me.cmdLihatDetail.Name = "cmdLihatDetail"
        Me.cmdLihatDetail.Size = New System.Drawing.Size(97, 30)
        Me.cmdLihatDetail.TabIndex = 4
        Me.cmdLihatDetail.Text = "Lihat Detail"
        Me.cmdLihatDetail.UseVisualStyleBackColor = True
        '
        'dgTransaksiFakturPajak
        '
        Me.dgTransaksiFakturPajak.AllowUserToAddRows = False
        Me.dgTransaksiFakturPajak.AllowUserToDeleteRows = False
        Me.dgTransaksiFakturPajak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransaksiFakturPajak.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgTransaksiFakturPajak.Location = New System.Drawing.Point(12, 97)
        Me.dgTransaksiFakturPajak.Name = "dgTransaksiFakturPajak"
        Me.dgTransaksiFakturPajak.ReadOnly = True
        Me.dgTransaksiFakturPajak.Size = New System.Drawing.Size(444, 317)
        Me.dgTransaksiFakturPajak.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdTampilkan)
        Me.GroupBox3.Controls.Add(Me.dtpAkhir)
        Me.GroupBox3.Controls.Add(Me.cmdExport)
        Me.GroupBox3.Controls.Add(Me.dtpAwal)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(448, 57)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periode"
        '
        'cmdTampilkan
        '
        Me.cmdTampilkan.Location = New System.Drawing.Point(267, 14)
        Me.cmdTampilkan.Name = "cmdTampilkan"
        Me.cmdTampilkan.Size = New System.Drawing.Size(85, 37)
        Me.cmdTampilkan.TabIndex = 3
        Me.cmdTampilkan.Text = "Tampilkan"
        Me.cmdTampilkan.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(158, 19)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(103, 20)
        Me.dtpAkhir.TabIndex = 2
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(358, 14)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(84, 37)
        Me.cmdExport.TabIndex = 3
        Me.cmdExport.Text = "Export To Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(18, 19)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(101, 20)
        Me.dtpAwal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "S/D"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.dgExport)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(220, 58)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(377, 19)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'dgExport
        '
        Me.dgExport.AllowUserToAddRows = False
        Me.dgExport.AllowUserToDeleteRows = False
        Me.dgExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExport.Location = New System.Drawing.Point(643, 19)
        Me.dgExport.Name = "dgExport"
        Me.dgExport.Size = New System.Drawing.Size(81, 72)
        Me.dgExport.TabIndex = 2
        Me.dgExport.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA TRANSAKSI FAKTUR PAJAK"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNPWPLawan)
        Me.GroupBox4.Controls.Add(Me.txtAlamatlawan)
        Me.GroupBox4.Controls.Add(Me.txtNamaLawan)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtNPWPKenaPajak)
        Me.GroupBox4.Controls.Add(Me.txtAlamatPengusahaKenaPajak)
        Me.GroupBox4.Controls.Add(Me.txtNamaPengusahakenaPajak)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtTglFakturpajak)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtNoFakturPajak)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 312)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Faktur"
        '
        'txtNPWPLawan
        '
        Me.txtNPWPLawan.Location = New System.Drawing.Point(102, 282)
        Me.txtNPWPLawan.Name = "txtNPWPLawan"
        Me.txtNPWPLawan.Size = New System.Drawing.Size(195, 20)
        Me.txtNPWPLawan.TabIndex = 17
        '
        'txtAlamatlawan
        '
        Me.txtAlamatlawan.Location = New System.Drawing.Point(102, 256)
        Me.txtAlamatlawan.Name = "txtAlamatlawan"
        Me.txtAlamatlawan.Size = New System.Drawing.Size(195, 20)
        Me.txtAlamatlawan.TabIndex = 16
        '
        'txtNamaLawan
        '
        Me.txtNamaLawan.Location = New System.Drawing.Point(102, 230)
        Me.txtNamaLawan.Name = "txtNamaLawan"
        Me.txtNamaLawan.Size = New System.Drawing.Size(195, 20)
        Me.txtNamaLawan.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "NPWP"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Pembeli Barang Kena Pajak"
        '
        'txtNPWPKenaPajak
        '
        Me.txtNPWPKenaPajak.Location = New System.Drawing.Point(102, 158)
        Me.txtNPWPKenaPajak.Name = "txtNPWPKenaPajak"
        Me.txtNPWPKenaPajak.Size = New System.Drawing.Size(195, 20)
        Me.txtNPWPKenaPajak.TabIndex = 11
        '
        'txtAlamatPengusahaKenaPajak
        '
        Me.txtAlamatPengusahaKenaPajak.Location = New System.Drawing.Point(102, 132)
        Me.txtAlamatPengusahaKenaPajak.Name = "txtAlamatPengusahaKenaPajak"
        Me.txtAlamatPengusahaKenaPajak.Size = New System.Drawing.Size(195, 20)
        Me.txtAlamatPengusahaKenaPajak.TabIndex = 10
        '
        'txtNamaPengusahakenaPajak
        '
        Me.txtNamaPengusahakenaPajak.Location = New System.Drawing.Point(102, 106)
        Me.txtNamaPengusahakenaPajak.Name = "txtNamaPengusahakenaPajak"
        Me.txtNamaPengusahakenaPajak.Size = New System.Drawing.Size(195, 20)
        Me.txtNamaPengusahakenaPajak.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NPWP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pengusaha Kena Pajak"
        '
        'txtTglFakturpajak
        '
        Me.txtTglFakturpajak.Location = New System.Drawing.Point(102, 48)
        Me.txtTglFakturpajak.Name = "txtTglFakturpajak"
        Me.txtTglFakturpajak.Size = New System.Drawing.Size(195, 20)
        Me.txtTglFakturpajak.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tanggal"
        '
        'txtNoFakturPajak
        '
        Me.txtNoFakturPajak.Location = New System.Drawing.Point(102, 22)
        Me.txtNoFakturPajak.Name = "txtNoFakturPajak"
        Me.txtNoFakturPajak.Size = New System.Drawing.Size(195, 20)
        Me.txtNoFakturPajak.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Faktur Pajak"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(308, 293)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(5, 183)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(289, 23)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(4, 59)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(289, 23)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPPNBMTotal)
        Me.GroupBox5.Controls.Add(Me.txtPPnTotal)
        Me.GroupBox5.Controls.Add(Me.txtDPPTotal)
        Me.GroupBox5.Controls.Add(Me.txtUangMukaTotal)
        Me.GroupBox5.Controls.Add(Me.txtDiskonTotal)
        Me.GroupBox5.Controls.Add(Me.txtHargaTotal)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 423)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(315, 174)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'txtPPNBMTotal
        '
        Me.txtPPNBMTotal.Location = New System.Drawing.Point(202, 147)
        Me.txtPPNBMTotal.Name = "txtPPNBMTotal"
        Me.txtPPNBMTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtPPNBMTotal.TabIndex = 23
        '
        'txtPPnTotal
        '
        Me.txtPPnTotal.Location = New System.Drawing.Point(202, 121)
        Me.txtPPnTotal.Name = "txtPPnTotal"
        Me.txtPPnTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtPPnTotal.TabIndex = 22
        '
        'txtDPPTotal
        '
        Me.txtDPPTotal.Location = New System.Drawing.Point(202, 95)
        Me.txtDPPTotal.Name = "txtDPPTotal"
        Me.txtDPPTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtDPPTotal.TabIndex = 21
        '
        'txtUangMukaTotal
        '
        Me.txtUangMukaTotal.Location = New System.Drawing.Point(202, 70)
        Me.txtUangMukaTotal.Name = "txtUangMukaTotal"
        Me.txtUangMukaTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtUangMukaTotal.TabIndex = 20
        '
        'txtDiskonTotal
        '
        Me.txtDiskonTotal.Location = New System.Drawing.Point(202, 44)
        Me.txtDiskonTotal.Name = "txtDiskonTotal"
        Me.txtDiskonTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtDiskonTotal.TabIndex = 19
        '
        'txtHargaTotal
        '
        Me.txtHargaTotal.Location = New System.Drawing.Point(202, 18)
        Me.txtHargaTotal.Name = "txtHargaTotal"
        Me.txtHargaTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtHargaTotal.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Total PPNBM"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(193, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "PPN = 10 % X Dasar Pengenaan Pajak"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Dasar Pengenaan Pajak"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Dikurangi Uang Muka"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Dikurangi Potongan Harga"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Harga Jual/Penggantian"
        '
        'FormDataFaktur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 599)
        Me.Controls.Add(Me.gbDetailFaktur)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataFaktur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataFaktur"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbDetailFaktur.ResumeLayout(False)
        Me.gbDetailFaktur.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgDetailFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.dgTransaksiFakturPajak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgTransaksiFakturPajak As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTampilkan As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNPWPLawan As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatlawan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaLawan As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNPWPKenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatPengusahaKenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPengusahakenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTglFakturpajak As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoFakturPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPPNBMTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPPnTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDPPTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtUangMukaTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskonTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdLihatDetail As System.Windows.Forms.Button
    Friend WithEvents gbDetailFaktur As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetailFaktur As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgExport As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahItemDetail As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahDataFaktur As System.Windows.Forms.ToolStripStatusLabel
End Class
