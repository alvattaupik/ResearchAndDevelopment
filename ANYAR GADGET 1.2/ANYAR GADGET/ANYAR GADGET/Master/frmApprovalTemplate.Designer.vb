<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovalTemplate
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
        Me.btnProses = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkStatusEnabled = New Guna.UI.WinForms.GunaCheckBox()
        Me.cmbFungsi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNamaTemplate = New System.Windows.Forms.TextBox()
        Me.txtKodetemplate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvListTemplate = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCariTemplateID = New System.Windows.Forms.TextBox()
        Me.picSearch = New Guna.UI.WinForms.GunaPictureBox()
        Me.picNew = New Guna.UI.WinForms.GunaPictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvMasterStagging = New System.Windows.Forms.DataGridView()
        Me.RemoveUserStaging = New System.Windows.Forms.Button()
        Me.btnAddNewUserStaging = New System.Windows.Forms.Button()
        Me.picSearchStaging = New Guna.UI.WinForms.GunaPictureBox()
        Me.picNewStaging = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKodeTemplate = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvListUsersAffected = New System.Windows.Forms.DataGridView()
        Me.cmbCariUsers = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListUsersMaster = New System.Windows.Forms.DataGridView()
        Me.cmbMasterStagging = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvMasterStagging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearchStaging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNewStaging, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListUsersAffected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListUsersMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 443)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnProses)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dgvListTemplate)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCariTemplateID)
        Me.TabPage1.Controls.Add(Me.picSearch)
        Me.TabPage1.Controls.Add(Me.picNew)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(536, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master Template"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(398, 304)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(114, 105)
        Me.btnProses.TabIndex = 6
        Me.btnProses.Text = "Ok"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkStatusEnabled)
        Me.GroupBox1.Controls.Add(Me.cmbFungsi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNamaTemplate)
        Me.GroupBox1.Controls.Add(Me.txtKodetemplate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 293)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 120)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'chkStatusEnabled
        '
        Me.chkStatusEnabled.BaseColor = System.Drawing.Color.White
        Me.chkStatusEnabled.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkStatusEnabled.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkStatusEnabled.FillColor = System.Drawing.Color.White
        Me.chkStatusEnabled.Location = New System.Drawing.Point(136, 90)
        Me.chkStatusEnabled.Name = "chkStatusEnabled"
        Me.chkStatusEnabled.Size = New System.Drawing.Size(106, 20)
        Me.chkStatusEnabled.TabIndex = 10
        Me.chkStatusEnabled.Text = "Status Enabled"
        '
        'cmbFungsi
        '
        Me.cmbFungsi.FormattingEnabled = True
        Me.cmbFungsi.Location = New System.Drawing.Point(137, 68)
        Me.cmbFungsi.Name = "cmbFungsi"
        Me.cmbFungsi.Size = New System.Drawing.Size(240, 21)
        Me.cmbFungsi.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fungsi"
        '
        'txtNamaTemplate
        '
        Me.txtNamaTemplate.Location = New System.Drawing.Point(137, 41)
        Me.txtNamaTemplate.Name = "txtNamaTemplate"
        Me.txtNamaTemplate.Size = New System.Drawing.Size(241, 20)
        Me.txtNamaTemplate.TabIndex = 7
        '
        'txtKodetemplate
        '
        Me.txtKodetemplate.Location = New System.Drawing.Point(136, 14)
        Me.txtKodetemplate.Name = "txtKodetemplate"
        Me.txtKodetemplate.Size = New System.Drawing.Size(241, 20)
        Me.txtKodetemplate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Template"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Template ID"
        '
        'dgvListTemplate
        '
        Me.dgvListTemplate.AllowUserToAddRows = False
        Me.dgvListTemplate.AllowUserToDeleteRows = False
        Me.dgvListTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTemplate.Location = New System.Drawing.Point(8, 62)
        Me.dgvListTemplate.Name = "dgvListTemplate"
        Me.dgvListTemplate.ReadOnly = True
        Me.dgvListTemplate.RowHeadersVisible = False
        Me.dgvListTemplate.Size = New System.Drawing.Size(505, 225)
        Me.dgvListTemplate.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cari Template ID"
        '
        'txtCariTemplateID
        '
        Me.txtCariTemplateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariTemplateID.Location = New System.Drawing.Point(231, 13)
        Me.txtCariTemplateID.Name = "txtCariTemplateID"
        Me.txtCariTemplateID.Size = New System.Drawing.Size(281, 29)
        Me.txtCariTemplateID.TabIndex = 2
        '
        'picSearch
        '
        Me.picSearch.BaseColor = System.Drawing.Color.White
        Me.picSearch.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picSearch.Location = New System.Drawing.Point(47, 7)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(34, 35)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSearch.TabIndex = 1
        Me.picSearch.TabStop = False
        '
        'picNew
        '
        Me.picNew.BaseColor = System.Drawing.Color.White
        Me.picNew.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_Document
        Me.picNew.Location = New System.Drawing.Point(7, 7)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(34, 35)
        Me.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNew.TabIndex = 0
        Me.picNew.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvMasterStagging)
        Me.TabPage2.Controls.Add(Me.RemoveUserStaging)
        Me.TabPage2.Controls.Add(Me.btnAddNewUserStaging)
        Me.TabPage2.Controls.Add(Me.picSearchStaging)
        Me.TabPage2.Controls.Add(Me.picNewStaging)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cmbKodeTemplate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(536, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Master Staging"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvMasterStagging
        '
        Me.dgvMasterStagging.AllowUserToAddRows = False
        Me.dgvMasterStagging.AllowUserToDeleteRows = False
        Me.dgvMasterStagging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterStagging.Location = New System.Drawing.Point(16, 47)
        Me.dgvMasterStagging.Name = "dgvMasterStagging"
        Me.dgvMasterStagging.ReadOnly = True
        Me.dgvMasterStagging.RowHeadersVisible = False
        Me.dgvMasterStagging.Size = New System.Drawing.Size(505, 319)
        Me.dgvMasterStagging.TabIndex = 8
        '
        'RemoveUserStaging
        '
        Me.RemoveUserStaging.Location = New System.Drawing.Point(126, 378)
        Me.RemoveUserStaging.Name = "RemoveUserStaging"
        Me.RemoveUserStaging.Size = New System.Drawing.Size(104, 33)
        Me.RemoveUserStaging.TabIndex = 7
        Me.RemoveUserStaging.Text = "Remove Users"
        Me.RemoveUserStaging.UseVisualStyleBackColor = True
        '
        'btnAddNewUserStaging
        '
        Me.btnAddNewUserStaging.Location = New System.Drawing.Point(16, 378)
        Me.btnAddNewUserStaging.Name = "btnAddNewUserStaging"
        Me.btnAddNewUserStaging.Size = New System.Drawing.Size(104, 33)
        Me.btnAddNewUserStaging.TabIndex = 6
        Me.btnAddNewUserStaging.Text = "Add New Users"
        Me.btnAddNewUserStaging.UseVisualStyleBackColor = True
        '
        'picSearchStaging
        '
        Me.picSearchStaging.BaseColor = System.Drawing.Color.White
        Me.picSearchStaging.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.picSearchStaging.Location = New System.Drawing.Point(59, 6)
        Me.picSearchStaging.Name = "picSearchStaging"
        Me.picSearchStaging.Size = New System.Drawing.Size(34, 35)
        Me.picSearchStaging.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSearchStaging.TabIndex = 4
        Me.picSearchStaging.TabStop = False
        '
        'picNewStaging
        '
        Me.picNewStaging.BaseColor = System.Drawing.Color.White
        Me.picNewStaging.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_Document
        Me.picNewStaging.Location = New System.Drawing.Point(19, 6)
        Me.picNewStaging.Name = "picNewStaging"
        Me.picNewStaging.Size = New System.Drawing.Size(34, 35)
        Me.picNewStaging.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNewStaging.TabIndex = 3
        Me.picNewStaging.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Kode Template"
        '
        'cmbKodeTemplate
        '
        Me.cmbKodeTemplate.FormattingEnabled = True
        Me.cmbKodeTemplate.Location = New System.Drawing.Point(194, 15)
        Me.cmbKodeTemplate.Name = "cmbKodeTemplate"
        Me.cmbKodeTemplate.Size = New System.Drawing.Size(327, 21)
        Me.cmbKodeTemplate.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GunaPictureBox2)
        Me.TabPage3.Controls.Add(Me.GunaPictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(536, 417)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Affected Users"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.dgvListUsersAffected)
        Me.GroupBox3.Controls.Add(Me.cmbCariUsers)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(81, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 222)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affected Users"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(330, 194)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(331, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 24)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvListUsersAffected
        '
        Me.dgvListUsersAffected.AllowUserToAddRows = False
        Me.dgvListUsersAffected.AllowUserToDeleteRows = False
        Me.dgvListUsersAffected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListUsersAffected.Location = New System.Drawing.Point(94, 46)
        Me.dgvListUsersAffected.Name = "dgvListUsersAffected"
        Me.dgvListUsersAffected.ReadOnly = True
        Me.dgvListUsersAffected.RowHeadersVisible = False
        Me.dgvListUsersAffected.Size = New System.Drawing.Size(337, 146)
        Me.dgvListUsersAffected.TabIndex = 3
        '
        'cmbCariUsers
        '
        Me.cmbCariUsers.FormattingEnabled = True
        Me.cmbCariUsers.Location = New System.Drawing.Point(94, 20)
        Me.cmbCariUsers.Name = "cmbCariUsers"
        Me.cmbCariUsers.Size = New System.Drawing.Size(229, 21)
        Me.cmbCariUsers.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cari User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListUsersMaster)
        Me.GroupBox2.Controls.Add(Me.cmbMasterStagging)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(81, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 174)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master Stagging"
        '
        'dgvListUsersMaster
        '
        Me.dgvListUsersMaster.AllowUserToAddRows = False
        Me.dgvListUsersMaster.AllowUserToDeleteRows = False
        Me.dgvListUsersMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListUsersMaster.Location = New System.Drawing.Point(94, 46)
        Me.dgvListUsersMaster.Name = "dgvListUsersMaster"
        Me.dgvListUsersMaster.ReadOnly = True
        Me.dgvListUsersMaster.RowHeadersVisible = False
        Me.dgvListUsersMaster.Size = New System.Drawing.Size(337, 111)
        Me.dgvListUsersMaster.TabIndex = 3
        '
        'cmbMasterStagging
        '
        Me.cmbMasterStagging.FormattingEnabled = True
        Me.cmbMasterStagging.Location = New System.Drawing.Point(94, 20)
        Me.cmbMasterStagging.Name = "cmbMasterStagging"
        Me.cmbMasterStagging.Size = New System.Drawing.Size(337, 21)
        Me.cmbMasterStagging.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cari Template"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.ANYAR_GADGET.My.Resources.Resources.Search_User
        Me.GunaPictureBox2.Location = New System.Drawing.Point(43, 13)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(34, 35)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 6
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = Global.ANYAR_GADGET.My.Resources.Resources.Add_Document
        Me.GunaPictureBox3.Location = New System.Drawing.Point(3, 13)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(34, 35)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox3.TabIndex = 5
        Me.GunaPictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Approval Decision Template"
        '
        'frmApprovalTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmApprovalTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmApprovalTemplate"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvMasterStagging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearchStaging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNewStaging, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListUsersAffected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvListUsersMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents picNew As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkStatusEnabled As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents cmbFungsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNamaTemplate As System.Windows.Forms.TextBox
    Friend WithEvents txtKodetemplate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvListTemplate As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCariTemplateID As System.Windows.Forms.TextBox
    Friend WithEvents picSearch As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbKodeTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents picSearchStaging As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents picNewStaging As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents RemoveUserStaging As System.Windows.Forms.Button
    Friend WithEvents btnAddNewUserStaging As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgvListUsersAffected As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCariUsers As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListUsersMaster As System.Windows.Forms.DataGridView
    Friend WithEvents cmbMasterStagging As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMasterStagging As System.Windows.Forms.DataGridView
End Class
