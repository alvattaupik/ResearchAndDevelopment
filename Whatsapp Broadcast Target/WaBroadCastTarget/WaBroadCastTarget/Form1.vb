Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

    Dim Driver As IWebDriver


    Private Function CekApakahSudahLogin() As Boolean
        Try

            Driver.FindElements(By.ClassName(" _2BPp"))
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Private Function CekNotifyBaloon() As Boolean
        Try

            Driver.FindElements(By.CssSelector("span[Class='_31gEB']"))
            Return True

        Catch ex As Exception
            Return False
        End Try


    End Function
    Private Function CekRequest(ByVal Request As String) As Boolean
        Dim strRequest As String()
        strRequest = Request.Split("#")



        If strRequest(0) = "Ta" Then
            Return True
        Else
            Return False
        End If



    End Function
    Private Function SendRespond(ByVal Request As String) As Boolean
        Dim strRequest As String()
        Dim Response As String
        strRequest = Request.Split("#")
        Dim strQuery As String

        Call KoneksiDatabase1()

        strQuery = "SELECT * FROM dbo.MasterStatus Where KdStatus='" & strRequest(1) & "'"
        cmd = New SqlCommand(strQuery, Koneksi1)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then
            Response = dr.GetString(0) & "-" & dr.GetString(1)
        Else
            Response = "Maaf Data Tidak Ditemukan!"
        End If




    End Function






    


    Private Sub GetIncomingMessageNonActive1()
        Dim all As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_210SC"))

        For Each element As IWebElement In all
            Try
                element.FindElement(By.CssSelector("span[Class='_31gEB']"))
                'element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()


                Dim Dari As String = "FROM" & element.FindElement(By.CssSelector("span[dir='auto']")).Text
                Dim Message As String = element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Text


                ListBox1.Items.Add(Dari & Message)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

            Catch ex As Exception

            End Try
        Next

    End Sub
    Private Sub GetIncomingMessageActive1()


        If Driver.Title <> "WhatsApp" Then
            If CekApakahSudahLogin() = False And CekNotifyBaloon() = False Then
                Try
                    Dim Last As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_2hq0q"))
                    Dim LastMsg As String = Nothing


                    For Each x As IWebElement In Last
                        LastMsg = x.Text.Substring(0, Len(x.Text) - 5)
                    Next

                    LastMsg = LastMsg.Replace(Environment.NewLine, String.Empty)

                    Dim Dari As String = "FROM " & Driver.FindElement(By.ClassName("DP7CM")).Text
                    ListBox1.Items.Add(Dari & LastMsg)
                    Threading.Thread.Sleep(500)


                Catch ex As Exception
                    MessageBox.Show(Err.Description)
                End Try
            End If
        End If




    End Sub




    Sub CariGroupChat()
        Try

            'Driver.FindElement(By.CssSelector("div[@class='_3qx7_']"))
            'Driver.FindElement(By.CssSelector("div[@class='_3qx7_']")).Click()

            'Driver.FindElement(By.CssSelector("//input[@title='Search or start new chat']")).SendKeys("GhibahGroup")

            Driver.FindElement(By.CssSelector("input[@title='Search or start new chat']")).Click()
            'Driver.FindElement(By.CssSelector("input[@title='Search or start new chat']")).SendKeys(Keys.Enter)

     
            'Dim Last As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_1KyAW"))

            'For Each element As IWebElement In Last
            '    element.FindElement(By.CssSelector("span[Class='J3VFH']"))
            '    element.FindElement(By.CssSelector("span[Class='_3qx7_']")).Click()
            '    ''element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

            '    ''J3VFH()


            '    'Dim Dari As String = "FROM" & element.FindElement(By.CssSelector("span[dir='auto']")).Text
            '    'Dim Message As String = element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Text


            '    'ListBox1.Items.Add(Dari & Message)
            '    'ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            '    'element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

            'Next

            'For Each element As IWebElement In Last
            '    element.FindElement(By.CssSelector("span[Class='_2EoyP']"))
            '    'element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

            '    'J3VFH()


            '    Dim Dari As String = "FROM" & element.FindElement(By.CssSelector("span[dir='auto']")).Text
            '    Dim Message As String = element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Text


            '    ListBox1.Items.Add(Dari & Message)
            '    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            '    element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

            'Next


        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try


    End Sub


    Private Sub TimerMsgIn1_Tick(sender As Object, e As EventArgs) Handles TimerMsgIn1.Tick
        GetIncomingMessageActive2()
    End Sub

    Private Sub TimerMsgIn2_Tick(sender As Object, e As EventArgs) Handles TimerMsgIn2.Tick
        GetIncomingMessageNonActive2()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "START" Then
            Driver = New ChromeDriver
            Driver.Navigate().GoToUrl("https://web.whatsapp.com/")


            Button1.Text = "STOP"
            TimerLogin.Enabled = True
            TimerLogin.Start()
            TimerLogin.Interval = 1000



        Else
            TimerMsgIn1.Enabled = False
            TimerMsgIn2.Enabled = False
            'Driver.Quit()
            Button1.Text = "START"
        End If
    End Sub


    Private Sub TimerLogin_Tick(sender As Object, e As EventArgs) Handles TimerLogin.Tick
        If CekApakahSudahLogin() = True Then
            'TimerMsgIn1.Enabled = True
            'TimerMsgIn1.Interval = 500
            'TimerMsgIn2.Enabled = True
            'TimerMsgIn2.Interval = 1000
            TimerLogin.Enabled = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CariGroupChat()
    End Sub


    Private Sub GetIncomingMessageNonActive3()
            Dim all As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_210SC"))


            For Each element As IWebElement In all
                Try
                    element.FindElement(By.CssSelector("span[Class='_31gEB']"))
                    element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

                    Dim Dari As String = "FROM" & element.FindElement(By.CssSelector("span[dir='auto']")).Text
                    Dim Message As String = element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Text


                    ListBox1.Items.Add(Dari & Message)
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                    'element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()



                    If CekRequest(Message) = True Then
                        Dim strResponse As String = SendRespond(Message)
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys(strResponse)
                    Else
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Selamat Datang Di")
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys(Keys.Shift + Keys.Enter)
                    End If


                    'Threading.Thread.Sleep("3000")
                    'Driver.Navigate().GoToUrl("https://web.whatsapp.com/")
                    'Threading.Thread.Sleep("5000")


                Catch ex As Exception

                End Try
            Next

    End Sub



    Private Sub GetIncomingMessageActive3()

        If Driver.Title <> "WhatsApp" Then
            If CekApakahSudahLogin() = False And CekNotifyBaloon() = False Then
                Try

                    Dim Last As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_2hq0q"))
                    Dim LastMsg As String = Nothing

                    For Each X As IWebElement In Last
                        LastMsg = X.Text.Substring(0, Len(X.Text) - 5)
                    Next


                    LastMsg = LastMsg.Replace(Environment.NewLine, String.Empty)
                    Dim Dari As String = "FROM" & Driver.FindElement(By.ClassName("DP7CM")).Text & " - "
                    ListBox1.Items.Add(Dari & LastMsg)
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1


                    If CekRequest(LastMsg) = True Then
                        Dim strResponse As String = SendRespond(LastMsg)
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys(strResponse)
                    Else
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Selamat Datang Di")
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys(Keys.Shift + Keys.Enter)
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Balasan Untuk Target Omset")
                        Driver.FindElement(By.ClassName("_3uMse")).SendKeys(Keys.Shift + Keys.Enter)

                    End If

                    Threading.Thread.Sleep(1000)
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()
                    'Threading.Thread.Sleep("3000")
                    'Driver.Navigate().GoToUrl("https://web.whatsapp.com/")
                    'Threading.Thread.Sleep("5000")


                Catch

                End Try

            End If


        End If



    End Sub



    Private Sub GetIncomingMessageNonActive2()
        Dim all As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_210SC"))


        For Each element As IWebElement In all
            Try
                element.FindElement(By.CssSelector("span[Class='_31gEB']"))
                element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()

                Dim Dari As String = "FROM" & element.FindElement(By.CssSelector("span[dir='auto']")).Text & " - "
                Dim Message As String = element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Text


                ListBox1.Items.Add(Dari & Message)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                'element.FindElement(By.CssSelector("span[Class='_2iq-U']")).Click()


                Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Auto Reply Non Aktif")
                Threading.Thread.Sleep(1000)
                Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()

                'If CekRequest(Message) = True Then
                '    Dim strResponse As String = SendRespond(Message)
                '    Driver.FindElement(By.ClassName("_3uMse")).SendKeys(strResponse)
                'Else
                '    Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Selamat Datang Di")
                '    Driver.FindElement(By.ClassName("_3uMse")).SendKeys(Keys.Shift + Keys.Enter)
                'End If



                'Driver.Navigate().GoToUrl("https://web.whatsapp.com/")
                'Threading.Thread.Sleep("5000")


            Catch ex As Exception

            End Try
        Next

    End Sub
    Private Sub GetIncomingMessageActive2()

        If Driver.Title <> "WhatsApp" Then
            If CekApakahSudahLogin() = False And CekNotifyBaloon() = False Then
                Try

                    Dim Last As IList(Of IWebElement) = Driver.FindElements(By.ClassName("_2hq0q"))
                    Dim LastMsg As String = Nothing

                    For Each X As IWebElement In Last
                        LastMsg = X.Text.Substring(0, Len(X.Text) - 5)
                    Next


                    LastMsg = LastMsg.Replace(Environment.NewLine, String.Empty)
                    Dim Dari As String = "FROM" & Driver.FindElement(By.ClassName("DP7CM")).Text & " - "
                    ListBox1.Items.Add(Dari & LastMsg)
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                    Driver.FindElement(By.ClassName("_3uMse")).SendKeys("Auto Reply Aktif")


                    Threading.Thread.Sleep(1000)
                    Driver.FindElement(By.CssSelector("span[data-icon='send']")).Click()



                Catch

                End Try

            End If


        End If
    End Sub

End Class
