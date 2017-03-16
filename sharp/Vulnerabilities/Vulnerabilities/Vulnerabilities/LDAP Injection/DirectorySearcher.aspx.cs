using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.LDAP_Injection
{
    public partial class DirectorySearcher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dir = new System.DirectoryServices.DirectorySearcher(new DirectoryEntry(Request.Params["path"]));
            string res = dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(Request.Params["filter"]);
            res += dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(new DirectoryEntry(Request.Params["path"]), Request.Params["filter"]);
            res += dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(Request.Params["filter"], new string[1] { "name" });
            res += dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(new DirectoryEntry(Request.Params["path"]), Request.Params["filter"], new string[1] { "name" });
            res += dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(Request.Params["filter"], new string[1] { "name" }, SearchScope.Base);
            res += dir.ToString();
            dir = new System.DirectoryServices.DirectorySearcher(new DirectoryEntry(Request.Params["path"]), Request.Params["filter"], new string[1] { "name" }, SearchScope.Base);
            res += dir.ToString();
            Response.Write(res);
        }
    }
}