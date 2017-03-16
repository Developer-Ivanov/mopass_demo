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
    /// System.Web.UI.XPathBinder
    /// </summary>
    public partial class XPathBinderEval : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument("books.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathBinder.Eval(nav, Request.Params["path1"]);

            XPathBinder.Eval(nav, Request.Params["path2"], "0, 1");

            XmlTextReader reader = new XmlTextReader("books.xml");
            XmlNamespaceManager nsmanager = new XmlNamespaceManager(reader.NameTable);


            XPathBinder.Eval(nav, Request.Params["path3"], nsmanager);
            
            XPathBinder.Eval(nav, Request.Params["path4"], "0,1", nsmanager);
        }
    }
}