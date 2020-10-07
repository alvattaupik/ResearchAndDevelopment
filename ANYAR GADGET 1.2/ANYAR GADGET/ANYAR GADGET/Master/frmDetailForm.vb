Imports System.Data
Imports System.Data.SqlClient

Public Class frmDetailForm

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtID.Text = ""
        txtKode.Text = ""
        txtDeskripsi.Text = ""
        txtNamaExternal.Text = ""
        btnProses.Text = "ADD"
    End Sub

    Private Sub cmbHeaderForm_Click(sender As Object, e As EventArgs) Handles cmbHeaderForm.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbHeaderForm, "SELECT KodeForm,Deskripsi FROM dbo.OForm WHERE KodeAplikasi='AG' AND StatusEnabled='Y'", "KodeForm", "Deskripsi", KoneksiDBEmail)
    End Sub

    Private Sub cmbHeaderForm_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbHeaderForm.SelectionChangeCommitted
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListDetailForm, "Select * from Form1 Where KodeForm='" & cmbHeaderForm.SelectedValue & "' AND KodeAplikasi='AG'", KoneksiDBEmail)
    End Sub

    Private Sub dgvListDetailForm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListDetailForm.CellClick
        txtID.Text = dgvListDetailForm.Item(0, dgvListDetailForm.CurrentRow.Index).Value
        txtKode.Text = dgvListDetailForm.Item(1, dgvListDetailForm.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvListDetailForm.Item(2, dgvListDetailForm.CurrentRow.Index).Value
        txtNamaExternal.Text = dgvListDetailForm.Item(3, dgvListDetailForm.CurrentRow.Index).Value
        If dgvListDetailForm.Item(5, dgvListDetailForm.CurrentRow.Index).Value = "Y" Then
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

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If btnProses.Text = "OK" Then Me.Dispose()

        Dim strCeklis As String

        If cboAktif.Checked = True Then
            strCeklis = "Y"
        Else
            strCeklis = "N"
        End If

        If btnProses.Text = "ADD" Then

            Call AUD_MenuAplikasi("A_DetailForm", txtID.Text, cmbHeaderForm.SelectedValue, txtKode.Text, txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            Bersihkan()
            LoadDataGrid(dgvListDetailForm, "Select * from Form1 Where KodeForm Like '%" & cmbHeaderForm.SelectedValue & "%' AND KodeAplikasi='AG'", KoneksiDBEmail)
        Else

            Call AUD_MenuAplikasi("U_DetailForm", txtID.Text, cmbHeaderForm.SelectedValue, txtKode.Text, txtDeskripsi.Text, txtNamaExternal.Text, strCeklis)
            LoadDataGrid(dgvListDetailForm, "Select * from Form1 Where KodeForm Like '%" & cmbHeaderForm.SelectedValue & "%' AND KodeAplikasi='AG'", KoneksiDBEmail)
        End If
    End Sub

    Sub Bersihkan()
        txtID.Text = ""
        txtKode.Text = ""
        txtDeskripsi.Text = ""
        txtNamaExternal.Text = ""
        btnProses.Text = "ADD"
    End Sub

End Class