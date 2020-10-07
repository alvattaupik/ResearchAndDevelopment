Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormSetting

    Private Sub btnSimpanSetting_Click(sender As Object, e As EventArgs) Handles btnSimpanSetting.Click

        If txtInterval.Text = "" Then
            MsgBox("Durasi Interval Harus DI Isi", vbCritical, "Penting !")
            Exit Sub
        End If

        If cmbSatuanInterval.Text = "" Then
            MsgBox("Satuan Interval Harus DI Isi", vbCritical, "Penting !")
            Exit Sub
        End If




        With My.Settings

            .Server = txtServerName.Text
            .DatabaseName = txtDabataseName.Text
            .UserNameDB = txtUsername.Text
            .PasswordDB = txtPassword.Text

            .DurasiInterval = txtInterval.Text
            .Delay1 = txtDelay1.Text
            .Delay2 = txtDelay2.Text

            .SatuanInterval = cmbSatuanInterval.Text
            .Save()

            MsgBox("Konfigurasi Aplikasi Berhasil Disimpan", vbInformation, "Sukses!")

        End With

        MainDisplay.LoadDurasi()



    End Sub

    Private Sub btnKoneksiDatabase_Click(sender As Object, e As EventArgs) Handles btnKoneksiDatabase.Click
        Call testKoneksiSQLSERVER()


        If bolStatusKoneksiSQLServer = True Then

            With My.Settings

                .Server = txtServerName.Text
                .DatabaseName = txtDabataseName.Text
                .UserNameDB = txtUsername.Text
                .PasswordDB = txtPassword.Text

                .DurasiInterval = txtInterval.Text
                .Delay1 = txtDelay1.Text
                .Delay2 = txtDelay2.Text

                .SatuanInterval = cmbSatuanInterval.Text
                .Save()
                MsgBox("Konfigurasi Database Berhasil Disimpan", vbInformation, "Sukses!")
            End With

        Else

            MsgBox("Kesalahan Pada Parameter Setting Database", vbCritical, "Error!")
            Exit Sub

        End If

    End Sub

    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadDaftarSetting()


        txtServerName.Text = My.Settings.Server
        txtDabataseName.Text = My.Settings.DatabaseName
        txtUsername.Text = My.Settings.UserNameDB
        txtPassword.Text = My.Settings.PasswordDB


        txtInterval.Text = My.Settings.DurasiInterval
        cmbSatuanInterval.Text = My.Settings.SatuanInterval
        txtDelay1.Text = My.Settings.Delay1
        txtDelay2.Text = My.Settings.Delay2

    End Sub

    Sub LoadDaftarSetting()
        Try

            dgBehaviour.DataSource = Nothing
            dgBehaviour.Rows.Clear()
            dgBehaviour.Columns.Clear()

            KoneksiDatabase()
            Dim command As SqlCommand
            command = New SqlCommand("_tmspBehaviour", Koneksi)
            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@KodeSetting", "")
            command.Parameters.AddWithValue("@NamaSetting", "")
            command.Parameters.AddWithValue("@Satuan", "")
            command.Parameters.AddWithValue("@Value1", "")
            command.Parameters.AddWithValue("@Value2", "")
            command.Parameters.AddWithValue("@StatusEnabled", "")
            command.Parameters.AddWithValue("@StatusSP", "R")
            command.ExecuteNonQuery()

            Dim table As New DataTable
            adapter.Fill(table)


            Dim chk As New DataGridViewCheckBoxColumn()
            dgBehaviour.Columns.Add(chk)
            chk.HeaderText = "Aktif"
            chk.Name = "Aktif"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgBehaviour.Columns.Add("NamaSetting", "NamaSetting")
            dgBehaviour.Columns.Add("Start", "Start")
            dgBehaviour.Columns.Add("Finish", "Finish")
            dgBehaviour.Columns.Add("KodeSetting", "KodeSetting")


            With table
                For i = 0 To table.Rows.Count - 1

                    dgBehaviour.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString(), .Rows(i).Item(3).ToString(), .Rows(i).Item(4).ToString())
                    dgBehaviour.Columns(4).ReadOnly = True
                    dgBehaviour.Columns(1).ReadOnly = True

                Next

                dgBehaviour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgBehaviour.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgBehaviour.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                dgBehaviour.AutoResizeColumns()

            End With



        Catch ex As Exception
            MessageBox.Show(Err.Description)
            Exit Sub
        End Try

    End Sub

    Sub AU_Behaviour(strStatusSP As String)
        Try

            For i As Integer = 0 To dgBehaviour.Rows.Count - 1
                KoneksiDatabase()
                Dim command As SqlCommand
                command = New SqlCommand("_tmspBehaviour", Koneksi)

                Dim adapter As New SqlDataAdapter(command)
                command.CommandType = CommandType.StoredProcedure


                command.Parameters.AddWithValue("@KodeSetting", dgBehaviour.Rows(i).Cells("KodeSetting").Value)
                command.Parameters.AddWithValue("@NamaSetting", dgBehaviour.Rows(i).Cells("NamaSetting").Value)
                command.Parameters.AddWithValue("@Satuan", "")
                command.Parameters.AddWithValue("@Value1", dgBehaviour.Rows(i).Cells("Start").Value)
                command.Parameters.AddWithValue("@Value2", dgBehaviour.Rows(i).Cells("Finish").Value)
                command.Parameters.AddWithValue("@StatusEnabled", dgBehaviour.Rows(i).Cells("Aktif").Value)
                command.Parameters.AddWithValue("@StatusSP", strStatusSP)
                command.ExecuteNonQuery()

            Next
            LoadDaftarSetting()

        Catch ex As Exception

            MsgBox(Err.Description)
            Exit Sub

        End Try
    End Sub


    Private Sub cmdSimpanSetting_Click(sender As Object, e As EventArgs) Handles cmdSimpanSetting.Click
        Call AU_Behaviour("U")
        MsgBox("Parameter Berhasil DI Update", vbInformation, "Sukses!")
        MainDisplay.cmdLoad.PerformClick()
        Exit Sub
    End Sub

End Class