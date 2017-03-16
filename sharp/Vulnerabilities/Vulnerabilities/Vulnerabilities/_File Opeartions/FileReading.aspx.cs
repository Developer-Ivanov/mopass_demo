using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities
{
    public partial class FileReading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = Request.Params["report"];

            if (fileName != null)
            {
                using (var file = new StreamReader("D:\\AI\\Reports\\" + fileName))
                {
                    string reportLines = "";
                    try
                    {
                        foreach (var line in file.ReadLine())
                        {
                            reportLines += line;
                        }

                        Response.Write("<b>Report:</b></br>" + reportLines);
                    }
                    catch
                    {
                        Response.Write("Error reading file");
                    }

                }
            }
        }
    }
}