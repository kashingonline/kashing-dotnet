Imports System.IO
Imports System.Net

' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-18

Public Class Init_Transaction
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    ''' <summary>
    ''' Initiate the Transaction
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnInitTransaction_Click(sender As Object, e As EventArgs) Handles btnInitTransaction.Click

        '' Init the Transaction
        Dim transaction_init = New Transaction_Action()
        Dim serviceOut As String = transaction_init.Init_Transaction(txtAmount.Text)
        txtResultInit.Text = serviceOut

    End Sub

    ''' <summary>
    ''' Do a Refund on the Init Transaction
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Protected Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
        '' Refund the Transaction
        Dim transaction_init = New Transaction_Action()
        Dim serviceOut As String = transaction_init.Refund_Transaction(txtToken.Text, txtAmount.Text)
        txtResultRefund.Text = serviceOut

    End Sub

End Class