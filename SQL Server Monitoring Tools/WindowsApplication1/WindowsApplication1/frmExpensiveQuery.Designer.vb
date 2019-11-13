<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpensiveQuery
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
        Me.dgTop50 = New System.Windows.Forms.DataGridView()
        Me.gbDetailQuery = New System.Windows.Forms.GroupBox()
        Me.txtDetailQuery = New System.Windows.Forms.TextBox()
        Me.cmdcopyclipboard = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTop50, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetailQuery.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOP 50 Expensive Query"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgTop50)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daftar 50 Query Dengan Penggunaan Sumberdaya Terbesar"
        '
        'dgTop50
        '
        Me.dgTop50.AllowUserToAddRows = False
        Me.dgTop50.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTop50.Location = New System.Drawing.Point(7, 21)
        Me.dgTop50.Name = "dgTop50"
        Me.dgTop50.Size = New System.Drawing.Size(532, 209)
        Me.dgTop50.TabIndex = 0
        '
        'gbDetailQuery
        '
        Me.gbDetailQuery.Controls.Add(Me.cmdClose)
        Me.gbDetailQuery.Controls.Add(Me.cmdcopyclipboard)
        Me.gbDetailQuery.Controls.Add(Me.txtDetailQuery)
        Me.gbDetailQuery.Location = New System.Drawing.Point(77, 1)
        Me.gbDetailQuery.Name = "gbDetailQuery"
        Me.gbDetailQuery.Size = New System.Drawing.Size(479, 337)
        Me.gbDetailQuery.TabIndex = 2
        Me.gbDetailQuery.TabStop = False
        Me.gbDetailQuery.Text = "QueryDetails"
        Me.gbDetailQuery.Visible = False
        '
        'txtDetailQuery
        '
        Me.txtDetailQuery.Location = New System.Drawing.Point(8, 20)
        Me.txtDetailQuery.Multiline = True
        Me.txtDetailQuery.Name = "txtDetailQuery"
        Me.txtDetailQuery.Size = New System.Drawing.Size(458, 280)
        Me.txtDetailQuery.TabIndex = 0
        '
        'cmdcopyclipboard
        '
        Me.cmdcopyclipboard.Location = New System.Drawing.Point(212, 306)
        Me.cmdcopyclipboard.Name = "cmdcopyclipboard"
        Me.cmdcopyclipboard.Size = New System.Drawing.Size(124, 20)
        Me.cmdcopyclipboard.TabIndex = 1
        Me.cmdcopyclipboard.Text = "Copy To Clipboard"
        Me.cmdcopyclipboard.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(347, 306)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(118, 19)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmExpensiveQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 343)
        Me.Controls.Add(Me.gbDetailQuery)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmExpensiveQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmExpensiveQuery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTop50, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetailQuery.ResumeLayout(False)
        Me.gbDetailQuery.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgTop50 As System.Windows.Forms.DataGridView
    Friend WithEvents gbDetailQuery As System.Windows.Forms.GroupBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdcopyclipboard As System.Windows.Forms.Button
    Friend WithEvents txtDetailQuery As System.Windows.Forms.TextBox
End Class
