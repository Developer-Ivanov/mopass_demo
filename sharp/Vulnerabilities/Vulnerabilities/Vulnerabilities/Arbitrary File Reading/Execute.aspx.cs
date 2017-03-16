using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyHandler;

namespace Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading
{
    public partial class Execute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var writer = new StringWriter();
            Server.Execute(Request.Params["file"], writer);
            IHttpHandler helloworld = new HelloWorldHandler();
            Server.Execute(helloworld, writer, true);
            Server.Execute(Request.Params["file"], writer, true);
        }
    }
}

namespace MyHandler
{
    public class HelloWorldHandler : IHttpHandler
    {
        public HelloWorldHandler()
        {
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest Request = context.Request;
            HttpResponse Response = context.Response;
            // This handler is called whenever a file ending 
            // in .sample is requested. A file with that extension
            // does not need to exist.
            context.Server.Execute(Request.Params["file"]);
        }

        public bool IsReusable
        {
            // To enable pooling, return true here.
            // This keeps the handler in memory.
            get { return false; }
        }
    }
}