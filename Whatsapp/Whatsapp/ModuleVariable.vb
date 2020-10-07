Imports System.Data.Sql
Imports System.Data.SqlClient
Module ModuleVariable

    Public Koneksi As SqlConnection
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public strKoneksiSQLSRV As String
    Public KoneksiSQLSRV As SqlConnection
    Public bolStatusKoneksiSQLServer As Boolean

    Public MdblDurasiDetikTimerNotifikasi As Long
    Public LongDurasi As Long



    Public MstrDelay1 As String
    Public MstrDelay2 As String



    Public strNamaServerCheck As String
    Public strNamaDatabaseCheck As String
    Public strUserNameCheck As String
    Public strPasswordCheck As String


    Public strNamaUser As String
    Public strKodePegawai As String
    Public MstrSQl As String



    Public bolStatusKoneksi As Boolean

    Public GlobalNoRM As String
    Public GlobalNoPendaftaran As String
    Public GlobalNamaForm As String
    Public GlobalKodeRuangan As String
    Public GlobalKodePetugasKesehatan As String
    Public GlobalJenisPasien As String


    Public MstrWorkingHour As String
    Public MstrWorkingHourValue1 As String
    Public MstrWorkingHourValue2 As String

    Public MstrNotifikasiBackup As String
    Public MstrNotifikasiBackupValue1 As String
    Public MstrNotifikasiBackupValue2 As String

    Public MstrNotifikasiIntegrasiBI As String
    Public MstrNotifikasiIntegrasiBIValue1 As String
    Public MstrNotifikasiIntegrasiBIValue2 As String

    Public MstrCustomCommand1 As String
    Public MstrCustomCommand1Value1 As String
    Public MstrCustomCommand1Value2 As String

    Public MstrCustomCommand2 As String
    Public MstrCustomCommand2Value1 As String
    Public MstrCustomCommand2Value2 As String

    Public MstrResendDeliveryGagal As String
    Public MstrResendDeliveryGagalValue1 As String
    Public MstrResendDeliveryGagalValue2 As String



End Module
