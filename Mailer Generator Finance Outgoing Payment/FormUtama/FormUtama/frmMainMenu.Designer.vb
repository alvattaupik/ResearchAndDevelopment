<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BehaviourAndConfigurationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmdManualStart = New System.Windows.Forms.Button()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPenerima = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoDokumen = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStrip1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgDaftarManualDiscount = New System.Windows.Forms.DataGridView()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblRecordTerkirim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgSuccess = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahRecordgagal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dtpAkhirFailed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAwalFailed = New System.Windows.Forms.DateTimePicker()
        Me.cmdRetryOne = New System.Windows.Forms.Button()
        Me.cmdShowData = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRetry = New System.Windows.Forms.Button()
        Me.dgFailed = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdPaused = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblAwal = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgDaftarManualDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.dgSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        CType(Me.dgFailed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailConfigurationToolStripMenuItem, Me.BehaviourAndConfigurationsToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'EmailConfigurationToolStripMenuItem
        '
        Me.EmailConfigurationToolStripMenuItem.Name = "EmailConfigurationToolStripMenuItem"
        Me.EmailConfigurationToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EmailConfigurationToolStripMenuItem.Text = "Email Configuration"
        '
        'BehaviourAndConfigurationsToolStripMenuItem
        '
        Me.BehaviourAndConfigurationsToolStripMenuItem.Name = "BehaviourAndConfigurationsToolStripMenuItem"
        Me.BehaviourAndConfigurationsToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.BehaviourAndConfigurationsToolStripMenuItem.Text = "Behaviour and Configurations"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Controls.Add(Me.dgDaftarManualDiscount)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 249)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Outgoing Payments"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdManualStart)
        Me.GroupBox8.Controls.Add(Me.cmdShow)
        Me.GroupBox8.Controls.Add(Me.dtpAkhir)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.dtpAwal)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(233, 114)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Custom Parameter"
        '
        'cmdManualStart
        '
        Me.cmdManualStart.Location = New System.Drawing.Point(162, 79)
        Me.cmdManualStart.Name = "cmdManualStart"
        Me.cmdManualStart.Size = New System.Drawing.Size(54, 25)
        Me.cmdManualStart.TabIndex = 12
        Me.cmdManualStart.Text = "Start"
        Me.cmdManualStart.UseVisualStyleBackColor = True
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(88, 79)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(68, 25)
        Me.cmdShow.TabIndex = 11
        Me.cmdShow.Text = "Show"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhir.Location = New System.Drawing.Point(88, 49)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(128, 24)
        Me.dtpAkhir.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Start From"
        '
        'dtpAwal
        '
        Me.dtpAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwal.Location = New System.Drawing.Point(88, 19)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(128, 24)
        Me.dtpAwal.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtPenerima)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.txtNoDokumen)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 133)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(237, 79)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Outgoing Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Recipient"
        '
        'txtPenerima
        '
        Me.txtPenerima.Location = New System.Drawing.Point(80, 45)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.Size = New System.Drawing.Size(151, 20)
        Me.txtPenerima.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No Dokumen"
        '
        'txtNoDokumen
        '
        Me.txtNoDokumen.Location = New System.Drawing.Point(80, 19)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.Size = New System.Drawing.Size(151, 20)
        Me.txtNoDokumen.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStrip1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 224)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(934, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStrip1
        '
        Me.lblStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrip1.ForeColor = System.Drawing.Color.Black
        Me.lblStrip1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblStrip1.Name = "lblStrip1"
        Me.lblStrip1.Size = New System.Drawing.Size(107, 17)
        Me.lblStrip1.Text = "Jumlah Record :"
        Me.lblStrip1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dgDaftarManualDiscount
        '
        Me.dgDaftarManualDiscount.AllowUserToAddRows = False
        Me.dgDaftarManualDiscount.AllowUserToDeleteRows = False
        Me.dgDaftarManualDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarManualDiscount.Location = New System.Drawing.Point(250, 19)
        Me.dgDaftarManualDiscount.Name = "dgDaftarManualDiscount"
        Me.dgDaftarManualDiscount.Size = New System.Drawing.Size(687, 202)
        Me.dgDaftarManualDiscount.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(491, 51)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(20, 25)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "-"
        Me.lblTime.Visible = False
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(373, 11)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(310, 24)
        Me.lblJudul.TabIndex = 9
        Me.lblJudul.Text = "Next Execution Plan Will Start In"
        Me.lblJudul.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LavenderBlush
        Me.GroupBox2.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 380)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preview Report"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(493, 361)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox4.Controls.Add(Me.StatusStrip2)
        Me.GroupBox4.Controls.Add(Me.dgSuccess)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(514, 369)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(434, 163)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Success To Send"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.SpringGreen
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblRecordTerkirim})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 138)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(428, 22)
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblRecordTerkirim
        '
        Me.lblRecordTerkirim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordTerkirim.Name = "lblRecordTerkirim"
        Me.lblRecordTerkirim.Size = New System.Drawing.Size(162, 17)
        Me.lblRecordTerkirim.Text = "Jumlah Record Terkirim :"
        '
        'dgSuccess
        '
        Me.dgSuccess.AllowUserToAddRows = False
        Me.dgSuccess.AllowUserToDeleteRows = False
        Me.dgSuccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSuccess.Location = New System.Drawing.Point(6, 16)
        Me.dgSuccess.Name = "dgSuccess"
        Me.dgSuccess.Size = New System.Drawing.Size(425, 119)
        Me.dgSuccess.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Red
        Me.GroupBox5.Controls.Add(Me.StatusStrip3)
        Me.GroupBox5.Controls.Add(Me.dtpAkhirFailed)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.dtpAwalFailed)
        Me.GroupBox5.Controls.Add(Me.cmdRetryOne)
        Me.GroupBox5.Controls.Add(Me.cmdShowData)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cmdRetry)
        Me.GroupBox5.Controls.Add(Me.dgFailed)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(514, 538)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(434, 208)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Failed To Send, Waiting to Resend"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.BackColor = System.Drawing.Color.Red
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahRecordgagal})
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 183)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(428, 22)
        Me.StatusStrip3.TabIndex = 10
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'lblJumlahRecordgagal
        '
        Me.lblJumlahRecordgagal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahRecordgagal.Name = "lblJumlahRecordgagal"
        Me.lblJumlahRecordgagal.Size = New System.Drawing.Size(201, 17)
        Me.lblJumlahRecordgagal.Text = "Jumlah Record Gagal Terkirim :"
        '
        'dtpAkhirFailed
        '
        Me.dtpAkhirFailed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhirFailed.Location = New System.Drawing.Point(213, 29)
        Me.dtpAkhirFailed.Name = "dtpAkhirFailed"
        Me.dtpAkhirFailed.Size = New System.Drawing.Size(121, 20)
        Me.dtpAkhirFailed.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "S/D"
        '
        'dtpAwalFailed
        '
        Me.dtpAwalFailed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwalFailed.Location = New System.Drawing.Point(66, 29)
        Me.dtpAwalFailed.Name = "dtpAwalFailed"
        Me.dtpAwalFailed.Size = New System.Drawing.Size(101, 20)
        Me.dtpAwalFailed.TabIndex = 7
        '
        'cmdRetryOne
        '
        Me.cmdRetryOne.Location = New System.Drawing.Point(340, 95)
        Me.cmdRetryOne.Name = "cmdRetryOne"
        Me.cmdRetryOne.Size = New System.Drawing.Size(91, 28)
        Me.cmdRetryOne.TabIndex = 6
        Me.cmdRetryOne.Text = "Retry"
        Me.cmdRetryOne.UseVisualStyleBackColor = True
        '
        'cmdShowData
        '
        Me.cmdShowData.Location = New System.Drawing.Point(340, 27)
        Me.cmdShowData.Name = "cmdShowData"
        Me.cmdShowData.Size = New System.Drawing.Size(91, 28)
        Me.cmdShowData.TabIndex = 5
        Me.cmdShowData.Text = "Show Data"
        Me.cmdShowData.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Priode"
        '
        'cmdRetry
        '
        Me.cmdRetry.Location = New System.Drawing.Point(340, 61)
        Me.cmdRetry.Name = "cmdRetry"
        Me.cmdRetry.Size = New System.Drawing.Size(91, 28)
        Me.cmdRetry.TabIndex = 2
        Me.cmdRetry.Text = "Retry ALL"
        Me.cmdRetry.UseVisualStyleBackColor = True
        '
        'dgFailed
        '
        Me.dgFailed.AllowUserToAddRows = False
        Me.dgFailed.AllowUserToDeleteRows = False
        Me.dgFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFailed.Location = New System.Drawing.Point(7, 61)
        Me.dgFailed.Name = "dgFailed"
        Me.dgFailed.Size = New System.Drawing.Size(327, 119)
        Me.dgFailed.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.PictureBox3)
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.cmdPaused)
        Me.GroupBox6.Controls.Add(Me.cmdStart)
        Me.GroupBox6.Controls.Add(Me.lblTime)
        Me.GroupBox6.Controls.Add(Me.cmdCancel)
        Me.GroupBox6.Controls.Add(Me.lblJudul)
        Me.GroupBox6.Controls.Add(Me.lblCounter)
        Me.GroupBox6.Controls.Add(Me.lblAwal)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(940, 86)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(183, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "V 1.1"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.OutgoingPayment.My.Resources.Resources._13_512
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(68, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 43)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.OutgoingPayment.My.Resources.Resources.email_notification_1533987_1300068
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(15, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 42)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(54, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Outgoing Notification "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 68)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cmdPaused
        '
        Me.cmdPaused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPaused.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPaused.Location = New System.Drawing.Point(880, 11)
        Me.cmdPaused.Name = "cmdPaused"
        Me.cmdPaused.Size = New System.Drawing.Size(57, 75)
        Me.cmdPaused.TabIndex = 12
        Me.cmdPaused.Text = "Pause"
        Me.cmdPaused.UseVisualStyleBackColor = False
        '
        'cmdStart
        '
        Me.cmdStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(817, 11)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(57, 75)
        Me.cmdStart.TabIndex = 11
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(743, 11)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(68, 75)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(485, 44)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(36, 39)
        Me.lblCounter.TabIndex = 8
        Me.lblCounter.Text = "0"
        '
        'lblAwal
        '
        Me.lblAwal.AutoSize = True
        Me.lblAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwal.Location = New System.Drawing.Point(320, 11)
        Me.lblAwal.Name = "lblAwal"
        Me.lblAwal.Size = New System.Drawing.Size(399, 24)
        Me.lblAwal.TabIndex = 0
        Me.lblAwal.Text = "This Application Will Start Automatically In"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Build 11.11.19"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 749)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgDaftarManualDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.dgSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        CType(Me.dgFailed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDaftarManualDiscount As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoDokumen As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStrip1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BehaviourAndConfigurationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSuccess As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRetry As System.Windows.Forms.Button
    Friend WithEvents dgFailed As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents lblAwal As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdManualStart As System.Windows.Forms.Button
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdShowData As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdPaused As System.Windows.Forms.Button
    Friend WithEvents cmdRetryOne As System.Windows.Forms.Button
    Friend WithEvents dtpAkhirFailed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpAwalFailed As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblRecordTerkirim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahRecordgagal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
