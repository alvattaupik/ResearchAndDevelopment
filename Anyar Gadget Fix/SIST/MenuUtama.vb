Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph
Imports System.Reflection
Imports System.CodeDom
Imports System.CodeDom.Compiler


Public Class MenuUtama
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

    Private Sub MenuUtama_Click(sender As Object, e As EventArgs) Handles Me.Click
        PanelListMenu.Visible = False
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Panel1.Enabled = True
        Timer1.Enabled = True


        Dim frm As New SideBar

        frm.MdiParent = Me
        'PanelSideBar.SendToBack()
        'PanelPencarian.SendToBack()
        frm.TopMost = True
        frm.Show()

        Dim tt As New ToolTip()
        'tt.SetToolTip(PictureBox1, "Sales & Return")
        'tt.SetToolTip(PictureBox2, "Debt & Asset & Bank")
        'tt.SetToolTip(PictureBox3, "Store Performance")
        'tt.SetToolTip(PictureBox5, "Reporting")
        'tt.SetToolTip(PictureBox6, "User Setting")
        'tt.SetToolTip(PictureBox7, "Log Off")
        'tt.SetToolTip(PictureBox8, "Min&Max Inventory")
        'tt.SetToolTip(PictureBox9, "Stock vs Omset")
        'tt.SetToolTip(PictureBox10, "Payment State By Date")
        'tt.SetToolTip(PictureBox11, "Sales Margin")
        'tt.SetToolTip(PictureBox12, "Stock Cabang")
        'tt.SetToolTip(PictureBox14, "Delivery")

      






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

        'LogIn.MdiParent = Me
        'LogIn.Show()
        'LoadSideBar()


    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New SalesMonitoringapter
        'frm.MdiParent = Me
        'frm.Show()
        'SalesMonitoringapter.MdiParent = Me
        'SalesMonitoringapter.Show()

        'Dim frm As New SalesMonitoringNew2

        'frm.MdiParent = Me
        'frm.Show()

        'Dim frm As New SalesMonitoringapter

        'frm.MdiParent = Me
        'frm.Show()


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sorry This Feature Unavailable, Is Currently Under Development", vbInformation, "Informasi")
        Exit Sub
        'Reporting.MdiParent = Me
        'Reporting.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'StorePerform.MdiParent = Me
        'StorePerform.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Sorry This Feature Unavailable, Is Currently Under Development", vbInformation, "Informasi")
        Exit Sub

        'Dim frm As New AsetMonitoring
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Timer4.Enabled = True

        If MsgBox("Anda Akan Keluar Dari Aplikasi Ini", vbYesNo, "Lanjutkan?") = vbYes Then
            Panel1.Enabled = False
            'LogIn.MdiParent = Me
            'Panel1.BackColor = Color.LightGray
            'LogIn.Show()
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
            'Dim frm As New LogIn
            'frm.MdiParent = Me
            'frm.Show()
        End If
    End Sub

  
 

  

   

    Sub LoadSideBar()

        'KoneksiDatabase()
        'Dim tgl As Date = Format(Now, "yyyy-MM-dd 00:00:00.000")
        'Dim tgl2 As Date = Format(Now, "yyyy-MM-dd 23:59:00.000")


        'Dim cmd As SqlCommand
        'cmd = New SqlCommand("_tmsp_Omset_Harian_Unpivot", Koneksi)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New SqlParameter("@TglAwal", Format(Now, "yyyy-MM-dd")))
        'cmd.Parameters.Add(New SqlParameter("@TglAkhir", Format(Now, "yyyy-MM-dd")))



        'Dim Tabel1 As New DataTable
        'Dim adapter1 As SqlDataAdapter
        'adapter1 = New SqlDataAdapter
        'adapter1.SelectCommand = cmd
        'adapter1.Fill(Tabel1)


        'dgSidebar.DataSource = Tabel1
        'dgSidebar.Columns(1).DefaultCellStyle.Format = "##,0"
        'dgSidebar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgSidebar.DefaultCellStyle.Font = New Font("Tahoma", 8)
        'dgSidebar.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8)
        ''dgSidebar.AutoResizeColumns()

        'dgSidebar.Columns(0).Width = 112
        'dgSidebar.Columns(1).Width = 98


        'If dgSidebar.RowCount > 1 Then
        '    Dim iSales As Integer = 0
        '    For index As Integer = 0 To dgSidebar.RowCount - 1
        '        iSales += Convert.ToInt32(dgSidebar.Rows(index).Cells(1).Value)
        '    Next
        '    lblNominal.Text = CDbl(iSales).ToString("##,0")
        'End If




        'lblJmlhCabang.Text = dgSidebar.RowCount


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

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'StockProInt.MdiParent = Me
        'StockProInt.Show()
    End Sub

  




  

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'omsetsale.MdiParent = Me
        'omsetsale.Show()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PaymentState.MdiParent = Me
        'PaymentState.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MarginBaru.MdiParent = Me
        ''MarginBaru.Show()
        'MarginBaruV1_1.MdiParent = Me
        'MarginBaruV1_1.Show()

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Stock.MdiParent = Me
        'Stock.Show()
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
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'delivery.MdiParent = Me
        'delivery.Show()
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

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'stockView.MdiParent = Me
        'stockView.Show()
    End Sub

    Private Sub MonitoringRealstokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringRealstokToolStripMenuItem.Click
        Dim frm As New MonitoringRealStock

        frm.MdiParent = Me
        'PanelSideBar.SendToBack()
        'PanelPencarian.SendToBack()
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New MonitoringDelivery

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub

    Private Sub AnyarDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnyarDirectoryToolStripMenuItem.Click
        Dim frm As New AnyarRepository

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Show()
    End Sub

    Private Sub txtCariMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCariMenu.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        If Tombol = 27 Then
            PanelListMenu.Visible = False
            Exit Sub
        End If

        PanelListMenu.Visible = True
    End Sub

    Private Sub MenuUtama_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        lblMousePosition.Text = "Mouse Position :" & "X." & e.X & vbCrLf & "Y." & e.Y
    End Sub

    Private Sub AnyarLocalPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnyarLocalPrintToolStripMenuItem.Click
        Dim frm As New AnyarLocalPrint

        frm.MdiParent = Me
        frm.TopMost = True
        frm.Location = New Point(229, 3)
        frm.Show()
    End Sub
End Class
