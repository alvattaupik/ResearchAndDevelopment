<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoringRealStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonitoringRealStock))
        Me.dgInventoryData = New Guna.UI.WinForms.GunaDataGridView()
        Me.cmMonitoringRealStock = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AvailableToPromiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGroup = New Guna.UI.WinForms.GunaTextBox()
        Me.txtNamaBarang = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.gbATP = New System.Windows.Forms.GroupBox()
        Me.dgvATP = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.dgItemList = New System.Windows.Forms.DataGridView()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        CType(Me.dgInventoryData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMonitoringRealStock.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbATP.SuspendLayout()
        CType(Me.dgvATP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgInventoryData
        '
        Me.dgInventoryData.AllowUserToAddRows = False
        Me.dgInventoryData.AllowUserToDeleteRows = False
        Me.dgInventoryData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInventoryData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgInventoryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgInventoryData.BackgroundColor = System.Drawing.Color.Silver
        Me.dgInventoryData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInventoryData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInventoryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInventoryData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInventoryData.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInventoryData.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInventoryData.EnableHeadersVisualStyles = False
        Me.dgInventoryData.GridColor = System.Drawing.Color.Blue
        Me.dgInventoryData.Location = New System.Drawing.Point(5, 192)
        Me.dgInventoryData.Name = "dgInventoryData"
        Me.dgInventoryData.ReadOnly = True
        Me.dgInventoryData.RowHeadersVisible = False
        Me.dgInventoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInventoryData.Size = New System.Drawing.Size(584, 466)
        Me.dgInventoryData.TabIndex = 7
        Me.dgInventoryData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgInventoryData.ThemeStyle.GridColor = System.Drawing.Color.Blue
        Me.dgInventoryData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInventoryData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgInventoryData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInventoryData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgInventoryData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgInventoryData.ThemeStyle.HeaderStyle.Height = 30
        Me.dgInventoryData.ThemeStyle.ReadOnly = True
        Me.dgInventoryData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInventoryData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInventoryData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgInventoryData.ThemeStyle.RowsStyle.Height = 22
        Me.dgInventoryData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInventoryData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmMonitoringRealStock
        '
        Me.cmMonitoringRealStock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvailableToPromiseToolStripMenuItem})
        Me.cmMonitoringRealStock.Name = "ContextMenuStrip1"
        Me.cmMonitoringRealStock.Size = New System.Drawing.Size(184, 26)
        '
        'AvailableToPromiseToolStripMenuItem
        '
        Me.AvailableToPromiseToolStripMenuItem.Name = "AvailableToPromiseToolStripMenuItem"
        Me.AvailableToPromiseToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AvailableToPromiseToolStripMenuItem.Text = "Available To Promise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGroup)
        Me.GroupBox1.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKodeBarang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 129)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txtGroup
        '
        Me.txtGroup.BaseColor = System.Drawing.Color.White
        Me.txtGroup.BorderColor = System.Drawing.Color.Silver
        Me.txtGroup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroup.Enabled = False
        Me.txtGroup.FocusedBaseColor = System.Drawing.Color.White
        Me.txtGroup.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGroup.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGroup.Location = New System.Drawing.Point(128, 80)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGroup.Size = New System.Drawing.Size(427, 26)
        Me.txtGroup.TabIndex = 14
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.BaseColor = System.Drawing.Color.White
        Me.txtNamaBarang.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaBarang.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaBarang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaBarang.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaBarang.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(128, 48)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaBarang.Size = New System.Drawing.Size(427, 28)
        Me.txtNamaBarang.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.BaseColor = System.Drawing.Color.White
        Me.txtKodeBarang.BorderColor = System.Drawing.Color.Silver
        Me.txtKodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeBarang.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKodeBarang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKodeBarang.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKodeBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Location = New System.Drawing.Point(128, 16)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeBarang.Size = New System.Drawing.Size(427, 28)
        Me.txtKodeBarang.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Group"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 50)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(721, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 567)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Available To Promis"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(184, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(321, 32)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "REAL STOCK MONITORING"
        '
        'gbATP
        '
        Me.gbATP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbATP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbATP.Controls.Add(Me.btnHide)
        Me.gbATP.Controls.Add(Me.dgvATP)
        Me.gbATP.Controls.Add(Me.Label1)
        Me.gbATP.Location = New System.Drawing.Point(597, 52)
        Me.gbATP.Name = "gbATP"
        Me.gbATP.Size = New System.Drawing.Size(612, 606)
        Me.gbATP.TabIndex = 14
        Me.gbATP.TabStop = False
        Me.gbATP.Text = "Available to Promise"
        Me.gbATP.Visible = False
        '
        'dgvATP
        '
        Me.dgvATP.AllowUserToAddRows = False
        Me.dgvATP.AllowUserToDeleteRows = False
        Me.dgvATP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvATP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvATP.Location = New System.Drawing.Point(6, 87)
        Me.dgvATP.Name = "dgvATP"
        Me.dgvATP.ReadOnly = True
        Me.dgvATP.Size = New System.Drawing.Size(582, 483)
        Me.dgvATP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AVAILABLE TO PROMISE"
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbItem.Controls.Add(Me.cmdTutup)
        Me.gbItem.Controls.Add(Me.dgItemList)
        Me.gbItem.Location = New System.Drawing.Point(29, 139)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(558, 197)
        Me.gbItem.TabIndex = 15
        Me.gbItem.TabStop = False
        Me.gbItem.Visible = False
        '
        'cmdTutup
        '
        Me.cmdTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdTutup.Location = New System.Drawing.Point(409, 170)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(143, 25)
        Me.cmdTutup.TabIndex = 1
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = False
        '
        'dgItemList
        '
        Me.dgItemList.AllowUserToAddRows = False
        Me.dgItemList.AllowUserToDeleteRows = False
        Me.dgItemList.AllowUserToResizeRows = False
        Me.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemList.Location = New System.Drawing.Point(9, 12)
        Me.dgItemList.Name = "dgItemList"
        Me.dgItemList.ReadOnly = True
        Me.dgItemList.Size = New System.Drawing.Size(543, 156)
        Me.dgItemList.TabIndex = 0
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.Red
        Me.btnHide.Location = New System.Drawing.Point(537, 8)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 55)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Text = "X"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 686)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(1212, 63)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 38
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        'Me.GunaTransfarantPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Inventorry_4
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(642, 87)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(547, 456)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 41
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'frmMonitoringRealStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 749)
        Me.ContextMenuStrip = Me.cmMonitoringRealStock
        Me.Controls.Add(Me.gbATP)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgInventoryData)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Name = "frmMonitoringRealStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonitoringRealStock"
        CType(Me.dgInventoryData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMonitoringRealStock.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbATP.ResumeLayout(False)
        Me.gbATP.PerformLayout()
        CType(Me.dgvATP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgInventoryData As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmMonitoringRealStock As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AvailableToPromiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGroup As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNamaBarang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbATP As System.Windows.Forms.GroupBox
    Friend WithEvents dgvATP As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents dgItemList As System.Windows.Forms.DataGridView
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
