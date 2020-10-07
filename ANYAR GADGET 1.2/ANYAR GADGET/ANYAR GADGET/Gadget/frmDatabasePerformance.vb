Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Sockets
Public Class frmDatabasePerformance

    Dim strServerNameLoc As String
    Dim strDatabaseNameLoc As String
    Dim strUsernameLoginLoc As String
    Dim strPasswordLoginLoc As String


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
    Private Sub frmReplicationMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        Call LoadDataGrid(dgvListKontrolForm, "SELECT KodeForm,KodeDetail,StatusEnabled FROM dbo.FormUser1 Where UsernameLogin='" & MstrUsernameLogin & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'", KoneksiDBEmail)
        LoadObjectForm(dgvListKontrolForm)

        If cmbLocation.Enabled = False Then
            cmbLocation.ValueMember = MstrSITEID
            cmbLocation.Text = MstrNamaCabang
        End If

        If cmbLocation.Enabled = False Then
            cmbLocation.ValueMember = MstrSITEID
            cmbLocation.Text = MstrNamaCabang
        End If

        txtIsiPesan.Text = "Membantu Memberikan gambaran terhadap performa Database Store, sehingga dapat diketahui dan diselidiki lebih lanjut, mengenai faktor yang menurunkan performa database"

    End Sub



    Sub LoadObjectForm(dgv As DataGridView)

        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = "frmReplicationMonitoring" And dgv.Rows(i).Cells(1).Value = "cmbLocationReplication" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.cmbLocation.Enabled = True
            ElseIf dgv.Rows(i).Cells(0).Value = "frmReplicationMonitoring" And dgv.Rows(i).Cells(1).Value = "cmbListCabangKeIvend" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.cmbLocation.Enabled = True
            End If
        Next

    End Sub


    Sub GetParameterKoneksi()
        If cmbLocation.Enabled = False Then
            Try
                Call KoneksiDB_EMAIL()
                Dim strSQL As String

                strSQL = "SELECT top 1 IPAddress,UsernameLogin,PasswordLogin,DatabaseName FROM dbo.OServers" & _
                         " LEFT OUTER JOIN dbo.V_ListSiteIDIvend ON V_ListSiteIDIvend.id=KodeCabang" & _
                         " WHERE dbo.OServers.Ket='Server Store' AND dbo.OServers.KodeCabang='" & MstrKodeDivisi & "'"
                cmd = New SqlCommand(strSQL, KoneksiDBEmail)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    strServerNameLoc = dr.GetString(0)
                    strUsernameLoginLoc = dr.GetString(1)
                    strPasswordLoginLoc = dr.GetString(2)
                    strDatabaseNameLoc = dr.GetString(3)

                    txtServerName.Text = strServerNameLoc
                    txtUsernameLogin.Text = strUsernameLoginLoc
                    txtPasswordlogin.Text = strPasswordLoginLoc
                    txtDatabaseName.Text = strDatabaseNameLoc
                    tmrPerformance.Enabled = True
                Else
                    DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                    tmrPerformance.Enabled = False
                    Exit Sub
                End If
            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                tmrPerformance.Enabled = False
            End Try
        Else
            Try
                Call KoneksiDB_EMAIL()
                Dim strSQL As String

                strSQL = "SELECT top 1 IPAddress,UsernameLogin,PasswordLogin,DatabaseName FROM dbo.OServers" & _
                         " LEFT OUTER JOIN dbo.V_ListSiteIDIvend ON V_ListSiteIDIvend.id=KodeCabang" & _
                         " WHERE dbo.OServers.Ket='Server Store' AND dbo.OServers.KodeCabang='" & cmbLocation.SelectedValue & "'"
                cmd = New SqlCommand(strSQL, KoneksiDBEmail)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    strServerNameLoc = dr.GetString(0)
                    strUsernameLoginLoc = dr.GetString(1)
                    strPasswordLoginLoc = dr.GetString(2)
                    strDatabaseNameLoc = dr.GetString(3)

                    txtServerName.Text = strServerNameLoc
                    txtUsernameLogin.Text = strUsernameLoginLoc
                    txtPasswordlogin.Text = strPasswordLoginLoc
                    txtDatabaseName.Text = strDatabaseNameLoc
                    tmrPerformance.Enabled = True
                Else
                    DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                    tmrPerformance.Enabled = False
                    Exit Sub
                End If
            Catch ex As Exception
                DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                tmrPerformance.Enabled = False
            End Try
        End If

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Call GetParameterKoneksi()
        cmbLocation.Enabled = False
    End Sub

    Private Sub tmrPerformance_Tick(sender As Object, e As EventArgs) Handles tmrPerformance.Tick

        Try
            Call Koneksi_CABANG(strServerNameLoc, strDatabaseNameLoc, strUsernameLoginLoc, strPasswordLoginLoc)
            Call LoadDataGrid(dgvListProses, "SELECT status,wait_type FROM dbo.V_MonitoringTraffic", KoneksiCabang)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
            tmrPerformance.Enabled = False
        End Try

        GetDataPoint()
        ChartPerforma.Series.Clear()
        ChartPerforma.Series.Add("Line Type")
        ChartPerforma.Series(0).IsVisibleInLegend = False
        ChartPerforma.Series(0).Color = Color.Red
        ChartPerforma.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line

        'ChartPerforma.Series(0).

        ChartPerforma.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        ChartPerforma.ChartAreas(0).AxisY.MajorGrid.Enabled = False

        'ChartPerforma.ChartAreas(0).AxisX.Minimum = ChartDataList(0).x
        'ChartPerforma.ChartAreas(0).AxisX.Maximum = ChartPerforma.ChartAreas(0).AxisX.Minimum + 360


        For i = 0 To ChartDataList.Count - 1
            ChartPerforma.Series(0).Points.AddXY(ChartDataList(i).x, ChartDataList(i).y)
        Next


    End Sub


    Private Sub GetDataPoint()

        If ChartDataList.Count > 17 Then
            ChartDataList.Remove(ChartDataList(0))
        End If
        Dim thisDataPoint As DataPointType
        'thisDataPoint.x = Angle
        thisDataPoint.x = Angle
        thisDataPoint.y = dgvListProses.Rows.Count 'BebanKerja
        ChartDataList.Add(thisDataPoint)
        Angle += 1

    End Sub




    Private Sub cmbLocation_Click(sender As Object, e As EventArgs) Handles cmbLocation.Click
        Try
            Dim strSQLLocation As String = "SELECT id,Nama FROM V_ListSiteIDIvend Where id In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "
            Call KoneksiDB_EMAIL()
            LoadComboBox(cmbLocation, strSQLLocation, "id", "Nama", KoneksiDBEmail)

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub



    Private Sub btnStopProses_Click(sender As Object, e As EventArgs) Handles btnStopProses.Click
        tmrPerformance.Enabled = False
        cmbLocation.Enabled = True
    End Sub


End Class