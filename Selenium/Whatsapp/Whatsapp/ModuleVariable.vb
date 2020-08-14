Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleVariable

    Public Koneksi As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public strKoneksiSQLSRV As String
    Public KoneksiSQLSRV As SqlConnection
    Public bolStatusKoneksiSQLServer As Boolean

    Public MdblDurasiDetikTimerNotifikasi As Long
    Public LongDurasi As Long


    Public strNamaServerCheck As String
    Public strNamaDatabaseCheck As String
    Public strUserNameCheck As String
    Public strPasswordCheck As String


    Public strNamaUser As String
    Public strKodePegawai As String




    Public bolStatusKoneksi As Boolean

    Public GlobalNoRM As String
    Public GlobalNoPendaftaran As String
    Public GlobalNamaForm As String
    Public GlobalKodeRuangan As String
    Public GlobalKodePetugasKesehatan As String
    Public GlobalJenisPasien As String


End Module
