Imports System.Data.SqlClient
Public Class Form1

    Public conn As SqlConnection
    Public server As String
    Public conn_server As String
    Public conn_user As String
    Public conn_pass As String
    Public conn_database As String


    Public Function koneksiMenu() As Boolean
        Try

            'server = "data source={0};user id={1};password={2};initial catalog={3}"

            server = "data source=" & conn_server & ";user id=" & conn_user & ";password=" & conn_pass & ";initial catalog=" & conn_database & ";Application Name=Anyar Gadget 1.1;MultipleActiveResultSets=True  "
            server = String.Format(server, conn_server, conn_user, conn_pass, conn_database)

            conn = New SqlConnection(server)
            conn.Open()


            Return True
        Catch ex As Exception
            MsgBox("Connection Error" + vbNewLine + "Please Check Setting Info!", MsgBoxStyle.Critical, "ERROR")

            Return False
        End Try

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        conn_server = "10.1.0.53"
        conn_database = "RKM_LIVE_2"
        conn_pass = "h0spit4lity#"
        conn_user = "sa"

        koneksiMenu()
        Dim command As SqlCommand
        command = New SqlCommand("_TmSp_HargaJualForPriceTag", conn)

        Dim adapter As New SqlDataAdapter(command)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@PriceList", "4")
        command.Parameters.AddWithValue("@KodeBarang1", "")
        command.Parameters.AddWithValue("@Kodebarang2", "")

        Dim TABLE As New DataTable
        adapter.Fill(TABLE)


        For i = 0 To TABLE.Rows.Count - 1

            With ListView1
                .BeginUpdate()
                .Items.Add(TABLE.Rows(i)("Keterangan"))

                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("ItemCode"))
                    .Add(TABLE.Rows(i)("ItemName"))
                    .Add(TABLE.Rows(i)("HargaJual"))
                End With
                .EndUpdate()
            End With

            TextBox1.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(1)

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
End Class
