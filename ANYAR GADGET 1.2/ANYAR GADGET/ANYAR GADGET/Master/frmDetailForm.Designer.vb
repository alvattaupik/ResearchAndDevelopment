<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailForm
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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
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
        Me.dgvListDetailForm = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbHeaderForm = New System.Windows.Forms.ComboBox()
        Me.gbField.SuspendLayout()
        CType(Me.dgvListDetailForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(445, 258)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(100, 42)
        Me.btnProses.TabIndex = 11
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(445, 194)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(101, 42)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.gbField.Location = New System.Drawing.Point(57, 189)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(381, 113)
        Me.gbField.TabIndex = 9
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
        'dgvListDetailForm
        '
        Me.dgvListDetailForm.AllowUserToAddRows = False
        Me.dgvListDetailForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDetailForm.Location = New System.Drawing.Point(57, 40)
        Me.dgvListDetailForm.Name = "dgvListDetailForm"
        Me.dgvListDetailForm.ReadOnly = True
        Me.dgvListDetailForm.Size = New System.Drawing.Size(489, 145)
        Me.dgvListDetailForm.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Headers"
        '
        'cmbHeaderForm
        '
        Me.cmbHeaderForm.FormattingEnabled = True
        Me.cmbHeaderForm.Location = New System.Drawing.Point(57, 12)
        Me.cmbHeaderForm.Name = "cmbHeaderForm"
        Me.cmbHeaderForm.Size = New System.Drawing.Size(489, 21)
        Me.cmbHeaderForm.TabIndex = 6
        '
        'frmDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 306)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.dgvListDetailForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHeaderForm)
        Me.Name = "frmDetailForm"
        Me.Text = "frmDetailForm"
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        CType(Me.dgvListDetailForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamaExternal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents dgvListDetailForm As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHeaderForm As System.Windows.Forms.ComboBox
End Class
