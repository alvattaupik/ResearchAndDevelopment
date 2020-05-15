Imports System.Data.SqlClient
Public Class FormDataUserALL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Sub LoadDaftarUserSAP()

        Call KoneksiDatabase2()


        Dim cmd As New SqlCommand("Select * From V_ListMasterUser WHERE NamaUser Like '%" & Trim(txtCariUer.Text) & "%'", Koneksi2)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarUserSAp.DataSource = table
        dgDaftarUserSAp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarUserSAp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgDaftarUserSAp.AutoResizeColumns()

    End Sub


    Private Sub txtCariUer_TextChanged(sender As Object, e As EventArgs) Handles txtCariUer.TextChanged
        LoadDaftarUserSAP()
    End Sub


    Private Sub dgDaftarUserSAp_Click(sender As Object, e As EventArgs) Handles dgDaftarUserSAp.Click
        'If MstrNamaForm = "Cari kode User" Then
        '    FormDataUser.txtKodeUser.Text = dgDaftarUserSAp.Item(0, dgDaftarUserSAp.CurrentRow.Index).Value
        '    FormDataUser.txtNamaLengkap.Text = dgDaftarUserSAp.Item(1, dgDaftarUserSAp.CurrentRow.Index).Value
        '    Me.Close()
        'End If


        'If MstrNamaForm = "Cari kode SPV" Then
        '    FormDataUser.txtKodeSPV.Text = dgDaftarUserSAp.Item(0, dgDaftarUserSAp.CurrentRow.Index).Value
        '    FormDataUser.txtNamaSPV.Text = dgDaftarUserSAp.Item(1, dgDaftarUserSAp.CurrentRow.Index).Value
        '    Me.Close()
        'End If



        Dim JumlahDuplikat As Integer
        'For i As Integer = 0 To dgSumberAset.Rows.Count() - 1 Step +1
        Dim strIntBarisAtas As String
        Dim intBarisNow As Integer
        Dim BolDuplikat As Boolean

        JumlahDuplikat = 0
        For Each drr As DataGridViewRow In dgDaftarUserSAp.SelectedRows
            strIntBarisAtas = drr.Index.ToString
            intBarisNow = CInt(strIntBarisAtas)
            Dim row2 As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i2 As Int32 = 0 To drr.Cells.Count - 1
                row2.Cells(i2).Value = drr.Cells(i2).Value

                For barisatas As Integer = 0 To FormBuatSuratJalan.dgItem.RowCount - 1

                    If FormBuatSuratTugas.dgItem.Rows(barisatas).Cells(1).Value = dgDaftarUserSAp.Rows(intBarisNow).Cells(1).Value Then
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
                FormBuatSuratTugas.dgItem.Rows.Add(row2)
                FormBuatSuratTugas.dgItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                FormBuatSuratTugas.dgItem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                FormBuatSuratTugas.dgItem.AutoResizeColumns()

                Me.Close()
            End If

        Next



    End Sub

    Private Sub dgDaftarUserSAp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarUserSAp.CellContentClick

    End Sub
End Class