Imports System.IO
Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Imports System.Data.SqlClient

Public Class FormIntegrasi
   
    Private Sub FormIntegrasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub cmdStopProses_Click(sender As Object, e As EventArgs) Handles cmdStopProses.Click
        If (bgSinkronisasi.IsBusy) Then
            bgSinkronisasi.CancelAsync()
            bgSinkronisasi.Dispose()
        End If
        cmdProses.Enabled = True
        cmdStopProses.Enabled = False
    End Sub
    Private Sub bgSinkronisasi_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgSinkronisasi.DoWork
        Call KoneksiDBSQLSRV()
        Dim command As SqlCommand
        command = New SqlCommand("_GetItemEcomdanSAP", KoneksiSQLSRV)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgListUpload.DataSource = table

        lblJumlahItem.Text = table.Rows.Count & " Records To Send"

        If (bgSinkronisasi.CancellationPending) Then
            e.Cancel = True
            Exit Sub
        End If

        cmdProses.Enabled = True
        cmdStopProses.Enabled = False

    End Sub










    Sub SinkronisasiMYSQLdanSQLSRV()
        Call KoneksiDBSQLSRV()
        Dim command As SqlCommand
        command = New SqlCommand("_GetItemEcomdanSAP", KoneksiSQLSRV)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgListUpload.DataSource = table

        lblJumlahItem.Text = table.Rows.Count & " Records To Send"
        cmdProses.Enabled = True
        cmdStopProses.Enabled = False
    End Sub



    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        If dgListUpload.RowCount = 0 Then
            MsgBox("Tidak Ada Data Data Untuk Di Integrasikan, Silahkan Coba beberapa saat lagi", vbInformation, "Kosong?")
            Exit Sub
        End If
        PanelIntegrasi.Visible = True
        bgIntegrasi.RunWorkerAsync()
    End Sub

    Private Sub bgIntegrasi_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgIntegrasi.DoWork
        On Error GoTo ErrorLoad

        cmdUpload.Enabled = False
        cmdCancelIntegrasi.Enabled = True

        connDB.Close()
        For i As Integer = 0 To dgListUpload.Rows.Count - 1

            closeDB()

            Call KoneksiMySQL()
            Call initCMD()

            With comDB

                .CommandText = "Call AU_MasterBarangIntegrasi('" & dgListUpload.Rows(i).Cells(0).Value & "','','','','" & dgListUpload.Rows(i).Cells(1).Value & "','','','" & dgListUpload.Rows(i).Cells(2).Value & "','" & dgListUpload.Rows(i).Cells(4).Value & "','" & dgListUpload.Rows(i).Cells(6).Value & "','" & dgListUpload.Rows(i).Cells(7).Value & "','" & dgListUpload.Rows(i).Cells(9).Value & "','" & dgListUpload.Rows(i).Cells(10).Value & "','','" & MstrKdPegawai & "','" & MstrKdPegawai & "','" & dgListUpload.Rows(i).Cells(13).Value & "','','','')"
                .ExecuteNonQuery()
            End With


            If (bgIntegrasi.CancellationPending) Then
                e.Cancel = True
                Exit For
            End If


            lblProsesIntegrasi.Text = "Mengintegrasikan :" & i & " Dari " & dgListUpload.Rows.Count
            bgIntegrasi.ReportProgress(i)
            System.Threading.Thread.Sleep(1)

        Next


        lblProsesIntegrasi.Visible = False
        PanelIntegrasi.Visible = False
        lblJumlahItem.Text = "Telah Mengintegrasikan : " & dgListUpload.Rows.Count & " Items"
        cmdUpload.Enabled = True
        cmdCancelIntegrasi.Enabled = False
        dgListUpload.DataSource = Nothing
        dgListUpload.Rows.Clear()


        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Me.Dispose()

        Exit Sub
    End Sub

    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        cmdProses.Enabled = False
        cmdStopProses.Enabled = True

        Call SinkronisasiMYSQLdanSQLSRV()

    End Sub
End Class
