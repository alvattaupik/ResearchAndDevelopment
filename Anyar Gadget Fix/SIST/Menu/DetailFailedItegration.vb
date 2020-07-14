Imports System.Data.SqlClient

Public Class DetailFailedItegration




    Sub LoadDaftarItemGagalIntegrasi()
        Call KoneksiDatabaseIvend()
        Dim cmd As New SqlCommand("SELECT ProductKey AS KodeBarang,Description,QTY,Total FROM dbo.V_ListItemErrorIntegrasi WHERE NoStruk='" & MstrNoStruk & "'", KoneksiIvend)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        dgListItemFail.DataSource = table
        dgListItemFail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgListItemFail.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgListItemFail.AutoResizeColumns()
        dgListItemFail.RowHeadersVisible = False
    End Sub


    Private Sub DetailFailedItegration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Target As String = ""

        If Microsoft.VisualBasic.Left(txtNotifError.Text, 12) = "Error(DL001)" Then

            Target = "Alamat Fullfill Tidak Sama dengan Alamat Customer!"
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font(txtNotifError.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Alamat Fullfill Tidak Sama dengan Alamat Customer!"
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font("Times New Roman", 14)
            txtNotifError.SelectionColor = Color.Blue

            txtNotifError.SelectionStart = 0
            txtNotifError.SelectionLength = 0

        End If



        If Microsoft.VisualBasic.Left(txtNotifError.Text, 12) = "Error(CUS001)" Then

            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font(txtNotifError.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font("Times New Roman", 14)
            txtNotifError.SelectionColor = Color.Blue

            txtNotifError.SelectionStart = 0
            txtNotifError.SelectionLength = 0
        End If


        If Microsoft.VisualBasic.Left(txtNotifError.Text, 12) = "Error(IV001)" Then

            Target = "Kesalahan Pada Query, Hubungi Vendor !!!"
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font(txtNotifError.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Kesalahan Pada Query, Hubungi Vendor !!!"
            txtNotifError.SelectionStart = txtNotifError.Text.IndexOf(Target)
            txtNotifError.SelectionLength = Target.Length
            txtNotifError.SelectionFont = New Font("Times New Roman", 14)
            txtNotifError.SelectionColor = Color.Red

            txtNotifError.SelectionStart = 0
            txtNotifError.SelectionLength = 0
        End If


        LoadDaftarItemGagalIntegrasi()
        hitung()

    End Sub



    Sub hitung()
        Dim LongTotal As Long
        Dim intJumlahItem As Integer
        Dim i As Integer

        For i = 0 To dgListItemFail.RowCount - 1
            dgListItemFail.Rows(i).Cells(3).Value = dgListItemFail.Rows(i).Cells(3).Value 'total jual
            LongTotal = LongTotal + (dgListItemFail.Rows(i).Cells(3).Value)

            dgListItemFail.Rows(i).Cells(2).Value = dgListItemFail.Rows(i).Cells(2).Value 'total jual
            intJumlahItem = intJumlahItem + (dgListItemFail.Rows(i).Cells(2).Value)

        Next


        txtTotal.Text = Format(LongTotal, "N0")
        lblJumlahItem.Text = "Jumlah Qty : " & Format(intJumlahItem, "N0")

    End Sub

    Private Sub cmdSolusi_Click(sender As Object, e As EventArgs) Handles cmdSolusi.Click
        FormDaftarSolusi.ShowDialog()
    End Sub
End Class