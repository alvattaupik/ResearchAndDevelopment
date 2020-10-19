<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogueApprovalReq
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
        Me.txtNomorSurat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStatusRequest = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.dgvListLampiran = New System.Windows.Forms.DataGridView()
        Me.btnLihatRequest = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Surat"
        '
        'txtNomorSurat
        '
        Me.txtNomorSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomorSurat.Location = New System.Drawing.Point(477, 12)
        Me.txtNomorSurat.Name = "txtNomorSurat"
        Me.txtNomorSurat.ReadOnly = True
        Me.txtNomorSurat.Size = New System.Drawing.Size(249, 26)
        Me.txtNomorSurat.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(385, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status"
        '
        'cmbStatusRequest
        '
        Me.cmbStatusRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatusRequest.FormattingEnabled = True
        Me.cmbStatusRequest.Items.AddRange(New Object() {"Approve", "Reject"})
        Me.cmbStatusRequest.Location = New System.Drawing.Point(477, 75)
        Me.cmbStatusRequest.Name = "cmbStatusRequest"
        Me.cmbStatusRequest.Size = New System.Drawing.Size(249, 28)
        Me.cmbStatusRequest.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(477, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(249, 26)
        Me.txtUsername.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(477, 142)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(249, 26)
        Me.txtPassword.TabIndex = 7
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(391, 244)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(343, 48)
        Me.btnProses.TabIndex = 8
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDownload)
        Me.GroupBox1.Controls.Add(Me.dgvListLampiran)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 302)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Lampiran"
        '
        'btnDownload
        '
        Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.Location = New System.Drawing.Point(11, 263)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(347, 33)
        Me.btnDownload.TabIndex = 1
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'dgvListLampiran
        '
        Me.dgvListLampiran.AllowUserToAddRows = False
        Me.dgvListLampiran.AllowUserToDeleteRows = False
        Me.dgvListLampiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListLampiran.Location = New System.Drawing.Point(10, 26)
        Me.dgvListLampiran.Name = "dgvListLampiran"
        Me.dgvListLampiran.ReadOnly = True
        Me.dgvListLampiran.RowHeadersVisible = False
        Me.dgvListLampiran.Size = New System.Drawing.Size(348, 230)
        Me.dgvListLampiran.TabIndex = 0
        '
        'btnLihatRequest
        '
        Me.btnLihatRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatRequest.Location = New System.Drawing.Point(391, 190)
        Me.btnLihatRequest.Name = "btnLihatRequest"
        Me.btnLihatRequest.Size = New System.Drawing.Size(343, 48)
        Me.btnLihatRequest.TabIndex = 10
        Me.btnLihatRequest.Text = "Lihat Request"
        Me.btnLihatRequest.UseVisualStyleBackColor = True
        '
        'frmDialogueApprovalReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 299)
        Me.Controls.Add(Me.btnLihatRequest)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbStatusRequest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomorSurat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDialogueApprovalReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogueApprovalReq"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListLampiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomorSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbStatusRequest As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents dgvListLampiran As System.Windows.Forms.DataGridView
    Friend WithEvents btnLihatRequest As System.Windows.Forms.Button
End Class
