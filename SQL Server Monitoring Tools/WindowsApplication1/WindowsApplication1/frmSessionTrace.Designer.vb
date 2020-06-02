<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSessionTrace
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgSessionTrace = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdSesi = New System.Windows.Forms.TextBox()
        Me.cmdFindSession = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdKillThisSession = New System.Windows.Forms.Button()
        Me.cmdcopyclipboard = New System.Windows.Forms.Button()
        Me.txtNamaProgram = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgSessionTrace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Session Trace"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgSessionTrace)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgSessionTrace
        '
        Me.dgSessionTrace.AllowUserToAddRows = False
        Me.dgSessionTrace.AllowUserToDeleteRows = False
        Me.dgSessionTrace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSessionTrace.Location = New System.Drawing.Point(8, 16)
        Me.dgSessionTrace.Name = "dgSessionTrace"
        Me.dgSessionTrace.ReadOnly = True
        Me.dgSessionTrace.Size = New System.Drawing.Size(355, 199)
        Me.dgSessionTrace.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Sesi"
        '
        'txtIdSesi
        '
        Me.txtIdSesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSesi.Location = New System.Drawing.Point(96, 41)
        Me.txtIdSesi.Multiline = True
        Me.txtIdSesi.Name = "txtIdSesi"
        Me.txtIdSesi.Size = New System.Drawing.Size(119, 32)
        Me.txtIdSesi.TabIndex = 3
        '
        'cmdFindSession
        '
        Me.cmdFindSession.Location = New System.Drawing.Point(221, 39)
        Me.cmdFindSession.Name = "cmdFindSession"
        Me.cmdFindSession.Size = New System.Drawing.Size(160, 35)
        Me.cmdFindSession.TabIndex = 4
        Me.cmdFindSession.Text = "Cari Sesi"
        Me.cmdFindSession.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdKillThisSession)
        Me.GroupBox3.Controls.Add(Me.cmdcopyclipboard)
        Me.GroupBox3.Controls.Add(Me.txtNamaProgram)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtQuery)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtStatus)
        Me.GroupBox3.Location = New System.Drawing.Point(387, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 334)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Session Detail"
        '
        'cmdKillThisSession
        '
        Me.cmdKillThisSession.Location = New System.Drawing.Point(260, 302)
        Me.cmdKillThisSession.Name = "cmdKillThisSession"
        Me.cmdKillThisSession.Size = New System.Drawing.Size(144, 31)
        Me.cmdKillThisSession.TabIndex = 7
        Me.cmdKillThisSession.Text = "Kill This Session"
        Me.cmdKillThisSession.UseVisualStyleBackColor = True
        '
        'cmdcopyclipboard
        '
        Me.cmdcopyclipboard.Location = New System.Drawing.Point(7, 302)
        Me.cmdcopyclipboard.Name = "cmdcopyclipboard"
        Me.cmdcopyclipboard.Size = New System.Drawing.Size(124, 32)
        Me.cmdcopyclipboard.TabIndex = 6
        Me.cmdcopyclipboard.Text = "Copy To Clipboard"
        Me.cmdcopyclipboard.UseVisualStyleBackColor = True
        '
        'txtNamaProgram
        '
        Me.txtNamaProgram.Enabled = False
        Me.txtNamaProgram.Location = New System.Drawing.Point(115, 52)
        Me.txtNamaProgram.Multiline = True
        Me.txtNamaProgram.Name = "txtNamaProgram"
        Me.txtNamaProgram.Size = New System.Drawing.Size(289, 23)
        Me.txtNamaProgram.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Program"
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(6, 99)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(398, 197)
        Me.txtQuery.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Query"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Enabled = False
        Me.txtStatus.Location = New System.Drawing.Point(115, 22)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(289, 23)
        Me.txtStatus.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(221, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Get Sleeping Session"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSessionTrace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 338)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdFindSession)
        Me.Controls.Add(Me.txtIdSesi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSessionTrace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSessionTrace"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgSessionTrace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSessionTrace As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdSesi As System.Windows.Forms.TextBox
    Friend WithEvents cmdFindSession As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaProgram As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdcopyclipboard As System.Windows.Forms.Button
    Friend WithEvents cmdKillThisSession As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
