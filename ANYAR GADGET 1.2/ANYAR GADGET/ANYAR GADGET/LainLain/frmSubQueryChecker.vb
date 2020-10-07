Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSubQueryChecker


    Sub LoadDoubleFullfillments()
        Try
            Koneksi_IVEND()
            Dim command As SqlCommand
            command = New SqlCommand("tmspCekDoubleFullfillments", KoneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TransactionKey", trxTransactionKey.Text)
            command.Parameters.AddWithValue("@FullfillmentDetailKey", "-")
            command.Parameters.AddWithValue("@SourceDetailKey", "-")
            command.Parameters.AddWithValue("@ProductKey", "-")
            command.Parameters.AddWithValue("@Quantity", "-")
            command.Parameters.AddWithValue("@Function", "Cek Double Fullfillment")
            Dim table As New DataTable
            adapter.Fill(table)

            dgvFullfillmentDetailKey.DataSource = table
            dgvFullfillmentDetailKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvFullfillmentDetailKey.AutoResizeColumns()
            dgvFullfillmentDetailKey.RowHeadersVisible = False

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub







    Sub LoadDetailFullfillments()
        Try
            Koneksi_IVEND()
            Dim command As SqlCommand
            command = New SqlCommand("tmspCekDoubleFullfillments", KoneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TransactionKey", trxTransactionKey.Text)
            command.Parameters.AddWithValue("@FullfillmentDetailKey", "-")
            command.Parameters.AddWithValue("@SourceDetailKey", "-")
            command.Parameters.AddWithValue("@ProductKey", "-")
            command.Parameters.AddWithValue("@Quantity", "-")
            command.Parameters.AddWithValue("@Function", "Cek Detail Fullfillment")
            Dim table As New DataTable
            adapter.Fill(table)

            dgvDetails.DataSource = table
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvDetails.AutoResizeColumns()


            'dgvDetails.RowHeadersVisible = False




            'For x As Integer = 0 To dgvDetails.Rows.Count - 2
            '    Dim tempStr As String = dgvDetails.Rows(x).Cells("SourceDetailKey").Value.ToString
            '    'Take(10) in this case discards the newrow
            '    If dgvDetails.Rows.Cast(Of DataGridViewRow).Take(2).Count(Function(row) row.Cells("SourceDetailKey").Value.ToString = tempStr) > 1 Then
            '        dgvDetails.Rows(x).DefaultCellStyle.BackColor = Color.Red
            '    End If


            'Next


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub Warna()
        For i = 0 To dgvDetails.RowCount - 2
            For j = i + 1 To dgvDetails.RowCount - 1
                Dim row2 = dgvDetails.Rows(j)

                If Not row2.IsNewRow Then
                    Dim row1 = dgvDetails.Rows(i)

                    If row1.Cells("SourceDetailKey").Value.ToString() = row2.Cells("SourceDetailKey").Value.ToString() Then
                        row1.DefaultCellStyle.BackColor = Color.Red
                        row2.DefaultCellStyle.BackColor = Color.Red
                    End If
                End If
            Next
        Next
    End Sub


    Sub LoadRootCause()
        Try
            Koneksi_IVEND()
            Dim command As SqlCommand
            command = New SqlCommand("tmspCekDoubleFullfillments", KoneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TransactionKey", trxTransactionKey.Text)
            command.Parameters.AddWithValue("@FullfillmentDetailKey", "-")


            If dgvFullfillmentDetailKey.Rows.Count > 0 Then
                command.Parameters.AddWithValue("@SourceDetailKey", dgvFullfillmentDetailKey.Item(0, dgvFullfillmentDetailKey.CurrentRow.Index).Value)
            Else
                command.Parameters.AddWithValue("@SourceDetailKey", "")
            End If

            command.Parameters.AddWithValue("@ProductKey", "-")
            command.Parameters.AddWithValue("@Quantity", "-")
            command.Parameters.AddWithValue("@Function", "Cek Root Cause")
            Dim table As New DataTable
            adapter.Fill(table)

            dgvRootCause.DataSource = table
            dgvRootCause.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvRootCause.AutoResizeColumns()
            dgvRootCause.RowHeadersVisible = False

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub





    Private Sub frmSubQueryChecker_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDoubleFullfillments()
        LoadDetailFullfillments()

        Threading.Thread.Sleep(1000)

        LoadRootCause()
    End Sub


    Private Sub dgvRootCause_Click(sender As Object, e As EventArgs) Handles dgvRootCause.Click
        txtFullfillmentDetailkey.Text = dgvRootCause.Item(0, dgvRootCause.CurrentRow.Index).Value
        txtSourceDetailkey.Text = dgvRootCause.Item(1, dgvRootCause.CurrentRow.Index).Value
        txtProductKey.Text = dgvRootCause.Item(2, dgvRootCause.CurrentRow.Index).Value
        txtNamaBarang.Text = dgvRootCause.Item(4, dgvRootCause.CurrentRow.Index).Value
        txtQty.Text = dgvRootCause.Item(5, dgvRootCause.CurrentRow.Index).Value
    End Sub


    Private Sub btnRollbackQuery_Click(sender As Object, e As EventArgs) Handles btnRollbackQuery.Click

        Dim StRSQL As String = " BEGIN TRAN INSERT INTO dbo.TempTrxTransactionFulfillmentDetailBackup SELECT *,'Backup',GETDATE() FROM dbo.TrxTransactionFulfillmentDetail WHERE TransactionKey='" & Trim(trxTransactionKey.Text) & "' Delete TrxTransactionFulfillmentDetail Where FulfillmentDetailKey='" & Trim(txtFullfillmentDetailkey.Text) & "' AND SourceDetailKey='" & Trim(txtSourceDetailkey.Text) & "' AND ProductKey='" & Trim(txtProductKey.Text) & "' AND Quantity='" & Trim(txtQty.Text) & "' select * fROM TempTrxTransactionFulfillmentDetailBackup WHERE TransactionKey='" & Trim(trxTransactionKey.Text) & "' ROLLBACK"

        txtQuerybuilder.Text = StRSQL
    End Sub

    Private Sub btnFixQuery_Click(sender As Object, e As EventArgs) Handles btnFixQuery.Click
        Dim StRSQL As String = " BEGIN INSERT INTO dbo.TempTrxTransactionFulfillmentDetailBackup" & _
                                " SELECT *,'Backup',GETDATE() FROM dbo.TrxTransactionFulfillmentDetail WHERE TransactionKey='" & Trim(trxTransactionKey.Text) & "' Delete TrxTransactionFulfillmentDetail Where FulfillmentDetailKey='" & Trim(txtFullfillmentDetailkey.Text) & "' AND SourceDetailKey='" & Trim(txtSourceDetailkey.Text) & "' AND ProductKey='" & Trim(txtProductKey.Text) & "' AND Quantity='" & Trim(txtQty.Text) & "' END"

        txtQuerybuilder.Text = StRSQL
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        If MsgBox("Apakah Anda Yakin data yang akan di pilih sudah sesuai?", vbYesNo, "Konfirmasi") = vbYes Then

            Call FixError()

            LoadDoubleFullfillments()
            LoadDetailFullfillments()
            Threading.Thread.Sleep(1000)
            LoadRootCause()



        Else

            Exit Sub

        End If



    End Sub





    Sub FixError()
        Try
            Koneksi_IVEND()
            Dim command As SqlCommand
            command = New SqlCommand("tmspCekDoubleFullfillments", KoneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@TransactionKey", Trim(trxTransactionKey.Text))
            command.Parameters.AddWithValue("@FullfillmentDetailKey", Trim(txtFullfillmentDetailkey.Text))
            command.Parameters.AddWithValue("@SourceDetailKey", Trim(txtSourceDetailkey.Text))
            command.Parameters.AddWithValue("@ProductKey", Trim(txtProductKey.Text))
            command.Parameters.AddWithValue("@Quantity", Trim(txtQty.Text))
            command.Parameters.AddWithValue("@Function", "Fix Error")
            Dim table As New DataTable
            adapter.Fill(table)

            dgvFullfillmentDetailKey.DataSource = table
            dgvFullfillmentDetailKey.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvFullfillmentDetailKey.AutoResizeColumns()
            dgvFullfillmentDetailKey.RowHeadersVisible = False

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



End Class