using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Resource_Injection
{
    public partial class IPEndPoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] bytes = new byte[Request.Params["address"].Length * sizeof(char)];
            System.Buffer.BlockCopy(Request.Params["address"].ToCharArray(), 0, bytes, 0, bytes.Length);
            var ip = new System.Net.IPEndPoint(Convert.ToInt64(Request.Params["long_address"]), Convert.ToInt16(Request.Params["port"]));
            ip = new System.Net.IPEndPoint(new IPAddress(bytes), Convert.ToInt16(Request.Params["port"]));
        }
    }
}