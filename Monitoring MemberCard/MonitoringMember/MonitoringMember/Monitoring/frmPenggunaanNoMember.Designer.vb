<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenggunaanNoMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenggunaanNoMember))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboTglRegistrasi = New System.Windows.Forms.CheckBox()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPekerjaan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSudahDiregistrasi = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvSudahRegistrasi = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvRincianTransaksi = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbDaftarPengguna = New System.Windows.Forms.GroupBox()
        Me.btnLihatTransaksi = New System.Windows.Forms.Button()
        Me.dgvPenggunaMember = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNoMember = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSudahRegistrasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvRincianTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.gbDaftarPengguna.SuspendLayout()
        CType(Me.dgvPenggunaMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.txtKota)
        Me.GroupBox1.Controls.Add(Me.btnProses)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbPekerjaan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCabang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 642)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(195, 559)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 70)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(141, 507)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(193, 26)
        Me.txtKota.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 39)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Member"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(164, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 31)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Penggunaan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(164, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Informasi"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(10, 559)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(136, 70)
        Me.btnProses.TabIndex = 12
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboTglRegistrasi)
        Me.GroupBox2.Controls.Add(Me.dtpAkhir)
        Me.GroupBox2.Controls.Add(Me.dtpAwal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 279)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 83)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'cboTglRegistrasi
        '
        Me.cboTglRegistrasi.AutoSize = True
        Me.cboTglRegistrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTglRegistrasi.Location = New System.Drawing.Point(4, 17)
        Me.cboTglRegistrasi.Name = "cboTglRegistrasi"
        Me.cboTglRegistrasi.Size = New System.Drawing.Size(15, 14)
        Me.cboTglRegistrasi.TabIndex = 13
        Me.cboTglRegistrasi.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(189, 46)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(130, 26)
        Me.dtpAkhir.TabIndex = 12
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(10, 46)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(130, 26)
        Me.dtpAwal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tgl Registrasi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kota"
        '
        'cmbPekerjaan
        '
        Me.cmbPekerjaan.FormattingEnabled = True
        Me.cmbPekerjaan.Location = New System.Drawing.Point(141, 472)
        Me.cmbPekerjaan.Name = "cmbPekerjaan"
        Me.cmbPekerjaan.Size = New System.Drawing.Size(193, 28)
        Me.cmbPekerjaan.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pekerjaan"
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(141, 440)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(193, 28)
        Me.cmbJenisKelamin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis Kelamin"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbStatus.Location = New System.Drawing.Point(141, 407)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(193, 28)
        Me.cmbStatus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(141, 375)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(193, 28)
        Me.cmbCabang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cabang"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(351, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 633)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgvSudahRegistrasi)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(766, 607)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Member Sudah di Registrasi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lblSudahDiregistrasi)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 462)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 134)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lblSudahDiregistrasi
        '
        Me.lblSudahDiregistrasi.AutoSize = True
        Me.lblSudahDiregistrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSudahDiregistrasi.Location = New System.Drawing.Point(78, 75)
        Me.lblSudahDiregistrasi.Name = "lblSudahDiregistrasi"
        Me.lblSudahDiregistrasi.Size = New System.Drawing.Size(36, 37)
        Me.lblSudahDiregistrasi.TabIndex = 1
        Me.lblSudahDiregistrasi.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 39)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Jumlah"
        '
        'dgvSudahRegistrasi
        '
        Me.dgvSudahRegistrasi.AllowUserToAddRows = False
        Me.dgvSudahRegistrasi.AllowUserToDeleteRows = False
        Me.dgvSudahRegistrasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSudahRegistrasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSudahRegistrasi.Location = New System.Drawing.Point(7, 6)
        Me.dgvSudahRegistrasi.Name = "dgvSudahRegistrasi"
        Me.dgvSudahRegistrasi.ReadOnly = True
        Me.dgvSudahRegistrasi.RowHeadersVisible = False
        Me.dgvSudahRegistrasi.Size = New System.Drawing.Size(753, 442)
        Me.dgvSudahRegistrasi.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.dgvRincianTransaksi)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(766, 607)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Penggunaan Transaksi Member"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 24)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Rincian Transaksi"
        '
        'dgvRincianTransaksi
        '
        Me.dgvRincianTransaksi.AllowUserToAddRows = False
        Me.dgvRincianTransaksi.AllowUserToDeleteRows = False
        Me.dgvRincianTransaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRincianTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRincianTransaksi.Location = New System.Drawing.Point(9, 270)
        Me.dgvRincianTransaksi.Name = "dgvRincianTransaksi"
        Me.dgvRincianTransaksi.ReadOnly = True
        Me.dgvRincianTransaksi.RowHeadersVisible = False
        Me.dgvRincianTransaksi.Size = New System.Drawing.Size(751, 331)
        Me.dgvRincianTransaksi.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.gbDaftarPengguna)
        Me.GroupBox4.Controls.Add(Me.txtNoMember)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(751, 240)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parameter"
        '
        'gbDaftarPengguna
        '
        Me.gbDaftarPengguna.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDaftarPengguna.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbDaftarPengguna.Controls.Add(Me.btnLihatTransaksi)
        Me.gbDaftarPengguna.Controls.Add(Me.dgvPenggunaMember)
        Me.gbDaftarPengguna.Controls.Add(Me.Label12)
        Me.gbDaftarPengguna.Location = New System.Drawing.Point(12, 48)
        Me.gbDaftarPengguna.Name = "gbDaftarPengguna"
        Me.gbDaftarPengguna.Size = New System.Drawing.Size(733, 178)
        Me.gbDaftarPengguna.TabIndex = 2
        Me.gbDaftarPengguna.TabStop = False
        '
        'btnLihatTransaksi
        '
        Me.btnLihatTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLihatTransaksi.Location = New System.Drawing.Point(602, 33)
        Me.btnLihatTransaksi.Name = "btnLihatTransaksi"
        Me.btnLihatTransaksi.Size = New System.Drawing.Size(125, 136)
        Me.btnLihatTransaksi.TabIndex = 2
        Me.btnLihatTransaksi.Text = "Lihat Transaksi"
        Me.btnLihatTransaksi.UseVisualStyleBackColor = True
        '
        'dgvPenggunaMember
        '
        Me.dgvPenggunaMember.AllowUserToAddRows = False
        Me.dgvPenggunaMember.AllowUserToDeleteRows = False
        Me.dgvPenggunaMember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPenggunaMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenggunaMember.Location = New System.Drawing.Point(7, 34)
        Me.dgvPenggunaMember.Name = "dgvPenggunaMember"
        Me.dgvPenggunaMember.ReadOnly = True
        Me.dgvPenggunaMember.RowHeadersVisible = False
        Me.dgvPenggunaMember.Size = New System.Drawing.Size(589, 136)
        Me.dgvPenggunaMember.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sudah Digunakan Oleh"
        '
        'txtNoMember
        '
        Me.txtNoMember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMember.Location = New System.Drawing.Point(198, 13)
        Me.txtNoMember.Name = "txtNoMember"
        Me.txtNoMember.Size = New System.Drawing.Size(547, 29)
        Me.txtNoMember.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nomor Member"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Memberrrrrrrr
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(6, 28)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(235, 245)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 19
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'frmPenggunaanNoMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPenggunaanNoMember"
        Me.Text = "frmPenggunaanNoMember"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvSudahRegistrasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvRincianTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDaftarPengguna.ResumeLayout(False)
        Me.gbDaftarPengguna.PerformLayout()
        CType(Me.dgvPenggunaMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTglRegistrasi As System.Windows.Forms.CheckBox
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvSudahRegistrasi As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSudahDiregistrasi As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbDaftarPengguna As System.Windows.Forms.GroupBox
    Friend WithEvents btnLihatTransaksi As System.Windows.Forms.Button
    Friend WithEvents dgvPenggunaMember As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNoMember As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvRincianTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
