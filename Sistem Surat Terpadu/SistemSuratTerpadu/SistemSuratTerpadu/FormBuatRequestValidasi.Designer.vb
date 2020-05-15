<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatRequestValidasi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKodeKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNoValidasi = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblKdJenisSurat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdBrowseAttatchment = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPathAttachments = New Guna.UI.WinForms.GunaTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.RichTextBox()
        Me.txtNamaSupervisor = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDivisi = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaLengkap = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.JamAkhir = New System.Windows.Forms.DateTimePicker()
        Me.JamAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtError = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbJenisValidasi = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbJenisRequest = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKodeKomponen)
        Me.GroupBox1.Controls.Add(Me.txtNoValidasi)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtKodeKomponen
        '
        Me.txtKodeKomponen.BaseColor = System.Drawing.Color.White
        Me.txtKodeKomponen.BorderColor = System.Drawing.Color.Silver
        Me.txtKodeKomponen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeKomponen.Enabled = False
        Me.txtKodeKomponen.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKodeKomponen.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKodeKomponen.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKodeKomponen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKodeKomponen.Location = New System.Drawing.Point(541, 34)
        Me.txtKodeKomponen.Name = "txtKodeKomponen"
        Me.txtKodeKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeKomponen.Size = New System.Drawing.Size(53, 26)
        Me.txtKodeKomponen.TabIndex = 17
        Me.txtKodeKomponen.Visible = False
        '
        'txtNoValidasi
        '
        Me.txtNoValidasi.BaseColor = System.Drawing.Color.White
        Me.txtNoValidasi.BorderColor = System.Drawing.Color.Silver
        Me.txtNoValidasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoValidasi.Enabled = False
        Me.txtNoValidasi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoValidasi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoValidasi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoValidasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoValidasi.Location = New System.Drawing.Point(283, 30)
        Me.txtNoValidasi.Name = "txtNoValidasi"
        Me.txtNoValidasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoValidasi.Size = New System.Drawing.Size(251, 30)
        Me.txtNoValidasi.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblKdJenisSurat)
        Me.GroupBox3.Location = New System.Drawing.Point(193, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(58, 53)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblKdJenisSurat
        '
        Me.lblKdJenisSurat.AutoSize = True
        Me.lblKdJenisSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdJenisSurat.Location = New System.Drawing.Point(6, 22)
        Me.lblKdJenisSurat.Name = "lblKdJenisSurat"
        Me.lblKdJenisSurat.Size = New System.Drawing.Size(40, 13)
        Me.lblKdJenisSurat.TabIndex = 0
        Me.lblKdJenisSurat.Text = "IT003"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM REQUEST FILLFILMENT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdBrowseAttatchment)
        Me.GroupBox2.Controls.Add(Me.txtPathAttachments)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPesan)
        Me.GroupBox2.Controls.Add(Me.txtNamaSupervisor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDivisi)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNamaLengkap)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 302)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identitas Pembuat Surat"
        '
        'cmdBrowseAttatchment
        '
        Me.cmdBrowseAttatchment.AnimationHoverSpeed = 0.07!
        Me.cmdBrowseAttatchment.AnimationSpeed = 0.03!
        Me.cmdBrowseAttatchment.BackColor = System.Drawing.Color.Transparent
        Me.cmdBrowseAttatchment.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdBrowseAttatchment.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdBrowseAttatchment.BorderColor = System.Drawing.Color.Black
        Me.cmdBrowseAttatchment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdBrowseAttatchment.FocusedColor = System.Drawing.Color.Empty
        Me.cmdBrowseAttatchment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowseAttatchment.ForeColor = System.Drawing.Color.White
        Me.cmdBrowseAttatchment.Image = Nothing
        Me.cmdBrowseAttatchment.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdBrowseAttatchment.Location = New System.Drawing.Point(298, 261)
        Me.cmdBrowseAttatchment.Name = "cmdBrowseAttatchment"
        Me.cmdBrowseAttatchment.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowseAttatchment.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowseAttatchment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowseAttatchment.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowseAttatchment.OnHoverImage = Nothing
        Me.cmdBrowseAttatchment.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowseAttatchment.Radius = 2
        Me.cmdBrowseAttatchment.Size = New System.Drawing.Size(100, 34)
        Me.cmdBrowseAttatchment.TabIndex = 37
        Me.cmdBrowseAttatchment.Text = "Browse"
        Me.cmdBrowseAttatchment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPathAttachments
        '
        Me.txtPathAttachments.BaseColor = System.Drawing.Color.White
        Me.txtPathAttachments.BorderColor = System.Drawing.Color.Silver
        Me.txtPathAttachments.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPathAttachments.Enabled = False
        Me.txtPathAttachments.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPathAttachments.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPathAttachments.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPathAttachments.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPathAttachments.Location = New System.Drawing.Point(149, 261)
        Me.txtPathAttachments.Name = "txtPathAttachments"
        Me.txtPathAttachments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathAttachments.Size = New System.Drawing.Size(128, 30)
        Me.txtPathAttachments.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Attachment"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(153, 139)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "(Deskripsikan Kebutuhan, Seperti No Dokumen dll)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Catatan User"
        '
        'txtPesan
        '
        Me.txtPesan.Location = New System.Drawing.Point(149, 155)
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.Size = New System.Drawing.Size(251, 102)
        Me.txtPesan.TabIndex = 12
        Me.txtPesan.Text = ""
        '
        'txtNamaSupervisor
        '
        Me.txtNamaSupervisor.BaseColor = System.Drawing.Color.White
        Me.txtNamaSupervisor.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaSupervisor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaSupervisor.Enabled = False
        Me.txtNamaSupervisor.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaSupervisor.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaSupervisor.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaSupervisor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaSupervisor.Location = New System.Drawing.Point(149, 89)
        Me.txtNamaSupervisor.Name = "txtNamaSupervisor"
        Me.txtNamaSupervisor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaSupervisor.Size = New System.Drawing.Size(251, 30)
        Me.txtNamaSupervisor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Supervisor"
        '
        'txtDivisi
        '
        Me.txtDivisi.BaseColor = System.Drawing.Color.White
        Me.txtDivisi.BorderColor = System.Drawing.Color.Silver
        Me.txtDivisi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDivisi.Enabled = False
        Me.txtDivisi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDivisi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDivisi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDivisi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDivisi.Location = New System.Drawing.Point(149, 51)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDivisi.Size = New System.Drawing.Size(251, 30)
        Me.txtDivisi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Divisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Lengkap"
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.BaseColor = System.Drawing.Color.White
        Me.txtNamaLengkap.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaLengkap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaLengkap.Enabled = False
        Me.txtNamaLengkap.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaLengkap.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaLengkap.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaLengkap.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaLengkap.Location = New System.Drawing.Point(149, 15)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaLengkap.Size = New System.Drawing.Size(251, 30)
        Me.txtNamaLengkap.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdBrowse)
        Me.GroupBox4.Controls.Add(Me.txtKomponen)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.JamAkhir)
        Me.GroupBox4.Controls.Add(Me.JamAwal)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtError)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cmbJenisValidasi)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cmbJenisRequest)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(420, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(410, 302)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Location = New System.Drawing.Point(314, 81)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(80, 25)
        Me.cmdBrowse.TabIndex = 17
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'txtKomponen
        '
        Me.txtKomponen.BaseColor = System.Drawing.Color.White
        Me.txtKomponen.BorderColor = System.Drawing.Color.Silver
        Me.txtKomponen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKomponen.Enabled = False
        Me.txtKomponen.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKomponen.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKomponen.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKomponen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKomponen.Location = New System.Drawing.Point(124, 81)
        Me.txtKomponen.Name = "txtKomponen"
        Me.txtKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKomponen.Size = New System.Drawing.Size(184, 26)
        Me.txtKomponen.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(122, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(241, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "(* Seperti ""Tanggal Posting Anda Telalu Tua, dll"")"
        '
        'JamAkhir
        '
        Me.JamAkhir.CustomFormat = "H:mm"
        Me.JamAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamAkhir.Location = New System.Drawing.Point(293, 53)
        Me.JamAkhir.Name = "JamAkhir"
        Me.JamAkhir.Size = New System.Drawing.Size(102, 20)
        Me.JamAkhir.TabIndex = 14
        '
        'JamAwal
        '
        Me.JamAwal.CustomFormat = ""
        Me.JamAwal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamAwal.Location = New System.Drawing.Point(125, 53)
        Me.JamAwal.Name = "JamAwal"
        Me.JamAwal.Size = New System.Drawing.Size(102, 20)
        Me.JamAwal.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Dari Validasi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Pesan"
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(125, 174)
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(272, 122)
        Me.txtError.TabIndex = 11
        Me.txtError.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(251, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "S/D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Jenis Validasi"
        '
        'cmbJenisValidasi
        '
        Me.cmbJenisValidasi.BackColor = System.Drawing.Color.Transparent
        Me.cmbJenisValidasi.BaseColor = System.Drawing.Color.White
        Me.cmbJenisValidasi.BorderColor = System.Drawing.Color.Silver
        Me.cmbJenisValidasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbJenisValidasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisValidasi.FocusedColor = System.Drawing.Color.Empty
        Me.cmbJenisValidasi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbJenisValidasi.ForeColor = System.Drawing.Color.Black
        Me.cmbJenisValidasi.FormattingEnabled = True
        Me.cmbJenisValidasi.Location = New System.Drawing.Point(124, 114)
        Me.cmbJenisValidasi.Name = "cmbJenisValidasi"
        Me.cmbJenisValidasi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbJenisValidasi.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbJenisValidasi.Size = New System.Drawing.Size(272, 26)
        Me.cmbJenisValidasi.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Durasi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Komponen"
        '
        'cmbJenisRequest
        '
        Me.cmbJenisRequest.BackColor = System.Drawing.Color.Transparent
        Me.cmbJenisRequest.BaseColor = System.Drawing.Color.White
        Me.cmbJenisRequest.BorderColor = System.Drawing.Color.Silver
        Me.cmbJenisRequest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbJenisRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisRequest.FocusedColor = System.Drawing.Color.Empty
        Me.cmbJenisRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbJenisRequest.ForeColor = System.Drawing.Color.Black
        Me.cmbJenisRequest.FormattingEnabled = True
        Me.cmbJenisRequest.Items.AddRange(New Object() {"BUKA VALIDASI", "TUTUP VALIDASI"})
        Me.cmbJenisRequest.Location = New System.Drawing.Point(125, 14)
        Me.cmbJenisRequest.Name = "cmbJenisRequest"
        Me.cmbJenisRequest.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbJenisRequest.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbJenisRequest.Size = New System.Drawing.Size(271, 26)
        Me.cmbJenisRequest.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jenis Request"
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
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(420, 378)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(410, 56)
        Me.GunaGradientButton1.TabIndex = 36
        Me.GunaGradientButton1.Text = "Kirim Permintaan"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(801, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 32)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormBuatRequestValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(837, 440)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuatRequestValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormValidasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaSupervisor As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDivisi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLengkap As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbJenisRequest As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtError As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisValidasi As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPesan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents txtNoValidasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents JamAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents JamAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtKodeKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdBrowseAttatchment As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPathAttachments As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
