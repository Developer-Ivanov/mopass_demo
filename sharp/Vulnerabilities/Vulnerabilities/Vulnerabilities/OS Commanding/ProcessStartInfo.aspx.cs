using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.OS_Commanding
{
    /// <summary>
    /// 1. string file
    /// 2. string fileName, string arguments
    /// </summary>
    public partial class ProcessStartInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cmd1 = Request.Params["cmd1"];

            if (cmd1 != null)
            {
                var procinfo = new System.Diagnostics.ProcessStartInfo(cmd1)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };
                Process.Start(procinfo);
            }

            string cmd2 = Request.Params["cmd2"];
            string arg2 = Request.Params["arg2"];
            if (cmd2 != null && arg2 != null)
            {
                var procinfo2 = new System.Diagnostics.ProcessStartInfo(cmd2, arg2)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };
                Process.Start(procinfo2);
            }

            string cmd3 = Request.Params["cmd3"];
            if (cmd3 != null)
            {
                var procinfo3 = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/C ping " + cmd3)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };
                var p = Process.Start(procinfo3);
                Response.Write(p.StandardOutput.ReadToEnd());
            }

        }
    }
}