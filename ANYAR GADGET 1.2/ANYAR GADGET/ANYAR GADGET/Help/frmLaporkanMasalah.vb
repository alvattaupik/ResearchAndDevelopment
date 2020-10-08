Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmLaporkanMasalah
    Public selRow As New DataGridViewRow


    Private Sub picCariSubKategori_Click(sender As Object, e As EventArgs) Handles picCariSubKategori.Click

        If cmbKategori.Text = "" Then
            DisplayPesanError("Category is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            frmBrowseSubkategori.ShowDialog()
        End If

    End Sub

    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "Select IDCategories,Deskripsi From OCategories Where StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbKategori_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedValueChanged
        txtKodeSubkategori.Text = ""
        txtNamaSubkategori.Text = ""

        txtKodeSpecificProblem.Text = ""
        txtNamaSpecificProblems.Text = ""

    End Sub

    Private Sub cmbKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbKategori.SelectionChangeCommitted
        MstrIDCategories = cmbKategori.SelectedValue
        MstrNamaCategories = cmbKategori.Text
    End Sub

    Private Sub frmLaporkanMasalah_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtEmpID.Text = MstrKodePegawai
        txtNamaPegawai.Text = MstrNamaPegawai
        txtUsernameLogin.Text = MstrUsernameLogin

        txtLokasi.Text = MstrKodeDivisi
        txtNamaSupervisor.Text = MstrNamaSPV


    End Sub

    Private Sub picCariSpesificProblem_Click(sender As Object, e As EventArgs) Handles picCariSpesificProblem.Click
        If txtKodeSubkategori.Text = "" Then
            DisplayPesanError(" Sub Category is Required", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            MstrNamaSubCategories = txtNamaSubkategori.Text
            MstrIDSubCategories = txtKodeSubkategori.Text
            frmBrowseSpecificProblem.ShowDialog()
        End If
    End Sub

    Private Sub btnAddLampiran_Click(sender As Object, e As EventArgs) Handles btnAddLampiran.Click
        If txtPathLampiran.Text = "" Then
            DisplayPesanError("Attachments Is Required, Please Browse", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        dgvListLampiran.Rows.Add(txtPathLampiran.Text)
        lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount
        dgvListLampiran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListLampiran.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvListLampiran.AutoResizeColumns()
        txtPathLampiran.Text = ""
    End Sub

    Private Sub picCariLampiran_Click(sender As Object, e As EventArgs) Handles picCariLampiran.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathLampiran.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnHapusLampiran_Click(sender As Object, e As EventArgs) Handles btnHapusLampiran.Click
        Dim row As Integer
        Dim index As Integer

        On Error Resume Next

        If dgvListLampiran.RowCount = 0 Then Exit Sub

        index = dgvListLampiran.SelectedRows.Item(0).Index
        selRow = dgvListLampiran.Rows.Item(index)
        dgvListLampiran.Rows.Remove(selRow)
        row = row - 1
        lblJumlahLampiran.Text = "Jumlah Lampiran : " & dgvListLampiran.RowCount

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtUniqueID.Text = ""
        cmbKategori.Text = ""
        txtKodeSubkategori.Text = ""
        txtNamaSubkategori.Text = ""
        txtKodeSpecificProblem.Text = ""
        txtNamaSpecificProblems.Text = ""

        txtDetailDeskripsi.Text = ""
        txtPathLampiran.Text = ""
        dgvListLampiran.Rows.Clear()
    End Sub

    Private Sub btnKirim_Click(sender As Object, e As EventArgs) Handles btnKirim.Click

        If txtDetailDeskripsi.ReadOnly = False And txtDetailDeskripsi.Text = "" Then
            DisplayPesanError("Detail Deskripsi Harus Dilengkapi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        AU_ITILV3_INC("Add-INC-USERS")




        For i As Integer = 0 To dgvListLampiran.Rows.Count - 1
            AU_ITILV3_INCLampiran("ADD-ATCH-USERS", dgvListLampiran, dgvListLampiran.Rows.Count - 1)
        Next




        txtUniqueID.Text = ""
        cmbKategori.Text = ""
        txtKodeSubkategori.Text = ""
        txtNamaSubkategori.Text = ""
        txtKodeSpecificProblem.Text = ""
        txtNamaSpecificProblems.Text = ""

        txtDetailDeskripsi.Text = ""
        txtPathLampiran.Text = ""
        dgvListLampiran.Rows.Clear()

    End Sub




    Sub CopyFileKeDirectoryAttachment(strLokasiAsal As String, strIDAttach As String)
        Dim strpathAttatchments As String


        strpathAttatchments = "\\10.1.0.52\Attachments Surat\ITIL INCIDENT MANAGEMENT\" & Trim(strIDAttach) & MstrExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), strpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub



    Private Sub txtNamaSpecificProblems_TextChanged(sender As Object, e As EventArgs) Handles txtNamaSpecificProblems.TextChanged
        If txtNamaSpecificProblems.Text = "Tidak Ada Dalam Daftar" Then
            txtDetailDeskripsi.ReadOnly = False
            txtDetailDeskripsi.Enabled = True
            txtDetailDeskripsi.BackColor = Color.Yellow
        Else
            txtDetailDeskripsi.ReadOnly = True
            txtDetailDeskripsi.Enabled = False
            txtDetailDeskripsi.BackColor = Color.White
            txtDetailDeskripsi.Text = ""
        End If
    End Sub



    Sub AU_ITILV3_INC(strFunction As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AU_INC_MAN]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("UniqueIDIN", Trim(txtUniqueID.Text))
            command.Parameters.Add("UniqueIDOUT", SqlDbType.VarChar, 50)
            command.Parameters("UniqueIDOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("MoNIN", Trim("Anyar Gadget")) 'Method Of Notification
            command.Parameters.Add("MoNOUT", SqlDbType.VarChar, 100)
            command.Parameters("MoNOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("HDAgentIN", Trim("-")) 'Method Of Notification
            command.Parameters.Add("HDAgentOUT", SqlDbType.VarChar, 50)
            command.Parameters("HDAgentOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("HDAgentNameOUT", SqlDbType.VarChar, 50)
            command.Parameters("HDAgentNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("ITILCategoryIN", Trim("-"))
            command.Parameters.Add("ITILCategoryOUT", SqlDbType.VarChar, 100)
            command.Parameters("ITILCategoryOUT").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("IncidentPriorityIN", Trim("-"))
            command.Parameters.Add("IncidentPriorityOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentPriorityOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IncidentImpactIN", Trim("-"))
            command.Parameters.Add("IncidentImpactOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentImpactOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("IncidentImpactNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentImpactNameOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("EmployeeIDIN", Trim(txtEmpID.Text))
            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("UsernameLoginIN", Trim(txtUsernameLogin.Text))
            command.Parameters.Add("UsernameLoginOUT", SqlDbType.VarChar, 100)
            command.Parameters("UsernameLoginOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("EmployeeNameIN", Trim(txtNamaPegawai.Text))
            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("CallBackMethodIN", Trim(""))
            command.Parameters.Add("CallBackMethodOUT", SqlDbType.VarChar, 100)
            command.Parameters("CallBackMethodOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LocationUserIN", Trim(MstrKodeDivisi))
            command.Parameters.Add("LocationNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("LocationNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("AffectedServiceIN", Trim("-"))
            command.Parameters.Add("AffectedServiceOUT", SqlDbType.VarChar, 100)
            command.Parameters("AffectedServiceOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("RelationToComponentIN", Trim("-"))
            command.Parameters.Add("RelationToComponentOUT", SqlDbType.VarChar, 100)
            command.Parameters("RelationToComponentOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("RelationToComponentNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("RelationToComponentNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDPICIN", Trim("-"))
            command.Parameters.Add("IDPICOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDPICOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("PICNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("PICNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDAssignIN", Trim("-"))
            command.Parameters.Add("IDAssignOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDAssignOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("IDAssignName", SqlDbType.VarChar, 100)
            command.Parameters("IDAssignName").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("IDActionIN", Trim("-"))
            command.Parameters.Add("IDActionOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDActionOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("IDActionNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDActionNameOUT").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("CommentIN", Trim(txtDetailDeskripsi.Text))
            command.Parameters.Add("CommentOUT", SqlDbType.VarChar, 100)
            command.Parameters("CommentOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LinkedtoIncidentRecordsIN", Trim("-"))
            command.Parameters.Add("LinkedtoIncidentRecordsIOUT", SqlDbType.VarChar, 100)
            command.Parameters("LinkedtoIncidentRecordsIOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("LinkedtoProblemRecordsIN", Trim("-"))
            command.Parameters.Add("LinkedtoProblemRecordsOUT", SqlDbType.VarChar, 100)
            command.Parameters("LinkedtoProblemRecordsOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LineStatusIN", Trim("-"))
            command.Parameters.Add("LineStatusOUT", SqlDbType.VarChar, 100)
            command.Parameters("LineStatusOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("LineStatusNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("LineStatusNameOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(cmbKategori.SelectedValue))
            command.Parameters.Add("IDCategoriesOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDCategoriesOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("CategoriesNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("CategoriesNameOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("PatchAttachmentsIN", Trim(""))
            command.Parameters.Add("IDAttachmentsOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDAttachmentsOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDSubIN", Trim(txtKodeSubkategori.Text))
            command.Parameters.Add("IDSubOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDSubOUT").Direction = ParameterDirection.Output



            command.Parameters.Add("SubCategoryNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("SubCategoryNameOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("IDSimptomsIN", Trim(txtKodeSpecificProblem.Text))
            command.Parameters.Add("IDSimptomsOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDSimptomsOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("SimptomsNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("SimptomsNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("CatatanIN", Trim(txtDetailDeskripsi.Text))
            command.Parameters.Add("CatatanOUT", SqlDbType.VarChar, 300)
            command.Parameters("CatatanOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("ResStatusIN", Trim(""))
            command.Parameters.Add("ResStatusOut", SqlDbType.VarChar, 300)
            command.Parameters("ResStatusOut").Direction = ParameterDirection.Output
            command.Parameters.Add("ResStatusName", SqlDbType.VarChar, 300)
            command.Parameters("ResStatusName").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            txtUniqueID.Text = command.Parameters("UniqueIDOUT").Value.ToString()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub






    Sub AU_ITILV3_INCLampiran(strFunction As String, dgv As DataGridView, intI As Integer)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AU_INC_MAN]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("UniqueIDIN", Trim(txtUniqueID.Text))
            command.Parameters.Add("UniqueIDOUT", SqlDbType.VarChar, 50)
            command.Parameters("UniqueIDOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("MoNIN", Trim("Anyar Gadget")) 'Method Of Notification
            command.Parameters.Add("MoNOUT", SqlDbType.VarChar, 100)
            command.Parameters("MoNOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("HDAgentIN", Trim("-")) 'Method Of Notification
            command.Parameters.Add("HDAgentOUT", SqlDbType.VarChar, 50)
            command.Parameters("HDAgentOUT").Direction = ParameterDirection.Output

            command.Parameters.Add("HDAgentNameOUT", SqlDbType.VarChar, 50)
            command.Parameters("HDAgentNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("ITILCategoryIN", Trim("-"))
            command.Parameters.Add("ITILCategoryOUT", SqlDbType.VarChar, 100)
            command.Parameters("ITILCategoryOUT").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("IncidentPriorityIN", Trim("-"))
            command.Parameters.Add("IncidentPriorityOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentPriorityOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IncidentImpactIN", Trim("-"))
            command.Parameters.Add("IncidentImpactOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentImpactOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("IncidentImpactNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("IncidentImpactNameOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("EmployeeIDIN", Trim(txtEmpID.Text))
            command.Parameters.Add("EmployeeIDOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeIDOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("UsernameLoginIN", Trim(txtUsernameLogin.Text))
            command.Parameters.Add("UsernameLoginOUT", SqlDbType.VarChar, 100)
            command.Parameters("UsernameLoginOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("EmployeeNameIN", Trim(txtNamaPegawai.Text))
            command.Parameters.Add("EmployeeNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("EmployeeNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("CallBackMethodIN", Trim(""))
            command.Parameters.Add("CallBackMethodOUT", SqlDbType.VarChar, 100)
            command.Parameters("CallBackMethodOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LocationUserIN", Trim(MstrKodeDivisi))
            command.Parameters.Add("LocationNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("LocationNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("AffectedServiceIN", Trim("-"))
            command.Parameters.Add("AffectedServiceOUT", SqlDbType.VarChar, 100)
            command.Parameters("AffectedServiceOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("RelationToComponentIN", Trim("-"))
            command.Parameters.Add("RelationToComponentOUT", SqlDbType.VarChar, 100)
            command.Parameters("RelationToComponentOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("RelationToComponentNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("RelationToComponentNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDPICIN", Trim("-"))
            command.Parameters.Add("IDPICOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDPICOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("PICNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("PICNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDAssignIN", Trim("-"))
            command.Parameters.Add("IDAssignOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDAssignOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("IDAssignName", SqlDbType.VarChar, 100)
            command.Parameters("IDAssignName").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("IDActionIN", Trim("-"))
            command.Parameters.Add("IDActionOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDActionOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("IDActionNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDActionNameOUT").Direction = ParameterDirection.Output




            command.Parameters.AddWithValue("CommentIN", Trim(txtDetailDeskripsi.Text))
            command.Parameters.Add("CommentOUT", SqlDbType.VarChar, 100)
            command.Parameters("CommentOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LinkedtoIncidentRecordsIN", Trim("-"))
            command.Parameters.Add("LinkedtoIncidentRecordsIOUT", SqlDbType.VarChar, 100)
            command.Parameters("LinkedtoIncidentRecordsIOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("LinkedtoProblemRecordsIN", Trim("-"))
            command.Parameters.Add("LinkedtoProblemRecordsOUT", SqlDbType.VarChar, 100)
            command.Parameters("LinkedtoProblemRecordsOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("LineStatusIN", Trim("-"))
            command.Parameters.Add("LineStatusOUT", SqlDbType.VarChar, 100)
            command.Parameters("LineStatusOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("LineStatusNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("LineStatusNameOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("IDCategoriesIN", Trim(cmbKategori.SelectedValue))
            command.Parameters.Add("IDCategoriesOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDCategoriesOUT").Direction = ParameterDirection.Output


            command.Parameters.Add("CategoriesNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("CategoriesNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("PatchAttachmentsIN", Trim(dgv.Rows(intI).Cells(0).Value))
            command.Parameters.Add("IDAttachmentsOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDAttachmentsOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("IDSubIN", Trim(txtKodeSubkategori.Text))
            command.Parameters.Add("IDSubOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDSubOUT").Direction = ParameterDirection.Output



            command.Parameters.Add("SubCategoryNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("SubCategoryNameOUT").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("IDSimptomsIN", Trim(txtKodeSpecificProblem.Text))
            command.Parameters.Add("IDSimptomsOUT", SqlDbType.VarChar, 100)
            command.Parameters("IDSimptomsOUT").Direction = ParameterDirection.Output
            command.Parameters.Add("SimptomsNameOUT", SqlDbType.VarChar, 100)
            command.Parameters("SimptomsNameOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("CatatanIN", Trim(txtDetailDeskripsi.Text))
            command.Parameters.Add("CatatanOUT", SqlDbType.VarChar, 300)
            command.Parameters("CatatanOUT").Direction = ParameterDirection.Output

            command.Parameters.AddWithValue("ResStatusIN", Trim(""))
            command.Parameters.Add("ResStatusOut", SqlDbType.VarChar, 300)
            command.Parameters("ResStatusOut").Direction = ParameterDirection.Output
            command.Parameters.Add("ResStatusName", SqlDbType.VarChar, 300)
            command.Parameters("ResStatusName").Direction = ParameterDirection.Output



            command.Parameters.AddWithValue("Function", Trim(strFunction))


            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
            'txtUniqueID.Text = command.Parameters("UniqueIDOUT").Value.ToString()

            '@IDAttachmentsOUT
            GetExtentionfile(Trim(dgv.Rows(intI).Cells(0).Value))
            Call CopyFileKeDirectoryAttachment(dgv.Rows(intI).Cells(0).Value, command.Parameters("IDAttachmentsOUT").Value.ToString())

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



   




End Class