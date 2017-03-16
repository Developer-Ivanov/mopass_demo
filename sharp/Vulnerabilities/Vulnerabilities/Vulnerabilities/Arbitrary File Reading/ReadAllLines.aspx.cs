using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading
{
    public partial class ReadAllLines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filepath = Request.Params["file"];
            var builder = new StringBuilder();
            foreach (var line in File.ReadAllLines(filepath))
            {
                builder.Append(line);
            }

            foreach (var line in File.ReadAllLines(filepath, Encoding.UTF8))
            {
                builder.Append(line);
            }
            Response.Write(builder.ToString());
        }
    }
}