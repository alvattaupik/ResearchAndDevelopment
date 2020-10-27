<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprovalPeminjamanAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAprovalPeminjamanAsset))
        Me.txtCariNoSurat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnLihat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListBelumDiproses = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCancelAssetBelumKembali = New System.Windows.Forms.Button()
        Me.btnApproveAssetBelumKembali = New System.Windows.Forms.Button()
        Me.btnLihatAssetBelumKembali = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvBelumKembali = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCariBelumKembali = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSudahKembali = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvListSudahKembali = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCariSuratSudahKembali = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListBelumDiproses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvBelumKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvListSudahKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCariNoSurat
        '
        Me.txtCariNoSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariNoSurat.Location = New System.Drawing.Point(128, 15)
        Me.txtCariNoSurat.Name = "txtCariNoSurat"
        Me.txtCariNoSurat.Size = New System.Drawing.Size(494, 29)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCariNoSurat)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 62)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnApprove
        '
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(496, 313)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(139, 55)
        Me.btnApprove.TabIndex = 5
        Me.btnApprove.Text = "Setujui"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnLihat
        '
        Me.btnLihat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihat.Location = New System.Drawing.Point(496, 101)
        Me.btnLihat.Name = "btnLihat"
        Me.btnLihat.Size = New System.Drawing.Size(139, 54)
        Me.btnLihat.TabIndex = 6
        Me.btnLihat.Text = "Lihat"
        Me.btnLihat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "APPROVAL PEMINJAMAN ASSET"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(496, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 55)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 406)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnApprove)
        Me.TabPage1.Controls.Add(Me.btnLihat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(654, 380)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Belum Di Proses"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListBelumDiproses)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(483, 281)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'dgvListBelumDiproses
        '
        Me.dgvListBelumDiproses.AllowUserToAddRows = False
        Me.dgvListBelumDiproses.AllowUserToDeleteRows = False
        Me.dgvListBelumDiproses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListBelumDiproses.Location = New System.Drawing.Point(7, 20)
        Me.dgvListBelumDiproses.Name = "dgvListBelumDiproses"
        Me.dgvListBelumDiproses.ReadOnly = True
        Me.dgvListBelumDiproses.RowHeadersVisible = False
        Me.dgvListBelumDiproses.Size = New System.Drawing.Size(470, 255)
        Me.dgvListBelumDiproses.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCancelAssetBelumKembali)
        Me.TabPage2.Controls.Add(Me.btnApproveAssetBelumKembali)
        Me.TabPage2.Controls.Add(Me.btnLihatAssetBelumKembali)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(654, 380)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Belum Kembali"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCancelAssetBelumKembali
        '
        Me.btnCancelAssetBelumKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAssetBelumKembali.Location = New System.Drawing.Point(495, 144)
        Me.btnCancelAssetBelumKembali.Name = "btnCancelAssetBelumKembali"
        Me.btnCancelAssetBelumKembali.Size = New System.Drawing.Size(139, 55)
        Me.btnCancelAssetBelumKembali.TabIndex = 13
        Me.btnCancelAssetBelumKembali.Text = "Cancel"
        Me.btnCancelAssetBelumKembali.UseVisualStyleBackColor = True
        '
        'btnApproveAssetBelumKembali
        '
        Me.btnApproveAssetBelumKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveAssetBelumKembali.Location = New System.Drawing.Point(495, 296)
        Me.btnApproveAssetBelumKembali.Name = "btnApproveAssetBelumKembali"
        Me.btnApproveAssetBelumKembali.Size = New System.Drawing.Size(139, 55)
        Me.btnApproveAssetBelumKembali.TabIndex = 11
        Me.btnApproveAssetBelumKembali.Text = "Pengembalian"
        Me.btnApproveAssetBelumKembali.UseVisualStyleBackColor = True
        '
        'btnLihatAssetBelumKembali
        '
        Me.btnLihatAssetBelumKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatAssetBelumKembali.Location = New System.Drawing.Point(495, 78)
        Me.btnLihatAssetBelumKembali.Name = "btnLihatAssetBelumKembali"
        Me.btnLihatAssetBelumKembali.Size = New System.Drawing.Size(139, 54)
        Me.btnLihatAssetBelumKembali.TabIndex = 12
        Me.btnLihatAssetBelumKembali.Text = "Lihat"
        Me.btnLihatAssetBelumKembali.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvBelumKembali)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(483, 281)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'dgvBelumKembali
        '
        Me.dgvBelumKembali.AllowUserToAddRows = False
        Me.dgvBelumKembali.AllowUserToDeleteRows = False
        Me.dgvBelumKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBelumKembali.Location = New System.Drawing.Point(7, 20)
        Me.dgvBelumKembali.Name = "dgvBelumKembali"
        Me.dgvBelumKembali.ReadOnly = True
        Me.dgvBelumKembali.RowHeadersVisible = False
        Me.dgvBelumKembali.Size = New System.Drawing.Size(470, 255)
        Me.dgvBelumKembali.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCariBelumKembali)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(628, 62)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cari No Surat"
        '
        'txtCariBelumKembali
        '
        Me.txtCariBelumKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariBelumKembali.Location = New System.Drawing.Point(128, 15)
        Me.txtCariBelumKembali.Name = "txtCariBelumKembali"
        Me.txtCariBelumKembali.Size = New System.Drawing.Size(494, 29)
        Me.txtCariBelumKembali.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnSudahKembali)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(654, 380)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sudah Kembali"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSudahKembali
        '
        Me.btnSudahKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSudahKembali.Location = New System.Drawing.Point(495, 84)
        Me.btnSudahKembali.Name = "btnSudahKembali"
        Me.btnSudahKembali.Size = New System.Drawing.Size(139, 54)
        Me.btnSudahKembali.TabIndex = 16
        Me.btnSudahKembali.Text = "Lihat"
        Me.btnSudahKembali.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvListSudahKembali)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 74)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(483, 281)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        '
        'dgvListSudahKembali
        '
        Me.dgvListSudahKembali.AllowUserToAddRows = False
        Me.dgvListSudahKembali.AllowUserToDeleteRows = False
        Me.dgvListSudahKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListSudahKembali.Location = New System.Drawing.Point(7, 20)
        Me.dgvListSudahKembali.Name = "dgvListSudahKembali"
        Me.dgvListSudahKembali.ReadOnly = True
        Me.dgvListSudahKembali.RowHeadersVisible = False
        Me.dgvListSudahKembali.Size = New System.Drawing.Size(470, 255)
        Me.dgvListSudahKembali.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtCariSuratSudahKembali)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(628, 62)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cari No Surat"
        '
        'txtCariSuratSudahKembali
        '
        Me.txtCariSuratSudahKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariSuratSudahKembali.Location = New System.Drawing.Point(128, 15)
        Me.txtCariSuratSudahKembali.Name = "txtCariSuratSudahKembali"
        Me.txtCariSuratSudahKembali.Size = New System.Drawing.Size(494, 29)
        Me.txtCariSuratSudahKembali.TabIndex = 0
        '
        'frmAprovalPeminjamanAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 473)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAprovalPeminjamanAsset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Peminjaman Asset"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListBelumDiproses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvBelumKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvListSudahKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCariNoSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents btnLihat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListBelumDiproses As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancelAssetBelumKembali As System.Windows.Forms.Button
    Friend WithEvents btnApproveAssetBelumKembali As System.Windows.Forms.Button
    Friend WithEvents btnLihatAssetBelumKembali As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBelumKembali As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCariBelumKembali As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnSudahKembali As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListSudahKembali As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCariSuratSudahKembali As System.Windows.Forms.TextBox
End Class
