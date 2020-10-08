Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailSpecificCategories

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtKode.Text = ""
        txtNamaExternal.Text = ""
        txtDeskripsi.Text = ""
        cboAktif.Checked = True
        txtSolutions.Text = ""
        cmbSeverityLevel.Text = ""
        btnProses.Text = "ADD"
        txtKode.Enabled = True


    End Sub

    Private Sub frmDetailMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Categories1 WHere IDCategories ='" & Trim(cmbHeaders.SelectedValue) & "' ", KoneksiDBEmail)
    End Sub




    Private Sub cmbHeaders_Click(sender As Object, e As EventArgs) Handles cmbHeaders.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbHeaders, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE  StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub

    'Private Sub cmbHeaders_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeaders.SelectionChangeCommitted
    '    Call KoneksiDB_EMAIL()
    '    LoadDataGrid(dgvListDetailMenu, "Select * from Categories1 Where IDCategories='" & cmbHeaders.SelectedValue & "'", KoneksiDBEmail)
    'End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()


        Dim strCeklis As String

        If cboAktif.Checked = True Then
            strCeklis = "Y"
        Else
            strCeklis = "N"
        End If

        If btnProses.Text = "ADD" Then

            Call AUD_MenuAplikasiSpecificITIL("A_SpecificCategories", cmbHeaders.SelectedValue, cmbSubCategories.SelectedValue, txtKode.Text, txtDeskripsi.Text, txtSolutions.Text, cmbSeverityLevel.Text, strCeklis)


            Bersihkan()
            LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Categories2 WHere IdCategories='" & Trim(cmbHeaders.SelectedValue) & "' AND IdSub='" & Trim(cmbSubCategories.SelectedValue) & "' ", KoneksiDBEmail)
        Else

            Call AUD_MenuAplikasiSpecificITIL("U_SpecificCategories", txtID.Text, txtIDSub.Text, txtKode.Text, txtDeskripsi.Text, txtSolutions.Text, cmbSeverityLevel.Text, strCeklis)
            LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Categories2 WHere IdCategories Like '%" & Trim(cmbHeaders.SelectedValue) & "%' AND IdSub='" & Trim(cmbSubCategories.SelectedValue) & "'", KoneksiDBEmail)
        End If


    End Sub

    Sub Bersihkan()
        txtKode.Text = ""
        txtID.Text = ""
        txtNamaExternal.Text = ""
        txtDeskripsi.Text = ""
        cboAktif.Checked = True
        btnProses.Text = "ADD"
    End Sub

    Private Sub dgvListDetailMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListDetailMenu.CellClick
        txtID.Text = dgvListDetailMenu.Item(0, dgvListDetailMenu.CurrentRow.Index).Value
        txtIDSub.Text = dgvListDetailMenu.Item(1, dgvListDetailMenu.CurrentRow.Index).Value
        txtKode.Text = dgvListDetailMenu.Item(2, dgvListDetailMenu.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvListDetailMenu.Item(3, dgvListDetailMenu.CurrentRow.Index).Value
        cmbSeverityLevel.Text = dgvListDetailMenu.Item(4, dgvListDetailMenu.CurrentRow.Index).Value
        txtSolutions.Text = dgvListDetailMenu.Item(7, dgvListDetailMenu.CurrentRow.Index).Value
        If dgvListDetailMenu.Item(8, dgvListDetailMenu.CurrentRow.Index).Value = "Y" Then
            cboAktif.Checked = True
        Else
            cboAktif.Checked = False
        End If

        txtKode.Enabled = False
        btnProses.Text = "UPDATE"
    End Sub


    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)
        If txtID.Text = "" Then
            txtKode.Enabled = True
            btnProses.Text = "ADD"
        Else
            txtKode.Enabled = False
            btnProses.Text = "UPDATE"
        End If
    End Sub

    Private Sub cmbSubCategories_Click(sender As Object, e As EventArgs) Handles cmbSubCategories.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubCategories, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE  StatusEnabled='Y' AND Cast(IDCategories AS varchar(100))='" & cmbHeaders.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbSubCategories_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubCategories.SelectionChangeCommitted
        dgvListDetailMenu.DataSource = Nothing
        dgvListDetailMenu.Rows.Clear()
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListDetailMenu, "Select * from Categories2 Where Cast(IDCategories AS varchar(100))='" & cmbHeaders.SelectedValue & "' and IDSub='" & cmbSubCategories.SelectedValue & "'", KoneksiDBEmail)
    End Sub

    Private Sub txtKode_TextChanged(sender As Object, e As EventArgs) Handles txtKode.TextChanged
        If btnProses.Text = "ADD" Then
            txtKode.Enabled = True
        End If


        If btnProses.Text = "UPDATE" Then
            txtKode.Enabled = False
            btnProses.Text = "UPDATE"

        End If
       
    End Sub
End Class