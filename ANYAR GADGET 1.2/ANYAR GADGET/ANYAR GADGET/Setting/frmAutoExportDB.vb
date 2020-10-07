Public Class frmAutoExportDB

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try

            Using O As New OpenFileDialog
                If O.ShowDialog = 1 Then
                    txtLokasiDatabase.Text = O.FileName
                End If
            End Using

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try



    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            With My.Settings
                .P_ExportDatabase = txtLokasiDatabase.Text
                .Save()
            End With

            DisplayPesanOK("Operation Success", frmMainMenu.txtPesanError, 1000)

        Catch ex As Exception
            DisplayPesanError(Err.Description, frmMainMenu.txtPesanError, 1000)
        End Try

    End Sub

    Private Sub frmAutoExportDB_Load(sender As Object, e As EventArgs) Handles Me.Load
        With My.Settings
            txtLokasiDatabase.Text = .P_ExportDatabase
        End With
    End Sub
End Class