<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLihatListItemCode
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
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.dgvCaribarang = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCaribarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari barang"
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Location = New System.Drawing.Point(71, 9)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(352, 20)
        Me.txtCariBarang.TabIndex = 1
        '
        'dgvCaribarang
        '
        Me.dgvCaribarang.AllowUserToAddRows = False
        Me.dgvCaribarang.AllowUserToDeleteRows = False
        Me.dgvCaribarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaribarang.Location = New System.Drawing.Point(7, 35)
        Me.dgvCaribarang.Name = "dgvCaribarang"
        Me.dgvCaribarang.ReadOnly = True
        Me.dgvCaribarang.RowHeadersVisible = False
        Me.dgvCaribarang.Size = New System.Drawing.Size(417, 297)
        Me.dgvCaribarang.TabIndex = 2
        '
        'frmLihatListItemCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 336)
        Me.Controls.Add(Me.dgvCaribarang)
        Me.Controls.Add(Me.txtCariBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLihatListItemCode"
        Me.Text = "Cari Item Code"
        CType(Me.dgvCaribarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents dgvCaribarang As System.Windows.Forms.DataGridView
End Class
