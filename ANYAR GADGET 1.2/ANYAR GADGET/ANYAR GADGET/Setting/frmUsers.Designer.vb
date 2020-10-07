<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAktif = New System.Windows.Forms.CheckBox()
        Me.btnAksi = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaPegawai = New System.Windows.Forms.TextBox()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvHeaderMenu = New System.Windows.Forms.DataGridView()
        Me.cmMenuHeader = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyHeaderToAnotherUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCariHeader = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdateHdrMenu = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDetailMenu = New System.Windows.Forms.DataGridView()
        Me.cmDetailMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyDetailMenuToAnotherUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbHeaderMenu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateDetailMenu = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnUpdateFormObject = New System.Windows.Forms.Button()
        Me.dgvDetailForm = New System.Windows.Forms.DataGridView()
        Me.cmFormObject = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyFormObjectToAnotherUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbListForm = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnUpdateLocationControl = New System.Windows.Forms.Button()
        Me.dgvLocationControl = New System.Windows.Forms.DataGridView()
        Me.cmLocationControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyLocationControlToAnotherUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmCopyAlltoAllUsers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyAllControlToAnotherUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRefreshHeaderMenu = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.picBrowsePegawai = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.picNew = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.picFind = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvHeaderMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmMenuHeader.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetailMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmDetailMenu.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvDetailForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmFormObject.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvLocationControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmLocationControl.SuspendLayout()
        Me.cmCopyAlltoAllUsers.SuspendLayout()
        CType(Me.btnRefreshHeaderMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrowsePegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.picBrowsePegawai)
        Me.GroupBox1.Controls.Add(Me.cmbLocation)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbManager)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.picNew)
        Me.GroupBox1.Controls.Add(Me.cboAktif)
        Me.GroupBox1.Controls.Add(Me.picFind)
        Me.GroupBox1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnAksi)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNamaPegawai)
        Me.GroupBox1.Controls.Add(Me.txtEmployee)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users Data"
        '
        'cmbLocation
        '
        Me.cmbLocation.Enabled = False
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(296, 95)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(195, 21)
        Me.cmbLocation.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Location"
        '
        'cmbManager
        '
        Me.cmbManager.Enabled = False
        Me.cmbManager.FormattingEnabled = True
        Me.cmbManager.Location = New System.Drawing.Point(296, 70)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(194, 21)
        Me.cmbManager.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Manager"
        '
        'cboAktif
        '
        Me.cboAktif.AutoSize = True
        Me.cboAktif.Enabled = False
        Me.cboAktif.Location = New System.Drawing.Point(296, 174)
        Me.cboAktif.Name = "cboAktif"
        Me.cboAktif.Size = New System.Drawing.Size(47, 17)
        Me.cboAktif.TabIndex = 12
        Me.cboAktif.Text = "Aktif"
        Me.cboAktif.UseVisualStyleBackColor = True
        '
        'btnAksi
        '
        Me.btnAksi.Location = New System.Drawing.Point(296, 197)
        Me.btnAksi.Name = "btnAksi"
        Me.btnAksi.Size = New System.Drawing.Size(195, 47)
        Me.btnAksi.TabIndex = 8
        Me.btnAksi.Text = "Ok"
        Me.btnAksi.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(296, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(194, 20)
        Me.txtPassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(296, 120)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(195, 20)
        Me.txtUsername.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee"
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.Enabled = False
        Me.txtNamaPegawai.Location = New System.Drawing.Point(296, 40)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.Size = New System.Drawing.Size(158, 20)
        Me.txtNamaPegawai.TabIndex = 1
        '
        'txtEmployee
        '
        Me.txtEmployee.Enabled = False
        Me.txtEmployee.Location = New System.Drawing.Point(296, 15)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(194, 20)
        Me.txtEmployee.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(3, 268)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 225)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvHeaderMenu)
        Me.TabPage1.Controls.Add(Me.btnRefreshHeaderMenu)
        Me.TabPage1.Controls.Add(Me.txtCariHeader)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnUpdateHdrMenu)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(492, 199)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Header Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvHeaderMenu
        '
        Me.dgvHeaderMenu.AllowUserToAddRows = False
        Me.dgvHeaderMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeaderMenu.ContextMenuStrip = Me.cmMenuHeader
        Me.dgvHeaderMenu.Location = New System.Drawing.Point(9, 35)
        Me.dgvHeaderMenu.Name = "dgvHeaderMenu"
        Me.dgvHeaderMenu.RowHeadersVisible = False
        Me.dgvHeaderMenu.Size = New System.Drawing.Size(474, 125)
        Me.dgvHeaderMenu.TabIndex = 16
        '
        'cmMenuHeader
        '
        Me.cmMenuHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyHeaderToAnotherUsersToolStripMenuItem})
        Me.cmMenuHeader.Name = "cmMenuHeader"
        Me.cmMenuHeader.Size = New System.Drawing.Size(236, 26)
        '
        'CopyHeaderToAnotherUsersToolStripMenuItem
        '
        Me.CopyHeaderToAnotherUsersToolStripMenuItem.Name = "CopyHeaderToAnotherUsersToolStripMenuItem"
        Me.CopyHeaderToAnotherUsersToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.CopyHeaderToAnotherUsersToolStripMenuItem.Text = "Copy Header To Another Users"
        '
        'txtCariHeader
        '
        Me.txtCariHeader.Location = New System.Drawing.Point(75, 9)
        Me.txtCariHeader.Name = "txtCariHeader"
        Me.txtCariHeader.Size = New System.Drawing.Size(373, 20)
        Me.txtCariHeader.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cari Header"
        '
        'btnUpdateHdrMenu
        '
        Me.btnUpdateHdrMenu.Location = New System.Drawing.Point(338, 164)
        Me.btnUpdateHdrMenu.Name = "btnUpdateHdrMenu"
        Me.btnUpdateHdrMenu.Size = New System.Drawing.Size(145, 29)
        Me.btnUpdateHdrMenu.TabIndex = 9
        Me.btnUpdateHdrMenu.Text = "Update"
        Me.btnUpdateHdrMenu.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDetailMenu)
        Me.TabPage2.Controls.Add(Me.cmbHeaderMenu)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnUpdateDetailMenu)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(492, 199)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detail Menu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDetailMenu
        '
        Me.dgvDetailMenu.AllowUserToAddRows = False
        Me.dgvDetailMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailMenu.ContextMenuStrip = Me.cmDetailMenu
        Me.dgvDetailMenu.Location = New System.Drawing.Point(9, 33)
        Me.dgvDetailMenu.Name = "dgvDetailMenu"
        Me.dgvDetailMenu.RowHeadersVisible = False
        Me.dgvDetailMenu.Size = New System.Drawing.Size(474, 131)
        Me.dgvDetailMenu.TabIndex = 15
        '
        'cmDetailMenu
        '
        Me.cmDetailMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyDetailMenuToAnotherUsersToolStripMenuItem})
        Me.cmDetailMenu.Name = "cmDetailMenu"
        Me.cmDetailMenu.Size = New System.Drawing.Size(262, 26)
        '
        'CopyDetailMenuToAnotherUsersToolStripMenuItem
        '
        Me.CopyDetailMenuToAnotherUsersToolStripMenuItem.Name = "CopyDetailMenuToAnotherUsersToolStripMenuItem"
        Me.CopyDetailMenuToAnotherUsersToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.CopyDetailMenuToAnotherUsersToolStripMenuItem.Text = "Copy Detail Menu To Another Users"
        '
        'cmbHeaderMenu
        '
        Me.cmbHeaderMenu.FormattingEnabled = True
        Me.cmbHeaderMenu.Location = New System.Drawing.Point(78, 6)
        Me.cmbHeaderMenu.Name = "cmbHeaderMenu"
        Me.cmbHeaderMenu.Size = New System.Drawing.Size(405, 21)
        Me.cmbHeaderMenu.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Header "
        '
        'btnUpdateDetailMenu
        '
        Me.btnUpdateDetailMenu.Location = New System.Drawing.Point(341, 167)
        Me.btnUpdateDetailMenu.Name = "btnUpdateDetailMenu"
        Me.btnUpdateDetailMenu.Size = New System.Drawing.Size(142, 29)
        Me.btnUpdateDetailMenu.TabIndex = 10
        Me.btnUpdateDetailMenu.Text = "Update"
        Me.btnUpdateDetailMenu.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnUpdateFormObject)
        Me.TabPage3.Controls.Add(Me.dgvDetailForm)
        Me.TabPage3.Controls.Add(Me.cmbListForm)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(492, 199)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Form Object"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnUpdateFormObject
        '
        Me.btnUpdateFormObject.Location = New System.Drawing.Point(336, 167)
        Me.btnUpdateFormObject.Name = "btnUpdateFormObject"
        Me.btnUpdateFormObject.Size = New System.Drawing.Size(147, 29)
        Me.btnUpdateFormObject.TabIndex = 17
        Me.btnUpdateFormObject.Text = "Update"
        Me.btnUpdateFormObject.UseVisualStyleBackColor = True
        '
        'dgvDetailForm
        '
        Me.dgvDetailForm.AllowUserToAddRows = False
        Me.dgvDetailForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailForm.ContextMenuStrip = Me.cmFormObject
        Me.dgvDetailForm.Location = New System.Drawing.Point(7, 34)
        Me.dgvDetailForm.Name = "dgvDetailForm"
        Me.dgvDetailForm.RowHeadersVisible = False
        Me.dgvDetailForm.Size = New System.Drawing.Size(476, 131)
        Me.dgvDetailForm.TabIndex = 16
        '
        'cmFormObject
        '
        Me.cmFormObject.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyFormObjectToAnotherUsersToolStripMenuItem})
        Me.cmFormObject.Name = "cmFormObject"
        Me.cmFormObject.Size = New System.Drawing.Size(264, 26)
        '
        'CopyFormObjectToAnotherUsersToolStripMenuItem
        '
        Me.CopyFormObjectToAnotherUsersToolStripMenuItem.Name = "CopyFormObjectToAnotherUsersToolStripMenuItem"
        Me.CopyFormObjectToAnotherUsersToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.CopyFormObjectToAnotherUsersToolStripMenuItem.Text = "Copy Form Object To Another Users"
        '
        'cmbListForm
        '
        Me.cmbListForm.FormattingEnabled = True
        Me.cmbListForm.Location = New System.Drawing.Point(52, 7)
        Me.cmbListForm.Name = "cmbListForm"
        Me.cmbListForm.Size = New System.Drawing.Size(434, 21)
        Me.cmbListForm.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Form"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnUpdateLocationControl)
        Me.TabPage4.Controls.Add(Me.dgvLocationControl)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(492, 199)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Location Control"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnUpdateLocationControl
        '
        Me.btnUpdateLocationControl.Location = New System.Drawing.Point(338, 167)
        Me.btnUpdateLocationControl.Name = "btnUpdateLocationControl"
        Me.btnUpdateLocationControl.Size = New System.Drawing.Size(145, 29)
        Me.btnUpdateLocationControl.TabIndex = 18
        Me.btnUpdateLocationControl.Text = "Update"
        Me.btnUpdateLocationControl.UseVisualStyleBackColor = True
        '
        'dgvLocationControl
        '
        Me.dgvLocationControl.AllowUserToAddRows = False
        Me.dgvLocationControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocationControl.ContextMenuStrip = Me.cmLocationControl
        Me.dgvLocationControl.Location = New System.Drawing.Point(6, 6)
        Me.dgvLocationControl.Name = "dgvLocationControl"
        Me.dgvLocationControl.RowHeadersVisible = False
        Me.dgvLocationControl.Size = New System.Drawing.Size(477, 158)
        Me.dgvLocationControl.TabIndex = 0
        '
        'cmLocationControl
        '
        Me.cmLocationControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyLocationControlToAnotherUsersToolStripMenuItem})
        Me.cmLocationControl.Name = "cmLocationControl"
        Me.cmLocationControl.Size = New System.Drawing.Size(287, 26)
        '
        'CopyLocationControlToAnotherUsersToolStripMenuItem
        '
        Me.CopyLocationControlToAnotherUsersToolStripMenuItem.Name = "CopyLocationControlToAnotherUsersToolStripMenuItem"
        Me.CopyLocationControlToAnotherUsersToolStripMenuItem.Size = New System.Drawing.Size(286, 22)
        Me.CopyLocationControlToAnotherUsersToolStripMenuItem.Text = "Copy Location Control To Another Users"
        '
        'cmCopyAlltoAllUsers
        '
        Me.cmCopyAlltoAllUsers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyAllControlToAnotherUsersToolStripMenuItem, Me.RefreshControlToolStripMenuItem})
        Me.cmCopyAlltoAllUsers.Name = "ContextMenuStrip1"
        Me.cmCopyAlltoAllUsers.Size = New System.Drawing.Size(255, 48)
        '
        'CopyAllControlToAnotherUsersToolStripMenuItem
        '
        Me.CopyAllControlToAnotherUsersToolStripMenuItem.Name = "CopyAllControlToAnotherUsersToolStripMenuItem"
        Me.CopyAllControlToAnotherUsersToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.CopyAllControlToAnotherUsersToolStripMenuItem.Text = "Copy All Control To Another Users"
        '
        'RefreshControlToolStripMenuItem
        '
        Me.RefreshControlToolStripMenuItem.Name = "RefreshControlToolStripMenuItem"
        Me.RefreshControlToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.RefreshControlToolStripMenuItem.Text = "Refresh Control"
        '
        'btnRefreshHeaderMenu
        '
        Me.btnRefreshHeaderMenu.BaseColor = System.Drawing.Color.White
        Me.btnRefreshHeaderMenu.Location = New System.Drawing.Point(454, 6)
        Me.btnRefreshHeaderMenu.Name = "btnRefreshHeaderMenu"
        Me.btnRefreshHeaderMenu.Size = New System.Drawing.Size(29, 29)
        Me.btnRefreshHeaderMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRefreshHeaderMenu.TabIndex = 12
        Me.btnRefreshHeaderMenu.TabStop = False
        Me.btnRefreshHeaderMenu.UseTransfarantBackground = False
        '
        'picBrowsePegawai
        '
        Me.picBrowsePegawai.BaseColor = System.Drawing.Color.White
        Me.picBrowsePegawai.Enabled = False
        Me.picBrowsePegawai.Image = Global.ANYAR_GADGET.My.Resources.Resources.browse
        Me.picBrowsePegawai.Location = New System.Drawing.Point(460, 37)
        Me.picBrowsePegawai.Name = "picBrowsePegawai"
        Me.picBrowsePegawai.Size = New System.Drawing.Size(27, 29)
        Me.picBrowsePegawai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrowsePegawai.TabIndex = 18
        Me.picBrowsePegawai.TabStop = False
        Me.picBrowsePegawai.UseTransfarantBackground = False
        '
        'picNew
        '
        Me.picNew.BaseColor = System.Drawing.Color.White
        Me.picNew.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_User
        Me.picNew.Location = New System.Drawing.Point(13, 196)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(47, 47)
        Me.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNew.TabIndex = 13
        Me.picNew.TabStop = False
        Me.picNew.UseTransfarantBackground = False
        '
        'picFind
        '
        Me.picFind.BaseColor = System.Drawing.Color.White
        Me.picFind.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picFind.Location = New System.Drawing.Point(66, 196)
        Me.picFind.Name = "picFind"
        Me.picFind.Size = New System.Drawing.Size(47, 47)
        Me.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFind.TabIndex = 11
        Me.picFind.TabStop = False
        Me.picFind.UseTransfarantBackground = False
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.ANYAR_GADGET.My.Resources.Resources.Komputer
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(9, 19)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(181, 171)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 9
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 495)
        Me.ContextMenuStrip = Me.cmCopyAlltoAllUsers
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Users"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvHeaderMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmMenuHeader.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetailMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmDetailMenu.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvDetailForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmFormObject.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvLocationControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmLocationControl.ResumeLayout(False)
        Me.cmCopyAlltoAllUsers.ResumeLayout(False)
        CType(Me.btnRefreshHeaderMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrowsePegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btnAksi As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployee As System.Windows.Forms.TextBox
    Friend WithEvents picFind As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents cboAktif As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtCariHeader As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateHdrMenu As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmbHeaderMenu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateDetailMenu As System.Windows.Forms.Button
    Friend WithEvents btnRefreshHeaderMenu As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents picNew As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents dgvDetailMenu As System.Windows.Forms.DataGridView
    Friend WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvHeaderMenu As System.Windows.Forms.DataGridView
    Friend WithEvents picBrowsePegawai As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateFormObject As System.Windows.Forms.Button
    Friend WithEvents dgvDetailForm As System.Windows.Forms.DataGridView
    Friend WithEvents cmbListForm As System.Windows.Forms.ComboBox
    Friend WithEvents cmCopyAlltoAllUsers As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyAllControlToAnotherUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmMenuHeader As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyHeaderToAnotherUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmDetailMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyDetailMenuToAnotherUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmFormObject As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyFormObjectToAnotherUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnUpdateLocationControl As System.Windows.Forms.Button
    Friend WithEvents dgvLocationControl As System.Windows.Forms.DataGridView
    Friend WithEvents cmLocationControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyLocationControlToAnotherUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
