using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.XPath
{
    public partial class XmlNodeSelectNodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("booksort.xml");

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            nodeList = root.SelectNodes(Request.Params["nede"]);
        }
    }
}