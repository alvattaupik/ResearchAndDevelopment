Public Class FormEmployee

    Private Sub chkManualNumber_CheckedChanged(sender As Object, e As EventArgs) Handles chkManualNumber.CheckedChanged
        If chkManualNumber.Checked = True Then
            txtEmployeeNo.ReadOnly = False
        Else
            txtEmployeeNo.ReadOnly = True
        End If
    End Sub


    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        On Error GoTo ErrorHandler
        Dim Tombol As Integer = Asc(e.KeyChar)

        If Tombol = 13 Then
            BrowseEmployee.Location = New Point(436, 160)
            BrowseEmployee.ShowDialog()
        End If
        Exit Sub

ErrorHandler:
        MsgBox(Err.Description)
        Exit Sub
    End Sub

    Private Sub FormEmployee_Move(sender As Object, e As EventArgs) Handles Me.Move
        ShowLocation(Me)
    End Sub

    Private Sub FormEmployee_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ShowLocation(Me)
    End Sub

 
    Private Sub cmdBrowseFromSAP_Click(sender As Object, e As EventArgs) Handles cmdBrowseFromSAP.Click
        BrowseSAPEmployee.ShowDialog()
    End Sub



    Private Sub cmbPosition_Click(sender As Object, e As EventArgs) Handles cmbPosition.Click
        LoadComboBoxDBLive(cmbPosition, "SELECT posID,name FROM dbo.OHPS", "posID", "name")
    End Sub

    Private Sub cmbManager_Click(sender As Object, e As EventArgs) Handles cmbManager.Click
        LoadComboBoxDBLive(cmbPosition, "SELECT Code,Name FROM dbo.OUDP", "Code", "Name")
    End Sub

    Private Sub cmbBranch_Click(sender As Object, e As EventArgs) Handles cmbBranch.Click
        LoadComboBoxDBLive(cmbBranch, "SELECT Code,Name FROM dbo.OUBR", "Code", "Name")
    End Sub
End Class