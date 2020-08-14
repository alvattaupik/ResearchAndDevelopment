<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNormalMode = New System.Windows.Forms.RadioButton()
        Me.rbStealthMode = New System.Windows.Forms.RadioButton()
        Me.cmdKirim = New System.Windows.Forms.Button()
        Me.dglistkontak = New System.Windows.Forms.DataGridView()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsiPesanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerExecute = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNextExecute = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblIntervalTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdGetContactList = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStatusPengiriman = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkAutoReply = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvDaftarPesan = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dglistkontak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Whatsapp Automation V1.0"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rbNormalMode)
        Me.GroupBox1.Controls.Add(Me.rbStealthMode)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 75)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'rbNormalMode
        '
        Me.rbNormalMode.AutoSize = True
        Me.rbNormalMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNormalMode.Location = New System.Drawing.Point(19, 40)
        Me.rbNormalMode.Name = "rbNormalMode"
        Me.rbNormalMode.Size = New System.Drawing.Size(169, 29)
        Me.rbNormalMode.TabIndex = 37
        Me.rbNormalMode.TabStop = True
        Me.rbNormalMode.Text = "Normal Mode"
        Me.rbNormalMode.UseVisualStyleBackColor = True
        '
        'rbStealthMode
        '
        Me.rbStealthMode.AutoSize = True
        Me.rbStealthMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStealthMode.Location = New System.Drawing.Point(19, 10)
        Me.rbStealthMode.Name = "rbStealthMode"
        Me.rbStealthMode.Size = New System.Drawing.Size(169, 29)
        Me.rbStealthMode.TabIndex = 36
        Me.rbStealthMode.TabStop = True
        Me.rbStealthMode.Text = "Stealth Mode"
        Me.rbStealthMode.UseVisualStyleBackColor = True
        '
        'cmdKirim
        '
        Me.cmdKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKirim.Location = New System.Drawing.Point(357, 474)
        Me.cmdKirim.Name = "cmdKirim"
        Me.cmdKirim.Size = New System.Drawing.Size(162, 40)
        Me.cmdKirim.TabIndex = 28
        Me.cmdKirim.Text = "Kirim"
        Me.cmdKirim.UseVisualStyleBackColor = True
        '
        'dglistkontak
        '
        Me.dglistkontak.AllowUserToAddRows = False
        Me.dglistkontak.AllowUserToDeleteRows = False
        Me.dglistkontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistkontak.Location = New System.Drawing.Point(12, 202)
        Me.dglistkontak.Name = "dglistkontak"
        Me.dglistkontak.ReadOnly = True
        Me.dglistkontak.RowHeadersVisible = False
        Me.dglistkontak.Size = New System.Drawing.Size(508, 266)
        Me.dglistkontak.TabIndex = 27
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(204, 94)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(315, 32)
        Me.btnStart.TabIndex = 25
        Me.btnStart.Text = "Start Service"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(204, 133)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(315, 29)
        Me.btnStop.TabIndex = 26
        Me.btnStop.Text = "Stop Service"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Daftar Penerima"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem, Me.MasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KontakToolStripMenuItem, Me.IsiPesanToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'KontakToolStripMenuItem
        '
        Me.KontakToolStripMenuItem.Name = "KontakToolStripMenuItem"
        Me.KontakToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.KontakToolStripMenuItem.Text = "Kontak"
        '
        'IsiPesanToolStripMenuItem
        '
        Me.IsiPesanToolStripMenuItem.Name = "IsiPesanToolStripMenuItem"
        Me.IsiPesanToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.IsiPesanToolStripMenuItem.Text = "Isi Pesan"
        '
        'TimerExecute
        '
        Me.TimerExecute.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNextExecute, Me.lblIntervalTimer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(826, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNextExecute
        '
        Me.lblNextExecute.Name = "lblNextExecute"
        Me.lblNextExecute.Size = New System.Drawing.Size(109, 17)
        Me.lblNextExecute.Text = "Next Execution In 0"
        '
        'lblIntervalTimer
        '
        Me.lblIntervalTimer.Name = "lblIntervalTimer"
        Me.lblIntervalTimer.Size = New System.Drawing.Size(88, 17)
        Me.lblIntervalTimer.Text = "Interval Timer : "
        '
        'cmdGetContactList
        '
        Me.cmdGetContactList.Enabled = False
        Me.cmdGetContactList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetContactList.Location = New System.Drawing.Point(4, 8)
        Me.cmdGetContactList.Name = "cmdGetContactList"
        Me.cmdGetContactList.Size = New System.Drawing.Size(259, 40)
        Me.cmdGetContactList.TabIndex = 36
        Me.cmdGetContactList.Text = "Lihat Daftar Kontak"
        Me.cmdGetContactList.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblStatusPengiriman)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(539, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 112)
        Me.Panel1.TabIndex = 37
        '
        'lblStatusPengiriman
        '
        Me.lblStatusPengiriman.AutoSize = True
        Me.lblStatusPengiriman.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusPengiriman.Location = New System.Drawing.Point(12, 56)
        Me.lblStatusPengiriman.Name = "lblStatusPengiriman"
        Me.lblStatusPengiriman.Size = New System.Drawing.Size(220, 24)
        Me.lblStatusPengiriman.TabIndex = 35
        Me.lblStatusPengiriman.Text = "Telah Terkirim 0 dari 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Status"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.chkAutoReply)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.chkAktif)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(537, 322)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 58)
        Me.Panel2.TabIndex = 39
        '
        'chkAutoReply
        '
        Me.chkAutoReply.AutoSize = True
        Me.chkAutoReply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoReply.Location = New System.Drawing.Point(215, 32)
        Me.chkAutoReply.Name = "chkAutoReply"
        Me.chkAutoReply.Size = New System.Drawing.Size(57, 20)
        Me.chkAutoReply.TabIndex = 3
        Me.chkAutoReply.Text = "Aktif"
        Me.chkAutoReply.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fitur Auto Reply"
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAktif.Location = New System.Drawing.Point(215, 6)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(57, 20)
        Me.chkAktif.TabIndex = 1
        Me.chkAktif.Text = "Aktif"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pesan Belum Dibaca"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.cmdGetContactList)
        Me.Panel3.Location = New System.Drawing.Point(539, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 68)
        Me.Panel3.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Whastapp.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'lvDaftarPesan
        '
        Me.lvDaftarPesan.FormattingEnabled = True
        Me.lvDaftarPesan.Location = New System.Drawing.Point(537, 399)
        Me.lvDaftarPesan.Name = "lvDaftarPesan"
        Me.lvDaftarPesan.Size = New System.Drawing.Size(276, 108)
        Me.lvDaftarPesan.TabIndex = 41
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 537)
        Me.Controls.Add(Me.lvDaftarPesan)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdKirim)
        Me.Controls.Add(Me.dglistkontak)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Whatsapp Automation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dglistkontak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdKirim As System.Windows.Forms.Button
    Friend WithEvents dglistkontak As System.Windows.Forms.DataGridView
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KontakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IsiPesanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimerExecute As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblNextExecute As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rbStealthMode As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormalMode As System.Windows.Forms.RadioButton
    Friend WithEvents cmdGetContactList As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStatusPengiriman As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblIntervalTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents lvDaftarPesan As System.Windows.Forms.ListBox
    Friend WithEvents chkAutoReply As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
