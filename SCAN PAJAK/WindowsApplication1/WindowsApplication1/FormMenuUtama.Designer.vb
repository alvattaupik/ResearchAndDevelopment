<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTglFakturPajak = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNPWPPengusahaKenaPajak = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAlamatPengusahaKenaPajak = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaPengusahaKenaPajak = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomorFakturPajak = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNpwpLawan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamatLawan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaLawan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgItemList = New System.Windows.Forms.DataGridView()
        Me.dgvDB = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvScan = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPPNBM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPPN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDPP = New System.Windows.Forms.TextBox()
        Me.txtUangMuka = New System.Windows.Forms.TextBox()
        Me.txtTotalPotonganHarga = New System.Windows.Forms.TextBox()
        Me.txtTotalHargaJual = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdNewScan = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatDataFakturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdSimpanData = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(171, 18)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(273, 20)
        Me.txtUrl.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTglFakturPajak)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNPWPPengusahaKenaPajak)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAlamatPengusahaKenaPajak)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNamaPengusahaKenaPajak)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNomorFakturPajak)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1221, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PENGUSAHA KENA PAJAK"
        '
        'txtTglFakturPajak
        '
        Me.txtTglFakturPajak.Location = New System.Drawing.Point(692, 19)
        Me.txtTglFakturPajak.Name = "txtTglFakturPajak"
        Me.txtTglFakturPajak.Size = New System.Drawing.Size(508, 20)
        Me.txtTglFakturPajak.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(561, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Tanggal Faktur Pajak"
        '
        'txtNPWPPengusahaKenaPajak
        '
        Me.txtNPWPPengusahaKenaPajak.Location = New System.Drawing.Point(188, 101)
        Me.txtNPWPPengusahaKenaPajak.Name = "txtNPWPPengusahaKenaPajak"
        Me.txtNPWPPengusahaKenaPajak.Size = New System.Drawing.Size(1012, 20)
        Me.txtNPWPPengusahaKenaPajak.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NPWP Pengusaha Kena Pajak"
        '
        'txtAlamatPengusahaKenaPajak
        '
        Me.txtAlamatPengusahaKenaPajak.Location = New System.Drawing.Point(188, 75)
        Me.txtAlamatPengusahaKenaPajak.Name = "txtAlamatPengusahaKenaPajak"
        Me.txtAlamatPengusahaKenaPajak.Size = New System.Drawing.Size(1012, 20)
        Me.txtAlamatPengusahaKenaPajak.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat Pengusaha Kena Pajak"
        '
        'txtNamaPengusahaKenaPajak
        '
        Me.txtNamaPengusahaKenaPajak.Location = New System.Drawing.Point(188, 49)
        Me.txtNamaPengusahaKenaPajak.Name = "txtNamaPengusahaKenaPajak"
        Me.txtNamaPengusahaKenaPajak.Size = New System.Drawing.Size(1012, 20)
        Me.txtNamaPengusahaKenaPajak.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pengusaha Kena Pajak"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomor Faktur Pajak"
        '
        'txtNomorFakturPajak
        '
        Me.txtNomorFakturPajak.Location = New System.Drawing.Point(188, 20)
        Me.txtNomorFakturPajak.Name = "txtNomorFakturPajak"
        Me.txtNomorFakturPajak.Size = New System.Drawing.Size(350, 20)
        Me.txtNomorFakturPajak.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNpwpLawan)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtAlamatLawan)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNamaLawan)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1220, 103)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PEMBELI BARANG KENA PAJAK/ PENERIMA JASA KENA PAJAK"
        '
        'txtNpwpLawan
        '
        Me.txtNpwpLawan.Location = New System.Drawing.Point(188, 74)
        Me.txtNpwpLawan.Name = "txtNpwpLawan"
        Me.txtNpwpLawan.Size = New System.Drawing.Size(1011, 20)
        Me.txtNpwpLawan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NPWP"
        '
        'txtAlamatLawan
        '
        Me.txtAlamatLawan.Location = New System.Drawing.Point(188, 48)
        Me.txtAlamatLawan.Name = "txtAlamatLawan"
        Me.txtAlamatLawan.Size = New System.Drawing.Size(1011, 20)
        Me.txtAlamatLawan.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Alamat Pengusaha"
        '
        'txtNamaLawan
        '
        Me.txtNamaLawan.Location = New System.Drawing.Point(188, 22)
        Me.txtNamaLawan.Name = "txtNamaLawan"
        Me.txtNamaLawan.Size = New System.Drawing.Size(1011, 20)
        Me.txtNamaLawan.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nama"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgItemList)
        Me.GroupBox3.Controls.Add(Me.dgvDB)
        Me.GroupBox3.Controls.Add(Me.StatusStrip1)
        Me.GroupBox3.Controls.Add(Me.dgvScan)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(655, 207)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Transaksi"
        '
        'dgItemList
        '
        Me.dgItemList.AllowUserToAddRows = False
        Me.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemList.Location = New System.Drawing.Point(6, 19)
        Me.dgItemList.Name = "dgItemList"
        Me.dgItemList.Size = New System.Drawing.Size(643, 148)
        Me.dgItemList.TabIndex = 5
        '
        'dgvDB
        '
        Me.dgvDB.AllowUserToAddRows = False
        Me.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDB.Location = New System.Drawing.Point(340, 24)
        Me.dgvDB.Name = "dgvDB"
        Me.dgvDB.Size = New System.Drawing.Size(271, 136)
        Me.dgvDB.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 174)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(649, 30)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(129, 25)
        Me.lblStatus.Text = "Jumlah Item :"
        '
        'dgvScan
        '
        Me.dgvScan.AllowUserToAddRows = False
        Me.dgvScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScan.Location = New System.Drawing.Point(11, 24)
        Me.dgvScan.Name = "dgvScan"
        Me.dgvScan.Size = New System.Drawing.Size(271, 136)
        Me.dgvScan.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPPNBM)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtPPN)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtDPP)
        Me.GroupBox4.Controls.Add(Me.txtUangMuka)
        Me.GroupBox4.Controls.Add(Me.txtTotalPotonganHarga)
        Me.GroupBox4.Controls.Add(Me.txtTotalHargaJual)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(662, 383)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(559, 207)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Summary"
        '
        'txtPPNBM
        '
        Me.txtPPNBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPNBM.Location = New System.Drawing.Point(331, 173)
        Me.txtPPNBM.Multiline = True
        Me.txtPPNBM.Name = "txtPPNBM"
        Me.txtPPNBM.Size = New System.Drawing.Size(207, 25)
        Me.txtPPNBM.TabIndex = 11
        Me.txtPPNBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total PPnBM(Pajak Penjualan Barang Mewah)"
        '
        'txtPPN
        '
        Me.txtPPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPN.Location = New System.Drawing.Point(331, 142)
        Me.txtPPN.Multiline = True
        Me.txtPPN.Name = "txtPPN"
        Me.txtPPN.Size = New System.Drawing.Size(207, 25)
        Me.txtPPN.TabIndex = 9
        Me.txtPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(252, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "PPN = 10 % Dasar Pengenaan Pajak"
        '
        'txtDPP
        '
        Me.txtDPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPP.Location = New System.Drawing.Point(331, 111)
        Me.txtDPP.Multiline = True
        Me.txtDPP.Name = "txtDPP"
        Me.txtDPP.Size = New System.Drawing.Size(207, 25)
        Me.txtDPP.TabIndex = 7
        Me.txtDPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUangMuka
        '
        Me.txtUangMuka.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUangMuka.Location = New System.Drawing.Point(331, 79)
        Me.txtUangMuka.Multiline = True
        Me.txtUangMuka.Name = "txtUangMuka"
        Me.txtUangMuka.Size = New System.Drawing.Size(207, 25)
        Me.txtUangMuka.TabIndex = 6
        Me.txtUangMuka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPotonganHarga
        '
        Me.txtTotalPotonganHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPotonganHarga.Location = New System.Drawing.Point(331, 48)
        Me.txtTotalPotonganHarga.Multiline = True
        Me.txtTotalPotonganHarga.Name = "txtTotalPotonganHarga"
        Me.txtTotalPotonganHarga.Size = New System.Drawing.Size(207, 25)
        Me.txtTotalPotonganHarga.TabIndex = 5
        Me.txtTotalPotonganHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalHargaJual
        '
        Me.txtTotalHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHargaJual.Location = New System.Drawing.Point(331, 17)
        Me.txtTotalHargaJual.Multiline = True
        Me.txtTotalHargaJual.Name = "txtTotalHargaJual"
        Me.txtTotalHargaJual.Size = New System.Drawing.Size(207, 25)
        Me.txtTotalHargaJual.TabIndex = 4
        Me.txtTotalHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Dasar Pengenaan Pajak"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Dikurangi Uang Muka"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Dikurangi Potongan Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Harga Jual / Penggantian"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(111, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "URL"
        '
        'cmdNewScan
        '
        Me.cmdNewScan.Location = New System.Drawing.Point(171, 44)
        Me.cmdNewScan.Name = "cmdNewScan"
        Me.cmdNewScan.Size = New System.Drawing.Size(101, 33)
        Me.cmdNewScan.TabIndex = 9
        Me.cmdNewScan.Text = "New Scan"
        Me.cmdNewScan.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1236, 24)
        Me.MenuStrip1.TabIndex = 11
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataFakturToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ReportToolStripMenuItem.Text = "Data"
        '
        'LihatDataFakturToolStripMenuItem
        '
        Me.LihatDataFakturToolStripMenuItem.Name = "LihatDataFakturToolStripMenuItem"
        Me.LihatDataFakturToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LihatDataFakturToolStripMenuItem.Text = "Lihat Data Faktur"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdSimpanData)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtUrl)
        Me.GroupBox5.Controls.Add(Me.cmdNewScan)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1221, 106)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'cmdSimpanData
        '
        Me.cmdSimpanData.Location = New System.Drawing.Point(346, 44)
        Me.cmdSimpanData.Name = "cmdSimpanData"
        Me.cmdSimpanData.Size = New System.Drawing.Size(98, 33)
        Me.cmdSimpanData.TabIndex = 10
        Me.cmdSimpanData.Text = "Simpan Data"
        Me.cmdSimpanData.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(20, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 79)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 594)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNPWPPengusahaKenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatPengusahaKenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPengusahaKenaPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomorFakturPajak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNpwpLawan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatLawan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLawan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgItemList As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPPNBM As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPPN As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDPP As System.Windows.Forms.TextBox
    Friend WithEvents txtUangMuka As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPotonganHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdNewScan As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvScan As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgvDB As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSimpanData As System.Windows.Forms.Button
    Friend WithEvents txtTglFakturPajak As System.Windows.Forms.TextBox
    Friend WithEvents LihatDataFakturToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
