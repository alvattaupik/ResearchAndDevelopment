Imports System.Data.SqlClient
Public Class frmPing

    Dim DataSourceGrid As New BindingSource()



  
    Private Sub Ping_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgListIP, " SELECT NamaComputer,IPAddress FROM dbo.V_ListKomputerRKM WHERE KodeCabang='" & MstrKodeDivisi & "' UNION ALL SELECT NamaComputer,IPAddress FROM dbo.V_ListKomputerRKM WHERE NamaComputer LIKE '%Server%' AND KodeCabang='000'", KoneksiDBEmail)
    End Sub


    Private Sub Ping_Move(sender As Object, e As EventArgs) Handles Me.Move
        'ShowLocation(Me)
    End Sub

    Private Sub Ping_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'ShowLocation(Me)
    End Sub

    'Private Sub txtCariNamaKomputer_TextChanged(sender As Object, e As EventArgs)
    '    DataSourceGrid.Filter = "NamaComputer like '%" & txtCariNamaKomputer.Text & "%'"
    '    dgListIP.Refresh()
    'End Sub


    Private Sub dgListIP_DoubleClick(sender As Object, e As EventArgs) Handles dgListIP.DoubleClick
        Shell("CMD.exe /C ping " & (Trim(dgListIP.Item(1, dgListIP.CurrentRow.Index).Value)) & " -t", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("CMD.exe /C ping " & (Trim(TextBox1.Text)) & " -t", AppWinStyle.NormalFocus)
    End Sub
End Class