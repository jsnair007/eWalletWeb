using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalletService;
using System.Net;
using System.IO;

public partial class eWallet_TPIN : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string sCountryCode = Request.QueryString.Get("countrycode");
        string sMobileNumber = Request.QueryString.Get("source_addr");
        string sOperator = Request.QueryString.Get("operator");
        string sRegion = Request.QueryString.Get("circle");
        string sMessage = Request.QueryString.Get("short_message");
        int ResponseCount = -1;
        ENROLL objEnroll=new ENROLL();
        string TARequestJson = string.Empty;
        string TAResponseJson = string.Empty;
        TAREQUEST objTARequest;
        TARESPONSE objTAResponse;
        COLLECTION objCollection = new COLLECTION();
        clsEvent.LogEvent("V-eWallet missed call Request: MobileNumber: " + sMobileNumber+", Operator: "+sOperator+", Region: "+sRegion+", Message: "+sMessage);
        if (string.IsNullOrEmpty(sMobileNumber))
        {
        }
        else
        {
            if (sMessage == "EWT")
            {
                WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
                ResponseCount = objWallet.MissedCallService("91", sMobileNumber, sOperator, sRegion);
                if (ResponseCount >= 0)
                {
                    //Check mobile number enrolled or not. If enrolled then send TPIN SMS to customer else not yet enrolled message
                    objEnroll = objWallet.CheckEnrollmentStatus(sMobileNumber);
                    if (objEnroll.RESPONSECODE == "913")
                    {
                        objTARequest = new TAREQUEST();
                        objTARequest.OPCODE = "GENERATETPIN";
                        objTARequest.VIRTUALACCNO = objEnroll.WALLETID;
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
                        objTARequest.VIRTUALACCNO = objEnroll.WALLETID;
                        objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                        TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                        TAResponseJson = PostToTA(TARequestJson);
                        objTAResponse = new TARESPONSE();
                        objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                        if (ResponseCount == 0 || ResponseCount == 1 || ResponseCount == 2 || ResponseCount == 3 || ResponseCount == 4)
                        {
                            string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objCollection.TPIN + " . Your current balance is: Rs. " + objTAResponse.BALANCE + ". Vijaya Bank";
                            objWallet.SendTPIN("91", sMobileNumber, objTAResponse.TPIN, Message);
                        }
                        else if (ResponseCount == 5)
                        {
                            string Message = "Kindly authorise your V-eWallet transaction with TPIN: " + objCollection.TPIN + " . Your current balance is: Rs. " + objTAResponse.BALANCE + ". Your maximum attempt count is exceeded for the day.";
                            objWallet.SendTPIN("91", sMobileNumber, objTAResponse.TPIN, Message);
                        }
                    }
                    else
                    {
                        string Message = "You are not yet enrolled for V-eWallet. Vijaya Bank";
                        objWallet.SendSMS("91", sMobileNumber, Message);
                    }
                }
            }
            else if (sMessage == "BAL" || sMessage == "bal")
            {
                clsEvent.LogEvent("V-eWallet SMS Request: MobileNumber: " + sMobileNumber + ", Operator: " + sOperator + ", Region: " + sRegion + ", Message: " + sMessage);
                WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
                objEnroll = objWallet.CheckEnrollmentStatus(sMobileNumber);
                if (objEnroll.RESPONSECODE == "913")
                {
                    objTARequest = new TAREQUEST();
                    objTARequest.OPCODE = "BALANCEENQUIRY";
                    objTARequest.VIRTUALACCNO = objEnroll.WALLETID;
                    objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
                    TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
                    TAResponseJson = PostToTA(TARequestJson);
                    objTAResponse = new TARESPONSE();
                    objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
                    //send sms
                    string Message = objTAResponse.BALANCE + " is your V-eWallet balance. Vijaya Bank";
                    objWallet.SendSMS("91", sMobileNumber, Message);
                }
                else
                {
                    string Message = "You are not yet enrolled for V-eWallet. Vijaya Bank";
                    objWallet.SendSMS("91", sMobileNumber, Message);
                }
            }
            else if (sMessage == "MINI" || sMessage == "mini")
            {
                string Message=string.Empty;
                clsEvent.LogEvent("V-eWallet SMS Request: MobileNumber: " + sMobileNumber + ", Operator: " + sOperator + ", Region: " + sRegion + ", Message: " + sMessage);
                WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
                COLLECTIONLIST objList = new COLLECTIONLIST();
                objEnroll = objWallet.CheckEnrollmentStatus(sMobileNumber);
                if (objEnroll.RESPONSECODE == "913")
                {
                    objList = objWallet.ViewMiniOrders(objEnroll.WALLETID);
                    //sms format to be defined here
                    foreach (var value in objList.LISTOFCOLLECTION)
                    {
                        Message += value.TXN_DATE + ":" + value.AMOUNT.PadLeft(8, 'X') + ":" + value.MINIDESCRIPTION.Substring(0, 6) + "\n";
                    }
                    objWallet.SendSMS("91", sMobileNumber, Message);
                }
            }
        }
        //Response.Redirect(""+sSourceAddr, false);

    }

    private string PostToTA(string sRequest)
    {
        var result = "";
        ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;

        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://180.92.175.246:449/Process.aspx"); //test url
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://akua1.transactionanalysts.com:449/Process.aspx"); //test TA server
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://service.transactionanalysts.com:460/Process.aspx");
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

        return result.ToString();
    }
}