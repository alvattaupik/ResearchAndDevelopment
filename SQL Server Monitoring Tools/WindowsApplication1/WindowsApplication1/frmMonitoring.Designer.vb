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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdStopMonitoring = New System.Windows.Forms.Button()
        Me.cmdStartMonitoring = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbListDB = New System.Windows.Forms.ComboBox()
        Me.dgDaftarTugas = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdKillSession = New System.Windows.Forms.Button()
        Me.cmdSessionTrace = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdConnectionMonitor = New System.Windows.Forms.Button()
        Me.txtBebanLoad = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monitoring Tools 1.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SQL SERVER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SQLServerMonitoringTools.My.Resources.Resources.microsoftsqlserver
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.GroupBox2.Size = New System.Drawing.Size(805, 354)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Task Monitor"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(441, 60)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(143, 28)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdStopMonitoring
        '
        Me.cmdStopMonitoring.Location = New System.Drawing.Point(633, 13)
        Me.cmdStopMonitoring.Name = "cmdStopMonitoring"
        Me.cmdStopMonitoring.Size = New System.Drawing.Size(166, 75)
        Me.cmdStopMonitoring.TabIndex = 4
        Me.cmdStopMonitoring.Text = "Stop"
        Me.cmdStopMonitoring.UseVisualStyleBackColor = True
        '
        'cmdStartMonitoring
        '
        Me.cmdStartMonitoring.Location = New System.Drawing.Point(441, 13)
        Me.cmdStartMonitoring.Name = "cmdStartMonitoring"
        Me.cmdStartMonitoring.Size = New System.Drawing.Size(143, 41)
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
        Me.cmbListDB.Size = New System.Drawing.Size(337, 26)
        Me.cmbListDB.TabIndex = 1
        '
        'dgDaftarTugas
        '
        Me.dgDaftarTugas.AllowUserToAddRows = False
        Me.dgDaftarTugas.AllowUserToDeleteRows = False
        Me.dgDaftarTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarTugas.Location = New System.Drawing.Point(4, 98)
        Me.dgDaftarTugas.Name = "dgDaftarTugas"
        Me.dgDaftarTugas.Size = New System.Drawing.Size(795, 250)
        Me.dgDaftarTugas.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 607)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(825, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.cmdKillSession)
        Me.GroupBox3.Controls.Add(Me.cmdSessionTrace)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmdConnectionMonitor)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(805, 95)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Feature"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(315, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 51)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Fragmentation Status"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmdKillSession
        '
        Me.cmdKillSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKillSession.Location = New System.Drawing.Point(713, 30)
        Me.cmdKillSession.Name = "cmdKillSession"
        Me.cmdKillSession.Size = New System.Drawing.Size(86, 51)
        Me.cmdKillSession.TabIndex = 4
        Me.cmdKillSession.Text = "Kill Session"
        Me.cmdKillSession.UseVisualStyleBackColor = True
        '
        'cmdSessionTrace
        '
        Me.cmdSessionTrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSessionTrace.Location = New System.Drawing.Point(482, 30)
        Me.cmdSessionTrace.Name = "cmdSessionTrace"
        Me.cmdSessionTrace.Size = New System.Drawing.Size(88, 51)
        Me.cmdSessionTrace.TabIndex = 3
        Me.cmdSessionTrace.Text = "Session Trace"
        Me.cmdSessionTrace.UseVisualStyleBackColor = True
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
        'txtBebanLoad
        '
        Me.txtBebanLoad.AutoSize = True
        Me.txtBebanLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBebanLoad.Location = New System.Drawing.Point(759, 609)
        Me.txtBebanLoad.Name = "txtBebanLoad"
        Me.txtBebanLoad.Size = New System.Drawing.Size(54, 20)
        Me.txtBebanLoad.TabIndex = 4
        Me.txtBebanLoad.Text = "Load "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 610)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Work Load :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Build 05042020"
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 629)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBebanLoad)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Monitoring"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDaftarTugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents txtBebanLoad As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
