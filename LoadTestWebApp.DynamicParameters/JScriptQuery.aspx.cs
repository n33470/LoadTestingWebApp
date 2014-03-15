using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoadTestWebApp.DynamicParameters
{
    public partial class JScriptQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int index;
            string qstring;
            string dateportion;
            string sessionidportion;

            qstring = Request.QueryString["CustomQueryString"];
            index = qstring.IndexOf("___");
            dateportion = qstring.Substring(0, index);
            index += 3;
            sessionidportion = qstring.Substring(index, qstring.Length - index);

            if (sessionidportion != Session.SessionID)
            {
                Response.StatusCode = 401;
                IndexLabel.Text = "Failure!  Invalid querystring parameter found.";
            }
            else
            {
                IndexLabel.Text = "Success.  Dynamic querystring parameter was found.";
            }
            IndexLabel.Text += "<br>\r\n";
        }
    }
}