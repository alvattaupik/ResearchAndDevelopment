<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserLogin
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeUser = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdSource1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaLengkap = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaSPV = New Guna.UI.WinForms.GunaTextBox()
        Me.txtKodeSPV = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdSource2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txtusername = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdNew = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdSave = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCariUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgDaftarUserAplikasi = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmbDivisi = New System.Windows.Forms.ComboBox()
        Me.cmbLevelUser = New System.Windows.Forms.ComboBox()
        Me.txtNamaDivisi = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaGradientButton2 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDaftarUserAplikasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(765, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 36)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login Aplikasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode User"
        '
        'txtKodeUser
        '
        Me.txtKodeUser.BaseColor = System.Drawing.Color.White
        Me.txtKodeUser.BorderColor = System.Drawing.Color.Silver
        Me.txtKodeUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKodeUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKodeUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKodeUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeUser.Location = New System.Drawing.Point(133, 61)
        Me.txtKodeUser.Name = "txtKodeUser"
        Me.txtKodeUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeUser.Size = New System.Drawing.Size(179, 28)
        Me.txtKodeUser.TabIndex = 2
        '
        'cmdSource1
        '
        Me.cmdSource1.Location = New System.Drawing.Point(318, 62)
        Me.cmdSource1.Name = "cmdSource1"
        Me.cmdSource1.Size = New System.Drawing.Size(69, 56)
        Me.cmdSource1.TabIndex = 3
        Me.cmdSource1.Text = "Ambil Dari SAP"
        Me.cmdSource1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Lengkap"
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.BaseColor = System.Drawing.Color.White
        Me.txtNamaLengkap.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaLengkap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaLengkap.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaLengkap.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaLengkap.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaLengkap.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaLengkap.Location = New System.Drawing.Point(133, 95)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaLengkap.Size = New System.Drawing.Size(179, 28)
        Me.txtNamaLengkap.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(445, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Level User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Divisi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(445, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SPV"
        '
        'txtNamaSPV
        '
        Me.txtNamaSPV.BaseColor = System.Drawing.Color.White
        Me.txtNamaSPV.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaSPV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaSPV.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaSPV.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaSPV.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaSPV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSPV.Location = New System.Drawing.Point(573, 90)
        Me.txtNamaSPV.Name = "txtNamaSPV"
        Me.txtNamaSPV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaSPV.Size = New System.Drawing.Size(139, 28)
        Me.txtNamaSPV.TabIndex = 11
        '
        'txtKodeSPV
        '
        Me.txtKodeSPV.BaseColor = System.Drawing.Color.White
        Me.txtKodeSPV.BorderColor = System.Drawing.Color.Silver
        Me.txtKodeSPV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeSPV.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKodeSPV.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKodeSPV.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKodeSPV.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeSPV.Location = New System.Drawing.Point(489, 90)
        Me.txtKodeSPV.Name = "txtKodeSPV"
        Me.txtKodeSPV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeSPV.Size = New System.Drawing.Size(78, 28)
        Me.txtKodeSPV.TabIndex = 12
        '
        'cmdSource2
        '
        Me.cmdSource2.Location = New System.Drawing.Point(739, 51)
        Me.cmdSource2.Name = "cmdSource2"
        Me.cmdSource2.Size = New System.Drawing.Size(71, 60)
        Me.cmdSource2.TabIndex = 13
        Me.cmdSource2.Text = "Ambil Dari SAP"
        Me.cmdSource2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAktif)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtusername)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 105)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Username dan Password"
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAktif.Location = New System.Drawing.Point(127, 77)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(60, 22)
        Me.chkAktif.TabIndex = 9
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Password Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Username Login"
        '
        'txtPassword
        '
        Me.txtPassword.BaseColor = System.Drawing.Color.White
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(127, 49)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.Size = New System.Drawing.Size(216, 28)
        Me.txtPassword.TabIndex = 6
        '
        'txtusername
        '
        Me.txtusername.BaseColor = System.Drawing.Color.White
        Me.txtusername.BorderColor = System.Drawing.Color.Silver
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(127, 19)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.Size = New System.Drawing.Size(216, 28)
        Me.txtusername.TabIndex = 3
        '
        'cmdNew
        '
        Me.cmdNew.AnimationHoverSpeed = 0.07!
        Me.cmdNew.AnimationSpeed = 0.03!
        Me.cmdNew.BackColor = System.Drawing.Color.Transparent
        Me.cmdNew.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdNew.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdNew.BorderColor = System.Drawing.Color.Black
        Me.cmdNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdNew.FocusedColor = System.Drawing.Color.Empty
        Me.cmdNew.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.Image = Nothing
        Me.cmdNew.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdNew.Location = New System.Drawing.Point(6, 273)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdNew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdNew.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdNew.OnHoverImage = Nothing
        Me.cmdNew.OnPressedColor = System.Drawing.Color.Black
        Me.cmdNew.Radius = 2
        Me.cmdNew.Size = New System.Drawing.Size(84, 50)
        Me.cmdNew.TabIndex = 36
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSave
        '
        Me.cmdSave.AnimationHoverSpeed = 0.07!
        Me.cmdSave.AnimationSpeed = 0.03!
        Me.cmdSave.BackColor = System.Drawing.Color.Transparent
        Me.cmdSave.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSave.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSave.BorderColor = System.Drawing.Color.Black
        Me.cmdSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSave.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = Nothing
        Me.cmdSave.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSave.Location = New System.Drawing.Point(96, 273)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSave.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSave.OnHoverImage = Nothing
        Me.cmdSave.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSave.Radius = 2
        Me.cmdSave.Size = New System.Drawing.Size(82, 50)
        Me.cmdSave.TabIndex = 37
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCariUser)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dgDaftarUserAplikasi)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 206)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data User"
        '
        'txtCariUser
        '
        Me.txtCariUser.BaseColor = System.Drawing.Color.White
        Me.txtCariUser.BorderColor = System.Drawing.Color.Silver
        Me.txtCariUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCariUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCariUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCariUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCariUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariUser.Location = New System.Drawing.Point(122, 19)
        Me.txtCariUser.Name = "txtCariUser"
        Me.txtCariUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCariUser.Size = New System.Drawing.Size(234, 28)
        Me.txtCariUser.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Cari User"
        '
        'dgDaftarUserAplikasi
        '
        Me.dgDaftarUserAplikasi.AllowUserToAddRows = False
        Me.dgDaftarUserAplikasi.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserAplikasi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDaftarUserAplikasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarUserAplikasi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgDaftarUserAplikasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarUserAplikasi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserAplikasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserAplikasi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDaftarUserAplikasi.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarUserAplikasi.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgDaftarUserAplikasi.EnableHeadersVisualStyles = False
        Me.dgDaftarUserAplikasi.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserAplikasi.Location = New System.Drawing.Point(8, 54)
        Me.dgDaftarUserAplikasi.Name = "dgDaftarUserAplikasi"
        Me.dgDaftarUserAplikasi.ReadOnly = True
        Me.dgDaftarUserAplikasi.RowHeadersVisible = False
        Me.dgDaftarUserAplikasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarUserAplikasi.Size = New System.Drawing.Size(351, 145)
        Me.dgDaftarUserAplikasi.TabIndex = 0
        Me.dgDaftarUserAplikasi.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgDaftarUserAplikasi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserAplikasi.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgDaftarUserAplikasi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserAplikasi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgDaftarUserAplikasi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserAplikasi.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgDaftarUserAplikasi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgDaftarUserAplikasi.ThemeStyle.HeaderStyle.Height = 30
        Me.dgDaftarUserAplikasi.ThemeStyle.ReadOnly = True
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.Height = 22
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserAplikasi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.Red
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(184, 273)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.Red
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(84, 50)
        Me.GunaGradientButton1.TabIndex = 39
        Me.GunaGradientButton1.Text = "Close"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDivisi
        '
        Me.cmbDivisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDivisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDivisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivisi.FormattingEnabled = True
        Me.cmbDivisi.Location = New System.Drawing.Point(133, 126)
        Me.cmbDivisi.Name = "cmbDivisi"
        Me.cmbDivisi.Size = New System.Drawing.Size(179, 26)
        Me.cmbDivisi.TabIndex = 40
        '
        'cmbLevelUser
        '
        Me.cmbLevelUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbLevelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLevelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevelUser.FormattingEnabled = True
        Me.cmbLevelUser.Items.AddRange(New Object() {"STAFF", "SPV", "MANAGEMENT"})
        Me.cmbLevelUser.Location = New System.Drawing.Point(570, 58)
        Me.cmbLevelUser.Name = "cmbLevelUser"
        Me.cmbLevelUser.Size = New System.Drawing.Size(142, 26)
        Me.cmbLevelUser.TabIndex = 41
        '
        'txtNamaDivisi
        '
        Me.txtNamaDivisi.BaseColor = System.Drawing.Color.White
        Me.txtNamaDivisi.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaDivisi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaDivisi.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaDivisi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaDivisi.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaDivisi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDivisi.Location = New System.Drawing.Point(318, 124)
        Me.txtNamaDivisi.Name = "txtNamaDivisi"
        Me.txtNamaDivisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaDivisi.Size = New System.Drawing.Size(56, 28)
        Me.txtNamaDivisi.TabIndex = 43
        Me.txtNamaDivisi.Visible = False
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
        Me.GunaGradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaGradientButton2.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.Image = Nothing
        Me.GunaGradientButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton2.Location = New System.Drawing.Point(274, 273)
        Me.GunaGradientButton2.Name = "GunaGradientButton2"
        Me.GunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton2.OnHoverImage = Nothing
        Me.GunaGradientButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton2.Radius = 2
        Me.GunaGradientButton2.Size = New System.Drawing.Size(84, 50)
        Me.GunaGradientButton2.TabIndex = 44
        Me.GunaGradientButton2.Text = "Hak Akses"
        Me.GunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(819, 333)
        Me.Controls.Add(Me.GunaGradientButton2)
        Me.Controls.Add(Me.txtNamaDivisi)
        Me.Controls.Add(Me.cmbLevelUser)
        Me.Controls.Add(Me.cmbDivisi)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSource2)
        Me.Controls.Add(Me.txtKodeSPV)
        Me.Controls.Add(Me.txtNamaSPV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaLengkap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSource1)
        Me.Controls.Add(Me.txtKodeUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUserLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgDaftarUserAplikasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdSource1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLengkap As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSPV As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtKodeSPV As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdSource2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdNew As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdSave As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDaftarUserAplikasi As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCariUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLevelUser As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaDivisi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents GunaGradientButton2 As Guna.UI.WinForms.GunaGradientButton
End Class
