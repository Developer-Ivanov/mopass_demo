using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Deserialization
{
    public partial class ObjectStateFormatterDeserialize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var obj = new ObjectStateFormatter();
            obj.Deserialize(Request.Params["object"]);
        }
    }
}