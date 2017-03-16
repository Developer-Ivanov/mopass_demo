using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class NavSelectSingleNode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument document = new XPathDocument("books.xml");

            XPathNavigator nav = document.CreateNavigator();
            var expr = XPathExpression.Compile(Request.Params["path"]);
            XmlTextReader reader = new XmlTextReader("books.xml");
            XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);
            nav.SelectSingleNode(expr);
            nav.SelectSingleNode(Request.Params["path"]);
            nav.SelectSingleNode(Request.Params["path"], nsmanager);
        }
    }
}