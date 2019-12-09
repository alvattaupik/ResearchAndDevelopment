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
        Else

            Call KoneksiDatabase6()

            Dim sqlCon = New SqlConnection(strKoneksi6)

            Using (sqlCon)

                Dim sqlComm As New SqlCommand

                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "[tmspEndSession]"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("KodeSession", Trim(txtIdSession.Text))
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()

            End Using
            MsgBox("Kill Session Berhasil ! Silahkan Lihat Process Rollback", vbInformation, "Informasi")
            LoadBackgroundProcess()

        End If

        LoadBackgroundProcess()

    End Sub

    Sub loadStatusRollback()
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


    Sub LoadBackgroundProcess()

        KoneksiDatabase6()
        Dim cmd As New SqlCommand("SELECT spid,sys.sysprocesses.status,hostname,cpu,memusage,physical_io," & _
        " SYS.DM_EXEC_REQuESTS.percent_complete,SYS.DM_EXEC_REQuESTS.estimated_completion_time " & _
        " FROM sys.sysprocesses LEFT OUTER JOIN	 SYS.DM_EXEC_REQuESTS ON SYS.DM_EXEC_REQuESTS.session_id=sys.sysprocesses.spid " & _
        " WHERE sys.sysprocesses.spid= '" & Trim(txtIdSession.Text) & "'", Koneksi6)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgBackgroundProcess.DataSource = table
        Koneksi6.Close()

    End Sub



End Class