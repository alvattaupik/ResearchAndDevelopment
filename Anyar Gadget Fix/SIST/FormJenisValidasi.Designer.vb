<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisValidasi
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
        Me.dgDaftarValidasi = New System.Windows.Forms.DataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtCariValidasi = New System.Windows.Forms.TextBox()
        CType(Me.dgDaftarValidasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDaftarValidasi
        '
        Me.dgDaftarValidasi.AllowUserToAddRows = False
        Me.dgDaftarValidasi.AllowUserToDeleteRows = False
        Me.dgDaftarValidasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarValidasi.Location = New System.Drawing.Point(1, 52)
        Me.dgDaftarValidasi.Name = "dgDaftarValidasi"
        Me.dgDaftarValidasi.ReadOnly = True
        Me.dgDaftarValidasi.Size = New System.Drawing.Size(452, 212)
        Me.dgDaftarValidasi.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(-2, 14)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(70, 15)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Cari Validasi"
        '
        'txtCariValidasi
        '
        Me.txtCariValidasi.Location = New System.Drawing.Point(95, 12)
        Me.txtCariValidasi.Name = "txtCariValidasi"
        Me.txtCariValidasi.Size = New System.Drawing.Size(349, 20)
        Me.txtCariValidasi.TabIndex = 2
        '
        'FormJenisValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 268)
        Me.Controls.Add(Me.txtCariValidasi)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.dgDaftarValidasi)
        Me.Name = "FormJenisValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJenisValidasi"
        CType(Me.dgDaftarValidasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDaftarValidasi As System.Windows.Forms.DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtCariValidasi As System.Windows.Forms.TextBox
End Class
