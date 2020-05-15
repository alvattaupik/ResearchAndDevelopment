<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetaiMyRequestCloseCancelDocument
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdLihatAttchment = New System.Windows.Forms.Button()
        Me.txtPesanUser = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStatus = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoDokumen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtErrorvalidasi = New System.Windows.Forms.RichTextBox()
        Me.txtJenisValidasi = New Guna.UI.WinForms.GunaTextBox()
        Me.txtTanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJenisRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahUserApproved = New System.Windows.Forms.Label()
        Me.dgDaftarUserApproval = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPesanAdmin = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtJenisForm = New Guna.UI.WinForms.GunaTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPathAttachment = New Guna.UI.WinForms.GunaTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStatusRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cmdLihatAttchment)
        Me.GroupBox2.Controls.Add(Me.txtPesanUser)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtNoDokumen)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtJenisValidasi)
        Me.GroupBox2.Controls.Add(Me.txtTanggal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtJenisRequest)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtKomponen)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 197)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdLihatAttchment
        '
        Me.cmdLihatAttchment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLihatAttchment.Location = New System.Drawing.Point(449, 108)
        Me.cmdLihatAttchment.Name = "cmdLihatAttchment"
        Me.cmdLihatAttchment.Size = New System.Drawing.Size(98, 81)
        Me.cmdLihatAttchment.TabIndex = 16
        Me.cmdLihatAttchment.Text = "Lihat Attachment"
        Me.cmdLihatAttchment.UseVisualStyleBackColor = True
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
        Me.txtPesanUser.Location = New System.Drawing.Point(145, 109)
        Me.txtPesanUser.Name = "txtPesanUser"
        Me.txtPesanUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPesanUser.Size = New System.Drawing.Size(293, 80)
        Me.txtPesanUser.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pesan Saya"
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
        Me.txtStatus.Location = New System.Drawing.Point(145, 19)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.Size = New System.Drawing.Size(162, 26)
        Me.txtStatus.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Status Approval"
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
        Me.txtNoDokumen.Location = New System.Drawing.Point(145, 45)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoDokumen.Size = New System.Drawing.Size(162, 26)
        Me.txtNoDokumen.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nomor Dokumen"
        '
        'txtErrorvalidasi
        '
        Me.txtErrorvalidasi.Enabled = False
        Me.txtErrorvalidasi.Location = New System.Drawing.Point(72, 0)
        Me.txtErrorvalidasi.Name = "txtErrorvalidasi"
        Me.txtErrorvalidasi.Size = New System.Drawing.Size(74, 24)
        Me.txtErrorvalidasi.TabIndex = 9
        Me.txtErrorvalidasi.Text = ""
        Me.txtErrorvalidasi.Visible = False
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
        Me.txtJenisValidasi.Location = New System.Drawing.Point(145, 108)
        Me.txtJenisValidasi.Name = "txtJenisValidasi"
        Me.txtJenisValidasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisValidasi.Size = New System.Drawing.Size(404, 26)
        Me.txtJenisValidasi.TabIndex = 7
        Me.txtJenisValidasi.Visible = False
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
        Me.txtTanggal.Location = New System.Drawing.Point(387, 13)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTanggal.Size = New System.Drawing.Size(162, 26)
        Me.txtTanggal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 15)
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
        Me.txtJenisRequest.Location = New System.Drawing.Point(146, 12)
        Me.txtJenisRequest.Name = "txtJenisRequest"
        Me.txtJenisRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisRequest.Size = New System.Drawing.Size(162, 26)
        Me.txtJenisRequest.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 14)
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
        Me.txtKomponen.Size = New System.Drawing.Size(403, 26)
        Me.txtKomponen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Komponen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblJumlahUserApproved)
        Me.GroupBox3.Controls.Add(Me.dgDaftarUserApproval)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtStatus)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 249)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lblJumlahUserApproved
        '
        Me.lblJumlahUserApproved.AutoSize = True
        Me.lblJumlahUserApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUserApproved.Location = New System.Drawing.Point(4, 227)
        Me.lblJumlahUserApproved.Name = "lblJumlahUserApproved"
        Me.lblJumlahUserApproved.Size = New System.Drawing.Size(166, 16)
        Me.lblJumlahUserApproved.TabIndex = 17
        Me.lblJumlahUserApproved.Text = "Jumlah User Approved"
        '
        'dgDaftarUserApproval
        '
        Me.dgDaftarUserApproval.AllowUserToAddRows = False
        Me.dgDaftarUserApproval.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDaftarUserApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarUserApproval.BackgroundColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarUserApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDaftarUserApproval.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarUserApproval.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDaftarUserApproval.EnableHeadersVisualStyles = False
        Me.dgDaftarUserApproval.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.Location = New System.Drawing.Point(7, 90)
        Me.dgDaftarUserApproval.Name = "dgDaftarUserApproval"
        Me.dgDaftarUserApproval.ReadOnly = True
        Me.dgDaftarUserApproval.RowHeadersVisible = False
        Me.dgDaftarUserApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarUserApproval.Size = New System.Drawing.Size(296, 134)
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
        Me.Label10.Location = New System.Drawing.Point(79, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 18)
        Me.Label10.TabIndex = 15
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
        Me.cmdSimpan.Location = New System.Drawing.Point(338, 494)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(225, 26)
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(338, 526)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(225, 26)
        Me.GunaGradientButton1.TabIndex = 41
        Me.GunaGradientButton1.Text = "Tutup"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(374, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 18)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Catatan Administrator"
        '
        'txtPesanAdmin
        '
        Me.txtPesanAdmin.Enabled = False
        Me.txtPesanAdmin.Location = New System.Drawing.Point(338, 324)
        Me.txtPesanAdmin.Name = "txtPesanAdmin"
        Me.txtPesanAdmin.Size = New System.Drawing.Size(225, 164)
        Me.txtPesanAdmin.TabIndex = 43
        Me.txtPesanAdmin.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtStatusRequest)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtJenisForm)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtPathAttachment)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtErrorvalidasi)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(10, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 89)
        Me.Panel1.TabIndex = 44
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
        Me.txtJenisForm.Location = New System.Drawing.Point(146, 25)
        Me.txtJenisForm.Name = "txtJenisForm"
        Me.txtJenisForm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisForm.Size = New System.Drawing.Size(342, 26)
        Me.txtJenisForm.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Jenis Form"
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
        Me.txtPathAttachment.Location = New System.Drawing.Point(12, 1)
        Me.txtPathAttachment.Name = "txtPathAttachment"
        Me.txtPathAttachment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathAttachment.Size = New System.Drawing.Size(28, 26)
        Me.txtPathAttachment.TabIndex = 11
        Me.txtPathAttachment.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(515, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Detail My Request"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Error Dari Validasi"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jenis Validasi"
        Me.Label5.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Status Request"
        '
        'txtStatusRequest
        '
        Me.txtStatusRequest.BaseColor = System.Drawing.Color.White
        Me.txtStatusRequest.BorderColor = System.Drawing.Color.Silver
        Me.txtStatusRequest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatusRequest.Enabled = False
        Me.txtStatusRequest.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStatusRequest.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatusRequest.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStatusRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatusRequest.Location = New System.Drawing.Point(145, 53)
        Me.txtStatusRequest.Name = "txtStatusRequest"
        Me.txtStatusRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatusRequest.Size = New System.Drawing.Size(342, 26)
        Me.txtStatusRequest.TabIndex = 17
        '
        'FormDetaiMyRequestCloseCancelDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(575, 555)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPesanAdmin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDetaiMyRequestCloseCancelDocument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetailValidasi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoDokumen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtErrorvalidasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtTanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJenisRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPesanUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDaftarUserApproval As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPesanAdmin As System.Windows.Forms.RichTextBox
    Friend WithEvents txtJenisValidasi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblJumlahUserApproved As System.Windows.Forms.Label
    Friend WithEvents cmdLihatAttchment As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtStatusRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtJenisForm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPathAttachment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
