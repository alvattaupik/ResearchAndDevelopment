Imports System.Data.SqlClient

Module ModulKoneksi


    Public Sub KoneksiDatabase()
        strKoneksi = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & "master" & ";MultipleActiveResultSets=True  "
        strKoneksi = String.Format(strKoneksi, strServerName, strLoginName, strPasswordLogin, "master")

        Koneksi = New SqlConnection(strKoneksi)

        Try
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Public Sub KoneksiDatabase2()



        strKoneksi2 = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDatabase2 & ";Application Name=SQLServer Monitoring Tools 1.1;MultipleActiveResultSets=True  "
        strKoneksi2 = String.Format(strKoneksi2, strServerName, strLoginName, strPasswordLogin, strNamaDatabase2)

        Koneksi2 = New SqlConnection(strKoneksi2)

        Try
            If Koneksi2.State = ConnectionState.Closed Then
                Koneksi2.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub


    Public Sub KoneksiDatabase3()



        strKoneksi3 = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDatabase2 & ";Application Name=SQLServer Monitoring Tools 1.1;MultipleActiveResultSets=True  "
        strKoneksi3 = String.Format(strKoneksi3, strServerName, strLoginName, strPasswordLogin, strNamaDatabase2)

        Koneksi3 = New SqlConnection(strKoneksi3)

        Try
            If Koneksi3.State = ConnectionState.Closed Then
                Koneksi3.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub






    Public Sub KoneksiDatabase4()



        strKoneksi4 = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDatabase2 & ";Application Name=SQLServer Monitoring Tools 1.1;MultipleActiveResultSets=True  "
        strKoneksi4 = String.Format(strKoneksi4, strServerName, strLoginName, strPasswordLogin, strNamaDatabase2)

        Koneksi4 = New SqlConnection(strKoneksi4)

        Try
            If Koneksi4.State = ConnectionState.Closed Then
                Koneksi4.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub




    Public Sub KoneksiDatabase5()

        strKoneksi5 = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDatabase2 & ";Application Name=SQLServer Monitoring Tools 1.1;MultipleActiveResultSets=True  "
        strKoneksi5 = String.Format(strKoneksi5, strServerName, strLoginName, strPasswordLogin, strNamaDatabase2)
        Koneksi5 = New SqlConnection(strKoneksi5)

        Try
            If Koneksi5.State = ConnectionState.Closed Then
                Koneksi5.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub



    Public Sub KoneksiDatabase6()

        strKoneksi6 = "data source=" & strServerName & ";user id=" & strLoginName & ";password=" & strPasswordLogin & ";initial catalog=" & strNamaDatabase2 & ";Application Name=SQLServer Monitoring Tools 1.1;MultipleActiveResultSets=True  "
        strKoneksi6 = String.Format(strKoneksi6, strServerName, strLoginName, strPasswordLogin, strNamaDatabase2)
        Koneksi6 = New SqlConnection(strKoneksi6)

        Try
            If Koneksi6.State = ConnectionState.Closed Then
                Koneksi6.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub





End Module
