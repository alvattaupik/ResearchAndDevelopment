Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Sockets
Imports System.Windows.Forms.DataVisualization.Charting
Public Class frmStoreDatabasePerformance


    Dim Rand As New Random
    Dim Counter As Double = 1
    Dim IsiCounterNew As Double
    Dim Client As TcpClient
    Dim RX As StreamReader
    Dim TX As StreamWriter
    Dim isiCounter As Integer
    Private Angle As Integer


    Structure DataPointType
        Public x As Double
        Public y As Double

    End Structure


    Private ChartDataList As New List(Of DataPointType)





    Private Sub cmbLocation_Click(sender As Object, e As EventArgs) Handles cmbLocation.Click
        Try
            Dim strSQLSiteId As String = "Select SiteID,Nama From V_ListSiteIDIvend Where SiteID In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
            Call KoneksiDB_EMAIL()
            LoadComboBox(cmbLocation, strSQLSiteId, "SiteID", "Nama", KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        cmbLocation.Enabled = False


    End Sub

    Private Sub btnStopProses_Click(sender As Object, e As EventArgs) Handles btnStopProses.Click
        cmbLocation.Enabled = True
    End Sub

    Private Sub tmrGrafik_Tick(sender As Object, e As EventArgs) Handles tmrGrafik.Tick
        GetDataPoint()


        ChartPerforma.Series.Clear()
        ChartPerforma.Series.Add("Line Type")
        ChartPerforma.Series(0).IsVisibleInLegend = False
        ChartPerforma.Series(0).Color = Color.Red
        ChartPerforma.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        ChartPerforma.ChartAreas(0).AxisX.Minimum = ChartDataList(0).x
        ChartPerforma.ChartAreas(0).AxisX.Maximum = ChartPerforma.ChartAreas(0).AxisX.Minimum + 360

        For i = 0 To ChartDataList.Count - 1
            ChartPerforma.Series(0).Points.AddXY(ChartDataList(i).x, ChartDataList(i).y)
        Next

    End Sub


    Private Sub GetDataPoint()
        If ChartDataList.Count > 17 Then
            ChartDataList.Remove(ChartDataList(0))
        End If
        Dim thisDataPoint As DataPointType
        thisDataPoint.x = Angle
        thisDataPoint.y = dgvListProses.Rows.Count 'BebanKerja
        Label1.Text = thisDataPoint.x
        Label2.Text = thisDataPoint.y

        ChartDataList.Add(thisDataPoint)
        Angle += 1
    End Sub


    Sub LoadWorkProcess()

        Dim command As SqlCommand
        command = New SqlCommand("[tmspCekTrafficDatabase]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

      


        If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
        command.Connection = KoneksiIvend
        KoneksiIvend.Open()

        Try
            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvListProses.DataSource = table
            dgvListProses.DataSource = table
            dgvListProses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvListProses.AutoResizeColumns()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub




End Class