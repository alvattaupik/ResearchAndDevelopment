Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleUltility

    Sub GetSettingBehaviour()
        Call KoneksiDatabase()


        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='ACV-001'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrWorkingHour = dr.GetString(0)
            MstrWorkingHourValue1 = dr.GetString(1)
            MstrWorkingHourValue2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If



        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='BCK-001'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrNotifikasiBackup = dr.GetString(0)
            MstrNotifikasiBackupValue1 = dr.GetString(1)
            MstrNotifikasiBackupValue2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If



        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='BI-001'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrNotifikasiIntegrasiBI = dr.GetString(0)
            MstrNotifikasiIntegrasiBIValue1 = dr.GetString(1)
            MstrNotifikasiIntegrasiBIValue2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If


        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='CTM-001'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrCustomCommand1 = dr.GetString(0)
            MstrCustomCommand1Value1 = dr.GetString(1)
            MstrCustomCommand1Value2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If



        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='CTM-002'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrCustomCommand2 = dr.GetString(0)
            MstrCustomCommand2Value1 = dr.GetString(1)
            MstrCustomCommand2Value2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If



        MstrSQl = "SELECT StatusEnabled,FORMAT(Value1,'HH:mm') AS Start,FORMAT(Value2,'HH:mm')AS Finish FROM dbo.MasterSettingWABlast WHERE KodeSetting='RSN-001'"
        cmd = New SqlCommand(MstrSQl, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            MstrResendDeliveryGagal = dr.GetString(0)
            MstrResendDeliveryGagalValue1 = dr.GetString(1)
            MstrResendDeliveryGagalValue2 = dr.GetString(2)
            dr.Close()
        Else
            dr.Close()
        End If



        Exit Sub

ErrorLoad:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

End Module
