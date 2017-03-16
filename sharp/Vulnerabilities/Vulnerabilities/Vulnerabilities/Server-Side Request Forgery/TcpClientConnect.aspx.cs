using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Server_Side_Request_Forgery
{
    public partial class TcpClientConnect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var socket = new ClientWebSocket();
            socket.ConnectAsync(new Uri(Request.Params["ImTainted"]), new CancellationToken());

            var tcpConn = new TcpClient();
            tcpConn.Connect(Request.Params["ImTainted"], 80);
        }
    }
}