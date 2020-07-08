<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertsSetup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgDaftarUser = New System.Windows.Forms.DataGridView()
        Me.txtCariUsers = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dgDaftarKomponen = New System.Windows.Forms.DataGridView()
        Me.txtCariKomponen = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKodeKomponen = New System.Windows.Forms.TextBox()
        Me.txtNamaKomponen = New System.Windows.Forms.TextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.txtSatuanWaktu = New System.Windows.Forms.TextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDurasi = New System.Windows.Forms.TextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNamaUser = New System.Windows.Forms.TextBox()
        Me.txtKodeUser = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDaftarUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDaftarKomponen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Location = New System.Drawing.Point(129, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 107)
        Me.Panel1.TabIndex = 1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(71, 31)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(364, 32)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Alerts And Notifications Setup"
        '
        'dgDaftarUser
        '
        Me.dgDaftarUser.AllowUserToAddRows = False
        Me.dgDaftarUser.AllowUserToDeleteRows = False
        Me.dgDaftarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarUser.Location = New System.Drawing.Point(2, 150)
        Me.dgDaftarUser.Name = "dgDaftarUser"
        Me.dgDaftarUser.ReadOnly = True
        Me.dgDaftarUser.Size = New System.Drawing.Size(274, 126)
        Me.dgDaftarUser.TabIndex = 2
        '
        'txtCariUsers
        '
        Me.txtCariUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariUsers.Location = New System.Drawing.Point(95, 118)
        Me.txtCariUsers.Name = "txtCariUsers"
        Me.txtCariUsers.Size = New System.Drawing.Size(181, 26)
        Me.txtCariUsers.TabIndex = 3
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(13, 124)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(54, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Cari User"
        '
        'dgDaftarKomponen
        '
        Me.dgDaftarKomponen.AllowUserToAddRows = False
        Me.dgDaftarKomponen.AllowUserToDeleteRows = False
        Me.dgDaftarKomponen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarKomponen.Location = New System.Drawing.Point(2, 320)
        Me.dgDaftarKomponen.Name = "dgDaftarKomponen"
        Me.dgDaftarKomponen.ReadOnly = True
        Me.dgDaftarKomponen.Size = New System.Drawing.Size(274, 117)
        Me.dgDaftarKomponen.TabIndex = 5
        '
        'txtCariKomponen
        '
        Me.txtCariKomponen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariKomponen.Location = New System.Drawing.Point(95, 288)
        Me.txtCariKomponen.Name = "txtCariKomponen"
        Me.txtCariKomponen.Size = New System.Drawing.Size(181, 26)
        Me.txtCariKomponen.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtKodeKomponen)
        Me.Panel2.Controls.Add(Me.txtNamaKomponen)
        Me.Panel2.Controls.Add(Me.GunaLabel9)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Controls.Add(Me.txtSatuanWaktu)
        Me.Panel2.Controls.Add(Me.GunaLabel8)
        Me.Panel2.Controls.Add(Me.GunaLabel7)
        Me.Panel2.Controls.Add(Me.txtDurasi)
        Me.Panel2.Controls.Add(Me.GunaLabel6)
        Me.Panel2.Controls.Add(Me.txtNamaUser)
        Me.Panel2.Controls.Add(Me.txtKodeUser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.GunaLabel5)
        Me.Panel2.Controls.Add(Me.GunaLabel4)
        Me.Panel2.Location = New System.Drawing.Point(282, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 319)
        Me.Panel2.TabIndex = 8
        '
        'txtKodeKomponen
        '
        Me.txtKodeKomponen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeKomponen.Location = New System.Drawing.Point(148, 119)
        Me.txtKodeKomponen.MaxLength = 1
        Me.txtKodeKomponen.Name = "txtKodeKomponen"
        Me.txtKodeKomponen.ReadOnly = True
        Me.txtKodeKomponen.Size = New System.Drawing.Size(212, 26)
        Me.txtKodeKomponen.TabIndex = 20
        '
        'txtNamaKomponen
        '
        Me.txtNamaKomponen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKomponen.Location = New System.Drawing.Point(148, 92)
        Me.txtNamaKomponen.MaxLength = 1
        Me.txtNamaKomponen.Name = "txtNamaKomponen"
        Me.txtNamaKomponen.ReadOnly = True
        Me.txtNamaKomponen.Size = New System.Drawing.Size(212, 26)
        Me.txtNamaKomponen.TabIndex = 19
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(3, 92)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(144, 21)
        Me.GunaLabel9.TabIndex = 18
        Me.GunaLabel9.Text = "Nama Komponen"
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(8, 255)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(352, 54)
        Me.cmdSimpan.TabIndex = 17
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'txtSatuanWaktu
        '
        Me.txtSatuanWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuanWaktu.Location = New System.Drawing.Point(148, 166)
        Me.txtSatuanWaktu.MaxLength = 1
        Me.txtSatuanWaktu.Name = "txtSatuanWaktu"
        Me.txtSatuanWaktu.Size = New System.Drawing.Size(212, 26)
        Me.txtSatuanWaktu.TabIndex = 16
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(184, 148)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(118, 15)
        Me.GunaLabel8.TabIndex = 15
        Me.GunaLabel8.Text = "(H: Hour , M:Minute)"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(3, 168)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(116, 21)
        Me.GunaLabel7.TabIndex = 14
        Me.GunaLabel7.Text = "Satuan Waktu"
        '
        'txtDurasi
        '
        Me.txtDurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDurasi.Location = New System.Drawing.Point(148, 200)
        Me.txtDurasi.Name = "txtDurasi"
        Me.txtDurasi.Size = New System.Drawing.Size(212, 26)
        Me.txtDurasi.TabIndex = 13
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(4, 204)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(59, 21)
        Me.GunaLabel6.TabIndex = 12
        Me.GunaLabel6.Text = "Durasi"
        '
        'txtNamaUser
        '
        Me.txtNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaUser.Location = New System.Drawing.Point(148, 38)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.ReadOnly = True
        Me.txtNamaUser.Size = New System.Drawing.Size(212, 26)
        Me.txtNamaUser.TabIndex = 11
        '
        'txtKodeUser
        '
        Me.txtKodeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeUser.Location = New System.Drawing.Point(148, 6)
        Me.txtKodeUser.Name = "txtKodeUser"
        Me.txtKodeUser.ReadOnly = True
        Me.txtKodeUser.Size = New System.Drawing.Size(212, 26)
        Me.txtKodeUser.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(8, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 10)
        Me.Panel3.TabIndex = 9
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(3, 40)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(94, 21)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Nama User"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(3, 8)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(87, 21)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Kode User"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(-1, 293)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel3.TabIndex = 6
        Me.GunaLabel3.Text = "Cari Komponen"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.AnyarGadget.My.Resources.Resources._772409_music_512x5121
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(2, -1)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(121, 112)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'AlertsSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 440)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtCariKomponen)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.dgDaftarKomponen)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtCariUsers)
        Me.Controls.Add(Me.dgDaftarUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "AlertsSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AlertsSetup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDaftarUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDaftarKomponen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgDaftarUser As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariUsers As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgDaftarKomponen As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariKomponen As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents txtSatuanWaktu As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDurasi As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeUser As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKomponen As System.Windows.Forms.TextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtKodeKomponen As System.Windows.Forms.TextBox
End Class
