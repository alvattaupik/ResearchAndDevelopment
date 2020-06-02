Imports System.Data.SqlClient

Public Class frmSessionTrace

    Dim strSessionID As String
    Dim BolStatusLoadSession As Boolean


    Sub LoadDetailSession()

        KoneksiDatabase4()

        'Dim cmd As New SqlCommand("SELECT  hostname AS NamaHost,S.program_name AS NamaProgram," & _
        '                          " net_library AS TipeKoneksi,net_address,client_net_address AS IpClient " & _
        '                          " FROM    sys.sysprocesses AS S INNER JOIN    sys.dm_exec_connections AS decc ON S.spid = decc.session_id " & _
        '                          " WHERE   spid = '" & Trim(txtIdSesi.Text) & "'", Koneksi4)


        Dim cmd As New SqlCommand("SELECT S.status,client_net_address AS IpClient,hostname AS NamaHost,text AS Query," & _
                                  " S.program_name AS NamaProgram,net_library AS TipeKoneksi " & _
                                  " FROM    sys.sysprocesses AS S INNER JOIN " & _
                                  " sys.dm_exec_connections AS decc ON S.spid = decc.session_id " & _
                                  " CROSS APPLY sys.dm_exec_sql_text(sql_handle) " & _
                                  " LEFT OUTER JOIN SYS.DM_EXEC_REQUESTS ON sys.dm_exec_requests.connection_id=decc.connection_id " & _
                                  " Where decc.Session_id = '" & Trim(txtIdSesi.Text) & "'", Koneksi4)




        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgSessionTrace.DataSource = table
        'aturDGSAP()
        dgSessionTrace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSessionTrace.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSessionTrace.AutoResizeColumns()
        Koneksi4.Close()


    End Sub



    Sub GetSleepingSession()

        KoneksiDatabase4()
        Dim cmd As New SqlCommand("SELECT * FROM V_GetStatusClient WHERE status='sleeping'", Koneksi4)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgSessionTrace.DataSource = table
        'aturDGSAP()
        dgSessionTrace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgSessionTrace.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgSessionTrace.AutoResizeColumns()
        Koneksi4.Close()


    End Sub








    Private Sub cmdFindSession_Click(sender As Object, e As EventArgs) Handles cmdFindSession.Click
        BolStatusLoadSession = True
        LoadDetailSession()
    End Sub


    Sub loadMySession()

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


    Private Sub dgSessionTrace_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSessionTrace.CellContentClick
        If BolStatusLoadSession = True Then
            txtStatus.Text = dgSessionTrace.Item(0, dgSessionTrace.CurrentRow.Index).Value
            txtNamaProgram.Text = dgSessionTrace.Item(4, dgSessionTrace.CurrentRow.Index).Value
            txtQuery.Text = dgSessionTrace.Item(3, dgSessionTrace.CurrentRow.Index).Value
        Else
            txtStatus.Text = dgSessionTrace.Item(0, dgSessionTrace.CurrentRow.Index).Value
            txtNamaProgram.Text = dgSessionTrace.Item(4, dgSessionTrace.CurrentRow.Index).Value
            txtQuery.Text = dgSessionTrace.Item(3, dgSessionTrace.CurrentRow.Index).Value
            txtIdSesi.Text = dgSessionTrace.Item(6, dgSessionTrace.CurrentRow.Index).Value
        End If
    End Sub

    Private Sub dgSessionTrace_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSessionTrace.CellContentDoubleClick

    End Sub

    Private Sub cmdcopyclipboard_Click(sender As Object, e As EventArgs) Handles cmdcopyclipboard.Click
        Clipboard.SetText(txtQuery.Text)
    End Sub

    Private Sub cmdKillThisSession_Click(sender As Object, e As EventArgs) Handles cmdKillThisSession.Click
        If Trim(txtIdSesi.Text) = strSessionID Then
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
                sqlComm.Parameters.AddWithValue("KodeSession", Trim(txtIdSesi.Text))
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()

            End Using
            MsgBox("Kill Session Berhasil !", vbInformation, "Informasi")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BolStatusLoadSession = False
        GetSleepingSession()
    End Sub
End Class