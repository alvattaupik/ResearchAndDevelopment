Imports System.Data.SqlClient

Public Class frmSessionTrace




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


    Private Sub cmdFindSession_Click(sender As Object, e As EventArgs) Handles cmdFindSession.Click
        LoadDetailSession()
    End Sub

    Private Sub dgSessionTrace_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSessionTrace.CellContentClick
        txtStatus.Text = dgSessionTrace.Item(0, dgSessionTrace.CurrentRow.Index).Value
        txtNamaProgram.Text = dgSessionTrace.Item(4, dgSessionTrace.CurrentRow.Index).Value
        txtQuery.Text = dgSessionTrace.Item(3, dgSessionTrace.CurrentRow.Index).Value
    End Sub

    Private Sub dgSessionTrace_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSessionTrace.CellContentDoubleClick

    End Sub

    Private Sub cmdcopyclipboard_Click(sender As Object, e As EventArgs) Handles cmdcopyclipboard.Click
        Clipboard.SetText(txtQuery.Text)
    End Sub
End Class