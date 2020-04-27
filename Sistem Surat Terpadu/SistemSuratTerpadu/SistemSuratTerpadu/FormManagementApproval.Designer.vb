<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManagementApproval
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDibuatOleh = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCari = New Guna.UI.WinForms.GunaGradientButton()
        Me.dtpAkhir = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtpAwal = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cmdCetakForm = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdLihatDetail = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgRequestApproval = New Guna.UI.WinForms.GunaDataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgRequestApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblJumlahData)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cmdCetakForm)
        Me.GroupBox2.Controls.Add(Me.cmdLihatDetail)
        Me.GroupBox2.Controls.Add(Me.dgRequestApproval)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 343)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahData.Location = New System.Drawing.Point(12, 318)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(110, 20)
        Me.lblJumlahData.TabIndex = 41
        Me.lblJumlahData.Text = "Jumlah Data"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDibuatOleh)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmdCari)
        Me.GroupBox3.Controls.Add(Me.dtpAkhir)
        Me.GroupBox3.Controls.Add(Me.dtpAwal)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 86)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'txtDibuatOleh
        '
        Me.txtDibuatOleh.BaseColor = System.Drawing.Color.White
        Me.txtDibuatOleh.BorderColor = System.Drawing.Color.Silver
        Me.txtDibuatOleh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDibuatOleh.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDibuatOleh.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDibuatOleh.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDibuatOleh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDibuatOleh.Location = New System.Drawing.Point(167, 52)
        Me.txtDibuatOleh.Name = "txtDibuatOleh"
        Me.txtDibuatOleh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDibuatOleh.Size = New System.Drawing.Size(316, 26)
        Me.txtDibuatOleh.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "User Created"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "S/D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 13)
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
        Me.cmdCari.Location = New System.Drawing.Point(516, 17)
        Me.cmdCari.Name = "cmdCari"
        Me.cmdCari.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCari.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCari.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCari.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCari.OnHoverImage = Nothing
        Me.cmdCari.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCari.Radius = 2
        Me.cmdCari.Size = New System.Drawing.Size(104, 61)
        Me.cmdCari.TabIndex = 38
        Me.cmdCari.Text = "Cari"
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
        Me.dtpAkhir.Location = New System.Drawing.Point(364, 15)
        Me.dtpAkhir.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpAkhir.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpAkhir.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAkhir.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpAkhir.OnPressedColor = System.Drawing.Color.Black
        Me.dtpAkhir.Size = New System.Drawing.Size(120, 30)
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
        Me.dtpAwal.Location = New System.Drawing.Point(169, 13)
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
        Me.cmdCetakForm.Location = New System.Drawing.Point(527, 178)
        Me.cmdCetakForm.Name = "cmdCetakForm"
        Me.cmdCetakForm.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdCetakForm.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCetakForm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdCetakForm.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdCetakForm.OnHoverImage = Nothing
        Me.cmdCetakForm.OnPressedColor = System.Drawing.Color.Black
        Me.cmdCetakForm.Radius = 2
        Me.cmdCetakForm.Size = New System.Drawing.Size(111, 56)
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
        Me.cmdLihatDetail.Location = New System.Drawing.Point(527, 116)
        Me.cmdLihatDetail.Name = "cmdLihatDetail"
        Me.cmdLihatDetail.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLihatDetail.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLihatDetail.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLihatDetail.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLihatDetail.OnHoverImage = Nothing
        Me.cmdLihatDetail.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLihatDetail.Radius = 2
        Me.cmdLihatDetail.Size = New System.Drawing.Size(111, 56)
        Me.cmdLihatDetail.TabIndex = 38
        Me.cmdLihatDetail.Text = "Lihat Detail"
        Me.cmdLihatDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgRequestApproval
        '
        Me.dgRequestApproval.AllowUserToAddRows = False
        Me.dgRequestApproval.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgRequestApproval.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRequestApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRequestApproval.BackgroundColor = System.Drawing.Color.White
        Me.dgRequestApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRequestApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRequestApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestApproval.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgRequestApproval.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRequestApproval.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgRequestApproval.EnableHeadersVisualStyles = False
        Me.dgRequestApproval.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestApproval.Location = New System.Drawing.Point(12, 116)
        Me.dgRequestApproval.Name = "dgRequestApproval"
        Me.dgRequestApproval.ReadOnly = True
        Me.dgRequestApproval.RowHeadersVisible = False
        Me.dgRequestApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRequestApproval.Size = New System.Drawing.Size(509, 200)
        Me.dgRequestApproval.TabIndex = 0
        Me.dgRequestApproval.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgRequestApproval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRequestApproval.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgRequestApproval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgRequestApproval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgRequestApproval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgRequestApproval.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgRequestApproval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgRequestApproval.ThemeStyle.HeaderStyle.Height = 30
        Me.dgRequestApproval.ThemeStyle.ReadOnly = True
        Me.dgRequestApproval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRequestApproval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRequestApproval.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgRequestApproval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgRequestApproval.ThemeStyle.RowsStyle.Height = 22
        Me.dgRequestApproval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestApproval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightPink
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request Approval"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(606, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormManagementApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(654, 407)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManagementApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormManagementApproval"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgRequestApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDibuatOleh As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCari As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dtpAkhir As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtpAwal As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cmdCetakForm As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdLihatDetail As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgRequestApproval As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
