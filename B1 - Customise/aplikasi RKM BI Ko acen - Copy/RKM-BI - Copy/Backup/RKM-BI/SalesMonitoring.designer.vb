<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesMonitoringapter
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesMonitoringapter))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridViewTotal = New System.Windows.Forms.DataGridView
        Me.zgc = New ZedGraph.ZedGraphControl
        Me.zgc30 = New ZedGraph.ZedGraphControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Aabm = New System.Windows.Forms.Label
        Me.AAyani = New System.Windows.Forms.Label
        Me.AKopo = New System.Windows.Forms.Label
        Me.ACibiru = New System.Windows.Forms.Label
        Me.ACibabat = New System.Windows.Forms.Label
        Me.AGarut = New System.Windows.Forms.Label
        Me.ACirebon = New System.Windows.Forms.Label
        Me.totToday = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.ASumedang = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ACiparay = New System.Windows.Forms.Label
        Me.ARancaekek = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ATasikmalaya = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.APamanukan = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.DataGridViewTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "today"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(863, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "30"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(480, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 22)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "yesterday"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(334, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 22)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "30 days"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(407, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 22)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "bulan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridViewTotal
        '
        Me.DataGridViewTotal.AllowUserToAddRows = False
        Me.DataGridViewTotal.AllowUserToDeleteRows = False
        Me.DataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTotal.Location = New System.Drawing.Point(480, 136)
        Me.DataGridViewTotal.Name = "DataGridViewTotal"
        Me.DataGridViewTotal.Size = New System.Drawing.Size(37, 29)
        Me.DataGridViewTotal.TabIndex = 61
        '
        'zgc
        '
        Me.zgc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zgc.Location = New System.Drawing.Point(12, 32)
        Me.zgc.Name = "zgc"
        Me.zgc.ScrollGrace = 0
        Me.zgc.ScrollMaxX = 0
        Me.zgc.ScrollMaxY = 0
        Me.zgc.ScrollMaxY2 = 0
        Me.zgc.ScrollMinX = 0
        Me.zgc.ScrollMinY = 0
        Me.zgc.ScrollMinY2 = 0
        Me.zgc.Size = New System.Drawing.Size(1172, 240)
        Me.zgc.TabIndex = 62
        '
        'zgc30
        '
        Me.zgc30.Location = New System.Drawing.Point(12, 340)
        Me.zgc30.Name = "zgc30"
        Me.zgc30.ScrollGrace = 0
        Me.zgc30.ScrollMaxX = 0
        Me.zgc30.ScrollMaxY = 0
        Me.zgc30.ScrollMaxY2 = 0
        Me.zgc30.ScrollMinX = 0
        Me.zgc30.ScrollMinY = 0
        Me.zgc30.ScrollMinY2 = 0
        Me.zgc30.Size = New System.Drawing.Size(970, 183)
        Me.zgc30.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "ABM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "AYANI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "KOPO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Lime
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(324, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "CIBIRU"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Cyan
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "CIBABAT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(501, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "GARUT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Fuchsia
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(590, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 23)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "CIREBON"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Aabm
        '
        Me.Aabm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aabm.Location = New System.Drawing.Point(64, 299)
        Me.Aabm.Name = "Aabm"
        Me.Aabm.Size = New System.Drawing.Size(73, 16)
        Me.Aabm.TabIndex = 71
        Me.Aabm.Text = "0"
        Me.Aabm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AAyani
        '
        Me.AAyani.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAyani.Location = New System.Drawing.Point(150, 299)
        Me.AAyani.Name = "AAyani"
        Me.AAyani.Size = New System.Drawing.Size(73, 16)
        Me.AAyani.TabIndex = 72
        Me.AAyani.Text = "0"
        Me.AAyani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AKopo
        '
        Me.AKopo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AKopo.Location = New System.Drawing.Point(237, 299)
        Me.AKopo.Name = "AKopo"
        Me.AKopo.Size = New System.Drawing.Size(73, 16)
        Me.AKopo.TabIndex = 73
        Me.AKopo.Text = "0"
        Me.AKopo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ACibiru
        '
        Me.ACibiru.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACibiru.Location = New System.Drawing.Point(324, 299)
        Me.ACibiru.Name = "ACibiru"
        Me.ACibiru.Size = New System.Drawing.Size(73, 16)
        Me.ACibiru.TabIndex = 74
        Me.ACibiru.Text = "0"
        Me.ACibiru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ACibabat
        '
        Me.ACibabat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACibabat.Location = New System.Drawing.Point(413, 299)
        Me.ACibabat.Name = "ACibabat"
        Me.ACibabat.Size = New System.Drawing.Size(73, 16)
        Me.ACibabat.TabIndex = 75
        Me.ACibabat.Text = "0"
        Me.ACibabat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AGarut
        '
        Me.AGarut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGarut.Location = New System.Drawing.Point(501, 299)
        Me.AGarut.Name = "AGarut"
        Me.AGarut.Size = New System.Drawing.Size(73, 16)
        Me.AGarut.TabIndex = 76
        Me.AGarut.Text = "0"
        Me.AGarut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ACirebon
        '
        Me.ACirebon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACirebon.Location = New System.Drawing.Point(589, 299)
        Me.ACirebon.Name = "ACirebon"
        Me.ACirebon.Size = New System.Drawing.Size(73, 16)
        Me.ACirebon.TabIndex = 77
        Me.ACirebon.Text = "0"
        Me.ACirebon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totToday
        '
        Me.totToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totToday.Location = New System.Drawing.Point(12, 315)
        Me.totToday.Name = "totToday"
        Me.totToday.Size = New System.Drawing.Size(970, 22)
        Me.totToday.TabIndex = 78
        Me.totToday.Text = "0"
        Me.totToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(212, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(369, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 81
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(187, 7)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Period :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(170, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "-"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(293, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 85
        Me.Button7.Text = "View"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ASumedang
        '
        Me.ASumedang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASumedang.Location = New System.Drawing.Point(679, 299)
        Me.ASumedang.Name = "ASumedang"
        Me.ASumedang.Size = New System.Drawing.Size(73, 16)
        Me.ASumedang.TabIndex = 86
        Me.ASumedang.Text = "0"
        Me.ASumedang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(678, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 23)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "SUMEDANG"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(773, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 23)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "CIPARAY"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ACiparay
        '
        Me.ACiparay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACiparay.Location = New System.Drawing.Point(773, 299)
        Me.ACiparay.Name = "ACiparay"
        Me.ACiparay.Size = New System.Drawing.Size(73, 16)
        Me.ACiparay.TabIndex = 88
        Me.ACiparay.Text = "0"
        Me.ACiparay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ARancaekek
        '
        Me.ARancaekek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARancaekek.Location = New System.Drawing.Point(860, 298)
        Me.ARancaekek.Name = "ARancaekek"
        Me.ARancaekek.Size = New System.Drawing.Size(88, 17)
        Me.ARancaekek.TabIndex = 90
        Me.ARancaekek.Text = "0"
        Me.ARancaekek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Orange
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(859, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 23)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "RANCAEKEK"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ATasikmalaya
        '
        Me.ATasikmalaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATasikmalaya.Location = New System.Drawing.Point(962, 298)
        Me.ATasikmalaya.Name = "ATasikmalaya"
        Me.ATasikmalaya.Size = New System.Drawing.Size(88, 17)
        Me.ATasikmalaya.TabIndex = 92
        Me.ATasikmalaya.Text = "0"
        Me.ATasikmalaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(1071, 275)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 23)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "PAMANUKAN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'APamanukan
        '
        Me.APamanukan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APamanukan.Location = New System.Drawing.Point(1072, 298)
        Me.APamanukan.Name = "APamanukan"
        Me.APamanukan.Size = New System.Drawing.Size(88, 17)
        Me.APamanukan.TabIndex = 94
        Me.APamanukan.Text = "0"
        Me.APamanukan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Moccasin
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(961, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 23)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "TASIKMALAYA"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalesMonitoringapter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1196, 531)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.APamanukan)
        Me.Controls.Add(Me.ATasikmalaya)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ARancaekek)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ACiparay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ASumedang)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.zgc30)
        Me.Controls.Add(Me.totToday)
        Me.Controls.Add(Me.ACirebon)
        Me.Controls.Add(Me.AGarut)
        Me.Controls.Add(Me.ACibabat)
        Me.Controls.Add(Me.ACibiru)
        Me.Controls.Add(Me.AKopo)
        Me.Controls.Add(Me.AAyani)
        Me.Controls.Add(Me.Aabm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.zgc)
        Me.Controls.Add(Me.DataGridViewTotal)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesMonitoringapter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Monitoring"
        CType(Me.DataGridViewTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTotal As System.Windows.Forms.DataGridView
    Friend WithEvents zgc As ZedGraph.ZedGraphControl
    Friend WithEvents zgc30 As ZedGraph.ZedGraphControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Aabm As System.Windows.Forms.Label
    Friend WithEvents AAyani As System.Windows.Forms.Label
    Friend WithEvents AKopo As System.Windows.Forms.Label
    Friend WithEvents ACibiru As System.Windows.Forms.Label
    Friend WithEvents ACibabat As System.Windows.Forms.Label
    Friend WithEvents AGarut As System.Windows.Forms.Label
    Friend WithEvents ACirebon As System.Windows.Forms.Label
    Friend WithEvents totToday As System.Windows.Forms.Label
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ASumedang As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ACiparay As System.Windows.Forms.Label
    Friend WithEvents ARancaekek As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ATasikmalaya As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents APamanukan As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
