<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPerubahanHargaJual
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
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.LblNamaPerubahanharga = New System.Windows.Forms.Label()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.dgPerubahanHarga = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPerubahanHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblTanggal)
        Me.Panel1.Controls.Add(Me.LblNamaPerubahanharga)
        Me.Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 107)
        Me.Panel1.TabIndex = 1
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.Location = New System.Drawing.Point(218, 67)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(97, 25)
        Me.lblTanggal.TabIndex = 2
        Me.lblTanggal.Text = "Tanggal"
        '
        'LblNamaPerubahanharga
        '
        Me.LblNamaPerubahanharga.AutoSize = True
        Me.LblNamaPerubahanharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPerubahanharga.Location = New System.Drawing.Point(218, 22)
        Me.LblNamaPerubahanharga.Name = "LblNamaPerubahanharga"
        Me.LblNamaPerubahanharga.Size = New System.Drawing.Size(196, 25)
        Me.LblNamaPerubahanharga.TabIndex = 1
        Me.LblNamaPerubahanharga.Text = "Perubahan Harga"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.AnyarGadget.My.Resources.Resources.unnamed__2_
        Me.GunaPictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(192, 81)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'dgPerubahanHarga
        '
        Me.dgPerubahanHarga.AllowUserToAddRows = False
        Me.dgPerubahanHarga.AllowUserToDeleteRows = False
        Me.dgPerubahanHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPerubahanHarga.Location = New System.Drawing.Point(3, 124)
        Me.dgPerubahanHarga.Name = "dgPerubahanHarga"
        Me.dgPerubahanHarga.ReadOnly = True
        Me.dgPerubahanHarga.Size = New System.Drawing.Size(736, 230)
        Me.dgPerubahanHarga.TabIndex = 2
        '
        'DetailPerubahanHargaJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 366)
        Me.Controls.Add(Me.dgPerubahanHarga)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DetailPerubahanHargaJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetailPerubahanHargaJual"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPerubahanHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents LblNamaPerubahanharga As System.Windows.Forms.Label
    Friend WithEvents dgPerubahanHarga As System.Windows.Forms.DataGridView
End Class
