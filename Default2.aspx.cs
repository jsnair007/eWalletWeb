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
    protected void Button1_Click(object sender, EventArgs e)
    {
        WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
        int ResponseCount = -1;
        bool Response = false;
        ENROLL objEnroll = new ENROLL();
        string TARequestJson = string.Empty;
        string TAResponseJson = string.Empty;
        TAREQUEST objTARequest;
        TARESPONSE objTAResponse;
        COLLECTION objCollection = new COLLECTION();
        //fetch mobile number from db
        IList<LOGIN> objList= objWallet.FetchMobileNumber();
        foreach(LOGIN staffRecord in objList)
        {
            //send to TA and get Wallet ID
            objTARequest = new TAREQUEST();
            objTARequest.OPCODE = "ENROLLMENT";
            objTARequest.MOBILE = staffRecord.MOBILENO;
            objTARequest.NAME = staffRecord.NAME;
            objTARequest.TIMESTAMP = DateTime.Now.ToString("ddMMyyyy HHmmss");
            TARequestJson = ClassJson.JsonSerializer<TAREQUEST>(objTARequest);
            TAResponseJson = PostToTA(TARequestJson);
            objTAResponse = new TARESPONSE();
            objTAResponse = ClassJson.JsonDeserialize<TARESPONSE>(TAResponseJson);
            if (objTAResponse.RESPONSECODE == "000" || objTAResponse.RESPONSECODE == "913")
            {
                Response = objWallet.UpdateWalletIDFromTABulk(objTAResponse.VIRTUALACCOUNT, staffRecord.MOBILENO, staffRecord.NAME);
                if (Response)
                {
                    objWallet.UpdateFlag(staffRecord.MOBILENO);
                    Page.Response.Write("\nWallet Created for Mobile: " + staffRecord.MOBILENO);
                }
                else {
                    Page.Response.Write("\nWallet Creation failed. Mobile: " + staffRecord.MOBILENO);
                }
            }
            else
            {
                Page.Response.Write("\nWallet creation failed due to TA response. Mobile: " + staffRecord.MOBILENO);
            }
            clsEvent.LogEvent("V-eWallet Bulk WalletID Update: MobileNumber: " + staffRecord.MOBILENO);
        }
       
    }

    private string PostToTA(string sRequest)
    {
        var result = "";
        ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;

        //var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://180.92.175.246:449/Process.aspx"); //Test
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