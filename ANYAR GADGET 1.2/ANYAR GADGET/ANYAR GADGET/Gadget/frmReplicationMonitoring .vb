Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets
Public Class frmReplicationMonitoring

    Dim strServerNameLoc As String
    Dim strDatabaseNameLoc As String
    Dim strUsernameLoginLoc As String
    Dim strPasswordLoginLoc As String

    Private Sub cmbLocation_Click(sender As Object, e As EventArgs)
        Try
            Dim strSQLSiteId As String = "Select SiteID,Nama From V_ListSiteIDIvend Where SiteID In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "

            Call KoneksiDB_EMAIL()
            LoadComboBox(cmbLocationReplication, strSQLSiteId, "SiteID", "Nama", KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub




    Sub LoadReplicationMonitorFromIvendToSAP()
        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[tmspCekReplicationMonitor]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        If cmbLocationReplication.Enabled = False Then
            command.Parameters.AddWithValue("pDestinationSiteID", MstrSITEID)

        Else
            command.Parameters.AddWithValue("pDestinationSiteID", cmbLocationReplication.SelectedValue)
        End If

        command.Parameters.Add("pOutRecordCount", SqlDbType.VarChar, 100)
        command.Parameters("pOutRecordCount").Direction = ParameterDirection.Output



        If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
        command.Connection = KoneksiIvend
        KoneksiIvend.Open()

        Try
            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvReplikasiIvendToSAP.DataSource = table
            dgvReplikasiIvendToSAP.DataSource = table
            dgvReplikasiIvendToSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvReplikasiIvendToSAP.AutoResizeColumns()
            dgvReplikasiIvendToSAP.RowHeadersVisible = False
            lblRecordsFromIvendToBranch.Text = "Data Dari Ivend Pusat Ke SAP : " & command.Parameters("pOutRecordCount").Value.ToString()

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
       

    End Sub


    Private Sub btnProsesReplikasiPusat_Click(sender As Object, e As EventArgs) Handles btnProsesReplikasiPusat.Click
        Try


            If cmbLocationReplication.Text = "" Then
                DisplayPesanError("Site Destinantion ID Tidak Ada", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If
            LoadReplicationMonitorFromIvendToSAP()
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub

    Private Sub frmReplicationMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        Call LoadDataGrid(dgvListKontrolForm, "SELECT KodeForm,KodeDetail,StatusEnabled FROM dbo.FormUser1 Where UsernameLogin='" & MstrUsernameLogin & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'", KoneksiDBEmail)
        LoadObjectForm(dgvListKontrolForm)

        If cmbListCabangKeIvend.Enabled = False Then
            cmbListCabangKeIvend.ValueMember = MstrSITEID
            cmbListCabangKeIvend.Text = MstrNamaCabang
        End If

        If cmbLocationReplication.Enabled = False Then
            cmbLocationReplication.ValueMember = MstrSITEID
            cmbLocationReplication.Text = MstrNamaCabang
        End If

    End Sub



    Sub LoadObjectForm(dgv As DataGridView)

        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = "frmReplicationMonitoring" And dgv.Rows(i).Cells(1).Value = "cmbLocationReplication" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.cmbLocationReplication.Enabled = True
            ElseIf dgv.Rows(i).Cells(0).Value = "frmReplicationMonitoring" And dgv.Rows(i).Cells(1).Value = "cmbListCabangKeIvend" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.cmbListCabangKeIvend.Enabled = True
            End If
        Next


    End Sub


    Private Sub cmbLocationReplication_Click(sender As Object, e As EventArgs) Handles cmbLocationReplication.Click
        Try


            Dim strSQLSiteId As String = "Select SiteID,Nama From V_ListSiteIDIvend Where SiteID In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "

            Call KoneksiDB_EMAIL()
            LoadComboBox(cmbLocationReplication, strSQLSiteId, "SiteID", "Nama", KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub cmbListCabangKeIvend_Click(sender As Object, e As EventArgs) Handles cmbListCabangKeIvend.Click
        Try


            Dim strSQLSiteId As String = "Select SiteID,Nama From V_ListSiteIDIvend Where SiteID In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "

            Call KoneksiDB_EMAIL()
            LoadComboBox(cmbListCabangKeIvend, strSQLSiteId, "SiteID", "Nama", KoneksiDBEmail)
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub



    Sub LoadReplicationMonitorStoreToIvend()
        Try
            Call Koneksi_CABANG(strServerNameLoc, strDatabaseNameLoc, strUsernameLoginLoc, strPasswordLoginLoc)
            Dim command As SqlCommand
            command = New SqlCommand("[tmspReplicationRecordsToSendCabangToIvend]", KoneksiCabang)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure

            If (KoneksiCabang.State = ConnectionState.Open) Then KoneksiCabang.Close()
            command.Connection = KoneksiCabang
            KoneksiCabang.Open()

            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvReplikasiIvendToSAP.DataSource = table
            dgvReplikasiIvendToSAP.DataSource = table
            dgvReplikasiIvendToSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvReplikasiIvendToSAP.AutoResizeColumns()
            dgvReplikasiIvendToSAP.RowHeadersVisible = False
            lblRecordsFromIvendToBranch.Text = "Data Dari Ivend Pusat : " & dgvReplikasiCabangkeIvend.Rows.Count


        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try




    End Sub





    Private Sub btnProsesReplikasiCabang_Click(sender As Object, e As EventArgs) Handles btnProsesReplikasiCabang.Click
        Try


            GetParameterKoneksi()
            Call Koneksi_CABANG(strServerNameLoc, strDatabaseNameLoc, strUsernameLoginLoc, strPasswordLoginLoc)

            If cmbListCabangKeIvend.Text = "" Then
                DisplayPesanError("Site Destinantion ID Tidak Ada", frmMainMenu.txtPesanError, 1000)
                Exit Sub
            End If
            LoadReplicationMonitorStoreToIvend()
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub



    Sub GetParameterKoneksi()
        If cmbListCabangKeIvend.Enabled = False Then
            Try
                Call KoneksiDB_EMAIL()
                Dim strSQL As String

                strSQL = "SELECT top 1 IPAddress,UsernameLogin,PasswordLogin,DatabaseName FROM dbo.OServers" & _
                         " LEFT OUTER JOIN dbo.V_ListSiteIDIvend ON V_ListSiteIDIvend.id=KodeCabang" & _
                         " WHERE dbo.OServers.Ket='Server Store' AND dbo.V_ListSiteIDIvend.SiteId='" & MstrSITEID & "'"
                cmd = New SqlCommand(strSQL, KoneksiDBEmail)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    strServerNameLoc = dr.GetString(0)
                    strUsernameLoginLoc = dr.GetString(1)
                    strPasswordLoginLoc = dr.GetString(2)
                    strDatabaseNameLoc = dr.GetString(3)
                Else
                    DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        Else
            Try
                Call KoneksiDB_EMAIL()
                Dim strSQL As String

                strSQL = "SELECT top 1 IPAddress,UsernameLogin,PasswordLogin,DatabaseName FROM dbo.OServers" & _
                         " LEFT OUTER JOIN dbo.V_ListSiteIDIvend ON V_ListSiteIDIvend.id=KodeCabang" & _
                         " WHERE dbo.OServers.Ket='Server Store' AND dbo.V_ListSiteIDIvend.SiteId='" & cmbListCabangKeIvend.SelectedValue & "'"
                cmd = New SqlCommand(strSQL, KoneksiDBEmail)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    strServerNameLoc = dr.GetString(0)
                    strUsernameLoginLoc = dr.GetString(1)
                    strPasswordLoginLoc = dr.GetString(2)
                    strDatabaseNameLoc = dr.GetString(3)
                Else
                    DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
                    Exit Sub
                End If
            Catch ex As Exception

            End Try
        End If

        
    End Sub




End Class