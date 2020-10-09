Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmBantuan
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Dim fileName As String
    Private myBindingSource As New BindingSource()



    Private Sub cmbKategori_Click(sender As Object, e As EventArgs) Handles cmbKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbKategori, "SELECT IDCategories,Deskripsi FROM dbo.OCategories WHERE  StatusEnabled='Y'", "IDCategories", "Deskripsi", KoneksiDBEmail)
    End Sub



    Private Sub cmbSubKategori_Click(sender As Object, e As EventArgs) Handles cmbSubKategori.Click
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbSubKategori, "SELECT IDSub,Deskripsi FROM dbo.Categories1 WHERE  StatusEnabled='Y' AND Cast(IDCategories AS varchar(100))='" & cmbKategori.SelectedValue & "'", "IDSub", "Deskripsi", KoneksiDBEmail)
    End Sub





    Private Sub cmbSubKategori_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubKategori.SelectionChangeCommitted
        dgvKonten.DataSource = Nothing
        dgvKonten.Rows.Clear()
        'Call KoneksiDB_EMAIL()
        'LoadDataGrid(dgvKonten, "SELECT ID,NamaKonten,IDKategori,IDSubKategori FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSubKategori='" & cmbSubKategori.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)
        LoadDetailKonten()



    End Sub



    Sub LoadDetailKonten()
        Call KoneksiDB_EMAIL()
        Dim cmd As New SqlCommand("SELECT ID,NamaKonten FROM dbo.OHelp Where Cast(IDKategori AS varchar(100))='" & cmbKategori.SelectedValue & "' and IDSubKategori='" & cmbSubKategori.SelectedValue & "' AND StatusEnabled='Y'", KoneksiDBEmail)

        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)

        myBindingSource.DataSource = table
        dgvKonten.DataSource = myBindingSource

        dgvKonten.DataSource = table
        dgvKonten.Refresh()
        dgvKonten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvKonten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvKonten.AutoResizeColumns()

    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            If Tombol = 13 Then
                Me.myBindingSource.Filter = "NamaKonten Like '%" & txtCari.Text & "%'"
                dgvKonten.Refresh()
            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub dgvKonten_Click(sender As Object, e As EventArgs) Handles dgvKonten.Click
        txtKodeKonten.Text = dgvKonten.Item(0, dgvKonten.CurrentRow.Index).Value
        txtDeskripsi.Text = dgvKonten.Item(1, dgvKonten.CurrentRow.Index).Value
        txtKategori.Text = cmbKategori.Text
        txtSubKategori.Text = cmbSubKategori.Text

        KoneksiDB_EMAIL()
        LoadDataGrid(dgvDaftarLampiran, "SELECT AttachID,NamaFile,LokasiFile FROM dbo.Help1 WHere ID='" & Trim(txtKodeKonten.Text) & "'", KoneksiDBEmail)

    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        On Error Resume Next
        If dgvDaftarLampiran.Rows.Count = 0 Then Exit Sub

        If dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value = "" Then
            DisplayPesanError("No Attachment Included", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        Else
            Call ShellExecute(0, "Open", dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value, "", "", 1)
        End If


    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        'On Error GoTo ErrorLoad
        CopyFileKeLokasiLain(dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value, Path.GetFileName((dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value)))







        'Try

        '    Dim LocationSave As String

        '    Dim mySaveFileDialog As New SaveFileDialog


        '    MsgBox("Silahkan Memilih Lokasi Penyimpanan", vbInformation, "Informasi!")

        '    mySaveFileDialog.Filter = "All files (*.*)|"
        '    mySaveFileDialog.FileName = Path.GetFileName((dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value))
        '    If mySaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

        '        LocationSave = IO.Path.GetDirectoryName(mySaveFileDialog.FileName)
        '        My.Computer.FileSystem.CopyFile(Trim(dgvDaftarLampiran.Item(2, dgvDaftarLampiran.CurrentRow.Index).Value), LocationSave + "\" + fileName,
        '        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        '        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        '    Else

        '        Exit Sub
        '    End If

        '    Exit Sub

        'Catch ex As Exception
        '    DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        'End Try

       




    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub
End Class