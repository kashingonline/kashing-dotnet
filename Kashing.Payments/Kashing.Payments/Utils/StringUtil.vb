Imports System.IO
Imports System.Security.Cryptography

' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-18

Public Class StringUtil

    ''' <summary>
    ''' PSIGN
    ''' </summary>
    ''' <param name="orgId"></param>
    ''' <param name="json"></param>
    ''' <returns></returns>
    Public Shared Function PSign(orgId As String, json As String) As String
        Dim sSourceData As String
        sSourceData = orgId + json
        If (json.Contains("{")) Then
            sSourceData = orgId + getValuesFromJson(json)
        End If
        Return Sha1(sSourceData)
    End Function

    Public Shared Function Sha_1(ByVal input As String) As String
        ' get the SHA1 Object
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        ' Convert the String to a Byte[]
        ''Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(input)
        Dim bytesToHash() As Byte = System.Text.Encoding.UTF8.GetBytes(input)

        ' Calculate the SHA1 of the Byte[[]
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        ' Conver the SHA1 Byte[] to an Hex String
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult

    End Function

    ''' <summary>
    ''' Get the SHA1 for the seleted String
    '''  ' Tested with online sha1 calculator at http://www.sha1-online.com
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Public Shared Function Sha1(ByVal input As String) As String
        'input = "4bde-c32b-5adb-2624-a001-94a6167123GBP11 x Test order from1https://merchant.com/browsersuccesshttps://server-to-server.merchant.com/notifyhttps://merchant.com/continue-shoppingenclient@email.net07770000000BarryO'ConnerFlat 6 Primrose Rise347 Lavender RoadNorthamptonNN17 8YGUK2022-01-01O-999992321"
        ' get the SHA1 Object
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider

        ' Convert the String to a Byte[]
        ''Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(input)
        Dim bytesToHash() As Byte = System.Text.Encoding.UTF8.GetBytes(input)

        ' Calculate the SHA1 of the Byte[[]
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        ' Conver the SHA1 Byte[] to an Hex String
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult

    End Function

    ''' <summary>
    ''' Concatenate the Values from a jSon String
    ''' </summary>
    ''' <param name="json"></param>
    ''' <returns></returns>
    Public Shared Function getValuesFromJson(json As String) As String
        Dim values = json.Replace("{", "").Replace("}", "").Replace("]", "").Split(",")
        Dim output As String = ""
        For i = 0 To UBound(values)
            Dim item = values(i).Split(":")
            If item(1).Contains("[") Then

                If item.Length > 3 Then
                    If Not item(2).Contains(",") Then
                        Dim temp As String = (item(2).Replace("""", "").Trim().TrimStart() + ":" + item(3).Replace("""", "")).Trim().TrimStart()
                        output += temp
                    End If
                Else
                    If Not item(2).Contains(",") Then
                        output += item(2).Replace("""", "").Trim().TrimStart()
                    End If
                End If

            Else

                If item.Length > 2 Then
                    If Not item(1).Contains(",") Then
                        Dim temp As String = (item(1).Replace("""", "").Trim().TrimStart() + ":" + item(2).Replace("""", "")).Trim().TrimStart()
                        output += temp
                    End If
                Else
                    If Not item(1).Contains(",") Then
                        output += item(1).Replace("""", "").Trim().TrimStart()
                    End If
                End If

            End If
        Next
        Return output

    End Function

End Class
