using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Open_Redirect
{
    public partial class AddHeader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listener = new HttpListener();
            listener.Start();
            HttpListenerContext context = listener.GetContext();
            HttpListenerResponse response = context.Response;
            response.AddHeader(Request.Params["name"], Request.Params["value"]);
        }
    }
}