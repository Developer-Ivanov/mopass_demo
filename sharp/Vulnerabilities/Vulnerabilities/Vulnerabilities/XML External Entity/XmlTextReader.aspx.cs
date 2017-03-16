using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.XML_External_Entity
{
    /// <summary>
    /// Check parameters
    /// </summary>
    public partial class XmlTextReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = "<book>" +
                         "<author>1</author>" +
                         "</book>";
            var reader = new System.Xml.XmlTextReader(Request.Params["url"]);
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new StreamReader("books.xml"));
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new StreamReader("books.xml"), new NameTable());
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new NameTable());
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new StringReader(xml));
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new StringReader(xml), new NameTable());
            reader = new System.Xml.XmlTextReader(Request.Params["url"], new XmlNodeType(), new XmlParserContext(null, null, null, new XmlSpace()));
        }
    }
}