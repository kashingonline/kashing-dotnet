<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Transaction.aspx.vb" Inherits="Kashing.Payments.Init_Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color:darkkhaki;
        }
        .auto-style3 {
            width: 209px;
        }
        .auto-style4 {
            width: 208px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="https://github.com/securityicon/kashing-dotnet">https://github.com/securityicon/kashing-dotnet</a><br />
            <br />
            Kashing Transaction Sample<br />
            <br />
             </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Init Transaction</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Amount</td>
                <td>
                    <asp:TextBox ID="txtAmount" runat="server" MaxLength="5" TextMode="Number" Width="20%">123</asp:TextBox>
                &nbsp;( in cents)</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Result</td>
                <td>
                    <asp:TextBox ID="txtResultInit" runat="server" Height="122px" TextMode="MultiLine" Width="95%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnInitTransaction" runat="server" Text="Init Transaction" Width="20%" />
                </td>
            </tr>
            </table>
    <p>
        &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Refund Transaction</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Amount</td>
                <td>
                    <asp:TextBox ID="txtRefundAmount" runat="server" Width="20%"></asp:TextBox>
                &nbsp;(in cents)</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Token (token from Init_Transaction)</td>
                <td>
                    <asp:TextBox ID="txtToken" runat="server" Width="40%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Result</td>
                <td>
                    <asp:TextBox ID="txtResultRefund" runat="server" Height="117px" TextMode="MultiLine" Width="95%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnRefund" runat="server" Text="Refund Transaction" Width="20%" />
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
