<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseNoSisterRequestFullfill
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
        Me.dgvListNomorSurat = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnLihat = New System.Windows.Forms.Button()
        CType(Me.dgvListNomorSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListNomorSurat
        '
        Me.dgvListNomorSurat.AllowUserToAddRows = False
        Me.dgvListNomorSurat.AllowUserToDeleteRows = False
        Me.dgvListNomorSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListNomorSurat.Location = New System.Drawing.Point(13, 58)
        Me.dgvListNomorSurat.Name = "dgvListNomorSurat"
        Me.dgvListNomorSurat.ReadOnly = True
        Me.dgvListNomorSurat.RowHeadersVisible = False
        Me.dgvListNomorSurat.Size = New System.Drawing.Size(461, 242)
        Me.dgvListNomorSurat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nomor Surat"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(146, 19)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(328, 31)
        Me.txtCari.TabIndex = 2
        '
        'btnLihat
        '
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Location = New System.Drawing.Point(369, 306)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(105, 37)
        Me.btnLihat.TabIndex = 3
        Me.btnLihat.Text = "Lihat"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'frmBrowseNoSisterRequestFullfill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 348)
        Me.Controls.Add(Me.btnLihat)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvListNomorSurat)
        Me.Name = "frmBrowseNoSisterRequestFullfill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse Nomor Request"
        CType(Me.dgvListNomorSurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListNomorSurat As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnLihat As System.Windows.Forms.Button
End Class
