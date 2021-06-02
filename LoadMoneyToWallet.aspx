<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoadMoneyToWallet.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
        <asp:Label ID="Label1" runat="server" Text="Load Money To Wallet" 
                        style="font-weight: 700; color: #000099; text-align: center; font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    Run this page only after loaded the amount(Rs. 300/-) in TA server. Because 
                    Balance is fetching from TA server and sending SMS to employees</td>
            </tr>
        </table>
    
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server"
            Text="Click here to Load Money" style="font-weight: 700" 
            onclick="Button1_Click1" />
    
    </div>
    </form>
</body>
</html>
