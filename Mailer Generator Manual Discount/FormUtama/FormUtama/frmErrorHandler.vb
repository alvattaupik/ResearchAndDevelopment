Public Class frmErrorHandler

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        With My.Settings

            .PenerimaPesanError = Trim(txtRecepientError.Text)
            .CCError = Trim(txtCC.Text)
            .SubjectError = Trim(txtSubjectError.Text)
            .BodyError = Trim(txtBodyError.Text)
            .FooterError = Trim(txtFooterError.Text)
            .HeaderError = Trim(txtHeaderError.Text)

            .Save()
            MsgBox("Konfigurasi berhasil disimpan", vbInformation, "Sukses!")

        End With
    End Sub

    Private Sub frmErrorHandler_ImeModeChanged(sender As Object, e As EventArgs) Handles Me.ImeModeChanged

    End Sub

    Private Sub frmErrorHandler_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetErrorHandler()
        txtRecepientError.Text = strPenerimaPesanError
        txtCC.Text = strCCError
        txtSubjectError.Text = strSubjectError
        txtBodyError.Text = strBodyError
        txtFooterError.Text = strFooterError
        txtHeaderError.Text = strHeaderError
    End Sub
End Class