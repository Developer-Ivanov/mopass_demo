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
    public partial class select2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                string id = Request.Params["id"].ToString();

                string query2 = "SELECT profile FROM profiles WHERE userid='" + id + "'";

                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);

                SqlCommand command = new SqlCommand(query2, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                string response = "";
                try
                {
                    while (reader.Read())
                    {
                        response += String.Format("{0}\r\n", reader["profile"]);
                    }
                    Response.Write(response);
                }
                catch
                {

                }
            }
        }
    }
}