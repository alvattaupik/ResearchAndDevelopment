Imports System.Data.SqlClient
Public Class FormStatusMaintenanceDanBackup



    Sub LoadBackupStatus()
        Try

            KoneksiDatabase2()
            Dim cmd As New SqlCommand("SELECT * FROM dbo.V_MonitoringBackup WHERE CAST(TanggalBackupTerakhir AS DATE)=CAST(GETDATE() AS DATE) ORDER BY NamaDatabase", Koneksi2)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgStatusbackup.DataSource = table
            'aturDGSAP()
            dgStatusbackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgStatusbackup.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgStatusbackup.AutoResizeColumns()
            Koneksi2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub



    Sub LoadTaskStatus()
        Try

            KoneksiDatabase2()
            Dim cmd As New SqlCommand("SELECT * FROM dbo.V_TaskMonitoringPlan WHERE CAST(Tanggal AS DATE)=CAST(GETDATE() AS DATE) ORDER BY NamaPlan", Koneksi2)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgStatusTaskPlan.DataSource = table
            'aturDGSAP()
            dgStatusTaskPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgStatusTaskPlan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgStatusTaskPlan.AutoResizeColumns()
            Koneksi2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub















    Private Sub FormStatusMaintenanceDanBackup_Load(sender As Object, e As EventArgs) Handles Me.Load

        dtpBackup1.Value = Now
        dtpBackup2.Value = Now
        dtpTask1.Value = Now
        dtpTask2.Value = Now
        LoadBackupStatus()
        LoadTaskStatus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadBackupStatusWithParameter()
    End Sub



    Sub LoadBackupStatusWithParameter()
        Try

            KoneksiDatabase2()
            Dim cmd As New SqlCommand("SELECT * FROM dbo.V_MonitoringBackup WHERE CAST(TanggalBackupTerakhir AS DATE) between '" & dtpBackup1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpBackup2.Value.ToString("yyyy-MM-dd") & "' ORDER BY NamaDatabase", Koneksi2)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgStatusbackup.DataSource = table
            'aturDGSAP()
            dgStatusbackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgStatusbackup.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgStatusbackup.AutoResizeColumns()
            Koneksi2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub




    Sub LoadTaskStatusWithParameter()
        Try

            KoneksiDatabase2()
            Dim cmd As New SqlCommand("SELECT * FROM dbo.V_TaskMonitoringPlan WHERE CAST(Tanggal AS DATE) between '" & dtpTask1.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpTask2.Value.ToString("yyyy-MM-dd") & "' ORDER BY NamaPlan", Koneksi2)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgStatusTaskPlan.DataSource = table
            'aturDGSAP()
            dgStatusTaskPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgStatusTaskPlan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgStatusTaskPlan.AutoResizeColumns()
            Koneksi2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadTaskStatusWithParameter()
    End Sub
End Class