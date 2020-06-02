<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusMaintenanceDanBackup
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpBackup2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpBackup1 = New System.Windows.Forms.DateTimePicker()
        Me.dgStatusbackup = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpTask2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpTask1 = New System.Windows.Forms.DateTimePicker()
        Me.dgStatusTaskPlan = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgStatusbackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgStatusTaskPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SQLServerMonitoringTools.My.Resources.Resources._22_512
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monitoring Tools 1.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SQL SERVER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(464, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Backup Plan And Task Plan Monitoring"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SQLServerMonitoringTools.My.Resources.Resources.microsoftsqlserver
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(677, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(122, 113)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.dgStatusbackup)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(13, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 318)
        Me.Panel1.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.dtpBackup2)
        Me.Panel3.Controls.Add(Me.dtpBackup1)
        Me.Panel3.Location = New System.Drawing.Point(7, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(378, 43)
        Me.Panel3.TabIndex = 2
        Me.Panel3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Periode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "S/D"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpBackup2
        '
        Me.dtpBackup2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBackup2.Location = New System.Drawing.Point(200, 11)
        Me.dtpBackup2.Name = "dtpBackup2"
        Me.dtpBackup2.Size = New System.Drawing.Size(113, 20)
        Me.dtpBackup2.TabIndex = 1
        '
        'dtpBackup1
        '
        Me.dtpBackup1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBackup1.Location = New System.Drawing.Point(55, 11)
        Me.dtpBackup1.Name = "dtpBackup1"
        Me.dtpBackup1.Size = New System.Drawing.Size(113, 20)
        Me.dtpBackup1.TabIndex = 0
        '
        'dgStatusbackup
        '
        Me.dgStatusbackup.AllowUserToAddRows = False
        Me.dgStatusbackup.AllowUserToDeleteRows = False
        Me.dgStatusbackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStatusbackup.Location = New System.Drawing.Point(7, 86)
        Me.dgStatusbackup.Name = "dgStatusbackup"
        Me.dgStatusbackup.ReadOnly = True
        Me.dgStatusbackup.Size = New System.Drawing.Size(379, 219)
        Me.dgStatusbackup.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "BACKUP STATUS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgStatusTaskPlan)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(417, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(398, 318)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.dtpTask2)
        Me.Panel4.Controls.Add(Me.dtpTask1)
        Me.Panel4.Location = New System.Drawing.Point(7, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(378, 43)
        Me.Panel4.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Periode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "S/D"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpTask2
        '
        Me.dtpTask2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTask2.Location = New System.Drawing.Point(200, 11)
        Me.dtpTask2.Name = "dtpTask2"
        Me.dtpTask2.Size = New System.Drawing.Size(113, 20)
        Me.dtpTask2.TabIndex = 1
        '
        'dtpTask1
        '
        Me.dtpTask1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTask1.Location = New System.Drawing.Point(55, 11)
        Me.dtpTask1.Name = "dtpTask1"
        Me.dtpTask1.Size = New System.Drawing.Size(113, 20)
        Me.dtpTask1.TabIndex = 0
        '
        'dgStatusTaskPlan
        '
        Me.dgStatusTaskPlan.AllowUserToAddRows = False
        Me.dgStatusTaskPlan.AllowUserToDeleteRows = False
        Me.dgStatusTaskPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStatusTaskPlan.Location = New System.Drawing.Point(7, 86)
        Me.dgStatusTaskPlan.Name = "dgStatusTaskPlan"
        Me.dgStatusTaskPlan.Size = New System.Drawing.Size(379, 219)
        Me.dgStatusTaskPlan.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TASK PLAN STATUS"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 485)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Location = New System.Drawing.Point(9, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(794, 13)
        Me.Panel5.TabIndex = 10
        '
        'FormStatusMaintenanceDanBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 485)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormStatusMaintenanceDanBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormStatusMaintenanceDanBackup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgStatusbackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgStatusTaskPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpBackup2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBackup1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgStatusbackup As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtpTask2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTask1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgStatusTaskPlan As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
