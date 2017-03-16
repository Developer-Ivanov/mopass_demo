//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlServerCe;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//
//
//namespace Vulnerabilities.Vulnerabilities.SQL_Injection
//{
//    public partial class SqlCeCommand : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            var sqlcecmd = new SqlCeCommand(Request.Params["cmd"]);
//            var conn =
//                new SqlCeConnection(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString);
//
//            sqlcecmd = new SqlCeCommand(Request.Params["cmd"], conn);
//
//            sqlcecmd = new SqlCeCommand(Request.Params["cmd"], conn, conn.BeginTransaction());
//        }
//    }
//}