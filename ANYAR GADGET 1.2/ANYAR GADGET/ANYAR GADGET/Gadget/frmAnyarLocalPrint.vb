Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmAnyarLocalPrint



    Private Sub cmbJenisDokumen_Click(sender As Object, e As EventArgs) Handles cmbJenisDokumen.Click
        Dim strQuery As String = "SELECT  FormUser1.KodeDetail , Deskripsi" & _
                                 " FROM dbo.FormUser1" & _
                                 " LEFT OUTER JOIN dbo.Form1 ON Form1.KodeAplikasi = FormUser1.KodeAplikasi" & _
                                 " AND Form1.KodeForm = FormUser1.KodeForm" & _
                                 " AND Form1.KodeDetail = FormUser1.KodeDetail WHERE FormUser1.UserNameLogin='" & MstrUsernameLogin & "' AND dbo.FormUser1.KodeAplikasi='" & MstrKodeAplikasi & "' AND dbo.FormUser1.KodeForm='frmAnyarLocalPrint' AND FormUser1.StatusEnabled='Y'"
        Call KoneksiDB_EMAIL()
        LoadComboBox(cmbJenisDokumen, strQuery, "KodeDetail", "Deskripsi", KoneksiDBEmail)
    End Sub


    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If txtNoDokumen.Text = "" Then
            DisplayPesanError("Nomor Dokumen Harus Di Isi", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If


        If cmbJenisDokumen.Text = "" Then
            DisplayPesanError("Jenis Dokumen Harus Di Pilih", frmMainMenu.txtPesanError, 1000)
            Exit Sub
        End If

        If cmbJenisDokumen.SelectedValue = "ODLN001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ODLN WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If
        If cmbJenisDokumen.SelectedValue = "OIGE001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OIGE WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "OIGN001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OIGN WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "OPDN001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OPDN WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If
        'Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OPKL WHERE DocNum='" & Trim(cmbJenisDokumen.SelectedValue) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        If cmbJenisDokumen.SelectedValue = "ORCT001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ORCT WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "ORDN001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ORDN WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "ORDR001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ORDR WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "ORPD001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.ORPD WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "OVPM001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OVPM WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If

        If cmbJenisDokumen.SelectedValue = "OWTQ001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OWTQ WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If
        If cmbJenisDokumen.SelectedValue = "OWTR001" Then
            Call DisplayAnyarLocalPrintCrystalReport("SELECT Top 1 Cast(DocEntry as VARCHAR(100)) AS DocEntry FROM dbo.OWTR WHERE DocNum='" & Trim(txtNoDokumen.Text) & "'", cmbJenisDokumen.SelectedValue, MstrKodePegawai, crvDokumen)
        End If
    End Sub




    Private Sub picSettingTemplate_Click(sender As Object, e As EventArgs) Handles picSettingTemplate.Click
        frmTemplate.ShowDialog()
    End Sub
End Class