<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenDanClosingPeriode
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbTujuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdInputPeriode = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.cmbCabang = New Guna.UI.WinForms.GunaComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNamaSupervisor = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDivisi = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaLengkap = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdBrowseAttatchment = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPathAttachments = New Guna.UI.WinForms.GunaTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.JamAkhir = New System.Windows.Forms.DateTimePicker()
        Me.JamAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgDaftarPeriode = New System.Windows.Forms.DataGridView()
        Me.AbsEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lblJumlahPeriode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKodeKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNoValidasi = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblKdJenisSurat = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDaftarPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmbTujuan)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdInputPeriode)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.GunaLinePanel1)
        Me.GroupBox2.Controls.Add(Me.cmbCabang)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GunaGradientButton2)
        Me.GroupBox2.Controls.Add(Me.txtKomponen)
        Me.GroupBox2.Controls.Add(Me.txtNamaSupervisor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDivisi)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNamaLengkap)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmbTujuan
        '
        Me.cmbTujuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTujuan.FormattingEnabled = True
        Me.cmbTujuan.Location = New System.Drawing.Point(146, 193)
        Me.cmbTujuan.Name = "cmbTujuan"
        Me.cmbTujuan.Size = New System.Drawing.Size(215, 28)
        Me.cmbTujuan.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 18)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Ditujukan Kepada"
        '
        'cmdInputPeriode
        '
        Me.cmdInputPeriode.AnimationHoverSpeed = 0.07!
        Me.cmdInputPeriode.AnimationSpeed = 0.03!
        Me.cmdInputPeriode.BackColor = System.Drawing.Color.Transparent
        Me.cmdInputPeriode.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdInputPeriode.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdInputPeriode.BorderColor = System.Drawing.Color.Black
        Me.cmdInputPeriode.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdInputPeriode.FocusedColor = System.Drawing.Color.Empty
        Me.cmdInputPeriode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInputPeriode.ForeColor = System.Drawing.Color.White
        Me.cmdInputPeriode.Image = Nothing
        Me.cmdInputPeriode.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdInputPeriode.Location = New System.Drawing.Point(146, 231)
        Me.cmdInputPeriode.Name = "cmdInputPeriode"
        Me.cmdInputPeriode.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdInputPeriode.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdInputPeriode.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdInputPeriode.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdInputPeriode.OnHoverImage = Nothing
        Me.cmdInputPeriode.OnPressedColor = System.Drawing.Color.Black
        Me.cmdInputPeriode.Radius = 2
        Me.cmdInputPeriode.Size = New System.Drawing.Size(215, 28)
        Me.cmdInputPeriode.TabIndex = 43
        Me.cmdInputPeriode.Text = "Input Periode"
        Me.cmdInputPeriode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Periode"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(3, 113)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(369, 11)
        Me.GunaLinePanel1.TabIndex = 41
        '
        'cmbCabang
        '
        Me.cmbCabang.BackColor = System.Drawing.Color.Transparent
        Me.cmbCabang.BaseColor = System.Drawing.Color.White
        Me.cmbCabang.BorderColor = System.Drawing.Color.Silver
        Me.cmbCabang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCabang.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCabang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCabang.ForeColor = System.Drawing.Color.Black
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Items.AddRange(New Object() {"OPEN PERIODE", "CLOSING PERIODE"})
        Me.cmbCabang.Location = New System.Drawing.Point(146, 129)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCabang.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCabang.Size = New System.Drawing.Size(215, 26)
        Me.cmbCabang.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Cabang/ Lokasi"
        '
        'GunaGradientButton2
        '
        Me.GunaGradientButton2.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton2.AnimationSpeed = 0.03!
        Me.GunaGradientButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.GunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GunaGradientButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(278, 159)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(83, 30)
        Me.GunaGradientButton2.TabIndex = 38
        Me.GunaGradientButton2.Text = "Browse"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtKomponen.Location = New System.Drawing.Point(146, 160)
        Me.txtKomponen.Name = "txtKomponen"
        Me.txtKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKomponen.Size = New System.Drawing.Size(126, 26)
        Me.txtKomponen.TabIndex = 16
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
        Me.txtNamaSupervisor.Location = New System.Drawing.Point(146, 80)
        Me.txtNamaSupervisor.Name = "txtNamaSupervisor"
        Me.txtNamaSupervisor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaSupervisor.Size = New System.Drawing.Size(215, 30)
        Me.txtNamaSupervisor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Supervisor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Komponen SAP"
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
        Me.txtDivisi.Location = New System.Drawing.Point(146, 45)
        Me.txtDivisi.Name = "txtDivisi"
        Me.txtDivisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDivisi.Size = New System.Drawing.Size(215, 30)
        Me.txtDivisi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Divisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 14)
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
        Me.txtNamaLengkap.Location = New System.Drawing.Point(146, 11)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaLengkap.Size = New System.Drawing.Size(215, 30)
        Me.txtNamaLengkap.TabIndex = 0
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
        Me.cmdBrowseAttatchment.Location = New System.Drawing.Point(268, 171)
        Me.cmdBrowseAttatchment.Name = "cmdBrowseAttatchment"
        Me.cmdBrowseAttatchment.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdBrowseAttatchment.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBrowseAttatchment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdBrowseAttatchment.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdBrowseAttatchment.OnHoverImage = Nothing
        Me.cmdBrowseAttatchment.OnPressedColor = System.Drawing.Color.Black
        Me.cmdBrowseAttatchment.Radius = 2
        Me.cmdBrowseAttatchment.Size = New System.Drawing.Size(100, 30)
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
        Me.txtPathAttachments.Location = New System.Drawing.Point(124, 172)
        Me.txtPathAttachments.Name = "txtPathAttachments"
        Me.txtPathAttachments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathAttachments.Size = New System.Drawing.Size(138, 30)
        Me.txtPathAttachments.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Lampiran"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(122, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "(Deskripsikan Kebutuhan, Seperti No Dokumen dll)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Catatan User"
        '
        'txtPesan
        '
        Me.txtPesan.Location = New System.Drawing.Point(125, 35)
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.Size = New System.Drawing.Size(244, 130)
        Me.txtPesan.TabIndex = 12
        Me.txtPesan.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.JamAkhir)
        Me.GroupBox4.Controls.Add(Me.JamAwal)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.GunaGradientButton1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtPathAttachments)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.cmdBrowseAttatchment)
        Me.GroupBox4.Controls.Add(Me.txtPesan)
        Me.GroupBox4.Location = New System.Drawing.Point(383, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(378, 410)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'JamAkhir
        '
        Me.JamAkhir.CustomFormat = "H:mm"
        Me.JamAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JamAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamAkhir.Location = New System.Drawing.Point(125, 245)
        Me.JamAkhir.Name = "JamAkhir"
        Me.JamAkhir.Size = New System.Drawing.Size(243, 26)
        Me.JamAkhir.TabIndex = 41
        '
        'JamAwal
        '
        Me.JamAwal.CustomFormat = ""
        Me.JamAwal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.JamAwal.Location = New System.Drawing.Point(255, 286)
        Me.JamAwal.Name = "JamAwal"
        Me.JamAwal.Size = New System.Drawing.Size(114, 20)
        Me.JamAwal.TabIndex = 40
        Me.JamAwal.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Sampai Dengan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Durasi"
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(6, 308)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(363, 96)
        Me.GunaGradientButton1.TabIndex = 36
        Me.GunaGradientButton1.Text = "Kirim Permintaan"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgDaftarPeriode
        '
        Me.dgDaftarPeriode.AllowUserToAddRows = False
        Me.dgDaftarPeriode.AllowUserToDeleteRows = False
        Me.dgDaftarPeriode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarPeriode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AbsEntry, Me.Periode, Me.Status})
        Me.dgDaftarPeriode.Location = New System.Drawing.Point(5, 347)
        Me.dgDaftarPeriode.Name = "dgDaftarPeriode"
        Me.dgDaftarPeriode.ReadOnly = True
        Me.dgDaftarPeriode.RowHeadersVisible = False
        Me.dgDaftarPeriode.Size = New System.Drawing.Size(281, 122)
        Me.dgDaftarPeriode.TabIndex = 4
        '
        'AbsEntry
        '
        Me.AbsEntry.HeaderText = "AbsEntry"
        Me.AbsEntry.Name = "AbsEntry"
        Me.AbsEntry.ReadOnly = True
        '
        'Periode
        '
        Me.Periode.HeaderText = "Periode"
        Me.Periode.Name = "Periode"
        Me.Periode.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(294, 347)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(83, 122)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "Hapus"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'lblJumlahPeriode
        '
        Me.lblJumlahPeriode.AutoSize = True
        Me.lblJumlahPeriode.Location = New System.Drawing.Point(5, 471)
        Me.lblJumlahPeriode.Name = "lblJumlahPeriode"
        Me.lblJumlahPeriode.Size = New System.Drawing.Size(94, 13)
        Me.lblJumlahPeriode.TabIndex = 6
        Me.lblJumlahPeriode.Text = "Jumlah Periode : 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImage = Global.AnyarGadget.My.Resources.Resources.Vector_2
        Me.GroupBox1.Controls.Add(Me.txtKodeKomponen)
        Me.GroupBox1.Controls.Add(Me.txtNoValidasi)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 66)
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
        Me.txtNoValidasi.Location = New System.Drawing.Point(648, 11)
        Me.txtNoValidasi.Name = "txtNoValidasi"
        Me.txtNoValidasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoValidasi.Size = New System.Drawing.Size(73, 30)
        Me.txtNoValidasi.TabIndex = 2
        Me.txtNoValidasi.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblKdJenisSurat)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(58, 53)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblKdJenisSurat
        '
        Me.lblKdJenisSurat.AutoSize = True
        Me.lblKdJenisSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdJenisSurat.Location = New System.Drawing.Point(7, 23)
        Me.lblKdJenisSurat.Name = "lblKdJenisSurat"
        Me.lblKdJenisSurat.Size = New System.Drawing.Size(40, 13)
        Me.lblKdJenisSurat.TabIndex = 0
        Me.lblKdJenisSurat.Text = "IT005"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OPEN DAN CLOSING PERIODE"
        '
        'OpenDanClosingPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(763, 487)
        Me.Controls.Add(Me.lblJumlahPeriode)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.dgDaftarPeriode)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "OpenDanClosingPeriode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormValidasi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgDaftarPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPesan As System.Windows.Forms.RichTextBox
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblKdJenisSurat As System.Windows.Forms.Label
    Friend WithEvents txtNoValidasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtKodeKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdBrowseAttatchment As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPathAttachments As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmdInputPeriode As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents dgDaftarPeriode As System.Windows.Forms.DataGridView
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents lblJumlahPeriode As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents JamAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AbsEntry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JamAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbTujuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
