Imports System.Data.SqlClient

Public Class frmExpensiveQuery


    Sub LoadTop50Query()


        KoneksiDatabase5()
        Dim cmd As New SqlCommand("SELECT qs.last_execution_time,qs.execution_count AS BanyakXEksekusi,qs.total_rows AS JumlahRecordTerproses,st.text AS Query " & _
                                " FROM (SELECT  TOP 50 * FROM sys.dm_exec_query_stats ORDER BY total_worker_time DESC) AS qs " & _
                                " CROSS APPLY sys.dm_exec_sql_text(qs.sql_handle) AS st " & _
                                " CROSS APPLY sys.dm_exec_query_plan(qs.plan_handle) AS qp " & _
                                " WHERE qs.max_worker_time > 300  OR qs.max_elapsed_time > 300 ", Koneksi5)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        adapter.Fill(table)

        dgTop50.DataSource = table
        'aturDGSAP()
        dgTop50.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgTop50.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgTop50.AutoResizeColumns()
        Koneksi5.Close()


    End Sub



    Private Sub frmExpensiveQuery_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTop50Query()
    End Sub

    Private Sub dgTop50_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTop50.CellContentClick

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        gbDetailQuery.Visible = False
    End Sub

    Private Sub cmdcopyclipboard_Click(sender As Object, e As EventArgs) Handles cmdcopyclipboard.Click
        Clipboard.SetText(txtDetailQuery.Text)
    End Sub

    Private Sub dgTop50_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTop50.CellContentDoubleClick
        gbDetailQuery.Visible = True
        txtDetailQuery.Text = dgTop50.Item(3, dgTop50.CurrentRow.Index).Value
    End Sub
End Class