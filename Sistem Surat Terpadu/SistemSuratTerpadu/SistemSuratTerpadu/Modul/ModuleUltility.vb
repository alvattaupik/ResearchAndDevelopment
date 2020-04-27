Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleUltility

    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

    End Sub


    Sub GetKontrolObjek()
        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat001' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratJalan = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If

        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat002' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratTerima = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If

        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat003' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratTugas = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If

        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Surat004' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuSuratPengajuanBiaya = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If




        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='BA001' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuBAPPenyelesaian = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If




        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='BA002' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuBAPSerahTerima = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If


        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req001' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormValidasi = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If


        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req002' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormCancelDanClose = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If


        strSQlLogin = "Select top 1 StatusEnabled From V_ObjectUserAplikasi WHERE KodeObject='Req003' AND KodePegawai ='" & Trim(GlobalstrKodeUser) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrMenuFormOpenDanClose = dr.GetString(0)
            dr.Close()
        Else
            dr.Close()
            Exit Sub
        End If



        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub


End Module
