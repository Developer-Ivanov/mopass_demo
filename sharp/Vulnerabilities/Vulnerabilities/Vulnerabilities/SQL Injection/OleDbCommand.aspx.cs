using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class OleDbCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var oledbcmd = new System.Data.OleDb.OleDbCommand(Request.Params["cmd"]);
            var conn =
                new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
            
            oledbcmd = new System.Data.OleDb.OleDbCommand(Request.Params["cmd"], conn);

            oledbcmd = new System.Data.OleDb.OleDbCommand(Request.Params["cmd"], conn, conn.BeginTransaction());
        }
    }
}