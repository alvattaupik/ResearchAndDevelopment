Imports System.Data.SqlClient

Module ModuleVariable
    Public strSQl As String
    Public da1 As SqlDataAdapter
    Public ds1 As DataSet
    Public cmd1 As SqlCommand
    Public dr1 As SqlDataReader
    Public dt1 As DataTable


    Public strKoneksi As String
    Public strSQLDataPegawai As String
    Public strKodePegawai, strNamaPegawai, strEmailPegawai, strUsernameLogin, strPasswordLogin As String

    Public strNamaKomputer, strAlamatIP As String


End Module
