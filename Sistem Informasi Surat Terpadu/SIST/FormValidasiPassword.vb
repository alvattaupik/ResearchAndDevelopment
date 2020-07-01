Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormValidasiPassword

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then


            KoneksiDatabase1()
            Dim strSQlLogin As String

            strSQlLogin = "SELECT * From UserLogin WHERE KodePegawai='" & Trim(MstrKodeUser) & "' AND PasswordLogin ='" & Trim(txtPassword.Text) & "'"
            cmd = New SqlCommand(strSQlLogin, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then


                If MstrJenisDokumen = "IT003" Then
                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    FormApprovalDetaiMyRequestValidasi.AUD_Approval()
                    FormApprovalDetaiMyRequestValidasi.LoadDaftarUserValidasi()
                    FormApprovalDetaiMyRequestValidasi.LoadDetailValidasi()
                    FormMonitoringApprovalUserRequest.LoadDaftarApprovalActive()
                    Me.Dispose()
                    dr.Close()
                End If

                If MstrJenisDokumen = "IT004" Then
                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    FormApprovalDetaiMyRequestCloseCancelDocument.AUD_Approval()
                    FormApprovalDetaiMyRequestCloseCancelDocument.LoadDetailValidasi()
                    FormApprovalDetaiMyRequestCloseCancelDocument.LoadDaftarUserValidasi()
                    FormMonitoringApprovalUserRequest.LoadDaftarApprovalActive()
                    Me.Dispose()
                    dr.Close()
                End If


                If MstrJenisDokumen = "IT005" Then
                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.AUD_Approval()
                    FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.LoadDetailValidasi()
                    FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.LoadDaftarUserValidasi()
                    FormMonitoringApprovalUserRequest.LoadDaftarApprovalActive()
                    Me.Dispose()
                    dr.Close()
                End If


            Else

                MsgBox("Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
                dr.Close()
                Exit Sub
            End If
            Exit Sub

        End If

        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


End Class