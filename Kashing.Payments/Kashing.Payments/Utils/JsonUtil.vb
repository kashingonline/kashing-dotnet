Imports Newtonsoft.Json

' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-18

Public Class JsonUtil(Of T)

    ''' <summary>
    ''' Convert to an Object(T) from json
    ''' </summary>
    ''' <param name="t"></param>
    ''' <param name="json"></param>
    ''' <returns></returns>
    Public Shared Function ToObject(t As T, json As String) As T
        Dim obj As T = JsonConvert.DeserializeObject(Of T)(json)
        Return obj
    End Function

    ''' <summary>
    ''' Convert to Json from a Object(T)
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Public Shared Function ToJson(t As T) As String
        Dim json As String = JsonConvert.SerializeObject(t)
        Return json
    End Function

End Class
