using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities
{
    public partial class OpenRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect(Request.Params["goto"], true); 
            }
            catch (Exception)
            {
                Response.Write("Go to");
            }
        }
    }
}