Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormRKMDisplayTag
    Dim source1 As New BindingSource()


    Private Sub FormRKMDisplayTag_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub


    Private Sub FormRKMDisplayTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MstrNamaModul = "RKM Display Tag"
        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"
    End Sub

    Private Sub cmdShowPromo_Click(sender As Object, e As EventArgs) Handles cmdShowPromo.Click
        LoadPromo()
    End Sub



    Sub LoadPromo()
        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("_tmspRKMDisplayTagPromo", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PriceList", MstrHargaJual)
        command.Parameters.AddWithValue("@Brand", cmbBrandPromo.SelectedValue)

        Dim table As New DataTable
        adapter.Fill(table)

        Dim view1 As New DataView(table)
        source1.DataSource = view1
        dgDaftarBarang.DataSource = view1
        dgDaftarBarang.Refresh()
        dgDaftarBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgDaftarBarang.AutoResizeColumns()
        dgDaftarBarang.Columns(1).ReadOnly = True
        dgDaftarBarang.Columns(2).ReadOnly = True
        dgDaftarBarang.Columns(3).ReadOnly = True
        dgDaftarBarang.Columns(4).ReadOnly = True
        dgDaftarBarang.Columns(5).ReadOnly = True
        dgDaftarBarang.Columns(6).ReadOnly = True
        dgDaftarBarang.Columns(7).ReadOnly = True
        dgDaftarBarang.Columns(8).ReadOnly = True
        dgDaftarBarang.Columns(9).ReadOnly = True

        dgDaftarBarang.Columns(5).DefaultCellStyle.Format = "N0"
        dgDaftarBarang.Columns(6).DefaultCellStyle.Format = "N0"
        dgDaftarBarang.Columns(7).DefaultCellStyle.Format = "N0"

        dgDaftarBarang.RowHeadersVisible = False


        lblJumlahBarang.Text = "Jumlah Barang : " & dgDaftarBarang.RowCount




    End Sub

    Private Sub cmbBrandPromo_Click(sender As Object, e As EventArgs) Handles cmbBrandPromo.Click
        Call LoadComboBoxDBLive(cmbBrandPromo, "SELECT FirmCode,FirmName FROM dbo.OMRC", "FirmCode", "FirmName")
    End Sub

    Private Sub cmbBrandNormalPrice_Click(sender As Object, e As EventArgs) Handles cmbBrandNormalPrice.Click
        Call LoadComboBoxDBLive(cmbBrandPromo, "SELECT FirmCode,FirmName FROM dbo.OMRC", "FirmCode", "FirmName")
    End Sub

    Private Sub txtCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txtCariBarang.TextChanged
        source1.Filter = "NamaBarang like '%" & txtCariBarang.Text & "%' Or KodeBarang like '" & txtCariBarang.Text & "%'"
        dgDaftarBarang.Refresh()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click


        Dim dtReport As New DataTable
        With dtReport

            .Columns.Add("NamaBarang")
            .Columns.Add("KodeBarang")
            .Columns.Add("UOM")
            .Columns.Add("Brand")
            .Columns.Add("HargaJual")
            .Columns.Add("Discount")
            .Columns.Add("PriceAfterDisc")
            .Columns.Add("ValidFrom")
            .Columns.Add("ValidTo")
        End With




        For Each row As DataGridViewRow In dgDaftarBarang.Rows
            If (row.Cells(0).Value <> 0) Then
                Dim a As Integer
                For a = 1 To Convert.ToInt16(row.Cells(0).Value)
                    dtReport.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
                Next
            End If
        Next



        Dim RDS As New ReportDataSource("DataSet1", dtReport)

        Me.ReportViewer1.LocalReport.ReportPath = "Report\PromoA5.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(RDS)
        Me.ReportViewer1.RefreshReport()




        'Dim dsCustomers As New DataSet1
        'dsCustomers.Merge(dtReport)
        'Dim datasource As New ReportDataSource("Promo", dsCustomers.Tables(0))


        'ReportViewer1.LocalReport.DataSources.Item(0).Value = datasource
        



        'ReportViewer1.LocalReport.DataSources.Add()

        'ReportViewer1.LocalReport.ReportPath = "Report\PromoA5.rdlc"
        'ReportViewer1.RefreshReport()

    End Sub
End Class