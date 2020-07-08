Imports System.Data.SqlClient


Module ModulVariable


    Public DtSet As System.Data.DataSet
    Public ctrlDict As New Dictionary(Of String, Control)
    Public Da As SqlDataAdapter

    Public strKoneksi As String
    Public Koneksi As SqlConnection
    Public strServerName As String
    Public strLoginName As String
    Public strPasswordLogin As String
    Public strNamaDB As String

    Public cmd As SqlCommand
    Public dr As SqlDataReader


    Public strServerName2 As String
    Public strLoginName2 As String
    Public strPasswordLogin2 As String
    Public strNamaDB2 As String
    Public strKoneksi2 As String
    Public Koneksi2 As SqlConnection
    Public GlobalstrKodeBarang As String
    Public GlobalStrNamaBarang As String
    Public GlobalStrKodeCabang As String
    Public GlobalStrNoStruk As String

    Public MstrNoStruk As String



End Module
