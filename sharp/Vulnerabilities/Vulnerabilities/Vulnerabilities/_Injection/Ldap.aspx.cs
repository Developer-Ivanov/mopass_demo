using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Injection
{
    public partial class Ldap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, "ptsecurity.ru");

            string address = Request.Params["address"];
            string filter = "Address=" + address;
            string result = "";

            Domain domain = Domain.GetDomain(dc);

            DirectorySearcher ds = new DirectorySearcher(domain.GetDirectoryEntry(), filter);
            using (SearchResultCollection src = ds.FindAll())
            {
                foreach (var res in src)
                {
                    result = res.ToString();
                }
            }

            Response.Write(result);
        }
    }
}