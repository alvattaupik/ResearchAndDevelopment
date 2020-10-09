<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBantuan
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvKonten = New System.Windows.Forms.DataGridView()
        Me.gbField = New System.Windows.Forms.GroupBox()
        Me.txtSubKategori = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeKonten = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.dgvDaftarLampiran = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKonten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDaftarLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSubKategori)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbKategori)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbSubKategori
        '
        Me.cmbSubKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubKategori.FormattingEnabled = True
        Me.cmbSubKategori.Location = New System.Drawing.Point(177, 38)
        Me.cmbSubKategori.Name = "cmbSubKategori"
        Me.cmbSubKategori.Size = New System.Drawing.Size(479, 24)
        Me.cmbSubKategori.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sub Kategori"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(177, 68)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(479, 20)
        Me.txtCari.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kategori"
        '
        'cmbKategori
        '
        Me.cmbKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(177, 12)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(479, 24)
        Me.cmbKategori.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 76)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgvKonten
        '
        Me.dgvKonten.AllowUserToAddRows = False
        Me.dgvKonten.AllowUserToDeleteRows = False
        Me.dgvKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKonten.Location = New System.Drawing.Point(13, 106)
        Me.dgvKonten.Name = "dgvKonten"
        Me.dgvKonten.ReadOnly = True
        Me.dgvKonten.RowHeadersVisible = False
        Me.dgvKonten.Size = New System.Drawing.Size(675, 152)
        Me.dgvKonten.TabIndex = 1
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.txtSubKategori)
        Me.gbField.Controls.Add(Me.txtKategori)
        Me.gbField.Controls.Add(Me.Label5)
        Me.gbField.Controls.Add(Me.Label4)
        Me.gbField.Controls.Add(Me.txtDeskripsi)
        Me.gbField.Controls.Add(Me.Label6)
        Me.gbField.Controls.Add(Me.Label11)
        Me.gbField.Controls.Add(Me.txtKodeKonten)
        Me.gbField.Location = New System.Drawing.Point(1, 264)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(443, 220)
        Me.gbField.TabIndex = 12
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'txtSubKategori
        '
        Me.txtSubKategori.Enabled = False
        Me.txtSubKategori.Location = New System.Drawing.Point(154, 64)
        Me.txtSubKategori.Name = "txtSubKategori"
        Me.txtSubKategori.Size = New System.Drawing.Size(273, 20)
        Me.txtSubKategori.TabIndex = 16
        '
        'txtKategori
        '
        Me.txtKategori.Enabled = False
        Me.txtKategori.Location = New System.Drawing.Point(154, 38)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(273, 20)
        Me.txtKategori.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sub Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Kategori"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(154, 90)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(273, 121)
        Me.txtDeskripsi.TabIndex = 12
        Me.txtDeskripsi.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Deskripsi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Kode Konten"
        '
        'txtKodeKonten
        '
        Me.txtKodeKonten.Enabled = False
        Me.txtKodeKonten.Location = New System.Drawing.Point(154, 13)
        Me.txtKodeKonten.Name = "txtKodeKonten"
        Me.txtKodeKonten.Size = New System.Drawing.Size(273, 20)
        Me.txtKodeKonten.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDownload)
        Me.GroupBox2.Controls.Add(Me.btnLihat)
        Me.GroupBox2.Controls.Add(Me.dgvDaftarLampiran)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 219)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar File"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(135, 187)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(96, 23)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnLihat
        '
        Me.btnLihat.Location = New System.Drawing.Point(7, 188)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(96, 23)
        Me.btnLihat.TabIndex = 1
        Me.btnLihat.Text = "Lihat"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'dgvDaftarLampiran
        '
        Me.dgvDaftarLampiran.AllowUserToAddRows = False
        Me.dgvDaftarLampiran.AllowUserToDeleteRows = False
        Me.dgvDaftarLampiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarLampiran.Location = New System.Drawing.Point(7, 19)
        Me.dgvDaftarLampiran.Name = "dgvDaftarLampiran"
        Me.dgvDaftarLampiran.ReadOnly = True
        Me.dgvDaftarLampiran.RowHeadersVisible = False
        Me.dgvDaftarLampiran.Size = New System.Drawing.Size(224, 162)
        Me.dgvDaftarLampiran.TabIndex = 0
        '
        'frmBantuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 496)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.dgvKonten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBantuan"
        Me.Text = "frmBantuan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKonten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDaftarLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSubKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents dgvKonten As System.Windows.Forms.DataGridView
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubKategori As System.Windows.Forms.TextBox
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKodeKonten As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnLihat As System.Windows.Forms.Button
    Friend WithEvents dgvDaftarLampiran As System.Windows.Forms.DataGridView
End Class
