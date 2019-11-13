Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Data.DataSet
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports ZedGraph

Public Class LogIn
    Dim MyCommand As SqlDataAdapter
    Dim DtSet As System.Data.DataSet
    Dim MyConnection As SqlConnection
    Dim MyCommand2 As SqlDataAdapter
    Dim DtSet2 As System.Data.DataSet
    Dim MyConnection2 As SqlConnection
    Dim MyCommand3 As SqlDataAdapter
    Dim DtSet3 As System.Data.DataSet
    Dim MyConnection3 As SqlConnection

    Dim ProMyCommand1 As SqlDataAdapter
    Dim ProDtSet1 As System.Data.DataSet
    Dim ProMyCommand2 As SqlDataAdapter
    Dim ProDtSet2 As System.Data.DataSet
    Dim cnt As Integer
    Dim ctrlDict As New Dictionary(Of String, Control)

    Sub Koneksi()
        MyConnection2 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=BIDBase;User ID=sa;Password=stip3ndium")
        If MyConnection2.State = ConnectionState.Closed Then
            MyConnection2.Open()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Koneksi()
        MyCommand = New SqlDataAdapter("Select * from userlist", MyConnection2)
        DtSet = New DataSet()
        DtSet.Clear()
        MyCommand.Fill(DtSet, "userlist")

        DataGridView1.DataSource = DtSet.Tables("userlist").DefaultView



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Masukkan Username dan Password")
            Exit Sub
        End If

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(1).Value = TextBox1.Text And DataGridView1.Rows(i).Cells(2).Value = TextBox2.Text Then
                Main.Label1.Text = DataGridView1.Rows(i).Cells(3).Value
                Main.Label2.Text = DataGridView1.Rows(i).Cells(4).Value
                Close()
                Main.PictureBox1.Enabled = True
                Main.PictureBox2.Enabled = True
                Main.PictureBox3.Enabled = True
                Main.PictureBox5.Enabled = True
                Main.PictureBox8.Enabled = True
                Main.PictureBox9.Enabled = True
                Main.PictureBox10.Enabled = True
                Main.PictureBox11.Enabled = True
                Main.PictureBox12.Enabled = True
                Main.Label5.Enabled = True
                Main.Timer1.Enabled = True
                Exit Sub
            End If
        Next

        MessageBox.Show("User Tidak Valid")
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class