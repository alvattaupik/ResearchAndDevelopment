<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fraFilter = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKodeBarang2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeBarang1 = New System.Windows.Forms.TextBox()
        Me.rbTertentu = New System.Windows.Forms.RadioButton()
        Me.rbTampilSemua = New System.Windows.Forms.RadioButton()
        Me.cmbHargaJual = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblNamaKomputer = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.fraFilter.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblIP)
        Me.GroupBox1.Controls.Add(Me.lblNamaKomputer)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(475, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 479)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Harga"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(73, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 36)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Export Ke NotePad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fraFilter)
        Me.GroupBox2.Controls.Add(Me.rbTertentu)
        Me.GroupBox2.Controls.Add(Me.rbTampilSemua)
        Me.GroupBox2.Controls.Add(Me.cmbHargaJual)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 215)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Harga Jual"
        '
        'fraFilter
        '
        Me.fraFilter.Controls.Add(Me.Label4)
        Me.fraFilter.Controls.Add(Me.Label5)
        Me.fraFilter.Controls.Add(Me.txtKodeBarang2)
        Me.fraFilter.Controls.Add(Me.Label3)
        Me.fraFilter.Controls.Add(Me.txtKodeBarang1)
        Me.fraFilter.Location = New System.Drawing.Point(10, 117)
        Me.fraFilter.Name = "fraFilter"
        Me.fraFilter.Size = New System.Drawing.Size(331, 92)
        Me.fraFilter.TabIndex = 7
        Me.fraFilter.TabStop = False
        Me.fraFilter.Text = "Filter"
        Me.fraFilter.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kode Barang 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kode Barang 2 :"
        '
        'txtKodeBarang2
        '
        Me.txtKodeBarang2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeBarang2.Location = New System.Drawing.Point(138, 62)
        Me.txtKodeBarang2.Name = "txtKodeBarang2"
        Me.txtKodeBarang2.Size = New System.Drawing.Size(150, 24)
        Me.txtKodeBarang2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "S/D"
        '
        'txtKodeBarang1
        '
        Me.txtKodeBarang1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeBarang1.Location = New System.Drawing.Point(138, 17)
        Me.txtKodeBarang1.Name = "txtKodeBarang1"
        Me.txtKodeBarang1.Size = New System.Drawing.Size(150, 24)
        Me.txtKodeBarang1.TabIndex = 4
        '
        'rbTertentu
        '
        Me.rbTertentu.AutoSize = True
        Me.rbTertentu.Location = New System.Drawing.Point(10, 89)
        Me.rbTertentu.Name = "rbTertentu"
        Me.rbTertentu.Size = New System.Drawing.Size(207, 22)
        Me.rbTertentu.TabIndex = 2
        Me.rbTertentu.TabStop = True
        Me.rbTertentu.Text = "Tampilkan Item Tertentu"
        Me.rbTertentu.UseVisualStyleBackColor = True
        '
        'rbTampilSemua
        '
        Me.rbTampilSemua.AutoSize = True
        Me.rbTampilSemua.Location = New System.Drawing.Point(9, 61)
        Me.rbTampilSemua.Name = "rbTampilSemua"
        Me.rbTampilSemua.Size = New System.Drawing.Size(197, 22)
        Me.rbTampilSemua.TabIndex = 1
        Me.rbTampilSemua.TabStop = True
        Me.rbTampilSemua.Text = "Tampilkan Semua Item"
        Me.rbTampilSemua.UseVisualStyleBackColor = True
        '
        'cmbHargaJual
        '
        Me.cmbHargaJual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHargaJual.FormattingEnabled = True
        Me.cmbHargaJual.Location = New System.Drawing.Point(6, 29)
        Me.cmbHargaJual.Name = "cmbHargaJual"
        Me.cmbHargaJual.Size = New System.Drawing.Size(234, 26)
        Me.cmbHargaJual.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your IP                :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computer Name    :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(457, 453)
        Me.DataGridView1.TabIndex = 3
        '
        'lblNamaKomputer
        '
        Me.lblNamaKomputer.AutoSize = True
        Me.lblNamaKomputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKomputer.Location = New System.Drawing.Point(131, 39)
        Me.lblNamaKomputer.Name = "lblNamaKomputer"
        Me.lblNamaKomputer.Size = New System.Drawing.Size(11, 13)
        Me.lblNamaKomputer.TabIndex = 6
        Me.lblNamaKomputer.Text = "-"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(131, 81)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(11, 13)
        Me.lblIP.TabIndex = 7
        Me.lblIP.Text = "-"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 503)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Harga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.fraFilter.ResumeLayout(False)
        Me.fraFilter.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fraFilter As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang1 As System.Windows.Forms.TextBox
    Friend WithEvents rbTertentu As System.Windows.Forms.RadioButton
    Friend WithEvents rbTampilSemua As System.Windows.Forms.RadioButton
    Friend WithEvents cmbHargaJual As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblNamaKomputer As System.Windows.Forms.Label
End Class
