<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporkanMasalah
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaSupervisor = New System.Windows.Forms.TextBox()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaPegawai = New System.Windows.Forms.TextBox()
        Me.txtUsernameLogin = New System.Windows.Forms.TextBox()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUniqueID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblJumlahLampiran = New System.Windows.Forms.Label()
        Me.dgvListLampiran = New System.Windows.Forms.DataGridView()
        Me.btnAddLampiran = New System.Windows.Forms.Button()
        Me.txtPathLampiran = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDetailDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKodeSpecificProblem = New System.Windows.Forms.TextBox()
        Me.txtNamaSpecificProblems = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeSubkategori = New System.Windows.Forms.TextBox()
        Me.txtNamaSubkategori = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnKirim = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.picCariLampiran = New System.Windows.Forms.PictureBox()
        Me.picCariSpesificProblem = New System.Windows.Forms.PictureBox()
        Me.picCariSubKategori = New System.Windows.Forms.PictureBox()
        Me.GunaTransfarantPictureBox3 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHapusLampiran = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariSpesificProblem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCariSubKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.GroupBox1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtNamaSupervisor)
        Me.GroupBox1.Controls.Add(Me.txtLokasi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNamaPegawai)
        Me.GroupBox1.Controls.Add(Me.txtUsernameLogin)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1033, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Help Desk Support"
        '
        'txtNamaSupervisor
        '
        Me.txtNamaSupervisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaSupervisor.Location = New System.Drawing.Point(619, 125)
        Me.txtNamaSupervisor.Name = "txtNamaSupervisor"
        Me.txtNamaSupervisor.ReadOnly = True
        Me.txtNamaSupervisor.Size = New System.Drawing.Size(361, 20)
        Me.txtNamaSupervisor.TabIndex = 9
        '
        'txtLokasi
        '
        Me.txtLokasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLokasi.Location = New System.Drawing.Point(619, 98)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.ReadOnly = True
        Me.txtLokasi.Size = New System.Drawing.Size(245, 20)
        Me.txtLokasi.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(470, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nama Supervisor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(470, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Divisi / Lokasi"
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaPegawai.Location = New System.Drawing.Point(619, 71)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.ReadOnly = True
        Me.txtNamaPegawai.Size = New System.Drawing.Size(361, 20)
        Me.txtNamaPegawai.TabIndex = 5
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsernameLogin.Location = New System.Drawing.Point(619, 45)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.ReadOnly = True
        Me.txtUsernameLogin.Size = New System.Drawing.Size(245, 20)
        Me.txtUsernameLogin.TabIndex = 4
        '
        'txtEmpID
        '
        Me.txtEmpID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpID.Location = New System.Drawing.Point(619, 19)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(361, 20)
        Me.txtEmpID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(471, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pegawai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtUniqueID)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 43)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Unique Incident Number"
        '
        'txtUniqueID
        '
        Me.txtUniqueID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUniqueID.BackColor = System.Drawing.Color.LimeGreen
        Me.txtUniqueID.Enabled = False
        Me.txtUniqueID.Location = New System.Drawing.Point(204, 15)
        Me.txtUniqueID.Name = "txtUniqueID"
        Me.txtUniqueID.Size = New System.Drawing.Size(520, 20)
        Me.txtUniqueID.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblJumlahLampiran)
        Me.GroupBox3.Controls.Add(Me.btnHapusLampiran)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btnAddLampiran)
        Me.GroupBox3.Controls.Add(Me.txtPathLampiran)
        Me.GroupBox3.Controls.Add(Me.picCariLampiran)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtDetailDeskripsi)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtKodeSpecificProblem)
        Me.GroupBox3.Controls.Add(Me.txtNamaSpecificProblems)
        Me.GroupBox3.Controls.Add(Me.picCariSpesificProblem)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtKodeSubkategori)
        Me.GroupBox3.Controls.Add(Me.txtNamaSubkategori)
        Me.GroupBox3.Controls.Add(Me.picCariSubKategori)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cmbKategori)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 395)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgvListLampiran)
        Me.GroupBox4.Location = New System.Drawing.Point(202, 237)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 151)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'lblJumlahLampiran
        '
        Me.lblJumlahLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahLampiran.AutoSize = True
        Me.lblJumlahLampiran.Location = New System.Drawing.Point(606, 285)
        Me.lblJumlahLampiran.Name = "lblJumlahLampiran"
        Me.lblJumlahLampiran.Size = New System.Drawing.Size(101, 13)
        Me.lblJumlahLampiran.TabIndex = 1
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
        Me.dgvListLampiran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Path})
        Me.dgvListLampiran.Location = New System.Drawing.Point(6, 16)
        Me.dgvListLampiran.Name = "dgvListLampiran"
        Me.dgvListLampiran.ReadOnly = True
        Me.dgvListLampiran.RowHeadersVisible = False
        Me.dgvListLampiran.Size = New System.Drawing.Size(378, 127)
        Me.dgvListLampiran.TabIndex = 0
        '
        'btnAddLampiran
        '
        Me.btnAddLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddLampiran.Location = New System.Drawing.Point(610, 210)
        Me.btnAddLampiran.Name = "btnAddLampiran"
        Me.btnAddLampiran.Size = New System.Drawing.Size(97, 21)
        Me.btnAddLampiran.TabIndex = 17
        Me.btnAddLampiran.Text = "Add"
        Me.btnAddLampiran.UseVisualStyleBackColor = True
        '
        'txtPathLampiran
        '
        Me.txtPathLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPathLampiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathLampiran.Location = New System.Drawing.Point(202, 211)
        Me.txtPathLampiran.Name = "txtPathLampiran"
        Me.txtPathLampiran.ReadOnly = True
        Me.txtPathLampiran.Size = New System.Drawing.Size(397, 22)
        Me.txtPathLampiran.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Lampiran"
        '
        'txtDetailDeskripsi
        '
        Me.txtDetailDeskripsi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetailDeskripsi.BackColor = System.Drawing.Color.White
        Me.txtDetailDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetailDeskripsi.Location = New System.Drawing.Point(202, 142)
        Me.txtDetailDeskripsi.Name = "txtDetailDeskripsi"
        Me.txtDetailDeskripsi.ReadOnly = True
        Me.txtDetailDeskripsi.Size = New System.Drawing.Size(397, 63)
        Me.txtDetailDeskripsi.TabIndex = 13
        Me.txtDetailDeskripsi.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Deskripsi Detail"
        '
        'txtKodeSpecificProblem
        '
        Me.txtKodeSpecificProblem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeSpecificProblem.Enabled = False
        Me.txtKodeSpecificProblem.Location = New System.Drawing.Point(621, 74)
        Me.txtKodeSpecificProblem.Name = "txtKodeSpecificProblem"
        Me.txtKodeSpecificProblem.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeSpecificProblem.TabIndex = 11
        '
        'txtNamaSpecificProblems
        '
        Me.txtNamaSpecificProblems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaSpecificProblems.Enabled = False
        Me.txtNamaSpecificProblems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSpecificProblems.Location = New System.Drawing.Point(202, 79)
        Me.txtNamaSpecificProblems.Name = "txtNamaSpecificProblems"
        Me.txtNamaSpecificProblems.Size = New System.Drawing.Size(397, 55)
        Me.txtNamaSpecificProblems.TabIndex = 10
        Me.txtNamaSpecificProblems.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Specific Problems"
        '
        'txtKodeSubkategori
        '
        Me.txtKodeSubkategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeSubkategori.Enabled = False
        Me.txtKodeSubkategori.Location = New System.Drawing.Point(621, 43)
        Me.txtKodeSubkategori.Name = "txtKodeSubkategori"
        Me.txtKodeSubkategori.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeSubkategori.TabIndex = 7
        '
        'txtNamaSubkategori
        '
        Me.txtNamaSubkategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaSubkategori.Enabled = False
        Me.txtNamaSubkategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSubkategori.Location = New System.Drawing.Point(202, 45)
        Me.txtNamaSubkategori.Name = "txtNamaSubkategori"
        Me.txtNamaSubkategori.Size = New System.Drawing.Size(397, 24)
        Me.txtNamaSubkategori.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Sub kategori"
        '
        'cmbKategori
        '
        Me.cmbKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(202, 13)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(520, 24)
        Me.cmbKategori.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Kategori"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(15, 490)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(266, 44)
        Me.btnNew.TabIndex = 21
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(15, 592)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(266, 45)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnKirim
        '
        Me.btnKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKirim.Location = New System.Drawing.Point(15, 542)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(266, 44)
        Me.btnKirim.TabIndex = 19
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(284, 15)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Designed Using ITIL V3 - Service Operation"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 20)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Incident Management"
        '
        'picCariLampiran
        '
        Me.picCariLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCariLampiran.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picCariLampiran.Location = New System.Drawing.Point(171, 212)
        Me.picCariLampiran.Name = "picCariLampiran"
        Me.picCariLampiran.Size = New System.Drawing.Size(25, 22)
        Me.picCariLampiran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCariLampiran.TabIndex = 15
        Me.picCariLampiran.TabStop = False
        '
        'picCariSpesificProblem
        '
        Me.picCariSpesificProblem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCariSpesificProblem.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picCariSpesificProblem.Location = New System.Drawing.Point(171, 78)
        Me.picCariSpesificProblem.Name = "picCariSpesificProblem"
        Me.picCariSpesificProblem.Size = New System.Drawing.Size(25, 22)
        Me.picCariSpesificProblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCariSpesificProblem.TabIndex = 9
        Me.picCariSpesificProblem.TabStop = False
        '
        'picCariSubKategori
        '
        Me.picCariSubKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCariSubKategori.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picCariSubKategori.Location = New System.Drawing.Point(171, 45)
        Me.picCariSubKategori.Name = "picCariSubKategori"
        Me.picCariSubKategori.Size = New System.Drawing.Size(25, 22)
        Me.picCariSubKategori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCariSubKategori.TabIndex = 5
        Me.picCariSubKategori.TabStop = False
        '
        'GunaTransfarantPictureBox3
        '
        Me.GunaTransfarantPictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaTransfarantPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox3.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox3.Image = Global.ANYAR_GADGET.My.Resources.Resources.Incident_Management
        Me.GunaTransfarantPictureBox3.Location = New System.Drawing.Point(48, 262)
        Me.GunaTransfarantPictureBox3.Name = "GunaTransfarantPictureBox3"
        Me.GunaTransfarantPictureBox3.Size = New System.Drawing.Size(213, 211)
        Me.GunaTransfarantPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox3.TabIndex = 1
        Me.GunaTransfarantPictureBox3.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.ANYAR_GADGET.My.Resources.Resources.Helpdesk_logo2
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(19, 10)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(247, 145)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaTransfarantPictureBox2.TabIndex = 13
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Idea
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(303, 12)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(161, 158)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 12
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Path
        '
        Me.Path.HeaderText = "Path"
        Me.Path.Name = "Path"
        Me.Path.ReadOnly = True
        '
        'btnHapusLampiran
        '
        Me.btnHapusLampiran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapusLampiran.Location = New System.Drawing.Point(610, 245)
        Me.btnHapusLampiran.Name = "btnHapusLampiran"
        Me.btnHapusLampiran.Size = New System.Drawing.Size(97, 23)
        Me.btnHapusLampiran.TabIndex = 2
        Me.btnHapusLampiran.Text = "Hapus Lampiran"
        Me.btnHapusLampiran.UseVisualStyleBackColor = True
        '
        'frmLaporkanMasalah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 656)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnKirim)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GunaTransfarantPictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLaporkanMasalah"
        Me.Text = "Laporkan Masalah"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariSpesificProblem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCariSubKategori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaSupervisor As System.Windows.Forms.TextBox
    Friend WithEvents txtLokasi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox3 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUniqueID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnKirim As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListLampiran As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddLampiran As System.Windows.Forms.Button
    Friend WithEvents txtPathLampiran As System.Windows.Forms.TextBox
    Friend WithEvents picCariLampiran As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDetailDeskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSpecificProblem As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSpecificProblems As System.Windows.Forms.RichTextBox
    Friend WithEvents picCariSpesificProblem As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSubkategori As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSubkategori As System.Windows.Forms.TextBox
    Friend WithEvents picCariSubKategori As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahLampiran As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHapusLampiran As System.Windows.Forms.Button
End Class
