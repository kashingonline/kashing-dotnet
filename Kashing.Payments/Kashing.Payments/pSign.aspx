<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PSign.aspx.vb" Inherits="Kashing.Payments.pSign_test" %>

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
            <h1 align="center">PSIGN TEST</h1>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbJson" runat="server" Width="100" Text="JSON: (without psign)"></asp:Label></td>
                    <td>
        <asp:TextBox ID="txtJson" runat="server" Height="151px" TextMode="MultiLine" Width="1157px">{
    &quot;transactions&quot;: [
        {
            &quot;merchantid&quot;: &quot;167&quot;,
            &quot;amount&quot;: &quot;123&quot;,
            &quot;currency&quot;: &quot;GBP&quot;,
            &quot;description&quot;: &quot;1 x Test order from&quot;,
            &quot;processtype&quot;: 1,
            &quot;returnurl&quot;: &quot;https://merchant.com/browsersuccess&quot;,
            &quot;webhook&quot;: &quot;https://server-to-server.merchant.com/notify&quot;,
            &quot;merchanturl&quot;: &quot;https://merchant.com/continue-shopping&quot;,
            &quot;language&quot;: &quot;en&quot;,
            &quot;email&quot;: &quot;client@email.net&quot;,
            &quot;phone&quot;: &quot;07770000000&quot;,
            &quot;firstname&quot;: &quot;Barry&quot;,
            &quot;lastname&quot;: &quot;O’Conner&quot;,
            &quot;address1&quot;: &quot;Flat 6 Primrose Rise&quot;,
            &quot;address2&quot;: &quot;347 Lavender Road&quot;,
            &quot;city&quot;: &quot;Northampton&quot;,
            &quot;postcode&quot;: &quot;NN17 8YG&quot;,
            &quot;country&quot;: &quot;UK&quot;,
            &quot;datetocomplete&quot;: &quot;2022-01-01&quot;,
            &quot;uid&quot;: &quot;O-99999&quot;,
            &quot;pid&quot;: &quot;232&quot;,
            &quot;method&quot;: &quot;1&quot;       }
    ]
}</asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbKey" runat="server" Width="100" Text="KEY:"></asp:Label></td>
                    <td>
        <asp:TextBox ID="txtKey" runat="server" Width="1150px">4bde-c32b-5adb-2624-a001-94a6</asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbCombine" runat="server" Text="Values Concate:" Width="100"></asp:Label>
                    </td>
                    <td>
        <asp:TextBox ID="txtCombine" runat="server" Height="59px" Width="1151px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbPSign" runat="server" Width="100" Text="PSIGN:"></asp:Label></td>
                    <td>
        <asp:TextBox ID="txtPSign" runat="server" Width="1154px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td align="center">
        <asp:Button ID="btnCalcPsign" runat="server" Text="pSign" Width="174px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
