using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page 
{

    protected void Page_Load(object sender, EventArgs e)
    {
        ReportViewer1.Report = new XtraReport1();

        if(Session["skippedDetailBands"] != null)
        {
            Hashtable ht = (Hashtable)Session["skippedDetailBands"];

            ((XtraReport1)ReportViewer1.Report).skippedDetailBands = ht;

            if(Request["grpid"] != null && !Page.IsCallback) {
                if(ht.Contains(Request["grpid"]))
                    ht[Request["grpid"]] = !Convert.ToBoolean(ht[Request["grpid"]]);
                else
                    ht.Add(Request["grpid"], true);
            }
        }
        else
            Session["skippedDetailBands"] = new Hashtable();
    
    }
}
