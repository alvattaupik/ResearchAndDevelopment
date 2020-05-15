Imports System.Data.SqlClient
Public Class FormHelp
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long






    Sub LihatDaftarBantuan()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("SELECT KodeKonten,NamaKonten,PathKonten FROM dbo.HelpKonten Where NamaKonten like '" & txtCariBantuan.Text & "%' And StatusEnabled='Y'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgDaftarBantuan.DataSource = table
        dgDaftarBantuan.Columns(0).Width = 150
        dgDaftarBantuan.Columns(1).Width = 1000
        dgDaftarBantuan.Columns(2).Width = 0
    End Sub



    Private Sub cmdLihat_Click(sender As Object, e As EventArgs) Handles cmdLihat.Click
        Dim strPathHelp As String

        strPathHelp = dgDaftarBantuan.Item(2, dgDaftarBantuan.CurrentRow.Index).Value

        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)

    End Sub

    Private Sub txtCariBantuan_TextChanged(sender As Object, e As EventArgs) Handles txtCariBantuan.TextChanged
        LihatDaftarBantuan()
    End Sub

    Private Sub FormHelp_Load(sender As Object, e As EventArgs) Handles Me.Load
        LihatDaftarBantuan()
    End Sub
End Class