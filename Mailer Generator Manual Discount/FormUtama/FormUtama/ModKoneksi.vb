Imports System.Data.Sql
Imports System.Data.SqlClient


Module ModKoneksi
    Public Koneksi As SqlConnection
    Public Koneksi2 As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Dim strServer As String
    Dim strNamaDatabase As String
    Dim strUserNameDB As String
    Dim strPasswordDB As String



    Public Sub KoneksiDatabase()

        strServer = "10.1.0.55"
        strNamaDatabase = "CXSRetail_HO_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"



        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";Application Name=Manual Discount Notification 1.0;MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub



    Public Sub KoneksiDatabaseEmail()

        strKoneksi2 = "data source=" & strLokasiDBEmail & ";user id=" & strusernameDatabaseEmail & ";password=" & strPassswordDatabaseEmail & ";initial catalog=" & strNamaDatabaseEmail & ";Application Name=Manual Discount Notification 1.0;MultipleActiveResultSets=True  "
        strKoneksi2 = String.Format(strKoneksi2, strLokasiDBEmail, strusernameDatabaseEmail, strPassswordDatabaseEmail, strNamaDatabaseEmail)

        Koneksi2 = New SqlConnection(strKoneksi2)

        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub



End Module
