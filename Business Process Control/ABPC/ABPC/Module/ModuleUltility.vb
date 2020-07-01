Imports System.Data.SqlClient
Module ModuleUltility


    Sub LoadComboBox1(cmb As ComboBox, strSQL As String, strValue As String, strMember As String)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase1()
            cmd = New SqlCommand(strSQL, Koneksi1)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi1.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strValue
            cmb.DisplayMember = strMember
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try

    End Sub



    Sub LoadComboBox2(cmb As ComboBox, strSQL As String, strValue As String, strMember As String)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Try
            KoneksiDatabase2()
            cmd = New SqlCommand(strSQL, Koneksi2)
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            adapter.Dispose()
            cmd.Dispose()
            Koneksi2.Close()
            cmb.DataSource = ds.Tables(0)
            cmb.ValueMember = strValue
            cmb.DisplayMember = strMember
        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try

    End Sub





End Module
