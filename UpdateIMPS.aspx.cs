using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateIMPS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WalletService.ServiceClient objWallet = new WalletService.ServiceClient();
        try
        {
            string Input = Request.QueryString.Get("INPUT");
            if (!string.IsNullOrEmpty(Input))
            {
                //Input = JsonCsharpUtiil.getDecryptString(Input, "ditVijayaBank!@#$$$~||%%");
                Input = HttpUtility.UrlDecode(Input);
                clsEvent.LogEvent(Input);

                ClassJson.REQUEST objReq = new ClassJson.REQUEST();
                objReq = ClassJson.JsonDeserialize<ClassJson.REQUEST>(Input);

                bool response = objWallet.UpdateIMPSTransactionStatus(objReq.TRNREFNO, objReq.STATUS.ToUpper());
                if (response)
                    Page.Response.Write("UPDATED SUCCESSFULLY");
                else
                    Page.Response.Write("FAILED TO UPDATE");
            }
            else
            {
                Page.Response.Write("EMPTY PARAMETER RECEIVED!");
            }
        }
        catch (Exception ee)
        {
            clsEvent.LogExceptionEvent("Exception in UpdateIMPS.aspx page. Message: "+ee.Message);
        }
    }
}