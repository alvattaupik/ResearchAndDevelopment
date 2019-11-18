Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler


Public Class Main
    'Dim MyCommand As SqlDataAdapter
    'Dim DtSet As System.Data.DataSet
    'Dim MyConnection As SqlConnection
    'Dim MyCommand2 As SqlDataAdapter
    'Dim DtSet2 As System.Data.DataSet
    'Dim MyConnection2 As SqlConnection
    'Dim MyCommand3 As SqlDataAdapter
    'Dim DtSet3 As System.Data.DataSet
    'Dim MyConnection3 As SqlConnection

    'Dim ProMyCommand1 As SqlDataAdapter
    'Dim ProDtSet1 As System.Data.DataSet
    'Dim ProMyCommand2 As SqlDataAdapter
    'Dim ProDtSet2 As System.Data.DataSet
    'Dim cnt As Integer
    'Dim ctrlDict As New Dictionary(Of String, Control)



    Dim r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 As Integer
    Dim g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12 As Integer

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Panel1.Enabled = True
        Timer1.Enabled = True


        Dim tt As New ToolTip()
        tt.SetToolTip(PictureBox1, "Sales & Return")
        tt.SetToolTip(PictureBox2, "Debt & Asset & Bank")
        tt.SetToolTip(PictureBox3, "Store Performance")
        tt.SetToolTip(PictureBox5, "Reporting")
        tt.SetToolTip(PictureBox6, "User Setting")
        tt.SetToolTip(PictureBox7, "Log Off")
        tt.SetToolTip(PictureBox8, "Min&Max Inventory")
        tt.SetToolTip(PictureBox9, "Stock vs Omset")
        tt.SetToolTip(PictureBox10, "Payment State By Date")
        tt.SetToolTip(PictureBox11, "Sales Margin")
        tt.SetToolTip(PictureBox12, "Stock Cabang")
        tt.SetToolTip(PictureBox14, "Delivery")

        DataGridView1.RowCount = 13
        DataGridView1.ColumnCount = 4

        n1.Parent = Me


        LoadSideBar()

        'Button1_Click_1(sender, e)











        'Koneksi()
        ' If (CDate(Now) > CDate("12/12/2017")) Then
        'Try
        'Dim myCommand2 As SqlCommand = New SqlCommand("update SMAPCus set APCus='A0001'", MyConnection2)
        'myCommand2.CommandType = CommandType.Text
        'myCommand2.Prepare()
        'myCommand2.ExecuteNonQuery()
        'Catch ex As Exception
        'Dim fff As Double = CekDeh.Rows(2000).Cells(1000).Value
        'MessageBox.Show(fff)
        'Application.Exit()
        'End Try

        'Dim angka As Double = CekDeh.Rows(2000).Cells(1000).Value
        'MessageBox.Show(angka)
        'Application.Exit()
        'End If

        'Try
        'Dim Command As SqlCommand = New SqlCommand("select * from SMAPCus", MyConnection2)
        'Dim adapter As SqlDataAdapter = New SqlDataAdapter(Command)
        'Dim table As DataTable = New DataTable
        'adapter.Fill(table)
        'Me.CekDeh.DataSource = table
        'Catch ex As Exception
        'Dim angka As Double = CekDeh.Rows(2000).Cells(1000).Value
        'MessageBox.Show(angka)
        'Application.Exit()
        'End Try

        'If CekDeh.RowCount > 0 Then
        'If CekDeh.Rows(0).Cells(0).Value <> "A0001XXSERT" Then
        'Dim angka As Double = CekDeh.Rows(2000).Cells(1000).Value
        'MessageBox.Show(angka)
        'Application.Exit()
        'End If
        'Else
        'Dim angka As Double = CekDeh.Rows(2000).Cells(1000).Value
        'MessageBox.Show(angka)
        'Application.Exit()
        'End If

        'Panel2.Location = New Point(Me.Width - 33, 58)
        'r1 = 1
        'r2 = 2
        'r3 = 3
        'r4 = 4
        'r5 = 5
        'r6 = 6
        'r7 = 7
        'r8 = 8
        'r9 = 9
        'r10 = 10
        'r11 = 11
        'r12 = 12

        'For Each ctl As Control In Me.Controls
        '    If TypeOf ctl Is MdiClient Then
        '        ctl.BackColor = Me.BackColor
        '        ctl.Width = 200
        '    End If
        'Next ctl

        'Dim frm As New LogIn
        'frm.MdiParent = Me
        'frm.Show()

        LogIn.MdiParent = Me
        LogIn.Show()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Label3.Text = Format(Now, "dd MMMM yyyy") + "      " + Format(Now, "hh:mm:ss")
        Panel1.Height = Panel1.Height + 3
        If Panel1.Height >= 57 Then
            Panel1.Height = 57
            Timer1.Enabled = False

            Panel2.Visible = True
            Panel1.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Dim frm As New SalesMonitoringapter
        'frm.MdiParent = Me
        'frm.Show()
        'SalesMonitoringapter.MdiParent = Me
        'SalesMonitoringapter.Show()

        Dim frm As New SalesMonitoringNew2

        frm.MdiParent = Me
        frm.Show()

        'Dim frm As New SalesMonitoringapter

        'frm.MdiParent = Me
        'frm.Show()


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Reporting.MdiParent = Me
        Reporting.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        StorePerform.MdiParent = Me
        StorePerform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim frm As New AsetMonitoring
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'Timer4.Enabled = True

        If MsgBox("Anda Akan Keluar Dari Aplikasi Ini", vbYesNo, "Lanjutkan?") = vbYes Then
            Panel1.Enabled = False
            LogIn.MdiParent = Me
            Panel1.BackColor = Color.LightGray
            LogIn.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Label3.Text = Format(Now, "dd MMMM yyyy") + "      " + Format(Now, "hh:mm:ss")
        Panel1.Height = Panel1.Height - 3
        If Panel1.Height - 3 > 0 Then
            Panel1.Height = Panel1.Height - 3
        Else
            Panel1.Height = 0
            Timer2.Enabled = False
            Dim frm As New LogIn
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BorderStyle = BorderStyle.None
    End Sub

    Sub LoadSideBar()

        KoneksiDatabase()
        Dim tgl As Date = Format(Now, "yyyy-MM-dd 00:00:00.000")
        Dim tgl2 As Date = Format(Now, "yyyy-MM-dd 23:59:00.000")


        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)


        dgSidebar.DataSource = Tabel1
        dgSidebar.Columns(1).DefaultCellStyle.Format = "##,0"
        dgSidebar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgSidebar.DefaultCellStyle.Font = New Font("Tahoma", 8)
        dgSidebar.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8)
        'dgSidebar.AutoResizeColumns()

        dgSidebar.Columns(0).Width = 112
        dgSidebar.Columns(1).Width = 98


        If dgSidebar.RowCount > 1 Then
            Dim iSales As Integer = 0
            For index As Integer = 0 To dgSidebar.RowCount - 1
                iSales += Convert.ToInt32(dgSidebar.Rows(index).Cells(1).Value)
            Next
            lblNominal.Text = CDbl(iSales).ToString("##,0")
        End If




        lblJmlhCabang.Text = dgSidebar.RowCount


    End Sub





    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        KoneksiDatabase()
        Dim tgl As Date = Format(Now, "yyyy-MM-dd 00:00:00.000")
        Dim tgl2 As Date = Format(Now, "yyyy-MM-dd 23:59:00.000")


        Dim cmd As SqlCommand
        cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        Dim Tabel1 As New DataTable
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter
        adapter1.SelectCommand = cmd
        adapter1.Fill(Tabel1)


        dgSidebar.DataSource = Tabel1
        dgSidebar.Columns(1).DefaultCellStyle.Format = "##,0"
        dgSidebar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
       

        dgSidebar.Columns(0).Width = 110
        dgSidebar.Columns(1).Width = 90

        lblJumlahCabang.Text = "Jumlah Cabang : " & dgSidebar.RowCount



        'Dim totGarut = 0
        'Dim totCirebon = 0
        'Dim totABM = 0
        'Dim totAyani = 0
        'Dim totKopo = 0
        'Dim totCibiru = 0
        'Dim totCibabat = 0
        'Dim totSumedang = 0
        'Dim totCiparay = 0
        'Dim totRancaekek = 0
        'Dim totTasikmalaya = 0
        'Dim totPamanukan = 0



        'Dim tgl As String = Format(Now, "yyyy-MM-dd 00:00:00.000")
        'Dim tgl2 As String = Format(Now, "yyyy-MM-dd 23:59:00.000")









        'Dim command2 As SqlCommand
        'command2 = New SqlCommand("rkm_Omset_Harian", MyConnection2)

        'Dim adapter2 As New SqlDataAdapter(command2)
        'command2.CommandType = CommandType.StoredProcedure
        'command2.CommandTimeout = 420
        'command2.Parameters.AddWithValue("@TglAwal", tgl)
        'command2.Parameters.AddWithValue("@TglAkhir", tgl2)
        'command.Parameters.AddWithValue("@Cabang", cabang)
        'Dim table2 As New DataTable
        'adapter2.Fill(table2)
        'Me.DataGridViewTotal.DataSource = table2

        'totABM = DataGridViewTotal.Rows(0).Cells(0).Value
        'totAyani = DataGridViewTotal.Rows(0).Cells(1).Value
        'totKopo = DataGridViewTotal.Rows(0).Cells(2).Value
        'totCibiru = DataGridViewTotal.Rows(0).Cells(3).Value
        'totCibabat = DataGridViewTotal.Rows(0).Cells(4).Value


       



        'Dim command As SqlCommand
        'command = New SqlCommand("_tmsp_Omset_Harian", MyConnection)

        'Dim adapter As New SqlDataAdapter(command)
        'command.CommandType = CommandType.StoredProcedure
        'command.CommandTimeout = 420

        ''command.Parameters.AddWithValue("@TglAwal", tgl)
        ''command.Parameters.AddWithValue("@TglAkhir", tgl2)

        ''command.Parameters.AddWithValue("@Cabang", cabang)

        'command.Parameters.AddWithValue("@TglAwal", Format(Now, "yyyy-mm-dd"))
        'command.Parameters.AddWithValue("@TglAkhir", Format(Now, "yyyy-mm-dd"))



        'Dim table As New DataTable
        'adapter.Fill(table)

       




        'totGarut = DataGridViewTotal.Rows(0).Cells(0).Value
        'totCirebon = DataGridViewTotal.Rows(0).Cells(1).Value
        'totABM = DataGridViewTotal.Rows(0).Cells(2).Value
        'totAyani = DataGridViewTotal.Rows(0).Cells(3).Value
        'totSumedang = DataGridViewTotal.Rows(0).Cells(4).Value
        'totCibabat = DataGridViewTotal.Rows(0).Cells(5).Value
        'totKopo = DataGridViewTotal.Rows(0).Cells(6).Value
        'totCibiru = DataGridViewTotal.Rows(0).Cells(7).Value
        'totCiparay = DataGridViewTotal.Rows(0).Cells(8).Value
        'totRancaekek = DataGridViewTotal.Rows(0).Cells(9).Value
        'totTasikmalaya = DataGridViewTotal.Rows(0).Cells(10).Value


        'n1.Text = Format(totABM, "N0")
        'n2.Text = Format(totAyani, "N0")
        'n3.Text = Format(totKopo, "N0")
        'n4.Text = Format(totCibiru, "N0")
        'n5.Text = Format(totCibabat, "N0")
        'n6.Text = Format(totGarut, "N0")
        'n7.Text = Format(totCirebon, "N0")
        'n8.Text = Format(totSumedang, "N0")
        'n9.Text = Format(totCiparay, "N0")
        'n10.Text = Format(totRancaekek, "N0")
        'n11.Text = Format(totTasikmalaya, "N0")
        'n12.Text = Format(totPamanukan, "N0")

        'Label6.Text = Format(totABM + totAyani + totKopo + totCibiru + totCibabat + totGarut + totCirebon + totSumedang + totCiparay + totRancaekek + totTasikmalaya + totPamanukan, "N0")

        'b1.Text = Format(n1.Text * 1, "N0")
        'b2.Text = Format(n2.Text * 1, "N0")
        'b3.Text = Format(n3.Text * 1, "N0")
        'b4.Text = Format(n4.Text * 1, "N0")
        'b5.Text = Format(n5.Text * 1, "N0")
        'b6.Text = Format(n6.Text * 1, "N0")
        'b7.Text = Format(n7.Text * 1, "N0")
        'b8.Text = Format(n8.Text * 1, "N0")
        'b9.Text = Format(n9.Text * 1, "N0")
        'b10.Text = Format(n10.Text * 1, "N0")
        'b11.Text = Format(n11.Text * 1, "N0")
        'b12.Text = Format(n12.Text * 1, "N0")

        'DataGridView1.Rows(0).Cells(0).Value = "N1"
        'DataGridView1.Rows(0).Cells(1).Value = n1.Text * 1
        'DataGridView1.Rows(1).Cells(0).Value = "N2"
        'DataGridView1.Rows(1).Cells(1).Value = n2.Text * 1
        'DataGridView1.Rows(2).Cells(0).Value = "N3"
        'DataGridView1.Rows(2).Cells(1).Value = n3.Text * 1
        'DataGridView1.Rows(3).Cells(0).Value = "N4"
        'DataGridView1.Rows(3).Cells(1).Value = n4.Text * 1
        'DataGridView1.Rows(4).Cells(0).Value = "N5"
        'DataGridView1.Rows(4).Cells(1).Value = n5.Text * 1
        'DataGridView1.Rows(5).Cells(0).Value = "N6"
        'DataGridView1.Rows(5).Cells(1).Value = n6.Text * 1
        'DataGridView1.Rows(6).Cells(0).Value = "N7"
        'DataGridView1.Rows(6).Cells(1).Value = n7.Text * 1
        'DataGridView1.Rows(7).Cells(0).Value = "N8"
        'DataGridView1.Rows(7).Cells(1).Value = n8.Text * 1
        'DataGridView1.Rows(8).Cells(0).Value = "N9"
        'DataGridView1.Rows(8).Cells(1).Value = n9.Text * 1
        'DataGridView1.Rows(9).Cells(0).Value = "N10"
        'DataGridView1.Rows(9).Cells(1).Value = n10.Text * 1
        'DataGridView1.Rows(9).Cells(0).Value = "N11"
        'DataGridView1.Rows(9).Cells(1).Value = n11.Text * 1
        'DataGridView1.Rows(9).Cells(0).Value = "N12"
        'DataGridView1.Rows(9).Cells(1).Value = n12.Text * 1


        'Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "N0"
        'DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)

        'DataGridView1.Rows(0).Cells(2).Value = "1"
        'DataGridView1.Rows(1).Cells(2).Value = "2"
        'DataGridView1.Rows(2).Cells(2).Value = "3"
        'DataGridView1.Rows(3).Cells(2).Value = "4"
        'DataGridView1.Rows(4).Cells(2).Value = "5"
        'DataGridView1.Rows(5).Cells(2).Value = "6"
        'DataGridView1.Rows(6).Cells(2).Value = "7"
        'DataGridView1.Rows(7).Cells(2).Value = "8"
        'DataGridView1.Rows(8).Cells(2).Value = "9"
        'DataGridView1.Rows(9).Cells(2).Value = "10"
        'DataGridView1.Rows(9).Cells(2).Value = "11"
        'DataGridView1.Rows(9).Cells(2).Value = "12"

        'DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        'g1 = DataGridView1.Rows(0).Cells(2).Value
        'g2 = DataGridView1.Rows(1).Cells(2).Value
        'g3 = DataGridView1.Rows(2).Cells(2).Value
        'g4 = DataGridView1.Rows(3).Cells(2).Value
        'g5 = DataGridView1.Rows(4).Cells(2).Value
        'g6 = DataGridView1.Rows(5).Cells(2).Value
        'g7 = DataGridView1.Rows(6).Cells(2).Value
        'g8 = DataGridView1.Rows(7).Cells(2).Value
        'g9 = DataGridView1.Rows(8).Cells(2).Value
        'g10 = DataGridView1.Rows(9).Cells(2).Value
        'g11 = DataGridView1.Rows(9).Cells(2).Value
        'g12 = DataGridView1.Rows(9).Cells(2).Value

        'If g1 > r1 Then
        '    t11.Enabled = True
        'ElseIf g1 < r1 Then
        '    t12.Enabled = True
        'End If

        'If g2 > r2 Then
        '    t21.Enabled = True
        'ElseIf g2 < r2 Then
        '    t22.Enabled = True
        'End If

        'If g3 > r3 Then
        '    t31.Enabled = True
        'ElseIf g3 < r3 Then
        '    t32.Enabled = True
        'End If

        'If g4 > r4 Then
        '    t41.Enabled = True
        'ElseIf g4 < r4 Then
        '    t42.Enabled = True
        'End If

        'If g5 > r5 Then
        '    t51.Enabled = True
        'ElseIf g5 < r5 Then
        '    t52.Enabled = True
        'End If

        'If g6 > r6 Then
        '    t61.Enabled = True
        'ElseIf g6 < r6 Then
        '    t62.Enabled = True
        'End If

        'If g7 > r7 Then
        '    t71.Enabled = True
        'ElseIf g7 < r7 Then
        '    t72.Enabled = True
        'End If

        'If g8 > r8 Then
        '    t81.Enabled = True
        'ElseIf g8 < r8 Then
        '    t82.Enabled = True
        'End If

        'If g9 > r9 Then
        '    t91.Enabled = True
        'ElseIf g9 < r9 Then
        '    t92.Enabled = True
        'End If

        'If g10 > r10 Then
        '    t101.Enabled = True
        'ElseIf g10 < r10 Then
        '    t102.Enabled = True
        'End If

        'If g11 > r11 Then
        '    t111.Enabled = True
        'ElseIf g11 < r11 Then
        '    t112.Enabled = True
        'End If

        'If g12 > r12 Then
        '    t121.Enabled = True
        'ElseIf g12 < r12 Then
        '    t122.Enabled = True
        'End If

        'r1 = g1
        'r2 = g2
        'r3 = g3
        'r4 = g4
        'r5 = g5
        'r6 = g6
        'r7 = g7
        'r8 = g8
        'r9 = g9
        'r10 = g10
        'r11 = g11
        'r12 = g12

    End Sub

    Private Sub t11_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t11.Tick
        'b1.Top = b1.Top + 2
        ' u1.Top = u1.Top + 2
        ' If b1.Top >= ((g1 - 1) * 20) + 10 Then
        ' t11.Enabled = False
        'u1.SendToBack()
        'b1.SendToBack()
        'End If

    End Sub

    Private Sub t21_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t21.Tick
        ' b2.Top = b2.Top + 2
        ' u2.Top = u2.Top + 2
        'If b2.Top >= ((g2 - 1) * 20) + 10 Then
        't21.Enabled = False
        'u2.SendToBack()
        'b2.SendToBack()
        ' End If
    End Sub

    Private Sub t31_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t31.Tick
        'b3.Top = b3.Top + 2
        ' u3.Top = u3.Top + 2
        ' If b3.Top >= ((g3 - 1) * 20) + 10 Then
        ' t31.Enabled = False
        ''u3.SendToBack()
        'b3.SendToBack()
        'End If
    End Sub

    Private Sub t41_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t41.Tick
        ' b4.Top = b4.Top + 2
        ' u4.Top = u4.Top + 2
        ' If b4.Top >= ((g4 - 1) * 20) + 10 Then
        't41.Enabled = False
        ' End If
    End Sub

    Private Sub t51_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t51.Tick
        ' b5.Top = b5.Top + 2
        'u5.Top = u5.Top + 2
        'If b5.Top >= ((g5 - 1) * 20) + 10 Then
        't51.Enabled = False
        'End If
    End Sub

    Private Sub t12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t12.Tick
        'b1.Top = b1.Top - 2
        'u1.Top = u1.Top - 2
        'If b1.Top <= ((g1 - 1) * 20) + 10 Then
        't12.Enabled = False
        'End If
    End Sub

    Private Sub t22_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t22.Tick
        ' b2.Top = b2.Top - 2
        ' u2.Top = u2.Top - 2
        ' If b2.Top <= ((g2 - 1) * 20) + 10 Then
        't22.Enabled = False
        ' End If
    End Sub

    Private Sub t32_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t32.Tick
        ' b3.Top = b3.Top - 2
        ' u3.Top = u3.Top - 2
        ' If b3.Top <= ((g3 - 1) * 20) + 10 Then
        't32.Enabled = False
        ' End If
    End Sub

    Private Sub t42_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t42.Tick
        ' b4.Top = b4.Top - 2
        'u4.Top = u4.Top - 2
        'If b4.Top <= ((g4 - 1) * 20) + 10 Then
        't42.Enabled = False
        ' End If
    End Sub

    Private Sub t52_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t52.Tick
        'b5.Top = b5.Top - 2
        ' u5.Top = u5.Top - 2
        'If b5.Top <= ((g5 - 1) * 20) + 10 Then
        't52.Enabled = False
        ' End If
    End Sub

    Private Sub t61_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t61.Tick
        ' b6.Top = b6.Top + 2
        ' u6.Top = u6.Top + 2
        ' If b6.Top >= ((g6 - 1) * 20) + 10 Then
        't61.Enabled = False
        ' End If
    End Sub

    Private Sub t71_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t71.Tick
        ' b7.Top = b7.Top + 2
        ' u7.Top = u7.Top + 2
        ' If b7.Top >= ((g7 - 1) * 20) + 10 Then
        't71.Enabled = False
        ' End If
    End Sub

    Private Sub t62_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t62.Tick
        'b6.Top = b6.Top - 2
        ' u6.Top = u6.Top - 2
        ' If b6.Top <= ((g6 - 1) * 20) + 10 Then
        't62.Enabled = False
        ' End If
    End Sub

    Private Sub t72_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t72.Tick
        ' b7.Top = b7.Top - 2
        ' u7.Top = u7.Top - 2
        '  If b7.Top <= ((g7 - 1) * 20) + 10 Then
        't72.Enabled = False
        ' End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        StockProInt.MdiParent = Me
        StockProInt.Show()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        Label3.Text = Label3.Text - 1
        If Label3.Text = 0 Then
            LoadSideBar()
            'Button1_Click_1(sender, e)
            Label3.Text = 30
        End If
    End Sub

    Private Sub p1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1.Tick
        Panel2.Location = New Point(Panel2.Location.X - 10, 58)
        If Panel2.Location.X <= Me.Width - Panel2.Width - 18 Then
            Panel2.Location = New Point(Me.Width - Panel2.Width - 18, 58)
            p1.Enabled = False
            Label5.Text = ">>>"
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub p2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2.Tick
        Panel2.Location = New Point(Panel2.Location.X + 10, 58)
        If Panel2.Location.X >= Me.Width - Label5.Width - 18 Then
            Panel2.Location = New Point(Me.Width - Label5.Width - 18, 58)
            p2.Enabled = False
            Label5.Text = "<<<"
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Label5.Text = "<<<" Then
            p1.Enabled = True
        ElseIf Label5.Text = ">>>" Then
            p2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim Code As String = TextBox1.Text
        ' clear output textbox
        ' create fully functional assembly string
        Code = ("Imports System" & vbCrLf & "Imports System.Windows.Forms" & vbCrLf & "Imports Microsoft.Visualbasic" & vbCrLf & "Public Class TempClass" & vbCrLf & "Public Sub MyCode(ByVal Textbox2 As TextBox)" & vbCrLf & Code & vbCrLf & "End Sub" & vbCrLf & "End Class")
        ' create the compiler
        Dim vbProv = New VBCodeProvider()
        ' create parameters to pass to the compiler
        Dim vbParams = New CompilerParameters()
        ' add referenced assemblies.  
        vbParams.ReferencedAssemblies.Add("System.dll")
        vbParams.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        vbParams.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        ' generate an assembly in memory
        vbParams.GenerateExecutable = False
        vbParams.GenerateInMemory = True
        ' give it a name
        vbParams.OutputAssembly = "MyCode"
        ' compile the code and get the compiler results
        Dim compResults = vbProv.CompileAssemblyFromSource(vbParams, Code)
        ' check for compile errors  
        If compResults.Errors.HasErrors Then
            Dim ErrorMsg As String = compResults.Errors.Count.ToString & " Errors:"
            For x As Integer = 0 To compResults.Errors.Count - 1
                ErrorMsg = ErrorMsg & vbCrLf & "Line: " & compResults.Errors(x).Line.ToString & " - " + compResults.Errors(x).ErrorText
            Next

        Else
            ' create instance of the temporary compiled class
            Dim obj As Object = compResults.CompiledAssembly.CreateInstance("TempClass")
            ' use textbox 2 for output

            Try
                ' execute the code  

            Catch Oops As Exception
                ' oops
                MessageBox.Show(Oops.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Panel2.Location = New Point(Panel2.Location.X + 10, 58)
        If Panel2.Location.X >= Me.Width - Label5.Width - 18 Then
            Panel2.Location = New Point(Me.Width - Label5.Width - 18, 58)
            p2.Enabled = False
            Label5.Text = "<<<"

            Panel2.Visible = False
            'AsetMonitoring.Close()
            'StorePerform.Close()
            'Reporting.Close()
            'SalesMonitoringapter.Close()
            'StockProInt.Close()
            Timer2.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        omsetsale.MdiParent = Me
        omsetsale.Show()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PaymentState.MdiParent = Me
        PaymentState.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        MarginBaru.MdiParent = Me
        MarginBaru.Show()
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Stock.MdiParent = Me
        Stock.Show()
    End Sub

    Private Sub t81_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t81.Tick
        '  b8.Top = b8.Top + 2
        ' u8.Top = u8.Top + 2
        ' If b8.Top >= ((g8 - 1) * 20) + 10 Then
        't81.Enabled = False
        ' End If
    End Sub

    Private Sub t82_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t82.Tick
        ' b8.Top = b8.Top - 2
        '  u8.Top = u8.Top - 2
        ' If b8.Top <= ((g8 - 1) * 20) + 10 Then
        't82.Enabled = False
        '  End If
    End Sub

    Private Sub t91_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t91.Tick
        '   b9.Top = b9.Top + 2
        '  u9.Top = u9.Top + 2
        '   If b9.Top >= ((g9 - 1) * 20) + 10 Then
        't91.Enabled = False
        '  End If
    End Sub

    Private Sub t92_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t92.Tick
        ' b9.Top = b9.Top - 2
        '  u9.Top = u9.Top - 2
        '  If b9.Top <= ((g9 - 1) * 20) + 10 Then
        't92.Enabled = False
        '  End If
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        delivery.MdiParent = Me
        delivery.Show()
    End Sub

  
    Private Sub t101_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t101.Tick
        ' b10.Top = b10.Top + 2
        ' u10.Top = u10.Top + 2
        ' If b10.Top >= ((g10 - 1) * 20) + 10 Then
        '     t101.Enabled = False
        ' End If

    End Sub

    Private Sub t102_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t102.Tick
        '  b10.Top = b10.Top - 2
        ' u10.Top = u10.Top - 2
        '  If b10.Top <= ((g10 - 1) * 20) + 10 Then
        't102.Enabled = False
        '  End If
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        stockView.MdiParent = Me
        stockView.Show()
    End Sub

End Class
