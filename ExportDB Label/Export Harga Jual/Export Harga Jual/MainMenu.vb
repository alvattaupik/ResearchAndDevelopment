Imports System.Data.SqlClient
Imports System.IO

Public Class MainMenu

    Private Sub txtCariAset_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariAset.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            If cmbLokasi.Text = "" Then

                KoneksiDatabase()

                Dim cmd As New SqlCommand("SELECT  [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' Order By ItemName ", Koneksi)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable

                adapter.Fill(table)


                dgAsetSAP.DataSource = table

                'aturDGV()
                dgAsetSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgAsetSAP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgAsetSAP.AutoResizeColumns()
                Koneksi.Close()

                lblJumlahDataSAP.Text = "Jumlah Aset : " & dgAsetSAP.RowCount

            Else

                KoneksiDatabase()

                Dim cmd As New SqlCommand("SELECT  [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' AND Lokasi= '" & Trim(cmbLokasi.Text) & "' Order By ItemName ", Koneksi)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable

                adapter.Fill(table)


                dgAsetSAP.DataSource = table

                'aturDGV()
                dgAsetSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgAsetSAP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgAsetSAP.AutoResizeColumns()
                Koneksi.Close()
                lblJumlahDataSAP.Text = "Jumlah Aset : " & dgAsetSAP.RowCount

            End If



        Else
            Exit Sub
        End If

    End Sub

    Sub LoadGridViewPencarian()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT top 10 [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' ", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgAsetSAP.DataSource = table

        'aturDGV()
        dgAsetSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgAsetSAP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgAsetSAP.AutoResizeColumns()
        Koneksi.Close()

    End Sub


    Sub LoadGridViewPencarianSudahDicetak()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT top 10 [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' And ItemCode In (Select KodeAset From LabelSudahDicetak) ", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        dgAsetSAP.DataSource = table

        'aturDGV()
        dgAsetSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgAsetSAP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgAsetSAP.AutoResizeColumns()
        Koneksi.Close()

    End Sub






    Private Sub LoadDaftarCabang()

        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT KodeLokasi,NamaLokasi FROM dbo.V_Lokasi", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbLokasi.DataSource = dt
            cmbLokasi.ValueMember = "KodeLokasi"
            cmbLokasi.DisplayMember = "NamaLokasi"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadDaftarCabangSudahDicetak()

        KoneksiDatabase()
        Dim da As New SqlDataAdapter("SELECT KodeLokasi,NamaLokasi FROM dbo.V_Lokasi", Koneksi)
        Dim dt As New DataTable
        ' enclose in try-catch block
        ' untuk menghindari crash jika terjadi kesalahan database
        Try
            ' ambil data dari database
            da.Fill(dt)
            ' bind data ke combobox
            cmbLokasiSudahDicetak.DataSource = dt
            cmbLokasiSudahDicetak.ValueMember = "KodeLokasi"
            cmbLokasiSudahDicetak.DisplayMember = "NamaLokasi"
            ' DONE!!!
        Catch ex As Exception
            ' tampilkan pesan error
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub cmbLokasi_Click(sender As Object, e As EventArgs) Handles cmbLokasi.Click
        LoadDaftarCabang()
    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        On Error GoTo ErrorLoad






        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0

        For Each drr As DataGridViewRow In dgAsetSAP.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To dgKeranjangExport.RowCount - 1

                    If dgKeranjangExport.Rows(barisatas).Cells(0).Value = dgAsetSAP.Rows(intBarisNow).Cells(0).Value Then
                        BolDuplikat = True
                        JumlahDuplikat = JumlahDuplikat + 1
                    Else

                        BolDuplikat = False

                    End If
                Next


            Next
            If JumlahDuplikat > 0 Then
                Exit Sub
            Else
                dgKeranjangExport.Rows.Add(row2)
                dgKeranjangExport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgKeranjangExport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgKeranjangExport.AutoResizeColumns()

                lblJumlahData.Text = "Jumlah Data Yang Akan Di Export : " & dgKeranjangExport.RowCount

            End If

        Next
        Exit Sub
ErrorLoad:
        MsubPesanError()
        Exit Sub
    End Sub

    Private Sub cmdExportDB_Click(sender As Object, e As EventArgs) Handles cmdExportDB.Click
        Dim count1 As Integer = 0

        MsgBox("Pilih Lokasi Penyimpanan", vbInformation, "Informasi")

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.txt")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Writer As TextWriter = New StreamWriter(sfile.FileName)

            For i As Integer = 0 To dgKeranjangExport.Rows.Count - 1 Step +1
                For j As Integer = 0 To dgKeranjangExport.Columns.Count - 1 Step +1
                    Writer.Write(dgKeranjangExport.Rows(i).Cells(j).Value.ToString() & vbTab)
                Next
                Writer.WriteLine(vbTab)
            Next
            Writer.Close() 'Or  Write.Flush()
            AU_LabelSudahDicetak()
            MsgBox("Database Berhasil Di Export", vbInformation, "Sukes")


        End If

        Exit Sub


    End Sub


    Sub AU_LabelSudahDicetak()
        Koneksi.Close()
        Dim strKodeAset As String

        For i As Integer = 0 To dgKeranjangExport.Rows.Count - 1
            strKodeAset = dgKeranjangExport.Rows(i).Cells(0).Value


            Using (Koneksi)

                Dim sqlComm As New SqlCommand


                Koneksi = New SqlConnection(strKoneksi)
                sqlComm.Connection = Koneksi

                sqlComm.CommandText = "[AU_StikerSudahDicetak]"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("KodeAset", Trim(strKodeAset))

                Koneksi.Open()
                sqlComm.ExecuteNonQuery()


                'Dim cmd As SqlCommand

                'cmd = New SqlCommand("AU_StikerSudahDicetak", Koneksi)
                'cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.Add(New SqlParameter("@KodeAset", Trim(strKodeAset)))

                'Koneksi.Open()
                'cmd.ExecuteNonQuery()



            End Using




            'Dim cmd As SqlCommand

            'cmd = New SqlCommand("AU_StikerSudahDicetak", Koneksi)
            'cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add(New SqlParameter("@KodeAset", Trim(strKodeAset)))

        Next

    End Sub

    Private Sub cmbLokasiSudahDicetak_Click(sender As Object, e As EventArgs) Handles cmbLokasiSudahDicetak.Click
        LoadDaftarCabangSudahDicetak()
    End Sub


    Private Sub txtCariAsetSudahDicetak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariAsetSudahDicetak.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then

            If cmbLokasiSudahDicetak.Text = "" Then

                KoneksiDatabase()

                Dim cmd As New SqlCommand("SELECT  [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAsetSudahDicetak.Text) & "%' AND [Kode Aset] In (Select KodeAset COLLATE DATABASE_DEFAULT From LabelSudahDiCetak) Order By ItemName ", Koneksi)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable

                adapter.Fill(table)


                dgAsetSAPSudahDicetak.DataSource = table

                'aturDGV()
                dgAsetSAPSudahDicetak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgAsetSAPSudahDicetak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgAsetSAPSudahDicetak.AutoResizeColumns()
                Koneksi.Close()

                test.Text = "Jumlah Aset : " & dgAsetSAPSudahDicetak.RowCount

            Else

                KoneksiDatabase()

                Dim cmd As New SqlCommand("SELECT  [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAsetSudahDicetak.Text) & "%' AND Lokasi= '" & Trim(cmbLokasiSudahDicetak.Text) & "' AND [Kode Aset] In (Select KodeAset COLLATE DATABASE_DEFAULT From LabelSudahDiCetak) Order By ItemName ", Koneksi)

                Dim adapter As New SqlDataAdapter(cmd)

                Dim table As New DataTable

                adapter.Fill(table)


                dgAsetSAPSudahDicetak.DataSource = table

                'aturDGV()
                dgAsetSAPSudahDicetak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgAsetSAPSudahDicetak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgAsetSAPSudahDicetak.AutoResizeColumns()
                Koneksi.Close()
                test.Text = "Jumlah Aset : " & dgAsetSAPSudahDicetak.RowCount

            End If



        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmdTambahSudahDicetak_Click(sender As Object, e As EventArgs) Handles cmdTambahSudahDicetak.Click
        On Error GoTo ErrorLoad






        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0

        For Each drr As DataGridViewRow In dgAsetSAPSudahDicetak.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To dgKeranjangExportSudahDicetak.RowCount - 1

                    If dgKeranjangExportSudahDicetak.Rows(barisatas).Cells(0).Value = dgAsetSAPSudahDicetak.Rows(intBarisNow).Cells(0).Value Then
                        BolDuplikat = True
                        JumlahDuplikat = JumlahDuplikat + 1
                    Else

                        BolDuplikat = False

                    End If
                Next


            Next
            If JumlahDuplikat > 0 Then
                Exit Sub
            Else
                dgKeranjangExportSudahDicetak.Rows.Add(row2)
                dgKeranjangExportSudahDicetak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgKeranjangExportSudahDicetak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgKeranjangExportSudahDicetak.AutoResizeColumns()

                lblJumlahDataSudahDicetak.Text = "Jumlah Data Yang Akan Di Export : " & dgKeranjangExportSudahDicetak.RowCount

            End If

        Next
        Exit Sub
ErrorLoad:
        MsubPesanError()
        Exit Sub
    End Sub
End Class