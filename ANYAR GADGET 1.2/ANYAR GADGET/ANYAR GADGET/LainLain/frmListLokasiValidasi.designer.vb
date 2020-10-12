<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListLokasiValidasi
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
        Me.txtJenisValidasi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFungsiValidasi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeValidasi = New System.Windows.Forms.TextBox()
        Me.dgvListLokasi = New System.Windows.Forms.DataGridView()
        Me.cmdBukaValidasi = New System.Windows.Forms.Button()
        Me.txtCatatan = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCabang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtkodeCabang = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRefNumber = New System.Windows.Forms.TextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListLokasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJenisValidasi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNotifikasi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFungsiValidasi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKodeValidasi)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtJenisValidasi
        '
        Me.txtJenisValidasi.Location = New System.Drawing.Point(86, 63)
        Me.txtJenisValidasi.Name = "txtJenisValidasi"
        Me.txtJenisValidasi.ReadOnly = True
        Me.txtJenisValidasi.Size = New System.Drawing.Size(297, 20)
        Me.txtJenisValidasi.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Jenis validasi"
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(84, 87)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.ReadOnly = True
        Me.txtNotifikasi.Size = New System.Drawing.Size(297, 51)
        Me.txtNotifikasi.TabIndex = 5
        Me.txtNotifikasi.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Notifikasi"
        '
        'txtFungsiValidasi
        '
        Me.txtFungsiValidasi.Location = New System.Drawing.Point(86, 38)
        Me.txtFungsiValidasi.Name = "txtFungsiValidasi"
        Me.txtFungsiValidasi.ReadOnly = True
        Me.txtFungsiValidasi.Size = New System.Drawing.Size(297, 20)
        Me.txtFungsiValidasi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fungsi Validasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Validasi"
        '
        'txtKodeValidasi
        '
        Me.txtKodeValidasi.Location = New System.Drawing.Point(86, 13)
        Me.txtKodeValidasi.Name = "txtKodeValidasi"
        Me.txtKodeValidasi.ReadOnly = True
        Me.txtKodeValidasi.Size = New System.Drawing.Size(297, 20)
        Me.txtKodeValidasi.TabIndex = 0
        '
        'dgvListLokasi
        '
        Me.dgvListLokasi.AllowUserToAddRows = False
        Me.dgvListLokasi.AllowUserToDeleteRows = False
        Me.dgvListLokasi.AllowUserToOrderColumns = True
        Me.dgvListLokasi.AllowUserToResizeColumns = False
        Me.dgvListLokasi.AllowUserToResizeRows = False
        Me.dgvListLokasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListLokasi.Location = New System.Drawing.Point(4, 179)
        Me.dgvListLokasi.Name = "dgvListLokasi"
        Me.dgvListLokasi.RowHeadersVisible = False
        Me.dgvListLokasi.Size = New System.Drawing.Size(294, 225)
        Me.dgvListLokasi.TabIndex = 2
        '
        'cmdBukaValidasi
        '
        Me.cmdBukaValidasi.Location = New System.Drawing.Point(304, 356)
        Me.cmdBukaValidasi.Name = "cmdBukaValidasi"
        Me.cmdBukaValidasi.Size = New System.Drawing.Size(204, 48)
        Me.cmdBukaValidasi.TabIndex = 3
        Me.cmdBukaValidasi.Text = "Buka Validasi"
        Me.cmdBukaValidasi.UseVisualStyleBackColor = True
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(305, 244)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.Size = New System.Drawing.Size(203, 59)
        Me.txtCatatan.TabIndex = 4
        Me.txtCatatan.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Catatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cabang  :"
        '
        'txtCabang
        '
        Me.txtCabang.Location = New System.Drawing.Point(360, 206)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.ReadOnly = True
        Me.txtCabang.Size = New System.Drawing.Size(148, 20)
        Me.txtCabang.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Daftar Lokasi Kontrol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Code      :"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(360, 179)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(148, 20)
        Me.txtCode.TabIndex = 10
        '
        'txtkodeCabang
        '
        Me.txtkodeCabang.Location = New System.Drawing.Point(360, 156)
        Me.txtkodeCabang.Name = "txtkodeCabang"
        Me.txtkodeCabang.ReadOnly = True
        Me.txtkodeCabang.Size = New System.Drawing.Size(148, 20)
        Me.txtkodeCabang.TabIndex = 11
        Me.txtkodeCabang.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ref Number"
        '
        'txtRefNumber
        '
        Me.txtRefNumber.Location = New System.Drawing.Point(350, 327)
        Me.txtRefNumber.Name = "txtRefNumber"
        Me.txtRefNumber.Size = New System.Drawing.Size(158, 20)
        Me.txtRefNumber.TabIndex = 13
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.browse
        Me.GunaPictureBox1.Location = New System.Drawing.Point(311, 322)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(33, 28)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 14
        Me.GunaPictureBox1.TabStop = False
        '
        'frmListLokasiValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 407)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txtRefNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtkodeCabang)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCabang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.cmdBukaValidasi)
        Me.Controls.Add(Me.dgvListLokasi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmListLokasiValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormListValidasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListLokasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFungsiValidasi As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvListLokasi As System.Windows.Forms.DataGridView
    Friend WithEvents cmdBukaValidasi As System.Windows.Forms.Button
    Friend WithEvents txtCatatan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCabang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeCabang As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisValidasi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRefNumber As System.Windows.Forms.TextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
