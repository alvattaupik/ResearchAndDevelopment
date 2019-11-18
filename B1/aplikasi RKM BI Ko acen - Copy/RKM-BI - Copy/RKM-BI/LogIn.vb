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
    'Dim MyCommand As SqlDataAdapter
    'Dim DtSet As System.Data.DataSet
    'Dim MyConnection As SqlConnection
    'Dim MyCommand2 As SqlDataAdapter
    'Dim DtSet2 As System.Data.DataSet
    'Dim MyConnection2 As SqlConnection
    'Dim MyCommand3 As SqlDataAdapter
    'Dim DtSet3 As System.Data.DataSet
    'Dim MyConnection3 As SqlConnection

    'Dim ProMyCommand1 As SqlDataAdapter
    'Dim ProDtSet1 As System.Data.DataSet
    'Dim ProMyCommand2 As SqlDataAdapter
    'Dim ProDtSet2 As System.Data.DataSet
    'Dim cnt As Integer
    'Dim ctrlDict As New Dictionary(Of String, Control)



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        chkRememberMe.CheckState = My.Settings.RememberMe
        TextBox1.Text = My.Settings.UsernameLogin
        TextBox2.Text = My.Settings.PasswordLogin

        Main.Panel1.Enabled = False

        Main.Panel1.BackColor = Color.LightGray

        Main.Panel2.Enabled = False







        'KoneksiDatabaseLoginAplikasi()

        'Dim cmd As New SqlCommand("Select * from userlist", Koneksi2)


        'Dim adapter As New SqlDataAdapter(cmd)

        'Dim table As New DataTable

        'adapter.Fill(table)


        'DataGridView1.DataSource = table
        ''aturDGSAP()
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'DataGridView1.AutoResizeColumns()
        'Koneksi2.Close()












        'Da = New SqlDataAdapter("Select * from userlist", Koneksi2)
        'DtSet = New DataSet()
        'DtSet.Clear()
        'Da.Fill(DtSet, "userlist")
        'DataGridView1.DataSource = DtSet.Tables("userlist").DefaultView



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strSQlLogin As String



        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Masukkan Username dan Password")
            Exit Sub
        End If



        If chkRememberMe.Checked = True Then
            With My.Settings
                .UsernameLogin = Trim(TextBox1.Text)
                .PasswordLogin = Trim(TextBox2.Text)
                .RememberMe = chkRememberMe.CheckState
                .Save()
            End With
        End If


        Call KoneksiDatabaseLoginAplikasi()

        strSQlLogin = "Select * From Userlist Where name='" & Trim(TextBox1.Text) & "' AND pass='" & Trim(TextBox2.Text) & "'"
        cmd = New SqlCommand(strSQlLogin, Koneksi2)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            Me.Dispose()
            Main.Panel1.Enabled = True
            Main.Panel1.BackColor = Color.White
            Main.Show()
            Main.Label5.Enabled = True
            Main.Timer1.Enabled = True
            Main.Timer3.Enabled = True
            Main.Panel2.Enabled = True
            Main.Panel2.Visible = True
        Else

            MsgBox("Username dan Password Yang Anda Masukan Salah", vbInformation, "Hubungi Administrator")
            Exit Sub
        End If



        'For i As Integer = 0 To DataGridView1.RowCount - 1
        '    If DataGridView1.Rows(i).Cells(1).Value = TextBox1.Text And DataGridView1.Rows(i).Cells(2).Value = TextBox2.Text Then
        '        Main.Label1.Text = DataGridView1.Rows(i).Cells(3).Value
        '        Main.Label2.Text = DataGridView1.Rows(i).Cells(4).Value
        '        Close()
        '        Main.PictureBox1.Enabled = True
        '        Main.PictureBox2.Enabled = True
        '        Main.PictureBox3.Enabled = True
        '        Main.PictureBox5.Enabled = True
        '        Main.PictureBox8.Enabled = True
        '        Main.PictureBox9.Enabled = True
        '        Main.PictureBox10.Enabled = True
        '        Main.PictureBox11.Enabled = True
        '        Main.PictureBox12.Enabled = True
        '        Main.Label5.Enabled = True
        '        Main.Timer1.Enabled = True
        '        Exit Sub
        '    End If
        'Next

        ''MessageBox.Show("User Tidak Valid")
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
End Class