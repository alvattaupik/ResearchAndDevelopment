Public Class SettingAplikasi

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click
        If txtDelaySendMessageLampiran.Text = "" Then
            MsgBox("Durasi Delay Send Message Dengan Lampiran Harus Di Isi", vbInformation, "Penting!")
            Exit Sub
        End If

        If txtDelaySendMessageTanpaLampiran.Text = "" Then
            MsgBox("Durasi Delay Send Message Tanpa Lampiran Harus Di Isi", vbInformation, "Penting!")
            Exit Sub
        End If



        If cmbSatuanInterval.Text = "" Then
            MsgBox("Satuan Interval Harus Di Isi", vbInformation, "Penting!")
            Exit Sub
        End If

        If txtDurasi.Text = "" Then
            MsgBox("Durasi Interval Harus Di Isi", vbInformation, "Penting!")
            Exit Sub
        End If




        With My.Settings

            .PathExport = txtpathExportDocument.Text
            .DelayMessageLampiran = txtDelaySendMessageLampiran.Text
            .DelayMessageTanpaLampiran = txtDelaySendMessageTanpaLampiran.Text

            '.DelayBCLampiran = txtBCLampiran.Text
            '.DelayBCTanpaLampiran = txtBCTanpaLampiran.Text

            .SatuanInterval = cmbSatuanInterval.Text
            .NilaiInterval = txtDurasi.Text
            .LokasiFileReport = txtLokasiFile.Text

            .Save()
            MsgBox("Konfigurasi Berhasil Disimpan, Silahkan Restart Aplikasi", vbInformation, "Sukses!")
            Exit Sub
        End With

    End Sub





    Sub LoadKonfigurasi()
        With My.Settings
            txtpathExportDocument.Text = .PathExport
            txtDelaySendMessageLampiran.Text = .DelayMessageLampiran
            txtDelaySendMessageTanpaLampiran.Text = .DelayMessageTanpaLampiran

            'txtBCLampiran.Text = .DelayBCLampiran
            'txtBCTanpaLampiran.Text = .DelayBCTanpaLampiran

            cmbSatuanInterval.Text = .SatuanInterval
            txtDurasi.Text = .NilaiInterval
            txtLokasiFile.Text = .LokasiFileReport

        End With
    End Sub



    Private Sub SettingAplikasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadKonfigurasi()
    End Sub
End Class