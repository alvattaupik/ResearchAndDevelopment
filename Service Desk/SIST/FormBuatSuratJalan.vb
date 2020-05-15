Public Class FormBuatSuratJalan
    Public selRow As New DataGridViewRow

    Private Sub cmbBuatBaru_Click(sender As Object, e As EventArgs) Handles cmbBuatBaru.Click
        ClearTextBoxes(Me)
    End Sub

    Private Sub cmdCariPenerima_Click(sender As Object, e As EventArgs) Handles cmdCariPenerima.Click


    End Sub

    Private Sub cmdTambah_Click(sender As Object, e As EventArgs) Handles cmdTambah.Click
        dgItem.Rows.Add("", "", "", "")
    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        Dim row As Integer
        Dim index As Integer


        If dgItem.RowCount = 0 Then Exit Sub

        index = dgItem.SelectedRows.Item(0).Index
        selRow = dgItem.Rows.Item(index)
        dgItem.Rows.Remove(selRow)
        row = row - 1
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        FormItemsSuratjalan.ShowDialog()
    End Sub

    Private Sub FormBuatSuratJalan_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaForm = "Surat Jalan"
    End Sub

    Sub LoadPenerima()
        txtPenerima.Text = MstrPenerima
        txtNoTelpPenerima.Text = Mstrtelepon
        txtAlamatPenerima.Text = MstrAlamat
    End Sub

End Class