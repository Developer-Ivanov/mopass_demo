using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Open_Redirect
{
    public partial class RedirectPermanent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.RedirectPermanent(Request.Params["link"]);
            Response.RedirectPermanent(Request.Params["link"], true);
        }
    }
}