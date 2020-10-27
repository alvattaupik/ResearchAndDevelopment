'Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Module ModuleKoneksi

'    Public koneksiIvend As SqlConnection
'    Public Koneksi2 As SqlConnection
'    Public strkoneksiIvend As String
'    Public strKoneksi2 As String

'    Public strServer As String
'    Public strNamaDatabase As String
'    Public strUserNameDB As String
'    Public strPasswordDB As String

'    Public strNamaUser As String
'    Public strUsernameSAP As String



'    Public dr As SqlDataReader
'    Public da As SqlDataAdapter
'    Public ds As DataSet
'    Public cmd As SqlCommand
'    Public rd As SqlDataReader


'    Public MstrKodeCabang As String


'    Public MstrNoMember As String








'    Public Sub Koneksi_IVEND()

'        strServer = "10.1.0.55"
'        strNamaDatabase = "CXSRetail_HO_2"
'        strUserNameDB = "sa"
'        strPasswordDB = "h0spit4lity#"

'        strkoneksiIvend = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Member Card Monitoring 1.0;  "
'        strkoneksiIvend = String.Format(strkoneksiIvend, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
'        koneksiIvend = New SqlConnection(strkoneksiIvend)

'        Try
'            If koneksiIvend.State = ConnectionState.Closed Then
'                koneksiIvend.Open()
'            End If
'        Catch ex As Exception
'            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
'        End Try

'    End Sub






'    Public SubKoneksiDB_EMAIL()

'        strServer = "10.1.0.53"
'        strNamaDatabase = "DB_email"
'        strUserNameDB = "sa"
'        strPasswordDB = "h0spit4lity#"

'        strkoneksiIvend = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Member Card Monitoring 1.0;  "
'        strkoneksiIvend = String.Format(strkoneksiIvend, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
'        koneksiIvend = New SqlConnection(strkoneksiIvend)

'        Try
'            If koneksiIvend.State = ConnectionState.Closed Then
'                koneksiIvend.Open()
'            End If
'        Catch ex As Exception
'            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
'        End Try

'    End Sub






'    Public Sub Koneksi_IVEND()

'        strServer = "10.1.0.53"
'        strNamaDatabase = "RKM_LIVE_2"
'        strUserNameDB = "sa"
'        strPasswordDB = "h0spit4lity#"

'        strKoneksi2 = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Member Card Monitoring 1.0;  "
'        strKoneksi2 = String.Format(strKoneksi2, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
'        Koneksi2 = New SqlConnection(strKoneksi2)



'        Try
'            If Koneksi2.State = ConnectionState.Closed Then
'                Koneksi2.Open()
'            End If
'        Catch ex As Exception
'            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
'        End Try

'    End Sub





'End Module
