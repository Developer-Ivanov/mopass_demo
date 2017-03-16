using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class OleDbDataAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var oledb = new System.Data.OleDb.OleDbDataAdapter(new System.Data.OleDb.OleDbCommand(Request.Params["cmd"]));
            oledb = new System.Data.OleDb.OleDbDataAdapter(Request.Params["cmd"], new OleDbConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString));
            oledb = new System.Data.OleDb.OleDbDataAdapter(Request.Params["cmd"], ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
        }
    }
}