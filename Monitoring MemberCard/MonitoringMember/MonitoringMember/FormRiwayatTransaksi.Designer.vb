<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRiwayatTransaksi
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
        Me.dgHistoryTransaksiCustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalTransaksi = New System.Windows.Forms.Label()
        CType(Me.dgHistoryTransaksiCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgHistoryTransaksiCustomer
        '
        Me.dgHistoryTransaksiCustomer.AllowUserToAddRows = False
        Me.dgHistoryTransaksiCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHistoryTransaksiCustomer.Location = New System.Drawing.Point(0, 77)
        Me.dgHistoryTransaksiCustomer.Name = "dgHistoryTransaksiCustomer"
        Me.dgHistoryTransaksiCustomer.ReadOnly = True
        Me.dgHistoryTransaksiCustomer.Size = New System.Drawing.Size(493, 269)
        Me.dgHistoryTransaksiCustomer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 71)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Riwayat Transaksi"
        '
        'lblTotalTransaksi
        '
        Me.lblTotalTransaksi.AutoSize = True
        Me.lblTotalTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTransaksi.Location = New System.Drawing.Point(158, 356)
        Me.lblTotalTransaksi.Name = "lblTotalTransaksi"
        Me.lblTotalTransaksi.Size = New System.Drawing.Size(175, 25)
        Me.lblTotalTransaksi.TabIndex = 34
        Me.lblTotalTransaksi.Text = "Total Transaksi"
        '
        'FormRiwayatTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 390)
        Me.Controls.Add(Me.lblTotalTransaksi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgHistoryTransaksiCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FormRiwayatTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRiwayatTransaksi"
        CType(Me.dgHistoryTransaksiCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgHistoryTransaksiCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTransaksi As System.Windows.Forms.Label
End Class
