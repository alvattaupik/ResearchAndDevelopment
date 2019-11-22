Public Class pingserver
    Dim DataGridView1 As New DataGridView()
    Dim ButtonUpdate As New Button()
    Dim BindingSource1 As New BindingSource()
    Dim DataTable1 As New DataTable()




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim IP As String
        IP = "10.1.0.4"

        If My.Computer.Network.Ping(IP) Then
            Label4.Text = ("Connect")
            Label4.ForeColor = Color.Green
        Else
            Label4.Text = ("Not Connect")
            Label4.ForeColor = Color.Red

        End If

        IP = "10.1.0.6"

        If My.Computer.Network.Ping(IP) Then
            Label5.Text = ("Connect")
            Label5.ForeColor = Color.Green
        Else
            Label5.Text = ("Not Connect")
            Label5.ForeColor = Color.Red
        End If

        IP = "10.1.0.7"

        If My.Computer.Network.Ping(IP) Then
            Label6.Text = ("Connect")
            Label6.ForeColor = Color.Green
        Else
            Label6.Text = ("Not Connect")
            Label6.ForeColor = Color.Red
        End If

        IP = "10.1.0.2"

        If My.Computer.Network.Ping(IP) Then
            Label13.Text = ("Connect")
            Label13.ForeColor = Color.Green
        Else
            Label13.Text = ("Not Connect")
            Label13.ForeColor = Color.Red
        End If

        IP = "10.1.20.31"

        If My.Computer.Network.Ping(IP) Then
            Label29.Text = ("Connect")
            Label29.ForeColor = Color.Green
        Else
            Label29.Text = ("Not Connect")
            Label29.ForeColor = Color.Red
        End If

        IP = "192.168.102.10"

        If My.Computer.Network.Ping(IP) Then
            Label30.Text = ("Connect")
            Label30.ForeColor = Color.Green
        Else
            Label30.Text = ("Not Connect")
            Label30.ForeColor = Color.Red
        End If

        IP = "10.1.1.42"

        If My.Computer.Network.Ping(IP) Then
            Label34.Text = ("Connect")
            Label34.ForeColor = Color.Green
        Else
            Label34.Text = ("Not Connect")
            Label34.ForeColor = Color.Red
        End If

        IP = "10.1.1.26"

        If My.Computer.Network.Ping(IP) Then
            Label35.Text = ("Connect")
            Label35.ForeColor = Color.Green
        Else
            Label35.Text = ("Not Connect")
            Label35.ForeColor = Color.Red
        End If

        IP = "10.1.1.136"

        If My.Computer.Network.Ping(IP) Then
            Label36.Text = ("Connect")
            Label36.ForeColor = Color.Green
        Else
            Label36.Text = ("Not Connect")
            Label36.ForeColor = Color.Red
        End If

        IP = "10.1.21.69"

        If My.Computer.Network.Ping(IP) Then
            Label37.Text = ("Connect")
            Label37.ForeColor = Color.Green
        Else
            Label37.Text = ("Not Connect")
            Label37.ForeColor = Color.Red
        End If

        IP = "10.1.11.11"

        If My.Computer.Network.Ping(IP) Then
            Label38.Text = ("Connect")
            Label38.ForeColor = Color.Green
        Else
            Label38.Text = ("Not Connect")
            Label38.ForeColor = Color.Red
        End If


        IP = "192.168.0.72"

        If My.Computer.Network.Ping(IP) Then
            Label39.Text = ("Connect")
            Label39.ForeColor = Color.Green
        Else
            Label39.Text = ("Not Connect")
            Label39.ForeColor = Color.Red
        End If

        IP = "192.168.102.20"

        If My.Computer.Network.Ping(IP) Then
            Label42.Text = ("Connect")
            Label42.ForeColor = Color.Green
        Else
            Label42.Text = ("Not Connect")
            Label42.ForeColor = Color.Red
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
      
        Dim IP2 As String
        IP2 = TextBox1.Text

        If My.Computer.Network.Ping(IP2) Then
            Label44.Text = ("Connect")
            Label44.ForeColor = Color.Green

        Else
            Label44.Text = ("Not Connect")
            Label44.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label45.Text = TimeOfDay
        Label46.Text = Format(Now, "dddd, dd – MMMM – yyyy")
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)
     

    End Sub



    



 


End Class