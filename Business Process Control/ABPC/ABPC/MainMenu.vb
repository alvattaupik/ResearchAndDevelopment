Imports System.Data.SqlClient

Public Class MainMenu

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtCariKontrol.TextChanged
        If My.Settings.ServerName = "" Then
            MsgBox("Setting Database Belum Diatur", vbInformation, "Perhatian !")
            FormKoneksiDatabase.ShowDialog()
            Exit Sub
        End If

        LoadMasterValidasi()


    End Sub




    Sub LoadMasterValidasi()

        Call KoneksiDatabase2()

        'Dim cmd As New SqlCommand("Select * from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%' AND StatusEnabled='1'", Koneksi2)

        Dim cmd As New SqlCommand("SELECT DISTINCT CAST(NamaValidasi AS VARCHAR(150)) AS NamaValidasi,CAST(Notifikasi AS VARCHAR(150)) AS Notifikasi,CAST(Fungsi AS VARCHAR(150)) AS Fungsi,KodeValidasi from V_DaftarKontrolValidasi Where Notifikasi Like '%" & Trim(txtCariKontrol.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgDaftarKontrol.DataSource = table
        dgDaftarKontrol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarKontrol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarKontrol.AutoResizeColumns()

    End Sub



    Sub LoadUnlockControl()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("Select * from V_DaftarKontrolValidasi Where StatusEnabled='0'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        dgUnlocked.DataSource = table
        dgUnlocked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgUnlocked.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgUnlocked.AutoResizeColumns()

    End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FormKoneksiDatabase.ShowDialog()
    End Sub

 
    Private Sub dgDaftarKontrol_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarKontrol.CellContentDoubleClick
        If dgDaftarKontrol.RowCount = 0 Then Exit Sub

        'MstrDocNum = dgDaftarKontrol.Item(5, dgDaftarKontrol.CurrentRow.Index).Value
        'MstrKodeCabang = dgDaftarKontrol.Item(6, dgDaftarKontrol.CurrentRow.Index).Value
        'MstrNamaCabang = dgDaftarKontrol.Item(1, dgDaftarKontrol.CurrentRow.Index).Value

        MstrNamaValidasi = dgDaftarKontrol.Item(0, dgDaftarKontrol.CurrentRow.Index).Value
        MstrNotifikasi = dgDaftarKontrol.Item(1, dgDaftarKontrol.CurrentRow.Index).Value
        MstrFungsi = dgDaftarKontrol.Item(2, dgDaftarKontrol.CurrentRow.Index).Value
        MstrKodeValidasi = dgDaftarKontrol.Item(3, dgDaftarKontrol.CurrentRow.Index).Value



        'MstrNotifikasi = dgDaftarKontrol.Item(2, dgDaftarKontrol.CurrentRow.Index).Value
        'MstrStatusEnabled = dgDaftarKontrol.Item(4, dgDaftarKontrol.CurrentRow.Index).Value



        'FormUpdateControl.ShowDialog()
        FormListValidasi.ShowDialog()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Private Sub cmdNewControl_Click(sender As Object, e As EventArgs) Handles cmdNewControl.Click
        FormAddControl.ShowDialog()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMasterValidasi()
        LoadUnlockControl()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadUnlockControl()
    End Sub

    Private Sub cmdRefreshMaster_Click(sender As Object, e As EventArgs) Handles cmdRefreshMaster.Click
        LoadMasterValidasi()
    End Sub


    Private Sub dgUnlocked_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUnlocked.CellContentDoubleClick
        If dgUnlocked.RowCount = 0 Then Exit Sub

        MstrDocNum = dgUnlocked.Item(5, dgUnlocked.CurrentRow.Index).Value
        MstrKodeCabang = dgUnlocked.Item(6, dgUnlocked.CurrentRow.Index).Value
        MstrNamaCabang = dgUnlocked.Item(1, dgUnlocked.CurrentRow.Index).Value


        MstrKodeValidasi = dgUnlocked.Item(7, dgUnlocked.CurrentRow.Index).Value
        MstrNamaValidasi = dgUnlocked.Item(0, dgUnlocked.CurrentRow.Index).Value

        MstrFungsi = dgUnlocked.Item(3, dgUnlocked.CurrentRow.Index).Value
        MstrNotifikasi = dgUnlocked.Item(2, dgUnlocked.CurrentRow.Index).Value
        MstrStatusEnabled = dgUnlocked.Item(4, dgUnlocked.CurrentRow.Index).Value

        FormUpdateControlValidasi.ShowDialog()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub




End Class