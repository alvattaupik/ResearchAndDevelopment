<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTampilkanSurat
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
        Me.crvTampilkanSurat = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvTampilkanSurat
        '
        Me.crvTampilkanSurat.ActiveViewIndex = -1
        Me.crvTampilkanSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvTampilkanSurat.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvTampilkanSurat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvTampilkanSurat.Location = New System.Drawing.Point(0, 0)
        Me.crvTampilkanSurat.Name = "crvTampilkanSurat"
        Me.crvTampilkanSurat.Size = New System.Drawing.Size(787, 462)
        Me.crvTampilkanSurat.TabIndex = 1
        '
        'frmTampilkanSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 462)
        Me.Controls.Add(Me.crvTampilkanSurat)
        Me.Name = "frmTampilkanSurat"
        Me.Text = "Tampilkan Surat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvTampilkanSurat As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
