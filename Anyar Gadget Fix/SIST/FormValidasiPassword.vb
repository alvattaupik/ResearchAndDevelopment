﻿Imports System.IO
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

                If MstrJenisDokumen = "FORM VALIDASI" Then
                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    'FormApprovalDetaiMyRequest.AUD_Approval()
                    'FormApprovalDetaiMyRequest.LoadDaftarUserValidasi()
                    FormMonitoringUserRequest.BelumDiproses()

                    Me.Dispose()
                    dr.Close()
                End If



                If MstrJenisDokumen = "FORM CLOSE AND CANCEL DOCUMENTS" Then

                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    'FormApprovalDetaiMyRequestCloseCancelDocument.AUD_Approval()
                    'FormApprovalDetaiMyRequestCloseCancelDocument.LoadDaftarUserValidasi()
                    FormMonitoringUserRequest.BelumDiproses()
                    Me.Dispose()
                    dr.Close()
                End If






                If MstrJenisDokumen = "FORM CLOSE AND OPEN POSTING PERIODE" Then

                    MstrKodeUser = dr.GetString(0)
                    MstrPassword = dr.GetString(3)
                    'FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.AUD_Approval()
                    'FormApprovalDetaiMyRequestCloseAndOpenPostingPeriode.LoadDaftarUserValidasi()
                    FormMonitoringUserRequest.BelumDiproses()
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