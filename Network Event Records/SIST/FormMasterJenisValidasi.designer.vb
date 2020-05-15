<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterJenisValidasi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.txtNamaExternal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbKelompokValidasi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJenisValidasi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCariJenisValidasi = New System.Windows.Forms.TextBox()
        Me.dgMasterJenisValidasi = New System.Windows.Forms.DataGridView()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdbatal = New System.Windows.Forms.Button()
        Me.txtKdjenisValidasi = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMasterJenisValidasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Jenis Validasi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAktif)
        Me.GroupBox1.Controls.Add(Me.txtNamaExternal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbKelompokValidasi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtJenisValidasi)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 103)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(530, 70)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(47, 17)
        Me.chkAktif.TabIndex = 14
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'txtNamaExternal
        '
        Me.txtNamaExternal.Location = New System.Drawing.Point(133, 67)
        Me.txtNamaExternal.Name = "txtNamaExternal"
        Me.txtNamaExternal.Size = New System.Drawing.Size(346, 20)
        Me.txtNamaExternal.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nama External"
        '
        'cmbKelompokValidasi
        '
        Me.cmbKelompokValidasi.FormattingEnabled = True
        Me.cmbKelompokValidasi.Location = New System.Drawing.Point(133, 40)
        Me.cmbKelompokValidasi.Name = "cmbKelompokValidasi"
        Me.cmbKelompokValidasi.Size = New System.Drawing.Size(444, 21)
        Me.cmbKelompokValidasi.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kelompok Validasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Jenis Validasi"
        '
        'txtJenisValidasi
        '
        Me.txtJenisValidasi.Location = New System.Drawing.Point(133, 16)
        Me.txtJenisValidasi.Name = "txtJenisValidasi"
        Me.txtJenisValidasi.Size = New System.Drawing.Size(444, 20)
        Me.txtJenisValidasi.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cari"
        '
        'txtCariJenisValidasi
        '
        Me.txtCariJenisValidasi.Location = New System.Drawing.Point(43, 216)
        Me.txtCariJenisValidasi.Name = "txtCariJenisValidasi"
        Me.txtCariJenisValidasi.Size = New System.Drawing.Size(546, 20)
        Me.txtCariJenisValidasi.TabIndex = 10
        '
        'dgMasterJenisValidasi
        '
        Me.dgMasterJenisValidasi.AllowUserToAddRows = False
        Me.dgMasterJenisValidasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMasterJenisValidasi.Location = New System.Drawing.Point(15, 242)
        Me.dgMasterJenisValidasi.Name = "dgMasterJenisValidasi"
        Me.dgMasterJenisValidasi.ReadOnly = True
        Me.dgMasterJenisValidasi.Size = New System.Drawing.Size(574, 132)
        Me.dgMasterJenisValidasi.TabIndex = 11
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(348, 165)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(112, 45)
        Me.cmdSimpan.TabIndex = 12
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdbatal
        '
        Me.cmdbatal.Location = New System.Drawing.Point(477, 165)
        Me.cmdbatal.Name = "cmdbatal"
        Me.cmdbatal.Size = New System.Drawing.Size(112, 45)
        Me.cmdbatal.TabIndex = 13
        Me.cmdbatal.Text = "Batal"
        Me.cmdbatal.UseVisualStyleBackColor = True
        '
        'txtKdjenisValidasi
        '
        Me.txtKdjenisValidasi.Location = New System.Drawing.Point(43, 6)
        Me.txtKdjenisValidasi.Name = "txtKdjenisValidasi"
        Me.txtKdjenisValidasi.Size = New System.Drawing.Size(101, 20)
        Me.txtKdjenisValidasi.TabIndex = 14
        Me.txtKdjenisValidasi.Visible = False
        '
        'FormMasterJenisValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 386)
        Me.Controls.Add(Me.txtKdjenisValidasi)
        Me.Controls.Add(Me.cmdbatal)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.dgMasterJenisValidasi)
        Me.Controls.Add(Me.txtCariJenisValidasi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMasterJenisValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Jenis Validasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgMasterJenisValidasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamaExternal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbKelompokValidasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJenisValidasi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCariJenisValidasi As System.Windows.Forms.TextBox
    Friend WithEvents dgMasterJenisValidasi As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdbatal As System.Windows.Forms.Button
    Friend WithEvents txtKdjenisValidasi As System.Windows.Forms.TextBox
End Class
