<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailSpecificCategories
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
        Me.cmbHeaders = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListDetailMenu = New System.Windows.Forms.DataGridView()
        Me.gbField = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSolutions = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSeverityLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAktif = New System.Windows.Forms.CheckBox()
        Me.txtNamaExternal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSubCategories = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIDSub = New System.Windows.Forms.TextBox()
        CType(Me.dgvListDetailMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbHeaders
        '
        Me.cmbHeaders.FormattingEnabled = True
        Me.cmbHeaders.Location = New System.Drawing.Point(109, 14)
        Me.cmbHeaders.Name = "cmbHeaders"
        Me.cmbHeaders.Size = New System.Drawing.Size(435, 21)
        Me.cmbHeaders.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Incident Categories"
        '
        'dgvListDetailMenu
        '
        Me.dgvListDetailMenu.AllowUserToAddRows = False
        Me.dgvListDetailMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDetailMenu.Location = New System.Drawing.Point(109, 70)
        Me.dgvListDetailMenu.Name = "dgvListDetailMenu"
        Me.dgvListDetailMenu.ReadOnly = True
        Me.dgvListDetailMenu.RowHeadersVisible = False
        Me.dgvListDetailMenu.Size = New System.Drawing.Size(434, 166)
        Me.dgvListDetailMenu.TabIndex = 2
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.txtIDSub)
        Me.gbField.Controls.Add(Me.Label10)
        Me.gbField.Controls.Add(Me.txtID)
        Me.gbField.Controls.Add(Me.Label9)
        Me.gbField.Controls.Add(Me.txtSolutions)
        Me.gbField.Controls.Add(Me.Label8)
        Me.gbField.Controls.Add(Me.cmbSeverityLevel)
        Me.gbField.Controls.Add(Me.Label2)
        Me.gbField.Controls.Add(Me.cboAktif)
        Me.gbField.Controls.Add(Me.txtNamaExternal)
        Me.gbField.Controls.Add(Me.Label5)
        Me.gbField.Controls.Add(Me.txtDeskripsi)
        Me.gbField.Controls.Add(Me.Label4)
        Me.gbField.Controls.Add(Me.Label3)
        Me.gbField.Controls.Add(Me.txtKode)
        Me.gbField.Location = New System.Drawing.Point(4, 242)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(447, 233)
        Me.gbField.TabIndex = 3
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(154, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(106, 20)
        Me.txtID.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ID"
        '
        'txtSolutions
        '
        Me.txtSolutions.Location = New System.Drawing.Point(154, 129)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.Size = New System.Drawing.Size(273, 77)
        Me.txtSolutions.TabIndex = 12
        Me.txtSolutions.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Solutions"
        '
        'cmbSeverityLevel
        '
        Me.cmbSeverityLevel.FormattingEnabled = True
        Me.cmbSeverityLevel.Items.AddRange(New Object() {"LOW", "MEDIUM", "HIGH"})
        Me.cmbSeverityLevel.Location = New System.Drawing.Point(154, 105)
        Me.cmbSeverityLevel.Name = "cmbSeverityLevel"
        Me.cmbSeverityLevel.Size = New System.Drawing.Size(273, 21)
        Me.cmbSeverityLevel.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Severity Level"
        '
        'cboAktif
        '
        Me.cboAktif.AutoSize = True
        Me.cboAktif.Location = New System.Drawing.Point(154, 212)
        Me.cboAktif.Name = "cboAktif"
        Me.cboAktif.Size = New System.Drawing.Size(53, 17)
        Me.cboAktif.TabIndex = 8
        Me.cboAktif.Text = "Aktif?"
        Me.cboAktif.UseVisualStyleBackColor = True
        '
        'txtNamaExternal
        '
        Me.txtNamaExternal.Location = New System.Drawing.Point(154, 82)
        Me.txtNamaExternal.Name = "txtNamaExternal"
        Me.txtNamaExternal.Size = New System.Drawing.Size(273, 20)
        Me.txtNamaExternal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama External"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(154, 58)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(273, 20)
        Me.txtDeskripsi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode Symptoms"
        '
        'txtKode
        '
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(154, 34)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(273, 20)
        Me.txtKode.TabIndex = 1
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(468, 246)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(76, 42)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(469, 299)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 42)
        Me.btnProses.TabIndex = 5
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sub Categories"
        '
        'cmbSubCategories
        '
        Me.cmbSubCategories.FormattingEnabled = True
        Me.cmbSubCategories.Location = New System.Drawing.Point(109, 43)
        Me.cmbSubCategories.Name = "cmbSubCategories"
        Me.cmbSubCategories.Size = New System.Drawing.Size(435, 21)
        Me.cmbSubCategories.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-1, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Specific Categories"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(266, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ID SUBS"
        '
        'txtIDSub
        '
        Me.txtIDSub.Location = New System.Drawing.Point(321, 12)
        Me.txtIDSub.Name = "txtIDSub"
        Me.txtIDSub.ReadOnly = True
        Me.txtIDSub.Size = New System.Drawing.Size(106, 20)
        Me.txtIDSub.TabIndex = 16
        '
        'frmDetailSpecificCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 477)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSubCategories)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.dgvListDetailMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHeaders)
        Me.Name = "frmDetailSpecificCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specific Categories"
        CType(Me.dgvListDetailMenu,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbField.ResumeLayout(false)
        Me.gbField.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbHeaders As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvListDetailMenu As System.Windows.Forms.DataGridView
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaExternal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtSolutions As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSeverityLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSubCategories As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIDSub As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
