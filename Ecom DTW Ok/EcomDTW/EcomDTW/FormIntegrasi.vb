Imports System.IO
Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Imports System.Data.SqlClient

Public Class FormIntegrasi
    Dim _Loop As Integer = 0
    Public connDB As New MySql.Data.MySqlClient.MySqlConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdProses.Click

        If My.Settings.ServerNameIntegrasi = "" Then
            MsgBox("Konfigurasi Server Integrasi Belum Di Atur", vbInformation, "Perhatian!")
            FormKonfigurasiIntegrasi.ShowDialog()
            Exit Sub
        End If


        _Loop = 30
        cmdLogoff.Enabled = False
        cmdUpload.Enabled = False
        cmdStopProses.Enabled = True




        KoneksiDatabaseSQLSERVER()
        Dim cmdSQLRV As SqlCommand
        cmdSQLRV = New SqlCommand("_GetItemEcomdanSAP", KoneksiSQLSRV)

        Dim adapter As New SqlDataAdapter(cmdSQLRV)
        cmdSQLRV.CommandType = CommandType.StoredProcedure
        cmdSQLRV.CommandTimeout = 0
        BgWorker.RunWorkerAsync()
        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgListUpload.DataSource = table

        lblJumlahItem.Text = "Jumlah Item : " & dgListUpload.RowCount

       


    End Sub





    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs)


        'Using objReader As New StreamReader(txtPathLokasi.Text)
        '    Do While objReader.Peek() <> -1
        '        Dim line As String = objReader.ReadLine()
        '        Dim splitLine() As String = line.Split(vbTab)
        '        Dim teamName As String = splitLine(0)
        '        Dim HargaJual As String = splitLine(1)
        '        dgListUpload.Rows.Add(teamName, HargaJual)
        '        dgListUpload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '        dgListUpload.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        '        dgListUpload.AutoResizeColumns()
        '    Loop
        'End Using

    End Sub


    Sub LoadtxtFile()

        'Using objReader As New StreamReader(txtPathLokasi.Text)
        '    Do While objReader.Peek() <> -1
        '        Dim line As String = objReader.ReadLine()
        '        Dim splitLine() As String = line.Split(vbTab)
        '        Dim IdProduk As String = splitLine(0)
        '        Dim Idkategori As String = splitLine(1)



        '        dgListUpload.Rows.Add(splitLine(0), splitLine(1), splitLine(2), splitLine(3), splitLine(4), splitLine(5), splitLine(6), splitLine(7), splitLine(8), splitLine(9), splitLine(10), splitLine(11), splitLine(12), splitLine(13), splitLine(14), splitLine(15))
        '    Loop
        '    lblJumlahItem.Text = "Jumlah Item: " & dgListUpload.Rows.Count
        'End Using
    End Sub

    Sub koneksiDatabase()
        Try
            If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass
            If connDB.State <> ConnectionState.Open Then connDB.Open() Else connDB.Close()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmdTestKoneksi_Click(sender As Object, e As EventArgs)
        Call koneksiDatabase()
    End Sub


    '    Sub UploadDatamaster()
    '        Dim intJumlahUpload As Long
    '        Using objReader As New StreamReader(txtPathLokasi.Text)

    '            Do While objReader.Peek() <> -1
    '                Dim line As String = objReader.ReadLine()
    '                Dim splitLine() As String = line.Split(vbTab)
    '                Dim IdProduk As String = splitLine(0)
    '                Dim Idkategori As String = splitLine(1)
    '                '  dgListUpload.Rows.Add(splitLine(0), splitLine(1), splitLine(2), splitLine(3), splitLine(4), splitLine(5), splitLine(6), splitLine(7), splitLine(8), splitLine(9), splitLine(10), splitLine(11), splitLine(12), splitLine(13), splitLine(14))


    '                Call conecDB()
    '                Call initCMD()

    '                With comDB
    '                    .CommandText = "Call AU_MasterBarang('" & splitLine(0) & "','" & splitLine(1) & "','" & splitLine(2) & "','" & splitLine(3) & "','" & splitLine(4) & "','" & splitLine(5) & "','" & splitLine(6) & "','" & splitLine(7) & "','" & splitLine(8) & "','" & splitLine(9) & "','" & splitLine(10) & "','" & splitLine(11) & "','" & splitLine(12) & "','" & splitLine(13) & "','" & splitLine(14) & "','" & splitLine(15) & "','" & MstrKdPegawai & "','A')"
    '                    .ExecuteNonQuery()
    '                End With




    '                intJumlahUpload = intJumlahUpload + 1
    '                lblJumlahUpload.Text = "Mengupload :" & intJumlahUpload & " Dari " & dgListUpload.RowCount



    '            Loop
    '            lblJumlahItem.Text = "Jumlah Item: " & dgListUpload.Rows.Count
    '            dgListUpload.RowCount = 0
    '            lblJumlahItem.Text = "Jumlah Item Untuk Di Upload : 0"
    '            lblJumlahUpload.Text = "Mengupload : 0 dari 0"


    '            Exit Sub
    'ErrorLoad:
    '            MsgBox(Err.Description)

    ''            Exit Sub
    ''        End Using





    'End Sub















    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click

        If dgListUpload.RowCount = 0 Then
            MsgBox("Tidak Ada Data Untuk Di Integrasikan, Silahkan Load File yang akan di Upload", vbInformation, "Kosong?")
            Exit Sub
        End If

        lblJumlahItem2.Text = dgListUpload.RowCount
        lblJumlahUpload.Visible = True
        lblDari.Visible = True
        lblJumlahItem2.Visible = True


        Dim intJumlahUpload As Long

        On Error GoTo ErrorLoad

        For i As Integer = 0 To dgListUpload.Rows.Count - 1


            Call conecDB()
            Call initCMD()

            With comDB
                .CommandText = "Call AU_MasterBarangIntegrasi('" & dgListUpload.Rows(i).Cells(0).Value & "','','','','','','','" & dgListUpload.Rows(i).Cells(2).Value & "','" & dgListUpload.Rows(i).Cells(4).Value & "','" & dgListUpload.Rows(i).Cells(6).Value & "','" & dgListUpload.Rows(i).Cells(7).Value & "','','','','','','" & MstrKdPegawai & "','A')"
                .ExecuteNonQuery()
            End With

            intJumlahUpload = intJumlahUpload + 1
            lblJumlahUpload.Text = intJumlahUpload


        Next


        MsgBox("Item Barang Sebanyak : " & intJumlahUpload & " dari " & lblJumlahItem2.Text & " Berhasil Di Upload", vbInformation, "Informasi")

        dgListUpload.RowCount = 0
        lblJumlahItem.Text = "Jumlah Item Untuk Di Upload : 0"
        lblJumlahUpload.Text = "0"

        dgListUpload.DataSource = Nothing
        dgListUpload.Rows.Clear()

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub


    End Sub

    Private Sub cmdLogoff_Click(sender As Object, e As EventArgs) Handles cmdLogoff.Click
        MsgBox("Logging Off")
        Me.Close()
        FormLogin.Show()
        FormLogin.txtUsername.Text = ""
        FormLogin.txtPassword.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Call UploadDatamaster()
    End Sub

    Private Sub cmdStopProses_Click(sender As Object, e As EventArgs) Handles cmdStopProses.Click
        If BgWorker.IsBusy Then
            If BgWorker.WorkerSupportsCancellation Then
                BgWorker.CancelAsync()
            End If
        End If
        cmdProses.Enabled = True
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWorker.DoWork
        For x As Integer = 0 To _Loop
            If BgWorker.CancellationPending Then
                e.Cancel = True
                Exit For
            End If
            System.Threading.Thread.Sleep(1000)
            BgWorker.ReportProgress(CInt((x / _Loop) * 100))
            UpdateLabel(Me.lblStatus, _
            FormatPercent(x / _Loop, 2))
        Next

       

    End Sub

    Private Sub BgWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BgWorker.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub


    Private Sub BgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWorker.RunWorkerCompleted
        If e.Cancelled Then
            lblStatus.Text = "Dibatalkan!"
            cmdLogoff.Enabled = True
            cmdUpload.Enabled = True
        Else
            lblStatus.Text = "Proses Selesai!"
            cmdLogoff.Enabled = True
            cmdUpload.Enabled = True
        End If
    End Sub

    Delegate Sub SetLabelText_Delegate(ByVal [Label] As Label, ByVal [text] As String)


    Private Sub UpdateLabel(ByVal [Label] As Label, ByVal [text] As String)
        If [Label].InvokeRequired Then
            Dim MyDelegate As New  _
            SetLabelText_Delegate(AddressOf UpdateLabel)
            Me.Invoke(MyDelegate, New Object() _
            {[Label], [text]})
        Else
            [Label].Text = [text]
        End If
    End Sub

End Class
