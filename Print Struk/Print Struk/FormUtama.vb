Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormUtama
    Dim tblImportSales As DataTable
    Dim tblImportPayment As DataTable
    Dim tblImportSales2 As DataTable


    Dim tblJoin As DataTable
    Dim strConn As String = "server=localhost; database=namadatabasemu; uid=root; password=;"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        With OpenFileDialog1
            .FileName = String.Empty
            .InitialDirectory = "C:\"
            .Title = "Pilih File Excel"
            .Filter = "Excel|*.xls;*.xlsx"
        End With

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                txtLokasiFile.Text = OpenFileDialog1.FileName
                'AmbilNamaSheet(txtLokasiFile.Text)

            Catch ex As Exception
                MsgBox("Error : " & ex.Message)
            End Try
        End If
    End Sub



    Public Sub IsiKeDataSheet(ByVal FileName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dtSales As DataSet


        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter


        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"


        exConn = New System.Data.OleDb.OleDbConnection(sConn)


        cmd = New System.Data.OleDb.OleDbDataAdapter("select  Sales.[Transaction No],Cus.Cashier,Cus.[Sales Organization],Cus.[Last Update],Cus.[Payment Group],Cus.[Payment Type],Cus.[Approval No],Cus.[EDC],Sales.[Product Code],Sales.[Product Name],Sales.Qty,Sales.UOM,Sales.Price,Sales.Total,Cus.Amount,Cus.Charges,Cus.[Total Amount],Cus.[Customer Name],Cus.[Addr1],Cus.[Total Amount] " & _
                                                    " FROM [" & "Sales$" & "] As Sales Left Outer Join [" & "Customer$" & "] AS Cus On Cus.[Payment No]=Sales.[Transaction No] Where Sales.[Transaction No]<>'' ", exConn)




        dtSales = New System.Data.DataSet
        cmd.Fill(dtSales)
        tblImportSales = dtSales.Tables(0)
        dgData.DataSource = tblImportSales

        exConn.Close()

    End Sub



    Public Sub LoadCashInvoice(ByVal FileName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dtSales As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"


        exConn = New System.Data.OleDb.OleDbConnection(sConn)


        cmd = New System.Data.OleDb.OleDbDataAdapter("select  Sales.[Transaction No],Cus.Cashier,Cus.[Sales Organization],Cus.[Last Update],Cus.[Payment Group],Cus.[Payment Type],Cus.[EDC],Sales.[Product Code],Sales.[Product Name],Sales.Qty,Sales.UOM,Sales.Price,Sales.Total,Cus.Amount,Cus.Charges,Cus.[Total Amount],Cus.[Customer Name],Cus.[Addr1],Cus.[Telp],Cus.[Account Name],Cus.[Account No],Cus.[Approval No] " & _
                                    " FROM [" & "Sales$" & "] As Sales Left Outer Join [" & "Customer$" & "] AS Cus On Cus.[Payment No]=Sales.[Transaction No] Where Sales.[Transaction No]<>'' AND Cus.[Payment Group]='CASH' AND Sales.[Transaction No] Not Like '%SO%'", exConn)

        dtSales = New System.Data.DataSet
        cmd.Fill(dtSales)
        tblImportSales = dtSales.Tables(0)
        dgData.DataSource = tblImportSales

        exConn.Close()

    End Sub




    Public Sub LoadCashANDReserveInvoice(ByVal FileName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dtSales As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"


        exConn = New System.Data.OleDb.OleDbConnection(sConn)


        cmd = New System.Data.OleDb.OleDbDataAdapter("select  Sales.[Transaction No],Cus.Cashier,Cus.[Sales Organization],Cus.[Last Update],Cus.[Payment Group],Cus.[Payment Type],Cus.[EDC],Sales.[Product Code],Sales.[Product Name],Sales.Qty,Sales.UOM,Sales.Price,Sales.Total,Cus.Amount,Cus.Charges,Cus.[Total Amount],Cus.[Customer Name],Cus.[Addr1],Cus.[Telp],Cus.[Account Name],Cus.[Account No],Cus.[Approval No] " & _
                            " FROM [" & "Sales$" & "] As Sales Left Outer Join [" & "Customer$" & "] AS Cus On Cus.[Payment No]=Sales.[Transaction No] Where Sales.[Transaction No]<>'' AND Cus.[Payment Group]='CASH' AND Sales.[Transaction No] Like '%SO%'", exConn)

        dtSales = New System.Data.DataSet
        cmd.Fill(dtSales)
        tblImportSales = dtSales.Tables(0)
        dgData.DataSource = tblImportSales

        exConn.Close()

    End Sub



    Public Sub LoadNonCashInvoice(ByVal FileName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dtSales As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"


        exConn = New System.Data.OleDb.OleDbConnection(sConn)


        cmd = New System.Data.OleDb.OleDbDataAdapter("select  Sales.[Transaction No],Cus.Cashier,Cus.[Sales Organization],Cus.[Last Update],Cus.[Payment Group],Cus.[Payment Type],Cus.[EDC],Sales.[Product Code],Sales.[Product Name],Sales.Qty,Sales.UOM,Sales.Price,Sales.Total,Cus.Amount,Cus.Charges,Cus.[Total Amount],Cus.[Addr1],Cus.[Customer Name],Cus.[Telp],Cus.[Account Name],Cus.[Account No],Cus.[Approval No] " & _
                            " FROM [" & "Sales$" & "] As Sales Left Outer Join [" & "Customer$" & "] AS Cus On Cus.[Payment No]=Sales.[Transaction No] Where Sales.[Transaction No]<>'' AND Cus.[Payment Group]<>'CASH' AND Sales.[Transaction No] Not Like '%SO%'", exConn)

        dtSales = New System.Data.DataSet
        cmd.Fill(dtSales)
        tblImportSales = dtSales.Tables(0)
        dgData.DataSource = tblImportSales

        exConn.Close()

    End Sub



    Public Sub LoadNonCashAndReserveInvoice(ByVal FileName As String)
        Dim exConn As OleDbConnection 'MySqlConnection
        Dim dtSales As DataSet
        Dim cmd As OleDbDataAdapter 'MySqlDataAdapter
        Dim sConn As String
        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"


        exConn = New System.Data.OleDb.OleDbConnection(sConn)


        cmd = New System.Data.OleDb.OleDbDataAdapter("select  Sales.[Transaction No],Cus.Cashier,Cus.[Sales Organization],Cus.[Last Update],Cus.[Payment Group],Cus.[Payment Type],Cus.[EDC],Sales.[Product Code],Sales.[Product Name],Sales.Qty,Sales.UOM,Sales.Price,Sales.Total,Cus.Amount,Cus.Charges,Cus.[Total Amount],Cus.[Addr1],Cus.[Customer Name],Cus.[Telp],Cus.[Account Name],Cus.[Account No],Cus.[Approval No] " & _
                    " FROM [" & "Sales$" & "] As Sales Left Outer Join [" & "Customer$" & "] AS Cus On Cus.[Payment No]=Sales.[Transaction No] Where Sales.[Transaction No]<>'' AND Cus.[Payment Group]<>'CASH' AND Sales.[Transaction No]  Like '%SO%'", exConn)


        dtSales = New System.Data.DataSet
        cmd.Fill(dtSales)
        tblImportSales = dtSales.Tables(0)
        dgData.DataSource = tblImportSales

        exConn.Close()

    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        If txtLokasiFile.Text = "" Then
            MsgBox("Tidak Ada File Yang Dipilih!")
            Exit Sub
        Else
            IsiKeDataSheet(txtLokasiFile.Text)
        End If

    End Sub

    Private Sub cmdCetak_Click(sender As Object, e As EventArgs) Handles cmdCetak.Click

        If cmbFormatCetak.Text = "" Then
            MsgBox("Pilih Format Cetak")
            Exit Sub
        End If

        If cmbJenisStruk.Text = "" Then
            MsgBox("Pilih Jenis Struk")
            Exit Sub
        End If


        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptDoc2 As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptDoc3 As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptDoc4 As CrystalDecisions.CrystalReports.Engine.ReportDocument


        rptDoc = New crCashAndCarry
        rptDoc2 = New crCashAndSO
        rptDoc3 = New crNonCashAndCarry
        rptDoc4 = New crNonCashAndSO



        If cmbJenisStruk.Text = "CASH Invoice" Then
            Call LoadCashInvoice(Trim(txtLokasiFile.Text))
            Dim dt As New DataTable
            With dt
                .Columns.Add("Transaction No")
                .Columns.Add("Cashier")
                .Columns.Add("Sales Organization")
                .Columns.Add("Last Update")
                .Columns.Add("Payment Group")
                .Columns.Add("Payment Type")
                .Columns.Add("Product Code")
                .Columns.Add("Product Name")
                .Columns.Add("Qty", GetType(Single))
                .Columns.Add("UOM")
                .Columns.Add("Price", GetType(Single))
                .Columns.Add("Total", GetType(Single))
                .Columns.Add("Amount", GetType(Single))
                .Columns.Add("Charges", GetType(Single))
                .Columns.Add("Total Amount", GetType(Single))
                .Columns.Add("Customer Name")
                .Columns.Add("addr1")
                .Columns.Add("telp")
                .Columns.Add("Account Name")
                .Columns.Add("Account No")
                .Columns.Add("Approval No")

            End With

            For Each dr As DataGridViewRow In Me.dgData.Rows
                dt.Rows.Add(dr.Cells("Transaction No").Value, dr.Cells("Cashier").Value, dr.Cells("Sales Organization").Value, dr.Cells("Last Update").Value, dr.Cells("Payment Group").Value, dr.Cells("Payment Type").Value, dr.Cells("Product Code").Value, dr.Cells("Product Name").Value, dr.Cells("Qty").Value, dr.Cells("UOM").Value, dr.Cells("Price").Value, dr.Cells("Total").Value, dr.Cells("Amount").Value, dr.Cells("Charges").Value, dr.Cells("Total Amount").Value, dr.Cells("Customer Name").Value, dr.Cells("addr1").Value, dr.Cells("telp").Value, dr.Cells("Account Name").Value, dr.Cells("Account No").Value, dr.Cells("Approval No").Value)
            Next


            If cmbFormatCetak.Text = "ABM" Then
                rptDoc.SetDataSource(dt)
                rptDoc.SetParameterValue("NamaToko", "ABM")
                rptDoc.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.341 - BANDUNG")
                rptDoc.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc.SetParameterValue("Telepon", "TELP : 022-7271511")
                FormCetakCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc
                FormCetakCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "AYANI" Then
                rptDoc.SetDataSource(dt)

                rptDoc.SetParameterValue("NamaToko", "RKM AYANI")
                rptDoc.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.323 - BANDUNG")
                rptDoc.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc.SetParameterValue("Telepon", "TELP : 022-7277108")
                FormCetakCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc
                FormCetakCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "CIBABAT" Then
                rptDoc.SetDataSource(dt)
                rptDoc.SetParameterValue("NamaToko", "RKM CIBABAT")
                rptDoc.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc.SetParameterValue("AlamatToko", "JL. RAYA CIBABAT NO.306 RT.003/015 CIBABAT")
                rptDoc.SetParameterValue("NPWP", "NPWP : 02.567.546.3-445.001")
                rptDoc.SetParameterValue("Telepon", "TELP : 022-6650881")
                FormCetakCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc
                FormCetakCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "CIBIRU" Then
                rptDoc.SetDataSource(dt)
                rptDoc.SetParameterValue("NamaToko", "RKM CIBIRU")
                rptDoc.SetParameterValue("NamaPerusahaan", "PT. KENCANA SATRIA SEJATI MANDIRI")
                rptDoc.SetParameterValue("AlamatToko", "JL. RAYA CIBIRU NO. 402 - KAB.BANDUNG")
                rptDoc.SetParameterValue("NPWP", "NPWP : 31.313.536.0.444.000")
                rptDoc.SetParameterValue("Telepon", "TELP : 022-7811074")
                FormCetakCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc
                FormCetakCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "KOPO" Then
                rptDoc.SetDataSource(dt)
                rptDoc.SetParameterValue("NamaToko", "RKM KOPO")
                rptDoc.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc.SetParameterValue("AlamatToko", "JL. KOPO BIHBUL NO.1 - KAB.BANDUNG")
                rptDoc.SetParameterValue("NPWP", "NPWP : 02.567.546.3.445.001")
                rptDoc.SetParameterValue("Telepon", "TELP : 022-54266583")
                FormCetakCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc
                FormCetakCashAndCarry.Show()
            End If


        ElseIf cmbJenisStruk.Text = "CASH Reserve Invoice" Then
            Call LoadCashANDReserveInvoice(txtLokasiFile.Text)

            Dim dt As New DataTable
            With dt
                .Columns.Add("Transaction No")
                .Columns.Add("Cashier")
                .Columns.Add("Sales Organization")
                .Columns.Add("Last Update")
                .Columns.Add("Payment Group")
                .Columns.Add("Payment Type")
                .Columns.Add("Product Code")
                .Columns.Add("Product Name")
                .Columns.Add("Qty", GetType(Single))
                .Columns.Add("UOM")
                .Columns.Add("Price", GetType(Single))
                .Columns.Add("Total", GetType(Single))
                .Columns.Add("Amount", GetType(Single))
                .Columns.Add("Charges", GetType(Single))
                .Columns.Add("Total Amount", GetType(Single))
                .Columns.Add("Customer Name")
                .Columns.Add("addr1")
                .Columns.Add("telp")
                .Columns.Add("Account Name")
                .Columns.Add("Account No")
                .Columns.Add("Approval No")

            End With

            For Each dr As DataGridViewRow In Me.dgData.Rows
                dt.Rows.Add(dr.Cells("Transaction No").Value, dr.Cells("Cashier").Value, dr.Cells("Sales Organization").Value, dr.Cells("Last Update").Value, dr.Cells("Payment Group").Value, dr.Cells("Payment Type").Value, dr.Cells("Product Code").Value, dr.Cells("Product Name").Value, dr.Cells("Qty").Value, dr.Cells("UOM").Value, dr.Cells("Price").Value, dr.Cells("Total").Value, dr.Cells("Amount").Value, dr.Cells("Charges").Value, dr.Cells("Total Amount").Value, dr.Cells("Customer Name").Value, dr.Cells("addr1").Value, dr.Cells("telp").Value, dr.Cells("Account Name").Value, dr.Cells("Account No").Value, dr.Cells("Approval No").Value)
            Next


            If cmbFormatCetak.Text = "ABM" Then
                rptDoc2.SetDataSource(dt)
                rptDoc2.SetParameterValue("NamaToko", "ABM")
                rptDoc2.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc2.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.341 - BANDUNG")
                rptDoc2.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc2.SetParameterValue("Telepon", "TELP : 022-7271511")
                FormCetakCashAndSO.CrystalReportViewer1.ReportSource = rptDoc2
                FormCetakCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "AYANI" Then
                rptDoc2.SetDataSource(dt)

                rptDoc2.SetParameterValue("NamaToko", "RKM AYANI")
                rptDoc2.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc2.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.323 - BANDUNG")
                rptDoc2.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc2.SetParameterValue("Telepon", "TELP : 022-7277108")
                FormCetakCashAndSO.CrystalReportViewer1.ReportSource = rptDoc2
                FormCetakCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "CIBABAT" Then
                rptDoc2.SetDataSource(dt)
                rptDoc2.SetParameterValue("NamaToko", "RKM CIBABAT")
                rptDoc2.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc2.SetParameterValue("AlamatToko", "JL. RAYA CIBABAT NO.306 RT.003/015 CIBABAT")
                rptDoc2.SetParameterValue("NPWP", "NPWP : 02.567.546.3-445.001")
                rptDoc2.SetParameterValue("Telepon", "TELP : 022-6650881")
                FormCetakCashAndSO.CrystalReportViewer1.ReportSource = rptDoc2
                FormCetakCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "CIBIRU" Then
                rptDoc2.SetDataSource(dt)
                rptDoc2.SetParameterValue("NamaToko", "RKM CIBIRU")
                rptDoc2.SetParameterValue("NamaPerusahaan", "PT. KENCANA SATRIA SEJATI MANDIRI")
                rptDoc2.SetParameterValue("AlamatToko", "JL. RAYA CIBIRU NO. 402 - KAB.BANDUNG")
                rptDoc2.SetParameterValue("NPWP", "NPWP : 31.313.536.0.444.000")
                rptDoc2.SetParameterValue("Telepon", "TELP : 022-7811074")
                FormCetakCashAndSO.CrystalReportViewer1.ReportSource = rptDoc2
                FormCetakCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "KOPO" Then
                rptDoc2.SetDataSource(dt)
                rptDoc2.SetParameterValue("NamaToko", "RKM KOPO")
                rptDoc2.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc2.SetParameterValue("AlamatToko", "JL. KOPO BIHBUL NO.1 - KAB.BANDUNG")
                rptDoc2.SetParameterValue("NPWP", "NPWP : 02.567.546.3.445.001")
                rptDoc2.SetParameterValue("Telepon", "TELP : 022-54266583")
                FormCetakCashAndSO.CrystalReportViewer1.ReportSource = rptDoc2
                FormCetakCashAndSO.Show()

            End If

        ElseIf cmbJenisStruk.Text = "Non Cash Invoice" Then
            Call LoadNonCashInvoice(txtLokasiFile.Text)

            Dim dt As New DataTable
            With dt
                .Columns.Add("Transaction No")
                .Columns.Add("Cashier")
                .Columns.Add("Sales Organization")
                .Columns.Add("Last Update")
                .Columns.Add("Payment Group")
                .Columns.Add("Payment Type")
                .Columns.Add("Product Code")
                .Columns.Add("Product Name")
                .Columns.Add("Qty", GetType(Single))
                .Columns.Add("UOM")
                .Columns.Add("Price", GetType(Single))
                .Columns.Add("Total", GetType(Single))
                .Columns.Add("Amount", GetType(Single))
                .Columns.Add("Charges", GetType(Single))
                .Columns.Add("Total Amount", GetType(Single))
                .Columns.Add("Customer Name")
                .Columns.Add("addr1")
                .Columns.Add("telp")
                .Columns.Add("Account Name")
                .Columns.Add("Account No")
                .Columns.Add("Approval No")


            End With

            For Each dr As DataGridViewRow In Me.dgData.Rows
                dt.Rows.Add(dr.Cells("Transaction No").Value, dr.Cells("Cashier").Value, dr.Cells("Sales Organization").Value, dr.Cells("Last Update").Value, dr.Cells("Payment Group").Value, dr.Cells("Payment Type").Value, dr.Cells("Product Code").Value, dr.Cells("Product Name").Value, dr.Cells("Qty").Value, dr.Cells("UOM").Value, dr.Cells("Price").Value, dr.Cells("Total").Value, dr.Cells("Amount").Value, dr.Cells("Charges").Value, dr.Cells("Total Amount").Value, dr.Cells("Customer Name").Value, dr.Cells("addr1").Value, dr.Cells("telp").Value, dr.Cells("Account Name").Value, dr.Cells("Account No").Value, dr.Cells("Approval No").Value)
            Next


            If cmbFormatCetak.Text = "ABM" Then
                rptDoc3.SetDataSource(dt)
                rptDoc3.SetParameterValue("NamaToko", "ABM")
                rptDoc3.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc3.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.341 - BANDUNG")
                rptDoc3.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc3.SetParameterValue("Telepon", "TELP : 022-7271511")
                FormCetakNonCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc3
                FormCetakNonCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "AYANI" Then
                rptDoc3.SetDataSource(dt)

                rptDoc3.SetParameterValue("NamaToko", "RKM AYANI")
                rptDoc3.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc3.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.323 - BANDUNG")
                rptDoc3.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc3.SetParameterValue("Telepon", "TELP : 022-7277108")
                FormCetakNonCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc3
                FormCetakNonCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "CIBABAT" Then
                rptDoc3.SetDataSource(dt)
                rptDoc3.SetParameterValue("NamaToko", "RKM CIBABAT")
                rptDoc3.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc3.SetParameterValue("AlamatToko", "JL. RAYA CIBABAT NO.306 RT.003/015 CIBABAT")
                rptDoc3.SetParameterValue("NPWP", "NPWP : 02.567.546.3-445.001")
                rptDoc3.SetParameterValue("Telepon", "TELP : 022-6650881")
                FormCetakNonCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc3
                FormCetakNonCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "CIBIRU" Then
                rptDoc3.SetDataSource(dt)
                rptDoc3.SetParameterValue("NamaToko", "RKM CIBIRU")
                rptDoc3.SetParameterValue("NamaPerusahaan", "PT. KENCANA SATRIA SEJATI MANDIRI")
                rptDoc3.SetParameterValue("AlamatToko", "JL. RAYA CIBIRU NO. 402 - KAB.BANDUNG")
                rptDoc3.SetParameterValue("NPWP", "NPWP : 31.313.536.0.444.000")
                rptDoc3.SetParameterValue("Telepon", "TELP : 022-7811074")
                FormCetakNonCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc3
                FormCetakNonCashAndCarry.Show()

            ElseIf cmbFormatCetak.Text = "KOPO" Then
                rptDoc3.SetDataSource(dt)
                rptDoc3.SetParameterValue("NamaToko", "RKM KOPO")
                rptDoc3.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc3.SetParameterValue("AlamatToko", "JL. KOPO BIHBUL NO.1 - KAB.BANDUNG")
                rptDoc3.SetParameterValue("NPWP", " NPWP : 02.567.546.3.445.001")
                rptDoc3.SetParameterValue("Telepon", "TELP : 022-54266583")
                FormCetakNonCashAndCarry.CrystalReportViewer1.ReportSource = rptDoc3
                FormCetakNonCashAndCarry.Show()

            End If



        ElseIf cmbJenisStruk.Text = "Non Cash Reserve Invoice" Then
            Call LoadNonCashAndReserveInvoice(txtLokasiFile.Text)

            Dim dt As New DataTable
            With dt
                .Columns.Add("Transaction No")
                .Columns.Add("Cashier")
                .Columns.Add("Sales Organization")
                .Columns.Add("Last Update")
                .Columns.Add("Payment Group")
                .Columns.Add("Payment Type")
                .Columns.Add("Product Code")
                .Columns.Add("Product Name")
                .Columns.Add("Qty", GetType(Single))
                .Columns.Add("UOM")
                .Columns.Add("Price", GetType(Single))
                .Columns.Add("Total", GetType(Single))
                .Columns.Add("Amount", GetType(Single))
                .Columns.Add("Charges", GetType(Single))
                .Columns.Add("Total Amount", GetType(Single))
                .Columns.Add("Customer Name")
                .Columns.Add("addr1")
                .Columns.Add("telp")
                .Columns.Add("Account Name")
                .Columns.Add("Account No")
                .Columns.Add("Approval No")


            End With

            For Each dr As DataGridViewRow In Me.dgData.Rows
                dt.Rows.Add(dr.Cells("Transaction No").Value, dr.Cells("Cashier").Value, dr.Cells("Sales Organization").Value, dr.Cells("Last Update").Value, dr.Cells("Payment Group").Value, dr.Cells("Payment Type").Value, dr.Cells("Product Code").Value, dr.Cells("Product Name").Value, dr.Cells("Qty").Value, dr.Cells("UOM").Value, dr.Cells("Price").Value, dr.Cells("Total").Value, dr.Cells("Amount").Value, dr.Cells("Charges").Value, dr.Cells("Total Amount").Value, dr.Cells("Customer Name").Value, dr.Cells("addr1").Value, dr.Cells("telp").Value, dr.Cells("Account Name").Value, dr.Cells("Account No").Value, dr.Cells("Approval No").Value)
            Next


            If cmbFormatCetak.Text = "ABM" Then
                rptDoc4.SetDataSource(dt)
                rptDoc4.SetParameterValue("NamaToko", "ABM")
                rptDoc4.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc4.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.341 - BANDUNG")
                rptDoc4.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc4.SetParameterValue("Telepon", "TELP : 022-7271511")
                FormCetakNonCashAndSO.CrystalReportViewer1.ReportSource = rptDoc4
                FormCetakNonCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "AYANI" Then
                rptDoc4.SetDataSource(dt)

                rptDoc4.SetParameterValue("NamaToko", "RKM AYANI")
                rptDoc4.SetParameterValue("NamaPerusahaan", "LIE PHIE TJEN")
                rptDoc4.SetParameterValue("AlamatToko", "JL. AHMAD YANI NO.323 - BANDUNG")
                rptDoc4.SetParameterValue("NPWP", "NPWP : 06.002.007.6-423.000")
                rptDoc4.SetParameterValue("Telepon", "TELP : 022-7277108")
                FormCetakNonCashAndSO.CrystalReportViewer1.ReportSource = rptDoc4
                FormCetakNonCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "CIBABAT" Then
                rptDoc4.SetDataSource(dt)
                rptDoc4.SetParameterValue("NamaToko", "RKM CIBABAT")
                rptDoc4.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc4.SetParameterValue("AlamatToko", "JL. RAYA CIBABAT NO.306 RT.003/015 CIBABAT")
                rptDoc4.SetParameterValue("NPWP", "NPWP : 02.567.546.3-445.001")
                rptDoc4.SetParameterValue("Telepon", "TELP : 022-6650881")
                FormCetakNonCashAndSO.CrystalReportViewer1.ReportSource = rptDoc4
                FormCetakNonCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "CIBIRU" Then
                rptDoc4.SetDataSource(dt)
                rptDoc4.SetParameterValue("NamaToko", "RKM CIBIRU")
                rptDoc4.SetParameterValue("NamaPerusahaan", "PT. KENCANA SATRIA SEJATI MANDIRI")
                rptDoc4.SetParameterValue("AlamatToko", "JL. RAYA CIBIRU NO. 402 - KAB.BANDUNG")
                rptDoc4.SetParameterValue("NPWP", "NPWP : 31.313.536.0.444.000")
                rptDoc4.SetParameterValue("Telepon", "TELP : 022-7811074")
                FormCetakNonCashAndSO.CrystalReportViewer1.ReportSource = rptDoc4
                FormCetakNonCashAndSO.Show()

            ElseIf cmbFormatCetak.Text = "KOPO" Then
                rptDoc4.SetDataSource(dt)
                rptDoc4.SetParameterValue("NamaToko", "RKM KOPO")
                rptDoc4.SetParameterValue("NamaPerusahaan", "CV. KENCANA SATRIA SEJATI")
                rptDoc4.SetParameterValue("AlamatToko", "JL. KOPO BIHBUL NO.1 - KAB.BANDUNG")
                rptDoc4.SetParameterValue("NPWP", "NPWP : 02.567.546.3.445.001")
                rptDoc4.SetParameterValue("Telepon", "TELP : 022-54266583")
                FormCetakNonCashAndSO.CrystalReportViewer1.ReportSource = rptDoc4
                FormCetakNonCashAndSO.Show()

            End If
        End If


    End Sub




End Class
