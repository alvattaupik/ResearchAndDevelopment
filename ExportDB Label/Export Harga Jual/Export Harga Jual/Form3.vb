Imports System.Data.SqlClient
Imports System.IO
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error GoTo ErrorHandler

        lblNamaKomputer.Text = Environment.MachineName()

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        lblIP.Text = h.AddressList.GetValue(0).ToString


        Call LoadGridView()
        'Call aturDGV2()


        If Err.Description = "" Then Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub

    Private Sub LoadComboBox()
      
    End Sub




    Private Sub rbTertentu_CheckedChanged(sender As Object, e As EventArgs)
      
    End Sub





    Sub LoadGridView()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi FROM V_LabelAsetRKM ", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        DataGridView1.DataSource = table


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        DataGridView1.AutoResizeColumns()
        Koneksi.Close()


    End Sub


    Sub LoadGridViewPencarian()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT top 10 [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' ", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        DataGridView1.DataSource = table

        aturDGV()
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'DataGridView1.AutoResizeColumns()
        Koneksi.Close()

    End Sub




    Sub LoadGridViewPencarianSudahDicetak()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT [Kode Aset],[Nama Aset],Tahun,ItemName,Lokasi From V_LabelAsetRKM Where ItemName  LIKE  '%" & Trim(txtCariAset.Text) & "%' ", Koneksi)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)
        DataGridView1.DataSource = table
        aturDGV()

        DataGridView1.AutoResizeColumns()
        Koneksi.Close()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)

        'Dim sfile As New SaveFileDialog
        'With sfile
        '    .Title = "Choose your path to save the information"
        '    .InitialDirectory = "C:\"
        '    .Filter = ("ONLY Text Files (*.txt) | *.txt")
        'End With

        'If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Dim Write As New IO.StreamWriter(sfile.FileName)
        '    'Dim k As DataGridView1.column = DataGridView1.Columns
        '    'For Each x As ListViewItem In ListView1.Items
        '    '    Dim StrLn As String = ""
        '    '    For i = 1 To x.SubItems.Count - 1
        '    '        StrLn += x.SubItems(i).Text + vbTab
        '    '    Next
        '    '    Write.WriteLine(StrLn)
        '    'Next
        '    'Write.Close() 'Or  Write.Flush()
        ''End If

        'Exit Sub





    End Sub



    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 0
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 500
            DataGridView1.Columns(3).Width = 700
            DataGridView1.Columns(4).Width = 700
            DataGridView1.Columns(5).Width = 100

        Catch ex As Exception
        End Try
    End Sub


    Sub aturDGV2()
        Try
            dgKeranjangCetak.Columns(0).HeaderText = "Kode Aset"
            dgKeranjangCetak.Columns(1).HeaderText = "Nama Aset"
            dgKeranjangCetak.Columns(2).HeaderText = "Tahun"
            dgKeranjangCetak.Columns(3).HeaderText = "ItemName"
            dgKeranjangCetak.Columns(4).HeaderText = "Lokasi"

        Catch ex As Exception
        End Try
    End Sub




    Sub LoadGridViewSudahDicetak()

        KoneksiDatabase()

        Dim cmd As New SqlCommand("SELECT * FROM dbo.V_LabelAsetRKM WHERE [Kode Aset] IN (SELECT KodeAset COLLATE DATABASE_DEFAULT FROM dbo.LabelSudahDiCetak) ", Koneksi)

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)


        DataGridView1.DataSource = table

        aturDGV()
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        DataGridView1.AutoResizeColumns()
        Koneksi.Close()

    End Sub





    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

   

        Dim count1 As Integer = 0

        Dim sfile As New SaveFileDialog
        With sfile
            .Title = "Choose your path to save the information"
            .InitialDirectory = "C:\"
            .Filter = ("ONLY Text Files (*.txt) | *.txt")
        End With

        If sfile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim Writer As TextWriter = New StreamWriter(sfile.FileName)





            For i As Integer = 0 To dgKeranjangCetak.Rows.Count - 1 Step +1
                For j As Integer = 0 To dgKeranjangCetak.Columns.Count - 1 Step +1
                    Writer.Write(dgKeranjangCetak.Rows(i).Cells(j).Value.ToString() & vbTab)
                Next
                Writer.WriteLine(vbTab)
            Next
            Writer.Close() 'Or  Write.Flush()


            'Using (Koneksi)

            '    For i As Integer = 0 To dgKeranjangCetak.Rows.Count - 2 Step +1

            '        Dim sqlComm As New SqlCommand

            '        sqlComm.Connection = Koneksi


            '        sqlComm.CommandText = "[AU_StikerSudahDicetak]"
            '        sqlComm.CommandType = CommandType.StoredProcedure

            '        sqlComm.Parameters.AddWithValue("@KodeAset", dgKeranjangCetak.Rows(i).Cells(0).Value.ToString())
            '        Koneksi.Open()

            '        sqlComm.ExecuteNonQuery()

            '    Next
            'End Using
            'LoadGridView()

        End If

        Exit Sub





























    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        On Error GoTo ErrorLoad






        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0

        For Each drr As DataGridViewRow In DataGridView1.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To dgKeranjangCetak.RowCount - 1

                    If dgKeranjangCetak.Rows(barisatas).Cells(0).Value = DataGridView1.Rows(intBarisNow).Cells(0).Value Then
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
                dgKeranjangCetak.Rows.Add(row2)
                dgKeranjangCetak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgKeranjangCetak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                dgKeranjangCetak.AutoResizeColumns()
            End If

        Next
        Exit Sub
ErrorLoad:
        MsubPesanError()
        Exit Sub

    End Sub

    Private Sub txtCariAset_TextChanged(sender As Object, e As EventArgs) Handles txtCariAset.TextChanged

            LoadGridViewPencarian()

    End Sub

    Private Sub chkSudahDiCetak_CheckedChanged(sender As Object, e As EventArgs)

        'If chkSudahDiCetak.Checked = True Then
        '    LoadGridViewSudahDicetak()
        'Else
        '    LoadGridView()
        'End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Koneksi.Close()

        Koneksi = New SqlConnection(strKoneksi)

        For i As Integer = 0 To dgKeranjangCetak.Rows.Count - 1
                Using (Koneksi)

                Dim sqlComm As New SqlCommand

                sqlComm.Connection = Koneksi


                sqlComm.CommandText = "[AD_TempPrintLabelAset]"
                sqlComm.CommandType = CommandType.StoredProcedure

                sqlComm.Parameters.AddWithValue("KdAset", dgKeranjangCetak.Rows(i).Cells(1).Value)
                sqlComm.Parameters.AddWithValue("NamaAset", dgKeranjangCetak.Rows(i).Cells(2).Value)
                sqlComm.Parameters.AddWithValue("TanggalAset", dgKeranjangCetak.Rows(i).Cells(3).Value)
                sqlComm.Parameters.AddWithValue("JumlahCetak", dgKeranjangCetak.Rows(i).Cells(0).Value)
                sqlComm.Parameters.AddWithValue("IpComName", Trim(lblIP.Text))
                sqlComm.Parameters.AddWithValue("Status", "A")



                Koneksi.Open()
                sqlComm.ExecuteNonQuery()

            End Using

        Next
        Koneksi.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoadGridView()
    End Sub
End Class