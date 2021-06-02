using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Text;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    clsDetails.UserDetails objUser = new clsDetails.UserDetails();
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                            " \"OPCODE\":\"SIGN_UP\", " +
                            " \"MOBILE\":\"" + txtMob.Text + "\", " +
                            " \"PASSWORD\":\"" + txtPassword.Text + "\" " +
                            " }";

        
        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);

        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");

        sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);

        RedirectURL(sJsonRequest);

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = true;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnChangeMPIN_Click(object sender, EventArgs e)
    {
        //string sMPINHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Convert.ToString(txtNewPin.Text), "SHA1");
        string sJsonRequest = "{" +
                            " \"OPCODE\":\"CHANGE_PASSWORD\", " +
                            " \"SESSION_ID\":\"" + txtSessionPIN.Text + "\", " +
                            " \"WALLET_ID\":\"" + txtWalletIdCP.Text + "\", " +
                            " \"CURRENT_PASSWORD\":\"" + txtCurrentPwdPIN.Text + "\", " +
                            " \"NEW_PASSWORD\":\"" + txtNewPin.Text + "\" " +
                            " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = true;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {

        string sJsonRequest = "{" +
                            " \"OPCODE\":\"LOGIN\", " +
                            " \"USER_ID\":\"" + txtWalletIdLogin.Text + "\", " +
                            " \"PASSWORD\":\"" + txtMPINLogin.Text + "\" " +
                            " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        
        RedirectURL(sJsonRequest);
        

    }
   
  
    protected void Button5_Click1(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = true;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
   
    protected void Button6_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = true;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
   
    protected void Button12_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = true;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelTransactions.Visible = true;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        PanelWalletMobileHead.Visible = true;

        
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        //string redirect = "<script>window.open('http://www.vijayabank.com:83/VPassBookV2.0/Reset.aspx');</script>";
        string redirect = "";
        Response.Write(redirect);
    }
    protected void btnMessage_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = true;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendOTP.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    
    protected void Button16_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = true;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible=false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
   
   
    protected void Button21_Click1(object sender, EventArgs e)
    {
        
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = true;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
   
    public void RedirectURL(string sJsonRequest)
    {
        Response.Redirect("https://www.mobile.vijayabankonline.in/eWalletWeb/VPTransReceiver.aspx?INPUT=" + sJsonRequest, false);
        //Response.Redirect("http://localhost:58784/V-eWalletWeb/VPTransReceiver.aspx?INPUT=" + sJsonRequest, false);
    }
  
    protected void btnEnrollCustomerStatus_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"ENROLL_CUSTOMER\", " +
                           " \"SESSION_ID\":\"" + txtSessionEnroll.Text + "\", " +
                           " \"NAME\":\"" + txtNameEnroll.Text + "\", " +
                           " \"MOBILE\":\"" + txtMobileEnroll.Text + "\", " +
                           " \"EMAIL\":\"" + txtEmailEnroll.Text + "\", " +
                           " \"ADDRESS\":\"" + txtAddressEnroll.Text + "\", " +
                           " \"CITY\":\"" + txtCityEnroll.Text + "\", " +
                           " \"STATE\":\"" + txtStateEnroll.Text + "\", " +
                           " \"PINCODE\":\"" + txtPinCode.Text + "\", " +
                           " \"MERCHANT_WALLET_ID\":\"" + txtMerchantWalletEnroll.Text + "\", " +
                           " \"INITIAL_AMOUNT\":\"" + txtInitialAmountEnroll.Text + "\" " +
                           " }";


        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);

        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");

        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);

        RedirectURL(sJsonRequest);

    }
    protected void btnEnrollValidate_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                          " \"OPCODE\":\"VALIDATE_OTP\", " +
                          " \"SESSION_ID\":\"" + txtSessionEV.Text + "\", " +
                          " \"MERCHANT_WALLET_ID\":\"" + txtMerchantWalletEV.Text + "\", " +
                          " \"CUSTOMER_USER_ID\":\"" + txtCustomerWalletEV.Text + "\", " +
                          " \"NAME\":\"" + txtNameEV.Text + "\", " +
                          " \"OTP\":\"" + txtOTPEV.Text + "\", " +
                          " \"INITIAL_AMOUNT\":\"" + txtInitialAmountEnroll0.Text + "\" " +
                          " }";


        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);

        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");

        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);

        RedirectURL(sJsonRequest);

    }

    protected void btnFTV_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                          " \"OPCODE\":\"VALIDATE_TPIN\", " +
                          " \"SESSION_ID\":\"" + txtSessionIdFTV.Text + "\", " +
                          " \"SOURCE_WALLET\":\"" + txtSourceWalletFTV.Text + "\", " +
                          " \"TPIN\":\"" + txtPinFTV.Text + "\", " +
                          " \"TXN_ID\":\"" + txtIdFTV.Text + "\" " +
                          " }";


        RedirectURL(sJsonRequest);

    }
    
    protected void btnCollectionPayment_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                            " \"OPCODE\":\"COLLECT_PAYMENT\", " +
                            " \"SESSION_ID\":\"" + txtSessionIdCP.Text + "\", " +
                            " \"COLLECTION_AMOUNT\":\"" + txtAmountCP.Text + "\", " +
                            " \"CASH_AMOUNT\":\"" + txtCashAmount.Text + "\", " +
                            " \"TXN_ID\":\"" + txtRemarksCP.Text + "\" " +
                            " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }

    protected void btnCollectionValidate_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                            " \"OPCODE\":\"VALIDATE_TPIN\", " +
                            " \"SESSION_ID\":\"" + txtSessionIdCV.Text + "\", " +
                            " \"SOURCE_WALLET\":\"" + txtCustomerWalletCV.Text + "\", " +
                            " \"TXN_ID\":\"" + txnTxnIdCV.Text + "\", " +
                            " \"TPIN\":\"" + txtOTPCV.Text + "\" " +
                            " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnWalletStmt_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"WALLET_STATEMENT\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdWS.Text + "\", " +
                           " \"WALLET_ID\":\"" + txtWalletIdWS.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnViewProfile_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"VIEW_PROFILE\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdVP.Text + "\", " +
                           " \"WALLET_ID\":\"" + txtWalletIdVP.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }

    protected void btnUpdateProfile_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"UPDATE_PROFILE\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdUP.Text + "\", " +
                           " \"WALLET_ID\":\"" + txtWalletIdUP.Text + "\", " +
                           " \"ESTABLISHMENT_NAME\":\"" + txtEstablish.Text + "\", " +
                           " \"NAME\":\"" + txtNameUP.Text + "\", " +
                           " \"MOBILE\":\"" + txtMobileUP.Text + "\", " +
                           " \"EMAIL\":\"" + txtEmailUP.Text + "\", " +
                           " \"ADDRESS\":\"" + txtAddressUP.Text + "\", " +
                           " \"CITY\":\"" + txtCityUP.Text + "\", " +
                           " \"STATE\":\"" + txtStateUP.Text + "\", " +
                           " \"PINCODE\":\"" + txtPINUP.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                          " \"OPCODE\":\"LOGOUT\", " +
                          " \"SESSION_ID\":\"" + txtSessionIdLogout.Text + "\", " +
                          " \"WALLET_ID\":\"" + txtWalletIdLogout.Text + "\" " +
                          " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnTxnSubmit_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                          " \"OPCODE\":\"WALLET_FUND_TRANSFER\", " +
                          " \"SESSION_ID\":\"" + txtSessionIdFT.Text + "\", " +
                          " \"SOURCE_MOBILE\":\"" + txtDebitMobileFTV.Text + "\", " +
                          " \"SOURCE_WALLET\":\"" + txtDebitWalletIdFT.Text + "\", " +
                          " \"DESTINATION_MOBILE\":\"" + txtCreditWalletIdFT.Text + "\", " +
                          " \"AMOUNT\":\"" + txtAmountFT.Text + "\" " +
                          " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void Button40_Click(object sender, EventArgs e)
    {
        PanelWalletMobileHead.Visible = false;
        PanelInput.Visible = false;
    }
    protected void Button41_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }
    protected void Button42_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }
    protected void Button43_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }
    protected void Button44_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }
    protected void btnMessage0_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }
    protected void Button45_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = false;
        PanelWalletMobileHead.Visible = false;
    }


    protected void Button46_Click(object sender, EventArgs e)
    {
        PanelWalletMobileHead.Visible = true;
    }
    protected void Button39_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = true;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void Button16_Click1(object sender, EventArgs e)
    {

        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = true;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void Button47_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                         " \"SIDNo\":\"999103000121121\", " +
                         " \"FeeAmount\":\"10\", " +
                         " \"TranDate\":\"2015-12-31\", " +
                         " \"Channel\":\"CASH\", " +
                         " \"Remarks\":\"Test\", " +
                         " \"PaymentId\":\"12345678\" " +
                         " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnCollectionCheckCC_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                            " \"OPCODE\":\"COLLECTION\", " +
                            " \"SESSION_ID\":\"" + txtSessionIdC.Text + "\", " +
                            " \"SOURCE_MOBILE\":\"" + txtSourceMobileCC.Text + "\", " +
                            " \"DESTINATION_WALLET\":\"" + txtDestWalletCC.Text + "\", " +
                            " \"COLLECTION_AMOUNT\":\"" + txtCashAmountCC.Text + "\", " +
                            " \"REMARKS\":\"" + txtRemarksCCC.Text + "\" " +
                            " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnMessage1_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = true;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnResendTPIN_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"RESEND_TPIN\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdLogout0.Text + "\", " +
                           " \"SOURCE_WALLET\":\"" + txtWalletIdLogout0.Text + "\", " +
                           " \"SOURCE_MOBILE\":\"" + txtSourceMobileRTPIN.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnMessage2_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = true;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    
    protected void btnResendTPIN0_Click1(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"RESEND_OTP\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdLogout1.Text + "\", " +
                           " \"MOBILE\":\"" + txtSourceMobileRTPIN0.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnMessage3_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = true;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnResendTPIN1_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"WALLET_STATEMENT\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdLogout2.Text + "\", " +
                           " \"WALLET_ID\":\"" + txtSourceMobileRTPIN1.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnMessage3_Click1(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = true;
        PanelBI.Visible = false;
        PanelIMPS.Visible = false;
    }
    protected void btnResendTPIN2_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"VIEW_ORDERS\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdLogout3.Text + "\", " +
                           " \"WALLET_ID\":\"" + txtSourceMobileRTPIN2.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnBalanceInq_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = true;
        PanelIMPS.Visible = false;
    }
    protected void btnResendTPIN3_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"BALANCEENQUIRY\", " +
                           " \"VIRTUALACCNO\":\"" + txtVirtualBI.Text + "\", " +
                           " \"TIMESTAMP\":\"" + txtTimeStamp.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void Button40_Click1(object sender, EventArgs e)
    {
        Response.Redirect("eWallet_TPIN.aspx?source_addr=8197891618&short_message=Hi", false);
    }
   
    protected void btnMiniStmt_Click(object sender, EventArgs e)
    {
        Response.Redirect("eWallet_TPIN.aspx?source_addr=8197891618&short_message=MINI", false);
    }
    protected void btnIMPS_Click(object sender, EventArgs e)
    {
        PanelInput.Visible = true;
        PanelEnrollment.Visible = false;
        PanelChangeMpin.Visible = false;
        PanelLogin.Visible = false;
        PanelAccounts.Visible = false;
        PanelTransactions.Visible = false;
        PanelMessage.Visible = false;
        PanelStatement.Visible = false;
        PanelViewProfile.Visible = false;
        PanelUpdateProfile.Visible = false;
        PanelLogout.Visible = false;
        PanelResendTPIN.Visible = false;
        PanelResendOTP.Visible = false;
        PanelWalletStatement.Visible = false;
        PanelViewOrders.Visible = false;
        PanelBI.Visible = false;
        PanelIMPS.Visible = true;
    }
    protected void btnIMPSSubmit_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"VERIFY_IMPS_P2A\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdVIMPS.Text + "\", " +
                           " \"SOURCE_WALLET\":\"" + txtSourceWalletVIMPS.Text + "\", " +
                           " \"SOURCE_MOBILE\":\"" + txtSourceWalletVIMPS0.Text + "\", " +
                           " \"AMOUNT\":\"" + txtAmountIMPS.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
    protected void btnIMPSSubmit1_Click1(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                              " \"OPCODE\":\"UPDATEIMPS\", " +
                              " \"TRNREFNO\":\"" + txtAmountIMPS1.Text + "\", " +
                              " \"STATUS\":\"" + txtTimeStamp2.Text + "\" " +
                              " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);

        Response.Redirect("https://www.mobile.vijayabankonline.in/eWalletWeb/UpdateIMPS.aspx?INPUT=" + sJsonRequest, false);
        //Response.Redirect("http://localhost:61996/V-eWalletWeb/UpdateIMPS.aspx?INPUT=" + sJsonRequest, false);

    }
    protected void btnIMPSSubmit0_Click(object sender, EventArgs e)
    {
        string sJsonRequest = "{" +
                           " \"OPCODE\":\"IMPS_P2A\", " +
                           " \"SESSION_ID\":\"" + txtSessionIdIMPST.Text + "\", " +
                           " \"SOURCE_WALLET\":\"" + txtVirtualBI1.Text + "\", " +
                           " \"TXN_ID\":\"" + txtTxnIdIMPSTTxx.Text + "\", " +
                           " \"ACCOUNT_NO\":\"" + txtAccountNumberIMPS.Text + "\", " +
                           " \"AMOUNT\":\"" + txtAmountIMPS0.Text + "\", " +
                           " \"TPIN\":\"" + txtTPINIMPST.Text + "\", " +
                           " \"TIMESTAMP\":\"" + txtTimeStamp1.Text + "\", " +
                           " \"REMARKS\":\"" + txtRemarksIMPST.Text + "\" " +
                           " }";

        objUser = ClassJson.JsonDeserialize<clsDetails.UserDetails>(sJsonRequest);
        //sJsonRequest = JsonCsharpUtiil.getEncryptString(sJsonRequest, "snowtint!@#$");
        //sJsonRequest = HttpUtility.UrlEncode(sJsonRequest);
        RedirectURL(sJsonRequest);
    }
  
    protected void btnIMPS0_Click1(object sender, EventArgs e)
    {
        Response.Redirect("LoadMoneyToWallet.aspx", false);
    }
    protected void btnBulkEnrollment_Click(object sender, EventArgs e)
    {
        Response.Redirect("BulkLoadWallet.aspx", false);
    }
}
