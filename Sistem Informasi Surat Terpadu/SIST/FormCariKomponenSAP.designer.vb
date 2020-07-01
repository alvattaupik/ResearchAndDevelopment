<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariKomponenSAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCariKomponenSAP))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCariKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.dgDaftarKomponenSAP = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDaftarKomponenSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Komponen SAP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cari Komponen SAP ( Misalnya: AR/ Invoice Item, GRPO)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cari"
        '
        'txtCariKomponen
        '
        Me.txtCariKomponen.BaseColor = System.Drawing.Color.White
        Me.txtCariKomponen.BorderColor = System.Drawing.Color.Silver
        Me.txtCariKomponen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCariKomponen.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCariKomponen.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCariKomponen.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCariKomponen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCariKomponen.Location = New System.Drawing.Point(60, 94)
        Me.txtCariKomponen.Name = "txtCariKomponen"
        Me.txtCariKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCariKomponen.Size = New System.Drawing.Size(387, 26)
        Me.txtCariKomponen.TabIndex = 3
        '
        'dgDaftarKomponenSAP
        '
        Me.dgDaftarKomponenSAP.AllowUserToAddRows = False
        Me.dgDaftarKomponenSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarKomponenSAP.Location = New System.Drawing.Point(12, 133)
        Me.dgDaftarKomponenSAP.Name = "dgDaftarKomponenSAP"
        Me.dgDaftarKomponenSAP.ReadOnly = True
        Me.dgDaftarKomponenSAP.Size = New System.Drawing.Size(434, 191)
        Me.dgDaftarKomponenSAP.TabIndex = 4
        '
        'FormCariKomponenSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(459, 337)
        Me.Controls.Add(Me.dgDaftarKomponenSAP)
        Me.Controls.Add(Me.txtCariKomponen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariKomponenSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCariKomponenSAP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDaftarKomponenSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCariKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgDaftarKomponenSAP As System.Windows.Forms.DataGridView
End Class
