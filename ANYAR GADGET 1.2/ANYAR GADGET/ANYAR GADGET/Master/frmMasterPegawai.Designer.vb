<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterPegawai
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
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPegawai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.RichTextBox()
        Me.cmbJabatan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbFungsional = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlamatEmail = New System.Windows.Forms.TextBox()
        Me.cboAktif = New System.Windows.Forms.CheckBox()
        Me.btnAksi = New System.Windows.Forms.Button()
        Me.picNew = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.picFind = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(117, 64)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(261, 20)
        Me.txtEmployeeID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pegawai"
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.Enabled = False
        Me.txtNamaPegawai.Location = New System.Drawing.Point(117, 93)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.Size = New System.Drawing.Size(261, 20)
        Me.txtNamaPegawai.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Location = New System.Drawing.Point(117, 119)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(261, 124)
        Me.txtAlamat.TabIndex = 5
        Me.txtAlamat.Text = ""
        '
        'cmbJabatan
        '
        Me.cmbJabatan.Enabled = False
        Me.cmbJabatan.FormattingEnabled = True
        Me.cmbJabatan.Items.AddRange(New Object() {"STAFF", "SPV", "RM", "MANAGER", "EXECUTIVE", "SUPER USER"})
        Me.cmbJabatan.Location = New System.Drawing.Point(117, 250)
        Me.cmbJabatan.Name = "cmbJabatan"
        Me.cmbJabatan.Size = New System.Drawing.Size(261, 21)
        Me.cmbJabatan.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jabatan"
        '
        'cmbFungsional
        '
        Me.cmbFungsional.Enabled = False
        Me.cmbFungsional.FormattingEnabled = True
        Me.cmbFungsional.Items.AddRange(New Object() {"OPERATIONAL", "WAREHOUSE", "CUSTOMER SERVICE", "IT", "HO", "MANAGEMENT", "EXECUTIVE"})
        Me.cmbFungsional.Location = New System.Drawing.Point(117, 277)
        Me.cmbFungsional.Name = "cmbFungsional"
        Me.cmbFungsional.Size = New System.Drawing.Size(261, 21)
        Me.cmbFungsional.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fungsional"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Alamat Email"
        '
        'txtAlamatEmail
        '
        Me.txtAlamatEmail.Enabled = False
        Me.txtAlamatEmail.Location = New System.Drawing.Point(117, 306)
        Me.txtAlamatEmail.Name = "txtAlamatEmail"
        Me.txtAlamatEmail.Size = New System.Drawing.Size(261, 20)
        Me.txtAlamatEmail.TabIndex = 11
        '
        'cboAktif
        '
        Me.cboAktif.AutoSize = True
        Me.cboAktif.Enabled = False
        Me.cboAktif.Location = New System.Drawing.Point(117, 367)
        Me.cboAktif.Name = "cboAktif"
        Me.cboAktif.Size = New System.Drawing.Size(53, 17)
        Me.cboAktif.TabIndex = 12
        Me.cboAktif.Text = "Aktif?"
        Me.cboAktif.UseVisualStyleBackColor = True
        '
        'btnAksi
        '
        Me.btnAksi.Location = New System.Drawing.Point(117, 384)
        Me.btnAksi.Name = "btnAksi"
        Me.btnAksi.Size = New System.Drawing.Size(259, 47)
        Me.btnAksi.TabIndex = 14
        Me.btnAksi.Text = "Ok"
        Me.btnAksi.UseVisualStyleBackColor = True
        '
        'picNew
        '
        Me.picNew.BaseColor = System.Drawing.Color.White
        Me.picNew.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_User
        Me.picNew.Location = New System.Drawing.Point(16, 10)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(47, 47)
        Me.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNew.TabIndex = 16
        Me.picNew.TabStop = False
        Me.picNew.UseTransfarantBackground = False
        '
        'picFind
        '
        Me.picFind.BaseColor = System.Drawing.Color.White
        Me.picFind.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picFind.Location = New System.Drawing.Point(69, 10)
        Me.picFind.Name = "picFind"
        Me.picFind.Size = New System.Drawing.Size(47, 47)
        Me.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFind.TabIndex = 15
        Me.picFind.TabStop = False
        Me.picFind.UseTransfarantBackground = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No Telp"
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Enabled = False
        Me.txtNoTelp.Location = New System.Drawing.Point(117, 332)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(261, 20)
        Me.txtNoTelp.TabIndex = 18
        '
        'frmMasterPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 443)
        Me.Controls.Add(Me.txtNoTelp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picNew)
        Me.Controls.Add(Me.picFind)
        Me.Controls.Add(Me.btnAksi)
        Me.Controls.Add(Me.cboAktif)
        Me.Controls.Add(Me.txtAlamatEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbFungsional)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbJabatan)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaPegawai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Name = "frmMasterPegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMasterPegawai"
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbFungsional As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatEmail As System.Windows.Forms.TextBox
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
    Friend WithEvents picNew As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents picFind As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnAksi As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoTelp As System.Windows.Forms.TextBox
End Class
