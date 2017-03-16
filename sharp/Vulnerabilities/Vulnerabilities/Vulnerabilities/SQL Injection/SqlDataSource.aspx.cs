using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.SQL_Injection
{
    public partial class SqlDataSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dsrc = new System.Web.UI.WebControls.SqlDataSource(ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString, Request.Params["cmd"]);
            dsrc = new System.Web.UI.WebControls.SqlDataSource("provider", ConfigurationManager.ConnectionStrings["connSpionshopString"].ConnectionString, Request.Params["cmd"]);
        }
    }
}