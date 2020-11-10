Imports System.Data.Sql
Imports System.Data
Public Class frmBrowseUsers


    Sub LoadDaftarUser()
        Dim strQuery As String = "SELECT UserNameLogin,NamaPegawai FROM dbo.OLogin" & _
                                " LEFT OUTER JOIN dbo.OEmployee ON OEmployee.ID=EmployeeID" & _
                                " Where OLogin.UserNameLogin Like '%" & Trim(txtCariPegawai.Text) & "%' Or NamaPegawai Like '%" & Trim(txtCariPegawai.Text) & "%'"
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListUsers, strQuery, KoneksiDBEmail)
    End Sub

    Private Sub dgvListUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListUsers.CellContentClick
        CType(frmMainMenu.ActiveMdiChild, frmSetttingUsers).txtUsername.Text = dgvListUsers.Rows(e.RowIndex).Cells(0).Value()
        CType(frmMainMenu.ActiveMdiChild, frmSetttingUsers).btnCariUser.PerformClick()
        Me.Close()
    End Sub



    Private Sub txtCariPegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariPegawai.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                LoadDaftarUser()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub
End Class
