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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdStopProses = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdCancelIntegrasi = New System.Windows.Forms.Button()
        Me.PanelIntegrasi = New System.Windows.Forms.Panel()
        Me.lblProsesIntegrasi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.PanelSinkronisasi = New System.Windows.Forms.Panel()
        Me.lblSinkronisasi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator2 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.bgSinkronisasi = New System.ComponentModel.BackgroundWorker()
        Me.bgIntegrasi = New System.ComponentModel.BackgroundWorker()
        Me.dgListUpload = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIntegrasi.SuspendLayout()
        Me.PanelSinkronisasi.SuspendLayout()
        CType(Me.dgListUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdProses
        '
        Me.cmdProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProses.Location = New System.Drawing.Point(249, 52)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(238, 56)
        Me.cmdProses.TabIndex = 0
        Me.cmdProses.Text = "Sinkronisasi MYSQL-SQL Server"
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahItem})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 404)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(801, 26)
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
        Me.cmdUpload.Location = New System.Drawing.Point(685, 14)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(111, 56)
        Me.cmdUpload.TabIndex = 7
        Me.cmdUpload.Text = "Integrasikan"
        Me.cmdUpload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Integrasi Master Data"
        '
        'cmdStopProses
        '
        Me.cmdStopProses.Enabled = False
        Me.cmdStopProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopProses.Location = New System.Drawing.Point(493, 52)
        Me.cmdStopProses.Name = "cmdStopProses"
        Me.cmdStopProses.Size = New System.Drawing.Size(70, 56)
        Me.cmdStopProses.TabIndex = 17
        Me.cmdStopProses.Text = "Stop Proses"
        Me.cmdStopProses.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(26, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cmdCancelIntegrasi
        '
        Me.cmdCancelIntegrasi.Enabled = False
        Me.cmdCancelIntegrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelIntegrasi.Location = New System.Drawing.Point(685, 76)
        Me.cmdCancelIntegrasi.Name = "cmdCancelIntegrasi"
        Me.cmdCancelIntegrasi.Size = New System.Drawing.Size(111, 56)
        Me.cmdCancelIntegrasi.TabIndex = 18
        Me.cmdCancelIntegrasi.Text = "Cancel Integrasi"
        Me.cmdCancelIntegrasi.UseVisualStyleBackColor = True
        '
        'PanelIntegrasi
        '
        Me.PanelIntegrasi.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelIntegrasi.Controls.Add(Me.PanelSinkronisasi)
        Me.PanelIntegrasi.Controls.Add(Me.lblProsesIntegrasi)
        Me.PanelIntegrasi.Controls.Add(Me.Label2)
        Me.PanelIntegrasi.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.PanelIntegrasi.Location = New System.Drawing.Point(265, 156)
        Me.PanelIntegrasi.Name = "PanelIntegrasi"
        Me.PanelIntegrasi.Size = New System.Drawing.Size(264, 223)
        Me.PanelIntegrasi.TabIndex = 19
        Me.PanelIntegrasi.Visible = False
        '
        'lblProsesIntegrasi
        '
        Me.lblProsesIntegrasi.AutoSize = True
        Me.lblProsesIntegrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProsesIntegrasi.Location = New System.Drawing.Point(3, 193)
        Me.lblProsesIntegrasi.Name = "lblProsesIntegrasi"
        Me.lblProsesIntegrasi.Size = New System.Drawing.Size(131, 16)
        Me.lblProsesIntegrasi.TabIndex = 2
        Me.lblProsesIntegrasi.Text = "Mengintegrasikan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mohon Menunggu"
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(78, 55)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(110, 114)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 0
        '
        'PanelSinkronisasi
        '
        Me.PanelSinkronisasi.BackColor = System.Drawing.Color.YellowGreen
        Me.PanelSinkronisasi.Controls.Add(Me.lblSinkronisasi)
        Me.PanelSinkronisasi.Controls.Add(Me.Label4)
        Me.PanelSinkronisasi.Controls.Add(Me.GunaWinCircleProgressIndicator2)
        Me.PanelSinkronisasi.Location = New System.Drawing.Point(0, 0)
        Me.PanelSinkronisasi.Name = "PanelSinkronisasi"
        Me.PanelSinkronisasi.Size = New System.Drawing.Size(264, 223)
        Me.PanelSinkronisasi.TabIndex = 20
        Me.PanelSinkronisasi.Visible = False
        '
        'lblSinkronisasi
        '
        Me.lblSinkronisasi.AutoSize = True
        Me.lblSinkronisasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinkronisasi.Location = New System.Drawing.Point(3, 193)
        Me.lblSinkronisasi.Name = "lblSinkronisasi"
        Me.lblSinkronisasi.Size = New System.Drawing.Size(120, 16)
        Me.lblSinkronisasi.TabIndex = 2
        Me.lblSinkronisasi.Text = "Mensinkronisasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mohon Menunggu"
        '
        'GunaWinCircleProgressIndicator2
        '
        Me.GunaWinCircleProgressIndicator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator2.Location = New System.Drawing.Point(78, 55)
        Me.GunaWinCircleProgressIndicator2.Name = "GunaWinCircleProgressIndicator2"
        Me.GunaWinCircleProgressIndicator2.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.GunaWinCircleProgressIndicator2.Size = New System.Drawing.Size(110, 114)
        Me.GunaWinCircleProgressIndicator2.TabIndex = 0
        '
        'bgSinkronisasi
        '
        Me.bgSinkronisasi.WorkerReportsProgress = True
        Me.bgSinkronisasi.WorkerSupportsCancellation = True
        '
        'bgIntegrasi
        '
        Me.bgIntegrasi.WorkerReportsProgress = True
        Me.bgIntegrasi.WorkerSupportsCancellation = True
        '
        'dgListUpload
        '
        Me.dgListUpload.AllowUserToAddRows = False
        Me.dgListUpload.AllowUserToDeleteRows = False
        Me.dgListUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListUpload.Location = New System.Drawing.Point(8, 144)
        Me.dgListUpload.Name = "dgListUpload"
        Me.dgListUpload.RowHeadersVisible = False
        Me.dgListUpload.Size = New System.Drawing.Size(784, 251)
        Me.dgListUpload.TabIndex = 20
        '
        'FormIntegrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(801, 430)
        Me.Controls.Add(Me.PanelIntegrasi)
        Me.Controls.Add(Me.cmdCancelIntegrasi)
        Me.Controls.Add(Me.cmdStopProses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdUpload)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdProses)
        Me.Controls.Add(Me.dgListUpload)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FormIntegrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Integrasi Master Data"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIntegrasi.ResumeLayout(False)
        Me.PanelIntegrasi.PerformLayout()
        Me.PanelSinkronisasi.ResumeLayout(False)
        Me.PanelSinkronisasi.PerformLayout()
        CType(Me.dgListUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProses As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdUpload As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdStopProses As System.Windows.Forms.Button
    Friend WithEvents cmdCancelIntegrasi As System.Windows.Forms.Button
    Friend WithEvents PanelIntegrasi As System.Windows.Forms.Panel
    Friend WithEvents lblProsesIntegrasi As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents PanelSinkronisasi As System.Windows.Forms.Panel
    Friend WithEvents lblSinkronisasi As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaWinCircleProgressIndicator2 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents bgSinkronisasi As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgIntegrasi As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgListUpload As System.Windows.Forms.DataGridView

End Class
