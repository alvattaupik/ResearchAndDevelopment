<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPesanWa
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKodeStatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPembukaan = New System.Windows.Forms.RichTextBox()
        Me.txtPenutup = New System.Windows.Forms.RichTextBox()
        Me.txtIsi = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFungsi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvMasterStatusWa = New System.Windows.Forms.DataGridView()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMasterStatusWa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKodeStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtKodeStatus
        '
        Me.txtKodeStatus.Location = New System.Drawing.Point(6, 19)
        Me.txtKodeStatus.Name = "txtKodeStatus"
        Me.txtKodeStatus.ReadOnly = True
        Me.txtKodeStatus.Size = New System.Drawing.Size(59, 20)
        Me.txtKodeStatus.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Master Status Whatsapp"
        '
        'txtPembukaan
        '
        Me.txtPembukaan.Location = New System.Drawing.Point(7, 105)
        Me.txtPembukaan.Name = "txtPembukaan"
        Me.txtPembukaan.Size = New System.Drawing.Size(248, 42)
        Me.txtPembukaan.TabIndex = 2
        Me.txtPembukaan.Text = ""
        '
        'txtPenutup
        '
        Me.txtPenutup.Location = New System.Drawing.Point(7, 242)
        Me.txtPenutup.Name = "txtPenutup"
        Me.txtPenutup.Size = New System.Drawing.Size(248, 59)
        Me.txtPenutup.TabIndex = 3
        Me.txtPenutup.Text = ""
        '
        'txtIsi
        '
        Me.txtIsi.Location = New System.Drawing.Point(7, 166)
        Me.txtIsi.Name = "txtIsi"
        Me.txtIsi.Size = New System.Drawing.Size(248, 57)
        Me.txtIsi.TabIndex = 4
        Me.txtIsi.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kalimat Pembuka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Isi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kalimat Penutup"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fungsi"
        '
        'txtFungsi
        '
        Me.txtFungsi.Location = New System.Drawing.Point(52, 65)
        Me.txtFungsi.Name = "txtFungsi"
        Me.txtFungsi.ReadOnly = True
        Me.txtFungsi.Size = New System.Drawing.Size(203, 20)
        Me.txtFungsi.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dgvMasterStatusWa)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 240)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(37, 13)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(283, 20)
        Me.txtCari.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cari"
        '
        'dgvMasterStatusWa
        '
        Me.dgvMasterStatusWa.AllowUserToAddRows = False
        Me.dgvMasterStatusWa.AllowUserToDeleteRows = False
        Me.dgvMasterStatusWa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterStatusWa.Location = New System.Drawing.Point(7, 44)
        Me.dgvMasterStatusWa.Name = "dgvMasterStatusWa"
        Me.dgvMasterStatusWa.ReadOnly = True
        Me.dgvMasterStatusWa.RowHeadersVisible = False
        Me.dgvMasterStatusWa.Size = New System.Drawing.Size(313, 190)
        Me.dgvMasterStatusWa.TabIndex = 0
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(7, 312)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(580, 41)
        Me.cmdUpdate.TabIndex = 11
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'MasterPesanWa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 361)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtFungsi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIsi)
        Me.Controls.Add(Me.txtPenutup)
        Me.Controls.Add(Me.txtPembukaan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MasterPesanWa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterPesanWa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMasterStatusWa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPembukaan As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPenutup As System.Windows.Forms.RichTextBox
    Friend WithEvents txtIsi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFungsi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvMasterStatusWa As System.Windows.Forms.DataGridView
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtKodeStatus As System.Windows.Forms.TextBox
End Class
