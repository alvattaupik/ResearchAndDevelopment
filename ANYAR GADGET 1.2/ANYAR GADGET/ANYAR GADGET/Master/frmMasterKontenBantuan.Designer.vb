<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterKontenBantuan
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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.txtNamaSubs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNamaCategories = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDSubCategories = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKodeKonten = New System.Windows.Forms.TextBox()
        Me.txtDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIDCategories = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNamaFile = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahLampiran = New System.Windows.Forms.Label()
        Me.btnHapusLampiran = New System.Windows.Forms.Button()
        Me.dgvListLampiran = New System.Windows.Forms.DataGridView()
        Me.btnAddLampiran = New System.Windows.Forms.Button()
        Me.txtPathLampiran = New System.Windows.Forms.TextBox()
        Me.picCariLampiran = New System.Windows.Forms.PictureBox()
        Me.AttachID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKonten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(814, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbSubKategori
        '
        Me.cmbSubKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubKategori.FormattingEnabled = True
        Me.cmbSubKategori.Location = New System.Drawing.Point(206, 38)
        Me.cmbSubKategori.Name = "cmbSubKategori"
        Me.cmbSubKategori.Size = New System.Drawing.Size(589, 24)
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
        Me.txtCari.Location = New System.Drawing.Point(206, 68)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(589, 20)
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
        Me.cmbKategori.Location = New System.Drawing.Point(206, 10)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(589, 24)
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
        Me.dgvKonten.Size = New System.Drawing.Size(814, 152)
        Me.dgvKonten.TabIndex = 1
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.btnProses)
        Me.gbField.Controls.Add(Me.btnNew)
        Me.gbField.Controls.Add(Me.chkAktif)
        Me.gbField.Controls.Add(Me.txtNamaSubs)
        Me.gbField.Controls.Add(Me.Label10)
        Me.gbField.Controls.Add(Me.txtNamaCategories)
        Me.gbField.Controls.Add(Me.Label9)
        Me.gbField.Controls.Add(Me.Label8)
        Me.gbField.Controls.Add(Me.txtIDSubCategories)
        Me.gbField.Controls.Add(Me.Label7)
        Me.gbField.Controls.Add(Me.txtKodeKonten)
        Me.gbField.Controls.Add(Me.txtDeskripsi)
        Me.gbField.Controls.Add(Me.Label6)
        Me.gbField.Controls.Add(Me.Label11)
        Me.gbField.Controls.Add(Me.txtIDCategories)
        Me.gbField.Location = New System.Drawing.Point(1, 264)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(443, 323)
        Me.gbField.TabIndex = 12
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(304, 264)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(133, 53)
        Me.btnProses.TabIndex = 25
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(165, 264)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(133, 53)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAktif.Location = New System.Drawing.Point(93, 234)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(75, 24)
        Me.chkAktif.TabIndex = 24
        Me.chkAktif.Text = "Aktif?"
        Me.chkAktif.UseVisualStyleBackColor = True
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
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Kode Konten"
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
        'txtKodeKonten
        '
        Me.txtKodeKonten.Enabled = False
        Me.txtKodeKonten.Location = New System.Drawing.Point(93, 71)
        Me.txtKodeKonten.Name = "txtKodeKonten"
        Me.txtKodeKonten.Size = New System.Drawing.Size(116, 20)
        Me.txtKodeKonten.TabIndex = 15
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(93, 97)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(344, 128)
        Me.txtDeskripsi.TabIndex = 12
        Me.txtDeskripsi.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Deskripsi Konten"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 19)
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
        Me.GroupBox2.Controls.Add(Me.txtNamaFile)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.btnAddLampiran)
        Me.GroupBox2.Controls.Add(Me.txtPathLampiran)
        Me.GroupBox2.Controls.Add(Me.picCariLampiran)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 327)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar File"
        '
        'txtNamaFile
        '
        Me.txtNamaFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaFile.Location = New System.Drawing.Point(45, 18)
        Me.txtNamaFile.Name = "txtNamaFile"
        Me.txtNamaFile.Size = New System.Drawing.Size(214, 22)
        Me.txtNamaFile.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lblJumlahLampiran)
        Me.GroupBox4.Controls.Add(Me.btnHapusLampiran)
        Me.GroupBox4.Controls.Add(Me.dgvListLampiran)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(347, 253)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'lblJumlahLampiran
        '
        Me.lblJumlahLampiran.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahLampiran.AutoSize = True
        Me.lblJumlahLampiran.Location = New System.Drawing.Point(6, 227)
        Me.lblJumlahLampiran.Name = "lblJumlahLampiran"
        Me.lblJumlahLampiran.Size = New System.Drawing.Size(101, 13)
        Me.lblJumlahLampiran.TabIndex = 20
        Me.lblJumlahLampiran.Text = "Jumlah Lampiran : 0"
        '
        'btnHapusLampiran
        '
        Me.btnHapusLampiran.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapusLampiran.Location = New System.Drawing.Point(233, 222)
        Me.btnHapusLampiran.Name = "btnHapusLampiran"
        Me.btnHapusLampiran.Size = New System.Drawing.Size(108, 23)
        Me.btnHapusLampiran.TabIndex = 19
        Me.btnHapusLampiran.Text = "Hapus Lampiran"
        Me.btnHapusLampiran.UseVisualStyleBackColor = True
        '
        'dgvListLampiran
        '
        Me.dgvListLampiran.AllowUserToAddRows = False
        Me.dgvListLampiran.AllowUserToDeleteRows = False
        Me.dgvListLampiran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListLampiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListLampiran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttachID, Me.NamaFile, Me.Path})
        Me.dgvListLampiran.Location = New System.Drawing.Point(6, 11)
        Me.dgvListLampiran.Name = "dgvListLampiran"
        Me.dgvListLampiran.ReadOnly = True
        Me.dgvListLampiran.RowHeadersVisible = False
        Me.dgvListLampiran.Size = New System.Drawing.Size(335, 207)
        Me.dgvListLampiran.TabIndex = 0
        '
        'btnAddLampiran
        '
        Me.btnAddLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLampiran.Location = New System.Drawing.Point(264, 15)
        Me.btnAddLampiran.Name = "btnAddLampiran"
        Me.btnAddLampiran.Size = New System.Drawing.Size(97, 25)
        Me.btnAddLampiran.TabIndex = 27
        Me.btnAddLampiran.Text = "Add"
        Me.btnAddLampiran.UseVisualStyleBackColor = True
        '
        'txtPathLampiran
        '
        Me.txtPathLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathLampiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathLampiran.Location = New System.Drawing.Point(45, 43)
        Me.txtPathLampiran.Name = "txtPathLampiran"
        Me.txtPathLampiran.ReadOnly = True
        Me.txtPathLampiran.Size = New System.Drawing.Size(316, 22)
        Me.txtPathLampiran.TabIndex = 26
        '
        'picCariLampiran
        '
        Me.picCariLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCariLampiran.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picCariLampiran.Location = New System.Drawing.Point(14, 18)
        Me.picCariLampiran.Name = "picCariLampiran"
        Me.picCariLampiran.Size = New System.Drawing.Size(25, 22)
        Me.picCariLampiran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCariLampiran.TabIndex = 25
        Me.picCariLampiran.TabStop = False
        '
        'AttachID
        '
        Me.AttachID.HeaderText = "AttachID"
        Me.AttachID.Name = "AttachID"
        Me.AttachID.ReadOnly = True
        '
        'NamaFile
        '
        Me.NamaFile.HeaderText = "NamaFile"
        Me.NamaFile.Name = "NamaFile"
        Me.NamaFile.ReadOnly = True
        '
        'Path
        '
        Me.Path.HeaderText = "Path"
        Me.Path.Name = "Path"
        Me.Path.ReadOnly = True
        '
        'frmMasterKontenBantuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 593)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.dgvKonten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMasterKontenBantuan"
        Me.Text = "Konten Bantuan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKonten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtKodeKonten As System.Windows.Forms.TextBox
    Friend WithEvents txtDeskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIDCategories As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamaSubs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNamaCategories As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDSubCategories As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNamaFile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblJumlahLampiran As System.Windows.Forms.Label
    Friend WithEvents btnHapusLampiran As System.Windows.Forms.Button
    Friend WithEvents dgvListLampiran As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddLampiran As System.Windows.Forms.Button
    Friend WithEvents txtPathLampiran As System.Windows.Forms.TextBox
    Friend WithEvents picCariLampiran As System.Windows.Forms.PictureBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents AttachID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
