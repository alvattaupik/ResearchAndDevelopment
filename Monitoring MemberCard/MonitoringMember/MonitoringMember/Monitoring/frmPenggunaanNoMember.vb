Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmPenggunaanNoMember



    Private Sub cmbCabang_Click(sender As Object, e As EventArgs) Handles cmbCabang.Click
        Call Koneksi_SAP()
        LoadComboBox(cmbCabang, "Select PrcCode,PrcName From OPRC Where PrcCode like '0%'", "PrcCode", "PrcName", KoneksiSAP)
    End Sub

    Private Sub cmbPekerjaan_Click(sender As Object, e As EventArgs) Handles cmbPekerjaan.Click
        Call Koneksi_IVEND()
        LoadComboBox(cmbPekerjaan, "SELECT Cast(CustomerGroupKey As varchar(100)) As CustomerGroupKey ,Id FROM dbo.CusCustomerGroup", "CustomerGroupKey", "Id", KoneksiIvend)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboTglRegistrasi.Checked = False
        cmbCabang.SelectedValue = ""
        cmbCabang.Text = ""
        cmbStatus.Text = ""
        cmbJenisKelamin.Text = ""
        cmbPekerjaan.SelectedValue = ""
        cmbPekerjaan.Text = ""
        txtKota.Text = ""
    End Sub
End Class