using System;

namespace Mopas.Tests
{
    public partial class Xss : System.Web.UI.Page
    {
        /// <summary>
        /// 3.
        /// Cross-Site Scripting
        /// MOPAS
        /// Contains 1 vulnerability
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Params["name"];
            //string name = Request.Params["name"];  //Request.Unvalidated().Params["name"];
            
            // FIXED: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
            // GET /Tests/1%20INPUT%20DATA%20VERIFICATION/3%20Cross-site%20Scripting/Xss.aspx?name=%3cscript%3ealert(1)%3c%2fscript%3e HTTP/1.1
            // Host: localhost
            Response.Write("<b>Hello, " + name + "!</b>");
        }
    }
}