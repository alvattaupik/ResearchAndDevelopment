Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.Net.Sockets
Public Class frmIntegrationMonitoring

    Private Sub cmbLocation_Click(sender As Object, e As EventArgs) Handles cmbLocation.Click
        Dim strSQLSiteId As String = "Select SiteID,Nama From V_ListSiteIDIvend Where id In (SELECT KodeLocation FROM dbo.OLocControlUsers Where UsernameLogin='" & MstrUsernameLogin & "' AND StatusEnabled='Y' AND KodeAplikasi='" & MstrKodeAplikasi & "') "

        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbLocation, strSQLSiteId, "SiteID", "Nama", KoneksiDBEmail)
    End Sub
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        If cmbLocation.Text = "" And MstrNamaCabang <> "IT" Then
            DisplayPesanError("Site ID Tidak Ada", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If MstrNamaCabang <> "IT" Then
            LoadIntegrationMonitor()
        End If


        If MstrNamaCabang = "IT" Then
            LoadIntegrationMonitorALL()
        End If

    End Sub
    Sub LoadIntegrationMonitor()
        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[tmspCekIntegrationMonitor]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        If cmbLocation.Enabled = False Then
            command.Parameters.AddWithValue("@Cabang", MstrSITEID)

        Else
            command.Parameters.AddWithValue("@Cabang", cmbLocation.SelectedValue)
        End If

        Try

            If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
            command.Connection = KoneksiIvend
            KoneksiIvend.Open()
            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvListErrorIntegrasi.DataSource = table
            dgvListErrorIntegrasi.DataSource = table
            dgvListErrorIntegrasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvListErrorIntegrasi.AutoResizeColumns()
            dgvListErrorIntegrasi.RowHeadersVisible = False
            lblJumlahErrorIntegrasi.Text = "Jumlah Error Integrasi : " & dgvListErrorIntegrasi.RowCount

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
       

    End Sub



    Sub LoadIntegrationMonitorALL()
        Call Koneksi_IVEND()
        Dim command As SqlCommand
        command = New SqlCommand("[tmspCekIntegrationMonitor]", KoneksiIvend)
        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Cabang", MstrNamaCabang)


        Try

            If (KoneksiIvend.State = ConnectionState.Open) Then KoneksiIvend.Close()
            command.Connection = KoneksiIvend
            KoneksiIvend.Open()
            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgvListErrorIntegrasi.DataSource = table
            dgvListErrorIntegrasi.DataSource = table
            dgvListErrorIntegrasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvListErrorIntegrasi.AutoResizeColumns()
            dgvListErrorIntegrasi.RowHeadersVisible = False
            lblJumlahErrorIntegrasi.Text = "Jumlah Error Integrasi : " & dgvListErrorIntegrasi.RowCount

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try


    End Sub











    Private Sub frmIntegrationMonitoring_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call KoneksiDB_EMAIL()
        Call LoadDataGrid(dgvListFormObject, "SELECT KodeForm,KodeDetail,StatusEnabled FROM dbo.FormUser1 Where UsernameLogin='" & MstrUsernameLogin & "' AND KodeAplikasi='" & MstrKodeAplikasi & "'", KoneksiDBEmail)
        LoadObjectForm(dgvListFormObject)

        If cmbLocation.Enabled = False Then
            cmbLocation.ValueMember = MstrSITEID
            cmbLocation.Text = MstrNamaCabang
        End If


    End Sub
    Sub LoadObjectForm(dgv As DataGridView)

        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(0).Value = "frmIntegrationMonitoring" And dgv.Rows(i).Cells(1).Value = "cmbLocation" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.cmbLocation.Enabled = True
            ElseIf dgv.Rows(i).Cells(0).Value = "frmIntegrationMonitoring" And dgv.Rows(i).Cells(1).Value = "btnSubQueryErrorChecker" And dgv.Rows(i).Cells(2).Value = "Y" Then
                Me.btnSubQueryErrorChecker.Enabled = True
            End If

        Next


    End Sub


    Private Sub btnSubQueryErrorChecker_Click(sender As Object, e As EventArgs) Handles btnSubQueryErrorChecker.Click
        If dgvListErrorIntegrasi.Rows.Count = 0 Then Exit Sub

        frmSubQueryChecker.trxTransactionID.Text = dgvListErrorIntegrasi.Item(3, dgvListErrorIntegrasi.CurrentRow.Index).Value
        frmSubQueryChecker.trxTransactionKey.Text = dgvListErrorIntegrasi.Item(10, dgvListErrorIntegrasi.CurrentRow.Index).Value
        frmSubQueryChecker.txtNamaCustomer.Text = dgvListErrorIntegrasi.Item(6, dgvListErrorIntegrasi.CurrentRow.Index).Value
        frmSubQueryChecker.ShowDialog()
    End Sub


   

    Private Sub dgvListErrorIntegrasi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListErrorIntegrasi.CellContentClick
        If dgvListErrorIntegrasi.RowCount = 0 Then Exit Sub

        If dgvListErrorIntegrasi.Item(3, dgvListErrorIntegrasi.CurrentRow.Index).Value = "" Then Exit Sub

        DetailFailedItegration.txtIntegrationKey.Text = dgvListErrorIntegrasi.Item(2, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtIntegrationKey.ReadOnly = True
        DetailFailedItegration.txtNoStruk.Text = dgvListErrorIntegrasi.Item(3, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtNoStruk.ReadOnly = True
        DetailFailedItegration.txtKodeCust.Text = dgvListErrorIntegrasi.Item(5, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtKodeCust.ReadOnly = True
        DetailFailedItegration.txtNamaCust.Text = dgvListErrorIntegrasi.Item(6, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtCabang.Text = dgvListErrorIntegrasi.Item(4, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtNotifError.Text = dgvListErrorIntegrasi.Item(7, dgvListErrorIntegrasi.CurrentRow.Index).Value
        DetailFailedItegration.txtNotifError.ReadOnly = True
        MstrNoStruk = dgvListErrorIntegrasi.Item(3, dgvListErrorIntegrasi.CurrentRow.Index).Value

        LoadAlamatCustomer(dgvListErrorIntegrasi.Item(3, dgvListErrorIntegrasi.CurrentRow.Index).Value, dgvListErrorIntegrasi.Item(5, dgvListErrorIntegrasi.CurrentRow.Index).Value)


        DetailFailedItegration.ShowDialog()

    End Sub

    Sub LoadAlamatCustomer(strNoStruk As String, strKodeCustomer As String)
        On Error Resume Next
        Call Koneksi_IVEND()

        Dim strSQL As String = "SELECT top 1 AlamatCustomer,AlamatDelivery FROM dbo.V_CekFullfilments WHERE NoStruk='" & strNoStruk & "' AND KodeCustomer='" & strKodeCustomer & "'"
        cmd = New SqlCommand(strSQL, KoneksiIvend)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            DetailFailedItegration.txtAlamatCustomer.Text = dr.GetString(0)
            DetailFailedItegration.txtAlamatCustomer.ReadOnly = True

            DetailFailedItegration.txtAlamatFullfill.Text = dr.GetString(1)
            DetailFailedItegration.txtAlamatFullfill.ReadOnly = True


            dr.Close()
        Else

            dr.Close()
            Exit Sub
        End If


    End Sub



End Class