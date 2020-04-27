Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module ModuleKoneksi

    Public Koneksi1 As SqlConnection
    Public Koneksi2 As SqlConnection
    Public strKoneksi1 As String
    Public strKoneksi2 As String

    Public strServer As String
    Public strNamaDatabase As String
    Public strUserNameDB As String
    Public strPasswordDB As String

    Public strNamaUser As String
    Public strUsernameSAP As String



    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader







    Public Sub KoneksiDatabaseIvend()

        strServer = "10.1.0.55"
        strNamaDatabase = "CXSRetail_HO_2"
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
    Public Sub KoneksiDatabaseSAP()

        strServer = "10.1.0.53"
        strNamaDatabase = "RKM_LIVE_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksi2 = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Member Card Monitoring 1.0;  "
        strKoneksi2 = String.Format(strKoneksi2, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
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
