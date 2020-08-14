<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokopediaStockCompare
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPathTokpedSKU = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgSAPStock = New System.Windows.Forms.DataGridView()
        Me.btnExportTo = New System.Windows.Forms.Button()
        Me.dgTokopediaSKU = New System.Windows.Forms.DataGridView()
        Me.SKU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumlahProdukTokped = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblJumlahProduk2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSAPStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTokopediaSKU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tokopedia SKU Product"
        '
        'txtPathTokpedSKU
        '
        Me.txtPathTokpedSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPathTokpedSKU.Location = New System.Drawing.Point(278, 49)
        Me.txtPathTokpedSKU.Name = "txtPathTokpedSKU"
        Me.txtPathTokpedSKU.ReadOnly = True
        Me.txtPathTokpedSKU.Size = New System.Drawing.Size(388, 26)
        Me.txtPathTokpedSKU.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.tokopedia_apa_itu_startup_pengertian_cara_memulai_dan_1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPathTokpedSKU)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'dgSAPStock
        '
        Me.dgSAPStock.AllowUserToAddRows = False
        Me.dgSAPStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSAPStock.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgSAPStock.Location = New System.Drawing.Point(281, 163)
        Me.dgSAPStock.Name = "dgSAPStock"
        Me.dgSAPStock.ReadOnly = True
        Me.dgSAPStock.Size = New System.Drawing.Size(488, 191)
        Me.dgSAPStock.TabIndex = 5
        '
        'btnExportTo
        '
        Me.btnExportTo.Enabled = False
        Me.btnExportTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportTo.Location = New System.Drawing.Point(281, 376)
        Me.btnExportTo.Name = "btnExportTo"
        Me.btnExportTo.Size = New System.Drawing.Size(488, 34)
        Me.btnExportTo.TabIndex = 6
        Me.btnExportTo.Text = "Export To Excel"
        Me.btnExportTo.UseVisualStyleBackColor = True
        '
        'dgTokopediaSKU
        '
        Me.dgTokopediaSKU.AllowUserToAddRows = False
        Me.dgTokopediaSKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTokopediaSKU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKU})
        Me.dgTokopediaSKU.Location = New System.Drawing.Point(3, 163)
        Me.dgTokopediaSKU.Name = "dgTokopediaSKU"
        Me.dgTokopediaSKU.ReadOnly = True
        Me.dgTokopediaSKU.RowHeadersVisible = False
        Me.dgTokopediaSKU.Size = New System.Drawing.Size(272, 191)
        Me.dgTokopediaSKU.TabIndex = 7
        '
        'SKU
        '
        Me.SKU.HeaderText = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.ReadOnly = True
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(3, 376)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(272, 34)
        Me.btnProcess.TabIndex = 8
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tokopedia SKU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SAP - REALTIME STOCK"
        '
        'lblJumlahProdukTokped
        '
        Me.lblJumlahProdukTokped.AutoSize = True
        Me.lblJumlahProdukTokped.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahProdukTokped.Location = New System.Drawing.Point(-1, 356)
        Me.lblJumlahProdukTokped.Name = "lblJumlahProdukTokped"
        Me.lblJumlahProdukTokped.Size = New System.Drawing.Size(152, 20)
        Me.lblJumlahProdukTokped.TabIndex = 11
        Me.lblJumlahProdukTokped.Text = "Jumlah Produk : 0"
        '
        'BackgroundWorker1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(4, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 34)
        Me.Panel1.TabIndex = 12
        '
        'lblJumlahProduk2
        '
        Me.lblJumlahProduk2.AutoSize = True
        Me.lblJumlahProduk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahProduk2.Location = New System.Drawing.Point(281, 355)
        Me.lblJumlahProduk2.Name = "lblJumlahProduk2"
        Me.lblJumlahProduk2.Size = New System.Drawing.Size(152, 20)
        Me.lblJumlahProduk2.TabIndex = 13
        Me.lblJumlahProduk2.Text = "Jumlah Produk : 0"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyTableToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 26)
        '
        'CopyTableToolStripMenuItem
        '
        Me.CopyTableToolStripMenuItem.Name = "CopyTableToolStripMenuItem"
        Me.CopyTableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyTableToolStripMenuItem.Text = "Copy Table"
        '
        'TokopediaStockCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 412)
        Me.Controls.Add(Me.lblJumlahProduk2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblJumlahProdukTokped)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.dgTokopediaSKU)
        Me.Controls.Add(Me.btnExportTo)
        Me.Controls.Add(Me.dgSAPStock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TokopediaStockCompare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TokopediaStockCompare"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgSAPStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTokopediaSKU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPathTokpedSKU As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgSAPStock As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportTo As System.Windows.Forms.Button
    Friend WithEvents dgTokopediaSKU As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahProdukTokped As System.Windows.Forms.Label
    Friend WithEvents SKU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJumlahProduk2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
