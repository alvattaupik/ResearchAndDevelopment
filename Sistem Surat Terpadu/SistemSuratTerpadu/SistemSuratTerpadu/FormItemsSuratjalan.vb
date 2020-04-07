Imports System.Data.SqlClient
Public Class FormItemsSuratjalan



    Sub LoadDaftarItemMasterData()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("SELECT top 10 ItemCode AS Kode,ItemName AS Deskripsi,'' AS Keterangan FROM RKM_LIVE_2.dbo.OITM WHere ItemName Like'%" & Trim(txtCariItemMasterData.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarItem.DataSource = table
        dgDaftarItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarItem.AutoResizeColumns()

    End Sub



    Sub LoadDaftarItemLainnya()

        Call KoneksiDatabase2()

        Dim cmd As New SqlCommand("SELECT top 10 '' AS Kode,Dscription AS Deskripsi,'' AS Keterangan FROM RKM_LIVE_2.dbo.PCH1 WHERE ItemCode IS NULL AND Dscription IS NOT NULL and Dscription Like'%" & Trim(txtCariItemLain.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarItemLainnya.DataSource = table
        dgDaftarItemLainnya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarItemLainnya.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarItemLainnya.AutoResizeColumns()

    End Sub





    Private Sub FormItems_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarItemMasterData()
        LoadDaftarItemLainnya()
    End Sub

    Private Sub txtCariItemLain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariItemLain.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        'Call NumberOnly(tombol, e)

        If tombol = 13 Then
            LoadDaftarItemLainnya()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtCariItemMasterData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariItemMasterData.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        'Call NumberOnly(tombol, e)

        If tombol = 13 Then
            LoadDaftarItemMasterData()
        Else
            Exit Sub
        End If
    End Sub


    Private Sub dgDaftarItem_Click(sender As Object, e As EventArgs) Handles dgDaftarItem.Click

    End Sub

    Private Sub dgDaftarItem_DoubleClick(sender As Object, e As EventArgs) Handles dgDaftarItem.DoubleClick
        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0
        For Each drr As DataGridViewRow In dgDaftarItem.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To FormBuatSuratJalan.dgItem.RowCount - 1

                    If FormBuatSuratJalan.dgItem.Rows(barisatas).Cells(0).Value = dgDaftarItem.Rows(intBarisNow).Cells(0).Value Then
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
                FormBuatSuratJalan.dgItem.Rows.Add(row2)
                Me.Close()
            End If

        Next


    End Sub

    Private Sub dgDaftarItemLainnya_Click(sender As Object, e As EventArgs) Handles dgDaftarItemLainnya.Click

    End Sub


    Private Sub dgDaftarItemLainnya_DoubleClick(sender As Object, e As EventArgs) Handles dgDaftarItemLainnya.DoubleClick
        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0
        For Each drr As DataGridViewRow In dgDaftarItemLainnya.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To FormBuatSuratJalan.dgItem.RowCount - 1

                    If FormBuatSuratJalan.dgItem.Rows(barisatas).Cells(0).Value = dgDaftarItemLainnya.Rows(intBarisNow).Cells(0).Value Then
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
                FormBuatSuratJalan.dgItem.Rows.Add(row2)
                Me.Close()
            End If

        Next

  

    End Sub


End Class