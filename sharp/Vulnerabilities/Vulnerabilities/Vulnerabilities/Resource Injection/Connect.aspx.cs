using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Resource_Injection
{
    public partial class Connect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sock = new System.Net.Sockets.Socket(SocketType.Raw, ProtocolType.IP);
            sock.Connect(new System.Net.IPEndPoint(Convert.ToInt64(Request.Params["long_address"]), Convert.ToInt16(Request.Params["port"])));

            byte[] bytes = new byte[Request.Params["address"].Length * sizeof(char)];
            System.Buffer.BlockCopy(Request.Params["address"].ToCharArray(), 0, bytes, 0, bytes.Length);

            byte[] bytes2 = new byte[Request.Params["address2"].Length * sizeof(char)];
            System.Buffer.BlockCopy(Request.Params["address2"].ToCharArray(), 0, bytes, 0, bytes.Length);

            var ip = new IPAddress(bytes);
            var ip2 = new IPAddress(bytes2);
            IPAddress[] ips = new IPAddress[2]{ip, ip2};
            sock.Connect(new System.Net.IPEndPoint(ip, Convert.ToInt16(Request.Params["port"])));

            sock.Connect(ips, Convert.ToInt16(Request.Params["port"]));

            sock.Connect(Request.Params["host"], Convert.ToInt16(Request.Params["port"]));
        }
    }
}