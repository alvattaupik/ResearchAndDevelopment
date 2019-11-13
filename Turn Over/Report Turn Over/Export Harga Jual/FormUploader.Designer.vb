<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUploader
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
        Me.dgReport = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDocEntry = New System.Windows.Forms.TextBox()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmdTambah = New System.Windows.Forms.Button()
        Me.txtKabur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPekerjaanLain = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSakit = New System.Windows.Forms.TextBox()
        Me.txtAtasan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTidakCocok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPersen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dcCabang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpInput = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNamaKomputer = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgReport
        '
        Me.dgReport.AllowUserToAddRows = False
        Me.dgReport.AllowUserToDeleteRows = False
        Me.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReport.Location = New System.Drawing.Point(9, 430)
        Me.dgReport.Name = "dgReport"
        Me.dgReport.Size = New System.Drawing.Size(712, 254)
        Me.dgReport.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDocEntry)
        Me.GroupBox1.Controls.Add(Me.cmdExport)
        Me.GroupBox1.Controls.Add(Me.cmdSimpan)
        Me.GroupBox1.Controls.Add(Me.cmdHapus)
        Me.GroupBox1.Controls.Add(Me.cmdTambah)
        Me.GroupBox1.Controls.Add(Me.txtKabur)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPekerjaanLain)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSakit)
        Me.GroupBox1.Controls.Add(Me.txtAtasan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTidakCocok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPersen)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dcCabang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpInput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 318)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtDocEntry
        '
        Me.txtDocEntry.Location = New System.Drawing.Point(171, 12)
        Me.txtDocEntry.Multiline = True
        Me.txtDocEntry.Name = "txtDocEntry"
        Me.txtDocEntry.Size = New System.Drawing.Size(70, 18)
        Me.txtDocEntry.TabIndex = 20
        Me.txtDocEntry.Visible = False
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(528, 247)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(161, 54)
        Me.cmdExport.TabIndex = 19
        Me.cmdExport.Text = "Export Grafik"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(528, 126)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(161, 54)
        Me.cmdSimpan.TabIndex = 18
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(528, 186)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(161, 54)
        Me.cmdHapus.TabIndex = 17
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Location = New System.Drawing.Point(528, 65)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(161, 54)
        Me.cmdTambah.TabIndex = 16
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'txtKabur
        '
        Me.txtKabur.Location = New System.Drawing.Point(317, 274)
        Me.txtKabur.Multiline = True
        Me.txtKabur.Name = "txtKabur"
        Me.txtKabur.Size = New System.Drawing.Size(124, 29)
        Me.txtKabur.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Kabur        :"
        '
        'txtPekerjaanLain
        '
        Me.txtPekerjaanLain.Location = New System.Drawing.Point(317, 239)
        Me.txtPekerjaanLain.Multiline = True
        Me.txtPekerjaanLain.Name = "txtPekerjaanLain"
        Me.txtPekerjaanLain.Size = New System.Drawing.Size(124, 29)
        Me.txtPekerjaanLain.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mendapat Pekerjaan Lain        :"
        '
        'txtSakit
        '
        Me.txtSakit.Location = New System.Drawing.Point(317, 204)
        Me.txtSakit.Multiline = True
        Me.txtSakit.Name = "txtSakit"
        Me.txtSakit.Size = New System.Drawing.Size(124, 29)
        Me.txtSakit.TabIndex = 11
        '
        'txtAtasan
        '
        Me.txtAtasan.Location = New System.Drawing.Point(317, 169)
        Me.txtAtasan.Multiline = True
        Me.txtAtasan.Name = "txtAtasan"
        Me.txtAtasan.Size = New System.Drawing.Size(124, 29)
        Me.txtAtasan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sakit         :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tidak Cocok Dengan Atasan   :"
        '
        'txtTidakCocok
        '
        Me.txtTidakCocok.Location = New System.Drawing.Point(317, 134)
        Me.txtTidakCocok.Multiline = True
        Me.txtTidakCocok.Name = "txtTidakCocok"
        Me.txtTidakCocok.Size = New System.Drawing.Size(124, 29)
        Me.txtTidakCocok.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pekerjaan Tidak Cocok           :"
        '
        'txtPersen
        '
        Me.txtPersen.Location = New System.Drawing.Point(317, 99)
        Me.txtPersen.Multiline = True
        Me.txtPersen.Name = "txtPersen"
        Me.txtPersen.Size = New System.Drawing.Size(124, 29)
        Me.txtPersen.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Persentase         :"
        '
        'dcCabang
        '
        Me.dcCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcCabang.FormattingEnabled = True
        Me.dcCabang.Location = New System.Drawing.Point(172, 68)
        Me.dcCabang.Name = "dcCabang"
        Me.dcCabang.Size = New System.Drawing.Size(269, 28)
        Me.dcCabang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cabang               :"
        '
        'dtpInput
        '
        Me.dtpInput.Location = New System.Drawing.Point(171, 36)
        Me.dtpInput.Name = "dtpInput"
        Me.dtpInput.Size = New System.Drawing.Size(270, 20)
        Me.dtpInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Rekap  :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.TurnOver.My.Resources.Resources._8d2266d10c0de8283c9f225d7f7b045b_colorful_abstract_geometric_background_vector_by_vexels
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.lblNamaKomputer)
        Me.GroupBox2.Controls.Add(Me.lblIP)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(360, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 104)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lblNamaKomputer
        '
        Me.lblNamaKomputer.AutoSize = True
        Me.lblNamaKomputer.Location = New System.Drawing.Point(170, 55)
        Me.lblNamaKomputer.Name = "lblNamaKomputer"
        Me.lblNamaKomputer.Size = New System.Drawing.Size(11, 13)
        Me.lblNamaKomputer.TabIndex = 3
        Me.lblNamaKomputer.Text = "-"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(170, 21)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(11, 13)
        Me.lblIP.TabIndex = 2
        Me.lblIP.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nama Komputer Saya"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "IP Komputer Saya"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(177, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 24)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "APLIKASI OLAH "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(163, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(191, 24)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "DATA TURN OVER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TurnOver.My.Resources.Resources._05_thumbnail
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 101)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FormUploader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TurnOver.My.Resources.Resources.md_5b12306722c18
        Me.ClientSize = New System.Drawing.Size(733, 696)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgReport)
        Me.Name = "FormUploader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporting Service"
        CType(Me.dgReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgReport As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents txtKabur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPekerjaanLain As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSakit As System.Windows.Forms.TextBox
    Friend WithEvents txtAtasan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTidakCocok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPersen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dcCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpInput As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNamaKomputer As System.Windows.Forms.Label
    Friend WithEvents txtDocEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
