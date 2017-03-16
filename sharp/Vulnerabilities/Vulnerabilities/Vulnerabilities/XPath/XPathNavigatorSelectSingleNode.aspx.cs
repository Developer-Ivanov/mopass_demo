using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class XPathNavigatorSelectSingleNode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            XPathNavigator node = navigator.SelectSingleNode(Request.Params["node"]);
            Response.Write(node.InnerXml);

        }
    }
}