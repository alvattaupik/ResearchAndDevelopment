<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoringStokMemberdanVoucher
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbRincianTransaksi = New System.Windows.Forms.GroupBox()
        Me.dgvTransaksiMemberCard = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStokMember = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbRincianVoucher = New System.Windows.Forms.GroupBox()
        Me.dgvRincianTransaksiVoucher = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvStockVoucher = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox13 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox12 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox5 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox4 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox2 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaTransfarantPictureBox8 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.picLihatRincianMember = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbRincianTransaksi.SuspendLayout()
        CType(Me.dgvTransaksiMemberCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStokMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbRincianVoucher.SuspendLayout()
        CType(Me.dgvRincianTransaksiVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStockVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLihatRincianMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 320)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.picLihatRincianMember)
        Me.TabPage1.Controls.Add(Me.gbRincianTransaksi)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgvStokMember)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stok Member"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbRincianTransaksi
        '
        Me.gbRincianTransaksi.Controls.Add(Me.dgvTransaksiMemberCard)
        Me.gbRincianTransaksi.Location = New System.Drawing.Point(333, 7)
        Me.gbRincianTransaksi.Name = "gbRincianTransaksi"
        Me.gbRincianTransaksi.Size = New System.Drawing.Size(302, 279)
        Me.gbRincianTransaksi.TabIndex = 38
        Me.gbRincianTransaksi.TabStop = False
        Me.gbRincianTransaksi.Text = "Rincian Transaksi"
        '
        'dgvTransaksiMemberCard
        '
        Me.dgvTransaksiMemberCard.AllowUserToAddRows = False
        Me.dgvTransaksiMemberCard.AllowUserToDeleteRows = False
        Me.dgvTransaksiMemberCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaksiMemberCard.Location = New System.Drawing.Point(10, 23)
        Me.dgvTransaksiMemberCard.Name = "dgvTransaksiMemberCard"
        Me.dgvTransaksiMemberCard.ReadOnly = True
        Me.dgvTransaksiMemberCard.RowHeadersVisible = False
        Me.dgvTransaksiMemberCard.Size = New System.Drawing.Size(286, 250)
        Me.dgvTransaksiMemberCard.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 33)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Head Office"
        '
        'dgvStokMember
        '
        Me.dgvStokMember.AllowUserToAddRows = False
        Me.dgvStokMember.AllowUserToDeleteRows = False
        Me.dgvStokMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStokMember.Location = New System.Drawing.Point(7, 36)
        Me.dgvStokMember.Name = "dgvStokMember"
        Me.dgvStokMember.ReadOnly = True
        Me.dgvStokMember.RowHeadersVisible = False
        Me.dgvStokMember.Size = New System.Drawing.Size(251, 250)
        Me.dgvStokMember.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbRincianVoucher)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.dgvStockVoucher)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(641, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock Voucher"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbRincianVoucher
        '
        Me.gbRincianVoucher.Controls.Add(Me.dgvRincianTransaksiVoucher)
        Me.gbRincianVoucher.Location = New System.Drawing.Point(333, 8)
        Me.gbRincianVoucher.Name = "gbRincianVoucher"
        Me.gbRincianVoucher.Size = New System.Drawing.Size(302, 279)
        Me.gbRincianVoucher.TabIndex = 43
        Me.gbRincianVoucher.TabStop = False
        Me.gbRincianVoucher.Text = "Rincian Transaksi"
        '
        'dgvRincianTransaksiVoucher
        '
        Me.dgvRincianTransaksiVoucher.AllowUserToAddRows = False
        Me.dgvRincianTransaksiVoucher.AllowUserToDeleteRows = False
        Me.dgvRincianTransaksiVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRincianTransaksiVoucher.Location = New System.Drawing.Point(10, 23)
        Me.dgvRincianTransaksiVoucher.Name = "dgvRincianTransaksiVoucher"
        Me.dgvRincianTransaksiVoucher.ReadOnly = True
        Me.dgvRincianTransaksiVoucher.RowHeadersVisible = False
        Me.dgvRincianTransaksiVoucher.Size = New System.Drawing.Size(286, 250)
        Me.dgvRincianTransaksiVoucher.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 33)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Head Office"
        '
        'dgvStockVoucher
        '
        Me.dgvStockVoucher.AllowUserToAddRows = False
        Me.dgvStockVoucher.AllowUserToDeleteRows = False
        Me.dgvStockVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockVoucher.Location = New System.Drawing.Point(9, 36)
        Me.dgvStockVoucher.Name = "dgvStockVoucher"
        Me.dgvStockVoucher.ReadOnly = True
        Me.dgvStockVoucher.RowHeadersVisible = False
        Me.dgvStockVoucher.Size = New System.Drawing.Size(251, 250)
        Me.dgvStockVoucher.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 33)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Monitoring Stok Voucher dan Member"
        '
        'GunaTransfarantPictureBox13
        '
        Me.GunaTransfarantPictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox13.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox13.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox13.Location = New System.Drawing.Point(554, 0)
        Me.GunaTransfarantPictureBox13.Name = "GunaTransfarantPictureBox13"
        Me.GunaTransfarantPictureBox13.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox13.TabIndex = 35
        Me.GunaTransfarantPictureBox13.TabStop = False
        '
        'GunaTransfarantPictureBox12
        '
        Me.GunaTransfarantPictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox12.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox12.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox12.Location = New System.Drawing.Point(462, 0)
        Me.GunaTransfarantPictureBox12.Name = "GunaTransfarantPictureBox12"
        Me.GunaTransfarantPictureBox12.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox12.TabIndex = 34
        Me.GunaTransfarantPictureBox12.TabStop = False
        '
        'GunaTransfarantPictureBox5
        '
        Me.GunaTransfarantPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox5.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox5.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox5.Location = New System.Drawing.Point(277, 0)
        Me.GunaTransfarantPictureBox5.Name = "GunaTransfarantPictureBox5"
        Me.GunaTransfarantPictureBox5.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox5.TabIndex = 33
        Me.GunaTransfarantPictureBox5.TabStop = False
        '
        'GunaTransfarantPictureBox4
        '
        Me.GunaTransfarantPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox4.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox4.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox4.Location = New System.Drawing.Point(184, -1)
        Me.GunaTransfarantPictureBox4.Name = "GunaTransfarantPictureBox4"
        Me.GunaTransfarantPictureBox4.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox4.TabIndex = 32
        Me.GunaTransfarantPictureBox4.TabStop = False
        '
        'GunaTransfarantPictureBox2
        '
        Me.GunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox2.Location = New System.Drawing.Point(92, -1)
        Me.GunaTransfarantPictureBox2.Name = "GunaTransfarantPictureBox2"
        Me.GunaTransfarantPictureBox2.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox2.TabIndex = 31
        Me.GunaTransfarantPictureBox2.TabStop = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 30
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaTransfarantPictureBox8
        '
        Me.GunaTransfarantPictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox8.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox8.Image = Global.MonitoringMember.My.Resources.Resources.Batik_9
        Me.GunaTransfarantPictureBox8.Location = New System.Drawing.Point(369, 0)
        Me.GunaTransfarantPictureBox8.Name = "GunaTransfarantPictureBox8"
        Me.GunaTransfarantPictureBox8.Size = New System.Drawing.Size(94, 66)
        Me.GunaTransfarantPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox8.TabIndex = 29
        Me.GunaTransfarantPictureBox8.TabStop = False
        '
        'picLihatRincianMember
        '
        Me.picLihatRincianMember.Image = Global.MonitoringMember.My.Resources.Resources.See
        Me.picLihatRincianMember.Location = New System.Drawing.Point(265, 36)
        Me.picLihatRincianMember.Name = "picLihatRincianMember"
        Me.picLihatRincianMember.Size = New System.Drawing.Size(53, 49)
        Me.picLihatRincianMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLihatRincianMember.TabIndex = 39
        Me.picLihatRincianMember.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MonitoringMember.My.Resources.Resources.See
        Me.PictureBox2.Location = New System.Drawing.Point(267, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'frmMonitoringStokMemberdanVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 424)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaTransfarantPictureBox13)
        Me.Controls.Add(Me.GunaTransfarantPictureBox12)
        Me.Controls.Add(Me.GunaTransfarantPictureBox5)
        Me.Controls.Add(Me.GunaTransfarantPictureBox4)
        Me.Controls.Add(Me.GunaTransfarantPictureBox2)
        Me.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.Controls.Add(Me.GunaTransfarantPictureBox8)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMonitoringStokMemberdanVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Voucher dan Member"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbRincianTransaksi.ResumeLayout(False)
        CType(Me.dgvTransaksiMemberCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStokMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbRincianVoucher.ResumeLayout(False)
        CType(Me.dgvRincianTransaksiVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStockVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLihatRincianMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GunaTransfarantPictureBox13 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox12 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox5 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox4 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox2 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents GunaTransfarantPictureBox8 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvStokMember As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbRincianTransaksi As System.Windows.Forms.GroupBox
    Friend WithEvents picLihatRincianMember As System.Windows.Forms.PictureBox
    Friend WithEvents dgvTransaksiMemberCard As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvStockVoucher As System.Windows.Forms.DataGridView
    Friend WithEvents gbRincianVoucher As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRincianTransaksiVoucher As System.Windows.Forms.DataGridView
End Class
