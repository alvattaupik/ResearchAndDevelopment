﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHelp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgDaftarBantuan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCariBantuan = New System.Windows.Forms.TextBox()
        Me.cmdLihat = New Guna.UI.WinForms.GunaGradientButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDaftarBantuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.NER.My.Resources.Resources.Vector_2
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 78)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAFTAR BANTUAN"
        '
        'dgDaftarBantuan
        '
        Me.dgDaftarBantuan.AllowUserToAddRows = False
        Me.dgDaftarBantuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarBantuan.Location = New System.Drawing.Point(6, 113)
        Me.dgDaftarBantuan.Name = "dgDaftarBantuan"
        Me.dgDaftarBantuan.ReadOnly = True
        Me.dgDaftarBantuan.Size = New System.Drawing.Size(403, 179)
        Me.dgDaftarBantuan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cari Bantuan"
        '
        'txtCariBantuan
        '
        Me.txtCariBantuan.Location = New System.Drawing.Point(159, 87)
        Me.txtCariBantuan.Name = "txtCariBantuan"
        Me.txtCariBantuan.Size = New System.Drawing.Size(249, 20)
        Me.txtCariBantuan.TabIndex = 3
        '
        'cmdLihat
        '
        Me.cmdLihat.AnimationHoverSpeed = 0.07!
        Me.cmdLihat.AnimationSpeed = 0.03!
        Me.cmdLihat.BackColor = System.Drawing.Color.Transparent
        Me.cmdLihat.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.cmdLihat.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.cmdLihat.BorderColor = System.Drawing.Color.Black
        Me.cmdLihat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdLihat.FocusedColor = System.Drawing.Color.Empty
        Me.cmdLihat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmdLihat.ForeColor = System.Drawing.Color.White
        Me.cmdLihat.Image = Nothing
        Me.cmdLihat.ImageSize = New System.Drawing.Size(20, 20)
        Me.cmdLihat.Location = New System.Drawing.Point(6, 320)
        Me.cmdLihat.Name = "cmdLihat"
        Me.cmdLihat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.cmdLihat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdLihat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.cmdLihat.OnHoverForeColor = System.Drawing.Color.White
        Me.cmdLihat.OnHoverImage = Nothing
        Me.cmdLihat.OnPressedColor = System.Drawing.Color.Black
        Me.cmdLihat.Radius = 2
        Me.cmdLihat.Size = New System.Drawing.Size(403, 44)
        Me.cmdLihat.TabIndex = 36
        Me.cmdLihat.Text = "Lihat"
        Me.cmdLihat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 366)
        Me.Controls.Add(Me.cmdLihat)
        Me.Controls.Add(Me.txtCariBantuan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgDaftarBantuan)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHelp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDaftarBantuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgDaftarBantuan As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCariBantuan As System.Windows.Forms.TextBox
    Friend WithEvents cmdLihat As Guna.UI.WinForms.GunaGradientButton
End Class
