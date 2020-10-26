<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKonten
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSubCategories = New System.Windows.Forms.ComboBox()
        Me.cmbHeaders = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListKonten = New System.Windows.Forms.DataGridView()
        Me.gbField = New System.Windows.Forms.GroupBox()
        Me.txtSubKategori = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaKategori = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDSub = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSolutions = New System.Windows.Forms.RichTextBox()
        Me.cboAktif = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnHapusLampiran = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahLampiran = New System.Windows.Forms.Label()
        Me.dgvListLampiran = New System.Windows.Forms.DataGridView()
        Me.KodeKonten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddLampiran = New System.Windows.Forms.Button()
        Me.txtPathLampiran = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtNamaFile = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.picCariLampiran = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListKonten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSubCategories)
        Me.GroupBox1.Controls.Add(Me.cmbHeaders)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(109, 74)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(733, 20)
        Me.txtCari.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sub Categories"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Categories"
        '
        'cmbSubCategories
        '
        Me.cmbSubCategories.FormattingEnabled = True
        Me.cmbSubCategories.Location = New System.Drawing.Point(109, 47)
        Me.cmbSubCategories.Name = "cmbSubCategories"
        Me.cmbSubCategories.Size = New System.Drawing.Size(733, 21)
        Me.cmbSubCategories.TabIndex = 9
        '
        'cmbHeaders
        '
        Me.cmbHeaders.FormattingEnabled = True
        Me.cmbHeaders.Location = New System.Drawing.Point(109, 16)
        Me.cmbHeaders.Name = "cmbHeaders"
        Me.cmbHeaders.Size = New System.Drawing.Size(733, 21)
        Me.cmbHeaders.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "List Konten"
        '
        'dgvListKonten
        '
        Me.dgvListKonten.AllowUserToAddRows = False
        Me.dgvListKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKonten.Location = New System.Drawing.Point(111, 116)
        Me.dgvListKonten.Name = "dgvListKonten"
        Me.dgvListKonten.ReadOnly = True
        Me.dgvListKonten.RowHeadersVisible = False
        Me.dgvListKonten.Size = New System.Drawing.Size(739, 166)
        Me.dgvListKonten.TabIndex = 9
        '
        'gbField
        '
        Me.gbField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbField.Controls.Add(Me.txtSubKategori)
        Me.gbField.Controls.Add(Me.Label5)
        Me.gbField.Controls.Add(Me.txtNamaKategori)
        Me.gbField.Controls.Add(Me.Label3)
        Me.gbField.Controls.Add(Me.txtIDSub)
        Me.gbField.Controls.Add(Me.Label10)
        Me.gbField.Controls.Add(Me.txtID)
        Me.gbField.Controls.Add(Me.Label9)
        Me.gbField.Controls.Add(Me.txtSolutions)
        Me.gbField.Controls.Add(Me.cboAktif)
        Me.gbField.Controls.Add(Me.Label4)
        Me.gbField.Controls.Add(Me.Label11)
        Me.gbField.Controls.Add(Me.txtKode)
        Me.gbField.Location = New System.Drawing.Point(7, 289)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(443, 313)
        Me.gbField.TabIndex = 11
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'txtSubKategori
        '
        Me.txtSubKategori.Location = New System.Drawing.Point(154, 75)
        Me.txtSubKategori.Name = "txtSubKategori"
        Me.txtSubKategori.ReadOnly = True
        Me.txtSubKategori.Size = New System.Drawing.Size(273, 20)
        Me.txtSubKategori.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sub Kategori"
        '
        'txtNamaKategori
        '
        Me.txtNamaKategori.Location = New System.Drawing.Point(154, 43)
        Me.txtNamaKategori.Name = "txtNamaKategori"
        Me.txtNamaKategori.ReadOnly = True
        Me.txtNamaKategori.Size = New System.Drawing.Size(273, 20)
        Me.txtNamaKategori.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kategori"
        '
        'txtIDSub
        '
        Me.txtIDSub.Location = New System.Drawing.Point(321, 12)
        Me.txtIDSub.Name = "txtIDSub"
        Me.txtIDSub.ReadOnly = True
        Me.txtIDSub.Size = New System.Drawing.Size(106, 20)
        Me.txtIDSub.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(266, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ID SUBS"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(154, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(106, 20)
        Me.txtID.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "IDCategori"
        '
        'txtSolutions
        '
        Me.txtSolutions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSolutions.Location = New System.Drawing.Point(154, 129)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.Size = New System.Drawing.Size(273, 77)
        Me.txtSolutions.TabIndex = 12
        Me.txtSolutions.Text = ""
        '
        'cboAktif
        '
        Me.cboAktif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboAktif.AutoSize = True
        Me.cboAktif.Location = New System.Drawing.Point(154, 212)
        Me.cboAktif.Name = "cboAktif"
        Me.cboAktif.Size = New System.Drawing.Size(53, 17)
        Me.cboAktif.TabIndex = 8
        Me.cboAktif.Text = "Aktif?"
        Me.cboAktif.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Kode Konten"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(154, 103)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(273, 20)
        Me.txtKode.TabIndex = 1
        '
        'btnHapusLampiran
        '
        Me.btnHapusLampiran.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapusLampiran.Location = New System.Drawing.Point(233, 237)
        Me.btnHapusLampiran.Name = "btnHapusLampiran"
        Me.btnHapusLampiran.Size = New System.Drawing.Size(97, 23)
        Me.btnHapusLampiran.TabIndex = 19
        Me.btnHapusLampiran.Text = "Hapus Lampiran"
        Me.btnHapusLampiran.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lblJumlahLampiran)
        Me.GroupBox4.Controls.Add(Me.btnHapusLampiran)
        Me.GroupBox4.Controls.Add(Me.dgvListLampiran)
        Me.GroupBox4.Location = New System.Drawing.Point(497, 342)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(347, 268)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'lblJumlahLampiran
        '
        Me.lblJumlahLampiran.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahLampiran.AutoSize = True
        Me.lblJumlahLampiran.Location = New System.Drawing.Point(6, 242)
        Me.lblJumlahLampiran.Name = "lblJumlahLampiran"
        Me.lblJumlahLampiran.Size = New System.Drawing.Size(101, 13)
        Me.lblJumlahLampiran.TabIndex = 20
        Me.lblJumlahLampiran.Text = "Jumlah Lampiran : 0"
        '
        'dgvListLampiran
        '
        Me.dgvListLampiran.AllowUserToAddRows = False
        Me.dgvListLampiran.AllowUserToDeleteRows = False
        Me.dgvListLampiran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListLampiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListLampiran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeKonten, Me.NamaFile, Me.Path})
        Me.dgvListLampiran.Location = New System.Drawing.Point(6, 11)
        Me.dgvListLampiran.Name = "dgvListLampiran"
        Me.dgvListLampiran.ReadOnly = True
        Me.dgvListLampiran.RowHeadersVisible = False
        Me.dgvListLampiran.Size = New System.Drawing.Size(335, 222)
        Me.dgvListLampiran.TabIndex = 0
        '
        'KodeKonten
        '
        Me.KodeKonten.HeaderText = "KodeKonten"
        Me.KodeKonten.Name = "KodeKonten"
        Me.KodeKonten.ReadOnly = True
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
        'btnAddLampiran
        '
        Me.btnAddLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLampiran.Location = New System.Drawing.Point(747, 296)
        Me.btnAddLampiran.Name = "btnAddLampiran"
        Me.btnAddLampiran.Size = New System.Drawing.Size(97, 21)
        Me.btnAddLampiran.TabIndex = 22
        Me.btnAddLampiran.Text = "Add"
        Me.btnAddLampiran.UseVisualStyleBackColor = True
        '
        'txtPathLampiran
        '
        Me.txtPathLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathLampiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathLampiran.Location = New System.Drawing.Point(528, 320)
        Me.txtPathLampiran.Name = "txtPathLampiran"
        Me.txtPathLampiran.ReadOnly = True
        Me.txtPathLampiran.Size = New System.Drawing.Size(316, 22)
        Me.txtPathLampiran.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtNamaFile
        '
        Me.txtNamaFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaFile.Location = New System.Drawing.Point(528, 295)
        Me.txtNamaFile.Name = "txtNamaFile"
        Me.txtNamaFile.Size = New System.Drawing.Size(214, 22)
        Me.txtNamaFile.TabIndex = 24
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(856, 315)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(106, 61)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Location = New System.Drawing.Point(856, 447)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(106, 61)
        Me.btnProses.TabIndex = 26
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'picCariLampiran
        '
        Me.picCariLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCariLampiran.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picCariLampiran.Location = New System.Drawing.Point(497, 295)
        Me.picCariLampiran.Name = "picCariLampiran"
        Me.picCariLampiran.Size = New System.Drawing.Size(25, 22)
        Me.picCariLampiran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCariLampiran.TabIndex = 20
        Me.picCariLampiran.TabStop = False
        '
        'frmKonten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 629)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtNamaFile)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAddLampiran)
        Me.Controls.Add(Me.txtPathLampiran)
        Me.Controls.Add(Me.picCariLampiran)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvListKonten)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmKonten"
        Me.Text = "frmKonten"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListKonten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSubCategories As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHeaders As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvListKonten As System.Windows.Forms.DataGridView
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDSub As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSolutions As System.Windows.Forms.RichTextBox
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents btnHapusLampiran As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListLampiran As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddLampiran As System.Windows.Forms.Button
    Friend WithEvents txtPathLampiran As System.Windows.Forms.TextBox
    Friend WithEvents picCariLampiran As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtSubKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaFile As System.Windows.Forms.TextBox
    Friend WithEvents KodeKonten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblJumlahLampiran As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
End Class
