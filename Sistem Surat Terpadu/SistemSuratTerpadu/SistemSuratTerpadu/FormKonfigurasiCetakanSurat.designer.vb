<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKonfigurasiCetakanSurat
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTambah = New System.Windows.Forms.Button()
        Me.chkStatus = New Guna.UI.WinForms.GunaCheckBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmbJenisSurat = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdbrowse = New System.Windows.Forms.Button()
        Me.txtpathtemplate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCariSettingTemplate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgSettingTemplate = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtDocEntry = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgSettingTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTambah)
        Me.GroupBox1.Controls.Add(Me.chkStatus)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSimpan)
        Me.GroupBox1.Controls.Add(Me.cmbJenisSurat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdbrowse)
        Me.GroupBox1.Controls.Add(Me.txtpathtemplate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Konfigurasi Template"
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(102, 114)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(165, 26)
        Me.cmdTambah.TabIndex = 10
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.BaseColor = System.Drawing.Color.White
        Me.chkStatus.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkStatus.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkStatus.FillColor = System.Drawing.Color.White
        Me.chkStatus.Location = New System.Drawing.Point(311, 85)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(52, 20)
        Me.chkStatus.TabIndex = 9
        Me.chkStatus.Text = "Aktif"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(102, 59)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(367, 20)
        Me.txtKeterangan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Keterangan"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(440, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(269, 114)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(165, 26)
        Me.cmdSimpan.TabIndex = 5
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmbJenisSurat
        '
        Me.cmbJenisSurat.FormattingEnabled = True
        Me.cmbJenisSurat.Location = New System.Drawing.Point(102, 87)
        Me.cmbJenisSurat.Name = "cmbJenisSurat"
        Me.cmbJenisSurat.Size = New System.Drawing.Size(203, 21)
        Me.cmbJenisSurat.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Surat"
        '
        'cmdbrowse
        '
        Me.cmdbrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbrowse.Location = New System.Drawing.Point(493, 12)
        Me.cmdbrowse.Name = "cmdbrowse"
        Me.cmdbrowse.Size = New System.Drawing.Size(91, 96)
        Me.cmdbrowse.TabIndex = 2
        Me.cmdbrowse.Text = "Browse.."
        Me.cmdbrowse.UseVisualStyleBackColor = True
        '
        'txtpathtemplate
        '
        Me.txtpathtemplate.Enabled = False
        Me.txtpathtemplate.Location = New System.Drawing.Point(102, 29)
        Me.txtpathtemplate.Name = "txtpathtemplate"
        Me.txtpathtemplate.Size = New System.Drawing.Size(367, 20)
        Me.txtpathtemplate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path Template"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "KONFIGURASI TEMPLATE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCariSettingTemplate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dgSettingTemplate)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 213)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtCariSettingTemplate
        '
        Me.txtCariSettingTemplate.Location = New System.Drawing.Point(189, 17)
        Me.txtCariSettingTemplate.Name = "txtCariSettingTemplate"
        Me.txtCariSettingTemplate.Size = New System.Drawing.Size(383, 20)
        Me.txtCariSettingTemplate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cari Setting Template"
        '
        'dgSettingTemplate
        '
        Me.dgSettingTemplate.AllowUserToAddRows = False
        Me.dgSettingTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSettingTemplate.Location = New System.Drawing.Point(14, 43)
        Me.dgSettingTemplate.Name = "dgSettingTemplate"
        Me.dgSettingTemplate.Size = New System.Drawing.Size(558, 159)
        Me.dgSettingTemplate.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtDocEntry
        '
        Me.txtDocEntry.Location = New System.Drawing.Point(20, 21)
        Me.txtDocEntry.Name = "txtDocEntry"
        Me.txtDocEntry.Size = New System.Drawing.Size(53, 20)
        Me.txtDocEntry.TabIndex = 3
        Me.txtDocEntry.Visible = False
        '
        'FormKonfigurasiCetakanSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 425)
        Me.Controls.Add(Me.txtDocEntry)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormKonfigurasiCetakanSurat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfigurasi Template"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgSettingTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmbJenisSurat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdbrowse As System.Windows.Forms.Button
    Friend WithEvents txtpathtemplate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSettingTemplate As System.Windows.Forms.DataGridView
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCariSettingTemplate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkStatus As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txtDocEntry As System.Windows.Forms.TextBox
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
End Class
