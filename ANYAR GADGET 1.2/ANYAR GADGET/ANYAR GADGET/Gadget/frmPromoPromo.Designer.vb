<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromoPromo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvListPromoAktif = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNamaPromo = New System.Windows.Forms.TextBox()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBerlakuUntuk = New System.Windows.Forms.Button()
        Me.lblJumlahPromoAktif = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.panelApplicable = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvListApplicable = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListPromoAktif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panelApplicable.SuspendLayout()
        CType(Me.dgvListApplicable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 73)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(213, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Promo - Promo"
        '
        'dgvListPromoAktif
        '
        Me.dgvListPromoAktif.AllowUserToAddRows = False
        Me.dgvListPromoAktif.AllowUserToDeleteRows = False
        Me.dgvListPromoAktif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvListPromoAktif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPromoAktif.Location = New System.Drawing.Point(6, 118)
        Me.dgvListPromoAktif.Name = "dgvListPromoAktif"
        Me.dgvListPromoAktif.ReadOnly = True
        Me.dgvListPromoAktif.RowHeadersVisible = False
        Me.dgvListPromoAktif.Size = New System.Drawing.Size(404, 253)
        Me.dgvListPromoAktif.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNamaPromo)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 93)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter"
        '
        'txtNamaPromo
        '
        Me.txtNamaPromo.Location = New System.Drawing.Point(124, 56)
        Me.txtNamaPromo.Name = "txtNamaPromo"
        Me.txtNamaPromo.Size = New System.Drawing.Size(261, 26)
        Me.txtNamaPromo.TabIndex = 3
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(124, 19)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(261, 26)
        Me.txtKode.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Promo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnBerlakuUntuk)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 495)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 67)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aksi"
        '
        'btnBerlakuUntuk
        '
        Me.btnBerlakuUntuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBerlakuUntuk.Location = New System.Drawing.Point(7, 16)
        Me.btnBerlakuUntuk.Name = "btnBerlakuUntuk"
        Me.btnBerlakuUntuk.Size = New System.Drawing.Size(117, 41)
        Me.btnBerlakuUntuk.TabIndex = 0
        Me.btnBerlakuUntuk.Text = "Berlaku Untuk"
        Me.btnBerlakuUntuk.UseVisualStyleBackColor = True
        '
        'lblJumlahPromoAktif
        '
        Me.lblJumlahPromoAktif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblJumlahPromoAktif.AutoSize = True
        Me.lblJumlahPromoAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahPromoAktif.Location = New System.Drawing.Point(6, 374)
        Me.lblJumlahPromoAktif.Name = "lblJumlahPromoAktif"
        Me.lblJumlahPromoAktif.Size = New System.Drawing.Size(180, 18)
        Me.lblJumlahPromoAktif.TabIndex = 9
        Me.lblJumlahPromoAktif.Text = "Jumlah Promo Aktif : 0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.lblJumlahPromoAktif)
        Me.GroupBox3.Controls.Add(Me.dgvListPromoAktif)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 398)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'panelApplicable
        '
        Me.panelApplicable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelApplicable.BackColor = System.Drawing.Color.White
        Me.panelApplicable.Controls.Add(Me.btnClose)
        Me.panelApplicable.Controls.Add(Me.Label3)
        Me.panelApplicable.Controls.Add(Me.dgvListApplicable)
        Me.panelApplicable.Location = New System.Drawing.Point(445, 88)
        Me.panelApplicable.Name = "panelApplicable"
        Me.panelApplicable.Size = New System.Drawing.Size(296, 233)
        Me.panelApplicable.TabIndex = 11
        Me.panelApplicable.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(246, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 35)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Berlaku Untuk"
        '
        'dgvListApplicable
        '
        Me.dgvListApplicable.AllowUserToAddRows = False
        Me.dgvListApplicable.AllowUserToDeleteRows = False
        Me.dgvListApplicable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListApplicable.Location = New System.Drawing.Point(3, 38)
        Me.dgvListApplicable.Name = "dgvListApplicable"
        Me.dgvListApplicable.ReadOnly = True
        Me.dgvListApplicable.Size = New System.Drawing.Size(286, 183)
        Me.dgvListApplicable.TabIndex = 0
        '
        'frmPromoPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 565)
        Me.Controls.Add(Me.panelApplicable)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPromoPromo"
        Me.Text = "frmPromoPromo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvListPromoAktif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panelApplicable.ResumeLayout(False)
        Me.panelApplicable.PerformLayout()
        CType(Me.dgvListApplicable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvListPromoAktif As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaPromo As System.Windows.Forms.TextBox
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBerlakuUntuk As System.Windows.Forms.Button
    Friend WithEvents lblJumlahPromoAktif As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents panelApplicable As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvListApplicable As System.Windows.Forms.DataGridView
End Class
