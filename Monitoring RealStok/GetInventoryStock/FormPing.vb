Public Class FormPing

    Private Sub FormPing_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIPSAP.Text = "10.1.0.53"
    End Sub

    Private Sub cmdCustomPing_Click(sender As Object, e As EventArgs) Handles cmdCustomPing.Click
        If txtCustomIP.Text = "" Then
            MsgBox("Masukan Alamat Ip Tujuan", vbCritical, "IP Tujuan Kosong")
            txtCustomIP.BackColor = Color.LimeGreen
            txtCustomIP.Focus()
            Exit Sub
        Else
            Shell("CMD.exe /C ping " & (Trim(txtCustomIP.Text)) & " -t", AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub cmdPingSAP_Click(sender As Object, e As EventArgs) Handles cmdPingSAP.Click
        Shell("CMD.exe /C ping " & (Trim(txtIPSAP.Text)) & " -t", AppWinStyle.NormalFocus)
    End Sub
End Class