Public Class IntegrationSetting

    Private Sub IntegrationSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNilai.Text = My.Settings.NilaiDurasi
        cmbSatuan.Text = My.Settings.SatuanDurasi

        If My.Settings.StatusIntegrasi = "1" Then
            rbAktif.Checked = True
        Else
            rbNonAktif.Checked = False
        End If

        If My.Settings.StatusIntegrasi = "" Then
            rbAktif.Checked = False
            rbNonAktif.Checked = False
        End If


    End Sub

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click


        If rbAktif.Checked = False And rbNonAktif.Checked = False Then
            MsgBox("Status Layanan Integrasi Harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If


        If cmbSatuan.Text = "" Then
            MsgBox("Satuan Durasi Integrasi harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If

        If txtNilai.Text = "" Then
            MsgBox("Nilai Durasi Integrasi harus Di Isi", vbCritical, "Penting!")
            Exit Sub
        End If

        With My.Settings
            If rbAktif.Checked = True Then
                .StatusIntegrasi = "1"
            Else
                .StatusIntegrasi = "0"
            End If


            .SatuanDurasi = cmbSatuan.Text
            .NilaiDurasi = txtNilai.Text
            .Save()

            MsgBox("Silahkan Login Ulang", vbInformation, "Sukses!")
            Exit Sub

        End With



    End Sub
End Class