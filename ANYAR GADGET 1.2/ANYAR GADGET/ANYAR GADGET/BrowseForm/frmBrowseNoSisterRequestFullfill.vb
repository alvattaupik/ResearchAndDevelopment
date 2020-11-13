Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmBrowseNoSisterRequestFullfill

    Public cryRpt As New ReportDocument
    Public crtableLogoninfos As New TableLogOnInfos
    Public crtableLogoninfo As New TableLogOnInfo
    Public crConnectionInfo As New ConnectionInfo
    Public CrTables As Tables
    Public CrTable As Table
    Public RptDocument As New ReportDocument
    Public reportDocument As New ReportDocument()
    Public paramField As New ParameterField()
    Public paramFields As New ParameterFields()
    Public paramDiscreteValue As New ParameterDiscreteValue()
    Public paramField2 As New ParameterField()
    Public paramFields2 As New ParameterFields()
    Public paramDiscreteValue2 As New ParameterDiscreteValue()

    Public paramField3 As New ParameterField()
    Public paramFields3 As New ParameterFields()
    Public paramDiscreteValue3 As New ParameterDiscreteValue()


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Dim Tombol As Integer = Asc(e.KeyChar)
        Try
            Dim strQuery As String = "SELECT Top 15 CANCELED,NomorSurat,EmpName AS DibuatOleh,CAST(TanggalSurat AS DATE) AS TglSurat FROM dbo.KopSurat " & _
                                     " WHERE KdJenisSurat='IT008' and (NomorSurat Like '%" & Trim(txtCari.Text) & "%' OR EmpName Like '%" & Trim(txtCari.Text) & "%')  ORDER BY TanggalSurat DESC"

            If Tombol = 13 Then
                Call KoneksiDB_EMAIL()
                LoadDataGrid(dgvListNomorSurat, strQuery, KoneksiDBEmail)

            End If
        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
    End Sub


    Private Sub dgvListNomorSurat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListNomorSurat.CellContentClick
        On Error Resume Next
        frmListLokasiValidasi.txtRefNumber.Text = dgvListNomorSurat.Rows(e.RowIndex).Cells(1).Value()
        Me.Dispose()
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        If dgvListNomorSurat.RowCount = 0 Then Exit Sub

        paramField.Name = "NomorSurat@"
        paramDiscreteValue.Value = (Trim(dgvListNomorSurat.Item(1, dgvListNomorSurat.CurrentRow.Index).Value))
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        paramField2.Name = "KodeJenisSurat@"
        paramDiscreteValue2.Value = Trim("IT008")
        paramField2.CurrentValues.Add(paramDiscreteValue2)
        paramFields.Add(paramField2)

        paramField3.Name = "EmpIDPrint@"
        paramDiscreteValue3.Value = Trim(MstrKodePegawai)
        paramField3.CurrentValues.Add(paramDiscreteValue3)
        paramFields.Add(paramField3)



        Dim frm As New frmTampilkanSurat
        frm.crvTampilkanSurat.ParameterFieldInfo = paramFields
        reportDocument = New RequestFullfillment
        reportDocument.SetDatabaseLogon("sa", "h0spit4lity#", "10.1.0.53", "DB_EMAIL")

        frm.crvTampilkanSurat.ReportSource = reportDocument
        frm.crvTampilkanSurat.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        frm.crvTampilkanSurat.Refresh()
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub frmBrowseNoSisterRequestFullfill_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strQuery As String = "SELECT Top 15 CANCELED,NomorSurat,EmpName AS DibuatOleh,CAST(TanggalSurat AS DATE) AS TglSurat FROM dbo.KopSurat " & _
                                     " WHERE KdJenisSurat='IT008' and (NomorSurat Like '%" & Trim(txtCari.Text) & "%' OR EmpName Like '%" & Trim(txtCari.Text) & "%')  ORDER BY TanggalSurat DESC"
        Call KoneksiDB_EMAIL()
        LoadDataGrid(dgvListNomorSurat, strQuery, KoneksiDBEmail)

    End Sub
End Class