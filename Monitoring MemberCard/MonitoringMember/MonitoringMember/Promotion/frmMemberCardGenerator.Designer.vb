<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberCardGenerator
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbRincianNomor = New System.Windows.Forms.GroupBox()
        Me.picExportToExcel = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvRincianNomor = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblJumlahNomor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblJumlahDataNomor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvListGenerate = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox8 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.txtCatatan = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.gbRincianNomor.SuspendLayout()
        CType(Me.picExportToExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRincianNomor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListGenerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.gbRincianNomor)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox8)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox5)
        Me.Panel1.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 787)
        Me.Panel1.TabIndex = 42
        '
        'gbRincianNomor
        '
        Me.gbRincianNomor.BackColor = System.Drawing.Color.Gainsboro
        Me.gbRincianNomor.Controls.Add(Me.picExportToExcel)
        Me.gbRincianNomor.Controls.Add(Me.Button1)
        Me.gbRincianNomor.Controls.Add(Me.Label5)
        Me.gbRincianNomor.Controls.Add(Me.dgvRincianNomor)
        Me.gbRincianNomor.Controls.Add(Me.lblJumlahNomor)
        Me.gbRincianNomor.Location = New System.Drawing.Point(458, 271)
        Me.gbRincianNomor.Name = "gbRincianNomor"
        Me.gbRincianNomor.Size = New System.Drawing.Size(209, 281)
        Me.gbRincianNomor.TabIndex = 21
        Me.gbRincianNomor.TabStop = False
        Me.gbRincianNomor.Visible = False
        '
        'picExportToExcel
        '
        Me.picExportToExcel.BackColor = System.Drawing.Color.Transparent
        Me.picExportToExcel.BaseColor = System.Drawing.Color.Lime
        Me.picExportToExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportToExcel.Image = Global.MonitoringMember.My.Resources.Resources.Export_To_Excel
        Me.picExportToExcel.Location = New System.Drawing.Point(7, 256)
        Me.picExportToExcel.Name = "picExportToExcel"
        Me.picExportToExcel.Size = New System.Drawing.Size(56, 22)
        Me.picExportToExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExportToExcel.TabIndex = 16
        Me.picExportToExcel.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(156, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Rincian Nomor"
        '
        'dgvRincianNomor
        '
        Me.dgvRincianNomor.AllowUserToAddRows = False
        Me.dgvRincianNomor.AllowUserToDeleteRows = False
        Me.dgvRincianNomor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRincianNomor.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvRincianNomor.Location = New System.Drawing.Point(6, 36)
        Me.dgvRincianNomor.Name = "dgvRincianNomor"
        Me.dgvRincianNomor.ReadOnly = True
        Me.dgvRincianNomor.RowHeadersVisible = False
        Me.dgvRincianNomor.Size = New System.Drawing.Size(194, 213)
        Me.dgvRincianNomor.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToExcelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(148, 26)
        '
        'CopyToExcelToolStripMenuItem
        '
        Me.CopyToExcelToolStripMenuItem.Name = "CopyToExcelToolStripMenuItem"
        Me.CopyToExcelToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CopyToExcelToolStripMenuItem.Text = "Copy To Excel"
        '
        'lblJumlahNomor
        '
        Me.lblJumlahNomor.AutoSize = True
        Me.lblJumlahNomor.Location = New System.Drawing.Point(72, 261)
        Me.lblJumlahNomor.Name = "lblJumlahNomor"
        Me.lblJumlahNomor.Size = New System.Drawing.Size(89, 13)
        Me.lblJumlahNomor.TabIndex = 3
        Me.lblJumlahNomor.Text = "Jumlah Nomor : 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblJumlahDataNomor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgvListGenerate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 281)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.See
        Me.PictureBox1.Location = New System.Drawing.Point(386, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblJumlahDataNomor
        '
        Me.lblJumlahDataNomor.AutoSize = True
        Me.lblJumlahDataNomor.Location = New System.Drawing.Point(248, 261)
        Me.lblJumlahDataNomor.Name = "lblJumlahDataNomor"
        Me.lblJumlahDataNomor.Size = New System.Drawing.Size(81, 13)
        Me.lblJumlahDataNomor.TabIndex = 2
        Me.lblJumlahDataNomor.Text = "Jumlah Data : 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Daftar Nomor Yang Telah Dibuat"
        '
        'dgvListGenerate
        '
        Me.dgvListGenerate.AllowUserToAddRows = False
        Me.dgvListGenerate.AllowUserToDeleteRows = False
        Me.dgvListGenerate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListGenerate.Location = New System.Drawing.Point(8, 39)
        Me.dgvListGenerate.Name = "dgvListGenerate"
        Me.dgvListGenerate.ReadOnly = True
        Me.dgvListGenerate.RowHeadersVisible = False
        Me.dgvListGenerate.Size = New System.Drawing.Size(372, 213)
        Me.dgvListGenerate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(197, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Member Card Generator"
        '
        'GunaTransfarantPictureBox8
        '
        Me.GunaTransfarantPictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox8.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox8.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox8.Location = New System.Drawing.Point(538, 0)
        Me.GunaTransfarantPictureBox8.Name = "GunaTransfarantPictureBox8"
        Me.GunaTransfarantPictureBox8.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox8.TabIndex = 19
        Me.GunaTransfarantPictureBox8.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(401, 0)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(139, 120)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 18
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(270, 0)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 17
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(132, -1)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(139, 120)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 13
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(132, 120)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 12
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbCabang)
        Me.GroupBox2.Controls.Add(Me.cmdGenerate)
        Me.GroupBox2.Controls.Add(Me.txtCatatan)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtTo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 138)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Catatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cabang"
        '
        'cmbCabang
        '
        Me.cmbCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(98, 42)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(238, 32)
        Me.cmbCabang.TabIndex = 8
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(387, 45)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(275, 86)
        Me.cmdGenerate.TabIndex = 6
        Me.cmdGenerate.Text = "Proses"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(98, 76)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(238, 55)
        Me.txtCatatan.TabIndex = 4
        Me.txtCatatan.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(342, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 25)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "To"
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(387, 10)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(270, 29)
        Me.txtTo.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-4, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 25)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "From"
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(98, 10)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(238, 29)
        Me.txtFrom.TabIndex = 0
        '
        'frmMemberCardGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(672, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMemberCardGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Card Generator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbRincianNomor.ResumeLayout(False)
        Me.gbRincianNomor.PerformLayout()
        CType(Me.picExportToExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRincianNomor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListGenerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox8 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents txtCatatan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblJumlahDataNomor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvListGenerate As System.Windows.Forms.DataGridView
    Friend WithEvents gbRincianNomor As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvRincianNomor As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlahNomor As System.Windows.Forms.Label
    Friend WithEvents picExportToExcel As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
