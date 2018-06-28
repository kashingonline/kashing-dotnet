
Imports System.IO
Imports System.Net
Imports Kashing.Payments.Constants
Imports Newtonsoft.Json

' Kashing Limited 2018
' Create by Heinrich Glover
' heinrich.glover@hotmail.com
' 2018-06-15

Public Class Transaction_Action

    ''' <summary>
    ''' ' Initiate a Transaction
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Public Function Init_Transaction(amount As String) As String
        Dim transactions As List(Of Transaction) = BuildTransaction(amount)
        Dim json As String = ToJson(transactions)
        Dim jsonConcate As String = StringUtil.getValuesFromJson(json)
        Dim psign As String = StringUtil.PSign(OrgSecret, jsonConcate)

        transactions.Item(0).psign = psign
        json = ToJson(transactions)
        json = "{""transactions"":" + json + "}"
        Dim uri As Uri = New Uri(InitTransaction)

        Dim output = ServiceCall(uri, json)
        Return output
    End Function

    ''' <summary>
    ''' ' Refund a Transaction
    ''' </summary>
    ''' <param name="transactionId"></param>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Public Function Refund_Transaction(transactionId As String, amount As String) As String
        Dim refundTransaction As TransactionRefund = BuildTransactionRefund(transactionId, amount)
        Dim json As String = ToJson(refundTransaction)
        Dim jsonConcate As String = StringUtil.getValuesFromJson(json)
        Dim psign As String = StringUtil.PSign(OrgSecret, jsonConcate)

        refundTransaction.psign = psign
        json = ToJson(refundTransaction)

        Dim uri As Uri = New Uri(Constants.RefundTransaction)

        Dim output = ServiceCall(uri, json)
        Return output
    End Function

    ''' <summary>
    ''' ' From Object to Json
    ''' </summary>
    ''' <param name="t"></param>
    ''' <returns></returns>
    Public Shared Function ToJson(t As Object) As String
        Dim json As String = JsonConvert.SerializeObject(t)
        Return json
    End Function

    ''' <summary>
    ''' ' Do a service call
    ''' </summary>
    ''' <param name="uri"></param>
    ''' <param name="json"></param>
    ''' <returns></returns>
    Private Function ServiceCall(uri As Uri, json As String) As String
        Dim req As WebRequest = WebRequest.Create(uri)
        Dim encoding As New System.Text.UTF8Encoding()
        Dim jsonDataBytes As Byte() = encoding.GetBytes(json)
        Dim contentType = "text/plain;charset=utf-8"
        Dim method = "POST"
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length

        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Close()

        Dim res = ""
        Try
            Dim response = req.GetResponse().GetResponseStream()
            Dim reader As New StreamReader(response)
            res = reader.ReadToEnd()
            reader.Close()
            response.Close()
        Catch ex As Exception
            Return ex.Message
        End Try

        Return res
    End Function

    ''' <summary>
    ''' ' Build the Transaction Object for Init Transaction
    ''' </summary>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Function BuildTransaction(amount As String) As IList(Of Transaction)
        Dim TransactionArray As List(Of Transaction) = New List(Of Transaction)
        Dim transaction As Transaction = New Transaction With {
            .returnurl = Constants.returnurl,
            .merchantid = Constants.merchantid,
            .currency = Constants.currency,
            .description = Constants.description,
            .processtype = Constants.processtype,
            .amount = amount,
            .notifyurl = Constants.notifyurl,
            .merchanturl = Constants.merchanturl,
            .language = Constants.language,
            .email = Constants.email,
            .phone = Constants.phone,
            .firstname = Constants.firstname,
            .lastname = Constants.lastname,
            .address1 = Constants.address1,
            .address2 = Constants.address2,
            .city = Constants.city,
            .postcode = Constants.postcode,
            .country = Constants.country,
            .datetocomplete = Constants.datetocomplete,
            .uid = Constants.uid,
            .pid = Constants.pid,
            .method = Constants.method,
            .psign = ""
        }
        TransactionArray.Add(transaction)
        Return TransactionArray
    End Function

    ''' <summary>
    ''' ' Build the Refund Object for Refunding a Transaction
    ''' </summary>
    ''' <param name="transactionid"></param>
    ''' <param name="amount"></param>
    ''' <returns></returns>
    Function BuildTransactionRefund(transactionid As String, amount As String) As TransactionRefund
        Dim transactionRefund As TransactionRefund = New TransactionRefund With {
                .merchantid = Constants.merchantid,
                .refundamount = amount,
                .transactionid = transactionid,
                .psign = ""
            }

        Return transactionRefund
    End Function

End Class
