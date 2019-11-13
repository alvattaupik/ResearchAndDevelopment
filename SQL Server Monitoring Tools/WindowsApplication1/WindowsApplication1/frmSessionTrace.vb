Imports System.Data.SqlClient

Public Class frmSessionTrace




    Sub LoadDetailSession()

        KoneksiDatabase4()
        Dim cmd As New SqlCommand("SELECT  hostname AS NamaHost,S.program_name AS NamaProgram," & _
                                  " net_library AS TipeKoneksi,net_address,client_net_address AS IpClient " & _
                                  " FROM    sys.sysprocesses AS S INNER JOIN    sys.dm_exec_connections AS decc ON S.spid = decc.session_id " & _
                                  " WHERE   spid = '" & Trim(txtIdSesi.Text) & "'", Koneksi4)
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
End Class