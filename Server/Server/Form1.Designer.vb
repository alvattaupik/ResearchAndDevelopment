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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtIsiBroadcast = New System.Windows.Forms.TextBox()
        Me.cmdSendBroadcast = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDisplaybroadcast = New System.Windows.Forms.RichTextBox()
        Me.dgDaftarTugas = New System.Windows.Forms.DataGridView()
        Me.cmbListDB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdStartMonitoring = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSessionTrace = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdStopMonitoring = New System.Windows.Forms.Button()
        Me.lblWorkLoad = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBebanLoad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIsiRunningText = New System.Windows.Forms.TextBox()
        Me.cmdSendRunningText = New System.Windows.Forms.Button()
        Me.txtDisplayRunningTextBroadcast = New System.Windows.Forms.RichTextBox()
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Server"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtIsiBroadcast
        '
        Me.txtIsiBroadcast.Location = New System.Drawing.Point(409, 128)
        Me.txtIsiBroadcast.Multiline = True
        Me.txtIsiBroadcast.Name = "txtIsiBroadcast"
        Me.txtIsiBroadcast.Size = New System.Drawing.Size(176, 65)
        Me.txtIsiBroadcast.TabIndex = 4
        '
        'cmdSendBroadcast
        '
        Me.cmdSendBroadcast.Location = New System.Drawing.Point(591, 126)
        Me.cmdSendBroadcast.Name = "cmdSendBroadcast"
        Me.cmdSendBroadcast.Size = New System.Drawing.Size(75, 67)
        Me.cmdSendBroadcast.TabIndex = 5
        Me.cmdSendBroadcast.Text = "Send"
        Me.cmdSendBroadcast.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SQL Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Monitoring"
        '
        'txtDisplaybroadcast
        '
        Me.txtDisplaybroadcast.Location = New System.Drawing.Point(409, 34)
        Me.txtDisplaybroadcast.Name = "txtDisplaybroadcast"
        Me.txtDisplaybroadcast.ReadOnly = True
        Me.txtDisplaybroadcast.Size = New System.Drawing.Size(257, 86)
        Me.txtDisplaybroadcast.TabIndex = 3
        Me.txtDisplaybroadcast.Text = ""
        '
        'dgDaftarTugas
        '
        Me.dgDaftarTugas.AllowUserToAddRows = False
        Me.dgDaftarTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarTugas.Location = New System.Drawing.Point(11, 193)
        Me.dgDaftarTugas.Name = "dgDaftarTugas"
        Me.dgDaftarTugas.ReadOnly = True
        Me.dgDaftarTugas.Size = New System.Drawing.Size(383, 158)
        Me.dgDaftarTugas.TabIndex = 9
        '
        'cmbListDB
        '
        Me.cmbListDB.FormattingEnabled = True
        Me.cmbListDB.Location = New System.Drawing.Point(60, 7)
        Me.cmbListDB.Name = "cmbListDB"
        Me.cmbListDB.Size = New System.Drawing.Size(198, 21)
        Me.cmbListDB.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Database"
        '
        'cmdStartMonitoring
        '
        Me.cmdStartMonitoring.Location = New System.Drawing.Point(264, 3)
        Me.cmdStartMonitoring.Name = "cmdStartMonitoring"
        Me.cmdStartMonitoring.Size = New System.Drawing.Size(115, 28)
        Me.cmdStartMonitoring.TabIndex = 12
        Me.cmdStartMonitoring.Text = "Start Monitoring"
        Me.cmdStartMonitoring.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdSessionTrace)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.cmdStopMonitoring)
        Me.Panel1.Controls.Add(Me.cmdStartMonitoring)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbListDB)
        Me.Panel1.Location = New System.Drawing.Point(11, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 98)
        Me.Panel1.TabIndex = 13
        '
        'cmdSessionTrace
        '
        Me.cmdSessionTrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSessionTrace.Location = New System.Drawing.Point(60, 34)
        Me.cmdSessionTrace.Name = "cmdSessionTrace"
        Me.cmdSessionTrace.Size = New System.Drawing.Size(88, 51)
        Me.cmdSessionTrace.TabIndex = 15
        Me.cmdSessionTrace.Text = "Session Trace"
        Me.cmdSessionTrace.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(264, 64)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(115, 25)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdStopMonitoring
        '
        Me.cmdStopMonitoring.Location = New System.Drawing.Point(264, 34)
        Me.cmdStopMonitoring.Name = "cmdStopMonitoring"
        Me.cmdStopMonitoring.Size = New System.Drawing.Size(115, 25)
        Me.cmdStopMonitoring.TabIndex = 13
        Me.cmdStopMonitoring.Text = "Stop Monitoring"
        Me.cmdStopMonitoring.UseVisualStyleBackColor = True
        '
        'lblWorkLoad
        '
        Me.lblWorkLoad.AutoSize = True
        Me.lblWorkLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkLoad.Location = New System.Drawing.Point(191, 360)
        Me.lblWorkLoad.Name = "lblWorkLoad"
        Me.lblWorkLoad.Size = New System.Drawing.Size(132, 25)
        Me.lblWorkLoad.TabIndex = 14
        Me.lblWorkLoad.Text = "WorkLoad :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Server.My.Resources.Resources.sql_server_logo_png_8
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtBebanLoad
        '
        Me.txtBebanLoad.AutoSize = True
        Me.txtBebanLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBebanLoad.Location = New System.Drawing.Point(365, 360)
        Me.txtBebanLoad.Name = "txtBebanLoad"
        Me.txtBebanLoad.Size = New System.Drawing.Size(25, 25)
        Me.txtBebanLoad.TabIndex = 15
        Me.txtBebanLoad.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Broadcast Message"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusServer})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 388)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(673, 26)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusServer
        '
        Me.StatusServer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusServer.Name = "StatusServer"
        Me.StatusServer.Size = New System.Drawing.Size(110, 21)
        Me.StatusServer.Text = "Server Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Broadcast Running Text"
        Me.Label5.Visible = False
        '
        'txtIsiRunningText
        '
        Me.txtIsiRunningText.Location = New System.Drawing.Point(409, 314)
        Me.txtIsiRunningText.Multiline = True
        Me.txtIsiRunningText.Name = "txtIsiRunningText"
        Me.txtIsiRunningText.Size = New System.Drawing.Size(176, 38)
        Me.txtIsiRunningText.TabIndex = 19
        '
        'cmdSendRunningText
        '
        Me.cmdSendRunningText.Location = New System.Drawing.Point(598, 313)
        Me.cmdSendRunningText.Name = "cmdSendRunningText"
        Me.cmdSendRunningText.Size = New System.Drawing.Size(68, 38)
        Me.cmdSendRunningText.TabIndex = 20
        Me.cmdSendRunningText.Text = "Send"
        Me.cmdSendRunningText.UseVisualStyleBackColor = True
        '
        'txtDisplayRunningTextBroadcast
        '
        Me.txtDisplayRunningTextBroadcast.Location = New System.Drawing.Point(409, 244)
        Me.txtDisplayRunningTextBroadcast.Name = "txtDisplayRunningTextBroadcast"
        Me.txtDisplayRunningTextBroadcast.ReadOnly = True
        Me.txtDisplayRunningTextBroadcast.Size = New System.Drawing.Size(257, 64)
        Me.txtDisplayRunningTextBroadcast.TabIndex = 21
        Me.txtDisplayRunningTextBroadcast.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 414)
        Me.Controls.Add(Me.txtDisplayRunningTextBroadcast)
        Me.Controls.Add(Me.cmdSendRunningText)
        Me.Controls.Add(Me.txtIsiRunningText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBebanLoad)
        Me.Controls.Add(Me.lblWorkLoad)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgDaftarTugas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSendBroadcast)
        Me.Controls.Add(Me.txtIsiBroadcast)
        Me.Controls.Add(Me.txtDisplaybroadcast)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Side"
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtIsiBroadcast As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendBroadcast As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDisplaybroadcast As System.Windows.Forms.RichTextBox
    Friend WithEvents dgDaftarTugas As System.Windows.Forms.DataGridView
    Friend WithEvents cmbListDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdStartMonitoring As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWorkLoad As System.Windows.Forms.Label
    Friend WithEvents cmdSessionTrace As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdStopMonitoring As System.Windows.Forms.Button
    Friend WithEvents txtBebanLoad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIsiRunningText As System.Windows.Forms.TextBox
    Friend WithEvents cmdSendRunningText As System.Windows.Forms.Button
    Friend WithEvents txtDisplayRunningTextBroadcast As System.Windows.Forms.RichTextBox

End Class
