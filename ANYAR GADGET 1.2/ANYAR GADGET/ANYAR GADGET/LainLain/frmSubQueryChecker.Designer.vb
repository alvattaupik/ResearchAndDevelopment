<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubQueryChecker
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvRootCause = New System.Windows.Forms.DataGridView()
        Me.dgvFullfillmentDetailKey = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNamaCustomer = New System.Windows.Forms.TextBox()
        Me.trxTransactionID = New System.Windows.Forms.TextBox()
        Me.trxTransactionKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.RichTextBox()
        Me.txtProductKey = New System.Windows.Forms.TextBox()
        Me.txtSourceDetailkey = New System.Windows.Forms.TextBox()
        Me.txtFullfillmentDetailkey = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRollbackQuery = New System.Windows.Forms.Button()
        Me.btnFixQuery = New System.Windows.Forms.Button()
        Me.txtQuerybuilder = New System.Windows.Forms.RichTextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvRootCause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFullfillmentDetailKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(353, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 442)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgvFullfillmentDetailKey)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fullfillment Detail Key"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvRootCause)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 214)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Root Cause"
        '
        'dgvRootCause
        '
        Me.dgvRootCause.AllowUserToAddRows = False
        Me.dgvRootCause.AllowUserToDeleteRows = False
        Me.dgvRootCause.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRootCause.Location = New System.Drawing.Point(9, 25)
        Me.dgvRootCause.Name = "dgvRootCause"
        Me.dgvRootCause.ReadOnly = True
        Me.dgvRootCause.RowHeadersVisible = False
        Me.dgvRootCause.Size = New System.Drawing.Size(402, 183)
        Me.dgvRootCause.TabIndex = 1
        '
        'dgvFullfillmentDetailKey
        '
        Me.dgvFullfillmentDetailKey.AllowUserToAddRows = False
        Me.dgvFullfillmentDetailKey.AllowUserToDeleteRows = False
        Me.dgvFullfillmentDetailKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFullfillmentDetailKey.Location = New System.Drawing.Point(6, 9)
        Me.dgvFullfillmentDetailKey.Name = "dgvFullfillmentDetailKey"
        Me.dgvFullfillmentDetailKey.ReadOnly = True
        Me.dgvFullfillmentDetailKey.RowHeadersVisible = False
        Me.dgvFullfillmentDetailKey.Size = New System.Drawing.Size(418, 178)
        Me.dgvFullfillmentDetailKey.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDetails)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetails
        '
        Me.dgvDetails.AllowUserToAddRows = False
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(6, 6)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(418, 401)
        Me.dgvDetails.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNamaCustomer)
        Me.GroupBox2.Controls.Add(Me.trxTransactionID)
        Me.GroupBox2.Controls.Add(Me.trxTransactionKey)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 106)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parameter"
        '
        'txtNamaCustomer
        '
        Me.txtNamaCustomer.Location = New System.Drawing.Point(122, 69)
        Me.txtNamaCustomer.Name = "txtNamaCustomer"
        Me.txtNamaCustomer.Size = New System.Drawing.Size(216, 20)
        Me.txtNamaCustomer.TabIndex = 5
        '
        'trxTransactionID
        '
        Me.trxTransactionID.Location = New System.Drawing.Point(122, 46)
        Me.trxTransactionID.Name = "trxTransactionID"
        Me.trxTransactionID.Size = New System.Drawing.Size(216, 20)
        Me.trxTransactionID.TabIndex = 4
        '
        'trxTransactionKey
        '
        Me.trxTransactionKey.Location = New System.Drawing.Point(122, 23)
        Me.trxTransactionKey.Name = "trxTransactionKey"
        Me.trxTransactionKey.Size = New System.Drawing.Size(216, 20)
        Me.trxTransactionKey.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaction ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction Key"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtNamaBarang)
        Me.GroupBox1.Controls.Add(Me.txtProductKey)
        Me.GroupBox1.Controls.Add(Me.txtSourceDetailkey)
        Me.GroupBox1.Controls.Add(Me.txtFullfillmentDetailkey)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 170)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameters"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(119, 141)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(219, 20)
        Me.txtQty.TabIndex = 9
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(119, 95)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(219, 41)
        Me.txtNamaBarang.TabIndex = 8
        Me.txtNamaBarang.Text = ""
        '
        'txtProductKey
        '
        Me.txtProductKey.Location = New System.Drawing.Point(119, 69)
        Me.txtProductKey.Name = "txtProductKey"
        Me.txtProductKey.ReadOnly = True
        Me.txtProductKey.Size = New System.Drawing.Size(219, 20)
        Me.txtProductKey.TabIndex = 7
        '
        'txtSourceDetailkey
        '
        Me.txtSourceDetailkey.Location = New System.Drawing.Point(119, 43)
        Me.txtSourceDetailkey.Name = "txtSourceDetailkey"
        Me.txtSourceDetailkey.ReadOnly = True
        Me.txtSourceDetailkey.Size = New System.Drawing.Size(219, 20)
        Me.txtSourceDetailkey.TabIndex = 6
        '
        'txtFullfillmentDetailkey
        '
        Me.txtFullfillmentDetailkey.Location = New System.Drawing.Point(119, 17)
        Me.txtFullfillmentDetailkey.Name = "txtFullfillmentDetailkey"
        Me.txtFullfillmentDetailkey.ReadOnly = True
        Me.txtFullfillmentDetailkey.Size = New System.Drawing.Size(219, 20)
        Me.txtFullfillmentDetailkey.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Product Key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Source Detail Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fullfillment Detail Key"
        '
        'btnRollbackQuery
        '
        Me.btnRollbackQuery.Location = New System.Drawing.Point(2, 301)
        Me.btnRollbackQuery.Name = "btnRollbackQuery"
        Me.btnRollbackQuery.Size = New System.Drawing.Size(114, 44)
        Me.btnRollbackQuery.TabIndex = 4
        Me.btnRollbackQuery.Text = "Build Rollback Query"
        Me.btnRollbackQuery.UseVisualStyleBackColor = True
        '
        'btnFixQuery
        '
        Me.btnFixQuery.Location = New System.Drawing.Point(122, 301)
        Me.btnFixQuery.Name = "btnFixQuery"
        Me.btnFixQuery.Size = New System.Drawing.Size(114, 44)
        Me.btnFixQuery.TabIndex = 5
        Me.btnFixQuery.Text = "Build Fix Query"
        Me.btnFixQuery.UseVisualStyleBackColor = True
        '
        'txtQuerybuilder
        '
        Me.txtQuerybuilder.CausesValidation = False
        Me.txtQuerybuilder.Location = New System.Drawing.Point(3, 353)
        Me.txtQuerybuilder.Name = "txtQuerybuilder"
        Me.txtQuerybuilder.Size = New System.Drawing.Size(344, 89)
        Me.txtQuerybuilder.TabIndex = 6
        Me.txtQuerybuilder.Text = ""
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(242, 301)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(99, 44)
        Me.btnExecute.TabIndex = 7
        Me.btnExecute.Text = "Fix This Error"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'frmSubQueryChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 454)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtQuerybuilder)
        Me.Controls.Add(Me.btnFixQuery)
        Me.Controls.Add(Me.btnRollbackQuery)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSubQueryChecker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSubQueryChecker"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvRootCause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFullfillmentDetailKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents trxTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents trxTransactionKey As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvFullfillmentDetailKey As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRootCause As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.RichTextBox
    Friend WithEvents txtProductKey As System.Windows.Forms.TextBox
    Friend WithEvents txtSourceDetailkey As System.Windows.Forms.TextBox
    Friend WithEvents txtFullfillmentDetailkey As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRollbackQuery As System.Windows.Forms.Button
    Friend WithEvents btnFixQuery As System.Windows.Forms.Button
    Friend WithEvents txtQuerybuilder As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
End Class
