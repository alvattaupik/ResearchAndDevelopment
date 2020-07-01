Imports System.Data.SqlClient
Imports System.Net.Dns
Imports System.ComponentModel

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        On Error Resume Next

        If rbTampilSemua.Checked = False And rbTertentu.Checked = False Then
            MsgBox("Tentukan Item Yang Akan Ditampilkan", vbInformation, "Pilih Filter")
            Exit Sub
        End If


        If rbTampilSemua.Checked = True Then
            If MsgBox("Menampilkan Semua Data akan membutuhkan banyak waktu" & vbNewLine & "Tetap lanjutkan?", vbYesNo) = vbYes Then
                ListView1.Items.Clear()

                Dim sqlQuery As String = ("SELECT Keterangan,ItemCode,ItemName,HargaJual " _
                & " FROM DB_EMAIL.dbo.V_HargaJualRKM " _
                & " Where PriceList='" & cmbHargaJual.SelectedValue & "' Order By ItemName")
                Dim sqlAdapter As New SqlDataAdapter
                Dim sqlCommand As New SqlCommand
                Dim TABLE As New DataTable
                Dim i As Integer
                With sqlCommand
                    .CommandText = sqlQuery
                    .Connection = Koneksi
                End With
                With sqlAdapter
                    .SelectCommand = sqlCommand
                    .Fill(TABLE)

                End With

                For i = 0 To TABLE.Rows.Count - 1

                    With ListView1
                        .BeginUpdate()
                        .Items.Add(TABLE.Rows(i)("Keterangan"))

                        With .Items(.Items.Count - 1).SubItems
                            .Add(TABLE.Rows(i)("ItemCode"))
                            .Add(TABLE.Rows(i)("ItemName"))
                            .Add(TABLE.Rows(i)("HargaJual"))
                        End With
                        .EndUpdate()

                    End With


                Next

            End If
        Else


            ListView1.Items.Clear()

            Dim sqlQuery As String = ("SELECT Keterangan,ItemCode,ItemName,HargaJual " _
            & " FROM DB_EMAIL.dbo.V_HargaJualRKM " _
            & " Where ItemCode Between '" & Trim(txtKodeBarang1.Text) & "' AND '" & Trim(txtKodeBarang2.Text) & "' AND PriceList='" & cmbHargaJual.SelectedValue & "'")
            Dim sqlAdapter As New SqlDataAdapter
            Dim sqlCommand As New SqlCommand
            Dim TABLE As New DataTable
            Dim i As Integer
            With sqlCommand
                .CommandText = sqlQuery
                .Connection = Koneksi
            End With
            With sqlAdapter
                .SelectCommand = sqlCommand
                .Fill(TABLE)
            End With


            For i = 0 To TABLE.Rows.Count - 1

                With ListView1
                    .Items.Add(TABLE.Rows(i)("Keterangan"))

                    With .Items(.Items.Count - 1).SubItems
                        .Add(TABLE.Rows(i)("ItemCode"))
                        .Add(TABLE.Rows(i)("ItemName"))
                        .Add(TABLE.Rows(i)("HargaJual"))
                    End With

                End With


            Next

        End If





    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error GoTo ErrorHandler


        Call LoadComboBox()


        lbNamaComputer.Text = Environment.MachineName()

        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        lbIPComputer.Text = h.AddressList.GetValue(0).ToString



        If Err.Description = "" Then Exit Sub

ErrorHandler:
        Call MsubPesanError()
        Exit Sub
    End Sub




    Private Sub LoadComboBox()
        ' siapkan koneksi database
        KoneksiDatabase()
        ' siapkan data adapter untuk data retrieval
        'Dim da As New SqlDataAdapter("Select pricelist, [Nama Toko] From V_PriceListPerCabang", conn)
        Dim da As New SqlDataAdapter("SELECT ListNum,ListName FROM RKM_LIVE_2.DBO.OPLN WHERE ListName LIKE '%Harga Jual%'", Koneksi)
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

    Private Sub cmbHargaJual_Click(sender As Object, e As EventArgs) Handles cmbHargaJual.Click

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
            Dim k As ListView.ColumnHeaderCollection = ListView1.Columns
            For Each x As ListViewItem In ListView1.Items
                Dim StrLn As String = ""
                For i = 1 To x.SubItems.Count - 1
                    StrLn += x.SubItems(i).Text + vbTab
                Next
                Write.WriteLine(StrLn)
            Next
            Write.Close() 'Or  Write.Flush()
        End If

        Exit Sub
    End Sub

    Private Sub rbTertentu_CheckedChanged(sender As Object, e As EventArgs) Handles rbTertentu.CheckedChanged
        If rbTertentu.Checked = True Then
            fraFilter.Visible = True
        Else
            fraFilter.Visible = False
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
        'Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        'Application.DoEvents()
        'Try

        '    Dim i As Integer = 0
        '    Do Until i = 150
        '        System.Threading.Thread.Sleep(100)
        '        i += 1
        '        Label4.Text = "Proses Belakang " & i
        '    Loop
        'Catch ex As Exception
        '    MsgBox(Err.Description)
        'End Try
    End Sub

    Private Sub rbTampilSemua_CheckedChanged(sender As Object, e As EventArgs) Handles rbTampilSemua.CheckedChanged

    End Sub
End Class


