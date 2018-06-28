
' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-27

Public Class pSign_test
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ''' <summary>
    ''' Calculate the psign aka SHA1 of the String
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnCalcPsign_Click(sender As Object, e As EventArgs) Handles btnCalcPsign.Click
        reset()
        Dim jsonConcate As String = StringUtil.getValuesFromJson(txtJson.Text)
        Dim combine As String = txtKey.Text + jsonConcate
        txtCombine.Text = combine
        Dim psign As String = StringUtil.PSign(txtKey.Text, jsonConcate)
        txtPSign.Text = psign
    End Sub

    Protected Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        reset()
    End Sub

    Protected Sub txtJson_TextChanged(sender As Object, e As EventArgs) Handles txtJson.TextChanged
        reset()
    End Sub

    Sub reset()
        txtCombine.Text = ""
        txtPSign.Text = ""
    End Sub

End Class