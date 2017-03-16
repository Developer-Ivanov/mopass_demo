using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading
{
    public partial class ReadAllBytes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var bytes = File.ReadAllBytes(Request.Params["file"]);
            Response.Write(System.Text.Encoding.UTF8.GetString(bytes));
        }
    }
}