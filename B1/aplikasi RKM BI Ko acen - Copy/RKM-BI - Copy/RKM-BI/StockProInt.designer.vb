<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockProInt
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.h1 = New System.Windows.Forms.CheckBox
        Me.h2 = New System.Windows.Forms.CheckBox
        Me.h3 = New System.Windows.Forms.CheckBox
        Me.h4 = New System.Windows.Forms.CheckBox
        Me.h5 = New System.Windows.Forms.CheckBox
        Me.h6 = New System.Windows.Forms.CheckBox
        Me.h7 = New System.Windows.Forms.CheckBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.h8 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 5
        Me.DataGridView1.Size = New System.Drawing.Size(781, 328)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cabang :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ABM (Anyar Building Material)", "RKM Ayani", "RKM Cibabat", "RKM Cibiru", "RKM Cirebon", "RKM Garut", "RKM Kopo", "RKM Sumedang"})
        Me.ComboBox1.Location = New System.Drawing.Point(78, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hari Cek :"
        '
        'h1
        '
        Me.h1.AutoSize = True
        Me.h1.Location = New System.Drawing.Point(78, 33)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(56, 17)
        Me.h1.TabIndex = 8
        Me.h1.Text = "Senin"
        Me.h1.UseVisualStyleBackColor = True
        '
        'h2
        '
        Me.h2.AutoSize = True
        Me.h2.Location = New System.Drawing.Point(145, 33)
        Me.h2.Name = "h2"
        Me.h2.Size = New System.Drawing.Size(59, 17)
        Me.h2.TabIndex = 9
        Me.h2.Text = "Selasa"
        Me.h2.UseVisualStyleBackColor = True
        '
        'h3
        '
        Me.h3.AutoSize = True
        Me.h3.Location = New System.Drawing.Point(210, 33)
        Me.h3.Name = "h3"
        Me.h3.Size = New System.Drawing.Size(53, 17)
        Me.h3.TabIndex = 10
        Me.h3.Text = "Rabu"
        Me.h3.UseVisualStyleBackColor = True
        '
        'h4
        '
        Me.h4.AutoSize = True
        Me.h4.Location = New System.Drawing.Point(284, 33)
        Me.h4.Name = "h4"
        Me.h4.Size = New System.Drawing.Size(58, 17)
        Me.h4.TabIndex = 11
        Me.h4.Text = "Kamis"
        Me.h4.UseVisualStyleBackColor = True
        '
        'h5
        '
        Me.h5.AutoSize = True
        Me.h5.Location = New System.Drawing.Point(78, 56)
        Me.h5.Name = "h5"
        Me.h5.Size = New System.Drawing.Size(61, 17)
        Me.h5.TabIndex = 12
        Me.h5.Text = "Jum'at"
        Me.h5.UseVisualStyleBackColor = True
        '
        'h6
        '
        Me.h6.AutoSize = True
        Me.h6.Location = New System.Drawing.Point(145, 56)
        Me.h6.Name = "h6"
        Me.h6.Size = New System.Drawing.Size(56, 17)
        Me.h6.TabIndex = 13
        Me.h6.Text = "Sabtu"
        Me.h6.UseVisualStyleBackColor = True
        '
        'h7
        '
        Me.h7.AutoSize = True
        Me.h7.Location = New System.Drawing.Point(210, 56)
        Me.h7.Name = "h7"
        Me.h7.Size = New System.Drawing.Size(68, 17)
        Me.h7.TabIndex = 14
        Me.h7.Text = "Minggu"
        Me.h7.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(438, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(99, 50)
        Me.DataGridView2.TabIndex = 15
        Me.DataGridView2.Visible = False
        '
        'h8
        '
        Me.h8.AutoSize = True
        Me.h8.Location = New System.Drawing.Point(284, 56)
        Me.h8.Name = "h8"
        Me.h8.Size = New System.Drawing.Size(65, 17)
        Me.h8.TabIndex = 16
        Me.h8.Text = "All Day"
        Me.h8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(680, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Preview && Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 442)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Upload Min Max Stock From Excel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'StockProInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 477)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.h8)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.h7)
        Me.Controls.Add(Me.h6)
        Me.Controls.Add(Me.h5)
        Me.Controls.Add(Me.h4)
        Me.Controls.Add(Me.h3)
        Me.Controls.Add(Me.h2)
        Me.Controls.Add(Me.h1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Gisha", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StockProInt"
        Me.ShowIcon = False
        Me.Text = "Min Max Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents h1 As System.Windows.Forms.CheckBox
    Friend WithEvents h2 As System.Windows.Forms.CheckBox
    Friend WithEvents h3 As System.Windows.Forms.CheckBox
    Friend WithEvents h4 As System.Windows.Forms.CheckBox
    Friend WithEvents h5 As System.Windows.Forms.CheckBox
    Friend WithEvents h6 As System.Windows.Forms.CheckBox
    Friend WithEvents h7 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents h8 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
