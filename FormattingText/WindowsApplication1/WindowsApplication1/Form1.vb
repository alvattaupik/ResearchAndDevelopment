Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Target As String = ""
        RichTextBox1.Text = "Error(DL001)-Alamat Fullfill Tidak Sama dengan Alamat Customer! System.Exception: DI:Invalid value  [OINV.ShipToCode] " & _
                     "at ReplicationSBOIntegrationWinSer.IntegrationObjects.Base.ARReserveInvoice.CreateARReserveInvoice(DataRow[] objDataRow, DataRow[] objDataRowSurcharges, DataSet ObjDataSetTransactionAttribute, DataSet ObjDataSetTransactionLineAttribute, Decimal passedRoundingAmount, Decimal& roundingAmount, Boolean& isRolledBack)" & _
                     "at ReplicationSBOIntegrationWinSer.IntegrationObjects.Transactions.Replicate(Direction From, Direction To, Int32 DatasetRowID)" & _
                     "at ReplicationSBOIntegrationWinSer.Integrator.MainStart(DateTime LastRetryAt, Boolean& Retried'"




        If Microsoft.VisualBasic.Left(RichTextBox1.Text, 12) = "Error(DL001)" Then

            Target = "Alamat Fullfill Tidak Sama dengan Alamat Customer!"
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Alamat Fullfill Tidak Sama dengan Alamat Customer!"
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font("Times New Roman", 14)
            RichTextBox1.SelectionColor = Color.Blue

            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = 0
        End If



        If Microsoft.VisualBasic.Left(RichTextBox1.Text, 12) = "Error(CUS001)" Then

            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font("Times New Roman", 14)
            RichTextBox1.SelectionColor = Color.Blue

            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = 0
        End If


        If Microsoft.VisualBasic.Left(RichTextBox1.Text, 12) = "Error(IV001)" Then

            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold Or FontStyle.Underline)


            Target = "Nama Customer Berisi karakter unik Lainnya seperti tanda kurung, Pastikan Hanya Alphabet Ya "
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(Target)
            RichTextBox1.SelectionLength = Target.Length
            RichTextBox1.SelectionFont = New Font("Times New Roman", 14)
            RichTextBox1.SelectionColor = Color.Blue

            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = 0
        End If








    End Sub














End Class
