Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets
Public Class frmFullfillmentChecker



    Sub LoadReplicationMonitorIvendToStore()
        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[tmspCekFullfillments]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure


        command.Parameters.AddWithValue("NoStruk", txtNoStruk.Text)


        command.Parameters.Add("OutStatusSAP", SqlDbType.VarChar, 100)
        command.Parameters("OutStatusSAP").Direction = ParameterDirection.Output


        command.Parameters.Add("OutStatusIvend", SqlDbType.VarChar, 100)
        command.Parameters("OutStatusIvend").Direction = ParameterDirection.Output


        If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
        command.Connection = KoneksiIvend
        KoneksiIvend.Open()
        command.ExecuteNonQuery()


        If command.Parameters("OutStatusSAP").Value.ToString() <> "0" Then
            picOkSAP.Visible = True
        Else
            picFailIvend.Visible = False
        End If

        If command.Parameters("OutStatusIvend").Value.ToString() <> "0" Then
            picOkIvend.Visible = True
        Else
            picFailIvend.Visible = False
        End If


        If command.Parameters("OutStatusIvend").Value.ToString() <> "0" And command.Parameters("OutStatusSAP").Value.ToString() <> "0" Then
            lblStatus.Text = "Terintegrasi !"
            lblStatus.BackColor = Color.Green
        ElseIf command.Parameters("OutStatusIvend").Value.ToString() <> "0" And command.Parameters("OutStatusSAP").Value.ToString() = "0" Then
            lblStatus.Text = "Terpending/Dalam Proses Integrasi Ivend"
            lblStatus.BackColor = Color.Yellow
        ElseIf command.Parameters("OutStatusIvend").Value.ToString() = "0" And command.Parameters("OutStatusSAP").Value.ToString() = "0" Then
            lblStatus.Text = "Belum Terintegrasi !, Cek Monitoring Integrasi"
            lblStatus.BackColor = Color.Red
        End If


        Dim table As New DataTable
        adapter.Fill(table)
        Me.dgvListItemIntegrasi.DataSource = table
        dgvListItemIntegrasi.DataSource = table
        dgvListItemIntegrasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvListItemIntegrasi.AutoResizeColumns()
        dgvListItemIntegrasi.RowHeadersVisible = False
        lbljumlahItem.Text = "Jumlah Item : " & dgvListItemIntegrasi.Rows.Count

    End Sub



    Private Sub frmReplicationMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
      

    End Sub





 
    Private Sub txtNoStruk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoStruk.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            Call LoadReplicationMonitorIvendToStore()
        End If
        Exit Sub

ErrorHandler:
        DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        Exit Sub
    End Sub

   
End Class