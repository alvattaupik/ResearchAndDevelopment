﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsePegawai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariPegawai = New System.Windows.Forms.TextBox()
        Me.dgvListPegawai = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari Master Pegawai"
        '
        'txtCariPegawai
        '
        Me.txtCariPegawai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCariPegawai.Location = New System.Drawing.Point(183, 4)
        Me.txtCariPegawai.Name = "txtCariPegawai"
        Me.txtCariPegawai.Size = New System.Drawing.Size(328, 20)
        Me.txtCariPegawai.TabIndex = 2
        '
        'dgvListPegawai
        '
        Me.dgvListPegawai.AllowUserToAddRows = False
        Me.dgvListPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListPegawai.Location = New System.Drawing.Point(1, 38)
        Me.dgvListPegawai.Name = "dgvListPegawai"
        Me.dgvListPegawai.ReadOnly = True
        Me.dgvListPegawai.Size = New System.Drawing.Size(510, 253)
        Me.dgvListPegawai.TabIndex = 3
        '
        'frmBrowsePegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 288)
        Me.Controls.Add(Me.dgvListPegawai)
        Me.Controls.Add(Me.txtCariPegawai)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBrowsePegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBrowsePegawai"
        CType(Me.dgvListPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariPegawai As System.Windows.Forms.TextBox
    Friend WithEvents dgvListPegawai As System.Windows.Forms.DataGridView
End Class