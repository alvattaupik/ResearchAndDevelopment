Module ModUltility
    Public Sub GetEmailSetting()
        strSMTP = My.Settings.SMTPName
        strHost = My.Settings.HostName
        strPort = My.Settings.PortName
        strSSL = My.Settings.SSLStatus
        strAuthenticate = My.Settings.AuthenticateStatus
        strUsernameEmail = My.Settings.UsernameEmail
        strPasswordEmail = My.Settings.PasswordEmail
        strPenerima = My.Settings.Penerima
        strSender = My.Settings.Sender

        strCC = My.Settings.CC
        strSubject = My.Settings.Subject
        strBody = My.Settings.Body
        strFooter = My.Settings.Footer
        strHeader = My.Settings.Header


    End Sub



    Public Sub GetAppandbehaviourSetting()
        strLokasiDatabaseUtama = My.Settings.IPDBUtama
        strLokasiDBEmail = My.Settings.IPDBEmail


        strNamaDatabaseUtama = My.Settings.NamaDBUtama
        strPasswordDatabaseUtama = My.Settings.PasswordDBUtama
        strUsernameDatabaseUtama = My.Settings.UsernameDBUtama

        strNamaDatabaseEmail = My.Settings.NamaDBEmail
        strusernameDatabaseEmail = My.Settings.UsernameDBEmail
        strPassswordDatabaseEmail = My.Settings.PasswordDBEmail

        strLokasiExport = My.Settings.LokasiExport
        strDurasiDelay = My.Settings.DelayTime
        strTestMode = My.Settings.TestMode



    End Sub



    Public Function GetTime(Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '

        'Seconds'
        Sec = Time Mod 60

        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function


End Module
