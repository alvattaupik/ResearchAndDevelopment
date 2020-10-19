<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprovalReqFullfillments
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
        Me.txtCariNoSurat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTampilkanSemua = New Guna.UI.WinForms.GunaCheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListSurat = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListSurat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCariNoSurat
        '
        Me.txtCariNoSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariNoSurat.Location = New System.Drawing.Point(128, 15)
        Me.txtCariNoSurat.Name = "txtCariNoSurat"
        Me.txtCariNoSurat.Size = New System.Drawing.Size(515, 29)
        Me.txtCariNoSurat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari No Surat"
        '
        'chkTampilkanSemua
        '
        Me.chkTampilkanSemua.BaseColor = System.Drawing.Color.White
        Me.chkTampilkanSemua.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkTampilkanSemua.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkTampilkanSemua.FillColor = System.Drawing.Color.White
        Me.chkTampilkanSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTampilkanSemua.Location = New System.Drawing.Point(128, 50)
        Me.chkTampilkanSemua.Name = "chkTampilkanSemua"
        Me.chkTampilkanSemua.Size = New System.Drawing.Size(160, 21)
        Me.chkTampilkanSemua.TabIndex = 2
        Me.chkTampilkanSemua.Text = "Tampilkan Semua"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTampilkanSemua)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCariNoSurat)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 84)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListSurat)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 232)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'dgvListSurat
        '
        Me.dgvListSurat.AllowUserToAddRows = False
        Me.dgvListSurat.AllowUserToDeleteRows = False
        Me.dgvListSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSurat.Location = New System.Drawing.Point(6, 19)
        Me.dgvListSurat.Name = "dgvListSurat"
        Me.dgvListSurat.ReadOnly = True
        Me.dgvListSurat.RowHeadersVisible = False
        Me.dgvListSurat.Size = New System.Drawing.Size(491, 207)
        Me.dgvListSurat.TabIndex = 0
        '
        'btnApprove
        '
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(521, 278)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(139, 98)
        Me.btnApprove.TabIndex = 5
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnLihat
        '
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Location = New System.Drawing.Point(521, 151)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(139, 98)
        Me.btnLihat.TabIndex = 6
        Me.btnLihat.Text = "Lihat"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "APPROVAL REQUEST"
        '
        'frmAprovalReqFullfillments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 376)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLihat)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAprovalReqFullfillments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAprovalReqFullfillments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListSurat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCariNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTampilkanSemua As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListSurat As System.Windows.Forms.DataGridView
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents btnLihat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
