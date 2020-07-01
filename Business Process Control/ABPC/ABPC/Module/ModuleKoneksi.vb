Imports System.Data.SqlClient
Module ModuleKoneksi
    Public Koneksi1 As SqlConnection
    Public Koneksi2 As SqlConnection
    Public strKoneksi1 As String
    Public strKoneksi2 As String
    Public bolStatusKoneksi As Boolean

    Public strServer As String
    Public strNamaDatabase As String
    Public strUserNameDB As String
    Public strPasswordDB As String


    Public strServer2 As String
    Public strNamaDatabase2 As String
    Public strUserNameDB2 As String
    Public strPasswordDB2 As String



    Public strNamaUser As String
    Public strUsernameSAP As String

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



    Public Sub KoneksiDatabase2()

        strServer2 = My.Settings.ServerName
        strNamaDatabase2 = My.Settings.NamaDatabase
        strUserNameDB2 = My.Settings.UsernameDatabase
        strPasswordDB2 = My.Settings.PasswordDatabase

        strKoneksi2 = "data source=" & strServer2 & ";user id=" & strUserNameDB2 & ";password=" & strPasswordDB2 & ";initial catalog=" & strNamaDatabase2 & ";MultipleActiveResultSets=True;Application Name=BCP V1.0;  "
        strKoneksi2 = String.Format(strKoneksi2, strServer2, strUserNameDB2, strPasswordDB2, strNamaDatabase2)
        Koneksi2 = New SqlConnection(strKoneksi2)

        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub






    Public Sub CekKoneksiDatabase()


        strKoneksi2 = "data source=" & strServer2 & ";user id=" & strUserNameDB2 & ";password=" & strPasswordDB2 & ";initial catalog=" & strNamaDatabase2 & ";MultipleActiveResultSets=True;Application Name=BCP V1.0;  "
        strKoneksi2 = String.Format(strKoneksi2, strServer2, strUserNameDB2, strPasswordDB2, strNamaDatabase2)
        Koneksi2 = New SqlConnection(strKoneksi2)

        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
                bolStatusKoneksi = True
            End If
        Catch ex As Exception
            bolStatusKoneksi = False
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub









End Module
