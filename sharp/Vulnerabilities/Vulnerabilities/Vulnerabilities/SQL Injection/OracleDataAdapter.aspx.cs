using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class OracleDataAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn =
                new OracleConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
            var oradb = new System.Data.OracleClient.OracleDataAdapter(new OracleCommand(Request.Params["cmd"]));

            oradb = new System.Data.OracleClient.OracleDataAdapter(Request.Params["cmd"], conn);

            oradb = new System.Data.OracleClient.OracleDataAdapter(Request.Params["cmd"], ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
        }
    }
}