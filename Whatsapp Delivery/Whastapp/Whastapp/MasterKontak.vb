Imports System.Data.SqlClient
Public Class MasterKontak

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtDocEntry.Text = ""
        txtKodeExternal.Text = ""
        txtNama.Text = ""
        txtNoTelepon.Text = ""
        txtPesan.Text = ""
        cmbCabang.Text = ""
    End Sub

    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        LoadComboBoxDBLive(cmbCabang, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode NOT LIKE 'Centr%'", "PrcCode", "PrcName")
    End Sub





    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtNoTelepon.Text = "" Then
            MsgBox("NoTelepon Harus Di isi", vbInformation, "Penting !")
            Exit Sub
        End If

        If txtNama.Text = "" Then
            MsgBox("Nama Kontak harus Di Isi", vbInformation, "Penting !")
            Exit Sub
        End If


        If cmbCabang.Text = "" Then
            MsgBox("Cabang Kontak harus Di Isi", vbInformation, "Penting !")
            Exit Sub
        End If



        If txtDocEntry.Text = "" Then

            Call KoneksiDatabase1()
            Dim str As String
            str = "Insert Into KontakWhatsapp Values ('" & txtNoTelepon.Text & "','" & txtNama.Text & "','" & txtPesan.Text & "','" & cmbCabang.SelectedValue & "','" & txtKodeExternal.Text & "', '" & 1 & "')"
            cmd = New SqlCommand(str, Koneksi1)
            cmd.ExecuteNonQuery()

            MsgBox("Data Kontak Berhasil Disimpan", vbInformation, "Sukses")
            LoadKontak()
        Else


            Call KoneksiDatabase1()
            Dim str As String
            str = "Update KontakWhatsapp Set NoTelepon='" & txtNoTelepon.Text & "', NamaPenerima='" & txtNama.Text & "',CustomMessage='" & txtPesan.Text & "',KodeCabang='" & cmbCabang.SelectedValue & "',KodeGroup='" & txtKodeExternal.Text & "' WHere DocEntry='" & txtDocEntry.Text & "'"
            cmd = New SqlCommand(str, Koneksi1)
            cmd.ExecuteNonQuery()

            MsgBox("Data Kontak Berhasil Diupdate", vbInformation, "Sukses")
            LoadKontak()


        End If

    End Sub


    Sub LoadKontak()


        Call KoneksiDatabase1()


        Dim cmd As New SqlCommand("SELECT * FROM dbo.kontakWhatsapp WHERE NamaPenerima Like '%" & Trim(txtCariKontak.Text) & "%'", Koneksi1)

        cmd.CommandTimeout = 0

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)


        dgDaftarKontak.DataSource = table

        dgDaftarKontak.Columns(0).Width = 0
        dgDaftarKontak.Columns(1).Width = 100
        dgDaftarKontak.Columns(2).Width = 500
        dgDaftarKontak.Columns(3).Width = 5000
        dgDaftarKontak.Columns(4).Width = 0
        dgDaftarKontak.Columns(5).Width = 0
        dgDaftarKontak.Columns(6).Width = 0


    End Sub



    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If txtDocEntry.Text = "" Then
            Exit Sub
        End If

        If MsgBox("Apakah Yakin Anda Akan Menghapus Kontak " & txtNama.Text & " ?", vbYesNo, "Konfirmasi?") = vbYes Then



        Else
            Exit Sub
        End If
    End Sub

    Private Sub MasterKontak_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadKontak()
    End Sub

    Private Sub dgDaftarKontak_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDaftarKontak.CellContentClick
        txtDocEntry.Text = dgDaftarKontak.Item(0, dgDaftarKontak.CurrentRow.Index).Value
        txtNoTelepon.Text = dgDaftarKontak.Item(1, dgDaftarKontak.CurrentRow.Index).Value
        txtNama.Text = dgDaftarKontak.Item(2, dgDaftarKontak.CurrentRow.Index).Value
        txtPesan.Text = dgDaftarKontak.Item(3, dgDaftarKontak.CurrentRow.Index).Value
        cmbCabang.SelectedValue = dgDaftarKontak.Item(4, dgDaftarKontak.CurrentRow.Index).Value
    End Sub
End Class