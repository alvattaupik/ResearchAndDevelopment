﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesCloseAndCancelDocuments
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtJenisForm = New Guna.UI.WinForms.GunaTextBox()
        Me.txtStatusApproval = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumlahDokumen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStatusProses = New Guna.UI.WinForms.GunaTextBox()
        Me.txtTanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblJumlahUserApproved = New System.Windows.Forms.Label()
        Me.dgDaftarUserApproval = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPesanAdmin = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdCetak = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJenisRequest = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNoDokumen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtPathAttachment = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPesanUser = New System.Windows.Forms.RichTextBox()
        Me.cmdLihatAttchment = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCabang = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New Guna.UI.WinForms.GunaComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmdSimpanProses = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtJenisForm)
        Me.Panel1.Controls.Add(Me.txtStatusApproval)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 89)
        Me.Panel1.TabIndex = 68
        '
        'txtJenisForm
        '
        Me.txtJenisForm.BaseColor = System.Drawing.Color.White
        Me.txtJenisForm.BorderColor = System.Drawing.Color.White
        Me.txtJenisForm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJenisForm.Enabled = False
        Me.txtJenisForm.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJenisForm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJenisForm.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJenisForm.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJenisForm.Location = New System.Drawing.Point(5, 47)
        Me.txtJenisForm.Name = "txtJenisForm"
        Me.txtJenisForm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisForm.Size = New System.Drawing.Size(693, 36)
        Me.txtJenisForm.TabIndex = 27
        Me.txtJenisForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatusApproval
        '
        Me.txtStatusApproval.BackColor = System.Drawing.Color.Orchid
        Me.txtStatusApproval.BaseColor = System.Drawing.Color.White
        Me.txtStatusApproval.BorderColor = System.Drawing.Color.White
        Me.txtStatusApproval.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatusApproval.Enabled = False
        Me.txtStatusApproval.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStatusApproval.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatusApproval.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStatusApproval.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusApproval.Location = New System.Drawing.Point(344, 6)
        Me.txtStatusApproval.Name = "txtStatusApproval"
        Me.txtStatusApproval.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatusApproval.Size = New System.Drawing.Size(400, 38)
        Me.txtStatusApproval.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Detail My Request"
        '
        'txtJumlahDokumen
        '
        Me.txtJumlahDokumen.BaseColor = System.Drawing.Color.White
        Me.txtJumlahDokumen.BorderColor = System.Drawing.Color.Silver
        Me.txtJumlahDokumen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJumlahDokumen.Enabled = False
        Me.txtJumlahDokumen.FocusedBaseColor = System.Drawing.Color.White
        Me.txtJumlahDokumen.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJumlahDokumen.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtJumlahDokumen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJumlahDokumen.Location = New System.Drawing.Point(4, 135)
        Me.txtJumlahDokumen.Name = "txtJumlahDokumen"
        Me.txtJumlahDokumen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlahDokumen.Size = New System.Drawing.Size(321, 32)
        Me.txtJumlahDokumen.TabIndex = 14
        Me.txtJumlahDokumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jumlah Dokumen"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(3, 97)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(322, 10)
        Me.GunaLinePanel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal"
        '
        'txtStatusProses
        '
        Me.txtStatusProses.BaseColor = System.Drawing.Color.White
        Me.txtStatusProses.BorderColor = System.Drawing.Color.Silver
        Me.txtStatusProses.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatusProses.Enabled = False
        Me.txtStatusProses.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStatusProses.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatusProses.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStatusProses.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStatusProses.Location = New System.Drawing.Point(6, 192)
        Me.txtStatusProses.Name = "txtStatusProses"
        Me.txtStatusProses.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatusProses.Size = New System.Drawing.Size(319, 32)
        Me.txtStatusProses.TabIndex = 8
        Me.txtStatusProses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtTanggal.Location = New System.Drawing.Point(69, 36)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTanggal.Size = New System.Drawing.Size(256, 26)
        Me.txtTanggal.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblJumlahUserApproved)
        Me.Panel2.Controls.Add(Me.dgDaftarUserApproval)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(3, 361)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 224)
        Me.Panel2.TabIndex = 69
        '
        'lblJumlahUserApproved
        '
        Me.lblJumlahUserApproved.AutoSize = True
        Me.lblJumlahUserApproved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUserApproved.Location = New System.Drawing.Point(3, 202)
        Me.lblJumlahUserApproved.Name = "lblJumlahUserApproved"
        Me.lblJumlahUserApproved.Size = New System.Drawing.Size(166, 16)
        Me.lblJumlahUserApproved.TabIndex = 22
        Me.lblJumlahUserApproved.Text = "Jumlah User Approved"
        '
        'dgDaftarUserApproval
        '
        Me.dgDaftarUserApproval.AllowUserToAddRows = False
        Me.dgDaftarUserApproval.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDaftarUserApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarUserApproval.BackgroundColor = System.Drawing.Color.Gray
        Me.dgDaftarUserApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarUserApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarUserApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarUserApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDaftarUserApproval.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarUserApproval.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgDaftarUserApproval.EnableHeadersVisualStyles = False
        Me.dgDaftarUserApproval.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarUserApproval.Location = New System.Drawing.Point(6, 30)
        Me.dgDaftarUserApproval.Name = "dgDaftarUserApproval"
        Me.dgDaftarUserApproval.ReadOnly = True
        Me.dgDaftarUserApproval.RowHeadersVisible = False
        Me.dgDaftarUserApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarUserApproval.Size = New System.Drawing.Size(310, 169)
        Me.dgDaftarUserApproval.TabIndex = 21
        Me.dgDaftarUserApproval.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgDaftarUserApproval.ThemeStyle.BackColor = System.Drawing.Color.Gray
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Daftar Persetujuan"
        '
        'txtPesanAdmin
        '
        Me.txtPesanAdmin.Location = New System.Drawing.Point(347, 379)
        Me.txtPesanAdmin.Name = "txtPesanAdmin"
        Me.txtPesanAdmin.Size = New System.Drawing.Size(406, 69)
        Me.txtPesanAdmin.TabIndex = 73
        Me.txtPesanAdmin.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(414, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(287, 18)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Catatan IT Department/ Administrator"
        '
        'cmdCetak
        '
        Me.cmdCetak.AnimationHoverSpeed = 0.07!
        Me.cmdCetak.AnimationSpeed = 0.03!
        Me.cmdCetak.BackColor = System.Drawing.Color.Transparent
        Me.cmdCetak.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdCetak.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdCetak.BorderColor = System.Drawing.Color.Black
        Me.cmdCetak.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdCetak.FocusedColor = System.Drawing.Color.Empty
        Me.cmdCetak.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdCetak.ForeColor = System.Drawing.Color.White
        Me.cmdCetak.Image = Nothing
        Me.cmdCetak.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdCetak.Location = New System.Drawing.Point(562, 500)
        Me.cmdCetak.Name = "cmdCetak"
        Me.cmdCetak.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCetak.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCetak.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCetak.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCetak.OnHoverImage = Nothing
        Me.cmdCetak.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCetak.Radius = 2
        Me.cmdCetak.Size = New System.Drawing.Size(191, 40)
        Me.cmdCetak.TabIndex = 70
        Me.cmdCetak.Text = "Cetak"
        Me.cmdCetak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis"
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
        Me.txtJenisRequest.Location = New System.Drawing.Point(69, 66)
        Me.txtJenisRequest.Name = "txtJenisRequest"
        Me.txtJenisRequest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenisRequest.Size = New System.Drawing.Size(256, 26)
        Me.txtJenisRequest.TabIndex = 3
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
        Me.txtNoDokumen.Location = New System.Drawing.Point(69, 6)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoDokumen.Size = New System.Drawing.Size(256, 26)
        Me.txtNoDokumen.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nomor"
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(349, 546)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Radius = 2
        Me.GunaGradientButton1.Size = New System.Drawing.Size(404, 40)
        Me.GunaGradientButton1.TabIndex = 71
        Me.GunaGradientButton1.Text = "Tutup"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtPathAttachment.Location = New System.Drawing.Point(647, 85)
        Me.txtPathAttachment.Name = "txtPathAttachment"
        Me.txtPathAttachment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPathAttachment.Size = New System.Drawing.Size(88, 26)
        Me.txtPathAttachment.TabIndex = 67
        Me.txtPathAttachment.Visible = False
        '
        'txtPesanUser
        '
        Me.txtPesanUser.Location = New System.Drawing.Point(344, 114)
        Me.txtPesanUser.Name = "txtPesanUser"
        Me.txtPesanUser.Size = New System.Drawing.Size(400, 72)
        Me.txtPesanUser.TabIndex = 66
        Me.txtPesanUser.Text = ""
        '
        'cmdLihatAttchment
        '
        Me.cmdLihatAttchment.BackColor = System.Drawing.Color.Gray
        Me.cmdLihatAttchment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLihatAttchment.Location = New System.Drawing.Point(344, 199)
        Me.cmdLihatAttchment.Name = "cmdLihatAttchment"
        Me.cmdLihatAttchment.Size = New System.Drawing.Size(400, 44)
        Me.cmdLihatAttchment.TabIndex = 65
        Me.cmdLihatAttchment.Text = "Lihat Lampiran"
        Me.cmdLihatAttchment.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(506, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 18)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Catatan User"
        '
        'txtCabang
        '
        Me.txtCabang.BaseColor = System.Drawing.Color.White
        Me.txtCabang.BorderColor = System.Drawing.Color.Silver
        Me.txtCabang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCabang.Enabled = False
        Me.txtCabang.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCabang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCabang.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCabang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCabang.Location = New System.Drawing.Point(436, 54)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCabang.Size = New System.Drawing.Size(308, 26)
        Me.txtCabang.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Cabang"
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
        Me.txtKomponen.Location = New System.Drawing.Point(436, 18)
        Me.txtKomponen.Name = "txtKomponen"
        Me.txtKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKomponen.Size = New System.Drawing.Size(308, 26)
        Me.txtKomponen.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(341, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Komponen"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtJumlahDokumen)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.GunaLinePanel1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtStatusProses)
        Me.Panel3.Controls.Add(Me.txtTanggal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtJenisRequest)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtNoDokumen)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(7, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(328, 235)
        Me.Panel3.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(96, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 18)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Status Proses"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtPathAttachment)
        Me.GroupBox2.Controls.Add(Me.txtPesanUser)
        Me.GroupBox2.Controls.Add(Me.cmdLihatAttchment)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCabang)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtKomponen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 261)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
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
        Me.cmbStatus.Location = New System.Drawing.Point(417, 460)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbStatus.Size = New System.Drawing.Size(336, 26)
        Me.cmbStatus.TabIndex = 85
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(343, 462)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 20)
        Me.Label20.TabIndex = 84
        Me.Label20.Text = "Status"
        '
        'cmdSimpanProses
        '
        Me.cmdSimpanProses.AnimationHoverSpeed = 0.07!
        Me.cmdSimpanProses.AnimationSpeed = 0.03!
        Me.cmdSimpanProses.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpanProses.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpanProses.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpanProses.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpanProses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpanProses.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpanProses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpanProses.ForeColor = System.Drawing.Color.White
        Me.cmdSimpanProses.Image = Nothing
        Me.cmdSimpanProses.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpanProses.Location = New System.Drawing.Point(349, 500)
        Me.cmdSimpanProses.Name = "cmdSimpanProses"
        Me.cmdSimpanProses.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpanProses.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpanProses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpanProses.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpanProses.OnHoverImage = Nothing
        Me.cmdSimpanProses.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpanProses.Radius = 2
        Me.cmdSimpanProses.Size = New System.Drawing.Size(179, 40)
        Me.cmdSimpanProses.TabIndex = 86
        Me.cmdSimpanProses.Text = "Simpan"
        Me.cmdSimpanProses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormProsesCloseAndCancelDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 588)
        Me.Controls.Add(Me.cmdSimpanProses)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtPesanAdmin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdCetak)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormProsesCloseAndCancelDocuments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProsesCloseAndCancelDocuments"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgDaftarUserApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtJenisForm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtStatusApproval As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahDokumen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStatusProses As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtTanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJumlahUserApproved As System.Windows.Forms.Label
    Friend WithEvents dgDaftarUserApproval As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPesanAdmin As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdCetak As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJenisRequest As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNoDokumen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPathAttachment As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtPesanUser As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdLihatAttchment As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCabang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpanProses As Guna.UI.WinForms.GunaGradientButton
End Class