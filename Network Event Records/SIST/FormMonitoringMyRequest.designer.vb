﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMonitoringMyRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMonitoringMyRequest))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbStatusRequest = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCari = New Guna.UI.WinForms.GunaGradientButton()
        Me.dtpAkhir = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtpAwal = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cmdCetakForm = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdLihatDetail = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdRefresh = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgRequestMonitoring = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgRequestMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(636, 0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(39, 27)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "X"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monitoring My Request"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GunaAdvenceButton1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cmdCetakForm)
        Me.GroupBox2.Controls.Add(Me.cmdLihatDetail)
        Me.GroupBox2.Controls.Add(Me.cmdRefresh)
        Me.GroupBox2.Controls.Add(Me.dgRequestMonitoring)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 312)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NER.My.Resources.Resources.Network_Operation_Center_NOC
        Me.PictureBox1.Location = New System.Drawing.Point(6, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageOffsetX = 20
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaAdvenceButton1.LineTop = 1
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(564, 264)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnPressedDepth = 0
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(104, 39)
        Me.GunaAdvenceButton1.TabIndex = 41
        Me.GunaAdvenceButton1.TextOffsetX = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbStatusRequest)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbStatus)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmdCari)
        Me.GroupBox3.Controls.Add(Me.dtpAkhir)
        Me.GroupBox3.Controls.Add(Me.dtpAwal)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 113)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'cmbStatusRequest
        '
        Me.cmbStatusRequest.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatusRequest.BaseColor = System.Drawing.Color.White
        Me.cmbStatusRequest.BorderColor = System.Drawing.Color.Silver
        Me.cmbStatusRequest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatusRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusRequest.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatusRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatusRequest.ForeColor = System.Drawing.Color.Black
        Me.cmbStatusRequest.FormattingEnabled = True
        Me.cmbStatusRequest.Location = New System.Drawing.Point(162, 76)
        Me.cmbStatusRequest.Name = "cmbStatusRequest"
        Me.cmbStatusRequest.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatusRequest.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbStatusRequest.Size = New System.Drawing.Size(350, 26)
        Me.cmbStatusRequest.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Status Request"
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
        Me.cmbStatus.Items.AddRange(New Object() {"Belum DiApprove", "Kurang beberapa Approval", "Lengkap Disetujui"})
        Me.cmbStatus.Location = New System.Drawing.Point(162, 46)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatus.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbStatus.Size = New System.Drawing.Size(350, 26)
        Me.cmbStatus.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Status Approval"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "S/D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tanggal"
        '
        'cmdCari
        '
        Me.cmdCari.AnimationHoverSpeed = 0.07!
        Me.cmdCari.AnimationSpeed = 0.03!
        Me.cmdCari.BackColor = System.Drawing.Color.Transparent
        Me.cmdCari.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdCari.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdCari.BorderColor = System.Drawing.Color.Black
        Me.cmdCari.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdCari.FocusedColor = System.Drawing.Color.Empty
        Me.cmdCari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdCari.ForeColor = System.Drawing.Color.White
        Me.cmdCari.Image = Nothing
        Me.cmdCari.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdCari.Location = New System.Drawing.Point(520, 10)
        Me.cmdCari.Name = "cmdCari"
        Me.cmdCari.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCari.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCari.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCari.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCari.OnHoverImage = Nothing
        Me.cmdCari.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCari.Radius = 2
        Me.cmdCari.Size = New System.Drawing.Size(126, 30)
        Me.cmdCari.TabIndex = 38
        Me.cmdCari.Text = "Cari Periode"
        Me.cmdCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpAkhir
        '
        Me.dtpAkhir.BaseColor = System.Drawing.Color.White
        Me.dtpAkhir.BorderColor = System.Drawing.Color.Silver
        Me.dtpAkhir.CustomFormat = Nothing
        Me.dtpAkhir.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpAkhir.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAkhir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpAkhir.ForeColor = System.Drawing.Color.Black
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(394, 10)
        Me.dtpAkhir.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAkhir.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpAkhir.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAkhir.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAkhir.OnPressedColor = System.Drawing.Color.Black
        Me.dtpAkhir.Size = New System.Drawing.Size(118, 30)
        Me.dtpAkhir.TabIndex = 1
        Me.dtpAkhir.Text = "01/04/2020"
        Me.dtpAkhir.Value = New Date(2020, 4, 1, 15, 7, 7, 565)
        '
        'dtpAwal
        '
        Me.dtpAwal.BaseColor = System.Drawing.Color.White
        Me.dtpAwal.BorderColor = System.Drawing.Color.Silver
        Me.dtpAwal.CustomFormat = Nothing
        Me.dtpAwal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpAwal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAwal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpAwal.ForeColor = System.Drawing.Color.Black
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(162, 10)
        Me.dtpAwal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAwal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpAwal.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAwal.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAwal.OnPressedColor = System.Drawing.Color.Black
        Me.dtpAwal.Size = New System.Drawing.Size(120, 30)
        Me.dtpAwal.TabIndex = 0
        Me.dtpAwal.Text = "01/04/2020"
        Me.dtpAwal.Value = New Date(2020, 4, 1, 15, 7, 7, 565)
        '
        'cmdCetakForm
        '
        Me.cmdCetakForm.AnimationHoverSpeed = 0.07!
        Me.cmdCetakForm.AnimationSpeed = 0.03!
        Me.cmdCetakForm.BackColor = System.Drawing.Color.Transparent
        Me.cmdCetakForm.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdCetakForm.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdCetakForm.BorderColor = System.Drawing.Color.Black
        Me.cmdCetakForm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdCetakForm.FocusedColor = System.Drawing.Color.Empty
        Me.cmdCetakForm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdCetakForm.ForeColor = System.Drawing.Color.White
        Me.cmdCetakForm.Image = Nothing
        Me.cmdCetakForm.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdCetakForm.Location = New System.Drawing.Point(564, 210)
        Me.cmdCetakForm.Name = "cmdCetakForm"
        Me.cmdCetakForm.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCetakForm.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCetakForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCetakForm.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCetakForm.OnHoverImage = Nothing
        Me.cmdCetakForm.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCetakForm.Radius = 2
        Me.cmdCetakForm.Size = New System.Drawing.Size(104, 37)
        Me.cmdCetakForm.TabIndex = 39
        Me.cmdCetakForm.Text = "Cetak Form"
        Me.cmdCetakForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdLihatDetail
        '
        Me.cmdLihatDetail.AnimationHoverSpeed = 0.07!
        Me.cmdLihatDetail.AnimationSpeed = 0.03!
        Me.cmdLihatDetail.BackColor = System.Drawing.Color.Transparent
        Me.cmdLihatDetail.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdLihatDetail.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdLihatDetail.BorderColor = System.Drawing.Color.Black
        Me.cmdLihatDetail.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdLihatDetail.FocusedColor = System.Drawing.Color.Empty
        Me.cmdLihatDetail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdLihatDetail.ForeColor = System.Drawing.Color.White
        Me.cmdLihatDetail.Image = Nothing
        Me.cmdLihatDetail.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdLihatDetail.Location = New System.Drawing.Point(564, 169)
        Me.cmdLihatDetail.Name = "cmdLihatDetail"
        Me.cmdLihatDetail.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLihatDetail.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLihatDetail.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLihatDetail.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLihatDetail.OnHoverImage = Nothing
        Me.cmdLihatDetail.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLihatDetail.Radius = 2
        Me.cmdLihatDetail.Size = New System.Drawing.Size(104, 35)
        Me.cmdLihatDetail.TabIndex = 38
        Me.cmdLihatDetail.Text = "Lihat Detail"
        Me.cmdLihatDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmdRefresh.Location = New System.Drawing.Point(564, 128)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdRefresh.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdRefresh.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdRefresh.OnHoverImage = Nothing
        Me.cmdRefresh.OnPressedColor = System.Drawing.Color.Black
        Me.cmdRefresh.Radius = 2
        Me.cmdRefresh.Size = New System.Drawing.Size(104, 35)
        Me.cmdRefresh.TabIndex = 37
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgRequestMonitoring
        '
        Me.dgRequestMonitoring.AllowUserToAddRows = False
        Me.dgRequestMonitoring.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgRequestMonitoring.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgRequestMonitoring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRequestMonitoring.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgRequestMonitoring.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRequestMonitoring.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRequestMonitoring.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestMonitoring.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgRequestMonitoring.ColumnHeadersHeight = 30
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRequestMonitoring.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgRequestMonitoring.EnableHeadersVisualStyles = False
        Me.dgRequestMonitoring.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestMonitoring.Location = New System.Drawing.Point(225, 128)
        Me.dgRequestMonitoring.Name = "dgRequestMonitoring"
        Me.dgRequestMonitoring.ReadOnly = True
        Me.dgRequestMonitoring.RowHeadersVisible = False
        Me.dgRequestMonitoring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgRequestMonitoring.Size = New System.Drawing.Size(333, 175)
        Me.dgRequestMonitoring.TabIndex = 0
        Me.dgRequestMonitoring.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgRequestMonitoring.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRequestMonitoring.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgRequestMonitoring.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgRequestMonitoring.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgRequestMonitoring.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgRequestMonitoring.ThemeStyle.BackColor = System.Drawing.Color.DarkGray
        Me.dgRequestMonitoring.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgRequestMonitoring.ThemeStyle.HeaderStyle.Height = 30
        Me.dgRequestMonitoring.ThemeStyle.ReadOnly = True
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.Height = 22
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestMonitoring.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 66)
        Me.Panel1.TabIndex = 2
        '
        'FormMonitoringMyRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(699, 404)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMonitoringMyRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMonitoringStatusValidasi"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgRequestMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgRequestMonitoring As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmdCetakForm As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdLihatDetail As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdRefresh As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCari As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dtpAkhir As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtpAwal As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatusRequest As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
