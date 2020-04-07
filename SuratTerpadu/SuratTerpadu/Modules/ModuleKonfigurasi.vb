Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Module ModuleKonfigurasi
    Public param1Fields As New ParameterFields
    Public param1Field As New ParameterField
    Public param1Range As New ParameterDiscreteValue
    Public param2Fields As New ParameterFields
    Public param2Field As New ParameterField
    Public param2Range As New ParameterDiscreteValue

    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table

    Public RptDocument As New ReportDocument
    Public reportDocument As New ReportDocument()
    Public paramField As New ParameterField()
    Public paramFields As New ParameterFields()
    Public paramDiscreteValue As New ParameterDiscreteValue()
    Public paramField2 As New ParameterField()
    Public paramFields2 As New ParameterFields()
    Public paramDiscreteValue2 As New ParameterDiscreteValue()


    Public Koneksi1 As SqlConnection
    Public Koneksi2 As SqlConnection
    Public strKoneksi As String

    Public strServer As String
    Public strNamaDatabase As String
    Public strUserNameDB As String
    Public strPasswordDB As String

    Public strNamaUser As String
    Public strUsernameSAP As String

    Public Sub Module_Konfigurasi_laporan()
        With crConnectionInfo
            .ServerName = "10.1.0.53"
            .UserID = "sa"
            .Password = "h0spit4lity#"
            .DatabaseName = "DB_EMAIL"
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

    End Sub



    Public Sub KoneksiDatabase1()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_EMAIL"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        Koneksi1 = New SqlConnection(strKoneksi)



        Try
            If Koneksi1.State = ConnectionState.Closed Then
                Koneksi1.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Public Sub KoneksiDatabase2()

        strServer = "10.1.0.53"
        strNamaDatabase = "RKM_LIVE_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"

        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        Koneksi2 = New SqlConnection(strKoneksi)



        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub



End Module
