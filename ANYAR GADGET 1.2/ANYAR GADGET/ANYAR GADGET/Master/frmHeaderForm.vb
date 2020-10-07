Imports System.Data
Imports System.Data.SqlClient
Public Class frmHeaderForm

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Text = ""
        txtKode.Text = ""
        txtDeskripsi.Text = ""
        txtNamaExternal.Text = ""
        btnProses.Text = "ADD"
    End Sub


    Private Sub frmHeaderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvHeaderForm, "Select * From OForm Where (KodeForm Like '%" & Trim(txtCariHeader.Text) & "%' OR Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or NamaExternal Like '%" & Trim(txtNamaExternal.Text) & "%') AND KodeAplikasi='AG'", KoneksiDBEmail)
    End Sub

    Private Sub txtCariHeader_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariHeader.KeyPress

        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgvHeaderForm, "Select * From OForm Where (KodeForm Like '%" & Trim(txtCariHeader.Text) & "%' OR Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or NamaExternal Like '%" & Trim(txtNamaExternal.Text) & "%') AND KodeAplikasi='AG'", KoneksiDBEmail)

        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub





        
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

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()

        Dim strCeklis As String

        If chkAktif.Checked = True Then
            strCeklis = "Y"
        Else
            strCeklis = "N"
        End If

        If btnProses.Text = "ADD" Then

            Call AUD_MenuAplikasi("A_HeaderForm", "", txtKode.Text, "", txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            Bersihkan()
            LoadDataGrid(dgvHeaderForm, "Select * From OForm Where (KodeForm Like '%" & Trim(txtCariHeader.Text) & "%' OR Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or NamaExternal Like '%" & Trim(txtNamaExternal.Text) & "%') AND KodeAplikasi='AG'", KoneksiDBEmail)
        Else

            Call AUD_MenuAplikasi("U_HeaderForm", txtID.Text, txtKode.Text, "", txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            LoadDataGrid(dgvHeaderForm, "Select * From OForm Where (KodeForm Like '%" & Trim(txtCariHeader.Text) & "%' OR Deskripsi Like '%" & Trim(txtCariHeader.Text) & "%' Or NamaExternal Like '%" & Trim(txtNamaExternal.Text) & "%') AND KodeAplikasi='AG'", KoneksiDBEmail)
        End If



    End Sub


    Sub Bersihkan()
        txtID.Text = ""
        txtKode.Text = ""
        txtDeskripsi.Text = ""
        txtNamaExternal.Text = ""
        btnProses.Text = "ADD"
    End Sub


    Private Sub dgvHeaderForm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHeaderForm.CellClick
        txtID.Text = dgvHeaderForm.Item(0, dgvHeaderForm.CurrentRow.Index).Value
        txtKode.Text = dgvHeaderForm.Item(1, dgvHeaderForm.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvHeaderForm.Item(2, dgvHeaderForm.CurrentRow.Index).Value
        txtNamaExternal.Text = dgvHeaderForm.Item(3, dgvHeaderForm.CurrentRow.Index).Value

        If dgvHeaderForm.Item(5, dgvHeaderForm.CurrentRow.Index).Value = "Y" Then
            chkAktif.Checked = True
        Else
            chkAktif.Checked = False
        End If

    End Sub

End Class