﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidationControls
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.cmdRefreshMaster = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariKontrol = New Guna.UI.WinForms.GunaTextBox()
        Me.cmdNewControl = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgDaftarKontrol = New Guna.UI.WinForms.GunaDataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdRefresh = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgUnlocked = New Guna.UI.WinForms.GunaDataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDaftarKontrol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgUnlocked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 478)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GunaPictureBox1)
        Me.TabPage1.Controls.Add(Me.cmdRefreshMaster)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtCariKontrol)
        Me.TabPage1.Controls.Add(Me.cmdNewControl)
        Me.TabPage1.Controls.Add(Me.dgDaftarKontrol)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 452)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daftar Kontrol"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Processor
        Me.GunaPictureBox1.Location = New System.Drawing.Point(7, 8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(493, 67)
        Me.GunaPictureBox1.TabIndex = 52
        Me.GunaPictureBox1.TabStop = False
        '
        'cmdRefreshMaster
        '
        Me.cmdRefreshMaster.AnimationHoverSpeed = 0.07!
        Me.cmdRefreshMaster.AnimationSpeed = 0.03!
        Me.cmdRefreshMaster.BackColor = System.Drawing.Color.Transparent
        Me.cmdRefreshMaster.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdRefreshMaster.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdRefreshMaster.BorderColor = System.Drawing.Color.Black
        Me.cmdRefreshMaster.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdRefreshMaster.FocusedColor = System.Drawing.Color.Empty
        Me.cmdRefreshMaster.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdRefreshMaster.ForeColor = System.Drawing.Color.White
        Me.cmdRefreshMaster.Image = Nothing
        Me.cmdRefreshMaster.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdRefreshMaster.Location = New System.Drawing.Point(171, 408)
        Me.cmdRefreshMaster.Name = "cmdRefreshMaster"
        Me.cmdRefreshMaster.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRefreshMaster.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRefreshMaster.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRefreshMaster.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRefreshMaster.OnHoverImage = Nothing
        Me.cmdRefreshMaster.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRefreshMaster.Radius = 2
        Me.cmdRefreshMaster.Size = New System.Drawing.Size(103, 34)
        Me.cmdRefreshMaster.TabIndex = 51
        Me.cmdRefreshMaster.Text = "Refresh"
        Me.cmdRefreshMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cari Validasi"
        '
        'txtCariKontrol
        '
        Me.txtCariKontrol.BackColor = System.Drawing.Color.Transparent
        Me.txtCariKontrol.BaseColor = System.Drawing.Color.Thistle
        Me.txtCariKontrol.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.txtCariKontrol.BorderSize = 1
        Me.txtCariKontrol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCariKontrol.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCariKontrol.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCariKontrol.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCariKontrol.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCariKontrol.ForeColor = System.Drawing.Color.White
        Me.txtCariKontrol.Location = New System.Drawing.Point(141, 90)
        Me.txtCariKontrol.Name = "txtCariKontrol"
        Me.txtCariKontrol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCariKontrol.Radius = 2
        Me.txtCariKontrol.Size = New System.Drawing.Size(363, 32)
        Me.txtCariKontrol.TabIndex = 49
        '
        'cmdNewControl
        '
        Me.cmdNewControl.AnimationHoverSpeed = 0.07!
        Me.cmdNewControl.AnimationSpeed = 0.03!
        Me.cmdNewControl.BackColor = System.Drawing.Color.Transparent
        Me.cmdNewControl.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdNewControl.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdNewControl.BorderColor = System.Drawing.Color.Black
        Me.cmdNewControl.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdNewControl.FocusedColor = System.Drawing.Color.Empty
        Me.cmdNewControl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdNewControl.ForeColor = System.Drawing.Color.White
        Me.cmdNewControl.Image = Nothing
        Me.cmdNewControl.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdNewControl.Location = New System.Drawing.Point(316, 408)
        Me.cmdNewControl.Name = "cmdNewControl"
        Me.cmdNewControl.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdNewControl.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNewControl.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdNewControl.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdNewControl.OnHoverImage = Nothing
        Me.cmdNewControl.OnPressedColor = System.Drawing.Color.Black
        Me.cmdNewControl.Radius = 2
        Me.cmdNewControl.Size = New System.Drawing.Size(188, 34)
        Me.cmdNewControl.TabIndex = 47
        Me.cmdNewControl.Text = "Register New Control"
        Me.cmdNewControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgDaftarKontrol
        '
        Me.dgDaftarKontrol.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgDaftarKontrol.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDaftarKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDaftarKontrol.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgDaftarKontrol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDaftarKontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarKontrol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDaftarKontrol.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDaftarKontrol.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDaftarKontrol.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDaftarKontrol.EnableHeadersVisualStyles = False
        Me.dgDaftarKontrol.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarKontrol.Location = New System.Drawing.Point(6, 125)
        Me.dgDaftarKontrol.Name = "dgDaftarKontrol"
        Me.dgDaftarKontrol.ReadOnly = True
        Me.dgDaftarKontrol.RowHeadersVisible = False
        Me.dgDaftarKontrol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDaftarKontrol.Size = New System.Drawing.Size(498, 277)
        Me.dgDaftarKontrol.TabIndex = 0
        Me.dgDaftarKontrol.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgDaftarKontrol.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarKontrol.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgDaftarKontrol.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgDaftarKontrol.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgDaftarKontrol.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgDaftarKontrol.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgDaftarKontrol.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgDaftarKontrol.ThemeStyle.HeaderStyle.Height = 30
        Me.dgDaftarKontrol.ThemeStyle.ReadOnly = True
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.Height = 22
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDaftarKontrol.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdRefresh)
        Me.TabPage2.Controls.Add(Me.dgUnlocked)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 452)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unlocked"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.AnimationHoverSpeed = 0.07!
        Me.cmdRefresh.AnimationSpeed = 0.03!
        Me.cmdRefresh.BackColor = System.Drawing.Color.Transparent
        Me.cmdRefresh.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdRefresh.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdRefresh.BorderColor = System.Drawing.Color.Black
        Me.cmdRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.cmdRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdRefresh.ForeColor = System.Drawing.Color.White
        Me.cmdRefresh.Image = Nothing
        Me.cmdRefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdRefresh.Location = New System.Drawing.Point(369, 412)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRefresh.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRefresh.OnHoverImage = Nothing
        Me.cmdRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRefresh.Radius = 2
        Me.cmdRefresh.Size = New System.Drawing.Size(135, 34)
        Me.cmdRefresh.TabIndex = 47
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgUnlocked
        '
        Me.dgUnlocked.AllowUserToAddRows = False
        Me.dgUnlocked.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgUnlocked.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgUnlocked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUnlocked.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgUnlocked.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUnlocked.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgUnlocked.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUnlocked.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgUnlocked.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUnlocked.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgUnlocked.EnableHeadersVisualStyles = False
        Me.dgUnlocked.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUnlocked.Location = New System.Drawing.Point(7, 6)
        Me.dgUnlocked.Name = "dgUnlocked"
        Me.dgUnlocked.ReadOnly = True
        Me.dgUnlocked.RowHeadersVisible = False
        Me.dgUnlocked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnlocked.Size = New System.Drawing.Size(497, 400)
        Me.dgUnlocked.TabIndex = 1
        Me.dgUnlocked.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgUnlocked.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUnlocked.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgUnlocked.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgUnlocked.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgUnlocked.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgUnlocked.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgUnlocked.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUnlocked.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUnlocked.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgUnlocked.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgUnlocked.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgUnlocked.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgUnlocked.ThemeStyle.HeaderStyle.Height = 30
        Me.dgUnlocked.ThemeStyle.ReadOnly = True
        Me.dgUnlocked.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUnlocked.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgUnlocked.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgUnlocked.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgUnlocked.ThemeStyle.RowsStyle.Height = 22
        Me.dgUnlocked.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUnlocked.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'frmValidationControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 479)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmValidationControls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Validation Control"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDaftarKontrol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgUnlocked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdRefreshMaster As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariKontrol As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmdNewControl As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgDaftarKontrol As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdRefresh As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgUnlocked As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class