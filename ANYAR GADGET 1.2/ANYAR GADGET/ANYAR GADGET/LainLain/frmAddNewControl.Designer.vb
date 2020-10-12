<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewControl
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
        Me.cmdSaveAll = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtJenisOperasi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeJenis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFungsi = New System.Windows.Forms.RichTextBox()
        Me.cmbLokasi = New Guna.UI.WinForms.GunaComboBox()
        Me.txtNamaValidasi = New System.Windows.Forms.TextBox()
        Me.txtKodeValidasi = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvListCabang = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListCabang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSaveAll
        '
        Me.cmdSaveAll.AnimationHoverSpeed = 0.07!
        Me.cmdSaveAll.AnimationSpeed = 0.03!
        Me.cmdSaveAll.BackColor = System.Drawing.Color.Transparent
        Me.cmdSaveAll.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSaveAll.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSaveAll.BorderColor = System.Drawing.Color.Black
        Me.cmdSaveAll.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSaveAll.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSaveAll.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSaveAll.ForeColor = System.Drawing.Color.White
        Me.cmdSaveAll.Image = Nothing
        Me.cmdSaveAll.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSaveAll.Location = New System.Drawing.Point(-1, 258)
        Me.cmdSaveAll.Name = "cmdSaveAll"
        Me.cmdSaveAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSaveAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSaveAll.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSaveAll.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSaveAll.OnHoverImage = Nothing
        Me.cmdSaveAll.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSaveAll.Radius = 2
        Me.cmdSaveAll.Size = New System.Drawing.Size(193, 37)
        Me.cmdSaveAll.TabIndex = 63
        Me.cmdSaveAll.Text = "Save For All Location"
        Me.cmdSaveAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtJenisOperasi
        '
        Me.txtJenisOperasi.Location = New System.Drawing.Point(301, 79)
        Me.txtJenisOperasi.Name = "txtJenisOperasi"
        Me.txtJenisOperasi.Size = New System.Drawing.Size(110, 20)
        Me.txtJenisOperasi.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(225, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Jenis Operasi"
        '
        'txtKodeJenis
        '
        Me.txtKodeJenis.Enabled = False
        Me.txtKodeJenis.Location = New System.Drawing.Point(301, 51)
        Me.txtKodeJenis.Name = "txtKodeJenis"
        Me.txtKodeJenis.Size = New System.Drawing.Size(69, 20)
        Me.txtKodeJenis.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "KodeJenis"
        '
        'cmdSimpan
        '
        Me.cmdSimpan.AnimationHoverSpeed = 0.07!
        Me.cmdSimpan.AnimationSpeed = 0.03!
        Me.cmdSimpan.BackColor = System.Drawing.Color.Transparent
        Me.cmdSimpan.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdSimpan.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdSimpan.BorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.cmdSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdSimpan.ForeColor = System.Drawing.Color.White
        Me.cmdSimpan.Image = Nothing
        Me.cmdSimpan.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdSimpan.Location = New System.Drawing.Point(203, 258)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(217, 37)
        Me.cmdSimpan.TabIndex = 57
        Me.cmdSimpan.Text = "Simpan Untuk Satu Lokasi"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtNotifikasi)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFungsi)
        Me.Panel2.Location = New System.Drawing.Point(5, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 116)
        Me.Panel2.TabIndex = 56
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(196, 22)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.Size = New System.Drawing.Size(211, 88)
        Me.txtNotifikasi.TabIndex = 13
        Me.txtNotifikasi.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Notifikasi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fungsi Kontrol"
        '
        'txtFungsi
        '
        Me.txtFungsi.Location = New System.Drawing.Point(4, 22)
        Me.txtFungsi.Name = "txtFungsi"
        Me.txtFungsi.Size = New System.Drawing.Size(183, 88)
        Me.txtFungsi.TabIndex = 10
        Me.txtFungsi.Text = ""
        '
        'cmbLokasi
        '
        Me.cmbLokasi.BackColor = System.Drawing.Color.Transparent
        Me.cmbLokasi.BaseColor = System.Drawing.Color.White
        Me.cmbLokasi.BorderColor = System.Drawing.Color.Silver
        Me.cmbLokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLokasi.FocusedColor = System.Drawing.Color.Empty
        Me.cmbLokasi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbLokasi.ForeColor = System.Drawing.Color.Black
        Me.cmbLokasi.FormattingEnabled = True
        Me.cmbLokasi.Location = New System.Drawing.Point(100, 105)
        Me.cmbLokasi.Name = "cmbLokasi"
        Me.cmbLokasi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbLokasi.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbLokasi.Size = New System.Drawing.Size(311, 26)
        Me.cmbLokasi.TabIndex = 55
        '
        'txtNamaValidasi
        '
        Me.txtNamaValidasi.Location = New System.Drawing.Point(100, 79)
        Me.txtNamaValidasi.Name = "txtNamaValidasi"
        Me.txtNamaValidasi.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaValidasi.TabIndex = 54
        '
        'txtKodeValidasi
        '
        Me.txtKodeValidasi.Location = New System.Drawing.Point(100, 51)
        Me.txtKodeValidasi.Name = "txtKodeValidasi"
        Me.txtKodeValidasi.Size = New System.Drawing.Size(119, 20)
        Me.txtKodeValidasi.TabIndex = 53
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvListCabang)
        Me.Panel1.Controls.Add(Me.txtDocNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 42)
        Me.Panel1.TabIndex = 52
        '
        'txtDocNum
        '
        Me.txtDocNum.Location = New System.Drawing.Point(6, 12)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.Size = New System.Drawing.Size(122, 20)
        Me.txtDocNum.TabIndex = 1
        Me.txtDocNum.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Kode Validasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Nama Validasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Lokasi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.browse
        Me.PictureBox1.Location = New System.Drawing.Point(379, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'dgvListCabang
        '
        Me.dgvListCabang.AllowUserToAddRows = False
        Me.dgvListCabang.AllowUserToDeleteRows = False
        Me.dgvListCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCabang.Location = New System.Drawing.Point(140, 7)
        Me.dgvListCabang.Name = "dgvListCabang"
        Me.dgvListCabang.RowHeadersVisible = False
        Me.dgvListCabang.Size = New System.Drawing.Size(46, 35)
        Me.dgvListCabang.TabIndex = 2
        '
        'frmAddNewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 297)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSaveAll)
        Me.Controls.Add(Me.txtJenisOperasi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKodeJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbLokasi)
        Me.Controls.Add(Me.txtNamaValidasi)
        Me.Controls.Add(Me.txtKodeValidasi)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAddNewControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddNewControl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListCabang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSaveAll As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtJenisOperasi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKodeJenis As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFungsi As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbLokasi As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtNamaValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeValidasi As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvListCabang As System.Windows.Forms.DataGridView
End Class
