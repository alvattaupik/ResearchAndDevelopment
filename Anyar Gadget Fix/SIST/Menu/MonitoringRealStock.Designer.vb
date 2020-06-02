<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoringRealStock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New Guna.UI.WinForms.GunaTextBox()
        Me.txtGroup = New Guna.UI.WinForms.GunaTextBox()
        Me.dgInventoryData = New Guna.UI.WinForms.GunaDataGridView()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.dgItemList = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgInventoryData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 66)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MONITORING REALSTOCK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.BaseColor = System.Drawing.Color.White
        Me.txtKodeBarang.BorderColor = System.Drawing.Color.Silver
        Me.txtKodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeBarang.FocusedBaseColor = System.Drawing.Color.White
        Me.txtKodeBarang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKodeBarang.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKodeBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKodeBarang.Location = New System.Drawing.Point(120, 71)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeBarang.Size = New System.Drawing.Size(280, 26)
        Me.txtKodeBarang.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.BaseColor = System.Drawing.Color.White
        Me.txtNamaBarang.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaBarang.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaBarang.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaBarang.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaBarang.Location = New System.Drawing.Point(120, 103)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaBarang.Size = New System.Drawing.Size(280, 26)
        Me.txtNamaBarang.TabIndex = 4
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
        Me.txtGroup.Location = New System.Drawing.Point(120, 135)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGroup.Size = New System.Drawing.Size(280, 26)
        Me.txtGroup.TabIndex = 6
        '
        'dgInventoryData
        '
        Me.dgInventoryData.AllowUserToAddRows = False
        Me.dgInventoryData.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgInventoryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInventoryData.BackgroundColor = System.Drawing.Color.White
        Me.dgInventoryData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInventoryData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInventoryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInventoryData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgInventoryData.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInventoryData.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgInventoryData.EnableHeadersVisualStyles = False
        Me.dgInventoryData.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInventoryData.Location = New System.Drawing.Point(406, 5)
        Me.dgInventoryData.Name = "dgInventoryData"
        Me.dgInventoryData.ReadOnly = True
        Me.dgInventoryData.RowHeadersVisible = False
        Me.dgInventoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInventoryData.Size = New System.Drawing.Size(432, 324)
        Me.dgInventoryData.TabIndex = 7
        Me.dgInventoryData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgInventoryData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgInventoryData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbItem.Controls.Add(Me.cmdTutup)
        Me.gbItem.Controls.Add(Me.dgItemList)
        Me.gbItem.Location = New System.Drawing.Point(7, 135)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(393, 197)
        Me.gbItem.TabIndex = 8
        Me.gbItem.TabStop = False
        Me.gbItem.Visible = False
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(281, 169)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(106, 25)
        Me.cmdTutup.TabIndex = 1
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'dgItemList
        '
        Me.dgItemList.AllowUserToAddRows = False
        Me.dgItemList.AllowUserToDeleteRows = False
        Me.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemList.Location = New System.Drawing.Point(9, 12)
        Me.dgItemList.Name = "dgItemList"
        Me.dgItemList.ReadOnly = True
        Me.dgItemList.Size = New System.Drawing.Size(378, 156)
        Me.dgItemList.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Group"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.AnyarGadget.My.Resources.Resources.LOGO_ANYAR_BULAT
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(35, 174)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(142, 145)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 10
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Monitoring Real Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "V1.1 Build XX.XX.XXXX"
        '
        'MonitoringRealStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 334)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.dgInventoryData)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.MaximizeBox = False
        Me.Name = "MonitoringRealStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonitoringRealStock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgInventoryData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaBarang As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtGroup As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgInventoryData As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents dgItemList As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
