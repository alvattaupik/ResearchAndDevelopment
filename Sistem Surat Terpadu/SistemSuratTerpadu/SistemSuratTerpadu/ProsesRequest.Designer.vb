﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProsesRequest
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCreatedBy = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPesanUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoDokumen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtErrorvalidasi = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJenisValidasi = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJenisRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahUserApproved = New System.Windows.Forms.Label()
        Me.cmdApprove = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgDaftarUserApproval = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdTutup = New Guna.UI.WinForms.GunaGradientButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCatatanAdmin = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbStatus = New Guna.UI.WinForms.GunaComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Red
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(656, 1)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(40, 30)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "X"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Proses Request Fullfilment"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCreatedBy)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtPesanUser)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtStatus)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtNoDokumen)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtErrorvalidasi)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtJenisValidasi)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTanggal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtJenisRequest)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtKomponen)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 306)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.BackColor = System.Drawing.Color.Orchid
        Me.txtCreatedBy.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCreatedBy.BorderColor = System.Drawing.Color.Silver
        Me.txtCreatedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCreatedBy.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreatedBy.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCreatedBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCreatedBy.Location = New System.Drawing.Point(491, 76)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreatedBy.Size = New System.Drawing.Size(177, 26)
        Me.txtCreatedBy.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(394, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Created By"
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
        Me.txtPesanUser.Location = New System.Drawing.Point(145, 196)
        Me.txtPesanUser.Name = "txtPesanUser"
        Me.txtPesanUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPesanUser.Size = New System.Drawing.Size(523, 88)
        Me.txtPesanUser.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pesan User"
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
        Me.txtStatus.Location = New System.Drawing.Point(491, 44)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.Size = New System.Drawing.Size(177, 26)
        Me.txtStatus.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(429, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Status"
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
        Me.txtNoDokumen.Location = New System.Drawing.Point(145, 48)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoDokumen.Size = New System.Drawing.Size(206, 26)
        Me.txtNoDokumen.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nomor Dokumen"
        '
        'txtErrorvalidasi
        '
        Me.txtErrorvalidasi.Enabled = False
        Me.txtErrorvalidasi.Location = New System.Drawing.Point(146, 138)
        Me.txtErrorvalidasi.Name = "txtErrorvalidasi"
        Me.txtErrorvalidasi.Size = New System.Drawing.Size(522, 52)
        Me.txtErrorvalidasi.TabIndex = 9
        Me.txtErrorvalidasi.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Error Dari Validasi"
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
        Me.txtJenisValidasi.Location = New System.Drawing.Point(145, 106)
        Me.txtJenisValidasi.Name = "txtJenisValidasi"
        Me.txtJenisValidasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisValidasi.Size = New System.Drawing.Size(523, 26)
        Me.txtJenisValidasi.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Validasi"
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
        Me.txtTanggal.Location = New System.Drawing.Point(491, 14)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTanggal.Size = New System.Drawing.Size(177, 26)
        Me.txtTanggal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal"
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
        Me.txtJenisRequest.Location = New System.Drawing.Point(146, 20)
        Me.txtJenisRequest.Name = "txtJenisRequest"
        Me.txtJenisRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisRequest.Size = New System.Drawing.Size(205, 26)
        Me.txtJenisRequest.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Request"
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
        Me.txtKomponen.Location = New System.Drawing.Point(145, 77)
        Me.txtKomponen.Name = "txtKomponen"
        Me.txtKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKomponen.Size = New System.Drawing.Size(206, 26)
        Me.txtKomponen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Komponen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblJumlahUserApproved)
        Me.GroupBox1.Controls.Add(Me.cmdApprove)
        Me.GroupBox1.Controls.Add(Me.dgDaftarUserApproval)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 192)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'lblJumlahUserApproved
        '
        Me.lblJumlahUserApproved.AutoSize = True
        Me.lblJumlahUserApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUserApproved.Location = New System.Drawing.Point(0, 173)
        Me.lblJumlahUserApproved.Name = "lblJumlahUserApproved"
        Me.lblJumlahUserApproved.Size = New System.Drawing.Size(166, 16)
        Me.lblJumlahUserApproved.TabIndex = 58
        Me.lblJumlahUserApproved.Text = "Jumlah User Approved"
        '
        'cmdApprove
        '
        Me.cmdApprove.AnimationHoverSpeed = 0.07!
        Me.cmdApprove.AnimationSpeed = 0.03!
        Me.cmdApprove.BackColor = System.Drawing.Color.Transparent
        Me.cmdApprove.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdApprove.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdApprove.BorderColor = System.Drawing.Color.Black
        Me.cmdApprove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdApprove.FocusedColor = System.Drawing.Color.Empty
        Me.cmdApprove.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdApprove.ForeColor = System.Drawing.Color.White
        Me.cmdApprove.Image = Nothing
        Me.cmdApprove.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdApprove.Location = New System.Drawing.Point(186, 165)
        Me.cmdApprove.Name = "cmdApprove"
        Me.cmdApprove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdApprove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdApprove.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdApprove.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdApprove.OnHoverImage = Nothing
        Me.cmdApprove.OnPressedColor = System.Drawing.Color.Black
        Me.cmdApprove.Radius = 2
        Me.cmdApprove.Size = New System.Drawing.Size(75, 27)
        Me.cmdApprove.TabIndex = 61
        Me.cmdApprove.Text = "Approve"
        Me.cmdApprove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgDaftarUserApproval
        '
        Me.dgDaftarUserApproval.AllowUserToAddRows = False
        Me.dgDaftarUserApproval.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDaftarUserApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarUserApproval.BackgroundColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarUserApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDaftarUserApproval.ColumnHeadersHeight = 30
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarUserApproval.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgDaftarUserApproval.EnableHeadersVisualStyles = False
        Me.dgDaftarUserApproval.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.Location = New System.Drawing.Point(6, 21)
        Me.dgDaftarUserApproval.Name = "dgDaftarUserApproval"
        Me.dgDaftarUserApproval.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserApproval.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDaftarUserApproval.RowHeadersVisible = False
        Me.dgDaftarUserApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarUserApproval.Size = New System.Drawing.Size(255, 129)
        Me.dgDaftarUserApproval.TabIndex = 57
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
        Me.Label10.Location = New System.Drawing.Point(-3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 18)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Telah Disetujui Oleh"
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
        Me.cmdSimpan.Location = New System.Drawing.Point(413, 531)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(146, 41)
        Me.cmdSimpan.TabIndex = 59
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdTutup
        '
        Me.cmdTutup.AnimationHoverSpeed = 0.07!
        Me.cmdTutup.AnimationSpeed = 0.03!
        Me.cmdTutup.BackColor = System.Drawing.Color.Transparent
        Me.cmdTutup.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdTutup.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdTutup.BorderColor = System.Drawing.Color.Black
        Me.cmdTutup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdTutup.FocusedColor = System.Drawing.Color.Empty
        Me.cmdTutup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdTutup.ForeColor = System.Drawing.Color.White
        Me.cmdTutup.Image = Nothing
        Me.cmdTutup.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdTutup.Location = New System.Drawing.Point(575, 531)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdTutup.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTutup.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdTutup.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdTutup.OnHoverImage = Nothing
        Me.cmdTutup.OnPressedColor = System.Drawing.Color.Black
        Me.cmdTutup.Radius = 2
        Me.cmdTutup.Size = New System.Drawing.Size(121, 41)
        Me.cmdTutup.TabIndex = 60
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCatatanAdmin)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cmbStatus)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(321, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(372, 142)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        '
        'txtCatatanAdmin
        '
        Me.txtCatatanAdmin.Location = New System.Drawing.Point(91, 41)
        Me.txtCatatanAdmin.Name = "txtCatatanAdmin"
        Me.txtCatatanAdmin.Size = New System.Drawing.Size(268, 88)
        Me.txtCatatanAdmin.TabIndex = 67
        Me.txtCatatanAdmin.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 20)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Catatan"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatus.BaseColor = System.Drawing.Color.White
        Me.cmbStatus.BorderColor = System.Drawing.Color.Silver
        Me.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.Black
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(92, 9)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbStatus.Size = New System.Drawing.Size(268, 26)
        Me.cmbStatus.TabIndex = 65
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 20)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Status"
        '
        'ProsesRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 573)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProsesRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProsesRequest"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesanUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoDokumen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtErrorvalidasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJenisValidasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJenisRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblJumlahUserApproved As System.Windows.Forms.Label
    Friend WithEvents dgDaftarUserApproval As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdTutup As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdApprove As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCatatanAdmin As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedBy As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
