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
        Me.ErrorNotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmdStartmanualparameter = New System.Windows.Forms.Button()
        Me.cmdShowManualParameter = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtPenerima = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoDokumen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.lblJumlahTerkirim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgSuccess = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.lblGagalTerkirim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdShowData = New System.Windows.Forms.Button()
        Me.dtpAkhirFailed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAwalFailed = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdRetryAll = New System.Windows.Forms.Button()
        Me.cmdRetry = New System.Windows.Forms.Button()
        Me.dgFailed = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdPaused = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.lblAwal = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
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
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailConfigurationToolStripMenuItem, Me.BehaviourAndConfigurationsToolStripMenuItem, Me.ErrorNotificationToolStripMenuItem})
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
        'ErrorNotificationToolStripMenuItem
        '
        Me.ErrorNotificationToolStripMenuItem.Name = "ErrorNotificationToolStripMenuItem"
        Me.ErrorNotificationToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ErrorNotificationToolStripMenuItem.Text = "Error Notification"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.StatusStrip1)
        Me.GroupBox1.Controls.Add(Me.dgDaftarManualDiscount)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 249)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Manual Discount"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdStartmanualparameter)
        Me.GroupBox8.Controls.Add(Me.cmdShowManualParameter)
        Me.GroupBox8.Controls.Add(Me.dtpAkhir)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.dtpAwal)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(237, 110)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Custom Parameter"
        '
        'cmdStartmanualparameter
        '
        Me.cmdStartmanualparameter.Location = New System.Drawing.Point(159, 79)
        Me.cmdStartmanualparameter.Name = "cmdStartmanualparameter"
        Me.cmdStartmanualparameter.Size = New System.Drawing.Size(65, 25)
        Me.cmdStartmanualparameter.TabIndex = 8
        Me.cmdStartmanualparameter.Text = "Start"
        Me.cmdStartmanualparameter.UseVisualStyleBackColor = True
        '
        'cmdShowManualParameter
        '
        Me.cmdShowManualParameter.Location = New System.Drawing.Point(96, 79)
        Me.cmdShowManualParameter.Name = "cmdShowManualParameter"
        Me.cmdShowManualParameter.Size = New System.Drawing.Size(57, 25)
        Me.cmdShowManualParameter.TabIndex = 7
        Me.cmdShowManualParameter.Text = "Show"
        Me.cmdShowManualParameter.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhir.Location = New System.Drawing.Point(96, 49)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(128, 26)
        Me.dtpAkhir.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start From"
        '
        'dtpAwal
        '
        Me.dtpAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwal.Location = New System.Drawing.Point(96, 17)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(128, 26)
        Me.dtpAwal.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtPenerima)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtNoDokumen)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 132)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(238, 80)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Details"
        '
        'txtPenerima
        '
        Me.txtPenerima.Location = New System.Drawing.Point(83, 45)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.Size = New System.Drawing.Size(141, 20)
        Me.txtPenerima.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Recipient"
        '
        'txtNoDokumen
        '
        Me.txtNoDokumen.Location = New System.Drawing.Point(83, 19)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.Size = New System.Drawing.Size(141, 20)
        Me.txtNoDokumen.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No Dokumen"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStrip1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 224)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(920, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStrip1
        '
        Me.lblStrip1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblStrip1.Name = "lblStrip1"
        Me.lblStrip1.Size = New System.Drawing.Size(91, 17)
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
        Me.dgDaftarManualDiscount.Size = New System.Drawing.Size(667, 193)
        Me.dgDaftarManualDiscount.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(501, 47)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(20, 25)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "-"
        Me.lblTime.Visible = False
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(388, 19)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(227, 16)
        Me.lblJudul.TabIndex = 9
        Me.lblJudul.Text = "Next Execution Plan Will Start In"
        Me.lblJudul.Visible = False
        '
        'GroupBox2
        '
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
        Me.GroupBox4.Controls.Add(Me.StatusStrip2)
        Me.GroupBox4.Controls.Add(Me.dgSuccess)
        Me.GroupBox4.Location = New System.Drawing.Point(514, 369)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 163)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Success To Send"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahTerkirim})
        Me.StatusStrip2.Location = New System.Drawing.Point(3, 138)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(414, 22)
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblJumlahTerkirim
        '
        Me.lblJumlahTerkirim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahTerkirim.Name = "lblJumlahTerkirim"
        Me.lblJumlahTerkirim.Size = New System.Drawing.Size(146, 17)
        Me.lblJumlahTerkirim.Text = "Jumlah Email Terkirim"
        '
        'dgSuccess
        '
        Me.dgSuccess.AllowUserToAddRows = False
        Me.dgSuccess.AllowUserToDeleteRows = False
        Me.dgSuccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSuccess.Location = New System.Drawing.Point(6, 22)
        Me.dgSuccess.Name = "dgSuccess"
        Me.dgSuccess.Size = New System.Drawing.Size(408, 113)
        Me.dgSuccess.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.StatusStrip3)
        Me.GroupBox5.Controls.Add(Me.cmdShowData)
        Me.GroupBox5.Controls.Add(Me.dtpAkhirFailed)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.dtpAwalFailed)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cmdRetryAll)
        Me.GroupBox5.Controls.Add(Me.cmdRetry)
        Me.GroupBox5.Controls.Add(Me.dgFailed)
        Me.GroupBox5.Location = New System.Drawing.Point(514, 538)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(420, 208)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Failed To Send, Waiting to Resend"
        '
        'StatusStrip3
        '
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblGagalTerkirim})
        Me.StatusStrip3.Location = New System.Drawing.Point(3, 183)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(414, 22)
        Me.StatusStrip3.TabIndex = 12
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'lblGagalTerkirim
        '
        Me.lblGagalTerkirim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGagalTerkirim.Name = "lblGagalTerkirim"
        Me.lblGagalTerkirim.Size = New System.Drawing.Size(185, 17)
        Me.lblGagalTerkirim.Text = "Jumlah Email Gagal Terkirim"
        '
        'cmdShowData
        '
        Me.cmdShowData.Location = New System.Drawing.Point(340, 22)
        Me.cmdShowData.Name = "cmdShowData"
        Me.cmdShowData.Size = New System.Drawing.Size(75, 28)
        Me.cmdShowData.TabIndex = 11
        Me.cmdShowData.Text = "Show Data"
        Me.cmdShowData.UseVisualStyleBackColor = True
        '
        'dtpAkhirFailed
        '
        Me.dtpAkhirFailed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhirFailed.Location = New System.Drawing.Point(212, 24)
        Me.dtpAkhirFailed.Name = "dtpAkhirFailed"
        Me.dtpAkhirFailed.Size = New System.Drawing.Size(121, 20)
        Me.dtpAkhirFailed.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "S/D"
        '
        'dtpAwalFailed
        '
        Me.dtpAwalFailed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwalFailed.Location = New System.Drawing.Point(66, 24)
        Me.dtpAwalFailed.Name = "dtpAwalFailed"
        Me.dtpAwalFailed.Size = New System.Drawing.Size(101, 20)
        Me.dtpAwalFailed.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Priode"
        '
        'cmdRetryAll
        '
        Me.cmdRetryAll.Location = New System.Drawing.Point(341, 56)
        Me.cmdRetryAll.Name = "cmdRetryAll"
        Me.cmdRetryAll.Size = New System.Drawing.Size(74, 28)
        Me.cmdRetryAll.TabIndex = 3
        Me.cmdRetryAll.Text = "Retry ALL"
        Me.cmdRetryAll.UseVisualStyleBackColor = True
        '
        'cmdRetry
        '
        Me.cmdRetry.Location = New System.Drawing.Point(340, 90)
        Me.cmdRetry.Name = "cmdRetry"
        Me.cmdRetry.Size = New System.Drawing.Size(74, 28)
        Me.cmdRetry.TabIndex = 2
        Me.cmdRetry.Text = "Retry"
        Me.cmdRetry.UseVisualStyleBackColor = True
        '
        'dgFailed
        '
        Me.dgFailed.AllowUserToAddRows = False
        Me.dgFailed.AllowUserToDeleteRows = False
        Me.dgFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFailed.Location = New System.Drawing.Point(6, 53)
        Me.dgFailed.Name = "dgFailed"
        Me.dgFailed.Size = New System.Drawing.Size(327, 129)
        Me.dgFailed.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.cmdPaused)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.cmdStart)
        Me.GroupBox6.Controls.Add(Me.lblTime)
        Me.GroupBox6.Controls.Add(Me.lblJudul)
        Me.GroupBox6.Controls.Add(Me.lblCounter)
        Me.GroupBox6.Controls.Add(Me.lblAwal)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(926, 86)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'cmdPaused
        '
        Me.cmdPaused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPaused.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPaused.Location = New System.Drawing.Point(863, 11)
        Me.cmdPaused.Name = "cmdPaused"
        Me.cmdPaused.Size = New System.Drawing.Size(57, 75)
        Me.cmdPaused.TabIndex = 14
        Me.cmdPaused.Text = "Pause"
        Me.cmdPaused.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(729, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 75)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdStart
        '
        Me.cmdStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(803, 11)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(57, 75)
        Me.cmdStart.TabIndex = 12
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = False
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(499, 35)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(36, 39)
        Me.lblCounter.TabIndex = 8
        Me.lblCounter.Text = "0"
        '
        'lblAwal
        '
        Me.lblAwal.AutoSize = True
        Me.lblAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwal.Location = New System.Drawing.Point(376, 11)
        Me.lblAwal.Name = "lblAwal"
        Me.lblAwal.Size = New System.Drawing.Size(270, 24)
        Me.lblAwal.TabIndex = 0
        Me.lblAwal.Text = "This Application Will Start In"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FormUtama.My.Resources.Resources.Sale_Notification_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 86)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, -4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Manual Discount Notification"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(272, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "V 1.0"
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 749)
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStrip1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BehaviourAndConfigurationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSuccess As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRetryAll As System.Windows.Forms.Button
    Friend WithEvents cmdRetry As System.Windows.Forms.Button
    Friend WithEvents dgFailed As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents lblAwal As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoDokumen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdStartmanualparameter As System.Windows.Forms.Button
    Friend WithEvents cmdShowManualParameter As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdPaused As System.Windows.Forms.Button
    Friend WithEvents cmdShowData As System.Windows.Forms.Button
    Friend WithEvents dtpAkhirFailed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpAwalFailed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ErrorNotificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahTerkirim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip3 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblGagalTerkirim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
