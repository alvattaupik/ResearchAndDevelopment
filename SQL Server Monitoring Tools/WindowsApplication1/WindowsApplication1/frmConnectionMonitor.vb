Imports System.Data.SqlClient

Public Class frmConnectionMonitor

    Private Sub frmConnectionMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblNamaDatabase.Text = strNamaDatabase2
        LoadMonitoringConnection()
    End Sub


    Sub LoadMonitoringConnection()

        KoneksiDatabase3()
        Dim cmd As New SqlCommand("SELECT DB_NAME(dbid) as DBName,COUNT(dbid) as NumberOfConnections FROM sys.sysprocesses WHERE dbid > 0 AND DB_NAME(dbid)='" & Trim(strNamaDatabase2) & "' GROUP BY dbid, loginame", Koneksi3)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgConnectionMonitor.DataSource = table
        'aturDGSAP()
        dgConnectionMonitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgConnectionMonitor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgConnectionMonitor.AutoResizeColumns()
        Koneksi3.Close()


    End Sub


End Class