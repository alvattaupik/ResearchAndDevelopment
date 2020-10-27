Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Guna
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.IO
Module ModuleUltility

    Public mBolFunction As Boolean


    'Public cryRpt As New ReportDocument
    'Public crtableLogoninfos As New TableLogOnInfos
    'Public crtableLogoninfo As New TableLogOnInfo
    'Public crConnectionInfo As New ConnectionInfo
    'Public CrTables As Tables
    'Public CrTable As Table
    'Public RptDocument As New ReportDocument
    'Public reportDocument As New ReportDocument()
    'Public paramField As New ParameterField()
    'Public paramFields As New ParameterFields()
    'Public paramDiscreteValue As New ParameterDiscreteValue()
    'Public paramField2 As New ParameterField()
    'Public paramFields2 As New ParameterFields()
    'Public paramDiscreteValue2 As New ParameterDiscreteValue()

    Sub LoadDataGrid(dgv As DataGridView, strQuery As String, connection As System.Data.SqlClient.SqlConnection)

        Try

            cmd = New SqlCommand(strQuery, connection)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgv.DataSource = table
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgv.AutoResizeColumns()

        Catch ex As Exception
            MessageBox.Show("Kesalahan memuat datagrid !: ( " & strQuery & ")")
        End Try

    End Sub
    Sub LoadComboBox(cmb As ComboBox, strQuery As String, strKode As String, strDeskripsi As String, connection As System.Data.SqlClient.SqlConnection)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            cmd = New SqlCommand(strQuery, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            connection.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strKode
            cmb.DisplayMember = strDeskripsi
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub
    Sub MessageBoxWarningOkGunaUI(txt As Guna.UI.WinForms.GunaTextBox, strPesan As String)
        If txt.Text = "" Then
            MsgBox(strPesan, MessageBoxButtons.OK, "Perhatian !")
            mBolFunction = True
        End If
    End Sub

    Sub MessageBoxWarningOkWinform(txt As TextBox, strPesan As String)
        If txt.Text = "" Then
            MsgBox(strPesan, MessageBoxButtons.OK, "Perhatian !")
            mBolFunction = True
        End If
    End Sub


 



 

    Public Sub FnCustomTimer(tmr As Timer, durasi As Integer)

        MintNilaiTimer = durasi * 1000

    End Sub
    Public Sub DisplayPesanError(strPesan As String, txtObject As TextBox, intInterval As Integer)
        txtObject.Visible = True
        frmMainMenu.txtJamDanWaktu.Visible = False
        frmMainMenu.TimerPesanError.Enabled = True

        txtObject.Text = strPesan
        txtObject.BackColor = Color.Red
        frmMainMenu.TimerPesanError.Interval = intInterval
        frmMainMenu.TimerPesanError.Start()

    End Sub
    Public Sub DisplayPesanOK(strPesan As String, txtObject As TextBox, intInterval As Integer)
        txtObject.Visible = True
        frmMainMenu.TimerPesanError.Enabled = True
        frmMainMenu.txtJamDanWaktu.Visible = False
        txtObject.Text = strPesan
        txtObject.BackColor = Color.LightGreen
        frmMainMenu.TimerPesanError.Interval = intInterval
        frmMainMenu.TimerPesanError.Start()


    End Sub
    Sub AUD_MenuAplikasi(strFunction As String, strDocEntry As String, strKode As String, strKodeDetail As String, strDeskripsi As String, strNamaExternal As String, strStatusEnabled As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_MenuAplikasi]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("DocEntry", Trim(strDocEntry))
            command.Parameters.AddWithValue("Kode", Trim(strKode))
            command.Parameters.AddWithValue("KodeDetail", Trim(strKodeDetail))
            command.Parameters.AddWithValue("Deskripsi", Trim(strDeskripsi))
            command.Parameters.AddWithValue("NamaExternal", Trim(strNamaExternal))
            command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
            command.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))

            command.Parameters.Add("StatusRecordOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusRecordOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            If Microsoft.VisualBasic.Left(strFunction, 1) = "A" Then

                If command.Parameters("StatusRecordOUT").Value.ToString() <> "0" Then
                    DisplayPesanError("Kode Telah Digunakan !", frmMainMenu.txtPesanError, 1000)
                  
                    Exit Sub
                Else
                    DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)
                   
                End If
            Else
                DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)



            End If


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub AUD_MenuAplikasiSpecificITIL(strFunction As String, strDocEntry As String, strKode As String, strKodeDetail As String, strDeskripsi As String, strNamaExternal As String, strKodeAplikasi As String, strStatusEnabled As String)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[AUD_MenuAplikasi]", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("DocEntry", Trim(strDocEntry))
            command.Parameters.AddWithValue("Kode", Trim(strKode))
            command.Parameters.AddWithValue("KodeDetail", Trim(strKodeDetail))
            command.Parameters.AddWithValue("Deskripsi", Trim(strDeskripsi))
            command.Parameters.AddWithValue("NamaExternal", Trim(strNamaExternal))
            command.Parameters.AddWithValue("KodeAplikasi", Trim(strKodeAplikasi))
            command.Parameters.AddWithValue("StatusEnabled", Trim(strStatusEnabled))

            command.Parameters.Add("StatusRecordOUT", SqlDbType.VarChar, 100)
            command.Parameters("StatusRecordOUT").Direction = ParameterDirection.Output


            command.Parameters.AddWithValue("Function", Trim(strFunction))

            If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
            command.Connection = KoneksiDBEmail
            KoneksiDBEmail.Open()
            command.ExecuteNonQuery()


            If Microsoft.VisualBasic.Left(strFunction, 1) = "A" Then

                If command.Parameters("StatusRecordOUT").Value.ToString() <> "0" Then
                    DisplayPesanError("Kode Telah Digunakan !", frmMainMenu.txtPesanError, 1000)

                    Exit Sub
                Else
                    DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)

                End If
            Else
                DisplayPesanOK("Operation Success !", frmMainMenu.txtPesanError, 1000)



            End If


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



  




    Sub GetExtentionfile(strPath As String)
        ' Get extension.
        Dim extension As String = Path.GetExtension(strPath)

        ' Display extension.
        MstrExtentionFile = extension

    End Sub


    Sub CopyFileKeDirectoryAttachment(strNamaAttachments As String, strLokasiAsal As String)


        MstrpathAttatchments = "\\10.1.0.52\Attachments Surat\ITIL INCIDENT MANAGEMENT\" & Trim(strNamaAttachments) & MstrExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), MstrpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub


    Sub CopyFileKeDirectoryAttachmentReq(strNamaAttachments As String, strLokasiAsal As String)


        MstrpathAttatchments = "\\10.1.0.52\Attachments Surat\ITIL REQ FULLFILLMENT\" & Trim(strNamaAttachments) & MstrExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), MstrpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub


    Sub CopyFileKeLokasiLain(strLokasiAsal As String, strFileName As String)
        Try

            Dim LocationSave As String

            Dim mySaveFileDialog As New SaveFileDialog


            MsgBox("Silahkan Memilih Lokasi Penyimpanan", vbInformation, "Informasi!")

            mySaveFileDialog.Filter = "All files (*.*)|"
            mySaveFileDialog.FileName = strFileName
            If mySaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                LocationSave = IO.Path.GetDirectoryName(mySaveFileDialog.FileName)
                My.Computer.FileSystem.CopyFile(Trim(strLokasiAsal), LocationSave + "\" + strFileName,
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                DisplayPesanOK("Download Successfully, Saved in : " & LocationSave + "\" + strFileName, frmMainMenu.txtPesanError, 1000)

            Else

                Exit Sub
            End If

            Exit Sub



        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub

    'Public Sub Module_Konfigurasi_laporan()
    '    With crConnectionInfo
    '        .ServerName = "10.1.0.53"
    '        .UserID = "sa"
    '        .Password = "h0spit4lity#"
    '        .DatabaseName = "DB_EMAIL"
    '    End With
    '    CrTables = cryRpt.Database.Tables
    '    For Each CrTable In CrTables
    '        crtableLogoninfo = CrTable.LogOnInfo
    '        crtableLogoninfo.ConnectionInfo = crConnectionInfo
    '        CrTable.ApplyLogOnInfo(crtableLogoninfo)
    '    Next
    'End Sub




    Sub CopyDataGridViewToClipboard(ByRef dgv As DataGridView)
        Dim s As String = ""
        Dim oCurrentCol As DataGridViewColumn    'Get header
        oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Do
            s &= oCurrentCol.HeaderText & Chr(Keys.Tab)
            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, _
               DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Loop Until oCurrentCol Is Nothing
        s = s.Substring(0, s.Length - 1)
        s &= Environment.NewLine    'Get rows
        For Each row As DataGridViewRow In dgv.Rows
            oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
            Do
                If row.Cells(oCurrentCol.Index).Value IsNot Nothing Then
                    s &= row.Cells(oCurrentCol.Index).Value.ToString
                End If
                s &= Chr(Keys.Tab)
                oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, _
                      DataGridViewElementStates.Visible, DataGridViewElementStates.None)
            Loop Until oCurrentCol Is Nothing
            s = s.Substring(0, s.Length - 1)
            s &= Environment.NewLine
        Next    'Put to clipboard
        Dim o As New DataObject
        o.SetText(s)

        Clipboard.ContainsText()
        Clipboard.SetDataObject(o, True, 10, 200)



    End Sub



    Sub ExportToExcel(lbl As Label, dgv As DataGridView)

        If dgv.RowCount = 0 Then
            DisplayPesanError("No Records To Export", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        Dim ApExcel As Object

        'Set sebagai excel  object
        ApExcel = CreateObject("Excel.application")

        'Menyembunyikan proses excel
        ApExcel.Visible = False

        'Membuat/menambah workbook baru
        ApExcel.Workbooks.Add()


        'Lebar Kolom
        ApExcel.Columns(1).ColumnWidth = 15
        ApExcel.Columns(2).ColumnWidth = 20

        'Tulis nama kolom ke excel
        For i As Integer = 1 To dgv.Columns.Count
            ApExcel.Cells(1, i).Value = dgv.Columns(i - 1).Name
        Next

        lbl.Visible = True

        'Tulis data ke excel
        For r = 0 To dgv.RowCount - 1
            For i As Integer = 1 To dgv.Columns.Count
                ApExcel.Cells(r + 2, i).Value = dgv.Rows(r).Cells(i - 1).Value
                lbl.Text = "Mengexport : " & r & " Dari : " & dgv.RowCount

            Next
        Next

        'Membuat Font Bold
        ApExcel.Range("A1:M1").Font.Bold = True

        'Memberi warna backgound
        ApExcel.Range("A1:M1").interior.colorindex = 36

        'Agar nilai cell yang panjang menjadi beberapa baris
        ApExcel.Range("A2:B" & dgv.RowCount + 1).WrapText = True

        'Membuat border hitam
        'ApExcel.Range("A1:M" & dgDaftarMember.RowCount + 1).Borders.Color = RGB(0, 0, 0)
        ApExcel.Visible = True
        ApExcel = Nothing
        lbl.Visible = False
    End Sub


End Module
