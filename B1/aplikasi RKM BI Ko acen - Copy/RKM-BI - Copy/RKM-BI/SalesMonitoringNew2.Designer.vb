<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesMonitoringNew2
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
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChartPenjualan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTotalALL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ChartPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTampilkanGrafik)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpAkhir)
        Me.GroupBox1.Controls.Add(Me.dtpAwal)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 52)
        Me.GroupBox1.TabIndex = 91
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
        'dtpAkhir
        '
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAkhir.Location = New System.Drawing.Point(182, 19)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(100, 20)
        Me.dtpAkhir.TabIndex = 91
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAwal.Location = New System.Drawing.Point(64, 20)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(100, 20)
        Me.dtpAwal.TabIndex = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTotalALL)
        Me.GroupBox2.Controls.Add(Me.ChartPenjualan)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1159, 383)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        '
        'ChartPenjualan
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartPenjualan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChartPenjualan.Legends.Add(Legend1)
        Me.ChartPenjualan.Location = New System.Drawing.Point(14, 19)
        Me.ChartPenjualan.Name = "ChartPenjualan"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.LabelBorderWidth = 2
        Series1.LabelFormat = "Rp ##,0"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartPenjualan.Series.Add(Series1)
        Me.ChartPenjualan.Size = New System.Drawing.Size(1139, 327)
        Me.ChartPenjualan.TabIndex = 0
        Me.ChartPenjualan.Text = "Chart1"
        '
        'txtTotalALL
        '
        Me.txtTotalALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalALL.Location = New System.Drawing.Point(421, 346)
        Me.txtTotalALL.Multiline = True
        Me.txtTotalALL.Name = "txtTotalALL"
        Me.txtTotalALL.Size = New System.Drawing.Size(383, 31)
        Me.txtTotalALL.TabIndex = 1
        Me.txtTotalALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL"
        '
        'SalesMonitoringNew2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 447)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalesMonitoringNew2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesMonitoringNew2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ChartPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTampilkanGrafik As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChartPenjualan As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalALL As System.Windows.Forms.TextBox
End Class
