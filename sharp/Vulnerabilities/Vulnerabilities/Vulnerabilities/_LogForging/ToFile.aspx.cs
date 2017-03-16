using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.LogForging
{
    public partial class ToFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string parId = Request.Params["id"];
            try
            {
                int id = int.Parse(parId);
            }
            catch (System.FormatException ex)
            {
                File.AppendAllText(@"C:\log\error.log", "Error trying parse id value '" + parId);
                File.AppendAllText(@"C:\log\error.log", ex.StackTrace);
                throw;
            }
        }
    }
}