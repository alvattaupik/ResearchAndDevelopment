Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleKoneksi

    Public strServer As String
    Public strNamaDatabase As String
    Public strUserNameDB As String
    Public strPasswordDB As String
    Public Koneksi1 As SqlConnection
    Public Koneksi2 As SqlConnection

    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader

    Public Sub KoneksiDatabase1()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_EMAIL"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"
        Dim strKoneksi1 As String


        strKoneksi1 = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
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
