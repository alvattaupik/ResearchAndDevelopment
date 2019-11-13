<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoring
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdStopMonitoring = New System.Windows.Forms.Button()
        Me.cmdStartMonitoring = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbListDB = New System.Windows.Forms.ComboBox()
        Me.dgDaftarTugas = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdConnectionMonitor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdSessionTrace = New System.Windows.Forms.Button()
        Me.cmdKillSession = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monitoring Tools 1.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SQL SERVER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdRefresh)
        Me.GroupBox2.Controls.Add(Me.cmdStopMonitoring)
        Me.GroupBox2.Controls.Add(Me.cmdStartMonitoring)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbListDB)
        Me.GroupBox2.Controls.Add(Me.dgDaftarTugas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 354)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Task Monitor"
        '
        'cmdStopMonitoring
        '
        Me.cmdStopMonitoring.Location = New System.Drawing.Point(440, 30)
        Me.cmdStopMonitoring.Name = "cmdStopMonitoring"
        Me.cmdStopMonitoring.Size = New System.Drawing.Size(166, 27)
        Me.cmdStopMonitoring.TabIndex = 4
        Me.cmdStopMonitoring.Text = "Stop"
        Me.cmdStopMonitoring.UseVisualStyleBackColor = True
        '
        'cmdStartMonitoring
        '
        Me.cmdStartMonitoring.Location = New System.Drawing.Point(291, 30)
        Me.cmdStartMonitoring.Name = "cmdStartMonitoring"
        Me.cmdStartMonitoring.Size = New System.Drawing.Size(143, 28)
        Me.cmdStartMonitoring.TabIndex = 3
        Me.cmdStartMonitoring.Text = "Start Monitoring"
        Me.cmdStartMonitoring.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Database"
        '
        'cmbListDB
        '
        Me.cmbListDB.FormattingEnabled = True
        Me.cmbListDB.Location = New System.Drawing.Point(86, 32)
        Me.cmbListDB.Name = "cmbListDB"
        Me.cmbListDB.Size = New System.Drawing.Size(199, 26)
        Me.cmbListDB.TabIndex = 1
        '
        'dgDaftarTugas
        '
        Me.dgDaftarTugas.AllowUserToAddRows = False
        Me.dgDaftarTugas.AllowUserToDeleteRows = False
        Me.dgDaftarTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarTugas.Location = New System.Drawing.Point(4, 98)
        Me.dgDaftarTugas.Name = "dgDaftarTugas"
        Me.dgDaftarTugas.Size = New System.Drawing.Size(600, 250)
        Me.dgDaftarTugas.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 603)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(630, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(291, 64)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(143, 28)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdKillSession)
        Me.GroupBox3.Controls.Add(Me.cmdSessionTrace)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmdConnectionMonitor)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 95)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Feature"
        '
        'cmdConnectionMonitor
        '
        Me.cmdConnectionMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnectionMonitor.Location = New System.Drawing.Point(6, 30)
        Me.cmdConnectionMonitor.Name = "cmdConnectionMonitor"
        Me.cmdConnectionMonitor.Size = New System.Drawing.Size(96, 51)
        Me.cmdConnectionMonitor.TabIndex = 0
        Me.cmdConnectionMonitor.Text = "Connection Monitor"
        Me.cmdConnectionMonitor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(108, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Performance Monitor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(219, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Expensive Query"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdSessionTrace
        '
        Me.cmdSessionTrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSessionTrace.Location = New System.Drawing.Point(315, 30)
        Me.cmdSessionTrace.Name = "cmdSessionTrace"
        Me.cmdSessionTrace.Size = New System.Drawing.Size(88, 51)
        Me.cmdSessionTrace.TabIndex = 3
        Me.cmdSessionTrace.Text = "Session Trace"
        Me.cmdSessionTrace.UseVisualStyleBackColor = True
        '
        'cmdKillSession
        '
        Me.cmdKillSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKillSession.Location = New System.Drawing.Point(520, 30)
        Me.cmdKillSession.Name = "cmdKillSession"
        Me.cmdKillSession.Size = New System.Drawing.Size(86, 51)
        Me.cmdKillSession.TabIndex = 4
        Me.cmdKillSession.Text = "Kill Session"
        Me.cmdKillSession.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.microsoftsqlserver
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 625)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Monitoring"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbListDB As System.Windows.Forms.ComboBox
    Friend WithEvents dgDaftarTugas As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents cmdStopMonitoring As System.Windows.Forms.Button
    Friend WithEvents cmdStartMonitoring As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConnectionMonitor As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdKillSession As System.Windows.Forms.Button
    Friend WithEvents cmdSessionTrace As System.Windows.Forms.Button

End Class
