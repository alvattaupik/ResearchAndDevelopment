Imports System.Data
Imports System.Data.SqlClient
Public Class frmDetailMenu

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtKode.Text = ""
        txtID.Text = ""
        txtNamaExternal.Text = ""
        txtDeskripsi.Text = ""
        cboAktif.Checked = True
        btnProses.Text = "ADD"


    End Sub

    Private Sub frmDetailMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Menu1 WHere Kode= '" & Trim(cmbHeaders.SelectedValue) & "' AND KodeAplikasi='" & MstrKodeAplikasi & "' ", KoneksiDBEmail)
    End Sub




    Private Sub cmbHeaders_Click(sender As Object, e As EventArgs) Handles cmbHeaders.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbHeaders, "SELECT Kode,Deskripsi FROM dbo.OMenu WHERE KodeAplikasi='AG' AND StatusEnabled='Y'", "Kode", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbHeaders_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeaders.SelectionChangeCommitted
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListDetailMenu, "Select * from Menu1 Where Kode='" & cmbHeaders.SelectedValue & "' AND KodeAplikasi='AG'", KoneksiDBEmail)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()


        Dim strCeklis As String

        If cboAktif.Checked = True Then
            strCeklis = "Y"
        Else
            strCeklis = "N"
        End If

        If btnProses.Text = "ADD" Then

            Call AUD_MenuAplikasi("A_DetailMenu", txtID.Text, cmbHeaders.SelectedValue, txtKode.Text, txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            Bersihkan()
            LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Menu1 WHere Kode Like '%" & Trim(cmbHeaders.SelectedValue) & "%' AND KodeAplikasi='" & MstrKodeAplikasi & "' ", KoneksiDBEmail)
        Else

            Call AUD_MenuAplikasi("U_DetailMenu", txtID.Text, cmbHeaders.SelectedValue, txtKode.Text, txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            LoadDataGrid(dgvListDetailMenu, "SELECT * FROM dbo.Menu1 WHere Kode Like '%" & Trim(cmbHeaders.SelectedValue) & "%' AND KodeAplikasi='" & MstrKodeAplikasi & "' ", KoneksiDBEmail)
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
        txtKode.Text = dgvListDetailMenu.Item(1, dgvListDetailMenu.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvListDetailMenu.Item(2, dgvListDetailMenu.CurrentRow.Index).Value
        txtNamaExternal.Text = dgvListDetailMenu.Item(3, dgvListDetailMenu.CurrentRow.Index).Value
        If dgvListDetailMenu.Item(5, dgvListDetailMenu.CurrentRow.Index).Value = "Y" Then
            cboAktif.Checked = True
        Else
            cboAktif.Checked = False
        End If
    End Sub


    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text = "" Then
            txtKode.Enabled = True
            btnProses.Text = "ADD"
        Else
            txtKode.Enabled = False
            btnProses.Text = "UPDATE"
        End If
    End Sub
End Class