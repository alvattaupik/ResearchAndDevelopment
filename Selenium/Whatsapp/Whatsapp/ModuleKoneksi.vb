Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleKoneksi

    Dim strServer As String
    Dim strNamaDatabase As String
    Dim strUserNameDB As String
    Dim strPasswordDB As String

    Dim strKoneksi As String



    Public Sub KoneksiDatabase()

        strServer = "10.1.0.53"
        strNamaDatabase = "RKM_TRAINING"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"


        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Public Sub KoneksiDBEmail()

        strServer = "10.1.0.53"
        strNamaDatabase = "DB_EMAIL"
        strUserNameDB = "sa"
        strPasswordDB = "h0spit4lity#"


        strKoneksi = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub












    Public Sub CekKoneksiDatabase()



        strKoneksi = "data source=" & strNamaServerCheck & ";user id=" & strUserNameCheck & ";password=" & strPasswordCheck & ";initial catalog=" & strNamaDatabaseCheck & ";MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
                MsgBox("Koneksi Terhubung", vbInformation, "Sukses")
                bolStatusKoneksi = True
                Exit Sub
            End If
        Catch ex As Exception
            bolStatusKoneksi = False
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub


    Public Sub FnTimerNotifikasi(intDurasi As Integer, strSatuan As String)


        If My.Settings.SatuanInterval = "Jam" Then
            MdblDurasiDetikTimerNotifikasi = intDurasi * 3600
            LongDurasi = MdblDurasiDetikTimerNotifikasi
        Else
            MdblDurasiDetikTimerNotifikasi = intDurasi * 60
            LongDurasi = MdblDurasiDetikTimerNotifikasi
        End If
    End Sub





    Public Sub CekKoneksiDatabaseLogin()

        'strServer = "10.1.1.132"
        'strNamaDatabase = "IClinic"
        'strUserNameDB = "sa"
        'strPasswordDB = "data1234"


        strKoneksi = "data source=" & strNamaServerCheck & ";user id=" & strUserNameCheck & ";password=" & strPasswordCheck & ";initial catalog=" & strNamaDatabaseCheck & ";MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strNamaServerCheck, strUserNameCheck, strPasswordCheck, strNamaDatabaseCheck)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
                'MsgBox("Koneksi Terhubung", vbInformation, "Sukses")
                bolStatusKoneksi = True
                Exit Sub
            End If
        Catch ex As Exception
            bolStatusKoneksi = False
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub





    Public Sub testKoneksiSQLSERVER()

        strServer = FormSetting.txtServerName.Text
        strUserNameDB = FormSetting.txtUsername.Text
        strPasswordDB = FormSetting.txtPassword.Text
        strNamaDatabase = FormSetting.txtDabataseName.Text


        strKoneksiSQLSRV = "data source=" & strServer & ";user id=" & strUserNameDB & ";password=" & strPasswordDB & ";initial catalog=" & strNamaDatabase & ";MultipleActiveResultSets=True;Application Name=WDB V1.0;  "
        strKoneksiSQLSRV = String.Format(strKoneksiSQLSRV, strServer, strUserNameDB, strPasswordDB, strNamaDatabase)
        KoneksiSQLSRV = New SqlConnection(strKoneksiSQLSRV)



        Try
            If KoneksiSQLSRV.State = ConnectionState.Closed Then
                KoneksiSQLSRV.Open()
                bolStatusKoneksiSQLServer = True
            End If
        Catch ex As Exception
            bolStatusKoneksiSQLServer = False
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub









End Module
