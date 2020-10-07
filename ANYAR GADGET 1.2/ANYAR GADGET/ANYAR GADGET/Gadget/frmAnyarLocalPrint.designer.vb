<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnyarLocalPrint
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.crvDokumen = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gbParameter = New System.Windows.Forms.GroupBox()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.txtNoDokumen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbJenisDokumen = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picSettingTemplate = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.gbParameter.SuspendLayout()
        CType(Me.picSettingTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.crvDokumen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1037, 474)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DOCUMENT VIEWER"
        '
        'crvDokumen
        '
        Me.crvDokumen.ActiveViewIndex = -1
        Me.crvDokumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvDokumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvDokumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvDokumen.Location = New System.Drawing.Point(3, 27)
        Me.crvDokumen.Name = "crvDokumen"
        Me.crvDokumen.Size = New System.Drawing.Size(1031, 444)
        Me.crvDokumen.TabIndex = 0
        '
        'gbParameter
        '
        Me.gbParameter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbParameter.AutoSize = True
        Me.gbParameter.Controls.Add(Me.picSettingTemplate)
        Me.gbParameter.Controls.Add(Me.btnProses)
        Me.gbParameter.Controls.Add(Me.txtNoDokumen)
        Me.gbParameter.Controls.Add(Me.Label2)
        Me.gbParameter.Controls.Add(Me.Label1)
        Me.gbParameter.Controls.Add(Me.cmbJenisDokumen)
        Me.gbParameter.Location = New System.Drawing.Point(380, 3)
        Me.gbParameter.Name = "gbParameter"
        Me.gbParameter.Size = New System.Drawing.Size(661, 164)
        Me.gbParameter.TabIndex = 0
        Me.gbParameter.TabStop = False
        '
        'btnProses
        '
        Me.btnProses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(230, 89)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(425, 56)
        Me.btnProses.TabIndex = 4
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'txtNoDokumen
        '
        Me.txtNoDokumen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoDokumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDokumen.Location = New System.Drawing.Point(166, 56)
        Me.txtNoDokumen.Name = "txtNoDokumen"
        Me.txtNoDokumen.Size = New System.Drawing.Size(489, 29)
        Me.txtNoDokumen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NO Dokumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Dokumen"
        '
        'cmbJenisDokumen
        '
        Me.cmbJenisDokumen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbJenisDokumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisDokumen.FormattingEnabled = True
        Me.cmbJenisDokumen.Location = New System.Drawing.Point(166, 15)
        Me.cmbJenisDokumen.Name = "cmbJenisDokumen"
        Me.cmbJenisDokumen.Size = New System.Drawing.Size(489, 32)
        Me.cmbJenisDokumen.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ANYAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "LOCAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRINT SERVICES"
        '
        'picSettingTemplate
        '
        Me.picSettingTemplate.BackColor = System.Drawing.Color.Transparent
        Me.picSettingTemplate.BaseColor = System.Drawing.Color.Black
        Me.picSettingTemplate.Image = Global.ANYAR_GADGET.My.Resources.Resources.Setting_Icon
        Me.picSettingTemplate.Location = New System.Drawing.Point(166, 90)
        Me.picSettingTemplate.Name = "picSettingTemplate"
        Me.picSettingTemplate.Size = New System.Drawing.Size(56, 55)
        Me.picSettingTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSettingTemplate.TabIndex = 5
        Me.picSettingTemplate.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Printer
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmAnyarLocalPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 631)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbParameter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(229, 3)
        Me.Name = "frmAnyarLocalPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AnyarLocalPrint"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbParameter.ResumeLayout(False)
        Me.gbParameter.PerformLayout()
        CType(Me.picSettingTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbParameter As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoDokumen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisDokumen As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents crvDokumen As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picSettingTemplate As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
