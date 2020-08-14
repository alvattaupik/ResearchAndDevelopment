Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormMainMenu

    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click
        FormUpload.ShowDialog()
    End Sub

    Private Sub IntegrationServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegrationServicesToolStripMenuItem.Click
        IntegrationSetting.ShowDialog()
    End Sub

    Private Sub IntegrasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegrasiToolStripMenuItem.Click
        FormIntegrasi.Show()
    End Sub

    Private Sub SAPDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAPDatabaseToolStripMenuItem.Click
        SettingDatabase.ShowDialog()
    End Sub

    Private Sub TimerJam_Tick(sender As Object, e As EventArgs) Handles TimerJam.Tick
        lblJam.Text = TimeOfDay

    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        lblHari.Text = Date.Today.ToString("dddd")
        LoadDurasi()
        TimerIntegrasi.Start()

        If My.Settings.StatusIntegrasi = "1" Then
            txtStatusIntegrasi.Text = "AKTIF"
        Else
            txtStatusIntegrasi.Text = "NON AKTIF"
        End If



    End Sub

    Private Sub cmbCekLink_Click(sender As Object, e As EventArgs) Handles cmbCekLink.Click

        connDB.Close()

        Call KoneksiDBSQLSRV()
        Call KoneksiMySQL()


        If bolStatusKoneksiMySQL = True Then
            lblHostMYSQL.Text = "Koneksi Host " & My.Settings.MysqlHost & " ---- OK 200 -----"
        Else
            lblHostMYSQL.Text = "Koneksi Host " & My.Settings.MysqlHost & " ---- Error 404 -----"
        End If



        If bolStatusKoneksiSQLServer = True Then
            lblHostSQL.Text = "Koneksi Server " & My.Settings.SQLServer & " ---- Connected -----"
        Else
            lblHostSQL.Text = "Koneksi Server " & My.Settings.SQLServer & " ---- Error Connection -----"
        End If



    End Sub

    Private Sub cmdLogoff_Click(sender As Object, e As EventArgs) Handles cmdLogoff.Click
        MsgBox("Logging Off")
        Me.Dispose()
        FormLogin.Show()
        FormLogin.txtUsername.SetOnGotFocus()
        FormLogin.txtUsername.Text = ""
        FormLogin.txtPassword.Text = ""
    End Sub



  

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        On Error GoTo ErrorLoad
        lblProsesIntegrasi.Visible = True


        connDB.Close()
        For i As Integer = 0 To dgListIntegrasi.Rows.Count - 1

            closeDB()

            Call KoneksiMySQL()
            Call initCMD()

            With comDB

                .CommandText = "Call AU_MasterBarangIntegrasi('" & dgListIntegrasi.Rows(i).Cells(0).Value & "','','','','','','','" & dgListIntegrasi.Rows(i).Cells(1).Value & "','" & dgListIntegrasi.Rows(i).Cells(2).Value & "','" & dgListIntegrasi.Rows(i).Cells(3).Value & "','" & dgListIntegrasi.Rows(i).Cells(4).Value & "','" & dgListIntegrasi.Rows(i).Cells(5).Value & "','" & dgListIntegrasi.Rows(i).Cells(6).Value & "','','" & MstrKdPegawai & "','" & MstrKdPegawai & "','','','','')"
                .ExecuteNonQuery()
            End With


            If (BackgroundWorker1.CancellationPending) Then
                e.Cancel = True
                Exit For
            End If


            lblProsesIntegrasi.Text = "Sending Records :" & i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(1)

        Next

        dgListIntegrasi.DataSource = Nothing
        dgListIntegrasi.Rows.Clear()


        LoadDurasi()
        TimerIntegrasi.Start()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub

    End Sub
    Sub LoadDurasi()
        FnTimerNotifikasi(My.Settings.NilaiDurasi, My.Settings.SatuanDurasi)
    End Sub





    Private Sub TimerIntegrasi_Tick(sender As Object, e As EventArgs) Handles TimerIntegrasi.Tick
        LongDurasi = LongDurasi - 1

        lblDurasi.Text = LongDurasi.ToString


        If lblDurasi.Text = "0" Then
            TimerIntegrasi.Stop()
            LoadDaftarIntegrasi()
            lblProsesIntegrasi.Visible = True
            BackgroundWorker1.RunWorkerAsync()
            LoadDurasi()
            TimerIntegrasi.Start()
        End If

    End Sub





    Sub LoadDaftarIntegrasi()

        Call KoneksiDBSQLSRV()
        Dim command As SqlCommand
        command = New SqlCommand("_GetItemEcomdanSAPIntegrasi", KoneksiSQLSRV)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgListIntegrasi.DataSource = table
        dgListIntegrasi.RowHeadersVisible = False
        lblJumlahIntegrasi.Text = table.Rows.Count & " Records To Send"

    End Sub




    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        LoadDaftarIntegrasi()
        lblProsesIntegrasi.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub cmbPause_Click(sender As Object, e As EventArgs) Handles cmbPause.Click
        TimerIntegrasi.Stop()
        txtStatusIntegrasi.Text = "Paused"
    End Sub

    Private Sub cmbResume_Click(sender As Object, e As EventArgs) Handles cmbResume.Click
        TimerIntegrasi.Start()
        txtStatusIntegrasi.Text = "Running"
    End Sub







    

    Private Sub TokopediaStockCompareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokopediaStockCompareToolStripMenuItem.Click
        TokopediaStockCompare.ShowDialog()
    End Sub


    Private Sub CekStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CekStokToolStripMenuItem.Click
        CekStok.ShowDialog()
    End Sub
End Class