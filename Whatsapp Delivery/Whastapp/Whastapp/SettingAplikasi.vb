Public Class SettingAplikasi

    Private Sub cmdSimpan_Click(sender As Object, e As EventArgs) Handles cmdSimpan.Click

        If cmbLokasi.SelectedValue = "" Then
            MsgBox("Lokasi Penggunaan Harus Di Isi", vbInformation, "Penting!")
            Exit Sub
        End If

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
            .SatuanInterval = cmbSatuanInterval.Text
            .NilaiInterval = txtDurasi.Text
            .LokasiFileReport = txtLokasiFile.Text
            .KalimatAutoReply = txtAutoReply.Text
            .KodeCabang = cmbLokasi.SelectedValue
            .NamaCabang = cmbLokasi.Text

            .Save()
            MsgBox("Konfigurasi Berhasil Disimpan", vbInformation, "Sukses!")
            Exit Sub
        End With

    End Sub


    Sub LoadKonfigurasi()
        With My.Settings
            txtpathExportDocument.Text = .PathExport
            txtDelaySendMessageLampiran.Text = .DelayMessageLampiran
            txtDelaySendMessageTanpaLampiran.Text = .DelayMessageTanpaLampiran
            cmbSatuanInterval.Text = .SatuanInterval
            txtDurasi.Text = .NilaiInterval
            txtLokasiFile.Text = .LokasiFileReport
            txtAutoReply.Text = .KalimatAutoReply
            cmbLokasi.Text = .NamaCabang
        End With
    End Sub



    Private Sub SettingAplikasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadKonfigurasi()
    End Sub

    Private Sub cmbLokasi_Click(sender As Object, e As EventArgs) Handles cmbLokasi.Click
        LoadComboBoxDBLive(cmbLokasi, "SELECT PrcCode,PrcName FROM dbo.OPRC WHERE PrcCode NOT LIKE 'Centr%%'", "PrcCode", "PrcName")
    End Sub


    Private Sub cmbSatuanInterval_Click(sender As Object, e As EventArgs) Handles cmbSatuanInterval.Click

    End Sub
End Class