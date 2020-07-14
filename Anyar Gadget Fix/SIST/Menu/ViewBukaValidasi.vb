Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ViewBukaValidasi
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    Dim strKodeKomponen As String
    Dim strKodeJenisValidasi As String
    Dim strpathAttatchments As String
    Dim strNamaAttachments As String
    Dim strExtentionFile As String

    Private Sub BukaValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaForm = "IT003"
        LoadRequest()
    End Sub



    Sub LoadRequest()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String

        strSQlLogin = "SELECT * FROM dbo.V_DetailRequestUsers WHERE NoValidasi='" & Trim(MstrNoSurat) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtNomorSurat.Text = dr.GetString(0)
            txtDisplayTanggal.Text = dr.GetDateTime(3)
            txtDurasi.Text = dr.GetString(8)
            txtDisplayNama.Text = dr.GetString(11)
            txtDisplayLokasi.Text = dr.GetString(23)
            txtKomponenSAP.Text = dr.GetString(5)
            txtKomponenValidasi.Text = dr.GetString(6)
            txtNotifValidasi.Text = dr.GetString(7)
            txtPesanUser.Text = dr.GetString(11)
            txtCatatanIT.Text = dr.GetString(12)
            txtPathLampiran.Text = dr.GetString(16)

        Else
            dr.Close()
            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


    Sub GetExtentionfile()
        Dim p As String = txtPathLampiran.Text
        Dim extension As String = Path.GetExtension(p)
        strExtentionFile = extension
    End Sub

    Sub CopyFileKeDirectoryAttachment()
        If txtPathLampiran.Text = "" Then Exit Sub
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand
        cmd.CommandText = "[OutNamaAttachments]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("NamaAttachments", SqlDbType.VarChar, 50)
        cmd.Parameters("NamaAttachments").Direction = ParameterDirection.Output

        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()
        strNamaAttachments = cmd.Parameters("NamaAttachments").Value.ToString()
        strpathAttatchments = "\\10.1.0.51\Attachments Surat\" & Trim(strNamaAttachments) & strExtentionFile
        My.Computer.FileSystem.CopyFile(Trim(txtPathLampiran.Text), strpathAttatchments, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Exit Sub


    End Sub

    Private Sub BukaValidasi_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub BukaValidasi_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub


    Private Sub cmbTujuan_Click(sender As Object, e As EventArgs)
        LoadComboBoxDBEMAIL(cmbTujuan, "SELECT KodeDivisi,NamaDivisi FROM dbo.V_Divisi WHERE KodeDivisi LIKE '1%'", "KodeDivisi", "NamaDivisi")
    End Sub

    Sub Bersihkan()
        txtPesanUser.Text = ""
        'cmbTujuan.Items.Clear()
        JamAwal.Value = Now

        txtKodeKomponenSAP.Text = ""
        txtKomponenSAP.Text = ""


        txtKodeKomponenValidasi.Text = ""
        txtKomponenValidasi.Text = ""


        txtNotifValidasi.Text = ""
        txtPathLampiran.Text = ""
        Me.Dispose()
    End Sub


    Private Sub cmdBrowseLampiran_Click(sender As Object, e As EventArgs) Handles cmdBrowseLampiran.Click
        Dim strPathHelp As String

        strPathHelp = txtPathLampiran.Text

        If strPathHelp = "" Then
            MsgBox("Tidak Ada Dokumen Bantuan yang Disimpan", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If

        Dim FilePath As String
        FilePath = strPathHelp
        Call ShellExecute(0, "Open", FilePath, "", "", 1)
    End Sub

    Private Sub cmdCariKomponenSAP_Click(sender As Object, e As EventArgs) Handles cmdCariKomponenSAP.Click
        On Error Resume Next
        FormCariKomponenSAP.ShowDialog()
    End Sub

    Private Sub cmdCariKomponenValidasi_Click(sender As Object, e As EventArgs) Handles cmdCariKomponenValidasi.Click
        On Error Resume Next
        FormJenisValidasi.ShowDialog()
    End Sub
End Class