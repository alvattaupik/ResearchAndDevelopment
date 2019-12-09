Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.NetworkInformation

Public Class Form1
    Dim pi As New Net.NetworkInformation.Ping
    Dim BolTambah As Boolean
    Dim BolUbahCabang As Boolean
    Dim strkodeCabangTemp As String


    Sub LoadDaftarIP()

        Dim strSQl As String

        strSQl = "SELECT  NamaCabang,NamaComputer,IPAddress,Alias,Lokasi, DocEntry,ListKomputerRKM.KodeCabang" & _
                " FROM dbo.ListKomputerRKM LEFT OUTER JOIN dbo.V_MasterCabang ON V_MasterCabang.KodeCabang COLLATE DATABASE_DEFAULT = ListKomputerRKM.KodeCabang COLLATE DATABASE_DEFAULT"

        Call KoneksiDatabase()


        Dim da1 As New SqlDataAdapter(strSQl, Koneksi)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        dgData.DataSource = dt1

        'dgData.Columns(0).Width = 100
        'dgData.Columns(1).Width = 100
        'dgData.Columns(2).Width = 100
        'dgData.Columns(3).Width = 500
        'dgData.Columns(4).Width = 100
        'dgData.Columns(5).Width = 100
        dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


    End Sub





    Private Sub LoadComboBox()
        ' siapkan koneksi database
        KoneksiDatabase()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT KodeCabang,NamaCabang FROM dbo.V_MasterCabang", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbCabang.DataSource = dt
            cmbCabang.ValueMember = "KodeCabang"
            cmbCabang.DisplayMember = "NamaCabang"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadComboBox2()
        ' siapkan koneksi database
        KoneksiDatabase()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT KodeCabang,NamaCabang FROM dbo.V_MasterCabang", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbCabang2.DataSource = dt
            cmbCabang2.ValueMember = "KodeCabang"
            cmbCabang2.DisplayMember = "NamaCabang"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub LoadComboBox3()
        ' siapkan koneksi database
        KoneksiDatabase()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT KodeCabang,NamaCabang FROM dbo.V_MasterCabang", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbCabang2.DataSource = dt
            cmbCabang2.ValueMember = "KodeCabang"
            cmbCabang2.DisplayMember = "NamaCabang"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Sub LoadDaftarIPFilter()

        Dim strSQl As String
        Dim strKodeCabang As String

        strKodeCabang = cmbCabang.SelectedValue.ToString

        strSQl = "SELECT NamaCabang,NamaComputer,IPAddress,Alias,Lokasi, DocEntry,ListKomputerRKM.KodeCabang" & _
                " FROM dbo.ListKomputerRKM LEFT OUTER JOIN dbo.V_MasterCabang ON V_MasterCabang.KodeCabang COLLATE DATABASE_DEFAULT = ListKomputerRKM.KodeCabang COLLATE DATABASE_DEFAULT Where ListKomputerRKM.KodeCabang = '" & cmbCabang.SelectedValue.ToString & "'"

        Call KoneksiDatabase()


        Dim da1 As New SqlDataAdapter(strSQl, Koneksi)
        Dim dt1 As New DataTable
        da1.Fill(dt1)
        dgData.DataSource = dt1

        'dgData.Columns(0).Width = 100
        'dgData.Columns(1).Width = 100
        'dgData.Columns(2).Width = 100
        'dgData.Columns(3).Width = 500
        'dgData.Columns(4).Width = 100
        ' dgData.Columns(5).Width = 100
        dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


    End Sub






    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call LoadComboBox()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarIP()
        lblNamaKomputer.Text = Environment.MachineName()

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        lblIP.Text = h.AddressList.GetValue(0).ToString
    End Sub

    Private Sub cmbCabang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCabang.SelectedValueChanged
        LoadDaftarIPFilter()
    End Sub



    Private Sub cmbCabang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCabang.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(8) Then
            LoadDaftarIP()
        End If
    End Sub

    Private Sub btTutup_Click(sender As Object, e As EventArgs) Handles btTutup.Click
        FraTambahUbah.Visible = False
    End Sub

    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click
        BolTambah = True

        If BolTambah = True Then
            FraTambahUbah.Text = "Tambah Data"
            FraTambahUbah.Visible = True
            txtNamaKomputer.Text = ""
            txtIpAddress.Text = ""
            txtLokasiPemasangan.Text = ""
            cmbCabang2.SelectedValue = ""
            cmbCabang2.Text = ""
            txtketlain.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BolTambah = False
        If BolTambah = False Then
            FraTambahUbah.Text = "Ubah Data"
            FraTambahUbah.Visible = True
            txtDocEntry.Text = dgData.Item(5, dgData.CurrentRow.Index).Value

            strKodeCabangTemp = dgData.Item(6, dgData.CurrentRow.Index).Value
            cmbCabang2.Text = dgData.Item(0, dgData.CurrentRow.Index).Value

            txtNamaKomputer.Text = dgData.Item(1, dgData.CurrentRow.Index).Value
            txtIpAddress.Text = dgData.Item(2, dgData.CurrentRow.Index).Value
            txtLokasiPemasangan.Text = dgData.Item(4, dgData.CurrentRow.Index).Value
            txtketlain.Text = dgData.Item(3, dgData.CurrentRow.Index).Value

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Koneksi.Close()
        If MsgBox("Apakah Anda Akan Menghapus IP : " & dgData.Item(2, dgData.CurrentRow.Index).Value & " Milik :" & dgData.Item(1, dgData.CurrentRow.Index).Value, vbYesNo) = vbYes Then
            Using (Koneksi)

                Dim sqlComm As New SqlCommand

                sqlComm.Connection = Koneksi


                sqlComm.CommandText = "[AUD_IPClientManagement]"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("DocEntry", dgData.Item(5, dgData.CurrentRow.Index).Value)
                sqlComm.Parameters.AddWithValue("KodeCabang", "")
                sqlComm.Parameters.AddWithValue("NamaComputer", "")
                sqlComm.Parameters.AddWithValue("UserName", "")
                sqlComm.Parameters.AddWithValue("Alias", "")
                sqlComm.Parameters.AddWithValue("IPAddress", "")
                sqlComm.Parameters.AddWithValue("Lokasi", "")
                sqlComm.Parameters.AddWithValue("Status", "D")
                Koneksi.Open()
                sqlComm.ExecuteNonQuery()

            End Using
            MsgBox("Data Berhasil Dihapus", vbInformation, "Informasi")
            Bersihkan()
            LoadDaftarIP()
        Else

            Exit Sub
        End If
    End Sub

    Private Sub cmbCabang2_Click(sender As Object, e As EventArgs) Handles cmbCabang2.Click
        BolUbahCabang = True
        LoadComboBox2()

    End Sub



    Private Sub btBatal_Click(sender As Object, e As EventArgs) Handles btBatal.Click
        txtNamaKomputer.Text = ""
        txtIpAddress.Text = ""
        txtLokasiPemasangan.Text = ""
        cmbCabang2.SelectedValue = ""
        cmbCabang2.Text = ""
        txtketlain.Text = ""
    End Sub

    Sub Bersihkan()
        txtNamaKomputer.Text = ""
        txtIpAddress.Text = ""
        txtLokasiPemasangan.Text = ""
        cmbCabang2.SelectedValue = ""
        cmbCabang2.Text = ""
        txtketlain.Text = ""
        FraTambahUbah.Visible = False
    End Sub


    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        If BolTambah = True Then
            Koneksi.Close()
            If cmbCabang2.Text = "" Then
                MsgBox("Nama Cabang Tidak boleh Kosong", vbInformation, "Informasi")
                Exit Sub
            End If


            Using (Koneksi)

                Dim sqlComm As New SqlCommand

                sqlComm.Connection = Koneksi


                sqlComm.CommandText = "[AUD_IPClientManagement]"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("DocEntry", "")
                sqlComm.Parameters.AddWithValue("KodeCabang", cmbCabang2.SelectedValue)
                sqlComm.Parameters.AddWithValue("NamaComputer", txtNamaKomputer.Text)
                sqlComm.Parameters.AddWithValue("UserName", "")
                sqlComm.Parameters.AddWithValue("Alias", txtketlain.Text)
                sqlComm.Parameters.AddWithValue("IPAddress", txtIpAddress.Text)
                sqlComm.Parameters.AddWithValue("Lokasi", txtLokasiPemasangan.Text)
                sqlComm.Parameters.AddWithValue("Status", "A")
                Koneksi.Open()
                sqlComm.ExecuteNonQuery()

            End Using
            MsgBox("Data Berhasil Disimpan", vbInformation, "Informasi")
            Bersihkan()
            FraTambahUbah.Visible = False

            LoadDaftarIP()


        Else
            Koneksi.Close()
            If cmbCabang2.Text = "" Then
                MsgBox("Nama Cabang Tidak boleh Kosong", vbInformation, "Informasi")
                Exit Sub
            End If


            Using (Koneksi)

                Dim sqlComm As New SqlCommand

                sqlComm.Connection = Koneksi


                sqlComm.CommandText = "[AUD_IPClientManagement]"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("DocEntry", txtDocEntry.Text)
                If BolUbahCabang = True Then
                    sqlComm.Parameters.AddWithValue("KodeCabang", cmbCabang2.SelectedValue)
                Else
                    sqlComm.Parameters.AddWithValue("KodeCabang", strkodeCabangTemp)
                End If
                sqlComm.Parameters.AddWithValue("NamaComputer", txtNamaKomputer.Text)
                sqlComm.Parameters.AddWithValue("UserName", "")
                sqlComm.Parameters.AddWithValue("Alias", txtketlain.Text)
                sqlComm.Parameters.AddWithValue("IPAddress", txtIpAddress.Text)
                sqlComm.Parameters.AddWithValue("Lokasi", txtLokasiPemasangan.Text)
                sqlComm.Parameters.AddWithValue("Status", "A")
                Koneksi.Open()
                sqlComm.ExecuteNonQuery()

            End Using
            MsgBox("Data Berhasil Disimpan", vbInformation, "Informasi")
            Bersihkan()

            LoadDaftarIP()
        End If
    End Sub


    Private Sub cmbCabang2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCabang2.SelectedIndexChanged
        'LoadComboBox2()
    End Sub

  

    Private Sub cmdPing_Click(sender As Object, e As EventArgs) Handles cmdPing.Click
        'Timer1.Enabled = True
        'Panel1.Visible = True
        'Dim IP As String = InputBox("Enter Client's IP", "Ping To Client")

        Shell("CMD.exe /C ping " & (Trim(dgData.Item(2, dgData.CurrentRow.Index).Value)) & " -t", AppWinStyle.NormalFocus)
    End Sub


End Class
