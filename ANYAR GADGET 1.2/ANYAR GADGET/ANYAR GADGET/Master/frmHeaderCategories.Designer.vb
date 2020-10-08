<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeaderCategories
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
        Me.dgvHeaderMenu = New System.Windows.Forms.DataGridView()
        Me.txtCariHeader = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbField = New System.Windows.Forms.GroupBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.txtNamaExternal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        CType(Me.dgvHeaderMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbField.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvHeaderMenu
        '
        Me.dgvHeaderMenu.AllowUserToAddRows = False
        Me.dgvHeaderMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeaderMenu.Location = New System.Drawing.Point(12, 40)
        Me.dgvHeaderMenu.Name = "dgvHeaderMenu"
        Me.dgvHeaderMenu.ReadOnly = True
        Me.dgvHeaderMenu.RowHeadersVisible = False
        Me.dgvHeaderMenu.Size = New System.Drawing.Size(591, 237)
        Me.dgvHeaderMenu.TabIndex = 0
        '
        'txtCariHeader
        '
        Me.txtCariHeader.Location = New System.Drawing.Point(128, 13)
        Me.txtCariHeader.Name = "txtCariHeader"
        Me.txtCariHeader.Size = New System.Drawing.Size(475, 20)
        Me.txtCariHeader.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Menu Header"
        '
        'gbField
        '
        Me.gbField.Controls.Add(Me.chkAktif)
        Me.gbField.Controls.Add(Me.txtNamaExternal)
        Me.gbField.Controls.Add(Me.Label5)
        Me.gbField.Controls.Add(Me.txtDeskripsi)
        Me.gbField.Controls.Add(Me.Label4)
        Me.gbField.Controls.Add(Me.txtKode)
        Me.gbField.Controls.Add(Me.Label3)
        Me.gbField.Controls.Add(Me.Label2)
        Me.gbField.Controls.Add(Me.txtID)
        Me.gbField.Location = New System.Drawing.Point(13, 279)
        Me.gbField.Name = "gbField"
        Me.gbField.Size = New System.Drawing.Size(412, 129)
        Me.gbField.TabIndex = 3
        Me.gbField.TabStop = False
        Me.gbField.Text = "field"
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Location = New System.Drawing.Point(140, 77)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(53, 17)
        Me.chkAktif.TabIndex = 8
        Me.chkAktif.Text = "Aktif?"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'txtNamaExternal
        '
        Me.txtNamaExternal.Location = New System.Drawing.Point(140, 46)
        Me.txtNamaExternal.Name = "txtNamaExternal"
        Me.txtNamaExternal.Size = New System.Drawing.Size(256, 20)
        Me.txtNamaExternal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama External"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(140, 20)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(256, 20)
        Me.txtDeskripsi.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(7, 54)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(53, 20)
        Me.txtKode.TabIndex = 3
        Me.txtKode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(31, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(31, 20)
        Me.txtID.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(432, 284)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(171, 46)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(432, 356)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(171, 46)
        Me.btnProses.TabIndex = 5
        Me.btnProses.Text = "OK"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'frmHeaderCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 414)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCariHeader)
        Me.Controls.Add(Me.dgvHeaderMenu)
        Me.Name = "frmHeaderCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHeaderMenu"
        CType(Me.dgvHeaderMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbField.ResumeLayout(False)
        Me.gbField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvHeaderMenu As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbField As System.Windows.Forms.GroupBox
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamaExternal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
End Class
