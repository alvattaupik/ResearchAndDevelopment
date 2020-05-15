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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgListUpload = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblJumlahItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblJumlahUpload = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdLogoff = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblJumlahItem2 = New System.Windows.Forms.Label()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgListUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(543, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cek Perubahan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgListUpload
        '
        Me.dgListUpload.AllowUserToAddRows = False
        Me.dgListUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListUpload.Location = New System.Drawing.Point(13, 84)
        Me.dgListUpload.Name = "dgListUpload"
        Me.dgListUpload.Size = New System.Drawing.Size(833, 265)
        Me.dgListUpload.TabIndex = 5
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblJumlahItem})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(858, 26)
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(651, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 69)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblJumlahUpload
        '
        Me.lblJumlahUpload.AutoSize = True
        Me.lblJumlahUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahUpload.Location = New System.Drawing.Point(657, 368)
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
        Me.Label1.Location = New System.Drawing.Point(205, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Integrasi Master Data"
        '
        'cmdLogoff
        '
        Me.cmdLogoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogoff.Location = New System.Drawing.Point(754, 6)
        Me.cmdLogoff.Name = "cmdLogoff"
        Me.cmdLogoff.Size = New System.Drawing.Size(92, 68)
        Me.cmdLogoff.TabIndex = 11
        Me.cmdLogoff.Text = "Logoff"
        Me.cmdLogoff.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EcomDTW.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'lblJumlahItem2
        '
        Me.lblJumlahItem2.AutoSize = True
        Me.lblJumlahItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahItem2.Location = New System.Drawing.Point(782, 368)
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
        Me.lblDari.Location = New System.Drawing.Point(714, 368)
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
        Me.Label3.Location = New System.Drawing.Point(527, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mengupload:"
        '
        'FormIntegrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 391)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDari)
        Me.Controls.Add(Me.lblJumlahItem2)
        Me.Controls.Add(Me.cmdLogoff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblJumlahUpload)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgListUpload)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgListUpload As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblJumlahItem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblJumlahUpload As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdLogoff As System.Windows.Forms.Button
    Friend WithEvents lblJumlahItem2 As System.Windows.Forms.Label
    Friend WithEvents lblDari As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
