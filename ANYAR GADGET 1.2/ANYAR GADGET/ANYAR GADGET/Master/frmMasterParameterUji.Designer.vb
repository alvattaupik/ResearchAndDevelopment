<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterParameterUji
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
        Me.cmbSubKategori = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbField = New System.Windows.Forms.GroupBox()
        Me.txtIndikator = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtNamaSubs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNamaCategories = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDSubCategories = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKodeParameter = New System.Windows.Forms.TextBox()
        Me.txtParameterUji = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIDCategories = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picCancelParameter = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.lblJumlahParameterUji = New System.Windows.Forms.Label()
        Me.dgvListParameter = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picCancelParameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListParameter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSubKategori)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbKategori)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbSubKategori
        '
        Me.cmbSubKategori.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSubKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubKategori.FormattingEnabled = True
        Me.cmbSubKategori.Location = New System.Drawing.Point(171, 51)
        Me.cmbSubKategori.Name = "cmbSubKategori"
        Me.cmbSubKategori.Size = New System.Drawing.Size(255, 24)
        Me.cmbSubKategori.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sub Kategori"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kategori"
        '
        'cmbKategori
        '
        Me.cmbKategori.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(171, 19)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(255, 24)
        Me.cmbKategori.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.txtIndikator)
        Me.gbField.Controls.Add(Me.Label2)
        Me.gbField.Controls.Add(Me.btnProses)
        Me.gbField.Controls.Add(Me.btnNew)
        Me.gbField.Controls.Add(Me.txtNamaSubs)
        Me.gbField.Controls.Add(Me.Label10)
        Me.gbField.Controls.Add(Me.txtNamaCategories)
        Me.gbField.Controls.Add(Me.Label9)
        Me.gbField.Controls.Add(Me.Label8)
        Me.gbField.Controls.Add(Me.txtIDSubCategories)
        Me.gbField.Controls.Add(Me.Label7)
        Me.gbField.Controls.Add(Me.txtKodeParameter)
        Me.gbField.Controls.Add(Me.txtParameterUji)
        Me.gbField.Controls.Add(Me.Label6)
        Me.gbField.Controls.Add(Me.Label11)
        Me.gbField.Controls.Add(Me.txtIDCategories)
        Me.gbField.Location = New System.Drawing.Point(11, 90)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(443, 341)
        Me.gbField.TabIndex = 12
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'txtIndikator
        '
        Me.txtIndikator.Location = New System.Drawing.Point(93, 189)
        Me.txtIndikator.Name = "txtIndikator"
        Me.txtIndikator.Size = New System.Drawing.Size(344, 74)
        Me.txtIndikator.TabIndex = 27
        Me.txtIndikator.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Indikator"
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(220, 279)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(133, 56)
        Me.btnProses.TabIndex = 25
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(93, 279)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(121, 56)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtNamaSubs
        '
        Me.txtNamaSubs.Enabled = False
        Me.txtNamaSubs.Location = New System.Drawing.Point(311, 42)
        Me.txtNamaSubs.Name = "txtNamaSubs"
        Me.txtNamaSubs.ReadOnly = True
        Me.txtNamaSubs.Size = New System.Drawing.Size(126, 20)
        Me.txtNamaSubs.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(215, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nama Subs"
        '
        'txtNamaCategories
        '
        Me.txtNamaCategories.Enabled = False
        Me.txtNamaCategories.Location = New System.Drawing.Point(93, 42)
        Me.txtNamaCategories.Name = "txtNamaCategories"
        Me.txtNamaCategories.ReadOnly = True
        Me.txtNamaCategories.Size = New System.Drawing.Size(116, 20)
        Me.txtNamaCategories.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Nama Categories"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Kode Parameter"
        '
        'txtIDSubCategories
        '
        Me.txtIDSubCategories.Enabled = False
        Me.txtIDSubCategories.Location = New System.Drawing.Point(311, 16)
        Me.txtIDSubCategories.Name = "txtIDSubCategories"
        Me.txtIDSubCategories.ReadOnly = True
        Me.txtIDSubCategories.Size = New System.Drawing.Size(126, 20)
        Me.txtIDSubCategories.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID SubCategories"
        '
        'txtKodeParameter
        '
        Me.txtKodeParameter.Enabled = False
        Me.txtKodeParameter.Location = New System.Drawing.Point(93, 71)
        Me.txtKodeParameter.Name = "txtKodeParameter"
        Me.txtKodeParameter.Size = New System.Drawing.Size(116, 20)
        Me.txtKodeParameter.TabIndex = 15
        '
        'txtParameterUji
        '
        Me.txtParameterUji.Location = New System.Drawing.Point(93, 105)
        Me.txtParameterUji.Name = "txtParameterUji"
        Me.txtParameterUji.Size = New System.Drawing.Size(344, 67)
        Me.txtParameterUji.TabIndex = 12
        Me.txtParameterUji.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Parameter Uji"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ID Categories"
        '
        'txtIDCategories
        '
        Me.txtIDCategories.Enabled = False
        Me.txtIDCategories.Location = New System.Drawing.Point(93, 16)
        Me.txtIDCategories.Name = "txtIDCategories"
        Me.txtIDCategories.ReadOnly = True
        Me.txtIDCategories.Size = New System.Drawing.Size(116, 20)
        Me.txtIDCategories.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picCancelParameter)
        Me.GroupBox2.Controls.Add(Me.lblJumlahParameterUji)
        Me.GroupBox2.Controls.Add(Me.dgvListParameter)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 430)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar Parameter Uji"
        '
        'picCancelParameter
        '
        Me.picCancelParameter.BackColor = System.Drawing.Color.Transparent
        Me.picCancelParameter.BaseColor = System.Drawing.Color.Black
        Me.picCancelParameter.Image = Global.ANYAR_GADGET.My.Resources.Resources.Cancel
        Me.picCancelParameter.Location = New System.Drawing.Point(340, 394)
        Me.picCancelParameter.Name = "picCancelParameter"
        Me.picCancelParameter.Size = New System.Drawing.Size(30, 30)
        Me.picCancelParameter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCancelParameter.TabIndex = 2
        Me.picCancelParameter.TabStop = False
        '
        'lblJumlahParameterUji
        '
        Me.lblJumlahParameterUji.AutoSize = True
        Me.lblJumlahParameterUji.Location = New System.Drawing.Point(6, 403)
        Me.lblJumlahParameterUji.Name = "lblJumlahParameterUji"
        Me.lblJumlahParameterUji.Size = New System.Drawing.Size(121, 13)
        Me.lblJumlahParameterUji.TabIndex = 1
        Me.lblJumlahParameterUji.Text = "Jumlah Parameter Uji : 0"
        '
        'dgvListParameter
        '
        Me.dgvListParameter.AllowUserToAddRows = False
        Me.dgvListParameter.AllowUserToDeleteRows = False
        Me.dgvListParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListParameter.Location = New System.Drawing.Point(7, 19)
        Me.dgvListParameter.Name = "dgvListParameter"
        Me.dgvListParameter.ReadOnly = True
        Me.dgvListParameter.Size = New System.Drawing.Size(363, 373)
        Me.dgvListParameter.TabIndex = 0
        '
        'frmMasterParameterUji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 439)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMasterParameterUji"
        Me.Text = "Parameter Uji"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picCancelParameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListParameter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSubKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents txtParameterUji As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIDCategories As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaSubs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNamaCategories As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIDSubCategories As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtIndikator As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKodeParameter As System.Windows.Forms.TextBox
    Friend WithEvents lblJumlahParameterUji As System.Windows.Forms.Label
    Friend WithEvents dgvListParameter As System.Windows.Forms.DataGridView
    Friend WithEvents picCancelParameter As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
