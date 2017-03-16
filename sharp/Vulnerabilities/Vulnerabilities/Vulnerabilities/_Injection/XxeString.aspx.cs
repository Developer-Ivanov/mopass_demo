using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.Injection
{
    public partial class XxeString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(Request.Params["xml"]);
            Response.Write(xmldoc.GetElementsByTagName("foo").Item(0).InnerText);
        }
    }
}