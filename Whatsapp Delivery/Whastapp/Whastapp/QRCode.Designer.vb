<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCode
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
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.tmrRefreshQRCode = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picQRCode
        '
        Me.picQRCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picQRCode.Location = New System.Drawing.Point(0, 0)
        Me.picQRCode.Margin = New System.Windows.Forms.Padding(10)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(309, 295)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picQRCode.TabIndex = 1
        Me.picQRCode.TabStop = False
        '
        'tmrRefreshQRCode
        '
        Me.tmrRefreshQRCode.Enabled = True
        Me.tmrRefreshQRCode.Interval = 1000
        '
        'QRCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 295)
        Me.Controls.Add(Me.picQRCode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QRCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QRCode"
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picQRCode As System.Windows.Forms.PictureBox
    Private WithEvents tmrRefreshQRCode As System.Windows.Forms.Timer
End Class
