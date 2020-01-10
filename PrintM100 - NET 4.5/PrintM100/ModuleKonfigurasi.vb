Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Module ModuleKonfigurasi
    Public Conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public rd As SqlDataReader

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


    Public KoneksiSQl As SqlConnection
    Public Koneksi2 As SqlConnection
    Public dr As SqlDataReader
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
            .DatabaseName = "RKM_LIVE_2"
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            'crtableLogoninfo.ConnectionInfo.ServerName = crConnectionInfo.ServerName
            'crtableLogoninfo.ConnectionInfo.UserID = crConnectionInfo.UserID
            'crtableLogoninfo.ConnectionInfo.Password = crConnectionInfo.Password
            CrTable.ApplyLogOnInfo(crtableLogoninfo)






        Next

    End Sub





    Private Sub AssignConnection(rpt As ReportDocument)
        Dim connection As New ConnectionInfo()


        connection.DatabaseName = "RKM_LIVE_2" 'myDataBase
        connection.ServerName = "10.1.0.53" '127.0.0.1
        connection.UserID = "sa" 'root
        connection.Password = "h0spit4lity#" '12345



        ' First we assign the connection to all tables in the main report
        '
        For Each table As CrystalDecisions.CrystalReports.Engine.Table In rpt.Database.Tables
            AssignTableConnection(table, connection)
        Next

        ' Now loop through all the sections and its objects to do the same for the subreports
        '
        For Each section As CrystalDecisions.CrystalReports.Engine.Section In rpt.ReportDefinition.Sections
            ' In each section we need to loop through all the reporting objects
            For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                If reportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim subReport As SubreportObject = DirectCast(reportObject, SubreportObject)
                    Dim subDocument As ReportDocument = subReport.OpenSubreport(subReport.SubreportName)

                    For Each table As CrystalDecisions.CrystalReports.Engine.Table In subDocument.Database.Tables
                        AssignTableConnection(table, connection)
                    Next

                    subDocument.SetDatabaseLogon(connection.UserID, connection.Password, connection.ServerName, connection.DatabaseName)
                End If
            Next
        Next
        rpt.SetDatabaseLogon(connection.UserID, connection.Password, connection.ServerName, connection.DatabaseName)
    End Sub


    Private Sub AssignTableConnection(ByVal table As CrystalDecisions.CrystalReports.Engine.Table, ByVal connection As ConnectionInfo)
        ' Cache the logon info block
        Dim logOnInfo As TableLogOnInfo = table.LogOnInfo

        connection.Type = logOnInfo.ConnectionInfo.Type

        ' Set the connection
        logOnInfo.ConnectionInfo = connection

        ' Apply the connection to the table!

        table.LogOnInfo.ConnectionInfo.DatabaseName = connection.DatabaseName
        table.LogOnInfo.ConnectionInfo.ServerName = connection.ServerName
        table.LogOnInfo.ConnectionInfo.UserID = connection.UserID
        table.LogOnInfo.ConnectionInfo.Password = connection.Password
        table.LogOnInfo.ConnectionInfo.Type = connection.Type
        table.ApplyLogOnInfo(logOnInfo)
    End Sub










    'Public Sub Koneksi()
    '    Conn = New SqlConnection("Data Source=10.1.0.53;Initial Catalog=RKM_LIVE_2;Persist Security Info=True;User ID=sa; password=h0spit4lity#")
    '    Conn.Open()
    'End Sub


    Public Sub KoneksiDatabase()

        strServer = "10.1.0.53"
        strNamaDatabase = "RKM_Live_2"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"



        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=Anyar Local Print Services 1.1;  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)

        KoneksiSQl = New SqlConnection(strKoneksi)

        Try
            If KoneksiSQl.State = ConnectionState.Closed Then
                KoneksiSQl.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub


End Module
