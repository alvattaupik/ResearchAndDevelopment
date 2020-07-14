Imports System.Data.SqlClient
Public Class FormAvailableToPromise

    Sub LoadAvailableToPromise()
        dgATP.DataSource = Nothing
        dgATP.Rows.Clear()
        dgATP.Columns.Clear()

        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspATP", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@KodeBarang", txtItemCode.Text)

        Dim table As New DataTable
        adapter.Fill(table)


        dgATP.Columns.Add("Document", "Document")
        dgATP.Columns.Add("CardName", "CardName")
        dgATP.Columns.Add("OrderDate", "OrderDate")
        dgATP.Columns.Add("DeliveryDate", "DeliveryDate")
        dgATP.Columns.Add("Ordered", "Ordered")
        dgATP.Columns.Add("Commited", "Commited")
        dgATP.Columns.Add("Total", "Available")
        dgATP.Columns.Add("WhsName", "Warehouse")

        dgATP.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable



        dgATP.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dgATP.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        dgATP.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        With table
            For i = 0 To table.Rows.Count - 1
                dgATP.Rows.Add(.Rows(i).Item(1).ToString(), .Rows(i).Item(3).ToString(), .Rows(i).Item(4).ToString(), .Rows(i).Item(5).ToString(), .Rows(i).Item(6).ToString(), .Rows(i).Item(7).ToString(), .Rows(i).Item(9).ToString(), .Rows(i).Item(10).ToString())
            Next

            dgATP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            dgATP.AutoResizeColumns()


        End With



    End Sub



    Private Sub FormAvailableToPromise_Load(sender As Object, e As EventArgs) Handles Me.Load
        MstrNamaModul = "AG- Available To Promise"
        LoadAvailableToPromise()
        HitungOrder()
        HitungCommited()
    End Sub


    Sub HitungOrder()
        Try
            If dgATP.RowCount > 1 Then
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgATP.RowCount - 1
                    iTotal += Convert.ToInt32(dgATP.Rows(index).Cells(4).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                lblTotalOrdered.Text = "Total Ordered : " & iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub HitungCommited()
        Try
            If dgATP.RowCount > 1 Then
                Dim iTotal As Integer = 0

                'if you have the other column to get the result you  could add a new one like these above 
                For index As Integer = 0 To dgATP.RowCount - 1
                    iTotal += Convert.ToInt32(dgATP.Rows(index).Cells(5).Value)
                    'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
                Next

                lblTotalCommited.Text = "Total Commited : " & iTotal
                'if you have the other column to get the result you  could add a new one like these above 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub








    Private Sub dgATP_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgATP.CellFormatting
        If e.ColumnIndex = 4 Then
            If e.Value.ToString = "0" Then
                e.Value = ""
                e.FormattingApplied = True
            End If
        End If

        If e.ColumnIndex = 5 Then
            If e.Value.ToString = "0" Then
                e.Value = ""
                e.FormattingApplied = True
            End If
        End If

    End Sub



    Sub DisabledHeader()
        dgATP.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        dgATP.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

 

    Private Sub FormAvailableToPromise_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub
End Class