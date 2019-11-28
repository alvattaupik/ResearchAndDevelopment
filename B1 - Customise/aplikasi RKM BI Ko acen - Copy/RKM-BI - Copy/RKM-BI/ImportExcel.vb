Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataSet

Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
'Imports System.Collections.Gene
Imports System.Data.Odbc
Imports System.Data.SqlClient
'Imports Microsoft.VisualBasicric

Public Class ImportExcel
    Implements IDisposable
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Dim MyCommandDet As System.Data.OleDb.OleDbDataAdapter
    Dim DtSetDel As System.Data.DataSet
    Dim MyConnectionDet As System.Data.OleDb.OleDbConnection
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Dim DtSet As System.Data.DataSet
    Dim MyConnection As System.Data.OleDb.OleDbConnection

    Dim MyCommandQuery As System.Data.OleDb.OleDbDataAdapter
    Dim DtSetQuery As System.Data.DataSet
    Dim MyConnectionQuery As System.Data.OleDb.OleDbConnection
    Dim MyCommand2 As SqlDataAdapter
    Dim DtSet2 As System.Data.DataSet
    Dim MyConnection2 As SqlConnection

    Sub Koneksi()
        MyConnection2 = New SqlConnection("Data Source=" + "10.1.0.4" + ";Initial Catalog=RKM-Marketing;User ID=sa;Password=stip3ndium")
        If MyConnection2.State = ConnectionState.Closed Then
            MyConnection2.Open()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then

            TextBox1.Text = OpenFileDialog1.FileName
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & OpenFileDialog1.FileName & "; Extended Properties=Excel 12.0;")
            MyConnection.Open()

            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select itemcode,itemname,cabang,minstock,maxstock,haricek from [DataMinMax$] order by itemcode", MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            DtSet = New System.Data.DataSet

            Try
                MyCommand.Fill(DtSet)
                DataGridView1.DataSource = DtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("File Excel Tidak Valid!!!")
                DataGridView1.Columns.Clear()

            End Try


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("Tidak Ada Data Yang Bisa DiImport!!!")
            Exit Sub
        End If

        Dim Box As MsgBoxResult = MsgBox("Start Importing Process?", MsgBoxStyle.YesNo)
        If Box = MsgBoxResult.No Then
            Exit Sub
        End If

        Koneksi()

        Dim berhasil As Integer = 0
        Dim gagal As Integer = 0

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(2).Value <> "ABM (Anyar Building Material)" And DataGridView1.Rows(i).Cells(2).Value <> "PM (Panca Mas)" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Ahmad Yani" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Cibabat" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Cibiru" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Cirebon" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Garut" And DataGridView1.Rows(i).Cells(2).Value <> "RKM Kopo" Then
                gagal = gagal + 1
            Else
                berhasil = berhasil + 1

                MyCommand2 = New SqlDataAdapter("Select itemcode,cabang from minmaxproint where itemcode='" + Format(DataGridView1.Rows(i).Cells(0).Value) + "' and cabang='" + DataGridView1.Rows(i).Cells(2).Value + "'", MyConnection2)
                DtSet2 = New DataSet()
                DtSet2.Clear()
                MyCommand2.Fill(DtSet2, "minmaxproint")
                DataGridView2.Columns.Clear()
                DataGridView2.DataSource = DtSet2.Tables("minmaxproint").DefaultView

                If DataGridView2.RowCount > 0 Then
                    Dim myCommand2 As SqlCommand = New SqlCommand("update minmaxproint set itemname=@itemname,minstock=@minstock,maxstock=@maxstock,haricek=@haricek,updateby=@updateby,updatedate=@updatedate where itemcode=@itemcode and cabang=@cabang", MyConnection2)
                    Dim a As String = Format(Now, "yyyy-MM-dd")
                    myCommand2.CommandType = CommandType.Text
                    myCommand2.Parameters.Add("@itemname", SqlDbType.VarChar, 250)
                    myCommand2.Parameters("@itemname").Value = DataGridView1.Rows(i).Cells(1).Value
                    myCommand2.Parameters.Add("@minstock", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@minstock").Value = DataGridView1.Rows(i).Cells(3).Value
                    myCommand2.Parameters.Add("@maxstock", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@maxstock").Value = DataGridView1.Rows(i).Cells(4).Value
                    myCommand2.Parameters.Add("@haricek", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@haricek").Value = DataGridView1.Rows(i).Cells(5).Value
                    myCommand2.Parameters.Add("@updateby", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@updateby").Value = Main.Label1.Text
                    myCommand2.Parameters.Add("@updatedate", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@updatedate").Value = a
                    myCommand2.Parameters.Add("@itemcode", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@itemcode").Value = DataGridView1.Rows(i).Cells(0).Value
                    myCommand2.Parameters.Add("@cabang", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@cabang").Value = DataGridView1.Rows(i).Cells(2).Value
                    myCommand2.Prepare()
                    myCommand2.ExecuteNonQuery()
                Else
                    Dim myCommand2 As SqlCommand = New SqlCommand("insert into minmaxproint(itemcode,itemname,cabang,minstock,maxstock,haricek,updateby,updatedate) values(@itemcode,@itemname,@cabang,@minstock,@maxstock,@haricek,@updateby,@updatedate)", MyConnection2)
                    Dim a As String = Format(Now, "yyyy-MM-dd")
                    myCommand2.CommandType = CommandType.Text
                    myCommand2.Parameters.Add("@itemcode", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@itemcode").Value = DataGridView1.Rows(i).Cells(0).Value
                    myCommand2.Parameters.Add("@itemname", SqlDbType.VarChar, 250)
                    myCommand2.Parameters("@itemname").Value = DataGridView1.Rows(i).Cells(1).Value
                    myCommand2.Parameters.Add("@cabang", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@cabang").Value = DataGridView1.Rows(i).Cells(2).Value
                    myCommand2.Parameters.Add("@minstock", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@minstock").Value = DataGridView1.Rows(i).Cells(3).Value
                    myCommand2.Parameters.Add("@maxstock", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@maxstock").Value = DataGridView1.Rows(i).Cells(4).Value
                    myCommand2.Parameters.Add("@haricek", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@haricek").Value = DataGridView1.Rows(i).Cells(5).Value
                    myCommand2.Parameters.Add("@updateby", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@updateby").Value = Main.Label1.Text
                    myCommand2.Parameters.Add("@updatedate", SqlDbType.VarChar, 100)
                    myCommand2.Parameters("@updatedate").Value = a
                    myCommand2.Prepare()
                    myCommand2.ExecuteNonQuery()
                End If
            End If
        Next

        MessageBox.Show("Import Finished. Imported = " + Format(berhasil) + ", Error = " + Format(gagal))
    End Sub
End Class
