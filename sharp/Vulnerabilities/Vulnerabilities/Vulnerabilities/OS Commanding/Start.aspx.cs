using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.OS_Commanding
{
    /// <summary>
    /// ProcessStartInfo startInfo
    ///string fileName
    ///string fileName, string arguments
    ///string fileName, string userName, SecureString password, string domain
    ///string fileName, string arguments, string userName, SecureString password, string domain
    /// </summary>
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cmd = Request.Params["cmd"];
            string arg = Request.Params["arg"];
            string userName = Request.Params["username"];
            string pass = Request.Params["password"];
            SecureString secPass = new SecureString();
            for (int i = 0; i < pass.Length; i++)
                secPass.AppendChar(pass[i]);
            string domain = Request.Params["domain"];

            System.Diagnostics.Process.Start(cmd);
            System.Diagnostics.Process.Start(cmd, arg);
            System.Diagnostics.Process.Start(cmd, userName, secPass, domain);
            System.Diagnostics.Process.Start(cmd, arg, userName, secPass, domain);
        }
    }
}