<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdPing = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.FraTambahUbah = New System.Windows.Forms.GroupBox()
        Me.txtDocEntry = New System.Windows.Forms.TextBox()
        Me.btTutup = New System.Windows.Forms.Button()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLokasiPemasangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtketlain = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNamaKomputer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCabang2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblNamaKomputer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.FraTambahUbah.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Versi 1.1"
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.AllowUserToDeleteRows = False
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Location = New System.Drawing.Point(-4, 244)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.Size = New System.Drawing.Size(452, 297)
        Me.dgData.TabIndex = 1
        '
        'cmbCabang
        '
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(70, 214)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(378, 21)
        Me.cmbCabang.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cabang"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmdPing)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btTambah)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 81)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(38, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Ping"
        '
        'cmdPing
        '
        Me.cmdPing.BackColor = System.Drawing.Color.LightCoral
        Me.cmdPing.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources._123521
        Me.cmdPing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdPing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPing.Location = New System.Drawing.Point(41, 15)
        Me.cmdPing.Name = "cmdPing"
        Me.cmdPing.Size = New System.Drawing.Size(64, 41)
        Me.cmdPing.TabIndex = 12
        Me.cmdPing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPing.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(256, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Hapus"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(180, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Ubah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tambah"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cornsilk
        Me.Button2.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.iconfinder_1_04_511562
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(257, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.iconfinder_icon_136_document_edit_314724
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(183, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btTambah
        '
        Me.btTambah.BackColor = System.Drawing.Color.LightCoral
        Me.btTambah.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.iconfinder_icon_33_clipboard_add_315154
        Me.btTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTambah.Location = New System.Drawing.Point(113, 15)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(64, 41)
        Me.btTambah.TabIndex = 6
        Me.btTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btTambah.UseVisualStyleBackColor = False
        '
        'FraTambahUbah
        '
        Me.FraTambahUbah.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.md_5b12306722c18
        Me.FraTambahUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FraTambahUbah.Controls.Add(Me.txtDocEntry)
        Me.FraTambahUbah.Controls.Add(Me.btTutup)
        Me.FraTambahUbah.Controls.Add(Me.btSimpan)
        Me.FraTambahUbah.Controls.Add(Me.btBatal)
        Me.FraTambahUbah.Controls.Add(Me.GroupBox5)
        Me.FraTambahUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraTambahUbah.Location = New System.Drawing.Point(17, 260)
        Me.FraTambahUbah.Name = "FraTambahUbah"
        Me.FraTambahUbah.Size = New System.Drawing.Size(430, 281)
        Me.FraTambahUbah.TabIndex = 9
        Me.FraTambahUbah.TabStop = False
        Me.FraTambahUbah.Text = "Tambah IP Baru"
        Me.FraTambahUbah.Visible = False
        '
        'txtDocEntry
        '
        Me.txtDocEntry.Location = New System.Drawing.Point(319, 8)
        Me.txtDocEntry.Multiline = True
        Me.txtDocEntry.Name = "txtDocEntry"
        Me.txtDocEntry.Size = New System.Drawing.Size(97, 24)
        Me.txtDocEntry.TabIndex = 10
        Me.txtDocEntry.Visible = False
        '
        'btTutup
        '
        Me.btTutup.Location = New System.Drawing.Point(307, 231)
        Me.btTutup.Name = "btTutup"
        Me.btTutup.Size = New System.Drawing.Size(109, 44)
        Me.btTutup.TabIndex = 9
        Me.btTutup.Text = "Tutup"
        Me.btTutup.UseVisualStyleBackColor = True
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(51, 231)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(109, 44)
        Me.btSimpan.TabIndex = 8
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Location = New System.Drawing.Point(178, 231)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(109, 44)
        Me.btBatal.TabIndex = 7
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox5.Controls.Add(Me.txtIpAddress)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtLokasiPemasangan)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.txtketlain)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtNamaKomputer)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.cmbCabang2)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(406, 176)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data IP"
        '
        'txtIpAddress
        '
        Me.txtIpAddress.Location = New System.Drawing.Point(168, 75)
        Me.txtIpAddress.Multiline = True
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(232, 24)
        Me.txtIpAddress.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "IP Address"
        '
        'txtLokasiPemasangan
        '
        Me.txtLokasiPemasangan.Location = New System.Drawing.Point(168, 137)
        Me.txtLokasiPemasangan.Multiline = True
        Me.txtLokasiPemasangan.Name = "txtLokasiPemasangan"
        Me.txtLokasiPemasangan.Size = New System.Drawing.Size(232, 24)
        Me.txtLokasiPemasangan.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Lokasi Pemasangan"
        '
        'txtketlain
        '
        Me.txtketlain.Location = New System.Drawing.Point(168, 107)
        Me.txtketlain.Multiline = True
        Me.txtketlain.Name = "txtketlain"
        Me.txtketlain.Size = New System.Drawing.Size(232, 24)
        Me.txtketlain.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Ket Lain"
        '
        'txtNamaKomputer
        '
        Me.txtNamaKomputer.Location = New System.Drawing.Point(168, 46)
        Me.txtNamaKomputer.Multiline = True
        Me.txtNamaKomputer.Name = "txtNamaKomputer"
        Me.txtNamaKomputer.Size = New System.Drawing.Size(232, 24)
        Me.txtNamaKomputer.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nama Komputer"
        '
        'cmbCabang2
        '
        Me.cmbCabang2.FormattingEnabled = True
        Me.cmbCabang2.Location = New System.Drawing.Point(168, 19)
        Me.cmbCabang2.Name = "cmbCabang2"
        Me.cmbCabang2.Size = New System.Drawing.Size(232, 24)
        Me.cmbCabang2.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cabang"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox1.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources._8d2266d10c0de8283c9f225d7f7b045b_colorful_abstract_geometric_background_vector_by_vexels
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.kisspng_ip_address_management_internet_protocol_computer_n_adress_5ac2a2f1d01703_7126512115227051378523
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 101)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox2.Controls.Add(Me.lblIP)
        Me.GroupBox2.Controls.Add(Me.lblNamaKomputer)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(145, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 69)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "My Info"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(139, 42)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(13, 16)
        Me.lblIP.TabIndex = 4
        Me.lblIP.Text = "-"
        '
        'lblNamaKomputer
        '
        Me.lblNamaKomputer.AutoSize = True
        Me.lblNamaKomputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKomputer.Location = New System.Drawing.Point(139, 16)
        Me.lblNamaKomputer.Name = "lblNamaKomputer"
        Me.lblNamaKomputer.Size = New System.Drawing.Size(13, 16)
        Me.lblNamaKomputer.TabIndex = 3
        Me.lblNamaKomputer.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "My IP                  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "My Comp Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP EFISIENSI"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(354, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Build 21.11.19"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.IP_Efisiensi.My.Resources.Resources.md_5b12306722c18
        Me.ClientSize = New System.Drawing.Size(459, 553)
        Me.Controls.Add(Me.FraTambahUbah)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCabang)
        Me.Controls.Add(Me.dgData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP Efisiensi"
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FraTambahUbah.ResumeLayout(False)
        Me.FraTambahUbah.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblNamaKomputer As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FraTambahUbah As System.Windows.Forms.GroupBox
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIpAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiPemasangan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtketlain As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNamaKomputer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btTutup As System.Windows.Forms.Button
    Friend WithEvents txtDocEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdPing As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
