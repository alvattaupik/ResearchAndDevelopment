Public Class FormChangeLog

    Private Sub FormChangeLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = "V.1.1 Build 13.11.19 -" & vbNewLine & "-Bug Fix Read Only Properties in Datagridview" & _
                        "" & vbNewLine & "-Penambahan Menu Strip(file,extra,about), Change Log, dan fitur Show My IP" & _
                        "" & vbNewLine & vbNewLine & "V.1.1 Build 11.11.19" & vbNewLine & _
                        "" & "-Improvement terhadap Query Pencarian Item" & _
                        "" & "-Improvement terhadap Key Event Textbox pencarian Item" & _
                        "" & vbNewLine & "-Penambahan Fungsi Tombol stop ALL Process untuk menghentikan request ke server saat traffic penuh " & _
                        "" & vbNewLine & "-Penambahan Backgroun worker untuk menanggulangi hang saat beberapa backgroup process masih berlangsung"

    End Sub
End Class