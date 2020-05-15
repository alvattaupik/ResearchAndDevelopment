Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormMasterJenisValidasi



    Sub LoadDaftarJenisValidasi()

        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand("	SELECT * FROM dbo.JenisValidasi Where NamaValidasi Like '%" & txtCariJenisValidasi.Text & "%'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgMasterJenisValidasi.DataSource = table
        dgMasterJenisValidasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgMasterJenisValidasi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgMasterJenisValidasi.AutoResizeColumns()

    End Sub


    Sub LoadDetailJenisValidasi()
        Call KoneksiDatabase1()
        Dim strSQlLogin As String
        Dim strStatusAktif As String

        strSQlLogin = "SELECT Cast(KdJenisValidasi As varchar(10)),NamaValidasi,NamaExternal,ISNULL(NamaKomponen,'') AS NamaKomponen,StatusEnabled FROM dbo.JenisValidasi LEFT OUTER JOIN dbo.V_KomponenSAP ON V_KomponenSAP.DocCode COLLATE DATABASE_DEFAULT= JenisValidasi.DocCode COLLATE DATABASE_DEFAULT WHERE KdJenisValidasi='" & Trim(dgMasterJenisValidasi.Item(0, dgMasterJenisValidasi.CurrentRow.Index).Value) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtKdjenisValidasi.Text = dr.GetString(0)
            txtJenisValidasi.Text = dr.GetString(1)
            txtNamaExternal.Text = dr.GetString(2)
            cmbKelompokValidasi.Text = dr.GetString(3)

            strStatusAktif = dr.GetString(4)

            If strStatusAktif = "Y" Then
                chkAktif.Checked = True
            Else
                chkAktif.Checked = False
            End If
        Else

            Exit Sub
        End If

        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Sub LoadComboKomponenSAP()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT DocCode,NamaKomponen FROM dbo.V_KomponenSAP", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbKelompokValidasi.DataSource = ds.Tables(0)
            cmbKelompokValidasi.ValueMember = "DocCode"
            cmbKelompokValidasi.DisplayMember = "NamaKomponen"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub




    Private Sub FormJenisValidasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarJenisValidasi()
    End Sub

    Private Sub txtCariJenisValidasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariJenisValidasi.KeyPress
        LoadDaftarJenisValidasi()
    End Sub

    Private Sub cmbKelompokValidasi_Click(sender As Object, e As EventArgs) Handles cmbKelompokValidasi.Click
        LoadComboKomponenSAP()
    End Sub

    Private Sub dgMasterJenisValidasi_Click(sender As Object, e As EventArgs) Handles dgMasterJenisValidasi.Click
        LoadDetailJenisValidasi()
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        On Error GoTo ErrorLoad



        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand

        cmd.CommandText = "[AU_DetailJenisValidasi]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("KdJenisValidasi", Trim(txtKdjenisValidasi.Text))
        cmd.Parameters.AddWithValue("NamaValidasi", Trim(txtJenisValidasi.Text))
        cmd.Parameters.AddWithValue("NamaExternal", Trim(txtNamaExternal.Text))
        cmd.Parameters.AddWithValue("DocCode", Trim(cmbKelompokValidasi.Text))
        cmd.Parameters.AddWithValue("StatusEnabled", Trim(chkAktif.CheckState))

        If (Koneksi1.State = ConnectionState.Open) Then Koneksi1.Close()
        cmd.Connection = Koneksi1
        Koneksi1.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan", vbInformation, "Sukses")
        LoadDaftarJenisValidasi()
        Bersihkan()
        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)

        Exit Sub
    End Sub


    Sub Bersihkan()
        txtKdjenisValidasi.Text = ""
        txtJenisValidasi.Text = ""
        txtNamaExternal.Text = ""
        chkAktif.Checked = False
        cmbKelompokValidasi.Text = ""
    End Sub

    Private Sub cmdbatal_Click(sender As Object, e As EventArgs) Handles cmdbatal.Click
        Bersihkan()
    End Sub
End Class