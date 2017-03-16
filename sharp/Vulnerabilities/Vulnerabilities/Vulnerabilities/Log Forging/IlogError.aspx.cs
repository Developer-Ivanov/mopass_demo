using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log.config", Watch = true)]
namespace Vulnerabilities.Vulnerabilities.Log_Forging
{
    public partial class IlogError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ILog log = LogManager.GetLogger("root");
            log.Error(Request.Params["error"]);
        }
    }
}