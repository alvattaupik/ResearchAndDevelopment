Imports System.Data.SqlClient
Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbTampilSemua.Checked = False And rbTertentu.Checked = False Then
            MsgBox("Tentukan Item Yang Akan Ditampilkan", vbInformation, "Pilih Filter")
            Exit Sub
        End If

        Call LoadGridView()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo ErrorHandler

        conn_server = "10.1.0.53"
        conn_user = "sa"
        conn_database = "DB_EMAIL"
        conn_pass = "h0spit4lity#"


        Call koneksi()
        Call LoadComboBox()

        lblNamaKomputer.Text = Environment.MachineName()

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        lblIP.Text = h.AddressList.GetValue(0).ToString






        If Err.Description = "" Then Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub

    Private Sub LoadComboBox()
        ' siapkan koneksi database
        koneksi()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT ListNum,ListName FROM RKM_LIVE_2.DBO.OPLN WHERE ListName LIKE '%Harga Jual%'", conn)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbHargaJual.DataSource = dt
            cmbHargaJual.ValueMember = "ListNum"
            cmbHargaJual.DisplayMember = "ListName"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub rbTertentu_CheckedChanged(sender As Object, e As EventArgs) Handles rbTertentu.CheckedChanged
        If rbTertentu.Checked = True Then
            fraFilter.Visible = True
        Else
            fraFilter.Visible = False
        End If

    End Sub





    Sub LoadGridView()
        Call koneksi()


        If rbTampilSemua.Checked = True Then
            If MsgBox("Menampilkan Semua Data akan membutuhkan banyak waktu" & vbNewLine & "Tetap lanjutkan?", vbYesNo) = vbYes Then

                If koneksi() = True Then
                    conn = New SqlConnection(server)
                    Dim cmd As New SqlCommand("SELECT Keterangan,ItemCode,ItemName,HargaJual " _
                                            & " FROM DB_EMAIL.dbo.V_HargaJualRKM " _
                                            & " Where PriceList='" & cmbHargaJual.SelectedValue & "' Order By ItemName", conn)

                    Dim adapter As New SqlDataAdapter(cmd)

                    Dim table As New DataTable

                    adapter.Fill(table)


                    DataGridView1.DataSource = table
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                    DataGridView1.AutoResizeColumns()


                End If
            End If
        Else

            If koneksi() = True Then
                conn = New SqlConnection(server)
                Dim cmd As New SqlCommand("SELECT Keterangan,ItemCode,ItemName,HargaJual " _
                                            & " FROM DB_EMAIL.dbo.V_HargaJualRKM " _
                                            & " Where PriceList='" & cmbHargaJual.SelectedValue & "' AND ItemCode Between '" & Trim(txtKodeBarang1.Text) & "' AND '" & Trim(txtKodeBarang2.Text) & "'", conn)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable

                adapter.Fill(table)


                DataGridView1.DataSource = table
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                DataGridView1.AutoResizeColumns()



            End If
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.txt")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Write As New IO.StreamWriter(sfile.FileName)
            'Dim k As DataGridView1.column = DataGridView1.Columns
            'For Each x As ListViewItem In ListView1.Items
            '    Dim StrLn As String = ""
            '    For i = 1 To x.SubItems.Count - 1
            '        StrLn += x.SubItems(i).Text + vbTab
            '    Next
            '    Write.WriteLine(StrLn)
            'Next
            'Write.Close() 'Or  Write.Flush()
        End If

        Exit Sub




    End Sub
End Class