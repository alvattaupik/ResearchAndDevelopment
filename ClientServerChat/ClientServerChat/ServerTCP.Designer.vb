<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerTCP
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdShowClient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 14)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(517, 200)
        Me.TextBox1.TabIndex = 0
        '
        'cmdShowClient
        '
        Me.cmdShowClient.Location = New System.Drawing.Point(456, 223)
        Me.cmdShowClient.Name = "cmdShowClient"
        Me.cmdShowClient.Size = New System.Drawing.Size(75, 23)
        Me.cmdShowClient.TabIndex = 1
        Me.cmdShowClient.Text = "Show Client"
        Me.cmdShowClient.UseVisualStyleBackColor = True
        '
        'ServerTCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 258)
        Me.Controls.Add(Me.cmdShowClient)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ServerTCP"
        Me.Text = "ServerTCP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdShowClient As System.Windows.Forms.Button
End Class
