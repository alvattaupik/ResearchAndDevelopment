Imports System.Data.SqlClient
Module ModuleVariable
    Public conn As SqlConnection
    Public server As String
    Public conn_server As String
    Public conn_user As String
    Public conn_pass As String
    Public conn_database As String

    Public temstrServer As String
    Public tempstrconn_server As String
    Public tempstrconn_user As String
    Public tempstrconn_pass As String
    Public tempstrconn_database As String
    Public GlobalstrNamaUser As String
    Public GlobalstrKodeUser As String
    Public GlobalstrKodeDivisi As String
    Public GlobalstrNamaDivisi As String


    Public KoneksiSQl As SqlConnection
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader

    Public GlobalstrPathReport As String
    Public GlobalstrNoSurat As String
    Public GlobalstrSupervisor As String
    Public GlobalstrJenisSurat As String


    Public GlobalstrKodeJenisSurat As String


    Public strStatusForm As String
    Public bolStatus As Boolean
    Public bolStatus1 As Boolean
End Module
