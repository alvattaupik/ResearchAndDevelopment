<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListCustomer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.cmbListCabang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvListCustomer = New System.Windows.Forms.DataGridView()
        Me.lblJumlahRow = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picExportTransaksi = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExportTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picExportTransaksi)
        Me.GroupBox1.Controls.Add(Me.btnProses)
        Me.GroupBox1.Controls.Add(Me.cmbListCabang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(90, 52)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(343, 24)
        Me.txtCari.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cari"
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(442, 13)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 63)
        Me.btnProses.TabIndex = 2
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'cmbListCabang
        '
        Me.cmbListCabang.FormattingEnabled = True
        Me.cmbListCabang.Location = New System.Drawing.Point(90, 19)
        Me.cmbListCabang.Name = "cmbListCabang"
        Me.cmbListCabang.Size = New System.Drawing.Size(343, 26)
        Me.cmbListCabang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cabang"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExport.Location = New System.Drawing.Point(294, 237)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(12, 16)
        Me.lblExport.TabIndex = 20
        Me.lblExport.Text = "-"
        Me.lblExport.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Daftar Customer"
        '
        'dgvListCustomer
        '
        Me.dgvListCustomer.AllowUserToAddRows = False
        Me.dgvListCustomer.AllowUserToDeleteRows = False
        Me.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListCustomer.Location = New System.Drawing.Point(6, 253)
        Me.dgvListCustomer.Name = "dgvListCustomer"
        Me.dgvListCustomer.ReadOnly = True
        Me.dgvListCustomer.RowHeadersVisible = False
        Me.dgvListCustomer.Size = New System.Drawing.Size(631, 322)
        Me.dgvListCustomer.TabIndex = 4
        '
        'lblJumlahRow
        '
        Me.lblJumlahRow.AutoSize = True
        Me.lblJumlahRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahRow.Location = New System.Drawing.Point(485, 578)
        Me.lblJumlahRow.Name = "lblJumlahRow"
        Me.lblJumlahRow.Size = New System.Drawing.Size(99, 16)
        Me.lblJumlahRow.TabIndex = 21
        Me.lblJumlahRow.Text = "Jumlah Data : 0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.logo_jpeg
        Me.PictureBox2.Location = New System.Drawing.Point(444, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(190, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Customer
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picExportTransaksi
        '
        Me.picExportTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.picExportTransaksi.BaseColor = System.Drawing.Color.Lime
        Me.picExportTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picExportTransaksi.Image = Global.MonitoringMember.My.Resources.Resources.Export_To_Excel
        Me.picExportTransaksi.Location = New System.Drawing.Point(523, 13)
        Me.picExportTransaksi.Name = "picExportTransaksi"
        Me.picExportTransaksi.Size = New System.Drawing.Size(109, 63)
        Me.picExportTransaksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExportTransaksi.TabIndex = 17
        Me.picExportTransaksi.TabStop = False
        '
        'frmListCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 599)
        Me.Controls.Add(Me.lblJumlahRow)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.dgvListCustomer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListCustomer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExportTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbListCabang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExportTransaksi As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents dgvListCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblExport As System.Windows.Forms.Label
    Friend WithEvents lblJumlahRow As System.Windows.Forms.Label
End Class
