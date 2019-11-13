Imports System.Windows.Forms

Public Class GraphOption1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GraphOption1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            StorePerform.aa1.Text = "True"
        Else
            StorePerform.aa1.Text = "False"
        End If
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            StorePerform.aa2.Text = "True"
        Else
            StorePerform.aa2.Text = "False"
        End If
    End Sub

    Private Sub CheckBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        If CheckBox3.Checked Then
            StorePerform.bb1.Text = "True"
        Else
            StorePerform.bb1.Text = "False"
        End If
    End Sub

    Private Sub CheckBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        If CheckBox4.Checked Then
            StorePerform.bb2.Text = "True"
        Else
            StorePerform.bb2.Text = "False"
        End If
    End Sub

    Private Sub CheckBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        If CheckBox5.Checked Then
            StorePerform.cc1.Text = "True"
        Else
            StorePerform.cc1.Text = "False"
        End If
    End Sub

    Private Sub CheckBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.Click
        If CheckBox6.Checked Then
            StorePerform.cc2.Text = "True"
        Else
            StorePerform.cc2.Text = "False"
        End If
    End Sub

    Private Sub CheckBox7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox7.Click
        If CheckBox7.Checked Then
            StorePerform.dd1.Text = "True"
        Else
            StorePerform.dd1.Text = "False"
        End If
    End Sub

    Private Sub CheckBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox8.Click
        If CheckBox8.Checked Then
            StorePerform.dd2.Text = "True"
        Else
            StorePerform.dd2.Text = "False"
        End If
    End Sub

    Private Sub CheckBox9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox9.Click
        If CheckBox9.Checked Then
            StorePerform.ee1.Text = "True"
        Else
            StorePerform.ee1.Text = "False"
        End If
    End Sub

    Private Sub CheckBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox10.Click
        If CheckBox10.Checked Then
            StorePerform.ee2.Text = "True"
        Else
            StorePerform.ee2.Text = "False"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StorePerform.grp.Text = ""
        StorePerform.grp.Text = "execute"
        Close()

    End Sub
End Class
