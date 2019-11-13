<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKonfigurasiAplikasi
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
        Me.txtUsernameDBemail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtusernameDBUtama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPasswordDBEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaDBEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLokasiDBEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPasswordDatabaseUtama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaDatabaseUtama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLokasiDatabaseUtama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLokasiExport = New System.Windows.Forms.TextBox()
        Me.cmdbrowseLokasi = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDurasiDelay = New System.Windows.Forms.TextBox()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdSimpandanRestart = New System.Windows.Forms.Button()
        Me.cmdRestart = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTestMode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsernameDBemail)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtusernameDBUtama)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPasswordDBEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNamaDBEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLokasiDBEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPasswordDatabaseUtama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNamaDatabaseUtama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLokasiDatabaseUtama)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Connection"
        '
        'txtUsernameDBemail
        '
        Me.txtUsernameDBemail.Location = New System.Drawing.Point(143, 129)
        Me.txtUsernameDBemail.Name = "txtUsernameDBemail"
        Me.txtUsernameDBemail.Size = New System.Drawing.Size(154, 20)
        Me.txtUsernameDBemail.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(84, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Username"
        '
        'txtusernameDBUtama
        '
        Me.txtusernameDBUtama.Location = New System.Drawing.Point(143, 60)
        Me.txtusernameDBUtama.Name = "txtusernameDBUtama"
        Me.txtusernameDBUtama.Size = New System.Drawing.Size(154, 20)
        Me.txtusernameDBUtama.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Username"
        '
        'txtPasswordDBEmail
        '
        Me.txtPasswordDBEmail.Location = New System.Drawing.Point(384, 132)
        Me.txtPasswordDBEmail.Name = "txtPasswordDBEmail"
        Me.txtPasswordDBEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDBEmail.Size = New System.Drawing.Size(155, 20)
        Me.txtPasswordDBEmail.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        '
        'txtNamaDBEmail
        '
        Me.txtNamaDBEmail.Location = New System.Drawing.Point(384, 106)
        Me.txtNamaDBEmail.Name = "txtNamaDBEmail"
        Me.txtNamaDBEmail.Size = New System.Drawing.Size(155, 20)
        Me.txtNamaDBEmail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Database Name"
        '
        'txtLokasiDBEmail
        '
        Me.txtLokasiDBEmail.Location = New System.Drawing.Point(143, 103)
        Me.txtLokasiDBEmail.Name = "txtLokasiDBEmail"
        Me.txtLokasiDBEmail.Size = New System.Drawing.Size(154, 20)
        Me.txtLokasiDBEmail.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email Database Location"
        '
        'txtPasswordDatabaseUtama
        '
        Me.txtPasswordDatabaseUtama.Location = New System.Drawing.Point(384, 60)
        Me.txtPasswordDatabaseUtama.Name = "txtPasswordDatabaseUtama"
        Me.txtPasswordDatabaseUtama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordDatabaseUtama.Size = New System.Drawing.Size(155, 20)
        Me.txtPasswordDatabaseUtama.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'txtNamaDatabaseUtama
        '
        Me.txtNamaDatabaseUtama.Location = New System.Drawing.Point(384, 32)
        Me.txtNamaDatabaseUtama.Name = "txtNamaDatabaseUtama"
        Me.txtNamaDatabaseUtama.Size = New System.Drawing.Size(155, 20)
        Me.txtNamaDatabaseUtama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database Name"
        '
        'txtLokasiDatabaseUtama
        '
        Me.txtLokasiDatabaseUtama.Location = New System.Drawing.Point(143, 32)
        Me.txtLokasiDatabaseUtama.Name = "txtLokasiDatabaseUtama"
        Me.txtLokasiDatabaseUtama.Size = New System.Drawing.Size(154, 20)
        Me.txtLokasiDatabaseUtama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Database Location"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(562, 148)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -3
        Me.LineShape1.X2 = 562
        Me.LineShape1.Y1 = 76
        Me.LineShape1.Y2 = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Behaviour and Configurations"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLokasiExport)
        Me.GroupBox2.Controls.Add(Me.cmdbrowseLokasi)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 72)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export Location"
        '
        'txtLokasiExport
        '
        Me.txtLokasiExport.Location = New System.Drawing.Point(91, 31)
        Me.txtLokasiExport.Name = "txtLokasiExport"
        Me.txtLokasiExport.Size = New System.Drawing.Size(204, 20)
        Me.txtLokasiExport.TabIndex = 1
        '
        'cmdbrowseLokasi
        '
        Me.cmdbrowseLokasi.Location = New System.Drawing.Point(6, 30)
        Me.cmdbrowseLokasi.Name = "cmdbrowseLokasi"
        Me.cmdbrowseLokasi.Size = New System.Drawing.Size(78, 26)
        Me.cmdbrowseLokasi.TabIndex = 0
        Me.cmdbrowseLokasi.Text = "Select"
        Me.cmdbrowseLokasi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtDurasiDelay)
        Me.GroupBox3.Location = New System.Drawing.Point(333, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(182, 72)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interval Duration"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(144, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Jam"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Durasi"
        '
        'txtDurasiDelay
        '
        Me.txtDurasiDelay.Location = New System.Drawing.Point(66, 30)
        Me.txtDurasiDelay.Name = "txtDurasiDelay"
        Me.txtDurasiDelay.Size = New System.Drawing.Size(72, 20)
        Me.txtDurasiDelay.TabIndex = 0
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(15, 320)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(190, 29)
        Me.cmdSimpan.TabIndex = 31
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdSimpandanRestart
        '
        Me.cmdSimpandanRestart.Location = New System.Drawing.Point(213, 320)
        Me.cmdSimpandanRestart.Name = "cmdSimpandanRestart"
        Me.cmdSimpandanRestart.Size = New System.Drawing.Size(190, 29)
        Me.cmdSimpandanRestart.TabIndex = 32
        Me.cmdSimpandanRestart.Text = "Simpan dan Restart"
        Me.cmdSimpandanRestart.UseVisualStyleBackColor = True
        '
        'cmdRestart
        '
        Me.cmdRestart.Location = New System.Drawing.Point(404, 320)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(174, 29)
        Me.cmdRestart.TabIndex = 33
        Me.cmdRestart.Text = "Restart"
        Me.cmdRestart.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTestMode)
        Me.GroupBox4.Location = New System.Drawing.Point(522, 219)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(60, 66)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Test Mode"
        '
        'txtTestMode
        '
        Me.txtTestMode.Location = New System.Drawing.Point(11, 31)
        Me.txtTestMode.Name = "txtTestMode"
        Me.txtTestMode.Size = New System.Drawing.Size(31, 20)
        Me.txtTestMode.TabIndex = 0
        '
        'frmKonfigurasiAplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 352)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdRestart)
        Me.Controls.Add(Me.cmdSimpandanRestart)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmKonfigurasiAplikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKonfigurasiAplikasi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPasswordDBEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDBEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiDBEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordDatabaseUtama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaDatabaseUtama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLokasiDatabaseUtama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLokasiExport As System.Windows.Forms.TextBox
    Friend WithEvents cmdbrowseLokasi As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDurasiDelay As System.Windows.Forms.TextBox
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdSimpandanRestart As System.Windows.Forms.Button
    Friend WithEvents cmdRestart As System.Windows.Forms.Button
    Friend WithEvents txtUsernameDBemail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtusernameDBUtama As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTestMode As System.Windows.Forms.TextBox
End Class
