using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.XML_External_Entity
{
    /// <summary>
    /// Not full parameter coverage
    /// </summary>
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create(Request.Params["inputUri"]);
            reader = XmlReader.Create(Request.Params["inputUri"], new XmlReaderSettings());
            reader = XmlReader.Create(Request.Params["inputUri"], new XmlReaderSettings(), new XmlParserContext(null, null, null, new XmlSpace(), null));
        }
    }
}