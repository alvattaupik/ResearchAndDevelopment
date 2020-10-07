<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMenu
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
        Me.cboAktif = New System.Windows.Forms.CheckBox()
        Me.txtNamaExternal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        CType(Me.dgvListDetailMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbHeaders
        '
        Me.cmbHeaders.FormattingEnabled = True
        Me.cmbHeaders.Location = New System.Drawing.Point(68, 14)
        Me.cmbHeaders.Name = "cmbHeaders"
        Me.cmbHeaders.Size = New System.Drawing.Size(476, 21)
        Me.cmbHeaders.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Detail Menu"
        '
        'dgvListDetailMenu
        '
        Me.dgvListDetailMenu.AllowUserToAddRows = False
        Me.dgvListDetailMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDetailMenu.Location = New System.Drawing.Point(68, 41)
        Me.dgvListDetailMenu.Name = "dgvListDetailMenu"
        Me.dgvListDetailMenu.ReadOnly = True
        Me.dgvListDetailMenu.RowHeadersVisible = False
        Me.dgvListDetailMenu.Size = New System.Drawing.Size(475, 145)
        Me.dgvListDetailMenu.TabIndex = 2
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.cboAktif)
        Me.gbField.Controls.Add(Me.txtNamaExternal)
        Me.gbField.Controls.Add(Me.Label5)
        Me.gbField.Controls.Add(Me.txtDeskripsi)
        Me.gbField.Controls.Add(Me.Label4)
        Me.gbField.Controls.Add(Me.Label3)
        Me.gbField.Controls.Add(Me.Label2)
        Me.gbField.Controls.Add(Me.txtKode)
        Me.gbField.Controls.Add(Me.txtID)
        Me.gbField.Location = New System.Drawing.Point(68, 193)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(383, 113)
        Me.gbField.TabIndex = 3
        Me.gbField.TabStop = False
        Me.gbField.Text = "Field"
        '
        'cboAktif
        '
        Me.cboAktif.AutoSize = True
        Me.cboAktif.Location = New System.Drawing.Point(154, 92)
        Me.cboAktif.Name = "cboAktif"
        Me.cboAktif.Size = New System.Drawing.Size(53, 17)
        Me.cboAktif.TabIndex = 8
        Me.cboAktif.Text = "Aktif?"
        Me.cboAktif.UseVisualStyleBackColor = True
        '
        'txtNamaExternal
        '
        Me.txtNamaExternal.Location = New System.Drawing.Point(154, 69)
        Me.txtNamaExternal.Name = "txtNamaExternal"
        Me.txtNamaExternal.Size = New System.Drawing.Size(221, 20)
        Me.txtNamaExternal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama External"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(154, 44)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(221, 20)
        Me.txtDeskripsi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(154, 19)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(221, 20)
        Me.txtKode.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(41, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(49, 20)
        Me.txtID.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(467, 199)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(76, 42)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(467, 262)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 42)
        Me.btnProses.TabIndex = 5
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'frmDetailMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 314)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.dgvListDetailMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHeaders)
        Me.Name = "frmDetailMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetailMenu"
        CType(Me.dgvListDetailMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
End Class
