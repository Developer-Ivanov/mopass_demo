using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading
{
    public partial class OpenRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = File.OpenRead(Request.Params["file"]);

            byte[] bytes = new byte[text.Length];
            int numBytesToRead = (int)text.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                // Read may return anything from 0 to numBytesToRead.
                int n = text.Read(bytes, numBytesRead, numBytesToRead);

                // Break when the end of the file is reached.
                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }
            Response.Write(System.Text.Encoding.UTF8.GetString(bytes));
        }
    }
}