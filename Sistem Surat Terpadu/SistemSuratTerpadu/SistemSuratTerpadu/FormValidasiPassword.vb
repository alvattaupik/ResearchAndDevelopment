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

            strSQlLogin = "SELECT * From UserLogin WHERE KodePegawai='" & Trim(GlobalstrKodeUser) & "' AND PasswordLogin ='" & Trim(txtPassword.Text) & "'"
            cmd = New SqlCommand(strSQlLogin, Koneksi1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then

                If MstrNamaForm = "Detail Approval" Then

                    GlobalstrKodeUser = dr.GetString(0)
                    GlobalstrPassword = dr.GetString(3)
                    FormDetailApproval.AUD_Approval()
                    FormDetailApproval.LoadDaftarUserValidasi()
                    FormManagementApproval.LoadDaftarRequestValidasiALL()
                    FormManagementApproval.LoadDaftarRequestValidasiBelumApproved()

                    Me.Dispose()
                    dr.Close()
                End If



                If MstrNamaForm = "Proses Request" Then

                    GlobalstrKodeUser = dr.GetString(0)
                    GlobalstrPassword = dr.GetString(3)
                    ProsesRequest.AUD_Approval()
                    ProsesRequest.LoadDaftarUserValidasi()

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