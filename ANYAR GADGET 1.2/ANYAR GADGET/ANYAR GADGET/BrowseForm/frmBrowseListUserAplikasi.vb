Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmBrowseListUserAplikasi




    Private Sub frmBrowseListUserAplikasi_Load(sender As Object, e As EventArgs) Handles Me.Load

        dgvListUserAplikasi.DataSource = Nothing
        dgvListUserAplikasi.Rows.Clear()
        dgvListUserAplikasi.Columns.Clear()
        Dim strQuery2 As String = "SELECT UsernameLogin,NamaPegawai,Pilih FROM V_ListUserAplikasi WHERE KodeAplikasi='" & MstrKodeAplikasi & "' AND Usernamelogin <>'" & MstrTempUsernameLogin & "'"
        Call KoneksiDB_EMAIL()

        Try
            cmd = New SqlCommand(strQuery2, KoneksiDBEmail)
            cmd.CommandTimeout = 0
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)

            dgvListUserAplikasi.Columns.Add("UsernameLogin", "UsernameLogin")
            dgvListUserAplikasi.Columns.Add("NamaPegawai", "NamaPegawai")
            Dim chk As New DataGridViewCheckBoxColumn()
            dgvListUserAplikasi.Columns.Add(chk)
            chk.HeaderText = "Pilih"
            chk.Name = "Pilih"

            chk.TrueValue = "Y"
            chk.FalseValue = "N"

            dgvListUserAplikasi.Columns(0).ReadOnly = True
            dgvListUserAplikasi.Columns(1).ReadOnly = True
            dgvListUserAplikasi.Columns(2).ReadOnly = False

            If table.Rows.Count = 0 Then Exit Sub


            With table
                For i = 0 To table.Rows.Count - 1
                    dgvListUserAplikasi.Rows.Add(.Rows(i).Item(0).ToString(), .Rows(i).Item(1).ToString(), .Rows(i).Item(2).ToString())
                Next


            End With


            Exit Sub

        Catch ex As Exception
            MessageBox.Show("Kesalahan memuat datagrid !: ( " & strQuery2 & ")")
        End Try



    End Sub


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Try
            If MstrFungsiContextMenu = "ALL" Then
                Call AUDRS_CopyToUser("CopyAllToAnotherUsers")
            End If

            If MstrFungsiContextMenu = "HEADER" Then
                Call AUDRS_CopyToUser("CopyHeaderMenuToAnotherUsers")
            End If

            If MstrFungsiContextMenu = "DETAIL" Then
                Call AUDRS_CopyToUser("CopyDetailMenuToAnotherUsers")
            End If

            If MstrFungsiContextMenu = "FORM" Then
                Call AUDRS_CopyToUser("CopyDetailFormToAnotherUsers")
            End If


            If MstrFungsiContextMenu = "LOCATION" Then
                Call AUDRS_CopyToUser("CopyLocationControlToAnotherUsers")
            End If

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try
          
    End Sub

    Sub AUDRS_CopyToUser(strFunction As String)

        For i As Integer = 0 To dgvListUserAplikasi.Rows.Count - 1

            If dgvListUserAplikasi.Rows(i).Cells(2).Value = "Y" Then
                KoneksiDB_EMAIL()
                Dim command As SqlCommand
                command = New SqlCommand("[tmsp_AUD_MenuAplikasi]", KoneksiDBEmail)
                Dim adapter As New SqlDataAdapter(command)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("KodeHeader", Trim(""))
                command.Parameters.AddWithValue("KodeDetail", Trim(""))
                command.Parameters.AddWithValue("StatusEnabled", Trim(""))
                command.Parameters.AddWithValue("UsernameLogin", Trim(MstrUsernameCopy))
                command.Parameters.AddWithValue("KodeAplikasi", Trim(MstrKodeAplikasi))
                command.Parameters.AddWithValue("KodeUsernameLoginTujuan", Trim(dgvListUserAplikasi.Rows(i).Cells(0).Value))
                command.Parameters.AddWithValue("Function", Trim(strFunction))

                If (KoneksiDBEmail.State = ConnectionState.Open) Then KoneksiDBEmail.Close()
                command.Connection = KoneksiDBEmail
                KoneksiDBEmail.Open()
                command.ExecuteNonQuery()
            End If

           

        Next

        DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)



    End Sub


End Class