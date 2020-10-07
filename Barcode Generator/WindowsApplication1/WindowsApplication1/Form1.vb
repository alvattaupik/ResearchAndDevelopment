Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.IO
Imports System.Drawing.Imaging

Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtStart.TextLength > 15 Or txtEnd.TextLength > 15 Then
            MsgBox("No Voucher Tidak boleh kurang atau lebih dari 15 Digit yang diperbolehkan!, Silahkan periksa kembali", vbCritical, "Penting!")
            Exit Sub
        End If


        If txtStart.Text = "" Or txtEnd.Text = "" Then
            MsgBox("No Voucher Start dan End Tidak Boleh Kosong!", vbCritical, "Penting!")
            Exit Sub
        End If



        If MsgBox("Apakah yakin Anda Akan Membuat No Voucher dari " & txtStart.Text & " Sampai No " & txtEnd.Text, vbYesNo, "Konfirmasi") = vbYes Then
            'Call GenerateNoMember()

            TampilkanNoVoucher()

            'GenerateBarcode()
            GenerateQRCode2()


        Else
            Exit Sub
        End If










    End Sub



    Sub TampilkanNoVoucher()


        Try
            KoneksiDatabaseDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("Fn_GenerateNoVoucher", Koneksi1)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@startnum", Trim(txtStart.Text))
            command.Parameters.AddWithValue("@endnum", Trim(txtEnd.Text))
            command.Parameters.AddWithValue("@status", "R")

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgNoVoucher.DataSource = table
            dgNoVoucher.DataSource = table

            lblJumlahVoucher.Text = "Jumlah Voucher: " & dgNoVoucher.RowCount
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub



    Sub GenerateBarcode()

        For i As Integer = 0 To dgNoVoucher.Rows.Count - 1

            Dim gen As New QRCoder.QRCodeGenerator
            Dim data = gen.CreateQrCode(dgNoVoucher.Rows(i).Cells(1).Value, QRCoder.QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCoder.QRCode(data)
            PictureBox1.Image = code.GetGraphic(16)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            'Dim pic As Image
            'OpenFileDialog1.ShowDialog()
            'pic = New Bitmap(OpenFileDialog1.FileName)
            'PictureBox1.Image = pic

            Dim path As String
            Dim pic As Image
            pic = PictureBox1.Image
            'SaveFileDialog1.ShowDialog()

            pic.Save("D:\Barcode\" & dgNoVoucher.Rows(i).Cells(0).Value & ".png")

        Next

        Exit Sub

    End Sub




    Sub GenerateQRCode2()
        For i As Integer = 0 To dgNoVoucher.Rows.Count - 1

            'Dim code As String = dgNoVoucher.Rows(i).Cells(1).Value
            Dim gen As New QRCoder.QRCodeGenerator
            Dim data = gen.CreateQrCode(dgNoVoucher.Rows(i).Cells(1).Value, QRCoder.QRCodeGenerator.ECCLevel.H)

            'Dim data = gen.CreateQrCode(strKode, QRCoder.QRCodeGenerator.ECCLevel.Q)
            Dim code As New QRCoder.QRCode(Data)
            Dim bitMap As Bitmap = code.GetGraphic(5)

            Using ms As MemoryStream = New MemoryStream()
                bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                PictureBox1.Image = bitMap
                PictureBox1.Height = bitMap.Height
                PictureBox1.Width = bitMap.Width
            End Using

            Dim x1 As Integer = 0
            Dim x2 As Integer = Math.Max(PictureBox1.Image.Width, PictureBox1.Image.Width)
            Dim y1 As Integer = 0
            Dim y2 As Integer = Math.Max(PictureBox1.Image.Height, PictureBox1.Image.Height)
            Dim rect1 As Rectangle = New Rectangle(New Point(x1, y1), PictureBox1.Image.Size)
            Dim firstLocation As PointF = New PointF(17.0F, 145.0F)
            'Dim firstLocation As PointF = New PointF(0.0F, 145.0F)
            Dim secondLocation As PointF = New PointF(30.0F, 50.0F)



            Using graphics As Graphics = graphics.FromImage(bitMap)

                Using arialFont As Font = New Font("Arial", 9)
                    graphics.DrawString(dgNoVoucher.Rows(i).Cells(1).Value, arialFont, Brushes.Black, firstLocation)
                    graphics.DrawImage(PictureBox1.Image, rect1)
                End Using

                Dim g As Graphics = graphics.FromImage(bitMap)
                g.DrawString(dgNoVoucher.Rows(i).Cells(1).Value, New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, 18, 130)

                bitMap.Save("D:\Barcode\" & dgNoVoucher.Rows(i).Cells(0).Value & ".png", ImageFormat.Png)
            End Using

        Next

        Exit Sub
    End Sub


    Private Function CreateLabeledAvatar(av As Image, bg As Color, text As String) As Image

        ' fixed size?
        Dim bmp As New Bitmap(250, 250)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using br As New SolidBrush(bg)
                g.FillRectangle(br, 0, 0, bmp.Width, bmp.Height)
            End Using
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.CompositingQuality = CompositingQuality.HighQuality
            g.TextRenderingHint = TextRenderingHint.AntiAlias
            g.SmoothingMode = SmoothingMode.HighQuality
            g.DrawImage(av, 0, 0, bmp.Width, bmp.Height)

            ' lastly the text, centred on the new image
            ' could also draw to the AV passed to center on IT
            Using fnt As New Font("Arial", 32, FontStyle.Bold, GraphicsUnit.Pixel)
                TextRenderer.DrawText(g, text, fnt, New Rectangle(0, 0, 250, 250),
                      Color.WhiteSmoke,
                      TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            End Using

        End Using

        Return bmp
    End Function

End Class
