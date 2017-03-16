using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities
{
    public partial class FileModification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = Request.Params["file"];
            File.AppendAllText(fileName, Request.Params["text"]);
        }
    }
}