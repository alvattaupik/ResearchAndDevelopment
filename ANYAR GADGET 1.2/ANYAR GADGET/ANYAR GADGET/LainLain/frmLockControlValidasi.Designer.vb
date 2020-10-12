<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockControlValidasi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.txtJenisvalidasi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtCabang = New System.Windows.Forms.TextBox()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCatatan = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 41)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lock Control"
        '
        'txtDocNum
        '
        Me.txtDocNum.Enabled = False
        Me.txtDocNum.Location = New System.Drawing.Point(87, 56)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.ReadOnly = True
        Me.txtDocNum.Size = New System.Drawing.Size(197, 20)
        Me.txtDocNum.TabIndex = 1
        '
        'txtJenisvalidasi
        '
        Me.txtJenisvalidasi.Enabled = False
        Me.txtJenisvalidasi.Location = New System.Drawing.Point(87, 82)
        Me.txtJenisvalidasi.Name = "txtJenisvalidasi"
        Me.txtJenisvalidasi.ReadOnly = True
        Me.txtJenisvalidasi.Size = New System.Drawing.Size(197, 20)
        Me.txtJenisvalidasi.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nama Validasi"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.Lime
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(5, 294)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(279, 52)
        Me.cmdUpdate.TabIndex = 21
        Me.cmdUpdate.Text = "Tutup Validasi"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'txtCabang
        '
        Me.txtCabang.Enabled = False
        Me.txtCabang.Location = New System.Drawing.Point(91, 268)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.ReadOnly = True
        Me.txtCabang.Size = New System.Drawing.Size(193, 20)
        Me.txtCabang.TabIndex = 20
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(10, 125)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.ReadOnly = True
        Me.txtNotifikasi.Size = New System.Drawing.Size(274, 49)
        Me.txtNotifikasi.TabIndex = 19
        Me.txtNotifikasi.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Notifikasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Lokasi Kontrol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Catatan"
        '
        'txtCatatan
        '
        Me.txtCatatan.Location = New System.Drawing.Point(10, 193)
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ReadOnly = True
        Me.txtCatatan.Size = New System.Drawing.Size(274, 39)
        Me.txtCatatan.TabIndex = 25
        Me.txtCatatan.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Ref"
        '
        'txtRef
        '
        Me.txtRef.Enabled = False
        Me.txtRef.Location = New System.Drawing.Point(91, 235)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.ReadOnly = True
        Me.txtRef.Size = New System.Drawing.Size(193, 20)
        Me.txtRef.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Code"
        '
        'frmLockControlValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 346)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.txtDocNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCatatan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtJenisvalidasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtCabang)
        Me.Controls.Add(Me.txtNotifikasi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmLockControlValidasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock Control"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisvalidasi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtCabang As System.Windows.Forms.TextBox
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCatatan As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
