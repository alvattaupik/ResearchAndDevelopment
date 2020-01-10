Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Module Module1
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
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

    End Sub
    Public Sub Koneksi()
        Conn = New SqlConnection("Data Source=10.1.0.53;Initial Catalog=RKM_LIVE_2;Persist Security Info=True;User ID=sa; password=h0spit4lity#")
        Conn.Open()
    End Sub

End Module
