using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.XML_External_Entity
{
    public partial class Load : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load(Request.Params["path"]);
        }
    }
}