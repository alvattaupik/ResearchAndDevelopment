Public Class frmTemplate

    Private Sub btnCariGoodsReceipt_Click(sender As Object, e As EventArgs) Handles btnCariGoodsReceipt.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiGoodsReceipt.Text = O.FileName
            End If
        End Using
    End Sub


    Private Sub btnCariIncomingPayment_Click(sender As Object, e As EventArgs) Handles btnCariIncomingPayment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiIncomingPayment.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnCariPickListForm_Click(sender As Object, e As EventArgs) Handles btnCariPickListForm.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiPickList.Text = O.FileName
            End If
        End Using
    End Sub



    Private Sub btnSimpanGoodsReceipt_Click(sender As Object, e As EventArgs) Handles btnSimpanGoodsReceipt.Click

        With My.Settings
            .P_GoodsReceipt = txtLokasiGoodsReceipt.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With


    End Sub

    Private Sub btnSimpanIncomingPayments_Click(sender As Object, e As EventArgs) Handles btnSimpanIncomingPayments.Click
        With My.Settings
            .P_IncomingPayment = txtLokasiIncomingPayment.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnSimpanPickListForm_Click(sender As Object, e As EventArgs) Handles btnSimpanPickListForm.Click
        With My.Settings
            .P_PickListForm = txtLokasiPickList.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnSimpanGoodsReturn_Click(sender As Object, e As EventArgs) Handles btnSimpanGoodsReturn.Click
        With My.Settings
            .P_GoodsReturn = txtLokasiGoodsReturn.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnSimpanReturn_Click(sender As Object, e As EventArgs) Handles btnSimpanReturn.Click
        With My.Settings
            .P_Return = txtLokasiReturn.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub


    Private Sub btnCariSalesOrder_Click(sender As Object, e As EventArgs) Handles btnCariSalesOrder.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiSalesOrder.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnCariGoodsReturn_Click(sender As Object, e As EventArgs) Handles btnCariGoodsReturn.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiGoodsReturn.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnCariReturn_Click(sender As Object, e As EventArgs) Handles btnCariReturn.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiReturn.Text = O.FileName
            End If
        End Using

    End Sub

    Private Sub btnSimpanSalesOrder_Click(sender As Object, e As EventArgs) Handles btnSimpanSalesOrder.Click
        With My.Settings
            .P_SalesOrder = txtLokasiSalesOrder.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnCariDelivery_Click(sender As Object, e As EventArgs) Handles btnCariDelivery.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiDelivery.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnSimpanDelivery_Click(sender As Object, e As EventArgs) Handles btnSimpanDelivery.Click
        With My.Settings
            .P_Delivery = txtLokasiDelivery.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub



    Private Sub btnCariGRPO_Click(sender As Object, e As EventArgs) Handles btnCariGRPO.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiGRPO.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnSimpanGRPO_Click(sender As Object, e As EventArgs) Handles btnSimpanGRPO.Click
        With My.Settings
            .P_GRPO = txtLokasiGRPO.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub


    Private Sub btnSimpanInventoryTransferRequest_Click(sender As Object, e As EventArgs) Handles btnSimpanInventoryTransferRequest.Click

        With My.Settings
            .P_InventoryTransferReq = txtlokasiInventoryTransferReq.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With

    End Sub

    Private Sub btnCariInventoryTransferRequest_Click(sender As Object, e As EventArgs) Handles btnCariInventoryTransferRequest.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtlokasiInventoryTransferReq.Text = O.FileName
            End If
        End Using
    End Sub



    Private Sub btnCariInventoryTransfer_Click(sender As Object, e As EventArgs) Handles btnCariInventoryTransfer.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiInventoryTransfer.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnSimpanInventoryTransfer_Click(sender As Object, e As EventArgs) Handles btnSimpanInventoryTransfer.Click
        With My.Settings
            .P_InventoryTransfer = txtLokasiInventoryTransfer.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnCariLokasiGoodsIssue_Click(sender As Object, e As EventArgs) Handles btnCariLokasiGoodsIssue.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiGoodsIssue.Text = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnCariOutgoingPayment_Click(sender As Object, e As EventArgs) Handles btnCariOutgoingPayment.Click
        Using O As New OpenFileDialog
            If O.ShowDialog = 1 Then
                txtLokasiOutgoingPayments.Text = O.FileName
            End If
        End Using


    End Sub

    Private Sub btnSimpanOutgoingPayment_Click(sender As Object, e As EventArgs) Handles btnSimpanOutgoingPayment.Click
        With My.Settings
            .P_OutgoingPayments = txtLokasiOutgoingPayments.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub

    Private Sub btnSimpanGoodsIssue_Click(sender As Object, e As EventArgs) Handles btnSimpanGoodsIssue.Click
        With My.Settings
            .P_GoodsIssue = txtLokasiGoodsIssue.Text
            .Save()
            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)
        End With
    End Sub





    Sub LoadTemplate()
        With My.Settings
            txtLokasiGoodsReceipt.Text = .P_GoodsReceipt
            txtLokasiIncomingPayment.Text = .P_IncomingPayment
            txtLokasiPickList.Text = .P_PickListForm
            txtLokasiGoodsReturn.Text = .P_GoodsReturn
            txtLokasiReturn.Text = .P_Return
            txtLokasiSalesOrder.Text = .P_SalesOrder
            txtLokasiDelivery.Text = .P_Delivery
            txtLokasiGRPO.Text = .P_GRPO
            txtlokasiInventoryTransferReq.Text = .P_InventoryTransferReq
            txtLokasiInventoryTransfer.Text = .P_InventoryTransfer
            txtLokasiGoodsIssue.Text = .P_GoodsIssue
            txtLokasiOutgoingPayments.Text = .P_OutgoingPayments
        End With
    End Sub


    Private Sub frmTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTemplate()
    End Sub

End Class