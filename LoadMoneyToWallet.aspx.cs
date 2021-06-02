using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WalletService;
using System.Net;
using System.IO;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    private string PostToTA(string sRequest)
    {
        var result = "";
        ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;

        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://180.92.175.246:449/Process.aspx"); //Test
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://akua1.transactionanalysts.com:449/Process.aspx"); //test TA server
        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://service.transactionanalysts.com:460/Process.aspx"); //LIVE TA Server
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
    protected void Button1_Click1(object sender, EventArgs e)
    {
        WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
        bool Response = false;
        ENROLL objEnroll = new ENROLL();
        string TARequestJson = string.Empty;
        string TAResponseJson = string.Empty;
        TAREQUEST objTARequest;
        TARESPONSE objTAResponse;
        COLLECTION objCollection = new COLLECTION();
        //fetch mobile number from db
        IList<LOGIN> objList = objWallet.FetchMobileNumberToLoadWallet();
        foreach (LOGIN staffRecord in objList)
        {
            //send to TA and get Wallet ID
            objTARequest = new TAREQUEST();
            objTARequest.OPCODE = "BALANCEENQUIRY";
            objTARequest.VIRTUALACCNO = staffRecord.WALLETID; //objCollection.SOURCE_WALLET;
            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
            TAResponseJson = PostToTA(TARequestJson);
            objTAResponse = new TARESPONSE();
            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
            if (objTAResponse.RESPONSECODE == "000")
            {
                Response = objWallet.LoadMoneyToWallet(staffRecord.WALLETID, staffRecord.MOBILENO, staffRecord.NAME, objTAResponse.BALANCE);
                if (Response)
                {
                    Page.Response.Write(Environment.NewLine + " | success for mobile"+staffRecord.MOBILENO);
                    clsEvent.LogEvent("success for Mobile: " + staffRecord.MOBILENO);
                }
                else
                {
                    Page.Response.Write("\nWallet loaded failed. Mobile: " + staffRecord.MOBILENO);
                }
            }
            else
            {
                Page.Response.Write("\nWallet loading failed due to TA response. Mobile: " + staffRecord.MOBILENO);
            }
        }
    }
}