
' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-18

Public Class Constants

    ' Init Transaction end-point
    Public Const InitTransaction As String = "https://staging-api.kashing.co.uk/transaction/init"
    ' Refund Transaction end-point
    Public Const RefundTransaction As String = "https://staging-api.kashing.co.uk/transaction/refund"
    ' Get Transaction end-point
    Public Const GetTransaction As String = "https://staging-api.kashing.co.uk/transaction/find"

    ' The Orginization Secret Key
    Public Const OrgSecret As String = "4bde-c32b-5adb-2624-a001-94a6"

    '' Constant Values for this Example
    Public Const merchantid As String = "167"
    Public Const currency As String = "GBP"
    Public Const returnurl = "https://merchant.com/browsersuccess"
    Public Const notifyurl = "https://server-to-server.merchant.com/notify"
    Public Const merchanturl = "https://merchant.com/continue-shopping"
    Public Const description = "1 x Test order from"
    Public Const language = "en"
    Public Const email = "client@email.net"
    Public Const phone = "07770000000"
    Public Const firstname = "Barry"
    Public Const lastname = "O’Conner"
    Public Const address1 = "Flat 6 Primrose Rise"
    Public Const address2 = "347 Lavender Road"
    Public Const city = "Northampton"
    Public Const postcode = "NN17 8YG"
    Public Const country = "UK"
    Public Const datetocomplete = "2022-01-01"
    Public Const uid = "Trans1"
    Public Const pid = "232"
    Public Const processtype = 1
    Public Const method = "1"
    '' Constant Values for this Example

End Class
