<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterNewAssets
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvAssetList = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSimpanKeDaftar = New System.Windows.Forms.Button()
        Me.txtSpesifikasi = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSubKategori = New System.Windows.Forms.ComboBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picEdit = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picDelete = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picManual = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picBrowseAssets = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvAssetList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrowseAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 446)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.picEdit)
        Me.GroupBox4.Controls.Add(Me.txtCari)
        Me.GroupBox4.Controls.Add(Me.picDelete)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.dgvAssetList)
        Me.GroupBox4.Location = New System.Drawing.Point(249, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(459, 286)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(115, 16)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(338, 26)
        Me.txtCari.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cari"
        '
        'dgvAssetList
        '
        Me.dgvAssetList.AllowUserToAddRows = False
        Me.dgvAssetList.AllowUserToDeleteRows = False
        Me.dgvAssetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssetList.Location = New System.Drawing.Point(6, 44)
        Me.dgvAssetList.Name = "dgvAssetList"
        Me.dgvAssetList.ReadOnly = True
        Me.dgvAssetList.RowHeadersVisible = False
        Me.dgvAssetList.Size = New System.Drawing.Size(447, 192)
        Me.dgvAssetList.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.picManual)
        Me.GroupBox3.Controls.Add(Me.btnSimpanKeDaftar)
        Me.GroupBox3.Controls.Add(Me.picBrowseAssets)
        Me.GroupBox3.Controls.Add(Me.txtSpesifikasi)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtItemName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtItemCode)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 286)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manual Register"
        '
        'btnSimpanKeDaftar
        '
        Me.btnSimpanKeDaftar.Location = New System.Drawing.Point(70, 248)
        Me.btnSimpanKeDaftar.Name = "btnSimpanKeDaftar"
        Me.btnSimpanKeDaftar.Size = New System.Drawing.Size(154, 32)
        Me.btnSimpanKeDaftar.TabIndex = 8
        Me.btnSimpanKeDaftar.Text = "Simpan Ke Daftar"
        Me.btnSimpanKeDaftar.UseVisualStyleBackColor = True
        '
        'txtSpesifikasi
        '
        Me.txtSpesifikasi.Location = New System.Drawing.Point(70, 157)
        Me.txtSpesifikasi.Name = "txtSpesifikasi"
        Me.txtSpesifikasi.Size = New System.Drawing.Size(154, 85)
        Me.txtSpesifikasi.TabIndex = 5
        Me.txtSpesifikasi.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Spesifikasi"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(70, 101)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(154, 50)
        Me.txtItemName.TabIndex = 3
        Me.txtItemName.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Item Name"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(70, 75)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(154, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Item Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GroupBox2.Controls.Add(Me.cmbSubKategori)
        Me.GroupBox2.Controls.Add(Me.cmbKategori)
        Me.GroupBox2.Controls.Add(Me.cmbCabang)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 124)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmbSubKategori
        '
        Me.cmbSubKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubKategori.FormattingEnabled = True
        Me.cmbSubKategori.Location = New System.Drawing.Point(351, 83)
        Me.cmbSubKategori.Name = "cmbSubKategori"
        Me.cmbSubKategori.Size = New System.Drawing.Size(338, 28)
        Me.cmbSubKategori.TabIndex = 5
        '
        'cmbKategori
        '
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(351, 47)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(338, 28)
        Me.cmbKategori.TabIndex = 4
        '
        'cmbCabang
        '
        Me.cmbCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(351, 14)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(338, 28)
        Me.cmbCabang.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sub Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cabang"
        '
        'picEdit
        '
        Me.picEdit.BackColor = System.Drawing.Color.Transparent
        Me.picEdit.BaseColor = System.Drawing.Color.Black
        Me.picEdit.Image = Global.ANYAR_GADGET.My.Resources.Resources.Edit_Data
        Me.picEdit.Location = New System.Drawing.Point(371, 242)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(38, 38)
        Me.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEdit.TabIndex = 8
        Me.picEdit.TabStop = False
        '
        'picDelete
        '
        Me.picDelete.BackColor = System.Drawing.Color.Transparent
        Me.picDelete.BaseColor = System.Drawing.Color.Black
        Me.picDelete.Image = Global.ANYAR_GADGET.My.Resources.Resources.Cancel
        Me.picDelete.Location = New System.Drawing.Point(415, 242)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(38, 38)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDelete.TabIndex = 7
        Me.picDelete.TabStop = False
        '
        'picManual
        '
        Me.picManual.BackColor = System.Drawing.Color.Transparent
        Me.picManual.BaseColor = System.Drawing.Color.Black
        Me.picManual.Image = Global.ANYAR_GADGET.My.Resources.Resources.Pick_Manual
        Me.picManual.Location = New System.Drawing.Point(122, 19)
        Me.picManual.Name = "picManual"
        Me.picManual.Size = New System.Drawing.Size(49, 50)
        Me.picManual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManual.TabIndex = 9
        Me.picManual.TabStop = False
        '
        'picBrowseAssets
        '
        Me.picBrowseAssets.BackColor = System.Drawing.Color.Transparent
        Me.picBrowseAssets.BaseColor = System.Drawing.Color.Black
        Me.picBrowseAssets.Image = Global.ANYAR_GADGET.My.Resources.Resources.browse
        Me.picBrowseAssets.Location = New System.Drawing.Point(70, 19)
        Me.picBrowseAssets.Name = "picBrowseAssets"
        Me.picBrowseAssets.Size = New System.Drawing.Size(46, 50)
        Me.picBrowseAssets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrowseAssets.TabIndex = 6
        Me.picBrowseAssets.TabStop = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Asset_Management
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(114, 117)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 6
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'frmMasterNewAssets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMasterNewAssets"
        Me.Text = "frmRegisterNewAssets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvAssetList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrowseAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvAssetList As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSpesifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSubKategori As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picBrowseAssets As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents picDelete As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents picManual As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btnSimpanKeDaftar As System.Windows.Forms.Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents picEdit As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
