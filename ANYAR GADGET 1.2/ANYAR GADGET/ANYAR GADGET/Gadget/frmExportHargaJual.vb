Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmExportHargaJual
    Dim iMax As Integer = 200 'iterasi maksimal
    Dim JumlahRow As Long


    Private Sub ExportHargaJual_Load(sender As Object, e As EventArgs) Handles Me.Load


        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True
        PanelLoading.Visible = False
        Control.CheckForIllegalCrossThreadCalls = False


        With My.Settings
            txtPathExportDb.Text = .P_ExportDatabase
        End With


        If txtPathExportDb.Text = "" Then
            cmdExport.Enabled = True
        Else
            cmdExport.Enabled = False
        End If

    End Sub


    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click
        On Error Resume Next

        ListView1.Items.Clear()
        ListView1.Visible = False

        If cmbHargaJual.Text = "" Then
            MsgBox("Pilih Harga Jual Yang Dibutuhkan", vbInformation, "Pilih Harga Jual")
            cmbHargaJual.BackColor = Color.Yellow
            Exit Sub
        End If

        If cmbNamaBrand.Text = "" Then

            If MsgBox("Apakah Anda yakin Tidak Akan Menggunakan Filter Brand?" & vbCrLf & "Proses Load Akan Lebih lama", vbYesNo, "Konfirmasi ?") = vbYes Then
                BackgroundWorker1.RunWorkerAsync()
            Else
                Exit Sub
            End If
        Else
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub



    Private Sub cmbHargaJual_Click(sender As Object, e As EventArgs) Handles cmbHargaJual.Click
        Call KoneksiDB_EMAIL()
        Dim strSQlQuery As String = "SELECT  ListNum ," & _
        " CASE WHEN NamaLocation IS NULL THEN Cabang" & _
        "     ELSE NamaLocation" & _
        " END AS Name" & _
        " FROM dbo.V_ListHargadanCabang" & _
        " LEFT OUTER JOIN dbo.OLocation ON KodeLocation = Cabang" & _
        " WHERE Ket='HJ' AND Cabang IN (SELECT KodeLocation FROM dbo.OLocControlUsers WHERE KodeAplikasi='AG' AND UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y')"
        LoadComboBox(cmbHargaJual, strSQlQuery, "ListNum", "Name", KoneksiDBEmail)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If (BackgroundWorker1.IsBusy) Then
            BackgroundWorker1.CancelAsync()
            BackgroundWorker1.Dispose()
        End If
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Proses Dibatalkan")
            PanelLoading.Visible = False
            ListView1.Items.Clear()
            lblJumlahData.Text = "Jumlah Data : " & ListView1.Items.Count
            ListView1.Visible = True

        Else
            ListView1.Visible = True
        End If
    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ListView1.Items.Clear()
        Koneksi_SAP()
        Dim command As SqlCommand
        command = New SqlCommand("_TmSp_HargaJualForPriceTag", KoneksiSAP)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PriceList", cmbHargaJual.SelectedValue)

        If txtNamaBarang.Text = "" Then
            command.Parameters.AddWithValue("@NamaBarang", "")
        Else
            command.Parameters.AddWithValue("@NamaBarang", txtNamaBarang.Text)
        End If

        If cmbNamaBrand.Text = "" Then
            command.Parameters.AddWithValue("@KodeBrand", "")
        Else
            command.Parameters.AddWithValue("@KodeBrand", cmbNamaBrand.SelectedValue)
        End If


        Dim TABLE As New DataTable
        adapter.Fill(TABLE)


        For i = 0 To TABLE.Rows.Count - 1

            With ListView1
                .BeginUpdate()
                .Items.Add(TABLE.Rows(i)("Keterangan"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("ItemCode"))
                    .Add(TABLE.Rows(i)("ItemName"))
                    .Add(TABLE.Rows(i)("HargaJual"))
                End With
                .EndUpdate()
            End With


            If (BackgroundWorker1.CancellationPending) Then
                e.Cancel = True
                Exit For
            End If


            PanelLoading.Visible = True
            lblProses.Visible = True
            lblProses.Text = "Memproses :" & i & " Dari " & TABLE.Rows.Count
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(1)

        Next


        If My.Settings.P_ExportDatabase = "" Then
            cmdExport.Enabled = True
            lblProses.Visible = False
            PanelLoading.Visible = False
            lblJumlahData.Text = "Jumlah Data : " & ListView1.Items.Count
        Else
            cmdExport.Enabled = False
            lblProses.Visible = False
            PanelLoading.Visible = False
            lblJumlahData.Text = "Jumlah Data : " & ListView1.Items.Count
            AutoExport()
            DisplayPesanOK("Sukses Di Export Ke Lokasi" & My.Settings.P_ExportDatabase, frmMainMenu.txtPesanError, 1000)
        End If



    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        On Error GoTo Errorload

        If ListView1.Items.Count = 0 Then
            MsgBox("Tidak Ada Data Yang Akan Di Export", vbInformation, "Perhatian!")
            Exit Sub
        End If

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.txt")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Write As New IO.StreamWriter(sfile.FileName)
            Dim k As ListView.ColumnHeaderCollection = ListView1.Columns
            For Each x As ListViewItem In ListView1.Items
                Dim StrLn As String = ""
                For i = 1 To x.SubItems.Count - 1
                    StrLn += x.SubItems(i).Text + vbTab
                Next
                Write.WriteLine(StrLn)
            Next
            Write.Close() 'Or  Write.Flush()
        End If

        Exit Sub

Errorload:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub

    End Sub



    Sub AutoExport()
        Try

            If ListView1.Items.Count = 0 Then
                MsgBox("Tidak Ada Data Yang Akan Di Export", vbInformation, "Perhatian!")
                Exit Sub
            End If

            'Dim sfile As New SaveFileDialog
            'With sfile
            '    .Title = "Choose your path to save the information"
            '    .InitialDirectory = "C:\"
            '    .Filter = ("ONLY Text Files (*.txt) | *.txt")
            'End With

            'If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Write As New IO.StreamWriter(txtPathExportDb.Text)
            Dim k As ListView.ColumnHeaderCollection = ListView1.Columns
            For Each x As ListViewItem In ListView1.Items
                Dim StrLn As String = ""
                For i = 1 To x.SubItems.Count - 1
                    StrLn += x.SubItems(i).Text + vbTab
                Next
                Write.WriteLine(StrLn)
            Next
            Write.Close() 'Or  Write.Flush()
            'End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try



    End Sub


    Private Sub cmbNamaBrand_Click(sender As Object, e As EventArgs) Handles cmbNamaBrand.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbNamaBrand, "SELECT FirmCode,FirmName FROM dbo.OMRC", "FirmCode", "FirmName", KoneksiSAP)
    End Sub

    Private Sub btnSettingAuto_Click(sender As Object, e As EventArgs) Handles btnSettingAuto.Click
        MsgBox("Dengan Menggunakan Fitur Ini Database akan otomatis Terupdate Saat Menekan tombol Proses" & vbNewLine & " Database Nama Database tidak boleh diganti atau dipindahkan", vbOK)
        frmAutoExportDB.ShowDialog()
    End Sub
End Class