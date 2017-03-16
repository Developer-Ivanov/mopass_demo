using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class ExpressionCompile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var reader = new XmlTextReader("books.xml");
            XElement root = XElement.Load(reader);
            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(reader.NameTable);
            XElement child1 = root.XPathSelectElement(Request.Params["path1"]);
            XElement child2 = root.XPathSelectElement(Request.Params["path2"], namespaceManager);

            Response.Write(child1.Value);
            Response.Write(child2.Value);
        }
    }
}