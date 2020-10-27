Imports System.Data.Sql
Imports System.Data.SqlClient


Module Koneksi
    Public conn As SqlConnection
    Public server As String
    Public conn_server As String
    Public conn_user As String
    Public conn_pass As String
    Public conn_database As String


    Public KoneksiDBEmail As SqlConnection
    Public KoneksiSAP As SqlConnection
    Public KoneksiCabang As SqlConnection
    Public KoneksiIvend As SqlConnection
    Public strkoneksiIvend As String
    Public strKoneksi2 As String





    Public strKoneksiCabang As String





    Public strServer As String
    Public strNamaDatabase As String
    Public strUserNameDB As String
    Public strPasswordDB As String

    Public strNamaUser As String
    Public strUsernameSAP As String




    Public strServer2 As String
    Public strNamaDatabase2 As String
    Public strUserNameDB2 As String
    Public strPasswordDB2 As String





    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader





    Public Sub KoneksiDB_EMAIL()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_EMAIL"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strkoneksiIvend = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strkoneksiIvend = String.Format(strkoneksiIvend, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        KoneksiDBEmail = New SqlConnection(strkoneksiIvend)



        Try
            If KoneksiDBEmail.State = ConnectionState.Closed Then
                KoneksiDBEmail.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Public Sub Koneksi_SAP()

        strServer = "10.1.0.53"
        strNamaDatabase = "RKM_LIVE_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksi2 = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strKoneksi2 = String.Format(strKoneksi2, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        KoneksiSAP = New SqlConnection(strKoneksi2)

        Try
            If KoneksiSAP.State = ConnectionState.Closed Then
                KoneksiSAP.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub






    Public Sub Koneksi_IVEND()

        strServer = "10.1.0.55"
        strNamaDatabase = "CXSRetail_HO_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksiIvend = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strKoneksiIvend = String.Format(strKoneksiIvend, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        KoneksiIvend = New SqlConnection(strKoneksiIvend)



        Try
            If KoneksiIvend.State = ConnectionState.Closed Then
                KoneksiIvend.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub





    Public Sub Koneksi_CABANG(strServer As String, strNamaDatabase As String, strUsernameDB As String, strPasswordDB As String)

        strKoneksiCabang = "data source=" & strServer & ";user id=" & strUsernameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True; "
        strKoneksiCabang = String.Format(strKoneksiCabang, strServer, strUsernameDB, strPasswordDB, strNamaDatabase)
        KoneksiCabang = New SqlConnection(strKoneksiCabang)



        Try
            If KoneksiCabang.State = ConnectionState.Closed Then
                KoneksiCabang.Open()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





End Module
