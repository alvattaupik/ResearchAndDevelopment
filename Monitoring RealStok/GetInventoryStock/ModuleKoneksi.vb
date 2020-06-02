Imports System.Data.SqlClient


Module ModuleKoneksi

    Public Sub conn_get()
        'conn_server = GetSetting("Buku", "Pengaturan", "server", "")
        'conn_user = GetSetting("Buku", "Pengaturan", "user", "")
        'conn_pass = GetSetting("Buku", "Pengaturan", "pass", "")
        'conn_database = GetSetting("Buku", "Pengaturan", "database", "")
        'conn_server
        'conn_user
        'conn_pass
        'conn_database

    End Sub

    Public Sub conn_save(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal data As String)
        'Call SaveSetting("Buku", "Pengaturan", "server", server)
        'Call SaveSetting("Buku", "Pengaturan", "user", user)
        'Call SaveSetting("Buku", "Pengaturan", "pass", pass)
        'Call SaveSetting("Buku", "Pengaturan", "database", data)
        'Call conn_get()


    End Sub

    Public Function koneksi() As Boolean
        Try

            'server = "data source={0};user id={1};password={2};initial catalog={3}"

            server = "data source=" & conn_server & ";user id=" & conn_user & ";password=" & conn_pass & ";initial catalog=" & conn_database & ";Application Name=Monitoring Realstock 1.1;MultipleActiveResultSets=True  "
            server = String.Format(server, conn_server, conn_user, conn_pass, conn_database)

            conn = New SqlConnection(server)
            conn.Open()


            Return True
        Catch ex As Exception
            MsgBox("Connection Error" + vbNewLine + "Please Check Setting Info!", MsgBoxStyle.Critical, "ERROR")

            Return False
        End Try

    End Function

    Public Function Testkoneksi() As Boolean
        Try
            server = "data source={0};user id={1};password={2};initial catalog={3}"
            'server = "data source={" & conn_server & "};user id={" & conn_user & "};password={" & conn_pass & "};initial catalog={" & conn_database & "}"
            server = String.Format(server, tempstrconn_server, tempstrconn_user, tempstrconn_pass, tempstrconn_database)
            conn = New SqlConnection(server)
            conn.Open()
            MsgBox("Koneksi Berhasil" + MsgBoxStyle.Information, "Sukses")
            Return True
        Catch ex As Exception
            MsgBox("Connection Error" + vbNewLine + "Please Check Setting Info!", MsgBoxStyle.Critical, "ERROR")
            Return False
        End Try
    End Function


End Module