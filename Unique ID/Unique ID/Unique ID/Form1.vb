Imports System.Globalization
Imports System.Net

Public Class Form1



    Public Shared Function GetUTC()
        ' connect to google servers
        ' you could use some SNTP time servers but can't be sure port will be open
        ' or you could just ping your own webserver
        Dim myNetRequest As WebRequest = HttpWebRequest.Create("http://www.example.com")
        ' read response header from connection
        Dim response = myNetRequest.GetResponse()
        ' read date/time header
        ' assume its UTC format
        Dim GlobalUTC As String = response.Headers("date").ToString
        ' convert string to datetime object
        Dim parsedDateTime As DateTime = DateTime.Parse(GlobalUTC)
        ' get UNIX time stamp
        Dim unixTime = (parsedDateTime - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Return unixTime
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim id As String = Guid.NewGuid().ToString("N")

        'TextBox1.Text = id


        Dim utc As String = GetUTC()
        ' add random alpha prefix to UNIX time stamp
        Dim sPrefix As String = ""
        Dim rdm As New Random()
        For i As Integer = 1 To 3 ' if you need more than 3 alpah random charachters adjust i length
            sPrefix &= ChrW(rdm.Next(65, 90))
        Next

        TextBox1.Text = sPrefix & utc
        'MsgBox(sPrefix & utc) ' OR MsgBox("ID" & sPrefix & utc)
        ' code here to use result


    End Sub
End Class
