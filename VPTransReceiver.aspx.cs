/* 
 ***** Author       : Jijeesh, Avaneeth & Ajay    *****
 ***** Start Date   : 02-Dec-2015       *****
 ***** Organization : Vijaya Bank       *****
*/
using System;
using System.IO;
using System.Net;
using System.Web;
using WalletService;

public partial class VPTransReceiver : System.Web.UI.Page
{
    WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
    string TARequestJson = string.Empty;
    string TAResponseJson = string.Empty;
    TAREQUEST objTARequest;
    TARESPONSE objTAResponse;
    bool bResponse = false;
    bool SessionTime = false;
    protected void Page_Load(object sender, EventArgs e)
    {

        string sResponse = "";
        string sRequest = string.Empty;

        try
        {
            string Input = Request.QueryString.Get("INPUT");
            //Input = JsonCsharpUtiil.getDecryptString(Input, "ditVijayaBank!@#$$$~||%%");
            Input = HttpUtility.UrlDecode(Input);
            clsEvent.LogEvent(Input);

            ClassJson.REQUEST objReq = new ClassJson.REQUEST();
            objReq = ClassJson.JsonDeserialize<ClassJson.REQUEST>(Input);
            SIGNUP objSignup = new SIGNUP();
            ENROLL objEnroll = new ENROLL();
            LOGIN objLogin=new LOGIN();
            COLLECTION objCollection = new COLLECTION();
            switch (objReq.OPCODE)
            {
                case "SIGN_UP":
                    {
                        //check merchant registration status
                        //string Mobile = ReturnEncryptedString(objReq.MOBILE);
                        objSignup = objWallet.CheckRegistrationStatus(objReq.MOBILE);
                        objSignup.PASSWORD = objReq.PASSWORD;//get encrypted password from manmohan

                        if (objSignup.RESPONSECODE == "000") //user already registered  
                        {
                            objEnroll = objWallet.CheckEnrollmentStatus(objReq.MOBILE);
                            if (objEnroll.RESPONSECODE == "913")
                            {
                                //assign values from enroll to signup 
                                objSignup = new SIGNUP();
                                objSignup.RESPONSECODE = "913";
                                objSignup.RESPONSEDESC = "WALLET ALREADY EXISTS";
                                //objSignup.WALLETID = objEnroll.WALLETID;
                            }
                            else
                            {
                                // Call TA
                                objTARequest = new TAREQUEST();
                                objTARequest.OPCODE = "ENROLLMENT";
                                objTARequest.MOBILE = objReq.MOBILE;
                                objTARequest.NAME = objSignup.NAME;
                                objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                                TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                                TAResponseJson = PostToTA(TARequestJson);
                                objTAResponse = new TARESPONSE();
                                objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                                if (objTAResponse.RESPONSECODE == "000" || objTAResponse.RESPONSECODE == "913")
                                {
                                    objSignup.WALLETID = objTAResponse.VIRTUALACCOUNT;
                                    bResponse = objWallet.InsertNewEnrollment(objSignup);
                                    if (bResponse)
                                    {
                                        objSignup.RESPONSEDESC = "SUCCESS";
                                        objSignup.ENROLLMENT_TYPE = "MERCHANT";
                                    }
                                    else
                                    {
                                        objSignup = new SIGNUP();
                                        objSignup.RESPONSECODE = "999";
                                        objSignup.RESPONSEDESC = "FAILURE";
                                    }
                                }
                                else
                                {
                                    objSignup.RESPONSECODE = objTAResponse.RESPONSECODE;
                                    objSignup.RESPONSEDESC = objTAResponse.RESPONSEDESC;

                                }

                            }
                        }
                        sResponse = ClassJson.JsonSerializer<SIGNUP>(objSignup);
                    }
                    break;
                case "LOGIN":
                    {
                        objLogin = objWallet.UserLogin(objReq.USER_ID, objReq.PASSWORD);
                        //if (objLogin.RESPONSECODE == "000")
                        //{
                            //call TA to get wallet balance
                            //objTARequest = new TAREQUEST();
                            //objTARequest.OPCODE = "BALANCEENQUIRY";
                            //objTARequest.VIRTUALACCNO = objLogin.WALLETID;
                            //objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            //TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            //TAResponseJson = PostToTA(TARequestJson);
                            //objTAResponse = new TARESPONSE();
                            //objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            //objLogin.BALANCE =  objTAResponse.BALANCE;   
                        //}
                        sResponse = ClassJson.JsonSerializer<LOGIN>(objLogin);
                    }
                    break;


                case "LOGOUT":
                    {
                        LOGOUT objLogout = new LOGOUT();
                        objLogout = objWallet.LogoutUser(objReq.WALLET_ID, objReq.SESSION_ID);
                        sResponse = ClassJson.JsonSerializer<LOGOUT>(objLogout);
                    }
                    break;
                case "ENROLL_CUSTOMER":
                    {
                        objEnroll = new ENROLL();
                        //objEnroll = objWallet.CheckUserEnrollmentStatus(objReq.MOBILE);
                        //if (objEnroll.RESPONSECODE == "913")
                        //{
                        //    //sResponse = ClassJson.JsonSerializer<ENROLL>(objEnroll);
                        //}
                        //else
                        //{
                            //call enroll customer
                        objEnroll = objWallet.EnrollCustomer(objReq.NAME, "91", objReq.MOBILE, objReq.EMAIL, objReq.ADDRESS, objReq.CITY, objReq.STATE, objReq.PINCODE, objReq.MERCHANT_WALLET_ID);
                        //}
                        sResponse = ClassJson.JsonSerializer<ENROLL>(objEnroll);
                    }
                    break;
                case "VALIDATE_OTP":
                    {
                        objEnroll = new ENROLL();
                        objEnroll = objWallet.ValidateOTP(objReq.SESSION_ID, objReq.MERCHANT_WALLET_ID, objReq.CUSTOMER_USER_ID, objReq.OTP);
                        if (objEnroll.RESPONSECODE == "000")
                        {
                            //call TA USER_ENROLLMENT
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "ENROLLMENT";
                            objTARequest.MOBILE = objReq.CUSTOMER_USER_ID;
                            objTARequest.NAME = objReq.NAME;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            if (objTAResponse.RESPONSECODE == "000" || objTAResponse.RESPONSECODE == "913")
                            {
                                objSignup = new SIGNUP();
                                objSignup.OPCODE = "VALIDATE_OTP"; //this is for updating enabled flg y in wcf
                                objSignup.WALLETID = objTAResponse.VIRTUALACCOUNT;
                                bResponse = objWallet.UpdateWalletId(objReq.CUSTOMER_USER_ID, objSignup.WALLETID);
                                if (bResponse)
                                {
                                    bResponse = objWallet.UpdateWalletIdMerchantTable(objReq.CUSTOMER_USER_ID, objSignup.WALLETID);
                                    if (bResponse)
                                    {
                                        objEnroll.RESPONSECODE = "000";
                                        objEnroll.RESPONSEDESC = "SUCCESS";
                                        objEnroll.OTP_VALIDATED = "TRUE";
                                        objEnroll.ENROLLMENT_STATUS = "TRUE";
                                        objEnroll.TRANSACTION_STATUS = "TRUE";
                                        objEnroll.WALLETID = objSignup.WALLETID;
                                        objEnroll.TXN_ID = string.Empty;
                                        objEnroll.TXN_DATE = string.Empty;
                                        //send sms to customer : Your wallet has been created successfully. Your current balance is Rs.[bal].
                                        string Message = "Congratulations! Your V-eWallet has been created successfully. WalletID:" + objTAResponse.VIRTUALACCOUNT + ". Vijaya Bank";
                                        objWallet.SendSMS("91", objReq.CUSTOMER_USER_ID, Message);
                                        ////call TA to get TPIN 
                                        //objCollection = new COLLECTION();
                                        ////objCollection = objWallet.GetTransactionDetails(objReq.TXN_ID);
                                        //bool Response = false;
                                        //objTARequest = new TAREQUEST();
                                        //objTARequest.OPCODE = "GENERATETPIN";
                                        //objTARequest.VIRTUALACCNO = objReq.MERCHANT_WALLET_ID;
                                        //objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                                        //TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                                        //TAResponseJson = PostToTA(TARequestJson);
                                        //objTAResponse = new TARESPONSE();
                                        //objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                                        //objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                                        //objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                                        //objCollection.TPIN = objTAResponse.TPIN;
                                        //objWallet.SendTPIN("91", objReq.MERCHANT_MOBILE, objTAResponse.TPIN);
                                        //objCollection.TPIN_SENT_STATUS = "TRUE";
                                        ////call TA for Fund Transfer with Initial amount

                                        //send sms to customer : Your wallet has been created successfully. Your current balance is Rs.[bal].
                                        //objSignup.RESPONSEDESC = "SUCCESS";
                                    }
                                }
                            }
                            else
                            {
                                objSignup.RESPONSECODE = objTAResponse.RESPONSECODE;
                                objSignup.RESPONSEDESC = objTAResponse.RESPONSEDESC;

                            }
                            ////update enabled flg
                            //objWallet.UpdateEnableFlg(objReq.CUSTOMER_WALLET_ID, "Y");
                        }
                        sResponse = ClassJson.JsonSerializer<ENROLL>(objEnroll);
                    }
                    break;
                case "VIEW_PROFILE":
                    {
                        PROFILE objProfile = new PROFILE();
                        objProfile = objWallet.ViewProfile(objReq.SESSION_ID, objReq.WALLET_ID);
                        sResponse = ClassJson.JsonSerializer<PROFILE>(objProfile);
                    }
                    break;
                case "UPDATE_PROFILE":
                    {
                        PROFILE objProfile = new PROFILE();
                        objProfile = objWallet.UpdateProfile(objReq.WALLET_ID,objReq.ESTABLISHMENT_NAME,objReq.NAME,objReq.MOBILE,objReq.EMAIL,objReq.ADDRESS,objReq.CITY,objReq.STATE,objReq.PINCODE);
                        sResponse = ClassJson.JsonSerializer<PROFILE>(objProfile);
                    }
                    break;
                case "CHANGE_PASSWORD":
                    {
                        objLogin = new LOGIN();
                        objLogin = objWallet.ChangePassword(objReq.WALLET_ID, objReq.SESSION_ID, objReq.CURRENT_PASSWORD, objReq.NEW_PASSWORD);
                        sResponse = ClassJson.JsonSerializer<LOGIN>(objLogin);
                    }
                    break;
                case "COLLECTION":
                    {
                        string sTxnId=string.Empty;
                        objCollection = new COLLECTION();
                        objCollection = objWallet.CheckSourceWalletAccount(objReq.SOURCE_MOBILE); //get walletid (virtual account) from source mobile number
                        if (objCollection.RESPONSECODE == "000")
                        {
                            // call TA VALIDATE FUND TRANSFER API
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "VALIDATINGFUNDTRANSFER";
                            objTARequest.SRCVIRTUALACCNO = objCollection.WALLETID;
                            objTARequest.DESTVIRTUALACCNO = objReq.DESTINATION_WALLET;
                            objTARequest.AMOUNT = objReq.COLLECTION_AMOUNT;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            if (objTAResponse.RESPONSECODE == "000") //wallet is having sufficent balance
                            {
                                //sTxnId = objWallet.TranIdGenerator();
                                objCollection.RESPONSECODE = "000";
                                objCollection.RESPONSEDESC = "SUCCESS";
                                objCollection.SOURCE_WALLET = objCollection.WALLETID;
                                objCollection.CASH_AMOUNT = "0";
                                //objCollection.TRANREFNO = sTxnId;
                                objCollection.TPIN = objTAResponse.TPIN;
                                objCollection.TXN_DATE = DateTime.Now.ToString("yyyy-MM-dd");
                                objCollection.COLLECTION_AMOUNT = objTARequest.AMOUNT;
                                objCollection.WALLET_AMOUNT = objTARequest.AMOUNT;
                                objCollection.WALLETBALANCE = objTAResponse.BALANCE;
                                objCollection.CASH_AMOUNT = "0";
                                objCollection.DESTINATION_WALLET = objTARequest.DESTVIRTUALACCNO;
                                objCollection.DESTINATIONMOBILE = objReq.DESTINATION_MOBILE;
                                objCollection.TRANSTATUS = "VALIDATED";
                                objCollection.TRANTYPE = "COLLECTION";
                                objCollection.SOURCE_MOBILE = objReq.SOURCE_MOBILE;
                                objCollection.REMARKS = objReq.REMARKS;
                                //insert into tblTransaction = TODO check error in insertion and return error message
                                objCollection.TXN_ID = objWallet.CreateTransaction(objCollection);
                                if (objCollection.TXN_ID == "")
                                {
                                    objCollection = new COLLECTION();
                                    objCollection.RESPONSECODE = "999";
                                    objCollection.RESPONSEDESC = "FAILURE";
                                }
                            }
                            else if (objTAResponse.RESPONSECODE == "101") //insuffient amount in source wallet
                            {
                                //cash transaction to be handled here. If wallet balance is above 0, then allow else reject
                                //if (Convert.ToDouble(objTAResponse.BALANCE)==0  )
                                if (Convert.ToDouble(objTAResponse.BALANCE) < Convert.ToDouble(objReq.COLLECTION_AMOUNT))
                                {
                                    //reject fund transfer with no balance 
                                    objCollection.RESPONSECODE = "300";
                                    objCollection.RESPONSEDESC = "INSUFFICIENT BALANCE(Balance: " + objTAResponse.BALANCE + "). TRANSACTION NOT PERMITTED";
                                }
                                //else if(Convert.ToDouble(objTAResponse.BALANCE) < Convert.ToDouble(objReq.COLLECTION_AMOUNT))
                                //{
                                //    //allow fund transfer
                                //   //sTxnId = objWallet.TranIdGenerator();
                                //    objCollection.SOURCE_WALLET = objCollection.WALLETID;
                                //    objCollection.COLLECTION_AMOUNT = objTARequest.AMOUNT;
                                //    objCollection.WALLET_AMOUNT = objTAResponse.BALANCE;
                                //    objCollection.CASH_AMOUNT = (Convert.ToDouble(objTARequest.AMOUNT) - Convert.ToDouble(objTAResponse.BALANCE)).ToString();

                                //    //objCollection.TRANREFNO = sTxnId;
                                //    objCollection.TPIN = objTAResponse.TPIN;
                                //    objCollection.TXN_DATE = DateTime.Now.ToString("yyyy-MM-dd");


                                //    objCollection.DESTINATION_WALLET = objTARequest.DESTVIRTUALACCNO;
                                //    objCollection.TRANSTATUS = "VALIDATED";
                                //    objCollection.TRANTYPE = "COLLECTION";
                                //    objCollection.SOURCE_MOBILE = objReq.SOURCE_MOBILE;
                                //    //insert into tblTransaction = TODO check error in insertion and return error message
                                //    //bool Response= objWallet.CreateTransaction(objCollection);
                                //    objCollection.TXN_ID = objWallet.CreateTransaction(objCollection);
                                //    if (String.IsNullOrEmpty(objCollection.TXN_ID))
                                //    {
                                //        objCollection.RESPONSECODE = "999";
                                //        objCollection.RESPONSEDESC = "FAILURE";
                                       
                                //    }
                                //    else
                                //    {
                                //        objCollection.RESPONSECODE = "000";
                                //        objCollection.RESPONSEDESC = "SUCCESS";
                                //    }
                                //}

                            }
                            else
                            {
                                objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                                objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                            }
                        }
                        else
                        {
                            objCollection = new COLLECTION();
                            objCollection.RESPONSECODE = "999";
                            objCollection.RESPONSEDESC = "USER IS NOT YET ENROLLED";
                        }
                        //objLogin = objWallet.ChangePassword(objReq.WALLET_ID, objReq.SESSION_ID, objReq.CURRENT_PASSWORD, objReq.NEW_PASSWORD);
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCollection);
                    }
                    break;
                case "COLLECT_PAYMENT":
                    {
                        objCollection = new COLLECTION();
                        //get tpin from sql server
                        objCollection = objWallet.GetTPIN(objReq.TXN_ID,"COLLECT_PAYMENT");
                        //get balance of source mobile and send sms
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "BALANCEENQUIRY";
                        objTARequest.VIRTUALACCNO = objCollection.SOURCE_WALLET;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        //objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objCollection.TPIN + " . Your current balance is: Rs. "+objTAResponse.BALANCE+". Vijaya Bank";
                        objWallet.SendSMS("91", objCollection.SOURCE_MOBILE, Message);
                        objCollection.TPIN_SENT_STATUS = "TRUE";
                        objCollection.RESPONSECODE = "000";
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCollection);
                    }
                    break;
                case "VALIDATE_TPIN":
                    {
                        //Get Wallet amount and dest wallet  from transaction table using tran ref no.
                        objCollection = new COLLECTION();
                        objCollection = objWallet.GetTransactionDetails(objReq.TXN_ID);
                        
                        bool Response = false;
                        
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "WALLETTOWALLETTRANSFER";
                        objTARequest.SRCVIRTUALACCNO = objReq.SOURCE_WALLET;
                        objTARequest.DESTVIRTUALACCNO = objCollection.DESTINATION_WALLET;
                        objTARequest.AMOUNT = objCollection.WALLET_AMOUNT;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        objTARequest.TPIN = objReq.TPIN;
                        objTARequest.TRNREFNO = objReq.TXN_ID;
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        //go ahead with wallet to wallet transfer
                        Response = objWallet.UpdateTransactionStatusWTW(objReq.TXN_ID, objTAResponse.RESPONSECODE, objTAResponse.TRNREFNO,objTAResponse.BALANCE);
                        objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                        objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                        objCollection.TXN_DATE = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");
                        //get balance and send sms to destination mobile
                        //get balance of source mobile and send sms
                        if (objTAResponse.RESPONSECODE == "000")
                        {
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "BALANCEENQUIRY";
                            objTARequest.VIRTUALACCNO = objCollection.DESTINATION_WALLET;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            //objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            string Message = "Added Rs. " + objCollection.WALLET_AMOUNT + " to your V-eWallet. Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                            objWallet.SendSMS("91", objCollection.DESTINATIONMOBILE, Message);
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "BALANCEENQUIRY";
                            objTARequest.VIRTUALACCNO = objCollection.SOURCE_WALLET;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            Message = "An amount of Rs. " + objCollection.WALLET_AMOUNT + " has been debited from your V-eWallet. Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                            objWallet.SendSMS("91", objCollection.SOURCE_MOBILE, Message);
                            objCollection.TPIN_SENT_STATUS = "TRUE";
                        }
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCollection);
                    }
                    break;
                case "WALLET_FUND_TRANSFER":
                    {
                        string sTxnId = string.Empty;
                        objCollection = new COLLECTION();
                        objCollection = objWallet.CheckSourceWalletAccount(objReq.DESTINATION_MOBILE); //get walletid (virtual account) from DESTINATION mobile number
                        if (objCollection.RESPONSECODE == "000")
                        {
                        //    // call TA VALIDATE FUND TRANSFER API
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "VALIDATINGFUNDTRANSFER";
                            objTARequest.SRCVIRTUALACCNO =objReq.SOURCE_WALLET;
                            objTARequest.DESTVIRTUALACCNO = objCollection.WALLETID;
                            objTARequest.AMOUNT = objReq.AMOUNT;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            if (objTAResponse.RESPONSECODE == "000") //wallet is having sufficent balance
                            {
                                //sTxnId = objWallet.TranIdGenerator();
                                objCollection.RESPONSECODE = "000";
                                objCollection.RESPONSEDESC = "SUCCESS";
                                objCollection.TPIN = objTAResponse.TPIN;
                                objCollection.TXN_DATE = DateTime.Now.ToString("yyyy-MM-dd");
                                objCollection.COLLECTION_AMOUNT = objTARequest.AMOUNT;
                                objCollection.WALLET_AMOUNT = objTARequest.AMOUNT;
                                objCollection.CASH_AMOUNT = "0";
				objCollection.WALLETBALANCE = objTAResponse.BALANCE;
                                objCollection.SOURCE_WALLET = objTARequest.SRCVIRTUALACCNO;
                                objCollection.DESTINATION_WALLET = objTARequest.DESTVIRTUALACCNO;
                                objCollection.TRANSTATUS = "VALIDATED";
                                objCollection.TRANTYPE = "WALLET TO WALLET TRANSFER";
                                objCollection.SOURCE_MOBILE = objReq.SOURCE_MOBILE;
                                objCollection.DESTINATIONMOBILE = objReq.DESTINATION_MOBILE;
                                //insert into tblTransaction = TODO check error in insertion and return error message
                                objCollection.TXN_ID = objWallet.CreateTransaction(objCollection);
                                //get wallet balance
                                objTARequest = new TAREQUEST();
                                objTARequest.OPCODE = "BALANCEENQUIRY";
                                objTARequest.VIRTUALACCNO = objReq.SOURCE_WALLET;
                                objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                                TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                                TAResponseJson = PostToTA(TARequestJson);
                                objTAResponse = new TARESPONSE();
                                objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                                //SEND TPIN 
                                string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objCollection.TPIN + " . Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                                objWallet.SendTPIN("91", objReq.SOURCE_MOBILE, objTAResponse.TPIN,Message);
                                objCollection.TPIN_SENT_STATUS = "TRUE"; 
                            }
                            else if (objTAResponse.RESPONSECODE == "101") //insuffient amount in source wallet
                            {
                                objCollection.RESPONSECODE = "300";
                                objCollection.RESPONSEDESC = "SOURCE WALLET DOESN'T HAVE SUFFICIENT BALANCE. TRANSACTION DECLINED";
                            }
                            else
                            {
                                objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                                objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                            }
                        }
                        else
                        {
                            objCollection = new COLLECTION();
                            objCollection.RESPONSECODE = "999";
                            objCollection.RESPONSEDESC = "USER IS NOT YET ENROLLED";
                        }
                        //objLogin = objWallet.ChangePassword(objReq.WALLET_ID, objReq.SESSION_ID, objReq.CURRENT_PASSWORD, objReq.NEW_PASSWORD);
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCollection);
                    }
                    break;
                case "RESEND_TPIN":
                    {
                        //Get Wallet amount and dest wallet  from transaction table using tran ref no.
                        objCollection = new COLLECTION();
                        //objCollection = objWallet.GetTransactionDetails(objReq.TXN_ID);
                        bool Response = false;
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "GENERATETPIN";
                        objTARequest.VIRTUALACCNO = objReq.SOURCE_WALLET;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                        objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                        objCollection.TPIN = objTAResponse.TPIN;
                        //get wallet balance
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "BALANCEENQUIRY";
                        objTARequest.VIRTUALACCNO = objReq.SOURCE_WALLET;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objCollection.TPIN + " . Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                        objWallet.SendTPIN("91", objReq.SOURCE_MOBILE, objTAResponse.TPIN,Message);
                        objCollection.TPIN_SENT_STATUS = "TRUE"; 
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCollection);
                    }
                    break;
                case "RESEND_OTP":
                    {
                         objLogin = new LOGIN();
                         objLogin.CURRENTPASSWORD=  objWallet.GetOTP(objReq.MOBILE);
                         if (objLogin.CURRENTPASSWORD != "")
                         {
                             objLogin.RESPONSECODE = "000";
                             objLogin.RESPONSEDESC = "SUCCESS";
                             string Message = objLogin.CURRENTPASSWORD + " is your One Time Password(OTP) for V-eWallet enrollment. Kindly share with merchant to authorise your enrollment. Vijaya Bank";
                             objWallet.SendSMS("91", objReq.MOBILE,Message); //Sending OTP to source mobile
                             objLogin.OTP_SENT_STATUS = "TRUE"; 
                         }
                         else
                         {
                             objLogin = new LOGIN();
                             objLogin.RESPONSECODE = "999";
                             objLogin.RESPONSEDESC = "FAILURE";
                         }
                         sResponse = ClassJson.JsonSerializer<LOGIN>(objLogin);
                    }
                    break;
                case "VIEW_ORDERS":
                    {
                        COLLECTIONLIST objList = new COLLECTIONLIST();
                        objList= objWallet.ViewOrders(objReq.WALLET_ID);
                        if (objList.RESPONSECODE == "000") //to be checked
                        {
                            //call TA to get balance on wallet
                            objTARequest = new TAREQUEST();
                            objTARequest.OPCODE = "BALANCEENQUIRY";
                            objTARequest.VIRTUALACCNO = objReq.WALLET_ID;
                            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                            TAResponseJson = PostToTA(TARequestJson);
                            objTAResponse = new TARESPONSE();
                            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                            objList.BALANCE = objTAResponse.BALANCE;  
                        }
                        else
                        {
                            objList = new COLLECTIONLIST();
                            objList.RESPONSECODE = "999";
                            objList.RESPONSEDESC = "FAILURE";
                        }
                        sResponse = ClassJson.JsonSerializer<COLLECTIONLIST>(objList);
                    }
                    break;
                case "SENDSMS":
                    {
                        objLogin= new LOGIN();
                        objWallet.SendSMS(objReq.COUNTRYCODE, objReq.MOBILE, objReq.MESSAGE);
                        objLogin.OTP_SENT_STATUS = "TRUE";
                        objLogin.RESPONSECODE = "000";
                        objLogin.RESPONSEDESC = "SUCCESS";
                        sResponse = ClassJson.JsonSerializer<LOGIN>(objLogin);
                    }
                    break;
                case "BALANCEENQUIRY":
                    {
                        COLLECTIONLIST objList = new COLLECTIONLIST();
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "BALANCEENQUIRY";
                        objTARequest.VIRTUALACCNO = objReq.VIRTUALACCNO;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        objList.BALANCE = objTAResponse.BALANCE;
                        sResponse = ClassJson.JsonSerializer<COLLECTIONLIST>(objList);
                    }
                    break;
                case "VERIFY_IMPS_P2A":
                    {
                        COLLECTION objCol = new COLLECTION();
                        objTARequest = new TAREQUEST();

                        objTARequest.OPCODE = "VERIFYIMPSTRANSFER";
                        objTARequest.VIRTUALACCNO = objReq.SOURCE_WALLET;
                        objTARequest.AMOUNT = objReq.AMOUNT;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        clsEvent.LogEvent("TA Responsecode: " + objTAResponse.RESPONSECODE);
                        if (objTAResponse.RESPONSECODE == "000")
                        {
                            if (objTARequest.VIRTUALACCNO == "999999900038430" || objTARequest.VIRTUALACCNO == "999999900038431" || objTARequest.VIRTUALACCNO == "999999900038429" || objTARequest.VIRTUALACCNO == "999999900086660")
                            {
                                objReq.ACCOUNTNO = "133100301000461";
                            }
                            objCol.RESPONSECODE = objTAResponse.RESPONSECODE;
                            objCol.RESPONSEDESC = objTAResponse.RESPONSEDESC;
			    objCol.WALLETBALANCE = objTAResponse.BALANCE;
                            objCol.TPIN = objTAResponse.TPIN;
                            objCol.REMARKS = objReq.REMARKS;
                            objCol.TXN_DATE = DateTime.Now.ToString("yyyy-MM-dd");
                            objCol.COLLECTION_AMOUNT = objReq.AMOUNT;
                            objCol.WALLET_AMOUNT = objReq.AMOUNT;
                            objCol.CASH_AMOUNT = "0.00";
                            objCol.SOURCE_WALLET = objReq.SOURCE_WALLET;
                            objCol.DESTINATION_WALLET = objReq.ACCOUNTNO; //null value
                            objCol.DESTINATIONMOBILE = objReq.ACCOUNTNO; //null value
                            objCol.TRANSTATUS = "VALIDATED";
                            objCol.TRANTYPE = "BANK TRANSFER";
                            objCol.SOURCE_MOBILE = objReq.SOURCE_MOBILE;
                            objCol.TXN_ID = objWallet.CreateTransaction(objCol);
                            if (objCollection.TXN_ID == "")
                            {
                                objCollection = new COLLECTION();
                                objCollection.RESPONSECODE = "999";
                                objCollection.RESPONSEDESC = "FAILURE";
                            }
                            else
                            {
                                string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objTAResponse.TPIN + " . Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                                objWallet.SendSMS("91", objReq.SOURCE_MOBILE, Message);
                                objCollection.TPIN_SENT_STATUS = "TRUE";
                                objCollection.RESPONSECODE = "000";
                            }
                        }
                        else
                        {
                            objCol.RESPONSECODE = objTAResponse.RESPONSECODE;
                            objCol.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                            objCol.BALANCE = objTAResponse.BALANCE;
                        }
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCol);
                    }
                    break;
                case "IMPS_P2A":
                    {
                        string Remarks = string.Empty;
                        COLLECTION objCol = new COLLECTION();
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "IMPSTRANSFERP2A";
                        objTARequest.VIRTUALACCNO = objReq.SOURCE_WALLET;
                        objTARequest.ACCOUNTNUMBER = objReq.ACCOUNT_NO;
                        if (string.IsNullOrEmpty(objReq.ACCOUNT_NO))
                        {
                            objCol=new COLLECTION();
                            objCol.RESPONSECODE = "777";
                            objCol.RESPONSEDESC = "Account Number Can't be null";
                        }
                        else
                        {
                            if (objTARequest.VIRTUALACCNO == "999999900038430" || objTARequest.VIRTUALACCNO == "999999900038431" || objTARequest.VIRTUALACCNO == "999999900038429" || objTARequest.VIRTUALACCNO == "999999900086660")
                            {
                                objTARequest.ACCOUNTNUMBER = "133100301000461";
                                objReq.ACCOUNT_NO = "133100301000461";
                            }
                                objTARequest.IFSCCODE = "VIJB000" + objReq.ACCOUNT_NO.Substring(0, 4);
                                objTARequest.AMOUNT = objReq.AMOUNT;
                                objTARequest.TPIN = objReq.TPIN;
                                objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                                TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                                TAResponseJson = PostToTA(TARequestJson);
                                objTAResponse = new TARESPONSE();
                                objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                                if (objTAResponse.RESPONSECODE == "000")
                                {
                                    //bool response = objWallet.UpdateTransactionStatusIMPS(objReq.TXN_ID, objTAResponse.RESPONSECODE, objTAResponse.TRNREFNO, "RRN:" + objTAResponse.RRN + " | TA RESPONSE: " + objTAResponse.RESPONSEDESC + " | USER REMARKS: " + objReq.REMARKS,objReq.ACCOUNT_NO);
                                    if (!String.IsNullOrEmpty(objReq.REMARKS))
                                        Remarks = "RRN:" + objTAResponse.RRN + " | " + objReq.REMARKS;
                                    else
                                        Remarks = "RRN:" + objTAResponse.RRN;
                                    bool response = objWallet.UpdateTransactionStatusIMPS(objReq.TXN_ID, objTAResponse.RESPONSECODE, objTAResponse.TRNREFNO,Remarks , objReq.ACCOUNT_NO);
                                    objCollection.RESPONSECODE = objTAResponse.RESPONSECODE;
                                    objCollection.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                                    objCollection.TXN_DATE = DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss");
                                    objCol.WALLET_AMOUNT = objReq.AMOUNT;

                                    string Message = "An amount of Rs. " + objReq.AMOUNT + " has been debited from your V-eWallet. Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                                    objWallet.SendSMS("91", objTAResponse.SRCMOBILENUMBER, Message);
                                }
                                objCol.RESPONSECODE = objTAResponse.RESPONSECODE;
                                objCol.RESPONSEDESC = objTAResponse.RESPONSEDESC;
                                objCol.BALANCE = objTAResponse.BALANCE;
                            //}
                        }
                        sResponse = ClassJson.JsonSerializer<COLLECTION>(objCol);
                    }
                    break;
                
                default: break;
            }
            //sResponse = ReturnEncryptedString(sResponse);
            Page.Response.Write(sResponse);
        }
       catch (Exception eee)
        {
            clsEvent.LogExceptionEvent(eee.Message + " at : " + DateTime.Now.ToString());
            sResponse = "116";
        }
        

    }
    public string PostToTA(string sRequest)
    {
        var result = "";
        ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;

        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://180.92.175.246:449/Process.aspx"); //firewall is blocking
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://akua1.transactionanalysts.com:449/Process.aspx"); //test TA server
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://service.transactionanalysts.com:460/Process.aspx"); //old live TA server
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://vbwallet.transactionanalysts.com/process.aspx"); //live TA server
    
        httpWebRequest.ContentType = "text/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            string json = sRequest;

            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
        }

        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
             result = streamReader.ReadToEnd();
        }

        return result.ToString() ;
    }
    private bool GetSessionTimedout(string Mobile)
    {
        return Convert.ToBoolean(objWallet.GetSessionTime(Mobile));
    }
    private string ReturnEncryptedString(string sResponse)
    {
        string sEncryptedResponse = JsonCsharpUtiil.getEncryptString(sResponse, "vijayaWallet@2015$$##||~@");
        return sEncryptedResponse;
    }
}