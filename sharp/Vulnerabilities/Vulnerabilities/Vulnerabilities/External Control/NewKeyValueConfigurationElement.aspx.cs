using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Vulnerabilities.Vulnerabilities.External_Control_of_System
{
    public partial class NewKeyValueConfigurationElement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var kvce = new KeyValueConfigurationElement(Request.Params["key"], Request.Params["value"]);
            Response.Write(kvce);
        }
    }
}