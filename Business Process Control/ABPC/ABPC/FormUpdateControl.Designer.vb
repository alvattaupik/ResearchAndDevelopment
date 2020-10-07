<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateControlValidasi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.txtCabang = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJenisvalidasi = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDocNum)
        Me.Panel1.Location = New System.Drawing.Point(2, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 41)
        Me.Panel1.TabIndex = 0
        '
        'txtDocNum
        '
        Me.txtDocNum.Location = New System.Drawing.Point(4, 12)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.Size = New System.Drawing.Size(155, 20)
        Me.txtDocNum.TabIndex = 1
        Me.txtDocNum.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Control"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lokasi Kontrol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Notifikasi"
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(2, 124)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.ReadOnly = True
        Me.txtNotifikasi.Size = New System.Drawing.Size(274, 88)
        Me.txtNotifikasi.TabIndex = 9
        Me.txtNotifikasi.Text = ""
        '
        'txtCabang
        '
        Me.txtCabang.Enabled = False
        Me.txtCabang.Location = New System.Drawing.Point(83, 218)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.ReadOnly = True
        Me.txtCabang.Size = New System.Drawing.Size(197, 20)
        Me.txtCabang.TabIndex = 12
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.Lime
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(6, 244)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(274, 52)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "Tutup Validasi"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Jenis Validasi"
        '
        'txtJenisvalidasi
        '
        Me.txtJenisvalidasi.Enabled = False
        Me.txtJenisvalidasi.Location = New System.Drawing.Point(79, 72)
        Me.txtJenisvalidasi.Name = "txtJenisvalidasi"
        Me.txtJenisvalidasi.ReadOnly = True
        Me.txtJenisvalidasi.Size = New System.Drawing.Size(197, 20)
        Me.txtJenisvalidasi.TabIndex = 15
        '
        'FormUpdateControlValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 297)
        Me.Controls.Add(Me.txtJenisvalidasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtCabang)
        Me.Controls.Add(Me.txtNotifikasi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUpdateControlValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateControl"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtCabang As System.Windows.Forms.TextBox
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJenisvalidasi As System.Windows.Forms.TextBox
End Class
