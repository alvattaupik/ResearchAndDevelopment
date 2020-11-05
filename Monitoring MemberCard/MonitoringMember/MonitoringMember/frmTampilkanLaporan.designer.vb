<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTampilkanLaporan
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
        Me.crvTampilkanSurat.Size = New System.Drawing.Size(284, 261)
        Me.crvTampilkanSurat.TabIndex = 0
        '
        'frmTampilkanLaporan
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.crvTampilkanSurat)
        Me.Name = "frmTampilkanLaporan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvTampilkanLaporan As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crvTampilkanSurat As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
