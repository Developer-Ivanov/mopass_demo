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
    /// <summary>
    /// XPathNavigator.Select()
    /// 2 XPath Injection Vulnerabilities 
    /// </summary>
    public partial class XPathBinderBinderSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument("books.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathBinder.Select(nav, Request.Params["path"]);

            XmlTextReader reader = new XmlTextReader("books.xml");
            XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);


            XPathBinder.Select(nav, Request.Params["path2"], nsmanager);
        }
    }
}