Imports System.Data.SqlClient
Public Class FormFragmentationStatus



    Sub LoadFragmentatonSTatusTop()

        Try
            strNamaDatabase2 = frmMonitoring.cmbListDB.Text

            Dim strQuery As String
            strQuery = "SELECT Top " & txtTop.Text & "* FROM dbo.V_StatusFragmentasi WHERE Recommendation<>'Nothing'"

            KoneksiDatabase5()
            Dim cmd As New SqlCommand(strQuery, Koneksi5)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable

            adapter.Fill(table)

            dgvStatusFragmentasi.DataSource = table
            'aturDGSAP()
            dgvStatusFragmentasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvStatusFragmentasi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvStatusFragmentasi.AutoResizeColumns()
            Koneksi5.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try



    End Sub



    Sub LoadFragmentatonSTatusAll()


        Try

            strNamaDatabase2 = frmMonitoring.cmbListDB.Text


            KoneksiDatabase5()
            Dim cmd As New SqlCommand("SELECT * FROM dbo.V_StatusFragmentasi WHERE Recommendation<>'Nothing'", Koneksi5)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable


            adapter.Fill(table)

            dgvStatusFragmentasi.DataSource = table
            'aturDGSAP()
            dgvStatusFragmentasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvStatusFragmentasi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvStatusFragmentasi.AutoResizeColumns()
            Koneksi5.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        



       


    End Sub




    Private Sub cmdProses_Click(sender As Object, e As EventArgs) Handles cmdProses.Click


        strNamaDatabase2 = frmMonitoring.cmbListDB.Text


        If txtTop.Text = "" Then
            If (MsgBox("Anda Yakin akan Me Load Semua Data?, Mohon Gunakan dengan Bijak", vbYesNo, "Bijaklah!")) = vbYes Then
                Call LoadFragmentatonSTatusAll()
            Else
                Exit Sub
            End If
        Else
            Call LoadFragmentatonSTatusTop()
        End If
    End Sub


End Class