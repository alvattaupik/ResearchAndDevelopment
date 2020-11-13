Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMonitoringStokMemberdanVoucher
    Sub VM_Stock(strFunction As String, dgv As DataGridView)

        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("dbo.R_VMStock ", KoneksiDBEmail)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Function", Trim(strFunction))
            Dim table As New DataTable
            adapter.Fill(table)
            dgv.DataSource = table
            dgv.DataSource = table

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub frmMonitoringStokMemberdanVoucher_Load(sender As Object, e As EventArgs) Handles Me.Load
        VM_Stock("Stok Voucher", dgvStockVoucher)
        VM_Stock("Stok Member", dgvStokMember)
    End Sub

    Private Sub picLihatRincianMember_Click(sender As Object, e As EventArgs) Handles picLihatRincianMember.Click
        If dgvStokMember.RowCount = 0 Then Exit Sub
        Dim strQuery As String
        strQuery = "SELECT OVMCategories.Deskripsi,Qty,OINM.Deskripsi AS Catatan,Date,CreatedBy,Sequence FROM dbo.OINM " & _
                    " LEFT OUTER JOIN dbo.OVMCategories ON dbo.OVMCategories.ID=dbo.OINM.Transtype " & _
                    " WHERE dbo.OINM.ItemCode='" & dgvStokMember.Item(0, dgvStokMember.CurrentRow.Index).Value() & "' Order By OINM.Sequence"
        Call Koneksi_SAP()
        LoadDataGrid(dgvTransaksiMemberCard, strQuery, KoneksiDBEmail)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If dgvStockVoucher.RowCount = 0 Then Exit Sub

        Dim strQuery As String
        strQuery = "SELECT OVMCategories.Deskripsi,Qty,OINM.Deskripsi AS Catatan,Date,CreatedBy,Sequence FROM dbo.OINM" & _
                    " LEFT OUTER JOIN dbo.OVMCategories ON dbo.OVMCategories.ID=dbo.OINM.Transtype" & _
                    " WHERE dbo.OINM.ItemCode='" & dgvStockVoucher.Item(0, dgvStockVoucher.CurrentRow.Index).Value() & "' Order By OINM.Sequence"
        Call Koneksi_SAP()
        LoadDataGrid(dgvRincianTransaksiVoucher, strQuery, KoneksiDBEmail)
    End Sub

    Private Sub CopyStokMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyStokMemberToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvStokMember)
    End Sub

    Private Sub CopyRincianTransaksiStokMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRincianTransaksiStokMemberToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvTransaksiMemberCard)
    End Sub

    Private Sub CopyStokVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyStokVoucherToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvStockVoucher)
    End Sub

    Private Sub CopyRincianTansaksiStokVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyRincianTansaksiStokVoucherToolStripMenuItem.Click
        CopyDataGridViewToClipboard(dgvRincianTransaksiVoucher)
    End Sub
End Class