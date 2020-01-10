Public Class FormKonfigurasiFormatLaporan
    Dim fileLocation As String
    Private Sub cmdTelusuri_Click(sender As Object, e As EventArgs) Handles cmdTelusuriDelivery.Click

        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtpathDelivery.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathDelivery.Click
        With My.Settings
            .DeliveryPath = Trim(txtpathDelivery.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With

    End Sub

    Private Sub FormKonfigurasiFormatLaporan_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtpathDelivery.Text = My.Settings.DeliveryPath
        txtpathGRPO.Text = My.Settings.GRPOPath
        txtPathInventoryRequest.Text = My.Settings.InventoryRequestPath
        txtPathInventoryTransfer.Text = My.Settings.InventoryTransferPath
        txtPathGoodsIssue.Text = My.Settings.GoodsIssuePath

    End Sub


    Private Sub cmdTelusuriGRPO_Click(sender As Object, e As EventArgs) Handles cmdTelusuriGRPO.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtpathGRPO.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanPathGRPO_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathGRPO.Click
        With My.Settings
            .GRPOPath = Trim(txtpathGRPO.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdSimpanPathInventoryRequest_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathInventoryRequest.Click
        With My.Settings
            .InventoryRequestPath = Trim(txtPathInventoryRequest.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdSimpanPathInventoryTransfer_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathInventoryTransfer.Click
        With My.Settings
            .InventoryTransferPath = Trim(txtPathInventoryTransfer.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdSimpanGoodsIssue_Click(sender As Object, e As EventArgs) Handles cmdSimpanGoodsIssue.Click
        With My.Settings
            .GoodsIssuePath = Trim(txtPathGoodsIssue.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub
End Class