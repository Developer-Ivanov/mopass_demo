using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Cross_Site_Scripting
{
    /// <summary>
    /// One vulnerability for each aspx and aspx.cs files
    /// </summary>
    public partial class Write : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpResponseBase resp = new HttpResponseWrapper(Response);
            resp.Write(Request.Params["name"]);
        }
    }
}