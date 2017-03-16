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
    public partial class XmlDocumentSelectSingleNode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("books.xml");
            XmlNode node = document.SelectSingleNode(Request.Params["node"]);
            XmlTextReader reader = new XmlTextReader("books.xml");
            XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);
            node = document.SelectSingleNode(Request.Params["node"], nsmanager);
        }
    }
}