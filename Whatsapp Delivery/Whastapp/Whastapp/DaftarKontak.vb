Public Class DaftarKontak
    Public Sub New(ByVal contacts As IList(Of String))
        ' This call is required by the designer.
        InitializeComponent()

        Dim noUrut = 1

        For Each contact As String In contacts

            ListView1.Items.Add(String.Format("{0}. {1}", noUrut, contact))
            noUrut += 1
        Next
    End Sub
End Class