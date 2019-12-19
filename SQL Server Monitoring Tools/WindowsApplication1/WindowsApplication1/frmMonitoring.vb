Imports System.Data.SqlClient

Public Class frmMonitoring

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        FrmSetting.ShowDialog()
    End Sub

    Private Sub cmbListDB_Click(sender As Object, e As EventArgs) Handles cmbListDB.Click
        LoadComboDaftarDB()
    End Sub



    Private Sub LoadComboDaftarDB()

        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT dbid,name FROM [master].[dbo].[sysdatabases]", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbListDB.DataSource = dt
            cmbListDB.ValueMember = "dbid"
            cmbListDB.DisplayMember = "name"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub LoadDaftarTugasSQL()
        strNamaDatabase2 = cmbListDB.Text

        KoneksiDatabase2()
        Dim cmd As New SqlCommand("SELECT session_id AS Sesi,[Blk by] AS BlockedBy,host_name AS NamaClient,cpu_time,status AS StatusSesi,wait_type AS WaitType,program_name AS NamaProgram ," & _
        " [Wait M] AS DurasiTunggu,command_text AS Query," & _
        " wait_resource ," & _
        " logical_reads,reads,writes From dbo.V_MonitoringTraffic ORDER BY cpu_time DESC ", Koneksi2)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgDaftarTugas.DataSource = table
        'aturDGSAP()
        dgDaftarTugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarTugas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarTugas.AutoResizeColumns()
        Koneksi2.Close()


    End Sub






    Private Sub frmMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetLoginSetting()
    End Sub

    Private Sub cmdStartMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStartMonitoring.Click
        If cmbListDB.Text = "" Then
            MsgBox("Pilih Database yang akan Dimonitor", vbInformation, "Informasi")
            Exit Sub
        End If
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadDaftarTugasSQL()
    End Sub

    Private Sub cmdStopMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStopMonitoring.Click
        Timer1.Enabled = False
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        LoadDaftarTugasSQL()
    End Sub

    Private Sub cmdConnectionMonitor_Click(sender As Object, e As EventArgs) Handles cmdConnectionMonitor.Click
        If cmbListDB.Text = "" Then
            MsgBox("Pilih Database yang akan Dimonitor", vbInformation, "Informasi")
            Exit Sub
        End If

        strNamaDatabase2 = cmbListDB.Text

        frmConnectionMonitor.ShowDialog()
    End Sub

    Private Sub cmdSessionTrace_Click(sender As Object, e As EventArgs) Handles cmdSessionTrace.Click
        frmSessionTrace.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmExpensiveQuery.ShowDialog()
    End Sub

    Private Sub cmdKillSession_Click(sender As Object, e As EventArgs) Handles cmdKillSession.Click
        FormKillSession.ShowDialog()
    End Sub
End Class
