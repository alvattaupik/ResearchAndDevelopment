<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabasePerformance
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvListKontrolForm = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrPerformance = New System.Windows.Forms.Timer(Me.components)
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
        Me.txtIsiPesan = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvListProses = New System.Windows.Forms.DataGridView()
        Me.ChartPerforma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvListKontrolForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListProses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartPerforma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.dgvListKontrolForm)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-2, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 535)
        Me.Panel2.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(8, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Engine Version 1.2.06.2020"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(8, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Monitor"
        '
        'dgvListKontrolForm
        '
        Me.dgvListKontrolForm.AllowUserToAddRows = False
        Me.dgvListKontrolForm.AllowUserToDeleteRows = False
        Me.dgvListKontrolForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListKontrolForm.Location = New System.Drawing.Point(194, 86)
        Me.dgvListKontrolForm.Name = "dgvListKontrolForm"
        Me.dgvListKontrolForm.Size = New System.Drawing.Size(41, 25)
        Me.dgvListKontrolForm.TabIndex = 7
        Me.dgvListKontrolForm.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(130, 55)
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
        Me.Label2.Location = New System.Drawing.Point(8, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Database Performance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(130, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anyar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1227, 22)
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
        'tmrPerformance
        '
        Me.tmrPerformance.Interval = 1000
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
        Me.GroupBox1.Location = New System.Drawing.Point(247, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 196)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameters"
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Location = New System.Drawing.Point(822, 19)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(134, 41)
        Me.btnProses.TabIndex = 3
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox2.Size = New System.Drawing.Size(955, 121)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'btnStopProses
        '
        Me.btnStopProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStopProses.Location = New System.Drawing.Point(815, 22)
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
        Me.txtPasswordlogin.Size = New System.Drawing.Size(648, 20)
        Me.txtPasswordlogin.TabIndex = 9
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.Enabled = False
        Me.txtUsernameLogin.Location = New System.Drawing.Point(132, 68)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsernameLogin.Size = New System.Drawing.Size(648, 20)
        Me.txtUsernameLogin.TabIndex = 8
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.Enabled = False
        Me.txtDatabaseName.Location = New System.Drawing.Point(132, 40)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDatabaseName.Size = New System.Drawing.Size(648, 20)
        Me.txtDatabaseName.TabIndex = 7
        '
        'txtServerName
        '
        Me.txtServerName.Enabled = False
        Me.txtServerName.Location = New System.Drawing.Point(132, 14)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(648, 20)
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
        Me.cmbLocation.Size = New System.Drawing.Size(648, 28)
        Me.cmbLocation.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtIsiPesan)
        Me.GroupBox3.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dgvListProses)
        Me.GroupBox3.Controls.Add(Me.ChartPerforma)
        Me.GroupBox3.Location = New System.Drawing.Point(247, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 320)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'txtIsiPesan
        '
        Me.txtIsiPesan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIsiPesan.Enabled = False
        Me.txtIsiPesan.Location = New System.Drawing.Point(53, 56)
        Me.txtIsiPesan.Name = "txtIsiPesan"
        Me.txtIsiPesan.Size = New System.Drawing.Size(219, 89)
        Me.txtIsiPesan.TabIndex = 22
        Me.txtIsiPesan.Text = ""
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Yellow
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(820, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "PROSES"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Yellow
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(824, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "DETAIL"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(537, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 20)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "WAKTU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Kerja  "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Yellow
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(332, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Beban"
        '
        'dgvListProses
        '
        Me.dgvListProses.AllowUserToAddRows = False
        Me.dgvListProses.AllowUserToDeleteRows = False
        Me.dgvListProses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListProses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListProses.Location = New System.Drawing.Point(756, 56)
        Me.dgvListProses.Name = "dgvListProses"
        Me.dgvListProses.ReadOnly = True
        Me.dgvListProses.RowHeadersVisible = False
        Me.dgvListProses.Size = New System.Drawing.Size(204, 233)
        Me.dgvListProses.TabIndex = 14
        '
        'ChartPerforma
        '
        Me.ChartPerforma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.ChartPerforma.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartPerforma.Legends.Add(Legend1)
        Me.ChartPerforma.Location = New System.Drawing.Point(397, 18)
        Me.ChartPerforma.Name = "ChartPerforma"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartPerforma.Series.Add(Series1)
        Me.ChartPerforma.Size = New System.Drawing.Size(353, 271)
        Me.ChartPerforma.TabIndex = 13
        Me.ChartPerforma.Text = "Chart1"
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Chat
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(15, 18)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(299, 258)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 21
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Loading_8
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmDatabasePerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 559)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmDatabasePerformance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IntegrationMonitoring"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvListKontrolForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListProses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPerforma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip

    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrPerformance As System.Windows.Forms.Timer
    Friend WithEvents dgvListKontrolForm As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStopProses As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListProses As System.Windows.Forms.DataGridView
    Friend WithEvents ChartPerforma As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents txtIsiPesan As System.Windows.Forms.RichTextBox
End Class
