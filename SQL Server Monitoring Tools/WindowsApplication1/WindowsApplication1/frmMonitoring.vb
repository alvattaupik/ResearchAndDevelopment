Imports System.Data.SqlClient

Public Class frmMonitoring
    Dim strStatusnamaServer As String
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        FrmSetting.ShowDialog()
    End Sub

    Private Sub cmbListDB_Click(sender As Object, e As EventArgs) Handles cmbListDB.Click

        If My.Settings.Servername = "" Then
            MsgBox("Konfigurasi Server Belum Diatur", vbCritical, "Warning!")
            FrmSetting.ShowDialog()
            Exit Sub
        End If

        GetLoginSetting()

            LoadComboDaftarDB()
    End Sub

    Private Sub LoadComboDaftarDB()

        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT dbid,name FROM [master].[dbo].[sysdatabases]", Koneksi)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cmbListDB.DataSource = dt
            cmbListDB.ValueMember = "dbid"
            cmbListDB.DisplayMember = "name"
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
        txtBebanLoad.Text = dgDaftarTugas.RowCount

    End Sub






    Private Sub frmMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetLoginSetting()
    End Sub

    Private Sub cmdStartMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStartMonitoring.Click

        If cmbListDB.Text = "" Then
            MsgBox("Pilih Database yang akan Dimonitor", vbInformation, "Informasi")
            Exit Sub
        End If
        cmbListDB.Enabled = False
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadDaftarTugasSQL()
    End Sub

    Private Sub cmdStopMonitoring_Click(sender As Object, e As EventArgs) Handles cmdStopMonitoring.Click
        Timer1.Enabled = False
        cmbListDB.Enabled = True
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If cmbListDB.Text = "" Then
            MsgBox("Pilih database", vbInformation, "Informasi")
            Exit Sub
        End If

        If (MsgBox("Perhatian!, Menggunakan Fitur Ini akan menggunakan resource yang tinggi, Mohon Gunakan dengan Bijak", vbYesNo, "Bijaklah!")) = vbYes Then
            FormFragmentationStatus.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GetLoginSetting()
        If strNamaDatabase2 = "" Then
            MsgBox("Nama Database Belum Dipilih", vbCritical, "Pilih Database!")

            FormListDatabase.ShowDialog()
            Exit Sub
        End If

        FormStatusMaintenanceDanBackup.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmSetting.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
