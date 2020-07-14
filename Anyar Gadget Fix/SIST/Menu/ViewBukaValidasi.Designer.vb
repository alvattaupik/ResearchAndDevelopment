<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBukaValidasi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblKdJenisSurat = New System.Windows.Forms.Label()
        Me.txtKodeKomponenValidasi = New System.Windows.Forms.TextBox()
        Me.txtKodeKomponenSAP = New System.Windows.Forms.TextBox()
        Me.JamAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPathLampiran = New System.Windows.Forms.TextBox()
        Me.cmdBrowseLampiran = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPesanUser = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNotifValidasi = New System.Windows.Forms.RichTextBox()
        Me.cmdCariKomponenValidasi = New System.Windows.Forms.Button()
        Me.cmdCariKomponenSAP = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKomponenValidasi = New System.Windows.Forms.RichTextBox()
        Me.txtKomponenSAP = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDisplayLokasi = New System.Windows.Forms.TextBox()
        Me.txtDisplayNama = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNomorSurat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCatatanIT = New System.Windows.Forms.RichTextBox()
        Me.txtDurasi = New System.Windows.Forms.TextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDisplayTanggal = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.Vector_2
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.txtKodeKomponenValidasi)
        Me.Panel1.Controls.Add(Me.txtKodeKomponenSAP)
        Me.Panel1.Controls.Add(Me.JamAwal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 78)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblKdJenisSurat)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(58, 53)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'lblKdJenisSurat
        '
        Me.lblKdJenisSurat.AutoSize = True
        Me.lblKdJenisSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdJenisSurat.Location = New System.Drawing.Point(9, 23)
        Me.lblKdJenisSurat.Name = "lblKdJenisSurat"
        Me.lblKdJenisSurat.Size = New System.Drawing.Size(40, 13)
        Me.lblKdJenisSurat.TabIndex = 0
        Me.lblKdJenisSurat.Text = "IT003"
        '
        'txtKodeKomponenValidasi
        '
        Me.txtKodeKomponenValidasi.Location = New System.Drawing.Point(90, 50)
        Me.txtKodeKomponenValidasi.Name = "txtKodeKomponenValidasi"
        Me.txtKodeKomponenValidasi.Size = New System.Drawing.Size(258, 20)
        Me.txtKodeKomponenValidasi.TabIndex = 4
        Me.txtKodeKomponenValidasi.Visible = False
        '
        'txtKodeKomponenSAP
        '
        Me.txtKodeKomponenSAP.Location = New System.Drawing.Point(90, 3)
        Me.txtKodeKomponenSAP.Name = "txtKodeKomponenSAP"
        Me.txtKodeKomponenSAP.Size = New System.Drawing.Size(258, 20)
        Me.txtKodeKomponenSAP.TabIndex = 3
        Me.txtKodeKomponenSAP.Visible = False
        '
        'JamAwal
        '
        Me.JamAwal.Location = New System.Drawing.Point(444, 50)
        Me.JamAwal.Name = "JamAwal"
        Me.JamAwal.Size = New System.Drawing.Size(200, 20)
        Me.JamAwal.TabIndex = 2
        Me.JamAwal.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FORM REQUEST BUKA VALIDASI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.txtDisplayTanggal)
        Me.Panel2.Controls.Add(Me.GunaLabel6)
        Me.Panel2.Controls.Add(Me.txtDurasi)
        Me.Panel2.Controls.Add(Me.txtNomorSurat)
        Me.Panel2.Controls.Add(Me.GunaLabel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.cmdCariKomponenValidasi)
        Me.Panel2.Controls.Add(Me.cmdCariKomponenSAP)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtKomponenValidasi)
        Me.Panel2.Controls.Add(Me.txtKomponenSAP)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.GunaLabel4)
        Me.Panel2.Controls.Add(Me.txtDisplayLokasi)
        Me.Panel2.Controls.Add(Me.txtDisplayNama)
        Me.Panel2.Controls.Add(Me.GunaLabel2)
        Me.Panel2.Controls.Add(Me.GunaLabel1)
        Me.Panel2.Location = New System.Drawing.Point(2, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(740, 310)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.txtCatatanIT)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtPathLampiran)
        Me.Panel3.Controls.Add(Me.cmdBrowseLampiran)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtPesanUser)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtNotifValidasi)
        Me.Panel3.Location = New System.Drawing.Point(374, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(361, 300)
        Me.Panel3.TabIndex = 22
        '
        'txtPathLampiran
        '
        Me.txtPathLampiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathLampiran.Location = New System.Drawing.Point(87, 176)
        Me.txtPathLampiran.Name = "txtPathLampiran"
        Me.txtPathLampiran.ReadOnly = True
        Me.txtPathLampiran.Size = New System.Drawing.Size(130, 26)
        Me.txtPathLampiran.TabIndex = 39
        '
        'cmdBrowseLampiran
        '
        Me.cmdBrowseLampiran.AnimationHoverSpeed = 0.07!
        Me.cmdBrowseLampiran.AnimationSpeed = 0.03!
        Me.cmdBrowseLampiran.BackColor = System.Drawing.Color.Transparent
        Me.cmdBrowseLampiran.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdBrowseLampiran.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdBrowseLampiran.BorderColor = System.Drawing.Color.Black
        Me.cmdBrowseLampiran.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdBrowseLampiran.FocusedColor = System.Drawing.Color.Empty
        Me.cmdBrowseLampiran.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowseLampiran.ForeColor = System.Drawing.Color.White
        Me.cmdBrowseLampiran.Image = Nothing
        Me.cmdBrowseLampiran.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdBrowseLampiran.Location = New System.Drawing.Point(228, 173)
        Me.cmdBrowseLampiran.Name = "cmdBrowseLampiran"
        Me.cmdBrowseLampiran.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowseLampiran.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowseLampiran.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowseLampiran.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowseLampiran.OnHoverImage = Nothing
        Me.cmdBrowseLampiran.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowseLampiran.Radius = 2
        Me.cmdBrowseLampiran.Size = New System.Drawing.Size(130, 30)
        Me.cmdBrowseLampiran.TabIndex = 38
        Me.cmdBrowseLampiran.Text = "Lihat Lampiran"
        Me.cmdBrowseLampiran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Lampiran"
        '
        'txtPesanUser
        '
        Me.txtPesanUser.Location = New System.Drawing.Point(87, 95)
        Me.txtPesanUser.Name = "txtPesanUser"
        Me.txtPesanUser.Size = New System.Drawing.Size(271, 67)
        Me.txtPesanUser.TabIndex = 23
        Me.txtPesanUser.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(165, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Pesan Saya"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Validasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Notif"
        '
        'txtNotifValidasi
        '
        Me.txtNotifValidasi.Location = New System.Drawing.Point(87, 5)
        Me.txtNotifValidasi.Name = "txtNotifValidasi"
        Me.txtNotifValidasi.Size = New System.Drawing.Size(271, 68)
        Me.txtNotifValidasi.TabIndex = 19
        Me.txtNotifValidasi.Text = ""
        '
        'cmdCariKomponenValidasi
        '
        Me.cmdCariKomponenValidasi.Location = New System.Drawing.Point(322, 219)
        Me.cmdCariKomponenValidasi.Name = "cmdCariKomponenValidasi"
        Me.cmdCariKomponenValidasi.Size = New System.Drawing.Size(46, 56)
        Me.cmdCariKomponenValidasi.TabIndex = 21
        Me.cmdCariKomponenValidasi.Text = "Cari"
        Me.cmdCariKomponenValidasi.UseVisualStyleBackColor = True
        '
        'cmdCariKomponenSAP
        '
        Me.cmdCariKomponenSAP.Location = New System.Drawing.Point(322, 152)
        Me.cmdCariKomponenSAP.Name = "cmdCariKomponenSAP"
        Me.cmdCariKomponenSAP.Size = New System.Drawing.Size(46, 61)
        Me.cmdCariKomponenSAP.TabIndex = 20
        Me.cmdCariKomponenSAP.Text = "Cari"
        Me.cmdCariKomponenSAP.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Komponen Validasi"
        '
        'txtKomponenValidasi
        '
        Me.txtKomponenValidasi.Location = New System.Drawing.Point(161, 219)
        Me.txtKomponenValidasi.Name = "txtKomponenValidasi"
        Me.txtKomponenValidasi.ReadOnly = True
        Me.txtKomponenValidasi.Size = New System.Drawing.Size(155, 56)
        Me.txtKomponenValidasi.TabIndex = 18
        Me.txtKomponenValidasi.Text = ""
        '
        'txtKomponenSAP
        '
        Me.txtKomponenSAP.Location = New System.Drawing.Point(161, 152)
        Me.txtKomponenSAP.Name = "txtKomponenSAP"
        Me.txtKomponenSAP.ReadOnly = True
        Me.txtKomponenSAP.Size = New System.Drawing.Size(155, 62)
        Me.txtKomponenSAP.TabIndex = 17
        Me.txtKomponenSAP.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Komponen SAP"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 283)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(120, 21)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Durasi Sampai"
        '
        'txtDisplayLokasi
        '
        Me.txtDisplayLokasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayLokasi.Location = New System.Drawing.Point(161, 91)
        Me.txtDisplayLokasi.Name = "txtDisplayLokasi"
        Me.txtDisplayLokasi.ReadOnly = True
        Me.txtDisplayLokasi.Size = New System.Drawing.Size(207, 26)
        Me.txtDisplayLokasi.TabIndex = 4
        '
        'txtDisplayNama
        '
        Me.txtDisplayNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayNama.Location = New System.Drawing.Point(161, 62)
        Me.txtDisplayNama.Name = "txtDisplayNama"
        Me.txtDisplayNama.ReadOnly = True
        Me.txtDisplayNama.Size = New System.Drawing.Size(207, 26)
        Me.txtDisplayNama.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(2, 90)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(116, 21)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Divisi / Lokasi"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(2, 59)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(102, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Dibuat Oleh"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(3, 3)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(64, 21)
        Me.GunaLabel5.TabIndex = 26
        Me.GunaLabel5.Text = "Nomor"
        '
        'txtNomorSurat
        '
        Me.txtNomorSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomorSurat.Location = New System.Drawing.Point(161, 4)
        Me.txtNomorSurat.Name = "txtNomorSurat"
        Me.txtNomorSurat.ReadOnly = True
        Me.txtNomorSurat.Size = New System.Drawing.Size(207, 26)
        Me.txtNomorSurat.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Catatan IT Department"
        '
        'txtCatatanIT
        '
        Me.txtCatatanIT.Location = New System.Drawing.Point(87, 228)
        Me.txtCatatanIT.Name = "txtCatatanIT"
        Me.txtCatatanIT.ReadOnly = True
        Me.txtCatatanIT.Size = New System.Drawing.Size(271, 67)
        Me.txtCatatanIT.TabIndex = 41
        Me.txtCatatanIT.Text = ""
        '
        'txtDurasi
        '
        Me.txtDurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDurasi.Location = New System.Drawing.Point(161, 281)
        Me.txtDurasi.Name = "txtDurasi"
        Me.txtDurasi.ReadOnly = True
        Me.txtDurasi.Size = New System.Drawing.Size(207, 26)
        Me.txtDurasi.TabIndex = 28
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(2, 32)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel6.TabIndex = 29
        Me.GunaLabel6.Text = "Tanggal"
        '
        'txtDisplayTanggal
        '
        Me.txtDisplayTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayTanggal.Location = New System.Drawing.Point(161, 32)
        Me.txtDisplayTanggal.Name = "txtDisplayTanggal"
        Me.txtDisplayTanggal.ReadOnly = True
        Me.txtDisplayTanggal.Size = New System.Drawing.Size(207, 26)
        Me.txtDisplayTanggal.TabIndex = 30
        '
        'ViewBukaValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 400)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ViewBukaValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BukaValidasi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDisplayNama As System.Windows.Forms.TextBox
    Friend WithEvents txtDisplayLokasi As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKomponenValidasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtKomponenSAP As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdCariKomponenValidasi As System.Windows.Forms.Button
    Friend WithEvents cmdCariKomponenSAP As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPesanUser As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotifValidasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPathLampiran As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseLampiran As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents JamAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKodeKomponenValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeKomponenSAP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNomorSurat As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtCatatanIT As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDisplayTanggal As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDurasi As System.Windows.Forms.TextBox
End Class
