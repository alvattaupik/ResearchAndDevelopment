Imports MySql.Data.MySqlClient
Imports System.Data
Module ModuleKoneksi
    Public Koneksi1 As MySqlConnection
    Public Koneksi2 As MySqlConnection
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet

    Public param As MySqlParameter

    Public cmd As MySql.Data.MySqlClient.MySqlCommand
    Public rd As MySql.Data.MySqlClient.MySqlDataReader

    Public strKoneksi1 As String
    Public strKoneksi2 As String


    'Public strServer As String
    'Public strNamaDatabase As String
    'Public strUserNameDB As String
    'Public strPasswordDB As String

    Public strNamaUser As String
    Public strUsernameSAP As String
    Public strPort As String


    Public strKodeUser As String

    Public connDB As New MySqlConnection
    Public comDB As New MySqlCommand
    Public rdDB As MySqlDataReader
    Public myError As MySqlError
    Public SQL As String
    Public bolStatusKoneksi As Boolean

    Public strServer As String
    Public strDbase As String
    Public strUser As String
    Public strPass As String


    Public Sub conecDB()
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass
        If connDB.State <> ConnectionState.Open Then connDB.Open()
    End Sub


    Public Sub TestconecDB()
        If connDB.State <> ConnectionState.Open Then
            connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass
            bolStatusKoneksi = True
        Else
            bolStatusKoneksi = False
        End If

        If connDB.State <> ConnectionState.Open Then connDB.Open()
    End Sub



    'Close the connection from database
    Public Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    'Initialize the sql command object
    Public Sub initCMD()
        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 0
        End With
    End Sub










End Module
