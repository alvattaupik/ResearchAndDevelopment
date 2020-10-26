<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListKendaraan
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
        Me.picSearch = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picNew = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.txtKodeNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTipeKendaraan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoKendaraan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbListKendaraan = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvListKendaraan = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbListKendaraan.SuspendLayout()
        CType(Me.dgvListKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.picSearch)
        Me.GroupBox1.Controls.Add(Me.picNew)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Kendaraan"
        '
        'picSearch
        '
        Me.picSearch.BackColor = System.Drawing.Color.Transparent
        Me.picSearch.BaseColor = System.Drawing.Color.Black
        Me.picSearch.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picSearch.Location = New System.Drawing.Point(63, 15)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(37, 38)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSearch.TabIndex = 4
        Me.picSearch.TabStop = False
        '
        'picNew
        '
        Me.picNew.BackColor = System.Drawing.Color.Transparent
        Me.picNew.BaseColor = System.Drawing.Color.Black
        Me.picNew.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_Document
        Me.picNew.Location = New System.Drawing.Point(19, 16)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(38, 37)
        Me.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNew.TabIndex = 3
        Me.picNew.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(316, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.ReadOnly = True
        Me.txtCari.Size = New System.Drawing.Size(366, 26)
        Me.txtCari.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProses)
        Me.GroupBox2.Controls.Add(Me.txtKodeNama)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbCabang)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTipeKendaraan)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNoKendaraan)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtKode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 216)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parameter"
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(139, 166)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(366, 44)
        Me.btnProses.TabIndex = 12
        Me.btnProses.Text = "Ok"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'txtKodeNama
        '
        Me.txtKodeNama.Enabled = False
        Me.txtKodeNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeNama.Location = New System.Drawing.Point(139, 133)
        Me.txtKodeNama.Name = "txtKodeNama"
        Me.txtKodeNama.Size = New System.Drawing.Size(366, 26)
        Me.txtKodeNama.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Kode Nama"
        '
        'cmbCabang
        '
        Me.cmbCabang.Enabled = False
        Me.cmbCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(139, 103)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(366, 26)
        Me.cmbCabang.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cabang"
        '
        'txtTipeKendaraan
        '
        Me.txtTipeKendaraan.Enabled = False
        Me.txtTipeKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipeKendaraan.Location = New System.Drawing.Point(139, 74)
        Me.txtTipeKendaraan.Name = "txtTipeKendaraan"
        Me.txtTipeKendaraan.Size = New System.Drawing.Size(366, 26)
        Me.txtTipeKendaraan.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipe Kendaraan"
        '
        'txtNoKendaraan
        '
        Me.txtNoKendaraan.Enabled = False
        Me.txtNoKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoKendaraan.Location = New System.Drawing.Point(139, 44)
        Me.txtNoKendaraan.Name = "txtNoKendaraan"
        Me.txtNoKendaraan.Size = New System.Drawing.Size(366, 26)
        Me.txtNoKendaraan.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No Kendaraan"
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode.Location = New System.Drawing.Point(139, 14)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(366, 26)
        Me.txtKode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode"
        '
        'gbListKendaraan
        '
        Me.gbListKendaraan.Controls.Add(Me.btnClose)
        Me.gbListKendaraan.Controls.Add(Me.dgvListKendaraan)
        Me.gbListKendaraan.Controls.Add(Me.PictureBox1)
        Me.gbListKendaraan.Location = New System.Drawing.Point(2, 79)
        Me.gbListKendaraan.Name = "gbListKendaraan"
        Me.gbListKendaraan.Size = New System.Drawing.Size(714, 251)
        Me.gbListKendaraan.TabIndex = 2
        Me.gbListKendaraan.TabStop = False
        Me.gbListKendaraan.Text = "ListKendaraan"
        Me.gbListKendaraan.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(591, 222)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvListKendaraan
        '
        Me.dgvListKendaraan.AllowUserToAddRows = False
        Me.dgvListKendaraan.AllowUserToDeleteRows = False
        Me.dgvListKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKendaraan.Location = New System.Drawing.Point(7, 20)
        Me.dgvListKendaraan.Name = "dgvListKendaraan"
        Me.dgvListKendaraan.ReadOnly = True
        Me.dgvListKendaraan.RowHeadersVisible = False
        Me.dgvListKendaraan.Size = New System.Drawing.Size(701, 196)
        Me.dgvListKendaraan.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(12, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ANYAR_GADGET.My.Resources.Resources.Car
        Me.PictureBox2.Location = New System.Drawing.Point(13, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(171, 208)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'frmListKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 313)
        Me.Controls.Add(Me.gbListKendaraan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmListKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Kendaraan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbListKendaraan.ResumeLayout(False)
        CType(Me.dgvListKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picNew As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipeKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picSearch As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents gbListKendaraan As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvListKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
