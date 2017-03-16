using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class XPathNavigatorMatches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator nav = document.CreateNavigator();

            nav.Matches(Request.Params["path1"]);

            var expr = XPathExpression.Compile(Request.Params["path2"]);
            nav.Matches(expr);
        }
    }
}