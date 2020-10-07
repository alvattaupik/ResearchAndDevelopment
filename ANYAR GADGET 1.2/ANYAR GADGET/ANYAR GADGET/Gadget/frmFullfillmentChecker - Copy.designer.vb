<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStoreDatabasePerformance
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvListKontrolForm = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrGrafik = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnStopProses = New System.Windows.Forms.Button()
        Me.txtPasswordlogin = New System.Windows.Forms.TextBox()
        Me.txtUsernameLogin = New System.Windows.Forms.TextBox()
        Me.txtDatabaseName = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvListProses = New System.Windows.Forms.DataGridView()
        Me.ChartPerforma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblWorkLoad = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvListKontrolForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListProses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartPerforma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.dgvListKontrolForm)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-2, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 588)
        Me.Panel2.TabIndex = 1
        '
        'dgvListKontrolForm
        '
        Me.dgvListKontrolForm.AllowUserToAddRows = False
        Me.dgvListKontrolForm.AllowUserToDeleteRows = False
        Me.dgvListKontrolForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKontrolForm.Location = New System.Drawing.Point(37, 150)
        Me.dgvListKontrolForm.Name = "dgvListKontrolForm"
        Me.dgvListKontrolForm.Size = New System.Drawing.Size(174, 127)
        Me.dgvListKontrolForm.TabIndex = 7
        Me.dgvListKontrolForm.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(110, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "A.I.O"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(7, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Replication Services Monitor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(109, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anyar"
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(7, 10)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(85, 85)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 2
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(894, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(358, 17)
        Me.ToolStripStatusLabel1.Text = "Anyar Gadget  - Integration Monitoring A.I.O V.1.0 Build xx.xx.xxxx"
        '
        'tmrGrafik
        '
        Me.tmrGrafik.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(247, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 108)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(535, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "STORE DATABASE PERFORMANCE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnProses)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbLocation)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(249, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 196)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameters"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(442, 20)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(134, 41)
        Me.btnProses.TabIndex = 3
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnStopProses)
        Me.GroupBox2.Controls.Add(Me.txtPasswordlogin)
        Me.GroupBox2.Controls.Add(Me.txtUsernameLogin)
        Me.GroupBox2.Controls.Add(Me.txtDatabaseName)
        Me.GroupBox2.Controls.Add(Me.txtServerName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(575, 121)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'btnStopProses
        '
        Me.btnStopProses.Location = New System.Drawing.Point(435, 22)
        Me.btnStopProses.Name = "btnStopProses"
        Me.btnStopProses.Size = New System.Drawing.Size(134, 88)
        Me.btnStopProses.TabIndex = 10
        Me.btnStopProses.Text = "Stop Proses"
        Me.btnStopProses.UseVisualStyleBackColor = True
        '
        'txtPasswordlogin
        '
        Me.txtPasswordlogin.Enabled = False
        Me.txtPasswordlogin.Location = New System.Drawing.Point(132, 94)
        Me.txtPasswordlogin.Name = "txtPasswordlogin"
        Me.txtPasswordlogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordlogin.Size = New System.Drawing.Size(283, 20)
        Me.txtPasswordlogin.TabIndex = 9
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.Enabled = False
        Me.txtUsernameLogin.Location = New System.Drawing.Point(132, 68)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsernameLogin.Size = New System.Drawing.Size(283, 20)
        Me.txtUsernameLogin.TabIndex = 8
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Enabled = False
        Me.txtDatabaseName.Location = New System.Drawing.Point(132, 40)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDatabaseName.Size = New System.Drawing.Size(283, 20)
        Me.txtDatabaseName.TabIndex = 7
        '
        'txtServerName
        '
        Me.txtServerName.Enabled = False
        Me.txtServerName.Location = New System.Drawing.Point(132, 14)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(283, 20)
        Me.txtServerName.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Password Login"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Username Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Database Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Server Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Location"
        '
        'cmbLocation
        '
        Me.cmbLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(139, 26)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(283, 28)
        Me.cmbLocation.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblWorkLoad)
        Me.GroupBox3.Controls.Add(Me.dgvListProses)
        Me.GroupBox3.Controls.Add(Me.ChartPerforma)
        Me.GroupBox3.Location = New System.Drawing.Point(247, 326)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(590, 261)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'dgvListProses
        '
        Me.dgvListProses.AllowUserToAddRows = False
        Me.dgvListProses.AllowUserToDeleteRows = False
        Me.dgvListProses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListProses.Location = New System.Drawing.Point(375, 16)
        Me.dgvListProses.Name = "dgvListProses"
        Me.dgvListProses.ReadOnly = True
        Me.dgvListProses.RowHeadersVisible = False
        Me.dgvListProses.Size = New System.Drawing.Size(203, 233)
        Me.dgvListProses.TabIndex = 12
        '
        'ChartPerforma
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartPerforma.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.ChartPerforma.Legends.Add(Legend3)
        Me.ChartPerforma.Location = New System.Drawing.Point(16, 16)
        Me.ChartPerforma.Name = "ChartPerforma"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.ChartPerforma.Series.Add(Series3)
        Me.ChartPerforma.Size = New System.Drawing.Size(343, 222)
        Me.ChartPerforma.TabIndex = 11
        Me.ChartPerforma.Text = "Chart1"
        '
        'lblWorkLoad
        '
        Me.lblWorkLoad.AutoSize = True
        Me.lblWorkLoad.Location = New System.Drawing.Point(16, 245)
        Me.lblWorkLoad.Name = "lblWorkLoad"
        Me.lblWorkLoad.Size = New System.Drawing.Size(80, 13)
        Me.lblWorkLoad.TabIndex = 13
        Me.lblWorkLoad.Text = "Beban Kerja : 0"
        '
        'frmStoreDatabasePerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 612)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmStoreDatabasePerformance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IntegrationMonitoring"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvListKontrolForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListProses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPerforma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip

    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrGrafik As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvListKontrolForm As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPasswordlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnStopProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListProses As System.Windows.Forms.DataGridView
    Friend WithEvents ChartPerforma As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblWorkLoad As System.Windows.Forms.Label
End Class
