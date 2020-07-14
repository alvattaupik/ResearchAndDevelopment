Imports System.IO
Public Class AnyarRepository
    Dim path As String
    Dim nextPath As String
    Dim fileName As String

    Private Sub AnyarRepository_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        ListView1.Clear()
        path = "\\10.1.0.51\test"
        'path = "D:\"

        For Each i In My.Computer.FileSystem.GetDirectories(path)
            ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
            TextBox1.Text = path
        Next


        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments)

        '    ListView1.Items.Add(foundFile.Substring(foundFile.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        'Next


        'For Each i In My.Computer.FileSystem.GetDirectories(path)
        '    ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        '    TextBox1.Text = path
        'Next


    End Sub

    Sub LoadMainDirectory()
        On Error Resume Next
        ListView1.Clear()

        If My.Settings.PathAnyarRepository = "" Then
            path = "\\10.1.0.51\test"
        Else

            path = My.Settings.PathAnyarRepository
        End If

        For Each i In My.Computer.FileSystem.GetDirectories(path)
            ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
            TextBox1.Text = path
        Next


    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        nextPath = path + "\" + e.Item.Text
        fileName = e.Item.Text
        TextBox2.Text = nextPath
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick

        If (My.Computer.FileSystem.DirectoryExists(nextPath)) Then
            path = nextPath
            ListView1.Clear()
            TextBox1.Text = path

            For Each i In My.Computer.FileSystem.GetDirectories(path)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
                TextBox1.Text = path
            Next


            For Each foundFile As String In My.Computer.FileSystem.GetFiles(path)

                ListView1.Items.Add(foundFile.Substring(foundFile.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
            Next

            'TextBox1.Text = path & "\" & ListView1.SelectedItems(1).Text

            'TextBox1.Text = path
        Else
            MsgBox("Anda Tidak Dapat Membuka File Berikut", vbCritical, "Warning!")
            Exit Sub
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'path = nextPath

        'For Each i In My.Computer.FileSystem.GetDirectories(path)
        '    ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        'Next

        'For Each i In My.Computer.FileSystem.GetDirectories(path)
        '    ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        'Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LoadMainDirectory()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LocationSave As String

        Dim mySaveFileDialog As New SaveFileDialog


        MsgBox("Silahkan Memilih Lokasi Penyimpanan", vbInformation, "Informasi!")

        mySaveFileDialog.Filter = "All files (*.*)|"
        mySaveFileDialog.FileName = fileName
        If mySaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            LocationSave = IO.Path.GetDirectoryName(mySaveFileDialog.FileName)
            My.Computer.FileSystem.CopyFile(Trim(TextBox2.Text), LocationSave + "\" + fileName,
     Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
     Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Else

            Exit Sub
        End If


        'Using O As New OpenFileDialog
        '    If O.ShowDialog = 1 Then
        '        TextBox3.Text = O.FileName
        '    End If
        'End Using

        'My.Computer.FileSystem.CopyFile(Trim(TextBox3.Text), TextBox2.Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
    End Sub

    Private Sub GunaCirclePictureBox2_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox2.Click
        gbPathDirectory.Visible = True
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        With My.Settings
            .PathAnyarRepository = Trim(txtPathDirectory.Text)
            .Save()
        End With
        gbPathDirectory.Visible = False

    End Sub
End Class