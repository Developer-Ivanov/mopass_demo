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
    public partial class SqlCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString;
            conn.Open();
            SqlTransaction transaction;
            transaction = conn.BeginTransaction("SampleTransaction");
            var cmd1 = new System.Data.SqlClient.SqlCommand(Request.Params["cmd1"]);
            var cmd2 = new System.Data.SqlClient.SqlCommand(Request.Params["cmd2"], conn);
            var cmd3 = new System.Data.SqlClient.SqlCommand(Request.Params["cmd3"], conn, transaction);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
    }
}