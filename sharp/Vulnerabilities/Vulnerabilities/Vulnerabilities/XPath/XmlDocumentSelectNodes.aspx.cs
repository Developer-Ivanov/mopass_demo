using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class XmlDocumentSelectNodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("books.xml");
            XmlNodeList node = document.SelectNodes(Request.Params["node"]);
            XmlTextReader reader = new XmlTextReader("myfile.xml");
            XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);
            node = document.SelectNodes(Request.Params["node"], nsmanager);
        }
    }
}