using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mssql
{
    public partial class insert1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                string id = Request.Params["id"].ToString();

                string query1 = "INSERT INTO articles (userid, article) values(" + id + ", 'asd')";

                SqlConnection con =
                    new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);

                SqlCommand command = new SqlCommand(query1, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                string response = "Inserted";

                Response.Write(response);
            }
        }
    }
}