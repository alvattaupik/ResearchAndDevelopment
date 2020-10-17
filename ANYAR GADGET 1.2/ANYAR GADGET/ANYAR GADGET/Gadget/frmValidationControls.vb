Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmValidationControls

    Private Sub cmdRefreshMaster_Click(sender As Object, e As EventArgs) Handles cmdRefreshMaster.Click
        Koneksi_SAP()
        LoadDataGrid(dgDaftarKontrol, "SELECT DISTINCT CAST(NamaValidasi AS VARCHAR(150)) AS NamaValidasi,CAST(Notifikasi AS VARCHAR(150)) AS Notifikasi,CAST(Fungsi AS VARCHAR(150)) AS Fungsi,KodeValidasi from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%'", KoneksiSAP)
    End Sub
    Private Sub txtCariKontrol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariKontrol.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Koneksi_SAP()
                LoadDataGrid(dgDaftarKontrol, "SELECT DISTINCT CAST(NamaValidasi AS VARCHAR(150)) AS NamaValidasi,CAST(Notifikasi AS VARCHAR(150)) AS Notifikasi,CAST(Fungsi AS VARCHAR(150)) AS Fungsi,KodeValidasi from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%'", KoneksiSAP)
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub
    Private Sub dgDaftarKontrol_DoubleClick(sender As Object, e As EventArgs) Handles dgDaftarKontrol.DoubleClick
        Try
            If dgDaftarKontrol.RowCount = 0 Then Exit Sub
            frmListLokasiValidasi.txtKodeValidasi.Text = dgDaftarKontrol.Item(3, dgDaftarKontrol.CurrentRow.Index).Value
            frmListLokasiValidasi.txtFungsiValidasi.Text = dgDaftarKontrol.Item(2, dgDaftarKontrol.CurrentRow.Index).Value
            frmListLokasiValidasi.txtNotifikasi.Text = dgDaftarKontrol.Item(1, dgDaftarKontrol.CurrentRow.Index).Value
            frmListLokasiValidasi.txtJenisValidasi.Text = dgDaftarKontrol.Item(0, dgDaftarKontrol.CurrentRow.Index).Value
            frmListLokasiValidasi.ShowDialog()
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub
    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Call Koneksi_SAP()
        LoadDataGrid(dgUnlocked, "Select * from V_DaftarKontrolValidasi Where StatusEnabled='0'", KoneksiSAP)
    End Sub

    Private Sub dgUnlocked_Click(sender As Object, e As EventArgs) Handles dgUnlocked.Click
        On Error Resume Next
        If dgUnlocked.RowCount = 0 Then Exit Sub
        frmLockControlValidasi.txtDocNum.Text = dgUnlocked.Item(5, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.txtJenisvalidasi.Text = dgUnlocked.Item(0, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.txtNotifikasi.Text = dgUnlocked.Item(2, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.txtCatatan.Text = dgUnlocked.Item(9, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.txtRef.Text = dgUnlocked.Item(8, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.txtCabang.Text = dgUnlocked.Item(1, dgUnlocked.CurrentRow.Index).Value
        frmLockControlValidasi.ShowDialog()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub frmValidationControls_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi_SAP()
        LoadDataGrid(dgUnlocked, "Select * from V_DaftarKontrolValidasi Where StatusEnabled='0'", KoneksiSAP)
        Koneksi_SAP()
        LoadDataGrid(dgDaftarKontrol, "SELECT DISTINCT CAST(NamaValidasi AS VARCHAR(150)) AS NamaValidasi,CAST(Notifikasi AS VARCHAR(150)) AS Notifikasi,CAST(Fungsi AS VARCHAR(150)) AS Fungsi,KodeValidasi from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%'", KoneksiSAP)
    End Sub

    Private Sub cmdNewControl_Click(sender As Object, e As EventArgs) Handles cmdNewControl.Click
        frmAddNewControl.ShowDialog()
    End Sub
End Class