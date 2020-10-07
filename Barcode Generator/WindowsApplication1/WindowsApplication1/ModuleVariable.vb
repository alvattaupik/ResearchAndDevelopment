Imports System.Data.SqlClient
Module ModuleVariable

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


End Module
