<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformasiCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformasiCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNamaCabang = New Guna.UI.WinForms.GunaLabel()
        Me.lblNamaUser = New Guna.UI.WinForms.GunaLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJamDigital = New System.Windows.Forms.Label()
        Me.timerInformasiMember = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblExportToExcel = New System.Windows.Forms.Label()
        Me.txtTransaksiTerakhir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoMember = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvListAlamatCustomer = New System.Windows.Forms.DataGridView()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.txtKodeCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblExportTransaksi = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvListTransaksi = New System.Windows.Forms.DataGridView()
        Me.picExportTransaksi = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picCariCustomer = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaTransfarantPictureBox7 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox6 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picLogout = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListAlamatCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox7)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox6)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox5)
        Me.Panel1.Controls.Add(Me.lblNamaCabang)
        Me.Panel1.Controls.Add(Me.lblNamaUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox3)
        Me.Panel1.Controls.Add(Me.picLogout)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 744)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-1, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Informasi Customer"
        '
        'lblNamaCabang
        '
        Me.lblNamaCabang.AutoSize = True
        Me.lblNamaCabang.BackColor = System.Drawing.Color.MistyRose
        Me.lblNamaCabang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaCabang.ForeColor = System.Drawing.Color.Black
        Me.lblNamaCabang.Location = New System.Drawing.Point(53, 298)
        Me.lblNamaCabang.Name = "lblNamaCabang"
        Me.lblNamaCabang.Size = New System.Drawing.Size(68, 13)
        Me.lblNamaCabang.TabIndex = 11
        Me.lblNamaCabang.Text = "GunaLabel1"
        '
        'lblNamaUser
        '
        Me.lblNamaUser.AutoSize = True
        Me.lblNamaUser.BackColor = System.Drawing.Color.MistyRose
        Me.lblNamaUser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaUser.ForeColor = System.Drawing.Color.Black
        Me.lblNamaUser.Location = New System.Drawing.Point(53, 316)
        Me.lblNamaUser.Name = "lblNamaUser"
        Me.lblNamaUser.Size = New System.Drawing.Size(68, 13)
        Me.lblNamaUser.TabIndex = 8
        Me.lblNamaUser.Text = "GunaLabel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblJamDigital)
        Me.Panel2.Location = New System.Drawing.Point(5, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 45)
        Me.Panel2.TabIndex = 7
        '
        'lblJamDigital
        '
        Me.lblJamDigital.AutoSize = True
        Me.lblJamDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJamDigital.Location = New System.Drawing.Point(51, 6)
        Me.lblJamDigital.Name = "lblJamDigital"
        Me.lblJamDigital.Size = New System.Drawing.Size(71, 31)
        Me.lblJamDigital.TabIndex = 0
        Me.lblJamDigital.Text = "JAM"
        '
        'timerInformasiMember
        '
        Me.timerInformasiMember.Enabled = True
        Me.timerInformasiMember.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblExportToExcel)
        Me.GroupBox1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtTransaksiTerakhir)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNoMember)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgvListAlamatCustomer)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.picCariCustomer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNamaCustomer)
        Me.GroupBox1.Controls.Add(Me.txtKodeCustomer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(277, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1081, 265)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'lblExportToExcel
        '
        Me.lblExportToExcel.AutoSize = True
        Me.lblExportToExcel.Location = New System.Drawing.Point(769, 237)
        Me.lblExportToExcel.Name = "lblExportToExcel"
        Me.lblExportToExcel.Size = New System.Drawing.Size(10, 13)
        Me.lblExportToExcel.TabIndex = 16
        Me.lblExportToExcel.Text = "-"
        Me.lblExportToExcel.Visible = False
        '
        'txtTransaksiTerakhir
        '
        Me.txtTransaksiTerakhir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTransaksiTerakhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransaksiTerakhir.Location = New System.Drawing.Point(171, 83)
        Me.txtTransaksiTerakhir.Name = "txtTransaksiTerakhir"
        Me.txtTransaksiTerakhir.ReadOnly = True
        Me.txtTransaksiTerakhir.Size = New System.Drawing.Size(442, 29)
        Me.txtTransaksiTerakhir.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Transaksi Terakhir"
        '
        'txtNoMember
        '
        Me.txtNoMember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMember.Location = New System.Drawing.Point(171, 50)
        Me.txtNoMember.Name = "txtNoMember"
        Me.txtNoMember.ReadOnly = True
        Me.txtNoMember.Size = New System.Drawing.Size(442, 29)
        Me.txtNoMember.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No. Member"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(767, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Daftar Alamat"
        '
        'dgvListAlamatCustomer
        '
        Me.dgvListAlamatCustomer.AllowUserToAddRows = False
        Me.dgvListAlamatCustomer.AllowUserToDeleteRows = False
        Me.dgvListAlamatCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListAlamatCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListAlamatCustomer.Location = New System.Drawing.Point(619, 38)
        Me.dgvListAlamatCustomer.Name = "dgvListAlamatCustomer"
        Me.dgvListAlamatCustomer.ReadOnly = True
        Me.dgvListAlamatCustomer.RowHeadersVisible = False
        Me.dgvListAlamatCustomer.Size = New System.Drawing.Size(456, 187)
        Me.dgvListAlamatCustomer.TabIndex = 9
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(171, 159)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(442, 29)
        Me.txtPhoneNumber.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Phone Number"
        '
        'txtAlamat
        '
        Me.txtAlamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlamat.Location = New System.Drawing.Point(171, 195)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(442, 61)
        Me.txtAlamat.TabIndex = 5
        Me.txtAlamat.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaCustomer.Location = New System.Drawing.Point(171, 124)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.ReadOnly = True
        Me.txtNamaCustomer.Size = New System.Drawing.Size(442, 29)
        Me.txtNamaCustomer.TabIndex = 3
        '
        'txtKodeCustomer
        '
        Me.txtKodeCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeCustomer.Location = New System.Drawing.Point(171, 16)
        Me.txtKodeCustomer.Name = "txtKodeCustomer"
        Me.txtKodeCustomer.ReadOnly = True
        Me.txtKodeCustomer.Size = New System.Drawing.Size(403, 29)
        Me.txtKodeCustomer.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kode Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblExportTransaksi)
        Me.GroupBox2.Controls.Add(Me.picExportTransaksi)
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnProses)
        Me.GroupBox2.Controls.Add(Me.dtpAkhir)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtpTglAwal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(277, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1081, 65)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tampilkan Daftar Transaksi"
        '
        'lblExportTransaksi
        '
        Me.lblExportTransaksi.AutoSize = True
        Me.lblExportTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExportTransaksi.Location = New System.Drawing.Point(77, 43)
        Me.lblExportTransaksi.Name = "lblExportTransaksi"
        Me.lblExportTransaksi.Size = New System.Drawing.Size(39, 18)
        Me.lblExportTransaksi.TabIndex = 18
        Me.lblExportTransaksi.Text = "Cari"
        Me.lblExportTransaksi.Visible = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(668, 13)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(407, 26)
        Me.txtCari.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(616, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cari"
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(404, 13)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(83, 46)
        Me.btnProses.TabIndex = 9
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(267, 15)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(130, 26)
        Me.dtpAkhir.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(221, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "S/D"
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglAwal.Location = New System.Drawing.Point(78, 16)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(130, 26)
        Me.dtpTglAwal.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Periode"
        '
        'dgvListTransaksi
        '
        Me.dgvListTransaksi.AllowUserToAddRows = False
        Me.dgvListTransaksi.AllowUserToDeleteRows = False
        Me.dgvListTransaksi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTransaksi.Location = New System.Drawing.Point(277, 337)
        Me.dgvListTransaksi.Name = "dgvListTransaksi"
        Me.dgvListTransaksi.ReadOnly = True
        Me.dgvListTransaksi.RowHeadersVisible = False
        Me.dgvListTransaksi.Size = New System.Drawing.Size(1081, 294)
        Me.dgvListTransaksi.TabIndex = 44
        '
        'picExportTransaksi
        '
        Me.picExportTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.picExportTransaksi.BaseColor = System.Drawing.Color.Lime
        Me.picExportTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportTransaksi.Image = Global.MonitoringMember.My.Resources.Resources.Export_To_Excel
        Me.picExportTransaksi.Location = New System.Drawing.Point(493, 13)
        Me.picExportTransaksi.Name = "picExportTransaksi"
        Me.picExportTransaksi.Size = New System.Drawing.Size(81, 46)
        Me.picExportTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExportTransaksi.TabIndex = 16
        Me.picExportTransaksi.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Lime
        Me.GunaTransfarantPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Export_To_Excel
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(999, 227)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(70, 31)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 15
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'picCariCustomer
        '
        Me.picCariCustomer.BaseColor = System.Drawing.Color.White
        Me.picCariCustomer.Image = Global.MonitoringMember.My.Resources.Resources.Search_User
        Me.picCariCustomer.Location = New System.Drawing.Point(580, 13)
        Me.picCariCustomer.Name = "picCariCustomer"
        Me.picCariCustomer.Size = New System.Drawing.Size(33, 32)
        Me.picCariCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCariCustomer.TabIndex = 6
        Me.picCariCustomer.TabStop = False
        Me.picCariCustomer.UseTransfarantBackground = False
        '
        'GunaTransfarantPictureBox7
        '
        Me.GunaTransfarantPictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox7.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox7.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9_rotate
        Me.GunaTransfarantPictureBox7.Location = New System.Drawing.Point(126, 548)
        Me.GunaTransfarantPictureBox7.Name = "GunaTransfarantPictureBox7"
        Me.GunaTransfarantPictureBox7.Size = New System.Drawing.Size(133, 120)
        Me.GunaTransfarantPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox7.TabIndex = 15
        Me.GunaTransfarantPictureBox7.TabStop = False
        '
        'GunaTransfarantPictureBox6
        '
        Me.GunaTransfarantPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox6.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox6.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9_rotate
        Me.GunaTransfarantPictureBox6.Location = New System.Drawing.Point(0, 548)
        Me.GunaTransfarantPictureBox6.Name = "GunaTransfarantPictureBox6"
        Me.GunaTransfarantPictureBox6.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox6.TabIndex = 14
        Me.GunaTransfarantPictureBox6.TabStop = False
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(132, 0)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(139, 120)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 13
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox3.Image = Global.MonitoringMember.My.Resources.Resources.Users_Dashboard
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(56, 219)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(76, 71)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox3.TabIndex = 6
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'picLogout
        '
        Me.picLogout.BaseColor = System.Drawing.Color.White
        Me.picLogout.Image = Global.MonitoringMember.My.Resources.Resources.Logout_Icon
        Me.picLogout.Location = New System.Drawing.Point(184, 188)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(65, 67)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogout.TabIndex = 3
        Me.picLogout.TabStop = False
        Me.picLogout.UseTransfarantBackground = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.Lembar_Kertas_Dashboard
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(12, 188)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(166, 365)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 5
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 12
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'frmInformasiCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 643)
        Me.Controls.Add(Me.dgvListTransaksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformasiCustomer"
        Me.Text = "Informasi Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListAlamatCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GunaTransfarantPictureBox7 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox6 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents lblNamaCabang As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblNamaUser As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJamDigital As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents picLogout As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerInformasiMember As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picCariCustomer As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents txtAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvListAlamatCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoMember As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTransaksiTerakhir As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExportToExcel As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvListTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents lblExportTransaksi As System.Windows.Forms.Label
    Friend WithEvents picExportTransaksi As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
