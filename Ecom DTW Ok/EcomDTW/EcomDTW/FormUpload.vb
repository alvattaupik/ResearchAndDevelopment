Imports System.IO
Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormUpload
    Public connDB As New MySql.Data.MySqlClient.MySqlConnection
    Dim LocationSave As String
    Dim BolStatusOpenDialog As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgListUpload.DataSource = Nothing
        dgListUpload.Rows.Clear()
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathLokasi.Text = O.FileName
                LoadtxtFile()
                'UploadDatamaster()
            End If
        End Using
    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs)


        Using objReader As New StreamReader(txtPathLokasi.Text)
            Do While objReader.Peek() <> -1
                Dim line As String = objReader.ReadLine()
                Dim splitLine() As String = line.Split(vbTab)
                Dim teamName As String = splitLine(0)
                Dim HargaJual As String = splitLine(1)
                dgListUpload.Rows.Add(teamName, HargaJual)
                dgListUpload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgListUpload.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgListUpload.AutoResizeColumns()
            Loop
        End Using

    End Sub


    Sub LoadtxtFile()

        Using objReader As New StreamReader(txtPathLokasi.Text)
            Do While objReader.Peek() <> -1
                Dim line As String = objReader.ReadLine()
                Dim splitLine() As String = line.Split(vbTab)
                Dim IdProduk As String = splitLine(0)
                Dim Idkategori As String = splitLine(1)



                dgListUpload.Rows.Add(splitLine(0), splitLine(1), splitLine(2), splitLine(3), splitLine(4), splitLine(5), splitLine(6), splitLine(7), splitLine(8), splitLine(9), splitLine(10), splitLine(11), splitLine(12), splitLine(13), splitLine(14), splitLine(15), splitLine(16), splitLine(17), splitLine(15))
            Loop
            lblJumlahItem.Text = "Jumlah Item: " & dgListUpload.Rows.Count
        End Using
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

    '            Exit Sub
    '        End Using





    '    End Sub















    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If dgListUpload.RowCount = 0 Then
            MsgBox("Tidak Ada Data Untuk Di Upload, Silahkan Load File yang akan di Upload", vbInformation, "Kosong?")
            Exit Sub
        End If
        panelLoading.Visible = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub cmdLogoff_Click(sender As Object, e As EventArgs)
        MsgBox("Logging Off")
        Me.Close()
        FormLogin.Show()
        FormLogin.txtUsername.Text = ""
        FormLogin.txtPassword.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Call UploadDatamaster()
    End Sub

    Private Sub LihatPerubahanItemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormIntegrasi.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        exportTemplate()
    End Sub




    Sub exportTemplate()


        dgExportTemplate.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        dgExportTemplate.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        LoadPenyimpanan()

        If BolStatusOpenDialog = False Then

            Try
                Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
                Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim a As Integer
                Dim b As Integer

                ExcelApp = New Microsoft.Office.Interop.Excel.Application
                ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
                ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")

                For a = 0 To dgExportTemplate.RowCount - 2
                    For b = 0 To dgExportTemplate.ColumnCount - 1
                        For c As Integer = 1 To dgExportTemplate.Columns.Count
                            ExcelWorkSheet.Cells(1, c) = dgExportTemplate.Columns(c - 1).HeaderText
                            ExcelWorkSheet.Cells(a + 2, b + 1) = dgExportTemplate(b, a).Value.ToString()
                        Next
                    Next
                Next




                ExcelWorkSheet.SaveAs(LocationSave & "\Template Ecom DTW.xlsx")
                ExcelWorkBook.Close()
                ExcelApp.Quit()

                releaseObject(ExcelApp)
                releaseObject(ExcelWorkBook)
                releaseObject(ExcelWorkSheet)

                MsgBox("Hasil export tersimpan di " & LocationSave)
            Catch ex As Exception
                MsgBox(Err.Description)
                Exit Sub
            End Try


        Else
            Exit Sub
        End If

     
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub





    Sub LoadPenyimpanan()

        Dim mySaveFileDialog As New SaveFileDialog


        MsgBox("Silahkan Memilih Lokasi Penyimpanan", vbInformation, "Informasi!")

        mySaveFileDialog.Filter = "All files (*.*)|"
        mySaveFileDialog.FileName = "Template Upload DTW Ecom.xlsx"
        If mySaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            LocationSave = IO.Path.GetDirectoryName(mySaveFileDialog.FileName)
        Else
            BolStatusOpenDialog = True
            MsgBox("Dibatalkan!")
        End If

    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        On Error GoTo ErrorLoad

        Button2.Enabled = False
        cmdCancel.Enabled = True

        connDB.Close()
        For i As Integer = 0 To dgListUpload.Rows.Count - 1

            closeDB()

            Call KoneksiMySQL()
            Call initCMD()



            With comDB

                .CommandText = "Call AU_MasterBarang('" & dgListUpload.Rows(i).Cells(0).Value & "','" & dgListUpload.Rows(i).Cells(1).Value & "','" & dgListUpload.Rows(i).Cells(2).Value & "','" & dgListUpload.Rows(i).Cells(3).Value & "','" & dgListUpload.Rows(i).Cells(4).Value & "','" & dgListUpload.Rows(i).Cells(5).Value & "','" & dgListUpload.Rows(i).Cells(6).Value & "','" & dgListUpload.Rows(i).Cells(7).Value & "','" & dgListUpload.Rows(i).Cells(8).Value & "','" & dgListUpload.Rows(i).Cells(9).Value & "','" & dgListUpload.Rows(i).Cells(10).Value & "','" & dgListUpload.Rows(i).Cells(11).Value & "','" & dgListUpload.Rows(i).Cells(12).Value & "','" & dgListUpload.Rows(i).Cells(13).Value & "','" & MstrKdPegawai & "','" & MstrKdPegawai & "','" & dgListUpload.Rows(i).Cells(14).Value & "','" & dgListUpload.Rows(i).Cells(15).Value & "','" & dgListUpload.Rows(i).Cells(16).Value & "','" & dgListUpload.Rows(i).Cells(17).Value & "')"
                .ExecuteNonQuery()
            End With



            If (BackgroundWorker1.CancellationPending) Then
                e.Cancel = True
                Exit For
            End If



            lblProses.Text = "Mengupload :" & i & " Dari " & dgListUpload.Rows.Count
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(1)

        Next


        lblProses.Visible = False
        panelLoading.Visible = False

        lblStatusUpload.Text = "Telah Mengupload :" & dgListUpload.Rows.Count & " Item Master Data"
        Button2.Enabled = True
        cmdCancel.Enabled = False
        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub
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
            panelLoading.Visible = False
            dgListUpload.Rows.Clear()
            lblProses.Text = "Jumlah Data : " & dgListUpload.Rows.Count
        End If
    End Sub

    Private Sub FormUpload_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
