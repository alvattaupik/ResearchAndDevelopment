<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterExportExcel
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
        Me.dtpBulanan = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCabang = New System.Windows.Forms.ComboBox()
        Me.ChkCabang = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTemplate1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtTemplate2 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtTemplate1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpBulanan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter PerBulan All Cabang"
        '
        'dtpBulanan
        '
        Me.dtpBulanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBulanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBulanan.Location = New System.Drawing.Point(153, 69)
        Me.dtpBulanan.Name = "dtpBulanan"
        Me.dtpBulanan.Size = New System.Drawing.Size(149, 22)
        Me.dtpBulanan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bulan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTemplate2)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.dtpTglAkhir)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpTglAwal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbCabang)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 152)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTglAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAkhir.Location = New System.Drawing.Point(356, 113)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(166, 22)
        Me.dtpTglAkhir.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "S/D"
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAwal.Location = New System.Drawing.Point(154, 114)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(148, 22)
        Me.dtpTglAwal.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Periode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Cabang"
        '
        'cmbCabang
        '
        Me.cmbCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCabang.FormattingEnabled = True
        Me.cmbCabang.Location = New System.Drawing.Point(154, 65)
        Me.cmbCabang.Name = "cmbCabang"
        Me.cmbCabang.Size = New System.Drawing.Size(368, 28)
        Me.cmbCabang.TabIndex = 0
        '
        'ChkCabang
        '
        Me.ChkCabang.AutoSize = True
        Me.ChkCabang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCabang.Location = New System.Drawing.Point(7, 189)
        Me.ChkCabang.Name = "ChkCabang"
        Me.ChkCabang.Size = New System.Drawing.Size(234, 24)
        Me.ChkCabang.TabIndex = 2
        Me.ChkCabang.Text = "Filter Periode Per Cabang"
        Me.ChkCabang.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(566, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Template"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(153, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Browse....."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTemplate1
        '
        Me.txtTemplate1.Enabled = False
        Me.txtTemplate1.Location = New System.Drawing.Point(312, 27)
        Me.txtTemplate1.Multiline = True
        Me.txtTemplate1.Name = "txtTemplate1"
        Me.txtTemplate1.Size = New System.Drawing.Size(209, 33)
        Me.txtTemplate1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(527, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 71)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(527, 44)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 71)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Export"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Template"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(153, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 33)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Browse....."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtTemplate2
        '
        Me.txtTemplate2.Enabled = False
        Me.txtTemplate2.Location = New System.Drawing.Point(312, 19)
        Me.txtTemplate2.Multiline = True
        Me.txtTemplate2.Name = "txtTemplate2"
        Me.txtTemplate2.Size = New System.Drawing.Size(210, 33)
        Me.txtTemplate2.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.TurnOver.My.Resources.Resources._8d2266d10c0de8283c9f225d7f7b045b_colorful_abstract_geometric_background_vector_by_vexels1
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 72)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Export Laporan"
        '
        'FilterExportExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 361)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ChkCabang)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FilterExportExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FilterExportExcel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkCabang As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpBulanan As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTemplate1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtTemplate2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
