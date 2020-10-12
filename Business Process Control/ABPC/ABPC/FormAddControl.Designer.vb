<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddControl
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKodeValidasi = New System.Windows.Forms.TextBox()
        Me.txtNamaValidasi = New System.Windows.Forms.TextBox()
        Me.cmbLokasi = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFungsi = New System.Windows.Forms.RichTextBox()
        Me.cmdSimpan = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKodeJenis = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmdNew = New Guna.UI.WinForms.GunaGradientButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJenisOperasi = New System.Windows.Forms.TextBox()
        Me.dgAllCabang = New System.Windows.Forms.DataGridView()
        Me.cmdSaveAll = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgAllCabang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtDocNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 42)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ABPC.My.Resources.Resources.control_accesos
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtDocNum
        '
        Me.txtDocNum.Location = New System.Drawing.Point(284, 28)
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
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Validasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Validasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lokasi Kontrol"
        '
        'txtKodeValidasi
        '
        Me.txtKodeValidasi.Location = New System.Drawing.Point(88, 60)
        Me.txtKodeValidasi.Name = "txtKodeValidasi"
        Me.txtKodeValidasi.Size = New System.Drawing.Size(119, 20)
        Me.txtKodeValidasi.TabIndex = 10
        '
        'txtNamaValidasi
        '
        Me.txtNamaValidasi.Location = New System.Drawing.Point(88, 88)
        Me.txtNamaValidasi.Name = "txtNamaValidasi"
        Me.txtNamaValidasi.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaValidasi.TabIndex = 11
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
        Me.cmbLokasi.Location = New System.Drawing.Point(88, 114)
        Me.cmbLokasi.Name = "cmbLokasi"
        Me.cmbLokasi.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbLokasi.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbLokasi.Size = New System.Drawing.Size(336, 26)
        Me.cmbLokasi.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtNotifikasi)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFungsi)
        Me.Panel2.Location = New System.Drawing.Point(9, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(415, 116)
        Me.Panel2.TabIndex = 15
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
        Me.cmdSimpan.Location = New System.Drawing.Point(289, 272)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSimpan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSimpan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSimpan.OnHoverImage = Nothing
        Me.cmdSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSimpan.Radius = 2
        Me.cmdSimpan.Size = New System.Drawing.Size(135, 37)
        Me.cmdSimpan.TabIndex = 44
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "KodeJenis"
        '
        'txtKodeJenis
        '
        Me.txtKodeJenis.Enabled = False
        Me.txtKodeJenis.Location = New System.Drawing.Point(289, 60)
        Me.txtKodeJenis.Name = "txtKodeJenis"
        Me.txtKodeJenis.Size = New System.Drawing.Size(69, 20)
        Me.txtKodeJenis.TabIndex = 46
        '
        'cmdLogin
        '
        Me.cmdLogin.AnimationHoverSpeed = 0.07!
        Me.cmdLogin.AnimationSpeed = 0.03!
        Me.cmdLogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdLogin.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdLogin.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdLogin.BorderColor = System.Drawing.Color.Black
        Me.cmdLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdLogin.FocusedColor = System.Drawing.Color.Empty
        Me.cmdLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.Image = Nothing
        Me.cmdLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdLogin.Location = New System.Drawing.Point(364, 57)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLogin.OnHoverImage = Nothing
        Me.cmdLogin.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLogin.Radius = 2
        Me.cmdLogin.Size = New System.Drawing.Size(56, 26)
        Me.cmdLogin.TabIndex = 47
        Me.cmdLogin.Text = "Browse.."
        Me.cmdLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdNew
        '
        Me.cmdNew.AnimationHoverSpeed = 0.07!
        Me.cmdNew.AnimationSpeed = 0.03!
        Me.cmdNew.BackColor = System.Drawing.Color.Transparent
        Me.cmdNew.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdNew.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdNew.BorderColor = System.Drawing.Color.Black
        Me.cmdNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdNew.FocusedColor = System.Drawing.Color.Empty
        Me.cmdNew.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.Image = Nothing
        Me.cmdNew.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdNew.Location = New System.Drawing.Point(9, 272)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdNew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdNew.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdNew.OnHoverImage = Nothing
        Me.cmdNew.OnPressedColor = System.Drawing.Color.Black
        Me.cmdNew.Radius = 2
        Me.cmdNew.Size = New System.Drawing.Size(98, 37)
        Me.cmdNew.TabIndex = 48
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cmdNew.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Jenis Operasi"
        '
        'txtJenisOperasi
        '
        Me.txtJenisOperasi.Location = New System.Drawing.Point(289, 88)
        Me.txtJenisOperasi.Name = "txtJenisOperasi"
        Me.txtJenisOperasi.Size = New System.Drawing.Size(69, 20)
        Me.txtJenisOperasi.TabIndex = 50
        '
        'dgAllCabang
        '
        Me.dgAllCabang.AllowUserToAddRows = False
        Me.dgAllCabang.AllowUserToDeleteRows = False
        Me.dgAllCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAllCabang.Location = New System.Drawing.Point(468, 6)
        Me.dgAllCabang.Name = "dgAllCabang"
        Me.dgAllCabang.Size = New System.Drawing.Size(247, 309)
        Me.dgAllCabang.TabIndex = 52
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
        Me.cmdSaveAll.Location = New System.Drawing.Point(148, 272)
        Me.cmdSaveAll.Name = "cmdSaveAll"
        Me.cmdSaveAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdSaveAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSaveAll.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdSaveAll.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdSaveAll.OnHoverImage = Nothing
        Me.cmdSaveAll.OnPressedColor = System.Drawing.Color.Black
        Me.cmdSaveAll.Radius = 2
        Me.cmdSaveAll.Size = New System.Drawing.Size(135, 37)
        Me.cmdSaveAll.TabIndex = 51
        Me.cmdSaveAll.Text = "Save For All Location"
        Me.cmdSaveAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormAddControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 319)
        Me.Controls.Add(Me.dgAllCabang)
        Me.Controls.Add(Me.cmdSaveAll)
        Me.Controls.Add(Me.txtJenisOperasi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtKodeJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbLokasi)
        Me.Controls.Add(Me.txtNamaValidasi)
        Me.Controls.Add(Me.txtKodeValidasi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAddControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Add Control"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgAllCabang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKodeValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents cmbLokasi As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFungsi As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdSimpan As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodeJenis As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmdNew As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJenisOperasi As System.Windows.Forms.TextBox
    Friend WithEvents dgAllCabang As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSaveAll As Guna.UI.WinForms.GunaGradientButton
End Class
