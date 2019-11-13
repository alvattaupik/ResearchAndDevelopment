<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Testing
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
        Me.OutlookGrid1 = New OutlookStyleControls.OutlookGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        'Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.OutlookGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutlookGrid1
        '
        Me.OutlookGrid1.CollapseIcon = Global.RKM_BI.My.Resources.Resources.shop
        Me.OutlookGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OutlookGrid1.ExpandIcon = Nothing
        Me.OutlookGrid1.Location = New System.Drawing.Point(12, 12)
        Me.OutlookGrid1.Name = "OutlookGrid1"
        Me.OutlookGrid1.Size = New System.Drawing.Size(606, 218)
        Me.OutlookGrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        'Me.DataGrid1.DataMember = ""
        ' Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        ' Me.DataGrid1.Location = New System.Drawing.Point(111, 236)
        ' Me.DataGrid1.Name = "DataGrid1"
        ' Me.DataGrid1.Size = New System.Drawing.Size(507, 177)
        ' Me.DataGrid1.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Testing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 425)
        Me.Controls.Add(Me.Button3)
        'Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OutlookGrid1)
        Me.Name = "Testing"
        Me.Text = "Testing"
        CType(Me.OutlookGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutlookGrid1 As OutlookStyleControls.OutlookGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    'Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
