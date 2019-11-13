Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleKoneksi
    Public Koneksi As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Dim strServer As String
    Dim strNamaDatabase As String
    Dim strUserNameDB As String
    Dim strPasswordDB As String





    Public Sub KoneksiDatabase()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_Email"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"



        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";Application Name=DBAsset Export 1.1;MultipleActiveResultSets=True  "
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







End Module
