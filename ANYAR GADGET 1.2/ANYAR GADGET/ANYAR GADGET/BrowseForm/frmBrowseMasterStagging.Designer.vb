<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseMasterStagging
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariEmployee = New System.Windows.Forms.TextBox()
        Me.dgvListEmployee = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Employee"
        '
        'txtCariEmployee
        '
        Me.txtCariEmployee.Location = New System.Drawing.Point(112, 13)
        Me.txtCariEmployee.Name = "txtCariEmployee"
        Me.txtCariEmployee.Size = New System.Drawing.Size(279, 20)
        Me.txtCariEmployee.TabIndex = 1
        '
        'dgvListEmployee
        '
        Me.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListEmployee.Location = New System.Drawing.Point(13, 49)
        Me.dgvListEmployee.Name = "dgvListEmployee"
        Me.dgvListEmployee.Size = New System.Drawing.Size(378, 190)
        Me.dgvListEmployee.TabIndex = 2
        '
        'frmBrowseMasterStagging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 247)
        Me.Controls.Add(Me.dgvListEmployee)
        Me.Controls.Add(Me.txtCariEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBrowseMasterStagging"
        Me.Text = "frmBrowseMasterStagging"
        CType(Me.dgvListEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariEmployee As System.Windows.Forms.TextBox
    Friend WithEvents dgvListEmployee As System.Windows.Forms.DataGridView
End Class
