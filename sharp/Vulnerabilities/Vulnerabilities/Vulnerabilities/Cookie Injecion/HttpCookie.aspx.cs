using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Cookie_Injecion
{
    public partial class HttpCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cookie = new System.Web.HttpCookie(Request.Params["name"]);
            cookie = new System.Web.HttpCookie(Request.Params["name"], Request.Params["value"]);
        }
    }
}