Imports System.Data.SqlClient
Public Class FormMonitoringDelivery

    Dim MyConnection As SqlConnection
    Dim MyCommand As SqlDataAdapter

    'Sub Koneksi()
    '    MyConnection = New SqlConnection("Data Source=" + "10.1.0.53" + ";Initial Catalog=RKM_LIVE_2;User ID=sa;Password=h0spit4lity#")
    '    If MyConnection.State = ConnectionState.Closed Then
    '        MyConnection.Open()
    '    End If

    'End Sub






    Sub LoadDataDelivery()
        KoneksiRKMLive2()
        Dim strSQL As String = "SELECT  TOP 1 CardCode,CardName,(SELECT  TOP 1 isnull(Phone1,'') FROM dbo.OCRD WHERE CardCode=dbo.OINV.CardCode) AS NoTelepon,ISNULL((SELECT  TOP 1 Cast(DocNum As Varchar(30)) FROM dbo.ODLN LEFT OUTER JOIN dbo.DLN1 ON DLN1.DocEntry = ODLN.DocEntry WHERE dbo.DLN1.BaseRef=dbo.OINV.DocNum),'')  AS NoSJ,isnull(ShipToCode,'')+' '+isnull(Address2,'') AS Alamat FROM dbo.OINV WHERE U_CXS_TRID = '" & MstrNoStruk & "' AND isIns='Y' ORDER BY DocDate DESC"
        cmd = New SqlCommand(strSQL, Koneksi)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = True Then

            txtNoStruk.Text = MstrNoStruk
            txtKodeCustomer.Text = dr.GetString(0)

            If dr.GetString(3) = "" Then
                txtNoDelivery.Text = "Belum Di Delivery"
                txtNoDelivery.BackColor = Color.Yellow
            Else
                txtNoDelivery.Text = dr.GetString(3)
                txtNoDelivery.BackColor = Color.White
            End If


            txtNamaCustomer.Text = dr.GetString(1)
            txtNoTelepon.Text = dr.GetString(2)
            txtAlamatDelivery.Text = dr.GetString(4)

            Exit Sub
        Else

            MsgBox("Transaksi Cash And Carry, Tidak Ada Informasi Delivery", vbInformation, "Informasi")

            Exit Sub
        End If
    End Sub







    Sub LoadDaftarItemDelivery()

        Try

            Call KoneksiRKMLive2()
            Dim cmd As New SqlCommand("select (case when t1.invntsttus='O'  then 'Belum Cutoff' when t1.invntsttus='C' then 'Sudah Cutoff' else  '---' END) AS [Status],t1.ItemCode as [Kode Barang],t1.Dscription as [Nama Barang],convert(int,t1.Quantity) as [Quantity],t1.unitmsr as [Satuan],convert(int,t1.PriceAfVAT) as [Harga],convert(int,t1.PriceAfVAT*t1.Quantity) as [Total] from oinv t0 left join inv1 t1 on t1.DocEntry=t0.DocEntry  where t0.U_CXS_TRID='" & txtNoStruk.Text & "'", Koneksi)
            cmd.CommandTimeout = 30
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            dgDaftarItemDelivery.DataSource = table
            dgDaftarItemDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgDaftarItemDelivery.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgDaftarItemDelivery.AutoResizeColumns()
            dgDaftarItemDelivery.RowHeadersVisible = False

        Catch ex As Exception
            MessageBox.Show("Koneksi Kehabisan Waktu")
        End Try




    End Sub






    Private Sub dgDaftarItemDelivery_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgDaftarItemDelivery.CellFormatting
        For i As Integer = 0 To Me.dgDaftarItemDelivery.Rows.Count - 1
            If Trim(Me.dgDaftarItemDelivery.Rows(i).Cells("Status").Value) = "Sudah Cutoff" Then
                Me.dgDaftarItemDelivery.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                Me.dgDaftarItemDelivery.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            ElseIf Trim(Me.dgDaftarItemDelivery.Rows(i).Cells("Status").Value) = "Belum Cutoff" Then
                Me.dgDaftarItemDelivery.Rows(i).DefaultCellStyle.BackColor = Color.White
                Me.dgDaftarItemDelivery.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub FormMonitoringDelivery_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataDelivery()
        LoadDaftarItemDelivery()
    End Sub
End Class