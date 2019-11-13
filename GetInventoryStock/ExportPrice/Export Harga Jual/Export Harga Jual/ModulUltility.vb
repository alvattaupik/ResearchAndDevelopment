Imports System.Data.SqlClient
Module ModulUltility
    Sub MsubPesanError()
        MsgBox("Kesalahan :" & Err.Description, vbCritical, "Silahkan Hubungi IT - Department")
    End Sub

    Sub NumberOnly(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Sub NotAllowSpecialCharacter(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 126)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub



    Public Function fConvert(ByVal sStr As String) As String
        Dim i As Integer
        Dim sBadChar As String

        ' List all illegal/unwanted characters
        sBadChar = "/<>?\/*:'"

        ' Loop through all the characters of the string
        ' checking whether each is an illegal character
        For i = 1 To Len(sStr)
            If InStr(sBadChar, Mid(sStr, i, 1)) Then
                Mid(sStr, i, 1) = " "
            End If
        Next i
        fConvert = sStr
    End Function



    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function




End Module

