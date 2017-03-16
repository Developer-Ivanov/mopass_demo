using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace Vulnerabilities.Vulnerabilities.Log_Forging
{
    public partial class IlogDebug : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ILog log = LogManager.GetLogger("root");
            log.Debug(Request.Params["error"]);
        }
    }
}