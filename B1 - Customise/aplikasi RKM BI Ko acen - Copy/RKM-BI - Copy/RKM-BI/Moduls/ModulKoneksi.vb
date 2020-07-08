Imports System.Data.SqlClient

Module ModulKoneksi



    Public Sub KoneksiDatabase()
        strServerName = "10.1.0.53"
        strLoginName = "sa"
        strPasswordLogin = "h0spit4lity#"
        strNamaDB = "RKM_Live_2"

        strKoneksi = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDB & ";Application Name=Business Inteligence ;MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServerName, strLoginName, strPasswordLogin, strNamaDB)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub




    Public Sub KoneksiRKMLive2()
        strServerName = "10.1.0.53"
        strLoginName = "sa"
        strPasswordLogin = "h0spit4lity#"
        strNamaDB = "RKM_Live_2"

        strKoneksi = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDB & ";Application Name=Business Inteligence ;MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServerName, strLoginName, strPasswordLogin, strNamaDB)

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub











    Sub KoneksiDatabaseLoginAplikasi()




        strServerName2 = "10.1.0.4"
        strLoginName2 = "sa"
        strPasswordLogin2 = "stip3ndium"
        strNamaDB2 = "BIDBase"

        strKoneksi2 = "data source=" & strServerName2 & ";user id=" & strLoginName2 & ";password=" & strPasswordLogin2 & ";initial catalog=" & strNamaDB2 & ";Application Name=Business Inteligence ;MultipleActiveResultSets=True  "
        strKoneksi2 = String.Format(strKoneksi2, strServerName2, strLoginName2, strPasswordLogin2, strNamaDB2)

        Koneksi2 = New SqlConnection(strKoneksi2)

        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub


End Module
