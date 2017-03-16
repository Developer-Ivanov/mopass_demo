using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities
{
    public partial class OSCommanding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo = new ProcessStartInfo(Request.Params["command"]);
                myProcess.Start();
                myProcess.Close();
        }
    }
}