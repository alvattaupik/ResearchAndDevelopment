Imports System.Data
Imports System.Data.SqlClient
Public Class frmHeaderCategories

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Text = ""
        txtKode.Text = ""
        txtNamaExternal.Text = ""
        txtDeskripsi.Text = ""
        btnProses.Text = "ADD"
    End Sub




    Private Sub frmHeaderMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvHeaderMenu, "SELECT * FROM dbo.OCategories WHere Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' ", KoneksiDBEmail)
    End Sub

    Private Sub txtCariHeader_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariHeader.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            LoadDataGrid(dgvHeaderMenu, "SELECT * FROM dbo.OCategories WHere (Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or IDCategories Like '%" & Trim(txtCariHeader.Text) & "%') ", KoneksiDBEmail)

        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub



    End Sub

    Private Sub dgvHeaderMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHeaderMenu.CellClick
        txtID.Text = dgvHeaderMenu.Item(0, dgvHeaderMenu.CurrentRow.Index).Value
        'txtKode.Text = dgvHeaderMenu.Item(1, dgvHeaderMenu.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvHeaderMenu.Item(1, dgvHeaderMenu.CurrentRow.Index).Value
        txtNamaExternal.Text = dgvHeaderMenu.Item(2, dgvHeaderMenu.CurrentRow.Index).Value
        If dgvHeaderMenu.Item(4, dgvHeaderMenu.CurrentRow.Index).Value = "Y" Then
            chkAktif.Checked = True
        Else
            chkAktif.Checked = False
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()

        Dim strCeklis As String

        If chkAktif.Checked = True Then
            strCeklis = "Y"
        Else
            strCeklis = "N"
        End If

        If btnProses.Text = "ADD" Then

            Call AUD_MenuAplikasi("A_HeaderMenuITILV3", "", txtKode.Text, "", txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            Bersihkan()
            LoadDataGrid(dgvHeaderMenu, "SELECT * FROM dbo.OCategories WHere (Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or IDCategories Like '%" & Trim(txtCariHeader.Text) & "%')", KoneksiDBEmail)
        Else

            Call AUD_MenuAplikasi("U_HeaderMenuITILV3", txtID.Text, txtKode.Text, "", txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            LoadDataGrid(dgvHeaderMenu, "SELECT * FROM dbo.OCategories WHere (Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or IDCategories Like '%" & Trim(txtCariHeader.Text) & "%')", KoneksiDBEmail)
        End If

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        If txtID.Text = "" Then
            txtKode.Enabled = True
            btnProses.Text = "Add"
        Else
            txtKode.Enabled = False
            btnProses.Text = "Update"
        End If

    End Sub


    Sub Bersihkan()
        txtID.Text = ""
        txtKode.Text = ""
        txtNamaExternal.Text = ""
        txtDeskripsi.Text = ""
    End Sub



End Class