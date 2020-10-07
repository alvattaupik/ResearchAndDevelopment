<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseListUserAplikasi
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
        Me.dgvListUserAplikasi = New System.Windows.Forms.DataGridView()
        Me.btnProses = New System.Windows.Forms.Button()
        CType(Me.dgvListUserAplikasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListUserAplikasi
        '
        Me.dgvListUserAplikasi.AllowUserToAddRows = False
        Me.dgvListUserAplikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListUserAplikasi.Location = New System.Drawing.Point(3, 1)
        Me.dgvListUserAplikasi.Name = "dgvListUserAplikasi"
        Me.dgvListUserAplikasi.RowHeadersVisible = False
        Me.dgvListUserAplikasi.Size = New System.Drawing.Size(325, 179)
        Me.dgvListUserAplikasi.TabIndex = 16
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(3, 186)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(325, 33)
        Me.btnProses.TabIndex = 17
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'frmBrowseListUserAplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 221)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.dgvListUserAplikasi)
        Me.Name = "frmBrowseListUserAplikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBrowseListUserAplikasi"
        CType(Me.dgvListUserAplikasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListUserAplikasi As System.Windows.Forms.DataGridView
    Friend WithEvents btnProses As System.Windows.Forms.Button
End Class
