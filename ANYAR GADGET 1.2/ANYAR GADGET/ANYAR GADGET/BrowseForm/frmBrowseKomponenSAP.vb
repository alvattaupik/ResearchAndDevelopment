Imports System.Data.SqlClient
Public Class frmBrowseKomponenSAP

    Private Sub txtCariKomponen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariKomponen.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            Call KoneksiDB_EMAIL()
            LoadDataGrid(dgDaftarKomponenSAP, "SELECT Top 10 * FROM V_KomponenSAP Where NamaKomponen Like '%" & Trim(txtCariKomponen.Text) & "%' Or DocCode  Like '%" & Trim(txtCariKomponen.Text) & "%'", KoneksiDBEmail)
        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

 

    Private Sub dgDaftarKomponenSAP_Click(sender As Object, e As EventArgs) Handles dgDaftarKomponenSAP.Click
        frmAddNewControl.txtKodeJenis.Text = dgDaftarKomponenSAP.Item(0, dgDaftarKomponenSAP.CurrentRow.Index).Value

        Me.Dispose()
        dgDaftarKomponenSAP.DataSource = Nothing
    End Sub
End Class