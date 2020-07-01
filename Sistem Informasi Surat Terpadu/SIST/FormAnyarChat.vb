Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormAnyarChat


    Sub LoadComboJenisSurat()
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand("SELECT IPAddress,NamaComputer FROM dbo.ListKomputerRKM", Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmbListIp.DataSource = ds.Tables(0)
            cmbListIp.ValueMember = "IPAddress"
            cmbListIp.DisplayMember = "NamaComputer"
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub

    Private Sub cmbListIp_Click(sender As Object, e As EventArgs) Handles cmbListIp.Click
        LoadComboJenisSurat()
    End Sub
End Class