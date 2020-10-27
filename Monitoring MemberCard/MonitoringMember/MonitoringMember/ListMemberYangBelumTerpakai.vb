Imports System.Data.SqlClient
Public Class ListMemberYangBelumTerpakai


    Sub RefreshStokNoMember()
        Try
            KoneksiDB_EMAIL()
            Dim command As SqlCommand
            command = New SqlCommand("[tmsp_AvailableMember]", koneksiIvend)

            Dim adapter As New SqlDataAdapter(command)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("KodeCabang", MstrKodeCabang)

            Dim table As New DataTable
            adapter.Fill(table)
            Me.dgAvailableMember.DataSource = table
            dgAvailableMember.DataSource = table

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub


    Private Sub ListMemberYangBelumTerpakai_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshStokNoMember()
    End Sub
End Class