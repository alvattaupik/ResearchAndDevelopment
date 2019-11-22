Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading

Public Class Form1

    ' Dim ping As New Ping
    ' Dim rp(2) As PingReply
    Dim myPing As New System.Net.NetworkInformation.Ping
    Dim PR(50) As System.Net.NetworkInformation.PingReply

 
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
   
        Label150.Font = New Font("ds-digital", 25, FontStyle.Bold)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Thread.Sleep(1000)
        'rp(0) = ping.Send("8.8.8.8")
        PR(0) = myPing.Send("10.1.0.4") 'server proint
        PR(1) = myPing.Send("10.1.0.6") 'server SAP
        PR(2) = myPing.Send("10.1.0.7") 'server Ivend
        PR(3) = myPing.Send("10.1.0.2") 'server Domain
        PR(4) = myPing.Send("10.1.20.31") 'server Garut
        PR(5) = myPing.Send("192.168.102.10") 'server Cirebon
        PR(6) = myPing.Send("10.1.1.75") 'server A yani
        PR(7) = myPing.Send("10.1.1.65") 'server Abm
        '=========================================================================================================
        PR(8) = myPing.Send("10.1.20.80") 'Client CS Garut
        PR(9) = myPing.Send("10.1.20.30") 'Client Kasir1 Garut
        PR(10) = myPing.Send("10.1.20.19") 'Client Kasir2 Garut
        'PR(11) = myPing.Send("10.1.20.22") 'Client Kasir3 Garut
        PR(12) = myPing.Send("10.1.20.61") 'Client gudang sanitary Garut
        PR(13) = myPing.Send("10.1.20.15") 'Client gudang keramik Garut
        '==========================================================================================================
        PR(14) = myPing.Send("192.168.102.8") 'Client CS Cirebon
        PR(15) = myPing.Send("192.168.102.20") 'Client VM Cirebon
        PR(16) = myPing.Send("192.168.102.7") 'Client gudang sanitary Cirebon
        PR(17) = myPing.Send("192.168.102.5") 'Client gudang keramik Cirebon
        PR(46) = myPing.Send("192.168.102.11") 'Client Kasir1 Cirebon
        PR(47) = myPing.Send("192.168.102.14") 'Client Kasir1 Cirebon
        '==========================================================================================================
        PR(18) = myPing.Send("10.1.1.136") 'Client Admin A Yani
        PR(19) = myPing.Send("10.1.1.137") 'Client sales A Yani
        PR(20) = myPing.Send("10.1.1.135") 'Client kasir1 A Yani
        PR(21) = myPing.Send("10.1.1.140") 'Client kasir2 A Yani
        PR(22) = myPing.Send("10.1.1.141") 'Client gudang sanitary A Yani
        PR(23) = myPing.Send("10.1.1.237") 'Client gudang keramik Yani
        '==========================================================================================================
        PR(24) = myPing.Send("10.1.1.73") 'Client kasir1 ABM
        PR(25) = myPing.Send("10.1.1.81") 'Client sales ABM
        PR(26) = myPing.Send("10.1.1.77") 'Client gudang sanitary A Yani
        '==========================================================================================================
        PR(27) = myPing.Send("192.168.0.80") 'Client SPV Cibiru
        PR(28) = myPing.Send("192.168.0.72") 'Client Kasir1 Cibiru
        PR(29) = myPing.Send("192.168.0.70") 'Client Kasir2 Cibiru
        PR(30) = myPing.Send("192.168.0.77") 'Client Gudang Cibiru
        '===========================================================================================================
        PR(31) = myPing.Send("10.1.21.77") 'Client SPV Kopo
        PR(32) = myPing.Send("10.1.21.13") 'Client Kasir1 Kopo
        PR(33) = myPing.Send("10.1.21.15") 'Client Kasir2 Kopo
        PR(34) = myPing.Send("10.1.21.69") 'Client Gudang Kopo
        '===========================================================================================================
        PR(35) = myPing.Send("10.1.11.11") 'Client SPV Kopo
        PR(36) = myPing.Send("10.1.11.12") 'Client Kasir1 Kopo
        PR(37) = myPing.Send("10.1.11.13") 'Client Kasir2 Kopo
        '=============================================================================================================
        PR(38) = myPing.Send("10.1.22.96") 'Server RKM Sumedang
        PR(39) = myPing.Send("10.1.22.93") 'Client admin Sumedang
        PR(40) = myPing.Send("10.1.22.89") 'Client VM Sumedang
        PR(41) = myPing.Send("10.1.22.95") 'Client CS Sumedang
        PR(42) = myPing.Send("10.1.22.91") 'Client Kasir1 Sumedang
        PR(43) = myPing.Send("10.1.22.92") 'Client Kasir2 Sumedang
        PR(44) = myPing.Send("10.1.22.97") 'Client sales Sumedang
        PR(45) = myPing.Send("10.1.22.100") 'Client Kramik Sumedang
        PR(48) = myPing.Send("10.1.21.17") 'server Kopo
        PR(49) = myPing.Send("10.1.11.16") 'server cibabat
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
  
        If PR(0).Status = IPStatus.Success Then
            Label1.Text = ("Reply from " & PR(0).Address.ToString & ": BYTES=" & PR(0).Buffer.Length & " TIME<" & PR(0).RoundtripTime & "ms TTL=" & PR(0).Options.Ttl)
            Label1.ForeColor = Color.Green
        Else
            Label1.Text = ("Not Connect")
            Label1.ForeColor = Color.Red
        End If

        If PR(1).Status = IPStatus.Success Then
            Label4.Text = ("Reply from " & PR(1).Address.ToString & ": BYTES=" & PR(1).Buffer.Length & " TIME<" & PR(1).RoundtripTime & "ms TTL=" & PR(1).Options.Ttl)
            Label4.ForeColor = Color.Green
        Else
            Label4.Text = ("Not Connect")
            Label4.ForeColor = Color.Red
        End If

        If PR(2).Status = IPStatus.Success Then
            Label6.Text = ("Reply from " & PR(2).Address.ToString & ": BYTES=" & PR(2).Buffer.Length & " TIME<" & PR(2).RoundtripTime & "ms TTL=" & PR(2).Options.Ttl)
            Label6.ForeColor = Color.Green
        Else
            Label6.Text = ("Not Connect")
            Label6.ForeColor = Color.Red
        End If

        If PR(3).Status = IPStatus.Success Then
            Label8.Text = ("Reply from " & PR(3).Address.ToString & ": BYTES=" & PR(3).Buffer.Length & " TIME<" & PR(3).RoundtripTime & "ms TTL=" & PR(3).Options.Ttl)
            Label8.ForeColor = Color.Green
        Else
            Label8.Text = ("Not Connect")
            Label8.ForeColor = Color.Red
        End If

        If PR(4).Status = IPStatus.Success Then
            Label10.Text = ("Reply from " & PR(4).Address.ToString & ": BYTES=" & PR(4).Buffer.Length & " TIME<" & PR(4).RoundtripTime & "ms TTL=" & PR(4).Options.Ttl)
            Label10.ForeColor = Color.Green
        Else
            Label10.Text = ("Not Connect")
            Label10.ForeColor = Color.Red
        End If

        If PR(5).Status = IPStatus.Success Then
            Label12.Text = ("Reply from " & PR(5).Address.ToString & ": BYTES=" & PR(5).Buffer.Length & " TIME<" & PR(5).RoundtripTime & "ms TTL=" & PR(5).Options.Ttl)
            Label12.ForeColor = Color.Green
        Else
            Label12.Text = ("Not Connect")
            Label12.ForeColor = Color.Red
        End If

        If PR(6).Status = IPStatus.Success Then
            Label14.Text = ("Reply from " & PR(6).Address.ToString & ": BYTES=" & PR(6).Buffer.Length & " TIME<" & PR(6).RoundtripTime & "ms TTL=" & PR(6).Options.Ttl)
            Label14.ForeColor = Color.Green
        Else
            Label14.Text = ("Not Connect")
            Label14.ForeColor = Color.Red
        End If

        If PR(7).Status = IPStatus.Success Then
            Label16.Text = ("Reply from " & PR(7).Address.ToString & ": BYTES=" & PR(7).Buffer.Length & " TIME<" & PR(7).RoundtripTime & "ms TTL=" & PR(7).Options.Ttl)
            Label16.ForeColor = Color.Green
        Else
            Label16.Text = ("Not Connect")
            Label16.ForeColor = Color.Red
        End If

        If PR(8).Status = IPStatus.Success Then
            Label18.Text = ("Reply from " & PR(8).Address.ToString & ": BYTES=" & PR(8).Buffer.Length & " TIME<" & PR(8).RoundtripTime & "ms TTL=" & PR(8).Options.Ttl)
            Label18.ForeColor = Color.Green
        Else
            Label18.Text = ("Not Connect")
            Label18.ForeColor = Color.Red
        End If

        If PR(9).Status = IPStatus.Success Then
            Label20.Text = ("Reply from " & PR(9).Address.ToString & ": BYTES=" & PR(9).Buffer.Length & " TIME<" & PR(9).RoundtripTime & "ms TTL=" & PR(9).Options.Ttl)
            Label20.ForeColor = Color.Green
        Else
            Label20.Text = ("Not Connect")
            Label20.ForeColor = Color.Red
        End If

        If PR(10).Status = IPStatus.Success Then
            Label22.Text = ("Reply from " & PR(10).Address.ToString & ": BYTES=" & PR(10).Buffer.Length & " TIME<" & PR(10).RoundtripTime & "ms TTL=" & PR(10).Options.Ttl)
            Label22.ForeColor = Color.Green
        Else
            Label22.Text = ("Not Connect")
            Label22.ForeColor = Color.Red
        End If

        ' If PR(11).Status = IPStatus.Success Then
        'Label24.Text = ("Reply from " & PR(11).Address.ToString & ": BYTES=" & PR(11).Buffer.Length & " TIME<" & PR(11).RoundtripTime & "ms TTL=" & PR(11).Options.Ttl)
        ' Label24.ForeColor = Color.Green
        ' Else
        ' Label24.Text = ("Not Connect")
        'Label24.ForeColor = Color.Red
        'End If

        If PR(12).Status = IPStatus.Success Then
            Label26.Text = ("Reply from " & PR(12).Address.ToString & ": BYTES=" & PR(12).Buffer.Length & " TIME<" & PR(12).RoundtripTime & "ms TTL=" & PR(12).Options.Ttl)
            Label26.ForeColor = Color.Green
        Else
            Label26.Text = ("Not Connect")
            Label26.ForeColor = Color.Red
        End If

        If PR(13).Status = IPStatus.Success Then
            Label28.Text = ("Reply from " & PR(13).Address.ToString & ": BYTES=" & PR(13).Buffer.Length & " TIME<" & PR(13).RoundtripTime & "ms TTL=" & PR(13).Options.Ttl)
            Label28.ForeColor = Color.Green
        Else
            Label28.Text = ("Not Connect")
            Label28.ForeColor = Color.Red
        End If

        If PR(14).Status = IPStatus.Success Then
            Label42.Text = ("Reply from " & PR(14).Address.ToString & ": BYTES=" & PR(14).Buffer.Length & " TIME<" & PR(14).RoundtripTime & "ms TTL=" & PR(14).Options.Ttl)
            Label42.ForeColor = Color.Green
        Else
            Label42.Text = ("Not Connect")
            Label42.ForeColor = Color.Red
        End If

        If PR(15).Status = IPStatus.Success Then
            Label40.Text = ("Reply from " & PR(15).Address.ToString & ": BYTES=" & PR(15).Buffer.Length & " TIME<" & PR(15).RoundtripTime & "ms TTL=" & PR(15).Options.Ttl)
            Label40.ForeColor = Color.Green
        Else
            Label40.Text = ("Not Connect")
            Label40.ForeColor = Color.Red
        End If

        If PR(16).Status = IPStatus.Success Then
            Label32.Text = ("Reply from " & PR(16).Address.ToString & ": BYTES=" & PR(16).Buffer.Length & " TIME<" & PR(16).RoundtripTime & "ms TTL=" & PR(16).Options.Ttl)
            Label32.ForeColor = Color.Green
        Else
            Label32.Text = ("Not Connect")
            Label32.ForeColor = Color.Red
        End If

        If PR(17).Status = IPStatus.Success Then
            Label30.Text = ("Reply from " & PR(17).Address.ToString & ": BYTES=" & PR(17).Buffer.Length & " TIME<" & PR(17).RoundtripTime & "ms TTL=" & PR(17).Options.Ttl)
            Label30.ForeColor = Color.Green
        Else
            Label30.Text = ("Not Connect")
            Label30.ForeColor = Color.Red
        End If

        If PR(18).Status = IPStatus.Success Then
            Label56.Text = ("Reply from " & PR(18).Address.ToString & ": BYTES=" & PR(18).Buffer.Length & " TIME<" & PR(18).RoundtripTime & "ms TTL=" & PR(18).Options.Ttl)
            Label56.ForeColor = Color.Green
        Else
            Label56.Text = ("Not Connect")
            Label56.ForeColor = Color.Red
        End If

        If PR(19).Status = IPStatus.Success Then
            Label54.Text = ("Reply from " & PR(19).Address.ToString & ": BYTES=" & PR(19).Buffer.Length & " TIME<" & PR(19).RoundtripTime & "ms TTL=" & PR(19).Options.Ttl)
            Label54.ForeColor = Color.Green
        Else
            Label54.Text = ("Not Connect")
            Label54.ForeColor = Color.Red
        End If

        If PR(20).Status = IPStatus.Success Then
            Label52.Text = ("Reply from " & PR(20).Address.ToString & ": BYTES=" & PR(20).Buffer.Length & " TIME<" & PR(20).RoundtripTime & "ms TTL=" & PR(20).Options.Ttl)
            Label52.ForeColor = Color.Green
        Else
            Label52.Text = ("Not Connect")
            Label52.ForeColor = Color.Red
        End If

        If PR(21).Status = IPStatus.Success Then
            Label50.Text = ("Reply from " & PR(21).Address.ToString & ": BYTES=" & PR(21).Buffer.Length & " TIME<" & PR(21).RoundtripTime & "ms TTL=" & PR(21).Options.Ttl)
            Label50.ForeColor = Color.Green
        Else
            Label50.Text = ("Not Connect")
            Label50.ForeColor = Color.Red
        End If

        If PR(22).Status = IPStatus.Success Then
            Label48.Text = ("Reply from " & PR(22).Address.ToString & ": BYTES=" & PR(22).Buffer.Length & " TIME<" & PR(22).RoundtripTime & "ms TTL=" & PR(22).Options.Ttl)
            Label48.ForeColor = Color.Green
        Else
            Label48.Text = ("Not Connect")
            Label48.ForeColor = Color.Red
        End If

        If PR(23).Status = IPStatus.Success Then
            Label46.Text = ("Reply from " & PR(23).Address.ToString & ": BYTES=" & PR(23).Buffer.Length & " TIME<" & PR(23).RoundtripTime & "ms TTL=" & PR(23).Options.Ttl)
            Label46.ForeColor = Color.Green
        Else
            Label46.Text = ("Not Connect")
            Label46.ForeColor = Color.Red
        End If

        If PR(24).Status = IPStatus.Success Then
            Label66.Text = ("Reply from " & PR(24).Address.ToString & ": BYTES=" & PR(24).Buffer.Length & " TIME<" & PR(24).RoundtripTime & "ms TTL=" & PR(24).Options.Ttl)
            Label66.ForeColor = Color.Green
        Else
            Label66.Text = ("Not Connect")
            Label66.ForeColor = Color.Red
        End If

        If PR(25).Status = IPStatus.Success Then
            Label64.Text = ("Reply from " & PR(25).Address.ToString & ": BYTES=" & PR(25).Buffer.Length & " TIME<" & PR(25).RoundtripTime & "ms TTL=" & PR(25).Options.Ttl)
            Label64.ForeColor = Color.Green
        Else
            Label64.Text = ("Not Connect")
            Label64.ForeColor = Color.Red
        End If

        If PR(26).Status = IPStatus.Success Then
            Label62.Text = ("Reply from " & PR(26).Address.ToString & ": BYTES=" & PR(26).Buffer.Length & " TIME<" & PR(26).RoundtripTime & "ms TTL=" & PR(26).Options.Ttl)
            Label62.ForeColor = Color.Green
        Else
            Label62.Text = ("Not Connect")
            Label62.ForeColor = Color.Red
        End If

        If PR(27).Status = IPStatus.Success Then
            Label70.Text = ("Reply from " & PR(27).Address.ToString & ": BYTES=" & PR(27).Buffer.Length & " TIME<" & PR(27).RoundtripTime & "ms TTL=" & PR(27).Options.Ttl)
            Label70.ForeColor = Color.Green
        Else
            Label70.Text = ("Not Connect")
            Label70.ForeColor = Color.Red
        End If

        If PR(28).Status = IPStatus.Success Then
            Label68.Text = ("Reply from " & PR(28).Address.ToString & ": BYTES=" & PR(28).Buffer.Length & " TIME<" & PR(28).RoundtripTime & "ms TTL=" & PR(28).Options.Ttl)
            Label68.ForeColor = Color.Green
        Else
            Label68.Text = ("Not Connect")
            Label68.ForeColor = Color.Red
        End If

        If PR(29).Status = IPStatus.Success Then
            Label58.Text = ("Reply from " & PR(29).Address.ToString & ": BYTES=" & PR(29).Buffer.Length & " TIME<" & PR(29).RoundtripTime & "ms TTL=" & PR(29).Options.Ttl)
            Label58.ForeColor = Color.Green
        Else
            Label58.Text = ("Not Connect")
            Label58.ForeColor = Color.Red
        End If

        If PR(30).Status = IPStatus.Success Then
            Label44.Text = ("Reply from " & PR(30).Address.ToString & ": BYTES=" & PR(30).Buffer.Length & " TIME<" & PR(30).RoundtripTime & "ms TTL=" & PR(30).Options.Ttl)
            Label44.ForeColor = Color.Green
        Else
            Label44.Text = ("Not Connect")
            Label44.ForeColor = Color.Red
        End If

        If PR(31).Status = IPStatus.Success Then
            Label80.Text = ("Reply from " & PR(31).Address.ToString & ": BYTES=" & PR(31).Buffer.Length & " TIME<" & PR(31).RoundtripTime & "ms TTL=" & PR(31).Options.Ttl)
            Label80.ForeColor = Color.Green
        Else
            Label80.Text = ("Not Connect")
            Label80.ForeColor = Color.Red
        End If

        If PR(32).Status = IPStatus.Success Then
            Label78.Text = ("Reply from " & PR(32).Address.ToString & ": BYTES=" & PR(32).Buffer.Length & " TIME<" & PR(32).RoundtripTime & "ms TTL=" & PR(32).Options.Ttl)
            Label78.ForeColor = Color.Green
        Else
            Label78.Text = ("Requeset timed out.")
            Label78.ForeColor = Color.Red
        End If

        If PR(33).Status = IPStatus.Success Then
            Label76.Text = ("Reply from " & PR(33).Address.ToString & ": BYTES=" & PR(33).Buffer.Length & " TIME<" & PR(33).RoundtripTime & "ms TTL=" & PR(33).Options.Ttl)
            Label76.ForeColor = Color.Green
        Else
            Label76.Text = ("Not Connect")
            Label76.ForeColor = Color.Red
        End If

        If PR(34).Status = IPStatus.Success Then
            Label74.Text = ("Reply from " & PR(34).Address.ToString & ": BYTES=" & PR(34).Buffer.Length & " TIME<" & PR(34).RoundtripTime & "ms TTL=" & PR(34).Options.Ttl)
            Label74.ForeColor = Color.Green
        Else
            Label74.Text = ("Not Connect")
            Label74.ForeColor = Color.Red
        End If

        If PR(35).Status = IPStatus.Success Then
            Label86.Text = ("Reply from " & PR(35).Address.ToString & ": BYTES=" & PR(35).Buffer.Length & " TIME<" & PR(35).RoundtripTime & "ms TTL=" & PR(35).Options.Ttl)
            Label86.ForeColor = Color.Green
        Else
            Label86.Text = ("Not Connect")
            Label86.ForeColor = Color.Red
        End If

        If PR(36).Status = IPStatus.Success Then
            Label84.Text = ("Reply from " & PR(36).Address.ToString & ": BYTES=" & PR(36).Buffer.Length & " TIME<" & PR(36).RoundtripTime & "ms TTL=" & PR(36).Options.Ttl)
            Label84.ForeColor = Color.Green
        Else
            Label84.Text = ("Not Connect")
            Label84.ForeColor = Color.Red
        End If

        If PR(37).Status = IPStatus.Success Then
            Label82.Text = ("Reply from " & PR(37).Address.ToString & ": BYTES=" & PR(37).Buffer.Length & " TIME<" & PR(37).RoundtripTime & "ms TTL=" & PR(37).Options.Ttl)
            Label82.ForeColor = Color.Green
        Else
            Label82.Text = ("Not Connect")
            Label82.ForeColor = Color.Red
        End If


        If PR(38).Status = IPStatus.Success Then
            Label149.Text = ("Reply from " & PR(38).Address.ToString & ": BYTES=" & PR(38).Buffer.Length & " TIME<" & PR(38).RoundtripTime & "ms TTL=" & PR(38).Options.Ttl)
            Label149.ForeColor = Color.Green
        Else
            Label149.Text = ("Not Connect")
            Label149.ForeColor = Color.Red
        End If

        If PR(39).Status = IPStatus.Success Then
            Label147.Text = ("Reply from " & PR(39).Address.ToString & ": BYTES=" & PR(39).Buffer.Length & " TIME<" & PR(39).RoundtripTime & "ms TTL=" & PR(39).Options.Ttl)
            Label147.ForeColor = Color.Green
        Else
            Label147.Text = ("Not Connect")
            Label147.ForeColor = Color.Red
        End If

        If PR(40).Status = IPStatus.Success Then
            Label145.Text = ("Reply from " & PR(40).Address.ToString & ": BYTES=" & PR(40).Buffer.Length & " TIME<" & PR(40).RoundtripTime & "ms TTL=" & PR(40).Options.Ttl)
            Label145.ForeColor = Color.Green
        Else
            Label145.Text = ("Not Connect")
            Label145.ForeColor = Color.Red
        End If

        If PR(41).Status = IPStatus.Success Then
            Label143.Text = ("Reply from " & PR(41).Address.ToString & ": BYTES=" & PR(41).Buffer.Length & " TIME<" & PR(41).RoundtripTime & "ms TTL=" & PR(41).Options.Ttl)
            Label143.ForeColor = Color.Green
        Else
            Label143.Text = ("Not Connect")
            Label143.ForeColor = Color.Red
        End If

        If PR(42).Status = IPStatus.Success Then
            Label141.Text = ("Reply from " & PR(42).Address.ToString & ": BYTES=" & PR(42).Buffer.Length & " TIME<" & PR(42).RoundtripTime & "ms TTL=" & PR(42).Options.Ttl)
            Label141.ForeColor = Color.Green
        Else
            Label141.Text = ("Not Connect")
            Label141.ForeColor = Color.Red
        End If

        If PR(43).Status = IPStatus.Success Then
            Label139.Text = ("Reply from " & PR(43).Address.ToString & ": BYTES=" & PR(43).Buffer.Length & " TIME<" & PR(43).RoundtripTime & "ms TTL=" & PR(43).Options.Ttl)
            Label139.ForeColor = Color.Green
        Else
            Label139.Text = ("Not Connect")
            Label139.ForeColor = Color.Red
        End If

        If PR(44).Status = IPStatus.Success Then
            Label137.Text = ("Reply from " & PR(44).Address.ToString & ": BYTES=" & PR(44).Buffer.Length & " TIME<" & PR(44).RoundtripTime & "ms TTL=" & PR(44).Options.Ttl)
            Label137.ForeColor = Color.Green
        Else
            Label137.Text = ("Not Connect")
            Label137.ForeColor = Color.Red
        End If

        If PR(45).Status = IPStatus.Success Then
            Label133.Text = ("Reply from " & PR(45).Address.ToString & ": BYTES=" & PR(45).Buffer.Length & " TIME<" & PR(45).RoundtripTime & "ms TTL=" & PR(45).Options.Ttl)
            Label133.ForeColor = Color.Green
        Else
            Label133.Text = ("Not Connect")
            Label133.ForeColor = Color.Red
        End If

        If PR(46).Status = IPStatus.Success Then
            Label38.Text = ("Reply from " & PR(46).Address.ToString & ": BYTES=" & PR(46).Buffer.Length & " TIME<" & PR(46).RoundtripTime & "ms TTL=" & PR(46).Options.Ttl)
            Label38.ForeColor = Color.Green
        Else
            Label38.Text = ("Not Connect")
            Label38.ForeColor = Color.Red
        End If

        If PR(47).Status = IPStatus.Success Then
            Label36.Text = ("Reply from " & PR(47).Address.ToString & ": BYTES=" & PR(47).Buffer.Length & " TIME<" & PR(47).RoundtripTime & "ms TTL=" & PR(47).Options.Ttl)
            Label36.ForeColor = Color.Green
        Else
            Label36.Text = ("Not Connect")
            Label36.ForeColor = Color.Red
        End If

        If PR(48).Status = IPStatus.Success Then
            Label153.Text = ("Reply from " & PR(48).Address.ToString & ": BYTES=" & PR(48).Buffer.Length & " TIME<" & PR(48).RoundtripTime & "ms TTL=" & PR(48).Options.Ttl)
            Label153.ForeColor = Color.Green
        Else
            Label153.Text = ("Not Connect")
            Label153.ForeColor = Color.Red
        End If

        BackgroundWorker1.RunWorkerAsync()
    End Sub

  
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label150.Text = TimeOfDay
        Label151.Text = Format(Now, "dddd, dd – MMMM – yyyy")
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)
    End Sub
End Class