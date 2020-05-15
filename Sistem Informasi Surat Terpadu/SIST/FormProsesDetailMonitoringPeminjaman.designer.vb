<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesDetailMonitoringPeminjaman
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaSPV = New Guna.UI.WinForms.GunaTextBox()
        Me.txtStatus = New Guna.UI.WinForms.GunaTextBox()
        Me.txtJenisForm = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPathAttachment = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdLihatAttchment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.txtJenisValidasi = New Guna.UI.WinForms.GunaTextBox()
        Me.txtErrorvalidasi = New System.Windows.Forms.RichTextBox()
        Me.txtNamaUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPesanUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNoDokumen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtLokasi = New Guna.UI.WinForms.GunaTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenerima = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTglKembali = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDiprosesOleh = New Guna.UI.WinForms.GunaTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblJumlahUserApproved = New System.Windows.Forms.Label()
        Me.dgDaftarUserApproval = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtCatatanAdmin = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLamanya = New Guna.UI.WinForms.GunaTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDurasi2 = New System.Windows.Forms.TextBox()
        Me.txtJenisRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDurasi1 = New System.Windows.Forms.TextBox()
        Me.cmdProses = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamaSPV)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.txtJenisForm)
        Me.GroupBox1.Controls.Add(Me.txtPathAttachment)
        Me.GroupBox1.Controls.Add(Me.cmdLihatAttchment)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKomponen)
        Me.GroupBox1.Controls.Add(Me.txtJenisValidasi)
        Me.GroupBox1.Controls.Add(Me.txtErrorvalidasi)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNamaSPV
        '
        Me.txtNamaSPV.BaseColor = System.Drawing.Color.White
        Me.txtNamaSPV.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaSPV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaSPV.Enabled = False
        Me.txtNamaSPV.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaSPV.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaSPV.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaSPV.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaSPV.Location = New System.Drawing.Point(646, 39)
        Me.txtNamaSPV.Name = "txtNamaSPV"
        Me.txtNamaSPV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaSPV.Size = New System.Drawing.Size(34, 26)
        Me.txtNamaSPV.TabIndex = 20
        Me.txtNamaSPV.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Orchid
        Me.txtStatus.BaseColor = System.Drawing.Color.Pink
        Me.txtStatus.BorderColor = System.Drawing.Color.Silver
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatus.Enabled = False
        Me.txtStatus.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStatus.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatus.Location = New System.Drawing.Point(475, 40)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.Size = New System.Drawing.Size(35, 26)
        Me.txtStatus.TabIndex = 13
        Me.txtStatus.Visible = False
        '
        'txtJenisForm
        '
        Me.txtJenisForm.BaseColor = System.Drawing.Color.White
        Me.txtJenisForm.BorderColor = System.Drawing.Color.Silver
        Me.txtJenisForm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJenisForm.Enabled = False
        Me.txtJenisForm.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJenisForm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJenisForm.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJenisForm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJenisForm.Location = New System.Drawing.Point(598, 10)
        Me.txtJenisForm.Name = "txtJenisForm"
        Me.txtJenisForm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisForm.Size = New System.Drawing.Size(42, 26)
        Me.txtJenisForm.TabIndex = 6
        Me.txtJenisForm.Visible = False
        '
        'txtPathAttachment
        '
        Me.txtPathAttachment.BaseColor = System.Drawing.Color.White
        Me.txtPathAttachment.BorderColor = System.Drawing.Color.Silver
        Me.txtPathAttachment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPathAttachment.Enabled = False
        Me.txtPathAttachment.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPathAttachment.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPathAttachment.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPathAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPathAttachment.Location = New System.Drawing.Point(598, 39)
        Me.txtPathAttachment.Name = "txtPathAttachment"
        Me.txtPathAttachment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathAttachment.Size = New System.Drawing.Size(42, 26)
        Me.txtPathAttachment.TabIndex = 4
        Me.txtPathAttachment.Visible = False
        '
        'cmdLihatAttchment
        '
        Me.cmdLihatAttchment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLihatAttchment.Location = New System.Drawing.Point(518, 39)
        Me.cmdLihatAttchment.Name = "cmdLihatAttchment"
        Me.cmdLihatAttchment.Size = New System.Drawing.Size(35, 27)
        Me.cmdLihatAttchment.TabIndex = 16
        Me.cmdLihatAttchment.Text = "Lihat Attachment"
        Me.cmdLihatAttchment.UseVisualStyleBackColor = True
        Me.cmdLihatAttchment.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(662, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail Peminjaman User"
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
        Me.txtKomponen.Location = New System.Drawing.Point(557, 10)
        Me.txtKomponen.Name = "txtKomponen"
        Me.txtKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKomponen.Size = New System.Drawing.Size(35, 26)
        Me.txtKomponen.TabIndex = 1
        Me.txtKomponen.Visible = False
        '
        'txtJenisValidasi
        '
        Me.txtJenisValidasi.BaseColor = System.Drawing.Color.White
        Me.txtJenisValidasi.BorderColor = System.Drawing.Color.Silver
        Me.txtJenisValidasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJenisValidasi.Enabled = False
        Me.txtJenisValidasi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJenisValidasi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJenisValidasi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJenisValidasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJenisValidasi.Location = New System.Drawing.Point(519, 10)
        Me.txtJenisValidasi.Name = "txtJenisValidasi"
        Me.txtJenisValidasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisValidasi.Size = New System.Drawing.Size(32, 26)
        Me.txtJenisValidasi.TabIndex = 7
        Me.txtJenisValidasi.Visible = False
        '
        'txtErrorvalidasi
        '
        Me.txtErrorvalidasi.Enabled = False
        Me.txtErrorvalidasi.Location = New System.Drawing.Point(557, 42)
        Me.txtErrorvalidasi.Name = "txtErrorvalidasi"
        Me.txtErrorvalidasi.Size = New System.Drawing.Size(32, 23)
        Me.txtErrorvalidasi.TabIndex = 9
        Me.txtErrorvalidasi.Text = ""
        Me.txtErrorvalidasi.Visible = False
        '
        'txtNamaUser
        '
        Me.txtNamaUser.BaseColor = System.Drawing.Color.White
        Me.txtNamaUser.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaUser.Enabled = False
        Me.txtNamaUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaUser.Location = New System.Drawing.Point(115, 28)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaUser.Size = New System.Drawing.Size(197, 26)
        Me.txtNamaUser.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Dibuat Oleh"
        '
        'txtPesanUser
        '
        Me.txtPesanUser.BaseColor = System.Drawing.Color.White
        Me.txtPesanUser.BorderColor = System.Drawing.Color.Silver
        Me.txtPesanUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPesanUser.Enabled = False
        Me.txtPesanUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPesanUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPesanUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPesanUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPesanUser.Location = New System.Drawing.Point(115, 147)
        Me.txtPesanUser.Name = "txtPesanUser"
        Me.txtPesanUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPesanUser.Size = New System.Drawing.Size(197, 61)
        Me.txtPesanUser.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pesan User"
        '
        'txtNoDokumen
        '
        Me.txtNoDokumen.BaseColor = System.Drawing.Color.White
        Me.txtNoDokumen.BorderColor = System.Drawing.Color.Silver
        Me.txtNoDokumen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoDokumen.Enabled = False
        Me.txtNoDokumen.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNoDokumen.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNoDokumen.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoDokumen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoDokumen.Location = New System.Drawing.Point(115, 86)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoDokumen.Size = New System.Drawing.Size(197, 26)
        Me.txtNoDokumen.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Doc Num"
        '
        'txtTanggal
        '
        Me.txtTanggal.BaseColor = System.Drawing.Color.White
        Me.txtTanggal.BorderColor = System.Drawing.Color.Silver
        Me.txtTanggal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTanggal.Enabled = False
        Me.txtTanggal.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTanggal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTanggal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTanggal.Location = New System.Drawing.Point(115, 115)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTanggal.Size = New System.Drawing.Size(197, 26)
        Me.txtTanggal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Request"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLokasi)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.lblJumlahUserApproved)
        Me.GroupBox3.Controls.Add(Me.dgDaftarUserApproval)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(341, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(375, 286)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtLokasi
        '
        Me.txtLokasi.BaseColor = System.Drawing.Color.White
        Me.txtLokasi.BorderColor = System.Drawing.Color.Silver
        Me.txtLokasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLokasi.Enabled = False
        Me.txtLokasi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLokasi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLokasi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLokasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLokasi.Location = New System.Drawing.Point(74, 142)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLokasi.Size = New System.Drawing.Size(292, 26)
        Me.txtLokasi.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 18)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Lokasi"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtPenerima)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtTglKembali)
        Me.Panel3.Location = New System.Drawing.Point(7, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 60)
        Me.Panel3.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Di Terima Oleh"
        '
        'txtPenerima
        '
        Me.txtPenerima.BaseColor = System.Drawing.Color.White
        Me.txtPenerima.BorderColor = System.Drawing.Color.Silver
        Me.txtPenerima.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPenerima.Enabled = False
        Me.txtPenerima.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPenerima.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPenerima.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPenerima.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPenerima.Location = New System.Drawing.Point(135, 32)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPenerima.Size = New System.Drawing.Size(222, 26)
        Me.txtPenerima.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Tanggal Kembali"
        '
        'txtTglKembali
        '
        Me.txtTglKembali.BaseColor = System.Drawing.Color.White
        Me.txtTglKembali.BorderColor = System.Drawing.Color.Silver
        Me.txtTglKembali.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTglKembali.Enabled = False
        Me.txtTglKembali.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTglKembali.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTglKembali.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTglKembali.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTglKembali.Location = New System.Drawing.Point(135, 3)
        Me.txtTglKembali.Name = "txtTglKembali"
        Me.txtTglKembali.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTglKembali.Size = New System.Drawing.Size(223, 26)
        Me.txtTglKembali.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSalmon
        Me.Panel2.Controls.Add(Me.txtDiprosesOleh)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(6, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 45)
        Me.Panel2.TabIndex = 51
        '
        'txtDiprosesOleh
        '
        Me.txtDiprosesOleh.BaseColor = System.Drawing.Color.White
        Me.txtDiprosesOleh.BorderColor = System.Drawing.Color.Silver
        Me.txtDiprosesOleh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiprosesOleh.Enabled = False
        Me.txtDiprosesOleh.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDiprosesOleh.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiprosesOleh.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDiprosesOleh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiprosesOleh.Location = New System.Drawing.Point(136, 9)
        Me.txtDiprosesOleh.Name = "txtDiprosesOleh"
        Me.txtDiprosesOleh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiprosesOleh.Size = New System.Drawing.Size(221, 26)
        Me.txtDiprosesOleh.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(4, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 18)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Diproses Oleh"
        '
        'lblJumlahUserApproved
        '
        Me.lblJumlahUserApproved.AutoSize = True
        Me.lblJumlahUserApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUserApproved.Location = New System.Drawing.Point(3, 122)
        Me.lblJumlahUserApproved.Name = "lblJumlahUserApproved"
        Me.lblJumlahUserApproved.Size = New System.Drawing.Size(166, 16)
        Me.lblJumlahUserApproved.TabIndex = 17
        Me.lblJumlahUserApproved.Text = "Jumlah User Approved"
        '
        'dgDaftarUserApproval
        '
        Me.dgDaftarUserApproval.AllowUserToAddRows = False
        Me.dgDaftarUserApproval.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgDaftarUserApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarUserApproval.BackgroundColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarUserApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDaftarUserApproval.ColumnHeadersHeight = 30
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarUserApproval.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgDaftarUserApproval.EnableHeadersVisualStyles = False
        Me.dgDaftarUserApproval.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.Location = New System.Drawing.Point(11, 29)
        Me.dgDaftarUserApproval.Name = "dgDaftarUserApproval"
        Me.dgDaftarUserApproval.ReadOnly = True
        Me.dgDaftarUserApproval.RowHeadersVisible = False
        Me.dgDaftarUserApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarUserApproval.Size = New System.Drawing.Size(354, 90)
        Me.dgDaftarUserApproval.TabIndex = 16
        Me.dgDaftarUserApproval.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgDaftarUserApproval.ThemeStyle.HeaderStyle.Height = 30
        Me.dgDaftarUserApproval.ThemeStyle.ReadOnly = True
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.Height = 22
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Daftar Asset Yang Dipinjam"
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
        Me.cmdSimpan.Location = New System.Drawing.Point(341, 412)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(367, 31)
        Me.cmdSimpan.TabIndex = 40
        Me.cmdSimpan.Text = "Cetak"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(341, 449)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(367, 32)
        Me.GunaGradientButton1.TabIndex = 41
        Me.GunaGradientButton1.Text = "Tutup"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbStatus)
        Me.GroupBox4.Controls.Add(Me.txtCatatanAdmin)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 366)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 122)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(130, 18)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(182, 24)
        Me.cmbStatus.TabIndex = 68
        '
        'txtCatatanAdmin
        '
        Me.txtCatatanAdmin.Enabled = False
        Me.txtCatatanAdmin.Location = New System.Drawing.Point(130, 46)
        Me.txtCatatanAdmin.Name = "txtCatatanAdmin"
        Me.txtCatatanAdmin.Size = New System.Drawing.Size(182, 67)
        Me.txtCatatanAdmin.TabIndex = 67
        Me.txtCatatanAdmin.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Catatan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 20)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Status Proses"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.txtLamanya)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtDurasi2)
        Me.Panel1.Controls.Add(Me.txtJenisRequest)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtDurasi1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPesanUser)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTanggal)
        Me.Panel1.Controls.Add(Me.txtNamaUser)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNoDokumen)
        Me.Panel1.Location = New System.Drawing.Point(8, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 279)
        Me.Panel1.TabIndex = 68
        '
        'txtLamanya
        '
        Me.txtLamanya.BaseColor = System.Drawing.Color.White
        Me.txtLamanya.BorderColor = System.Drawing.Color.Silver
        Me.txtLamanya.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLamanya.Enabled = False
        Me.txtLamanya.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLamanya.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLamanya.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLamanya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLamanya.Location = New System.Drawing.Point(115, 243)
        Me.txtLamanya.Name = "txtLamanya"
        Me.txtLamanya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLamanya.Size = New System.Drawing.Size(197, 26)
        Me.txtLamanya.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 18)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Lamanya"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Periode"
        '
        'txtDurasi2
        '
        Me.txtDurasi2.Enabled = False
        Me.txtDurasi2.Location = New System.Drawing.Point(225, 212)
        Me.txtDurasi2.Name = "txtDurasi2"
        Me.txtDurasi2.Size = New System.Drawing.Size(87, 20)
        Me.txtDurasi2.TabIndex = 56
        '
        'txtJenisRequest
        '
        Me.txtJenisRequest.BaseColor = System.Drawing.Color.White
        Me.txtJenisRequest.BorderColor = System.Drawing.Color.Silver
        Me.txtJenisRequest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJenisRequest.Enabled = False
        Me.txtJenisRequest.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJenisRequest.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJenisRequest.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJenisRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJenisRequest.Location = New System.Drawing.Point(115, 57)
        Me.txtJenisRequest.Name = "txtJenisRequest"
        Me.txtJenisRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisRequest.Size = New System.Drawing.Size(197, 26)
        Me.txtJenisRequest.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(199, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "S/D"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(97, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 18)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Document Owner"
        '
        'txtDurasi1
        '
        Me.txtDurasi1.Enabled = False
        Me.txtDurasi1.Location = New System.Drawing.Point(115, 212)
        Me.txtDurasi1.Name = "txtDurasi1"
        Me.txtDurasi1.Size = New System.Drawing.Size(83, 20)
        Me.txtDurasi1.TabIndex = 54
        '
        'cmdProses
        '
        Me.cmdProses.AnimationHoverSpeed = 0.07!
        Me.cmdProses.AnimationSpeed = 0.03!
        Me.cmdProses.BackColor = System.Drawing.Color.Transparent
        Me.cmdProses.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdProses.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdProses.BorderColor = System.Drawing.Color.Black
        Me.cmdProses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdProses.FocusedColor = System.Drawing.Color.Empty
        Me.cmdProses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdProses.ForeColor = System.Drawing.Color.White
        Me.cmdProses.Image = Nothing
        Me.cmdProses.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdProses.Location = New System.Drawing.Point(341, 376)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdProses.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdProses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdProses.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdProses.OnHoverImage = Nothing
        Me.cmdProses.OnPressedColor = System.Drawing.Color.Black
        Me.cmdProses.Radius = 2
        Me.cmdProses.Size = New System.Drawing.Size(367, 31)
        Me.cmdProses.TabIndex = 69
        Me.cmdProses.Text = "Pengembalian Aset"
        Me.cmdProses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormProsesDetailMonitoringPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 491)
        Me.Controls.Add(Me.cmdProses)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSimpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProsesDetailMonitoringPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetailValidasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoDokumen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtErrorvalidasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtTanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtStatus As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPesanUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDaftarUserApproval As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtJenisValidasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblJumlahUserApproved As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdLihatAttchment As System.Windows.Forms.Button
    Friend WithEvents txtPathAttachment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtJenisForm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNamaSPV As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNamaUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCatatanAdmin As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDiprosesOleh As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTglKembali As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPenerima As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtJenisRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLokasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLamanya As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDurasi2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDurasi1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdProses As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
End Class
