<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdLogoff = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblHari = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DTWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrationServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAPDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblProsesIntegrasi = New System.Windows.Forms.Label()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.lblJumlahIntegrasi = New System.Windows.Forms.Label()
        Me.dgListIntegrasi = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbCekLink = New System.Windows.Forms.Button()
        Me.lblHostMYSQL = New System.Windows.Forms.Label()
        Me.lblHostSQL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbResume = New System.Windows.Forms.Button()
        Me.cmbPause = New System.Windows.Forms.Button()
        Me.txtStatusIntegrasi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TimerIntegrasi = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgListIntegrasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdLogoff)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lblHari)
        Me.Panel1.Controls.Add(Me.lblJam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 499)
        Me.Panel1.TabIndex = 0
        '
        'cmdLogoff
        '
        Me.cmdLogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogoff.Location = New System.Drawing.Point(15, 267)
        Me.cmdLogoff.Name = "cmdLogoff"
        Me.cmdLogoff.Size = New System.Drawing.Size(138, 55)
        Me.cmdLogoff.TabIndex = 5
        Me.cmdLogoff.Text = "Logoff"
        Me.cmdLogoff.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(14, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 135)
        Me.Panel5.TabIndex = 4
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 0
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.Location = New System.Drawing.Point(12, 186)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(39, 18)
        Me.lblHari.TabIndex = 3
        Me.lblHari.Text = "Hari"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.Location = New System.Drawing.Point(12, 222)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(40, 18)
        Me.lblJam.TabIndex = 2
        Me.lblJam.Text = "Jam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Halo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DTWToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DTWToolStripMenuItem
        '
        Me.DTWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadToolStripMenuItem, Me.IntegrasiToolStripMenuItem})
        Me.DTWToolStripMenuItem.Name = "DTWToolStripMenuItem"
        Me.DTWToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DTWToolStripMenuItem.Text = "DTW"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'IntegrasiToolStripMenuItem
        '
        Me.IntegrasiToolStripMenuItem.Name = "IntegrasiToolStripMenuItem"
        Me.IntegrasiToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.IntegrasiToolStripMenuItem.Text = "Integrasi"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntegrationServicesToolStripMenuItem, Me.SAPDatabaseToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'IntegrationServicesToolStripMenuItem
        '
        Me.IntegrationServicesToolStripMenuItem.Name = "IntegrationServicesToolStripMenuItem"
        Me.IntegrationServicesToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.IntegrationServicesToolStripMenuItem.Text = "Integration Services"
        '
        'SAPDatabaseToolStripMenuItem
        '
        Me.SAPDatabaseToolStripMenuItem.Name = "SAPDatabaseToolStripMenuItem"
        Me.SAPDatabaseToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SAPDatabaseToolStripMenuItem.Text = "Database"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblProsesIntegrasi)
        Me.Panel2.Controls.Add(Me.lblDurasi)
        Me.Panel2.Controls.Add(Me.lblJumlahIntegrasi)
        Me.Panel2.Controls.Add(Me.dgListIntegrasi)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.cmbResume)
        Me.Panel2.Controls.Add(Me.cmbPause)
        Me.Panel2.Controls.Add(Me.txtStatusIntegrasi)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(178, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 467)
        Me.Panel2.TabIndex = 2
        '
        'lblProsesIntegrasi
        '
        Me.lblProsesIntegrasi.AutoSize = True
        Me.lblProsesIntegrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProsesIntegrasi.Location = New System.Drawing.Point(410, 442)
        Me.lblProsesIntegrasi.Name = "lblProsesIntegrasi"
        Me.lblProsesIntegrasi.Size = New System.Drawing.Size(161, 18)
        Me.lblProsesIntegrasi.TabIndex = 8
        Me.lblProsesIntegrasi.Text = "Sending Records : 0"
        Me.lblProsesIntegrasi.Visible = False
        '
        'lblDurasi
        '
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Location = New System.Drawing.Point(11, 447)
        Me.lblDurasi.Name = "lblDurasi"
        Me.lblDurasi.Size = New System.Drawing.Size(37, 13)
        Me.lblDurasi.TabIndex = 7
        Me.lblDurasi.Text = "Durasi"
        '
        'lblJumlahIntegrasi
        '
        Me.lblJumlahIntegrasi.AutoSize = True
        Me.lblJumlahIntegrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahIntegrasi.Location = New System.Drawing.Point(73, 442)
        Me.lblJumlahIntegrasi.Name = "lblJumlahIntegrasi"
        Me.lblJumlahIntegrasi.Size = New System.Drawing.Size(154, 18)
        Me.lblJumlahIntegrasi.TabIndex = 6
        Me.lblJumlahIntegrasi.Text = "0 Records To Send"
        '
        'dgListIntegrasi
        '
        Me.dgListIntegrasi.AllowUserToAddRows = False
        Me.dgListIntegrasi.AllowUserToDeleteRows = False
        Me.dgListIntegrasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListIntegrasi.Location = New System.Drawing.Point(14, 198)
        Me.dgListIntegrasi.Name = "dgListIntegrasi"
        Me.dgListIntegrasi.ReadOnly = True
        Me.dgListIntegrasi.Size = New System.Drawing.Size(557, 241)
        Me.dgListIntegrasi.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(14, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 111)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel4.Controls.Add(Me.cmbCekLink)
        Me.Panel4.Controls.Add(Me.lblHostMYSQL)
        Me.Panel4.Controls.Add(Me.lblHostSQL)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(14, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(532, 95)
        Me.Panel4.TabIndex = 5
        '
        'cmbCekLink
        '
        Me.cmbCekLink.Location = New System.Drawing.Point(448, 6)
        Me.cmbCekLink.Name = "cmbCekLink"
        Me.cmbCekLink.Size = New System.Drawing.Size(75, 83)
        Me.cmbCekLink.TabIndex = 5
        Me.cmbCekLink.Text = "Cek Link"
        Me.cmbCekLink.UseVisualStyleBackColor = True
        '
        'lblHostMYSQL
        '
        Me.lblHostMYSQL.AutoSize = True
        Me.lblHostMYSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostMYSQL.Location = New System.Drawing.Point(20, 66)
        Me.lblHostMYSQL.Name = "lblHostMYSQL"
        Me.lblHostMYSQL.Size = New System.Drawing.Size(15, 20)
        Me.lblHostMYSQL.TabIndex = 4
        Me.lblHostMYSQL.Text = "-"
        '
        'lblHostSQL
        '
        Me.lblHostSQL.AutoSize = True
        Me.lblHostSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostSQL.Location = New System.Drawing.Point(20, 34)
        Me.lblHostSQL.Name = "lblHostSQL"
        Me.lblHostSQL.Size = New System.Drawing.Size(15, 20)
        Me.lblHostSQL.TabIndex = 3
        Me.lblHostSQL.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Link Health"
        '
        'cmbResume
        '
        Me.cmbResume.Location = New System.Drawing.Point(487, 8)
        Me.cmbResume.Name = "cmbResume"
        Me.cmbResume.Size = New System.Drawing.Size(80, 34)
        Me.cmbResume.TabIndex = 3
        Me.cmbResume.Text = "Resume Service"
        Me.cmbResume.UseVisualStyleBackColor = True
        '
        'cmbPause
        '
        Me.cmbPause.Location = New System.Drawing.Point(401, 8)
        Me.cmbPause.Name = "cmbPause"
        Me.cmbPause.Size = New System.Drawing.Size(84, 34)
        Me.cmbPause.TabIndex = 2
        Me.cmbPause.Text = "Pause Service"
        Me.cmbPause.UseVisualStyleBackColor = True
        '
        'txtStatusIntegrasi
        '
        Me.txtStatusIntegrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusIntegrasi.Location = New System.Drawing.Point(192, 11)
        Me.txtStatusIntegrasi.Name = "txtStatusIntegrasi"
        Me.txtStatusIntegrasi.ReadOnly = True
        Me.txtStatusIntegrasi.Size = New System.Drawing.Size(199, 26)
        Me.txtStatusIntegrasi.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INTEGRATION SERVICES"
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'TimerIntegrasi
        '
        Me.TimerIntegrasi.Interval = 1000
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(771, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgListIntegrasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblHari As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DTWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegrasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegrationServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAPDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmbCekLink As System.Windows.Forms.Button
    Friend WithEvents lblHostMYSQL As System.Windows.Forms.Label
    Friend WithEvents lblHostSQL As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbResume As System.Windows.Forms.Button
    Friend WithEvents cmbPause As System.Windows.Forms.Button
    Friend WithEvents txtStatusIntegrasi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblJumlahIntegrasi As System.Windows.Forms.Label
    Friend WithEvents dgListIntegrasi As System.Windows.Forms.DataGridView
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents cmdLogoff As System.Windows.Forms.Button
    Friend WithEvents lblDurasi As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TimerIntegrasi As System.Windows.Forms.Timer
    Friend WithEvents lblProsesIntegrasi As System.Windows.Forms.Label
End Class
