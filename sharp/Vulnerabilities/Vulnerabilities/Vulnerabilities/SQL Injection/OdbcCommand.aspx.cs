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
    public partial class OdbcCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn =
                new System.Data.Odbc.OdbcConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);

            var cmd = new System.Data.Odbc.OdbcCommand(Request.Params["cmd"]);
            cmd = new System.Data.Odbc.OdbcCommand(Request.Params["cmd"], conn);
            cmd = new System.Data.Odbc.OdbcCommand(Request.Params["cmd"], conn, conn.BeginTransaction());
        }
    }
}