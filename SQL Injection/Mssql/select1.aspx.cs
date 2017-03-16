using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace Mssql
{
    public partial class select1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null)
            {
                string id = Request.Params["id"].ToString();

                string query1 = "SELECT article FROM articles WHERE userid=" + id;

                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);

                SqlCommand command = new SqlCommand(query1, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                string response = "";
                try
                {
                    while (reader.Read())
                    {
                        response += String.Format("{0}\r\n", reader["article"]);
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