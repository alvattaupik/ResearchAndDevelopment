﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataUserALL
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
        Me.txtCariUer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgDaftarUserSAp = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgDaftarUserSAp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari User SAP"
        '
        'txtCariUer
        '
        Me.txtCariUer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariUer.Location = New System.Drawing.Point(155, 39)
        Me.txtCariUer.Name = "txtCariUer"
        Me.txtCariUer.Size = New System.Drawing.Size(385, 22)
        Me.txtCariUer.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(506, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgDaftarUserSAp
        '
        Me.dgDaftarUserSAp.AllowUserToAddRows = False
        Me.dgDaftarUserSAp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDaftarUserSAp.Location = New System.Drawing.Point(155, 72)
        Me.dgDaftarUserSAp.Name = "dgDaftarUserSAp"
        Me.dgDaftarUserSAp.ReadOnly = True
        Me.dgDaftarUserSAp.Size = New System.Drawing.Size(385, 143)
        Me.dgDaftarUserSAp.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISTER.My.Resources.Resources._743px_SAP_Logo_svg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormDataUserSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 227)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgDaftarUserSAp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCariUer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDataUserSAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataUserSAP"
        CType(Me.dgDaftarUserSAp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariUer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgDaftarUserSAp As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
