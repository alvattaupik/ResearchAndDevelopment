Imports System.Data.SqlClient
Public Class Ping

    Dim DataSourceGrid As New BindingSource()



    Sub LoadDaftarUserAplikasi()
        Call KoneksiDatabase1()
        Dim cmd As New SqlCommand(" SELECT NamaComputer,IPAddress FROM dbo.V_ListKomputerRKM WHERE KodeCabang='" & MstrKodeDivisi & "' UNION ALL SELECT NamaComputer,IPAddress FROM dbo.V_ListKomputerRKM WHERE NamaComputer LIKE '%Server%' AND KodeCabang='000'", Koneksi1)
        cmd.CommandTimeout = 0
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        Dim view1 As New DataView(table)
        DataSourceGrid.DataSource = view1
        dgListIP.DataSource = view1
        dgListIP.Refresh()
        dgListIP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgListIP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgListIP.AutoResizeColumns()
        dgListIP.RowHeadersVisible = False
    End Sub

    Private Sub Ping_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDaftarUserAplikasi()
    End Sub




    Private Sub Ping_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub Ping_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

    Private Sub txtCariNamaKomputer_TextChanged(sender As Object, e As EventArgs) Handles txtCariNamaKomputer.TextChanged
        DataSourceGrid.Filter = "NamaComputer like '%" & txtCariNamaKomputer.Text & "%'"
        dgListIP.Refresh()
    End Sub

  
    Private Sub dgListIP_DoubleClick(sender As Object, e As EventArgs) Handles dgListIP.DoubleClick
        Shell("CMD.exe /C ping " & (Trim(dgListIP.Item(1, dgListIP.CurrentRow.Index).Value)) & " -t", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("CMD.exe /C ping " & (Trim(TextBox1.Text)) & " -t", AppWinStyle.NormalFocus)
    End Sub
End Class