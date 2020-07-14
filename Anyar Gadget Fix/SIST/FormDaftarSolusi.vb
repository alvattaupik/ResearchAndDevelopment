Imports System.Data.SqlClient
Public Class FormDaftarSolusi
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Private Sub cmdTampilkanSolusi_Click(sender As Object, e As EventArgs) Handles cmdTampilkanSolusi.Click
        Dim strPathHelp As String

        strPathHelp = dgDaftarSolusi.Item(2, dgDaftarSolusi.CurrentRow.Index).Value

        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub FormDaftarSolusi_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT KodeKonten AS KodeError,NamaKonten As JenisError,isnull(PathKonten,'')As PathKonten FROM dbo.HelpKonten Where (NamaKonten like '%" & txtCariSolusi.Text & "%' or KodeKonten Like '%" & txtCariSolusi.Text & "%') And StatusEnabled='Y' AND KodeFungsi='Solusi Integrasi'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarSolusi.DataSource = table
        dgDaftarSolusi.Columns(0).Width = 150
        dgDaftarSolusi.Columns(1).Width = 3000
        dgDaftarSolusi.Columns(2).Width = 0
        dgDaftarSolusi.RowHeadersVisible = False

    End Sub

    Private Sub txtCariSolusi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariSolusi.KeyPress
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT KodeKonten AS KodeError,NamaKonten As JenisError,isnull(PathKonten,'')As PathKonten FROM dbo.HelpKonten Where (NamaKonten like '%" & txtCariSolusi.Text & "%' or KodeKonten Like '%" & txtCariSolusi.Text & "%') And StatusEnabled='Y' AND KodeFungsi='Solusi Integrasi'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarSolusi.DataSource = table
        dgDaftarSolusi.Columns(0).Width = 150
        dgDaftarSolusi.Columns(1).Width = 3000
        dgDaftarSolusi.Columns(2).Width = 0
        dgDaftarSolusi.RowHeadersVisible = False
    End Sub
End Class