<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesMonitoringNew
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTampilkanGrafik = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChartPenjualan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTampilkanGrafik)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 52)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter"
        '
        'cmdTampilkanGrafik
        '
        Me.cmdTampilkanGrafik.Location = New System.Drawing.Point(288, 17)
        Me.cmdTampilkanGrafik.Name = "cmdTampilkanGrafik"
        Me.cmdTampilkanGrafik.Size = New System.Drawing.Size(75, 23)
        Me.cmdTampilkanGrafik.TabIndex = 93
        Me.cmdTampilkanGrafik.Text = "View"
        Me.cmdTampilkanGrafik.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Period :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(182, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 91
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 90
        '
        'ChartPenjualan
        '
        Me.ChartPenjualan.BackColor = System.Drawing.Color.MistyRose
        Me.ChartPenjualan.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Me.ChartPenjualan.BackImageTransparentColor = System.Drawing.Color.White
        Me.ChartPenjualan.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.Format = "##,0"
        ChartArea1.Name = "ChartArea1"
        Me.ChartPenjualan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartPenjualan.Legends.Add(Legend1)
        Me.ChartPenjualan.Location = New System.Drawing.Point(10, 19)
        Me.ChartPenjualan.Name = "ChartPenjualan"
        Me.ChartPenjualan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.LabelFormat = "Rp ##,0"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Series1.SmartLabelStyle.IsOverlappedHidden = False
        Series1.SmartLabelStyle.MovingDirection = CType(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center), System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)
        Me.ChartPenjualan.Series.Add(Series1)
        Me.ChartPenjualan.Size = New System.Drawing.Size(1146, 310)
        Me.ChartPenjualan.TabIndex = 70
        Me.ChartPenjualan.Text = "TURN OVER STORE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ChartPenjualan)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1170, 349)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        '
        'SalesMonitoringNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalesMonitoringNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SalesMonitoringNew"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ChartPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTampilkanGrafik As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChartPenjualan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
