<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseKomponenSAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowseKomponenSAP))
        Me.dgDaftarKomponenSAP = New System.Windows.Forms.DataGridView()
        Me.txtCariKomponen = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgDaftarKomponenSAP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDaftarKomponenSAP
        '
        Me.dgDaftarKomponenSAP.AllowUserToAddRows = False
        Me.dgDaftarKomponenSAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarKomponenSAP.Location = New System.Drawing.Point(5, 31)
        Me.dgDaftarKomponenSAP.Name = "dgDaftarKomponenSAP"
        Me.dgDaftarKomponenSAP.ReadOnly = True
        Me.dgDaftarKomponenSAP.RowHeadersVisible = False
        Me.dgDaftarKomponenSAP.Size = New System.Drawing.Size(434, 191)
        Me.dgDaftarKomponenSAP.TabIndex = 7
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
        Me.txtCariKomponen.Location = New System.Drawing.Point(53, 4)
        Me.txtCariKomponen.Name = "txtCariKomponen"
        Me.txtCariKomponen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCariKomponen.Size = New System.Drawing.Size(387, 26)
        Me.txtCariKomponen.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cari"
        '
        'frmBrowseKomponenSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 225)
        Me.Controls.Add(Me.dgDaftarKomponenSAP)
        Me.Controls.Add(Me.txtCariKomponen)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBrowseKomponenSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse SAP Components"
        CType(Me.dgDaftarKomponenSAP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgDaftarKomponenSAP As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariKomponen As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
