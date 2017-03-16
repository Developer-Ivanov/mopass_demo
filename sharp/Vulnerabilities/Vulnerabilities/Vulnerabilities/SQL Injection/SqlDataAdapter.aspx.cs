using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class SqlDataAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sqlad =
                new System.Data.SqlClient.SqlDataAdapter(new System.Data.SqlClient.SqlCommand(Request.Params["file"]));

            sqlad =
                new System.Data.SqlClient.SqlDataAdapter(Request.Params["cmd"], new SqlConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString));

            sqlad =
                new System.Data.SqlClient.SqlDataAdapter(Request.Params["cmd"], ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
        }
    }
}