using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Resource_Injection
{
    public partial class DnsEndPoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dnsep = new System.Net.DnsEndPoint(Request.Params["address"], Convert.ToInt16(Request.Params["port"]));

            dnsep = new System.Net.DnsEndPoint(Request.Params["address"], Convert.ToInt16(Request.Params["port"]), AddressFamily.FireFox);
        }
    }
}