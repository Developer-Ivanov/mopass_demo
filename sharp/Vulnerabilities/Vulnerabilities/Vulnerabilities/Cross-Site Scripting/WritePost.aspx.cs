using System;

namespace Vulnerabilities.Vulnerabilities.Cross_Site_Scripting
{
    public partial class WritePost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.Form["name2"]);
        }
    }
}