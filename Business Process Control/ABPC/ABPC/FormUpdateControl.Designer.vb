<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatusEnabled = New Guna.UI.WinForms.GunaComboBox()
        Me.txtFungsi = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotifikasi = New System.Windows.Forms.RichTextBox()
        Me.txtKodeValidasi = New System.Windows.Forms.TextBox()
        Me.txtNamaValidasi = New System.Windows.Forms.TextBox()
        Me.txtCabang = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdUpdateAllLocation = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDocNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 42)
        Me.Panel1.TabIndex = 0
        '
        'txtDocNum
        '
        Me.txtDocNum.Location = New System.Drawing.Point(4, 12)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.Size = New System.Drawing.Size(155, 20)
        Me.txtDocNum.TabIndex = 1
        Me.txtDocNum.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Validasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Validasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lokasi Kontrol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status Enabled"
        '
        'cmbStatusEnabled
        '
        Me.cmbStatusEnabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbStatusEnabled.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbStatusEnabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbStatusEnabled.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatusEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusEnabled.FocusedColor = System.Drawing.Color.Empty
        Me.cmbStatusEnabled.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatusEnabled.ForeColor = System.Drawing.Color.Black
        Me.cmbStatusEnabled.FormattingEnabled = True
        Me.cmbStatusEnabled.Items.AddRange(New Object() {"ENABLED", "DISABLED"})
        Me.cmbStatusEnabled.Location = New System.Drawing.Point(358, 85)
        Me.cmbStatusEnabled.Name = "cmbStatusEnabled"
        Me.cmbStatusEnabled.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatusEnabled.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbStatusEnabled.Size = New System.Drawing.Size(207, 26)
        Me.cmbStatusEnabled.TabIndex = 5
        '
        'txtFungsi
        '
        Me.txtFungsi.Location = New System.Drawing.Point(13, 140)
        Me.txtFungsi.Name = "txtFungsi"
        Me.txtFungsi.Size = New System.Drawing.Size(257, 88)
        Me.txtFungsi.TabIndex = 6
        Me.txtFungsi.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fungsi Kontrol"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(273, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Notifikasi"
        '
        'txtNotifikasi
        '
        Me.txtNotifikasi.Location = New System.Drawing.Point(276, 140)
        Me.txtNotifikasi.Name = "txtNotifikasi"
        Me.txtNotifikasi.Size = New System.Drawing.Size(289, 88)
        Me.txtNotifikasi.TabIndex = 9
        Me.txtNotifikasi.Text = ""
        '
        'txtKodeValidasi
        '
        Me.txtKodeValidasi.Enabled = False
        Me.txtKodeValidasi.Location = New System.Drawing.Point(88, 62)
        Me.txtKodeValidasi.Name = "txtKodeValidasi"
        Me.txtKodeValidasi.Size = New System.Drawing.Size(182, 20)
        Me.txtKodeValidasi.TabIndex = 10
        '
        'txtNamaValidasi
        '
        Me.txtNamaValidasi.Enabled = False
        Me.txtNamaValidasi.Location = New System.Drawing.Point(88, 88)
        Me.txtNamaValidasi.Name = "txtNamaValidasi"
        Me.txtNamaValidasi.Size = New System.Drawing.Size(182, 20)
        Me.txtNamaValidasi.TabIndex = 11
        '
        'txtCabang
        '
        Me.txtCabang.Enabled = False
        Me.txtCabang.Location = New System.Drawing.Point(359, 59)
        Me.txtCabang.Name = "txtCabang"
        Me.txtCabang.Size = New System.Drawing.Size(206, 20)
        Me.txtCabang.TabIndex = 12
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.Lime
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(276, 234)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(289, 71)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "Update Only For This Location"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdUpdateAllLocation
        '
        Me.cmdUpdateAllLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdUpdateAllLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateAllLocation.Location = New System.Drawing.Point(12, 234)
        Me.cmdUpdateAllLocation.Name = "cmdUpdateAllLocation"
        Me.cmdUpdateAllLocation.Size = New System.Drawing.Size(258, 71)
        Me.cmdUpdateAllLocation.TabIndex = 14
        Me.cmdUpdateAllLocation.Text = "Update For All Location"
        Me.cmdUpdateAllLocation.UseVisualStyleBackColor = False
        '
        'FormUpdateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 305)
        Me.Controls.Add(Me.cmdUpdateAllLocation)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtCabang)
        Me.Controls.Add(Me.txtNamaValidasi)
        Me.Controls.Add(Me.txtKodeValidasi)
        Me.Controls.Add(Me.txtNotifikasi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFungsi)
        Me.Controls.Add(Me.cmbStatusEnabled)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUpdateControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateControl"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbStatusEnabled As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtFungsi As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotifikasi As System.Windows.Forms.RichTextBox
    Friend WithEvents txtKodeValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaValidasi As System.Windows.Forms.TextBox
    Friend WithEvents txtCabang As System.Windows.Forms.TextBox
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateAllLocation As System.Windows.Forms.Button
End Class
