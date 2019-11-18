Imports System.Data.SqlClient
Public Class FormKillSession
    Dim strSessionID As String
    Private Sub FormKillSession_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadSession()
    End Sub


    Sub loadSession()

        KoneksiDatabase2()
        Dim cmd As New SqlCommand("SELECT @@SPID AS 'ID', SYSTEM_USER AS 'Login Name'", Koneksi2)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)



        If table.Rows.Count > 0 Then
            strSessionID = table.Rows(0).Item(0)
        Else
            Exit Sub
        End If

        Koneksi2.Close()
    End Sub




    Private Sub cmdKIll_Click(sender As Object, e As EventArgs) Handles cmdKIll.Click
        If Trim(txtIdSession.Text) = strSessionID Then
            MsgBox("Anda Tidak dapat Mengakhiri Session Anda Sendiri", vbCritical, "Warning!")
            Exit Sub
        End If
    End Sub
End Class