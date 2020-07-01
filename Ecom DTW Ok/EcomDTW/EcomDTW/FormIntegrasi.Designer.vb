<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIntegrasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIntegrasi))
        Me.cmdProses = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgListUpload = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdUpload = New System.Windows.Forms.Button()
        Me.lblJumlahUpload = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdLogoff = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblJumlahItem2 = New System.Windows.Forms.Label()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BgWorker = New System.ComponentModel.BackgroundWorker()
        Me.cmdStopProses = New System.Windows.Forms.Button()
        Me.lblStatusProses = New System.Windows.Forms.Label()
        CType(Me.dgListUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdProses
        '
        Me.cmdProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProses.Location = New System.Drawing.Point(460, 9)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(102, 89)
        Me.cmdProses.TabIndex = 0
        Me.cmdProses.Text = "Proses"
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgListUpload
        '
        Me.dgListUpload.AllowUserToAddRows = False
        Me.dgListUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListUpload.Location = New System.Drawing.Point(13, 114)
        Me.dgListUpload.Name = "dgListUpload"
        Me.dgListUpload.Size = New System.Drawing.Size(833, 287)
        Me.dgListUpload.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahItem})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 404)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(862, 26)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblJumlahItem
        '
        Me.lblJumlahItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahItem.Name = "lblJumlahItem"
        Me.lblJumlahItem.Size = New System.Drawing.Size(98, 21)
        Me.lblJumlahItem.Text = "Jumlah Item"
        '
        'cmdUpload
        '
        Me.cmdUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpload.Location = New System.Drawing.Point(705, 6)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(70, 92)
        Me.cmdUpload.TabIndex = 7
        Me.cmdUpload.Text = "Upload"
        Me.cmdUpload.UseVisualStyleBackColor = True
        '
        'lblJumlahUpload
        '
        Me.lblJumlahUpload.AutoSize = True
        Me.lblJumlahUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUpload.Location = New System.Drawing.Point(651, 410)
        Me.lblJumlahUpload.Name = "lblJumlahUpload"
        Me.lblJumlahUpload.Size = New System.Drawing.Size(19, 20)
        Me.lblJumlahUpload.TabIndex = 8
        Me.lblJumlahUpload.Text = "0"
        Me.lblJumlahUpload.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Integrasi Master Data"
        '
        'cmdLogoff
        '
        Me.cmdLogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogoff.Location = New System.Drawing.Point(781, 6)
        Me.cmdLogoff.Name = "cmdLogoff"
        Me.cmdLogoff.Size = New System.Drawing.Size(65, 92)
        Me.cmdLogoff.TabIndex = 11
        Me.cmdLogoff.Text = "Logoff"
        Me.cmdLogoff.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblJumlahItem2
        '
        Me.lblJumlahItem2.AutoSize = True
        Me.lblJumlahItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahItem2.Location = New System.Drawing.Point(777, 410)
        Me.lblJumlahItem2.Name = "lblJumlahItem2"
        Me.lblJumlahItem2.Size = New System.Drawing.Size(19, 20)
        Me.lblJumlahItem2.TabIndex = 13
        Me.lblJumlahItem2.Text = "0"
        Me.lblJumlahItem2.Visible = False
        '
        'lblDari
        '
        Me.lblDari.AutoSize = True
        Me.lblDari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDari.Location = New System.Drawing.Point(701, 408)
        Me.lblDari.Name = "lblDari"
        Me.lblDari.Size = New System.Drawing.Size(42, 20)
        Me.lblDari.TabIndex = 14
        Me.lblDari.Text = "Dari"
        Me.lblDari.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(514, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mengintegrasikan:"
        '
        'BgWorker
        '
        Me.BgWorker.WorkerReportsProgress = True
        Me.BgWorker.WorkerSupportsCancellation = True
        '
        'cmdStopProses
        '
        Me.cmdStopProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopProses.Location = New System.Drawing.Point(568, 9)
        Me.cmdStopProses.Name = "cmdStopProses"
        Me.cmdStopProses.Size = New System.Drawing.Size(102, 89)
        Me.cmdStopProses.TabIndex = 17
        Me.cmdStopProses.Text = "Stop Proses"
        Me.cmdStopProses.UseVisualStyleBackColor = True
        '
        'lblStatusProses
        '
        Me.lblStatusProses.AutoSize = True
        Me.lblStatusProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusProses.Location = New System.Drawing.Point(183, 45)
        Me.lblStatusProses.Name = "lblStatusProses"
        Me.lblStatusProses.Size = New System.Drawing.Size(167, 16)
        Me.lblStatusProses.TabIndex = 18
        Me.lblStatusProses.Text = "Status Proses : 0 dari 0"
        Me.lblStatusProses.Visible = False
        '
        'FormIntegrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 430)
        Me.Controls.Add(Me.lblStatusProses)
        Me.Controls.Add(Me.cmdStopProses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDari)
        Me.Controls.Add(Me.lblJumlahItem2)
        Me.Controls.Add(Me.cmdLogoff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblJumlahUpload)
        Me.Controls.Add(Me.cmdUpload)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgListUpload)
        Me.Controls.Add(Me.cmdProses)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIntegrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Integrasi Master Data"
        CType(Me.dgListUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProses As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgListUpload As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdUpload As System.Windows.Forms.Button
    Friend WithEvents lblJumlahUpload As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdLogoff As System.Windows.Forms.Button
    Friend WithEvents lblJumlahItem2 As System.Windows.Forms.Label
    Friend WithEvents lblDari As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdStopProses As System.Windows.Forms.Button
    Friend WithEvents lblStatusProses As System.Windows.Forms.Label

End Class
