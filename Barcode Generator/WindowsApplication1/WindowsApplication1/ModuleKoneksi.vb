Imports System.Data.SqlClient
Module ModuleKoneksi



    Public Sub KoneksiDatabaseDB_EMAIL()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_email"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksi1 = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Member Card Monitoring 1.0;  "
        strKoneksi1 = String.Format(strKoneksi1, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        Koneksi1 = New SqlConnection(strKoneksi1)

        Try
            If Koneksi1.State = ConnectionState.Closed Then
                Koneksi1.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


End Module
