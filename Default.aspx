<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 46%;
            height: 24px;
        }
        .style3
        {
            text-align: center;
        }
        .style4
        {
            width: 46%;
            height: 39px;
        }
        .style1
        {
            width: 44%;
            height: 34px;
        }
        .style5
        {
            width: 61%;
            height: 46px;
        }
        .style6
        {
            text-align: left;
        }
        .style7
        {
            width: 42%;
            height: 62px;
        }
        .style8
        {
            width: 33%;
            height: 38px;
        }
        .style10
        {
            width: 85%;
        }
        .style11
        {
            width: 159px;
            height: 55px;
        }
        .style12
        {
            width: 398px;
            height: 181px;
        }
        .style13
        {
            font-weight: normal;
        }
        .style14
        {
            font-weight: normal;
            width: 244px;
        }
        .style15
        {
            width: 244px;
        }
        .style16
        {
            font-weight: normal;
            width: 247px;
        }
        .style17
        {
            width: 247px;
        }
        .style18
        {
            font-weight: normal;
            width: 240px;
        }
        .style19
        {
            width: 240px;
        }
        .style20
        {
            font-weight: normal;
            width: 221px;
        }
        .style21
        {
            width: 221px;
        }
        .style22
        {
            font-weight: normal;
            width: 173px;
        }
        .style23
        {
            width: 173px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="width: 1664px">
    
        <table class="style10">
            <tr>
                <td align="center">
                    <img alt="" class="style12" src="images/images.jpg" /></td>
            </tr>
        </table>
        <br />
    
        <asp:Panel ID="PanelWalletMobileHead" runat="server">
            <table align="center" class="style2" 
                style="border-style: outset; border-color: #CC99FF">
                <tr>
                    <td class="style3" colspan="2">
                        <asp:Label ID="Label115" runat="server" Font-Size="X-Large" ForeColor="#CC66FF" 
                            style="font-weight: 700; text-decoration: underline" Text="V-eWallet - Mobile"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                            style="font-weight: 700" Text="MERCHANT SIGNUP" ForeColor="#0066CC" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                            style="font-weight: 700" Text="CHANGE MPIN" ForeColor="#0066CC" />
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="Button5" runat="server" onclick="Button5_Click1" 
                            style="font-weight: 700" Text="LOGIN" ForeColor="#0066CC" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                            style="font-weight: 700" Text="ENROLL CUSTOMER" ForeColor="#0066CC" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="Button12" runat="server" onclick="Button12_Click" 
                            style="text-align: center; font-weight: 700;" Text="FUND TRANSFER" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="btnMessage" runat="server" onclick="btnMessage_Click" 
                            style="font-weight: 700" Text="COLLECTION" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="Button21" runat="server" onclick="Button21_Click1" 
                            style="font-weight: 700" Text="WALLET STATEMENT" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="btnMessage1" runat="server" 
                            style="font-weight: 700" Text="RESEND TPIN" onclick="btnMessage1_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="Button38" runat="server" onclick="Button16_Click" 
                            style="font-weight: 700" Text="VIEW PROFILE" ForeColor="#0066CC" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="Button39" runat="server" 
                            style="font-weight: 700" Text="UPDATE PROFILE" ForeColor="#0066CC" 
                            onclick="Button39_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="Button16" runat="server"  
                            style="font-weight: 700" Text="LOGOUT" ForeColor="#0066CC" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="btnMessage2" runat="server" 
                            style="font-weight: 700" Text="RESEND OTP" onclick="btnMessage2_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnMessage3" runat="server" 
                            style="font-weight: 700" Text="VIEW ORDERS" onclick="btnMessage3_Click1" 
                             />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="btnMessage4" runat="server" onclick="btnMessage3_Click" 
                            style="font-weight: 700" Text="WALLET STATEMENT" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnBalanceInq" runat="server" 
                            style="font-weight: 700" Text="BALANCE INQUIRY" 
                            onclick="btnBalanceInq_Click" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="Button40" runat="server" style="font-weight: 700" 
                            Text="Missed Call" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnMiniStmt" runat="server" style="font-weight: 700" 
                            Text="Mini Statement" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="Button13" runat="server" BorderColor="Lime" Font-Bold="True" 
                            onclick="Button13_Click" Text="Back" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnIMPS" runat="server" onclick="btnIMPS_Click" 
                            style="font-weight: 700" Text="IMPS" />
                    </td>
                    <td style="text-align: center">
                        <asp:Button ID="btnIMPS0" runat="server" 
                            style="font-weight: 700" Text="Load Money" onclick="btnIMPS0_Click1" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        <asp:Button ID="btnBulkEnrollment" runat="server" 
                            style="font-weight: 700" Text="Bulk Enrollment" 
                            onclick="btnBulkEnrollment_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        &nbsp;</td>
                    <td style="text-align: center">
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
        <asp:Panel ID="PanelInput" runat="server" style="font-weight: 700">
            <br />
            <table align="center" class="style10" 
                style="border-style: ridge; border-color: #CC99FF; margin-right: 0px;">
                <tr>
                    <td align="center">
                        <asp:Label ID="Label159" runat="server" Font-Bold="True" Font-Size="X-Large" 
                            ForeColor="Blue" Text="V-eWallet - Mobile"></asp:Label>
                        <br />
                        <asp:Panel ID="PanelEnrollment" runat="server" style="text-align: center" 
                            Visible="False">
                            <br />
                            <asp:Label ID="Label4" runat="server" style="font-weight: 700" 
                                Text="Check Enrollment Status"></asp:Label>
                            <br />
                            <table align="center" class="style4">
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label11" runat="server" CssClass="style13" Text="OP Code :"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtOPCode" runat="server">SIGN_UP</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label1" runat="server" CssClass="style13" Text="Mobile Number :"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtMob" runat="server">8197891618</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label116" runat="server" CssClass="style13" Text="Password:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
                                                        Text="Submit" />
                                                </td>
                                                <td align="left">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelChangeMpin" runat="server" Visible="False">
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label5" runat="server" style="font-weight: 700" 
                                            Text="Change MPIN"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label119" runat="server" CssClass="style13" Text="OP Code :"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtOPCodePIN" runat="server" Width="135px">CHANGE_PASSWORD</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label7" runat="server" CssClass="style13" Text="Session ID: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtSessionPIN" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label205" runat="server" CssClass="style13" Text="WalletID:"></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtWalletIdCP" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label9" runat="server" CssClass="style13" 
                                                        Text="Current Password: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtCurrentPwdPIN" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label10" runat="server" CssClass="style13" Text="New Password: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtNewPin" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnChangeMPIN" runat="server" onclick="btnChangeMPIN_Click" 
                                                        Text="Submit" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelLogin" runat="server">
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label14" runat="server" style="font-weight: 700" Text="Login"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label17" runat="server" CssClass="style13" Text="OP Code: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtOPCodeLogin" runat="server">LOGIN</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label18" runat="server" CssClass="style13" 
                                                        Text="Mobile: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtWalletIdLogin" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <asp:Label ID="Label19" runat="server" CssClass="style13" Text="MPIN: "></asp:Label>
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtMPINLogin" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
                                                        Text="Submit" />
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelAccounts" runat="server" style="text-align: center">
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label20" runat="server" style="font-weight: 700" 
                                            Text="Enroll Customer Status"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label21" runat="server" Text="OP Code: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtOPCodeEnroll" runat="server">ENROLL_CUSTOMER</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label22" runat="server" Text="Session ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtSessionEnroll" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label23" runat="server" Text="Name: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtNameEnroll" runat="server">jijeesh</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label24" runat="server" Text="Mobile: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtMobileEnroll" runat="server">8197891618</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label120" runat="server" Text="Email:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtEmailEnroll" runat="server">jijeesh@vijayabank.co.in</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label121" runat="server" Text="Address: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtAddressEnroll" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label122" runat="server" Text="City: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtCityEnroll" runat="server">Bangalore</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label123" runat="server" Text="State:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtStateEnroll" runat="server">Karnataka</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label124" runat="server" Text="Pin Code: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtPinCode" runat="server">560001</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label125" runat="server" Text="Merchant Wallet ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtMerchantWalletEnroll" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label126" runat="server" Text="Initial Amount: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtInitialAmountEnroll" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnEnrollCustomerStatus" runat="server"  
                                                        Text="Submit" onclick="btnEnrollCustomerStatus_Click" />
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label73" runat="server" style="font-weight: 700" 
                                            Text="Enroll Validate"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label127" runat="server" Text="OP Code: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtOPCodeEV" runat="server">VALIDATE_OTP</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label74" runat="server" Text="Session ID:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtSessionEV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label75" runat="server" Text="Merchant Wallet ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtMerchantWalletEV" runat="server">999999900000780</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label76" runat="server" Text="Customer User ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtCustomerWalletEV" runat="server">9986829508</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label204" runat="server" Text="Name: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtNameEV" runat="server">MANMOHAN</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label77" runat="server" Text="OTP:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtOTPEV" runat="server">1111</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label229" runat="server" Text="Initial Amount: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtInitialAmountEnroll0" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnEnrollValidate" runat="server" 
                                                        Text="Submit" onclick="btnEnrollValidate_Click" />
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelTransactions" runat="server">
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label25" runat="server" style="font-weight: 700" 
                                            Text="Fund Transfer Validation"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label26" runat="server" Text="OP Code: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtOPCodeFT" runat="server">WALLET_FUND_TRANSFER</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label30" runat="server" Text="Session ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtSessionIdFT" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label207" runat="server" Text="Source Mobile: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtDebitMobileFTV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label31" runat="server" Text="Source Wallet ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtDebitWalletIdFT" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label29" runat="server" Text="Destination Mobile:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtCreditWalletIdFT" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label27" runat="server" Text="Amount:"></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtAmountFT" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnTxnSubmit" runat="server" onclick="btnTxnSubmit_Click" 
                                                        Text="Submit" />
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style5">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label78" runat="server" style="font-weight: 700" 
                                            Text="Fund Transfer Validate"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <table align="center" class="style1">
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label79" runat="server" Text="OP Code: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtOPCodeFTV" runat="server">VALIDATE_TPIN</asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label80" runat="server" Text="Session ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtSessionIdFTV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label208" runat="server" Text="Source Wallet: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtSourceWalletFTV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label81" runat="server" Text="TPIN: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtPinFTV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style13">
                                                    <asp:Label ID="Label209" runat="server" Text="Transaction ID: "></asp:Label>
                                                </td>
                                                <td align="left" class="style6">
                                                    <asp:TextBox ID="txtIdFTV" runat="server"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right">
                                                    <asp:Button ID="btnFTV" runat="server" 
                                                        Text="Submit" onclick="btnFTV_Click" />
                                                </td>
                                                <td style="text-align: left">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelMessage" runat="server">
                            <br />
                            <table align="center" class="style7">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label33" runat="server" style="font-weight: 700" 
                                            Text="Collection Check"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label39" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeC" runat="server">COLLECTION</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label40" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdC" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label36" runat="server" Text="Source Mobile:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceMobileCC" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label38" runat="server" Text="Destination Wallet:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtDestWalletCC" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label128" runat="server" Text="Amount:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCashAmountCC" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style16">
                                        <asp:Label ID="Label129" runat="server" Text="Remarks:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtRemarksCCC" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right" class="style17">
                                        <asp:Button ID="btnCollectionCheckCC" runat="server" 
                                          Text="Submit" onclick="btnCollectionCheckCC_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style17">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style7">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label130" runat="server" style="font-weight: 700" 
                                            Text="Collection Payment"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style14">
                                        <asp:Label ID="Label131" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeCP" runat="server">COLLECT_PAYMENT</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style14">
                                        <asp:Label ID="Label132" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdCP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style14">
                                        <asp:Label ID="Label134" runat="server" Text="COLLECTION_AMOUNT:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAmountCP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style14">
                                        <asp:Label ID="Label156" runat="server" Text="CASH_AMOUNT:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCashAmount" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style14">
                                        <asp:Label ID="Label135" runat="server" Text="TXN_ID :"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtRemarksCP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style15" style="text-align: right">
                                        <asp:Button ID="btnCollectionPayment" runat="server" 
                                             Text="Submit" onclick="btnCollectionPayment_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style15">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style7">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label137" runat="server" style="font-weight: 700" 
                                            Text="Collection Validate"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style18">
                                        <asp:Label ID="Label138" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeCV" runat="server">VALIDATE_TPIN</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style18">
                                        <asp:Label ID="Label139" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdCV" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style18">
                                        <asp:Label ID="Label140" runat="server" Text="SOURCE WALLET: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCustomerWalletCV" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style18">
                                        <asp:Label ID="Label141" runat="server" Text="OTP: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOTPCV" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style18">
                                        <asp:Label ID="Label206" runat="server" Text="TXN ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txnTxnIdCV" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style19" style="text-align: right">
                                        <asp:Button ID="btnCollectionValidate" runat="server" 
                                             Text="Submit" onclick="btnCollectionValidate_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style19">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelStatement" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label96" runat="server" style="font-weight: 700" 
                                            Text="Wallet Statement"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label97" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeWS" runat="server">WALLET_STATEMENT</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label98" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdWS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label99" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtWalletIdWS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Button ID="btnWalletStmt" runat="server" 
                                            Text="Submit" onclick="btnWalletStmt_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelViewProfile" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label100" runat="server" style="font-weight: 700" 
                                            Text="View Profile"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label101" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeVP" runat="server">VIEW_PROFILE</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label102" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdVP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style13">
                                        <asp:Label ID="Label103" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtWalletIdVP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Button ID="btnViewProfile" runat="server"
                                            Text="Submit" onclick="btnViewProfile_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelUpdateProfile" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label104" runat="server" style="font-weight: 700" 
                                            Text="Update Profile"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label105" runat="server" Text="OP Code:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeUP" runat="server">UPDATE_PROFILE</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label106" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label107" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtWalletIdUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label142" runat="server" Text="Establishment Name: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtEstablish" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label143" runat="server" Text="Name: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtNameUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label144" runat="server" Text="Mobile: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtMobileUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label145" runat="server" Text="Email ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtEmailUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label146" runat="server" Text="Address: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAddressUP" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label147" runat="server" Text="City: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCityUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label148" runat="server" Text="State: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtStateUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style22">
                                        <asp:Label ID="Label149" runat="server" Text="PIN Code:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtPINUP" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right" class="style23">
                                        <asp:Button ID="btnUpdateProfile" runat="server" 
                                            Text="Submit" onclick="btnUpdateProfile_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style23">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelLogout" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label41" runat="server" style="font-weight: 700" Text="Logout"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label42" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout" runat="server">LOGOUT</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label43" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdLogout" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label44" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtWalletIdLogout" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right" class="style21">
                                        <asp:Button ID="btnLogout" runat="server" 
                                            Text="Submit" onclick="btnLogout_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelResendTPIN" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label210" runat="server" style="font-weight: 700" 
                                            Text="Resend TPIN"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label211" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout0" runat="server">RESEND_TPIN</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label212" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdLogout0" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label213" runat="server" Text="Source Wallet :"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtWalletIdLogout0" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label215" runat="server" Text="SOURCE_MOBILE: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceMobileRTPIN" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnResendTPIN" runat="server" 
                                            Text="Submit" onclick="btnResendTPIN_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelResendOTP" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label216" runat="server" style="font-weight: 700" 
                                            Text="Resend OTP"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label217" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout1" runat="server">RESEND_OTP</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label218" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdLogout1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label220" runat="server" Text="SOURCE_MOBILE: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceMobileRTPIN0" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnResendTPIN0" runat="server" 
                                            Text="Submit" onclick="btnResendTPIN0_Click1" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelWalletStatement" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label221" runat="server" style="font-weight: 700" 
                                            Text="Wallet Statement"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label222" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout2" runat="server">WALLET_STATEMENT</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label223" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdLogout2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label224" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceMobileRTPIN1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnResendTPIN1" runat="server" 
                                            Text="Submit" onclick="btnResendTPIN1_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelViewOrders" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label225" runat="server" style="font-weight: 700" 
                                            Text="View Orders"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label226" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout3" runat="server">VIEW_ORDERS</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label227" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdLogout3" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label228" runat="server" Text="Wallet ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceMobileRTPIN2" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnResendTPIN2" runat="server" 
                                            Text="Submit" onclick="btnResendTPIN2_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelBI" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label231" runat="server" style="font-weight: 700" 
                                            Text="Balance Inquiry"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label232" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout4" runat="server">BALANCEENQUIRY</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label233" runat="server" Text="VIRTUAL ACCNO:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtVirtualBI" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label234" runat="server" Text="TIME STAMP:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTimeStamp" runat="server">20012016 105500</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnResendTPIN3" runat="server"

                                            Text="Submit" onclick="btnResendTPIN3_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="PanelIMPS" runat="server">
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label235" runat="server" style="font-weight: 700" 
                                            Text="Verify IMPS "></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label236" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout5" runat="server">VERIFY_IMPS_P2A</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label245" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdVIMPS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label237" runat="server" Text="SOURCE WALLET:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceWalletVIMPS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label257" runat="server" Text="SOURCE MOBILE:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSourceWalletVIMPS0" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label239" runat="server" Text="AMOUNT:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAmountIMPS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnIMPSSubmit" runat="server"
                                            Text="Submit" onclick="btnIMPSSubmit_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label240" runat="server" style="font-weight: 700" 
                                            Text="IMPS Transfer"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label241" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout6" runat="server">IMPS_P2A</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label254" runat="server" Text="Session ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtSessionIdIMPST" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label256" runat="server" Text="TXN ID: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTxnIdIMPSTTxx" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label242" runat="server" Text="VIRTUAL ACCNO:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtVirtualBI1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label251" runat="server" Text="ACCOUNTNUMBER:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAccountNumberIMPS" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label243" runat="server" Text="AMOUNT:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAmountIMPS0" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label253" runat="server" Text="TPIN:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTPINIMPST" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label244" runat="server" Text="TIME STAMP:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTimeStamp1" runat="server">20012016 105500</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label255" runat="server" Text="REMARKS: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtRemarksIMPST" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnIMPSSubmit0" runat="server"
                                            Text="Submit" onclick="btnIMPSSubmit0_Click" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <table align="center" class="style8">
                                <tr>
                                    <td colspan="2" style="text-align: center">
                                        <asp:Label ID="Label246" runat="server" style="font-weight: 700" 
                                            Text="IMPS Update"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label247" runat="server" Text="OP Code: "></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOPCodeLogout7" runat="server">UPDATEIMPS</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label249" runat="server" Text="TRAN REF NO:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtAmountIMPS1" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left" class="style20">
                                        <asp:Label ID="Label250" runat="server" Text="STATUS:"></asp:Label>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtTimeStamp2" runat="server">SUCCESS</asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style21" style="text-align: right">
                                        <asp:Button ID="btnIMPSSubmit1" runat="server" 
                                            Text="Submit" onclick="btnIMPSSubmit1_Click1" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style21">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                            <br />
                        </asp:Panel>
                        <br />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        <table class="style10">
            <tr>
                <td align="center">
                    <img alt="" class="style11" src="images/VijayaBank_thumb.png" /></td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
