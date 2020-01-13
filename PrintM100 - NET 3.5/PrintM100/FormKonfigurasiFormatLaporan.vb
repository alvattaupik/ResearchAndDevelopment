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
        txtPathOutgoingPayments.Text = My.Settings.OutgoingPaymentsPath
        txtPathIncomingPayments.Text = My.Settings.IncomingPaymentsPath
        txtPathGoodsReceipt.Text = My.Settings.GoodsReceiptPath
        txtPathPickList.Text = My.Settings.PickListPath

        txtPathReturn.Text = My.Settings.ReturnPath
        txtPathSalesOrder.Text = My.Settings.SalesOrderPath
        txtPathGoodsReturn.Text = My.Settings.GoodsReturnPath



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

    Private Sub cmdTelusuriPathOutgoingPayments_Click(sender As Object, e As EventArgs) Handles cmdTelusuriPathOutgoingPayments.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathOutgoingPayments.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanPathOutgoingpayments_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathOutgoingpayments.Click
        With My.Settings
            .OutgoingPaymentsPath = Trim(txtPathOutgoingPayments.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdTelusuriInventoryTransfer_Click(sender As Object, e As EventArgs) Handles cmdTelusuriInventoryTransfer.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathInventoryTransfer.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdTelusuriInventoryRequest_Click(sender As Object, e As EventArgs) Handles cmdTelusuriInventoryRequest.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathInventoryRequest.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdTelusuriGoodsIssue_Click(sender As Object, e As EventArgs) Handles cmdTelusuriGoodsIssue.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathGoodsIssue.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdBrowseGoodsReceipt_Click(sender As Object, e As EventArgs) Handles cmdBrowseGoodsReceipt.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathGoodsReceipt.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanGoodsReceipt_Click(sender As Object, e As EventArgs) Handles cmdSimpanGoodsReceipt.Click
        With My.Settings
            .GoodsReceiptPath = Trim(txtPathGoodsReceipt.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdBrowsePickList_Click(sender As Object, e As EventArgs) Handles cmdBrowsePickList.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathPickList.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanPathPickList_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathPickList.Click
        With My.Settings
            .PickListPath = Trim(txtPathPickList.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdBrowsePathIncomingPayment_Click(sender As Object, e As EventArgs) Handles cmdBrowsePathIncomingPayment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathIncomingPayments.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanIncomingPayment_Click(sender As Object, e As EventArgs) Handles cmdSimpanIncomingPayment.Click
        With My.Settings
            .IncomingPaymentsPath = Trim(txtPathIncomingPayments.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdTelusuriPathReturn_Click(sender As Object, e As EventArgs) Handles cmdTelusuriPathReturn.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathReturn.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanPathReturn_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathReturn.Click
        With My.Settings
            .ReturnPath = Trim(txtPathReturn.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdTelusuriPathSO_Click(sender As Object, e As EventArgs) Handles cmdTelusuriPathSO.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathSalesOrder.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanPathSO_Click(sender As Object, e As EventArgs) Handles cmdSimpanPathSO.Click
        With My.Settings
            .SalesOrderPath = Trim(txtPathSalesOrder.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub

    Private Sub cmdBrowseGoodsReturn_Click(sender As Object, e As EventArgs) Handles cmdBrowseGoodsReturn.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtPathGoodsReturn.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub cmdSimpanGoodsReturn_Click(sender As Object, e As EventArgs) Handles cmdSimpanGoodsReturn.Click
        With My.Settings
            .GoodsReturnPath = Trim(txtPathGoodsReturn.Text)
            MsgBox("Pengaturan Berhasil Disimpan", vbInformation, "Sukses")
            .Save()
        End With
    End Sub
End Class