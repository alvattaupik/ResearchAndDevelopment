<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryInWarehouse
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
        Me.cmbItemGroup = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKodeCabangFrom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVendorCodeTo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemCodeTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemCodeFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLihatItemCode = New System.Windows.Forms.Button()
        Me.txtLihatvendorCode = New System.Windows.Forms.Button()
        Me.txtVendorCodeFrom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeCabangTo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbItemGroup)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtKodeCabangTo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtKodeCabangFrom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtVendorCodeTo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtVendorCodeFrom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtItemCodeTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtItemCodeFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbItemGroup
        '
        Me.cmbItemGroup.FormattingEnabled = True
        Me.cmbItemGroup.Location = New System.Drawing.Point(148, 109)
        Me.cmbItemGroup.Name = "cmbItemGroup"
        Me.cmbItemGroup.Size = New System.Drawing.Size(370, 21)
        Me.cmbItemGroup.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "From"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Item Group"
        '
        'txtKodeCabangFrom
        '
        Me.txtKodeCabangFrom.Location = New System.Drawing.Point(148, 81)
        Me.txtKodeCabangFrom.Name = "txtKodeCabangFrom"
        Me.txtKodeCabangFrom.Size = New System.Drawing.Size(149, 20)
        Me.txtKodeCabangFrom.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Kode Warehouse"
        '
        'txtVendorCodeTo
        '
        Me.txtVendorCodeTo.Location = New System.Drawing.Point(353, 50)
        Me.txtVendorCodeTo.Name = "txtVendorCodeTo"
        Me.txtVendorCodeTo.Size = New System.Drawing.Size(165, 20)
        Me.txtVendorCodeTo.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Vendor Code"
        '
        'txtItemCodeTo
        '
        Me.txtItemCodeTo.Location = New System.Drawing.Point(353, 18)
        Me.txtItemCodeTo.Name = "txtItemCodeTo"
        Me.txtItemCodeTo.Size = New System.Drawing.Size(165, 20)
        Me.txtItemCodeTo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'txtItemCodeFrom
        '
        Me.txtItemCodeFrom.Location = New System.Drawing.Point(148, 19)
        Me.txtItemCodeFrom.Name = "txtItemCodeFrom"
        Me.txtItemCodeFrom.Size = New System.Drawing.Size(149, 20)
        Me.txtItemCodeFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Code"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(366, 152)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(88, 37)
        Me.btnProses.TabIndex = 14
        Me.btnProses.Text = "Ok"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(474, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 37)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLihatItemCode
        '
        Me.btnLihatItemCode.Location = New System.Drawing.Point(12, 151)
        Me.btnLihatItemCode.Name = "btnLihatItemCode"
        Me.btnLihatItemCode.Size = New System.Drawing.Size(106, 36)
        Me.btnLihatItemCode.TabIndex = 16
        Me.btnLihatItemCode.Text = "Lihat Item Code"
        Me.btnLihatItemCode.UseVisualStyleBackColor = True
        '
        'txtLihatvendorCode
        '
        Me.txtLihatvendorCode.Location = New System.Drawing.Point(124, 151)
        Me.txtLihatvendorCode.Name = "txtLihatvendorCode"
        Me.txtLihatvendorCode.Size = New System.Drawing.Size(106, 36)
        Me.txtLihatvendorCode.TabIndex = 17
        Me.txtLihatvendorCode.Text = "Lihat Vendor Code"
        Me.txtLihatvendorCode.UseVisualStyleBackColor = True
        '
        'txtVendorCodeFrom
        '
        Me.txtVendorCodeFrom.Location = New System.Drawing.Point(148, 50)
        Me.txtVendorCodeFrom.Name = "txtVendorCodeFrom"
        Me.txtVendorCodeFrom.Size = New System.Drawing.Size(149, 20)
        Me.txtVendorCodeFrom.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "To"
        '
        'txtKodeCabangTo
        '
        Me.txtKodeCabangTo.Location = New System.Drawing.Point(353, 81)
        Me.txtKodeCabangTo.Name = "txtKodeCabangTo"
        Me.txtKodeCabangTo.Size = New System.Drawing.Size(165, 20)
        Me.txtKodeCabangTo.TabIndex = 13
        '
        'frmInventoryInWarehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 193)
        Me.Controls.Add(Me.txtLihatvendorCode)
        Me.Controls.Add(Me.btnLihatItemCode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProses)
        Me.Name = "frmInventoryInWarehouse"
        Me.Text = "Laporan Inventory In Warehouse Report - Selection Criteria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeCabangFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVendorCodeTo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemCodeTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemCodeFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLihatItemCode As System.Windows.Forms.Button
    Friend WithEvents txtLihatvendorCode As System.Windows.Forms.Button
    Friend WithEvents cmbItemGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKodeCabangTo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVendorCodeFrom As System.Windows.Forms.TextBox
End Class
