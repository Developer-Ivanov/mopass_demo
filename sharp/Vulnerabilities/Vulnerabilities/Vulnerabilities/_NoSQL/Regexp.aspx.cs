using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Vulnerabilities.Vulnerabilities.NoSQL
{
    public partial class Regexp : System.Web.UI.Page
    {
        private bool isAuthorized = false;
        private string connectionString = "mongodb://localhost";

        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("users");
            var collection = database.GetCollection("users");
            var query = Query.And(
                Query.Matches("login", new BsonRegularExpression(new Regex(string.Format("^{0}$", Request.Params["username"])))), 
                Query.Matches("password", new BsonRegularExpression(new Regex(string.Format("^{0}$", Request.Params["password"]))))
                );
            var result = collection.FindOne(query);
            if (result != null)
            {
                isAuthorized = true;
                Response.Write("User " + Request.Params["username"] + " authorized");
            }
            else
            {
                Response.Write("Not authorized");
            }
        }
    }
}