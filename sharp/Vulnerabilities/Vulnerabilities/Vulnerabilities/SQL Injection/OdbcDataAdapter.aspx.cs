using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class OdbcDataAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            var conn =
                new System.Data.Odbc.OdbcConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);

            var odbcadp = new System.Data.Odbc.OdbcDataAdapter(new System.Data.Odbc.OdbcCommand(Request.Params["cmd"]));
            odbcadp = new System.Data.Odbc.OdbcDataAdapter(Request.Params["cmd"], conn);
            odbcadp = new System.Data.Odbc.OdbcDataAdapter(Request.Params["cmd"], ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
        }
    }
}